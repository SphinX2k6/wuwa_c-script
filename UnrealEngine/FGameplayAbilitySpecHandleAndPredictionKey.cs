using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001357 RID: 4951
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilitySpecHandleAndPredictionKey")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FGameplayAbilitySpecHandleAndPredictionKey : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060122AF RID: 74415 RVA: 0x001AAD15 File Offset: 0x001A8F15
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilitySpecHandleAndPredictionKey._ScriptStructPtr != 0) ? FGameplayAbilitySpecHandleAndPredictionKey._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilitySpecHandleAndPredictionKey", ref FGameplayAbilitySpecHandleAndPredictionKey._ScriptStructPtr);
		}

		// Token: 0x170046C6 RID: 18118
		// (get) Token: 0x060122B0 RID: 74416 RVA: 0x001AAD3C File Offset: 0x001A8F3C
		// (set) Token: 0x060122B1 RID: 74417 RVA: 0x001AAD7F File Offset: 0x001A8F7F
		public FGameplayAbilitySpecHandle AbilityHandle
		{
			get
			{
				base.FastCheckIsValid();
				FGameplayAbilitySpecHandle result;
				if ((result = this._AbilityHandle) == null)
				{
					result = (this._AbilityHandle = new FGameplayAbilitySpecHandle(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandleAndPredictionKey.__PropertyOffset_AbilityHandle, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayAbilitySpecHandle.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilitySpecHandleAndPredictionKey.__PropertyOffset_AbilityHandle, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046C7 RID: 18119
		// (get) Token: 0x060122B2 RID: 74418 RVA: 0x001AADA0 File Offset: 0x001A8FA0
		// (set) Token: 0x060122B3 RID: 74419 RVA: 0x001AADB0 File Offset: 0x001A8FB0
		public unsafe int PredictionKeyAtCreation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandleAndPredictionKey.__PropertyOffset_PredictionKeyAtCreation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilitySpecHandleAndPredictionKey.__PropertyOffset_PredictionKeyAtCreation) = value;
			}
		}

		// Token: 0x060122B4 RID: 74420 RVA: 0x001AADC1 File Offset: 0x001A8FC1
		public FGameplayAbilitySpecHandleAndPredictionKey()
		{
		}

		// Token: 0x060122B5 RID: 74421 RVA: 0x001AADC9 File Offset: 0x001A8FC9
		public FGameplayAbilitySpecHandleAndPredictionKey(FGameplayAbilitySpecHandle AbilityHandle, int PredictionKeyAtCreation)
		{
			this.AbilityHandle = AbilityHandle;
			this.PredictionKeyAtCreation = PredictionKeyAtCreation;
		}

		// Token: 0x060122B6 RID: 74422 RVA: 0x001AADDF File Offset: 0x001A8FDF
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilitySpecHandleAndPredictionKey.StaticStruct();
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x001AADEB File Offset: 0x001A8FEB
		[NullableContext(2)]
		public FGameplayAbilitySpecHandleAndPredictionKey(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060122B8 RID: 74424 RVA: 0x001AADF5 File Offset: 0x001A8FF5
		public FGameplayAbilitySpecHandleAndPredictionKey(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060122B9 RID: 74425 RVA: 0x001AAE00 File Offset: 0x001A9000
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilitySpecHandleAndPredictionKey(Pointer, false, true);
		}

		// Token: 0x060122BA RID: 74426 RVA: 0x001AAE0A File Offset: 0x001A900A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilitySpecHandleAndPredictionKey(Pointer, MemoryOwner);
		}

		// Token: 0x04009BB8 RID: 39864
		public const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilitySpecHandleAndPredictionKey";

		// Token: 0x04009BB9 RID: 39865
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BBA RID: 39866
		internal static int __PropertyOffset_AbilityHandle;

		// Token: 0x04009BBB RID: 39867
		[Nullable(2)]
		private FGameplayAbilitySpecHandle _AbilityHandle;

		// Token: 0x04009BBC RID: 39868
		internal static int __PropertyOffset_PredictionKeyAtCreation;
	}
}
