using UnityEngine;

namespace Assets.Scripts.Logic.Selection
{
	public class Selection : MonoBehaviour, ISelectable
	{
		[SerializeField] private SelectionConfig selectionConfigSO = default;
		[SerializeField] private Renderer objRenderer = default;
		private string propertyKeyword = "_EMISSION";
		private int emissionID = default;
		protected bool isSelected = default;
		private void Awake()
		{
			emissionID = Shader.PropertyToID("_EmissionColor");
		}
		public virtual void Select()
		{
			if (!isSelected)
			{
				objRenderer.material.EnableKeyword(propertyKeyword);
				objRenderer.material.SetColor(emissionID, selectionConfigSO.EmissionColor);
				isSelected = true;
			}
		}

		public virtual void Exclude()
		{
			if (isSelected)
			{
				objRenderer.material.DisableKeyword(propertyKeyword);
				isSelected = false;
			}
		}
	}
}
