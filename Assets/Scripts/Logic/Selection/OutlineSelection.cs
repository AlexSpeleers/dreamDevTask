using UnityEngine;

namespace Assets.Scripts.Logic.Selection
{
	public class OutlineSelection : Selection
	{
		[SerializeField] private Renderer propRendere = default;
		[SerializeField] private Shader outlineShader = default;
		public override void Select()
		{
			if (!isSelected)
			{
				isSelected = true;
				//turn on some value
			}
		}
		public override void Exclude()
		{
			if (isSelected)
			{
				isSelected = false;
				//turn off
			}
		}
	}
}
