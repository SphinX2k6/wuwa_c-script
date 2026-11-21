using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078F RID: 1935
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSpawnTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneSpawnTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A74D RID: 42829 RVA: 0x000F6ECE File Offset: 0x000F50CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSpawnTrack._ClassPtr;
		}

		// Token: 0x0600A74E RID: 42830 RVA: 0x000F6EDC File Offset: 0x000F50DC
		public UMovieSceneSpawnTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A74F RID: 42831 RVA: 0x000F6F04 File Offset: 0x000F5104
		public UMovieSceneSpawnTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSpawnTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x0600A750 RID: 42832 RVA: 0x000F6F38 File Offset: 0x000F5138
		// (set) Token: 0x0600A751 RID: 42833 RVA: 0x000F6F71 File Offset: 0x000F5171
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600A752 RID: 42834 RVA: 0x000F6F7F File Offset: 0x000F517F
		// (set) Token: 0x0600A753 RID: 42835 RVA: 0x000F6F93 File Offset: 0x000F5193
		public unsafe FGuid ObjectGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_ObjectGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSpawnTrack.__PropertyOffset_ObjectGuid) = value;
			}
		}

		// Token: 0x0600A754 RID: 42836 RVA: 0x000F6FA8 File Offset: 0x000F51A8
		static UMovieSceneSpawnTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSpawnTrack");
		}

		// Token: 0x0600A755 RID: 42837 RVA: 0x000F6FB6 File Offset: 0x000F51B6
		protected UMovieSceneSpawnTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047A4 RID: 18340
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSpawnTrack";

		// Token: 0x040047A5 RID: 18341
		private static IntPtr _ClassPtr;

		// Token: 0x040047A6 RID: 18342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047A7 RID: 18343
		internal static int __PropertyOffset_Sections;

		// Token: 0x040047A8 RID: 18344
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x040047A9 RID: 18345
		internal static int __PropertyOffset_ObjectGuid;
	}
}
