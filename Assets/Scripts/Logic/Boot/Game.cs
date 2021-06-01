using Assets.Scripts.AllServices;
using Assets.Scripts.ObjFactory;
using UnityTemplateProjects;

namespace Assets.Scripts.Logic.Boot
{
	public class Game
	{
		public Services allServices = default;
		public IFactory factory = default;
		private SimpleCameraController simpleCameraController = default;
		private SelectionManager selectionManager = default;
		public Game(Services services)
		{
			allServices = services;
			allServices.RegisterSingle<IFactory>(new Factory());
			factory = allServices.Single<IFactory>();
			PrepareScene();
		}
		private void PrepareScene() 
		{
			simpleCameraController = factory.CreateObj(simpleCameraController, AssetPath.CameraControllerPath);
			selectionManager = factory.CreateObj(selectionManager, AssetPath.WorkRoomPath).Construct(simpleCameraController.MyCamera);
			
		}
	}
}
