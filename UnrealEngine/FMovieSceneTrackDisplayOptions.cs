using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200244D RID: 9293
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackDisplayOptions")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneTrackDisplayOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D63 RID: 142691 RVA: 0x00338471 File Offset: 0x00336671
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackDisplayOptions._ScriptStructPtr != 0) ? FMovieSceneTrackDisplayOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackDisplayOptions", ref FMovieSceneTrackDisplayOptions._ScriptStructPtr);
		}

		// Token: 0x170085F2 RID: 34290
		// (get) Token: 0x06022D64 RID: 142692 RVA: 0x00338495 File Offset: 0x00336695
		// (set) Token: 0x06022D65 RID: 142693 RVA: 0x003384AE File Offset: 0x003366AE
		public unsafe bool bShowVerticalFrames
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackDisplayOptions.__PropertyOffset_bShowVerticalFrames) & FMovieSceneTrackDisplayOptions.__PropertyMask_bShowVerticalFrames) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackDisplayOptions.__PropertyOffset_bShowVerticalFrames) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackDisplayOptions.__PropertyOffset_bShowVerticalFrames) & ~FMovieSceneTrackDisplayOptions.__PropertyMask_bShowVerticalFrames) | (value ? FMovieSceneTrackDisplayOptions.__PropertyMask_bShowVerticalFrames : 0));
			}
		}

		// Token: 0x06022D66 RID: 142694 RVA: 0x003384DE File Offset: 0x003366DE
		public FMovieSceneTrackDisplayOptions()
		{
		}

		// Token: 0x06022D67 RID: 142695 RVA: 0x003384E6 File Offset: 0x003366E6
		public FMovieSceneTrackDisplayOptions(bool bShowVerticalFrames)
		{
			this.bShowVerticalFrames = bShowVerticalFrames;
		}

		// Token: 0x06022D68 RID: 142696 RVA: 0x003384F5 File Offset: 0x003366F5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackDisplayOptions.StaticStruct();
		}

		// Token: 0x06022D69 RID: 142697 RVA: 0x00338501 File Offset: 0x00336701
		[NullableContext(2)]
		public FMovieSceneTrackDisplayOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D6A RID: 142698 RVA: 0x0033850B File Offset: 0x0033670B
		public FMovieSceneTrackDisplayOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D6B RID: 142699 RVA: 0x00338516 File Offset: 0x00336716
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackDisplayOptions(Pointer, false, true);
		}

		// Token: 0x06022D6C RID: 142700 RVA: 0x00338520 File Offset: 0x00336720
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackDisplayOptions(Pointer, MemoryOwner);
		}

		// Token: 0x040129A1 RID: 76193
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackDisplayOptions";

		// Token: 0x040129A2 RID: 76194
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129A3 RID: 76195
		internal static int __PropertyOffset_bShowVerticalFrames;

		// Token: 0x040129A4 RID: 76196
		internal static byte __PropertyMask_bShowVerticalFrames;
	}
}
