using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Utils
{
	// Token: 0x020008A1 RID: 2209
	public static class GCEvent
	{
		// Token: 0x0600BE33 RID: 48691 RVA: 0x0012FBD9 File Offset: 0x0012DDD9
		[Obfuscation]
		internal static void TriggerPreGarbageCollectDelegate(bool IsLowMemory)
		{
			Action<bool> onEnginePreGarbageCollectDelegate = GCEvent.OnEnginePreGarbageCollectDelegate;
			if (onEnginePreGarbageCollectDelegate == null)
			{
				return;
			}
			onEnginePreGarbageCollectDelegate(IsLowMemory);
		}

		// Token: 0x040056B9 RID: 22201
		[Nullable(2)]
		public static Action<bool> OnEnginePreGarbageCollectDelegate;
	}
}
