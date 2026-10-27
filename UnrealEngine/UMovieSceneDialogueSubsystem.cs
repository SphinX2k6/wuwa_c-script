using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026EE RID: 9966
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SequenceDialogue.MovieSceneDialogueSubsystem")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UMovieSceneDialogueSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024F5C RID: 151388 RVA: 0x0036AA7A File Offset: 0x00368C7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneDialogueSubsystem._ClassPtr;
		}

		// Token: 0x06024F5D RID: 151389 RVA: 0x0036AA88 File Offset: 0x00368C88
		public UMovieSceneDialogueSubsystem() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024F5E RID: 151390 RVA: 0x0036AAB0 File Offset: 0x00368CB0
		public UMovieSceneDialogueSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneDialogueSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008EB4 RID: 36532
		// (get) Token: 0x06024F5F RID: 151391 RVA: 0x0036AAE4 File Offset: 0x00368CE4
		// (set) Token: 0x06024F60 RID: 151392 RVA: 0x0036AB1D File Offset: 0x00368D1D
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

		// Token: 0x17008EB5 RID: 36533
		// (get) Token: 0x06024F61 RID: 151393 RVA: 0x0036AB40 File Offset: 0x00368D40
		// (set) Token: 0x06024F62 RID: 151394 RVA: 0x0036AB79 File Offset: 0x00368D79
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

		// Token: 0x17008EB6 RID: 36534
		// (get) Token: 0x06024F63 RID: 151395 RVA: 0x0036AB9C File Offset: 0x00368D9C
		// (set) Token: 0x06024F64 RID: 151396 RVA: 0x0036ABD5 File Offset: 0x00368DD5
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

		// Token: 0x17008EB7 RID: 36535
		// (get) Token: 0x06024F65 RID: 151397 RVA: 0x0036ABF6 File Offset: 0x00368DF6
		// (set) Token: 0x06024F66 RID: 151398 RVA: 0x0036AC0A File Offset: 0x00368E0A
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

		// Token: 0x17008EB8 RID: 36536
		// (get) Token: 0x06024F67 RID: 151399 RVA: 0x0036AC1F File Offset: 0x00368E1F
		// (set) Token: 0x06024F68 RID: 151400 RVA: 0x0036AC33 File Offset: 0x00368E33
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

		// Token: 0x17008EB9 RID: 36537
		// (get) Token: 0x06024F69 RID: 151401 RVA: 0x0036AC48 File Offset: 0x00368E48
		// (set) Token: 0x06024F6A RID: 151402 RVA: 0x0036AC5C File Offset: 0x00368E5C
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

		// Token: 0x17008EBA RID: 36538
		// (get) Token: 0x06024F6B RID: 151403 RVA: 0x0036AC71 File Offset: 0x00368E71
		// (set) Token: 0x06024F6C RID: 151404 RVA: 0x0036AC85 File Offset: 0x00368E85
		[Nullable(2)]
		public unsafe UMovieScene3DAttachTrack AutoTransformAttachTrack
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieScene3DAttachTrack>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformAttachTrack);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneDialogueSubsystem.__PropertyOffset_AutoTransformAttachTrack, value);
			}
		}

		// Token: 0x17008EBB RID: 36539
		// (get) Token: 0x06024F6D RID: 151405 RVA: 0x0036AC9C File Offset: 0x00368E9C
		// (set) Token: 0x06024F6E RID: 151406 RVA: 0x0036ACD5 File Offset: 0x00368ED5
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

		// Token: 0x06024F6F RID: 151407 RVA: 0x0036ACE4 File Offset: 0x00368EE4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool TryGetAutoTransformByOffsetTime(ref FTransform OutTrans, float OffsetTime, bool bApplyCameraProperties = false)
		{
			UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_NativeFunctionPtr, (void*)ptr, 1);
			ptr->OutTrans = OutTrans;
			ptr->OffsetTime = OffsetTime;
			ptr->bApplyCameraProperties = bApplyCameraProperties;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__TryGetAutoTransformByOffsetTime_NativeFunctionPtr, (void*)ptr, 0);
			OutTrans = ptr->OutTrans;
			return ptr->__Result;
		}

		// Token: 0x06024F70 RID: 151408 RVA: 0x0036AD50 File Offset: 0x00368F50
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void ShowDialogueAudio(bool bShow, string AudioKey, int AudioTransitionDuration)
		{
			UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bShow = bShow;
			FString.CopyFrom((void*)(&ptr->AudioKey), AudioKey);
			ptr->AudioTransitionDuration = AudioTransitionDuration;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSubsystem.__ShowDialogueAudio_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024F71 RID: 151409 RVA: 0x0036ADBC File Offset: 0x00368FBC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__ShowDialogue_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = UnisonIdList;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->UnisonIdList);
			}
			UnrealReflectionUtils.DestroyStruct(UMovieSceneDialogueSubsystem.__ShowDialogue_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06024F72 RID: 151410 RVA: 0x0036AE78 File Offset: 0x00369078
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UMovieSceneQteManager GetQteManager()
		{
			UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams* ptr = stackalloc UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UMovieSceneDialogueSubsystem.__GetQteManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UMovieSceneDialogueSubsystem.__GetQteManager_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UMovieSceneDialogueSubsystem.__GetQteManager_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMovieSceneQteManager>(ptr->__Result);
		}

		// Token: 0x06024F73 RID: 151411 RVA: 0x0036AEC3 File Offset: 0x003690C3
		static UMovieSceneDialogueSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SequenceDialogue.MovieSceneDialogueSubsystem");
		}

		// Token: 0x06024F74 RID: 151412 RVA: 0x0036AED1 File Offset: 0x003690D1
		protected UMovieSceneDialogueSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013EA9 RID: 81577
		public new const string __ObjectPath = "/Script/SequenceDialogue.MovieSceneDialogueSubsystem";

		// Token: 0x04013EAA RID: 81578
		private static IntPtr _ClassPtr;

		// Token: 0x04013EAB RID: 81579
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013EAC RID: 81580
		internal static int __PropertyOffset_OnShowDialogue;

		// Token: 0x04013EAD RID: 81581
		[Nullable(2)]
		private FOnDialogueEvent _OnShowDialogue;

		// Token: 0x04013EAE RID: 81582
		internal static int __PropertyOffset_OnShowDialogueWithUnison;

		// Token: 0x04013EAF RID: 81583
		[Nullable(2)]
		private FOnDialogueWithUnisonEvent _OnShowDialogueWithUnison;

		// Token: 0x04013EB0 RID: 81584
		internal static int __PropertyOffset_OnShowDialogueAudio;

		// Token: 0x04013EB1 RID: 81585
		[Nullable(2)]
		private FOnDialogueAudioEvent _OnShowDialogueAudio;

		// Token: 0x04013EB2 RID: 81586
		internal static int __PropertyOffset_QteManager;

		// Token: 0x04013EB3 RID: 81587
		internal static int __PropertyOffset_AutoTransformActor;

		// Token: 0x04013EB4 RID: 81588
		internal static int __PropertyOffset_AutoTransformDataTrack;

		// Token: 0x04013EB5 RID: 81589
		internal static int __PropertyOffset_AutoTransformAttachTrack;

		// Token: 0x04013EB6 RID: 81590
		internal static int __PropertyOffset_AutoTransformPropertyTracks;

		// Token: 0x04013EB7 RID: 81591
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMovieScenePropertyTrack> _AutoTransformPropertyTracks;

		// Token: 0x04013EB8 RID: 81592
		private static IntPtr __TryGetAutoTransformByOffsetTime_NativeFunctionPtr;

		// Token: 0x04013EB9 RID: 81593
		private static IntPtr __ShowDialogueAudio_NativeFunctionPtr;

		// Token: 0x04013EBA RID: 81594
		private static IntPtr __ShowDialogue_NativeFunctionPtr;

		// Token: 0x04013EBB RID: 81595
		private static IntPtr __GetQteManager_NativeFunctionPtr;

		// Token: 0x02003696 RID: 13974
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __TryGetAutoTransformByOffsetTime_FunctionParams
		{
			// Token: 0x04017789 RID: 96137
			[FieldOffset(0)]
			public FTransform OutTrans;

			// Token: 0x0401778A RID: 96138
			[FieldOffset(48)]
			public float OffsetTime;

			// Token: 0x0401778B RID: 96139
			[FieldOffset(52)]
			public bool bApplyCameraProperties;

			// Token: 0x0401778C RID: 96140
			[FieldOffset(53)]
			public bool __Result;
		}

		// Token: 0x02003697 RID: 13975
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ShowDialogueAudio_FunctionParams
		{
			// Token: 0x0401778D RID: 96141
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x0401778E RID: 96142
			[FieldOffset(8)]
			public FString AudioKey;

			// Token: 0x0401778F RID: 96143
			[FieldOffset(24)]
			public int AudioTransitionDuration;
		}

		// Token: 0x02003698 RID: 13976
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __ShowDialogue_FunctionParams
		{
			// Token: 0x04017790 RID: 96144
			[FieldOffset(0)]
			public bool bShow;

			// Token: 0x04017791 RID: 96145
			[FieldOffset(8)]
			public byte DialogueID;

			// Token: 0x04017792 RID: 96146
			[FieldOffset(32)]
			public int GuardTime;

			// Token: 0x04017793 RID: 96147
			[FieldOffset(36)]
			public int AudioDelay;

			// Token: 0x04017794 RID: 96148
			[FieldOffset(40)]
			public int AudioTransitionDuration;

			// Token: 0x04017795 RID: 96149
			[FieldOffset(44)]
			public ELanguageAudio LanguageType;

			// Token: 0x04017796 RID: 96150
			[FieldOffset(48)]
			public int AutoPlayDelay;

			// Token: 0x04017797 RID: 96151
			[FieldOffset(56)]
			public byte UnisonIdList;
		}

		// Token: 0x02003699 RID: 13977
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetQteManager_FunctionParams
		{
			// Token: 0x04017798 RID: 96152
			[FieldOffset(0)]
			public IntPtr __Result;
		}
	}
}
