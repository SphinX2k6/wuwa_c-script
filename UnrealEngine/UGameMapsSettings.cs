using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000799 RID: 1945
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/EngineSettings.GameMapsSettings")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UGameMapsSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006531 RID: 25905 RVA: 0x0009113E File Offset: 0x0008F33E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGameMapsSettings._ClassPtr;
		}

		// Token: 0x06006532 RID: 25906 RVA: 0x0009114C File Offset: 0x0008F34C
		public UGameMapsSettings() : this(BuiltinUtils.AllocNativeUObject(UGameMapsSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006533 RID: 25907 RVA: 0x00091174 File Offset: 0x0008F374
		public UGameMapsSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGameMapsSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001807 RID: 6151
		// (get) Token: 0x06006534 RID: 25908 RVA: 0x000911A7 File Offset: 0x0008F3A7
		// (set) Token: 0x06006535 RID: 25909 RVA: 0x000911BB File Offset: 0x0008F3BB
		public unsafe string LocalMapOptions
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_LocalMapOptions)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_LocalMapOptions)), value);
			}
		}

		// Token: 0x17001808 RID: 6152
		// (get) Token: 0x06006536 RID: 25910 RVA: 0x000911D0 File Offset: 0x0008F3D0
		// (set) Token: 0x06006537 RID: 25911 RVA: 0x00091209 File Offset: 0x0008F409
		public FSoftObjectPath TransitionMap
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._TransitionMap) == null)
				{
					result = (this._TransitionMap = new FSoftObjectPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_TransitionMap, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_TransitionMap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001809 RID: 6153
		// (get) Token: 0x06006538 RID: 25912 RVA: 0x0009122A File Offset: 0x0008F42A
		// (set) Token: 0x06006539 RID: 25913 RVA: 0x0009123A File Offset: 0x0008F43A
		public unsafe bool bUseSplitscreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_bUseSplitscreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_bUseSplitscreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700180A RID: 6154
		// (get) Token: 0x0600653A RID: 25914 RVA: 0x0009124B File Offset: 0x0008F44B
		// (set) Token: 0x0600653B RID: 25915 RVA: 0x0009125F File Offset: 0x0008F45F
		[Nullable(0)]
		public unsafe TEnumAsByte<ETwoPlayerSplitScreenType> TwoPlayerSplitscreenLayout
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_TwoPlayerSplitscreenLayout);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_TwoPlayerSplitscreenLayout) = value;
			}
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x0600653C RID: 25916 RVA: 0x00091274 File Offset: 0x0008F474
		// (set) Token: 0x0600653D RID: 25917 RVA: 0x00091288 File Offset: 0x0008F488
		[Nullable(0)]
		public unsafe TEnumAsByte<EThreePlayerSplitScreenType> ThreePlayerSplitscreenLayout
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_ThreePlayerSplitscreenLayout);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_ThreePlayerSplitscreenLayout) = value;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x0600653E RID: 25918 RVA: 0x0009129D File Offset: 0x0008F49D
		// (set) Token: 0x0600653F RID: 25919 RVA: 0x000912AD File Offset: 0x0008F4AD
		public unsafe EFourPlayerSplitScreenType FourPlayerSplitscreenLayout
		{
			get
			{
				return (EFourPlayerSplitScreenType)(*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_FourPlayerSplitscreenLayout));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_FourPlayerSplitscreenLayout) = (byte)value;
			}
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06006540 RID: 25920 RVA: 0x000912BE File Offset: 0x0008F4BE
		// (set) Token: 0x06006541 RID: 25921 RVA: 0x000912CE File Offset: 0x0008F4CE
		public unsafe bool bOffsetPlayerGamepadIds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_bOffsetPlayerGamepadIds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_bOffsetPlayerGamepadIds) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06006542 RID: 25922 RVA: 0x000912E0 File Offset: 0x0008F4E0
		// (set) Token: 0x06006543 RID: 25923 RVA: 0x00091319 File Offset: 0x0008F519
		public FSoftClassPath GameInstanceClass
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GameInstanceClass) == null)
				{
					result = (this._GameInstanceClass = new FSoftClassPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameInstanceClass, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameInstanceClass, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06006544 RID: 25924 RVA: 0x0009133A File Offset: 0x0008F53A
		// (set) Token: 0x06006545 RID: 25925 RVA: 0x0009134E File Offset: 0x0008F54E
		public unsafe string LevelActorRegularConfigPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_LevelActorRegularConfigPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_LevelActorRegularConfigPath)), value);
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06006546 RID: 25926 RVA: 0x00091363 File Offset: 0x0008F563
		// (set) Token: 0x06006547 RID: 25927 RVA: 0x00091377 File Offset: 0x0008F577
		public unsafe string PrefabLevelActorRegularConfigPath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_PrefabLevelActorRegularConfigPath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UGameMapsSettings.__PropertyOffset_PrefabLevelActorRegularConfigPath)), value);
			}
		}

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06006548 RID: 25928 RVA: 0x0009138C File Offset: 0x0008F58C
		// (set) Token: 0x06006549 RID: 25929 RVA: 0x000913C5 File Offset: 0x0008F5C5
		public FSoftObjectPath GameDefaultMap
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._GameDefaultMap) == null)
				{
					result = (this._GameDefaultMap = new FSoftObjectPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameDefaultMap, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameDefaultMap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x0600654A RID: 25930 RVA: 0x000913E8 File Offset: 0x0008F5E8
		// (set) Token: 0x0600654B RID: 25931 RVA: 0x00091421 File Offset: 0x0008F621
		public FSoftObjectPath ServerDefaultMap
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._ServerDefaultMap) == null)
				{
					result = (this._ServerDefaultMap = new FSoftObjectPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_ServerDefaultMap, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_ServerDefaultMap, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x0600654C RID: 25932 RVA: 0x00091444 File Offset: 0x0008F644
		// (set) Token: 0x0600654D RID: 25933 RVA: 0x0009147D File Offset: 0x0008F67D
		public FSoftClassPath GlobalDefaultGameMode
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GlobalDefaultGameMode) == null)
				{
					result = (this._GlobalDefaultGameMode = new FSoftClassPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GlobalDefaultGameMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GlobalDefaultGameMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x0600654E RID: 25934 RVA: 0x000914A0 File Offset: 0x0008F6A0
		// (set) Token: 0x0600654F RID: 25935 RVA: 0x000914D9 File Offset: 0x0008F6D9
		public FSoftClassPath GlobalDefaultServerGameMode
		{
			get
			{
				base.FastCheckIsValid();
				FSoftClassPath result;
				if ((result = this._GlobalDefaultServerGameMode) == null)
				{
					result = (this._GlobalDefaultServerGameMode = new FSoftClassPath(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GlobalDefaultServerGameMode, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftClassPath.StaticStruct(), base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GlobalDefaultServerGameMode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001815 RID: 6165
		// (get) Token: 0x06006550 RID: 25936 RVA: 0x000914FC File Offset: 0x0008F6FC
		// (set) Token: 0x06006551 RID: 25937 RVA: 0x00091535 File Offset: 0x0008F735
		public TArray<FGameModeName> GameModeMapPrefixes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameModeName> result;
				if ((result = this._GameModeMapPrefixes) == null)
				{
					result = (this._GameModeMapPrefixes = new TArray<FGameModeName>(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameModeMapPrefixes, this));
				}
				return result;
			}
			set
			{
				this.GameModeMapPrefixes.CopyAssign(value);
			}
		}

		// Token: 0x17001816 RID: 6166
		// (get) Token: 0x06006552 RID: 25938 RVA: 0x00091544 File Offset: 0x0008F744
		// (set) Token: 0x06006553 RID: 25939 RVA: 0x0009157D File Offset: 0x0008F77D
		public TArray<FGameModeName> GameModeClassAliases
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FGameModeName> result;
				if ((result = this._GameModeClassAliases) == null)
				{
					result = (this._GameModeClassAliases = new TArray<FGameModeName>(base.NativePtr + (IntPtr)UGameMapsSettings.__PropertyOffset_GameModeClassAliases, this));
				}
				return result;
			}
			set
			{
				this.GameModeClassAliases.CopyAssign(value);
			}
		}

		// Token: 0x06006554 RID: 25940 RVA: 0x0009158B File Offset: 0x0008F78B
		public void SetSkipAssigningGamepadToPlayer1(bool bSkipFirstPlayer = true)
		{
			UGameMapsSettings.__SetSkipAssigningGamepadToPlayer1_Internal(base.NativePtr, bSkipFirstPlayer);
		}

		// Token: 0x06006555 RID: 25941 RVA: 0x00091599 File Offset: 0x0008F799
		public bool GetSkipAssigningGamepadToPlayer1()
		{
			return UGameMapsSettings.__GetSkipAssigningGamepadToPlayer1_Internal(base.NativePtr);
		}

		// Token: 0x06006556 RID: 25942 RVA: 0x000915A6 File Offset: 0x0008F7A6
		[NullableContext(2)]
		public static UGameMapsSettings GetGameMapsSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameMapsSettings>(UGameMapsSettings.__GetGameMapsSettings_Internal());
		}

		// Token: 0x06006557 RID: 25943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkipAssigningGamepadToPlayer1_Internal(IntPtr @this, bool bSkipFirstPlayer);

		// Token: 0x06006558 RID: 25944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSkipAssigningGamepadToPlayer1_Internal(IntPtr @this);

		// Token: 0x06006559 RID: 25945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameMapsSettings_Internal();

		// Token: 0x0600655A RID: 25946 RVA: 0x000915B2 File Offset: 0x0008F7B2
		static UGameMapsSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/EngineSettings.GameMapsSettings");
		}

		// Token: 0x0600655B RID: 25947 RVA: 0x000915C0 File Offset: 0x0008F7C0
		protected UGameMapsSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003114 RID: 12564
		public new const string __ObjectPath = "/Script/EngineSettings.GameMapsSettings";

		// Token: 0x04003115 RID: 12565
		private static IntPtr _ClassPtr;

		// Token: 0x04003116 RID: 12566
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003117 RID: 12567
		internal static int __PropertyOffset_LocalMapOptions;

		// Token: 0x04003118 RID: 12568
		internal static int __PropertyOffset_TransitionMap;

		// Token: 0x04003119 RID: 12569
		[Nullable(2)]
		private FSoftObjectPath _TransitionMap;

		// Token: 0x0400311A RID: 12570
		internal static int __PropertyOffset_bUseSplitscreen;

		// Token: 0x0400311B RID: 12571
		internal static int __PropertyOffset_TwoPlayerSplitscreenLayout;

		// Token: 0x0400311C RID: 12572
		internal static int __PropertyOffset_ThreePlayerSplitscreenLayout;

		// Token: 0x0400311D RID: 12573
		internal static int __PropertyOffset_FourPlayerSplitscreenLayout;

		// Token: 0x0400311E RID: 12574
		internal static int __PropertyOffset_bOffsetPlayerGamepadIds;

		// Token: 0x0400311F RID: 12575
		internal static int __PropertyOffset_GameInstanceClass;

		// Token: 0x04003120 RID: 12576
		[Nullable(2)]
		private FSoftClassPath _GameInstanceClass;

		// Token: 0x04003121 RID: 12577
		internal static int __PropertyOffset_LevelActorRegularConfigPath;

		// Token: 0x04003122 RID: 12578
		internal static int __PropertyOffset_PrefabLevelActorRegularConfigPath;

		// Token: 0x04003123 RID: 12579
		internal static int __PropertyOffset_GameDefaultMap;

		// Token: 0x04003124 RID: 12580
		[Nullable(2)]
		private FSoftObjectPath _GameDefaultMap;

		// Token: 0x04003125 RID: 12581
		internal static int __PropertyOffset_ServerDefaultMap;

		// Token: 0x04003126 RID: 12582
		[Nullable(2)]
		private FSoftObjectPath _ServerDefaultMap;

		// Token: 0x04003127 RID: 12583
		internal static int __PropertyOffset_GlobalDefaultGameMode;

		// Token: 0x04003128 RID: 12584
		[Nullable(2)]
		private FSoftClassPath _GlobalDefaultGameMode;

		// Token: 0x04003129 RID: 12585
		internal static int __PropertyOffset_GlobalDefaultServerGameMode;

		// Token: 0x0400312A RID: 12586
		[Nullable(2)]
		private FSoftClassPath _GlobalDefaultServerGameMode;

		// Token: 0x0400312B RID: 12587
		internal static int __PropertyOffset_GameModeMapPrefixes;

		// Token: 0x0400312C RID: 12588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameModeName> _GameModeMapPrefixes;

		// Token: 0x0400312D RID: 12589
		internal static int __PropertyOffset_GameModeClassAliases;

		// Token: 0x0400312E RID: 12590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FGameModeName> _GameModeClassAliases;
	}
}
