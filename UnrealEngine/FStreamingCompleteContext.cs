using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011AA RID: 4522
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.StreamingCompleteContext")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FStreamingCompleteContext : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010AB4 RID: 68276 RVA: 0x00187B7E File Offset: 0x00185D7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStreamingCompleteContext._ScriptStructPtr != 0) ? FStreamingCompleteContext._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.StreamingCompleteContext", ref FStreamingCompleteContext._ScriptStructPtr);
		}

		// Token: 0x17004114 RID: 16660
		// (get) Token: 0x06010AB5 RID: 68277 RVA: 0x00187BA4 File Offset: 0x00185DA4
		// (set) Token: 0x06010AB6 RID: 68278 RVA: 0x00187BE7 File Offset: 0x00185DE7
		public TArray<FName> DataLayerLabels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._DataLayerLabels) == null)
				{
					result = (this._DataLayerLabels = new TArray<FName>(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_DataLayerLabels, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DataLayerLabels.CopyAssign(value);
			}
		}

		// Token: 0x17004115 RID: 16661
		// (get) Token: 0x06010AB7 RID: 68279 RVA: 0x00187BF5 File Offset: 0x00185DF5
		// (set) Token: 0x06010AB8 RID: 68280 RVA: 0x00187C05 File Offset: 0x00185E05
		public unsafe bool bUseCustomLoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bUseCustomLoadingRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bUseCustomLoadingRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004116 RID: 16662
		// (get) Token: 0x06010AB9 RID: 68281 RVA: 0x00187C16 File Offset: 0x00185E16
		// (set) Token: 0x06010ABA RID: 68282 RVA: 0x00187C26 File Offset: 0x00185E26
		public unsafe float LoadingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_LoadingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_LoadingRange) = value;
			}
		}

		// Token: 0x17004117 RID: 16663
		// (get) Token: 0x06010ABB RID: 68283 RVA: 0x00187C37 File Offset: 0x00185E37
		// (set) Token: 0x06010ABC RID: 68284 RVA: 0x00187C47 File Offset: 0x00185E47
		public unsafe bool bNeedProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bNeedProgress) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bNeedProgress) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004118 RID: 16664
		// (get) Token: 0x06010ABD RID: 68285 RVA: 0x00187C58 File Offset: 0x00185E58
		// (set) Token: 0x06010ABE RID: 68286 RVA: 0x00187C68 File Offset: 0x00185E68
		public unsafe bool bRequirePhysicsReady
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bRequirePhysicsReady) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bRequirePhysicsReady) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004119 RID: 16665
		// (get) Token: 0x06010ABF RID: 68287 RVA: 0x00187C79 File Offset: 0x00185E79
		// (set) Token: 0x06010AC0 RID: 68288 RVA: 0x00187C89 File Offset: 0x00185E89
		public unsafe bool bNeedUnCompletedCells
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bNeedUnCompletedCells) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_bNeedUnCompletedCells) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700411A RID: 16666
		// (get) Token: 0x06010AC1 RID: 68289 RVA: 0x00187C9A File Offset: 0x00185E9A
		// (set) Token: 0x06010AC2 RID: 68290 RVA: 0x00187CAA File Offset: 0x00185EAA
		public unsafe int CellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_CellNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_CellNum) = value;
			}
		}

		// Token: 0x1700411B RID: 16667
		// (get) Token: 0x06010AC3 RID: 68291 RVA: 0x00187CBB File Offset: 0x00185EBB
		// (set) Token: 0x06010AC4 RID: 68292 RVA: 0x00187CCB File Offset: 0x00185ECB
		public unsafe int NotMatchCellNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_NotMatchCellNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_NotMatchCellNum) = value;
			}
		}

		// Token: 0x1700411C RID: 16668
		// (get) Token: 0x06010AC5 RID: 68293 RVA: 0x00187CDC File Offset: 0x00185EDC
		// (set) Token: 0x06010AC6 RID: 68294 RVA: 0x00187D1F File Offset: 0x00185F1F
		public TArray<FName> UnCompletedCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._UnCompletedCells) == null)
				{
					result = (this._UnCompletedCells = new TArray<FName>(base.NativePtr + (IntPtr)FStreamingCompleteContext.__PropertyOffset_UnCompletedCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnCompletedCells.CopyAssign(value);
			}
		}

		// Token: 0x06010AC7 RID: 68295 RVA: 0x00187D2D File Offset: 0x00185F2D
		public FStreamingCompleteContext()
		{
		}

		// Token: 0x06010AC8 RID: 68296 RVA: 0x00187D38 File Offset: 0x00185F38
		public FStreamingCompleteContext(TArray<FName> DataLayerLabels, bool bUseCustomLoadingRange, float LoadingRange, bool bNeedProgress, bool bRequirePhysicsReady, bool bNeedUnCompletedCells, int CellNum, int NotMatchCellNum, TArray<FName> UnCompletedCells)
		{
			this.DataLayerLabels = DataLayerLabels;
			this.bUseCustomLoadingRange = bUseCustomLoadingRange;
			this.LoadingRange = LoadingRange;
			this.bNeedProgress = bNeedProgress;
			this.bRequirePhysicsReady = bRequirePhysicsReady;
			this.bNeedUnCompletedCells = bNeedUnCompletedCells;
			this.CellNum = CellNum;
			this.NotMatchCellNum = NotMatchCellNum;
			this.UnCompletedCells = UnCompletedCells;
		}

		// Token: 0x06010AC9 RID: 68297 RVA: 0x00187D90 File Offset: 0x00185F90
		protected override IntPtr GetUStructPtr()
		{
			return FStreamingCompleteContext.StaticStruct();
		}

		// Token: 0x06010ACA RID: 68298 RVA: 0x00187D9C File Offset: 0x00185F9C
		[NullableContext(2)]
		public FStreamingCompleteContext(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010ACB RID: 68299 RVA: 0x00187DA6 File Offset: 0x00185FA6
		public FStreamingCompleteContext(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010ACC RID: 68300 RVA: 0x00187DB1 File Offset: 0x00185FB1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStreamingCompleteContext(Pointer, false, true);
		}

		// Token: 0x06010ACD RID: 68301 RVA: 0x00187DBB File Offset: 0x00185FBB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStreamingCompleteContext(Pointer, MemoryOwner);
		}

		// Token: 0x04008EA5 RID: 36517
		public const string __ObjectPath = "/Script/Engine.StreamingCompleteContext";

		// Token: 0x04008EA6 RID: 36518
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EA7 RID: 36519
		internal static int __PropertyOffset_DataLayerLabels;

		// Token: 0x04008EA8 RID: 36520
		[Nullable(2)]
		private TArray<FName> _DataLayerLabels;

		// Token: 0x04008EA9 RID: 36521
		internal static int __PropertyOffset_bUseCustomLoadingRange;

		// Token: 0x04008EAA RID: 36522
		internal static int __PropertyOffset_LoadingRange;

		// Token: 0x04008EAB RID: 36523
		internal static int __PropertyOffset_bNeedProgress;

		// Token: 0x04008EAC RID: 36524
		internal static int __PropertyOffset_bRequirePhysicsReady;

		// Token: 0x04008EAD RID: 36525
		internal static int __PropertyOffset_bNeedUnCompletedCells;

		// Token: 0x04008EAE RID: 36526
		internal static int __PropertyOffset_CellNum;

		// Token: 0x04008EAF RID: 36527
		internal static int __PropertyOffset_NotMatchCellNum;

		// Token: 0x04008EB0 RID: 36528
		internal static int __PropertyOffset_UnCompletedCells;

		// Token: 0x04008EB1 RID: 36529
		[Nullable(2)]
		private TArray<FName> _UnCompletedCells;
	}
}
