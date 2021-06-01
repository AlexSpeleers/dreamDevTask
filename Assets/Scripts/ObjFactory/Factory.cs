using UnityEngine;

namespace Assets.Scripts.ObjFactory
{
	public class Factory : IFactory
	{
		
		public T CreateObj<T>(T obj, string path) where T : MonoBehaviour
		{
			var prefab = Resources.Load<T>(path);
			return Object.Instantiate(prefab);
		}
	}
}
