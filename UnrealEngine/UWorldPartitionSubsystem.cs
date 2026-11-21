using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002B4 RID: 692
	[UnrealObjectPath("/Script/Engine.WorldPartitionSubsystem")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class UWorldPartitionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004ADF RID: 19167 RVA: 0x00068CD4 File Offset: 0x00066ED4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionSubsystem._ClassPtr;
		}

		// Token: 0x06004AE0 RID: 19168 RVA: 0x00068CE0 File Offset: 0x00066EE0
		public UWorldPartitionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004AE1 RID: 19169 RVA: 0x00068D08 File Offset: 0x00066F08
		[NullableContext(1)]
		public UWorldPartitionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06004AE2 RID: 19170 RVA: 0x00068D3C File Offset: 0x00066F3C
		[NullableContext(1)]
		public unsafe void SetStreamingEnable(bool StreamingEnable, string Reason = "")
		{
			FString fstring = FString.AllocTemp(Reason);
			UWorldPartitionSubsystem.__SetStreamingEnable_Internal(base.NativePtr, StreamingEnable, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06004AE3 RID: 19171 RVA: 0x00068D67 File Offset: 0x00066F67
		public void ReloadActorStreamingCells()
		{
			UWorldPartitionSubsystem.__ReloadActorStreamingCells_Internal(base.NativePtr);
		}

		// Token: 0x06004AE4 RID: 19172 RVA: 0x00068D74 File Offset: 0x00066F74
		[NullableContext(2)]
		public void MarkActorStreamingCellsDirty(UWorld InWorld, ref TArray<FName> ModifiedActors)
		{
			UWorldPartitionSubsystem.__MarkActorStreamingCellsDirty_Internal(base.NativePtr, (InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, (ModifiedActors ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06004AE5 RID: 19173 RVA: 0x00068DA1 File Offset: 0x00066FA1
		public bool IsStreamingEnable()
		{
			return UWorldPartitionSubsystem.__IsStreamingEnable_Internal(base.NativePtr);
		}

		// Token: 0x06004AE6 RID: 19174 RVA: 0x00068DAE File Offset: 0x00066FAE
		public bool IsStreamingCompletedWithPhysicsReady(EWorldPartitionRuntimeCellState QueryState, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources)
		{
			return UWorldPartitionSubsystem.__IsStreamingCompletedWithPhysicsReady_Internal(base.NativePtr, QueryState, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr);
		}

		// Token: 0x06004AE7 RID: 19175 RVA: 0x00068DCC File Offset: 0x00066FCC
		public unsafe bool IsStreamingCompleted(EWorldPartitionRuntimeCellState QueryState, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources, bool bReturnCellDetail, ref int CellNum, ref int MatchCellNum, bool bExactState, bool bEnableDataLayerTest = false)
		{
			fixed (int* ptr = &CellNum)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &MatchCellNum)
				{
					void* ptr4 = (void*)ptr3;
					return UWorldPartitionSubsystem.__IsStreamingCompleted_Internal(base.NativePtr, QueryState, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr, bReturnCellDetail, ref CellNum, ref MatchCellNum, bExactState, bEnableDataLayerTest);
				}
			}
		}

		// Token: 0x06004AE8 RID: 19176 RVA: 0x00068E0A File Offset: 0x0006700A
		public bool IsRenderAssetsStreamingCompletedForQuerySources([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery)
		{
			return UWorldPartitionSubsystem.__IsRenderAssetsStreamingCompletedForQuerySources_Internal(base.NativePtr, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr, bIgnoreQuerySource, bQueryMeshOnly, bForceStopQuery);
		}

		// Token: 0x06004AE9 RID: 19177 RVA: 0x00068E2B File Offset: 0x0006702B
		[NullableContext(2)]
		public bool IsRenderAssetsStreamingCompleted(in FWorldPartitionStreamingQuerySource QuerySource, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery)
		{
			return UWorldPartitionSubsystem.__IsRenderAssetsStreamingCompleted_Internal(base.NativePtr, (QuerySource ?? new FWorldPartitionStreamingQuerySource()).NativePtr, bIgnoreQuerySource, bQueryMeshOnly, bForceStopQuery);
		}

		// Token: 0x06004AEA RID: 19178 RVA: 0x00068E4C File Offset: 0x0006704C
		public bool IsAllStreamingCompleted(bool bWaitForLevelInstanceWP = true)
		{
			return UWorldPartitionSubsystem.__IsAllStreamingCompleted_Internal(base.NativePtr, bWaitForLevelInstanceWP);
		}

		// Token: 0x06004AEB RID: 19179 RVA: 0x00068E5A File Offset: 0x0006705A
		public void FlushUnloadingStreamingCells()
		{
			UWorldPartitionSubsystem.__FlushUnloadingStreamingCells_Internal(base.NativePtr);
		}

		// Token: 0x06004AEC RID: 19180 RVA: 0x00068E67 File Offset: 0x00067067
		public void D_AddOrRemoveRenderAssetsQueryViewInfo(in FVectorDouble ViewOrigin, float Duration = 0f, float BoostFactor = 1.2f)
		{
			UWorldPartitionSubsystem.__D_AddOrRemoveRenderAssetsQueryViewInfo_Internal(base.NativePtr, ViewOrigin, Duration, BoostFactor);
		}

		// Token: 0x06004AED RID: 19181 RVA: 0x00068E77 File Offset: 0x00067077
		public void AddOrRemoveRenderAssetsQueryViewInfo(in FVector ViewOrigin, float Duration = 0f, float BoostFactor = 1.2f)
		{
			UWorldPartitionSubsystem.__AddOrRemoveRenderAssetsQueryViewInfo_Internal(base.NativePtr, ViewOrigin, Duration, BoostFactor);
		}

		// Token: 0x06004AEE RID: 19182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStreamingEnable_Internal(IntPtr @this, bool StreamingEnable, in FString Reason);

		// Token: 0x06004AEF RID: 19183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReloadActorStreamingCells_Internal(IntPtr @this);

		// Token: 0x06004AF0 RID: 19184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkActorStreamingCellsDirty_Internal(IntPtr @this, IntPtr InWorld, IntPtr ModifiedActors);

		// Token: 0x06004AF1 RID: 19185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingEnable_Internal(IntPtr @this);

		// Token: 0x06004AF2 RID: 19186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompletedWithPhysicsReady_Internal(IntPtr @this, EWorldPartitionRuntimeCellState QueryState, IntPtr QuerySources);

		// Token: 0x06004AF3 RID: 19187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompleted_Internal(IntPtr @this, EWorldPartitionRuntimeCellState QueryState, IntPtr QuerySources, bool bReturnCellDetail, ref int CellNum, ref int MatchCellNum, bool bExactState, bool bEnableDataLayerTest);

		// Token: 0x06004AF4 RID: 19188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderAssetsStreamingCompletedForQuerySources_Internal(IntPtr @this, IntPtr QuerySources, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery);

		// Token: 0x06004AF5 RID: 19189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderAssetsStreamingCompleted_Internal(IntPtr @this, IntPtr QuerySource, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery);

		// Token: 0x06004AF6 RID: 19190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllStreamingCompleted_Internal(IntPtr @this, bool bWaitForLevelInstanceWP);

		// Token: 0x06004AF7 RID: 19191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushUnloadingStreamingCells_Internal(IntPtr @this);

		// Token: 0x06004AF8 RID: 19192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddOrRemoveRenderAssetsQueryViewInfo_Internal(IntPtr @this, in FVectorDouble ViewOrigin, float Duration, float BoostFactor);

		// Token: 0x06004AF9 RID: 19193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrRemoveRenderAssetsQueryViewInfo_Internal(IntPtr @this, in FVector ViewOrigin, float Duration, float BoostFactor);

		// Token: 0x06004AFA RID: 19194 RVA: 0x00068E87 File Offset: 0x00067087
		static UWorldPartitionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionSubsystem");
		}

		// Token: 0x06004AFB RID: 19195 RVA: 0x00068E95 File Offset: 0x00067095
		protected UWorldPartitionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001D90 RID: 7568
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionSubsystem";

		// Token: 0x04001D91 RID: 7569
		private static IntPtr _ClassPtr;

		// Token: 0x04001D92 RID: 7570
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
