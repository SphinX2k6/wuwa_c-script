using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200184D RID: 6221
	[UnrealObjectPath("/Script/KuroFauxPhysics.KuroPrimitiveVisualizedInterface")]
	public interface IKuroPrimitiveVisualizedInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06016EE0 RID: 93920
		int InterfaceOffset();

		// Token: 0x0400C751 RID: 51025
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroFauxPhysics.KuroPrimitiveVisualizedInterface";
	}
}
