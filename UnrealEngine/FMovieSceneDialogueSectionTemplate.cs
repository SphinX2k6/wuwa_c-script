using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020026E9 RID: 9961
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSectionTemplate")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FMovieSceneDialogueSectionTemplate : FMovieSceneEvalTemplate, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024F1B RID: 151323 RVA: 0x0036A41E File Offset: 0x0036861E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneDialogueSectionTemplate._ScriptStructPtr != 0) ? FMovieSceneDialogueSectionTemplate._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SequenceDialogue.MovieSceneDialogueSectionTemplate", ref FMovieSceneDialogueSectionTemplate._ScriptStructPtr);
		}

		// Token: 0x17008EA5 RID: 36517
		// (get) Token: 0x06024F1C RID: 151324 RVA: 0x0036A444 File Offset: 0x00368644
		// (set) Token: 0x06024F1D RID: 151325 RVA: 0x0036A487 File Offset: 0x00368687
		public unsafe FText DialogueInfo
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DialogueInfo) == null)
				{
					result = (this._DialogueInfo = new FText(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueInfo)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008EA6 RID: 36518
		// (get) Token: 0x06024F1E RID: 151326 RVA: 0x0036A4A4 File Offset: 0x003686A4
		// (set) Token: 0x06024F1F RID: 151327 RVA: 0x0036A4E7 File Offset: 0x003686E7
		public unsafe FText SpeakerName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._SpeakerName) == null)
				{
					result = (this._SpeakerName = new FText(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_SpeakerName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_SpeakerName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008EA7 RID: 36519
		// (get) Token: 0x06024F20 RID: 151328 RVA: 0x0036A504 File Offset: 0x00368704
		// (set) Token: 0x06024F21 RID: 151329 RVA: 0x0036A547 File Offset: 0x00368747
		public unsafe FText DialogueID
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DialogueID) == null)
				{
					result = (this._DialogueID = new FText(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueID, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueID)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008EA8 RID: 36520
		// (get) Token: 0x06024F22 RID: 151330 RVA: 0x0036A562 File Offset: 0x00368762
		// (set) Token: 0x06024F23 RID: 151331 RVA: 0x0036A572 File Offset: 0x00368772
		public unsafe int GuardTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_GuardTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_GuardTime) = value;
			}
		}

		// Token: 0x17008EA9 RID: 36521
		// (get) Token: 0x06024F24 RID: 151332 RVA: 0x0036A583 File Offset: 0x00368783
		// (set) Token: 0x06024F25 RID: 151333 RVA: 0x0036A593 File Offset: 0x00368793
		public unsafe int AudioDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AudioDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AudioDelay) = value;
			}
		}

		// Token: 0x17008EAA RID: 36522
		// (get) Token: 0x06024F26 RID: 151334 RVA: 0x0036A5A4 File Offset: 0x003687A4
		// (set) Token: 0x06024F27 RID: 151335 RVA: 0x0036A5B4 File Offset: 0x003687B4
		public unsafe int AudioTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AudioTransitionDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AudioTransitionDuration) = value;
			}
		}

		// Token: 0x17008EAB RID: 36523
		// (get) Token: 0x06024F28 RID: 151336 RVA: 0x0036A5C8 File Offset: 0x003687C8
		// (set) Token: 0x06024F29 RID: 151337 RVA: 0x0036A60B File Offset: 0x0036880B
		public TArray<FText> Options
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._Options) == null)
				{
					result = (this._Options = new TArray<FText>(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_Options, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Options.CopyAssign(value);
			}
		}

		// Token: 0x17008EAC RID: 36524
		// (get) Token: 0x06024F2A RID: 151338 RVA: 0x0036A61C File Offset: 0x0036881C
		// (set) Token: 0x06024F2B RID: 151339 RVA: 0x0036A65F File Offset: 0x0036885F
		public unsafe FText DialogueKey
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DialogueKey) == null)
				{
					result = (this._DialogueKey = new FText(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueKey, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_DialogueKey)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008EAD RID: 36525
		// (get) Token: 0x06024F2C RID: 151340 RVA: 0x0036A67A File Offset: 0x0036887A
		// (set) Token: 0x06024F2D RID: 151341 RVA: 0x0036A68A File Offset: 0x0036888A
		public unsafe int SpeakerID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_SpeakerID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_SpeakerID) = value;
			}
		}

		// Token: 0x17008EAE RID: 36526
		// (get) Token: 0x06024F2E RID: 151342 RVA: 0x0036A69B File Offset: 0x0036889B
		// (set) Token: 0x06024F2F RID: 151343 RVA: 0x0036A6AB File Offset: 0x003688AB
		public unsafe ELanguageAudio LanguageType
		{
			get
			{
				return (ELanguageAudio)(*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_LanguageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_LanguageType) = (byte)value;
			}
		}

		// Token: 0x17008EAF RID: 36527
		// (get) Token: 0x06024F30 RID: 151344 RVA: 0x0036A6BC File Offset: 0x003688BC
		// (set) Token: 0x06024F31 RID: 151345 RVA: 0x0036A6CC File Offset: 0x003688CC
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_QteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_QteId) = value;
			}
		}

		// Token: 0x17008EB0 RID: 36528
		// (get) Token: 0x06024F32 RID: 151346 RVA: 0x0036A6DD File Offset: 0x003688DD
		// (set) Token: 0x06024F33 RID: 151347 RVA: 0x0036A6ED File Offset: 0x003688ED
		public unsafe int AutoPlayDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AutoPlayDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_AutoPlayDelay) = value;
			}
		}

		// Token: 0x17008EB1 RID: 36529
		// (get) Token: 0x06024F34 RID: 151348 RVA: 0x0036A700 File Offset: 0x00368900
		// (set) Token: 0x06024F35 RID: 151349 RVA: 0x0036A743 File Offset: 0x00368943
		public TArray<int> UnisonIdList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._UnisonIdList) == null)
				{
					result = (this._UnisonIdList = new TArray<int>(base.NativePtr + (IntPtr)FMovieSceneDialogueSectionTemplate.__PropertyOffset_UnisonIdList, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.UnisonIdList.CopyAssign(value);
			}
		}

		// Token: 0x06024F36 RID: 151350 RVA: 0x0036A751 File Offset: 0x00368951
		public FMovieSceneDialogueSectionTemplate()
		{
		}

		// Token: 0x06024F37 RID: 151351 RVA: 0x0036A75C File Offset: 0x0036895C
		public FMovieSceneDialogueSectionTemplate(FText DialogueInfo, FText SpeakerName, FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, TArray<FText> Options, FText DialogueKey, int SpeakerID, ELanguageAudio LanguageType, int QteId, int AutoPlayDelay, TArray<int> UnisonIdList, EMovieSceneCompletionMode CompletionMode, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr)
		{
			this.DialogueInfo = DialogueInfo;
			this.SpeakerName = SpeakerName;
			this.DialogueID = DialogueID;
			this.GuardTime = GuardTime;
			this.AudioDelay = AudioDelay;
			this.AudioTransitionDuration = AudioTransitionDuration;
			this.Options = Options;
			this.DialogueKey = DialogueKey;
			this.SpeakerID = SpeakerID;
			this.LanguageType = LanguageType;
			this.QteId = QteId;
			this.AutoPlayDelay = AutoPlayDelay;
			this.UnisonIdList = UnisonIdList;
			base.CompletionMode = CompletionMode;
			base.SourceSectionPtr = SourceSectionPtr;
		}

		// Token: 0x06024F38 RID: 151352 RVA: 0x0036A7E4 File Offset: 0x003689E4
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneDialogueSectionTemplate.StaticStruct();
		}

		// Token: 0x06024F39 RID: 151353 RVA: 0x0036A7F0 File Offset: 0x003689F0
		[NullableContext(2)]
		public FMovieSceneDialogueSectionTemplate(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x0036A7FA File Offset: 0x003689FA
		public FMovieSceneDialogueSectionTemplate(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024F3B RID: 151355 RVA: 0x0036A805 File Offset: 0x00368A05
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneDialogueSectionTemplate(Pointer, false, true);
		}

		// Token: 0x06024F3C RID: 151356 RVA: 0x0036A80F File Offset: 0x00368A0F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneDialogueSectionTemplate(Pointer, MemoryOwner);
		}

		// Token: 0x04013E86 RID: 81542
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSectionTemplate";

		// Token: 0x04013E87 RID: 81543
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013E88 RID: 81544
		internal static int __PropertyOffset_DialogueInfo;

		// Token: 0x04013E89 RID: 81545
		[Nullable(2)]
		private FText _DialogueInfo;

		// Token: 0x04013E8A RID: 81546
		internal static int __PropertyOffset_SpeakerName;

		// Token: 0x04013E8B RID: 81547
		[Nullable(2)]
		private FText _SpeakerName;

		// Token: 0x04013E8C RID: 81548
		internal static int __PropertyOffset_DialogueID;

		// Token: 0x04013E8D RID: 81549
		[Nullable(2)]
		private FText _DialogueID;

		// Token: 0x04013E8E RID: 81550
		internal static int __PropertyOffset_GuardTime;

		// Token: 0x04013E8F RID: 81551
		internal static int __PropertyOffset_AudioDelay;

		// Token: 0x04013E90 RID: 81552
		internal static int __PropertyOffset_AudioTransitionDuration;

		// Token: 0x04013E91 RID: 81553
		internal static int __PropertyOffset_Options;

		// Token: 0x04013E92 RID: 81554
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _Options;

		// Token: 0x04013E93 RID: 81555
		internal static int __PropertyOffset_DialogueKey;

		// Token: 0x04013E94 RID: 81556
		[Nullable(2)]
		private FText _DialogueKey;

		// Token: 0x04013E95 RID: 81557
		internal static int __PropertyOffset_SpeakerID;

		// Token: 0x04013E96 RID: 81558
		internal static int __PropertyOffset_LanguageType;

		// Token: 0x04013E97 RID: 81559
		internal static int __PropertyOffset_QteId;

		// Token: 0x04013E98 RID: 81560
		internal static int __PropertyOffset_AutoPlayDelay;

		// Token: 0x04013E99 RID: 81561
		internal static int __PropertyOffset_UnisonIdList;

		// Token: 0x04013E9A RID: 81562
		[Nullable(2)]
		private TArray<int> _UnisonIdList;
	}
}
