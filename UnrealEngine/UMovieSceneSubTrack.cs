using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000791 RID: 1937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneSubTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A76D RID: 42861 RVA: 0x000F71A6 File Offset: 0x000F53A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSubTrack._ClassPtr;
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x000F71B4 File Offset: 0x000F53B4
		public UMovieSceneSubTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x000F71DC File Offset: 0x000F53DC
		public UMovieSceneSubTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600A770 RID: 42864 RVA: 0x000F7210 File Offset: 0x000F5410
		// (set) Token: 0x0600A771 RID: 42865 RVA: 0x000F7249 File Offset: 0x000F5449
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSubTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x000F7257 File Offset: 0x000F5457
		static UMovieSceneSubTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSubTrack");
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x000F7265 File Offset: 0x000F5465
		protected UMovieSceneSubTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047B5 RID: 18357
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSubTrack";

		// Token: 0x040047B6 RID: 18358
		private static IntPtr _ClassPtr;

		// Token: 0x040047B7 RID: 18359
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047B8 RID: 18360
		internal static int __PropertyOffset_Sections;

		// Token: 0x040047B9 RID: 18361
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
