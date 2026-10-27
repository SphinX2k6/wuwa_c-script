using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012FF RID: 4863
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameplayAbilities.AbilityTask_SpawnActor")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UAbilityTask_SpawnActor : UAbilityTask, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06011EFA RID: 73466 RVA: 0x001A5013 File Offset: 0x001A3213
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbilityTask_SpawnActor._ClassPtr;
		}

		// Token: 0x06011EFB RID: 73467 RVA: 0x001A5020 File Offset: 0x001A3220
		public UAbilityTask_SpawnActor() : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_SpawnActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011EFC RID: 73468 RVA: 0x001A5048 File Offset: 0x001A3248
		public UAbilityTask_SpawnActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbilityTask_SpawnActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700461F RID: 17951
		// (get) Token: 0x06011EFD RID: 73469 RVA: 0x001A507C File Offset: 0x001A327C
		// (set) Token: 0x06011EFE RID: 73470 RVA: 0x001A50B5 File Offset: 0x001A32B5
		public FSpawnActorDelegate Success
		{
			get
			{
				base.FastCheckIsValid();
				FSpawnActorDelegate result;
				if ((result = this._Success) == null)
				{
					result = (this._Success = new FSpawnActorDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpawnActor.__PropertyOffset_Success, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpawnActor.__PropertyOffset_Success, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17004620 RID: 17952
		// (get) Token: 0x06011EFF RID: 73471 RVA: 0x001A50D8 File Offset: 0x001A32D8
		// (set) Token: 0x06011F00 RID: 73472 RVA: 0x001A5111 File Offset: 0x001A3311
		public FSpawnActorDelegate DidNotSpawn
		{
			get
			{
				base.FastCheckIsValid();
				FSpawnActorDelegate result;
				if ((result = this._DidNotSpawn) == null)
				{
					result = (this._DidNotSpawn = new FSpawnActorDelegate(base.NativePtr + (IntPtr)UAbilityTask_SpawnActor.__PropertyOffset_DidNotSpawn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAbilityTask_SpawnActor.__PropertyOffset_DidNotSpawn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06011F01 RID: 73473 RVA: 0x001A5132 File Offset: 0x001A3332
		[NullableContext(2)]
		public static UAbilityTask_SpawnActor SpawnActor(UGameplayAbility OwningAbility, FGameplayAbilityTargetDataHandle TargetData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAbilityTask_SpawnActor>(UAbilityTask_SpawnActor.__SpawnActor_Internal((OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Class._NativePtr));
		}

		// Token: 0x06011F02 RID: 73474 RVA: 0x001A5163 File Offset: 0x001A3363
		[NullableContext(2)]
		public void FinishSpawningActor(UGameplayAbility OwningAbility, FGameplayAbilityTargetDataHandle TargetData, AActor SpawnedActor)
		{
			UAbilityTask_SpawnActor.__FinishSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, (SpawnedActor != null) ? SpawnedActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06011F03 RID: 73475 RVA: 0x001A51A0 File Offset: 0x001A33A0
		[NullableContext(2)]
		public bool BeginSpawningActor(UGameplayAbility OwningAbility, FGameplayAbilityTargetDataHandle TargetData, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<AActor> Class, ref AActor SpawnedActor)
		{
			AActor aactor = SpawnedActor;
			IntPtr nativeObjectPtr = (aactor != null) ? aactor.NativePtr : IntPtr.Zero;
			bool result = UAbilityTask_SpawnActor.__BeginSpawningActor_Internal(base.NativePtr, (OwningAbility != null) ? OwningAbility.NativePtr : IntPtr.Zero, (TargetData ?? new FGameplayAbilityTargetDataHandle()).NativePtr, Class._NativePtr, ref nativeObjectPtr);
			SpawnedActor = BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(nativeObjectPtr);
			return result;
		}

		// Token: 0x06011F04 RID: 73476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SpawnActor_Internal(IntPtr OwningAbility, IntPtr TargetData, IntPtr Class);

		// Token: 0x06011F05 RID: 73477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FinishSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr TargetData, IntPtr SpawnedActor);

		// Token: 0x06011F06 RID: 73478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BeginSpawningActor_Internal(IntPtr @this, IntPtr OwningAbility, IntPtr TargetData, IntPtr Class, ref IntPtr SpawnedActor);

		// Token: 0x06011F07 RID: 73479 RVA: 0x001A51FC File Offset: 0x001A33FC
		static UAbilityTask_SpawnActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GameplayAbilities.AbilityTask_SpawnActor");
		}

		// Token: 0x06011F08 RID: 73480 RVA: 0x001A520A File Offset: 0x001A340A
		protected UAbilityTask_SpawnActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400996C RID: 39276
		public new const string __ObjectPath = "/Script/GameplayAbilities.AbilityTask_SpawnActor";

		// Token: 0x0400996D RID: 39277
		private static IntPtr _ClassPtr;

		// Token: 0x0400996E RID: 39278
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400996F RID: 39279
		internal static int __PropertyOffset_Success;

		// Token: 0x04009970 RID: 39280
		[Nullable(2)]
		private FSpawnActorDelegate _Success;

		// Token: 0x04009971 RID: 39281
		internal static int __PropertyOffset_DidNotSpawn;

		// Token: 0x04009972 RID: 39282
		[Nullable(2)]
		private FSpawnActorDelegate _DidNotSpawn;
	}
}
