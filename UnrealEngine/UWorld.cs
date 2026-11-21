using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B0 RID: 688
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.World")]
	[UnrealStructLayout(2592, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2592)]
	public class UWorld : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004A66 RID: 19046 RVA: 0x000681F2 File Offset: 0x000663F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorld._ClassPtr;
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00068200 File Offset: 0x00066400
		public UWorld() : this(BuiltinUtils.AllocNativeUObject(UWorld.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00068228 File Offset: 0x00066428
		public UWorld(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorld.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06004A69 RID: 19049 RVA: 0x0006825B File Offset: 0x0006645B
		// (set) Token: 0x06004A6A RID: 19050 RVA: 0x0006826F File Offset: 0x0006646F
		[Nullable(2)]
		public unsafe ULevel PersistentLevel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLevel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_PersistentLevel, value);
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06004A6B RID: 19051 RVA: 0x00068284 File Offset: 0x00066484
		// (set) Token: 0x06004A6C RID: 19052 RVA: 0x000682BD File Offset: 0x000664BD
		public TArray<UObject> ExtraReferencedObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ExtraReferencedObjects) == null)
				{
					result = (this._ExtraReferencedObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ExtraReferencedObjects, this));
				}
				return result;
			}
			set
			{
				this.ExtraReferencedObjects.CopyAssign(value);
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x06004A6D RID: 19053 RVA: 0x000682CC File Offset: 0x000664CC
		// (set) Token: 0x06004A6E RID: 19054 RVA: 0x00068305 File Offset: 0x00066505
		public TArray<UObject> PerModuleDataObjects
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._PerModuleDataObjects) == null)
				{
					result = (this._PerModuleDataObjects = new TArray<UObject>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_PerModuleDataObjects, this));
				}
				return result;
			}
			set
			{
				this.PerModuleDataObjects.CopyAssign(value);
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x06004A6F RID: 19055 RVA: 0x00068314 File Offset: 0x00066514
		// (set) Token: 0x06004A70 RID: 19056 RVA: 0x0006834D File Offset: 0x0006654D
		public TArray<ULevelStreaming> StreamingLevels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelStreaming> result;
				if ((result = this._StreamingLevels) == null)
				{
					result = (this._StreamingLevels = new TArray<ULevelStreaming>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_StreamingLevels, this));
				}
				return result;
			}
			set
			{
				this.StreamingLevels.CopyAssign(value);
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x06004A71 RID: 19057 RVA: 0x0006835B File Offset: 0x0006655B
		// (set) Token: 0x06004A72 RID: 19058 RVA: 0x0006836F File Offset: 0x0006656F
		public unsafe string StreamingLevelsPrefix
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UWorld.__PropertyOffset_StreamingLevelsPrefix)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UWorld.__PropertyOffset_StreamingLevelsPrefix)), value);
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x06004A73 RID: 19059 RVA: 0x00068384 File Offset: 0x00066584
		// (set) Token: 0x06004A74 RID: 19060 RVA: 0x00068398 File Offset: 0x00066598
		[Nullable(2)]
		public unsafe ULevel CurrentLevelPendingVisibility
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingVisibility);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingVisibility, value);
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06004A75 RID: 19061 RVA: 0x000683AD File Offset: 0x000665AD
		// (set) Token: 0x06004A76 RID: 19062 RVA: 0x000683C1 File Offset: 0x000665C1
		[Nullable(2)]
		public unsafe ULevel CurrentLevelPendingInvisibility
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULevel>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingInvisibility);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_CurrentLevelPendingInvisibility, value);
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06004A77 RID: 19063 RVA: 0x000683D6 File Offset: 0x000665D6
		// (set) Token: 0x06004A78 RID: 19064 RVA: 0x000683EF File Offset: 0x000665EF
		public unsafe bool bAreConstraintsDirty
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) & UWorld.__PropertyMask_bAreConstraintsDirty) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) = ((*(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_bAreConstraintsDirty) & ~UWorld.__PropertyMask_bAreConstraintsDirty) | (value ? UWorld.__PropertyMask_bAreConstraintsDirty : 0));
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06004A79 RID: 19065 RVA: 0x0006841F File Offset: 0x0006661F
		// (set) Token: 0x06004A7A RID: 19066 RVA: 0x00068433 File Offset: 0x00066633
		[Nullable(2)]
		public unsafe UNavigationSystemBase NavigationSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_NavigationSystem, value);
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06004A7B RID: 19067 RVA: 0x00068448 File Offset: 0x00066648
		// (set) Token: 0x06004A7C RID: 19068 RVA: 0x0006845C File Offset: 0x0006665C
		[Nullable(2)]
		public unsafe UNavigationSystemBase StreamingDungeonNavSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_StreamingDungeonNavSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_StreamingDungeonNavSystem, value);
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06004A7D RID: 19069 RVA: 0x00068471 File Offset: 0x00066671
		// (set) Token: 0x06004A7E RID: 19070 RVA: 0x00068485 File Offset: 0x00066685
		[Nullable(2)]
		public unsafe URoadNetNavigationSystemBase RoadNetNavigationSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<URoadNetNavigationSystemBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_RoadNetNavigationSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_RoadNetNavigationSystem, value);
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06004A7F RID: 19071 RVA: 0x0006849A File Offset: 0x0006669A
		// (set) Token: 0x06004A80 RID: 19072 RVA: 0x000684AE File Offset: 0x000666AE
		[Nullable(2)]
		public unsafe AGameModeBase AuthorityGameMode
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AGameModeBase>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AuthorityGameMode);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_AuthorityGameMode, value);
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06004A81 RID: 19073 RVA: 0x000684C4 File Offset: 0x000666C4
		// (set) Token: 0x06004A82 RID: 19074 RVA: 0x000684FD File Offset: 0x000666FD
		public TArray<ULevel> Levels
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULevel> result;
				if ((result = this._Levels) == null)
				{
					result = (this._Levels = new TArray<ULevel>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_Levels, this));
				}
				return result;
			}
			set
			{
				this.Levels.CopyAssign(value);
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06004A83 RID: 19075 RVA: 0x0006850B File Offset: 0x0006670B
		// (set) Token: 0x06004A84 RID: 19076 RVA: 0x0006851F File Offset: 0x0006671F
		[Nullable(2)]
		public unsafe UGameInstance OwningGameInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UGameInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_OwningGameInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWorld.__PropertyOffset_OwningGameInstance, value);
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06004A85 RID: 19077 RVA: 0x00068534 File Offset: 0x00066734
		// (set) Token: 0x06004A86 RID: 19078 RVA: 0x0006856D File Offset: 0x0006676D
		public TSet<UActorComponent> ComponentsThatNeedPreEndOfFrameSync
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UActorComponent> result;
				if ((result = this._ComponentsThatNeedPreEndOfFrameSync) == null)
				{
					result = (this._ComponentsThatNeedPreEndOfFrameSync = new TSet<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedPreEndOfFrameSync, this));
				}
				return result;
			}
			set
			{
				this.ComponentsThatNeedPreEndOfFrameSync.CopyAssign(value);
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x06004A87 RID: 19079 RVA: 0x0006857C File Offset: 0x0006677C
		// (set) Token: 0x06004A88 RID: 19080 RVA: 0x000685B5 File Offset: 0x000667B5
		public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentsThatNeedEndOfFrameUpdate) == null)
				{
					result = (this._ComponentsThatNeedEndOfFrameUpdate = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedEndOfFrameUpdate, this));
				}
				return result;
			}
			set
			{
				this.ComponentsThatNeedEndOfFrameUpdate.CopyAssign(value);
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x06004A89 RID: 19081 RVA: 0x000685C4 File Offset: 0x000667C4
		// (set) Token: 0x06004A8A RID: 19082 RVA: 0x000685FD File Offset: 0x000667FD
		public TArray<UActorComponent> ComponentsThatNeedEndOfFrameUpdate_OnGameThread
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UActorComponent> result;
				if ((result = this._ComponentsThatNeedEndOfFrameUpdate_OnGameThread) == null)
				{
					result = (this._ComponentsThatNeedEndOfFrameUpdate_OnGameThread = new TArray<UActorComponent>(base.NativePtr + (IntPtr)UWorld.__PropertyOffset_ComponentsThatNeedEndOfFrameUpdate_OnGameThread, this));
				}
				return result;
			}
			set
			{
				this.ComponentsThatNeedEndOfFrameUpdate_OnGameThread.CopyAssign(value);
			}
		}

		// Token: 0x06004A8B RID: 19083 RVA: 0x0006860B File Offset: 0x0006680B
		public void SetSeamlessTravelMidpointPause(bool bNowPaused)
		{
			UWorld.__SetSeamlessTravelMidpointPause_Internal(base.NativePtr, bNowPaused);
		}

		// Token: 0x06004A8C RID: 19084 RVA: 0x00068619 File Offset: 0x00066819
		public void ResetAllTimeSeconds(float Seconds)
		{
			UWorld.__ResetAllTimeSeconds_Internal(base.NativePtr, Seconds);
		}

		// Token: 0x06004A8D RID: 19085 RVA: 0x00068627 File Offset: 0x00066827
		[NullableContext(2)]
		public AWorldSettings K2_GetWorldSettings()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AWorldSettings>(UWorld.__K2_GetWorldSettings_Internal(base.NativePtr));
		}

		// Token: 0x06004A8E RID: 19086 RVA: 0x00068639 File Offset: 0x00066839
		public void HandleTimelineScrubbed()
		{
			UWorld.__HandleTimelineScrubbed_Internal(base.NativePtr);
		}

		// Token: 0x06004A8F RID: 19087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSeamlessTravelMidpointPause_Internal(IntPtr @this, bool bNowPaused);

		// Token: 0x06004A90 RID: 19088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetAllTimeSeconds_Internal(IntPtr @this, float Seconds);

		// Token: 0x06004A91 RID: 19089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __K2_GetWorldSettings_Internal(IntPtr @this);

		// Token: 0x06004A92 RID: 19090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HandleTimelineScrubbed_Internal(IntPtr @this);

		// Token: 0x06004A93 RID: 19091 RVA: 0x00068646 File Offset: 0x00066846
		static UWorld()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.World");
		}

		// Token: 0x06004A94 RID: 19092 RVA: 0x00068654 File Offset: 0x00066854
		protected UWorld(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D52 RID: 7506
		public new const string __ObjectPath = "/Script/Engine.World";

		// Token: 0x04001D53 RID: 7507
		private static IntPtr _ClassPtr;

		// Token: 0x04001D54 RID: 7508
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001D55 RID: 7509
		internal static int __PropertyOffset_PersistentLevel;

		// Token: 0x04001D56 RID: 7510
		internal static int __PropertyOffset_ExtraReferencedObjects;

		// Token: 0x04001D57 RID: 7511
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ExtraReferencedObjects;

		// Token: 0x04001D58 RID: 7512
		internal static int __PropertyOffset_PerModuleDataObjects;

		// Token: 0x04001D59 RID: 7513
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _PerModuleDataObjects;

		// Token: 0x04001D5A RID: 7514
		internal static int __PropertyOffset_StreamingLevels;

		// Token: 0x04001D5B RID: 7515
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelStreaming> _StreamingLevels;

		// Token: 0x04001D5C RID: 7516
		internal static int __PropertyOffset_StreamingLevelsPrefix;

		// Token: 0x04001D5D RID: 7517
		internal static int __PropertyOffset_CurrentLevelPendingVisibility;

		// Token: 0x04001D5E RID: 7518
		internal static int __PropertyOffset_CurrentLevelPendingInvisibility;

		// Token: 0x04001D5F RID: 7519
		internal static int __PropertyOffset_bAreConstraintsDirty;

		// Token: 0x04001D60 RID: 7520
		internal static byte __PropertyMask_bAreConstraintsDirty;

		// Token: 0x04001D61 RID: 7521
		internal static int __PropertyOffset_NavigationSystem;

		// Token: 0x04001D62 RID: 7522
		internal static int __PropertyOffset_StreamingDungeonNavSystem;

		// Token: 0x04001D63 RID: 7523
		internal static int __PropertyOffset_RoadNetNavigationSystem;

		// Token: 0x04001D64 RID: 7524
		internal static int __PropertyOffset_AuthorityGameMode;

		// Token: 0x04001D65 RID: 7525
		internal static int __PropertyOffset_Levels;

		// Token: 0x04001D66 RID: 7526
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevel> _Levels;

		// Token: 0x04001D67 RID: 7527
		internal static int __PropertyOffset_OwningGameInstance;

		// Token: 0x04001D68 RID: 7528
		internal static int __PropertyOffset_ComponentsThatNeedPreEndOfFrameSync;

		// Token: 0x04001D69 RID: 7529
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UActorComponent> _ComponentsThatNeedPreEndOfFrameSync;

		// Token: 0x04001D6A RID: 7530
		internal static int __PropertyOffset_ComponentsThatNeedEndOfFrameUpdate;

		// Token: 0x04001D6B RID: 7531
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentsThatNeedEndOfFrameUpdate;

		// Token: 0x04001D6C RID: 7532
		internal static int __PropertyOffset_ComponentsThatNeedEndOfFrameUpdate_OnGameThread;

		// Token: 0x04001D6D RID: 7533
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UActorComponent> _ComponentsThatNeedEndOfFrameUpdate_OnGameThread;
	}
}
