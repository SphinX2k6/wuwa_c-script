using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001300 RID: 4864
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_StartAbilityState")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UAbilityTask_StartAbilityState : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F09 RID: 73481 RVA: 0x001A5213 File Offset: 0x001A3413
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_StartAbilityState._ClassPtr;
		}

		// Token: 0x06011F0A RID: 73482 RVA: 0x001A5220 File Offset: 0x001A3420
		public UAbilityTask_StartAbilityState() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_StartAbilityState.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F0B RID: 73483 RVA: 0x001A5248 File Offset: 0x001A3448
		public UAbilityTask_StartAbilityState(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_StartAbilityState.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004621 RID: 17953
		// (get) Token: 0x06011F0C RID: 73484 RVA: 0x001A527C File Offset: 0x001A347C
		// (set) Token: 0x06011F0D RID: 73485 RVA: 0x001A52B5 File Offset: 0x001A34B5
		public FAbilityStateDelegate OnStateEnded
		{
			get
			{
				base.FastCheckIsValid();
				FAbilityStateDelegate result;
				if ((result = this._OnStateEnded) == null)
				{
					result = (this._OnStateEnded = new FAbilityStateDelegate(base.NativePtr + (IntPtr)UAbilityTask_StartAbilityState.__PropertyOffset_OnStateEnded, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_StartAbilityState.__PropertyOffset_OnStateEnded, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004622 RID: 17954
		// (get) Token: 0x06011F0E RID: 73486 RVA: 0x001A52D8 File Offset: 0x001A34D8
		// (set) Token: 0x06011F0F RID: 73487 RVA: 0x001A5311 File Offset: 0x001A3511
		public FAbilityStateDelegate OnStateInterrupted
		{
			get
			{
				base.FastCheckIsValid();
				FAbilityStateDelegate result;
				if ((result = this._OnStateInterrupted) == null)
				{
					result = (this._OnStateInterrupted = new FAbilityStateDelegate(base.NativePtr + (IntPtr)UAbilityTask_StartAbilityState.__PropertyOffset_OnStateInterrupted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_StartAbilityState.__PropertyOffset_OnStateInterrupted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F10 RID: 73488 RVA: 0x001A5332 File Offset: 0x001A3532
		[NullableContext(2)]
		public static UAbilityTask_StartAbilityState StartAbilityState(UGameplayAbility OwningAbility, FName StateName, bool bEndCurrentState = true)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_StartAbilityState>(UAbilityTask_StartAbilityState.__StartAbilityState_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, StateName, bEndCurrentState));
		}

		// Token: 0x06011F11 RID: 73489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __StartAbilityState_Internal(IntPtr OwningAbility, FName StateName, bool bEndCurrentState);

		// Token: 0x06011F12 RID: 73490 RVA: 0x001A5350 File Offset: 0x001A3550
		static UAbilityTask_StartAbilityState()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_StartAbilityState");
		}

		// Token: 0x06011F13 RID: 73491 RVA: 0x001A535E File Offset: 0x001A355E
		protected UAbilityTask_StartAbilityState(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009973 RID: 39283
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_StartAbilityState";

		// Token: 0x04009974 RID: 39284
		private static IntPtr _ClassPtr;

		// Token: 0x04009975 RID: 39285
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009976 RID: 39286
		internal static int __PropertyOffset_OnStateEnded;

		// Token: 0x04009977 RID: 39287
		[Nullable(2)]
		private FAbilityStateDelegate _OnStateEnded;

		// Token: 0x04009978 RID: 39288
		internal static int __PropertyOffset_OnStateInterrupted;

		// Token: 0x04009979 RID: 39289
		[Nullable(2)]
		private FAbilityStateDelegate _OnStateInterrupted;
	}
}
