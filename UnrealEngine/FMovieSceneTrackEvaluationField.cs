using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200244F RID: 9295
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackEvaluationField")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneTrackEvaluationField : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D7F RID: 142719 RVA: 0x00338723 File Offset: 0x00336923
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackEvaluationField._ScriptStructPtr != 0) ? FMovieSceneTrackEvaluationField._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackEvaluationField", ref FMovieSceneTrackEvaluationField._ScriptStructPtr);
		}

		// Token: 0x170085F8 RID: 34296
		// (get) Token: 0x06022D80 RID: 142720 RVA: 0x00338748 File Offset: 0x00336948
		// (set) Token: 0x06022D81 RID: 142721 RVA: 0x0033878B File Offset: 0x0033698B
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

		// Token: 0x06022D82 RID: 142722 RVA: 0x00338799 File Offset: 0x00336999
		public FMovieSceneTrackEvaluationField()
		{
		}

		// Token: 0x06022D83 RID: 142723 RVA: 0x003387A1 File Offset: 0x003369A1
		public FMovieSceneTrackEvaluationField(TArray<FMovieSceneTrackEvaluationFieldEntry> Entries)
		{
			this.Entries = Entries;
		}

		// Token: 0x06022D84 RID: 142724 RVA: 0x003387B0 File Offset: 0x003369B0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackEvaluationField.StaticStruct();
		}

		// Token: 0x06022D85 RID: 142725 RVA: 0x003387BC File Offset: 0x003369BC
		[NullableContext(2)]
		public FMovieSceneTrackEvaluationField(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D86 RID: 142726 RVA: 0x003387C6 File Offset: 0x003369C6
		public FMovieSceneTrackEvaluationField(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D87 RID: 142727 RVA: 0x003387D1 File Offset: 0x003369D1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackEvaluationField(Pointer, false, true);
		}

		// Token: 0x06022D88 RID: 142728 RVA: 0x003387DB File Offset: 0x003369DB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackEvaluationField(Pointer, MemoryOwner);
		}

		// Token: 0x040129B1 RID: 76209
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackEvaluationField";

		// Token: 0x040129B2 RID: 76210
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129B3 RID: 76211
		internal static int __PropertyOffset_Entries;

		// Token: 0x040129B4 RID: 76212
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneTrackEvaluationFieldEntry> _Entries;
	}
}
