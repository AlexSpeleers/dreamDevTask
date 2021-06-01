
namespace Assets.Scripts.AllServices
{
	public class Services
	{
		private static Services instance;
		public static Services Container => instance ?? (instance = new Services());
		public void RegisterSingle<TService>(TService implementation) where TService : IService => Implementation<TService>.ServiceInstance = implementation;

		public TService Single<TService>() where TService : IService => Implementation<TService>.ServiceInstance;
		private static class Implementation<TService> where TService : IService
		{
			public static TService ServiceInstance;
		}
	}
}
