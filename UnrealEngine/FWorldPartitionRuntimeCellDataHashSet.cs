using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001270 RID: 4720
	[UnrealObjectPath("/Script/Engine.WorldPartitionRuntimeCellDataHashSet")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FWorldPartitionRuntimeCellDataHashSet : FWorldPartitionRuntimeCellData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060114F9 RID: 70905 RVA: 0x001969F3 File Offset: 0x00194BF3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionRuntimeCellDataHashSet._ScriptStructPtr != 0) ? FWorldPartitionRuntimeCellDataHashSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionRuntimeCellDataHashSet", ref FWorldPartitionRuntimeCellDataHashSet._ScriptStructPtr);
		}

		// Token: 0x1700437E RID: 17278
		// (get) Token: 0x060114FA RID: 70906 RVA: 0x00196A17 File Offset: 0x00194C17
		// (set) Token: 0x060114FB RID: 70907 RVA: 0x00196A27 File Offset: 0x00194C27
		public unsafe bool bIs2D
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataHashSet.__PropertyOffset_bIs2D) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FWorldPartitionRuntimeCellDataHashSet.__PropertyOffset_bIs2D) = (value ? 1 : 0);
			}
		}

		// Token: 0x060114FC RID: 70908 RVA: 0x00196A38 File Offset: 0x00194C38
		public FWorldPartitionRuntimeCellDataHashSet()
		{
		}

		// Token: 0x060114FD RID: 70909 RVA: 0x00196A40 File Offset: 0x00194C40
		public FWorldPartitionRuntimeCellDataHashSet(bool bIs2D, FBox ContentBounds, FBox CellBounds, FName GridName, int Priority, int HierarchicalLevel)
		{
			this.bIs2D = bIs2D;
			base.ContentBounds = ContentBounds;
			base.CellBounds = CellBounds;
			base.GridName = GridName;
			base.Priority = Priority;
			base.HierarchicalLevel = HierarchicalLevel;
		}

		// Token: 0x060114FE RID: 70910 RVA: 0x00196A75 File Offset: 0x00194C75
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionRuntimeCellDataHashSet.StaticStruct();
		}

		// Token: 0x060114FF RID: 70911 RVA: 0x00196A81 File Offset: 0x00194C81
		[NullableContext(2)]
		public FWorldPartitionRuntimeCellDataHashSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011500 RID: 70912 RVA: 0x00196A8B File Offset: 0x00194C8B
		public FWorldPartitionRuntimeCellDataHashSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011501 RID: 70913 RVA: 0x00196A96 File Offset: 0x00194C96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionRuntimeCellDataHashSet(Pointer, false, true);
		}

		// Token: 0x06011502 RID: 70914 RVA: 0x00196AA0 File Offset: 0x00194CA0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionRuntimeCellDataHashSet(Pointer, MemoryOwner);
		}

		// Token: 0x0400943E RID: 37950
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionRuntimeCellDataHashSet";

		// Token: 0x0400943F RID: 37951
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009440 RID: 37952
		internal static int __PropertyOffset_bIs2D;
	}
}
