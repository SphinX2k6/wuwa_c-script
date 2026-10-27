using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200128A RID: 4746
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.WorldPartitionSubsystem")]
	[UnrealStructLayout(1152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1152)]
	public class UWorldPartitionSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601163A RID: 71226 RVA: 0x001986AA File Offset: 0x001968AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWorldPartitionSubsystem._ClassPtr;
		}

		// Token: 0x0601163B RID: 71227 RVA: 0x001986B8 File Offset: 0x001968B8
		public UWorldPartitionSubsystem() : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601163C RID: 71228 RVA: 0x001986E0 File Offset: 0x001968E0
		public UWorldPartitionSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWorldPartitionSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170043C0 RID: 17344
		// (get) Token: 0x0601163D RID: 71229 RVA: 0x00198714 File Offset: 0x00196914
		// (set) Token: 0x0601163E RID: 71230 RVA: 0x0019874D File Offset: 0x0019694D
		public TArray<UWorldPartition> RegisteredWorldPartitions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UWorldPartition> result;
				if ((result = this._RegisteredWorldPartitions) == null)
				{
					result = (this._RegisteredWorldPartitions = new TArray<UWorldPartition>(base.NativePtr + (IntPtr)UWorldPartitionSubsystem.__PropertyOffset_RegisteredWorldPartitions, this));
				}
				return result;
			}
			set
			{
				this.RegisteredWorldPartitions.CopyAssign(value);
			}
		}

		// Token: 0x0601163F RID: 71231 RVA: 0x0019875C File Offset: 0x0019695C
		public unsafe void SetStreamingEnable(bool StreamingEnable, string Reason = "")
		{
			FString fstring = FString.AllocTemp(Reason);
			UWorldPartitionSubsystem.__SetStreamingEnable_Internal(base.NativePtr, StreamingEnable, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06011640 RID: 71232 RVA: 0x00198787 File Offset: 0x00196987
		public void ReloadActorStreamingCells()
		{
			UWorldPartitionSubsystem.__ReloadActorStreamingCells_Internal(base.NativePtr);
		}

		// Token: 0x06011641 RID: 71233 RVA: 0x00198794 File Offset: 0x00196994
		[NullableContext(2)]
		public void MarkActorStreamingCellsDirty(UWorld InWorld, ref TArray<FName> ModifiedActors)
		{
			UWorldPartitionSubsystem.__MarkActorStreamingCellsDirty_Internal(base.NativePtr, (InWorld != null) ? InWorld.NativePtr : IntPtr.Zero, (ModifiedActors ?? new TArray<FName>()).NativePtr);
		}

		// Token: 0x06011642 RID: 71234 RVA: 0x001987C1 File Offset: 0x001969C1
		[NullableContext(2)]
		public bool KURO_IsStreamingCompleted(EWorldPartitionRuntimeCellState QueryState, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources, bool bExactState, ref FStreamingCompleteContext Params, bool bWaitForLevelInstanceWP = true)
		{
			return UWorldPartitionSubsystem.__KURO_IsStreamingCompleted_Internal(base.NativePtr, QueryState, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr, bExactState, (Params ?? new FStreamingCompleteContext()).NativePtr, bWaitForLevelInstanceWP);
		}

		// Token: 0x06011643 RID: 71235 RVA: 0x001987F3 File Offset: 0x001969F3
		public bool IsStreamingEnable()
		{
			return UWorldPartitionSubsystem.__IsStreamingEnable_Internal(base.NativePtr);
		}

		// Token: 0x06011644 RID: 71236 RVA: 0x00198800 File Offset: 0x00196A00
		public bool IsStreamingCompletedWithPhysicsReady(EWorldPartitionRuntimeCellState QueryState, [Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources)
		{
			return UWorldPartitionSubsystem.__IsStreamingCompletedWithPhysicsReady_Internal(base.NativePtr, QueryState, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr);
		}

		// Token: 0x06011645 RID: 71237 RVA: 0x00198820 File Offset: 0x00196A20
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

		// Token: 0x06011646 RID: 71238 RVA: 0x0019885E File Offset: 0x00196A5E
		public bool IsRenderAssetsStreamingCompletedForQuerySources([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FWorldPartitionStreamingQuerySource> QuerySources, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery)
		{
			return UWorldPartitionSubsystem.__IsRenderAssetsStreamingCompletedForQuerySources_Internal(base.NativePtr, (QuerySources ?? new TArray<FWorldPartitionStreamingQuerySource>()).NativePtr, bIgnoreQuerySource, bQueryMeshOnly, bForceStopQuery);
		}

		// Token: 0x06011647 RID: 71239 RVA: 0x0019887F File Offset: 0x00196A7F
		[NullableContext(2)]
		public bool IsRenderAssetsStreamingCompleted(in FWorldPartitionStreamingQuerySource QuerySource, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery)
		{
			return UWorldPartitionSubsystem.__IsRenderAssetsStreamingCompleted_Internal(base.NativePtr, (QuerySource ?? new FWorldPartitionStreamingQuerySource()).NativePtr, bIgnoreQuerySource, bQueryMeshOnly, bForceStopQuery);
		}

		// Token: 0x06011648 RID: 71240 RVA: 0x001988A0 File Offset: 0x00196AA0
		public bool IsAllStreamingCompleted(bool bWaitForLevelInstanceWP = true)
		{
			return UWorldPartitionSubsystem.__IsAllStreamingCompleted_Internal(base.NativePtr, bWaitForLevelInstanceWP);
		}

		// Token: 0x06011649 RID: 71241 RVA: 0x001988AE File Offset: 0x00196AAE
		public void FlushUnloadingStreamingCells()
		{
			UWorldPartitionSubsystem.__FlushUnloadingStreamingCells_Internal(base.NativePtr);
		}

		// Token: 0x0601164A RID: 71242 RVA: 0x001988BB File Offset: 0x00196ABB
		public void D_AddOrRemoveRenderAssetsQueryViewInfo(in FVectorDouble ViewOrigin, float Duration = 0f, float BoostFactor = 1.2f)
		{
			UWorldPartitionSubsystem.__D_AddOrRemoveRenderAssetsQueryViewInfo_Internal(base.NativePtr, ViewOrigin, Duration, BoostFactor);
		}

		// Token: 0x0601164B RID: 71243 RVA: 0x001988CB File Offset: 0x00196ACB
		public void AddOrRemoveRenderAssetsQueryViewInfo(in FVector ViewOrigin, float Duration = 0f, float BoostFactor = 1.2f)
		{
			UWorldPartitionSubsystem.__AddOrRemoveRenderAssetsQueryViewInfo_Internal(base.NativePtr, ViewOrigin, Duration, BoostFactor);
		}

		// Token: 0x0601164C RID: 71244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStreamingEnable_Internal(IntPtr @this, bool StreamingEnable, in FString Reason);

		// Token: 0x0601164D RID: 71245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReloadActorStreamingCells_Internal(IntPtr @this);

		// Token: 0x0601164E RID: 71246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkActorStreamingCellsDirty_Internal(IntPtr @this, IntPtr InWorld, IntPtr ModifiedActors);

		// Token: 0x0601164F RID: 71247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KURO_IsStreamingCompleted_Internal(IntPtr @this, EWorldPartitionRuntimeCellState QueryState, IntPtr QuerySources, bool bExactState, IntPtr Params, bool bWaitForLevelInstanceWP);

		// Token: 0x06011650 RID: 71248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingEnable_Internal(IntPtr @this);

		// Token: 0x06011651 RID: 71249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompletedWithPhysicsReady_Internal(IntPtr @this, EWorldPartitionRuntimeCellState QueryState, IntPtr QuerySources);

		// Token: 0x06011652 RID: 71250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStreamingCompleted_Internal(IntPtr @this, EWorldPartitionRuntimeCellState QueryState, IntPtr QuerySources, bool bReturnCellDetail, ref int CellNum, ref int MatchCellNum, bool bExactState, bool bEnableDataLayerTest);

		// Token: 0x06011653 RID: 71251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderAssetsStreamingCompletedForQuerySources_Internal(IntPtr @this, IntPtr QuerySources, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery);

		// Token: 0x06011654 RID: 71252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderAssetsStreamingCompleted_Internal(IntPtr @this, IntPtr QuerySource, bool bIgnoreQuerySource, bool bQueryMeshOnly, bool bForceStopQuery);

		// Token: 0x06011655 RID: 71253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllStreamingCompleted_Internal(IntPtr @this, bool bWaitForLevelInstanceWP);

		// Token: 0x06011656 RID: 71254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushUnloadingStreamingCells_Internal(IntPtr @this);

		// Token: 0x06011657 RID: 71255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_AddOrRemoveRenderAssetsQueryViewInfo_Internal(IntPtr @this, in FVectorDouble ViewOrigin, float Duration, float BoostFactor);

		// Token: 0x06011658 RID: 71256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOrRemoveRenderAssetsQueryViewInfo_Internal(IntPtr @this, in FVector ViewOrigin, float Duration, float BoostFactor);

		// Token: 0x06011659 RID: 71257 RVA: 0x001988DB File Offset: 0x00196ADB
		static UWorldPartitionSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.WorldPartitionSubsystem");
		}

		// Token: 0x0601165A RID: 71258 RVA: 0x001988E9 File Offset: 0x00196AE9
		protected UWorldPartitionSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040094E4 RID: 38116
		public new const string __ObjectPath = "/Script/Engine.WorldPartitionSubsystem";

		// Token: 0x040094E5 RID: 38117
		private static IntPtr _ClassPtr;

		// Token: 0x040094E6 RID: 38118
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040094E7 RID: 38119
		internal static int __PropertyOffset_RegisteredWorldPartitions;

		// Token: 0x040094E8 RID: 38120
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UWorldPartition> _RegisteredWorldPartitions;
	}
}
