using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ECD RID: 3789
	[UnrealObjectPath("/Script/Engine.NavAgentInterface")]
	public interface INavAgentInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CD0E RID: 52494
		int InterfaceOffset();

		// Token: 0x04006E55 RID: 28245
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavAgentInterface";
	}
}
