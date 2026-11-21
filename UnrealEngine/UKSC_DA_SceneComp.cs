using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200056F RID: 1391
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_SceneComp")]
	[UnrealStructLayout(224, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UKSC_DA_SceneComp : UKSC_DA_CompBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007E67 RID: 32359 RVA: 0x000BB57A File Offset: 0x000B977A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_SceneComp._ClassPtr;
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x000BB588 File Offset: 0x000B9788
		public UKSC_DA_SceneComp() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneComp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x000BB5B0 File Offset: 0x000B97B0
		[NullableContext(1)]
		public UKSC_DA_SceneComp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_SceneComp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700186F RID: 6255
		// (get) Token: 0x06007E6A RID: 32362 RVA: 0x000BB5E3 File Offset: 0x000B97E3
		// (set) Token: 0x06007E6B RID: 32363 RVA: 0x000BB5F3 File Offset: 0x000B97F3
		public unsafe float NeighborDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_NeighborDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_NeighborDist) = value;
			}
		}

		// Token: 0x17001870 RID: 6256
		// (get) Token: 0x06007E6C RID: 32364 RVA: 0x000BB604 File Offset: 0x000B9804
		// (set) Token: 0x06007E6D RID: 32365 RVA: 0x000BB614 File Offset: 0x000B9814
		public unsafe int MaxNeighborsNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_MaxNeighborsNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_MaxNeighborsNum) = value;
			}
		}

		// Token: 0x17001871 RID: 6257
		// (get) Token: 0x06007E6E RID: 32366 RVA: 0x000BB625 File Offset: 0x000B9825
		// (set) Token: 0x06007E6F RID: 32367 RVA: 0x000BB635 File Offset: 0x000B9835
		public unsafe float ColliderRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_ColliderRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_ColliderRadius) = value;
			}
		}

		// Token: 0x17001872 RID: 6258
		// (get) Token: 0x06007E70 RID: 32368 RVA: 0x000BB646 File Offset: 0x000B9846
		// (set) Token: 0x06007E71 RID: 32369 RVA: 0x000BB656 File Offset: 0x000B9856
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06007E72 RID: 32370 RVA: 0x000BB667 File Offset: 0x000B9867
		// (set) Token: 0x06007E73 RID: 32371 RVA: 0x000BB677 File Offset: 0x000B9877
		public unsafe bool bEnableCapsuleComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bEnableCapsuleComponent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bEnableCapsuleComponent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06007E74 RID: 32372 RVA: 0x000BB688 File Offset: 0x000B9888
		// (set) Token: 0x06007E75 RID: 32373 RVA: 0x000BB698 File Offset: 0x000B9898
		public unsafe bool bIgnoreUpdateOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bIgnoreUpdateOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_bIgnoreUpdateOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06007E76 RID: 32374 RVA: 0x000BB6A9 File Offset: 0x000B98A9
		// (set) Token: 0x06007E77 RID: 32375 RVA: 0x000BB6B9 File Offset: 0x000B98B9
		public unsafe bool OverrideNeighborCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_OverrideNeighborCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001876 RID: 6262
		// (get) Token: 0x06007E78 RID: 32376 RVA: 0x000BB6CA File Offset: 0x000B98CA
		// (set) Token: 0x06007E79 RID: 32377 RVA: 0x000BB6DA File Offset: 0x000B98DA
		public unsafe bool CheckWorldObstacles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_CheckWorldObstacles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_SceneComp.__PropertyOffset_CheckWorldObstacles) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x000BB6EB File Offset: 0x000B98EB
		static UKSC_DA_SceneComp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_SceneComp");
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x000BB6F9 File Offset: 0x000B98F9
		protected UKSC_DA_SceneComp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400372B RID: 14123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_SceneComp";

		// Token: 0x0400372C RID: 14124
		private static IntPtr _ClassPtr;

		// Token: 0x0400372D RID: 14125
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400372E RID: 14126
		internal static int __PropertyOffset_NeighborDist;

		// Token: 0x0400372F RID: 14127
		internal static int __PropertyOffset_MaxNeighborsNum;

		// Token: 0x04003730 RID: 14128
		internal static int __PropertyOffset_ColliderRadius;

		// Token: 0x04003731 RID: 14129
		internal static int __PropertyOffset_Mass;

		// Token: 0x04003732 RID: 14130
		internal static int __PropertyOffset_bEnableCapsuleComponent;

		// Token: 0x04003733 RID: 14131
		internal static int __PropertyOffset_bIgnoreUpdateOverlap;

		// Token: 0x04003734 RID: 14132
		internal static int __PropertyOffset_OverrideNeighborCenter;

		// Token: 0x04003735 RID: 14133
		internal static int __PropertyOffset_CheckWorldObstacles;
	}
}
