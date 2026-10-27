using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FCE RID: 4046
	[UnrealObjectPath("/Script/Engine.PathFollowingAgentInterface")]
	public interface IPathFollowingAgentInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600DA4B RID: 55883
		int InterfaceOffset();

		// Token: 0x04007655 RID: 30293
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PathFollowingAgentInterface";
	}
}
