using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200238A RID: 9098
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneMaterialTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMovieSceneMaterialTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060224AB RID: 140459 RVA: 0x0032B663 File Offset: 0x00329863
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMaterialTrack._ClassPtr;
		}

		// Token: 0x060224AC RID: 140460 RVA: 0x0032B670 File Offset: 0x00329870
		public UMovieSceneMaterialTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMaterialTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060224AD RID: 140461 RVA: 0x0032B698 File Offset: 0x00329898
		public UMovieSceneMaterialTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMaterialTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700843A RID: 33850
		// (get) Token: 0x060224AE RID: 140462 RVA: 0x0032B6CC File Offset: 0x003298CC
		// (set) Token: 0x060224AF RID: 140463 RVA: 0x0032B705 File Offset: 0x00329905
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneMaterialTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x060224B0 RID: 140464 RVA: 0x0032B713 File Offset: 0x00329913
		static UMovieSceneMaterialTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneMaterialTrack");
		}

		// Token: 0x060224B1 RID: 140465 RVA: 0x0032B721 File Offset: 0x00329921
		protected UMovieSceneMaterialTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124E7 RID: 74983
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneMaterialTrack";

		// Token: 0x040124E8 RID: 74984
		private static IntPtr _ClassPtr;

		// Token: 0x040124E9 RID: 74985
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040124EA RID: 74986
		internal static int __PropertyOffset_Sections;

		// Token: 0x040124EB RID: 74987
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
