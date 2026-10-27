using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200249D RID: 9373
	[UnrealObjectPath("/Script/NavigationSystem.NavLinkHostInterface")]
	public interface INavLinkHostInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06023180 RID: 143744
		int InterfaceOffset();

		// Token: 0x04012BC0 RID: 76736
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavLinkHostInterface";
	}
}
