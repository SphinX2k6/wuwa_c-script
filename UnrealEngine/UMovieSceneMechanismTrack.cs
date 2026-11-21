using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000463 RID: 1123
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneMechanismTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B7B RID: 27515 RVA: 0x0009C74E File Offset: 0x0009A94E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMechanismTrack._ClassPtr;
		}

		// Token: 0x06006B7C RID: 27516 RVA: 0x0009C75C File Offset: 0x0009A95C
		public UMovieSceneMechanismTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B7D RID: 27517 RVA: 0x0009C784 File Offset: 0x0009A984
		public UMovieSceneMechanismTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMechanismTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700155A RID: 5466
		// (get) Token: 0x06006B7E RID: 27518 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
		// (set) Token: 0x06006B7F RID: 27519 RVA: 0x0009C7F1 File Offset: 0x0009A9F1
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneMechanismTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x06006B80 RID: 27520 RVA: 0x0009C7FF File Offset: 0x0009A9FF
		static UMovieSceneMechanismTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack");
		}

		// Token: 0x06006B81 RID: 27521 RVA: 0x0009C80D File Offset: 0x0009AA0D
		protected UMovieSceneMechanismTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002DC1 RID: 11713
		public new const string __ObjectPath = "/Script/KuroMechanismSequenceRuntime.MovieSceneMechanismTrack";

		// Token: 0x04002DC2 RID: 11714
		private static IntPtr _ClassPtr;

		// Token: 0x04002DC3 RID: 11715
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002DC4 RID: 11716
		internal static int __PropertyOffset_Sections;

		// Token: 0x04002DC5 RID: 11717
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
