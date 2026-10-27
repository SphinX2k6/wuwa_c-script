using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001303 RID: 4867
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitAbilityCommit")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class UAbilityTask_WaitAbilityCommit : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F32 RID: 73522 RVA: 0x001A5681 File Offset: 0x001A3881
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitAbilityCommit._ClassPtr;
		}

		// Token: 0x06011F33 RID: 73523 RVA: 0x001A5690 File Offset: 0x001A3890
		public UAbilityTask_WaitAbilityCommit() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAbilityCommit.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F34 RID: 73524 RVA: 0x001A56B8 File Offset: 0x001A38B8
		public UAbilityTask_WaitAbilityCommit(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitAbilityCommit.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004625 RID: 17957
		// (get) Token: 0x06011F35 RID: 73525 RVA: 0x001A56EC File Offset: 0x001A38EC
		// (set) Token: 0x06011F36 RID: 73526 RVA: 0x001A5725 File Offset: 0x001A3925
		public FWaitAbilityCommitDelegate OnCommit
		{
			get
			{
				base.FastCheckIsValid();
				FWaitAbilityCommitDelegate result;
				if ((result = this._OnCommit) == null)
				{
					result = (this._OnCommit = new FWaitAbilityCommitDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitAbilityCommit.__PropertyOffset_OnCommit, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitAbilityCommit.__PropertyOffset_OnCommit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F37 RID: 73527 RVA: 0x001A5746 File Offset: 0x001A3946
		[NullableContext(2)]
		public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit_Query(UGameplayAbility OwningAbility, FGameplayTagQuery Query, bool TriggerOnce = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAbilityCommit>(UAbilityTask_WaitAbilityCommit.__WaitForAbilityCommit_Query_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Query ?? new FGameplayTagQuery()).NativePtr, TriggerOnce));
		}

		// Token: 0x06011F38 RID: 73528 RVA: 0x001A5772 File Offset: 0x001A3972
		[NullableContext(2)]
		public static UAbilityTask_WaitAbilityCommit WaitForAbilityCommit(UGameplayAbility OwningAbility, FGameplayTag WithTag, FGameplayTag WithoutTage, bool TriggerOnce = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitAbilityCommit>(UAbilityTask_WaitAbilityCommit.__WaitForAbilityCommit_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, WithTag, WithoutTage, TriggerOnce));
		}

		// Token: 0x06011F39 RID: 73529 RVA: 0x001A5791 File Offset: 0x001A3991
		[NullableContext(2)]
		public void OnAbilityCommit(UGameplayAbility ActivatedAbility)
		{
			UAbilityTask_WaitAbilityCommit.__OnAbilityCommit_Internal(base.NativePtr, (ActivatedAbility != null) ? ActivatedAbility.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011F3A RID: 73530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAbilityCommit_Query_Internal(IntPtr OwningAbility, IntPtr Query, bool TriggerOnce);

		// Token: 0x06011F3B RID: 73531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForAbilityCommit_Internal(IntPtr OwningAbility, FGameplayTag WithTag, FGameplayTag WithoutTage, bool TriggerOnce);

		// Token: 0x06011F3C RID: 73532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAbilityCommit_Internal(IntPtr @this, IntPtr ActivatedAbility);

		// Token: 0x06011F3D RID: 73533 RVA: 0x001A57AE File Offset: 0x001A39AE
		static UAbilityTask_WaitAbilityCommit()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitAbilityCommit");
		}

		// Token: 0x06011F3E RID: 73534 RVA: 0x001A57BC File Offset: 0x001A39BC
		protected UAbilityTask_WaitAbilityCommit(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009984 RID: 39300
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitAbilityCommit";

		// Token: 0x04009985 RID: 39301
		private static IntPtr _ClassPtr;

		// Token: 0x04009986 RID: 39302
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009987 RID: 39303
		internal static int __PropertyOffset_OnCommit;

		// Token: 0x04009988 RID: 39304
		[Nullable(2)]
		private FWaitAbilityCommitDelegate _OnCommit;
	}
}
