using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000756 RID: 1878
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneMediaTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3FD RID: 41981 RVA: 0x000F21B2 File Offset: 0x000F03B2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMediaTrack._ClassPtr;
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x000F21C0 File Offset: 0x000F03C0
		public UMovieSceneMediaTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x000F21E8 File Offset: 0x000F03E8
		public UMovieSceneMediaTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E61 RID: 7777
		// (get) Token: 0x0600A400 RID: 41984 RVA: 0x000F221C File Offset: 0x000F041C
		// (set) Token: 0x0600A401 RID: 41985 RVA: 0x000F2255 File Offset: 0x000F0455
		public TArray<UMovieSceneSection> MediaSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._MediaSections) == null)
				{
					result = (this._MediaSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneMediaTrack.__PropertyOffset_MediaSections, this));
				}
				return result;
			}
			set
			{
				this.MediaSections.CopyAssign(value);
			}
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x000F2263 File Offset: 0x000F0463
		static UMovieSceneMediaTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaCompositing.MovieSceneMediaTrack");
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x000F2271 File Offset: 0x000F0471
		protected UMovieSceneMediaTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045F1 RID: 17905
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaTrack";

		// Token: 0x040045F2 RID: 17906
		private static IntPtr _ClassPtr;

		// Token: 0x040045F3 RID: 17907
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040045F4 RID: 17908
		internal static int __PropertyOffset_MediaSections;

		// Token: 0x040045F5 RID: 17909
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _MediaSections;
	}
}
