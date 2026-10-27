using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200244E RID: 9294
	[UnrealObjectPath("/Script/MovieScene.MovieSceneTrackEvalOptions")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FMovieSceneTrackEvalOptions : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022D6D RID: 142701 RVA: 0x00338529 File Offset: 0x00336729
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneTrackEvalOptions._ScriptStructPtr != 0) ? FMovieSceneTrackEvalOptions._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneTrackEvalOptions", ref FMovieSceneTrackEvalOptions._ScriptStructPtr);
		}

		// Token: 0x170085F3 RID: 34291
		// (get) Token: 0x06022D6E RID: 142702 RVA: 0x0033854D File Offset: 0x0033674D
		// (set) Token: 0x06022D6F RID: 142703 RVA: 0x00338566 File Offset: 0x00336766
		public unsafe bool bCanEvaluateNearestSection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bCanEvaluateNearestSection) & FMovieSceneTrackEvalOptions.__PropertyMask_bCanEvaluateNearestSection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bCanEvaluateNearestSection) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bCanEvaluateNearestSection) & ~FMovieSceneTrackEvalOptions.__PropertyMask_bCanEvaluateNearestSection) | (value ? FMovieSceneTrackEvalOptions.__PropertyMask_bCanEvaluateNearestSection : 0));
			}
		}

		// Token: 0x170085F4 RID: 34292
		// (get) Token: 0x06022D70 RID: 142704 RVA: 0x00338596 File Offset: 0x00336796
		// (set) Token: 0x06022D71 RID: 142705 RVA: 0x003385AF File Offset: 0x003367AF
		public unsafe bool bEvalNearestSection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvalNearestSection) & FMovieSceneTrackEvalOptions.__PropertyMask_bEvalNearestSection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvalNearestSection) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvalNearestSection) & ~FMovieSceneTrackEvalOptions.__PropertyMask_bEvalNearestSection) | (value ? FMovieSceneTrackEvalOptions.__PropertyMask_bEvalNearestSection : 0));
			}
		}

		// Token: 0x170085F5 RID: 34293
		// (get) Token: 0x06022D72 RID: 142706 RVA: 0x003385DF File Offset: 0x003367DF
		// (set) Token: 0x06022D73 RID: 142707 RVA: 0x003385F8 File Offset: 0x003367F8
		public unsafe bool bEvaluateInPreroll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPreroll) & FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPreroll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPreroll) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPreroll) & ~FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPreroll) | (value ? FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPreroll : 0));
			}
		}

		// Token: 0x170085F6 RID: 34294
		// (get) Token: 0x06022D74 RID: 142708 RVA: 0x00338628 File Offset: 0x00336828
		// (set) Token: 0x06022D75 RID: 142709 RVA: 0x00338641 File Offset: 0x00336841
		public unsafe bool bEvaluateInPostroll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPostroll) & FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPostroll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPostroll) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateInPostroll) & ~FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPostroll) | (value ? FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateInPostroll : 0));
			}
		}

		// Token: 0x170085F7 RID: 34295
		// (get) Token: 0x06022D76 RID: 142710 RVA: 0x00338671 File Offset: 0x00336871
		// (set) Token: 0x06022D77 RID: 142711 RVA: 0x0033868A File Offset: 0x0033688A
		public unsafe bool bEvaluateNearestSection_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateNearestSection_DEPRECATED) & FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateNearestSection_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateNearestSection_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FMovieSceneTrackEvalOptions.__PropertyOffset_bEvaluateNearestSection_DEPRECATED) & ~FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateNearestSection_DEPRECATED) | (value ? FMovieSceneTrackEvalOptions.__PropertyMask_bEvaluateNearestSection_DEPRECATED : 0));
			}
		}

		// Token: 0x06022D78 RID: 142712 RVA: 0x003386BA File Offset: 0x003368BA
		public FMovieSceneTrackEvalOptions()
		{
		}

		// Token: 0x06022D79 RID: 142713 RVA: 0x003386C2 File Offset: 0x003368C2
		public FMovieSceneTrackEvalOptions(bool bCanEvaluateNearestSection, bool bEvalNearestSection, bool bEvaluateInPreroll, bool bEvaluateInPostroll, bool bEvaluateNearestSection_DEPRECATED)
		{
			this.bCanEvaluateNearestSection = bCanEvaluateNearestSection;
			this.bEvalNearestSection = bEvalNearestSection;
			this.bEvaluateInPreroll = bEvaluateInPreroll;
			this.bEvaluateInPostroll = bEvaluateInPostroll;
			this.bEvaluateNearestSection_DEPRECATED = bEvaluateNearestSection_DEPRECATED;
		}

		// Token: 0x06022D7A RID: 142714 RVA: 0x003386EF File Offset: 0x003368EF
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneTrackEvalOptions.StaticStruct();
		}

		// Token: 0x06022D7B RID: 142715 RVA: 0x003386FB File Offset: 0x003368FB
		[NullableContext(2)]
		public FMovieSceneTrackEvalOptions(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D7C RID: 142716 RVA: 0x00338705 File Offset: 0x00336905
		public FMovieSceneTrackEvalOptions(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D7D RID: 142717 RVA: 0x00338710 File Offset: 0x00336910
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneTrackEvalOptions(Pointer, false, true);
		}

		// Token: 0x06022D7E RID: 142718 RVA: 0x0033871A File Offset: 0x0033691A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneTrackEvalOptions(Pointer, MemoryOwner);
		}

		// Token: 0x040129A5 RID: 76197
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneTrackEvalOptions";

		// Token: 0x040129A6 RID: 76198
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040129A7 RID: 76199
		internal static int __PropertyOffset_bCanEvaluateNearestSection;

		// Token: 0x040129A8 RID: 76200
		internal static byte __PropertyMask_bCanEvaluateNearestSection;

		// Token: 0x040129A9 RID: 76201
		internal static int __PropertyOffset_bEvalNearestSection;

		// Token: 0x040129AA RID: 76202
		internal static byte __PropertyMask_bEvalNearestSection;

		// Token: 0x040129AB RID: 76203
		internal static int __PropertyOffset_bEvaluateInPreroll;

		// Token: 0x040129AC RID: 76204
		internal static byte __PropertyMask_bEvaluateInPreroll;

		// Token: 0x040129AD RID: 76205
		internal static int __PropertyOffset_bEvaluateInPostroll;

		// Token: 0x040129AE RID: 76206
		internal static byte __PropertyMask_bEvaluateInPostroll;

		// Token: 0x040129AF RID: 76207
		internal static int __PropertyOffset_bEvaluateNearestSection_DEPRECATED;

		// Token: 0x040129B0 RID: 76208
		internal static byte __PropertyMask_bEvaluateNearestSection_DEPRECATED;
	}
}
