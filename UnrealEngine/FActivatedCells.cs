using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020007A2 RID: 1954
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ActivatedCells")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FActivatedCells : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065DD RID: 26077 RVA: 0x000920DC File Offset: 0x000902DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActivatedCells._ScriptStructPtr != 0) ? FActivatedCells._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ActivatedCells", ref FActivatedCells._ScriptStructPtr);
		}

		// Token: 0x1700183F RID: 6207
		// (get) Token: 0x060065DE RID: 26078 RVA: 0x00092100 File Offset: 0x00090300
		// (set) Token: 0x060065DF RID: 26079 RVA: 0x00092143 File Offset: 0x00090343
		public TSet<UWorldPartitionRuntimeCell> Cells
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UWorldPartitionRuntimeCell> result;
				if ((result = this._Cells) == null)
				{
					result = (this._Cells = new TSet<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FActivatedCells.__PropertyOffset_Cells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Cells.CopyAssign(value);
			}
		}

		// Token: 0x060065E0 RID: 26080 RVA: 0x00092151 File Offset: 0x00090351
		public FActivatedCells()
		{
		}

		// Token: 0x060065E1 RID: 26081 RVA: 0x00092159 File Offset: 0x00090359
		public FActivatedCells(TSet<UWorldPartitionRuntimeCell> Cells)
		{
			this.Cells = Cells;
		}

		// Token: 0x060065E2 RID: 26082 RVA: 0x00092168 File Offset: 0x00090368
		protected override IntPtr GetUStructPtr()
		{
			return FActivatedCells.StaticStruct();
		}

		// Token: 0x060065E3 RID: 26083 RVA: 0x00092174 File Offset: 0x00090374
		[NullableContext(2)]
		public FActivatedCells(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065E4 RID: 26084 RVA: 0x0009217E File Offset: 0x0009037E
		public FActivatedCells(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065E5 RID: 26085 RVA: 0x00092189 File Offset: 0x00090389
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActivatedCells(Pointer, false, true);
		}

		// Token: 0x060065E6 RID: 26086 RVA: 0x00092193 File Offset: 0x00090393
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActivatedCells(Pointer, MemoryOwner);
		}

		// Token: 0x04003175 RID: 12661
		public const string __ObjectPath = "/Script/Engine.ActivatedCells";

		// Token: 0x04003176 RID: 12662
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003177 RID: 12663
		internal static int __PropertyOffset_Cells;

		// Token: 0x04003178 RID: 12664
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UWorldPartitionRuntimeCell> _Cells;
	}
}
