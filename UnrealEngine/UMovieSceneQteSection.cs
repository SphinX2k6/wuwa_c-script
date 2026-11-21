using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CF RID: 1999
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteSection")]
	[UnrealStructLayout(544, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UMovieSceneQteSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC9E RID: 44190 RVA: 0x000FECD1 File Offset: 0x000FCED1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneQteSection._ClassPtr;
		}

		// Token: 0x0600AC9F RID: 44191 RVA: 0x000FECE0 File Offset: 0x000FCEE0
		public UMovieSceneQteSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x000FED08 File Offset: 0x000FCF08
		public UMovieSceneQteSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneQteSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x000FED3C File Offset: 0x000FCF3C
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x000FED75 File Offset: 0x000FCF75
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

		// Token: 0x0600ACA3 RID: 44195 RVA: 0x000FED96 File Offset: 0x000FCF96
		static UMovieSceneQteSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneQteSection");
		}

		// Token: 0x0600ACA4 RID: 44196 RVA: 0x000FEDA4 File Offset: 0x000FCFA4
		protected UMovieSceneQteSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A69 RID: 19049
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteSection";

		// Token: 0x04004A6A RID: 19050
		private static IntPtr _ClassPtr;

		// Token: 0x04004A6B RID: 19051
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A6C RID: 19052
		internal static int __PropertyOffset_Params;

		// Token: 0x04004A6D RID: 19053
		[Nullable(2)]
		private FMovieSceneQteParams _Params;
	}
}
