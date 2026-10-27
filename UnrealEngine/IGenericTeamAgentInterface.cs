using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001C7 RID: 455
	[UnrealObjectPath("/Script/AIModule.GenericTeamAgentInterface")]
	public interface IGenericTeamAgentInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06001B0C RID: 6924
		int InterfaceOffset();

		// Token: 0x040008A5 RID: 2213
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.GenericTeamAgentInterface";
	}
}
