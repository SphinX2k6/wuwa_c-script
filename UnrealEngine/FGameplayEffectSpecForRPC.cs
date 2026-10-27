using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001391 RID: 5009
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayEffectSpecForRPC")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FGameplayEffectSpecForRPC : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601265E RID: 75358 RVA: 0x001B0AB8 File Offset: 0x001AECB8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayEffectSpecForRPC._ScriptStructPtr != 0) ? FGameplayEffectSpecForRPC._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayEffectSpecForRPC", ref FGameplayEffectSpecForRPC._ScriptStructPtr);
		}

		// Token: 0x170047BB RID: 18363
		// (get) Token: 0x0601265F RID: 75359 RVA: 0x001B0ADC File Offset: 0x001AECDC
		// (set) Token: 0x06012660 RID: 75360 RVA: 0x001B0AF0 File Offset: 0x001AECF0
		[Nullable(2)]
		public unsafe UGameplayEffect Def
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameplayEffect>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpecForRPC.__PropertyOffset_Def);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayEffectSpecForRPC.__PropertyOffset_Def, value);
			}
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x06012661 RID: 75361 RVA: 0x001B0B08 File Offset: 0x001AED08
		// (set) Token: 0x06012662 RID: 75362 RVA: 0x001B0B4B File Offset: 0x001AED4B
		public TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameplayEffectModifiedAttribute> result;
				if ((result = this._ModifiedAttributes) == null)
				{
					result = (this._ModifiedAttributes = new TArray<FGameplayEffectModifiedAttribute>(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_ModifiedAttributes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ModifiedAttributes.CopyAssign(value);
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x06012663 RID: 75363 RVA: 0x001B0B5C File Offset: 0x001AED5C
		// (set) Token: 0x06012664 RID: 75364 RVA: 0x001B0B9F File Offset: 0x001AED9F
		public FGameplayEffectContextHandle EffectContext
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectContextHandle result;
				if ((result = this._EffectContext) == null)
				{
					result = (this._EffectContext = new FGameplayEffectContextHandle(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_EffectContext, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_EffectContext, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x06012665 RID: 75365 RVA: 0x001B0BC0 File Offset: 0x001AEDC0
		// (set) Token: 0x06012666 RID: 75366 RVA: 0x001B0C03 File Offset: 0x001AEE03
		public FGameplayTagContainer AggregatedSourceTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AggregatedSourceTags) == null)
				{
					result = (this._AggregatedSourceTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AggregatedSourceTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AggregatedSourceTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06012667 RID: 75367 RVA: 0x001B0C24 File Offset: 0x001AEE24
		// (set) Token: 0x06012668 RID: 75368 RVA: 0x001B0C67 File Offset: 0x001AEE67
		public FGameplayTagContainer AggregatedTargetTags
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayTagContainer result;
				if ((result = this._AggregatedTargetTags) == null)
				{
					result = (this._AggregatedTargetTags = new FGameplayTagContainer(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AggregatedTargetTags, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayTagContainer.StaticStruct(), base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AggregatedTargetTags, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170047C0 RID: 18368
		// (get) Token: 0x06012669 RID: 75369 RVA: 0x001B0C88 File Offset: 0x001AEE88
		// (set) Token: 0x0601266A RID: 75370 RVA: 0x001B0C98 File Offset: 0x001AEE98
		public unsafe float Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x170047C1 RID: 18369
		// (get) Token: 0x0601266B RID: 75371 RVA: 0x001B0CA9 File Offset: 0x001AEEA9
		// (set) Token: 0x0601266C RID: 75372 RVA: 0x001B0CB9 File Offset: 0x001AEEB9
		public unsafe float AbilityLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AbilityLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayEffectSpecForRPC.__PropertyOffset_AbilityLevel) = value;
			}
		}

		// Token: 0x0601266D RID: 75373 RVA: 0x001B0CCA File Offset: 0x001AEECA
		public FGameplayEffectSpecForRPC()
		{
		}

		// Token: 0x0601266E RID: 75374 RVA: 0x001B0CD2 File Offset: 0x001AEED2
		public FGameplayEffectSpecForRPC(UGameplayEffect Def, TArray<FGameplayEffectModifiedAttribute> ModifiedAttributes, FGameplayEffectContextHandle EffectContext, FGameplayTagContainer AggregatedSourceTags, FGameplayTagContainer AggregatedTargetTags, float Level, float AbilityLevel)
		{
			this.Def = Def;
			this.ModifiedAttributes = ModifiedAttributes;
			this.EffectContext = EffectContext;
			this.AggregatedSourceTags = AggregatedSourceTags;
			this.AggregatedTargetTags = AggregatedTargetTags;
			this.Level = Level;
			this.AbilityLevel = AbilityLevel;
		}

		// Token: 0x0601266F RID: 75375 RVA: 0x001B0D0F File Offset: 0x001AEF0F
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayEffectSpecForRPC.StaticStruct();
		}

		// Token: 0x06012670 RID: 75376 RVA: 0x001B0D1B File Offset: 0x001AEF1B
		[NullableContext(2)]
		public FGameplayEffectSpecForRPC(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012671 RID: 75377 RVA: 0x001B0D25 File Offset: 0x001AEF25
		public FGameplayEffectSpecForRPC(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012672 RID: 75378 RVA: 0x001B0D30 File Offset: 0x001AEF30
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayEffectSpecForRPC(Pointer, false, true);
		}

		// Token: 0x06012673 RID: 75379 RVA: 0x001B0D3A File Offset: 0x001AEF3A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayEffectSpecForRPC(Pointer, MemoryOwner);
		}

		// Token: 0x04009DA3 RID: 40355
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayEffectSpecForRPC";

		// Token: 0x04009DA4 RID: 40356
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009DA5 RID: 40357
		internal static int __PropertyOffset_Def;

		// Token: 0x04009DA6 RID: 40358
		internal static int __PropertyOffset_ModifiedAttributes;

		// Token: 0x04009DA7 RID: 40359
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameplayEffectModifiedAttribute> _ModifiedAttributes;

		// Token: 0x04009DA8 RID: 40360
		internal static int __PropertyOffset_EffectContext;

		// Token: 0x04009DA9 RID: 40361
		[Nullable(2)]
		private FGameplayEffectContextHandle _EffectContext;

		// Token: 0x04009DAA RID: 40362
		internal static int __PropertyOffset_AggregatedSourceTags;

		// Token: 0x04009DAB RID: 40363
		[Nullable(2)]
		private FGameplayTagContainer _AggregatedSourceTags;

		// Token: 0x04009DAC RID: 40364
		internal static int __PropertyOffset_AggregatedTargetTags;

		// Token: 0x04009DAD RID: 40365
		[Nullable(2)]
		private FGameplayTagContainer _AggregatedTargetTags;

		// Token: 0x04009DAE RID: 40366
		internal static int __PropertyOffset_Level;

		// Token: 0x04009DAF RID: 40367
		internal static int __PropertyOffset_AbilityLevel;
	}
}
