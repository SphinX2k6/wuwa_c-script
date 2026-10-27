using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001657 RID: 5719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceMonster")]
	[UnrealStructLayout(2864, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2864)]
	public class UKuroAnimInstanceMonster : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060149D5 RID: 84437 RVA: 0x001E5A98 File Offset: 0x001E3C98
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceMonster._ClassPtr;
		}

		// Token: 0x060149D6 RID: 84438 RVA: 0x001E5AA4 File Offset: 0x001E3CA4
		public UKuroAnimInstanceMonster() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceMonster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060149D7 RID: 84439 RVA: 0x001E5ACC File Offset: 0x001E3CCC
		public UKuroAnimInstanceMonster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceMonster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700511C RID: 20764
		// (get) Token: 0x060149D8 RID: 84440 RVA: 0x001E5B00 File Offset: 0x001E3D00
		// (set) Token: 0x060149D9 RID: 84441 RVA: 0x001E5B39 File Offset: 0x001E3D39
		public TArray<FName> HitBonesList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._HitBonesList) == null)
				{
					result = (this._HitBonesList = new TArray<FName>(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_HitBonesList, this));
				}
				return result;
			}
			set
			{
				this.HitBonesList.CopyAssign(value);
			}
		}

		// Token: 0x1700511D RID: 20765
		// (get) Token: 0x060149DA RID: 84442 RVA: 0x001E5B47 File Offset: 0x001E3D47
		// (set) Token: 0x060149DB RID: 84443 RVA: 0x001E5B5B File Offset: 0x001E3D5B
		public unsafe FVector SightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirection) = value;
			}
		}

		// Token: 0x1700511E RID: 20766
		// (get) Token: 0x060149DC RID: 84444 RVA: 0x001E5B70 File Offset: 0x001E3D70
		// (set) Token: 0x060149DD RID: 84445 RVA: 0x001E5B80 File Offset: 0x001E3D80
		public unsafe float SightAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightAlpha) = value;
			}
		}

		// Token: 0x1700511F RID: 20767
		// (get) Token: 0x060149DE RID: 84446 RVA: 0x001E5B91 File Offset: 0x001E3D91
		// (set) Token: 0x060149DF RID: 84447 RVA: 0x001E5BA1 File Offset: 0x001E3DA1
		public unsafe float SightDirectionRightAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirectionRightAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirectionRightAngle) = value;
			}
		}

		// Token: 0x17005120 RID: 20768
		// (get) Token: 0x060149E0 RID: 84448 RVA: 0x001E5BB2 File Offset: 0x001E3DB2
		// (set) Token: 0x060149E1 RID: 84449 RVA: 0x001E5BC2 File Offset: 0x001E3DC2
		public unsafe float SightDirectionUpAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirectionUpAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_SightDirectionUpAngle) = value;
			}
		}

		// Token: 0x17005121 RID: 20769
		// (get) Token: 0x060149E2 RID: 84450 RVA: 0x001E5BD3 File Offset: 0x001E3DD3
		// (set) Token: 0x060149E3 RID: 84451 RVA: 0x001E5BE7 File Offset: 0x001E3DE7
		public unsafe FVector HateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_HateLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_HateLocation) = value;
			}
		}

		// Token: 0x17005122 RID: 20770
		// (get) Token: 0x060149E4 RID: 84452 RVA: 0x001E5BFC File Offset: 0x001E3DFC
		// (set) Token: 0x060149E5 RID: 84453 RVA: 0x001E5C0C File Offset: 0x001E3E0C
		public unsafe bool bIsBeingCaptured
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIsBeingCaptured) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIsBeingCaptured) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005123 RID: 20771
		// (get) Token: 0x060149E6 RID: 84454 RVA: 0x001E5C1D File Offset: 0x001E3E1D
		// (set) Token: 0x060149E7 RID: 84455 RVA: 0x001E5C2D File Offset: 0x001E3E2D
		public unsafe bool bPlayKnockUpAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bPlayKnockUpAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bPlayKnockUpAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005124 RID: 20772
		// (get) Token: 0x060149E8 RID: 84456 RVA: 0x001E5C3E File Offset: 0x001E3E3E
		// (set) Token: 0x060149E9 RID: 84457 RVA: 0x001E5C4E File Offset: 0x001E3E4E
		public unsafe bool bHeadIKReturnToOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bHeadIKReturnToOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bHeadIKReturnToOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005125 RID: 20773
		// (get) Token: 0x060149EA RID: 84458 RVA: 0x001E5C5F File Offset: 0x001E3E5F
		// (set) Token: 0x060149EB RID: 84459 RVA: 0x001E5C6F File Offset: 0x001E3E6F
		public unsafe ECharMoveStateType CharacterMoveStateType
		{
			get
			{
				return (ECharMoveStateType)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_CharacterMoveStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_CharacterMoveStateType) = (byte)value;
			}
		}

		// Token: 0x17005126 RID: 20774
		// (get) Token: 0x060149EC RID: 84460 RVA: 0x001E5C80 File Offset: 0x001E3E80
		// (set) Token: 0x060149ED RID: 84461 RVA: 0x001E5C90 File Offset: 0x001E3E90
		public unsafe ECharPositionStateType CharacterPositionStateType
		{
			get
			{
				return (ECharPositionStateType)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_CharacterPositionStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_CharacterPositionStateType) = (byte)value;
			}
		}

		// Token: 0x17005127 RID: 20775
		// (get) Token: 0x060149EE RID: 84462 RVA: 0x001E5CA1 File Offset: 0x001E3EA1
		// (set) Token: 0x060149EF RID: 84463 RVA: 0x001E5CB1 File Offset: 0x001E3EB1
		public unsafe bool bAcceptNewHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bAcceptNewHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bAcceptNewHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005128 RID: 20776
		// (get) Token: 0x060149F0 RID: 84464 RVA: 0x001E5CC2 File Offset: 0x001E3EC2
		// (set) Token: 0x060149F1 RID: 84465 RVA: 0x001E5CD2 File Offset: 0x001E3ED2
		public unsafe bool bEnterFk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bEnterFk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bEnterFk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005129 RID: 20777
		// (get) Token: 0x060149F2 RID: 84466 RVA: 0x001E5CE3 File Offset: 0x001E3EE3
		// (set) Token: 0x060149F3 RID: 84467 RVA: 0x001E5CF3 File Offset: 0x001E3EF3
		public unsafe bool bHitInAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bHitInAir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bHitInAir) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700512A RID: 20778
		// (get) Token: 0x060149F4 RID: 84468 RVA: 0x001E5D04 File Offset: 0x001E3F04
		// (set) Token: 0x060149F5 RID: 84469 RVA: 0x001E5D14 File Offset: 0x001E3F14
		public unsafe int HitAnimType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_HitAnimType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_HitAnimType) = value;
			}
		}

		// Token: 0x1700512B RID: 20779
		// (get) Token: 0x060149F6 RID: 84470 RVA: 0x001E5D25 File Offset: 0x001E3F25
		// (set) Token: 0x060149F7 RID: 84471 RVA: 0x001E5D35 File Offset: 0x001E3F35
		public unsafe EMoveDirection MovementDirection
		{
			get
			{
				return (EMoveDirection)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_MovementDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_MovementDirection) = (byte)value;
			}
		}

		// Token: 0x1700512C RID: 20780
		// (get) Token: 0x060149F8 RID: 84472 RVA: 0x001E5D46 File Offset: 0x001E3F46
		// (set) Token: 0x060149F9 RID: 84473 RVA: 0x001E5D56 File Offset: 0x001E3F56
		public unsafe EWalkPosture WalkingPosture
		{
			get
			{
				return (EWalkPosture)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_WalkingPosture));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_WalkingPosture) = (byte)value;
			}
		}

		// Token: 0x1700512D RID: 20781
		// (get) Token: 0x060149FA RID: 84474 RVA: 0x001E5D67 File Offset: 0x001E3F67
		// (set) Token: 0x060149FB RID: 84475 RVA: 0x001E5D77 File Offset: 0x001E3F77
		public unsafe float UpdateDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_UpdateDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_UpdateDeltaSeconds) = value;
			}
		}

		// Token: 0x1700512E RID: 20782
		// (get) Token: 0x060149FC RID: 84476 RVA: 0x001E5D88 File Offset: 0x001E3F88
		// (set) Token: 0x060149FD RID: 84477 RVA: 0x001E5D98 File Offset: 0x001E3F98
		public unsafe float WorldDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_WorldDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_WorldDeltaSeconds) = value;
			}
		}

		// Token: 0x1700512F RID: 20783
		// (get) Token: 0x060149FE RID: 84478 RVA: 0x001E5DA9 File Offset: 0x001E3FA9
		// (set) Token: 0x060149FF RID: 84479 RVA: 0x001E5DB9 File Offset: 0x001E3FB9
		public unsafe bool bIdleThreeState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIdleThreeState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIdleThreeState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005130 RID: 20784
		// (get) Token: 0x06014A00 RID: 84480 RVA: 0x001E5DCA File Offset: 0x001E3FCA
		// (set) Token: 0x06014A01 RID: 84481 RVA: 0x001E5DDA File Offset: 0x001E3FDA
		public unsafe bool bCommonDebugState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bCommonDebugState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bCommonDebugState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005131 RID: 20785
		// (get) Token: 0x06014A02 RID: 84482 RVA: 0x001E5DEB File Offset: 0x001E3FEB
		// (set) Token: 0x06014A03 RID: 84483 RVA: 0x001E5DFB File Offset: 0x001E3FFB
		public unsafe bool bInAirState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bInAirState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bInAirState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005132 RID: 20786
		// (get) Token: 0x06014A04 RID: 84484 RVA: 0x001E5E0C File Offset: 0x001E400C
		// (set) Token: 0x06014A05 RID: 84485 RVA: 0x001E5E1C File Offset: 0x001E401C
		public unsafe bool bLowerHalfUniversalFusionState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bLowerHalfUniversalFusionState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bLowerHalfUniversalFusionState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005133 RID: 20787
		// (get) Token: 0x06014A06 RID: 84486 RVA: 0x001E5E2D File Offset: 0x001E402D
		// (set) Token: 0x06014A07 RID: 84487 RVA: 0x001E5E3D File Offset: 0x001E403D
		public unsafe bool bInBattleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bInBattleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bInBattleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005134 RID: 20788
		// (get) Token: 0x06014A08 RID: 84488 RVA: 0x001E5E4E File Offset: 0x001E404E
		// (set) Token: 0x06014A09 RID: 84489 RVA: 0x001E5E5E File Offset: 0x001E405E
		public unsafe bool bPlayEnterBattleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bPlayEnterBattleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bPlayEnterBattleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005135 RID: 20789
		// (get) Token: 0x06014A0A RID: 84490 RVA: 0x001E5E6F File Offset: 0x001E406F
		// (set) Token: 0x06014A0B RID: 84491 RVA: 0x001E5E7F File Offset: 0x001E407F
		public unsafe bool bIsFlyMonster
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIsFlyMonster) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_bIsFlyMonster) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005136 RID: 20790
		// (get) Token: 0x06014A0C RID: 84492 RVA: 0x001E5E90 File Offset: 0x001E4090
		// (set) Token: 0x06014A0D RID: 84493 RVA: 0x001E5EA0 File Offset: 0x001E40A0
		public unsafe int TurnInt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_TurnInt);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceMonster.__PropertyOffset_TurnInt) = value;
			}
		}

		// Token: 0x06014A0E RID: 84494 RVA: 0x001E5EB1 File Offset: 0x001E40B1
		static UKuroAnimInstanceMonster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceMonster");
		}

		// Token: 0x06014A0F RID: 84495 RVA: 0x001E5EBF File Offset: 0x001E40BF
		protected UKuroAnimInstanceMonster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3E2 RID: 46050
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceMonster";

		// Token: 0x0400B3E3 RID: 46051
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3E4 RID: 46052
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3E5 RID: 46053
		internal static int __PropertyOffset_HitBonesList;

		// Token: 0x0400B3E6 RID: 46054
		[Nullable(2)]
		private TArray<FName> _HitBonesList;

		// Token: 0x0400B3E7 RID: 46055
		internal static int __PropertyOffset_SightDirection;

		// Token: 0x0400B3E8 RID: 46056
		internal static int __PropertyOffset_SightAlpha;

		// Token: 0x0400B3E9 RID: 46057
		internal static int __PropertyOffset_SightDirectionRightAngle;

		// Token: 0x0400B3EA RID: 46058
		internal static int __PropertyOffset_SightDirectionUpAngle;

		// Token: 0x0400B3EB RID: 46059
		internal static int __PropertyOffset_HateLocation;

		// Token: 0x0400B3EC RID: 46060
		internal static int __PropertyOffset_bIsBeingCaptured;

		// Token: 0x0400B3ED RID: 46061
		internal static int __PropertyOffset_bPlayKnockUpAnim;

		// Token: 0x0400B3EE RID: 46062
		internal static int __PropertyOffset_bHeadIKReturnToOrigin;

		// Token: 0x0400B3EF RID: 46063
		internal static int __PropertyOffset_CharacterMoveStateType;

		// Token: 0x0400B3F0 RID: 46064
		internal static int __PropertyOffset_CharacterPositionStateType;

		// Token: 0x0400B3F1 RID: 46065
		internal static int __PropertyOffset_bAcceptNewHit;

		// Token: 0x0400B3F2 RID: 46066
		internal static int __PropertyOffset_bEnterFk;

		// Token: 0x0400B3F3 RID: 46067
		internal static int __PropertyOffset_bHitInAir;

		// Token: 0x0400B3F4 RID: 46068
		internal static int __PropertyOffset_HitAnimType;

		// Token: 0x0400B3F5 RID: 46069
		internal static int __PropertyOffset_MovementDirection;

		// Token: 0x0400B3F6 RID: 46070
		internal static int __PropertyOffset_WalkingPosture;

		// Token: 0x0400B3F7 RID: 46071
		internal static int __PropertyOffset_UpdateDeltaSeconds;

		// Token: 0x0400B3F8 RID: 46072
		internal static int __PropertyOffset_WorldDeltaSeconds;

		// Token: 0x0400B3F9 RID: 46073
		internal static int __PropertyOffset_bIdleThreeState;

		// Token: 0x0400B3FA RID: 46074
		internal static int __PropertyOffset_bCommonDebugState;

		// Token: 0x0400B3FB RID: 46075
		internal static int __PropertyOffset_bInAirState;

		// Token: 0x0400B3FC RID: 46076
		internal static int __PropertyOffset_bLowerHalfUniversalFusionState;

		// Token: 0x0400B3FD RID: 46077
		internal static int __PropertyOffset_bInBattleState;

		// Token: 0x0400B3FE RID: 46078
		internal static int __PropertyOffset_bPlayEnterBattleState;

		// Token: 0x0400B3FF RID: 46079
		internal static int __PropertyOffset_bIsFlyMonster;

		// Token: 0x0400B400 RID: 46080
		internal static int __PropertyOffset_TurnInt;
	}
}
