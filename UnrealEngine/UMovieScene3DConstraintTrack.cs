using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002329 RID: 9001
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DConstraintTrack")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UMovieScene3DConstraintTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060220D3 RID: 139475 RVA: 0x0032569D File Offset: 0x0032389D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DConstraintTrack._ClassPtr;
		}

		// Token: 0x060220D4 RID: 139476 RVA: 0x003256AC File Offset: 0x003238AC
		public UMovieScene3DConstraintTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DConstraintTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060220D5 RID: 139477 RVA: 0x003256D4 File Offset: 0x003238D4
		public UMovieScene3DConstraintTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DConstraintTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700838D RID: 33677
		// (get) Token: 0x060220D6 RID: 139478 RVA: 0x00325708 File Offset: 0x00323908
		// (set) Token: 0x060220D7 RID: 139479 RVA: 0x00325741 File Offset: 0x00323941
		public TArray<UMovieSceneSection> ConstraintSections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._ConstraintSections) == null)
				{
					result = (this._ConstraintSections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieScene3DConstraintTrack.__PropertyOffset_ConstraintSections, this));
				}
				return result;
			}
			set
			{
				this.ConstraintSections.CopyAssign(value);
			}
		}

		// Token: 0x060220D8 RID: 139480 RVA: 0x0032574F File Offset: 0x0032394F
		static UMovieScene3DConstraintTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DConstraintTrack");
		}

		// Token: 0x060220D9 RID: 139481 RVA: 0x0032575D File Offset: 0x0032395D
		protected UMovieScene3DConstraintTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122B7 RID: 74423
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DConstraintTrack";

		// Token: 0x040122B8 RID: 74424
		private static IntPtr _ClassPtr;

		// Token: 0x040122B9 RID: 74425
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040122BA RID: 74426
		internal static int __PropertyOffset_ConstraintSections;

		// Token: 0x040122BB RID: 74427
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _ConstraintSections;
	}
}
