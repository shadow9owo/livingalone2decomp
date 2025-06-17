using UnityEngine;

namespace TapjoyUnity.Internal
{
	public sealed class TapjoyUnityInit : MonoBehaviour
	{
		private static bool initialized;

		private void Awake()
		{
			if (!initialized)
			{
				initialized = true;
				ApiBindingAndroid.Install();
			}
		}
	}
}
