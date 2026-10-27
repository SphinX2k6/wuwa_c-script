using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001317 RID: 4887
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitMovementModeChange")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class UAbilityTask_WaitMovementModeChange : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012016 RID: 73750 RVA: 0x001A6F77 File Offset: 0x001A5177
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitMovementModeChange._ClassPtr;
		}

		// Token: 0x06012017 RID: 73751 RVA: 0x001A6F84 File Offset: 0x001A5184
		public UAbilityTask_WaitMovementModeChange() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitMovementModeChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012018 RID: 73752 RVA: 0x001A6FAC File Offset: 0x001A51AC
		[NullableContext(1)]
		public UAbilityTask_WaitMovementModeChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitMovementModeChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004641 RID: 17985
		// (get) Token: 0x06012019 RID: 73753 RVA: 0x001A6FE0 File Offset: 0x001A51E0
		// (set) Token: 0x0601201A RID: 73754 RVA: 0x001A7019 File Offset: 0x001A5219
		[Nullable(1)]
		public FMovementModeChangedDelegate OnChange
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovementModeChangedDelegate result;
				if ((result = this._OnChange) == null)
				{
					result = (this._OnChange = new FMovementModeChangedDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitMovementModeChange.__PropertyOffset_OnChange, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitMovementModeChange.__PropertyOffset_OnChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0601201B RID: 73755 RVA: 0x001A703A File Offset: 0x001A523A
		[NullableContext(2)]
		public void OnMovementModeChange(ACharacter Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			UAbilityTask_WaitMovementModeChange.__OnMovementModeChange_Internal(base.NativePtr, (Character != null) ? Character.NativePtr : IntPtr.Zero, PrevMovementMode, PreviousCustomMode);
		}

		// Token: 0x0601201C RID: 73756 RVA: 0x001A705E File Offset: 0x001A525E
		[NullableContext(2)]
		public static UAbilityTask_WaitMovementModeChange CreateWaitMovementModeChange(UGameplayAbility OwningAbility, EMovementMode NewMode)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitMovementModeChange>(UAbilityTask_WaitMovementModeChange.__CreateWaitMovementModeChange_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, NewMode));
		}

		// Token: 0x0601201D RID: 73757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMovementModeChange_Internal(IntPtr @this, IntPtr Character, TEnumAsByte<EMovementMode> PrevMovementMode, byte PreviousCustomMode);

		// Token: 0x0601201E RID: 73758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWaitMovementModeChange_Internal(IntPtr OwningAbility, TEnumAsByte<EMovementMode> NewMode);

		// Token: 0x0601201F RID: 73759 RVA: 0x001A7080 File Offset: 0x001A5280
		static UAbilityTask_WaitMovementModeChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitMovementModeChange");
		}

		// Token: 0x06012020 RID: 73760 RVA: 0x001A708E File Offset: 0x001A528E
		protected UAbilityTask_WaitMovementModeChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040099F1 RID: 39409
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitMovementModeChange";

		// Token: 0x040099F2 RID: 39410
		private static IntPtr _ClassPtr;

		// Token: 0x040099F3 RID: 39411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040099F4 RID: 39412
		internal static int __PropertyOffset_OnChange;

		// Token: 0x040099F5 RID: 39413
		[Nullable(2)]
		private FMovementModeChangedDelegate _OnChange;
	}
}
