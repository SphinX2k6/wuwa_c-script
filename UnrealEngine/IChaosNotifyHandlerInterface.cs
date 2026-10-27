using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200044F RID: 1103
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface")]
	public interface IChaosNotifyHandlerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06003B79 RID: 15225
		int InterfaceOffset();

		// Token: 0x04001B60 RID: 7008
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosNotifyHandlerInterface";
	}
}
