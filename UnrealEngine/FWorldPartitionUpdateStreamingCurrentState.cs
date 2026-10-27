using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200128C RID: 4748
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionUpdateStreamingCurrentState")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FWorldPartitionUpdateStreamingCurrentState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011668 RID: 71272 RVA: 0x001989F5 File Offset: 0x00196BF5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FWorldPartitionUpdateStreamingCurrentState._ScriptStructPtr != 0) ? FWorldPartitionUpdateStreamingCurrentState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.WorldPartitionUpdateStreamingCurrentState", ref FWorldPartitionUpdateStreamingCurrentState._ScriptStructPtr);
		}

		// Token: 0x170043C3 RID: 17347
		// (get) Token: 0x06011669 RID: 71273 RVA: 0x00198A1C File Offset: 0x00196C1C
		// (set) Token: 0x0601166A RID: 71274 RVA: 0x00198A5F File Offset: 0x00196C5F
		public TSet<UWorldPartitionRuntimeCell> LoadedCells
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UWorldPartitionRuntimeCell> result;
				if ((result = this._LoadedCells) == null)
				{
					result = (this._LoadedCells = new TSet<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingCurrentState.__PropertyOffset_LoadedCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LoadedCells.CopyAssign(value);
			}
		}

		// Token: 0x170043C4 RID: 17348
		// (get) Token: 0x0601166B RID: 71275 RVA: 0x00198A70 File Offset: 0x00196C70
		// (set) Token: 0x0601166C RID: 71276 RVA: 0x00198AB3 File Offset: 0x00196CB3
		public FActivatedCells ActivatedCells
		{
			get
			{
				base.FastCheckIsValid();
				FActivatedCells result;
				if ((result = this._ActivatedCells) == null)
				{
					result = (this._ActivatedCells = new FActivatedCells(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingCurrentState.__PropertyOffset_ActivatedCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FActivatedCells.StaticStruct(), base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingCurrentState.__PropertyOffset_ActivatedCells, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170043C5 RID: 17349
		// (get) Token: 0x0601166D RID: 71277 RVA: 0x00198AD4 File Offset: 0x00196CD4
		// (set) Token: 0x0601166E RID: 71278 RVA: 0x00198B17 File Offset: 0x00196D17
		public TSet<UWorldPartitionRuntimeCell> ExternalStreamingCells
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UWorldPartitionRuntimeCell> result;
				if ((result = this._ExternalStreamingCells) == null)
				{
					result = (this._ExternalStreamingCells = new TSet<UWorldPartitionRuntimeCell>(base.NativePtr + (IntPtr)FWorldPartitionUpdateStreamingCurrentState.__PropertyOffset_ExternalStreamingCells, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExternalStreamingCells.CopyAssign(value);
			}
		}

		// Token: 0x0601166F RID: 71279 RVA: 0x00198B25 File Offset: 0x00196D25
		public FWorldPartitionUpdateStreamingCurrentState()
		{
		}

		// Token: 0x06011670 RID: 71280 RVA: 0x00198B2D File Offset: 0x00196D2D
		public FWorldPartitionUpdateStreamingCurrentState(TSet<UWorldPartitionRuntimeCell> LoadedCells, FActivatedCells ActivatedCells, TSet<UWorldPartitionRuntimeCell> ExternalStreamingCells)
		{
			this.LoadedCells = LoadedCells;
			this.ActivatedCells = ActivatedCells;
			this.ExternalStreamingCells = ExternalStreamingCells;
		}

		// Token: 0x06011671 RID: 71281 RVA: 0x00198B4A File Offset: 0x00196D4A
		protected override IntPtr GetUStructPtr()
		{
			return FWorldPartitionUpdateStreamingCurrentState.StaticStruct();
		}

		// Token: 0x06011672 RID: 71282 RVA: 0x00198B56 File Offset: 0x00196D56
		[NullableContext(2)]
		public FWorldPartitionUpdateStreamingCurrentState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011673 RID: 71283 RVA: 0x00198B60 File Offset: 0x00196D60
		public FWorldPartitionUpdateStreamingCurrentState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011674 RID: 71284 RVA: 0x00198B6B File Offset: 0x00196D6B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FWorldPartitionUpdateStreamingCurrentState(Pointer, false, true);
		}

		// Token: 0x06011675 RID: 71285 RVA: 0x00198B75 File Offset: 0x00196D75
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FWorldPartitionUpdateStreamingCurrentState(Pointer, MemoryOwner);
		}

		// Token: 0x040094EF RID: 38127
		public const string __ObjectPath = "/Script/Engine.WorldPartitionUpdateStreamingCurrentState";

		// Token: 0x040094F0 RID: 38128
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040094F1 RID: 38129
		internal static int __PropertyOffset_LoadedCells;

		// Token: 0x040094F2 RID: 38130
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UWorldPartitionRuntimeCell> _LoadedCells;

		// Token: 0x040094F3 RID: 38131
		internal static int __PropertyOffset_ActivatedCells;

		// Token: 0x040094F4 RID: 38132
		[Nullable(2)]
		private FActivatedCells _ActivatedCells;

		// Token: 0x040094F5 RID: 38133
		internal static int __PropertyOffset_ExternalStreamingCells;

		// Token: 0x040094F6 RID: 38134
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UWorldPartitionRuntimeCell> _ExternalStreamingCells;
	}
}
