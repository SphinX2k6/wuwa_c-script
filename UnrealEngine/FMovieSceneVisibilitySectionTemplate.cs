using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023BC RID: 9148
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVisibilitySectionTemplate")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FMovieSceneVisibilitySectionTemplate : FMovieSceneBoolPropertySectionTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060226CB RID: 141003 RVA: 0x0032E8D7 File Offset: 0x0032CAD7
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneVisibilitySectionTemplate._ScriptStructPtr != 0) ? FMovieSceneVisibilitySectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieSceneTracks.MovieSceneVisibilitySectionTemplate", ref FMovieSceneVisibilitySectionTemplate._ScriptStructPtr);
		}

		// Token: 0x060226CC RID: 141004 RVA: 0x0032E8FB File Offset: 0x0032CAFB
		public FMovieSceneVisibilitySectionTemplate()
		{
		}

		// Token: 0x060226CD RID: 141005 RVA: 0x0032E903 File Offset: 0x0032CB03
		[NullableContext(1)]
		public FMovieSceneVisibilitySectionTemplate(FMovieSceneBoolChannel BoolCurve, FMovieScenePropertySectionData PropertyData, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			base.BoolCurve = BoolCurve;
			base.PropertyData = PropertyData;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x060226CE RID: 141006 RVA: 0x0032E928 File Offset: 0x0032CB28
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneVisibilitySectionTemplate.StaticStruct();
		}

		// Token: 0x060226CF RID: 141007 RVA: 0x0032E934 File Offset: 0x0032CB34
		[NullableContext(2)]
		public FMovieSceneVisibilitySectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060226D0 RID: 141008 RVA: 0x0032E93E File Offset: 0x0032CB3E
		public FMovieSceneVisibilitySectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060226D1 RID: 141009 RVA: 0x0032E949 File Offset: 0x0032CB49
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneVisibilitySectionTemplate(Pointer, false, true);
		}

		// Token: 0x060226D2 RID: 141010 RVA: 0x0032E953 File Offset: 0x0032CB53
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneVisibilitySectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04012603 RID: 75267
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVisibilitySectionTemplate";

		// Token: 0x04012604 RID: 75268
		private static IntPtr _ScriptStructPtr;
	}
}
