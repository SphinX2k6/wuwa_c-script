using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001658 RID: 5720
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstanceNpc")]
	[UnrealStructLayout(2816, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2816)]
	public class UKuroAnimInstanceNpc : UKuroAnimInstanceChar, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014A10 RID: 84496 RVA: 0x001E5EC8 File Offset: 0x001E40C8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstanceNpc._ClassPtr;
		}

		// Token: 0x06014A11 RID: 84497 RVA: 0x001E5ED4 File Offset: 0x001E40D4
		public UKuroAnimInstanceNpc() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceNpc.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014A12 RID: 84498 RVA: 0x001E5EFC File Offset: 0x001E40FC
		[NullableContext(1)]
		public UKuroAnimInstanceNpc(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstanceNpc.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005137 RID: 20791
		// (get) Token: 0x06014A13 RID: 84499 RVA: 0x001E5F2F File Offset: 0x001E412F
		// (set) Token: 0x06014A14 RID: 84500 RVA: 0x001E5F43 File Offset: 0x001E4143
		public unsafe FVector SightDirection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_SightDirection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_SightDirection) = value;
			}
		}

		// Token: 0x17005138 RID: 20792
		// (get) Token: 0x06014A15 RID: 84501 RVA: 0x001E5F58 File Offset: 0x001E4158
		// (set) Token: 0x06014A16 RID: 84502 RVA: 0x001E5F68 File Offset: 0x001E4168
		public unsafe float SightAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_SightAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_SightAlpha) = value;
			}
		}

		// Token: 0x17005139 RID: 20793
		// (get) Token: 0x06014A17 RID: 84503 RVA: 0x001E5F79 File Offset: 0x001E4179
		// (set) Token: 0x06014A18 RID: 84504 RVA: 0x001E5F89 File Offset: 0x001E4189
		public unsafe int CameraModeType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CameraModeType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CameraModeType) = value;
			}
		}

		// Token: 0x1700513A RID: 20794
		// (get) Token: 0x06014A19 RID: 84505 RVA: 0x001E5F9A File Offset: 0x001E419A
		// (set) Token: 0x06014A1A RID: 84506 RVA: 0x001E5FAA File Offset: 0x001E41AA
		public unsafe bool bIsBeingCaptured
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bIsBeingCaptured) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bIsBeingCaptured) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700513B RID: 20795
		// (get) Token: 0x06014A1B RID: 84507 RVA: 0x001E5FBB File Offset: 0x001E41BB
		// (set) Token: 0x06014A1C RID: 84508 RVA: 0x001E5FCB File Offset: 0x001E41CB
		public unsafe bool bPlayKnockUpAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bPlayKnockUpAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bPlayKnockUpAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700513C RID: 20796
		// (get) Token: 0x06014A1D RID: 84509 RVA: 0x001E5FDC File Offset: 0x001E41DC
		// (set) Token: 0x06014A1E RID: 84510 RVA: 0x001E5FEC File Offset: 0x001E41EC
		public unsafe bool bHeadIKReturnToOrigin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bHeadIKReturnToOrigin) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bHeadIKReturnToOrigin) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700513D RID: 20797
		// (get) Token: 0x06014A1F RID: 84511 RVA: 0x001E5FFD File Offset: 0x001E41FD
		// (set) Token: 0x06014A20 RID: 84512 RVA: 0x001E600D File Offset: 0x001E420D
		public unsafe ECharMoveStateType CharacterMoveStateType
		{
			get
			{
				return (ECharMoveStateType)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CharacterMoveStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CharacterMoveStateType) = (byte)value;
			}
		}

		// Token: 0x1700513E RID: 20798
		// (get) Token: 0x06014A21 RID: 84513 RVA: 0x001E601E File Offset: 0x001E421E
		// (set) Token: 0x06014A22 RID: 84514 RVA: 0x001E602E File Offset: 0x001E422E
		public unsafe ECharPositionStateType CharacterPositionStateType
		{
			get
			{
				return (ECharPositionStateType)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CharacterPositionStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_CharacterPositionStateType) = (byte)value;
			}
		}

		// Token: 0x1700513F RID: 20799
		// (get) Token: 0x06014A23 RID: 84515 RVA: 0x001E603F File Offset: 0x001E423F
		// (set) Token: 0x06014A24 RID: 84516 RVA: 0x001E604F File Offset: 0x001E424F
		public unsafe EMoveDirection MovementDirection
		{
			get
			{
				return (EMoveDirection)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_MovementDirection));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_MovementDirection) = (byte)value;
			}
		}

		// Token: 0x17005140 RID: 20800
		// (get) Token: 0x06014A25 RID: 84517 RVA: 0x001E6060 File Offset: 0x001E4260
		// (set) Token: 0x06014A26 RID: 84518 RVA: 0x001E6070 File Offset: 0x001E4270
		public unsafe EWalkPosture WalkingPosture
		{
			get
			{
				return (EWalkPosture)(*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_WalkingPosture));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_WalkingPosture) = (byte)value;
			}
		}

		// Token: 0x17005141 RID: 20801
		// (get) Token: 0x06014A27 RID: 84519 RVA: 0x001E6081 File Offset: 0x001E4281
		// (set) Token: 0x06014A28 RID: 84520 RVA: 0x001E6091 File Offset: 0x001E4291
		public unsafe float UpdateDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_UpdateDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_UpdateDeltaSeconds) = value;
			}
		}

		// Token: 0x17005142 RID: 20802
		// (get) Token: 0x06014A29 RID: 84521 RVA: 0x001E60A2 File Offset: 0x001E42A2
		// (set) Token: 0x06014A2A RID: 84522 RVA: 0x001E60B2 File Offset: 0x001E42B2
		public unsafe float WorldDeltaSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_WorldDeltaSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_WorldDeltaSeconds) = value;
			}
		}

		// Token: 0x17005143 RID: 20803
		// (get) Token: 0x06014A2B RID: 84523 RVA: 0x001E60C3 File Offset: 0x001E42C3
		// (set) Token: 0x06014A2C RID: 84524 RVA: 0x001E60D3 File Offset: 0x001E42D3
		public unsafe bool bIdleThreeState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bIdleThreeState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bIdleThreeState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005144 RID: 20804
		// (get) Token: 0x06014A2D RID: 84525 RVA: 0x001E60E4 File Offset: 0x001E42E4
		// (set) Token: 0x06014A2E RID: 84526 RVA: 0x001E60F4 File Offset: 0x001E42F4
		public unsafe bool bCommonDebugState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bCommonDebugState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bCommonDebugState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005145 RID: 20805
		// (get) Token: 0x06014A2F RID: 84527 RVA: 0x001E6105 File Offset: 0x001E4305
		// (set) Token: 0x06014A30 RID: 84528 RVA: 0x001E6115 File Offset: 0x001E4315
		public unsafe bool bInAirState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bInAirState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bInAirState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005146 RID: 20806
		// (get) Token: 0x06014A31 RID: 84529 RVA: 0x001E6126 File Offset: 0x001E4326
		// (set) Token: 0x06014A32 RID: 84530 RVA: 0x001E6136 File Offset: 0x001E4336
		public unsafe bool bLowerHalfUniversalFusionState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bLowerHalfUniversalFusionState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bLowerHalfUniversalFusionState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005147 RID: 20807
		// (get) Token: 0x06014A33 RID: 84531 RVA: 0x001E6147 File Offset: 0x001E4347
		// (set) Token: 0x06014A34 RID: 84532 RVA: 0x001E6157 File Offset: 0x001E4357
		public unsafe bool bInBattleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bInBattleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bInBattleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005148 RID: 20808
		// (get) Token: 0x06014A35 RID: 84533 RVA: 0x001E6168 File Offset: 0x001E4368
		// (set) Token: 0x06014A36 RID: 84534 RVA: 0x001E6178 File Offset: 0x001E4378
		public unsafe bool bPlayEnterBattleState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bPlayEnterBattleState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstanceNpc.__PropertyOffset_bPlayEnterBattleState) = (value ? 1 : 0);
			}
		}

		// Token: 0x06014A37 RID: 84535 RVA: 0x001E6189 File Offset: 0x001E4389
		static UKuroAnimInstanceNpc()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstanceNpc");
		}

		// Token: 0x06014A38 RID: 84536 RVA: 0x001E6197 File Offset: 0x001E4397
		protected UKuroAnimInstanceNpc(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B401 RID: 46081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstanceNpc";

		// Token: 0x0400B402 RID: 46082
		private static IntPtr _ClassPtr;

		// Token: 0x0400B403 RID: 46083
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B404 RID: 46084
		internal static int __PropertyOffset_SightDirection;

		// Token: 0x0400B405 RID: 46085
		internal static int __PropertyOffset_SightAlpha;

		// Token: 0x0400B406 RID: 46086
		internal static int __PropertyOffset_CameraModeType;

		// Token: 0x0400B407 RID: 46087
		internal static int __PropertyOffset_bIsBeingCaptured;

		// Token: 0x0400B408 RID: 46088
		internal static int __PropertyOffset_bPlayKnockUpAnim;

		// Token: 0x0400B409 RID: 46089
		internal static int __PropertyOffset_bHeadIKReturnToOrigin;

		// Token: 0x0400B40A RID: 46090
		internal static int __PropertyOffset_CharacterMoveStateType;

		// Token: 0x0400B40B RID: 46091
		internal static int __PropertyOffset_CharacterPositionStateType;

		// Token: 0x0400B40C RID: 46092
		internal static int __PropertyOffset_MovementDirection;

		// Token: 0x0400B40D RID: 46093
		internal static int __PropertyOffset_WalkingPosture;

		// Token: 0x0400B40E RID: 46094
		internal static int __PropertyOffset_UpdateDeltaSeconds;

		// Token: 0x0400B40F RID: 46095
		internal static int __PropertyOffset_WorldDeltaSeconds;

		// Token: 0x0400B410 RID: 46096
		internal static int __PropertyOffset_bIdleThreeState;

		// Token: 0x0400B411 RID: 46097
		internal static int __PropertyOffset_bCommonDebugState;

		// Token: 0x0400B412 RID: 46098
		internal static int __PropertyOffset_bInAirState;

		// Token: 0x0400B413 RID: 46099
		internal static int __PropertyOffset_bLowerHalfUniversalFusionState;

		// Token: 0x0400B414 RID: 46100
		internal static int __PropertyOffset_bInBattleState;

		// Token: 0x0400B415 RID: 46101
		internal static int __PropertyOffset_bPlayEnterBattleState;
	}
}
