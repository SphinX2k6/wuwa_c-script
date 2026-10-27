using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200233D RID: 9021
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneAudioSectionTemplate")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneAudioSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060221D9 RID: 139737 RVA: 0x0032718B File Offset: 0x0032538B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAudioSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneAudioSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneAudioSectionTemplate", ref FMovieSceneAudioSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x170083CC RID: 33740
		// (get) Token: 0x060221DA RID: 139738 RVA: 0x003271AF File Offset: 0x003253AF
		// (set) Token: 0x060221DB RID: 139739 RVA: 0x003271C3 File Offset: 0x003253C3
		[Nullable(2)]
		public unsafe UMovieSceneAudioSection AudioSection
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneAudioSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAudioSectionTemplate.__PropertyOffset_AudioSection);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAudioSectionTemplate.__PropertyOffset_AudioSection, value);
			}
		}

		// Token: 0x060221DC RID: 139740 RVA: 0x003271D8 File Offset: 0x003253D8
		public FMovieSceneAudioSectionTemplate()
		{
		}

		// Token: 0x060221DD RID: 139741 RVA: 0x003271E0 File Offset: 0x003253E0
		[NullableContext(1)]
		public FMovieSceneAudioSectionTemplate(UMovieSceneAudioSection AudioSection, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.AudioSection = AudioSection;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060221DE RID: 139742 RVA: 0x003271FD File Offset: 0x003253FD
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneAudioSectionTemplate.StaticStruct();
		}

		// Token: 0x060221DF RID: 139743 RVA: 0x00327209 File Offset: 0x00325409
		[NullableContext(2)]
		public FMovieSceneAudioSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060221E0 RID: 139744 RVA: 0x00327213 File Offset: 0x00325413
		public FMovieSceneAudioSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060221E1 RID: 139745 RVA: 0x0032721E File Offset: 0x0032541E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneAudioSectionTemplate(Pointer, false, true);
		}

		// Token: 0x060221E2 RID: 139746 RVA: 0x00327228 File Offset: 0x00325428
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneAudioSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012357 RID: 74583
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneAudioSectionTemplate";

		// Token: 0x04012358 RID: 74584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012359 RID: 74585
		internal static int __PropertyOffset_AudioSection;
	}
}
