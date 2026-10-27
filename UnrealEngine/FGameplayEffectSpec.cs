using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001390 RID: 5008
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectSpec")]
	[UnrealStructLayout(688, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 688)]
	public class FGameplayEffectSpec : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601262C RID: 75308 RVA: 0x001B0431 File Offset: 0x001AE631
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectSpec._ScriptStructPtr != 0) ? FGameplayEffectSpec._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectSpec", ref FGameplayEffectSpec._ScriptStructPtr);
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x0601262D RID: 75309 RVA: 0x001B0455 File Offset: 0x001AE655
		// (set) Token: 0x0601262E RID: 75310 RVA: 0x001B0465 File Offset: 0x001AE665
		public unsafe bool FromRemote
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_FromRemote) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_FromRemote) = (value ? 1 : 0);
			}
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x0601262F RID: 75311 RVA: 0x001B0476 File Offset: 0x001AE676
		// (set) Token: 0x06012630 RID: 75312 RVA: 0x001B0486 File Offset: 0x001AE686
		public unsafe int GameplayEffectServerId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_GameplayEffectServerId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_GameplayEffectServerId) = value;
			}
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x06012631 RID: 75313 RVA: 0x001B0497 File Offset: 0x001AE697
		// (set) Token: 0x06012632 RID: 75314 RVA: 0x001B04AB File Offset: 0x001AE6AB
		[Nullable(2)]
		public unsafe AActor CurrentSpecTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpec.__PropertyOffset_CurrentSpecTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpec.__PropertyOffset_CurrentSpecTarget, value);
			}
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x06012633 RID: 75315 RVA: 0x001B04C0 File Offset: 0x001AE6C0
		// (set) Token: 0x06012634 RID: 75316 RVA: 0x001B04D4 File Offset: 0x001AE6D4
		[Nullable(2)]
		public unsafe UGameplayEffect Def
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayEffect>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpec.__PropertyOffset_Def);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpec.__PropertyOffset_Def, value);
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x06012635 RID: 75317 RVA: 0x001B04EC File Offset: 0x001AE6EC
		// (set) Token: 0x06012636 RID: 75318 RVA: 0x001B052F File Offset: 0x001AE72F
		public TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectModifiedAttribute> result;
				if ((result = this._ModifiedAttributes) == null)
				{
					result = (this._ModifiedAttributes = new TArray<FGameplayEffectModifiedAttribute>(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_ModifiedAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedAttributes.CopyAssign(value);
			}
		}

		// Token: 0x170047AB RID: 18347
		// (get) Token: 0x06012637 RID: 75319 RVA: 0x001B0540 File Offset: 0x001AE740
		// (set) Token: 0x06012638 RID: 75320 RVA: 0x001B0583 File Offset: 0x001AE783
		public FGameplayEffectAttributeCaptureSpecContainer CapturedRelevantAttributes
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectAttributeCaptureSpecContainer result;
				if ((result = this._CapturedRelevantAttributes) == null)
				{
					result = (this._CapturedRelevantAttributes = new FGameplayEffectAttributeCaptureSpecContainer(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedRelevantAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectAttributeCaptureSpecContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedRelevantAttributes, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047AC RID: 18348
		// (get) Token: 0x06012639 RID: 75321 RVA: 0x001B05A4 File Offset: 0x001AE7A4
		// (set) Token: 0x0601263A RID: 75322 RVA: 0x001B05B4 File Offset: 0x001AE7B4
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x170047AD RID: 18349
		// (get) Token: 0x0601263B RID: 75323 RVA: 0x001B05C5 File Offset: 0x001AE7C5
		// (set) Token: 0x0601263C RID: 75324 RVA: 0x001B05D5 File Offset: 0x001AE7D5
		public unsafe float Period
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Period);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Period) = value;
			}
		}

		// Token: 0x170047AE RID: 18350
		// (get) Token: 0x0601263D RID: 75325 RVA: 0x001B05E6 File Offset: 0x001AE7E6
		// (set) Token: 0x0601263E RID: 75326 RVA: 0x001B05F6 File Offset: 0x001AE7F6
		public unsafe float ChanceToApplyToTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_ChanceToApplyToTarget);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_ChanceToApplyToTarget) = value;
			}
		}

		// Token: 0x170047AF RID: 18351
		// (get) Token: 0x0601263F RID: 75327 RVA: 0x001B0608 File Offset: 0x001AE808
		// (set) Token: 0x06012640 RID: 75328 RVA: 0x001B064B File Offset: 0x001AE84B
		public FTagContainerAggregator CapturedSourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FTagContainerAggregator result;
				if ((result = this._CapturedSourceTags) == null)
				{
					result = (this._CapturedSourceTags = new FTagContainerAggregator(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedSourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTagContainerAggregator.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedSourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047B0 RID: 18352
		// (get) Token: 0x06012641 RID: 75329 RVA: 0x001B066C File Offset: 0x001AE86C
		// (set) Token: 0x06012642 RID: 75330 RVA: 0x001B06AF File Offset: 0x001AE8AF
		public FTagContainerAggregator CapturedTargetTags
		{
			get
			{
				base.FastCheckIsValid();
				FTagContainerAggregator result;
				if ((result = this._CapturedTargetTags) == null)
				{
					result = (this._CapturedTargetTags = new FTagContainerAggregator(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedTargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTagContainerAggregator.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_CapturedTargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047B1 RID: 18353
		// (get) Token: 0x06012643 RID: 75331 RVA: 0x001B06D0 File Offset: 0x001AE8D0
		// (set) Token: 0x06012644 RID: 75332 RVA: 0x001B0713 File Offset: 0x001AE913
		public FGameplayTagContainer DynamicGrantedTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DynamicGrantedTags) == null)
				{
					result = (this._DynamicGrantedTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_DynamicGrantedTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_DynamicGrantedTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047B2 RID: 18354
		// (get) Token: 0x06012645 RID: 75333 RVA: 0x001B0734 File Offset: 0x001AE934
		// (set) Token: 0x06012646 RID: 75334 RVA: 0x001B0777 File Offset: 0x001AE977
		public FGameplayTagContainer DynamicAssetTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._DynamicAssetTags) == null)
				{
					result = (this._DynamicAssetTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_DynamicAssetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_DynamicAssetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047B3 RID: 18355
		// (get) Token: 0x06012647 RID: 75335 RVA: 0x001B0798 File Offset: 0x001AE998
		// (set) Token: 0x06012648 RID: 75336 RVA: 0x001B07DB File Offset: 0x001AE9DB
		public TArray<FModifierSpec> Modifiers
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FModifierSpec> result;
				if ((result = this._Modifiers) == null)
				{
					result = (this._Modifiers = new TArray<FModifierSpec>(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Modifiers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Modifiers.CopyAssign(value);
			}
		}

		// Token: 0x170047B4 RID: 18356
		// (get) Token: 0x06012649 RID: 75337 RVA: 0x001B07E9 File Offset: 0x001AE9E9
		// (set) Token: 0x0601264A RID: 75338 RVA: 0x001B07F9 File Offset: 0x001AE9F9
		public unsafe int StackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_StackCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_StackCount) = value;
			}
		}

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x0601264B RID: 75339 RVA: 0x001B080A File Offset: 0x001AEA0A
		// (set) Token: 0x0601264C RID: 75340 RVA: 0x001B0823 File Offset: 0x001AEA23
		public unsafe bool bCompletedSourceAttributeCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedSourceAttributeCapture) & FGameplayEffectSpec.__PropertyMask_bCompletedSourceAttributeCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedSourceAttributeCapture) = ((*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedSourceAttributeCapture) & ~FGameplayEffectSpec.__PropertyMask_bCompletedSourceAttributeCapture) | (value ? FGameplayEffectSpec.__PropertyMask_bCompletedSourceAttributeCapture : 0));
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x0601264D RID: 75341 RVA: 0x001B0853 File Offset: 0x001AEA53
		// (set) Token: 0x0601264E RID: 75342 RVA: 0x001B086C File Offset: 0x001AEA6C
		public unsafe bool bCompletedTargetAttributeCapture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedTargetAttributeCapture) & FGameplayEffectSpec.__PropertyMask_bCompletedTargetAttributeCapture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedTargetAttributeCapture) = ((*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bCompletedTargetAttributeCapture) & ~FGameplayEffectSpec.__PropertyMask_bCompletedTargetAttributeCapture) | (value ? FGameplayEffectSpec.__PropertyMask_bCompletedTargetAttributeCapture : 0));
			}
		}

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x0601264F RID: 75343 RVA: 0x001B089C File Offset: 0x001AEA9C
		// (set) Token: 0x06012650 RID: 75344 RVA: 0x001B08B5 File Offset: 0x001AEAB5
		public unsafe bool bDurationLocked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bDurationLocked) & FGameplayEffectSpec.__PropertyMask_bDurationLocked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bDurationLocked) = ((*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_bDurationLocked) & ~FGameplayEffectSpec.__PropertyMask_bDurationLocked) | (value ? FGameplayEffectSpec.__PropertyMask_bDurationLocked : 0));
			}
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x06012651 RID: 75345 RVA: 0x001B08E8 File Offset: 0x001AEAE8
		// (set) Token: 0x06012652 RID: 75346 RVA: 0x001B092B File Offset: 0x001AEB2B
		public TArray<FGameplayAbilitySpecDef> GrantedAbilitySpecs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayAbilitySpecDef> result;
				if ((result = this._GrantedAbilitySpecs) == null)
				{
					result = (this._GrantedAbilitySpecs = new TArray<FGameplayAbilitySpecDef>(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_GrantedAbilitySpecs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GrantedAbilitySpecs.CopyAssign(value);
			}
		}

		// Token: 0x170047B9 RID: 18361
		// (get) Token: 0x06012653 RID: 75347 RVA: 0x001B093C File Offset: 0x001AEB3C
		// (set) Token: 0x06012654 RID: 75348 RVA: 0x001B097F File Offset: 0x001AEB7F
		public FGameplayEffectContextHandle EffectContext
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectContextHandle result;
				if ((result = this._EffectContext) == null)
				{
					result = (this._EffectContext = new FGameplayEffectContextHandle(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_EffectContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_EffectContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047BA RID: 18362
		// (get) Token: 0x06012655 RID: 75349 RVA: 0x001B09A0 File Offset: 0x001AEBA0
		// (set) Token: 0x06012656 RID: 75350 RVA: 0x001B09B0 File Offset: 0x001AEBB0
		public unsafe float Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpec.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x06012657 RID: 75351 RVA: 0x001B09C1 File Offset: 0x001AEBC1
		public FGameplayEffectSpec()
		{
		}

		// Token: 0x06012658 RID: 75352 RVA: 0x001B09CC File Offset: 0x001AEBCC
		public FGameplayEffectSpec(bool FromRemote, int GameplayEffectServerId, AActor CurrentSpecTarget, UGameplayEffect Def, TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes, FGameplayEffectAttributeCaptureSpecContainer CapturedRelevantAttributes, float Duration, float Period, float ChanceToApplyToTarget, FTagContainerAggregator CapturedSourceTags, FTagContainerAggregator CapturedTargetTags, FGameplayTagContainer DynamicGrantedTags, FGameplayTagContainer DynamicAssetTags, TArray<FModifierSpec> Modifiers, int StackCount, bool bCompletedSourceAttributeCapture, bool bCompletedTargetAttributeCapture, bool bDurationLocked, TArray<FGameplayAbilitySpecDef> GrantedAbilitySpecs, FGameplayEffectContextHandle EffectContext, float Level)
		{
			this.FromRemote = FromRemote;
			this.GameplayEffectServerId = GameplayEffectServerId;
			this.CurrentSpecTarget = CurrentSpecTarget;
			this.Def = Def;
			this.ModifiedAttributes = ModifiedAttributes;
			this.CapturedRelevantAttributes = CapturedRelevantAttributes;
			this.Duration = Duration;
			this.Period = Period;
			this.ChanceToApplyToTarget = ChanceToApplyToTarget;
			this.CapturedSourceTags = CapturedSourceTags;
			this.CapturedTargetTags = CapturedTargetTags;
			this.DynamicGrantedTags = DynamicGrantedTags;
			this.DynamicAssetTags = DynamicAssetTags;
			this.Modifiers = Modifiers;
			this.StackCount = StackCount;
			this.bCompletedSourceAttributeCapture = bCompletedSourceAttributeCapture;
			this.bCompletedTargetAttributeCapture = bCompletedTargetAttributeCapture;
			this.bDurationLocked = bDurationLocked;
			this.GrantedAbilitySpecs = GrantedAbilitySpecs;
			this.EffectContext = EffectContext;
			this.Level = Level;
		}

		// Token: 0x06012659 RID: 75353 RVA: 0x001B0A84 File Offset: 0x001AEC84
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectSpec.StaticStruct();
		}

		// Token: 0x0601265A RID: 75354 RVA: 0x001B0A90 File Offset: 0x001AEC90
		[NullableContext(2)]
		public FGameplayEffectSpec(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601265B RID: 75355 RVA: 0x001B0A9A File Offset: 0x001AEC9A
		public FGameplayEffectSpec(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601265C RID: 75356 RVA: 0x001B0AA5 File Offset: 0x001AECA5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectSpec(Pointer, false, true);
		}

		// Token: 0x0601265D RID: 75357 RVA: 0x001B0AAF File Offset: 0x001AECAF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectSpec(Pointer, MemoryOwner);
		}

		// Token: 0x04009D80 RID: 40320
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectSpec";

		// Token: 0x04009D81 RID: 40321
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009D82 RID: 40322
		internal static int __PropertyOffset_FromRemote;

		// Token: 0x04009D83 RID: 40323
		internal static int __PropertyOffset_GameplayEffectServerId;

		// Token: 0x04009D84 RID: 40324
		internal static int __PropertyOffset_CurrentSpecTarget;

		// Token: 0x04009D85 RID: 40325
		internal static int __PropertyOffset_Def;

		// Token: 0x04009D86 RID: 40326
		internal static int __PropertyOffset_ModifiedAttributes;

		// Token: 0x04009D87 RID: 40327
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectModifiedAttribute> _ModifiedAttributes;

		// Token: 0x04009D88 RID: 40328
		internal static int __PropertyOffset_CapturedRelevantAttributes;

		// Token: 0x04009D89 RID: 40329
		[Nullable(2)]
		private FGameplayEffectAttributeCaptureSpecContainer _CapturedRelevantAttributes;

		// Token: 0x04009D8A RID: 40330
		internal static int __PropertyOffset_Duration;

		// Token: 0x04009D8B RID: 40331
		internal static int __PropertyOffset_Period;

		// Token: 0x04009D8C RID: 40332
		internal static int __PropertyOffset_ChanceToApplyToTarget;

		// Token: 0x04009D8D RID: 40333
		internal static int __PropertyOffset_CapturedSourceTags;

		// Token: 0x04009D8E RID: 40334
		[Nullable(2)]
		private FTagContainerAggregator _CapturedSourceTags;

		// Token: 0x04009D8F RID: 40335
		internal static int __PropertyOffset_CapturedTargetTags;

		// Token: 0x04009D90 RID: 40336
		[Nullable(2)]
		private FTagContainerAggregator _CapturedTargetTags;

		// Token: 0x04009D91 RID: 40337
		internal static int __PropertyOffset_DynamicGrantedTags;

		// Token: 0x04009D92 RID: 40338
		[Nullable(2)]
		private FGameplayTagContainer _DynamicGrantedTags;

		// Token: 0x04009D93 RID: 40339
		internal static int __PropertyOffset_DynamicAssetTags;

		// Token: 0x04009D94 RID: 40340
		[Nullable(2)]
		private FGameplayTagContainer _DynamicAssetTags;

		// Token: 0x04009D95 RID: 40341
		internal static int __PropertyOffset_Modifiers;

		// Token: 0x04009D96 RID: 40342
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FModifierSpec> _Modifiers;

		// Token: 0x04009D97 RID: 40343
		internal static int __PropertyOffset_StackCount;

		// Token: 0x04009D98 RID: 40344
		internal static int __PropertyOffset_bCompletedSourceAttributeCapture;

		// Token: 0x04009D99 RID: 40345
		internal static byte __PropertyMask_bCompletedSourceAttributeCapture;

		// Token: 0x04009D9A RID: 40346
		internal static int __PropertyOffset_bCompletedTargetAttributeCapture;

		// Token: 0x04009D9B RID: 40347
		internal static byte __PropertyMask_bCompletedTargetAttributeCapture;

		// Token: 0x04009D9C RID: 40348
		internal static int __PropertyOffset_bDurationLocked;

		// Token: 0x04009D9D RID: 40349
		internal static byte __PropertyMask_bDurationLocked;

		// Token: 0x04009D9E RID: 40350
		internal static int __PropertyOffset_GrantedAbilitySpecs;

		// Token: 0x04009D9F RID: 40351
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayAbilitySpecDef> _GrantedAbilitySpecs;

		// Token: 0x04009DA0 RID: 40352
		internal static int __PropertyOffset_EffectContext;

		// Token: 0x04009DA1 RID: 40353
		[Nullable(2)]
		private FGameplayEffectContextHandle _EffectContext;

		// Token: 0x04009DA2 RID: 40354
		internal static int __PropertyOffset_Level;
	}
}
