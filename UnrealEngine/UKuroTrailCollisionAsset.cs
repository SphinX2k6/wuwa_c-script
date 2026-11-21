using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003A2 RID: 930
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroTrailCollisionAsset")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroTrailCollisionAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005C01 RID: 23553 RVA: 0x000819DA File Offset: 0x0007FBDA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTrailCollisionAsset._ClassPtr;
		}

		// Token: 0x06005C02 RID: 23554 RVA: 0x000819E8 File Offset: 0x0007FBE8
		public UKuroTrailCollisionAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroTrailCollisionAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00081A10 File Offset: 0x0007FC10
		[NullableContext(1)]
		public UKuroTrailCollisionAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTrailCollisionAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001216 RID: 4630
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x00081A43 File Offset: 0x0007FC43
		// (set) Token: 0x06005C05 RID: 23557 RVA: 0x00081A53 File Offset: 0x0007FC53
		public unsafe float StepDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_StepDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_StepDistance) = value;
			}
		}

		// Token: 0x17001217 RID: 4631
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x00081A64 File Offset: 0x0007FC64
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x00081A74 File Offset: 0x0007FC74
		public unsafe float StepInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_StepInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_StepInterval) = value;
			}
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06005C08 RID: 23560 RVA: 0x00081A85 File Offset: 0x0007FC85
		// (set) Token: 0x06005C09 RID: 23561 RVA: 0x00081A95 File Offset: 0x0007FC95
		public unsafe float HalfWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_HalfWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_HalfWidth) = value;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06005C0A RID: 23562 RVA: 0x00081AA6 File Offset: 0x0007FCA6
		// (set) Token: 0x06005C0B RID: 23563 RVA: 0x00081AB6 File Offset: 0x0007FCB6
		public unsafe float HalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_HalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_HalfHeight) = value;
			}
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x06005C0C RID: 23564 RVA: 0x00081AC7 File Offset: 0x0007FCC7
		// (set) Token: 0x06005C0D RID: 23565 RVA: 0x00081AD7 File Offset: 0x0007FCD7
		public unsafe float PaddingAlong
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_PaddingAlong);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_PaddingAlong) = value;
			}
		}

		// Token: 0x1700121B RID: 4635
		// (get) Token: 0x06005C0E RID: 23566 RVA: 0x00081AE8 File Offset: 0x0007FCE8
		// (set) Token: 0x06005C0F RID: 23567 RVA: 0x00081AF8 File Offset: 0x0007FCF8
		public unsafe float TTLSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_TTLSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_TTLSeconds) = value;
			}
		}

		// Token: 0x1700121C RID: 4636
		// (get) Token: 0x06005C10 RID: 23568 RVA: 0x00081B09 File Offset: 0x0007FD09
		// (set) Token: 0x06005C11 RID: 23569 RVA: 0x00081B19 File Offset: 0x0007FD19
		public unsafe int MaxSegments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MaxSegments);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MaxSegments) = value;
			}
		}

		// Token: 0x1700121D RID: 4637
		// (get) Token: 0x06005C12 RID: 23570 RVA: 0x00081B2C File Offset: 0x0007FD2C
		// (set) Token: 0x06005C13 RID: 23571 RVA: 0x00081B65 File Offset: 0x0007FD65
		[Nullable(1)]
		public FCollisionProfileName CollisionProfileName
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCollisionProfileName result;
				if ((result = this._CollisionProfileName) == null)
				{
					result = (this._CollisionProfileName = new FCollisionProfileName(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_CollisionProfileName, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCollisionProfileName.StaticStruct(), base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_CollisionProfileName, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06005C14 RID: 23572 RVA: 0x00081B86 File Offset: 0x0007FD86
		// (set) Token: 0x06005C15 RID: 23573 RVA: 0x00081B9F File Offset: 0x0007FD9F
		public unsafe bool bGenerateOverlapEvents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bGenerateOverlapEvents) & UKuroTrailCollisionAsset.__PropertyMask_bGenerateOverlapEvents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bGenerateOverlapEvents) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bGenerateOverlapEvents) & ~UKuroTrailCollisionAsset.__PropertyMask_bGenerateOverlapEvents) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bGenerateOverlapEvents : 0));
			}
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x06005C16 RID: 23574 RVA: 0x00081BCF File Offset: 0x0007FDCF
		// (set) Token: 0x06005C17 RID: 23575 RVA: 0x00081BE8 File Offset: 0x0007FDE8
		public unsafe bool bKuroOverlapNotify
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroOverlapNotify) & UKuroTrailCollisionAsset.__PropertyMask_bKuroOverlapNotify) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroOverlapNotify) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroOverlapNotify) & ~UKuroTrailCollisionAsset.__PropertyMask_bKuroOverlapNotify) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bKuroOverlapNotify : 0));
			}
		}

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x06005C18 RID: 23576 RVA: 0x00081C18 File Offset: 0x0007FE18
		// (set) Token: 0x06005C19 RID: 23577 RVA: 0x00081C31 File Offset: 0x0007FE31
		public unsafe bool bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) & UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) & ~UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap : 0));
			}
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06005C1A RID: 23578 RVA: 0x00081C61 File Offset: 0x0007FE61
		// (set) Token: 0x06005C1B RID: 23579 RVA: 0x00081C7A File Offset: 0x0007FE7A
		public unsafe bool bKuroPassiveCollision
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollision) & UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollision) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollision) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bKuroPassiveCollision) & ~UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollision) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bKuroPassiveCollision : 0));
			}
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06005C1C RID: 23580 RVA: 0x00081CAA File Offset: 0x0007FEAA
		// (set) Token: 0x06005C1D RID: 23581 RVA: 0x00081CC3 File Offset: 0x0007FEC3
		public unsafe bool bIgnoreOwner
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bIgnoreOwner) & UKuroTrailCollisionAsset.__PropertyMask_bIgnoreOwner) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bIgnoreOwner) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bIgnoreOwner) & ~UKuroTrailCollisionAsset.__PropertyMask_bIgnoreOwner) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bIgnoreOwner : 0));
			}
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06005C1E RID: 23582 RVA: 0x00081CF3 File Offset: 0x0007FEF3
		// (set) Token: 0x06005C1F RID: 23583 RVA: 0x00081D07 File Offset: 0x0007FF07
		public unsafe TEnumAsByte<EComponentMobility> Mobility
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_Mobility);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_Mobility) = value;
			}
		}

		// Token: 0x17001224 RID: 4644
		// (get) Token: 0x06005C20 RID: 23584 RVA: 0x00081D1C File Offset: 0x0007FF1C
		// (set) Token: 0x06005C21 RID: 23585 RVA: 0x00081D2C File Offset: 0x0007FF2C
		public unsafe float TeleportDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_TeleportDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_TeleportDistance) = value;
			}
		}

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x06005C22 RID: 23586 RVA: 0x00081D3D File Offset: 0x0007FF3D
		// (set) Token: 0x06005C23 RID: 23587 RVA: 0x00081D56 File Offset: 0x0007FF56
		public unsafe bool bMergeCollinear
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bMergeCollinear) & UKuroTrailCollisionAsset.__PropertyMask_bMergeCollinear) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bMergeCollinear) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bMergeCollinear) & ~UKuroTrailCollisionAsset.__PropertyMask_bMergeCollinear) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bMergeCollinear : 0));
			}
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x06005C24 RID: 23588 RVA: 0x00081D86 File Offset: 0x0007FF86
		// (set) Token: 0x06005C25 RID: 23589 RVA: 0x00081D96 File Offset: 0x0007FF96
		public unsafe float MergeAngleDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MergeAngleDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MergeAngleDeg) = value;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x06005C26 RID: 23590 RVA: 0x00081DA7 File Offset: 0x0007FFA7
		// (set) Token: 0x06005C27 RID: 23591 RVA: 0x00081DB7 File Offset: 0x0007FFB7
		public unsafe float MergeGapMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MergeGapMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_MergeGapMax) = value;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06005C28 RID: 23592 RVA: 0x00081DC8 File Offset: 0x0007FFC8
		// (set) Token: 0x06005C29 RID: 23593 RVA: 0x00081DE1 File Offset: 0x0007FFE1
		public unsafe bool bDrawDebug
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bDrawDebug) & UKuroTrailCollisionAsset.__PropertyMask_bDrawDebug) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bDrawDebug) = ((*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_bDrawDebug) & ~UKuroTrailCollisionAsset.__PropertyMask_bDrawDebug) | (value ? UKuroTrailCollisionAsset.__PropertyMask_bDrawDebug : 0));
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06005C2A RID: 23594 RVA: 0x00081E11 File Offset: 0x00080011
		// (set) Token: 0x06005C2B RID: 23595 RVA: 0x00081E25 File Offset: 0x00080025
		public unsafe FColor DebugColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_DebugColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_DebugColor) = value;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06005C2C RID: 23596 RVA: 0x00081E3A File Offset: 0x0008003A
		// (set) Token: 0x06005C2D RID: 23597 RVA: 0x00081E4E File Offset: 0x0008004E
		public unsafe FColor DebugMergedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_DebugMergedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTrailCollisionAsset.__PropertyOffset_DebugMergedColor) = value;
			}
		}

		// Token: 0x06005C2E RID: 23598 RVA: 0x00081E63 File Offset: 0x00080063
		static UKuroTrailCollisionAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayInterface.KuroTrailCollisionAsset");
		}

		// Token: 0x06005C2F RID: 23599 RVA: 0x00081E71 File Offset: 0x00080071
		protected UKuroTrailCollisionAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400264A RID: 9802
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayInterface.KuroTrailCollisionAsset";

		// Token: 0x0400264B RID: 9803
		private static IntPtr _ClassPtr;

		// Token: 0x0400264C RID: 9804
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400264D RID: 9805
		internal static int __PropertyOffset_StepDistance;

		// Token: 0x0400264E RID: 9806
		internal static int __PropertyOffset_StepInterval;

		// Token: 0x0400264F RID: 9807
		internal static int __PropertyOffset_HalfWidth;

		// Token: 0x04002650 RID: 9808
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x04002651 RID: 9809
		internal static int __PropertyOffset_PaddingAlong;

		// Token: 0x04002652 RID: 9810
		internal static int __PropertyOffset_TTLSeconds;

		// Token: 0x04002653 RID: 9811
		internal static int __PropertyOffset_MaxSegments;

		// Token: 0x04002654 RID: 9812
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x04002655 RID: 9813
		[Nullable(2)]
		private FCollisionProfileName _CollisionProfileName;

		// Token: 0x04002656 RID: 9814
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x04002657 RID: 9815
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x04002658 RID: 9816
		internal static int __PropertyOffset_bKuroOverlapNotify;

		// Token: 0x04002659 RID: 9817
		internal static byte __PropertyMask_bKuroOverlapNotify;

		// Token: 0x0400265A RID: 9818
		internal static int __PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400265B RID: 9819
		internal static byte __PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400265C RID: 9820
		internal static int __PropertyOffset_bKuroPassiveCollision;

		// Token: 0x0400265D RID: 9821
		internal static byte __PropertyMask_bKuroPassiveCollision;

		// Token: 0x0400265E RID: 9822
		internal static int __PropertyOffset_bIgnoreOwner;

		// Token: 0x0400265F RID: 9823
		internal static byte __PropertyMask_bIgnoreOwner;

		// Token: 0x04002660 RID: 9824
		internal static int __PropertyOffset_Mobility;

		// Token: 0x04002661 RID: 9825
		internal static int __PropertyOffset_TeleportDistance;

		// Token: 0x04002662 RID: 9826
		internal static int __PropertyOffset_bMergeCollinear;

		// Token: 0x04002663 RID: 9827
		internal static byte __PropertyMask_bMergeCollinear;

		// Token: 0x04002664 RID: 9828
		internal static int __PropertyOffset_MergeAngleDeg;

		// Token: 0x04002665 RID: 9829
		internal static int __PropertyOffset_MergeGapMax;

		// Token: 0x04002666 RID: 9830
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x04002667 RID: 9831
		internal static byte __PropertyMask_bDrawDebug;

		// Token: 0x04002668 RID: 9832
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x04002669 RID: 9833
		internal static int __PropertyOffset_DebugMergedColor;
	}
}
