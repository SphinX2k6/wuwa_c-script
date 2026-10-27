using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018F3 RID: 6387
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroLevelPlaySubsystem")]
	[UnrealStructLayout(480, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 480)]
	public class UKuroLevelPlaySubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017AFD RID: 97021 RVA: 0x0022B5DA File Offset: 0x002297DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLevelPlaySubsystem._ClassPtr;
		}

		// Token: 0x06017AFE RID: 97022 RVA: 0x0022B5E8 File Offset: 0x002297E8
		public UKuroLevelPlaySubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017AFF RID: 97023 RVA: 0x0022B610 File Offset: 0x00229810
		public UKuroLevelPlaySubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLevelPlaySubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x06017B00 RID: 97024 RVA: 0x0022B644 File Offset: 0x00229844
		// (set) Token: 0x06017B01 RID: 97025 RVA: 0x0022B67D File Offset: 0x0022987D
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

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x06017B02 RID: 97026 RVA: 0x0022B6A0 File Offset: 0x002298A0
		// (set) Token: 0x06017B03 RID: 97027 RVA: 0x0022B6D9 File Offset: 0x002298D9
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

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x06017B04 RID: 97028 RVA: 0x0022B6FC File Offset: 0x002298FC
		// (set) Token: 0x06017B05 RID: 97029 RVA: 0x0022B735 File Offset: 0x00229935
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

		// Token: 0x17005F73 RID: 24435
		// (get) Token: 0x06017B06 RID: 97030 RVA: 0x0022B758 File Offset: 0x00229958
		// (set) Token: 0x06017B07 RID: 97031 RVA: 0x0022B791 File Offset: 0x00229991
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

		// Token: 0x17005F74 RID: 24436
		// (get) Token: 0x06017B08 RID: 97032 RVA: 0x0022B7B4 File Offset: 0x002299B4
		// (set) Token: 0x06017B09 RID: 97033 RVA: 0x0022B7ED File Offset: 0x002299ED
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

		// Token: 0x17005F75 RID: 24437
		// (get) Token: 0x06017B0A RID: 97034 RVA: 0x0022B810 File Offset: 0x00229A10
		// (set) Token: 0x06017B0B RID: 97035 RVA: 0x0022B849 File Offset: 0x00229A49
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

		// Token: 0x17005F76 RID: 24438
		// (get) Token: 0x06017B0C RID: 97036 RVA: 0x0022B858 File Offset: 0x00229A58
		// (set) Token: 0x06017B0D RID: 97037 RVA: 0x0022B891 File Offset: 0x00229A91
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

		// Token: 0x06017B0E RID: 97038 RVA: 0x0022B89F File Offset: 0x00229A9F
		[NullableContext(2)]
		public void WaitEntitiesByPbDataIds(UObject WorldContextObject, int LevelPlayId, in TArray<int> PbDataIds, float Timeout, FLatentActionInfo LatentInfo)
		{
			UKuroLevelPlaySubsystem.__WaitEntitiesByPbDataIds_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, LevelPlayId, (PbDataIds ?? new TArray<int>()).NativePtr, Timeout, (LatentInfo ?? new FLatentActionInfo()).NativePtr);
		}

		// Token: 0x06017B0F RID: 97039 RVA: 0x0022B8DF File Offset: 0x00229ADF
		[NullableContext(2)]
		public void UnregisterObject(UObject InKuroLevelPlayObject)
		{
			UKuroLevelPlaySubsystem.__UnregisterObject_Internal(base.NativePtr, (InKuroLevelPlayObject != null) ? InKuroLevelPlayObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B10 RID: 97040 RVA: 0x0022B8FC File Offset: 0x00229AFC
		[NullableContext(2)]
		public void UnregisterLoopTeleportVolume(AKuroLoopTeleportVolume Volume)
		{
			UKuroLevelPlaySubsystem.__UnregisterLoopTeleportVolume_Internal(base.NativePtr, (Volume != null) ? Volume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B11 RID: 97041 RVA: 0x0022B919 File Offset: 0x00229B19
		[NullableContext(2)]
		public void RegisterObject(UObject InKuroLevelPlayObject)
		{
			UKuroLevelPlaySubsystem.__RegisterObject_Internal(base.NativePtr, (InKuroLevelPlayObject != null) ? InKuroLevelPlayObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B12 RID: 97042 RVA: 0x0022B936 File Offset: 0x00229B36
		[NullableContext(2)]
		public void RegisterLoopTeleportVolume(AKuroLoopTeleportVolume Volume)
		{
			UKuroLevelPlaySubsystem.__RegisterLoopTeleportVolume_Internal(base.NativePtr, (Volume != null) ? Volume.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017B13 RID: 97043 RVA: 0x0022B953 File Offset: 0x00229B53
		public void RegisterEntityToLevelPlay(int LevelPlayId, int EntityId)
		{
			UKuroLevelPlaySubsystem.__RegisterEntityToLevelPlay_Internal(base.NativePtr, LevelPlayId, EntityId);
		}

		// Token: 0x06017B14 RID: 97044 RVA: 0x0022B962 File Offset: 0x00229B62
		public void ProcessAllItems()
		{
			UKuroLevelPlaySubsystem.__ProcessAllItems_Internal(base.NativePtr);
		}

		// Token: 0x06017B15 RID: 97045 RVA: 0x0022B96F File Offset: 0x00229B6F
		public TArray<AKuroLoopTeleportVolume> GetRegisteredLoopTeleportVolumes()
		{
			return new TArray<AKuroLoopTeleportVolume>(UKuroLevelPlaySubsystem.__GetRegisteredLoopTeleportVolumes_Internal(base.NativePtr), null);
		}

		// Token: 0x06017B16 RID: 97046 RVA: 0x0022B982 File Offset: 0x00229B82
		public TSet<int> GetLevelPlayIdsByType(EKuroLevelPlayType PlayType)
		{
			return new TSet<int>(UKuroLevelPlaySubsystem.__GetLevelPlayIdsByType_Internal(base.NativePtr, PlayType), null);
		}

		// Token: 0x06017B17 RID: 97047 RVA: 0x0022B998 File Offset: 0x00229B98
		[NullableContext(2)]
		public unsafe static bool D_FindTeleportSpot(AActor TestActor, UPrimitiveComponent TestPrimitiveComponent, FVectorDouble InPlaceLocation, FRotator TestRotation, byte Iterations, ref FVectorDouble OutPlaceLocation)
		{
			fixed (FVectorDouble* ptr = &OutPlaceLocation)
			{
				void* ptr2 = (void*)ptr;
				return UKuroLevelPlaySubsystem.__D_FindTeleportSpot_Internal((TestActor != null) ? TestActor.NativePtr : IntPtr.Zero, (TestPrimitiveComponent != null) ? TestPrimitiveComponent.NativePtr : IntPtr.Zero, InPlaceLocation, TestRotation, Iterations, ref OutPlaceLocation);
			}
		}

		// Token: 0x06017B18 RID: 97048 RVA: 0x0022B9D6 File Offset: 0x00229BD6
		public int AssignLevelPlayId(EKuroLevelPlayType PlayType)
		{
			return UKuroLevelPlaySubsystem.__AssignLevelPlayId_Internal(base.NativePtr, PlayType);
		}

		// Token: 0x06017B19 RID: 97049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __WaitEntitiesByPbDataIds_Internal(IntPtr @this, IntPtr WorldContextObject, int LevelPlayId, IntPtr PbDataIds, float Timeout, IntPtr LatentInfo);

		// Token: 0x06017B1A RID: 97050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterObject_Internal(IntPtr @this, IntPtr InKuroLevelPlayObject);

		// Token: 0x06017B1B RID: 97051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterLoopTeleportVolume_Internal(IntPtr @this, IntPtr Volume);

		// Token: 0x06017B1C RID: 97052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterObject_Internal(IntPtr @this, IntPtr InKuroLevelPlayObject);

		// Token: 0x06017B1D RID: 97053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterLoopTeleportVolume_Internal(IntPtr @this, IntPtr Volume);

		// Token: 0x06017B1E RID: 97054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterEntityToLevelPlay_Internal(IntPtr @this, int LevelPlayId, int EntityId);

		// Token: 0x06017B1F RID: 97055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ProcessAllItems_Internal(IntPtr @this);

		// Token: 0x06017B20 RID: 97056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRegisteredLoopTeleportVolumes_Internal(IntPtr @this);

		// Token: 0x06017B21 RID: 97057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetLevelPlayIdsByType_Internal(IntPtr @this, EKuroLevelPlayType PlayType);

		// Token: 0x06017B22 RID: 97058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_FindTeleportSpot_Internal(IntPtr TestActor, IntPtr TestPrimitiveComponent, FVectorDouble InPlaceLocation, FRotator TestRotation, byte Iterations, ref FVectorDouble OutPlaceLocation);

		// Token: 0x06017B23 RID: 97059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __AssignLevelPlayId_Internal(IntPtr @this, EKuroLevelPlayType PlayType);

		// Token: 0x06017B24 RID: 97060 RVA: 0x0022B9E4 File Offset: 0x00229BE4
		static UKuroLevelPlaySubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroLevelPlaySubsystem");
		}

		// Token: 0x06017B25 RID: 97061 RVA: 0x0022B9F2 File Offset: 0x00229BF2
		protected UKuroLevelPlaySubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CDCB RID: 52683
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroLevelPlaySubsystem";

		// Token: 0x0400CDCC RID: 52684
		private static IntPtr _ClassPtr;

		// Token: 0x0400CDCD RID: 52685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CDCE RID: 52686
		internal static int __PropertyOffset_OnSpecificTagActorHit;

		// Token: 0x0400CDCF RID: 52687
		[Nullable(2)]
		private FSpecificTagActorHitSignature _OnSpecificTagActorHit;

		// Token: 0x0400CDD0 RID: 52688
		internal static int __PropertyOffset_OnSpecificTagActorBeginOverlap;

		// Token: 0x0400CDD1 RID: 52689
		[Nullable(2)]
		private FSpecificTagActorBeginOverlapSignature _OnSpecificTagActorBeginOverlap;

		// Token: 0x0400CDD2 RID: 52690
		internal static int __PropertyOffset_OnSpecificTagObjectStartRelayCollisionEvent;

		// Token: 0x0400CDD3 RID: 52691
		[Nullable(2)]
		private FSpecificTagRelaySignature _OnSpecificTagObjectStartRelayCollisionEvent;

		// Token: 0x0400CDD4 RID: 52692
		internal static int __PropertyOffset_OnSpecificTagObjectEndRelayCollisionEvent;

		// Token: 0x0400CDD5 RID: 52693
		[Nullable(2)]
		private FSpecificTagRelaySignature _OnSpecificTagObjectEndRelayCollisionEvent;

		// Token: 0x0400CDD6 RID: 52694
		internal static int __PropertyOffset_OnLoopTeleportVolumeRegistered;

		// Token: 0x0400CDD7 RID: 52695
		[Nullable(2)]
		private FLoopTeleportVolumeRegisteredSignature _OnLoopTeleportVolumeRegistered;

		// Token: 0x0400CDD8 RID: 52696
		internal static int __PropertyOffset_ManagedObjects;

		// Token: 0x0400CDD9 RID: 52697
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TSet<TWeakObjectPtr<UObject>> _ManagedObjects;

		// Token: 0x0400CDDA RID: 52698
		internal static int __PropertyOffset_LoopTeleportVolumes;

		// Token: 0x0400CDDB RID: 52699
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AKuroLoopTeleportVolume>> _LoopTeleportVolumes;
	}
}
