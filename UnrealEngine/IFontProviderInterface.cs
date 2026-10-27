using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002819 RID: 10265
	[UnrealObjectPath("/Script/SlateCore.FontProviderInterface")]
	public interface IFontProviderInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602628D RID: 156301
		int InterfaceOffset();

		// Token: 0x04014E31 RID: 85553
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.FontProviderInterface";
	}
}
