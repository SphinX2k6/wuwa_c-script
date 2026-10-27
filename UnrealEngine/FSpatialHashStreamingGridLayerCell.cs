using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200116A RID: 4458
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpatialHashStreamingGridLayerCell")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSpatialHashStreamingGridLayerCell : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060104BE RID: 66750 RVA: 0x001801A8 File Offset: 0x0017E3A8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpatialHashStreamingGridLayerCell._ScriptStructPtr != 0) ? FSpatialHashStreamingGridLayerCell._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpatialHashStreamingGridLayerCell", ref FSpatialHashStreamingGridLayerCell._ScriptStructPtr);
		}

		// Token: 0x17003FE0 RID: 16352
		// (get) Token: 0x060104BF RID: 66751 RVA: 0x001801CC File Offset: 0x0017E3CC
		// (set) Token: 0x060104C0 RID: 66752 RVA: 0x0018020F File Offset: 0x0017E40F
		public TArray<UWorldPartitionRuntimeCell> GridCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._GridCells) == null)
				{
					result = (this._GridCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FSpatialHashStreamingGridLayerCell.__PropertyOffset_GridCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.GridCells.CopyAssign(value);
			}
		}

		// Token: 0x060104C1 RID: 66753 RVA: 0x0018021D File Offset: 0x0017E41D
		public FSpatialHashStreamingGridLayerCell()
		{
		}

		// Token: 0x060104C2 RID: 66754 RVA: 0x00180225 File Offset: 0x0017E425
		public FSpatialHashStreamingGridLayerCell(TArray<UWorldPartitionRuntimeCell> GridCells)
		{
			this.GridCells = GridCells;
		}

		// Token: 0x060104C3 RID: 66755 RVA: 0x00180234 File Offset: 0x0017E434
		protected override IntPtr GetUStructPtr()
		{
			return FSpatialHashStreamingGridLayerCell.StaticStruct();
		}

		// Token: 0x060104C4 RID: 66756 RVA: 0x00180240 File Offset: 0x0017E440
		[NullableContext(2)]
		public FSpatialHashStreamingGridLayerCell(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104C5 RID: 66757 RVA: 0x0018024A File Offset: 0x0017E44A
		public FSpatialHashStreamingGridLayerCell(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104C6 RID: 66758 RVA: 0x00180255 File Offset: 0x0017E455
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpatialHashStreamingGridLayerCell(Pointer, false, true);
		}

		// Token: 0x060104C7 RID: 66759 RVA: 0x0018025F File Offset: 0x0017E45F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpatialHashStreamingGridLayerCell(Pointer, MemoryOwner);
		}

		// Token: 0x04008C3F RID: 35903
		public const string __ObjectPath = "/Script/Engine.SpatialHashStreamingGridLayerCell";

		// Token: 0x04008C40 RID: 35904
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C41 RID: 35905
		internal static int __PropertyOffset_GridCells;

		// Token: 0x04008C42 RID: 35906
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _GridCells;
	}
}
