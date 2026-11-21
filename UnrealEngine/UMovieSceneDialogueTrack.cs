using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CB RID: 1995
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueTrack")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UMovieSceneDialogueTrack : UMovieSceneNameableTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC42 RID: 44098 RVA: 0x000FE3E5 File Offset: 0x000FC5E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueTrack._ClassPtr;
		}

		// Token: 0x0600AC43 RID: 44099 RVA: 0x000FE3F4 File Offset: 0x000FC5F4
		public UMovieSceneDialogueTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AC44 RID: 44100 RVA: 0x000FE41C File Offset: 0x000FC61C
		public UMovieSceneDialogueTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x0600AC45 RID: 44101 RVA: 0x000FE450 File Offset: 0x000FC650
		// (set) Token: 0x0600AC46 RID: 44102 RVA: 0x000FE489 File Offset: 0x000FC689
		public TArray<UMovieSceneSection> Sections
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieSceneSection> result;
				if ((result = this._Sections) == null)
				{
					result = (this._Sections = new TArray<UMovieSceneSection>(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_Sections, this));
				}
				return result;
			}
			set
			{
				this.Sections.CopyAssign(value);
			}
		}

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x0600AC47 RID: 44103 RVA: 0x000FE497 File Offset: 0x000FC697
		// (set) Token: 0x0600AC48 RID: 44104 RVA: 0x000FE4A7 File Offset: 0x000FC6A7
		public unsafe ELanguageAudio LanguageType
		{
			get
			{
				return (ELanguageAudio)(*(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_LanguageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueTrack.__PropertyOffset_LanguageType) = (byte)value;
			}
		}

		// Token: 0x0600AC49 RID: 44105 RVA: 0x000FE4B8 File Offset: 0x000FC6B8
		static UMovieSceneDialogueTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueTrack");
		}

		// Token: 0x0600AC4A RID: 44106 RVA: 0x000FE4C6 File Offset: 0x000FC6C6
		protected UMovieSceneDialogueTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A35 RID: 18997
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueTrack";

		// Token: 0x04004A36 RID: 18998
		private static IntPtr _ClassPtr;

		// Token: 0x04004A37 RID: 18999
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A38 RID: 19000
		internal static int __PropertyOffset_Sections;

		// Token: 0x04004A39 RID: 19001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieSceneSection> _Sections;

		// Token: 0x04004A3A RID: 19002
		internal static int __PropertyOffset_LanguageType;
	}
}
