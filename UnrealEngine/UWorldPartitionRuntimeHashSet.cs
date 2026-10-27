using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200127C RID: 4732
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeHashSet")]
	[UnrealStructLayout(648, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 648)]
	public class UWorldPartitionRuntimeHashSet : UWorldPartitionRuntimeHash, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601156B RID: 71019 RVA: 0x00197275 File Offset: 0x00195475
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeHashSet._ClassPtr;
		}

		// Token: 0x0601156C RID: 71020 RVA: 0x00197284 File Offset: 0x00195484
		public UWorldPartitionRuntimeHashSet() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeHashSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601156D RID: 71021 RVA: 0x001972AC File Offset: 0x001954AC
		public UWorldPartitionRuntimeHashSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeHashSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700438E RID: 17294
		// (get) Token: 0x0601156E RID: 71022 RVA: 0x001972E0 File Offset: 0x001954E0
		// (set) Token: 0x0601156F RID: 71023 RVA: 0x00197319 File Offset: 0x00195519
		public TArray<FRuntimePartitionDesc> RuntimePartitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionDesc> result;
				if ((result = this._RuntimePartitions) == null)
				{
					result = (this._RuntimePartitions = new TArray<FRuntimePartitionDesc>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeHashSet.__PropertyOffset_RuntimePartitions, this));
				}
				return result;
			}
			set
			{
				this.RuntimePartitions.CopyAssign(value);
			}
		}

		// Token: 0x1700438F RID: 17295
		// (get) Token: 0x06011570 RID: 71024 RVA: 0x00197328 File Offset: 0x00195528
		// (set) Token: 0x06011571 RID: 71025 RVA: 0x00197361 File Offset: 0x00195561
		public TArray<FRuntimePartitionStreamingData> RuntimeStreamingData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRuntimePartitionStreamingData> result;
				if ((result = this._RuntimeStreamingData) == null)
				{
					result = (this._RuntimeStreamingData = new TArray<FRuntimePartitionStreamingData>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeHashSet.__PropertyOffset_RuntimeStreamingData, this));
				}
				return result;
			}
			set
			{
				this.RuntimeStreamingData.CopyAssign(value);
			}
		}

		// Token: 0x17004390 RID: 17296
		// (get) Token: 0x06011572 RID: 71026 RVA: 0x00197370 File Offset: 0x00195570
		// (set) Token: 0x06011573 RID: 71027 RVA: 0x001973A9 File Offset: 0x001955A9
		public TMap<FGuid, URuntimeHashSetExternalStreamingObject> WorldAssetStreamingObjects
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, URuntimeHashSetExternalStreamingObject> result;
				if ((result = this._WorldAssetStreamingObjects) == null)
				{
					result = (this._WorldAssetStreamingObjects = new TMap<FGuid, URuntimeHashSetExternalStreamingObject>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeHashSet.__PropertyOffset_WorldAssetStreamingObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldAssetStreamingObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004391 RID: 17297
		// (get) Token: 0x06011574 RID: 71028 RVA: 0x001973B8 File Offset: 0x001955B8
		// (set) Token: 0x06011575 RID: 71029 RVA: 0x001973F1 File Offset: 0x001955F1
		public TMap<FGuid, FGuid> StandaloneHLODActorToSourceCellsMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, FGuid> result;
				if ((result = this._StandaloneHLODActorToSourceCellsMap) == null)
				{
					result = (this._StandaloneHLODActorToSourceCellsMap = new TMap<FGuid, FGuid>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeHashSet.__PropertyOffset_StandaloneHLODActorToSourceCellsMap, this));
				}
				return result;
			}
			set
			{
				this.StandaloneHLODActorToSourceCellsMap.CopyAssign(value);
			}
		}

		// Token: 0x06011576 RID: 71030 RVA: 0x001973FF File Offset: 0x001955FF
		static UWorldPartitionRuntimeHashSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeHashSet");
		}

		// Token: 0x06011577 RID: 71031 RVA: 0x0019740D File Offset: 0x0019560D
		protected UWorldPartitionRuntimeHashSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400946D RID: 37997
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeHashSet";

		// Token: 0x0400946E RID: 37998
		private static IntPtr _ClassPtr;

		// Token: 0x0400946F RID: 37999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009470 RID: 38000
		internal static int __PropertyOffset_RuntimePartitions;

		// Token: 0x04009471 RID: 38001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionDesc> _RuntimePartitions;

		// Token: 0x04009472 RID: 38002
		internal static int __PropertyOffset_RuntimeStreamingData;

		// Token: 0x04009473 RID: 38003
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRuntimePartitionStreamingData> _RuntimeStreamingData;

		// Token: 0x04009474 RID: 38004
		internal static int __PropertyOffset_WorldAssetStreamingObjects;

		// Token: 0x04009475 RID: 38005
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, URuntimeHashSetExternalStreamingObject> _WorldAssetStreamingObjects;

		// Token: 0x04009476 RID: 38006
		internal static int __PropertyOffset_StandaloneHLODActorToSourceCellsMap;

		// Token: 0x04009477 RID: 38007
		[Nullable(2)]
		private TMap<FGuid, FGuid> _StandaloneHLODActorToSourceCellsMap;
	}
}
