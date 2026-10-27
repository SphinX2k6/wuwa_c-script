using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200128D RID: 4749
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionUpdateStreamingTargetState")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FWorldPartitionUpdateStreamingTargetState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011676 RID: 71286 RVA: 0x00198B7E File Offset: 0x00196D7E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionUpdateStreamingTargetState._ScriptStructPtr != 0) ? FWorldPartitionUpdateStreamingTargetState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionUpdateStreamingTargetState", ref FWorldPartitionUpdateStreamingTargetState._ScriptStructPtr);
		}

		// Token: 0x170043C6 RID: 17350
		// (get) Token: 0x06011677 RID: 71287 RVA: 0x00198BA4 File Offset: 0x00196DA4
		// (set) Token: 0x06011678 RID: 71288 RVA: 0x00198BE7 File Offset: 0x00196DE7
		public TArray<UWorldPartitionRuntimeCell> ToLoadCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._ToLoadCells) == null)
				{
					result = (this._ToLoadCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_ToLoadCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToLoadCells.CopyAssign(value);
			}
		}

		// Token: 0x170043C7 RID: 17351
		// (get) Token: 0x06011679 RID: 71289 RVA: 0x00198BF8 File Offset: 0x00196DF8
		// (set) Token: 0x0601167A RID: 71290 RVA: 0x00198C3B File Offset: 0x00196E3B
		public TArray<UWorldPartitionRuntimeCell> ToActivateCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._ToActivateCells) == null)
				{
					result = (this._ToActivateCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_ToActivateCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToActivateCells.CopyAssign(value);
			}
		}

		// Token: 0x170043C8 RID: 17352
		// (get) Token: 0x0601167B RID: 71291 RVA: 0x00198C4C File Offset: 0x00196E4C
		// (set) Token: 0x0601167C RID: 71292 RVA: 0x00198C8F File Offset: 0x00196E8F
		public TArray<UWorldPartitionRuntimeCell> ToDeactivateCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._ToDeactivateCells) == null)
				{
					result = (this._ToDeactivateCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_ToDeactivateCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToDeactivateCells.CopyAssign(value);
			}
		}

		// Token: 0x170043C9 RID: 17353
		// (get) Token: 0x0601167D RID: 71293 RVA: 0x00198CA0 File Offset: 0x00196EA0
		// (set) Token: 0x0601167E RID: 71294 RVA: 0x00198CE3 File Offset: 0x00196EE3
		public TArray<UWorldPartitionRuntimeCell> ToUnloadCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._ToUnloadCells) == null)
				{
					result = (this._ToUnloadCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_ToUnloadCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToUnloadCells.CopyAssign(value);
			}
		}

		// Token: 0x170043CA RID: 17354
		// (get) Token: 0x0601167F RID: 71295 RVA: 0x00198CF4 File Offset: 0x00196EF4
		// (set) Token: 0x06011680 RID: 71296 RVA: 0x00198D37 File Offset: 0x00196F37
		public TArray<UWorldPartitionRuntimeCell> NotGoodCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._NotGoodCells) == null)
				{
					result = (this._NotGoodCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_NotGoodCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.NotGoodCells.CopyAssign(value);
			}
		}

		// Token: 0x170043CB RID: 17355
		// (get) Token: 0x06011681 RID: 71297 RVA: 0x00198D48 File Offset: 0x00196F48
		// (set) Token: 0x06011682 RID: 71298 RVA: 0x00198D8B File Offset: 0x00196F8B
		public TArray<UWorldPartitionRuntimeCell> ToBehaviorChangeCells
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartitionRuntimeCell> result;
				if ((result = this._ToBehaviorChangeCells) == null)
				{
					result = (this._ToBehaviorChangeCells = new TArray<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingTargetState.__PropertyOffset_ToBehaviorChangeCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ToBehaviorChangeCells.CopyAssign(value);
			}
		}

		// Token: 0x06011683 RID: 71299 RVA: 0x00198D99 File Offset: 0x00196F99
		public FWorldPartitionUpdateStreamingTargetState()
		{
		}

		// Token: 0x06011684 RID: 71300 RVA: 0x00198DA1 File Offset: 0x00196FA1
		public FWorldPartitionUpdateStreamingTargetState(TArray<UWorldPartitionRuntimeCell> ToLoadCells, TArray<UWorldPartitionRuntimeCell> ToActivateCells, TArray<UWorldPartitionRuntimeCell> ToDeactivateCells, TArray<UWorldPartitionRuntimeCell> ToUnloadCells, TArray<UWorldPartitionRuntimeCell> NotGoodCells, TArray<UWorldPartitionRuntimeCell> ToBehaviorChangeCells)
		{
			this.ToLoadCells = ToLoadCells;
			this.ToActivateCells = ToActivateCells;
			this.ToDeactivateCells = ToDeactivateCells;
			this.ToUnloadCells = ToUnloadCells;
			this.NotGoodCells = NotGoodCells;
			this.ToBehaviorChangeCells = ToBehaviorChangeCells;
		}

		// Token: 0x06011685 RID: 71301 RVA: 0x00198DD6 File Offset: 0x00196FD6
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionUpdateStreamingTargetState.StaticStruct();
		}

		// Token: 0x06011686 RID: 71302 RVA: 0x00198DE2 File Offset: 0x00196FE2
		[NullableContext(2)]
		public FWorldPartitionUpdateStreamingTargetState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011687 RID: 71303 RVA: 0x00198DEC File Offset: 0x00196FEC
		public FWorldPartitionUpdateStreamingTargetState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011688 RID: 71304 RVA: 0x00198DF7 File Offset: 0x00196FF7
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionUpdateStreamingTargetState(Pointer, false, true);
		}

		// Token: 0x06011689 RID: 71305 RVA: 0x00198E01 File Offset: 0x00197001
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionUpdateStreamingTargetState(Pointer, MemoryOwner);
		}

		// Token: 0x040094F7 RID: 38135
		public const string __ObjectPath = "/Script/Engine.WorldPartitionUpdateStreamingTargetState";

		// Token: 0x040094F8 RID: 38136
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040094F9 RID: 38137
		internal static int __PropertyOffset_ToLoadCells;

		// Token: 0x040094FA RID: 38138
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _ToLoadCells;

		// Token: 0x040094FB RID: 38139
		internal static int __PropertyOffset_ToActivateCells;

		// Token: 0x040094FC RID: 38140
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _ToActivateCells;

		// Token: 0x040094FD RID: 38141
		internal static int __PropertyOffset_ToDeactivateCells;

		// Token: 0x040094FE RID: 38142
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _ToDeactivateCells;

		// Token: 0x040094FF RID: 38143
		internal static int __PropertyOffset_ToUnloadCells;

		// Token: 0x04009500 RID: 38144
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _ToUnloadCells;

		// Token: 0x04009501 RID: 38145
		internal static int __PropertyOffset_NotGoodCells;

		// Token: 0x04009502 RID: 38146
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _NotGoodCells;

		// Token: 0x04009503 RID: 38147
		internal static int __PropertyOffset_ToBehaviorChangeCells;

		// Token: 0x04009504 RID: 38148
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartitionRuntimeCell> _ToBehaviorChangeCells;
	}
}
