using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001407 RID: 5127
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCacheTracks.MovieSceneGeometryCacheParams")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FMovieSceneGeometryCacheParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012B79 RID: 76665 RVA: 0x001B8C35 File Offset: 0x001B6E35
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneGeometryCacheParams._ScriptStructPtr != 0) ? FMovieSceneGeometryCacheParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCacheTracks.MovieSceneGeometryCacheParams", ref FMovieSceneGeometryCacheParams._ScriptStructPtr);
		}

		// Token: 0x1700488F RID: 18575
		// (get) Token: 0x06012B7A RID: 76666 RVA: 0x001B8C59 File Offset: 0x001B6E59
		// (set) Token: 0x06012B7B RID: 76667 RVA: 0x001B8C6D File Offset: 0x001B6E6D
		[Nullable(2)]
		public unsafe UGeometryCache GeometryCacheAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGeometryCache>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneGeometryCacheParams.__PropertyOffset_GeometryCacheAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneGeometryCacheParams.__PropertyOffset_GeometryCacheAsset, value);
			}
		}

		// Token: 0x17004890 RID: 18576
		// (get) Token: 0x06012B7C RID: 76668 RVA: 0x001B8C84 File Offset: 0x001B6E84
		// (set) Token: 0x06012B7D RID: 76669 RVA: 0x001B8CC7 File Offset: 0x001B6EC7
		public FFrameNumber FirstLoopStartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._FirstLoopStartFrameOffset) == null)
				{
					result = (this._FirstLoopStartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_FirstLoopStartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_FirstLoopStartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004891 RID: 18577
		// (get) Token: 0x06012B7E RID: 76670 RVA: 0x001B8CE8 File Offset: 0x001B6EE8
		// (set) Token: 0x06012B7F RID: 76671 RVA: 0x001B8D2B File Offset: 0x001B6F2B
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_StartFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004892 RID: 18578
		// (get) Token: 0x06012B80 RID: 76672 RVA: 0x001B8D4C File Offset: 0x001B6F4C
		// (set) Token: 0x06012B81 RID: 76673 RVA: 0x001B8D8F File Offset: 0x001B6F8F
		public FFrameNumber EndFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._EndFrameOffset) == null)
				{
					result = (this._EndFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_EndFrameOffset, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_EndFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17004893 RID: 18579
		// (get) Token: 0x06012B82 RID: 76674 RVA: 0x001B8DB0 File Offset: 0x001B6FB0
		// (set) Token: 0x06012B83 RID: 76675 RVA: 0x001B8DC0 File Offset: 0x001B6FC0
		public unsafe float PlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_PlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_PlayRate) = value;
			}
		}

		// Token: 0x17004894 RID: 18580
		// (get) Token: 0x06012B84 RID: 76676 RVA: 0x001B8DD1 File Offset: 0x001B6FD1
		// (set) Token: 0x06012B85 RID: 76677 RVA: 0x001B8DEA File Offset: 0x001B6FEA
		public unsafe bool bReverse
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_bReverse) & FMovieSceneGeometryCacheParams.__PropertyMask_bReverse) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_bReverse) = ((*(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_bReverse) & ~FMovieSceneGeometryCacheParams.__PropertyMask_bReverse) | (value ? FMovieSceneGeometryCacheParams.__PropertyMask_bReverse : 0));
			}
		}

		// Token: 0x17004895 RID: 18581
		// (get) Token: 0x06012B86 RID: 76678 RVA: 0x001B8E1A File Offset: 0x001B701A
		// (set) Token: 0x06012B87 RID: 76679 RVA: 0x001B8E2A File Offset: 0x001B702A
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17004896 RID: 18582
		// (get) Token: 0x06012B88 RID: 76680 RVA: 0x001B8E3B File Offset: 0x001B703B
		// (set) Token: 0x06012B89 RID: 76681 RVA: 0x001B8E4B File Offset: 0x001B704B
		public unsafe float EndOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_EndOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_EndOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x17004897 RID: 18583
		// (get) Token: 0x06012B8A RID: 76682 RVA: 0x001B8E5C File Offset: 0x001B705C
		// (set) Token: 0x06012B8B RID: 76683 RVA: 0x001B8E9F File Offset: 0x001B709F
		public FSoftObjectPath GeometryCache_DEPRECATED
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GeometryCache_DEPRECATED) == null)
				{
					result = (this._GeometryCache_DEPRECATED = new FSoftObjectPath(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_GeometryCache_DEPRECATED, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheParams.__PropertyOffset_GeometryCache_DEPRECATED, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012B8C RID: 76684 RVA: 0x001B8EC0 File Offset: 0x001B70C0
		public FMovieSceneGeometryCacheParams()
		{
		}

		// Token: 0x06012B8D RID: 76685 RVA: 0x001B8EC8 File Offset: 0x001B70C8
		public FMovieSceneGeometryCacheParams(UGeometryCache GeometryCacheAsset, FFrameNumber FirstLoopStartFrameOffset, FFrameNumber StartFrameOffset, FFrameNumber EndFrameOffset, float PlayRate, bool bReverse, float StartOffset_DEPRECATED, float EndOffset_DEPRECATED, FSoftObjectPath GeometryCache_DEPRECATED)
		{
			this.GeometryCacheAsset = GeometryCacheAsset;
			this.FirstLoopStartFrameOffset = FirstLoopStartFrameOffset;
			this.StartFrameOffset = StartFrameOffset;
			this.EndFrameOffset = EndFrameOffset;
			this.PlayRate = PlayRate;
			this.bReverse = bReverse;
			this.StartOffset_DEPRECATED = StartOffset_DEPRECATED;
			this.EndOffset_DEPRECATED = EndOffset_DEPRECATED;
			this.GeometryCache_DEPRECATED = GeometryCache_DEPRECATED;
		}

		// Token: 0x06012B8E RID: 76686 RVA: 0x001B8F20 File Offset: 0x001B7120
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneGeometryCacheParams.StaticStruct();
		}

		// Token: 0x06012B8F RID: 76687 RVA: 0x001B8F2C File Offset: 0x001B712C
		[NullableContext(2)]
		public FMovieSceneGeometryCacheParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012B90 RID: 76688 RVA: 0x001B8F36 File Offset: 0x001B7136
		public FMovieSceneGeometryCacheParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012B91 RID: 76689 RVA: 0x001B8F41 File Offset: 0x001B7141
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneGeometryCacheParams(Pointer, false, true);
		}

		// Token: 0x06012B92 RID: 76690 RVA: 0x001B8F4B File Offset: 0x001B714B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneGeometryCacheParams(Pointer, MemoryOwner);
		}

		// Token: 0x0400A018 RID: 40984
		public const string __ObjectPath = "/Script/GeometryCacheTracks.MovieSceneGeometryCacheParams";

		// Token: 0x0400A019 RID: 40985
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A01A RID: 40986
		internal static int __PropertyOffset_GeometryCacheAsset;

		// Token: 0x0400A01B RID: 40987
		internal static int __PropertyOffset_FirstLoopStartFrameOffset;

		// Token: 0x0400A01C RID: 40988
		[Nullable(2)]
		private FFrameNumber _FirstLoopStartFrameOffset;

		// Token: 0x0400A01D RID: 40989
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x0400A01E RID: 40990
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x0400A01F RID: 40991
		internal static int __PropertyOffset_EndFrameOffset;

		// Token: 0x0400A020 RID: 40992
		[Nullable(2)]
		private FFrameNumber _EndFrameOffset;

		// Token: 0x0400A021 RID: 40993
		internal static int __PropertyOffset_PlayRate;

		// Token: 0x0400A022 RID: 40994
		internal static int __PropertyOffset_bReverse;

		// Token: 0x0400A023 RID: 40995
		internal static byte __PropertyMask_bReverse;

		// Token: 0x0400A024 RID: 40996
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x0400A025 RID: 40997
		internal static int __PropertyOffset_EndOffset_DEPRECATED;

		// Token: 0x0400A026 RID: 40998
		internal static int __PropertyOffset_GeometryCache_DEPRECATED;

		// Token: 0x0400A027 RID: 40999
		[Nullable(2)]
		private FSoftObjectPath _GeometryCache_DEPRECATED;
	}
}
