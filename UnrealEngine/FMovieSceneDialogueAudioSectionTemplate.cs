using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026E5 RID: 9957
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueAudioSectionTemplate")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FMovieSceneDialogueAudioSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024ED7 RID: 151255 RVA: 0x00369DE0 File Offset: 0x00367FE0
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneDialogueAudioSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneDialogueAudioSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneDialogueAudioSectionTemplate", ref FMovieSceneDialogueAudioSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008E91 RID: 36497
		// (get) Token: 0x06024ED8 RID: 151256 RVA: 0x00369E04 File Offset: 0x00368004
		// (set) Token: 0x06024ED9 RID: 151257 RVA: 0x00369E18 File Offset: 0x00368018
		public unsafe string AudioKey
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueAudioSectionTemplate.__PropertyOffset_AudioKey)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueAudioSectionTemplate.__PropertyOffset_AudioKey)), value);
			}
		}

		// Token: 0x17008E92 RID: 36498
		// (get) Token: 0x06024EDA RID: 151258 RVA: 0x00369E2D File Offset: 0x0036802D
		// (set) Token: 0x06024EDB RID: 151259 RVA: 0x00369E3D File Offset: 0x0036803D
		public unsafe int AudioTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueAudioSectionTemplate.__PropertyOffset_AudioTransitionDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueAudioSectionTemplate.__PropertyOffset_AudioTransitionDuration) = value;
			}
		}

		// Token: 0x06024EDC RID: 151260 RVA: 0x00369E4E File Offset: 0x0036804E
		public FMovieSceneDialogueAudioSectionTemplate()
		{
		}

		// Token: 0x06024EDD RID: 151261 RVA: 0x00369E56 File Offset: 0x00368056
		public FMovieSceneDialogueAudioSectionTemplate(string AudioKey, int AudioTransitionDuration, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.AudioKey = AudioKey;
			this.AudioTransitionDuration = AudioTransitionDuration;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024EDE RID: 151262 RVA: 0x00369E7B File Offset: 0x0036807B
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneDialogueAudioSectionTemplate.StaticStruct();
		}

		// Token: 0x06024EDF RID: 151263 RVA: 0x00369E87 File Offset: 0x00368087
		[NullableContext(2)]
		public FMovieSceneDialogueAudioSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024EE0 RID: 151264 RVA: 0x00369E91 File Offset: 0x00368091
		public FMovieSceneDialogueAudioSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024EE1 RID: 151265 RVA: 0x00369E9C File Offset: 0x0036809C
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneDialogueAudioSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06024EE2 RID: 151266 RVA: 0x00369EA6 File Offset: 0x003680A6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneDialogueAudioSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013E5F RID: 81503
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueAudioSectionTemplate";

		// Token: 0x04013E60 RID: 81504
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013E61 RID: 81505
		internal static int __PropertyOffset_AudioKey;

		// Token: 0x04013E62 RID: 81506
		internal static int __PropertyOffset_AudioTransitionDuration;
	}
}
