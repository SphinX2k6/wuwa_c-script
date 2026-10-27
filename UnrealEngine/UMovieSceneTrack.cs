using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200244C RID: 9292
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrack")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public abstract class UMovieSceneTrack : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022D55 RID: 142677 RVA: 0x003382DA File Offset: 0x003364DA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneTrack._ClassPtr;
		}

		// Token: 0x170085ED RID: 34285
		// (get) Token: 0x06022D56 RID: 142678 RVA: 0x003382E8 File Offset: 0x003364E8
		// (set) Token: 0x06022D57 RID: 142679 RVA: 0x00338321 File Offset: 0x00336521
		public FMovieSceneTrackEvalOptions EvalOptions
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneTrackEvalOptions result;
				if ((result = this._EvalOptions) == null)
				{
					result = (this._EvalOptions = new FMovieSceneTrackEvalOptions(base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvalOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneTrackEvalOptions.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneTrack.__PropertyOffset_EvalOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085EE RID: 34286
		// (get) Token: 0x06022D58 RID: 142680 RVA: 0x00338344 File Offset: 0x00336544
		// (set) Token: 0x06022D59 RID: 142681 RVA: 0x0033837D File Offset: 0x0033657D
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

		// Token: 0x170085EF RID: 34287
		// (get) Token: 0x06022D5A RID: 142682 RVA: 0x0033838B File Offset: 0x0033658B
		// (set) Token: 0x06022D5B RID: 142683 RVA: 0x0033839B File Offset: 0x0033659B
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

		// Token: 0x170085F0 RID: 34288
		// (get) Token: 0x06022D5C RID: 142684 RVA: 0x003383AC File Offset: 0x003365AC
		// (set) Token: 0x06022D5D RID: 142685 RVA: 0x003383C0 File Offset: 0x003365C0
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

		// Token: 0x170085F1 RID: 34289
		// (get) Token: 0x06022D5E RID: 142686 RVA: 0x003383D8 File Offset: 0x003365D8
		// (set) Token: 0x06022D5F RID: 142687 RVA: 0x00338411 File Offset: 0x00336611
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

		// Token: 0x06022D60 RID: 142688 RVA: 0x00338432 File Offset: 0x00336632
		static UMovieSceneTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneTrack");
		}

		// Token: 0x06022D61 RID: 142689 RVA: 0x00338440 File Offset: 0x00336640
		protected UMovieSceneTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D62 RID: 142690 RVA: 0x00338468 File Offset: 0x00336668
		protected UMovieSceneTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012996 RID: 76182
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneTrack";

		// Token: 0x04012997 RID: 76183
		private static IntPtr _ClassPtr;

		// Token: 0x04012998 RID: 76184
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012999 RID: 76185
		internal static int __PropertyOffset_EvalOptions;

		// Token: 0x0401299A RID: 76186
		[Nullable(2)]
		private FMovieSceneTrackEvalOptions _EvalOptions;

		// Token: 0x0401299B RID: 76187
		internal static int __PropertyOffset_TrackTags;

		// Token: 0x0401299C RID: 76188
		[Nullable(2)]
		private TArray<FName> _TrackTags;

		// Token: 0x0401299D RID: 76189
		internal static int __PropertyOffset_bIsEvalDisabled;

		// Token: 0x0401299E RID: 76190
		internal static int __PropertyOffset_EvaluationFieldGuid;

		// Token: 0x0401299F RID: 76191
		internal static int __PropertyOffset_EvaluationField;

		// Token: 0x040129A0 RID: 76192
		[Nullable(2)]
		private FMovieSceneTrackEvaluationField _EvaluationField;
	}
}
