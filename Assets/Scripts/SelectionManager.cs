using Assets.Scripts.Logic.Selection;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
	[SerializeField] private SelectionConfig selectionConfigSO = default;
	[SerializeField] private List<Selection> selectableObjects = default;
	private Camera myCamera = default;
	private Selection previousSelection = default;
	private Selection currentSelection = default;
	private int selectionLayerIndex = default;
	private int selectionMask = default;
	private void Update()
	{
		SelectItem();
	}
	public SelectionManager Construct(Camera camera)
	{
		myCamera = camera;
		SetLayer();
		return this;
	}
	private void SetLayer()
	{
		selectionLayerIndex = LayerMask.NameToLayer(selectionConfigSO.SelectionLayer);
		if (selectionLayerIndex == -1)
		{
			Debug.LogError("Layer Does not exist");
			return;
		}
		selectionMask = (1 << selectionLayerIndex);
	}
	private void SelectItem()
	{
		if (Physics.Raycast(myCamera.ScreenPointToRay(Input.mousePosition), out var hit, 2000, selectionMask))
		{
			currentSelection = selectableObjects.Find(x => x.gameObject == hit.transform.gameObject);
			if (previousSelection != currentSelection)
			{
				previousSelection?.Exclude();
			}
			previousSelection = currentSelection;
			currentSelection?.Select();
		}
		else
		{
			previousSelection?.Exclude();
			return;
		}
	}
}
