using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ADF RID: 6879
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class AKuroDestructibleActor : AActor, IUnrealUObject, IUnrealObject, IDestructibleInterface, IUnrealNativeInterface, IUnrealInterface, IBulletHitActorInterface, IGamePartitionInterface
	{
		// Token: 0x06019A08 RID: 104968 RVA: 0x0025DFC2 File Offset: 0x0025C1C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroDestructibleActor._ClassPtr;
		}

		// Token: 0x06019A09 RID: 104969 RVA: 0x0025DFCE File Offset: 0x0025C1CE
		int IDestructibleInterface.InterfaceOffset()
		{
			return AKuroDestructibleActor.__InterfaceOffset_IDestructibleInterface;
		}

		// Token: 0x06019A0A RID: 104970 RVA: 0x0025DFD5 File Offset: 0x0025C1D5
		int IBulletHitActorInterface.InterfaceOffset()
		{
			return AKuroDestructibleActor.__InterfaceOffset_IBulletHitActorInterface;
		}

		// Token: 0x06019A0B RID: 104971 RVA: 0x0025DFDC File Offset: 0x0025C1DC
		int IGamePartitionInterface.InterfaceOffset()
		{
			return AKuroDestructibleActor.__InterfaceOffset_IGamePartitionInterface;
		}

		// Token: 0x06019A0C RID: 104972 RVA: 0x0025DFE4 File Offset: 0x0025C1E4
		public AKuroDestructibleActor() : this(BuiltinUtils.AllocNativeUObject(AKuroDestructibleActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019A0D RID: 104973 RVA: 0x0025E00C File Offset: 0x0025C20C
		[NullableContext(1)]
		public AKuroDestructibleActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroDestructibleActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006659 RID: 26201
		// (get) Token: 0x06019A0E RID: 104974 RVA: 0x0025E03F File Offset: 0x0025C23F
		// (set) Token: 0x06019A0F RID: 104975 RVA: 0x0025E053 File Offset: 0x0025C253
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

		// Token: 0x1700665A RID: 26202
		// (get) Token: 0x06019A10 RID: 104976 RVA: 0x0025E068 File Offset: 0x0025C268
		// (set) Token: 0x06019A11 RID: 104977 RVA: 0x0025E07C File Offset: 0x0025C27C
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

		// Token: 0x1700665B RID: 26203
		// (get) Token: 0x06019A12 RID: 104978 RVA: 0x0025E091 File Offset: 0x0025C291
		// (set) Token: 0x06019A13 RID: 104979 RVA: 0x0025E0A1 File Offset: 0x0025C2A1
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

		// Token: 0x1700665C RID: 26204
		// (get) Token: 0x06019A14 RID: 104980 RVA: 0x0025E0B2 File Offset: 0x0025C2B2
		// (set) Token: 0x06019A15 RID: 104981 RVA: 0x0025E0C6 File Offset: 0x0025C2C6
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

		// Token: 0x1700665D RID: 26205
		// (get) Token: 0x06019A16 RID: 104982 RVA: 0x0025E0DC File Offset: 0x0025C2DC
		// (set) Token: 0x06019A17 RID: 104983 RVA: 0x0025E115 File Offset: 0x0025C315
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

		// Token: 0x1700665E RID: 26206
		// (get) Token: 0x06019A18 RID: 104984 RVA: 0x0025E138 File Offset: 0x0025C338
		// (set) Token: 0x06019A19 RID: 104985 RVA: 0x0025E171 File Offset: 0x0025C371
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

		// Token: 0x1700665F RID: 26207
		// (get) Token: 0x06019A1A RID: 104986 RVA: 0x0025E194 File Offset: 0x0025C394
		// (set) Token: 0x06019A1B RID: 104987 RVA: 0x0025E1CD File Offset: 0x0025C3CD
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

		// Token: 0x17006660 RID: 26208
		// (get) Token: 0x06019A1C RID: 104988 RVA: 0x0025E1F0 File Offset: 0x0025C3F0
		// (set) Token: 0x06019A1D RID: 104989 RVA: 0x0025E229 File Offset: 0x0025C429
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

		// Token: 0x17006661 RID: 26209
		// (get) Token: 0x06019A1E RID: 104990 RVA: 0x0025E24C File Offset: 0x0025C44C
		// (set) Token: 0x06019A1F RID: 104991 RVA: 0x0025E285 File Offset: 0x0025C485
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

		// Token: 0x17006662 RID: 26210
		// (get) Token: 0x06019A20 RID: 104992 RVA: 0x0025E293 File Offset: 0x0025C493
		// (set) Token: 0x06019A21 RID: 104993 RVA: 0x0025E2A7 File Offset: 0x0025C4A7
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

		// Token: 0x17006663 RID: 26211
		// (get) Token: 0x06019A22 RID: 104994 RVA: 0x0025E2BC File Offset: 0x0025C4BC
		// (set) Token: 0x06019A23 RID: 104995 RVA: 0x0025E2D0 File Offset: 0x0025C4D0
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

		// Token: 0x06019A24 RID: 104996 RVA: 0x0025E2E5 File Offset: 0x0025C4E5
		public void ToggleTrunks()
		{
			AKuroDestructibleActor.__ToggleTrunks_Internal(base.NativePtr);
		}

		// Token: 0x06019A25 RID: 104997 RVA: 0x0025E2F2 File Offset: 0x0025C4F2
		public void ToggleProxyMesh()
		{
			AKuroDestructibleActor.__ToggleProxyMesh_Internal(base.NativePtr);
		}

		// Token: 0x06019A26 RID: 104998 RVA: 0x0025E2FF File Offset: 0x0025C4FF
		public void TogglePoseableMesh()
		{
			AKuroDestructibleActor.__TogglePoseableMesh_Internal(base.NativePtr);
		}

		// Token: 0x06019A27 RID: 104999 RVA: 0x0025E30C File Offset: 0x0025C50C
		public void PreviewDestruction(bool bShowTrunks = true)
		{
			AKuroDestructibleActor.__PreviewDestruction_Internal(base.NativePtr, bShowTrunks);
		}

		// Token: 0x06019A28 RID: 105000 RVA: 0x0025E31C File Offset: 0x0025C51C
		public void OnProxyMeshHit(UPrimitiveComponent HitComponent, AActor OtherActor, UPrimitiveComponent OtherComp, FVector NormalImpulse, in FHitResult HitResult)
		{
			AKuroDestructibleActor.__OnProxyMeshHit_Internal(base.NativePtr, (HitComponent != null) ? HitComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, NormalImpulse, (HitResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06019A29 RID: 105001 RVA: 0x0025E378 File Offset: 0x0025C578
		public void OnProxyMeshBeginOverlap(UPrimitiveComponent OverlappedComponent, AActor OtherActor, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			AKuroDestructibleActor.__OnProxyMeshBeginOverlap_Internal(base.NativePtr, (OverlappedComponent != null) ? OverlappedComponent.NativePtr : IntPtr.Zero, (OtherActor != null) ? OtherActor.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06019A2A RID: 105002 RVA: 0x0025E3D5 File Offset: 0x0025C5D5
		public void InsertToGamePartition()
		{
			AKuroDestructibleActor.__InsertToGamePartition_Internal(base.NativePtr);
		}

		// Token: 0x06019A2B RID: 105003 RVA: 0x0025E3E2 File Offset: 0x0025C5E2
		[NullableContext(1)]
		public TArray<UStaticMeshComponent> GetTrunks()
		{
			return new TArray<UStaticMeshComponent>(AKuroDestructibleActor.__GetTrunks_Internal(base.NativePtr), null);
		}

		// Token: 0x06019A2C RID: 105004 RVA: 0x0025E3F5 File Offset: 0x0025C5F5
		public UStaticMeshComponent GetProxyMeshComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UStaticMeshComponent>(AKuroDestructibleActor.__GetProxyMeshComponent_Internal(base.NativePtr));
		}

		// Token: 0x06019A2D RID: 105005 RVA: 0x0025E407 File Offset: 0x0025C607
		public int GetGamePartitionObjectID()
		{
			return AKuroDestructibleActor.__GetGamePartitionObjectID_Internal(base.NativePtr);
		}

		// Token: 0x06019A2E RID: 105006 RVA: 0x0025E414 File Offset: 0x0025C614
		public void D_ApplyRadiusDamage(float BaseDamage, in FVectorDouble HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			AKuroDestructibleActor.__D_ApplyRadiusDamage_Internal(base.NativePtr, BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage);
		}

		// Token: 0x06019A2F RID: 105007 RVA: 0x0025E428 File Offset: 0x0025C628
		public static void D_ApplyDamageForActorsInRange(UObject WorldContextObject, in FVectorDouble HurtOrigin, double QuerySphereRadius, EGamePartitionCellSizeType GamePartitionCellSize = EGamePartitionCellSizeType.Default)
		{
			AKuroDestructibleActor.__D_ApplyDamageForActorsInRange_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, HurtOrigin, QuerySphereRadius, GamePartitionCellSize);
		}

		// Token: 0x06019A30 RID: 105008 RVA: 0x0025E442 File Offset: 0x0025C642
		public void D_ApplyDamage(float DamageAmount, in FVectorDouble HitLocation, in FVectorDouble ImpulseDir, float ImpulseStrength)
		{
			AKuroDestructibleActor.__D_ApplyDamage_Internal(base.NativePtr, DamageAmount, HitLocation, ImpulseDir, ImpulseStrength);
		}

		// Token: 0x06019A31 RID: 105009 RVA: 0x0025E454 File Offset: 0x0025C654
		public void ApplyRadiusDamage(float BaseDamage, in FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage)
		{
			AKuroDestructibleActor.__ApplyRadiusDamage_Internal(base.NativePtr, BaseDamage, HurtOrigin, DamageRadius, ImpulseStrength, bFullDamage);
		}

		// Token: 0x06019A32 RID: 105010 RVA: 0x0025E468 File Offset: 0x0025C668
		public void ApplyDamage(float DamageAmount, in FVector HitLocation, in FVector ImpulseDir, float ImpulseStrength)
		{
			AKuroDestructibleActor.__ApplyDamage_Internal(base.NativePtr, DamageAmount, HitLocation, ImpulseDir, ImpulseStrength);
		}

		// Token: 0x06019A33 RID: 105011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleTrunks_Internal(IntPtr @this);

		// Token: 0x06019A34 RID: 105012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ToggleProxyMesh_Internal(IntPtr @this);

		// Token: 0x06019A35 RID: 105013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TogglePoseableMesh_Internal(IntPtr @this);

		// Token: 0x06019A36 RID: 105014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreviewDestruction_Internal(IntPtr @this, bool bShowTrunks);

		// Token: 0x06019A37 RID: 105015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyMeshHit_Internal(IntPtr @this, IntPtr HitComponent, IntPtr OtherActor, IntPtr OtherComp, FVector NormalImpulse, IntPtr HitResult);

		// Token: 0x06019A38 RID: 105016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnProxyMeshBeginOverlap_Internal(IntPtr @this, IntPtr OverlappedComponent, IntPtr OtherActor, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06019A39 RID: 105017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InsertToGamePartition_Internal(IntPtr @this);

		// Token: 0x06019A3A RID: 105018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrunks_Internal(IntPtr @this);

		// Token: 0x06019A3B RID: 105019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetProxyMeshComponent_Internal(IntPtr @this);

		// Token: 0x06019A3C RID: 105020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGamePartitionObjectID_Internal(IntPtr @this);

		// Token: 0x06019A3D RID: 105021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyRadiusDamage_Internal(IntPtr @this, float BaseDamage, in FVectorDouble HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage);

		// Token: 0x06019A3E RID: 105022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyDamageForActorsInRange_Internal(IntPtr WorldContextObject, in FVectorDouble HurtOrigin, double QuerySphereRadius, EGamePartitionCellSizeType GamePartitionCellSize);

		// Token: 0x06019A3F RID: 105023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_ApplyDamage_Internal(IntPtr @this, float DamageAmount, in FVectorDouble HitLocation, in FVectorDouble ImpulseDir, float ImpulseStrength);

		// Token: 0x06019A40 RID: 105024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyRadiusDamage_Internal(IntPtr @this, float BaseDamage, in FVector HurtOrigin, float DamageRadius, float ImpulseStrength, bool bFullDamage);

		// Token: 0x06019A41 RID: 105025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyDamage_Internal(IntPtr @this, float DamageAmount, in FVector HitLocation, in FVector ImpulseDir, float ImpulseStrength);

		// Token: 0x06019A42 RID: 105026 RVA: 0x0025E47A File Offset: 0x0025C67A
		static AKuroDestructibleActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor");
		}

		// Token: 0x06019A43 RID: 105027 RVA: 0x0025E488 File Offset: 0x0025C688
		protected AKuroDestructibleActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DF1F RID: 57119
		internal static int __InterfaceOffset_IDestructibleInterface;

		// Token: 0x0400DF20 RID: 57120
		internal static int __InterfaceOffset_IBulletHitActorInterface;

		// Token: 0x0400DF21 RID: 57121
		internal static int __InterfaceOffset_IGamePartitionInterface;

		// Token: 0x0400DF22 RID: 57122
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroDestructibleActor";

		// Token: 0x0400DF23 RID: 57123
		private static IntPtr _ClassPtr;

		// Token: 0x0400DF24 RID: 57124
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DF25 RID: 57125
		internal static int __PropertyOffset_KuroDestructibleAsset;

		// Token: 0x0400DF26 RID: 57126
		internal static int __PropertyOffset_KuroDestructibleDestructionAsset;

		// Token: 0x0400DF27 RID: 57127
		internal static int __PropertyOffset_bUseDummyHurtOrigin;

		// Token: 0x0400DF28 RID: 57128
		internal static int __PropertyOffset_DummyHurtOrigin;

		// Token: 0x0400DF29 RID: 57129
		internal static int __PropertyOffset_TrunksInitializedDelegate;

		// Token: 0x0400DF2A RID: 57130
		private FKuroDestructibleActorDelegateSignature _TrunksInitializedDelegate;

		// Token: 0x0400DF2B RID: 57131
		internal static int __PropertyOffset_StartDestruction;

		// Token: 0x0400DF2C RID: 57132
		private FKuroDestructibleActorDelegateSignature _StartDestruction;

		// Token: 0x0400DF2D RID: 57133
		internal static int __PropertyOffset_PlayEffectPostInitialized;

		// Token: 0x0400DF2E RID: 57134
		private FKuroDestructibleActorPlayEffectDelegateSignature _PlayEffectPostInitialized;

		// Token: 0x0400DF2F RID: 57135
		internal static int __PropertyOffset_PlayEffectWhenStartDestruction;

		// Token: 0x0400DF30 RID: 57136
		private FKuroDestructibleActorPlayEffectDelegateSignature _PlayEffectWhenStartDestruction;

		// Token: 0x0400DF31 RID: 57137
		internal static int __PropertyOffset_StaticMeshChunkList;

		// Token: 0x0400DF32 RID: 57138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _StaticMeshChunkList;

		// Token: 0x0400DF33 RID: 57139
		internal static int __PropertyOffset_NewPoseableMeshComponent;

		// Token: 0x0400DF34 RID: 57140
		internal static int __PropertyOffset_ProxyMeshComponent;
	}
}
