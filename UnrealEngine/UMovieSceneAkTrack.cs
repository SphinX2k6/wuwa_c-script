using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D7 RID: 215
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UMovieSceneAkTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F4F RID: 3919 RVA: 0x00017A4A File Offset: 0x00015C4A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkTrack._ClassPtr;
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000F50 RID: 3920 RVA: 0x00017A58 File Offset: 0x00015C58
		// (set) Token: 0x06000F51 RID: 3921 RVA: 0x00017A91 File Offset: 0x00015C91
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

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000F52 RID: 3922 RVA: 0x00017A9F File Offset: 0x00015C9F
		// (set) Token: 0x06000F53 RID: 3923 RVA: 0x00017AAF File Offset: 0x00015CAF
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

		// Token: 0x06000F54 RID: 3924 RVA: 0x00017AC0 File Offset: 0x00015CC0
		static UMovieSceneAkTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkTrack");
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00017AD0 File Offset: 0x00015CD0
		protected UMovieSceneAkTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00017AF8 File Offset: 0x00015CF8
		protected UMovieSceneAkTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000361 RID: 865
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkTrack";

		// Token: 0x04000362 RID: 866
		private static IntPtr _ClassPtr;

		// Token: 0x04000363 RID: 867
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000364 RID: 868
		internal static int __PropertyOffset_Sections;

		// Token: 0x04000365 RID: 869
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x04000366 RID: 870
		internal static int __PropertyOffset_bIsAMasterTrack;
	}
}
