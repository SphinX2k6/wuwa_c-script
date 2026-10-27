using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002443 RID: 9283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSubSequenceData")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 336)]
	public class FMovieSceneSubSequenceData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022CE3 RID: 142563 RVA: 0x0033761C File Offset: 0x0033581C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneSubSequenceData._ScriptStructPtr != 0) ? FMovieSceneSubSequenceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MovieScene.MovieSceneSubSequenceData", ref FMovieSceneSubSequenceData._ScriptStructPtr);
		}

		// Token: 0x170085D5 RID: 34261
		// (get) Token: 0x06022CE4 RID: 142564 RVA: 0x00337640 File Offset: 0x00335840
		// (set) Token: 0x06022CE5 RID: 142565 RVA: 0x00337683 File Offset: 0x00335883
		public FSoftObjectPath Sequence
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._Sequence) == null)
				{
					result = (this._Sequence = new FSoftObjectPath(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_Sequence, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_Sequence, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085D6 RID: 34262
		// (get) Token: 0x06022CE6 RID: 142566 RVA: 0x003376A4 File Offset: 0x003358A4
		// (set) Token: 0x06022CE7 RID: 142567 RVA: 0x003376E7 File Offset: 0x003358E7
		public FMovieSceneSequenceTransform RootToSequenceTransform
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceTransform result;
				if ((result = this._RootToSequenceTransform) == null)
				{
					result = (this._RootToSequenceTransform = new FMovieSceneSequenceTransform(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_RootToSequenceTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceTransform.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_RootToSequenceTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085D7 RID: 34263
		// (get) Token: 0x06022CE8 RID: 142568 RVA: 0x00337708 File Offset: 0x00335908
		// (set) Token: 0x06022CE9 RID: 142569 RVA: 0x0033771C File Offset: 0x0033591C
		public unsafe FFrameRate TickResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_TickResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_TickResolution) = value;
			}
		}

		// Token: 0x170085D8 RID: 34264
		// (get) Token: 0x06022CEA RID: 142570 RVA: 0x00337734 File Offset: 0x00335934
		// (set) Token: 0x06022CEB RID: 142571 RVA: 0x00337777 File Offset: 0x00335977
		public FMovieSceneSequenceID DeterministicSequenceID
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceID result;
				if ((result = this._DeterministicSequenceID) == null)
				{
					result = (this._DeterministicSequenceID = new FMovieSceneSequenceID(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_DeterministicSequenceID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_DeterministicSequenceID, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085D9 RID: 34265
		// (get) Token: 0x06022CEC RID: 142572 RVA: 0x00337798 File Offset: 0x00335998
		// (set) Token: 0x06022CED RID: 142573 RVA: 0x003377DB File Offset: 0x003359DB
		public FMovieSceneFrameRange PlayRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._PlayRange) == null)
				{
					result = (this._PlayRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PlayRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PlayRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085DA RID: 34266
		// (get) Token: 0x06022CEE RID: 142574 RVA: 0x003377FC File Offset: 0x003359FC
		// (set) Token: 0x06022CEF RID: 142575 RVA: 0x0033783F File Offset: 0x00335A3F
		public FMovieSceneFrameRange FullPlayRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._FullPlayRange) == null)
				{
					result = (this._FullPlayRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_FullPlayRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_FullPlayRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085DB RID: 34267
		// (get) Token: 0x06022CF0 RID: 142576 RVA: 0x00337860 File Offset: 0x00335A60
		// (set) Token: 0x06022CF1 RID: 142577 RVA: 0x003378A3 File Offset: 0x00335AA3
		public FMovieSceneFrameRange UnwarpedPlayRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._UnwarpedPlayRange) == null)
				{
					result = (this._UnwarpedPlayRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_UnwarpedPlayRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_UnwarpedPlayRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085DC RID: 34268
		// (get) Token: 0x06022CF2 RID: 142578 RVA: 0x003378C4 File Offset: 0x00335AC4
		// (set) Token: 0x06022CF3 RID: 142579 RVA: 0x00337907 File Offset: 0x00335B07
		public FMovieSceneFrameRange PreRollRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._PreRollRange) == null)
				{
					result = (this._PreRollRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PreRollRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PreRollRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085DD RID: 34269
		// (get) Token: 0x06022CF4 RID: 142580 RVA: 0x00337928 File Offset: 0x00335B28
		// (set) Token: 0x06022CF5 RID: 142581 RVA: 0x0033796B File Offset: 0x00335B6B
		public FMovieSceneFrameRange PostRollRange
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFrameRange result;
				if ((result = this._PostRollRange) == null)
				{
					result = (this._PostRollRange = new FMovieSceneFrameRange(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PostRollRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFrameRange.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_PostRollRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085DE RID: 34270
		// (get) Token: 0x06022CF6 RID: 142582 RVA: 0x0033798C File Offset: 0x00335B8C
		// (set) Token: 0x06022CF7 RID: 142583 RVA: 0x0033799C File Offset: 0x00335B9C
		public unsafe short HierarchicalBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_HierarchicalBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_HierarchicalBias) = value;
			}
		}

		// Token: 0x170085DF RID: 34271
		// (get) Token: 0x06022CF8 RID: 142584 RVA: 0x003379AD File Offset: 0x00335BAD
		// (set) Token: 0x06022CF9 RID: 142585 RVA: 0x003379BD File Offset: 0x00335BBD
		public unsafe bool bHasHierarchicalEasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_bHasHierarchicalEasing) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_bHasHierarchicalEasing) = (value ? 1 : 0);
			}
		}

		// Token: 0x170085E0 RID: 34272
		// (get) Token: 0x06022CFA RID: 142586 RVA: 0x003379D0 File Offset: 0x00335BD0
		// (set) Token: 0x06022CFB RID: 142587 RVA: 0x00337A13 File Offset: 0x00335C13
		public FMovieSceneSequenceInstanceDataPtr InstanceData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceInstanceDataPtr result;
				if ((result = this._InstanceData) == null)
				{
					result = (this._InstanceData = new FMovieSceneSequenceInstanceDataPtr(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_InstanceData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceInstanceDataPtr.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_InstanceData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085E1 RID: 34273
		// (get) Token: 0x06022CFC RID: 142588 RVA: 0x00337A34 File Offset: 0x00335C34
		// (set) Token: 0x06022CFD RID: 142589 RVA: 0x00337A48 File Offset: 0x00335C48
		public unsafe FGuid SubSectionSignature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_SubSectionSignature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_SubSectionSignature) = value;
			}
		}

		// Token: 0x170085E2 RID: 34274
		// (get) Token: 0x06022CFE RID: 142590 RVA: 0x00337A60 File Offset: 0x00335C60
		// (set) Token: 0x06022CFF RID: 142591 RVA: 0x00337AA3 File Offset: 0x00335CA3
		public FMovieSceneSequenceTransform OuterToInnerTransform
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceTransform result;
				if ((result = this._OuterToInnerTransform) == null)
				{
					result = (this._OuterToInnerTransform = new FMovieSceneSequenceTransform(base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_OuterToInnerTransform, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceTransform.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneSubSequenceData.__PropertyOffset_OuterToInnerTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06022D00 RID: 142592 RVA: 0x00337AC4 File Offset: 0x00335CC4
		public FMovieSceneSubSequenceData()
		{
		}

		// Token: 0x06022D01 RID: 142593 RVA: 0x00337ACC File Offset: 0x00335CCC
		public FMovieSceneSubSequenceData(FSoftObjectPath Sequence, FMovieSceneSequenceTransform RootToSequenceTransform, FFrameRate TickResolution, FMovieSceneSequenceID DeterministicSequenceID, FMovieSceneFrameRange PlayRange, FMovieSceneFrameRange FullPlayRange, FMovieSceneFrameRange UnwarpedPlayRange, FMovieSceneFrameRange PreRollRange, FMovieSceneFrameRange PostRollRange, short HierarchicalBias, bool bHasHierarchicalEasing, FMovieSceneSequenceInstanceDataPtr InstanceData, FName SectionPath, FGuid SubSectionSignature, FMovieSceneSequenceTransform OuterToInnerTransform)
		{
			this.Sequence = Sequence;
			this.RootToSequenceTransform = RootToSequenceTransform;
			this.TickResolution = TickResolution;
			this.DeterministicSequenceID = DeterministicSequenceID;
			this.PlayRange = PlayRange;
			this.FullPlayRange = FullPlayRange;
			this.UnwarpedPlayRange = UnwarpedPlayRange;
			this.PreRollRange = PreRollRange;
			this.PostRollRange = PostRollRange;
			this.HierarchicalBias = HierarchicalBias;
			this.bHasHierarchicalEasing = bHasHierarchicalEasing;
			this.InstanceData = InstanceData;
			this.SubSectionSignature = SubSectionSignature;
			this.OuterToInnerTransform = OuterToInnerTransform;
		}

		// Token: 0x06022D02 RID: 142594 RVA: 0x00337B4C File Offset: 0x00335D4C
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneSubSequenceData.StaticStruct();
		}

		// Token: 0x06022D03 RID: 142595 RVA: 0x00337B58 File Offset: 0x00335D58
		[NullableContext(2)]
		public FMovieSceneSubSequenceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022D04 RID: 142596 RVA: 0x00337B62 File Offset: 0x00335D62
		public FMovieSceneSubSequenceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022D05 RID: 142597 RVA: 0x00337B6D File Offset: 0x00335D6D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneSubSequenceData(Pointer, false, true);
		}

		// Token: 0x06022D06 RID: 142598 RVA: 0x00337B77 File Offset: 0x00335D77
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneSubSequenceData(Pointer, MemoryOwner);
		}

		// Token: 0x04012954 RID: 76116
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneSubSequenceData";

		// Token: 0x04012955 RID: 76117
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012956 RID: 76118
		internal static int __PropertyOffset_Sequence;

		// Token: 0x04012957 RID: 76119
		[Nullable(2)]
		private FSoftObjectPath _Sequence;

		// Token: 0x04012958 RID: 76120
		internal static int __PropertyOffset_RootToSequenceTransform;

		// Token: 0x04012959 RID: 76121
		[Nullable(2)]
		private FMovieSceneSequenceTransform _RootToSequenceTransform;

		// Token: 0x0401295A RID: 76122
		internal static int __PropertyOffset_TickResolution;

		// Token: 0x0401295B RID: 76123
		internal static int __PropertyOffset_DeterministicSequenceID;

		// Token: 0x0401295C RID: 76124
		[Nullable(2)]
		private FMovieSceneSequenceID _DeterministicSequenceID;

		// Token: 0x0401295D RID: 76125
		internal static int __PropertyOffset_PlayRange;

		// Token: 0x0401295E RID: 76126
		[Nullable(2)]
		private FMovieSceneFrameRange _PlayRange;

		// Token: 0x0401295F RID: 76127
		internal static int __PropertyOffset_FullPlayRange;

		// Token: 0x04012960 RID: 76128
		[Nullable(2)]
		private FMovieSceneFrameRange _FullPlayRange;

		// Token: 0x04012961 RID: 76129
		internal static int __PropertyOffset_UnwarpedPlayRange;

		// Token: 0x04012962 RID: 76130
		[Nullable(2)]
		private FMovieSceneFrameRange _UnwarpedPlayRange;

		// Token: 0x04012963 RID: 76131
		internal static int __PropertyOffset_PreRollRange;

		// Token: 0x04012964 RID: 76132
		[Nullable(2)]
		private FMovieSceneFrameRange _PreRollRange;

		// Token: 0x04012965 RID: 76133
		internal static int __PropertyOffset_PostRollRange;

		// Token: 0x04012966 RID: 76134
		[Nullable(2)]
		private FMovieSceneFrameRange _PostRollRange;

		// Token: 0x04012967 RID: 76135
		internal static int __PropertyOffset_HierarchicalBias;

		// Token: 0x04012968 RID: 76136
		internal static int __PropertyOffset_bHasHierarchicalEasing;

		// Token: 0x04012969 RID: 76137
		internal static int __PropertyOffset_InstanceData;

		// Token: 0x0401296A RID: 76138
		[Nullable(2)]
		private FMovieSceneSequenceInstanceDataPtr _InstanceData;

		// Token: 0x0401296B RID: 76139
		internal static int __PropertyOffset_SubSectionSignature;

		// Token: 0x0401296C RID: 76140
		internal static int __PropertyOffset_OuterToInnerTransform;

		// Token: 0x0401296D RID: 76141
		[Nullable(2)]
		private FMovieSceneSequenceTransform _OuterToInnerTransform;
	}
}
