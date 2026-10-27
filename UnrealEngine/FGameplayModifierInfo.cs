using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001398 RID: 5016
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayModifierInfo")]
	[UnrealStructLayout(808, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 808)]
	public class FGameplayModifierInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060126BE RID: 75454 RVA: 0x001B145A File Offset: 0x001AF65A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayModifierInfo._ScriptStructPtr != 0) ? FGameplayModifierInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayModifierInfo", ref FGameplayModifierInfo._ScriptStructPtr);
		}

		// Token: 0x170047D3 RID: 18387
		// (get) Token: 0x060126BF RID: 75455 RVA: 0x001B1480 File Offset: 0x001AF680
		// (set) Token: 0x060126C0 RID: 75456 RVA: 0x001B14C3 File Offset: 0x001AF6C3
		public FGameplayAttribute Attribute
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAttribute result;
				if ((result = this._Attribute) == null)
				{
					result = (this._Attribute = new FGameplayAttribute(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_Attribute, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAttribute.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_Attribute, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D4 RID: 18388
		// (get) Token: 0x060126C1 RID: 75457 RVA: 0x001B14E4 File Offset: 0x001AF6E4
		// (set) Token: 0x060126C2 RID: 75458 RVA: 0x001B14F8 File Offset: 0x001AF6F8
		[Nullable(0)]
		public unsafe TEnumAsByte<EGameplayModOp> ModifierOp
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_ModifierOp);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_ModifierOp) = value;
			}
		}

		// Token: 0x170047D5 RID: 18389
		// (get) Token: 0x060126C3 RID: 75459 RVA: 0x001B1510 File Offset: 0x001AF710
		// (set) Token: 0x060126C4 RID: 75460 RVA: 0x001B1553 File Offset: 0x001AF753
		public FScalableFloat Magnitude
		{
			get
			{
				base.FastCheckIsValid();
				FScalableFloat result;
				if ((result = this._Magnitude) == null)
				{
					result = (this._Magnitude = new FScalableFloat(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_Magnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FScalableFloat.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_Magnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D6 RID: 18390
		// (get) Token: 0x060126C5 RID: 75461 RVA: 0x001B1574 File Offset: 0x001AF774
		// (set) Token: 0x060126C6 RID: 75462 RVA: 0x001B15B7 File Offset: 0x001AF7B7
		public FGameplayEffectModifierMagnitude ModifierMagnitude
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectModifierMagnitude result;
				if ((result = this._ModifierMagnitude) == null)
				{
					result = (this._ModifierMagnitude = new FGameplayEffectModifierMagnitude(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_ModifierMagnitude, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectModifierMagnitude.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_ModifierMagnitude, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D7 RID: 18391
		// (get) Token: 0x060126C7 RID: 75463 RVA: 0x001B15D8 File Offset: 0x001AF7D8
		// (set) Token: 0x060126C8 RID: 75464 RVA: 0x001B161B File Offset: 0x001AF81B
		public FGameplayModEvaluationChannelSettings EvaluationChannelSettings
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayModEvaluationChannelSettings result;
				if ((result = this._EvaluationChannelSettings) == null)
				{
					result = (this._EvaluationChannelSettings = new FGameplayModEvaluationChannelSettings(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_EvaluationChannelSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayModEvaluationChannelSettings.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_EvaluationChannelSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D8 RID: 18392
		// (get) Token: 0x060126C9 RID: 75465 RVA: 0x001B163C File Offset: 0x001AF83C
		// (set) Token: 0x060126CA RID: 75466 RVA: 0x001B167F File Offset: 0x001AF87F
		public FGameplayTagRequirements SourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._SourceTags) == null)
				{
					result = (this._SourceTags = new FGameplayTagRequirements(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_SourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_SourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047D9 RID: 18393
		// (get) Token: 0x060126CB RID: 75467 RVA: 0x001B16A0 File Offset: 0x001AF8A0
		// (set) Token: 0x060126CC RID: 75468 RVA: 0x001B16E3 File Offset: 0x001AF8E3
		public FGameplayTagRequirements TargetTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagRequirements result;
				if ((result = this._TargetTags) == null)
				{
					result = (this._TargetTags = new FGameplayTagRequirements(base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_TargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagRequirements.StaticStruct(), base.NativePtr + (IntPtr)FGameplayModifierInfo.__PropertyOffset_TargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060126CD RID: 75469 RVA: 0x001B1704 File Offset: 0x001AF904
		public FGameplayModifierInfo()
		{
		}

		// Token: 0x060126CE RID: 75470 RVA: 0x001B170C File Offset: 0x001AF90C
		public FGameplayModifierInfo(FGameplayAttribute Attribute, [Nullable(0)] TEnumAsByte<EGameplayModOp> ModifierOp, FScalableFloat Magnitude, FGameplayEffectModifierMagnitude ModifierMagnitude, FGameplayModEvaluationChannelSettings EvaluationChannelSettings, FGameplayTagRequirements SourceTags, FGameplayTagRequirements TargetTags)
		{
			this.Attribute = Attribute;
			this.ModifierOp = ModifierOp;
			this.Magnitude = Magnitude;
			this.ModifierMagnitude = ModifierMagnitude;
			this.EvaluationChannelSettings = EvaluationChannelSettings;
			this.SourceTags = SourceTags;
			this.TargetTags = TargetTags;
		}

		// Token: 0x060126CF RID: 75471 RVA: 0x001B1749 File Offset: 0x001AF949
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayModifierInfo.StaticStruct();
		}

		// Token: 0x060126D0 RID: 75472 RVA: 0x001B1755 File Offset: 0x001AF955
		[NullableContext(2)]
		public FGameplayModifierInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060126D1 RID: 75473 RVA: 0x001B175F File Offset: 0x001AF95F
		public FGameplayModifierInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060126D2 RID: 75474 RVA: 0x001B176A File Offset: 0x001AF96A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayModifierInfo(Pointer, false, true);
		}

		// Token: 0x060126D3 RID: 75475 RVA: 0x001B1774 File Offset: 0x001AF974
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayModifierInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009DD6 RID: 40406
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayModifierInfo";

		// Token: 0x04009DD7 RID: 40407
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DD8 RID: 40408
		internal static int __PropertyOffset_Attribute;

		// Token: 0x04009DD9 RID: 40409
		[Nullable(2)]
		private FGameplayAttribute _Attribute;

		// Token: 0x04009DDA RID: 40410
		internal static int __PropertyOffset_ModifierOp;

		// Token: 0x04009DDB RID: 40411
		internal static int __PropertyOffset_Magnitude;

		// Token: 0x04009DDC RID: 40412
		[Nullable(2)]
		private FScalableFloat _Magnitude;

		// Token: 0x04009DDD RID: 40413
		internal static int __PropertyOffset_ModifierMagnitude;

		// Token: 0x04009DDE RID: 40414
		[Nullable(2)]
		private FGameplayEffectModifierMagnitude _ModifierMagnitude;

		// Token: 0x04009DDF RID: 40415
		internal static int __PropertyOffset_EvaluationChannelSettings;

		// Token: 0x04009DE0 RID: 40416
		[Nullable(2)]
		private FGameplayModEvaluationChannelSettings _EvaluationChannelSettings;

		// Token: 0x04009DE1 RID: 40417
		internal static int __PropertyOffset_SourceTags;

		// Token: 0x04009DE2 RID: 40418
		[Nullable(2)]
		private FGameplayTagRequirements _SourceTags;

		// Token: 0x04009DE3 RID: 40419
		internal static int __PropertyOffset_TargetTags;

		// Token: 0x04009DE4 RID: 40420
		[Nullable(2)]
		private FGameplayTagRequirements _TargetTags;
	}
}
