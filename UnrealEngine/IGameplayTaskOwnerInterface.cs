using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002CA RID: 714
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTaskOwnerInterface")]
	public interface IGameplayTaskOwnerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06004DDC RID: 19932
		int InterfaceOffset();

		// Token: 0x04001F14 RID: 7956
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTaskOwnerInterface";
	}
}
