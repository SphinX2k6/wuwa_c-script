using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000282 RID: 642
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioEventTemplate")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneAkAudioEventTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002422 RID: 9250 RVA: 0x0003597F File Offset: 0x00033B7F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneAkAudioEventTemplate._ScriptStructPtr != 0) ? FMovieSceneAkAudioEventTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.MovieSceneAkAudioEventTemplate", ref FMovieSceneAkAudioEventTemplate._ScriptStructPtr);
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x06002423 RID: 9251 RVA: 0x000359A3 File Offset: 0x00033BA3
		// (set) Token: 0x06002424 RID: 9252 RVA: 0x000359B7 File Offset: 0x00033BB7
		[Nullable(2)]
		public unsafe UMovieSceneAkAudioEventSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneAkAudioEventSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAkAudioEventTemplate.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneAkAudioEventTemplate.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000359CC File Offset: 0x00033BCC
		public FMovieSceneAkAudioEventTemplate()
		{
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000359D4 File Offset: 0x00033BD4
		[NullableContext(1)]
		public FMovieSceneAkAudioEventTemplate(UMovieSceneAkAudioEventSection Section, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Section = Section;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000359F1 File Offset: 0x00033BF1
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneAkAudioEventTemplate.StaticStruct();
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000359FD File Offset: 0x00033BFD
		[NullableContext(2)]
		public FMovieSceneAkAudioEventTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x00035A07 File Offset: 0x00033C07
		public FMovieSceneAkAudioEventTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600242A RID: 9258 RVA: 0x00035A12 File Offset: 0x00033C12
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneAkAudioEventTemplate(Pointer, false, true);
		}

		// Token: 0x0600242B RID: 9259 RVA: 0x00035A1C File Offset: 0x00033C1C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneAkAudioEventTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04000DB4 RID: 3508
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioEventTemplate";

		// Token: 0x04000DB5 RID: 3509
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000DB6 RID: 3510
		internal static int __PropertyOffset_Section;
	}
}
