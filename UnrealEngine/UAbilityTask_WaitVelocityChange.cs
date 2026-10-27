using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200131A RID: 4890
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_WaitVelocityChange")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UAbilityTask_WaitVelocityChange : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06012049 RID: 73801 RVA: 0x001A74AE File Offset: 0x001A56AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_WaitVelocityChange._ClassPtr;
		}

		// Token: 0x0601204A RID: 73802 RVA: 0x001A74BC File Offset: 0x001A56BC
		public UAbilityTask_WaitVelocityChange() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitVelocityChange.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601204B RID: 73803 RVA: 0x001A74E4 File Offset: 0x001A56E4
		public UAbilityTask_WaitVelocityChange(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_WaitVelocityChange.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004647 RID: 17991
		// (get) Token: 0x0601204C RID: 73804 RVA: 0x001A7518 File Offset: 0x001A5718
		// (set) Token: 0x0601204D RID: 73805 RVA: 0x001A7551 File Offset: 0x001A5751
		public FWaitVelocityChangeDelegate OnVelocityChage
		{
			get
			{
				base.FastCheckIsValid();
				FWaitVelocityChangeDelegate result;
				if ((result = this._OnVelocityChage) == null)
				{
					result = (this._OnVelocityChage = new FWaitVelocityChangeDelegate(base.NativePtr + (IntPtr)UAbilityTask_WaitVelocityChange.__PropertyOffset_OnVelocityChage, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_WaitVelocityChange.__PropertyOffset_OnVelocityChage, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004648 RID: 17992
		// (get) Token: 0x0601204E RID: 73806 RVA: 0x001A7572 File Offset: 0x001A5772
		// (set) Token: 0x0601204F RID: 73807 RVA: 0x001A7586 File Offset: 0x001A5786
		[Nullable(2)]
		public unsafe UMovementComponent CachedMovementComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitVelocityChange.__PropertyOffset_CachedMovementComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbilityTask_WaitVelocityChange.__PropertyOffset_CachedMovementComponent, value);
			}
		}

		// Token: 0x06012050 RID: 73808 RVA: 0x001A759B File Offset: 0x001A579B
		[NullableContext(2)]
		public static UAbilityTask_WaitVelocityChange CreateWaitVelocityChange(UGameplayAbility OwningAbility, FVector Direction, float MinimumMagnitude)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_WaitVelocityChange>(UAbilityTask_WaitVelocityChange.__CreateWaitVelocityChange_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Direction, MinimumMagnitude));
		}

		// Token: 0x06012051 RID: 73809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateWaitVelocityChange_Internal(IntPtr OwningAbility, FVector Direction, float MinimumMagnitude);

		// Token: 0x06012052 RID: 73810 RVA: 0x001A75B9 File Offset: 0x001A57B9
		static UAbilityTask_WaitVelocityChange()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_WaitVelocityChange");
		}

		// Token: 0x06012053 RID: 73811 RVA: 0x001A75C7 File Offset: 0x001A57C7
		protected UAbilityTask_WaitVelocityChange(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009A04 RID: 39428
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_WaitVelocityChange";

		// Token: 0x04009A05 RID: 39429
		private static IntPtr _ClassPtr;

		// Token: 0x04009A06 RID: 39430
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009A07 RID: 39431
		internal static int __PropertyOffset_OnVelocityChage;

		// Token: 0x04009A08 RID: 39432
		[Nullable(2)]
		private FWaitVelocityChangeDelegate _OnVelocityChage;

		// Token: 0x04009A09 RID: 39433
		internal static int __PropertyOffset_CachedMovementComponent;
	}
}
