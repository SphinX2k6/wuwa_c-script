using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E5B RID: 3675
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSubtract")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionSubtract : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C4FC RID: 50428 RVA: 0x0011D17B File Offset: 0x0011B37B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSubtract._ClassPtr;
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x0011D188 File Offset: 0x0011B388
		public UMaterialExpressionSubtract() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSubtract.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x0011D1B0 File Offset: 0x0011B3B0
		public UMaterialExpressionSubtract(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSubtract.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002DBE RID: 11710
		// (get) Token: 0x0600C4FF RID: 50431 RVA: 0x0011D1E4 File Offset: 0x0011B3E4
		// (set) Token: 0x0600C500 RID: 50432 RVA: 0x0011D21D File Offset: 0x0011B41D
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DBF RID: 11711
		// (get) Token: 0x0600C501 RID: 50433 RVA: 0x0011D240 File Offset: 0x0011B440
		// (set) Token: 0x0600C502 RID: 50434 RVA: 0x0011D279 File Offset: 0x0011B479
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002DC0 RID: 11712
		// (get) Token: 0x0600C503 RID: 50435 RVA: 0x0011D29A File Offset: 0x0011B49A
		// (set) Token: 0x0600C504 RID: 50436 RVA: 0x0011D2AA File Offset: 0x0011B4AA
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002DC1 RID: 11713
		// (get) Token: 0x0600C505 RID: 50437 RVA: 0x0011D2BB File Offset: 0x0011B4BB
		// (set) Token: 0x0600C506 RID: 50438 RVA: 0x0011D2CB File Offset: 0x0011B4CB
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSubtract.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600C507 RID: 50439 RVA: 0x0011D2DC File Offset: 0x0011B4DC
		static UMaterialExpressionSubtract()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSubtract");
		}

		// Token: 0x0600C508 RID: 50440 RVA: 0x0011D2EA File Offset: 0x0011B4EA
		protected UMaterialExpressionSubtract(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400694C RID: 26956
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSubtract";

		// Token: 0x0400694D RID: 26957
		private static IntPtr _ClassPtr;

		// Token: 0x0400694E RID: 26958
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400694F RID: 26959
		internal static int __PropertyOffset_A;

		// Token: 0x04006950 RID: 26960
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x04006951 RID: 26961
		internal static int __PropertyOffset_B;

		// Token: 0x04006952 RID: 26962
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x04006953 RID: 26963
		internal static int __PropertyOffset_ConstA;

		// Token: 0x04006954 RID: 26964
		internal static int __PropertyOffset_ConstB;
	}
}
