using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002449 RID: 9289
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTimecodeSource")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMovieSceneTimecodeSource : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D31 RID: 142641 RVA: 0x00337F9A File Offset: 0x0033619A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTimecodeSource._ScriptStructPtr != 0) ? FMovieSceneTimecodeSource._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTimecodeSource", ref FMovieSceneTimecodeSource._ScriptStructPtr);
		}

		// Token: 0x170085E7 RID: 34279
		// (get) Token: 0x06022D32 RID: 142642 RVA: 0x00337FBE File Offset: 0x003361BE
		// (set) Token: 0x06022D33 RID: 142643 RVA: 0x00337FD2 File Offset: 0x003361D2
		public unsafe FTimecode Timecode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneTimecodeSource.__PropertyOffset_Timecode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneTimecodeSource.__PropertyOffset_Timecode) = value;
			}
		}

		// Token: 0x170085E8 RID: 34280
		// (get) Token: 0x06022D34 RID: 142644 RVA: 0x00337FE8 File Offset: 0x003361E8
		// (set) Token: 0x06022D35 RID: 142645 RVA: 0x0033802B File Offset: 0x0033622B
		public FFrameNumber DeltaFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._DeltaFrame) == null)
				{
					result = (this._DeltaFrame = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneTimecodeSource.__PropertyOffset_DeltaFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneTimecodeSource.__PropertyOffset_DeltaFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022D36 RID: 142646 RVA: 0x0033804C File Offset: 0x0033624C
		public FMovieSceneTimecodeSource()
		{
		}

		// Token: 0x06022D37 RID: 142647 RVA: 0x00338054 File Offset: 0x00336254
		public FMovieSceneTimecodeSource(FTimecode Timecode, FFrameNumber DeltaFrame)
		{
			this.Timecode = Timecode;
			this.DeltaFrame = DeltaFrame;
		}

		// Token: 0x06022D38 RID: 142648 RVA: 0x0033806A File Offset: 0x0033626A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTimecodeSource.StaticStruct();
		}

		// Token: 0x06022D39 RID: 142649 RVA: 0x00338076 File Offset: 0x00336276
		[NullableContext(2)]
		public FMovieSceneTimecodeSource(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D3A RID: 142650 RVA: 0x00338080 File Offset: 0x00336280
		public FMovieSceneTimecodeSource(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D3B RID: 142651 RVA: 0x0033808B File Offset: 0x0033628B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTimecodeSource(Pointer, false, true);
		}

		// Token: 0x06022D3C RID: 142652 RVA: 0x00338095 File Offset: 0x00336295
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTimecodeSource(Pointer, MemoryOwner);
		}

		// Token: 0x04012986 RID: 76166
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTimecodeSource";

		// Token: 0x04012987 RID: 76167
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012988 RID: 76168
		internal static int __PropertyOffset_Timecode;

		// Token: 0x04012989 RID: 76169
		internal static int __PropertyOffset_DeltaFrame;

		// Token: 0x0401298A RID: 76170
		[Nullable(2)]
		private FFrameNumber _DeltaFrame;
	}
}
