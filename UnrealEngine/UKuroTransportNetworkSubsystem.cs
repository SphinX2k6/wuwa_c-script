using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000407 RID: 1031
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroTransportNetworkSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroTransportNetworkSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060064E4 RID: 25828 RVA: 0x0008FFD1 File Offset: 0x0008E1D1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTransportNetworkSubsystem._ClassPtr;
		}

		// Token: 0x060064E5 RID: 25829 RVA: 0x0008FFE0 File Offset: 0x0008E1E0
		public UKuroTransportNetworkSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060064E6 RID: 25830 RVA: 0x00090008 File Offset: 0x0008E208
		[NullableContext(1)]
		public UKuroTransportNetworkSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060064E7 RID: 25831 RVA: 0x0009003B File Offset: 0x0008E23B
		public void SetRoadwayEnable(TArray<int> RoadwayIds, bool bEnable)
		{
			UKuroTransportNetworkSubsystem.__SetRoadwayEnable_Internal(base.NativePtr, (RoadwayIds ?? new TArray<int>()).NativePtr, bEnable);
		}

		// Token: 0x060064E8 RID: 25832 RVA: 0x00090058 File Offset: 0x0008E258
		public void InitTransportNetwork()
		{
			UKuroTransportNetworkSubsystem.__InitTransportNetwork_Internal(base.NativePtr);
		}

		// Token: 0x060064E9 RID: 25833 RVA: 0x00090065 File Offset: 0x0008E265
		public bool GetRoadwaysAtSameIntersection(int InstersectionId, ref TArray<int> OutputRoads)
		{
			return UKuroTransportNetworkSubsystem.__GetRoadwaysAtSameIntersection_Internal(base.NativePtr, InstersectionId, (OutputRoads ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060064EA RID: 25834 RVA: 0x00090083 File Offset: 0x0008E283
		public UKuroRoadwayIntersection GetRoadWayIntersection(int RoadwayId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadwayIntersection>(UKuroTransportNetworkSubsystem.__GetRoadWayIntersection_Internal(base.NativePtr, RoadwayId));
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x00090096 File Offset: 0x0008E296
		public UKuroRoadway GetRoadWay(int RoadwayId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(UKuroTransportNetworkSubsystem.__GetRoadWay_Internal(base.NativePtr, RoadwayId));
		}

		// Token: 0x060064EC RID: 25836 RVA: 0x000900A9 File Offset: 0x0008E2A9
		public int GetIntersectionId(int RoadwayId)
		{
			return UKuroTransportNetworkSubsystem.__GetIntersectionId_Internal(base.NativePtr, RoadwayId);
		}

		// Token: 0x060064ED RID: 25837 RVA: 0x000900B7 File Offset: 0x0008E2B7
		public bool GetCrossingRoads(int RoadwayId, ref TArray<int> OutputCrossingRoads)
		{
			return UKuroTransportNetworkSubsystem.__GetCrossingRoads_Internal(base.NativePtr, RoadwayId, (OutputCrossingRoads ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x060064EE RID: 25838 RVA: 0x000900D5 File Offset: 0x0008E2D5
		public UAutopilotRoute GetAssembleAutopilotRoute(TArray<int> RoadwayIds, bool bClosedLoop = true, bool bDebugDraw = false, float DebugLifeTime = 60f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAutopilotRoute>(UKuroTransportNetworkSubsystem.__GetAssembleAutopilotRoute_Internal(base.NativePtr, (RoadwayIds ?? new TArray<int>()).NativePtr, bClosedLoop, bDebugDraw, DebugLifeTime));
		}

		// Token: 0x060064EF RID: 25839 RVA: 0x000900FC File Offset: 0x0008E2FC
		public unsafe UKuroRoadway D_GetNearestRoadwayAtWorldPosition(FVectorDouble WorldPosition, ref FVectorDouble OutputNearestPosition, ref float OutputNearestPointKey, ref float OutputDistance, bool bForAutopilot = true, int MaxSearExtent = 5000)
		{
			fixed (FVectorDouble* ptr = &OutputNearestPosition)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutputNearestPointKey)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutputDistance)
					{
						void* ptr6 = (void*)ptr5;
						return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(UKuroTransportNetworkSubsystem.__D_GetNearestRoadwayAtWorldPosition_Internal(base.NativePtr, WorldPosition, ref OutputNearestPosition, ref OutputNearestPointKey, ref OutputDistance, bForAutopilot, MaxSearExtent));
					}
				}
			}
		}

		// Token: 0x060064F0 RID: 25840 RVA: 0x00090138 File Offset: 0x0008E338
		public unsafe float D_FindPathForAutopilotRoute(FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UKuroRoadway> OutputPaths, bool bDebugDraw = false, float DebugLifeTime = 60f)
		{
			fixed (FVectorDouble* ptr = &RoadStartPoint)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVectorDouble* ptr3 = &RoadEndPoint)
				{
					void* ptr4 = (void*)ptr3;
					return UKuroTransportNetworkSubsystem.__D_FindPathForAutopilotRoute_Internal(base.NativePtr, Source, Destination, ref RoadStartPoint, ref RoadEndPoint, (OutputPaths ?? new TArray<UKuroRoadway>()).NativePtr, bDebugDraw, DebugLifeTime);
				}
			}
		}

		// Token: 0x060064F1 RID: 25841 RVA: 0x00090178 File Offset: 0x0008E378
		public unsafe void D_FindPath(FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UKuroRoadway> OutputPaths, bool bDebugDraw = false, float DebugLifeTime = 60f)
		{
			fixed (FVectorDouble* ptr = &RoadStartPoint)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVectorDouble* ptr3 = &RoadEndPoint)
				{
					void* ptr4 = (void*)ptr3;
					UKuroTransportNetworkSubsystem.__D_FindPath_Internal(base.NativePtr, Source, Destination, ref RoadStartPoint, ref RoadEndPoint, (OutputPaths ?? new TArray<UKuroRoadway>()).NativePtr, bDebugDraw, DebugLifeTime);
					ptr = null;
				}
			}
		}

		// Token: 0x060064F2 RID: 25842 RVA: 0x000901BB File Offset: 0x0008E3BB
		public void CleanUpTransportNetwork()
		{
			UKuroTransportNetworkSubsystem.__CleanUpTransportNetwork_Internal(base.NativePtr);
		}

		// Token: 0x060064F3 RID: 25843 RVA: 0x000901C8 File Offset: 0x0008E3C8
		public void AddRoadwayData(ref FRoadwayCreateParam Param)
		{
			UKuroTransportNetworkSubsystem.__AddRoadwayData_Internal(base.NativePtr, (Param ?? new FRoadwayCreateParam()).NativePtr);
		}

		// Token: 0x060064F4 RID: 25844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRoadwayEnable_Internal(IntPtr @this, IntPtr RoadwayIds, bool bEnable);

		// Token: 0x060064F5 RID: 25845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitTransportNetwork_Internal(IntPtr @this);

		// Token: 0x060064F6 RID: 25846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRoadwaysAtSameIntersection_Internal(IntPtr @this, int InstersectionId, IntPtr OutputRoads);

		// Token: 0x060064F7 RID: 25847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRoadWayIntersection_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x060064F8 RID: 25848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRoadWay_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x060064F9 RID: 25849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntersectionId_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x060064FA RID: 25850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCrossingRoads_Internal(IntPtr @this, int RoadwayId, IntPtr OutputCrossingRoads);

		// Token: 0x060064FB RID: 25851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAssembleAutopilotRoute_Internal(IntPtr @this, IntPtr RoadwayIds, bool bClosedLoop, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x060064FC RID: 25852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_GetNearestRoadwayAtWorldPosition_Internal(IntPtr @this, FVectorDouble WorldPosition, ref FVectorDouble OutputNearestPosition, ref float OutputNearestPointKey, ref float OutputDistance, bool bForAutopilot, int MaxSearExtent);

		// Token: 0x060064FD RID: 25853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindPathForAutopilotRoute_Internal(IntPtr @this, FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, IntPtr OutputPaths, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x060064FE RID: 25854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_FindPath_Internal(IntPtr @this, FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, IntPtr OutputPaths, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x060064FF RID: 25855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanUpTransportNetwork_Internal(IntPtr @this);

		// Token: 0x06006500 RID: 25856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRoadwayData_Internal(IntPtr @this, IntPtr Param);

		// Token: 0x06006501 RID: 25857 RVA: 0x000901E5 File Offset: 0x0008E3E5
		static UKuroTransportNetworkSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroTransportNetworkSubsystem");
		}

		// Token: 0x06006502 RID: 25858 RVA: 0x000901F3 File Offset: 0x0008E3F3
		protected UKuroTransportNetworkSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002A80 RID: 10880
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroTransportNetworkSubsystem";

		// Token: 0x04002A81 RID: 10881
		private static IntPtr _ClassPtr;

		// Token: 0x04002A82 RID: 10882
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
