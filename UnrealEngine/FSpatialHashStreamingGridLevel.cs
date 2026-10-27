using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200116B RID: 4459
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SpatialHashStreamingGridLevel")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FSpatialHashStreamingGridLevel : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060104C8 RID: 66760 RVA: 0x00180268 File Offset: 0x0017E468
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSpatialHashStreamingGridLevel._ScriptStructPtr != 0) ? FSpatialHashStreamingGridLevel._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SpatialHashStreamingGridLevel", ref FSpatialHashStreamingGridLevel._ScriptStructPtr);
		}

		// Token: 0x17003FE1 RID: 16353
		// (get) Token: 0x060104C9 RID: 66761 RVA: 0x0018028C File Offset: 0x0017E48C
		// (set) Token: 0x060104CA RID: 66762 RVA: 0x001802CF File Offset: 0x0017E4CF
		public TArray<FSpatialHashStreamingGridLayerCell> LayerCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSpatialHashStreamingGridLayerCell> result;
				if ((result = this._LayerCells) == null)
				{
					result = (this._LayerCells = new TArray<FSpatialHashStreamingGridLayerCell>(base.NativePtr + (IntPtr)FSpatialHashStreamingGridLevel.__PropertyOffset_LayerCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerCells.CopyAssign(value);
			}
		}

		// Token: 0x17003FE2 RID: 16354
		// (get) Token: 0x060104CB RID: 66763 RVA: 0x001802E0 File Offset: 0x0017E4E0
		// (set) Token: 0x060104CC RID: 66764 RVA: 0x00180323 File Offset: 0x0017E523
		public TMap<long, int> LayerCellsMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<long, int> result;
				if ((result = this._LayerCellsMapping) == null)
				{
					result = (this._LayerCellsMapping = new TMap<long, int>(base.NativePtr + (IntPtr)FSpatialHashStreamingGridLevel.__PropertyOffset_LayerCellsMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerCellsMapping.CopyAssign(value);
			}
		}

		// Token: 0x17003FE3 RID: 16355
		// (get) Token: 0x060104CD RID: 66765 RVA: 0x00180334 File Offset: 0x0017E534
		// (set) Token: 0x060104CE RID: 66766 RVA: 0x00180377 File Offset: 0x0017E577
		public TMap<int, string> CoordCells
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, string> result;
				if ((result = this._CoordCells) == null)
				{
					result = (this._CoordCells = new TMap<int, string>(base.NativePtr + (IntPtr)FSpatialHashStreamingGridLevel.__PropertyOffset_CoordCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.CoordCells.CopyAssign(value);
			}
		}

		// Token: 0x060104CF RID: 66767 RVA: 0x00180385 File Offset: 0x0017E585
		public FSpatialHashStreamingGridLevel()
		{
		}

		// Token: 0x060104D0 RID: 66768 RVA: 0x0018038D File Offset: 0x0017E58D
		public FSpatialHashStreamingGridLevel(TArray<FSpatialHashStreamingGridLayerCell> LayerCells, TMap<long, int> LayerCellsMapping, TMap<int, string> CoordCells)
		{
			this.LayerCells = LayerCells;
			this.LayerCellsMapping = LayerCellsMapping;
			this.CoordCells = CoordCells;
		}

		// Token: 0x060104D1 RID: 66769 RVA: 0x001803AA File Offset: 0x0017E5AA
		protected override IntPtr GetUStructPtr()
		{
			return FSpatialHashStreamingGridLevel.StaticStruct();
		}

		// Token: 0x060104D2 RID: 66770 RVA: 0x001803B6 File Offset: 0x0017E5B6
		[NullableContext(2)]
		public FSpatialHashStreamingGridLevel(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060104D3 RID: 66771 RVA: 0x001803C0 File Offset: 0x0017E5C0
		public FSpatialHashStreamingGridLevel(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060104D4 RID: 66772 RVA: 0x001803CB File Offset: 0x0017E5CB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSpatialHashStreamingGridLevel(Pointer, false, true);
		}

		// Token: 0x060104D5 RID: 66773 RVA: 0x001803D5 File Offset: 0x0017E5D5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSpatialHashStreamingGridLevel(Pointer, MemoryOwner);
		}

		// Token: 0x04008C43 RID: 35907
		public const string __ObjectPath = "/Script/Engine.SpatialHashStreamingGridLevel";

		// Token: 0x04008C44 RID: 35908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008C45 RID: 35909
		internal static int __PropertyOffset_LayerCells;

		// Token: 0x04008C46 RID: 35910
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSpatialHashStreamingGridLayerCell> _LayerCells;

		// Token: 0x04008C47 RID: 35911
		internal static int __PropertyOffset_LayerCellsMapping;

		// Token: 0x04008C48 RID: 35912
		[Nullable(2)]
		private TMap<long, int> _LayerCellsMapping;

		// Token: 0x04008C49 RID: 35913
		internal static int __PropertyOffset_CoordCells;

		// Token: 0x04008C4A RID: 35914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<int, string> _CoordCells;
	}
}
