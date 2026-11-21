using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C9 RID: 1993
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueStateTrack")]
	[UnrealStructLayout(256, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 256)]
	public class UMovieSceneDialogueStateTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC24 RID: 44068 RVA: 0x000FDEE7 File Offset: 0x000FC0E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueStateTrack._ClassPtr;
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x000FDEF4 File Offset: 0x000FC0F4
		public UMovieSceneDialogueStateTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x000FDF1C File Offset: 0x000FC11C
		public UMovieSceneDialogueStateTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002013 RID: 8211
		// (get) Token: 0x0600AC27 RID: 44071 RVA: 0x000FDF50 File Offset: 0x000FC150
		// (set) Token: 0x0600AC28 RID: 44072 RVA: 0x000FDF89 File Offset: 0x000FC189
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneDialogueStateTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x000FDF97 File Offset: 0x000FC197
		static UMovieSceneDialogueStateTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueStateTrack");
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x000FDFA5 File Offset: 0x000FC1A5
		protected UMovieSceneDialogueStateTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A1E RID: 18974
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueStateTrack";

		// Token: 0x04004A1F RID: 18975
		private static IntPtr _ClassPtr;

		// Token: 0x04004A20 RID: 18976
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A21 RID: 18977
		internal static int __PropertyOffset_Sections;

		// Token: 0x04004A22 RID: 18978
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;
	}
}
