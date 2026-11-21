using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CE RID: 1998
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteParams")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FMovieSceneQteParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AC87 RID: 44167 RVA: 0x000FEAA7 File Offset: 0x000FCCA7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteParams._ScriptStructPtr != 0) ? FMovieSceneQteParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteParams", ref FMovieSceneQteParams._ScriptStructPtr);
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x0600AC88 RID: 44168 RVA: 0x000FEACB File Offset: 0x000FCCCB
		// (set) Token: 0x0600AC89 RID: 44169 RVA: 0x000FEADB File Offset: 0x000FCCDB
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_QteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_QteId) = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x0600AC8A RID: 44170 RVA: 0x000FEAEC File Offset: 0x000FCCEC
		// (set) Token: 0x0600AC8B RID: 44171 RVA: 0x000FEAFC File Offset: 0x000FCCFC
		public unsafe bool IsGroupQte
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_IsGroupQte) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_IsGroupQte) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x0600AC8C RID: 44172 RVA: 0x000FEB0D File Offset: 0x000FCD0D
		// (set) Token: 0x0600AC8D RID: 44173 RVA: 0x000FEB1D File Offset: 0x000FCD1D
		public unsafe int SubtitleId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_SubtitleId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_SubtitleId) = value;
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x0600AC8E RID: 44174 RVA: 0x000FEB30 File Offset: 0x000FCD30
		// (set) Token: 0x0600AC8F RID: 44175 RVA: 0x000FEB73 File Offset: 0x000FCD73
		public FMovieSceneObjectBindingID AttachActor
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneObjectBindingID result;
				if ((result = this._AttachActor) == null)
				{
					result = (this._AttachActor = new FMovieSceneObjectBindingID(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_AttachActor, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneObjectBindingID.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_AttachActor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x0600AC90 RID: 44176 RVA: 0x000FEB94 File Offset: 0x000FCD94
		// (set) Token: 0x0600AC91 RID: 44177 RVA: 0x000FEBA4 File Offset: 0x000FCDA4
		public unsafe bool IsUpdateWithProgress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_IsUpdateWithProgress) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_IsUpdateWithProgress) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x0600AC92 RID: 44178 RVA: 0x000FEBB5 File Offset: 0x000FCDB5
		// (set) Token: 0x0600AC93 RID: 44179 RVA: 0x000FEBC9 File Offset: 0x000FCDC9
		[Nullable(2)]
		public unsafe ULevelSequence LevelSequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevelSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteParams.__PropertyOffset_LevelSequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FMovieSceneQteParams.__PropertyOffset_LevelSequence, value);
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x0600AC94 RID: 44180 RVA: 0x000FEBE0 File Offset: 0x000FCDE0
		// (set) Token: 0x0600AC95 RID: 44181 RVA: 0x000FEC23 File Offset: 0x000FCE23
		public FQteSpineInfo SpineInfo
		{
			get
			{
				base.FastCheckIsValid();
				FQteSpineInfo result;
				if ((result = this._SpineInfo) == null)
				{
					result = (this._SpineInfo = new FQteSpineInfo(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_SpineInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FQteSpineInfo.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_SpineInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x0600AC96 RID: 44182 RVA: 0x000FEC44 File Offset: 0x000FCE44
		// (set) Token: 0x0600AC97 RID: 44183 RVA: 0x000FEC87 File Offset: 0x000FCE87
		public TArray<FMovieSceneSubQteParams> SubQteParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneSubQteParams> result;
				if ((result = this._SubQteParams) == null)
				{
					result = (this._SubQteParams = new TArray<FMovieSceneSubQteParams>(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_SubQteParams, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubQteParams.CopyAssign(value);
			}
		}

		// Token: 0x0600AC98 RID: 44184 RVA: 0x000FEC95 File Offset: 0x000FCE95
		public FMovieSceneQteParams()
		{
		}

		// Token: 0x0600AC99 RID: 44185 RVA: 0x000FEC9D File Offset: 0x000FCE9D
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteParams.StaticStruct();
		}

		// Token: 0x0600AC9A RID: 44186 RVA: 0x000FECA9 File Offset: 0x000FCEA9
		[NullableContext(2)]
		public FMovieSceneQteParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AC9B RID: 44187 RVA: 0x000FECB3 File Offset: 0x000FCEB3
		public FMovieSceneQteParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AC9C RID: 44188 RVA: 0x000FECBE File Offset: 0x000FCEBE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteParams(Pointer, false, true);
		}

		// Token: 0x0600AC9D RID: 44189 RVA: 0x000FECC8 File Offset: 0x000FCEC8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteParams(Pointer, MemoryOwner);
		}

		// Token: 0x04004A5C RID: 19036
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteParams";

		// Token: 0x04004A5D RID: 19037
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004A5E RID: 19038
		internal static int __PropertyOffset_QteId;

		// Token: 0x04004A5F RID: 19039
		internal static int __PropertyOffset_IsGroupQte;

		// Token: 0x04004A60 RID: 19040
		internal static int __PropertyOffset_SubtitleId;

		// Token: 0x04004A61 RID: 19041
		internal static int __PropertyOffset_AttachActor;

		// Token: 0x04004A62 RID: 19042
		[Nullable(2)]
		private FMovieSceneObjectBindingID _AttachActor;

		// Token: 0x04004A63 RID: 19043
		internal static int __PropertyOffset_IsUpdateWithProgress;

		// Token: 0x04004A64 RID: 19044
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x04004A65 RID: 19045
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04004A66 RID: 19046
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;

		// Token: 0x04004A67 RID: 19047
		internal static int __PropertyOffset_SubQteParams;

		// Token: 0x04004A68 RID: 19048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSubQteParams> _SubQteParams;
	}
}
