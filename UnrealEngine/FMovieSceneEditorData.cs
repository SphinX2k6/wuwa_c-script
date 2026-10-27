using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023E7 RID: 9191
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEditorData")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 240)]
	public class FMovieSceneEditorData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022818 RID: 141336 RVA: 0x00330A5C File Offset: 0x0032EC5C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEditorData._ScriptStructPtr != 0) ? FMovieSceneEditorData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEditorData", ref FMovieSceneEditorData._ScriptStructPtr);
		}

		// Token: 0x170084E9 RID: 34025
		// (get) Token: 0x06022819 RID: 141337 RVA: 0x00330A80 File Offset: 0x0032EC80
		// (set) Token: 0x0602281A RID: 141338 RVA: 0x00330AC3 File Offset: 0x0032ECC3
		public TMap<string, FMovieSceneExpansionState> ExpansionStates
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FMovieSceneExpansionState> result;
				if ((result = this._ExpansionStates) == null)
				{
					result = (this._ExpansionStates = new TMap<string, FMovieSceneExpansionState>(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ExpansionStates, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ExpansionStates.CopyAssign(value);
			}
		}

		// Token: 0x170084EA RID: 34026
		// (get) Token: 0x0602281B RID: 141339 RVA: 0x00330AD4 File Offset: 0x0032ECD4
		// (set) Token: 0x0602281C RID: 141340 RVA: 0x00330B17 File Offset: 0x0032ED17
		public TArray<string> PinnedNodes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._PinnedNodes) == null)
				{
					result = (this._PinnedNodes = new TArray<string>(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_PinnedNodes, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.PinnedNodes.CopyAssign(value);
			}
		}

		// Token: 0x170084EB RID: 34027
		// (get) Token: 0x0602281D RID: 141341 RVA: 0x00330B25 File Offset: 0x0032ED25
		// (set) Token: 0x0602281E RID: 141342 RVA: 0x00330B35 File Offset: 0x0032ED35
		public unsafe double ViewStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewStart) = value;
			}
		}

		// Token: 0x170084EC RID: 34028
		// (get) Token: 0x0602281F RID: 141343 RVA: 0x00330B46 File Offset: 0x0032ED46
		// (set) Token: 0x06022820 RID: 141344 RVA: 0x00330B56 File Offset: 0x0032ED56
		public unsafe double ViewEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewEnd) = value;
			}
		}

		// Token: 0x170084ED RID: 34029
		// (get) Token: 0x06022821 RID: 141345 RVA: 0x00330B67 File Offset: 0x0032ED67
		// (set) Token: 0x06022822 RID: 141346 RVA: 0x00330B77 File Offset: 0x0032ED77
		public unsafe double WorkStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkStart) = value;
			}
		}

		// Token: 0x170084EE RID: 34030
		// (get) Token: 0x06022823 RID: 141347 RVA: 0x00330B88 File Offset: 0x0032ED88
		// (set) Token: 0x06022824 RID: 141348 RVA: 0x00330B98 File Offset: 0x0032ED98
		public unsafe double WorkEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkEnd);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkEnd) = value;
			}
		}

		// Token: 0x170084EF RID: 34031
		// (get) Token: 0x06022825 RID: 141349 RVA: 0x00330BAC File Offset: 0x0032EDAC
		// (set) Token: 0x06022826 RID: 141350 RVA: 0x00330BEF File Offset: 0x0032EDEF
		public TSet<FFrameNumber> MarkedFrames_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FFrameNumber> result;
				if ((result = this._MarkedFrames_DEPRECATED) == null)
				{
					result = (this._MarkedFrames_DEPRECATED = new TSet<FFrameNumber>(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_MarkedFrames_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MarkedFrames_DEPRECATED.CopyAssign(value);
			}
		}

		// Token: 0x170084F0 RID: 34032
		// (get) Token: 0x06022827 RID: 141351 RVA: 0x00330BFD File Offset: 0x0032EDFD
		// (set) Token: 0x06022828 RID: 141352 RVA: 0x00330C11 File Offset: 0x0032EE11
		public unsafe FFloatRange WorkingRange_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkingRange_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_WorkingRange_DEPRECATED) = value;
			}
		}

		// Token: 0x170084F1 RID: 34033
		// (get) Token: 0x06022829 RID: 141353 RVA: 0x00330C26 File Offset: 0x0032EE26
		// (set) Token: 0x0602282A RID: 141354 RVA: 0x00330C3A File Offset: 0x0032EE3A
		public unsafe FFloatRange ViewRange_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewRange_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEditorData.__PropertyOffset_ViewRange_DEPRECATED) = value;
			}
		}

		// Token: 0x0602282B RID: 141355 RVA: 0x00330C4F File Offset: 0x0032EE4F
		public FMovieSceneEditorData()
		{
		}

		// Token: 0x0602282C RID: 141356 RVA: 0x00330C58 File Offset: 0x0032EE58
		public FMovieSceneEditorData(TMap<string, FMovieSceneExpansionState> ExpansionStates, TArray<string> PinnedNodes, double ViewStart, double ViewEnd, double WorkStart, double WorkEnd, TSet<FFrameNumber> MarkedFrames_DEPRECATED, FFloatRange WorkingRange_DEPRECATED, FFloatRange ViewRange_DEPRECATED)
		{
			this.ExpansionStates = ExpansionStates;
			this.PinnedNodes = PinnedNodes;
			this.ViewStart = ViewStart;
			this.ViewEnd = ViewEnd;
			this.WorkStart = WorkStart;
			this.WorkEnd = WorkEnd;
			this.MarkedFrames_DEPRECATED = MarkedFrames_DEPRECATED;
			this.WorkingRange_DEPRECATED = WorkingRange_DEPRECATED;
			this.ViewRange_DEPRECATED = ViewRange_DEPRECATED;
		}

		// Token: 0x0602282D RID: 141357 RVA: 0x00330CB0 File Offset: 0x0032EEB0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEditorData.StaticStruct();
		}

		// Token: 0x0602282E RID: 141358 RVA: 0x00330CBC File Offset: 0x0032EEBC
		[NullableContext(2)]
		public FMovieSceneEditorData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602282F RID: 141359 RVA: 0x00330CC6 File Offset: 0x0032EEC6
		public FMovieSceneEditorData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022830 RID: 141360 RVA: 0x00330CD1 File Offset: 0x0032EED1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEditorData(Pointer, false, true);
		}

		// Token: 0x06022831 RID: 141361 RVA: 0x00330CDB File Offset: 0x0032EEDB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEditorData(Pointer, MemoryOwner);
		}

		// Token: 0x0401271D RID: 75549
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEditorData";

		// Token: 0x0401271E RID: 75550
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401271F RID: 75551
		internal static int __PropertyOffset_ExpansionStates;

		// Token: 0x04012720 RID: 75552
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FMovieSceneExpansionState> _ExpansionStates;

		// Token: 0x04012721 RID: 75553
		internal static int __PropertyOffset_PinnedNodes;

		// Token: 0x04012722 RID: 75554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _PinnedNodes;

		// Token: 0x04012723 RID: 75555
		internal static int __PropertyOffset_ViewStart;

		// Token: 0x04012724 RID: 75556
		internal static int __PropertyOffset_ViewEnd;

		// Token: 0x04012725 RID: 75557
		internal static int __PropertyOffset_WorkStart;

		// Token: 0x04012726 RID: 75558
		internal static int __PropertyOffset_WorkEnd;

		// Token: 0x04012727 RID: 75559
		internal static int __PropertyOffset_MarkedFrames_DEPRECATED;

		// Token: 0x04012728 RID: 75560
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FFrameNumber> _MarkedFrames_DEPRECATED;

		// Token: 0x04012729 RID: 75561
		internal static int __PropertyOffset_WorkingRange_DEPRECATED;

		// Token: 0x0401272A RID: 75562
		internal static int __PropertyOffset_ViewRange_DEPRECATED;
	}
}
