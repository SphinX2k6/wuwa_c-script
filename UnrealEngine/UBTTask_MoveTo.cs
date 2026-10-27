using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200015A RID: 346
	[UnrealObjectPath("/Script/AIModule.BTTask_MoveTo")]
	[UnrealStructLayout(208, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 208)]
	public class UBTTask_MoveTo : UBTTask_BlackboardBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060017B9 RID: 6073 RVA: 0x00022E2D File Offset: 0x0002102D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTTask_MoveTo._ClassPtr;
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x00022E3C File Offset: 0x0002103C
		public UBTTask_MoveTo() : this(BuiltinUtils.AllocNativeUObject(UBTTask_MoveTo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060017BB RID: 6075 RVA: 0x00022E64 File Offset: 0x00021064
		[NullableContext(1)]
		public UBTTask_MoveTo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTTask_MoveTo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000611 RID: 1553
		// (get) Token: 0x060017BC RID: 6076 RVA: 0x00022E97 File Offset: 0x00021097
		// (set) Token: 0x060017BD RID: 6077 RVA: 0x00022EA7 File Offset: 0x000210A7
		public unsafe float AcceptableRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_AcceptableRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_AcceptableRadius) = value;
			}
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x060017BE RID: 6078 RVA: 0x00022EB8 File Offset: 0x000210B8
		// (set) Token: 0x060017BF RID: 6079 RVA: 0x00022ECC File Offset: 0x000210CC
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavigationQueryFilter> FilterClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_FilterClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_FilterClass) = value;
			}
		}

		// Token: 0x17000613 RID: 1555
		// (get) Token: 0x060017C0 RID: 6080 RVA: 0x00022EE1 File Offset: 0x000210E1
		// (set) Token: 0x060017C1 RID: 6081 RVA: 0x00022EF1 File Offset: 0x000210F1
		public unsafe float ObservedBlackboardValueTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_ObservedBlackboardValueTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_ObservedBlackboardValueTolerance) = value;
			}
		}

		// Token: 0x17000614 RID: 1556
		// (get) Token: 0x060017C2 RID: 6082 RVA: 0x00022F02 File Offset: 0x00021102
		// (set) Token: 0x060017C3 RID: 6083 RVA: 0x00022F1B File Offset: 0x0002111B
		public unsafe bool bObserveBlackboardValue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bObserveBlackboardValue) & UBTTask_MoveTo.__PropertyMask_bObserveBlackboardValue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bObserveBlackboardValue) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bObserveBlackboardValue) & ~UBTTask_MoveTo.__PropertyMask_bObserveBlackboardValue) | (value ? UBTTask_MoveTo.__PropertyMask_bObserveBlackboardValue : 0));
			}
		}

		// Token: 0x17000615 RID: 1557
		// (get) Token: 0x060017C4 RID: 6084 RVA: 0x00022F4B File Offset: 0x0002114B
		// (set) Token: 0x060017C5 RID: 6085 RVA: 0x00022F64 File Offset: 0x00021164
		public unsafe bool bAllowStrafe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowStrafe) & UBTTask_MoveTo.__PropertyMask_bAllowStrafe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowStrafe) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowStrafe) & ~UBTTask_MoveTo.__PropertyMask_bAllowStrafe) | (value ? UBTTask_MoveTo.__PropertyMask_bAllowStrafe : 0));
			}
		}

		// Token: 0x17000616 RID: 1558
		// (get) Token: 0x060017C6 RID: 6086 RVA: 0x00022F94 File Offset: 0x00021194
		// (set) Token: 0x060017C7 RID: 6087 RVA: 0x00022FAD File Offset: 0x000211AD
		public unsafe bool bAllowPartialPath
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowPartialPath) & UBTTask_MoveTo.__PropertyMask_bAllowPartialPath) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowPartialPath) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bAllowPartialPath) & ~UBTTask_MoveTo.__PropertyMask_bAllowPartialPath) | (value ? UBTTask_MoveTo.__PropertyMask_bAllowPartialPath : 0));
			}
		}

		// Token: 0x17000617 RID: 1559
		// (get) Token: 0x060017C8 RID: 6088 RVA: 0x00022FDD File Offset: 0x000211DD
		// (set) Token: 0x060017C9 RID: 6089 RVA: 0x00022FF6 File Offset: 0x000211F6
		public unsafe bool bTrackMovingGoal
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bTrackMovingGoal) & UBTTask_MoveTo.__PropertyMask_bTrackMovingGoal) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bTrackMovingGoal) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bTrackMovingGoal) & ~UBTTask_MoveTo.__PropertyMask_bTrackMovingGoal) | (value ? UBTTask_MoveTo.__PropertyMask_bTrackMovingGoal : 0));
			}
		}

		// Token: 0x17000618 RID: 1560
		// (get) Token: 0x060017CA RID: 6090 RVA: 0x00023026 File Offset: 0x00021226
		// (set) Token: 0x060017CB RID: 6091 RVA: 0x0002303F File Offset: 0x0002123F
		public unsafe bool bProjectGoalLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bProjectGoalLocation) & UBTTask_MoveTo.__PropertyMask_bProjectGoalLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bProjectGoalLocation) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bProjectGoalLocation) & ~UBTTask_MoveTo.__PropertyMask_bProjectGoalLocation) | (value ? UBTTask_MoveTo.__PropertyMask_bProjectGoalLocation : 0));
			}
		}

		// Token: 0x17000619 RID: 1561
		// (get) Token: 0x060017CC RID: 6092 RVA: 0x0002306F File Offset: 0x0002126F
		// (set) Token: 0x060017CD RID: 6093 RVA: 0x00023088 File Offset: 0x00021288
		public unsafe bool bReachTestIncludesAgentRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesAgentRadius) & UBTTask_MoveTo.__PropertyMask_bReachTestIncludesAgentRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesAgentRadius) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesAgentRadius) & ~UBTTask_MoveTo.__PropertyMask_bReachTestIncludesAgentRadius) | (value ? UBTTask_MoveTo.__PropertyMask_bReachTestIncludesAgentRadius : 0));
			}
		}

		// Token: 0x1700061A RID: 1562
		// (get) Token: 0x060017CE RID: 6094 RVA: 0x000230B8 File Offset: 0x000212B8
		// (set) Token: 0x060017CF RID: 6095 RVA: 0x000230D1 File Offset: 0x000212D1
		public unsafe bool bReachTestIncludesGoalRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesGoalRadius) & UBTTask_MoveTo.__PropertyMask_bReachTestIncludesGoalRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesGoalRadius) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bReachTestIncludesGoalRadius) & ~UBTTask_MoveTo.__PropertyMask_bReachTestIncludesGoalRadius) | (value ? UBTTask_MoveTo.__PropertyMask_bReachTestIncludesGoalRadius : 0));
			}
		}

		// Token: 0x1700061B RID: 1563
		// (get) Token: 0x060017D0 RID: 6096 RVA: 0x00023101 File Offset: 0x00021301
		// (set) Token: 0x060017D1 RID: 6097 RVA: 0x0002311A File Offset: 0x0002131A
		public unsafe bool bStopOnOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlap) & UBTTask_MoveTo.__PropertyMask_bStopOnOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlap) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlap) & ~UBTTask_MoveTo.__PropertyMask_bStopOnOverlap) | (value ? UBTTask_MoveTo.__PropertyMask_bStopOnOverlap : 0));
			}
		}

		// Token: 0x1700061C RID: 1564
		// (get) Token: 0x060017D2 RID: 6098 RVA: 0x0002314A File Offset: 0x0002134A
		// (set) Token: 0x060017D3 RID: 6099 RVA: 0x00023163 File Offset: 0x00021363
		public unsafe bool bStopOnOverlapNeedsUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlapNeedsUpdate) & UBTTask_MoveTo.__PropertyMask_bStopOnOverlapNeedsUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlapNeedsUpdate) = ((*(base.NativePtr + (IntPtr)UBTTask_MoveTo.__PropertyOffset_bStopOnOverlapNeedsUpdate) & ~UBTTask_MoveTo.__PropertyMask_bStopOnOverlapNeedsUpdate) | (value ? UBTTask_MoveTo.__PropertyMask_bStopOnOverlapNeedsUpdate : 0));
			}
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x00023193 File Offset: 0x00021393
		static UBTTask_MoveTo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTTask_MoveTo");
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x000231A1 File Offset: 0x000213A1
		protected UBTTask_MoveTo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040005B5 RID: 1461
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTTask_MoveTo";

		// Token: 0x040005B6 RID: 1462
		private static IntPtr _ClassPtr;

		// Token: 0x040005B7 RID: 1463
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040005B8 RID: 1464
		internal static int __PropertyOffset_AcceptableRadius;

		// Token: 0x040005B9 RID: 1465
		internal static int __PropertyOffset_FilterClass;

		// Token: 0x040005BA RID: 1466
		internal static int __PropertyOffset_ObservedBlackboardValueTolerance;

		// Token: 0x040005BB RID: 1467
		internal static int __PropertyOffset_bObserveBlackboardValue;

		// Token: 0x040005BC RID: 1468
		internal static byte __PropertyMask_bObserveBlackboardValue;

		// Token: 0x040005BD RID: 1469
		internal static int __PropertyOffset_bAllowStrafe;

		// Token: 0x040005BE RID: 1470
		internal static byte __PropertyMask_bAllowStrafe;

		// Token: 0x040005BF RID: 1471
		internal static int __PropertyOffset_bAllowPartialPath;

		// Token: 0x040005C0 RID: 1472
		internal static byte __PropertyMask_bAllowPartialPath;

		// Token: 0x040005C1 RID: 1473
		internal static int __PropertyOffset_bTrackMovingGoal;

		// Token: 0x040005C2 RID: 1474
		internal static byte __PropertyMask_bTrackMovingGoal;

		// Token: 0x040005C3 RID: 1475
		internal static int __PropertyOffset_bProjectGoalLocation;

		// Token: 0x040005C4 RID: 1476
		internal static byte __PropertyMask_bProjectGoalLocation;

		// Token: 0x040005C5 RID: 1477
		internal static int __PropertyOffset_bReachTestIncludesAgentRadius;

		// Token: 0x040005C6 RID: 1478
		internal static byte __PropertyMask_bReachTestIncludesAgentRadius;

		// Token: 0x040005C7 RID: 1479
		internal static int __PropertyOffset_bReachTestIncludesGoalRadius;

		// Token: 0x040005C8 RID: 1480
		internal static byte __PropertyMask_bReachTestIncludesGoalRadius;

		// Token: 0x040005C9 RID: 1481
		internal static int __PropertyOffset_bStopOnOverlap;

		// Token: 0x040005CA RID: 1482
		internal static byte __PropertyMask_bStopOnOverlap;

		// Token: 0x040005CB RID: 1483
		internal static int __PropertyOffset_bStopOnOverlapNeedsUpdate;

		// Token: 0x040005CC RID: 1484
		internal static byte __PropertyMask_bStopOnOverlapNeedsUpdate;
	}
}
