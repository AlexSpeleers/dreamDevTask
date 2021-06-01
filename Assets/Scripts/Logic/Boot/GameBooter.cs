using Assets.Scripts.AllServices;
using UnityEngine;

namespace Assets.Scripts.Logic.Boot
{
	public class GameBooter : MonoBehaviour
	{
		public Game game { get; private set; }
		private void Awake()
		{
			game = new Game(services: Services.Container);
		}
	}
}
