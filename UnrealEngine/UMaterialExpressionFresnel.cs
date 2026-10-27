using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DCD RID: 3533
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionFresnel")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionFresnel : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BF7D RID: 49021 RVA: 0x00112AF1 File Offset: 0x00110CF1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionFresnel._ClassPtr;
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x00112B00 File Offset: 0x00110D00
		public UMaterialExpressionFresnel() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFresnel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BF7F RID: 49023 RVA: 0x00112B28 File Offset: 0x00110D28
		public UMaterialExpressionFresnel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionFresnel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x00112B5C File Offset: 0x00110D5C
		// (set) Token: 0x0600BF81 RID: 49025 RVA: 0x00112B95 File Offset: 0x00110D95
		public FExpressionInput ExponentIn
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._ExponentIn) == null)
				{
					result = (this._ExponentIn = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_ExponentIn, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_ExponentIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x00112BB6 File Offset: 0x00110DB6
		// (set) Token: 0x0600BF83 RID: 49027 RVA: 0x00112BC6 File Offset: 0x00110DC6
		public unsafe float Exponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_Exponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_Exponent) = value;
			}
		}

		// Token: 0x17002C62 RID: 11362
		// (get) Token: 0x0600BF84 RID: 49028 RVA: 0x00112BD8 File Offset: 0x00110DD8
		// (set) Token: 0x0600BF85 RID: 49029 RVA: 0x00112C11 File Offset: 0x00110E11
		public FExpressionInput BaseReflectFractionIn
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._BaseReflectFractionIn) == null)
				{
					result = (this._BaseReflectFractionIn = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_BaseReflectFractionIn, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_BaseReflectFractionIn, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C63 RID: 11363
		// (get) Token: 0x0600BF86 RID: 49030 RVA: 0x00112C32 File Offset: 0x00110E32
		// (set) Token: 0x0600BF87 RID: 49031 RVA: 0x00112C42 File Offset: 0x00110E42
		public unsafe float BaseReflectFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_BaseReflectFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_BaseReflectFraction) = value;
			}
		}

		// Token: 0x17002C64 RID: 11364
		// (get) Token: 0x0600BF88 RID: 49032 RVA: 0x00112C54 File Offset: 0x00110E54
		// (set) Token: 0x0600BF89 RID: 49033 RVA: 0x00112C8D File Offset: 0x00110E8D
		public FExpressionInput Normal
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Normal) == null)
				{
					result = (this._Normal = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_Normal, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionFresnel.__PropertyOffset_Normal, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600BF8A RID: 49034 RVA: 0x00112CAE File Offset: 0x00110EAE
		static UMaterialExpressionFresnel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionFresnel");
		}

		// Token: 0x0600BF8B RID: 49035 RVA: 0x00112CBC File Offset: 0x00110EBC
		protected UMaterialExpressionFresnel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006564 RID: 25956
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionFresnel";

		// Token: 0x04006565 RID: 25957
		private static IntPtr _ClassPtr;

		// Token: 0x04006566 RID: 25958
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04006567 RID: 25959
		internal static int __PropertyOffset_ExponentIn;

		// Token: 0x04006568 RID: 25960
		[Nullable(2)]
		private FExpressionInput _ExponentIn;

		// Token: 0x04006569 RID: 25961
		internal static int __PropertyOffset_Exponent;

		// Token: 0x0400656A RID: 25962
		internal static int __PropertyOffset_BaseReflectFractionIn;

		// Token: 0x0400656B RID: 25963
		[Nullable(2)]
		private FExpressionInput _BaseReflectFractionIn;

		// Token: 0x0400656C RID: 25964
		internal static int __PropertyOffset_BaseReflectFraction;

		// Token: 0x0400656D RID: 25965
		internal static int __PropertyOffset_Normal;

		// Token: 0x0400656E RID: 25966
		[Nullable(2)]
		private FExpressionInput _Normal;
	}
}
