using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001271 RID: 4721
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellDataSpatialHash")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 264)]
	public class FWorldPartitionRuntimeCellDataSpatialHash : FWorldPartitionRuntimeCellData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011503 RID: 70915 RVA: 0x00196AA9 File Offset: 0x00194CA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellDataSpatialHash._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellDataSpatialHash._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellDataSpatialHash", ref FWorldPartitionRuntimeCellDataSpatialHash._ScriptStructPtr);
		}

		// Token: 0x1700437F RID: 17279
		// (get) Token: 0x06011504 RID: 70916 RVA: 0x00196ACD File Offset: 0x00194CCD
		// (set) Token: 0x06011505 RID: 70917 RVA: 0x00196AE1 File Offset: 0x00194CE1
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataSpatialHash.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataSpatialHash.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004380 RID: 17280
		// (get) Token: 0x06011506 RID: 70918 RVA: 0x00196AF6 File Offset: 0x00194CF6
		// (set) Token: 0x06011507 RID: 70919 RVA: 0x00196B06 File Offset: 0x00194D06
		public unsafe float Extent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataSpatialHash.__PropertyOffset_Extent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataSpatialHash.__PropertyOffset_Extent) = value;
			}
		}

		// Token: 0x06011508 RID: 70920 RVA: 0x00196B17 File Offset: 0x00194D17
		public FWorldPartitionRuntimeCellDataSpatialHash()
		{
		}

		// Token: 0x06011509 RID: 70921 RVA: 0x00196B1F File Offset: 0x00194D1F
		public FWorldPartitionRuntimeCellDataSpatialHash(FVector Position, float Extent, FBox ContentBounds, FBox CellBounds, FName GridName, int Priority, int HierarchicalLevel)
		{
			this.Position = Position;
			this.Extent = Extent;
			base.ContentBounds = ContentBounds;
			base.CellBounds = CellBounds;
			base.GridName = GridName;
			base.Priority = Priority;
			base.HierarchicalLevel = HierarchicalLevel;
		}

		// Token: 0x0601150A RID: 70922 RVA: 0x00196B5C File Offset: 0x00194D5C
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellDataSpatialHash.StaticStruct();
		}

		// Token: 0x0601150B RID: 70923 RVA: 0x00196B68 File Offset: 0x00194D68
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellDataSpatialHash(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601150C RID: 70924 RVA: 0x00196B72 File Offset: 0x00194D72
		public FWorldPartitionRuntimeCellDataSpatialHash(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601150D RID: 70925 RVA: 0x00196B7D File Offset: 0x00194D7D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellDataSpatialHash(Pointer, false, true);
		}

		// Token: 0x0601150E RID: 70926 RVA: 0x00196B87 File Offset: 0x00194D87
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellDataSpatialHash(Pointer, MemoryOwner);
		}

		// Token: 0x04009441 RID: 37953
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellDataSpatialHash";

		// Token: 0x04009442 RID: 37954
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009443 RID: 37955
		internal static int __PropertyOffset_Position;

		// Token: 0x04009444 RID: 37956
		internal static int __PropertyOffset_Extent;
	}
}
