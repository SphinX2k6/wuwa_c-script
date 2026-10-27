using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001313 RID: 4883
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayTagAdded")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_WaitGameplayTagAdded : UAbilityTask_WaitGameplayTag, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FEE RID: 73710 RVA: 0x001A6B5E File Offset: 0x001A4D5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayTagAdded._ClassPtr;
		}

		// Token: 0x06011FEF RID: 73711 RVA: 0x001A6B6C File Offset: 0x001A4D6C
		public UAbilityTask_WaitGameplayTagAdded() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTagAdded.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FF0 RID: 73712 RVA: 0x001A6B94 File Offset: 0x001A4D94
		public UAbilityTask_WaitGameplayTagAdded(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayTagAdded.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700463D RID: 17981
		// (get) Token: 0x06011FF1 RID: 73713 RVA: 0x001A6BC8 File Offset: 0x001A4DC8
		// (set) Token: 0x06011FF2 RID: 73714 RVA: 0x001A6C01 File Offset: 0x001A4E01
		public FWaitGameplayTagDelegate Added
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayTagDelegate result;
				if ((result = this._Added) == null)
				{
					result = (this._Added = new FWaitGameplayTagDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayTagAdded.__PropertyOffset_Added, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayTagAdded.__PropertyOffset_Added, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FF3 RID: 73715 RVA: 0x001A6C22 File Offset: 0x001A4E22
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayTagAdded WaitGameplayTagAdd(UGameplayAbility OwningAbility, FGameplayTag Tag, AActor InOptionalExternalTarget = null, bool OnlyTriggerOnce = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayTagAdded>(UAbilityTask_WaitGameplayTagAdded.__WaitGameplayTagAdd_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Tag, (InOptionalExternalTarget != null) ? InOptionalExternalTarget.NativePtr : IntPtr.Zero, OnlyTriggerOnce));
		}

		// Token: 0x06011FF4 RID: 73716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitGameplayTagAdd_Internal(IntPtr OwningAbility, FGameplayTag Tag, IntPtr InOptionalExternalTarget, bool OnlyTriggerOnce);

		// Token: 0x06011FF5 RID: 73717 RVA: 0x001A6C50 File Offset: 0x001A4E50
		static UAbilityTask_WaitGameplayTagAdded()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayTagAdded");
		}

		// Token: 0x06011FF6 RID: 73718 RVA: 0x001A6C5E File Offset: 0x001A4E5E
		protected UAbilityTask_WaitGameplayTagAdded(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099DD RID: 39389
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayTagAdded";

		// Token: 0x040099DE RID: 39390
		private static IntPtr _ClassPtr;

		// Token: 0x040099DF RID: 39391
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099E0 RID: 39392
		internal static int __PropertyOffset_Added;

		// Token: 0x040099E1 RID: 39393
		[Nullable(2)]
		private FWaitGameplayTagDelegate _Added;
	}
}
