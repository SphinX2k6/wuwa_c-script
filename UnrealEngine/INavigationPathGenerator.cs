using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002494 RID: 9364
	[UnrealObjectPath("/Script/NavigationSystem.NavigationPathGenerator")]
	public interface INavigationPathGenerator : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602304D RID: 143437
		int InterfaceOffset();

		// Token: 0x04012B25 RID: 76581
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavigationPathGenerator";
	}
}
