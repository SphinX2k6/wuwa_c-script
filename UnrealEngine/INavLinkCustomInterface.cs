using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200249C RID: 9372
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkCustomInterface")]
	public interface INavLinkCustomInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602317F RID: 143743
		int InterfaceOffset();

		// Token: 0x04012BBF RID: 76735
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavLinkCustomInterface";
	}
}
