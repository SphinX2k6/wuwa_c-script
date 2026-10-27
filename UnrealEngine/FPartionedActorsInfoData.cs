using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FCB RID: 4043
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PartionedActorsInfoData")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FPartionedActorsInfoData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DA19 RID: 55833 RVA: 0x00141E80 File Offset: 0x00140080
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPartionedActorsInfoData._ScriptStructPtr != 0) ? FPartionedActorsInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PartionedActorsInfoData", ref FPartionedActorsInfoData._ScriptStructPtr);
		}

		// Token: 0x1700337B RID: 13179
		// (get) Token: 0x0600DA1A RID: 55834 RVA: 0x00141EA4 File Offset: 0x001400A4
		// (set) Token: 0x0600DA1B RID: 55835 RVA: 0x00141EB8 File Offset: 0x001400B8
		public unsafe string GridName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPartionedActorsInfoData.__PropertyOffset_GridName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPartionedActorsInfoData.__PropertyOffset_GridName)), value);
			}
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600DA1C RID: 55836 RVA: 0x00141ECD File Offset: 0x001400CD
		// (set) Token: 0x0600DA1D RID: 55837 RVA: 0x00141EE1 File Offset: 0x001400E1
		public unsafe string CellName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPartionedActorsInfoData.__PropertyOffset_CellName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPartionedActorsInfoData.__PropertyOffset_CellName)), value);
			}
		}

		// Token: 0x1700337D RID: 13181
		// (get) Token: 0x0600DA1E RID: 55838 RVA: 0x00141EF6 File Offset: 0x001400F6
		// (set) Token: 0x0600DA1F RID: 55839 RVA: 0x00141F06 File Offset: 0x00140106
		public unsafe int Level
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_Level);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_Level) = value;
			}
		}

		// Token: 0x1700337E RID: 13182
		// (get) Token: 0x0600DA20 RID: 55840 RVA: 0x00141F17 File Offset: 0x00140117
		// (set) Token: 0x0600DA21 RID: 55841 RVA: 0x00141F27 File Offset: 0x00140127
		public unsafe int CellSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_CellSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_CellSize) = value;
			}
		}

		// Token: 0x1700337F RID: 13183
		// (get) Token: 0x0600DA22 RID: 55842 RVA: 0x00141F38 File Offset: 0x00140138
		// (set) Token: 0x0600DA23 RID: 55843 RVA: 0x00141F48 File Offset: 0x00140148
		public unsafe int GridSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_GridSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_GridSize) = value;
			}
		}

		// Token: 0x17003380 RID: 13184
		// (get) Token: 0x0600DA24 RID: 55844 RVA: 0x00141F59 File Offset: 0x00140159
		// (set) Token: 0x0600DA25 RID: 55845 RVA: 0x00141F69 File Offset: 0x00140169
		public unsafe int PcLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcLoadingRange) = value;
			}
		}

		// Token: 0x17003381 RID: 13185
		// (get) Token: 0x0600DA26 RID: 55846 RVA: 0x00141F7A File Offset: 0x0014017A
		// (set) Token: 0x0600DA27 RID: 55847 RVA: 0x00141F8A File Offset: 0x0014018A
		public unsafe int PcMinStreamingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcMinStreamingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcMinStreamingRange) = value;
			}
		}

		// Token: 0x17003382 RID: 13186
		// (get) Token: 0x0600DA28 RID: 55848 RVA: 0x00141F9B File Offset: 0x0014019B
		// (set) Token: 0x0600DA29 RID: 55849 RVA: 0x00141FAB File Offset: 0x001401AB
		public unsafe int PcMaxStreamingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcMaxStreamingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_PcMaxStreamingRange) = value;
			}
		}

		// Token: 0x17003383 RID: 13187
		// (get) Token: 0x0600DA2A RID: 55850 RVA: 0x00141FBC File Offset: 0x001401BC
		// (set) Token: 0x0600DA2B RID: 55851 RVA: 0x00141FCC File Offset: 0x001401CC
		public unsafe int MobileLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileLoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileLoadingRange) = value;
			}
		}

		// Token: 0x17003384 RID: 13188
		// (get) Token: 0x0600DA2C RID: 55852 RVA: 0x00141FDD File Offset: 0x001401DD
		// (set) Token: 0x0600DA2D RID: 55853 RVA: 0x00141FED File Offset: 0x001401ED
		public unsafe int MobileMinStreamingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileMinStreamingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileMinStreamingRange) = value;
			}
		}

		// Token: 0x17003385 RID: 13189
		// (get) Token: 0x0600DA2E RID: 55854 RVA: 0x00141FFE File Offset: 0x001401FE
		// (set) Token: 0x0600DA2F RID: 55855 RVA: 0x0014200E File Offset: 0x0014020E
		public unsafe int MobileMaxStreamingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileMaxStreamingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPartionedActorsInfoData.__PropertyOffset_MobileMaxStreamingRange) = value;
			}
		}

		// Token: 0x0600DA30 RID: 55856 RVA: 0x0014201F File Offset: 0x0014021F
		public FPartionedActorsInfoData()
		{
		}

		// Token: 0x0600DA31 RID: 55857 RVA: 0x00142028 File Offset: 0x00140228
		public FPartionedActorsInfoData(string GridName, string CellName, int Level, int CellSize, int GridSize, int PcLoadingRange, int PcMinStreamingRange, int PcMaxStreamingRange, int MobileLoadingRange, int MobileMinStreamingRange, int MobileMaxStreamingRange)
		{
			this.GridName = GridName;
			this.CellName = CellName;
			this.Level = Level;
			this.CellSize = CellSize;
			this.GridSize = GridSize;
			this.PcLoadingRange = PcLoadingRange;
			this.PcMinStreamingRange = PcMinStreamingRange;
			this.PcMaxStreamingRange = PcMaxStreamingRange;
			this.MobileLoadingRange = MobileLoadingRange;
			this.MobileMinStreamingRange = MobileMinStreamingRange;
			this.MobileMaxStreamingRange = MobileMaxStreamingRange;
		}

		// Token: 0x0600DA32 RID: 55858 RVA: 0x00142090 File Offset: 0x00140290
		protected override IntPtr GetUStructPtr()
		{
			return FPartionedActorsInfoData.StaticStruct();
		}

		// Token: 0x0600DA33 RID: 55859 RVA: 0x0014209C File Offset: 0x0014029C
		[NullableContext(2)]
		public FPartionedActorsInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DA34 RID: 55860 RVA: 0x001420A6 File Offset: 0x001402A6
		public FPartionedActorsInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DA35 RID: 55861 RVA: 0x001420B1 File Offset: 0x001402B1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPartionedActorsInfoData(Pointer, false, true);
		}

		// Token: 0x0600DA36 RID: 55862 RVA: 0x001420BB File Offset: 0x001402BB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPartionedActorsInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x0400763F RID: 30271
		public new const string __ObjectPath = "/Script/Engine.PartionedActorsInfoData";

		// Token: 0x04007640 RID: 30272
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007641 RID: 30273
		internal static int __PropertyOffset_GridName;

		// Token: 0x04007642 RID: 30274
		internal static int __PropertyOffset_CellName;

		// Token: 0x04007643 RID: 30275
		internal static int __PropertyOffset_Level;

		// Token: 0x04007644 RID: 30276
		internal static int __PropertyOffset_CellSize;

		// Token: 0x04007645 RID: 30277
		internal static int __PropertyOffset_GridSize;

		// Token: 0x04007646 RID: 30278
		internal static int __PropertyOffset_PcLoadingRange;

		// Token: 0x04007647 RID: 30279
		internal static int __PropertyOffset_PcMinStreamingRange;

		// Token: 0x04007648 RID: 30280
		internal static int __PropertyOffset_PcMaxStreamingRange;

		// Token: 0x04007649 RID: 30281
		internal static int __PropertyOffset_MobileLoadingRange;

		// Token: 0x0400764A RID: 30282
		internal static int __PropertyOffset_MobileMinStreamingRange;

		// Token: 0x0400764B RID: 30283
		internal static int __PropertyOffset_MobileMaxStreamingRange;
	}
}
