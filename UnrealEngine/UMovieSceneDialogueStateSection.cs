using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026EB RID: 9963
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueStateSection")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class UMovieSceneDialogueStateSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F45 RID: 151365 RVA: 0x0036A88E File Offset: 0x00368A8E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueStateSection._ClassPtr;
		}

		// Token: 0x06024F46 RID: 151366 RVA: 0x0036A89C File Offset: 0x00368A9C
		public UMovieSceneDialogueStateSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F47 RID: 151367 RVA: 0x0036A8C4 File Offset: 0x00368AC4
		[NullableContext(1)]
		public UMovieSceneDialogueStateSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueStateSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EB2 RID: 36530
		// (get) Token: 0x06024F48 RID: 151368 RVA: 0x0036A8F7 File Offset: 0x00368AF7
		// (set) Token: 0x06024F49 RID: 151369 RVA: 0x0036A90B File Offset: 0x00368B0B
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

		// Token: 0x06024F4A RID: 151370 RVA: 0x0036A920 File Offset: 0x00368B20
		static UMovieSceneDialogueStateSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueStateSection");
		}

		// Token: 0x06024F4B RID: 151371 RVA: 0x0036A92E File Offset: 0x00368B2E
		protected UMovieSceneDialogueStateSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E9D RID: 81565
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueStateSection";

		// Token: 0x04013E9E RID: 81566
		private static IntPtr _ClassPtr;

		// Token: 0x04013E9F RID: 81567
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EA0 RID: 81568
		internal static int __PropertyOffset_SectionData;
	}
}
