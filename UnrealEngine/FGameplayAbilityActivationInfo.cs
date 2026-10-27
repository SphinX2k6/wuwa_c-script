using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200134C RID: 4940
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityActivationInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FGameplayAbilityActivationInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060121F1 RID: 74225 RVA: 0x001A9A53 File Offset: 0x001A7C53
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityActivationInfo._ScriptStructPtr != 0) ? FGameplayAbilityActivationInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityActivationInfo", ref FGameplayAbilityActivationInfo._ScriptStructPtr);
		}

		// Token: 0x17004690 RID: 18064
		// (get) Token: 0x060121F2 RID: 74226 RVA: 0x001A9A77 File Offset: 0x001A7C77
		// (set) Token: 0x060121F3 RID: 74227 RVA: 0x001A9A8B File Offset: 0x001A7C8B
		public unsafe TEnumAsByte<EGameplayAbilityActivationMode> ActivationMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_ActivationMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_ActivationMode) = value;
			}
		}

		// Token: 0x17004691 RID: 18065
		// (get) Token: 0x060121F4 RID: 74228 RVA: 0x001A9AA0 File Offset: 0x001A7CA0
		// (set) Token: 0x060121F5 RID: 74229 RVA: 0x001A9AB9 File Offset: 0x001A7CB9
		public unsafe bool bCanBeEndedByOtherInstance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_bCanBeEndedByOtherInstance) & FGameplayAbilityActivationInfo.__PropertyMask_bCanBeEndedByOtherInstance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_bCanBeEndedByOtherInstance) = ((*(base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_bCanBeEndedByOtherInstance) & ~FGameplayAbilityActivationInfo.__PropertyMask_bCanBeEndedByOtherInstance) | (value ? FGameplayAbilityActivationInfo.__PropertyMask_bCanBeEndedByOtherInstance : 0));
			}
		}

		// Token: 0x17004692 RID: 18066
		// (get) Token: 0x060121F6 RID: 74230 RVA: 0x001A9AEC File Offset: 0x001A7CEC
		// (set) Token: 0x060121F7 RID: 74231 RVA: 0x001A9B2F File Offset: 0x001A7D2F
		[Nullable(1)]
		public FPredictionKey PredictionKeyWhenActivated
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FPredictionKey result;
				if ((result = this._PredictionKeyWhenActivated) == null)
				{
					result = (this._PredictionKeyWhenActivated = new FPredictionKey(base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_PredictionKeyWhenActivated, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPredictionKey.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityActivationInfo.__PropertyOffset_PredictionKeyWhenActivated, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060121F8 RID: 74232 RVA: 0x001A9B50 File Offset: 0x001A7D50
		public FGameplayAbilityActivationInfo()
		{
		}

		// Token: 0x060121F9 RID: 74233 RVA: 0x001A9B58 File Offset: 0x001A7D58
		public FGameplayAbilityActivationInfo(TEnumAsByte<EGameplayAbilityActivationMode> ActivationMode, bool bCanBeEndedByOtherInstance, [Nullable(1)] FPredictionKey PredictionKeyWhenActivated)
		{
			this.ActivationMode = ActivationMode;
			this.bCanBeEndedByOtherInstance = bCanBeEndedByOtherInstance;
			this.PredictionKeyWhenActivated = PredictionKeyWhenActivated;
		}

		// Token: 0x060121FA RID: 74234 RVA: 0x001A9B75 File Offset: 0x001A7D75
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityActivationInfo.StaticStruct();
		}

		// Token: 0x060121FB RID: 74235 RVA: 0x001A9B81 File Offset: 0x001A7D81
		[NullableContext(2)]
		public FGameplayAbilityActivationInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060121FC RID: 74236 RVA: 0x001A9B8B File Offset: 0x001A7D8B
		public FGameplayAbilityActivationInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060121FD RID: 74237 RVA: 0x001A9B96 File Offset: 0x001A7D96
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityActivationInfo(Pointer, false, true);
		}

		// Token: 0x060121FE RID: 74238 RVA: 0x001A9BA0 File Offset: 0x001A7DA0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityActivationInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009B53 RID: 39763
		[Nullable(1)]
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityActivationInfo";

		// Token: 0x04009B54 RID: 39764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009B55 RID: 39765
		internal static int __PropertyOffset_ActivationMode;

		// Token: 0x04009B56 RID: 39766
		internal static int __PropertyOffset_bCanBeEndedByOtherInstance;

		// Token: 0x04009B57 RID: 39767
		internal static byte __PropertyMask_bCanBeEndedByOtherInstance;

		// Token: 0x04009B58 RID: 39768
		internal static int __PropertyOffset_PredictionKeyWhenActivated;

		// Token: 0x04009B59 RID: 39769
		[Nullable(2)]
		private FPredictionKey _PredictionKeyWhenActivated;
	}
}
