using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F5 RID: 9973
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteSection")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UMovieSceneQteSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024FF0 RID: 151536 RVA: 0x0036BB04 File Offset: 0x00369D04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteSection._ClassPtr;
		}

		// Token: 0x06024FF1 RID: 151537 RVA: 0x0036BB10 File Offset: 0x00369D10
		public UMovieSceneQteSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024FF2 RID: 151538 RVA: 0x0036BB38 File Offset: 0x00369D38
		public UMovieSceneQteSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EE0 RID: 36576
		// (get) Token: 0x06024FF3 RID: 151539 RVA: 0x0036BB6C File Offset: 0x00369D6C
		// (set) Token: 0x06024FF4 RID: 151540 RVA: 0x0036BBA5 File Offset: 0x00369DA5
		public FMovieSceneQteParams Params
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneQteParams result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new FMovieSceneQteParams(base.NativePtr + (IntPtr)UMovieSceneQteSection.__PropertyOffset_Params, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneQteParams.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneQteSection.__PropertyOffset_Params, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06024FF5 RID: 151541 RVA: 0x0036BBC6 File Offset: 0x00369DC6
		static UMovieSceneQteSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteSection");
		}

		// Token: 0x06024FF6 RID: 151542 RVA: 0x0036BBD4 File Offset: 0x00369DD4
		protected UMovieSceneQteSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EFE RID: 81662
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteSection";

		// Token: 0x04013EFF RID: 81663
		private static IntPtr _ClassPtr;

		// Token: 0x04013F00 RID: 81664
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013F01 RID: 81665
		internal static int __PropertyOffset_Params;

		// Token: 0x04013F02 RID: 81666
		[Nullable(2)]
		private FMovieSceneQteParams _Params;
	}
}
