using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200138B RID: 5003
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectExecutionScopedModifierInfo")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 808)]
	public class FGameplayEffectExecutionScopedModifierInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060125D2 RID: 75218 RVA: 0x001AF9D2 File Offset: 0x001ADBD2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectExecutionScopedModifierInfo._ScriptStructPtr != 0) ? FGameplayEffectExecutionScopedModifierInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectExecutionScopedModifierInfo", ref FGameplayEffectExecutionScopedModifierInfo._ScriptStructPtr);
		}

		// Token: 0x1700478D RID: 18317
		// (get) Token: 0x060125D3 RID: 75219 RVA: 0x001AF9F8 File Offset: 0x001ADBF8
		// (set) Token: 0x060125D4 RID: 75220 RVA: 0x001AFA3B File Offset: 0x001ADC3B
		public FGameplayEffectAttributeCaptureDefinition CapturedAttribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAttributeCaptureDefinition result;
				if ((result = this._CapturedAttribute) == null)
				{
					result = (this._CapturedAttribute = new FGameplayEffectAttributeCaptureDefinition(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_CapturedAttribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectAttributeCaptureDefinition.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_CapturedAttribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700478E RID: 18318
		// (get) Token: 0x060125D5 RID: 75221 RVA: 0x001AFA5C File Offset: 0x001ADC5C
		// (set) Token: 0x060125D6 RID: 75222 RVA: 0x001AFA70 File Offset: 0x001ADC70
		public unsafe FGameplayTag TransientAggregatorIdentifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_TransientAggregatorIdentifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_TransientAggregatorIdentifier) = value;
			}
		}

		// Token: 0x1700478F RID: 18319
		// (get) Token: 0x060125D7 RID: 75223 RVA: 0x001AFA85 File Offset: 0x001ADC85
		// (set) Token: 0x060125D8 RID: 75224 RVA: 0x001AFA95 File Offset: 0x001ADC95
		public unsafe EGameplayEffectScopedModifierAggregatorType AggregatorType
		{
			get
			{
				return (EGameplayEffectScopedModifierAggregatorType)(*(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_AggregatorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_AggregatorType) = (byte)value;
			}
		}

		// Token: 0x17004790 RID: 18320
		// (get) Token: 0x060125D9 RID: 75225 RVA: 0x001AFAA6 File Offset: 0x001ADCA6
		// (set) Token: 0x060125DA RID: 75226 RVA: 0x001AFABA File Offset: 0x001ADCBA
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayModOp> ModifierOp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_ModifierOp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_ModifierOp) = value;
			}
		}

		// Token: 0x17004791 RID: 18321
		// (get) Token: 0x060125DB RID: 75227 RVA: 0x001AFAD0 File Offset: 0x001ADCD0
		// (set) Token: 0x060125DC RID: 75228 RVA: 0x001AFB13 File Offset: 0x001ADD13
		public FGameplayEffectModifierMagnitude ModifierMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectModifierMagnitude result;
				if ((result = this._ModifierMagnitude) == null)
				{
					result = (this._ModifierMagnitude = new FGameplayEffectModifierMagnitude(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_ModifierMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectModifierMagnitude.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_ModifierMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004792 RID: 18322
		// (get) Token: 0x060125DD RID: 75229 RVA: 0x001AFB34 File Offset: 0x001ADD34
		// (set) Token: 0x060125DE RID: 75230 RVA: 0x001AFB77 File Offset: 0x001ADD77
		public FGameplayModEvaluationChannelSettings EvaluationChannelSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayModEvaluationChannelSettings result;
				if ((result = this._EvaluationChannelSettings) == null)
				{
					result = (this._EvaluationChannelSettings = new FGameplayModEvaluationChannelSettings(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_EvaluationChannelSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayModEvaluationChannelSettings.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_EvaluationChannelSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004793 RID: 18323
		// (get) Token: 0x060125DF RID: 75231 RVA: 0x001AFB98 File Offset: 0x001ADD98
		// (set) Token: 0x060125E0 RID: 75232 RVA: 0x001AFBDB File Offset: 0x001ADDDB
		public FGameplayTagRequirements SourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._SourceTags) == null)
				{
					result = (this._SourceTags = new FGameplayTagRequirements(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_SourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_SourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004794 RID: 18324
		// (get) Token: 0x060125E1 RID: 75233 RVA: 0x001AFBFC File Offset: 0x001ADDFC
		// (set) Token: 0x060125E2 RID: 75234 RVA: 0x001AFC3F File Offset: 0x001ADE3F
		public FGameplayTagRequirements TargetTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._TargetTags) == null)
				{
					result = (this._TargetTags = new FGameplayTagRequirements(base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_TargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectExecutionScopedModifierInfo.__PropertyOffset_TargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060125E3 RID: 75235 RVA: 0x001AFC60 File Offset: 0x001ADE60
		public FGameplayEffectExecutionScopedModifierInfo()
		{
		}

		// Token: 0x060125E4 RID: 75236 RVA: 0x001AFC68 File Offset: 0x001ADE68
		public FGameplayEffectExecutionScopedModifierInfo(FGameplayEffectAttributeCaptureDefinition CapturedAttribute, FGameplayTag TransientAggregatorIdentifier, EGameplayEffectScopedModifierAggregatorType AggregatorType, [Nullable(0)] TEnumAsByte<EGameplayModOp> ModifierOp, FGameplayEffectModifierMagnitude ModifierMagnitude, FGameplayModEvaluationChannelSettings EvaluationChannelSettings, FGameplayTagRequirements SourceTags, FGameplayTagRequirements TargetTags)
		{
			this.CapturedAttribute = CapturedAttribute;
			this.TransientAggregatorIdentifier = TransientAggregatorIdentifier;
			this.AggregatorType = AggregatorType;
			this.ModifierOp = ModifierOp;
			this.ModifierMagnitude = ModifierMagnitude;
			this.EvaluationChannelSettings = EvaluationChannelSettings;
			this.SourceTags = SourceTags;
			this.TargetTags = TargetTags;
		}

		// Token: 0x060125E5 RID: 75237 RVA: 0x001AFCB8 File Offset: 0x001ADEB8
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectExecutionScopedModifierInfo.StaticStruct();
		}

		// Token: 0x060125E6 RID: 75238 RVA: 0x001AFCC4 File Offset: 0x001ADEC4
		[NullableContext(2)]
		public FGameplayEffectExecutionScopedModifierInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060125E7 RID: 75239 RVA: 0x001AFCCE File Offset: 0x001ADECE
		public FGameplayEffectExecutionScopedModifierInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060125E8 RID: 75240 RVA: 0x001AFCD9 File Offset: 0x001ADED9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectExecutionScopedModifierInfo(Pointer, false, true);
		}

		// Token: 0x060125E9 RID: 75241 RVA: 0x001AFCE3 File Offset: 0x001ADEE3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectExecutionScopedModifierInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009D4D RID: 40269
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectExecutionScopedModifierInfo";

		// Token: 0x04009D4E RID: 40270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D4F RID: 40271
		internal static int __PropertyOffset_CapturedAttribute;

		// Token: 0x04009D50 RID: 40272
		[Nullable(2)]
		private FGameplayEffectAttributeCaptureDefinition _CapturedAttribute;

		// Token: 0x04009D51 RID: 40273
		internal static int __PropertyOffset_TransientAggregatorIdentifier;

		// Token: 0x04009D52 RID: 40274
		internal static int __PropertyOffset_AggregatorType;

		// Token: 0x04009D53 RID: 40275
		internal static int __PropertyOffset_ModifierOp;

		// Token: 0x04009D54 RID: 40276
		internal static int __PropertyOffset_ModifierMagnitude;

		// Token: 0x04009D55 RID: 40277
		[Nullable(2)]
		private FGameplayEffectModifierMagnitude _ModifierMagnitude;

		// Token: 0x04009D56 RID: 40278
		internal static int __PropertyOffset_EvaluationChannelSettings;

		// Token: 0x04009D57 RID: 40279
		[Nullable(2)]
		private FGameplayModEvaluationChannelSettings _EvaluationChannelSettings;

		// Token: 0x04009D58 RID: 40280
		internal static int __PropertyOffset_SourceTags;

		// Token: 0x04009D59 RID: 40281
		[Nullable(2)]
		private FGameplayTagRequirements _SourceTags;

		// Token: 0x04009D5A RID: 40282
		internal static int __PropertyOffset_TargetTags;

		// Token: 0x04009D5B RID: 40283
		[Nullable(2)]
		private FGameplayTagRequirements _TargetTags;
	}
}
