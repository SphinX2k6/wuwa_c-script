using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000787 RID: 1927
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSectionEvalOptions")]
	[UnrealStructLayout(2, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2)]
	public class FMovieSceneSectionEvalOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A63A RID: 42554 RVA: 0x000F5A89 File Offset: 0x000F3C89
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSectionEvalOptions._ScriptStructPtr != 0) ? FMovieSceneSectionEvalOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSectionEvalOptions", ref FMovieSceneSectionEvalOptions._ScriptStructPtr);
		}

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x0600A63B RID: 42555 RVA: 0x000F5AAD File Offset: 0x000F3CAD
		// (set) Token: 0x0600A63C RID: 42556 RVA: 0x000F5ABD File Offset: 0x000F3CBD
		public unsafe bool bCanEditCompletionMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_bCanEditCompletionMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_bCanEditCompletionMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x0600A63D RID: 42557 RVA: 0x000F5ACE File Offset: 0x000F3CCE
		// (set) Token: 0x0600A63E RID: 42558 RVA: 0x000F5ADE File Offset: 0x000F3CDE
		public unsafe EMovieSceneCompletionMode CompletionMode
		{
			get
			{
				return (EMovieSceneCompletionMode)(*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_CompletionMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionEvalOptions.__PropertyOffset_CompletionMode) = (byte)value;
			}
		}

		// Token: 0x0600A63F RID: 42559 RVA: 0x000F5AEF File Offset: 0x000F3CEF
		public FMovieSceneSectionEvalOptions()
		{
		}

		// Token: 0x0600A640 RID: 42560 RVA: 0x000F5AF7 File Offset: 0x000F3CF7
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSectionEvalOptions.StaticStruct();
		}

		// Token: 0x0600A641 RID: 42561 RVA: 0x000F5B03 File Offset: 0x000F3D03
		[NullableContext(2)]
		public FMovieSceneSectionEvalOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A642 RID: 42562 RVA: 0x000F5B0D File Offset: 0x000F3D0D
		public FMovieSceneSectionEvalOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A643 RID: 42563 RVA: 0x000F5B18 File Offset: 0x000F3D18
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSectionEvalOptions(Pointer, false, true);
		}

		// Token: 0x0600A644 RID: 42564 RVA: 0x000F5B22 File Offset: 0x000F3D22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSectionEvalOptions(Pointer, MemoryOwner);
		}

		// Token: 0x04004741 RID: 18241
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSectionEvalOptions";

		// Token: 0x04004742 RID: 18242
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004743 RID: 18243
		internal static int __PropertyOffset_bCanEditCompletionMode;

		// Token: 0x04004744 RID: 18244
		internal static int __PropertyOffset_CompletionMode;
	}
}
