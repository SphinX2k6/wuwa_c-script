using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020024A5 RID: 9381
	[UnrealObjectPath("/Script/NavigationSystem.NavNodeInterface")]
	public interface INavNodeInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060231BD RID: 143805
		int InterfaceOffset();

		// Token: 0x04012BE2 RID: 76770
		[Nullable(1)]
		public const string __ObjectPath = "/Script/NavigationSystem.NavNodeInterface";
	}
}
