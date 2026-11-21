using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007C7 RID: 1991
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSection")]
	[UnrealStructLayout(528, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 528)]
	public class UMovieSceneDialogueSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600ABF3 RID: 44019 RVA: 0x000FD99E File Offset: 0x000FBB9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueSection._ClassPtr;
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x000FD9AC File Offset: 0x000FBBAC
		public UMovieSceneDialogueSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x000FD9D4 File Offset: 0x000FBBD4
		public UMovieSceneDialogueSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002001 RID: 8193
		// (get) Token: 0x0600ABF6 RID: 44022 RVA: 0x000FDA08 File Offset: 0x000FBC08
		// (set) Token: 0x0600ABF7 RID: 44023 RVA: 0x000FDA41 File Offset: 0x000FBC41
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

		// Token: 0x17002002 RID: 8194
		// (get) Token: 0x0600ABF8 RID: 44024 RVA: 0x000FDA5C File Offset: 0x000FBC5C
		// (set) Token: 0x0600ABF9 RID: 44025 RVA: 0x000FDA6C File Offset: 0x000FBC6C
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

		// Token: 0x17002003 RID: 8195
		// (get) Token: 0x0600ABFA RID: 44026 RVA: 0x000FDA80 File Offset: 0x000FBC80
		// (set) Token: 0x0600ABFB RID: 44027 RVA: 0x000FDAB9 File Offset: 0x000FBCB9
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

		// Token: 0x17002004 RID: 8196
		// (get) Token: 0x0600ABFC RID: 44028 RVA: 0x000FDAD4 File Offset: 0x000FBCD4
		// (set) Token: 0x0600ABFD RID: 44029 RVA: 0x000FDAE4 File Offset: 0x000FBCE4
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

		// Token: 0x17002005 RID: 8197
		// (get) Token: 0x0600ABFE RID: 44030 RVA: 0x000FDAF8 File Offset: 0x000FBCF8
		// (set) Token: 0x0600ABFF RID: 44031 RVA: 0x000FDB31 File Offset: 0x000FBD31
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

		// Token: 0x17002006 RID: 8198
		// (get) Token: 0x0600AC00 RID: 44032 RVA: 0x000FDB4C File Offset: 0x000FBD4C
		// (set) Token: 0x0600AC01 RID: 44033 RVA: 0x000FDB85 File Offset: 0x000FBD85
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

		// Token: 0x17002007 RID: 8199
		// (get) Token: 0x0600AC02 RID: 44034 RVA: 0x000FDB94 File Offset: 0x000FBD94
		// (set) Token: 0x0600AC03 RID: 44035 RVA: 0x000FDBCD File Offset: 0x000FBDCD
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

		// Token: 0x17002008 RID: 8200
		// (get) Token: 0x0600AC04 RID: 44036 RVA: 0x000FDBDB File Offset: 0x000FBDDB
		// (set) Token: 0x0600AC05 RID: 44037 RVA: 0x000FDBEB File Offset: 0x000FBDEB
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

		// Token: 0x17002009 RID: 8201
		// (get) Token: 0x0600AC06 RID: 44038 RVA: 0x000FDBFC File Offset: 0x000FBDFC
		// (set) Token: 0x0600AC07 RID: 44039 RVA: 0x000FDC0C File Offset: 0x000FBE0C
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

		// Token: 0x1700200A RID: 8202
		// (get) Token: 0x0600AC08 RID: 44040 RVA: 0x000FDC1D File Offset: 0x000FBE1D
		// (set) Token: 0x0600AC09 RID: 44041 RVA: 0x000FDC2D File Offset: 0x000FBE2D
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

		// Token: 0x1700200B RID: 8203
		// (get) Token: 0x0600AC0A RID: 44042 RVA: 0x000FDC3E File Offset: 0x000FBE3E
		// (set) Token: 0x0600AC0B RID: 44043 RVA: 0x000FDC4E File Offset: 0x000FBE4E
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

		// Token: 0x1700200C RID: 8204
		// (get) Token: 0x0600AC0C RID: 44044 RVA: 0x000FDC5F File Offset: 0x000FBE5F
		// (set) Token: 0x0600AC0D RID: 44045 RVA: 0x000FDC6F File Offset: 0x000FBE6F
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

		// Token: 0x1700200D RID: 8205
		// (get) Token: 0x0600AC0E RID: 44046 RVA: 0x000FDC80 File Offset: 0x000FBE80
		// (set) Token: 0x0600AC0F RID: 44047 RVA: 0x000FDC90 File Offset: 0x000FBE90
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

		// Token: 0x1700200E RID: 8206
		// (get) Token: 0x0600AC10 RID: 44048 RVA: 0x000FDCA1 File Offset: 0x000FBEA1
		// (set) Token: 0x0600AC11 RID: 44049 RVA: 0x000FDCB1 File Offset: 0x000FBEB1
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

		// Token: 0x1700200F RID: 8207
		// (get) Token: 0x0600AC12 RID: 44050 RVA: 0x000FDCC2 File Offset: 0x000FBEC2
		// (set) Token: 0x0600AC13 RID: 44051 RVA: 0x000FDCD2 File Offset: 0x000FBED2
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

		// Token: 0x17002010 RID: 8208
		// (get) Token: 0x0600AC14 RID: 44052 RVA: 0x000FDCE4 File Offset: 0x000FBEE4
		// (set) Token: 0x0600AC15 RID: 44053 RVA: 0x000FDD1D File Offset: 0x000FBF1D
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

		// Token: 0x17002011 RID: 8209
		// (get) Token: 0x0600AC16 RID: 44054 RVA: 0x000FDD2B File Offset: 0x000FBF2B
		// (set) Token: 0x0600AC17 RID: 44055 RVA: 0x000FDD3F File Offset: 0x000FBF3F
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

		// Token: 0x0600AC18 RID: 44056 RVA: 0x000FDD54 File Offset: 0x000FBF54
		[SkipLocalsInit]
		public unsafe TArray<string> GetTargetBindingNameOptions()
		{
			UMovieSceneDialogueSection.__GetTargetBindingNameOptions_FunctionParams* ptr = stackalloc UMovieSceneDialogueSection.__GetTargetBindingNameOptions_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMovieSceneDialogueSection.__GetTargetBindingNameOptions_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSection.__GetTargetBindingNameOptions_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSection.__GetTargetBindingNameOptions_NativeFunctionPtr, (void*)ptr);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSection.__GetTargetBindingNameOptions_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600AC19 RID: 44057 RVA: 0x000FDDB4 File Offset: 0x000FBFB4
		[SkipLocalsInit]
		public unsafe TArray<string> GetEmotionNames()
		{
			UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams* ptr = stackalloc UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UMovieSceneDialogueSection.__GetEmotionNames_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr);
			TArray<string> result = new TArray<string>(&ptr->__Result, true, true);
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSection.__GetEmotionNames_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0600AC1A RID: 44058 RVA: 0x000FDE12 File Offset: 0x000FC012
		[SkipLocalsInit]
		public void CreateAutoMouthAnimation()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSection.__CreateAutoMouthAnimation_NativeFunctionPtr, null);
		}

		// Token: 0x0600AC1B RID: 44059 RVA: 0x000FDE26 File Offset: 0x000FC026
		static UMovieSceneDialogueSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueSection");
		}

		// Token: 0x0600AC1C RID: 44060 RVA: 0x000FDE34 File Offset: 0x000FC034
		protected UMovieSceneDialogueSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040049FD RID: 18941
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSection";

		// Token: 0x040049FE RID: 18942
		private static IntPtr _ClassPtr;

		// Token: 0x040049FF RID: 18943
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A00 RID: 18944
		internal static int __PropertyOffset_DialogueInfo;

		// Token: 0x04004A01 RID: 18945
		[Nullable(2)]
		private FText _DialogueInfo;

		// Token: 0x04004A02 RID: 18946
		internal static int __PropertyOffset_Index;

		// Token: 0x04004A03 RID: 18947
		internal static int __PropertyOffset_SpeakerName;

		// Token: 0x04004A04 RID: 18948
		[Nullable(2)]
		private FText _SpeakerName;

		// Token: 0x04004A05 RID: 18949
		internal static int __PropertyOffset_SpeakerID;

		// Token: 0x04004A06 RID: 18950
		internal static int __PropertyOffset_DialogueID;

		// Token: 0x04004A07 RID: 18951
		[Nullable(2)]
		private FText _DialogueID;

		// Token: 0x04004A08 RID: 18952
		internal static int __PropertyOffset_DialogueInfos;

		// Token: 0x04004A09 RID: 18953
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _DialogueInfos;

		// Token: 0x04004A0A RID: 18954
		internal static int __PropertyOffset_OptionInfos;

		// Token: 0x04004A0B RID: 18955
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FText> _OptionInfos;

		// Token: 0x04004A0C RID: 18956
		internal static int __PropertyOffset_GuardTime;

		// Token: 0x04004A0D RID: 18957
		internal static int __PropertyOffset_AudioDelay;

		// Token: 0x04004A0E RID: 18958
		internal static int __PropertyOffset_AudioTransitionDuration;

		// Token: 0x04004A0F RID: 18959
		internal static int __PropertyOffset_LanguageType;

		// Token: 0x04004A10 RID: 18960
		internal static int __PropertyOffset_QteId;

		// Token: 0x04004A11 RID: 18961
		internal static int __PropertyOffset_AutoPlayDelay;

		// Token: 0x04004A12 RID: 18962
		internal static int __PropertyOffset_EnableGuardTime;

		// Token: 0x04004A13 RID: 18963
		internal static int __PropertyOffset_EnableAutoPlayDelay;

		// Token: 0x04004A14 RID: 18964
		internal static int __PropertyOffset_UnisonIdList;

		// Token: 0x04004A15 RID: 18965
		[Nullable(2)]
		private TArray<int> _UnisonIdList;

		// Token: 0x04004A16 RID: 18966
		internal static int __PropertyOffset_Emotion;

		// Token: 0x04004A17 RID: 18967
		private static IntPtr __GetTargetBindingNameOptions_NativeFunctionPtr;

		// Token: 0x04004A18 RID: 18968
		private static IntPtr __GetEmotionNames_NativeFunctionPtr;

		// Token: 0x04004A19 RID: 18969
		private static IntPtr __CreateAutoMouthAnimation_NativeFunctionPtr;

		// Token: 0x02000F6F RID: 3951
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetTargetBindingNameOptions_FunctionParams
		{
			// Token: 0x04006349 RID: 25417
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000F70 RID: 3952
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetEmotionNames_FunctionParams
		{
			// Token: 0x0400634A RID: 25418
			[FieldOffset(0)]
			public byte __Result;
		}
	}
}
