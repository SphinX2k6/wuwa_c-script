using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BD RID: 1213
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class AKuroDestructibleActor : AActor, IUnrealUObject, IUnrealObject, IBulletHitActorInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06006FAA RID: 28586 RVA: 0x000A50F0 File Offset: 0x000A32F0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDestructibleActor._ClassPtr;
		}

		// Token: 0x06006FAB RID: 28587 RVA: 0x000A50FC File Offset: 0x000A32FC
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return AKuroDestructibleActor.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x06006FAC RID: 28588 RVA: 0x000A5104 File Offset: 0x000A3304
		public AKuroDestructibleActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDestructibleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006FAD RID: 28589 RVA: 0x000A512C File Offset: 0x000A332C
		[NullableContext(1)]
		public AKuroDestructibleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDestructibleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06006FAE RID: 28590 RVA: 0x000A515F File Offset: 0x000A335F
		// (set) Token: 0x06006FAF RID: 28591 RVA: 0x000A5173 File Offset: 0x000A3373
		public unsafe UKuroDestructibleAsset KuroDestructibleAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroDestructibleAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_KuroDestructibleAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_KuroDestructibleAsset, value);
			}
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06006FB0 RID: 28592 RVA: 0x000A5188 File Offset: 0x000A3388
		// (set) Token: 0x06006FB1 RID: 28593 RVA: 0x000A519C File Offset: 0x000A339C
		public unsafe UKuroDestructibleDestructionAsset KuroDestructibleDestructionAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroDestructibleDestructionAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_KuroDestructibleDestructionAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_KuroDestructibleDestructionAsset, value);
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06006FB2 RID: 28594 RVA: 0x000A51B1 File Offset: 0x000A33B1
		// (set) Token: 0x06006FB3 RID: 28595 RVA: 0x000A51C1 File Offset: 0x000A33C1
		public unsafe bool bUseDummyHurtOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_bUseDummyHurtOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_bUseDummyHurtOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06006FB4 RID: 28596 RVA: 0x000A51D2 File Offset: 0x000A33D2
		// (set) Token: 0x06006FB5 RID: 28597 RVA: 0x000A51E6 File Offset: 0x000A33E6
		public unsafe FVector DummyHurtOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_DummyHurtOrigin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_DummyHurtOrigin) = value;
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06006FB6 RID: 28598 RVA: 0x000A51FC File Offset: 0x000A33FC
		// (set) Token: 0x06006FB7 RID: 28599 RVA: 0x000A5235 File Offset: 0x000A3435
		[Nullable(1)]
		public FKuroDestructibleActorDelegateSignature TrunksInitializedDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleActorDelegateSignature result;
				if ((result = this._TrunksInitializedDelegate) == null)
				{
					result = (this._TrunksInitializedDelegate = new FKuroDestructibleActorDelegateSignature(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_TrunksInitializedDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_TrunksInitializedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170015C5 RID: 5573
		// (get) Token: 0x06006FB8 RID: 28600 RVA: 0x000A5258 File Offset: 0x000A3458
		// (set) Token: 0x06006FB9 RID: 28601 RVA: 0x000A5291 File Offset: 0x000A3491
		[Nullable(1)]
		public FKuroDestructibleActorDelegateSignature StartDestruction
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleActorDelegateSignature result;
				if ((result = this._StartDestruction) == null)
				{
					result = (this._StartDestruction = new FKuroDestructibleActorDelegateSignature(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_StartDestruction, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_StartDestruction, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170015C6 RID: 5574
		// (get) Token: 0x06006FBA RID: 28602 RVA: 0x000A52B4 File Offset: 0x000A34B4
		// (set) Token: 0x06006FBB RID: 28603 RVA: 0x000A52ED File Offset: 0x000A34ED
		[Nullable(1)]
		public FKuroDestructibleActorPlayEffectDelegateSignature PlayEffectPostInitialized
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleActorPlayEffectDelegateSignature result;
				if ((result = this._PlayEffectPostInitialized) == null)
				{
					result = (this._PlayEffectPostInitialized = new FKuroDestructibleActorPlayEffectDelegateSignature(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_PlayEffectPostInitialized, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_PlayEffectPostInitialized, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170015C7 RID: 5575
		// (get) Token: 0x06006FBC RID: 28604 RVA: 0x000A5310 File Offset: 0x000A3510
		// (set) Token: 0x06006FBD RID: 28605 RVA: 0x000A5349 File Offset: 0x000A3549
		[Nullable(1)]
		public FKuroDestructibleActorPlayEffectDelegateSignature PlayEffectWhenStartDestruction
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroDestructibleActorPlayEffectDelegateSignature result;
				if ((result = this._PlayEffectWhenStartDestruction) == null)
				{
					result = (this._PlayEffectWhenStartDestruction = new FKuroDestructibleActorPlayEffectDelegateSignature(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_PlayEffectWhenStartDestruction, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_PlayEffectWhenStartDestruction, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170015C8 RID: 5576
		// (get) Token: 0x06006FBE RID: 28606 RVA: 0x000A536C File Offset: 0x000A356C
		// (set) Token: 0x06006FBF RID: 28607 RVA: 0x000A53A5 File Offset: 0x000A35A5
		[Nullable(1)]
		public TArray<UStaticMeshComponent> StaticMeshChunkList
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._StaticMeshChunkList) == null)
				{
					result = (this._StaticMeshChunkList = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)AKuroDestructibleActor.__PropertyOffset_StaticMeshChunkList, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StaticMeshChunkList.CopyAssign(value);
			}
		}

		// Token: 0x170015C9 RID: 5577
		// (get) Token: 0x06006FC0 RID: 28608 RVA: 0x000A53B3 File Offset: 0x000A35B3
		// (set) Token: 0x06006FC1 RID: 28609 RVA: 0x000A53C7 File Offset: 0x000A35C7
		public unsafe UPoseableMeshComponent NewPoseableMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPoseableMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_NewPoseableMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_NewPoseableMeshComponent, value);
			}
		}

		// Token: 0x170015CA RID: 5578
		// (get) Token: 0x06006FC2 RID: 28610 RVA: 0x000A53DC File Offset: 0x000A35DC
		// (set) Token: 0x06006FC3 RID: 28611 RVA: 0x000A53F0 File Offset: 0x000A35F0
		public unsafe UStaticMeshComponent ProxyMeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_ProxyMeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroDestructibleActor.__PropertyOffset_ProxyMeshComponent, value);
			}
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x000A5405 File Offset: 0x000A3605
		public void ToggleTrunks()
		{
			AKuroDestructibleActor.__ToggleTrunks_Internal(base.NativePtr);
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x000A5412 File Offset: 0x000A3612
		public void ToggleProxyMesh()
		{
			AKuroDestructibleActor.__ToggleProxyMesh_Internal(base.NativePtr);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x000A541F File Offset: 0x000A361F
		public void TogglePoseableMesh()
		{
			AKuroDestructibleActor.__TogglePoseableMesh_Internal(base.NativePtr);
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x000A542C File Offset: 0x000A362C
		public void PreviewDestruction(bool bShowTrunks = true)
		{
			AKuroDestructibleActor.__PreviewDestruction_Internal(base.NativePtr, bShowTrunks);
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x000A543C File Offset: 0x000A363C
		public void OnProxyMeshHit(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult HitResult)
		{
			AKuroDestructibleActor.__OnProxyMeshHit_Internal(base.NativePtr, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, NormalImpulse, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x000A5498 File Offset: 0x000A3698
		public void OnProxyMeshBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			AKuroDestructibleActor.__OnProxyMeshBeginOverlap_Internal(base.NativePtr, (OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x000A54F5 File Offset: 0x000A36F5
		public void InsertToGamePartition()
		{
			AKuroDestructibleActor.__InsertToGamePartition_Internal(base.NativePtr);
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x000A5502 File Offset: 0x000A3702
		[NullableContext(1)]
		public TArray<UStaticMeshComponent> GetTrunks()
		{
			return new TArray<UStaticMeshComponent>(AKuroDestructibleActor.__GetTrunks_Internal(base.NativePtr), null);
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x000A5515 File Offset: 0x000A3715
		public UStaticMeshComponent GetProxyMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshComponent>(AKuroDestructibleActor.__GetProxyMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x06006FCD RID: 28621 RVA: 0x000A5527 File Offset: 0x000A3727
		public int GetGamePartitionObjectID()
		{
			return AKuroDestructibleActor.__GetGamePartitionObjectID_Internal(base.NativePtr);
		}

		// Token: 0x06006FCE RID: 28622 RVA: 0x000A5534 File Offset: 0x000A3734
		public void D_ApplyRadiusDamage(float BaseDamage, in FVectorDouble HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			AKuroDestructibleActor.__D_ApplyRadiusDamage_Internal(base.NativePtr, BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x000A5548 File Offset: 0x000A3748
		public static void D_ApplyDamageForActorsInRange(UObject WorldContextObject, in FVectorDouble HurtOrigin, double QuerySphereRadius, EGamePartitionCellSizeType GamePartitionCellSize = EGamePartitionCellSizeType.Default)
		{
			AKuroDestructibleActor.__D_ApplyDamageForActorsInRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HurtOrigin, QuerySphereRadius, GamePartitionCellSize);
		}

		// Token: 0x06006FD0 RID: 28624 RVA: 0x000A5562 File Offset: 0x000A3762
		public void D_ApplyDamage(float DamageAmount, in FVectorDouble HitLocation, in FVectorDouble ImpulseDir, float ImpulseStrength)
		{
			AKuroDestructibleActor.__D_ApplyDamage_Internal(base.NativePtr, DamageAmount, HitLocation, ImpulseDir, ImpulseStrength);
		}

		// Token: 0x06006FD1 RID: 28625 RVA: 0x000A5574 File Offset: 0x000A3774
		public void ApplyRadiusDamage(float BaseDamage, in FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			AKuroDestructibleActor.__ApplyRadiusDamage_Internal(base.NativePtr, BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage);
		}

		// Token: 0x06006FD2 RID: 28626 RVA: 0x000A5588 File Offset: 0x000A3788
		public void ApplyDamage(float DamageAmount, in FVector HitLocation, in FVector ImpulseDir, float ImpulseStrength)
		{
			AKuroDestructibleActor.__ApplyDamage_Internal(base.NativePtr, DamageAmount, HitLocation, ImpulseDir, ImpulseStrength);
		}

		// Token: 0x06006FD3 RID: 28627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleTrunks_Internal(IntPtr @this);

		// Token: 0x06006FD4 RID: 28628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleProxyMesh_Internal(IntPtr @this);

		// Token: 0x06006FD5 RID: 28629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TogglePoseableMesh_Internal(IntPtr @this);

		// Token: 0x06006FD6 RID: 28630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreviewDestruction_Internal(IntPtr @this, bool bShowTrunks);

		// Token: 0x06006FD7 RID: 28631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyMeshHit_Internal(IntPtr @this, IntPtr HitComponent, IntPtr OtherActor, IntPtr OtherComp, FVector NormalImpulse, IntPtr HitResult);

		// Token: 0x06006FD8 RID: 28632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyMeshBeginOverlap_Internal(IntPtr @this, IntPtr OverlappedComponent, IntPtr OtherActor, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06006FD9 RID: 28633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InsertToGamePartition_Internal(IntPtr @this);

		// Token: 0x06006FDA RID: 28634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrunks_Internal(IntPtr @this);

		// Token: 0x06006FDB RID: 28635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetProxyMeshComponent_Internal(IntPtr @this);

		// Token: 0x06006FDC RID: 28636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGamePartitionObjectID_Internal(IntPtr @this);

		// Token: 0x06006FDD RID: 28637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyRadiusDamage_Internal(IntPtr @this, float BaseDamage, in FVectorDouble HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage);

		// Token: 0x06006FDE RID: 28638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyDamageForActorsInRange_Internal(IntPtr WorldContextObject, in FVectorDouble HurtOrigin, double QuerySphereRadius, EGamePartitionCellSizeType GamePartitionCellSize);

		// Token: 0x06006FDF RID: 28639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyDamage_Internal(IntPtr @this, float DamageAmount, in FVectorDouble HitLocation, in FVectorDouble ImpulseDir, float ImpulseStrength);

		// Token: 0x06006FE0 RID: 28640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRadiusDamage_Internal(IntPtr @this, float BaseDamage, in FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage);

		// Token: 0x06006FE1 RID: 28641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDamage_Internal(IntPtr @this, float DamageAmount, in FVector HitLocation, in FVector ImpulseDir, float ImpulseStrength);

		// Token: 0x06006FE2 RID: 28642 RVA: 0x000A559A File Offset: 0x000A379A
		static AKuroDestructibleActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor");
		}

		// Token: 0x06006FE3 RID: 28643 RVA: 0x000A55A8 File Offset: 0x000A37A8
		protected AKuroDestructibleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400303B RID: 12347
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x0400303C RID: 12348
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor";

		// Token: 0x0400303D RID: 12349
		private static IntPtr _ClassPtr;

		// Token: 0x0400303E RID: 12350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400303F RID: 12351
		internal static int __PropertyOffset_KuroDestructibleAsset;

		// Token: 0x04003040 RID: 12352
		internal static int __PropertyOffset_KuroDestructibleDestructionAsset;

		// Token: 0x04003041 RID: 12353
		internal static int __PropertyOffset_bUseDummyHurtOrigin;

		// Token: 0x04003042 RID: 12354
		internal static int __PropertyOffset_DummyHurtOrigin;

		// Token: 0x04003043 RID: 12355
		internal static int __PropertyOffset_TrunksInitializedDelegate;

		// Token: 0x04003044 RID: 12356
		private FKuroDestructibleActorDelegateSignature _TrunksInitializedDelegate;

		// Token: 0x04003045 RID: 12357
		internal static int __PropertyOffset_StartDestruction;

		// Token: 0x04003046 RID: 12358
		private FKuroDestructibleActorDelegateSignature _StartDestruction;

		// Token: 0x04003047 RID: 12359
		internal static int __PropertyOffset_PlayEffectPostInitialized;

		// Token: 0x04003048 RID: 12360
		private FKuroDestructibleActorPlayEffectDelegateSignature _PlayEffectPostInitialized;

		// Token: 0x04003049 RID: 12361
		internal static int __PropertyOffset_PlayEffectWhenStartDestruction;

		// Token: 0x0400304A RID: 12362
		private FKuroDestructibleActorPlayEffectDelegateSignature _PlayEffectWhenStartDestruction;

		// Token: 0x0400304B RID: 12363
		internal static int __PropertyOffset_StaticMeshChunkList;

		// Token: 0x0400304C RID: 12364
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _StaticMeshChunkList;

		// Token: 0x0400304D RID: 12365
		internal static int __PropertyOffset_NewPoseableMeshComponent;

		// Token: 0x0400304E RID: 12366
		internal static int __PropertyOffset_ProxyMeshComponent;
	}
}
