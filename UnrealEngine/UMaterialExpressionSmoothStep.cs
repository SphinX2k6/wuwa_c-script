using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E4A RID: 3658
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionSmoothStep")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMaterialExpressionSmoothStep : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C43E RID: 50238 RVA: 0x0011BB56 File Offset: 0x00119D56
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionSmoothStep._ClassPtr;
		}

		// Token: 0x0600C43F RID: 50239 RVA: 0x0011BB64 File Offset: 0x00119D64
		public UMaterialExpressionSmoothStep() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSmoothStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C440 RID: 50240 RVA: 0x0011BB8C File Offset: 0x00119D8C
		public UMaterialExpressionSmoothStep(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionSmoothStep.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600C441 RID: 50241 RVA: 0x0011BBC0 File Offset: 0x00119DC0
		// (set) Token: 0x0600C442 RID: 50242 RVA: 0x0011BBF9 File Offset: 0x00119DF9
		public FExpressionInput Min
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Min) == null)
				{
					result = (this._Min = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Min, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Min, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600C443 RID: 50243 RVA: 0x0011BC1C File Offset: 0x00119E1C
		// (set) Token: 0x0600C444 RID: 50244 RVA: 0x0011BC55 File Offset: 0x00119E55
		public FExpressionInput Max
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Max) == null)
				{
					result = (this._Max = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Max, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Max, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600C445 RID: 50245 RVA: 0x0011BC78 File Offset: 0x00119E78
		// (set) Token: 0x0600C446 RID: 50246 RVA: 0x0011BCB1 File Offset: 0x00119EB1
		public FExpressionInput Value
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Value) == null)
				{
					result = (this._Value = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Value, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_Value, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600C447 RID: 50247 RVA: 0x0011BCD2 File Offset: 0x00119ED2
		// (set) Token: 0x0600C448 RID: 50248 RVA: 0x0011BCE2 File Offset: 0x00119EE2
		public unsafe float ConstMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstMin) = value;
			}
		}

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600C449 RID: 50249 RVA: 0x0011BCF3 File Offset: 0x00119EF3
		// (set) Token: 0x0600C44A RID: 50250 RVA: 0x0011BD03 File Offset: 0x00119F03
		public unsafe float ConstMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstMax) = value;
			}
		}

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600C44B RID: 50251 RVA: 0x0011BD14 File Offset: 0x00119F14
		// (set) Token: 0x0600C44C RID: 50252 RVA: 0x0011BD24 File Offset: 0x00119F24
		public unsafe float ConstValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionSmoothStep.__PropertyOffset_ConstValue) = value;
			}
		}

		// Token: 0x0600C44D RID: 50253 RVA: 0x0011BD35 File Offset: 0x00119F35
		static UMaterialExpressionSmoothStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionSmoothStep");
		}

		// Token: 0x0600C44E RID: 50254 RVA: 0x0011BD43 File Offset: 0x00119F43
		protected UMaterialExpressionSmoothStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040068C4 RID: 26820
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionSmoothStep";

		// Token: 0x040068C5 RID: 26821
		private static IntPtr _ClassPtr;

		// Token: 0x040068C6 RID: 26822
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040068C7 RID: 26823
		internal static int __PropertyOffset_Min;

		// Token: 0x040068C8 RID: 26824
		[Nullable(2)]
		private FExpressionInput _Min;

		// Token: 0x040068C9 RID: 26825
		internal static int __PropertyOffset_Max;

		// Token: 0x040068CA RID: 26826
		[Nullable(2)]
		private FExpressionInput _Max;

		// Token: 0x040068CB RID: 26827
		internal static int __PropertyOffset_Value;

		// Token: 0x040068CC RID: 26828
		[Nullable(2)]
		private FExpressionInput _Value;

		// Token: 0x040068CD RID: 26829
		internal static int __PropertyOffset_ConstMin;

		// Token: 0x040068CE RID: 26830
		internal static int __PropertyOffset_ConstMax;

		// Token: 0x040068CF RID: 26831
		internal static int __PropertyOffset_ConstValue;
	}
}
