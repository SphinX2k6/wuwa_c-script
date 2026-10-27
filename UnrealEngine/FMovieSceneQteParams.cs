using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026F4 RID: 9972
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneQteParams")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 200)]
	public class FMovieSceneQteParams : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024FD6 RID: 151510 RVA: 0x0036B82B File Offset: 0x00369A2B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneQteParams._ScriptStructPtr != 0) ? FMovieSceneQteParams._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneQteParams", ref FMovieSceneQteParams._ScriptStructPtr);
		}

		// Token: 0x17008ED7 RID: 36567
		// (get) Token: 0x06024FD7 RID: 151511 RVA: 0x0036B84F File Offset: 0x00369A4F
		// (set) Token: 0x06024FD8 RID: 151512 RVA: 0x0036B85F File Offset: 0x00369A5F
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

		// Token: 0x17008ED8 RID: 36568
		// (get) Token: 0x06024FD9 RID: 151513 RVA: 0x0036B870 File Offset: 0x00369A70
		// (set) Token: 0x06024FDA RID: 151514 RVA: 0x0036B880 File Offset: 0x00369A80
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

		// Token: 0x17008ED9 RID: 36569
		// (get) Token: 0x06024FDB RID: 151515 RVA: 0x0036B891 File Offset: 0x00369A91
		// (set) Token: 0x06024FDC RID: 151516 RVA: 0x0036B8A1 File Offset: 0x00369AA1
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

		// Token: 0x17008EDA RID: 36570
		// (get) Token: 0x06024FDD RID: 151517 RVA: 0x0036B8B4 File Offset: 0x00369AB4
		// (set) Token: 0x06024FDE RID: 151518 RVA: 0x0036B8F7 File Offset: 0x00369AF7
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

		// Token: 0x17008EDB RID: 36571
		// (get) Token: 0x06024FDF RID: 151519 RVA: 0x0036B918 File Offset: 0x00369B18
		// (set) Token: 0x06024FE0 RID: 151520 RVA: 0x0036B928 File Offset: 0x00369B28
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

		// Token: 0x17008EDC RID: 36572
		// (get) Token: 0x06024FE1 RID: 151521 RVA: 0x0036B93C File Offset: 0x00369B3C
		// (set) Token: 0x06024FE2 RID: 151522 RVA: 0x0036B97F File Offset: 0x00369B7F
		public TArray<FMovieSceneQteAnimParams> Anims
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMovieSceneQteAnimParams> result;
				if ((result = this._Anims) == null)
				{
					result = (this._Anims = new TArray<FMovieSceneQteAnimParams>(base.NativePtr + (IntPtr)FMovieSceneQteParams.__PropertyOffset_Anims, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Anims.CopyAssign(value);
			}
		}

		// Token: 0x17008EDD RID: 36573
		// (get) Token: 0x06024FE3 RID: 151523 RVA: 0x0036B98D File Offset: 0x00369B8D
		// (set) Token: 0x06024FE4 RID: 151524 RVA: 0x0036B9A1 File Offset: 0x00369BA1
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

		// Token: 0x17008EDE RID: 36574
		// (get) Token: 0x06024FE5 RID: 151525 RVA: 0x0036B9B8 File Offset: 0x00369BB8
		// (set) Token: 0x06024FE6 RID: 151526 RVA: 0x0036B9FB File Offset: 0x00369BFB
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

		// Token: 0x17008EDF RID: 36575
		// (get) Token: 0x06024FE7 RID: 151527 RVA: 0x0036BA1C File Offset: 0x00369C1C
		// (set) Token: 0x06024FE8 RID: 151528 RVA: 0x0036BA5F File Offset: 0x00369C5F
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

		// Token: 0x06024FE9 RID: 151529 RVA: 0x0036BA6D File Offset: 0x00369C6D
		public FMovieSceneQteParams()
		{
		}

		// Token: 0x06024FEA RID: 151530 RVA: 0x0036BA78 File Offset: 0x00369C78
		public FMovieSceneQteParams(int QteId, bool IsGroupQte, int SubtitleId, FMovieSceneObjectBindingID AttachActor, bool IsUpdateWithProgress, TArray<FMovieSceneQteAnimParams> Anims, ULevelSequence LevelSequence, FQteSpineInfo SpineInfo, TArray<FMovieSceneSubQteParams> SubQteParams)
		{
			this.QteId = QteId;
			this.IsGroupQte = IsGroupQte;
			this.SubtitleId = SubtitleId;
			this.AttachActor = AttachActor;
			this.IsUpdateWithProgress = IsUpdateWithProgress;
			this.Anims = Anims;
			this.LevelSequence = LevelSequence;
			this.SpineInfo = SpineInfo;
			this.SubQteParams = SubQteParams;
		}

		// Token: 0x06024FEB RID: 151531 RVA: 0x0036BAD0 File Offset: 0x00369CD0
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneQteParams.StaticStruct();
		}

		// Token: 0x06024FEC RID: 151532 RVA: 0x0036BADC File Offset: 0x00369CDC
		[NullableContext(2)]
		public FMovieSceneQteParams(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024FED RID: 151533 RVA: 0x0036BAE6 File Offset: 0x00369CE6
		public FMovieSceneQteParams(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024FEE RID: 151534 RVA: 0x0036BAF1 File Offset: 0x00369CF1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneQteParams(Pointer, false, true);
		}

		// Token: 0x06024FEF RID: 151535 RVA: 0x0036BAFB File Offset: 0x00369CFB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneQteParams(Pointer, MemoryOwner);
		}

		// Token: 0x04013EEF RID: 81647
		public const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneQteParams";

		// Token: 0x04013EF0 RID: 81648
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013EF1 RID: 81649
		internal static int __PropertyOffset_QteId;

		// Token: 0x04013EF2 RID: 81650
		internal static int __PropertyOffset_IsGroupQte;

		// Token: 0x04013EF3 RID: 81651
		internal static int __PropertyOffset_SubtitleId;

		// Token: 0x04013EF4 RID: 81652
		internal static int __PropertyOffset_AttachActor;

		// Token: 0x04013EF5 RID: 81653
		[Nullable(2)]
		private FMovieSceneObjectBindingID _AttachActor;

		// Token: 0x04013EF6 RID: 81654
		internal static int __PropertyOffset_IsUpdateWithProgress;

		// Token: 0x04013EF7 RID: 81655
		internal static int __PropertyOffset_Anims;

		// Token: 0x04013EF8 RID: 81656
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneQteAnimParams> _Anims;

		// Token: 0x04013EF9 RID: 81657
		internal static int __PropertyOffset_LevelSequence;

		// Token: 0x04013EFA RID: 81658
		internal static int __PropertyOffset_SpineInfo;

		// Token: 0x04013EFB RID: 81659
		[Nullable(2)]
		private FQteSpineInfo _SpineInfo;

		// Token: 0x04013EFC RID: 81660
		internal static int __PropertyOffset_SubQteParams;

		// Token: 0x04013EFD RID: 81661
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMovieSceneSubQteParams> _SubQteParams;
	}
}
