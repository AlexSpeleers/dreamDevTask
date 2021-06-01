using Assets.Scripts.AllServices;
using UnityEngine;
namespace Assets.Scripts.ObjFactory
{
	public interface IFactory : IService
	{
		T CreateObj<T>(T obj, string path) where T : MonoBehaviour;
	}
}