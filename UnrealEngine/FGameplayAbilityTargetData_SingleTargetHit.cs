using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001362 RID: 4962
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.GameplayAbilityTargetData_SingleTargetHit")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FGameplayAbilityTargetData_SingleTargetHit : FGameplayAbilityTargetData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012327 RID: 74535 RVA: 0x001AB782 File Offset: 0x001A9982
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGameplayAbilityTargetData_SingleTargetHit._ScriptStructPtr != 0) ? FGameplayAbilityTargetData_SingleTargetHit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameplayAbilities.GameplayAbilityTargetData_SingleTargetHit", ref FGameplayAbilityTargetData_SingleTargetHit._ScriptStructPtr);
		}

		// Token: 0x170046DF RID: 18143
		// (get) Token: 0x06012328 RID: 74536 RVA: 0x001AB7A8 File Offset: 0x001A99A8
		// (set) Token: 0x06012329 RID: 74537 RVA: 0x001AB7EB File Offset: 0x001A99EB
		public FHitResult HitResult
		{
			get
			{
				base.FastCheckIsValid();
				FHitResult result;
				if ((result = this._HitResult) == null)
				{
					result = (this._HitResult = new FHitResult(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_SingleTargetHit.__PropertyOffset_HitResult, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHitResult.StaticStruct(), base.NativePtr + (IntPtr)FGameplayAbilityTargetData_SingleTargetHit.__PropertyOffset_HitResult, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170046E0 RID: 18144
		// (get) Token: 0x0601232A RID: 74538 RVA: 0x001AB80C File Offset: 0x001A9A0C
		// (set) Token: 0x0601232B RID: 74539 RVA: 0x001AB81C File Offset: 0x001A9A1C
		public unsafe bool bHitReplaced
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_SingleTargetHit.__PropertyOffset_bHitReplaced) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGameplayAbilityTargetData_SingleTargetHit.__PropertyOffset_bHitReplaced) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601232C RID: 74540 RVA: 0x001AB82D File Offset: 0x001A9A2D
		public FGameplayAbilityTargetData_SingleTargetHit()
		{
		}

		// Token: 0x0601232D RID: 74541 RVA: 0x001AB835 File Offset: 0x001A9A35
		public FGameplayAbilityTargetData_SingleTargetHit(FHitResult HitResult, bool bHitReplaced)
		{
			this.HitResult = HitResult;
			this.bHitReplaced = bHitReplaced;
		}

		// Token: 0x0601232E RID: 74542 RVA: 0x001AB84B File Offset: 0x001A9A4B
		protected override IntPtr GetUStructPtr()
		{
			return FGameplayAbilityTargetData_SingleTargetHit.StaticStruct();
		}

		// Token: 0x0601232F RID: 74543 RVA: 0x001AB857 File Offset: 0x001A9A57
		[NullableContext(2)]
		public FGameplayAbilityTargetData_SingleTargetHit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012330 RID: 74544 RVA: 0x001AB861 File Offset: 0x001A9A61
		public FGameplayAbilityTargetData_SingleTargetHit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012331 RID: 74545 RVA: 0x001AB86C File Offset: 0x001A9A6C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGameplayAbilityTargetData_SingleTargetHit(Pointer, false, true);
		}

		// Token: 0x06012332 RID: 74546 RVA: 0x001AB876 File Offset: 0x001A9A76
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGameplayAbilityTargetData_SingleTargetHit(Pointer, MemoryOwner);
		}

		// Token: 0x04009BF6 RID: 39926
		public new const string __ObjectPath = "/Script/GameplayAbilities.GameplayAbilityTargetData_SingleTargetHit";

		// Token: 0x04009BF7 RID: 39927
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009BF8 RID: 39928
		internal static int __PropertyOffset_HitResult;

		// Token: 0x04009BF9 RID: 39929
		[Nullable(2)]
		private FHitResult _HitResult;

		// Token: 0x04009BFA RID: 39930
		internal static int __PropertyOffset_bHitReplaced;
	}
}
