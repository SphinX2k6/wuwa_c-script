using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002387 RID: 9095
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilityTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMovieSceneLevelVisibilityTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022492 RID: 140434 RVA: 0x0032B40A File Offset: 0x0032960A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneLevelVisibilityTrack._ClassPtr;
		}

		// Token: 0x06022493 RID: 140435 RVA: 0x0032B418 File Offset: 0x00329618
		public UMovieSceneLevelVisibilityTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilityTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022494 RID: 140436 RVA: 0x0032B440 File Offset: 0x00329640
		public UMovieSceneLevelVisibilityTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneLevelVisibilityTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008437 RID: 33847
		// (get) Token: 0x06022495 RID: 140437 RVA: 0x0032B474 File Offset: 0x00329674
		// (set) Token: 0x06022496 RID: 140438 RVA: 0x0032B4AD File Offset: 0x003296AD
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneLevelVisibilityTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06022497 RID: 140439 RVA: 0x0032B4BB File Offset: 0x003296BB
		static UMovieSceneLevelVisibilityTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneLevelVisibilityTrack");
		}

		// Token: 0x06022498 RID: 140440 RVA: 0x0032B4C9 File Offset: 0x003296C9
		protected UMovieSceneLevelVisibilityTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124DA RID: 74970
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneLevelVisibilityTrack";

		// Token: 0x040124DB RID: 74971
		private static IntPtr _ClassPtr;

		// Token: 0x040124DC RID: 74972
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124DD RID: 74973
		internal static int __PropertyOffset_Sections;

		// Token: 0x040124DE RID: 74974
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
