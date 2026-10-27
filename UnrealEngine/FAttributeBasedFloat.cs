using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001328 RID: 4904
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AttributeBasedFloat")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FAttributeBasedFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060120EC RID: 73964 RVA: 0x001A84F2 File Offset: 0x001A66F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAttributeBasedFloat._ScriptStructPtr != 0) ? FAttributeBasedFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.AttributeBasedFloat", ref FAttributeBasedFloat._ScriptStructPtr);
		}

		// Token: 0x1700465C RID: 18012
		// (get) Token: 0x060120ED RID: 73965 RVA: 0x001A8518 File Offset: 0x001A6718
		// (set) Token: 0x060120EE RID: 73966 RVA: 0x001A855B File Offset: 0x001A675B
		public FScalableFloat Coefficient
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._Coefficient) == null)
				{
					result = (this._Coefficient = new FScalableFloat(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_Coefficient, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_Coefficient, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700465D RID: 18013
		// (get) Token: 0x060120EF RID: 73967 RVA: 0x001A857C File Offset: 0x001A677C
		// (set) Token: 0x060120F0 RID: 73968 RVA: 0x001A85BF File Offset: 0x001A67BF
		public FScalableFloat PreMultiplyAdditiveValue
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._PreMultiplyAdditiveValue) == null)
				{
					result = (this._PreMultiplyAdditiveValue = new FScalableFloat(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_PreMultiplyAdditiveValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_PreMultiplyAdditiveValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700465E RID: 18014
		// (get) Token: 0x060120F1 RID: 73969 RVA: 0x001A85E0 File Offset: 0x001A67E0
		// (set) Token: 0x060120F2 RID: 73970 RVA: 0x001A8623 File Offset: 0x001A6823
		public FScalableFloat PostMultiplyAdditiveValue
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._PostMultiplyAdditiveValue) == null)
				{
					result = (this._PostMultiplyAdditiveValue = new FScalableFloat(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_PostMultiplyAdditiveValue, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_PostMultiplyAdditiveValue, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700465F RID: 18015
		// (get) Token: 0x060120F3 RID: 73971 RVA: 0x001A8644 File Offset: 0x001A6844
		// (set) Token: 0x060120F4 RID: 73972 RVA: 0x001A8687 File Offset: 0x001A6887
		public FGameplayEffectAttributeCaptureDefinition BackingAttribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAttributeCaptureDefinition result;
				if ((result = this._BackingAttribute) == null)
				{
					result = (this._BackingAttribute = new FGameplayEffectAttributeCaptureDefinition(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_BackingAttribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectAttributeCaptureDefinition.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_BackingAttribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004660 RID: 18016
		// (get) Token: 0x060120F5 RID: 73973 RVA: 0x001A86A8 File Offset: 0x001A68A8
		// (set) Token: 0x060120F6 RID: 73974 RVA: 0x001A86EB File Offset: 0x001A68EB
		public FCurveTableRowHandle AttributeCurve
		{
			get
			{
				base.FastCheckIsValid();
				FCurveTableRowHandle result;
				if ((result = this._AttributeCurve) == null)
				{
					result = (this._AttributeCurve = new FCurveTableRowHandle(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_AttributeCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCurveTableRowHandle.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_AttributeCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004661 RID: 18017
		// (get) Token: 0x060120F7 RID: 73975 RVA: 0x001A870C File Offset: 0x001A690C
		// (set) Token: 0x060120F8 RID: 73976 RVA: 0x001A871C File Offset: 0x001A691C
		public unsafe EAttributeBasedFloatCalculationType AttributeCalculationType
		{
			get
			{
				return (EAttributeBasedFloatCalculationType)(*(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_AttributeCalculationType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_AttributeCalculationType) = (byte)value;
			}
		}

		// Token: 0x17004662 RID: 18018
		// (get) Token: 0x060120F9 RID: 73977 RVA: 0x001A872D File Offset: 0x001A692D
		// (set) Token: 0x060120FA RID: 73978 RVA: 0x001A873D File Offset: 0x001A693D
		public unsafe EGameplayModEvaluationChannel FinalChannel
		{
			get
			{
				return (EGameplayModEvaluationChannel)(*(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_FinalChannel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_FinalChannel) = (byte)value;
			}
		}

		// Token: 0x17004663 RID: 18019
		// (get) Token: 0x060120FB RID: 73979 RVA: 0x001A8750 File Offset: 0x001A6950
		// (set) Token: 0x060120FC RID: 73980 RVA: 0x001A8793 File Offset: 0x001A6993
		public FGameplayTagContainer SourceTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._SourceTagFilter) == null)
				{
					result = (this._SourceTagFilter = new FGameplayTagContainer(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_SourceTagFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_SourceTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004664 RID: 18020
		// (get) Token: 0x060120FD RID: 73981 RVA: 0x001A87B4 File Offset: 0x001A69B4
		// (set) Token: 0x060120FE RID: 73982 RVA: 0x001A87F7 File Offset: 0x001A69F7
		public FGameplayTagContainer TargetTagFilter
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._TargetTagFilter) == null)
				{
					result = (this._TargetTagFilter = new FGameplayTagContainer(base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_TargetTagFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FAttributeBasedFloat.__PropertyOffset_TargetTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060120FF RID: 73983 RVA: 0x001A8818 File Offset: 0x001A6A18
		public FAttributeBasedFloat()
		{
		}

		// Token: 0x06012100 RID: 73984 RVA: 0x001A8820 File Offset: 0x001A6A20
		public FAttributeBasedFloat(FScalableFloat Coefficient, FScalableFloat PreMultiplyAdditiveValue, FScalableFloat PostMultiplyAdditiveValue, FGameplayEffectAttributeCaptureDefinition BackingAttribute, FCurveTableRowHandle AttributeCurve, EAttributeBasedFloatCalculationType AttributeCalculationType, EGameplayModEvaluationChannel FinalChannel, FGameplayTagContainer SourceTagFilter, FGameplayTagContainer TargetTagFilter)
		{
			this.Coefficient = Coefficient;
			this.PreMultiplyAdditiveValue = PreMultiplyAdditiveValue;
			this.PostMultiplyAdditiveValue = PostMultiplyAdditiveValue;
			this.BackingAttribute = BackingAttribute;
			this.AttributeCurve = AttributeCurve;
			this.AttributeCalculationType = AttributeCalculationType;
			this.FinalChannel = FinalChannel;
			this.SourceTagFilter = SourceTagFilter;
			this.TargetTagFilter = TargetTagFilter;
		}

		// Token: 0x06012101 RID: 73985 RVA: 0x001A8878 File Offset: 0x001A6A78
		protected override IntPtr GetUStructPtr()
		{
			return FAttributeBasedFloat.StaticStruct();
		}

		// Token: 0x06012102 RID: 73986 RVA: 0x001A8884 File Offset: 0x001A6A84
		[NullableContext(2)]
		public FAttributeBasedFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012103 RID: 73987 RVA: 0x001A888E File Offset: 0x001A6A8E
		public FAttributeBasedFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012104 RID: 73988 RVA: 0x001A8899 File Offset: 0x001A6A99
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAttributeBasedFloat(Pointer, false, true);
		}

		// Token: 0x06012105 RID: 73989 RVA: 0x001A88A3 File Offset: 0x001A6AA3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAttributeBasedFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04009A44 RID: 39492
		public const string __ObjectPath = "/Script/GameplayAbilities.AttributeBasedFloat";

		// Token: 0x04009A45 RID: 39493
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009A46 RID: 39494
		internal static int __PropertyOffset_Coefficient;

		// Token: 0x04009A47 RID: 39495
		[Nullable(2)]
		private FScalableFloat _Coefficient;

		// Token: 0x04009A48 RID: 39496
		internal static int __PropertyOffset_PreMultiplyAdditiveValue;

		// Token: 0x04009A49 RID: 39497
		[Nullable(2)]
		private FScalableFloat _PreMultiplyAdditiveValue;

		// Token: 0x04009A4A RID: 39498
		internal static int __PropertyOffset_PostMultiplyAdditiveValue;

		// Token: 0x04009A4B RID: 39499
		[Nullable(2)]
		private FScalableFloat _PostMultiplyAdditiveValue;

		// Token: 0x04009A4C RID: 39500
		internal static int __PropertyOffset_BackingAttribute;

		// Token: 0x04009A4D RID: 39501
		[Nullable(2)]
		private FGameplayEffectAttributeCaptureDefinition _BackingAttribute;

		// Token: 0x04009A4E RID: 39502
		internal static int __PropertyOffset_AttributeCurve;

		// Token: 0x04009A4F RID: 39503
		[Nullable(2)]
		private FCurveTableRowHandle _AttributeCurve;

		// Token: 0x04009A50 RID: 39504
		internal static int __PropertyOffset_AttributeCalculationType;

		// Token: 0x04009A51 RID: 39505
		internal static int __PropertyOffset_FinalChannel;

		// Token: 0x04009A52 RID: 39506
		internal static int __PropertyOffset_SourceTagFilter;

		// Token: 0x04009A53 RID: 39507
		[Nullable(2)]
		private FGameplayTagContainer _SourceTagFilter;

		// Token: 0x04009A54 RID: 39508
		internal static int __PropertyOffset_TargetTagFilter;

		// Token: 0x04009A55 RID: 39509
		[Nullable(2)]
		private FGameplayTagContainer _TargetTagFilter;
	}
}
