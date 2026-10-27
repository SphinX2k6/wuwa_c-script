using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002379 RID: 9081
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFadeSection")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UMovieSceneFadeSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022421 RID: 140321 RVA: 0x0032A939 File Offset: 0x00328B39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFadeSection._ClassPtr;
		}

		// Token: 0x06022422 RID: 140322 RVA: 0x0032A948 File Offset: 0x00328B48
		public UMovieSceneFadeSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022423 RID: 140323 RVA: 0x0032A970 File Offset: 0x00328B70
		public UMovieSceneFadeSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700842B RID: 33835
		// (get) Token: 0x06022424 RID: 140324 RVA: 0x0032A9A4 File Offset: 0x00328BA4
		// (set) Token: 0x06022425 RID: 140325 RVA: 0x0032A9DD File Offset: 0x00328BDD
		public FMovieSceneFloatChannel FloatCurve
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._FloatCurve) == null)
				{
					result = (this._FloatCurve = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_FloatCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_FloatCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700842C RID: 33836
		// (get) Token: 0x06022426 RID: 140326 RVA: 0x0032A9FE File Offset: 0x00328BFE
		// (set) Token: 0x06022427 RID: 140327 RVA: 0x0032AA12 File Offset: 0x00328C12
		public unsafe FLinearColor FadeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_FadeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_FadeColor) = value;
			}
		}

		// Token: 0x1700842D RID: 33837
		// (get) Token: 0x06022428 RID: 140328 RVA: 0x0032AA27 File Offset: 0x00328C27
		// (set) Token: 0x06022429 RID: 140329 RVA: 0x0032AA40 File Offset: 0x00328C40
		public unsafe bool bFadeAudio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_bFadeAudio) & UMovieSceneFadeSection.__PropertyMask_bFadeAudio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_bFadeAudio) = ((*(base.NativePtr + (IntPtr)UMovieSceneFadeSection.__PropertyOffset_bFadeAudio) & ~UMovieSceneFadeSection.__PropertyMask_bFadeAudio) | (value ? UMovieSceneFadeSection.__PropertyMask_bFadeAudio : 0));
			}
		}

		// Token: 0x0602242A RID: 140330 RVA: 0x0032AA70 File Offset: 0x00328C70
		static UMovieSceneFadeSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFadeSection");
		}

		// Token: 0x0602242B RID: 140331 RVA: 0x0032AA7E File Offset: 0x00328C7E
		protected UMovieSceneFadeSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012499 RID: 74905
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFadeSection";

		// Token: 0x0401249A RID: 74906
		private static IntPtr _ClassPtr;

		// Token: 0x0401249B RID: 74907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401249C RID: 74908
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x0401249D RID: 74909
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatCurve;

		// Token: 0x0401249E RID: 74910
		internal static int __PropertyOffset_FadeColor;

		// Token: 0x0401249F RID: 74911
		internal static int __PropertyOffset_bFadeAudio;

		// Token: 0x040124A0 RID: 74912
		internal static byte __PropertyMask_bFadeAudio;
	}
}
