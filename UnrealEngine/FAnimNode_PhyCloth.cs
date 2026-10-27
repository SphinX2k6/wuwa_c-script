using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200161C RID: 5660
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_PhyCloth")]
	[UnrealStructLayout(1296, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1296)]
	public class FAnimNode_PhyCloth : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601473C RID: 83772 RVA: 0x001E146C File Offset: 0x001DF66C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_PhyCloth._ScriptStructPtr != 0) ? FAnimNode_PhyCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_PhyCloth", ref FAnimNode_PhyCloth._ScriptStructPtr);
		}

		// Token: 0x17005070 RID: 20592
		// (get) Token: 0x0601473D RID: 83773 RVA: 0x001E1490 File Offset: 0x001DF690
		// (set) Token: 0x0601473E RID: 83774 RVA: 0x001E14D3 File Offset: 0x001DF6D3
		public TArray<FPhyClothGroup> ClothGroups
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPhyClothGroup> result;
				if ((result = this._ClothGroups) == null)
				{
					result = (this._ClothGroups = new TArray<FPhyClothGroup>(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_ClothGroups, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ClothGroups.CopyAssign(value);
			}
		}

		// Token: 0x17005071 RID: 20593
		// (get) Token: 0x0601473F RID: 83775 RVA: 0x001E14E1 File Offset: 0x001DF6E1
		// (set) Token: 0x06014740 RID: 83776 RVA: 0x001E14F1 File Offset: 0x001DF6F1
		public unsafe bool OpenCollateralRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_OpenCollateralRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_OpenCollateralRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005072 RID: 20594
		// (get) Token: 0x06014741 RID: 83777 RVA: 0x001E1502 File Offset: 0x001DF702
		// (set) Token: 0x06014742 RID: 83778 RVA: 0x001E1512 File Offset: 0x001DF712
		public unsafe bool MultiThread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MultiThread) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MultiThread) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005073 RID: 20595
		// (get) Token: 0x06014743 RID: 83779 RVA: 0x001E1523 File Offset: 0x001DF723
		// (set) Token: 0x06014744 RID: 83780 RVA: 0x001E1533 File Offset: 0x001DF733
		public unsafe bool Transport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_Transport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_Transport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005074 RID: 20596
		// (get) Token: 0x06014745 RID: 83781 RVA: 0x001E1544 File Offset: 0x001DF744
		// (set) Token: 0x06014746 RID: 83782 RVA: 0x001E1554 File Offset: 0x001DF754
		public unsafe float TransportThreadHold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_TransportThreadHold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_TransportThreadHold) = value;
			}
		}

		// Token: 0x17005075 RID: 20597
		// (get) Token: 0x06014747 RID: 83783 RVA: 0x001E1565 File Offset: 0x001DF765
		// (set) Token: 0x06014748 RID: 83784 RVA: 0x001E1575 File Offset: 0x001DF775
		public unsafe int MinIterTimes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MinIterTimes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MinIterTimes) = value;
			}
		}

		// Token: 0x17005076 RID: 20598
		// (get) Token: 0x06014749 RID: 83785 RVA: 0x001E1586 File Offset: 0x001DF786
		// (set) Token: 0x0601474A RID: 83786 RVA: 0x001E1596 File Offset: 0x001DF796
		public unsafe int MaxIterTimes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MaxIterTimes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MaxIterTimes) = value;
			}
		}

		// Token: 0x17005077 RID: 20599
		// (get) Token: 0x0601474B RID: 83787 RVA: 0x001E15A7 File Offset: 0x001DF7A7
		// (set) Token: 0x0601474C RID: 83788 RVA: 0x001E15B7 File Offset: 0x001DF7B7
		public unsafe float MaxDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MaxDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_MaxDeltaTime) = value;
			}
		}

		// Token: 0x17005078 RID: 20600
		// (get) Token: 0x0601474D RID: 83789 RVA: 0x001E15C8 File Offset: 0x001DF7C8
		// (set) Token: 0x0601474E RID: 83790 RVA: 0x001E15DC File Offset: 0x001DF7DC
		public unsafe FVector WindSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_WindSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_WindSpeed) = value;
			}
		}

		// Token: 0x17005079 RID: 20601
		// (get) Token: 0x0601474F RID: 83791 RVA: 0x001E15F1 File Offset: 0x001DF7F1
		// (set) Token: 0x06014750 RID: 83792 RVA: 0x001E1601 File Offset: 0x001DF801
		public unsafe float AirDrag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_AirDrag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_AirDrag) = value;
			}
		}

		// Token: 0x1700507A RID: 20602
		// (get) Token: 0x06014751 RID: 83793 RVA: 0x001E1612 File Offset: 0x001DF812
		// (set) Token: 0x06014752 RID: 83794 RVA: 0x001E1622 File Offset: 0x001DF822
		public unsafe float DisturbPeriodic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_DisturbPeriodic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_DisturbPeriodic) = value;
			}
		}

		// Token: 0x1700507B RID: 20603
		// (get) Token: 0x06014753 RID: 83795 RVA: 0x001E1633 File Offset: 0x001DF833
		// (set) Token: 0x06014754 RID: 83796 RVA: 0x001E1643 File Offset: 0x001DF843
		public unsafe float DisturbStrMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_DisturbStrMul);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_DisturbStrMul) = value;
			}
		}

		// Token: 0x1700507C RID: 20604
		// (get) Token: 0x06014755 RID: 83797 RVA: 0x001E1654 File Offset: 0x001DF854
		// (set) Token: 0x06014756 RID: 83798 RVA: 0x001E1668 File Offset: 0x001DF868
		[Nullable(2)]
		public unsafe UCurveFloat DisturbStr
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PhyCloth.__PropertyOffset_DisturbStr);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PhyCloth.__PropertyOffset_DisturbStr, value);
			}
		}

		// Token: 0x1700507D RID: 20605
		// (get) Token: 0x06014757 RID: 83799 RVA: 0x001E167D File Offset: 0x001DF87D
		// (set) Token: 0x06014758 RID: 83800 RVA: 0x001E1691 File Offset: 0x001DF891
		[Nullable(2)]
		public unsafe UCurveFloat DisturbSplit
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PhyCloth.__PropertyOffset_DisturbSplit);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_PhyCloth.__PropertyOffset_DisturbSplit, value);
			}
		}

		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x06014759 RID: 83801 RVA: 0x001E16A6 File Offset: 0x001DF8A6
		// (set) Token: 0x0601475A RID: 83802 RVA: 0x001E16BA File Offset: 0x001DF8BA
		public unsafe FName OriginAlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_OriginAlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_PhyCloth.__PropertyOffset_OriginAlphaCurveName) = value;
			}
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x001E16CF File Offset: 0x001DF8CF
		public FAnimNode_PhyCloth()
		{
		}

		// Token: 0x0601475C RID: 83804 RVA: 0x001E16D8 File Offset: 0x001DF8D8
		public FAnimNode_PhyCloth(TArray<FPhyClothGroup> ClothGroups, bool OpenCollateralRotation, bool MultiThread, bool Transport, float TransportThreadHold, int MinIterTimes, int MaxIterTimes, float MaxDeltaTime, FVector WindSpeed, float AirDrag, float DisturbPeriodic, float DisturbStrMul, UCurveFloat DisturbStr, UCurveFloat DisturbSplit, FName OriginAlphaCurveName, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.ClothGroups = ClothGroups;
			this.OpenCollateralRotation = OpenCollateralRotation;
			this.MultiThread = MultiThread;
			this.Transport = Transport;
			this.TransportThreadHold = TransportThreadHold;
			this.MinIterTimes = MinIterTimes;
			this.MaxIterTimes = MaxIterTimes;
			this.MaxDeltaTime = MaxDeltaTime;
			this.WindSpeed = WindSpeed;
			this.AirDrag = AirDrag;
			this.DisturbPeriodic = DisturbPeriodic;
			this.DisturbStrMul = DisturbStrMul;
			this.DisturbStr = DisturbStr;
			this.DisturbSplit = DisturbSplit;
			this.OriginAlphaCurveName = OriginAlphaCurveName;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x0601475D RID: 83805 RVA: 0x001E17C8 File Offset: 0x001DF9C8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_PhyCloth.StaticStruct();
		}

		// Token: 0x0601475E RID: 83806 RVA: 0x001E17D4 File Offset: 0x001DF9D4
		[NullableContext(2)]
		public FAnimNode_PhyCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601475F RID: 83807 RVA: 0x001E17DE File Offset: 0x001DF9DE
		public FAnimNode_PhyCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014760 RID: 83808 RVA: 0x001E17E9 File Offset: 0x001DF9E9
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_PhyCloth(Pointer, false, true);
		}

		// Token: 0x06014761 RID: 83809 RVA: 0x001E17F3 File Offset: 0x001DF9F3
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_PhyCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400B204 RID: 45572
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_PhyCloth";

		// Token: 0x0400B205 RID: 45573
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B206 RID: 45574
		internal static int __PropertyOffset_ClothGroups;

		// Token: 0x0400B207 RID: 45575
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPhyClothGroup> _ClothGroups;

		// Token: 0x0400B208 RID: 45576
		internal static int __PropertyOffset_OpenCollateralRotation;

		// Token: 0x0400B209 RID: 45577
		internal static int __PropertyOffset_MultiThread;

		// Token: 0x0400B20A RID: 45578
		internal static int __PropertyOffset_Transport;

		// Token: 0x0400B20B RID: 45579
		internal static int __PropertyOffset_TransportThreadHold;

		// Token: 0x0400B20C RID: 45580
		internal static int __PropertyOffset_MinIterTimes;

		// Token: 0x0400B20D RID: 45581
		internal static int __PropertyOffset_MaxIterTimes;

		// Token: 0x0400B20E RID: 45582
		internal static int __PropertyOffset_MaxDeltaTime;

		// Token: 0x0400B20F RID: 45583
		internal static int __PropertyOffset_WindSpeed;

		// Token: 0x0400B210 RID: 45584
		internal static int __PropertyOffset_AirDrag;

		// Token: 0x0400B211 RID: 45585
		internal static int __PropertyOffset_DisturbPeriodic;

		// Token: 0x0400B212 RID: 45586
		internal static int __PropertyOffset_DisturbStrMul;

		// Token: 0x0400B213 RID: 45587
		internal static int __PropertyOffset_DisturbStr;

		// Token: 0x0400B214 RID: 45588
		internal static int __PropertyOffset_DisturbSplit;

		// Token: 0x0400B215 RID: 45589
		internal static int __PropertyOffset_OriginAlphaCurveName;
	}
}
