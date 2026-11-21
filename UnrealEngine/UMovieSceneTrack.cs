using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000792 RID: 1938
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrack")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public abstract class UMovieSceneTrack : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A774 RID: 42868 RVA: 0x000F726E File Offset: 0x000F546E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTrack._ClassPtr;
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600A775 RID: 42869 RVA: 0x000F727C File Offset: 0x000F547C
		// (set) Token: 0x0600A776 RID: 42870 RVA: 0x000F72B5 File Offset: 0x000F54B5
		public TArray<FName> TrackTags
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._TrackTags) == null)
				{
					result = (this._TrackTags = new TArray<FName>(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_TrackTags, this));
				}
				return result;
			}
			set
			{
				this.TrackTags.CopyAssign(value);
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600A777 RID: 42871 RVA: 0x000F72C3 File Offset: 0x000F54C3
		// (set) Token: 0x0600A778 RID: 42872 RVA: 0x000F72D3 File Offset: 0x000F54D3
		public unsafe bool bIsEvalDisabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_bIsEvalDisabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_bIsEvalDisabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x0600A779 RID: 42873 RVA: 0x000F72E4 File Offset: 0x000F54E4
		// (set) Token: 0x0600A77A RID: 42874 RVA: 0x000F72F8 File Offset: 0x000F54F8
		public unsafe FGuid EvaluationFieldGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvaluationFieldGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvaluationFieldGuid) = value;
			}
		}

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x0600A77B RID: 42875 RVA: 0x000F7310 File Offset: 0x000F5510
		// (set) Token: 0x0600A77C RID: 42876 RVA: 0x000F7349 File Offset: 0x000F5549
		public FMovieSceneTrackEvaluationField EvaluationField
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackEvaluationField result;
				if ((result = this._EvaluationField) == null)
				{
					result = (this._EvaluationField = new FMovieSceneTrackEvaluationField(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvaluationField, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackEvaluationField.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvaluationField, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x000F736A File Offset: 0x000F556A
		static UMovieSceneTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneTrack");
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x000F7378 File Offset: 0x000F5578
		protected UMovieSceneTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x000F73A0 File Offset: 0x000F55A0
		protected UMovieSceneTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047BA RID: 18362
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrack";

		// Token: 0x040047BB RID: 18363
		private static IntPtr _ClassPtr;

		// Token: 0x040047BC RID: 18364
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047BD RID: 18365
		internal static int __PropertyOffset_TrackTags;

		// Token: 0x040047BE RID: 18366
		[Nullable(2)]
		private TArray<FName> _TrackTags;

		// Token: 0x040047BF RID: 18367
		internal static int __PropertyOffset_bIsEvalDisabled;

		// Token: 0x040047C0 RID: 18368
		internal static int __PropertyOffset_EvaluationFieldGuid;

		// Token: 0x040047C1 RID: 18369
		internal static int __PropertyOffset_EvaluationField;

		// Token: 0x040047C2 RID: 18370
		[Nullable(2)]
		private FMovieSceneTrackEvaluationField _EvaluationField;
	}
}
