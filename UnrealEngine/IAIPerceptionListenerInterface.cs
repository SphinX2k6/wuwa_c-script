using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F3 RID: 243
	[UnrealObjectPath("/Script/AIModule.AIPerceptionListenerInterface")]
	public interface IAIPerceptionListenerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06001315 RID: 4885
		int InterfaceOffset();

		// Token: 0x04000367 RID: 871
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIPerceptionListenerInterface";
	}
}
