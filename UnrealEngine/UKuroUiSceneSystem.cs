using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BD9 RID: 7129
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UKuroUiSceneSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B5C8 RID: 112072 RVA: 0x002850F2 File Offset: 0x002832F2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUiSceneSystem._ClassPtr;
		}

		// Token: 0x0601B5C9 RID: 112073 RVA: 0x00285100 File Offset: 0x00283300
		public UKuroUiSceneSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B5CA RID: 112074 RVA: 0x00285128 File Offset: 0x00283328
		public UKuroUiSceneSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006DF2 RID: 28146
		// (get) Token: 0x0601B5CB RID: 112075 RVA: 0x0028515C File Offset: 0x0028335C
		// (set) Token: 0x0601B5CC RID: 112076 RVA: 0x00285195 File Offset: 0x00283395
		public FKuroUiSceneLoadCompleteDelegate OnKuroUiSceneLoadComplete
		{
			get
			{
				base.FastCheckIsValid();
				FKuroUiSceneLoadCompleteDelegate result;
				if ((result = this._OnKuroUiSceneLoadComplete) == null)
				{
					result = (this._OnKuroUiSceneLoadComplete = new FKuroUiSceneLoadCompleteDelegate(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneLoadComplete, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneLoadComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006DF3 RID: 28147
		// (get) Token: 0x0601B5CD RID: 112077 RVA: 0x002851B8 File Offset: 0x002833B8
		// (set) Token: 0x0601B5CE RID: 112078 RVA: 0x002851F1 File Offset: 0x002833F1
		public FKuroUiSceneUnLoadCompleteDelegate OnKuroUiSceneUnLoadComplete
		{
			get
			{
				base.FastCheckIsValid();
				FKuroUiSceneUnLoadCompleteDelegate result;
				if ((result = this._OnKuroUiSceneUnLoadComplete) == null)
				{
					result = (this._OnKuroUiSceneUnLoadComplete = new FKuroUiSceneUnLoadCompleteDelegate(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneUnLoadComplete, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneUnLoadComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006DF4 RID: 28148
		// (get) Token: 0x0601B5CF RID: 112079 RVA: 0x00285214 File Offset: 0x00283414
		// (set) Token: 0x0601B5D0 RID: 112080 RVA: 0x0028524D File Offset: 0x0028344D
		public FKuroUiSceneVisibleCompleteDelegate OnKuroUiSceneVisibleComplete
		{
			get
			{
				base.FastCheckIsValid();
				FKuroUiSceneVisibleCompleteDelegate result;
				if ((result = this._OnKuroUiSceneVisibleComplete) == null)
				{
					result = (this._OnKuroUiSceneVisibleComplete = new FKuroUiSceneVisibleCompleteDelegate(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneVisibleComplete, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneVisibleComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006DF5 RID: 28149
		// (get) Token: 0x0601B5D1 RID: 112081 RVA: 0x00285270 File Offset: 0x00283470
		// (set) Token: 0x0601B5D2 RID: 112082 RVA: 0x002852A9 File Offset: 0x002834A9
		public FKuroUiSceneInVisibleCompleteDelegate OnKuroUiSceneInVisibleComplete
		{
			get
			{
				base.FastCheckIsValid();
				FKuroUiSceneInVisibleCompleteDelegate result;
				if ((result = this._OnKuroUiSceneInVisibleComplete) == null)
				{
					result = (this._OnKuroUiSceneInVisibleComplete = new FKuroUiSceneInVisibleCompleteDelegate(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneInVisibleComplete, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_OnKuroUiSceneInVisibleComplete, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006DF6 RID: 28150
		// (get) Token: 0x0601B5D3 RID: 112083 RVA: 0x002852CC File Offset: 0x002834CC
		// (set) Token: 0x0601B5D4 RID: 112084 RVA: 0x00285305 File Offset: 0x00283505
		public TMap<string, UKuroUiSceneInfo> AllStreamingLevelInfo
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, UKuroUiSceneInfo> result;
				if ((result = this._AllStreamingLevelInfo) == null)
				{
					result = (this._AllStreamingLevelInfo = new TMap<string, UKuroUiSceneInfo>(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_AllStreamingLevelInfo, this));
				}
				return result;
			}
			set
			{
				this.AllStreamingLevelInfo.CopyAssign(value);
			}
		}

		// Token: 0x17006DF7 RID: 28151
		// (get) Token: 0x0601B5D5 RID: 112085 RVA: 0x00285313 File Offset: 0x00283513
		// (set) Token: 0x0601B5D6 RID: 112086 RVA: 0x00285323 File Offset: 0x00283523
		public unsafe int LevelLoadingCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_LevelLoadingCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_LevelLoadingCount) = value;
			}
		}

		// Token: 0x17006DF8 RID: 28152
		// (get) Token: 0x0601B5D7 RID: 112087 RVA: 0x00285334 File Offset: 0x00283534
		// (set) Token: 0x0601B5D8 RID: 112088 RVA: 0x00285344 File Offset: 0x00283544
		public unsafe int LastGlobalGiActorId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_LastGlobalGiActorId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroUiSceneSystem.__PropertyOffset_LastGlobalGiActorId) = value;
			}
		}

		// Token: 0x17006DF9 RID: 28153
		// (get) Token: 0x0601B5D9 RID: 112089 RVA: 0x00285355 File Offset: 0x00283555
		// (set) Token: 0x0601B5DA RID: 112090 RVA: 0x00285369 File Offset: 0x00283569
		public unsafe string CurrentShowScenePath
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneSystem.__PropertyOffset_CurrentShowScenePath)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UKuroUiSceneSystem.__PropertyOffset_CurrentShowScenePath)), value);
			}
		}

		// Token: 0x0601B5DB RID: 112091 RVA: 0x00285380 File Offset: 0x00283580
		public unsafe bool UnloadUiScene(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			bool result = UKuroUiSceneSystem.__UnloadUiScene_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601B5DC RID: 112092 RVA: 0x002853AA File Offset: 0x002835AA
		public bool StartUiSceneRendering()
		{
			return UKuroUiSceneSystem.__StartUiSceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x0601B5DD RID: 112093 RVA: 0x002853B8 File Offset: 0x002835B8
		public unsafe void PreloadUiScene(string ScenePath, FVector WorldPositionOffset)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__PreloadUiScene_Internal(base.NativePtr, fstring, WorldPositionOffset);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B5DE RID: 112094 RVA: 0x002853E4 File Offset: 0x002835E4
		public unsafe void InvokeSceneVisible(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__InvokeSceneVisible_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B5DF RID: 112095 RVA: 0x0028540E File Offset: 0x0028360E
		public FVector GetUiSceneWorldPositionOffset()
		{
			return UKuroUiSceneSystem.__GetUiSceneWorldPositionOffset_Internal(base.NativePtr);
		}

		// Token: 0x0601B5E0 RID: 112096 RVA: 0x0028541B File Offset: 0x0028361B
		public TMap<string, EKuroUiSceneLoadingState> GetUiSceneStates()
		{
			return new TMap<string, EKuroUiSceneLoadingState>(UKuroUiSceneSystem.__GetUiSceneStates_Internal(base.NativePtr), null);
		}

		// Token: 0x0601B5E1 RID: 112097 RVA: 0x00285430 File Offset: 0x00283630
		[return: Nullable(2)]
		public unsafe AKuroUiSceneRootActor GetUiSceneRootActor(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			AKuroUiSceneRootActor orCreateUObjectByNativePointer = BuiltinUtils.GetOrCreateUObjectByNativePointer<AKuroUiSceneRootActor>(UKuroUiSceneSystem.__GetUiSceneRootActor_Internal(base.NativePtr, fstring));
			FString.NativeDestruct(&fstring, 1);
			return orCreateUObjectByNativePointer;
		}

		// Token: 0x0601B5E2 RID: 112098 RVA: 0x00285460 File Offset: 0x00283660
		public unsafe EKuroUiSceneLoadingState GetUiSceneLoadingState(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			EKuroUiSceneLoadingState result = UKuroUiSceneSystem.__GetUiSceneLoadingState_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0601B5E3 RID: 112099 RVA: 0x0028548A File Offset: 0x0028368A
		[NullableContext(2)]
		public static UKuroUiSceneSystem GetKuroUiSceneSystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroUiSceneSystem>(UKuroUiSceneSystem.__GetKuroUiSceneSystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601B5E4 RID: 112100 RVA: 0x002854A6 File Offset: 0x002836A6
		public EKuroUiSceneLoadingState GetAllUiSceneLoadingState()
		{
			return UKuroUiSceneSystem.__GetAllUiSceneLoadingState_Internal(base.NativePtr);
		}

		// Token: 0x0601B5E5 RID: 112101 RVA: 0x002854B3 File Offset: 0x002836B3
		public bool EndUiSceneRendering()
		{
			return UKuroUiSceneSystem.__EndUiSceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x0601B5E6 RID: 112102 RVA: 0x002854C0 File Offset: 0x002836C0
		public unsafe void D_PreloadUiScene(string ScenePath, FVectorDouble WorldPositionOffset)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__D_PreloadUiScene_Internal(base.NativePtr, fstring, WorldPositionOffset);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601B5E7 RID: 112103
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UnloadUiScene_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x0601B5E8 RID: 112104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StartUiSceneRendering_Internal(IntPtr @this);

		// Token: 0x0601B5E9 RID: 112105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreloadUiScene_Internal(IntPtr @this, in FString ScenePath, FVector WorldPositionOffset);

		// Token: 0x0601B5EA RID: 112106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvokeSceneVisible_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x0601B5EB RID: 112107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUiSceneWorldPositionOffset_Internal(IntPtr @this);

		// Token: 0x0601B5EC RID: 112108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUiSceneStates_Internal(IntPtr @this);

		// Token: 0x0601B5ED RID: 112109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUiSceneRootActor_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x0601B5EE RID: 112110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUiSceneLoadingState __GetUiSceneLoadingState_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x0601B5EF RID: 112111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroUiSceneSystem_Internal(IntPtr InWorld);

		// Token: 0x0601B5F0 RID: 112112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUiSceneLoadingState __GetAllUiSceneLoadingState_Internal(IntPtr @this);

		// Token: 0x0601B5F1 RID: 112113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EndUiSceneRendering_Internal(IntPtr @this);

		// Token: 0x0601B5F2 RID: 112114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_PreloadUiScene_Internal(IntPtr @this, in FString ScenePath, FVectorDouble WorldPositionOffset);

		// Token: 0x0601B5F3 RID: 112115 RVA: 0x002854EB File Offset: 0x002836EB
		static UKuroUiSceneSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem");
		}

		// Token: 0x0601B5F4 RID: 112116 RVA: 0x002854F9 File Offset: 0x002836F9
		protected UKuroUiSceneSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EBB6 RID: 60342
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem";

		// Token: 0x0400EBB7 RID: 60343
		private static IntPtr _ClassPtr;

		// Token: 0x0400EBB8 RID: 60344
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EBB9 RID: 60345
		internal static int __PropertyOffset_OnKuroUiSceneLoadComplete;

		// Token: 0x0400EBBA RID: 60346
		[Nullable(2)]
		private FKuroUiSceneLoadCompleteDelegate _OnKuroUiSceneLoadComplete;

		// Token: 0x0400EBBB RID: 60347
		internal static int __PropertyOffset_OnKuroUiSceneUnLoadComplete;

		// Token: 0x0400EBBC RID: 60348
		[Nullable(2)]
		private FKuroUiSceneUnLoadCompleteDelegate _OnKuroUiSceneUnLoadComplete;

		// Token: 0x0400EBBD RID: 60349
		internal static int __PropertyOffset_OnKuroUiSceneVisibleComplete;

		// Token: 0x0400EBBE RID: 60350
		[Nullable(2)]
		private FKuroUiSceneVisibleCompleteDelegate _OnKuroUiSceneVisibleComplete;

		// Token: 0x0400EBBF RID: 60351
		internal static int __PropertyOffset_OnKuroUiSceneInVisibleComplete;

		// Token: 0x0400EBC0 RID: 60352
		[Nullable(2)]
		private FKuroUiSceneInVisibleCompleteDelegate _OnKuroUiSceneInVisibleComplete;

		// Token: 0x0400EBC1 RID: 60353
		internal static int __PropertyOffset_AllStreamingLevelInfo;

		// Token: 0x0400EBC2 RID: 60354
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroUiSceneInfo> _AllStreamingLevelInfo;

		// Token: 0x0400EBC3 RID: 60355
		internal static int __PropertyOffset_LevelLoadingCount;

		// Token: 0x0400EBC4 RID: 60356
		internal static int __PropertyOffset_LastGlobalGiActorId;

		// Token: 0x0400EBC5 RID: 60357
		internal static int __PropertyOffset_CurrentShowScenePath;
	}
}
