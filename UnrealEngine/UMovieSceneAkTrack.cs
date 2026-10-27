using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000287 RID: 647
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkTrack")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public abstract class UMovieSceneAkTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002451 RID: 9297 RVA: 0x00035DBE File Offset: 0x00033FBE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkTrack._ClassPtr;
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x00035DCC File Offset: 0x00033FCC
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x00035E05 File Offset: 0x00034005
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneAkTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002454 RID: 9300 RVA: 0x00035E13 File Offset: 0x00034013
		// (set) Token: 0x06002455 RID: 9301 RVA: 0x00035E23 File Offset: 0x00034023
		public unsafe bool bIsAMasterTrack
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkTrack.__PropertyOffset_bIsAMasterTrack) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkTrack.__PropertyOffset_bIsAMasterTrack) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002456 RID: 9302 RVA: 0x00035E34 File Offset: 0x00034034
		static UMovieSceneAkTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkTrack");
		}

		// Token: 0x06002457 RID: 9303 RVA: 0x00035E44 File Offset: 0x00034044
		protected UMovieSceneAkTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002458 RID: 9304 RVA: 0x00035E6C File Offset: 0x0003406C
		protected UMovieSceneAkTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DCD RID: 3533
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkTrack";

		// Token: 0x04000DCE RID: 3534
		private static IntPtr _ClassPtr;

		// Token: 0x04000DCF RID: 3535
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000DD0 RID: 3536
		internal static int __PropertyOffset_Sections;

		// Token: 0x04000DD1 RID: 3537
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x04000DD2 RID: 3538
		internal static int __PropertyOffset_bIsAMasterTrack;
	}
}
