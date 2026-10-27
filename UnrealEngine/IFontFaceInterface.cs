using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002817 RID: 10263
	[UnrealObjectPath("/Script/SlateCore.FontFaceInterface")]
	public interface IFontFaceInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602627A RID: 156282
		int InterfaceOffset();

		// Token: 0x04014E29 RID: 85545
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SlateCore.FontFaceInterface";
	}
}
