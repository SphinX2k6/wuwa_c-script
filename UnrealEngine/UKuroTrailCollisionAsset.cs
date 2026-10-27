using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001878 RID: 6264
	[UnrealObjectPath("/Script/KuroGameplayInterface.KuroTrailCollisionAsset")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UKuroTrailCollisionAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060170F7 RID: 94455 RVA: 0x00219ABC File Offset: 0x00217CBC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTrailCollisionAsset._ClassPtr;
		}

		// Token: 0x060170F8 RID: 94456 RVA: 0x00219AC8 File Offset: 0x00217CC8
		public UKuroTrailCollisionAsset() : this(BuiltinUtils.AllocNativeUObject(UKuroTrailCollisionAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060170F9 RID: 94457 RVA: 0x00219AF0 File Offset: 0x00217CF0
		[NullableContext(1)]
		public UKuroTrailCollisionAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTrailCollisionAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005CB7 RID: 23735
		// (get) Token: 0x060170FA RID: 94458 RVA: 0x00219B23 File Offset: 0x00217D23
		// (set) Token: 0x060170FB RID: 94459 RVA: 0x00219B33 File Offset: 0x00217D33
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

		// Token: 0x17005CB8 RID: 23736
		// (get) Token: 0x060170FC RID: 94460 RVA: 0x00219B44 File Offset: 0x00217D44
		// (set) Token: 0x060170FD RID: 94461 RVA: 0x00219B54 File Offset: 0x00217D54
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

		// Token: 0x17005CB9 RID: 23737
		// (get) Token: 0x060170FE RID: 94462 RVA: 0x00219B65 File Offset: 0x00217D65
		// (set) Token: 0x060170FF RID: 94463 RVA: 0x00219B75 File Offset: 0x00217D75
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

		// Token: 0x17005CBA RID: 23738
		// (get) Token: 0x06017100 RID: 94464 RVA: 0x00219B86 File Offset: 0x00217D86
		// (set) Token: 0x06017101 RID: 94465 RVA: 0x00219B96 File Offset: 0x00217D96
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

		// Token: 0x17005CBB RID: 23739
		// (get) Token: 0x06017102 RID: 94466 RVA: 0x00219BA7 File Offset: 0x00217DA7
		// (set) Token: 0x06017103 RID: 94467 RVA: 0x00219BB7 File Offset: 0x00217DB7
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

		// Token: 0x17005CBC RID: 23740
		// (get) Token: 0x06017104 RID: 94468 RVA: 0x00219BC8 File Offset: 0x00217DC8
		// (set) Token: 0x06017105 RID: 94469 RVA: 0x00219BD8 File Offset: 0x00217DD8
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

		// Token: 0x17005CBD RID: 23741
		// (get) Token: 0x06017106 RID: 94470 RVA: 0x00219BE9 File Offset: 0x00217DE9
		// (set) Token: 0x06017107 RID: 94471 RVA: 0x00219BF9 File Offset: 0x00217DF9
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

		// Token: 0x17005CBE RID: 23742
		// (get) Token: 0x06017108 RID: 94472 RVA: 0x00219C0C File Offset: 0x00217E0C
		// (set) Token: 0x06017109 RID: 94473 RVA: 0x00219C45 File Offset: 0x00217E45
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

		// Token: 0x17005CBF RID: 23743
		// (get) Token: 0x0601710A RID: 94474 RVA: 0x00219C66 File Offset: 0x00217E66
		// (set) Token: 0x0601710B RID: 94475 RVA: 0x00219C7F File Offset: 0x00217E7F
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

		// Token: 0x17005CC0 RID: 23744
		// (get) Token: 0x0601710C RID: 94476 RVA: 0x00219CAF File Offset: 0x00217EAF
		// (set) Token: 0x0601710D RID: 94477 RVA: 0x00219CC8 File Offset: 0x00217EC8
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

		// Token: 0x17005CC1 RID: 23745
		// (get) Token: 0x0601710E RID: 94478 RVA: 0x00219CF8 File Offset: 0x00217EF8
		// (set) Token: 0x0601710F RID: 94479 RVA: 0x00219D11 File Offset: 0x00217F11
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

		// Token: 0x17005CC2 RID: 23746
		// (get) Token: 0x06017110 RID: 94480 RVA: 0x00219D41 File Offset: 0x00217F41
		// (set) Token: 0x06017111 RID: 94481 RVA: 0x00219D5A File Offset: 0x00217F5A
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

		// Token: 0x17005CC3 RID: 23747
		// (get) Token: 0x06017112 RID: 94482 RVA: 0x00219D8A File Offset: 0x00217F8A
		// (set) Token: 0x06017113 RID: 94483 RVA: 0x00219DA3 File Offset: 0x00217FA3
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

		// Token: 0x17005CC4 RID: 23748
		// (get) Token: 0x06017114 RID: 94484 RVA: 0x00219DD3 File Offset: 0x00217FD3
		// (set) Token: 0x06017115 RID: 94485 RVA: 0x00219DE7 File Offset: 0x00217FE7
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

		// Token: 0x17005CC5 RID: 23749
		// (get) Token: 0x06017116 RID: 94486 RVA: 0x00219DFC File Offset: 0x00217FFC
		// (set) Token: 0x06017117 RID: 94487 RVA: 0x00219E0C File Offset: 0x0021800C
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

		// Token: 0x17005CC6 RID: 23750
		// (get) Token: 0x06017118 RID: 94488 RVA: 0x00219E1D File Offset: 0x0021801D
		// (set) Token: 0x06017119 RID: 94489 RVA: 0x00219E36 File Offset: 0x00218036
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

		// Token: 0x17005CC7 RID: 23751
		// (get) Token: 0x0601711A RID: 94490 RVA: 0x00219E66 File Offset: 0x00218066
		// (set) Token: 0x0601711B RID: 94491 RVA: 0x00219E76 File Offset: 0x00218076
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

		// Token: 0x17005CC8 RID: 23752
		// (get) Token: 0x0601711C RID: 94492 RVA: 0x00219E87 File Offset: 0x00218087
		// (set) Token: 0x0601711D RID: 94493 RVA: 0x00219E97 File Offset: 0x00218097
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

		// Token: 0x17005CC9 RID: 23753
		// (get) Token: 0x0601711E RID: 94494 RVA: 0x00219EA8 File Offset: 0x002180A8
		// (set) Token: 0x0601711F RID: 94495 RVA: 0x00219EC1 File Offset: 0x002180C1
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

		// Token: 0x17005CCA RID: 23754
		// (get) Token: 0x06017120 RID: 94496 RVA: 0x00219EF1 File Offset: 0x002180F1
		// (set) Token: 0x06017121 RID: 94497 RVA: 0x00219F05 File Offset: 0x00218105
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

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x06017122 RID: 94498 RVA: 0x00219F1A File Offset: 0x0021811A
		// (set) Token: 0x06017123 RID: 94499 RVA: 0x00219F2E File Offset: 0x0021812E
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

		// Token: 0x06017124 RID: 94500 RVA: 0x00219F43 File Offset: 0x00218143
		static UKuroTrailCollisionAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplayInterface.KuroTrailCollisionAsset");
		}

		// Token: 0x06017125 RID: 94501 RVA: 0x00219F51 File Offset: 0x00218151
		protected UKuroTrailCollisionAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C833 RID: 51251
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplayInterface.KuroTrailCollisionAsset";

		// Token: 0x0400C834 RID: 51252
		private static IntPtr _ClassPtr;

		// Token: 0x0400C835 RID: 51253
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C836 RID: 51254
		internal static int __PropertyOffset_StepDistance;

		// Token: 0x0400C837 RID: 51255
		internal static int __PropertyOffset_StepInterval;

		// Token: 0x0400C838 RID: 51256
		internal static int __PropertyOffset_HalfWidth;

		// Token: 0x0400C839 RID: 51257
		internal static int __PropertyOffset_HalfHeight;

		// Token: 0x0400C83A RID: 51258
		internal static int __PropertyOffset_PaddingAlong;

		// Token: 0x0400C83B RID: 51259
		internal static int __PropertyOffset_TTLSeconds;

		// Token: 0x0400C83C RID: 51260
		internal static int __PropertyOffset_MaxSegments;

		// Token: 0x0400C83D RID: 51261
		internal static int __PropertyOffset_CollisionProfileName;

		// Token: 0x0400C83E RID: 51262
		[Nullable(2)]
		private FCollisionProfileName _CollisionProfileName;

		// Token: 0x0400C83F RID: 51263
		internal static int __PropertyOffset_bGenerateOverlapEvents;

		// Token: 0x0400C840 RID: 51264
		internal static byte __PropertyMask_bGenerateOverlapEvents;

		// Token: 0x0400C841 RID: 51265
		internal static int __PropertyOffset_bKuroOverlapNotify;

		// Token: 0x0400C842 RID: 51266
		internal static byte __PropertyMask_bKuroOverlapNotify;

		// Token: 0x0400C843 RID: 51267
		internal static int __PropertyOffset_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400C844 RID: 51268
		internal static byte __PropertyMask_bKuroPassiveCollisionUpdateOverlapsWhenEnterOverlap;

		// Token: 0x0400C845 RID: 51269
		internal static int __PropertyOffset_bKuroPassiveCollision;

		// Token: 0x0400C846 RID: 51270
		internal static byte __PropertyMask_bKuroPassiveCollision;

		// Token: 0x0400C847 RID: 51271
		internal static int __PropertyOffset_bIgnoreOwner;

		// Token: 0x0400C848 RID: 51272
		internal static byte __PropertyMask_bIgnoreOwner;

		// Token: 0x0400C849 RID: 51273
		internal static int __PropertyOffset_Mobility;

		// Token: 0x0400C84A RID: 51274
		internal static int __PropertyOffset_TeleportDistance;

		// Token: 0x0400C84B RID: 51275
		internal static int __PropertyOffset_bMergeCollinear;

		// Token: 0x0400C84C RID: 51276
		internal static byte __PropertyMask_bMergeCollinear;

		// Token: 0x0400C84D RID: 51277
		internal static int __PropertyOffset_MergeAngleDeg;

		// Token: 0x0400C84E RID: 51278
		internal static int __PropertyOffset_MergeGapMax;

		// Token: 0x0400C84F RID: 51279
		internal static int __PropertyOffset_bDrawDebug;

		// Token: 0x0400C850 RID: 51280
		internal static byte __PropertyMask_bDrawDebug;

		// Token: 0x0400C851 RID: 51281
		internal static int __PropertyOffset_DebugColor;

		// Token: 0x0400C852 RID: 51282
		internal static int __PropertyOffset_DebugMergedColor;
	}
}
