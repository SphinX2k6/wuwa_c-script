using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004EA RID: 1258
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 328)]
	public class UKuroUiSceneSystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060076A7 RID: 30375 RVA: 0x000AD512 File Offset: 0x000AB712
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroUiSceneSystem._ClassPtr;
		}

		// Token: 0x060076A8 RID: 30376 RVA: 0x000AD520 File Offset: 0x000AB720
		public UKuroUiSceneSystem() : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060076A9 RID: 30377 RVA: 0x000AD548 File Offset: 0x000AB748
		public UKuroUiSceneSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroUiSceneSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x060076AA RID: 30378 RVA: 0x000AD57C File Offset: 0x000AB77C
		// (set) Token: 0x060076AB RID: 30379 RVA: 0x000AD5B5 File Offset: 0x000AB7B5
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

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x060076AC RID: 30380 RVA: 0x000AD5D8 File Offset: 0x000AB7D8
		// (set) Token: 0x060076AD RID: 30381 RVA: 0x000AD611 File Offset: 0x000AB811
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

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x060076AE RID: 30382 RVA: 0x000AD634 File Offset: 0x000AB834
		// (set) Token: 0x060076AF RID: 30383 RVA: 0x000AD66D File Offset: 0x000AB86D
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

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x060076B0 RID: 30384 RVA: 0x000AD690 File Offset: 0x000AB890
		// (set) Token: 0x060076B1 RID: 30385 RVA: 0x000AD6C9 File Offset: 0x000AB8C9
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

		// Token: 0x170016E6 RID: 5862
		// (get) Token: 0x060076B2 RID: 30386 RVA: 0x000AD6EC File Offset: 0x000AB8EC
		// (set) Token: 0x060076B3 RID: 30387 RVA: 0x000AD725 File Offset: 0x000AB925
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

		// Token: 0x170016E7 RID: 5863
		// (get) Token: 0x060076B4 RID: 30388 RVA: 0x000AD733 File Offset: 0x000AB933
		// (set) Token: 0x060076B5 RID: 30389 RVA: 0x000AD743 File Offset: 0x000AB943
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

		// Token: 0x170016E8 RID: 5864
		// (get) Token: 0x060076B6 RID: 30390 RVA: 0x000AD754 File Offset: 0x000AB954
		// (set) Token: 0x060076B7 RID: 30391 RVA: 0x000AD764 File Offset: 0x000AB964
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

		// Token: 0x170016E9 RID: 5865
		// (get) Token: 0x060076B8 RID: 30392 RVA: 0x000AD775 File Offset: 0x000AB975
		// (set) Token: 0x060076B9 RID: 30393 RVA: 0x000AD789 File Offset: 0x000AB989
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

		// Token: 0x060076BA RID: 30394 RVA: 0x000AD7A0 File Offset: 0x000AB9A0
		public unsafe bool UnloadUiScene(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			bool result = UKuroUiSceneSystem.__UnloadUiScene_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060076BB RID: 30395 RVA: 0x000AD7CA File Offset: 0x000AB9CA
		public bool StartUiSceneRendering()
		{
			return UKuroUiSceneSystem.__StartUiSceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x060076BC RID: 30396 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		public unsafe void PreloadUiScene(string ScenePath, FVector WorldPositionOffset)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__PreloadUiScene_Internal(base.NativePtr, fstring, WorldPositionOffset);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060076BD RID: 30397 RVA: 0x000AD804 File Offset: 0x000ABA04
		public unsafe void InvokeSceneVisible(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__InvokeSceneVisible_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060076BE RID: 30398 RVA: 0x000AD82E File Offset: 0x000ABA2E
		public FVector GetUiSceneWorldPositionOffset()
		{
			return UKuroUiSceneSystem.__GetUiSceneWorldPositionOffset_Internal(base.NativePtr);
		}

		// Token: 0x060076BF RID: 30399 RVA: 0x000AD83B File Offset: 0x000ABA3B
		public TMap<string, EKuroUiSceneLoadingState> GetUiSceneStates()
		{
			return new TMap<string, EKuroUiSceneLoadingState>(UKuroUiSceneSystem.__GetUiSceneStates_Internal(base.NativePtr), null);
		}

		// Token: 0x060076C0 RID: 30400 RVA: 0x000AD850 File Offset: 0x000ABA50
		public unsafe EKuroUiSceneLoadingState GetUiSceneLoadingState(string ScenePath)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			EKuroUiSceneLoadingState result = UKuroUiSceneSystem.__GetUiSceneLoadingState_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060076C1 RID: 30401 RVA: 0x000AD87A File Offset: 0x000ABA7A
		[NullableContext(2)]
		public static UKuroUiSceneSystem GetKuroUiSceneSystem(UWorld InWorld)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroUiSceneSystem>(UKuroUiSceneSystem.__GetKuroUiSceneSystem_Internal((InWorld != null) ? InWorld.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060076C2 RID: 30402 RVA: 0x000AD896 File Offset: 0x000ABA96
		public EKuroUiSceneLoadingState GetAllUiSceneLoadingState()
		{
			return UKuroUiSceneSystem.__GetAllUiSceneLoadingState_Internal(base.NativePtr);
		}

		// Token: 0x060076C3 RID: 30403 RVA: 0x000AD8A3 File Offset: 0x000ABAA3
		public bool EndUiSceneRendering()
		{
			return UKuroUiSceneSystem.__EndUiSceneRendering_Internal(base.NativePtr);
		}

		// Token: 0x060076C4 RID: 30404 RVA: 0x000AD8B0 File Offset: 0x000ABAB0
		public unsafe void D_PreloadUiScene(string ScenePath, FVectorDouble WorldPositionOffset)
		{
			FString fstring = FString.AllocTemp(ScenePath);
			UKuroUiSceneSystem.__D_PreloadUiScene_Internal(base.NativePtr, fstring, WorldPositionOffset);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060076C5 RID: 30405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __UnloadUiScene_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x060076C6 RID: 30406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __StartUiSceneRendering_Internal(IntPtr @this);

		// Token: 0x060076C7 RID: 30407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreloadUiScene_Internal(IntPtr @this, in FString ScenePath, FVector WorldPositionOffset);

		// Token: 0x060076C8 RID: 30408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvokeSceneVisible_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x060076C9 RID: 30409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUiSceneWorldPositionOffset_Internal(IntPtr @this);

		// Token: 0x060076CA RID: 30410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUiSceneStates_Internal(IntPtr @this);

		// Token: 0x060076CB RID: 30411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUiSceneLoadingState __GetUiSceneLoadingState_Internal(IntPtr @this, in FString ScenePath);

		// Token: 0x060076CC RID: 30412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKuroUiSceneSystem_Internal(IntPtr InWorld);

		// Token: 0x060076CD RID: 30413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroUiSceneLoadingState __GetAllUiSceneLoadingState_Internal(IntPtr @this);

		// Token: 0x060076CE RID: 30414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EndUiSceneRendering_Internal(IntPtr @this);

		// Token: 0x060076CF RID: 30415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_PreloadUiScene_Internal(IntPtr @this, in FString ScenePath, FVectorDouble WorldPositionOffset);

		// Token: 0x060076D0 RID: 30416 RVA: 0x000AD8DB File Offset: 0x000ABADB
		static UKuroUiSceneSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem");
		}

		// Token: 0x060076D1 RID: 30417 RVA: 0x000AD8E9 File Offset: 0x000ABAE9
		protected UKuroUiSceneSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003208 RID: 12808
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroUiSceneSystem";

		// Token: 0x04003209 RID: 12809
		private static IntPtr _ClassPtr;

		// Token: 0x0400320A RID: 12810
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400320B RID: 12811
		internal static int __PropertyOffset_OnKuroUiSceneLoadComplete;

		// Token: 0x0400320C RID: 12812
		[Nullable(2)]
		private FKuroUiSceneLoadCompleteDelegate _OnKuroUiSceneLoadComplete;

		// Token: 0x0400320D RID: 12813
		internal static int __PropertyOffset_OnKuroUiSceneUnLoadComplete;

		// Token: 0x0400320E RID: 12814
		[Nullable(2)]
		private FKuroUiSceneUnLoadCompleteDelegate _OnKuroUiSceneUnLoadComplete;

		// Token: 0x0400320F RID: 12815
		internal static int __PropertyOffset_OnKuroUiSceneVisibleComplete;

		// Token: 0x04003210 RID: 12816
		[Nullable(2)]
		private FKuroUiSceneVisibleCompleteDelegate _OnKuroUiSceneVisibleComplete;

		// Token: 0x04003211 RID: 12817
		internal static int __PropertyOffset_OnKuroUiSceneInVisibleComplete;

		// Token: 0x04003212 RID: 12818
		[Nullable(2)]
		private FKuroUiSceneInVisibleCompleteDelegate _OnKuroUiSceneInVisibleComplete;

		// Token: 0x04003213 RID: 12819
		internal static int __PropertyOffset_AllStreamingLevelInfo;

		// Token: 0x04003214 RID: 12820
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, UKuroUiSceneInfo> _AllStreamingLevelInfo;

		// Token: 0x04003215 RID: 12821
		internal static int __PropertyOffset_LevelLoadingCount;

		// Token: 0x04003216 RID: 12822
		internal static int __PropertyOffset_LastGlobalGiActorId;

		// Token: 0x04003217 RID: 12823
		internal static int __PropertyOffset_CurrentShowScenePath;
	}
}
