using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F2 RID: 9970
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteEventParam")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FMovieSceneQteEventParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024FA3 RID: 151459 RVA: 0x0036B2E1 File Offset: 0x003694E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteEventParam._ScriptStructPtr != 0) ? FMovieSceneQteEventParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteEventParam", ref FMovieSceneQteEventParam._ScriptStructPtr);
		}

		// Token: 0x17008EC8 RID: 36552
		// (get) Token: 0x06024FA4 RID: 151460 RVA: 0x0036B305 File Offset: 0x00369505
		// (set) Token: 0x06024FA5 RID: 151461 RVA: 0x0036B315 File Offset: 0x00369515
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_QteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_QteId) = value;
			}
		}

		// Token: 0x17008EC9 RID: 36553
		// (get) Token: 0x06024FA6 RID: 151462 RVA: 0x0036B326 File Offset: 0x00369526
		// (set) Token: 0x06024FA7 RID: 151463 RVA: 0x0036B336 File Offset: 0x00369536
		public unsafe int SubtitleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_SubtitleId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_SubtitleId) = value;
			}
		}

		// Token: 0x17008ECA RID: 36554
		// (get) Token: 0x06024FA8 RID: 151464 RVA: 0x0036B347 File Offset: 0x00369547
		// (set) Token: 0x06024FA9 RID: 151465 RVA: 0x0036B35B File Offset: 0x0036955B
		[Nullable(2)]
		public unsafe AActor AttachActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteEventParam.__PropertyOffset_AttachActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteEventParam.__PropertyOffset_AttachActor, value);
			}
		}

		// Token: 0x17008ECB RID: 36555
		// (get) Token: 0x06024FAA RID: 151466 RVA: 0x0036B370 File Offset: 0x00369570
		// (set) Token: 0x06024FAB RID: 151467 RVA: 0x0036B380 File Offset: 0x00369580
		public unsafe bool IsGroupQte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsGroupQte) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsGroupQte) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008ECC RID: 36556
		// (get) Token: 0x06024FAC RID: 151468 RVA: 0x0036B391 File Offset: 0x00369591
		// (set) Token: 0x06024FAD RID: 151469 RVA: 0x0036B3A1 File Offset: 0x003695A1
		public unsafe bool IsTriggerType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsTriggerType) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsTriggerType) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008ECD RID: 36557
		// (get) Token: 0x06024FAE RID: 151470 RVA: 0x0036B3B4 File Offset: 0x003695B4
		// (set) Token: 0x06024FAF RID: 151471 RVA: 0x0036B3F7 File Offset: 0x003695F7
		public FFrameTime StartFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._StartFrame) == null)
				{
					result = (this._StartFrame = new FFrameTime(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_StartFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_StartFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008ECE RID: 36558
		// (get) Token: 0x06024FB0 RID: 151472 RVA: 0x0036B418 File Offset: 0x00369618
		// (set) Token: 0x06024FB1 RID: 151473 RVA: 0x0036B45B File Offset: 0x0036965B
		public FFrameTime EndFrame
		{
			get
			{
				base.FastCheckIsValid();
				FFrameTime result;
				if ((result = this._EndFrame) == null)
				{
					result = (this._EndFrame = new FFrameTime(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_EndFrame, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameTime.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_EndFrame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008ECF RID: 36559
		// (get) Token: 0x06024FB2 RID: 151474 RVA: 0x0036B47C File Offset: 0x0036967C
		// (set) Token: 0x06024FB3 RID: 151475 RVA: 0x0036B4BF File Offset: 0x003696BF
		public FQteSpineInfo SpineInfo
		{
			get
			{
				base.FastCheckIsValid();
				FQteSpineInfo result;
				if ((result = this._SpineInfo) == null)
				{
					result = (this._SpineInfo = new FQteSpineInfo(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_SpineInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQteSpineInfo.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_SpineInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008ED0 RID: 36560
		// (get) Token: 0x06024FB4 RID: 151476 RVA: 0x0036B4E0 File Offset: 0x003696E0
		// (set) Token: 0x06024FB5 RID: 151477 RVA: 0x0036B4F0 File Offset: 0x003696F0
		public unsafe bool IsUpdateWithProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsUpdateWithProgress) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_IsUpdateWithProgress) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008ED1 RID: 36561
		// (get) Token: 0x06024FB6 RID: 151478 RVA: 0x0036B504 File Offset: 0x00369704
		// (set) Token: 0x06024FB7 RID: 151479 RVA: 0x0036B547 File Offset: 0x00369747
		public TArray<FMovieSceneSubQteParams> SubQteParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneSubQteParams> result;
				if ((result = this._SubQteParams) == null)
				{
					result = (this._SubQteParams = new TArray<FMovieSceneSubQteParams>(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_SubQteParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubQteParams.CopyAssign(value);
			}
		}

		// Token: 0x06024FB8 RID: 151480 RVA: 0x0036B555 File Offset: 0x00369755
		public FMovieSceneQteEventParam()
		{
		}

		// Token: 0x06024FB9 RID: 151481 RVA: 0x0036B560 File Offset: 0x00369760
		public FMovieSceneQteEventParam(int QteId, int SubtitleId, AActor AttachActor, bool IsGroupQte, bool IsTriggerType, FFrameTime StartFrame, FFrameTime EndFrame, FQteSpineInfo SpineInfo, bool IsUpdateWithProgress, TArray<FMovieSceneSubQteParams> SubQteParams)
		{
			this.QteId = QteId;
			this.SubtitleId = SubtitleId;
			this.AttachActor = AttachActor;
			this.IsGroupQte = IsGroupQte;
			this.IsTriggerType = IsTriggerType;
			this.StartFrame = StartFrame;
			this.EndFrame = EndFrame;
			this.SpineInfo = SpineInfo;
			this.IsUpdateWithProgress = IsUpdateWithProgress;
			this.SubQteParams = SubQteParams;
		}

		// Token: 0x06024FBA RID: 151482 RVA: 0x0036B5C0 File Offset: 0x003697C0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteEventParam.StaticStruct();
		}

		// Token: 0x06024FBB RID: 151483 RVA: 0x0036B5CC File Offset: 0x003697CC
		[NullableContext(2)]
		public FMovieSceneQteEventParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024FBC RID: 151484 RVA: 0x0036B5D6 File Offset: 0x003697D6
		public FMovieSceneQteEventParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024FBD RID: 151485 RVA: 0x0036B5E1 File Offset: 0x003697E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteEventParam(Pointer, false, true);
		}

		// Token: 0x06024FBE RID: 151486 RVA: 0x0036B5EB File Offset: 0x003697EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteEventParam(Pointer, MemoryOwner);
		}

		// Token: 0x04013ED3 RID: 81619
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteEventParam";

		// Token: 0x04013ED4 RID: 81620
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013ED5 RID: 81621
		internal static int __PropertyOffset_QteId;

		// Token: 0x04013ED6 RID: 81622
		internal static int __PropertyOffset_SubtitleId;

		// Token: 0x04013ED7 RID: 81623
		internal static int __PropertyOffset_AttachActor;

		// Token: 0x04013ED8 RID: 81624
		internal static int __PropertyOffset_IsGroupQte;

		// Token: 0x04013ED9 RID: 81625
		internal static int __PropertyOffset_IsTriggerType;

		// Token: 0x04013EDA RID: 81626
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x04013EDB RID: 81627
		[Nullable(2)]
		private FFrameTime _StartFrame;

		// Token: 0x04013EDC RID: 81628
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x04013EDD RID: 81629
		[Nullable(2)]
		private FFrameTime _EndFrame;

		// Token: 0x04013EDE RID: 81630
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04013EDF RID: 81631
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;

		// Token: 0x04013EE0 RID: 81632
		internal static int __PropertyOffset_IsUpdateWithProgress;

		// Token: 0x04013EE1 RID: 81633
		internal static int __PropertyOffset_SubQteParams;

		// Token: 0x04013EE2 RID: 81634
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSubQteParams> _SubQteParams;
	}
}
