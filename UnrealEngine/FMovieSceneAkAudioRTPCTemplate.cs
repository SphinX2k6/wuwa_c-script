using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000285 RID: 645
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioRTPCTemplate")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneAkAudioRTPCTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002441 RID: 9281 RVA: 0x00035C91 File Offset: 0x00033E91
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAkAudioRTPCTemplate._ScriptStructPtr != 0) ? FMovieSceneAkAudioRTPCTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.MovieSceneAkAudioRTPCTemplate", ref FMovieSceneAkAudioRTPCTemplate._ScriptStructPtr);
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002442 RID: 9282 RVA: 0x00035CB5 File Offset: 0x00033EB5
		// (set) Token: 0x06002443 RID: 9283 RVA: 0x00035CC9 File Offset: 0x00033EC9
		[Nullable(2)]
		public unsafe UMovieSceneAkAudioRTPCSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneAkAudioRTPCSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAkAudioRTPCTemplate.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAkAudioRTPCTemplate.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x06002444 RID: 9284 RVA: 0x00035CDE File Offset: 0x00033EDE
		public FMovieSceneAkAudioRTPCTemplate()
		{
		}

		// Token: 0x06002445 RID: 9285 RVA: 0x00035CE6 File Offset: 0x00033EE6
		[NullableContext(1)]
		public FMovieSceneAkAudioRTPCTemplate(UMovieSceneAkAudioRTPCSection Section, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Section = Section;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06002446 RID: 9286 RVA: 0x00035D03 File Offset: 0x00033F03
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneAkAudioRTPCTemplate.StaticStruct();
		}

		// Token: 0x06002447 RID: 9287 RVA: 0x00035D0F File Offset: 0x00033F0F
		[NullableContext(2)]
		public FMovieSceneAkAudioRTPCTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002448 RID: 9288 RVA: 0x00035D19 File Offset: 0x00033F19
		public FMovieSceneAkAudioRTPCTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00035D24 File Offset: 0x00033F24
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneAkAudioRTPCTemplate(Pointer, false, true);
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00035D2E File Offset: 0x00033F2E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneAkAudioRTPCTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04000DC6 RID: 3526
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioRTPCTemplate";

		// Token: 0x04000DC7 RID: 3527
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DC8 RID: 3528
		internal static int __PropertyOffset_Section;
	}
}
