using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001301 RID: 4865
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_VisualizeTargeting")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UAbilityTask_VisualizeTargeting : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011F14 RID: 73492 RVA: 0x001A5367 File Offset: 0x001A3567
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_VisualizeTargeting._ClassPtr;
		}

		// Token: 0x06011F15 RID: 73493 RVA: 0x001A5374 File Offset: 0x001A3574
		public UAbilityTask_VisualizeTargeting() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_VisualizeTargeting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011F16 RID: 73494 RVA: 0x001A539C File Offset: 0x001A359C
		public UAbilityTask_VisualizeTargeting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_VisualizeTargeting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004623 RID: 17955
		// (get) Token: 0x06011F17 RID: 73495 RVA: 0x001A53D0 File Offset: 0x001A35D0
		// (set) Token: 0x06011F18 RID: 73496 RVA: 0x001A5409 File Offset: 0x001A3609
		public FVisualizeTargetingDelegate TimeElapsed
		{
			get
			{
				base.FastCheckIsValid();
				FVisualizeTargetingDelegate result;
				if ((result = this._TimeElapsed) == null)
				{
					result = (this._TimeElapsed = new FVisualizeTargetingDelegate(base.NativePtr + (IntPtr)UAbilityTask_VisualizeTargeting.__PropertyOffset_TimeElapsed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_VisualizeTargeting.__PropertyOffset_TimeElapsed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F19 RID: 73497 RVA: 0x001A542A File Offset: 0x001A362A
		[NullableContext(2)]
		public static UAbilityTask_VisualizeTargeting VisualizeTargetingUsingActor(UGameplayAbility OwningAbility, AGameplayAbilityTargetActor TargetActor, FName TaskInstanceName, float Duration = -1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_VisualizeTargeting>(UAbilityTask_VisualizeTargeting.__VisualizeTargetingUsingActor_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TargetActor != null) ? TargetActor.NativePtr : IntPtr.Zero, TaskInstanceName, Duration));
		}

		// Token: 0x06011F1A RID: 73498 RVA: 0x001A5458 File Offset: 0x001A3658
		[NullableContext(2)]
		public static UAbilityTask_VisualizeTargeting VisualizeTargeting(UGameplayAbility OwningAbility, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AGameplayAbilityTargetActor> Class, FName TaskInstanceName, float Duration = -1f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_VisualizeTargeting>(UAbilityTask_VisualizeTargeting.__VisualizeTargeting_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Class._NativePtr, TaskInstanceName, Duration));
		}

		// Token: 0x06011F1B RID: 73499 RVA: 0x001A547C File Offset: 0x001A367C
		[NullableContext(2)]
		public void FinishSpawningActor(UGameplayAbility OwningAbility, AGameplayAbilityTargetActor SpawnedActor)
		{
			UAbilityTask_VisualizeTargeting.__FinishSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011F1C RID: 73500 RVA: 0x001A54AC File Offset: 0x001A36AC
		[NullableContext(2)]
		public bool BeginSpawningActor(UGameplayAbility OwningAbility, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AGameplayAbilityTargetActor> Class, ref AGameplayAbilityTargetActor SpawnedActor)
		{
			AGameplayAbilityTargetActor agameplayAbilityTargetActor = SpawnedActor;
			IntPtr nativeObjectPtr = (agameplayAbilityTargetActor != null) ? agameplayAbilityTargetActor.NativePtr : IntPtr.Zero;
			bool result = UAbilityTask_VisualizeTargeting.__BeginSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, Class._NativePtr, ref nativeObjectPtr);
			SpawnedActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AGameplayAbilityTargetActor>(nativeObjectPtr);
			return result;
		}

		// Token: 0x06011F1D RID: 73501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __VisualizeTargetingUsingActor_Internal(IntPtr OwningAbility, IntPtr TargetActor, FName TaskInstanceName, float Duration);

		// Token: 0x06011F1E RID: 73502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __VisualizeTargeting_Internal(IntPtr OwningAbility, IntPtr Class, FName TaskInstanceName, float Duration);

		// Token: 0x06011F1F RID: 73503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr SpawnedActor);

		// Token: 0x06011F20 RID: 73504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BeginSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr Class, ref IntPtr SpawnedActor);

		// Token: 0x06011F21 RID: 73505 RVA: 0x001A54F7 File Offset: 0x001A36F7
		static UAbilityTask_VisualizeTargeting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_VisualizeTargeting");
		}

		// Token: 0x06011F22 RID: 73506 RVA: 0x001A5505 File Offset: 0x001A3705
		protected UAbilityTask_VisualizeTargeting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400997A RID: 39290
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_VisualizeTargeting";

		// Token: 0x0400997B RID: 39291
		private static IntPtr _ClassPtr;

		// Token: 0x0400997C RID: 39292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400997D RID: 39293
		internal static int __PropertyOffset_TimeElapsed;

		// Token: 0x0400997E RID: 39294
		[Nullable(2)]
		private FVisualizeTargetingDelegate _TimeElapsed;
	}
}
