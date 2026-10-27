using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200130F RID: 4879
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectRemoved")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UAbilityTask_WaitGameplayEffectRemoved : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FC0 RID: 73664 RVA: 0x001A6672 File Offset: 0x001A4872
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectRemoved._ClassPtr;
		}

		// Token: 0x06011FC1 RID: 73665 RVA: 0x001A6680 File Offset: 0x001A4880
		public UAbilityTask_WaitGameplayEffectRemoved() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectRemoved.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FC2 RID: 73666 RVA: 0x001A66A8 File Offset: 0x001A48A8
		public UAbilityTask_WaitGameplayEffectRemoved(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectRemoved.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x06011FC3 RID: 73667 RVA: 0x001A66DC File Offset: 0x001A48DC
		// (set) Token: 0x06011FC4 RID: 73668 RVA: 0x001A6715 File Offset: 0x001A4915
		public FWaitGameplayEffectRemovedDelegate OnRemoved
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEffectRemovedDelegate result;
				if ((result = this._OnRemoved) == null)
				{
					result = (this._OnRemoved = new FWaitGameplayEffectRemovedDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectRemoved.__PropertyOffset_OnRemoved, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectRemoved.__PropertyOffset_OnRemoved, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x06011FC5 RID: 73669 RVA: 0x001A6738 File Offset: 0x001A4938
		// (set) Token: 0x06011FC6 RID: 73670 RVA: 0x001A6771 File Offset: 0x001A4971
		public FWaitGameplayEffectRemovedDelegate InvalidHandle
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEffectRemovedDelegate result;
				if ((result = this._InvalidHandle) == null)
				{
					result = (this._InvalidHandle = new FWaitGameplayEffectRemovedDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectRemoved.__PropertyOffset_InvalidHandle, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectRemoved.__PropertyOffset_InvalidHandle, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FC7 RID: 73671 RVA: 0x001A6792 File Offset: 0x001A4992
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectRemoved WaitForGameplayEffectRemoved(UGameplayAbility OwningAbility, FActiveGameplayEffectHandle Handle)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectRemoved>(UAbilityTask_WaitGameplayEffectRemoved.__WaitForGameplayEffectRemoved_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06011FC8 RID: 73672 RVA: 0x001A67BD File Offset: 0x001A49BD
		[NullableContext(2)]
		public void OnGameplayEffectRemoved(in FGameplayEffectRemovalInfo InGameplayEffectRemovalInfo)
		{
			UAbilityTask_WaitGameplayEffectRemoved.__OnGameplayEffectRemoved_Internal(base.NativePtr, (InGameplayEffectRemovalInfo ?? new FGameplayEffectRemovalInfo()).NativePtr);
		}

		// Token: 0x06011FC9 RID: 73673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForGameplayEffectRemoved_Internal(IntPtr OwningAbility, IntPtr Handle);

		// Token: 0x06011FCA RID: 73674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGameplayEffectRemoved_Internal(IntPtr @this, IntPtr InGameplayEffectRemovalInfo);

		// Token: 0x06011FCB RID: 73675 RVA: 0x001A67DA File Offset: 0x001A49DA
		static UAbilityTask_WaitGameplayEffectRemoved()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectRemoved");
		}

		// Token: 0x06011FCC RID: 73676 RVA: 0x001A67E8 File Offset: 0x001A49E8
		protected UAbilityTask_WaitGameplayEffectRemoved(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099C5 RID: 39365
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectRemoved";

		// Token: 0x040099C6 RID: 39366
		private static IntPtr _ClassPtr;

		// Token: 0x040099C7 RID: 39367
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099C8 RID: 39368
		internal static int __PropertyOffset_OnRemoved;

		// Token: 0x040099C9 RID: 39369
		[Nullable(2)]
		private FWaitGameplayEffectRemovedDelegate _OnRemoved;

		// Token: 0x040099CA RID: 39370
		internal static int __PropertyOffset_InvalidHandle;

		// Token: 0x040099CB RID: 39371
		[Nullable(2)]
		private FWaitGameplayEffectRemovedDelegate _InvalidHandle;
	}
}
