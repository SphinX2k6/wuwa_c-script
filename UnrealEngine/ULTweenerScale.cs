using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200224D RID: 8781
	[UnrealObjectPath("/Script/LTween.LTweenerScale")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class ULTweenerScale : ULTweener, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021661 RID: 136801 RVA: 0x0031371A File Offset: 0x0031191A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULTweenerScale._ClassPtr;
		}

		// Token: 0x06021662 RID: 136802 RVA: 0x00313728 File Offset: 0x00311928
		public ULTweenerScale() : this(BuiltinUtils.AllocNativeUObject(ULTweenerScale.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021663 RID: 136803 RVA: 0x00313750 File Offset: 0x00311950
		[NullableContext(1)]
		public ULTweenerScale(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULTweenerScale.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021664 RID: 136804 RVA: 0x00313783 File Offset: 0x00311983
		static ULTweenerScale()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LTween.LTweenerScale");
		}

		// Token: 0x06021665 RID: 136805 RVA: 0x00313791 File Offset: 0x00311991
		protected ULTweenerScale(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011CCC RID: 72908
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LTween.LTweenerScale";

		// Token: 0x04011CCD RID: 72909
		private static IntPtr _ClassPtr;

		// Token: 0x04011CCE RID: 72910
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
