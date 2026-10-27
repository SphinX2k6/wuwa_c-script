using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020B0 RID: 8368
	[UnrealObjectPath("/Script/LGUI.LGUIPrefabCheckerInterface")]
	public interface ILGUIPrefabCheckerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0601F8A4 RID: 129188
		int InterfaceOffset();

		// Token: 0x0401106E RID: 69742
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.LGUIPrefabCheckerInterface";
	}
}
