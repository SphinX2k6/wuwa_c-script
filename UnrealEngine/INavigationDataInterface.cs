using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000ED9 RID: 3801
	[UnrealObjectPath("/Script/Engine.NavigationDataInterface")]
	public interface INavigationDataInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600CDD8 RID: 52696
		int InterfaceOffset();

		// Token: 0x04006EE8 RID: 28392
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.NavigationDataInterface";
	}
}
