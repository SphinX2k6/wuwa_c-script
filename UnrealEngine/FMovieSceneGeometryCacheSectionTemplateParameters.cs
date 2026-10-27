using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200140A RID: 5130
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplateParameters")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FMovieSceneGeometryCacheSectionTemplateParameters : FMovieSceneGeometryCacheParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012BA4 RID: 76708 RVA: 0x001B9111 File Offset: 0x001B7311
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneGeometryCacheSectionTemplateParameters._ScriptStructPtr != 0) ? FMovieSceneGeometryCacheSectionTemplateParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplateParameters", ref FMovieSceneGeometryCacheSectionTemplateParameters._ScriptStructPtr);
		}

		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06012BA5 RID: 76709 RVA: 0x001B9138 File Offset: 0x001B7338
		// (set) Token: 0x06012BA6 RID: 76710 RVA: 0x001B917B File Offset: 0x001B737B
		public FFrameNumber SectionStartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionStartTime) == null)
				{
					result = (this._SectionStartTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplateParameters.__PropertyOffset_SectionStartTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplateParameters.__PropertyOffset_SectionStartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06012BA7 RID: 76711 RVA: 0x001B919C File Offset: 0x001B739C
		// (set) Token: 0x06012BA8 RID: 76712 RVA: 0x001B91DF File Offset: 0x001B73DF
		public FFrameNumber SectionEndTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._SectionEndTime) == null)
				{
					result = (this._SectionEndTime = new FFrameNumber(base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplateParameters.__PropertyOffset_SectionEndTime, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneGeometryCacheSectionTemplateParameters.__PropertyOffset_SectionEndTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06012BA9 RID: 76713 RVA: 0x001B9200 File Offset: 0x001B7400
		public FMovieSceneGeometryCacheSectionTemplateParameters()
		{
		}

		// Token: 0x06012BAA RID: 76714 RVA: 0x001B9208 File Offset: 0x001B7408
		public FMovieSceneGeometryCacheSectionTemplateParameters(FFrameNumber SectionStartTime, FFrameNumber SectionEndTime, UGeometryCache GeometryCacheAsset, FFrameNumber FirstLoopStartFrameOffset, FFrameNumber StartFrameOffset, FFrameNumber EndFrameOffset, float PlayRate, bool bReverse, float StartOffset_DEPRECATED, float EndOffset_DEPRECATED, FSoftObjectPath GeometryCache_DEPRECATED)
		{
			this.SectionStartTime = SectionStartTime;
			this.SectionEndTime = SectionEndTime;
			base.GeometryCacheAsset = GeometryCacheAsset;
			base.FirstLoopStartFrameOffset = FirstLoopStartFrameOffset;
			base.StartFrameOffset = StartFrameOffset;
			base.EndFrameOffset = EndFrameOffset;
			base.PlayRate = PlayRate;
			base.bReverse = bReverse;
			base.StartOffset_DEPRECATED = StartOffset_DEPRECATED;
			base.EndOffset_DEPRECATED = EndOffset_DEPRECATED;
			base.GeometryCache_DEPRECATED = GeometryCache_DEPRECATED;
		}

		// Token: 0x06012BAB RID: 76715 RVA: 0x001B9270 File Offset: 0x001B7470
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneGeometryCacheSectionTemplateParameters.StaticStruct();
		}

		// Token: 0x06012BAC RID: 76716 RVA: 0x001B927C File Offset: 0x001B747C
		[NullableContext(2)]
		public FMovieSceneGeometryCacheSectionTemplateParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012BAD RID: 76717 RVA: 0x001B9286 File Offset: 0x001B7486
		public FMovieSceneGeometryCacheSectionTemplateParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012BAE RID: 76718 RVA: 0x001B9291 File Offset: 0x001B7491
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneGeometryCacheSectionTemplateParameters(Pointer, false, true);
		}

		// Token: 0x06012BAF RID: 76719 RVA: 0x001B929B File Offset: 0x001B749B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneGeometryCacheSectionTemplateParameters(Pointer, MemoryOwner);
		}

		// Token: 0x0400A031 RID: 41009
		public new const string __ObjectPath = "/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplateParameters";

		// Token: 0x0400A032 RID: 41010
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A033 RID: 41011
		internal static int __PropertyOffset_SectionStartTime;

		// Token: 0x0400A034 RID: 41012
		[Nullable(2)]
		private FFrameNumber _SectionStartTime;

		// Token: 0x0400A035 RID: 41013
		internal static int __PropertyOffset_SectionEndTime;

		// Token: 0x0400A036 RID: 41014
		[Nullable(2)]
		private FFrameNumber _SectionEndTime;
	}
}
