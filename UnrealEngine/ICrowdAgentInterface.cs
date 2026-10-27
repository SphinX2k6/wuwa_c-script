using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000166 RID: 358
	[UnrealObjectPath("/Script/AIModule.CrowdAgentInterface")]
	public interface ICrowdAgentInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600183E RID: 6206
		int InterfaceOffset();

		// Token: 0x0400060E RID: 1550
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.CrowdAgentInterface";
	}
}
