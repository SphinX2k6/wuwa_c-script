using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000786 RID: 1926
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSection")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public abstract class UMovieSceneSection : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A60C RID: 42508 RVA: 0x000F52DC File Offset: 0x000F34DC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSection._ClassPtr;
		}

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x0600A60D RID: 42509 RVA: 0x000F52E8 File Offset: 0x000F34E8
		// (set) Token: 0x0600A60E RID: 42510 RVA: 0x000F5321 File Offset: 0x000F3521
		[Nullable(1)]
		public FMovieSceneSectionEvalOptions EvalOptions
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSectionEvalOptions result;
				if ((result = this._EvalOptions) == null)
				{
					result = (this._EvalOptions = new FMovieSceneSectionEvalOptions(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_EvalOptions, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSectionEvalOptions.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_EvalOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x0600A60F RID: 42511 RVA: 0x000F5344 File Offset: 0x000F3544
		// (set) Token: 0x0600A610 RID: 42512 RVA: 0x000F537D File Offset: 0x000F357D
		[Nullable(1)]
		public FFrameNumber PreRollFrames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._PreRollFrames) == null)
				{
					result = (this._PreRollFrames = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PreRollFrames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PreRollFrames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x0600A611 RID: 42513 RVA: 0x000F53A0 File Offset: 0x000F35A0
		// (set) Token: 0x0600A612 RID: 42514 RVA: 0x000F53D9 File Offset: 0x000F35D9
		[Nullable(1)]
		public FFrameNumber PostRollFrames
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._PostRollFrames) == null)
				{
					result = (this._PostRollFrames = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PostRollFrames, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PostRollFrames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x0600A613 RID: 42515 RVA: 0x000F53FA File Offset: 0x000F35FA
		// (set) Token: 0x0600A614 RID: 42516 RVA: 0x000F540A File Offset: 0x000F360A
		public unsafe int RowIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_RowIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_RowIndex) = value;
			}
		}

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x0600A615 RID: 42517 RVA: 0x000F541B File Offset: 0x000F361B
		// (set) Token: 0x0600A616 RID: 42518 RVA: 0x000F542B File Offset: 0x000F362B
		public unsafe int OverlapPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_OverlapPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_OverlapPriority) = value;
			}
		}

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x0600A617 RID: 42519 RVA: 0x000F543C File Offset: 0x000F363C
		// (set) Token: 0x0600A618 RID: 42520 RVA: 0x000F5455 File Offset: 0x000F3655
		public unsafe bool bIsActive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsActive) & UMovieSceneSection.__PropertyMask_bIsActive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsActive) = ((*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsActive) & ~UMovieSceneSection.__PropertyMask_bIsActive) | (value ? UMovieSceneSection.__PropertyMask_bIsActive : 0));
			}
		}

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x0600A619 RID: 42521 RVA: 0x000F5485 File Offset: 0x000F3685
		// (set) Token: 0x0600A61A RID: 42522 RVA: 0x000F549E File Offset: 0x000F369E
		public unsafe bool bIsLocked
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsLocked) & UMovieSceneSection.__PropertyMask_bIsLocked) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsLocked) = ((*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsLocked) & ~UMovieSceneSection.__PropertyMask_bIsLocked) | (value ? UMovieSceneSection.__PropertyMask_bIsLocked : 0));
			}
		}

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x0600A61B RID: 42523 RVA: 0x000F54CE File Offset: 0x000F36CE
		// (set) Token: 0x0600A61C RID: 42524 RVA: 0x000F54DE File Offset: 0x000F36DE
		public unsafe float StartTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_StartTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_StartTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x0600A61D RID: 42525 RVA: 0x000F54EF File Offset: 0x000F36EF
		// (set) Token: 0x0600A61E RID: 42526 RVA: 0x000F54FF File Offset: 0x000F36FF
		public unsafe float EndTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_EndTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_EndTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x0600A61F RID: 42527 RVA: 0x000F5510 File Offset: 0x000F3710
		// (set) Token: 0x0600A620 RID: 42528 RVA: 0x000F5520 File Offset: 0x000F3720
		public unsafe float PreRollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PreRollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PreRollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x0600A621 RID: 42529 RVA: 0x000F5531 File Offset: 0x000F3731
		// (set) Token: 0x0600A622 RID: 42530 RVA: 0x000F5541 File Offset: 0x000F3741
		public unsafe float PostRollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PostRollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PostRollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x0600A623 RID: 42531 RVA: 0x000F5552 File Offset: 0x000F3752
		// (set) Token: 0x0600A624 RID: 42532 RVA: 0x000F556B File Offset: 0x000F376B
		public unsafe bool bIsInfinite_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsInfinite_DEPRECATED) & UMovieSceneSection.__PropertyMask_bIsInfinite_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsInfinite_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bIsInfinite_DEPRECATED) & ~UMovieSceneSection.__PropertyMask_bIsInfinite_DEPRECATED) | (value ? UMovieSceneSection.__PropertyMask_bIsInfinite_DEPRECATED : 0));
			}
		}

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x0600A625 RID: 42533 RVA: 0x000F559B File Offset: 0x000F379B
		// (set) Token: 0x0600A626 RID: 42534 RVA: 0x000F55AB File Offset: 0x000F37AB
		public unsafe bool bSupportsInfiniteRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bSupportsInfiniteRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_bSupportsInfiniteRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600A627 RID: 42535 RVA: 0x000F55BC File Offset: 0x000F37BC
		[SkipLocalsInit]
		public unsafe void SetRowIndex(int NewRowIndex)
		{
			UMovieSceneSection.__SetRowIndex_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetRowIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetRowIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetRowIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewRowIndex = NewRowIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetRowIndex_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A628 RID: 42536 RVA: 0x000F5604 File Offset: 0x000F3804
		[SkipLocalsInit]
		public unsafe void SetPreRollFrames(int InPreRollFrames)
		{
			UMovieSceneSection.__SetPreRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetPreRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetPreRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetPreRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPreRollFrames = InPreRollFrames;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetPreRollFrames_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A629 RID: 42537 RVA: 0x000F564C File Offset: 0x000F384C
		[SkipLocalsInit]
		public unsafe void SetPostRollFrames(int InPostRollFrames)
		{
			UMovieSceneSection.__SetPostRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetPostRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetPostRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetPostRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPostRollFrames = InPostRollFrames;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetPostRollFrames_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A62A RID: 42538 RVA: 0x000F5694 File Offset: 0x000F3894
		[SkipLocalsInit]
		public unsafe void SetOverlapPriority(int NewPriority)
		{
			UMovieSceneSection.__SetOverlapPriority_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetOverlapPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetOverlapPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetOverlapPriority_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPriority = NewPriority;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetOverlapPriority_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A62B RID: 42539 RVA: 0x000F56DC File Offset: 0x000F38DC
		[SkipLocalsInit]
		public unsafe void SetIsLocked(bool bInIsLocked)
		{
			UMovieSceneSection.__SetIsLocked_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetIsLocked_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetIsLocked_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetIsLocked_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInIsLocked = bInIsLocked;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetIsLocked_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A62C RID: 42540 RVA: 0x000F5724 File Offset: 0x000F3924
		[SkipLocalsInit]
		public unsafe void SetIsActive(bool bInIsActive)
		{
			UMovieSceneSection.__SetIsActive_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetIsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetIsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetIsActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInIsActive = bInIsActive;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetIsActive_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A62D RID: 42541 RVA: 0x000F576C File Offset: 0x000F396C
		[SkipLocalsInit]
		public unsafe void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode)
		{
			UMovieSceneSection.__SetCompletionMode_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetCompletionMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetCompletionMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetCompletionMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InCompletionMode = InCompletionMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetCompletionMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600A62E RID: 42542 RVA: 0x000F57B4 File Offset: 0x000F39B4
		[SkipLocalsInit]
		public unsafe bool IsLocked()
		{
			UMovieSceneSection.__IsLocked_FunctionParams* ptr = stackalloc UMovieSceneSection.__IsLocked_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__IsLocked_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__IsLocked_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__IsLocked_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A62F RID: 42543 RVA: 0x000F57FC File Offset: 0x000F39FC
		[SkipLocalsInit]
		public unsafe bool IsActive()
		{
			UMovieSceneSection.__IsActive_FunctionParams* ptr = stackalloc UMovieSceneSection.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__IsActive_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A630 RID: 42544 RVA: 0x000F5844 File Offset: 0x000F3A44
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FFrameNumberRangeBound GetStartFrame()
		{
			UMovieSceneSection.__GetStartFrame_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetStartFrame_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneSection.__GetStartFrame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetStartFrame_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetStartFrame_NativeFunctionPtr, (void*)ptr);
			return new FFrameNumberRangeBound(&ptr->__Result, true, true);
		}

		// Token: 0x0600A631 RID: 42545 RVA: 0x000F5894 File Offset: 0x000F3A94
		[SkipLocalsInit]
		public unsafe int GetRowIndex()
		{
			UMovieSceneSection.__GetRowIndex_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetRowIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetRowIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetRowIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetRowIndex_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A632 RID: 42546 RVA: 0x000F58DC File Offset: 0x000F3ADC
		[SkipLocalsInit]
		public unsafe int GetPreRollFrames()
		{
			UMovieSceneSection.__GetPreRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetPreRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetPreRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetPreRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetPreRollFrames_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A633 RID: 42547 RVA: 0x000F5924 File Offset: 0x000F3B24
		[SkipLocalsInit]
		public unsafe int GetPostRollFrames()
		{
			UMovieSceneSection.__GetPostRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetPostRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetPostRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetPostRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetPostRollFrames_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A634 RID: 42548 RVA: 0x000F596C File Offset: 0x000F3B6C
		[SkipLocalsInit]
		public unsafe int GetOverlapPriority()
		{
			UMovieSceneSection.__GetOverlapPriority_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetOverlapPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetOverlapPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetOverlapPriority_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetOverlapPriority_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A635 RID: 42549 RVA: 0x000F59B4 File Offset: 0x000F3BB4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe FFrameNumberRangeBound GetEndFrame()
		{
			UMovieSceneSection.__GetEndFrame_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetEndFrame_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneSection.__GetEndFrame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetEndFrame_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetEndFrame_NativeFunctionPtr, (void*)ptr);
			return new FFrameNumberRangeBound(&ptr->__Result, true, true);
		}

		// Token: 0x0600A636 RID: 42550 RVA: 0x000F5A04 File Offset: 0x000F3C04
		[SkipLocalsInit]
		public unsafe EMovieSceneCompletionMode GetCompletionMode()
		{
			UMovieSceneSection.__GetCompletionMode_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetCompletionMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__GetCompletionMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetCompletionMode_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetCompletionMode_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600A637 RID: 42551 RVA: 0x000F5A49 File Offset: 0x000F3C49
		static UMovieSceneSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSection");
		}

		// Token: 0x0600A638 RID: 42552 RVA: 0x000F5A58 File Offset: 0x000F3C58
		protected UMovieSceneSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A639 RID: 42553 RVA: 0x000F5A80 File Offset: 0x000F3C80
		protected UMovieSceneSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400471B RID: 18203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSection";

		// Token: 0x0400471C RID: 18204
		private static IntPtr _ClassPtr;

		// Token: 0x0400471D RID: 18205
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400471E RID: 18206
		internal static int __PropertyOffset_EvalOptions;

		// Token: 0x0400471F RID: 18207
		[Nullable(2)]
		private FMovieSceneSectionEvalOptions _EvalOptions;

		// Token: 0x04004720 RID: 18208
		internal static int __PropertyOffset_PreRollFrames;

		// Token: 0x04004721 RID: 18209
		[Nullable(2)]
		private FFrameNumber _PreRollFrames;

		// Token: 0x04004722 RID: 18210
		internal static int __PropertyOffset_PostRollFrames;

		// Token: 0x04004723 RID: 18211
		[Nullable(2)]
		private FFrameNumber _PostRollFrames;

		// Token: 0x04004724 RID: 18212
		internal static int __PropertyOffset_RowIndex;

		// Token: 0x04004725 RID: 18213
		internal static int __PropertyOffset_OverlapPriority;

		// Token: 0x04004726 RID: 18214
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x04004727 RID: 18215
		internal static byte __PropertyMask_bIsActive;

		// Token: 0x04004728 RID: 18216
		internal static int __PropertyOffset_bIsLocked;

		// Token: 0x04004729 RID: 18217
		internal static byte __PropertyMask_bIsLocked;

		// Token: 0x0400472A RID: 18218
		internal static int __PropertyOffset_StartTime_DEPRECATED;

		// Token: 0x0400472B RID: 18219
		internal static int __PropertyOffset_EndTime_DEPRECATED;

		// Token: 0x0400472C RID: 18220
		internal static int __PropertyOffset_PreRollTime_DEPRECATED;

		// Token: 0x0400472D RID: 18221
		internal static int __PropertyOffset_PostRollTime_DEPRECATED;

		// Token: 0x0400472E RID: 18222
		internal static int __PropertyOffset_bIsInfinite_DEPRECATED;

		// Token: 0x0400472F RID: 18223
		internal static byte __PropertyMask_bIsInfinite_DEPRECATED;

		// Token: 0x04004730 RID: 18224
		internal static int __PropertyOffset_bSupportsInfiniteRange;

		// Token: 0x04004731 RID: 18225
		private static IntPtr __SetRowIndex_NativeFunctionPtr;

		// Token: 0x04004732 RID: 18226
		private static IntPtr __SetPreRollFrames_NativeFunctionPtr;

		// Token: 0x04004733 RID: 18227
		private static IntPtr __SetPostRollFrames_NativeFunctionPtr;

		// Token: 0x04004734 RID: 18228
		private static IntPtr __SetOverlapPriority_NativeFunctionPtr;

		// Token: 0x04004735 RID: 18229
		private static IntPtr __SetIsLocked_NativeFunctionPtr;

		// Token: 0x04004736 RID: 18230
		private static IntPtr __SetIsActive_NativeFunctionPtr;

		// Token: 0x04004737 RID: 18231
		private static IntPtr __SetCompletionMode_NativeFunctionPtr;

		// Token: 0x04004738 RID: 18232
		private static IntPtr __IsLocked_NativeFunctionPtr;

		// Token: 0x04004739 RID: 18233
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x0400473A RID: 18234
		private static IntPtr __GetStartFrame_NativeFunctionPtr;

		// Token: 0x0400473B RID: 18235
		private static IntPtr __GetRowIndex_NativeFunctionPtr;

		// Token: 0x0400473C RID: 18236
		private static IntPtr __GetPreRollFrames_NativeFunctionPtr;

		// Token: 0x0400473D RID: 18237
		private static IntPtr __GetPostRollFrames_NativeFunctionPtr;

		// Token: 0x0400473E RID: 18238
		private static IntPtr __GetOverlapPriority_NativeFunctionPtr;

		// Token: 0x0400473F RID: 18239
		private static IntPtr __GetEndFrame_NativeFunctionPtr;

		// Token: 0x04004740 RID: 18240
		private static IntPtr __GetCompletionMode_NativeFunctionPtr;

		// Token: 0x02000F4B RID: 3915
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetRowIndex_FunctionParams
		{
			// Token: 0x04006321 RID: 25377
			[FieldOffset(0)]
			public int NewRowIndex;
		}

		// Token: 0x02000F4C RID: 3916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPreRollFrames_FunctionParams
		{
			// Token: 0x04006322 RID: 25378
			[FieldOffset(0)]
			public int InPreRollFrames;
		}

		// Token: 0x02000F4D RID: 3917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPostRollFrames_FunctionParams
		{
			// Token: 0x04006323 RID: 25379
			[FieldOffset(0)]
			public int InPostRollFrames;
		}

		// Token: 0x02000F4E RID: 3918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetOverlapPriority_FunctionParams
		{
			// Token: 0x04006324 RID: 25380
			[FieldOffset(0)]
			public int NewPriority;
		}

		// Token: 0x02000F4F RID: 3919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsLocked_FunctionParams
		{
			// Token: 0x04006325 RID: 25381
			[FieldOffset(0)]
			public bool bInIsLocked;
		}

		// Token: 0x02000F50 RID: 3920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsActive_FunctionParams
		{
			// Token: 0x04006326 RID: 25382
			[FieldOffset(0)]
			public bool bInIsActive;
		}

		// Token: 0x02000F51 RID: 3921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCompletionMode_FunctionParams
		{
			// Token: 0x04006327 RID: 25383
			[FieldOffset(0)]
			public EMovieSceneCompletionMode InCompletionMode;
		}

		// Token: 0x02000F52 RID: 3922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLocked_FunctionParams
		{
			// Token: 0x04006328 RID: 25384
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000F53 RID: 3923
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x04006329 RID: 25385
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000F54 RID: 3924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStartFrame_FunctionParams
		{
			// Token: 0x0400632A RID: 25386
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000F55 RID: 3925
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRowIndex_FunctionParams
		{
			// Token: 0x0400632B RID: 25387
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F56 RID: 3926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPreRollFrames_FunctionParams
		{
			// Token: 0x0400632C RID: 25388
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F57 RID: 3927
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPostRollFrames_FunctionParams
		{
			// Token: 0x0400632D RID: 25389
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F58 RID: 3928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetOverlapPriority_FunctionParams
		{
			// Token: 0x0400632E RID: 25390
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F59 RID: 3929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetEndFrame_FunctionParams
		{
			// Token: 0x0400632F RID: 25391
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000F5A RID: 3930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCompletionMode_FunctionParams
		{
			// Token: 0x04006330 RID: 25392
			[FieldOffset(0)]
			public EMovieSceneCompletionMode __Result;
		}
	}
}
