using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CC RID: 1996
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteEventParam")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 184)]
	public class FMovieSceneQteEventParam : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AC4B RID: 44107 RVA: 0x000FE4CF File Offset: 0x000FC6CF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteEventParam._ScriptStructPtr != 0) ? FMovieSceneQteEventParam._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteEventParam", ref FMovieSceneQteEventParam._ScriptStructPtr);
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x0600AC4C RID: 44108 RVA: 0x000FE4F3 File Offset: 0x000FC6F3
		// (set) Token: 0x0600AC4D RID: 44109 RVA: 0x000FE503 File Offset: 0x000FC703
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

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x0600AC4E RID: 44110 RVA: 0x000FE514 File Offset: 0x000FC714
		// (set) Token: 0x0600AC4F RID: 44111 RVA: 0x000FE524 File Offset: 0x000FC724
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

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x0600AC50 RID: 44112 RVA: 0x000FE535 File Offset: 0x000FC735
		// (set) Token: 0x0600AC51 RID: 44113 RVA: 0x000FE549 File Offset: 0x000FC749
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

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x0600AC52 RID: 44114 RVA: 0x000FE55E File Offset: 0x000FC75E
		// (set) Token: 0x0600AC53 RID: 44115 RVA: 0x000FE56E File Offset: 0x000FC76E
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

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x0600AC54 RID: 44116 RVA: 0x000FE57F File Offset: 0x000FC77F
		// (set) Token: 0x0600AC55 RID: 44117 RVA: 0x000FE58F File Offset: 0x000FC78F
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

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x0600AC56 RID: 44118 RVA: 0x000FE5A0 File Offset: 0x000FC7A0
		// (set) Token: 0x0600AC57 RID: 44119 RVA: 0x000FE5E3 File Offset: 0x000FC7E3
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

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x0600AC58 RID: 44120 RVA: 0x000FE604 File Offset: 0x000FC804
		// (set) Token: 0x0600AC59 RID: 44121 RVA: 0x000FE647 File Offset: 0x000FC847
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

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x0600AC5A RID: 44122 RVA: 0x000FE668 File Offset: 0x000FC868
		// (set) Token: 0x0600AC5B RID: 44123 RVA: 0x000FE6AB File Offset: 0x000FC8AB
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

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x0600AC5C RID: 44124 RVA: 0x000FE6CC File Offset: 0x000FC8CC
		// (set) Token: 0x0600AC5D RID: 44125 RVA: 0x000FE6DC File Offset: 0x000FC8DC
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

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x0600AC5E RID: 44126 RVA: 0x000FE6ED File Offset: 0x000FC8ED
		// (set) Token: 0x0600AC5F RID: 44127 RVA: 0x000FE6FD File Offset: 0x000FC8FD
		public unsafe bool NeedPauseSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_NeedPauseSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteEventParam.__PropertyOffset_NeedPauseSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x0600AC60 RID: 44128 RVA: 0x000FE710 File Offset: 0x000FC910
		// (set) Token: 0x0600AC61 RID: 44129 RVA: 0x000FE753 File Offset: 0x000FC953
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

		// Token: 0x0600AC62 RID: 44130 RVA: 0x000FE761 File Offset: 0x000FC961
		public FMovieSceneQteEventParam()
		{
		}

		// Token: 0x0600AC63 RID: 44131 RVA: 0x000FE769 File Offset: 0x000FC969
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteEventParam.StaticStruct();
		}

		// Token: 0x0600AC64 RID: 44132 RVA: 0x000FE775 File Offset: 0x000FC975
		[NullableContext(2)]
		public FMovieSceneQteEventParam(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AC65 RID: 44133 RVA: 0x000FE77F File Offset: 0x000FC97F
		public FMovieSceneQteEventParam(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AC66 RID: 44134 RVA: 0x000FE78A File Offset: 0x000FC98A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteEventParam(Pointer, false, true);
		}

		// Token: 0x0600AC67 RID: 44135 RVA: 0x000FE794 File Offset: 0x000FC994
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteEventParam(Pointer, MemoryOwner);
		}

		// Token: 0x04004A3B RID: 19003
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteEventParam";

		// Token: 0x04004A3C RID: 19004
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004A3D RID: 19005
		internal static int __PropertyOffset_QteId;

		// Token: 0x04004A3E RID: 19006
		internal static int __PropertyOffset_SubtitleId;

		// Token: 0x04004A3F RID: 19007
		internal static int __PropertyOffset_AttachActor;

		// Token: 0x04004A40 RID: 19008
		internal static int __PropertyOffset_IsGroupQte;

		// Token: 0x04004A41 RID: 19009
		internal static int __PropertyOffset_IsTriggerType;

		// Token: 0x04004A42 RID: 19010
		internal static int __PropertyOffset_StartFrame;

		// Token: 0x04004A43 RID: 19011
		[Nullable(2)]
		private FFrameTime _StartFrame;

		// Token: 0x04004A44 RID: 19012
		internal static int __PropertyOffset_EndFrame;

		// Token: 0x04004A45 RID: 19013
		[Nullable(2)]
		private FFrameTime _EndFrame;

		// Token: 0x04004A46 RID: 19014
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04004A47 RID: 19015
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;

		// Token: 0x04004A48 RID: 19016
		internal static int __PropertyOffset_IsUpdateWithProgress;

		// Token: 0x04004A49 RID: 19017
		internal static int __PropertyOffset_NeedPauseSequence;

		// Token: 0x04004A4A RID: 19018
		internal static int __PropertyOffset_SubQteParams;

		// Token: 0x04004A4B RID: 19019
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSubQteParams> _SubQteParams;
	}
}
