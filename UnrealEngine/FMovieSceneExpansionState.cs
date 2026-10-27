using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002405 RID: 9221
	[UnrealObjectPath("/Script/MovieScene.MovieSceneExpansionState")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FMovieSceneExpansionState : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022969 RID: 141673 RVA: 0x00332874 File Offset: 0x00330A74
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneExpansionState._ScriptStructPtr != 0) ? FMovieSceneExpansionState._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneExpansionState", ref FMovieSceneExpansionState._ScriptStructPtr);
		}

		// Token: 0x17008527 RID: 34087
		// (get) Token: 0x0602296A RID: 141674 RVA: 0x00332898 File Offset: 0x00330A98
		// (set) Token: 0x0602296B RID: 141675 RVA: 0x003328A8 File Offset: 0x00330AA8
		public unsafe bool bExpanded
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneExpansionState.__PropertyOffset_bExpanded) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneExpansionState.__PropertyOffset_bExpanded) = (value ? 1 : 0);
			}
		}

		// Token: 0x0602296C RID: 141676 RVA: 0x003328B9 File Offset: 0x00330AB9
		public FMovieSceneExpansionState()
		{
		}

		// Token: 0x0602296D RID: 141677 RVA: 0x003328C1 File Offset: 0x00330AC1
		public FMovieSceneExpansionState(bool bExpanded)
		{
			this.bExpanded = bExpanded;
		}

		// Token: 0x0602296E RID: 141678 RVA: 0x003328D0 File Offset: 0x00330AD0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneExpansionState.StaticStruct();
		}

		// Token: 0x0602296F RID: 141679 RVA: 0x003328DC File Offset: 0x00330ADC
		[NullableContext(2)]
		public FMovieSceneExpansionState(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022970 RID: 141680 RVA: 0x003328E6 File Offset: 0x00330AE6
		public FMovieSceneExpansionState(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022971 RID: 141681 RVA: 0x003328F1 File Offset: 0x00330AF1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneExpansionState(Pointer, false, true);
		}

		// Token: 0x06022972 RID: 141682 RVA: 0x003328FB File Offset: 0x00330AFB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneExpansionState(Pointer, MemoryOwner);
		}

		// Token: 0x040127BE RID: 75710
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneExpansionState";

		// Token: 0x040127BF RID: 75711
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040127C0 RID: 75712
		internal static int __PropertyOffset_bExpanded;
	}
}
