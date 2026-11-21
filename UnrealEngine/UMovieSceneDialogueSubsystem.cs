using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007CA RID: 1994
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSubsystem")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UMovieSceneDialogueSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AC2B RID: 44075 RVA: 0x000FDFAE File Offset: 0x000FC1AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueSubsystem._ClassPtr;
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x000FDFBC File Offset: 0x000FC1BC
		public UMovieSceneDialogueSubsystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AC2D RID: 44077 RVA: 0x000FDFE4 File Offset: 0x000FC1E4
		public UMovieSceneDialogueSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002014 RID: 8212
		// (get) Token: 0x0600AC2E RID: 44078 RVA: 0x000FE018 File Offset: 0x000FC218
		// (set) Token: 0x0600AC2F RID: 44079 RVA: 0x000FE051 File Offset: 0x000FC251
		public FOnDialogueEvent OnShowDialogue
		{
			get
			{
				base.FastCheckIsValid();
				FOnDialogueEvent result;
				if ((result = this._OnShowDialogue) == null)
				{
					result = (this._OnShowDialogue = new FOnDialogueEvent(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogue, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogue, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002015 RID: 8213
		// (get) Token: 0x0600AC30 RID: 44080 RVA: 0x000FE074 File Offset: 0x000FC274
		// (set) Token: 0x0600AC31 RID: 44081 RVA: 0x000FE0AD File Offset: 0x000FC2AD
		public FOnDialogueWithUnisonEvent OnShowDialogueWithUnison
		{
			get
			{
				base.FastCheckIsValid();
				FOnDialogueWithUnisonEvent result;
				if ((result = this._OnShowDialogueWithUnison) == null)
				{
					result = (this._OnShowDialogueWithUnison = new FOnDialogueWithUnisonEvent(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogueWithUnison, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogueWithUnison, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002016 RID: 8214
		// (get) Token: 0x0600AC32 RID: 44082 RVA: 0x000FE0D0 File Offset: 0x000FC2D0
		// (set) Token: 0x0600AC33 RID: 44083 RVA: 0x000FE109 File Offset: 0x000FC309
		public FOnDialogueAudioEvent OnShowDialogueAudio
		{
			get
			{
				base.FastCheckIsValid();
				FOnDialogueAudioEvent result;
				if ((result = this._OnShowDialogueAudio) == null)
				{
					result = (this._OnShowDialogueAudio = new FOnDialogueAudioEvent(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogueAudio, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_OnShowDialogueAudio, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17002017 RID: 8215
		// (get) Token: 0x0600AC34 RID: 44084 RVA: 0x000FE12A File Offset: 0x000FC32A
		// (set) Token: 0x0600AC35 RID: 44085 RVA: 0x000FE13E File Offset: 0x000FC33E
		[Nullable(2)]
		public unsafe UMovieSceneQteManager QteManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneQteManager>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_QteManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_QteManager, value);
			}
		}

		// Token: 0x17002018 RID: 8216
		// (get) Token: 0x0600AC36 RID: 44086 RVA: 0x000FE153 File Offset: 0x000FC353
		// (set) Token: 0x0600AC37 RID: 44087 RVA: 0x000FE167 File Offset: 0x000FC367
		[Nullable(2)]
		public unsafe AActor AutoTransformActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformActor, value);
			}
		}

		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x0600AC38 RID: 44088 RVA: 0x000FE17C File Offset: 0x000FC37C
		// (set) Token: 0x0600AC39 RID: 44089 RVA: 0x000FE190 File Offset: 0x000FC390
		[Nullable(2)]
		public unsafe UMovieScene3DTransformTrack AutoTransformDataTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene3DTransformTrack>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformDataTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformDataTrack, value);
			}
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x0600AC3A RID: 44090 RVA: 0x000FE1A8 File Offset: 0x000FC3A8
		// (set) Token: 0x0600AC3B RID: 44091 RVA: 0x000FE1E1 File Offset: 0x000FC3E1
		public TArray<UMovieScenePropertyTrack> AutoTransformPropertyTracks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMovieScenePropertyTrack> result;
				if ((result = this._AutoTransformPropertyTracks) == null)
				{
					result = (this._AutoTransformPropertyTracks = new TArray<UMovieScenePropertyTrack>(base.NativePtr + (IntPtr)UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformPropertyTracks, this));
				}
				return result;
			}
			set
			{
				this.AutoTransformPropertyTracks.CopyAssign(value);
			}
		}

		// Token: 0x0600AC3C RID: 44092 RVA: 0x000FE1F0 File Offset: 0x000FC3F0
		[SkipLocalsInit]
		public unsafe bool TryGetAutoTransformByOffsetTime(ref FTransform OutTrans, float OffsetTime, bool bApplyCameraProperties = false)
		{
			UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTrans = OutTrans;
			ptr->OffsetTime = OffsetTime;
			ptr->bApplyCameraProperties = bApplyCameraProperties;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_NativeFunctionPtr, (void*)ptr);
			OutTrans = ptr->OutTrans;
			return ptr->__Result;
		}

		// Token: 0x0600AC3D RID: 44093 RVA: 0x000FE25C File Offset: 0x000FC45C
		[SkipLocalsInit]
		public unsafe void ShowDialogueAudio(bool bShow, string AudioKey, int AudioTransitionDuration)
		{
			UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShow = bShow;
			FString.CopyFrom((void*)(&ptr->AudioKey), AudioKey);
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AC3E RID: 44094 RVA: 0x000FE2C8 File Offset: 0x000FC4C8
		[SkipLocalsInit]
		public unsafe void ShowDialogue(bool bShow, in FText DialogueID, int GuardTime, int AudioDelay, int AudioTransitionDuration, ELanguageAudio LanguageType, int AutoPlayDelay, [Nullable(2)] in TArray<int> UnisonIdList)
		{
			UMovieSceneDialogueSubsystem.__ShowDialogue_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__ShowDialogue_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__ShowDialogue_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__ShowDialogue_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShow = bShow;
			FText.NativeMove((void*)(&ptr->DialogueID), DialogueID.NativePtr);
			ptr->GuardTime = GuardTime;
			ptr->AudioDelay = AudioDelay;
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			ptr->LanguageType = LanguageType;
			ptr->AutoPlayDelay = AutoPlayDelay;
			TArray<int> tarray = UnisonIdList;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->UnisonIdList);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__ShowDialogue_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = UnisonIdList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->UnisonIdList);
			}
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSubsystem.__ShowDialogue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600AC3F RID: 44095 RVA: 0x000FE384 File Offset: 0x000FC584
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UMovieSceneQteManager GetQteManager()
		{
			UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__GetQteManager_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__GetQteManager_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneQteManager>(ptr->__Result);
		}

		// Token: 0x0600AC40 RID: 44096 RVA: 0x000FE3CE File Offset: 0x000FC5CE
		static UMovieSceneDialogueSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueSubsystem");
		}

		// Token: 0x0600AC41 RID: 44097 RVA: 0x000FE3DC File Offset: 0x000FC5DC
		protected UMovieSceneDialogueSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004A23 RID: 18979
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSubsystem";

		// Token: 0x04004A24 RID: 18980
		private static IntPtr _ClassPtr;

		// Token: 0x04004A25 RID: 18981
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004A26 RID: 18982
		internal static int __PropertyOffset_OnShowDialogue;

		// Token: 0x04004A27 RID: 18983
		[Nullable(2)]
		private FOnDialogueEvent _OnShowDialogue;

		// Token: 0x04004A28 RID: 18984
		internal static int __PropertyOffset_OnShowDialogueWithUnison;

		// Token: 0x04004A29 RID: 18985
		[Nullable(2)]
		private FOnDialogueWithUnisonEvent _OnShowDialogueWithUnison;

		// Token: 0x04004A2A RID: 18986
		internal static int __PropertyOffset_OnShowDialogueAudio;

		// Token: 0x04004A2B RID: 18987
		[Nullable(2)]
		private FOnDialogueAudioEvent _OnShowDialogueAudio;

		// Token: 0x04004A2C RID: 18988
		internal static int __PropertyOffset_QteManager;

		// Token: 0x04004A2D RID: 18989
		internal static int __PropertyOffset_AutoTransformActor;

		// Token: 0x04004A2E RID: 18990
		internal static int __PropertyOffset_AutoTransformDataTrack;

		// Token: 0x04004A2F RID: 18991
		internal static int __PropertyOffset_AutoTransformPropertyTracks;

		// Token: 0x04004A30 RID: 18992
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieScenePropertyTrack> _AutoTransformPropertyTracks;

		// Token: 0x04004A31 RID: 18993
		private static IntPtr __TryGetAutoTransformByOffsetTime_NativeFunctionPtr;

		// Token: 0x04004A32 RID: 18994
		private static IntPtr __ShowDialogueAudio_NativeFunctionPtr;

		// Token: 0x04004A33 RID: 18995
		private static IntPtr __ShowDialogue_NativeFunctionPtr;

		// Token: 0x04004A34 RID: 18996
		private static IntPtr __GetQteManager_NativeFunctionPtr;

		// Token: 0x02000F71 RID: 3953
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __TryGetAutoTransformByOffsetTime_FunctionParams
		{
			// Token: 0x0400634B RID: 25419
			[FieldOffset(0)]
			public FTransform OutTrans;

			// Token: 0x0400634C RID: 25420
			[FieldOffset(48)]
			public float OffsetTime;

			// Token: 0x0400634D RID: 25421
			[FieldOffset(52)]
			public bool bApplyCameraProperties;

			// Token: 0x0400634E RID: 25422
			[FieldOffset(53)]
			public bool __Result;
		}

		// Token: 0x02000F72 RID: 3954
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ShowDialogueAudio_FunctionParams
		{
			// Token: 0x0400634F RID: 25423
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006350 RID: 25424
			[FieldOffset(8)]
			public FString AudioKey;

			// Token: 0x04006351 RID: 25425
			[FieldOffset(24)]
			public int AudioTransitionDuration;
		}

		// Token: 0x02000F73 RID: 3955
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __ShowDialogue_FunctionParams
		{
			// Token: 0x04006352 RID: 25426
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04006353 RID: 25427
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x04006354 RID: 25428
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x04006355 RID: 25429
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x04006356 RID: 25430
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x04006357 RID: 25431
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x04006358 RID: 25432
			[FieldOffset(48)]
			public int AutoPlayDelay;

			// Token: 0x04006359 RID: 25433
			[FieldOffset(56)]
			public byte UnisonIdList;
		}

		// Token: 0x02000F74 RID: 3956
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetQteManager_FunctionParams
		{
			// Token: 0x0400635A RID: 25434
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
