using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200126F RID: 4719
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellData")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FWorldPartitionRuntimeCellData : FKuroWorldPartitionStruct, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060114E7 RID: 70887 RVA: 0x001968A9 File Offset: 0x00194AA9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellData._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellData", ref FWorldPartitionRuntimeCellData._ScriptStructPtr);
		}

		// Token: 0x17004379 RID: 17273
		// (get) Token: 0x060114E8 RID: 70888 RVA: 0x001968CD File Offset: 0x00194ACD
		// (set) Token: 0x060114E9 RID: 70889 RVA: 0x001968E1 File Offset: 0x00194AE1
		public unsafe FBox ContentBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_ContentBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_ContentBounds) = value;
			}
		}

		// Token: 0x1700437A RID: 17274
		// (get) Token: 0x060114EA RID: 70890 RVA: 0x001968F6 File Offset: 0x00194AF6
		// (set) Token: 0x060114EB RID: 70891 RVA: 0x0019690A File Offset: 0x00194B0A
		public unsafe FBox CellBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_CellBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_CellBounds) = value;
			}
		}

		// Token: 0x1700437B RID: 17275
		// (get) Token: 0x060114EC RID: 70892 RVA: 0x0019691F File Offset: 0x00194B1F
		// (set) Token: 0x060114ED RID: 70893 RVA: 0x00196933 File Offset: 0x00194B33
		public unsafe FName GridName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_GridName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_GridName) = value;
			}
		}

		// Token: 0x1700437C RID: 17276
		// (get) Token: 0x060114EE RID: 70894 RVA: 0x00196948 File Offset: 0x00194B48
		// (set) Token: 0x060114EF RID: 70895 RVA: 0x00196958 File Offset: 0x00194B58
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x1700437D RID: 17277
		// (get) Token: 0x060114F0 RID: 70896 RVA: 0x00196969 File Offset: 0x00194B69
		// (set) Token: 0x060114F1 RID: 70897 RVA: 0x00196979 File Offset: 0x00194B79
		public unsafe int HierarchicalLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_HierarchicalLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellData.__PropertyOffset_HierarchicalLevel) = value;
			}
		}

		// Token: 0x060114F2 RID: 70898 RVA: 0x0019698A File Offset: 0x00194B8A
		public FWorldPartitionRuntimeCellData()
		{
		}

		// Token: 0x060114F3 RID: 70899 RVA: 0x00196992 File Offset: 0x00194B92
		public FWorldPartitionRuntimeCellData(FBox ContentBounds, FBox CellBounds, FName GridName, int Priority, int HierarchicalLevel)
		{
			this.ContentBounds = ContentBounds;
			this.CellBounds = CellBounds;
			this.GridName = GridName;
			this.Priority = Priority;
			this.HierarchicalLevel = HierarchicalLevel;
		}

		// Token: 0x060114F4 RID: 70900 RVA: 0x001969BF File Offset: 0x00194BBF
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellData.StaticStruct();
		}

		// Token: 0x060114F5 RID: 70901 RVA: 0x001969CB File Offset: 0x00194BCB
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060114F6 RID: 70902 RVA: 0x001969D5 File Offset: 0x00194BD5
		public FWorldPartitionRuntimeCellData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060114F7 RID: 70903 RVA: 0x001969E0 File Offset: 0x00194BE0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellData(Pointer, false, true);
		}

		// Token: 0x060114F8 RID: 70904 RVA: 0x001969EA File Offset: 0x00194BEA
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellData(Pointer, MemoryOwner);
		}

		// Token: 0x04009437 RID: 37943
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellData";

		// Token: 0x04009438 RID: 37944
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009439 RID: 37945
		internal static int __PropertyOffset_ContentBounds;

		// Token: 0x0400943A RID: 37946
		internal static int __PropertyOffset_CellBounds;

		// Token: 0x0400943B RID: 37947
		internal static int __PropertyOffset_GridName;

		// Token: 0x0400943C RID: 37948
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400943D RID: 37949
		internal static int __PropertyOffset_HierarchicalLevel;
	}
}
