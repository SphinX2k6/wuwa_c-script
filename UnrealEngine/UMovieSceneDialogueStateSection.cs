using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C8 RID: 1992
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueStateSection")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UMovieSceneDialogueStateSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC1D RID: 44061 RVA: 0x000FDE3D File Offset: 0x000FC03D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueStateSection._ClassPtr;
		}

		// Token: 0x0600AC1E RID: 44062 RVA: 0x000FDE4C File Offset: 0x000FC04C
		public UMovieSceneDialogueStateSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AC1F RID: 44063 RVA: 0x000FDE74 File Offset: 0x000FC074
		[NullableContext(1)]
		public UMovieSceneDialogueStateSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002012 RID: 8210
		// (get) Token: 0x0600AC20 RID: 44064 RVA: 0x000FDEA7 File Offset: 0x000FC0A7
		// (set) Token: 0x0600AC21 RID: 44065 RVA: 0x000FDEBB File Offset: 0x000FC0BB
		public unsafe FDialogueStateStruct SectionData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueStateSection.__PropertyOffset_SectionData);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueStateSection.__PropertyOffset_SectionData) = value;
			}
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x000FDED0 File Offset: 0x000FC0D0
		static UMovieSceneDialogueStateSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueStateSection");
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x000FDEDE File Offset: 0x000FC0DE
		protected UMovieSceneDialogueStateSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A1A RID: 18970
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueStateSection";

		// Token: 0x04004A1B RID: 18971
		private static IntPtr _ClassPtr;

		// Token: 0x04004A1C RID: 18972
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A1D RID: 18973
		internal static int __PropertyOffset_SectionData;
	}
}
