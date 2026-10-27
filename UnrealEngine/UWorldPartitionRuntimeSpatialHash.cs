using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200127F RID: 4735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeSpatialHash")]
	[UnrealStructLayout(1008, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1008)]
	public class UWorldPartitionRuntimeSpatialHash : UWorldPartitionRuntimeHash, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601158E RID: 71054 RVA: 0x0019761B File Offset: 0x0019581B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionRuntimeSpatialHash._ClassPtr;
		}

		// Token: 0x0601158F RID: 71055 RVA: 0x00197628 File Offset: 0x00195828
		public UWorldPartitionRuntimeSpatialHash() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeSpatialHash.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06011590 RID: 71056 RVA: 0x00197650 File Offset: 0x00195850
		public UWorldPartitionRuntimeSpatialHash(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionRuntimeSpatialHash.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004395 RID: 17301
		// (get) Token: 0x06011591 RID: 71057 RVA: 0x00197684 File Offset: 0x00195884
		// (set) Token: 0x06011592 RID: 71058 RVA: 0x001976BD File Offset: 0x001958BD
		public FSpatialHashSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSpatialHashSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSpatialHashSettings(base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSpatialHashSettings.StaticStruct(), base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004396 RID: 17302
		// (get) Token: 0x06011593 RID: 71059 RVA: 0x001976E0 File Offset: 0x001958E0
		// (set) Token: 0x06011594 RID: 71060 RVA: 0x00197719 File Offset: 0x00195919
		public TArray<FSpatialHashStreamingGrid> StreamingGrids
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpatialHashStreamingGrid> result;
				if ((result = this._StreamingGrids) == null)
				{
					result = (this._StreamingGrids = new TArray<FSpatialHashStreamingGrid>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_StreamingGrids, this));
				}
				return result;
			}
			set
			{
				this.StreamingGrids.CopyAssign(value);
			}
		}

		// Token: 0x17004397 RID: 17303
		// (get) Token: 0x06011595 RID: 71061 RVA: 0x00197728 File Offset: 0x00195928
		// (set) Token: 0x06011596 RID: 71062 RVA: 0x00197761 File Offset: 0x00195961
		public TMap<FGuid, URuntimeSpatialHashExternalStreamingObject> WorldAssetStreamingObjects
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FGuid, URuntimeSpatialHashExternalStreamingObject> result;
				if ((result = this._WorldAssetStreamingObjects) == null)
				{
					result = (this._WorldAssetStreamingObjects = new TMap<FGuid, URuntimeSpatialHashExternalStreamingObject>(base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_WorldAssetStreamingObjects, this));
				}
				return result;
			}
			set
			{
				this.WorldAssetStreamingObjects.CopyAssign(value);
			}
		}

		// Token: 0x17004398 RID: 17304
		// (get) Token: 0x06011597 RID: 71063 RVA: 0x0019776F File Offset: 0x0019596F
		// (set) Token: 0x06011598 RID: 71064 RVA: 0x0019777F File Offset: 0x0019597F
		public unsafe bool bEnableZCulling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_bEnableZCulling) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWorldPartitionRuntimeSpatialHash.__PropertyOffset_bEnableZCulling) = (value ? 1 : 0);
			}
		}

		// Token: 0x06011599 RID: 71065 RVA: 0x00197790 File Offset: 0x00195990
		static UWorldPartitionRuntimeSpatialHash()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionRuntimeSpatialHash");
		}

		// Token: 0x0601159A RID: 71066 RVA: 0x0019779E File Offset: 0x0019599E
		protected UWorldPartitionRuntimeSpatialHash(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04009483 RID: 38019
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeSpatialHash";

		// Token: 0x04009484 RID: 38020
		private static IntPtr _ClassPtr;

		// Token: 0x04009485 RID: 38021
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04009486 RID: 38022
		internal static int __PropertyOffset_Settings;

		// Token: 0x04009487 RID: 38023
		[Nullable(2)]
		private FSpatialHashSettings _Settings;

		// Token: 0x04009488 RID: 38024
		internal static int __PropertyOffset_StreamingGrids;

		// Token: 0x04009489 RID: 38025
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpatialHashStreamingGrid> _StreamingGrids;

		// Token: 0x0400948A RID: 38026
		internal static int __PropertyOffset_WorldAssetStreamingObjects;

		// Token: 0x0400948B RID: 38027
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FGuid, URuntimeSpatialHashExternalStreamingObject> _WorldAssetStreamingObjects;

		// Token: 0x0400948C RID: 38028
		internal static int __PropertyOffset_bEnableZCulling;
	}
}
