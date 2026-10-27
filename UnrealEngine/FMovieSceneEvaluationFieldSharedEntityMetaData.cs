using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023FB RID: 9211
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEvaluationFieldSharedEntityMetaData")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FMovieSceneEvaluationFieldSharedEntityMetaData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060228DD RID: 141533 RVA: 0x00331B75 File Offset: 0x0032FD75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneEvaluationFieldSharedEntityMetaData._ScriptStructPtr != 0) ? FMovieSceneEvaluationFieldSharedEntityMetaData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneEvaluationFieldSharedEntityMetaData", ref FMovieSceneEvaluationFieldSharedEntityMetaData._ScriptStructPtr);
		}

		// Token: 0x17008509 RID: 34057
		// (get) Token: 0x060228DE RID: 141534 RVA: 0x00331B99 File Offset: 0x0032FD99
		// (set) Token: 0x060228DF RID: 141535 RVA: 0x00331BAD File Offset: 0x0032FDAD
		public unsafe FGuid ObjectBindingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldSharedEntityMetaData.__PropertyOffset_ObjectBindingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneEvaluationFieldSharedEntityMetaData.__PropertyOffset_ObjectBindingID) = value;
			}
		}

		// Token: 0x060228E0 RID: 141536 RVA: 0x00331BC2 File Offset: 0x0032FDC2
		public FMovieSceneEvaluationFieldSharedEntityMetaData()
		{
		}

		// Token: 0x060228E1 RID: 141537 RVA: 0x00331BCA File Offset: 0x0032FDCA
		public FMovieSceneEvaluationFieldSharedEntityMetaData(FGuid ObjectBindingID)
		{
			this.ObjectBindingID = ObjectBindingID;
		}

		// Token: 0x060228E2 RID: 141538 RVA: 0x00331BD9 File Offset: 0x0032FDD9
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneEvaluationFieldSharedEntityMetaData.StaticStruct();
		}

		// Token: 0x060228E3 RID: 141539 RVA: 0x00331BE5 File Offset: 0x0032FDE5
		[NullableContext(2)]
		public FMovieSceneEvaluationFieldSharedEntityMetaData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060228E4 RID: 141540 RVA: 0x00331BEF File Offset: 0x0032FDEF
		public FMovieSceneEvaluationFieldSharedEntityMetaData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060228E5 RID: 141541 RVA: 0x00331BFA File Offset: 0x0032FDFA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneEvaluationFieldSharedEntityMetaData(Pointer, false, true);
		}

		// Token: 0x060228E6 RID: 141542 RVA: 0x00331C04 File Offset: 0x0032FE04
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneEvaluationFieldSharedEntityMetaData(Pointer, MemoryOwner);
		}

		// Token: 0x0401277A RID: 75642
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEvaluationFieldSharedEntityMetaData";

		// Token: 0x0401277B RID: 75643
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401277C RID: 75644
		internal static int __PropertyOffset_ObjectBindingID;
	}
}
