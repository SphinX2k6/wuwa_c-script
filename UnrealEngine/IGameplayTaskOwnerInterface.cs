using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020013F1 RID: 5105
	[UnrealObjectPath("/Script/GameplayTasks.GameplayTaskOwnerInterface")]
	public interface IGameplayTaskOwnerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06012A5C RID: 76380
		int InterfaceOffset();

		// Token: 0x04009F6F RID: 40815
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayTasks.GameplayTaskOwnerInterface";
	}
}
