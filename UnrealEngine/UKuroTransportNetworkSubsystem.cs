using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001919 RID: 6425
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroTransportNetworkSubsystem")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroTransportNetworkSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017D6B RID: 97643 RVA: 0x0022E9A2 File Offset: 0x0022CBA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTransportNetworkSubsystem._ClassPtr;
		}

		// Token: 0x06017D6C RID: 97644 RVA: 0x0022E9B0 File Offset: 0x0022CBB0
		public UKuroTransportNetworkSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017D6D RID: 97645 RVA: 0x0022E9D8 File Offset: 0x0022CBD8
		[NullableContext(1)]
		public UKuroTransportNetworkSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTransportNetworkSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005FD3 RID: 24531
		// (get) Token: 0x06017D6E RID: 97646 RVA: 0x0022EA0B File Offset: 0x0022CC0B
		// (set) Token: 0x06017D6F RID: 97647 RVA: 0x0022EA1F File Offset: 0x0022CC1F
		public unsafe ATransportNetwork TransportNetwork
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ATransportNetwork>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTransportNetworkSubsystem.__PropertyOffset_TransportNetwork);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroTransportNetworkSubsystem.__PropertyOffset_TransportNetwork, value);
			}
		}

		// Token: 0x06017D70 RID: 97648 RVA: 0x0022EA34 File Offset: 0x0022CC34
		public void SetRoadwayEnable(TArray<int> RoadwayIds, bool bEnable)
		{
			UKuroTransportNetworkSubsystem.__SetRoadwayEnable_Internal(base.NativePtr, (RoadwayIds ?? new TArray<int>()).NativePtr, bEnable);
		}

		// Token: 0x06017D71 RID: 97649 RVA: 0x0022EA51 File Offset: 0x0022CC51
		public void InitTransportNetwork()
		{
			UKuroTransportNetworkSubsystem.__InitTransportNetwork_Internal(base.NativePtr);
		}

		// Token: 0x06017D72 RID: 97650 RVA: 0x0022EA5E File Offset: 0x0022CC5E
		public bool GetRoadwaysAtSameIntersection(int InstersectionId, ref TArray<int> OutputRoads)
		{
			return UKuroTransportNetworkSubsystem.__GetRoadwaysAtSameIntersection_Internal(base.NativePtr, InstersectionId, (OutputRoads ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06017D73 RID: 97651 RVA: 0x0022EA7C File Offset: 0x0022CC7C
		public UKuroRoadwayIntersection GetRoadWayIntersection(int RoadwayId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadwayIntersection>(UKuroTransportNetworkSubsystem.__GetRoadWayIntersection_Internal(base.NativePtr, RoadwayId));
		}

		// Token: 0x06017D74 RID: 97652 RVA: 0x0022EA8F File Offset: 0x0022CC8F
		public UKuroRoadway GetRoadWay(int RoadwayId)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRoadway>(UKuroTransportNetworkSubsystem.__GetRoadWay_Internal(base.NativePtr, RoadwayId));
		}

		// Token: 0x06017D75 RID: 97653 RVA: 0x0022EAA2 File Offset: 0x0022CCA2
		public int GetIntersectionId(int RoadwayId)
		{
			return UKuroTransportNetworkSubsystem.__GetIntersectionId_Internal(base.NativePtr, RoadwayId);
		}

		// Token: 0x06017D76 RID: 97654 RVA: 0x0022EAB0 File Offset: 0x0022CCB0
		public bool GetCrossingRoads(int RoadwayId, ref TArray<int> OutputCrossingRoads)
		{
			return UKuroTransportNetworkSubsystem.__GetCrossingRoads_Internal(base.NativePtr, RoadwayId, (OutputCrossingRoads ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06017D77 RID: 97655 RVA: 0x0022EACE File Offset: 0x0022CCCE
		public UAutopilotRoute GetAssembleAutopilotRoute(TArray<int> RoadwayIds, bool bClosedLoop = true, bool bDebugDraw = false, float DebugLifeTime = 60f)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAutopilotRoute>(UKuroTransportNetworkSubsystem.__GetAssembleAutopilotRoute_Internal(base.NativePtr, (RoadwayIds ?? new TArray<int>()).NativePtr, bClosedLoop, bDebugDraw, DebugLifeTime));
		}

		// Token: 0x06017D78 RID: 97656 RVA: 0x0022EAF4 File Offset: 0x0022CCF4
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

		// Token: 0x06017D79 RID: 97657 RVA: 0x0022EB30 File Offset: 0x0022CD30
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

		// Token: 0x06017D7A RID: 97658 RVA: 0x0022EB70 File Offset: 0x0022CD70
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

		// Token: 0x06017D7B RID: 97659 RVA: 0x0022EBB3 File Offset: 0x0022CDB3
		public void CleanUpTransportNetwork()
		{
			UKuroTransportNetworkSubsystem.__CleanUpTransportNetwork_Internal(base.NativePtr);
		}

		// Token: 0x06017D7C RID: 97660 RVA: 0x0022EBC0 File Offset: 0x0022CDC0
		public void AddRoadwayData(ref FRoadwayCreateParam Param)
		{
			UKuroTransportNetworkSubsystem.__AddRoadwayData_Internal(base.NativePtr, (Param ?? new FRoadwayCreateParam()).NativePtr);
		}

		// Token: 0x06017D7D RID: 97661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRoadwayEnable_Internal(IntPtr @this, IntPtr RoadwayIds, bool bEnable);

		// Token: 0x06017D7E RID: 97662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitTransportNetwork_Internal(IntPtr @this);

		// Token: 0x06017D7F RID: 97663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRoadwaysAtSameIntersection_Internal(IntPtr @this, int InstersectionId, IntPtr OutputRoads);

		// Token: 0x06017D80 RID: 97664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRoadWayIntersection_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x06017D81 RID: 97665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRoadWay_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x06017D82 RID: 97666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIntersectionId_Internal(IntPtr @this, int RoadwayId);

		// Token: 0x06017D83 RID: 97667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCrossingRoads_Internal(IntPtr @this, int RoadwayId, IntPtr OutputCrossingRoads);

		// Token: 0x06017D84 RID: 97668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAssembleAutopilotRoute_Internal(IntPtr @this, IntPtr RoadwayIds, bool bClosedLoop, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x06017D85 RID: 97669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __D_GetNearestRoadwayAtWorldPosition_Internal(IntPtr @this, FVectorDouble WorldPosition, ref FVectorDouble OutputNearestPosition, ref float OutputNearestPointKey, ref float OutputDistance, bool bForAutopilot, int MaxSearExtent);

		// Token: 0x06017D86 RID: 97670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __D_FindPathForAutopilotRoute_Internal(IntPtr @this, FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, IntPtr OutputPaths, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x06017D87 RID: 97671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_FindPath_Internal(IntPtr @this, FVectorDouble Source, FVectorDouble Destination, ref FVectorDouble RoadStartPoint, ref FVectorDouble RoadEndPoint, IntPtr OutputPaths, bool bDebugDraw, float DebugLifeTime);

		// Token: 0x06017D88 RID: 97672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanUpTransportNetwork_Internal(IntPtr @this);

		// Token: 0x06017D89 RID: 97673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddRoadwayData_Internal(IntPtr @this, IntPtr Param);

		// Token: 0x06017D8A RID: 97674 RVA: 0x0022EBDD File Offset: 0x0022CDDD
		static UKuroTransportNetworkSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroTransportNetworkSubsystem");
		}

		// Token: 0x06017D8B RID: 97675 RVA: 0x0022EBEB File Offset: 0x0022CDEB
		protected UKuroTransportNetworkSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CEB9 RID: 52921
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroTransportNetworkSubsystem";

		// Token: 0x0400CEBA RID: 52922
		private static IntPtr _ClassPtr;

		// Token: 0x0400CEBB RID: 52923
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CEBC RID: 52924
		internal static int __PropertyOffset_TransportNetwork;
	}
}
