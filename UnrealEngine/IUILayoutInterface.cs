using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002184 RID: 8580
	[UnrealObjectPath("/Script/LGUI.UILayoutInterface")]
	public interface IUILayoutInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060207D9 RID: 133081
		int InterfaceOffset();

		// Token: 0x0401168B RID: 71307
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UILayoutInterface";
	}
}
