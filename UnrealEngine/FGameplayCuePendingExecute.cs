using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001372 RID: 4978
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayCuePendingExecute")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 376)]
	public class FGameplayCuePendingExecute : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601245E RID: 74846 RVA: 0x001AD28C File Offset: 0x001AB48C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayCuePendingExecute._ScriptStructPtr != 0) ? FGameplayCuePendingExecute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayCuePendingExecute", ref FGameplayCuePendingExecute._ScriptStructPtr);
		}

		// Token: 0x1700472F RID: 18223
		// (get) Token: 0x0601245F RID: 74847 RVA: 0x001AD2B0 File Offset: 0x001AB4B0
		// (set) Token: 0x06012460 RID: 74848 RVA: 0x001AD2F3 File Offset: 0x001AB4F3
		public FPredictionKey PredictionKey
		{
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKey) == null)
				{
					result = (this._PredictionKey = new FPredictionKey(base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_PredictionKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_PredictionKey, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004730 RID: 18224
		// (get) Token: 0x06012461 RID: 74849 RVA: 0x001AD314 File Offset: 0x001AB514
		// (set) Token: 0x06012462 RID: 74850 RVA: 0x001AD324 File Offset: 0x001AB524
		public unsafe EGameplayCuePayloadType PayloadType
		{
			get
			{
				return (EGameplayCuePayloadType)(*(base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_PayloadType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_PayloadType) = (byte)value;
			}
		}

		// Token: 0x17004731 RID: 18225
		// (get) Token: 0x06012463 RID: 74851 RVA: 0x001AD335 File Offset: 0x001AB535
		// (set) Token: 0x06012464 RID: 74852 RVA: 0x001AD349 File Offset: 0x001AB549
		[Nullable(2)]
		public unsafe UAbilitySystemComponent OwningComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCuePendingExecute.__PropertyOffset_OwningComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FGameplayCuePendingExecute.__PropertyOffset_OwningComponent, value);
			}
		}

		// Token: 0x17004732 RID: 18226
		// (get) Token: 0x06012465 RID: 74853 RVA: 0x001AD360 File Offset: 0x001AB560
		// (set) Token: 0x06012466 RID: 74854 RVA: 0x001AD3A3 File Offset: 0x001AB5A3
		public FGameplayEffectSpecForRPC FromSpec
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayEffectSpecForRPC result;
				if ((result = this._FromSpec) == null)
				{
					result = (this._FromSpec = new FGameplayEffectSpecForRPC(base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_FromSpec, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectSpecForRPC.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_FromSpec, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004733 RID: 18227
		// (get) Token: 0x06012467 RID: 74855 RVA: 0x001AD3C4 File Offset: 0x001AB5C4
		// (set) Token: 0x06012468 RID: 74856 RVA: 0x001AD407 File Offset: 0x001AB607
		public FGameplayCueParameters CueParameters
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayCueParameters result;
				if ((result = this._CueParameters) == null)
				{
					result = (this._CueParameters = new FGameplayCueParameters(base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_CueParameters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayCueParameters.StaticStruct(), base.NativePtr + (IntPtr)FGameplayCuePendingExecute.__PropertyOffset_CueParameters, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012469 RID: 74857 RVA: 0x001AD428 File Offset: 0x001AB628
		public FGameplayCuePendingExecute()
		{
		}

		// Token: 0x0601246A RID: 74858 RVA: 0x001AD430 File Offset: 0x001AB630
		public FGameplayCuePendingExecute(FPredictionKey PredictionKey, EGameplayCuePayloadType PayloadType, UAbilitySystemComponent OwningComponent, FGameplayEffectSpecForRPC FromSpec, FGameplayCueParameters CueParameters)
		{
			this.PredictionKey = PredictionKey;
			this.PayloadType = PayloadType;
			this.OwningComponent = OwningComponent;
			this.FromSpec = FromSpec;
			this.CueParameters = CueParameters;
		}

		// Token: 0x0601246B RID: 74859 RVA: 0x001AD45D File Offset: 0x001AB65D
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayCuePendingExecute.StaticStruct();
		}

		// Token: 0x0601246C RID: 74860 RVA: 0x001AD469 File Offset: 0x001AB669
		[NullableContext(2)]
		public FGameplayCuePendingExecute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601246D RID: 74861 RVA: 0x001AD473 File Offset: 0x001AB673
		public FGameplayCuePendingExecute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601246E RID: 74862 RVA: 0x001AD47E File Offset: 0x001AB67E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayCuePendingExecute(Pointer, false, true);
		}

		// Token: 0x0601246F RID: 74863 RVA: 0x001AD488 File Offset: 0x001AB688
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayCuePendingExecute(Pointer, MemoryOwner);
		}

		// Token: 0x04009C7D RID: 40061
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayCuePendingExecute";

		// Token: 0x04009C7E RID: 40062
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009C7F RID: 40063
		internal static int __PropertyOffset_PredictionKey;

		// Token: 0x04009C80 RID: 40064
		[Nullable(2)]
		private FPredictionKey _PredictionKey;

		// Token: 0x04009C81 RID: 40065
		internal static int __PropertyOffset_PayloadType;

		// Token: 0x04009C82 RID: 40066
		internal static int __PropertyOffset_OwningComponent;

		// Token: 0x04009C83 RID: 40067
		internal static int __PropertyOffset_FromSpec;

		// Token: 0x04009C84 RID: 40068
		[Nullable(2)]
		private FGameplayEffectSpecForRPC _FromSpec;

		// Token: 0x04009C85 RID: 40069
		internal static int __PropertyOffset_CueParameters;

		// Token: 0x04009C86 RID: 40070
		[Nullable(2)]
		private FGameplayCueParameters _CueParameters;
	}
}
