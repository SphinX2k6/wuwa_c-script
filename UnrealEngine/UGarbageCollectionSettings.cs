using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C06 RID: 3078
	[UnrealObjectPath("/Script/Engine.GarbageCollectionSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UGarbageCollectionSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009AEB RID: 39659 RVA: 0x000DC1F1 File Offset: 0x000DA3F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGarbageCollectionSettings._ClassPtr;
		}

		// Token: 0x06009AEC RID: 39660 RVA: 0x000DC200 File Offset: 0x000DA400
		public UGarbageCollectionSettings() : this(BuiltinUtils.AllocNativeUObject(UGarbageCollectionSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009AED RID: 39661 RVA: 0x000DC228 File Offset: 0x000DA428
		[NullableContext(1)]
		public UGarbageCollectionSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGarbageCollectionSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170024CA RID: 9418
		// (get) Token: 0x06009AEE RID: 39662 RVA: 0x000DC25B File Offset: 0x000DA45B
		// (set) Token: 0x06009AEF RID: 39663 RVA: 0x000DC26B File Offset: 0x000DA46B
		public unsafe float TimeBetweenPurgingPendingKillObjects
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_TimeBetweenPurgingPendingKillObjects);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_TimeBetweenPurgingPendingKillObjects) = value;
			}
		}

		// Token: 0x170024CB RID: 9419
		// (get) Token: 0x06009AF0 RID: 39664 RVA: 0x000DC27C File Offset: 0x000DA47C
		// (set) Token: 0x06009AF1 RID: 39665 RVA: 0x000DC295 File Offset: 0x000DA495
		public unsafe bool FlushStreamingOnGC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_FlushStreamingOnGC) & UGarbageCollectionSettings.__PropertyMask_FlushStreamingOnGC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_FlushStreamingOnGC) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_FlushStreamingOnGC) & ~UGarbageCollectionSettings.__PropertyMask_FlushStreamingOnGC) | (value ? UGarbageCollectionSettings.__PropertyMask_FlushStreamingOnGC : 0));
			}
		}

		// Token: 0x170024CC RID: 9420
		// (get) Token: 0x06009AF2 RID: 39666 RVA: 0x000DC2C5 File Offset: 0x000DA4C5
		// (set) Token: 0x06009AF3 RID: 39667 RVA: 0x000DC2DE File Offset: 0x000DA4DE
		public unsafe bool AllowParallelGC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AllowParallelGC) & UGarbageCollectionSettings.__PropertyMask_AllowParallelGC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AllowParallelGC) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AllowParallelGC) & ~UGarbageCollectionSettings.__PropertyMask_AllowParallelGC) | (value ? UGarbageCollectionSettings.__PropertyMask_AllowParallelGC : 0));
			}
		}

		// Token: 0x170024CD RID: 9421
		// (get) Token: 0x06009AF4 RID: 39668 RVA: 0x000DC30E File Offset: 0x000DA50E
		// (set) Token: 0x06009AF5 RID: 39669 RVA: 0x000DC327 File Offset: 0x000DA527
		public unsafe bool IncrementalBeginDestroyEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_IncrementalBeginDestroyEnabled) & UGarbageCollectionSettings.__PropertyMask_IncrementalBeginDestroyEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_IncrementalBeginDestroyEnabled) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_IncrementalBeginDestroyEnabled) & ~UGarbageCollectionSettings.__PropertyMask_IncrementalBeginDestroyEnabled) | (value ? UGarbageCollectionSettings.__PropertyMask_IncrementalBeginDestroyEnabled : 0));
			}
		}

		// Token: 0x170024CE RID: 9422
		// (get) Token: 0x06009AF6 RID: 39670 RVA: 0x000DC357 File Offset: 0x000DA557
		// (set) Token: 0x06009AF7 RID: 39671 RVA: 0x000DC370 File Offset: 0x000DA570
		public unsafe bool MultithreadedDestructionEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MultithreadedDestructionEnabled) & UGarbageCollectionSettings.__PropertyMask_MultithreadedDestructionEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MultithreadedDestructionEnabled) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MultithreadedDestructionEnabled) & ~UGarbageCollectionSettings.__PropertyMask_MultithreadedDestructionEnabled) | (value ? UGarbageCollectionSettings.__PropertyMask_MultithreadedDestructionEnabled : 0));
			}
		}

		// Token: 0x170024CF RID: 9423
		// (get) Token: 0x06009AF8 RID: 39672 RVA: 0x000DC3A0 File Offset: 0x000DA5A0
		// (set) Token: 0x06009AF9 RID: 39673 RVA: 0x000DC3B9 File Offset: 0x000DA5B9
		public unsafe bool CreateGCClusters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_CreateGCClusters) & UGarbageCollectionSettings.__PropertyMask_CreateGCClusters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_CreateGCClusters) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_CreateGCClusters) & ~UGarbageCollectionSettings.__PropertyMask_CreateGCClusters) | (value ? UGarbageCollectionSettings.__PropertyMask_CreateGCClusters : 0));
			}
		}

		// Token: 0x170024D0 RID: 9424
		// (get) Token: 0x06009AFA RID: 39674 RVA: 0x000DC3E9 File Offset: 0x000DA5E9
		// (set) Token: 0x06009AFB RID: 39675 RVA: 0x000DC402 File Offset: 0x000DA602
		public unsafe bool AssetClusteringEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AssetClusteringEnabled) & UGarbageCollectionSettings.__PropertyMask_AssetClusteringEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AssetClusteringEnabled) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_AssetClusteringEnabled) & ~UGarbageCollectionSettings.__PropertyMask_AssetClusteringEnabled) | (value ? UGarbageCollectionSettings.__PropertyMask_AssetClusteringEnabled : 0));
			}
		}

		// Token: 0x170024D1 RID: 9425
		// (get) Token: 0x06009AFC RID: 39676 RVA: 0x000DC432 File Offset: 0x000DA632
		// (set) Token: 0x06009AFD RID: 39677 RVA: 0x000DC44B File Offset: 0x000DA64B
		public unsafe bool ActorClusteringEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_ActorClusteringEnabled) & UGarbageCollectionSettings.__PropertyMask_ActorClusteringEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_ActorClusteringEnabled) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_ActorClusteringEnabled) & ~UGarbageCollectionSettings.__PropertyMask_ActorClusteringEnabled) | (value ? UGarbageCollectionSettings.__PropertyMask_ActorClusteringEnabled : 0));
			}
		}

		// Token: 0x170024D2 RID: 9426
		// (get) Token: 0x06009AFE RID: 39678 RVA: 0x000DC47B File Offset: 0x000DA67B
		// (set) Token: 0x06009AFF RID: 39679 RVA: 0x000DC494 File Offset: 0x000DA694
		public unsafe bool BlueprintClusteringEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_BlueprintClusteringEnabled) & UGarbageCollectionSettings.__PropertyMask_BlueprintClusteringEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_BlueprintClusteringEnabled) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_BlueprintClusteringEnabled) & ~UGarbageCollectionSettings.__PropertyMask_BlueprintClusteringEnabled) | (value ? UGarbageCollectionSettings.__PropertyMask_BlueprintClusteringEnabled : 0));
			}
		}

		// Token: 0x170024D3 RID: 9427
		// (get) Token: 0x06009B00 RID: 39680 RVA: 0x000DC4C4 File Offset: 0x000DA6C4
		// (set) Token: 0x06009B01 RID: 39681 RVA: 0x000DC4DD File Offset: 0x000DA6DD
		public unsafe bool UseDisregardForGCOnDedicatedServers
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_UseDisregardForGCOnDedicatedServers) & UGarbageCollectionSettings.__PropertyMask_UseDisregardForGCOnDedicatedServers) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_UseDisregardForGCOnDedicatedServers) = ((*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_UseDisregardForGCOnDedicatedServers) & ~UGarbageCollectionSettings.__PropertyMask_UseDisregardForGCOnDedicatedServers) | (value ? UGarbageCollectionSettings.__PropertyMask_UseDisregardForGCOnDedicatedServers : 0));
			}
		}

		// Token: 0x170024D4 RID: 9428
		// (get) Token: 0x06009B02 RID: 39682 RVA: 0x000DC50D File Offset: 0x000DA70D
		// (set) Token: 0x06009B03 RID: 39683 RVA: 0x000DC51D File Offset: 0x000DA71D
		public unsafe int MinGCClusterSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MinGCClusterSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MinGCClusterSize) = value;
			}
		}

		// Token: 0x170024D5 RID: 9429
		// (get) Token: 0x06009B04 RID: 39684 RVA: 0x000DC52E File Offset: 0x000DA72E
		// (set) Token: 0x06009B05 RID: 39685 RVA: 0x000DC53E File Offset: 0x000DA73E
		public unsafe int NumRetriesBeforeForcingGC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_NumRetriesBeforeForcingGC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_NumRetriesBeforeForcingGC) = value;
			}
		}

		// Token: 0x170024D6 RID: 9430
		// (get) Token: 0x06009B06 RID: 39686 RVA: 0x000DC54F File Offset: 0x000DA74F
		// (set) Token: 0x06009B07 RID: 39687 RVA: 0x000DC55F File Offset: 0x000DA75F
		public unsafe int MaxObjectsNotConsideredByGC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsNotConsideredByGC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsNotConsideredByGC) = value;
			}
		}

		// Token: 0x170024D7 RID: 9431
		// (get) Token: 0x06009B08 RID: 39688 RVA: 0x000DC570 File Offset: 0x000DA770
		// (set) Token: 0x06009B09 RID: 39689 RVA: 0x000DC580 File Offset: 0x000DA780
		public unsafe int SizeOfPermanentObjectPool
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_SizeOfPermanentObjectPool);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_SizeOfPermanentObjectPool) = value;
			}
		}

		// Token: 0x170024D8 RID: 9432
		// (get) Token: 0x06009B0A RID: 39690 RVA: 0x000DC591 File Offset: 0x000DA791
		// (set) Token: 0x06009B0B RID: 39691 RVA: 0x000DC5A1 File Offset: 0x000DA7A1
		public unsafe int MaxObjectsInGame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsInGame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsInGame) = value;
			}
		}

		// Token: 0x170024D9 RID: 9433
		// (get) Token: 0x06009B0C RID: 39692 RVA: 0x000DC5B2 File Offset: 0x000DA7B2
		// (set) Token: 0x06009B0D RID: 39693 RVA: 0x000DC5C2 File Offset: 0x000DA7C2
		public unsafe int MaxObjectsInEditor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsInEditor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGarbageCollectionSettings.__PropertyOffset_MaxObjectsInEditor) = value;
			}
		}

		// Token: 0x06009B0E RID: 39694 RVA: 0x000DC5D3 File Offset: 0x000DA7D3
		static UGarbageCollectionSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.GarbageCollectionSettings");
		}

		// Token: 0x06009B0F RID: 39695 RVA: 0x000DC5E1 File Offset: 0x000DA7E1
		protected UGarbageCollectionSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005582 RID: 21890
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.GarbageCollectionSettings";

		// Token: 0x04005583 RID: 21891
		private static IntPtr _ClassPtr;

		// Token: 0x04005584 RID: 21892
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005585 RID: 21893
		internal static int __PropertyOffset_TimeBetweenPurgingPendingKillObjects;

		// Token: 0x04005586 RID: 21894
		internal static int __PropertyOffset_FlushStreamingOnGC;

		// Token: 0x04005587 RID: 21895
		internal static byte __PropertyMask_FlushStreamingOnGC;

		// Token: 0x04005588 RID: 21896
		internal static int __PropertyOffset_AllowParallelGC;

		// Token: 0x04005589 RID: 21897
		internal static byte __PropertyMask_AllowParallelGC;

		// Token: 0x0400558A RID: 21898
		internal static int __PropertyOffset_IncrementalBeginDestroyEnabled;

		// Token: 0x0400558B RID: 21899
		internal static byte __PropertyMask_IncrementalBeginDestroyEnabled;

		// Token: 0x0400558C RID: 21900
		internal static int __PropertyOffset_MultithreadedDestructionEnabled;

		// Token: 0x0400558D RID: 21901
		internal static byte __PropertyMask_MultithreadedDestructionEnabled;

		// Token: 0x0400558E RID: 21902
		internal static int __PropertyOffset_CreateGCClusters;

		// Token: 0x0400558F RID: 21903
		internal static byte __PropertyMask_CreateGCClusters;

		// Token: 0x04005590 RID: 21904
		internal static int __PropertyOffset_AssetClusteringEnabled;

		// Token: 0x04005591 RID: 21905
		internal static byte __PropertyMask_AssetClusteringEnabled;

		// Token: 0x04005592 RID: 21906
		internal static int __PropertyOffset_ActorClusteringEnabled;

		// Token: 0x04005593 RID: 21907
		internal static byte __PropertyMask_ActorClusteringEnabled;

		// Token: 0x04005594 RID: 21908
		internal static int __PropertyOffset_BlueprintClusteringEnabled;

		// Token: 0x04005595 RID: 21909
		internal static byte __PropertyMask_BlueprintClusteringEnabled;

		// Token: 0x04005596 RID: 21910
		internal static int __PropertyOffset_UseDisregardForGCOnDedicatedServers;

		// Token: 0x04005597 RID: 21911
		internal static byte __PropertyMask_UseDisregardForGCOnDedicatedServers;

		// Token: 0x04005598 RID: 21912
		internal static int __PropertyOffset_MinGCClusterSize;

		// Token: 0x04005599 RID: 21913
		internal static int __PropertyOffset_NumRetriesBeforeForcingGC;

		// Token: 0x0400559A RID: 21914
		internal static int __PropertyOffset_MaxObjectsNotConsideredByGC;

		// Token: 0x0400559B RID: 21915
		internal static int __PropertyOffset_SizeOfPermanentObjectPool;

		// Token: 0x0400559C RID: 21916
		internal static int __PropertyOffset_MaxObjectsInGame;

		// Token: 0x0400559D RID: 21917
		internal static int __PropertyOffset_MaxObjectsInEditor;
	}
}
