using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200242B RID: 9259
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSectionParameters")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FMovieSceneSectionParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022B0A RID: 142090 RVA: 0x00334EF0 File Offset: 0x003330F0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSectionParameters._ScriptStructPtr != 0) ? FMovieSceneSectionParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSectionParameters", ref FMovieSceneSectionParameters._ScriptStructPtr);
		}

		// Token: 0x17008576 RID: 34166
		// (get) Token: 0x06022B0B RID: 142091 RVA: 0x00334F14 File Offset: 0x00333114
		// (set) Token: 0x06022B0C RID: 142092 RVA: 0x00334F57 File Offset: 0x00333157
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008577 RID: 34167
		// (get) Token: 0x06022B0D RID: 142093 RVA: 0x00334F78 File Offset: 0x00333178
		// (set) Token: 0x06022B0E RID: 142094 RVA: 0x00334F88 File Offset: 0x00333188
		public unsafe bool bCanLoop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_bCanLoop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_bCanLoop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008578 RID: 34168
		// (get) Token: 0x06022B0F RID: 142095 RVA: 0x00334F9C File Offset: 0x0033319C
		// (set) Token: 0x06022B10 RID: 142096 RVA: 0x00334FDF File Offset: 0x003331DF
		public FFrameNumber EndFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._EndFrameOffset) == null)
				{
					result = (this._EndFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_EndFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_EndFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008579 RID: 34169
		// (get) Token: 0x06022B11 RID: 142097 RVA: 0x00335000 File Offset: 0x00333200
		// (set) Token: 0x06022B12 RID: 142098 RVA: 0x00335043 File Offset: 0x00333243
		public FFrameNumber FirstLoopStartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FirstLoopStartFrameOffset) == null)
				{
					result = (this._FirstLoopStartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_FirstLoopStartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_FirstLoopStartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700857A RID: 34170
		// (get) Token: 0x06022B13 RID: 142099 RVA: 0x00335064 File Offset: 0x00333264
		// (set) Token: 0x06022B14 RID: 142100 RVA: 0x00335074 File Offset: 0x00333274
		public unsafe float TimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_TimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_TimeScale) = value;
			}
		}

		// Token: 0x1700857B RID: 34171
		// (get) Token: 0x06022B15 RID: 142101 RVA: 0x00335085 File Offset: 0x00333285
		// (set) Token: 0x06022B16 RID: 142102 RVA: 0x00335095 File Offset: 0x00333295
		public unsafe int HierarchicalBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_HierarchicalBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_HierarchicalBias) = value;
			}
		}

		// Token: 0x1700857C RID: 34172
		// (get) Token: 0x06022B17 RID: 142103 RVA: 0x003350A6 File Offset: 0x003332A6
		// (set) Token: 0x06022B18 RID: 142104 RVA: 0x003350B6 File Offset: 0x003332B6
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x1700857D RID: 34173
		// (get) Token: 0x06022B19 RID: 142105 RVA: 0x003350C7 File Offset: 0x003332C7
		// (set) Token: 0x06022B1A RID: 142106 RVA: 0x003350D7 File Offset: 0x003332D7
		public unsafe float PrerollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PrerollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PrerollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x1700857E RID: 34174
		// (get) Token: 0x06022B1B RID: 142107 RVA: 0x003350E8 File Offset: 0x003332E8
		// (set) Token: 0x06022B1C RID: 142108 RVA: 0x003350F8 File Offset: 0x003332F8
		public unsafe float PostrollTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PostrollTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSectionParameters.__PropertyOffset_PostrollTime_DEPRECATED) = value;
			}
		}

		// Token: 0x06022B1D RID: 142109 RVA: 0x00335109 File Offset: 0x00333309
		public FMovieSceneSectionParameters()
		{
		}

		// Token: 0x06022B1E RID: 142110 RVA: 0x00335114 File Offset: 0x00333314
		public FMovieSceneSectionParameters(FFrameNumber StartFrameOffset, bool bCanLoop, FFrameNumber EndFrameOffset, FFrameNumber FirstLoopStartFrameOffset, float TimeScale, int HierarchicalBias, float StartOffset_DEPRECATED, float PrerollTime_DEPRECATED, float PostrollTime_DEPRECATED)
		{
			this.StartFrameOffset = StartFrameOffset;
			this.bCanLoop = bCanLoop;
			this.EndFrameOffset = EndFrameOffset;
			this.FirstLoopStartFrameOffset = FirstLoopStartFrameOffset;
			this.TimeScale = TimeScale;
			this.HierarchicalBias = HierarchicalBias;
			this.StartOffset_DEPRECATED = StartOffset_DEPRECATED;
			this.PrerollTime_DEPRECATED = PrerollTime_DEPRECATED;
			this.PostrollTime_DEPRECATED = PostrollTime_DEPRECATED;
		}

		// Token: 0x06022B1F RID: 142111 RVA: 0x0033516C File Offset: 0x0033336C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSectionParameters.StaticStruct();
		}

		// Token: 0x06022B20 RID: 142112 RVA: 0x00335178 File Offset: 0x00333378
		[NullableContext(2)]
		public FMovieSceneSectionParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022B21 RID: 142113 RVA: 0x00335182 File Offset: 0x00333382
		public FMovieSceneSectionParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022B22 RID: 142114 RVA: 0x0033518D File Offset: 0x0033338D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSectionParameters(Pointer, false, true);
		}

		// Token: 0x06022B23 RID: 142115 RVA: 0x00335197 File Offset: 0x00333397
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSectionParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0401288E RID: 75918
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSectionParameters";

		// Token: 0x0401288F RID: 75919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012890 RID: 75920
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04012891 RID: 75921
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04012892 RID: 75922
		internal static int __PropertyOffset_bCanLoop;

		// Token: 0x04012893 RID: 75923
		internal static int __PropertyOffset_EndFrameOffset;

		// Token: 0x04012894 RID: 75924
		[Nullable(2)]
		private FFrameNumber _EndFrameOffset;

		// Token: 0x04012895 RID: 75925
		internal static int __PropertyOffset_FirstLoopStartFrameOffset;

		// Token: 0x04012896 RID: 75926
		[Nullable(2)]
		private FFrameNumber _FirstLoopStartFrameOffset;

		// Token: 0x04012897 RID: 75927
		internal static int __PropertyOffset_TimeScale;

		// Token: 0x04012898 RID: 75928
		internal static int __PropertyOffset_HierarchicalBias;

		// Token: 0x04012899 RID: 75929
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x0401289A RID: 75930
		internal static int __PropertyOffset_PrerollTime_DEPRECATED;

		// Token: 0x0401289B RID: 75931
		internal static int __PropertyOffset_PostrollTime_DEPRECATED;
	}
}
