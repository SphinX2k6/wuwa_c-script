using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000177 RID: 375
	[UnrealObjectPath("/Script/Engine.AnimCompositeBase")]
	[UnrealStructLayout(440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 440)]
	public abstract class UAnimCompositeBase : UAnimSequenceBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060016D0 RID: 5840 RVA: 0x00023925 File Offset: 0x00021B25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimCompositeBase._ClassPtr;
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00023931 File Offset: 0x00021B31
		static UAnimCompositeBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AnimCompositeBase");
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00023940 File Offset: 0x00021B40
		protected UAnimCompositeBase() : this(BuiltinUtils.AllocNativeUObject(UAnimCompositeBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x00023968 File Offset: 0x00021B68
		protected UAnimCompositeBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000747 RID: 1863
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimCompositeBase";

		// Token: 0x04000748 RID: 1864
		private static IntPtr _ClassPtr;

		// Token: 0x04000749 RID: 1865
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
