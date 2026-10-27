using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000167 RID: 359
	[UnrealObjectPath("/Script/AIModule.CrowdAvoidanceConfig")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FCrowdAvoidanceConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600183F RID: 6207 RVA: 0x00023BD5 File Offset: 0x00021DD5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCrowdAvoidanceConfig._ScriptStructPtr != 0) ? FCrowdAvoidanceConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.CrowdAvoidanceConfig", ref FCrowdAvoidanceConfig._ScriptStructPtr);
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06001840 RID: 6208 RVA: 0x00023BF9 File Offset: 0x00021DF9
		// (set) Token: 0x06001841 RID: 6209 RVA: 0x00023C09 File Offset: 0x00021E09
		public unsafe float VelocityBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_VelocityBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_VelocityBias) = value;
			}
		}

		// Token: 0x17000637 RID: 1591
		// (get) Token: 0x06001842 RID: 6210 RVA: 0x00023C1A File Offset: 0x00021E1A
		// (set) Token: 0x06001843 RID: 6211 RVA: 0x00023C2A File Offset: 0x00021E2A
		public unsafe float DesiredVelocityWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_DesiredVelocityWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_DesiredVelocityWeight) = value;
			}
		}

		// Token: 0x17000638 RID: 1592
		// (get) Token: 0x06001844 RID: 6212 RVA: 0x00023C3B File Offset: 0x00021E3B
		// (set) Token: 0x06001845 RID: 6213 RVA: 0x00023C4B File Offset: 0x00021E4B
		public unsafe float CurrentVelocityWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_CurrentVelocityWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_CurrentVelocityWeight) = value;
			}
		}

		// Token: 0x17000639 RID: 1593
		// (get) Token: 0x06001846 RID: 6214 RVA: 0x00023C5C File Offset: 0x00021E5C
		// (set) Token: 0x06001847 RID: 6215 RVA: 0x00023C6C File Offset: 0x00021E6C
		public unsafe float SideBiasWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_SideBiasWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_SideBiasWeight) = value;
			}
		}

		// Token: 0x1700063A RID: 1594
		// (get) Token: 0x06001848 RID: 6216 RVA: 0x00023C7D File Offset: 0x00021E7D
		// (set) Token: 0x06001849 RID: 6217 RVA: 0x00023C8D File Offset: 0x00021E8D
		public unsafe float ImpactTimeWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_ImpactTimeWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_ImpactTimeWeight) = value;
			}
		}

		// Token: 0x1700063B RID: 1595
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x00023C9E File Offset: 0x00021E9E
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00023CAE File Offset: 0x00021EAE
		public unsafe float ImpactTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_ImpactTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_ImpactTimeRange) = value;
			}
		}

		// Token: 0x1700063C RID: 1596
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00023CBF File Offset: 0x00021EBF
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x00023CCF File Offset: 0x00021ECF
		public unsafe byte CustomPatternIdx
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_CustomPatternIdx);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_CustomPatternIdx) = value;
			}
		}

		// Token: 0x1700063D RID: 1597
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00023CE0 File Offset: 0x00021EE0
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x00023CF0 File Offset: 0x00021EF0
		public unsafe byte AdaptiveDivisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveDivisions);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveDivisions) = value;
			}
		}

		// Token: 0x1700063E RID: 1598
		// (get) Token: 0x06001850 RID: 6224 RVA: 0x00023D01 File Offset: 0x00021F01
		// (set) Token: 0x06001851 RID: 6225 RVA: 0x00023D11 File Offset: 0x00021F11
		public unsafe byte AdaptiveRings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveRings);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveRings) = value;
			}
		}

		// Token: 0x1700063F RID: 1599
		// (get) Token: 0x06001852 RID: 6226 RVA: 0x00023D22 File Offset: 0x00021F22
		// (set) Token: 0x06001853 RID: 6227 RVA: 0x00023D32 File Offset: 0x00021F32
		public unsafe byte AdaptiveDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCrowdAvoidanceConfig.__PropertyOffset_AdaptiveDepth) = value;
			}
		}

		// Token: 0x06001854 RID: 6228 RVA: 0x00023D43 File Offset: 0x00021F43
		public FCrowdAvoidanceConfig()
		{
		}

		// Token: 0x06001855 RID: 6229 RVA: 0x00023D4C File Offset: 0x00021F4C
		public FCrowdAvoidanceConfig(float VelocityBias, float DesiredVelocityWeight, float CurrentVelocityWeight, float SideBiasWeight, float ImpactTimeWeight, float ImpactTimeRange, byte CustomPatternIdx, byte AdaptiveDivisions, byte AdaptiveRings, byte AdaptiveDepth)
		{
			this.VelocityBias = VelocityBias;
			this.DesiredVelocityWeight = DesiredVelocityWeight;
			this.CurrentVelocityWeight = CurrentVelocityWeight;
			this.SideBiasWeight = SideBiasWeight;
			this.ImpactTimeWeight = ImpactTimeWeight;
			this.ImpactTimeRange = ImpactTimeRange;
			this.CustomPatternIdx = CustomPatternIdx;
			this.AdaptiveDivisions = AdaptiveDivisions;
			this.AdaptiveRings = AdaptiveRings;
			this.AdaptiveDepth = AdaptiveDepth;
		}

		// Token: 0x06001856 RID: 6230 RVA: 0x00023DAC File Offset: 0x00021FAC
		protected override IntPtr GetUStructPtr()
		{
			return FCrowdAvoidanceConfig.StaticStruct();
		}

		// Token: 0x06001857 RID: 6231 RVA: 0x00023DB8 File Offset: 0x00021FB8
		[NullableContext(2)]
		public FCrowdAvoidanceConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001858 RID: 6232 RVA: 0x00023DC2 File Offset: 0x00021FC2
		public FCrowdAvoidanceConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001859 RID: 6233 RVA: 0x00023DCD File Offset: 0x00021FCD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCrowdAvoidanceConfig(Pointer, false, true);
		}

		// Token: 0x0600185A RID: 6234 RVA: 0x00023DD7 File Offset: 0x00021FD7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCrowdAvoidanceConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400060F RID: 1551
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.CrowdAvoidanceConfig";

		// Token: 0x04000610 RID: 1552
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000611 RID: 1553
		internal static int __PropertyOffset_VelocityBias;

		// Token: 0x04000612 RID: 1554
		internal static int __PropertyOffset_DesiredVelocityWeight;

		// Token: 0x04000613 RID: 1555
		internal static int __PropertyOffset_CurrentVelocityWeight;

		// Token: 0x04000614 RID: 1556
		internal static int __PropertyOffset_SideBiasWeight;

		// Token: 0x04000615 RID: 1557
		internal static int __PropertyOffset_ImpactTimeWeight;

		// Token: 0x04000616 RID: 1558
		internal static int __PropertyOffset_ImpactTimeRange;

		// Token: 0x04000617 RID: 1559
		internal static int __PropertyOffset_CustomPatternIdx;

		// Token: 0x04000618 RID: 1560
		internal static int __PropertyOffset_AdaptiveDivisions;

		// Token: 0x04000619 RID: 1561
		internal static int __PropertyOffset_AdaptiveRings;

		// Token: 0x0400061A RID: 1562
		internal static int __PropertyOffset_AdaptiveDepth;
	}
}
