using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200016A RID: 362
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.CrowdManager")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UCrowdManager : UCrowdManagerBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001871 RID: 6257 RVA: 0x00023FB9 File Offset: 0x000221B9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrowdManager._ClassPtr;
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00023FC8 File Offset: 0x000221C8
		public UCrowdManager() : this(BuiltinUtils.AllocNativeUObject(UCrowdManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001873 RID: 6259 RVA: 0x00023FF0 File Offset: 0x000221F0
		public UCrowdManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCrowdManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001874 RID: 6260 RVA: 0x00024023 File Offset: 0x00022223
		// (set) Token: 0x06001875 RID: 6261 RVA: 0x00024037 File Offset: 0x00022237
		[Nullable(2)]
		public unsafe ANavigationData MyNavData
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ANavigationData>(base.NativePtr / (IntPtr)sizeof(void*) + UCrowdManager.__PropertyOffset_MyNavData);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCrowdManager.__PropertyOffset_MyNavData, value);
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001876 RID: 6262 RVA: 0x0002404C File Offset: 0x0002224C
		// (set) Token: 0x06001877 RID: 6263 RVA: 0x00024085 File Offset: 0x00022285
		public TArray<FCrowdAvoidanceConfig> AvoidanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCrowdAvoidanceConfig> result;
				if ((result = this._AvoidanceConfig) == null)
				{
					result = (this._AvoidanceConfig = new TArray<FCrowdAvoidanceConfig>(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_AvoidanceConfig, this));
				}
				return result;
			}
			set
			{
				this.AvoidanceConfig.CopyAssign(value);
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x00024094 File Offset: 0x00022294
		// (set) Token: 0x06001879 RID: 6265 RVA: 0x000240CD File Offset: 0x000222CD
		public TArray<FCrowdAvoidanceSamplingPattern> SamplingPatterns
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FCrowdAvoidanceSamplingPattern> result;
				if ((result = this._SamplingPatterns) == null)
				{
					result = (this._SamplingPatterns = new TArray<FCrowdAvoidanceSamplingPattern>(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_SamplingPatterns, this));
				}
				return result;
			}
			set
			{
				this.SamplingPatterns.CopyAssign(value);
			}
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x0600187A RID: 6266 RVA: 0x000240DB File Offset: 0x000222DB
		// (set) Token: 0x0600187B RID: 6267 RVA: 0x000240EB File Offset: 0x000222EB
		public unsafe int MaxAgents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAgents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAgents) = value;
			}
		}

		// Token: 0x17000647 RID: 1607
		// (get) Token: 0x0600187C RID: 6268 RVA: 0x000240FC File Offset: 0x000222FC
		// (set) Token: 0x0600187D RID: 6269 RVA: 0x0002410C File Offset: 0x0002230C
		public unsafe float MaxAgentRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAgentRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAgentRadius) = value;
			}
		}

		// Token: 0x17000648 RID: 1608
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0002411D File Offset: 0x0002231D
		// (set) Token: 0x0600187F RID: 6271 RVA: 0x0002412D File Offset: 0x0002232D
		public unsafe int MaxAvoidedAgents
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAvoidedAgents);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAvoidedAgents) = value;
			}
		}

		// Token: 0x17000649 RID: 1609
		// (get) Token: 0x06001880 RID: 6272 RVA: 0x0002413E File Offset: 0x0002233E
		// (set) Token: 0x06001881 RID: 6273 RVA: 0x0002414E File Offset: 0x0002234E
		public unsafe int MaxAvoidedWalls
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAvoidedWalls);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_MaxAvoidedWalls) = value;
			}
		}

		// Token: 0x1700064A RID: 1610
		// (get) Token: 0x06001882 RID: 6274 RVA: 0x0002415F File Offset: 0x0002235F
		// (set) Token: 0x06001883 RID: 6275 RVA: 0x0002416F File Offset: 0x0002236F
		public unsafe float NavmeshCheckInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_NavmeshCheckInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_NavmeshCheckInterval) = value;
			}
		}

		// Token: 0x1700064B RID: 1611
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x00024180 File Offset: 0x00022380
		// (set) Token: 0x06001885 RID: 6277 RVA: 0x00024190 File Offset: 0x00022390
		public unsafe float PathOptimizationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_PathOptimizationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_PathOptimizationInterval) = value;
			}
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x000241A1 File Offset: 0x000223A1
		// (set) Token: 0x06001887 RID: 6279 RVA: 0x000241B1 File Offset: 0x000223B1
		public unsafe float SeparationDirClamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_SeparationDirClamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_SeparationDirClamp) = value;
			}
		}

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001888 RID: 6280 RVA: 0x000241C2 File Offset: 0x000223C2
		// (set) Token: 0x06001889 RID: 6281 RVA: 0x000241D2 File Offset: 0x000223D2
		public unsafe float PathOffsetRadiusMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_PathOffsetRadiusMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_PathOffsetRadiusMultiplier) = value;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x0600188A RID: 6282 RVA: 0x000241E3 File Offset: 0x000223E3
		// (set) Token: 0x0600188B RID: 6283 RVA: 0x000241FC File Offset: 0x000223FC
		public unsafe bool bResolveCollisions
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_bResolveCollisions) & UCrowdManager.__PropertyMask_bResolveCollisions) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_bResolveCollisions) = ((*(base.NativePtr + (IntPtr)UCrowdManager.__PropertyOffset_bResolveCollisions) & ~UCrowdManager.__PropertyMask_bResolveCollisions) | (value ? UCrowdManager.__PropertyMask_bResolveCollisions : 0));
			}
		}

		// Token: 0x0600188C RID: 6284 RVA: 0x0002422C File Offset: 0x0002242C
		static UCrowdManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.CrowdManager");
		}

		// Token: 0x0600188D RID: 6285 RVA: 0x0002423A File Offset: 0x0002243A
		protected UCrowdManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000626 RID: 1574
		public new const string __ObjectPath = "/Script/AIModule.CrowdManager";

		// Token: 0x04000627 RID: 1575
		private static IntPtr _ClassPtr;

		// Token: 0x04000628 RID: 1576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000629 RID: 1577
		internal static int __PropertyOffset_MyNavData;

		// Token: 0x0400062A RID: 1578
		internal static int __PropertyOffset_AvoidanceConfig;

		// Token: 0x0400062B RID: 1579
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCrowdAvoidanceConfig> _AvoidanceConfig;

		// Token: 0x0400062C RID: 1580
		internal static int __PropertyOffset_SamplingPatterns;

		// Token: 0x0400062D RID: 1581
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCrowdAvoidanceSamplingPattern> _SamplingPatterns;

		// Token: 0x0400062E RID: 1582
		internal static int __PropertyOffset_MaxAgents;

		// Token: 0x0400062F RID: 1583
		internal static int __PropertyOffset_MaxAgentRadius;

		// Token: 0x04000630 RID: 1584
		internal static int __PropertyOffset_MaxAvoidedAgents;

		// Token: 0x04000631 RID: 1585
		internal static int __PropertyOffset_MaxAvoidedWalls;

		// Token: 0x04000632 RID: 1586
		internal static int __PropertyOffset_NavmeshCheckInterval;

		// Token: 0x04000633 RID: 1587
		internal static int __PropertyOffset_PathOptimizationInterval;

		// Token: 0x04000634 RID: 1588
		internal static int __PropertyOffset_SeparationDirClamp;

		// Token: 0x04000635 RID: 1589
		internal static int __PropertyOffset_PathOffsetRadiusMultiplier;

		// Token: 0x04000636 RID: 1590
		internal static int __PropertyOffset_bResolveCollisions;

		// Token: 0x04000637 RID: 1591
		internal static byte __PropertyMask_bResolveCollisions;
	}
}
