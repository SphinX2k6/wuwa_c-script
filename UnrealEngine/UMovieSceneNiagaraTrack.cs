using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200252E RID: 9518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.MovieSceneNiagaraTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMovieSceneNiagaraTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602356F RID: 144751 RVA: 0x00344465 File Offset: 0x00342665
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNiagaraTrack._ClassPtr;
		}

		// Token: 0x06023570 RID: 144752 RVA: 0x00344474 File Offset: 0x00342674
		public UMovieSceneNiagaraTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023571 RID: 144753 RVA: 0x0034449C File Offset: 0x0034269C
		public UMovieSceneNiagaraTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNiagaraTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087DF RID: 34783
		// (get) Token: 0x06023572 RID: 144754 RVA: 0x003444D0 File Offset: 0x003426D0
		// (set) Token: 0x06023573 RID: 144755 RVA: 0x00344509 File Offset: 0x00342709
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneNiagaraTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06023574 RID: 144756 RVA: 0x00344517 File Offset: 0x00342717
		static UMovieSceneNiagaraTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.MovieSceneNiagaraTrack");
		}

		// Token: 0x06023575 RID: 144757 RVA: 0x00344525 File Offset: 0x00342725
		protected UMovieSceneNiagaraTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F87 RID: 77703
		public new const string __ObjectPath = "/Script/Niagara.MovieSceneNiagaraTrack";

		// Token: 0x04012F88 RID: 77704
		private static IntPtr _ClassPtr;

		// Token: 0x04012F89 RID: 77705
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F8A RID: 77706
		internal static int __PropertyOffset_Sections;

		// Token: 0x04012F8B RID: 77707
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
