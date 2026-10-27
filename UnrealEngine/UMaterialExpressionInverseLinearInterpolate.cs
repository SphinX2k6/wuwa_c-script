using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DD7 RID: 3543
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionInverseLinearInterpolate")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionInverseLinearInterpolate : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C007 RID: 49159 RVA: 0x00113BE9 File Offset: 0x00111DE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionInverseLinearInterpolate._ClassPtr;
		}

		// Token: 0x0600C008 RID: 49160 RVA: 0x00113BF8 File Offset: 0x00111DF8
		public UMaterialExpressionInverseLinearInterpolate() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionInverseLinearInterpolate.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C009 RID: 49161 RVA: 0x00113C20 File Offset: 0x00111E20
		public UMaterialExpressionInverseLinearInterpolate(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionInverseLinearInterpolate.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002C8C RID: 11404
		// (get) Token: 0x0600C00A RID: 49162 RVA: 0x00113C54 File Offset: 0x00111E54
		// (set) Token: 0x0600C00B RID: 49163 RVA: 0x00113C8D File Offset: 0x00111E8D
		public FExpressionInput A
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._A) == null)
				{
					result = (this._A = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_A, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_A, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x0600C00C RID: 49164 RVA: 0x00113CB0 File Offset: 0x00111EB0
		// (set) Token: 0x0600C00D RID: 49165 RVA: 0x00113CE9 File Offset: 0x00111EE9
		public FExpressionInput B
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._B) == null)
				{
					result = (this._B = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_B, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_B, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x0600C00E RID: 49166 RVA: 0x00113D0C File Offset: 0x00111F0C
		// (set) Token: 0x0600C00F RID: 49167 RVA: 0x00113D45 File Offset: 0x00111F45
		public FExpressionInput Value
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_Value, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x0600C010 RID: 49168 RVA: 0x00113D66 File Offset: 0x00111F66
		// (set) Token: 0x0600C011 RID: 49169 RVA: 0x00113D76 File Offset: 0x00111F76
		public unsafe float ConstA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstA) = value;
			}
		}

		// Token: 0x17002C90 RID: 11408
		// (get) Token: 0x0600C012 RID: 49170 RVA: 0x00113D87 File Offset: 0x00111F87
		// (set) Token: 0x0600C013 RID: 49171 RVA: 0x00113D97 File Offset: 0x00111F97
		public unsafe float ConstB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstB) = value;
			}
		}

		// Token: 0x17002C91 RID: 11409
		// (get) Token: 0x0600C014 RID: 49172 RVA: 0x00113DA8 File Offset: 0x00111FA8
		// (set) Token: 0x0600C015 RID: 49173 RVA: 0x00113DB8 File Offset: 0x00111FB8
		public unsafe float ConstValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_ConstValue) = value;
			}
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x0600C016 RID: 49174 RVA: 0x00113DC9 File Offset: 0x00111FC9
		// (set) Token: 0x0600C017 RID: 49175 RVA: 0x00113DD9 File Offset: 0x00111FD9
		public unsafe bool bClampResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_bClampResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionInverseLinearInterpolate.__PropertyOffset_bClampResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600C018 RID: 49176 RVA: 0x00113DEA File Offset: 0x00111FEA
		static UMaterialExpressionInverseLinearInterpolate()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionInverseLinearInterpolate");
		}

		// Token: 0x0600C019 RID: 49177 RVA: 0x00113DF8 File Offset: 0x00111FF8
		protected UMaterialExpressionInverseLinearInterpolate(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040065CA RID: 26058
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionInverseLinearInterpolate";

		// Token: 0x040065CB RID: 26059
		private static IntPtr _ClassPtr;

		// Token: 0x040065CC RID: 26060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040065CD RID: 26061
		internal static int __PropertyOffset_A;

		// Token: 0x040065CE RID: 26062
		[Nullable(2)]
		private FExpressionInput _A;

		// Token: 0x040065CF RID: 26063
		internal static int __PropertyOffset_B;

		// Token: 0x040065D0 RID: 26064
		[Nullable(2)]
		private FExpressionInput _B;

		// Token: 0x040065D1 RID: 26065
		internal static int __PropertyOffset_Value;

		// Token: 0x040065D2 RID: 26066
		[Nullable(2)]
		private FExpressionInput _Value;

		// Token: 0x040065D3 RID: 26067
		internal static int __PropertyOffset_ConstA;

		// Token: 0x040065D4 RID: 26068
		internal static int __PropertyOffset_ConstB;

		// Token: 0x040065D5 RID: 26069
		internal static int __PropertyOffset_ConstValue;

		// Token: 0x040065D6 RID: 26070
		internal static int __PropertyOffset_bClampResult;
	}
}
