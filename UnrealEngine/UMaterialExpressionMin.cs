using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DF9 RID: 3577
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionMin")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMaterialExpressionMin : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C17D RID: 49533 RVA: 0x00116B93 File Offset: 0x00114D93
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionMin._ClassPtr;
		}

		// Token: 0x0600C17E RID: 49534 RVA: 0x00116BA0 File Offset: 0x00114DA0
		public UMaterialExpressionMin() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMin.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C17F RID: 49535 RVA: 0x00116BC8 File Offset: 0x00114DC8
		public UMaterialExpressionMin(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionMin.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002CF2 RID: 11506
		// (get) Token: 0x0600C180 RID: 49536 RVA: 0x00116BFC File Offset: 0x00114DFC
		// (set) Token: 0x0600C181 RID: 49537 RVA: 0x00116C35 File Offset: 0x00114E35
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF3 RID: 11507
		// (get) Token: 0x0600C182 RID: 49538 RVA: 0x00116C58 File Offset: 0x00114E58
		// (set) Token: 0x0600C183 RID: 49539 RVA: 0x00116C91 File Offset: 0x00114E91
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002CF4 RID: 11508
		// (get) Token: 0x0600C184 RID: 49540 RVA: 0x00116CB2 File Offset: 0x00114EB2
		// (set) Token: 0x0600C185 RID: 49541 RVA: 0x00116CC2 File Offset: 0x00114EC2
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002CF5 RID: 11509
		// (get) Token: 0x0600C186 RID: 49542 RVA: 0x00116CD3 File Offset: 0x00114ED3
		// (set) Token: 0x0600C187 RID: 49543 RVA: 0x00116CE3 File Offset: 0x00114EE3
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionMin.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x0600C188 RID: 49544 RVA: 0x00116CF4 File Offset: 0x00114EF4
		static UMaterialExpressionMin()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionMin");
		}

		// Token: 0x0600C189 RID: 49545 RVA: 0x00116D02 File Offset: 0x00114F02
		protected UMaterialExpressionMin(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040066E2 RID: 26338
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionMin";

		// Token: 0x040066E3 RID: 26339
		private static IntPtr _ClassPtr;

		// Token: 0x040066E4 RID: 26340
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040066E5 RID: 26341
		internal static int __PropertyOffset_A;

		// Token: 0x040066E6 RID: 26342
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040066E7 RID: 26343
		internal static int __PropertyOffset_B;

		// Token: 0x040066E8 RID: 26344
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040066E9 RID: 26345
		internal static int __PropertyOffset_ConstA;

		// Token: 0x040066EA RID: 26346
		internal static int __PropertyOffset_ConstB;
	}
}
