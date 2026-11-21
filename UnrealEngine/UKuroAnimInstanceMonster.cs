using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F0 RID: 752
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceMonster")]
	[UnrealStructLayout(2880, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2880)]
	public class UKuroAnimInstanceMonster : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06005080 RID: 20608 RVA: 0x0007123C File Offset: 0x0006F43C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceMonster._ClassPtr;
		}

		// Token: 0x06005081 RID: 20609 RVA: 0x00071248 File Offset: 0x0006F448
		public UKuroAnimInstanceMonster() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceMonster.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005082 RID: 20610 RVA: 0x00071270 File Offset: 0x0006F470
		public UKuroAnimInstanceMonster(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceMonster.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x000712A4 File Offset: 0x0006F4A4
		// (set) Token: 0x06005084 RID: 20612 RVA: 0x000712DD File Offset: 0x0006F4DD
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

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x000712EB File Offset: 0x0006F4EB
		// (set) Token: 0x06005086 RID: 20614 RVA: 0x000712FF File Offset: 0x0006F4FF
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

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06005087 RID: 20615 RVA: 0x00071314 File Offset: 0x0006F514
		// (set) Token: 0x06005088 RID: 20616 RVA: 0x00071324 File Offset: 0x0006F524
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

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06005089 RID: 20617 RVA: 0x00071335 File Offset: 0x0006F535
		// (set) Token: 0x0600508A RID: 20618 RVA: 0x00071345 File Offset: 0x0006F545
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

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x0600508B RID: 20619 RVA: 0x00071356 File Offset: 0x0006F556
		// (set) Token: 0x0600508C RID: 20620 RVA: 0x00071366 File Offset: 0x0006F566
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

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x0600508D RID: 20621 RVA: 0x00071377 File Offset: 0x0006F577
		// (set) Token: 0x0600508E RID: 20622 RVA: 0x0007138B File Offset: 0x0006F58B
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

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x0600508F RID: 20623 RVA: 0x000713A0 File Offset: 0x0006F5A0
		// (set) Token: 0x06005090 RID: 20624 RVA: 0x000713B0 File Offset: 0x0006F5B0
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

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06005091 RID: 20625 RVA: 0x000713C1 File Offset: 0x0006F5C1
		// (set) Token: 0x06005092 RID: 20626 RVA: 0x000713D1 File Offset: 0x0006F5D1
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

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06005093 RID: 20627 RVA: 0x000713E2 File Offset: 0x0006F5E2
		// (set) Token: 0x06005094 RID: 20628 RVA: 0x000713F2 File Offset: 0x0006F5F2
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

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06005095 RID: 20629 RVA: 0x00071403 File Offset: 0x0006F603
		// (set) Token: 0x06005096 RID: 20630 RVA: 0x00071413 File Offset: 0x0006F613
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

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06005097 RID: 20631 RVA: 0x00071424 File Offset: 0x0006F624
		// (set) Token: 0x06005098 RID: 20632 RVA: 0x00071434 File Offset: 0x0006F634
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

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06005099 RID: 20633 RVA: 0x00071445 File Offset: 0x0006F645
		// (set) Token: 0x0600509A RID: 20634 RVA: 0x00071455 File Offset: 0x0006F655
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

		// Token: 0x17000F9C RID: 3996
		// (get) Token: 0x0600509B RID: 20635 RVA: 0x00071466 File Offset: 0x0006F666
		// (set) Token: 0x0600509C RID: 20636 RVA: 0x00071476 File Offset: 0x0006F676
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

		// Token: 0x17000F9D RID: 3997
		// (get) Token: 0x0600509D RID: 20637 RVA: 0x00071487 File Offset: 0x0006F687
		// (set) Token: 0x0600509E RID: 20638 RVA: 0x00071497 File Offset: 0x0006F697
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

		// Token: 0x17000F9E RID: 3998
		// (get) Token: 0x0600509F RID: 20639 RVA: 0x000714A8 File Offset: 0x0006F6A8
		// (set) Token: 0x060050A0 RID: 20640 RVA: 0x000714B8 File Offset: 0x0006F6B8
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

		// Token: 0x17000F9F RID: 3999
		// (get) Token: 0x060050A1 RID: 20641 RVA: 0x000714C9 File Offset: 0x0006F6C9
		// (set) Token: 0x060050A2 RID: 20642 RVA: 0x000714D9 File Offset: 0x0006F6D9
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

		// Token: 0x17000FA0 RID: 4000
		// (get) Token: 0x060050A3 RID: 20643 RVA: 0x000714EA File Offset: 0x0006F6EA
		// (set) Token: 0x060050A4 RID: 20644 RVA: 0x000714FA File Offset: 0x0006F6FA
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

		// Token: 0x17000FA1 RID: 4001
		// (get) Token: 0x060050A5 RID: 20645 RVA: 0x0007150B File Offset: 0x0006F70B
		// (set) Token: 0x060050A6 RID: 20646 RVA: 0x0007151B File Offset: 0x0006F71B
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

		// Token: 0x17000FA2 RID: 4002
		// (get) Token: 0x060050A7 RID: 20647 RVA: 0x0007152C File Offset: 0x0006F72C
		// (set) Token: 0x060050A8 RID: 20648 RVA: 0x0007153C File Offset: 0x0006F73C
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

		// Token: 0x17000FA3 RID: 4003
		// (get) Token: 0x060050A9 RID: 20649 RVA: 0x0007154D File Offset: 0x0006F74D
		// (set) Token: 0x060050AA RID: 20650 RVA: 0x0007155D File Offset: 0x0006F75D
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

		// Token: 0x17000FA4 RID: 4004
		// (get) Token: 0x060050AB RID: 20651 RVA: 0x0007156E File Offset: 0x0006F76E
		// (set) Token: 0x060050AC RID: 20652 RVA: 0x0007157E File Offset: 0x0006F77E
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

		// Token: 0x17000FA5 RID: 4005
		// (get) Token: 0x060050AD RID: 20653 RVA: 0x0007158F File Offset: 0x0006F78F
		// (set) Token: 0x060050AE RID: 20654 RVA: 0x0007159F File Offset: 0x0006F79F
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

		// Token: 0x17000FA6 RID: 4006
		// (get) Token: 0x060050AF RID: 20655 RVA: 0x000715B0 File Offset: 0x0006F7B0
		// (set) Token: 0x060050B0 RID: 20656 RVA: 0x000715C0 File Offset: 0x0006F7C0
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

		// Token: 0x17000FA7 RID: 4007
		// (get) Token: 0x060050B1 RID: 20657 RVA: 0x000715D1 File Offset: 0x0006F7D1
		// (set) Token: 0x060050B2 RID: 20658 RVA: 0x000715E1 File Offset: 0x0006F7E1
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

		// Token: 0x17000FA8 RID: 4008
		// (get) Token: 0x060050B3 RID: 20659 RVA: 0x000715F2 File Offset: 0x0006F7F2
		// (set) Token: 0x060050B4 RID: 20660 RVA: 0x00071602 File Offset: 0x0006F802
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

		// Token: 0x060050B5 RID: 20661 RVA: 0x00071613 File Offset: 0x0006F813
		static UKuroAnimInstanceMonster()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceMonster");
		}

		// Token: 0x060050B6 RID: 20662 RVA: 0x00071621 File Offset: 0x0006F821
		protected UKuroAnimInstanceMonster(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040020A3 RID: 8355
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceMonster";

		// Token: 0x040020A4 RID: 8356
		private static IntPtr _ClassPtr;

		// Token: 0x040020A5 RID: 8357
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040020A6 RID: 8358
		internal static int __PropertyOffset_HitBonesList;

		// Token: 0x040020A7 RID: 8359
		[Nullable(2)]
		private TArray<FName> _HitBonesList;

		// Token: 0x040020A8 RID: 8360
		internal static int __PropertyOffset_SightDirection;

		// Token: 0x040020A9 RID: 8361
		internal static int __PropertyOffset_SightAlpha;

		// Token: 0x040020AA RID: 8362
		internal static int __PropertyOffset_SightDirectionRightAngle;

		// Token: 0x040020AB RID: 8363
		internal static int __PropertyOffset_SightDirectionUpAngle;

		// Token: 0x040020AC RID: 8364
		internal static int __PropertyOffset_HateLocation;

		// Token: 0x040020AD RID: 8365
		internal static int __PropertyOffset_bIsBeingCaptured;

		// Token: 0x040020AE RID: 8366
		internal static int __PropertyOffset_bPlayKnockUpAnim;

		// Token: 0x040020AF RID: 8367
		internal static int __PropertyOffset_bHeadIKReturnToOrigin;

		// Token: 0x040020B0 RID: 8368
		internal static int __PropertyOffset_CharacterMoveStateType;

		// Token: 0x040020B1 RID: 8369
		internal static int __PropertyOffset_CharacterPositionStateType;

		// Token: 0x040020B2 RID: 8370
		internal static int __PropertyOffset_bAcceptNewHit;

		// Token: 0x040020B3 RID: 8371
		internal static int __PropertyOffset_bEnterFk;

		// Token: 0x040020B4 RID: 8372
		internal static int __PropertyOffset_bHitInAir;

		// Token: 0x040020B5 RID: 8373
		internal static int __PropertyOffset_HitAnimType;

		// Token: 0x040020B6 RID: 8374
		internal static int __PropertyOffset_UpdateDeltaSeconds;

		// Token: 0x040020B7 RID: 8375
		internal static int __PropertyOffset_WorldDeltaSeconds;

		// Token: 0x040020B8 RID: 8376
		internal static int __PropertyOffset_bIdleThreeState;

		// Token: 0x040020B9 RID: 8377
		internal static int __PropertyOffset_bCommonDebugState;

		// Token: 0x040020BA RID: 8378
		internal static int __PropertyOffset_bInAirState;

		// Token: 0x040020BB RID: 8379
		internal static int __PropertyOffset_bLowerHalfUniversalFusionState;

		// Token: 0x040020BC RID: 8380
		internal static int __PropertyOffset_bInBattleState;

		// Token: 0x040020BD RID: 8381
		internal static int __PropertyOffset_bPlayEnterBattleState;

		// Token: 0x040020BE RID: 8382
		internal static int __PropertyOffset_bIsFlyMonster;

		// Token: 0x040020BF RID: 8383
		internal static int __PropertyOffset_TurnInt;
	}
}
