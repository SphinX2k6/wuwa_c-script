using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002F3 RID: 755
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RandomPlayer")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FAnimNode_RandomPlayer : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B0F RID: 11023 RVA: 0x00041892 File Offset: 0x0003FA92
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RandomPlayer._ScriptStructPtr != 0) ? FAnimNode_RandomPlayer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RandomPlayer", ref FAnimNode_RandomPlayer._ScriptStructPtr);
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x000418B8 File Offset: 0x0003FAB8
		// (set) Token: 0x06002B11 RID: 11025 RVA: 0x000418FB File Offset: 0x0003FAFB
		public TArray<FRandomPlayerSequenceEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRandomPlayerSequenceEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FRandomPlayerSequenceEntry>(base.NativePtr + (IntPtr)FAnimNode_RandomPlayer.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06002B12 RID: 11026 RVA: 0x00041909 File Offset: 0x0003FB09
		// (set) Token: 0x06002B13 RID: 11027 RVA: 0x00041919 File Offset: 0x0003FB19
		public unsafe bool bShuffleMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RandomPlayer.__PropertyOffset_bShuffleMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RandomPlayer.__PropertyOffset_bShuffleMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002B14 RID: 11028 RVA: 0x0004192A File Offset: 0x0003FB2A
		public FAnimNode_RandomPlayer()
		{
		}

		// Token: 0x06002B15 RID: 11029 RVA: 0x00041932 File Offset: 0x0003FB32
		public FAnimNode_RandomPlayer(TArray<FRandomPlayerSequenceEntry> Entries, bool bShuffleMode)
		{
			this.Entries = Entries;
			this.bShuffleMode = bShuffleMode;
		}

		// Token: 0x06002B16 RID: 11030 RVA: 0x00041948 File Offset: 0x0003FB48
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RandomPlayer.StaticStruct();
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00041954 File Offset: 0x0003FB54
		[NullableContext(2)]
		public FAnimNode_RandomPlayer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x0004195E File Offset: 0x0003FB5E
		public FAnimNode_RandomPlayer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B19 RID: 11033 RVA: 0x00041969 File Offset: 0x0003FB69
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RandomPlayer(Pointer, false, true);
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00041973 File Offset: 0x0003FB73
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RandomPlayer(Pointer, MemoryOwner);
		}

		// Token: 0x0400117D RID: 4477
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RandomPlayer";

		// Token: 0x0400117E RID: 4478
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400117F RID: 4479
		internal static int __PropertyOffset_Entries;

		// Token: 0x04001180 RID: 4480
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRandomPlayerSequenceEntry> _Entries;

		// Token: 0x04001181 RID: 4481
		internal static int __PropertyOffset_bShuffleMode;
	}
}
