using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001314 RID: 4884
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayTagRemoved")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_WaitGameplayTagRemoved : UAbilityTask_WaitGameplayTag, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FF7 RID: 73719 RVA: 0x001A6C67 File Offset: 0x001A4E67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayTagRemoved._ClassPtr;
		}

		// Token: 0x06011FF8 RID: 73720 RVA: 0x001A6C74 File Offset: 0x001A4E74
		public UAbilityTask_WaitGameplayTagRemoved() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTagRemoved.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FF9 RID: 73721 RVA: 0x001A6C9C File Offset: 0x001A4E9C
		public UAbilityTask_WaitGameplayTagRemoved(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTagRemoved.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463E RID: 17982
		// (get) Token: 0x06011FFA RID: 73722 RVA: 0x001A6CD0 File Offset: 0x001A4ED0
		// (set) Token: 0x06011FFB RID: 73723 RVA: 0x001A6D09 File Offset: 0x001A4F09
		public FWaitGameplayTagDelegate Removed
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayTagDelegate result;
				if ((result = this._Removed) == null)
				{
					result = (this._Removed = new FWaitGameplayTagDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayTagRemoved.__PropertyOffset_Removed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayTagRemoved.__PropertyOffset_Removed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FFC RID: 73724 RVA: 0x001A6D2A File Offset: 0x001A4F2A
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayTagRemoved WaitGameplayTagRemove(UGameplayAbility OwningAbility, FGameplayTag Tag, AActor InOptionalExternalTarget = null, bool OnlyTriggerOnce = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayTagRemoved>(UAbilityTask_WaitGameplayTagRemoved.__WaitGameplayTagRemove_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Tag, (InOptionalExternalTarget != null) ? InOptionalExternalTarget.NativePtr : IntPtr.Zero, OnlyTriggerOnce));
		}

		// Token: 0x06011FFD RID: 73725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayTagRemove_Internal(IntPtr OwningAbility, FGameplayTag Tag, IntPtr InOptionalExternalTarget, bool OnlyTriggerOnce);

		// Token: 0x06011FFE RID: 73726 RVA: 0x001A6D58 File Offset: 0x001A4F58
		static UAbilityTask_WaitGameplayTagRemoved()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayTagRemoved");
		}

		// Token: 0x06011FFF RID: 73727 RVA: 0x001A6D66 File Offset: 0x001A4F66
		protected UAbilityTask_WaitGameplayTagRemoved(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099E2 RID: 39394
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayTagRemoved";

		// Token: 0x040099E3 RID: 39395
		private static IntPtr _ClassPtr;

		// Token: 0x040099E4 RID: 39396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099E5 RID: 39397
		internal static int __PropertyOffset_Removed;

		// Token: 0x040099E6 RID: 39398
		[Nullable(2)]
		private FWaitGameplayTagDelegate _Removed;
	}
}
