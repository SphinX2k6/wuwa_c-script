using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003F4 RID: 1012
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlaySubsystem")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKuroLevelPlaySubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006382 RID: 25474 RVA: 0x0008E434 File Offset: 0x0008C634
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlaySubsystem._ClassPtr;
		}

		// Token: 0x06006383 RID: 25475 RVA: 0x0008E440 File Offset: 0x0008C640
		public UKuroLevelPlaySubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006384 RID: 25476 RVA: 0x0008E468 File Offset: 0x0008C668
		public UKuroLevelPlaySubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x06006385 RID: 25477 RVA: 0x0008E49C File Offset: 0x0008C69C
		// (set) Token: 0x06006386 RID: 25478 RVA: 0x0008E4D5 File Offset: 0x0008C6D5
		public FSpecificTagActorHitSignature OnSpecificTagActorHit
		{
			get
			{
				base.FastCheckIsValid();
				FSpecificTagActorHitSignature result;
				if ((result = this._OnSpecificTagActorHit) == null)
				{
					result = (this._OnSpecificTagActorHit = new FSpecificTagActorHitSignature(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagActorHit, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagActorHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x06006387 RID: 25479 RVA: 0x0008E4F8 File Offset: 0x0008C6F8
		// (set) Token: 0x06006388 RID: 25480 RVA: 0x0008E531 File Offset: 0x0008C731
		public FSpecificTagActorBeginOverlapSignature OnSpecificTagActorBeginOverlap
		{
			get
			{
				base.FastCheckIsValid();
				FSpecificTagActorBeginOverlapSignature result;
				if ((result = this._OnSpecificTagActorBeginOverlap) == null)
				{
					result = (this._OnSpecificTagActorBeginOverlap = new FSpecificTagActorBeginOverlapSignature(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagActorBeginOverlap, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagActorBeginOverlap, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06006389 RID: 25481 RVA: 0x0008E554 File Offset: 0x0008C754
		// (set) Token: 0x0600638A RID: 25482 RVA: 0x0008E58D File Offset: 0x0008C78D
		public FSpecificTagRelaySignature OnSpecificTagObjectStartRelayCollisionEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSpecificTagRelaySignature result;
				if ((result = this._OnSpecificTagObjectStartRelayCollisionEvent) == null)
				{
					result = (this._OnSpecificTagObjectStartRelayCollisionEvent = new FSpecificTagRelaySignature(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagObjectStartRelayCollisionEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagObjectStartRelayCollisionEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x0600638B RID: 25483 RVA: 0x0008E5B0 File Offset: 0x0008C7B0
		// (set) Token: 0x0600638C RID: 25484 RVA: 0x0008E5E9 File Offset: 0x0008C7E9
		public FSpecificTagRelaySignature OnSpecificTagObjectEndRelayCollisionEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSpecificTagRelaySignature result;
				if ((result = this._OnSpecificTagObjectEndRelayCollisionEvent) == null)
				{
					result = (this._OnSpecificTagObjectEndRelayCollisionEvent = new FSpecificTagRelaySignature(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagObjectEndRelayCollisionEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnSpecificTagObjectEndRelayCollisionEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600638D RID: 25485 RVA: 0x0008E60C File Offset: 0x0008C80C
		// (set) Token: 0x0600638E RID: 25486 RVA: 0x0008E645 File Offset: 0x0008C845
		public FLoopTeleportVolumeRegisteredSignature OnLoopTeleportVolumeRegistered
		{
			get
			{
				base.FastCheckIsValid();
				FLoopTeleportVolumeRegisteredSignature result;
				if ((result = this._OnLoopTeleportVolumeRegistered) == null)
				{
					result = (this._OnLoopTeleportVolumeRegistered = new FLoopTeleportVolumeRegisteredSignature(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnLoopTeleportVolumeRegistered, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_OnLoopTeleportVolumeRegistered, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600638F RID: 25487 RVA: 0x0008E668 File Offset: 0x0008C868
		// (set) Token: 0x06006390 RID: 25488 RVA: 0x0008E6A1 File Offset: 0x0008C8A1
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TSet<TWeakObjectPtr<UObject>> ManagedObjects
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TSet<TWeakObjectPtr<UObject>> result;
				if ((result = this._ManagedObjects) == null)
				{
					result = (this._ManagedObjects = new TSet<TWeakObjectPtr<UObject>>(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_ManagedObjects, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ManagedObjects.CopyAssign(value);
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06006391 RID: 25489 RVA: 0x0008E6B0 File Offset: 0x0008C8B0
		// (set) Token: 0x06006392 RID: 25490 RVA: 0x0008E6E9 File Offset: 0x0008C8E9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AKuroLoopTeleportVolume>> LoopTeleportVolumes
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AKuroLoopTeleportVolume>> result;
				if ((result = this._LoopTeleportVolumes) == null)
				{
					result = (this._LoopTeleportVolumes = new TArray<TWeakObjectPtr<AKuroLoopTeleportVolume>>(base.NativePtr + (IntPtr)UKuroLevelPlaySubsystem.__PropertyOffset_LoopTeleportVolumes, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.LoopTeleportVolumes.CopyAssign(value);
			}
		}

		// Token: 0x06006393 RID: 25491 RVA: 0x0008E6F7 File Offset: 0x0008C8F7
		[NullableContext(2)]
		public void UnregisterObject(UObject InKuroLevelPlayObject)
		{
			UKuroLevelPlaySubsystem.__UnregisterObject_Internal(base.NativePtr, (InKuroLevelPlayObject != null) ? InKuroLevelPlayObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006394 RID: 25492 RVA: 0x0008E714 File Offset: 0x0008C914
		[NullableContext(2)]
		public void UnregisterLoopTeleportVolume(AKuroLoopTeleportVolume Volume)
		{
			UKuroLevelPlaySubsystem.__UnregisterLoopTeleportVolume_Internal(base.NativePtr, (Volume != null) ? Volume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006395 RID: 25493 RVA: 0x0008E731 File Offset: 0x0008C931
		[NullableContext(2)]
		public void RegisterObject(UObject InKuroLevelPlayObject)
		{
			UKuroLevelPlaySubsystem.__RegisterObject_Internal(base.NativePtr, (InKuroLevelPlayObject != null) ? InKuroLevelPlayObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006396 RID: 25494 RVA: 0x0008E74E File Offset: 0x0008C94E
		[NullableContext(2)]
		public void RegisterLoopTeleportVolume(AKuroLoopTeleportVolume Volume)
		{
			UKuroLevelPlaySubsystem.__RegisterLoopTeleportVolume_Internal(base.NativePtr, (Volume != null) ? Volume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006397 RID: 25495 RVA: 0x0008E76B File Offset: 0x0008C96B
		public void RegisterEntityToLevelPlay(int LevelPlayId, int EntityId)
		{
			UKuroLevelPlaySubsystem.__RegisterEntityToLevelPlay_Internal(base.NativePtr, LevelPlayId, EntityId);
		}

		// Token: 0x06006398 RID: 25496 RVA: 0x0008E77A File Offset: 0x0008C97A
		public void ProcessAllItems()
		{
			UKuroLevelPlaySubsystem.__ProcessAllItems_Internal(base.NativePtr);
		}

		// Token: 0x06006399 RID: 25497 RVA: 0x0008E787 File Offset: 0x0008C987
		public TArray<AKuroLoopTeleportVolume> GetRegisteredLoopTeleportVolumes()
		{
			return new TArray<AKuroLoopTeleportVolume>(UKuroLevelPlaySubsystem.__GetRegisteredLoopTeleportVolumes_Internal(base.NativePtr), null);
		}

		// Token: 0x0600639A RID: 25498 RVA: 0x0008E79C File Offset: 0x0008C99C
		[NullableContext(2)]
		public unsafe static bool D_FindTeleportSpot(AActor TestActor, UPrimitiveComponent TestPrimitiveComponent, FVectorDouble InPlaceLocation, FRotator TestRotation, byte Iterations, ref FVectorDouble OutPlaceLocation)
		{
			fixed (FVectorDouble* ptr = &OutPlaceLocation)
			{
				void* ptr2 = (void*)ptr;
				return UKuroLevelPlaySubsystem.__D_FindTeleportSpot_Internal((TestActor != null) ? TestActor.NativePtr : IntPtr.Zero, (TestPrimitiveComponent != null) ? TestPrimitiveComponent.NativePtr : IntPtr.Zero, InPlaceLocation, TestRotation, Iterations, ref OutPlaceLocation);
			}
		}

		// Token: 0x0600639B RID: 25499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterObject_Internal(IntPtr @this, IntPtr InKuroLevelPlayObject);

		// Token: 0x0600639C RID: 25500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterLoopTeleportVolume_Internal(IntPtr @this, IntPtr Volume);

		// Token: 0x0600639D RID: 25501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterObject_Internal(IntPtr @this, IntPtr InKuroLevelPlayObject);

		// Token: 0x0600639E RID: 25502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterLoopTeleportVolume_Internal(IntPtr @this, IntPtr Volume);

		// Token: 0x0600639F RID: 25503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntityToLevelPlay_Internal(IntPtr @this, int LevelPlayId, int EntityId);

		// Token: 0x060063A0 RID: 25504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ProcessAllItems_Internal(IntPtr @this);

		// Token: 0x060063A1 RID: 25505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredLoopTeleportVolumes_Internal(IntPtr @this);

		// Token: 0x060063A2 RID: 25506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_FindTeleportSpot_Internal(IntPtr TestActor, IntPtr TestPrimitiveComponent, FVectorDouble InPlaceLocation, FRotator TestRotation, byte Iterations, ref FVectorDouble OutPlaceLocation);

		// Token: 0x060063A3 RID: 25507 RVA: 0x0008E7DA File Offset: 0x0008C9DA
		static UKuroLevelPlaySubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlaySubsystem");
		}

		// Token: 0x060063A4 RID: 25508 RVA: 0x0008E7E8 File Offset: 0x0008C9E8
		protected UKuroLevelPlaySubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A0D RID: 10765
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlaySubsystem";

		// Token: 0x04002A0E RID: 10766
		private static IntPtr _ClassPtr;

		// Token: 0x04002A0F RID: 10767
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002A10 RID: 10768
		internal static int __PropertyOffset_OnSpecificTagActorHit;

		// Token: 0x04002A11 RID: 10769
		[Nullable(2)]
		private FSpecificTagActorHitSignature _OnSpecificTagActorHit;

		// Token: 0x04002A12 RID: 10770
		internal static int __PropertyOffset_OnSpecificTagActorBeginOverlap;

		// Token: 0x04002A13 RID: 10771
		[Nullable(2)]
		private FSpecificTagActorBeginOverlapSignature _OnSpecificTagActorBeginOverlap;

		// Token: 0x04002A14 RID: 10772
		internal static int __PropertyOffset_OnSpecificTagObjectStartRelayCollisionEvent;

		// Token: 0x04002A15 RID: 10773
		[Nullable(2)]
		private FSpecificTagRelaySignature _OnSpecificTagObjectStartRelayCollisionEvent;

		// Token: 0x04002A16 RID: 10774
		internal static int __PropertyOffset_OnSpecificTagObjectEndRelayCollisionEvent;

		// Token: 0x04002A17 RID: 10775
		[Nullable(2)]
		private FSpecificTagRelaySignature _OnSpecificTagObjectEndRelayCollisionEvent;

		// Token: 0x04002A18 RID: 10776
		internal static int __PropertyOffset_OnLoopTeleportVolumeRegistered;

		// Token: 0x04002A19 RID: 10777
		[Nullable(2)]
		private FLoopTeleportVolumeRegisteredSignature _OnLoopTeleportVolumeRegistered;

		// Token: 0x04002A1A RID: 10778
		internal static int __PropertyOffset_ManagedObjects;

		// Token: 0x04002A1B RID: 10779
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TWeakObjectPtr<UObject>> _ManagedObjects;

		// Token: 0x04002A1C RID: 10780
		internal static int __PropertyOffset_LoopTeleportVolumes;

		// Token: 0x04002A1D RID: 10781
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AKuroLoopTeleportVolume>> _LoopTeleportVolumes;
	}
}
