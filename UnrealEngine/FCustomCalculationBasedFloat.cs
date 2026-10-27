using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200132D RID: 4909
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.CustomCalculationBasedFloat")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 152)]
	public class FCustomCalculationBasedFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012135 RID: 74037 RVA: 0x001A8C32 File Offset: 0x001A6E32
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCustomCalculationBasedFloat._ScriptStructPtr != 0) ? FCustomCalculationBasedFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.CustomCalculationBasedFloat", ref FCustomCalculationBasedFloat._ScriptStructPtr);
		}

		// Token: 0x1700466E RID: 18030
		// (get) Token: 0x06012136 RID: 74038 RVA: 0x001A8C56 File Offset: 0x001A6E56
		// (set) Token: 0x06012137 RID: 74039 RVA: 0x001A8C6A File Offset: 0x001A6E6A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UGameplayModMagnitudeCalculation> CalculationClassMagnitude
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_CalculationClassMagnitude);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_CalculationClassMagnitude) = value;
			}
		}

		// Token: 0x1700466F RID: 18031
		// (get) Token: 0x06012138 RID: 74040 RVA: 0x001A8C80 File Offset: 0x001A6E80
		// (set) Token: 0x06012139 RID: 74041 RVA: 0x001A8CC3 File Offset: 0x001A6EC3
		public FScalableFloat Coefficient
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._Coefficient) == null)
				{
					result = (this._Coefficient = new FScalableFloat(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_Coefficient, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_Coefficient, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004670 RID: 18032
		// (get) Token: 0x0601213A RID: 74042 RVA: 0x001A8CE4 File Offset: 0x001A6EE4
		// (set) Token: 0x0601213B RID: 74043 RVA: 0x001A8D27 File Offset: 0x001A6F27
		public FScalableFloat PreMultiplyAdditiveValue
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._PreMultiplyAdditiveValue) == null)
				{
					result = (this._PreMultiplyAdditiveValue = new FScalableFloat(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_PreMultiplyAdditiveValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_PreMultiplyAdditiveValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004671 RID: 18033
		// (get) Token: 0x0601213C RID: 74044 RVA: 0x001A8D48 File Offset: 0x001A6F48
		// (set) Token: 0x0601213D RID: 74045 RVA: 0x001A8D8B File Offset: 0x001A6F8B
		public FScalableFloat PostMultiplyAdditiveValue
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._PostMultiplyAdditiveValue) == null)
				{
					result = (this._PostMultiplyAdditiveValue = new FScalableFloat(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_PostMultiplyAdditiveValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_PostMultiplyAdditiveValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004672 RID: 18034
		// (get) Token: 0x0601213E RID: 74046 RVA: 0x001A8DAC File Offset: 0x001A6FAC
		// (set) Token: 0x0601213F RID: 74047 RVA: 0x001A8DEF File Offset: 0x001A6FEF
		public FCurveTableRowHandle FinalLookupCurve
		{
			get
			{
				base.FastCheckIsValid();
				FCurveTableRowHandle result;
				if ((result = this._FinalLookupCurve) == null)
				{
					result = (this._FinalLookupCurve = new FCurveTableRowHandle(base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_FinalLookupCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCurveTableRowHandle.StaticStruct(), base.NativePtr + (IntPtr)FCustomCalculationBasedFloat.__PropertyOffset_FinalLookupCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012140 RID: 74048 RVA: 0x001A8E10 File Offset: 0x001A7010
		public FCustomCalculationBasedFloat()
		{
		}

		// Token: 0x06012141 RID: 74049 RVA: 0x001A8E18 File Offset: 0x001A7018
		public FCustomCalculationBasedFloat([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UGameplayModMagnitudeCalculation> CalculationClassMagnitude, FScalableFloat Coefficient, FScalableFloat PreMultiplyAdditiveValue, FScalableFloat PostMultiplyAdditiveValue, FCurveTableRowHandle FinalLookupCurve)
		{
			this.CalculationClassMagnitude = CalculationClassMagnitude;
			this.Coefficient = Coefficient;
			this.PreMultiplyAdditiveValue = PreMultiplyAdditiveValue;
			this.PostMultiplyAdditiveValue = PostMultiplyAdditiveValue;
			this.FinalLookupCurve = FinalLookupCurve;
		}

		// Token: 0x06012142 RID: 74050 RVA: 0x001A8E45 File Offset: 0x001A7045
		protected override IntPtr GetUStructPtr()
		{
			return FCustomCalculationBasedFloat.StaticStruct();
		}

		// Token: 0x06012143 RID: 74051 RVA: 0x001A8E51 File Offset: 0x001A7051
		[NullableContext(2)]
		public FCustomCalculationBasedFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012144 RID: 74052 RVA: 0x001A8E5B File Offset: 0x001A705B
		public FCustomCalculationBasedFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012145 RID: 74053 RVA: 0x001A8E66 File Offset: 0x001A7066
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCustomCalculationBasedFloat(Pointer, false, true);
		}

		// Token: 0x06012146 RID: 74054 RVA: 0x001A8E70 File Offset: 0x001A7070
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCustomCalculationBasedFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04009A69 RID: 39529
		public const string __ObjectPath = "/Script/GameplayAbilities.CustomCalculationBasedFloat";

		// Token: 0x04009A6A RID: 39530
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A6B RID: 39531
		internal static int __PropertyOffset_CalculationClassMagnitude;

		// Token: 0x04009A6C RID: 39532
		internal static int __PropertyOffset_Coefficient;

		// Token: 0x04009A6D RID: 39533
		[Nullable(2)]
		private FScalableFloat _Coefficient;

		// Token: 0x04009A6E RID: 39534
		internal static int __PropertyOffset_PreMultiplyAdditiveValue;

		// Token: 0x04009A6F RID: 39535
		[Nullable(2)]
		private FScalableFloat _PreMultiplyAdditiveValue;

		// Token: 0x04009A70 RID: 39536
		internal static int __PropertyOffset_PostMultiplyAdditiveValue;

		// Token: 0x04009A71 RID: 39537
		[Nullable(2)]
		private FScalableFloat _PostMultiplyAdditiveValue;

		// Token: 0x04009A72 RID: 39538
		internal static int __PropertyOffset_FinalLookupCurve;

		// Token: 0x04009A73 RID: 39539
		[Nullable(2)]
		private FCurveTableRowHandle _FinalLookupCurve;
	}
}
