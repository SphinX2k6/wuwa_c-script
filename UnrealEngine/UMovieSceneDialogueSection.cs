using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026E8 RID: 9960
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSection")]
	[UnrealStructLayout(488, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 488)]
	public class UMovieSceneDialogueSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024EF3 RID: 151283 RVA: 0x00369FF2 File Offset: 0x003681F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueSection._ClassPtr;
		}

		// Token: 0x06024EF4 RID: 151284 RVA: 0x0036A000 File Offset: 0x00368200
		public UMovieSceneDialogueSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024EF5 RID: 151285 RVA: 0x0036A028 File Offset: 0x00368228
		public UMovieSceneDialogueSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E94 RID: 36500
		// (get) Token: 0x06024EF6 RID: 151286 RVA: 0x0036A05C File Offset: 0x0036825C
		// (set) Token: 0x06024EF7 RID: 151287 RVA: 0x0036A095 File Offset: 0x00368295
		public unsafe FText DialogueInfo
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DialogueInfo) == null)
				{
					result = (this._DialogueInfo = new FText(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_DialogueInfo, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneDialogueSection.__PropertyOffset_DialogueInfo)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008E95 RID: 36501
		// (get) Token: 0x06024EF8 RID: 151288 RVA: 0x0036A0B0 File Offset: 0x003682B0
		// (set) Token: 0x06024EF9 RID: 151289 RVA: 0x0036A0C0 File Offset: 0x003682C0
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x17008E96 RID: 36502
		// (get) Token: 0x06024EFA RID: 151290 RVA: 0x0036A0D4 File Offset: 0x003682D4
		// (set) Token: 0x06024EFB RID: 151291 RVA: 0x0036A10D File Offset: 0x0036830D
		public unsafe FText SpeakerName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._SpeakerName) == null)
				{
					result = (this._SpeakerName = new FText(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_SpeakerName, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneDialogueSection.__PropertyOffset_SpeakerName)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008E97 RID: 36503
		// (get) Token: 0x06024EFC RID: 151292 RVA: 0x0036A128 File Offset: 0x00368328
		// (set) Token: 0x06024EFD RID: 151293 RVA: 0x0036A138 File Offset: 0x00368338
		public unsafe int SpeakerID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_SpeakerID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_SpeakerID) = value;
			}
		}

		// Token: 0x17008E98 RID: 36504
		// (get) Token: 0x06024EFE RID: 151294 RVA: 0x0036A14C File Offset: 0x0036834C
		// (set) Token: 0x06024EFF RID: 151295 RVA: 0x0036A185 File Offset: 0x00368385
		public unsafe FText DialogueID
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DialogueID) == null)
				{
					result = (this._DialogueID = new FText(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_DialogueID, this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneDialogueSection.__PropertyOffset_DialogueID)), value.NativePtr, 1);
			}
		}

		// Token: 0x17008E99 RID: 36505
		// (get) Token: 0x06024F00 RID: 151296 RVA: 0x0036A1A0 File Offset: 0x003683A0
		// (set) Token: 0x06024F01 RID: 151297 RVA: 0x0036A1D9 File Offset: 0x003683D9
		public TArray<FText> DialogueInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._DialogueInfos) == null)
				{
					result = (this._DialogueInfos = new TArray<FText>(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_DialogueInfos, this));
				}
				return result;
			}
			set
			{
				this.DialogueInfos.CopyAssign(value);
			}
		}

		// Token: 0x17008E9A RID: 36506
		// (get) Token: 0x06024F02 RID: 151298 RVA: 0x0036A1E8 File Offset: 0x003683E8
		// (set) Token: 0x06024F03 RID: 151299 RVA: 0x0036A221 File Offset: 0x00368421
		public TArray<FText> OptionInfos
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FText> result;
				if ((result = this._OptionInfos) == null)
				{
					result = (this._OptionInfos = new TArray<FText>(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_OptionInfos, this));
				}
				return result;
			}
			set
			{
				this.OptionInfos.CopyAssign(value);
			}
		}

		// Token: 0x17008E9B RID: 36507
		// (get) Token: 0x06024F04 RID: 151300 RVA: 0x0036A22F File Offset: 0x0036842F
		// (set) Token: 0x06024F05 RID: 151301 RVA: 0x0036A23F File Offset: 0x0036843F
		public unsafe int GuardTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_GuardTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_GuardTime) = value;
			}
		}

		// Token: 0x17008E9C RID: 36508
		// (get) Token: 0x06024F06 RID: 151302 RVA: 0x0036A250 File Offset: 0x00368450
		// (set) Token: 0x06024F07 RID: 151303 RVA: 0x0036A260 File Offset: 0x00368460
		public unsafe int AudioDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AudioDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AudioDelay) = value;
			}
		}

		// Token: 0x17008E9D RID: 36509
		// (get) Token: 0x06024F08 RID: 151304 RVA: 0x0036A271 File Offset: 0x00368471
		// (set) Token: 0x06024F09 RID: 151305 RVA: 0x0036A281 File Offset: 0x00368481
		public unsafe int AudioTransitionDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AudioTransitionDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AudioTransitionDuration) = value;
			}
		}

		// Token: 0x17008E9E RID: 36510
		// (get) Token: 0x06024F0A RID: 151306 RVA: 0x0036A292 File Offset: 0x00368492
		// (set) Token: 0x06024F0B RID: 151307 RVA: 0x0036A2A2 File Offset: 0x003684A2
		public unsafe ELanguageAudio LanguageType
		{
			get
			{
				return (ELanguageAudio)(*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_LanguageType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_LanguageType) = (byte)value;
			}
		}

		// Token: 0x17008E9F RID: 36511
		// (get) Token: 0x06024F0C RID: 151308 RVA: 0x0036A2B3 File Offset: 0x003684B3
		// (set) Token: 0x06024F0D RID: 151309 RVA: 0x0036A2C3 File Offset: 0x003684C3
		public unsafe int QteId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_QteId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_QteId) = value;
			}
		}

		// Token: 0x17008EA0 RID: 36512
		// (get) Token: 0x06024F0E RID: 151310 RVA: 0x0036A2D4 File Offset: 0x003684D4
		// (set) Token: 0x06024F0F RID: 151311 RVA: 0x0036A2E4 File Offset: 0x003684E4
		public unsafe int AutoPlayDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AutoPlayDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_AutoPlayDelay) = value;
			}
		}

		// Token: 0x17008EA1 RID: 36513
		// (get) Token: 0x06024F10 RID: 151312 RVA: 0x0036A2F5 File Offset: 0x003684F5
		// (set) Token: 0x06024F11 RID: 151313 RVA: 0x0036A305 File Offset: 0x00368505
		public unsafe bool EnableGuardTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_EnableGuardTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_EnableGuardTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008EA2 RID: 36514
		// (get) Token: 0x06024F12 RID: 151314 RVA: 0x0036A316 File Offset: 0x00368516
		// (set) Token: 0x06024F13 RID: 151315 RVA: 0x0036A326 File Offset: 0x00368526
		public unsafe bool EnableAutoPlayDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_EnableAutoPlayDelay) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_EnableAutoPlayDelay) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008EA3 RID: 36515
		// (get) Token: 0x06024F14 RID: 151316 RVA: 0x0036A338 File Offset: 0x00368538
		// (set) Token: 0x06024F15 RID: 151317 RVA: 0x0036A371 File Offset: 0x00368571
		public TArray<int> UnisonIdList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._UnisonIdList) == null)
				{
					result = (this._UnisonIdList = new TArray<int>(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_UnisonIdList, this));
				}
				return result;
			}
			set
			{
				this.UnisonIdList.CopyAssign(value);
			}
		}

		// Token: 0x17008EA4 RID: 36516
		// (get) Token: 0x06024F16 RID: 151318 RVA: 0x0036A37F File Offset: 0x0036857F
		// (set) Token: 0x06024F17 RID: 151319 RVA: 0x0036A393 File Offset: 0x00368593
		public unsafe FName Emotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_Emotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneDialogueSection.__PropertyOffset_Emotion) = value;
			}
		}

		// Token: 0x06024F18 RID: 151320 RVA: 0x0036A3A8 File Offset: 0x003685A8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe TArray<string> GetEmotionNames()
		{
			UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams* ptr = stackalloc UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr, 0);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x06024F19 RID: 151321 RVA: 0x0036A407 File Offset: 0x00368607
		static UMovieSceneDialogueSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueSection");
		}

		// Token: 0x06024F1A RID: 151322 RVA: 0x0036A415 File Offset: 0x00368615
		protected UMovieSceneDialogueSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E6B RID: 81515
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSection";

		// Token: 0x04013E6C RID: 81516
		private static IntPtr _ClassPtr;

		// Token: 0x04013E6D RID: 81517
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E6E RID: 81518
		internal static int __PropertyOffset_DialogueInfo;

		// Token: 0x04013E6F RID: 81519
		[Nullable(2)]
		private FText _DialogueInfo;

		// Token: 0x04013E70 RID: 81520
		internal static int __PropertyOffset_Index;

		// Token: 0x04013E71 RID: 81521
		internal static int __PropertyOffset_SpeakerName;

		// Token: 0x04013E72 RID: 81522
		[Nullable(2)]
		private FText _SpeakerName;

		// Token: 0x04013E73 RID: 81523
		internal static int __PropertyOffset_SpeakerID;

		// Token: 0x04013E74 RID: 81524
		internal static int __PropertyOffset_DialogueID;

		// Token: 0x04013E75 RID: 81525
		[Nullable(2)]
		private FText _DialogueID;

		// Token: 0x04013E76 RID: 81526
		internal static int __PropertyOffset_DialogueInfos;

		// Token: 0x04013E77 RID: 81527
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _DialogueInfos;

		// Token: 0x04013E78 RID: 81528
		internal static int __PropertyOffset_OptionInfos;

		// Token: 0x04013E79 RID: 81529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _OptionInfos;

		// Token: 0x04013E7A RID: 81530
		internal static int __PropertyOffset_GuardTime;

		// Token: 0x04013E7B RID: 81531
		internal static int __PropertyOffset_AudioDelay;

		// Token: 0x04013E7C RID: 81532
		internal static int __PropertyOffset_AudioTransitionDuration;

		// Token: 0x04013E7D RID: 81533
		internal static int __PropertyOffset_LanguageType;

		// Token: 0x04013E7E RID: 81534
		internal static int __PropertyOffset_QteId;

		// Token: 0x04013E7F RID: 81535
		internal static int __PropertyOffset_AutoPlayDelay;

		// Token: 0x04013E80 RID: 81536
		internal static int __PropertyOffset_EnableGuardTime;

		// Token: 0x04013E81 RID: 81537
		internal static int __PropertyOffset_EnableAutoPlayDelay;

		// Token: 0x04013E82 RID: 81538
		internal static int __PropertyOffset_UnisonIdList;

		// Token: 0x04013E83 RID: 81539
		[Nullable(2)]
		private TArray<int> _UnisonIdList;

		// Token: 0x04013E84 RID: 81540
		internal static int __PropertyOffset_Emotion;

		// Token: 0x04013E85 RID: 81541
		private static IntPtr __GetEmotionNames_NativeFunctionPtr;

		// Token: 0x02003695 RID: 13973
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEmotionNames_FunctionParams
		{
			// Token: 0x04017788 RID: 96136
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
