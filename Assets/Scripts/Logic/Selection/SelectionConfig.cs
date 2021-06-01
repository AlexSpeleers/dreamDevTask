using UnityEngine;

namespace Assets.Scripts.Logic.Selection
{
	[CreateAssetMenu(fileName = "Selection Config", menuName = "SO/Selection config")]
	public class SelectionConfig : ScriptableObject
	{
		[SerializeField] private Color emissionColor = default;
		[SerializeField] private string selectionLayer = default;
		public Color EmissionColor => emissionColor;
		public string SelectionLayer => selectionLayer;
	}
}
