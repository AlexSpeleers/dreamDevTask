using UnityEngine;

namespace Assets.Scripts.Logic.Selection
{
	public class AnimationSelection : Selection
	{
		[SerializeField] private Animator propAnimator = default;
		private int selectionTrigger = Animator.StringToHash("Select");
		public override void Select()
		{
			if (!isSelected)
			{
				isSelected = true;
				//run selection animation
			}
		}
		public override void Exclude()
		{
			if(isSelected)
			{
				isSelected = false;
				//run default animation if needed
			}
		}
	}
}
