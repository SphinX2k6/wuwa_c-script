using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002428 RID: 9256
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSection")]
	[UnrealStructLayout(304, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 304)]
	public abstract class UMovieSceneSection : UMovieSceneSignedObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022ABD RID: 142013 RVA: 0x00334452 File Offset: 0x00332652
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSection._ClassPtr;
		}

		// Token: 0x17008563 RID: 34147
		// (get) Token: 0x06022ABE RID: 142014 RVA: 0x00334460 File Offset: 0x00332660
		// (set) Token: 0x06022ABF RID: 142015 RVA: 0x00334499 File Offset: 0x00332699
		public FMovieSceneSectionEvalOptions EvalOptions
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSectionEvalOptions.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_EvalOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008564 RID: 34148
		// (get) Token: 0x06022AC0 RID: 142016 RVA: 0x003344BC File Offset: 0x003326BC
		// (set) Token: 0x06022AC1 RID: 142017 RVA: 0x003344F5 File Offset: 0x003326F5
		public FMovieSceneEasingSettings Easing
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEasingSettings result;
				if ((result = this._Easing) == null)
				{
					result = (this._Easing = new FMovieSceneEasingSettings(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_Easing, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEasingSettings.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_Easing, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008565 RID: 34149
		// (get) Token: 0x06022AC2 RID: 142018 RVA: 0x00334518 File Offset: 0x00332718
		// (set) Token: 0x06022AC3 RID: 142019 RVA: 0x00334551 File Offset: 0x00332751
		public FMovieSceneFrameRange SectionRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._SectionRange) == null)
				{
					result = (this._SectionRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_SectionRange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_SectionRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008566 RID: 34150
		// (get) Token: 0x06022AC4 RID: 142020 RVA: 0x00334574 File Offset: 0x00332774
		// (set) Token: 0x06022AC5 RID: 142021 RVA: 0x003345AD File Offset: 0x003327AD
		public FFrameNumber PreRollFrames
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PreRollFrames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008567 RID: 34151
		// (get) Token: 0x06022AC6 RID: 142022 RVA: 0x003345D0 File Offset: 0x003327D0
		// (set) Token: 0x06022AC7 RID: 142023 RVA: 0x00334609 File Offset: 0x00332809
		public FFrameNumber PostRollFrames
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_PostRollFrames, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008568 RID: 34152
		// (get) Token: 0x06022AC8 RID: 142024 RVA: 0x0033462A File Offset: 0x0033282A
		// (set) Token: 0x06022AC9 RID: 142025 RVA: 0x0033463A File Offset: 0x0033283A
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

		// Token: 0x17008569 RID: 34153
		// (get) Token: 0x06022ACA RID: 142026 RVA: 0x0033464B File Offset: 0x0033284B
		// (set) Token: 0x06022ACB RID: 142027 RVA: 0x0033465B File Offset: 0x0033285B
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

		// Token: 0x1700856A RID: 34154
		// (get) Token: 0x06022ACC RID: 142028 RVA: 0x0033466C File Offset: 0x0033286C
		// (set) Token: 0x06022ACD RID: 142029 RVA: 0x00334685 File Offset: 0x00332885
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

		// Token: 0x1700856B RID: 34155
		// (get) Token: 0x06022ACE RID: 142030 RVA: 0x003346B5 File Offset: 0x003328B5
		// (set) Token: 0x06022ACF RID: 142031 RVA: 0x003346CE File Offset: 0x003328CE
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

		// Token: 0x1700856C RID: 34156
		// (get) Token: 0x06022AD0 RID: 142032 RVA: 0x003346FE File Offset: 0x003328FE
		// (set) Token: 0x06022AD1 RID: 142033 RVA: 0x0033470E File Offset: 0x0033290E
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

		// Token: 0x1700856D RID: 34157
		// (get) Token: 0x06022AD2 RID: 142034 RVA: 0x0033471F File Offset: 0x0033291F
		// (set) Token: 0x06022AD3 RID: 142035 RVA: 0x0033472F File Offset: 0x0033292F
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

		// Token: 0x1700856E RID: 34158
		// (get) Token: 0x06022AD4 RID: 142036 RVA: 0x00334740 File Offset: 0x00332940
		// (set) Token: 0x06022AD5 RID: 142037 RVA: 0x00334750 File Offset: 0x00332950
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

		// Token: 0x1700856F RID: 34159
		// (get) Token: 0x06022AD6 RID: 142038 RVA: 0x00334761 File Offset: 0x00332961
		// (set) Token: 0x06022AD7 RID: 142039 RVA: 0x00334771 File Offset: 0x00332971
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

		// Token: 0x17008570 RID: 34160
		// (get) Token: 0x06022AD8 RID: 142040 RVA: 0x00334782 File Offset: 0x00332982
		// (set) Token: 0x06022AD9 RID: 142041 RVA: 0x0033479B File Offset: 0x0033299B
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

		// Token: 0x17008571 RID: 34161
		// (get) Token: 0x06022ADA RID: 142042 RVA: 0x003347CB File Offset: 0x003329CB
		// (set) Token: 0x06022ADB RID: 142043 RVA: 0x003347DB File Offset: 0x003329DB
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

		// Token: 0x17008572 RID: 34162
		// (get) Token: 0x06022ADC RID: 142044 RVA: 0x003347EC File Offset: 0x003329EC
		// (set) Token: 0x06022ADD RID: 142045 RVA: 0x00334825 File Offset: 0x00332A25
		public FOptionalMovieSceneBlendType BlendType
		{
			get
			{
				base.FastCheckIsValid();
				FOptionalMovieSceneBlendType result;
				if ((result = this._BlendType) == null)
				{
					result = (this._BlendType = new FOptionalMovieSceneBlendType(base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_BlendType, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FOptionalMovieSceneBlendType.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSection.__PropertyOffset_BlendType, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022ADE RID: 142046 RVA: 0x00334848 File Offset: 0x00332A48
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetRowIndex(int NewRowIndex)
		{
			UMovieSceneSection.__SetRowIndex_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetRowIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetRowIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetRowIndex_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewRowIndex = NewRowIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetRowIndex_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022ADF RID: 142047 RVA: 0x00334890 File Offset: 0x00332A90
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPreRollFrames(int InPreRollFrames)
		{
			UMovieSceneSection.__SetPreRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetPreRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetPreRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetPreRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPreRollFrames = InPreRollFrames;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetPreRollFrames_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE0 RID: 142048 RVA: 0x003348D8 File Offset: 0x00332AD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetPostRollFrames(int InPostRollFrames)
		{
			UMovieSceneSection.__SetPostRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetPostRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetPostRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetPostRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InPostRollFrames = InPostRollFrames;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetPostRollFrames_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE1 RID: 142049 RVA: 0x00334920 File Offset: 0x00332B20
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetOverlapPriority(int NewPriority)
		{
			UMovieSceneSection.__SetOverlapPriority_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetOverlapPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__SetOverlapPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetOverlapPriority_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewPriority = NewPriority;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetOverlapPriority_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE2 RID: 142050 RVA: 0x00334968 File Offset: 0x00332B68
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetIsLocked(bool bInIsLocked)
		{
			UMovieSceneSection.__SetIsLocked_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetIsLocked_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetIsLocked_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetIsLocked_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInIsLocked = bInIsLocked;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetIsLocked_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE3 RID: 142051 RVA: 0x003349B0 File Offset: 0x00332BB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetIsActive(bool bInIsActive)
		{
			UMovieSceneSection.__SetIsActive_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetIsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetIsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetIsActive_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bInIsActive = bInIsActive;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetIsActive_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE4 RID: 142052 RVA: 0x003349F8 File Offset: 0x00332BF8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetCompletionMode(EMovieSceneCompletionMode InCompletionMode)
		{
			UMovieSceneSection.__SetCompletionMode_FunctionParams* ptr = stackalloc UMovieSceneSection.__SetCompletionMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__SetCompletionMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__SetCompletionMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InCompletionMode = InCompletionMode;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__SetCompletionMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06022AE5 RID: 142053 RVA: 0x00334A3F File Offset: 0x00332C3F
		public void SetBlendType(EMovieSceneBlendType InBlendType)
		{
			UMovieSceneSection.__SetBlendType_Internal(base.NativePtr, InBlendType);
		}

		// Token: 0x06022AE6 RID: 142054 RVA: 0x00334A50 File Offset: 0x00332C50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsLocked()
		{
			UMovieSceneSection.__IsLocked_FunctionParams* ptr = stackalloc UMovieSceneSection.__IsLocked_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__IsLocked_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__IsLocked_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__IsLocked_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AE7 RID: 142055 RVA: 0x00334A98 File Offset: 0x00332C98
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsActive()
		{
			UMovieSceneSection.__IsActive_FunctionParams* ptr = stackalloc UMovieSceneSection.__IsActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__IsActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__IsActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__IsActive_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AE8 RID: 142056 RVA: 0x00334AE0 File Offset: 0x00332CE0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FFrameNumberRangeBound GetStartFrame()
		{
			UMovieSceneSection.__GetStartFrame_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetStartFrame_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneSection.__GetStartFrame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetStartFrame_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetStartFrame_NativeFunctionPtr, (void*)ptr, 0);
			return new FFrameNumberRangeBound(&ptr->__Result, true, true);
		}

		// Token: 0x06022AE9 RID: 142057 RVA: 0x00334B30 File Offset: 0x00332D30
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetRowIndex()
		{
			UMovieSceneSection.__GetRowIndex_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetRowIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetRowIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetRowIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetRowIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AEA RID: 142058 RVA: 0x00334B78 File Offset: 0x00332D78
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetPreRollFrames()
		{
			UMovieSceneSection.__GetPreRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetPreRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetPreRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetPreRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetPreRollFrames_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AEB RID: 142059 RVA: 0x00334BC0 File Offset: 0x00332DC0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetPostRollFrames()
		{
			UMovieSceneSection.__GetPostRollFrames_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetPostRollFrames_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetPostRollFrames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetPostRollFrames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetPostRollFrames_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AEC RID: 142060 RVA: 0x00334C08 File Offset: 0x00332E08
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetOverlapPriority()
		{
			UMovieSceneSection.__GetOverlapPriority_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetOverlapPriority_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UMovieSceneSection.__GetOverlapPriority_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetOverlapPriority_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetOverlapPriority_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AED RID: 142061 RVA: 0x00334C50 File Offset: 0x00332E50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FFrameNumberRangeBound GetEndFrame()
		{
			UMovieSceneSection.__GetEndFrame_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetEndFrame_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneSection.__GetEndFrame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetEndFrame_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetEndFrame_NativeFunctionPtr, (void*)ptr, 0);
			return new FFrameNumberRangeBound(&ptr->__Result, true, true);
		}

		// Token: 0x06022AEE RID: 142062 RVA: 0x00334CA0 File Offset: 0x00332EA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EMovieSceneCompletionMode GetCompletionMode()
		{
			UMovieSceneSection.__GetCompletionMode_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetCompletionMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UMovieSceneSection.__GetCompletionMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetCompletionMode_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetCompletionMode_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06022AEF RID: 142063 RVA: 0x00334CE8 File Offset: 0x00332EE8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FOptionalMovieSceneBlendType GetBlendType()
		{
			UMovieSceneSection.__GetBlendType_FunctionParams* ptr = stackalloc UMovieSceneSection.__GetBlendType_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UMovieSceneSection.__GetBlendType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneSection.__GetBlendType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneSection.__GetBlendType_NativeFunctionPtr, (void*)ptr, 0);
			return new FOptionalMovieSceneBlendType(&ptr->__Result, true, true);
		}

		// Token: 0x06022AF0 RID: 142064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlendType_Internal(IntPtr @this, EMovieSceneBlendType InBlendType);

		// Token: 0x06022AF1 RID: 142065 RVA: 0x00334D36 File Offset: 0x00332F36
		static UMovieSceneSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSection");
		}

		// Token: 0x06022AF2 RID: 142066 RVA: 0x00334D44 File Offset: 0x00332F44
		protected UMovieSceneSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022AF3 RID: 142067 RVA: 0x00334D6C File Offset: 0x00332F6C
		protected UMovieSceneSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012859 RID: 75865
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSection";

		// Token: 0x0401285A RID: 75866
		private static IntPtr _ClassPtr;

		// Token: 0x0401285B RID: 75867
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401285C RID: 75868
		internal static int __PropertyOffset_EvalOptions;

		// Token: 0x0401285D RID: 75869
		[Nullable(2)]
		private FMovieSceneSectionEvalOptions _EvalOptions;

		// Token: 0x0401285E RID: 75870
		internal static int __PropertyOffset_Easing;

		// Token: 0x0401285F RID: 75871
		[Nullable(2)]
		private FMovieSceneEasingSettings _Easing;

		// Token: 0x04012860 RID: 75872
		internal static int __PropertyOffset_SectionRange;

		// Token: 0x04012861 RID: 75873
		[Nullable(2)]
		private FMovieSceneFrameRange _SectionRange;

		// Token: 0x04012862 RID: 75874
		internal static int __PropertyOffset_PreRollFrames;

		// Token: 0x04012863 RID: 75875
		[Nullable(2)]
		private FFrameNumber _PreRollFrames;

		// Token: 0x04012864 RID: 75876
		internal static int __PropertyOffset_PostRollFrames;

		// Token: 0x04012865 RID: 75877
		[Nullable(2)]
		private FFrameNumber _PostRollFrames;

		// Token: 0x04012866 RID: 75878
		internal static int __PropertyOffset_RowIndex;

		// Token: 0x04012867 RID: 75879
		internal static int __PropertyOffset_OverlapPriority;

		// Token: 0x04012868 RID: 75880
		internal static int __PropertyOffset_bIsActive;

		// Token: 0x04012869 RID: 75881
		internal static byte __PropertyMask_bIsActive;

		// Token: 0x0401286A RID: 75882
		internal static int __PropertyOffset_bIsLocked;

		// Token: 0x0401286B RID: 75883
		internal static byte __PropertyMask_bIsLocked;

		// Token: 0x0401286C RID: 75884
		internal static int __PropertyOffset_StartTime_DEPRECATED;

		// Token: 0x0401286D RID: 75885
		internal static int __PropertyOffset_EndTime_DEPRECATED;

		// Token: 0x0401286E RID: 75886
		internal static int __PropertyOffset_PreRollTime_DEPRECATED;

		// Token: 0x0401286F RID: 75887
		internal static int __PropertyOffset_PostRollTime_DEPRECATED;

		// Token: 0x04012870 RID: 75888
		internal static int __PropertyOffset_bIsInfinite_DEPRECATED;

		// Token: 0x04012871 RID: 75889
		internal static byte __PropertyMask_bIsInfinite_DEPRECATED;

		// Token: 0x04012872 RID: 75890
		internal static int __PropertyOffset_bSupportsInfiniteRange;

		// Token: 0x04012873 RID: 75891
		internal static int __PropertyOffset_BlendType;

		// Token: 0x04012874 RID: 75892
		[Nullable(2)]
		private FOptionalMovieSceneBlendType _BlendType;

		// Token: 0x04012875 RID: 75893
		private static IntPtr __SetRowIndex_NativeFunctionPtr;

		// Token: 0x04012876 RID: 75894
		private static IntPtr __SetPreRollFrames_NativeFunctionPtr;

		// Token: 0x04012877 RID: 75895
		private static IntPtr __SetPostRollFrames_NativeFunctionPtr;

		// Token: 0x04012878 RID: 75896
		private static IntPtr __SetOverlapPriority_NativeFunctionPtr;

		// Token: 0x04012879 RID: 75897
		private static IntPtr __SetIsLocked_NativeFunctionPtr;

		// Token: 0x0401287A RID: 75898
		private static IntPtr __SetIsActive_NativeFunctionPtr;

		// Token: 0x0401287B RID: 75899
		private static IntPtr __SetCompletionMode_NativeFunctionPtr;

		// Token: 0x0401287C RID: 75900
		private static IntPtr __IsLocked_NativeFunctionPtr;

		// Token: 0x0401287D RID: 75901
		private static IntPtr __IsActive_NativeFunctionPtr;

		// Token: 0x0401287E RID: 75902
		private static IntPtr __GetStartFrame_NativeFunctionPtr;

		// Token: 0x0401287F RID: 75903
		private static IntPtr __GetRowIndex_NativeFunctionPtr;

		// Token: 0x04012880 RID: 75904
		private static IntPtr __GetPreRollFrames_NativeFunctionPtr;

		// Token: 0x04012881 RID: 75905
		private static IntPtr __GetPostRollFrames_NativeFunctionPtr;

		// Token: 0x04012882 RID: 75906
		private static IntPtr __GetOverlapPriority_NativeFunctionPtr;

		// Token: 0x04012883 RID: 75907
		private static IntPtr __GetEndFrame_NativeFunctionPtr;

		// Token: 0x04012884 RID: 75908
		private static IntPtr __GetCompletionMode_NativeFunctionPtr;

		// Token: 0x04012885 RID: 75909
		private static IntPtr __GetBlendType_NativeFunctionPtr;

		// Token: 0x02003652 RID: 13906
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetRowIndex_FunctionParams
		{
			// Token: 0x04017720 RID: 96032
			[FieldOffset(0)]
			public int NewRowIndex;
		}

		// Token: 0x02003653 RID: 13907
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPreRollFrames_FunctionParams
		{
			// Token: 0x04017721 RID: 96033
			[FieldOffset(0)]
			public int InPreRollFrames;
		}

		// Token: 0x02003654 RID: 13908
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetPostRollFrames_FunctionParams
		{
			// Token: 0x04017722 RID: 96034
			[FieldOffset(0)]
			public int InPostRollFrames;
		}

		// Token: 0x02003655 RID: 13909
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetOverlapPriority_FunctionParams
		{
			// Token: 0x04017723 RID: 96035
			[FieldOffset(0)]
			public int NewPriority;
		}

		// Token: 0x02003656 RID: 13910
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsLocked_FunctionParams
		{
			// Token: 0x04017724 RID: 96036
			[FieldOffset(0)]
			public bool bInIsLocked;
		}

		// Token: 0x02003657 RID: 13911
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetIsActive_FunctionParams
		{
			// Token: 0x04017725 RID: 96037
			[FieldOffset(0)]
			public bool bInIsActive;
		}

		// Token: 0x02003658 RID: 13912
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetCompletionMode_FunctionParams
		{
			// Token: 0x04017726 RID: 96038
			[FieldOffset(0)]
			public EMovieSceneCompletionMode InCompletionMode;
		}

		// Token: 0x02003659 RID: 13913
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsLocked_FunctionParams
		{
			// Token: 0x04017727 RID: 96039
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200365A RID: 13914
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsActive_FunctionParams
		{
			// Token: 0x04017728 RID: 96040
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x0200365B RID: 13915
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetStartFrame_FunctionParams
		{
			// Token: 0x04017729 RID: 96041
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x0200365C RID: 13916
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetRowIndex_FunctionParams
		{
			// Token: 0x0401772A RID: 96042
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200365D RID: 13917
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPreRollFrames_FunctionParams
		{
			// Token: 0x0401772B RID: 96043
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200365E RID: 13918
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetPostRollFrames_FunctionParams
		{
			// Token: 0x0401772C RID: 96044
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x0200365F RID: 13919
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetOverlapPriority_FunctionParams
		{
			// Token: 0x0401772D RID: 96045
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02003660 RID: 13920
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetEndFrame_FunctionParams
		{
			// Token: 0x0401772E RID: 96046
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02003661 RID: 13921
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCompletionMode_FunctionParams
		{
			// Token: 0x0401772F RID: 96047
			[FieldOffset(0)]
			public EMovieSceneCompletionMode __Result;
		}

		// Token: 0x02003662 RID: 13922
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __GetBlendType_FunctionParams
		{
			// Token: 0x04017730 RID: 96048
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
