using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000793 RID: 1939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackEvaluationField")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackEvaluationField : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A780 RID: 42880 RVA: 0x000F73A9 File Offset: 0x000F55A9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackEvaluationField._ScriptStructPtr != 0) ? FMovieSceneTrackEvaluationField._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackEvaluationField", ref FMovieSceneTrackEvaluationField._ScriptStructPtr);
		}

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x0600A781 RID: 42881 RVA: 0x000F73D0 File Offset: 0x000F55D0
		// (set) Token: 0x0600A782 RID: 42882 RVA: 0x000F7413 File Offset: 0x000F5613
		public TArray<FMovieSceneTrackEvaluationFieldEntry> Entries
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneTrackEvaluationFieldEntry> result;
				if ((result = this._Entries) == null)
				{
					result = (this._Entries = new TArray<FMovieSceneTrackEvaluationFieldEntry>(base.NativePtr + (IntPtr)FMovieSceneTrackEvaluationField.__PropertyOffset_Entries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Entries.CopyAssign(value);
			}
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x000F7421 File Offset: 0x000F5621
		public FMovieSceneTrackEvaluationField()
		{
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x000F7429 File Offset: 0x000F5629
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackEvaluationField.StaticStruct();
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x000F7435 File Offset: 0x000F5635
		[NullableContext(2)]
		public FMovieSceneTrackEvaluationField(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x000F743F File Offset: 0x000F563F
		public FMovieSceneTrackEvaluationField(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x000F744A File Offset: 0x000F564A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackEvaluationField(Pointer, false, true);
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x000F7454 File Offset: 0x000F5654
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackEvaluationField(Pointer, MemoryOwner);
		}

		// Token: 0x040047C3 RID: 18371
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackEvaluationField";

		// Token: 0x040047C4 RID: 18372
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040047C5 RID: 18373
		internal static int __PropertyOffset_Entries;

		// Token: 0x040047C6 RID: 18374
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneTrackEvaluationFieldEntry> _Entries;
	}
}
