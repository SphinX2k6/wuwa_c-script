using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000760 RID: 1888
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneAudioTrack")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMovieSceneAudioTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A466 RID: 42086 RVA: 0x000F2CFA File Offset: 0x000F0EFA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAudioTrack._ClassPtr;
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x000F2D08 File Offset: 0x000F0F08
		public UMovieSceneAudioTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x000F2D30 File Offset: 0x000F0F30
		public UMovieSceneAudioTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600A469 RID: 42089 RVA: 0x000F2D64 File Offset: 0x000F0F64
		// (set) Token: 0x0600A46A RID: 42090 RVA: 0x000F2D9D File Offset: 0x000F0F9D
		public TArray<UMovieSceneSection> AudioSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._AudioSections) == null)
				{
					result = (this._AudioSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneAudioTrack.__PropertyOffset_AudioSections, this));
				}
				return result;
			}
			set
			{
				this.AudioSections.CopyAssign(value);
			}
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x000F2DAB File Offset: 0x000F0FAB
		static UMovieSceneAudioTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneAudioTrack");
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x000F2DB9 File Offset: 0x000F0FB9
		protected UMovieSceneAudioTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400461A RID: 17946
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneAudioTrack";

		// Token: 0x0400461B RID: 17947
		private static IntPtr _ClassPtr;

		// Token: 0x0400461C RID: 17948
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400461D RID: 17949
		internal static int __PropertyOffset_AudioSections;

		// Token: 0x0400461E RID: 17950
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _AudioSections;
	}
}
