using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000E9E RID: 3742
	[UnrealObjectPath("/Script/Engine.MatineeInterface")]
	public interface IMatineeInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600C9E2 RID: 51682
		int InterfaceOffset();

		// Token: 0x04006CAA RID: 27818
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.MatineeInterface";
	}
}
