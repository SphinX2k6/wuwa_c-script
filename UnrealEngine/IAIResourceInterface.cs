using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F8 RID: 248
	[UnrealObjectPath("/Script/AIModule.AIResourceInterface")]
	public interface IAIResourceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06001350 RID: 4944
		int InterfaceOffset();

		// Token: 0x0400037C RID: 892
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIResourceInterface";
	}
}
