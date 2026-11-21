using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007D0 RID: 2000
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneQteTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ACA5 RID: 44197 RVA: 0x000FEDAD File Offset: 0x000FCFAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteTrack._ClassPtr;
		}

		// Token: 0x0600ACA6 RID: 44198 RVA: 0x000FEDBC File Offset: 0x000FCFBC
		public UMovieSceneQteTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ACA7 RID: 44199 RVA: 0x000FEDE4 File Offset: 0x000FCFE4
		public UMovieSceneQteTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x0600ACA8 RID: 44200 RVA: 0x000FEE18 File Offset: 0x000FD018
		// (set) Token: 0x0600ACA9 RID: 44201 RVA: 0x000FEE51 File Offset: 0x000FD051
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneQteTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600ACAA RID: 44202 RVA: 0x000FEE5F File Offset: 0x000FD05F
		static UMovieSceneQteTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteTrack");
		}

		// Token: 0x0600ACAB RID: 44203 RVA: 0x000FEE6D File Offset: 0x000FD06D
		protected UMovieSceneQteTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A6E RID: 19054
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteTrack";

		// Token: 0x04004A6F RID: 19055
		private static IntPtr _ClassPtr;

		// Token: 0x04004A70 RID: 19056
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A71 RID: 19057
		internal static int __PropertyOffset_Sections;

		// Token: 0x04004A72 RID: 19058
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
