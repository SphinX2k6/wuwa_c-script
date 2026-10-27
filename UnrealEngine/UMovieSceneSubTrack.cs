using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002446 RID: 9286
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMovieSceneSubTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022D15 RID: 142613 RVA: 0x00337C40 File Offset: 0x00335E40
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSubTrack._ClassPtr;
		}

		// Token: 0x06022D16 RID: 142614 RVA: 0x00337C4C File Offset: 0x00335E4C
		public UMovieSceneSubTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022D17 RID: 142615 RVA: 0x00337C74 File Offset: 0x00335E74
		public UMovieSceneSubTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSubTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170085E3 RID: 34275
		// (get) Token: 0x06022D18 RID: 142616 RVA: 0x00337CA8 File Offset: 0x00335EA8
		// (set) Token: 0x06022D19 RID: 142617 RVA: 0x00337CE1 File Offset: 0x00335EE1
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

		// Token: 0x06022D1A RID: 142618 RVA: 0x00337CEF File Offset: 0x00335EEF
		static UMovieSceneSubTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSubTrack");
		}

		// Token: 0x06022D1B RID: 142619 RVA: 0x00337CFD File Offset: 0x00335EFD
		protected UMovieSceneSubTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012972 RID: 76146
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSubTrack";

		// Token: 0x04012973 RID: 76147
		private static IntPtr _ClassPtr;

		// Token: 0x04012974 RID: 76148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012975 RID: 76149
		internal static int __PropertyOffset_Sections;

		// Token: 0x04012976 RID: 76150
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
