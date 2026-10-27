using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016A0 RID: 5792
	[UnrealObjectPath("/Script/KuroAudio.MovieSceneKuroAudioEventTemplate")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FMovieSceneKuroAudioEventTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601500D RID: 86029 RVA: 0x001EDDB8 File Offset: 0x001EBFB8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneKuroAudioEventTemplate._ScriptStructPtr != 0) ? FMovieSceneKuroAudioEventTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAudio.MovieSceneKuroAudioEventTemplate", ref FMovieSceneKuroAudioEventTemplate._ScriptStructPtr);
		}

		// Token: 0x17005320 RID: 21280
		// (get) Token: 0x0601500E RID: 86030 RVA: 0x001EDDDC File Offset: 0x001EBFDC
		// (set) Token: 0x0601500F RID: 86031 RVA: 0x001EDDF0 File Offset: 0x001EBFF0
		[Nullable(2)]
		public unsafe UMovieSceneKuroAudioEventSection Section
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneKuroAudioEventSection>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneKuroAudioEventTemplate.__PropertyOffset_Section);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneKuroAudioEventTemplate.__PropertyOffset_Section, value);
			}
		}

		// Token: 0x06015010 RID: 86032 RVA: 0x001EDE05 File Offset: 0x001EC005
		public FMovieSceneKuroAudioEventTemplate()
		{
		}

		// Token: 0x06015011 RID: 86033 RVA: 0x001EDE0D File Offset: 0x001EC00D
		[NullableContext(1)]
		public FMovieSceneKuroAudioEventTemplate(UMovieSceneKuroAudioEventSection Section, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.Section = Section;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06015012 RID: 86034 RVA: 0x001EDE2A File Offset: 0x001EC02A
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneKuroAudioEventTemplate.StaticStruct();
		}

		// Token: 0x06015013 RID: 86035 RVA: 0x001EDE36 File Offset: 0x001EC036
		[NullableContext(2)]
		public FMovieSceneKuroAudioEventTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015014 RID: 86036 RVA: 0x001EDE40 File Offset: 0x001EC040
		public FMovieSceneKuroAudioEventTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015015 RID: 86037 RVA: 0x001EDE4B File Offset: 0x001EC04B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneKuroAudioEventTemplate(Pointer, false, true);
		}

		// Token: 0x06015016 RID: 86038 RVA: 0x001EDE55 File Offset: 0x001EC055
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneKuroAudioEventTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0400B6FC RID: 46844
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.MovieSceneKuroAudioEventTemplate";

		// Token: 0x0400B6FD RID: 46845
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B6FE RID: 46846
		internal static int __PropertyOffset_Section;
	}
}
