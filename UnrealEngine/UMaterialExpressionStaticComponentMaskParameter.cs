using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E57 RID: 3671
	[UnrealObjectPath("/Script/Engine.MaterialExpressionStaticComponentMaskParameter")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public class UMaterialExpressionStaticComponentMaskParameter : UMaterialExpressionParameter, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4D0 RID: 50384 RVA: 0x0011CC02 File Offset: 0x0011AE02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionStaticComponentMaskParameter._ClassPtr;
		}

		// Token: 0x0600C4D1 RID: 50385 RVA: 0x0011CC10 File Offset: 0x0011AE10
		public UMaterialExpressionStaticComponentMaskParameter() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticComponentMaskParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4D2 RID: 50386 RVA: 0x0011CC38 File Offset: 0x0011AE38
		[NullableContext(1)]
		public UMaterialExpressionStaticComponentMaskParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionStaticComponentMaskParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DB2 RID: 11698
		// (get) Token: 0x0600C4D3 RID: 50387 RVA: 0x0011CC6B File Offset: 0x0011AE6B
		// (set) Token: 0x0600C4D4 RID: 50388 RVA: 0x0011CC84 File Offset: 0x0011AE84
		public unsafe bool DefaultR
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultR) & UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultR) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultR) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultR) & ~UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultR) | (value ? UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultR : 0));
			}
		}

		// Token: 0x17002DB3 RID: 11699
		// (get) Token: 0x0600C4D5 RID: 50389 RVA: 0x0011CCB4 File Offset: 0x0011AEB4
		// (set) Token: 0x0600C4D6 RID: 50390 RVA: 0x0011CCCD File Offset: 0x0011AECD
		public unsafe bool DefaultG
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultG) & UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultG) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultG) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultG) & ~UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultG) | (value ? UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultG : 0));
			}
		}

		// Token: 0x17002DB4 RID: 11700
		// (get) Token: 0x0600C4D7 RID: 50391 RVA: 0x0011CCFD File Offset: 0x0011AEFD
		// (set) Token: 0x0600C4D8 RID: 50392 RVA: 0x0011CD16 File Offset: 0x0011AF16
		public unsafe bool DefaultB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultB) & UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultB) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultB) & ~UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultB) | (value ? UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultB : 0));
			}
		}

		// Token: 0x17002DB5 RID: 11701
		// (get) Token: 0x0600C4D9 RID: 50393 RVA: 0x0011CD46 File Offset: 0x0011AF46
		// (set) Token: 0x0600C4DA RID: 50394 RVA: 0x0011CD5F File Offset: 0x0011AF5F
		public unsafe bool DefaultA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultA) & UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultA) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionStaticComponentMaskParameter.__PropertyOffset_DefaultA) & ~UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultA) | (value ? UMaterialExpressionStaticComponentMaskParameter.__PropertyMask_DefaultA : 0));
			}
		}

		// Token: 0x0600C4DB RID: 50395 RVA: 0x0011CD8F File Offset: 0x0011AF8F
		static UMaterialExpressionStaticComponentMaskParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionStaticComponentMaskParameter");
		}

		// Token: 0x0600C4DC RID: 50396 RVA: 0x0011CD9D File Offset: 0x0011AF9D
		protected UMaterialExpressionStaticComponentMaskParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400692A RID: 26922
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionStaticComponentMaskParameter";

		// Token: 0x0400692B RID: 26923
		private static IntPtr _ClassPtr;

		// Token: 0x0400692C RID: 26924
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400692D RID: 26925
		internal static int __PropertyOffset_DefaultR;

		// Token: 0x0400692E RID: 26926
		internal static byte __PropertyMask_DefaultR;

		// Token: 0x0400692F RID: 26927
		internal static int __PropertyOffset_DefaultG;

		// Token: 0x04006930 RID: 26928
		internal static byte __PropertyMask_DefaultG;

		// Token: 0x04006931 RID: 26929
		internal static int __PropertyOffset_DefaultB;

		// Token: 0x04006932 RID: 26930
		internal static byte __PropertyMask_DefaultB;

		// Token: 0x04006933 RID: 26931
		internal static int __PropertyOffset_DefaultA;

		// Token: 0x04006934 RID: 26932
		internal static byte __PropertyMask_DefaultA;
	}
}
