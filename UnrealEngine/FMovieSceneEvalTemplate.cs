using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023F1 RID: 9201
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvalTemplate")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FMovieSceneEvalTemplate : FMovieSceneEvalTemplateBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022877 RID: 141431 RVA: 0x00331361 File Offset: 0x0032F561
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvalTemplate._ScriptStructPtr != 0) ? FMovieSceneEvalTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvalTemplate", ref FMovieSceneEvalTemplate._ScriptStructPtr);
		}

		// Token: 0x170084FB RID: 34043
		// (get) Token: 0x06022878 RID: 141432 RVA: 0x00331385 File Offset: 0x0032F585
		// (set) Token: 0x06022879 RID: 141433 RVA: 0x00331395 File Offset: 0x0032F595
		public unsafe EMovieSceneCompletionMode CompletionMode
		{
			get
			{
				return (EMovieSceneCompletionMode)(*(base.NativePtr + (IntPtr)FMovieSceneEvalTemplate.__PropertyOffset_CompletionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvalTemplate.__PropertyOffset_CompletionMode) = (byte)value;
			}
		}

		// Token: 0x170084FC RID: 34044
		// (get) Token: 0x0602287A RID: 141434 RVA: 0x003313A6 File Offset: 0x0032F5A6
		// (set) Token: 0x0602287B RID: 141435 RVA: 0x003313BA File Offset: 0x0032F5BA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvalTemplate.__PropertyOffset_SourceSectionPtr);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvalTemplate.__PropertyOffset_SourceSectionPtr) = value;
			}
		}

		// Token: 0x0602287C RID: 141436 RVA: 0x003313CF File Offset: 0x0032F5CF
		public FMovieSceneEvalTemplate()
		{
		}

		// Token: 0x0602287D RID: 141437 RVA: 0x003313D7 File Offset: 0x0032F5D7
		public FMovieSceneEvalTemplate(EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.CompletionMode = CompletionMode;
			this.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x0602287E RID: 141438 RVA: 0x003313ED File Offset: 0x0032F5ED
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvalTemplate.StaticStruct();
		}

		// Token: 0x0602287F RID: 141439 RVA: 0x003313F9 File Offset: 0x0032F5F9
		[NullableContext(2)]
		public FMovieSceneEvalTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022880 RID: 141440 RVA: 0x00331403 File Offset: 0x0032F603
		public FMovieSceneEvalTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022881 RID: 141441 RVA: 0x0033140E File Offset: 0x0032F60E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvalTemplate(Pointer, false, true);
		}

		// Token: 0x06022882 RID: 141442 RVA: 0x00331418 File Offset: 0x0032F618
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvalTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x0401274F RID: 75599
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneEvalTemplate";

		// Token: 0x04012750 RID: 75600
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012751 RID: 75601
		internal static int __PropertyOffset_CompletionMode;

		// Token: 0x04012752 RID: 75602
		internal static int __PropertyOffset_SourceSectionPtr;
	}
}
