using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200076A RID: 1898
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFadeSection")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMovieSceneFadeSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A4B6 RID: 42166 RVA: 0x000F34A1 File Offset: 0x000F16A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFadeSection._ClassPtr;
		}

		// Token: 0x0600A4B7 RID: 42167 RVA: 0x000F34B0 File Offset: 0x000F16B0
		public UMovieSceneFadeSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A4B8 RID: 42168 RVA: 0x000F34D8 File Offset: 0x000F16D8
		public UMovieSceneFadeSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x0600A4B9 RID: 42169 RVA: 0x000F350C File Offset: 0x000F170C
		// (set) Token: 0x0600A4BA RID: 42170 RVA: 0x000F3545 File Offset: 0x000F1745
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

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600A4BB RID: 42171 RVA: 0x000F3566 File Offset: 0x000F1766
		// (set) Token: 0x0600A4BC RID: 42172 RVA: 0x000F357A File Offset: 0x000F177A
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

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600A4BD RID: 42173 RVA: 0x000F358F File Offset: 0x000F178F
		// (set) Token: 0x0600A4BE RID: 42174 RVA: 0x000F35A8 File Offset: 0x000F17A8
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

		// Token: 0x0600A4BF RID: 42175 RVA: 0x000F35D8 File Offset: 0x000F17D8
		static UMovieSceneFadeSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFadeSection");
		}

		// Token: 0x0600A4C0 RID: 42176 RVA: 0x000F35E6 File Offset: 0x000F17E6
		protected UMovieSceneFadeSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004647 RID: 17991
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFadeSection";

		// Token: 0x04004648 RID: 17992
		private static IntPtr _ClassPtr;

		// Token: 0x04004649 RID: 17993
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400464A RID: 17994
		internal static int __PropertyOffset_FloatCurve;

		// Token: 0x0400464B RID: 17995
		[Nullable(2)]
		private FMovieSceneFloatChannel _FloatCurve;

		// Token: 0x0400464C RID: 17996
		internal static int __PropertyOffset_FadeColor;

		// Token: 0x0400464D RID: 17997
		internal static int __PropertyOffset_bFadeAudio;

		// Token: 0x0400464E RID: 17998
		internal static byte __PropertyMask_bFadeAudio;
	}
}
