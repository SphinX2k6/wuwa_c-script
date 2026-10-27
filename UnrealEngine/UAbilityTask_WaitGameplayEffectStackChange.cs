using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001310 RID: 4880
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectStackChange")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_WaitGameplayEffectStackChange : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011FCD RID: 73677 RVA: 0x001A67F1 File Offset: 0x001A49F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitGameplayEffectStackChange._ClassPtr;
		}

		// Token: 0x06011FCE RID: 73678 RVA: 0x001A6800 File Offset: 0x001A4A00
		public UAbilityTask_WaitGameplayEffectStackChange() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectStackChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011FCF RID: 73679 RVA: 0x001A6828 File Offset: 0x001A4A28
		public UAbilityTask_WaitGameplayEffectStackChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitGameplayEffectStackChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004638 RID: 17976
		// (get) Token: 0x06011FD0 RID: 73680 RVA: 0x001A685C File Offset: 0x001A4A5C
		// (set) Token: 0x06011FD1 RID: 73681 RVA: 0x001A6895 File Offset: 0x001A4A95
		public FWaitGameplayEffectStackChangeDelegate OnChange
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEffectStackChangeDelegate result;
				if ((result = this._OnChange) == null)
				{
					result = (this._OnChange = new FWaitGameplayEffectStackChangeDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectStackChange.__PropertyOffset_OnChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectStackChange.__PropertyOffset_OnChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004639 RID: 17977
		// (get) Token: 0x06011FD2 RID: 73682 RVA: 0x001A68B8 File Offset: 0x001A4AB8
		// (set) Token: 0x06011FD3 RID: 73683 RVA: 0x001A68F1 File Offset: 0x001A4AF1
		public FWaitGameplayEffectStackChangeDelegate InvalidHandle
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEffectStackChangeDelegate result;
				if ((result = this._InvalidHandle) == null)
				{
					result = (this._InvalidHandle = new FWaitGameplayEffectStackChangeDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectStackChange.__PropertyOffset_InvalidHandle, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitGameplayEffectStackChange.__PropertyOffset_InvalidHandle, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011FD4 RID: 73684 RVA: 0x001A6912 File Offset: 0x001A4B12
		[NullableContext(2)]
		public static UAbilityTask_WaitGameplayEffectStackChange WaitForGameplayEffectStackChange(UGameplayAbility OwningAbility, FActiveGameplayEffectHandle Handle)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitGameplayEffectStackChange>(UAbilityTask_WaitGameplayEffectStackChange.__WaitForGameplayEffectStackChange_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr));
		}

		// Token: 0x06011FD5 RID: 73685 RVA: 0x001A693D File Offset: 0x001A4B3D
		[NullableContext(2)]
		public void OnGameplayEffectStackChange(FActiveGameplayEffectHandle Handle, int NewCount, int OldCount, bool bPremature)
		{
			UAbilityTask_WaitGameplayEffectStackChange.__OnGameplayEffectStackChange_Internal(base.NativePtr, (Handle ?? new FActiveGameplayEffectHandle()).NativePtr, NewCount, OldCount, bPremature);
		}

		// Token: 0x06011FD6 RID: 73686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __WaitForGameplayEffectStackChange_Internal(IntPtr OwningAbility, IntPtr Handle);

		// Token: 0x06011FD7 RID: 73687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnGameplayEffectStackChange_Internal(IntPtr @this, IntPtr Handle, int NewCount, int OldCount, bool bPremature);

		// Token: 0x06011FD8 RID: 73688 RVA: 0x001A695D File Offset: 0x001A4B5D
		static UAbilityTask_WaitGameplayEffectStackChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectStackChange");
		}

		// Token: 0x06011FD9 RID: 73689 RVA: 0x001A696B File Offset: 0x001A4B6B
		protected UAbilityTask_WaitGameplayEffectStackChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099CC RID: 39372
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitGameplayEffectStackChange";

		// Token: 0x040099CD RID: 39373
		private static IntPtr _ClassPtr;

		// Token: 0x040099CE RID: 39374
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099CF RID: 39375
		internal static int __PropertyOffset_OnChange;

		// Token: 0x040099D0 RID: 39376
		[Nullable(2)]
		private FWaitGameplayEffectStackChangeDelegate _OnChange;

		// Token: 0x040099D1 RID: 39377
		internal static int __PropertyOffset_InvalidHandle;

		// Token: 0x040099D2 RID: 39378
		[Nullable(2)]
		private FWaitGameplayEffectStackChangeDelegate _InvalidHandle;
	}
}
