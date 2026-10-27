using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002251 RID: 8785
	[UnrealObjectPath("/Script/LTween.LTweenerVirtual")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class ULTweenerVirtual : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021675 RID: 136821 RVA: 0x0031391A File Offset: 0x00311B1A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerVirtual._ClassPtr;
		}

		// Token: 0x06021676 RID: 136822 RVA: 0x00313928 File Offset: 0x00311B28
		public ULTweenerVirtual() : this(BuiltinUtils.AllocNativeUObject(ULTweenerVirtual.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021677 RID: 136823 RVA: 0x00313950 File Offset: 0x00311B50
		[NullableContext(1)]
		public ULTweenerVirtual(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerVirtual.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021678 RID: 136824 RVA: 0x00313983 File Offset: 0x00311B83
		static ULTweenerVirtual()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerVirtual");
		}

		// Token: 0x06021679 RID: 136825 RVA: 0x00313991 File Offset: 0x00311B91
		protected ULTweenerVirtual(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CD8 RID: 72920
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerVirtual";

		// Token: 0x04011CD9 RID: 72921
		private static IntPtr _ClassPtr;

		// Token: 0x04011CDA RID: 72922
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
