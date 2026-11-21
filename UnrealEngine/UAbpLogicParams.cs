using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DF RID: 735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AbpLogicParams")]
	[UnrealStructLayout(560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UAbpLogicParams : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004EFC RID: 20220 RVA: 0x0006EB67 File Offset: 0x0006CD67
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAbpLogicParams._ClassPtr;
		}

		// Token: 0x06004EFD RID: 20221 RVA: 0x0006EB74 File Offset: 0x0006CD74
		public UAbpLogicParams() : this(BuiltinUtils.AllocNativeUObject(UAbpLogicParams.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004EFE RID: 20222 RVA: 0x0006EB9C File Offset: 0x0006CD9C
		public UAbpLogicParams(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAbpLogicParams.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x06004EFF RID: 20223 RVA: 0x0006EBCF File Offset: 0x0006CDCF
		// (set) Token: 0x06004F00 RID: 20224 RVA: 0x0006EBDF File Offset: 0x0006CDDF
		public unsafe bool AcceptedNewBeHitRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AcceptedNewBeHitRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AcceptedNewBeHitRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06004F01 RID: 20225 RVA: 0x0006EBF0 File Offset: 0x0006CDF0
		// (set) Token: 0x06004F02 RID: 20226 RVA: 0x0006EC00 File Offset: 0x0006CE00
		public unsafe int BeHitAnimRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitAnimRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitAnimRef) = value;
			}
		}

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06004F03 RID: 20227 RVA: 0x0006EC11 File Offset: 0x0006CE11
		// (set) Token: 0x06004F04 RID: 20228 RVA: 0x0006EC21 File Offset: 0x0006CE21
		public unsafe bool EnterFkRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_EnterFkRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_EnterFkRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x06004F05 RID: 20229 RVA: 0x0006EC32 File Offset: 0x0006CE32
		// (set) Token: 0x06004F06 RID: 20230 RVA: 0x0006EC42 File Offset: 0x0006CE42
		public unsafe bool DoubleHitInAirRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DoubleHitInAirRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DoubleHitInAirRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x06004F07 RID: 20231 RVA: 0x0006EC53 File Offset: 0x0006CE53
		// (set) Token: 0x06004F08 RID: 20232 RVA: 0x0006EC67 File Offset: 0x0006CE67
		public unsafe FVector BeHitDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitDirectRef) = value;
			}
		}

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x06004F09 RID: 20233 RVA: 0x0006EC7C File Offset: 0x0006CE7C
		// (set) Token: 0x06004F0A RID: 20234 RVA: 0x0006EC90 File Offset: 0x0006CE90
		public unsafe FVector BeHitLocationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitLocationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitLocationRef) = value;
			}
		}

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x06004F0B RID: 20235 RVA: 0x0006ECA5 File Offset: 0x0006CEA5
		// (set) Token: 0x06004F0C RID: 20236 RVA: 0x0006ECB9 File Offset: 0x0006CEB9
		public unsafe FName BeHitSocketNameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitSocketNameRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitSocketNameRef) = value;
			}
		}

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x06004F0D RID: 20237 RVA: 0x0006ECCE File Offset: 0x0006CECE
		// (set) Token: 0x06004F0E RID: 20238 RVA: 0x0006ECE2 File Offset: 0x0006CEE2
		public unsafe FName BeHitBoneRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitBoneRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BeHitBoneRef) = value;
			}
		}

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x06004F0F RID: 20239 RVA: 0x0006ECF8 File Offset: 0x0006CEF8
		// (set) Token: 0x06004F10 RID: 20240 RVA: 0x0006ED31 File Offset: 0x0006CF31
		public FBoneFeedbackAnimHitInfo HitInfo
		{
			get
			{
				base.FastCheckIsValid();
				FBoneFeedbackAnimHitInfo result;
				if ((result = this._HitInfo) == null)
				{
					result = (this._HitInfo = new FBoneFeedbackAnimHitInfo(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HitInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneFeedbackAnimHitInfo.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HitInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x06004F11 RID: 20241 RVA: 0x0006ED52 File Offset: 0x0006CF52
		// (set) Token: 0x06004F12 RID: 20242 RVA: 0x0006ED62 File Offset: 0x0006CF62
		public unsafe ECharMoveStateType CharMoveStateRef
		{
			get
			{
				return (ECharMoveStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharMoveStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharMoveStateRef) = (byte)value;
			}
		}

		// Token: 0x17000F20 RID: 3872
		// (get) Token: 0x06004F13 RID: 20243 RVA: 0x0006ED73 File Offset: 0x0006CF73
		// (set) Token: 0x06004F14 RID: 20244 RVA: 0x0006ED83 File Offset: 0x0006CF83
		public unsafe ECharPositionStateType CharPositionStateRef
		{
			get
			{
				return (ECharPositionStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharPositionStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharPositionStateRef) = (byte)value;
			}
		}

		// Token: 0x17000F21 RID: 3873
		// (get) Token: 0x06004F15 RID: 20245 RVA: 0x0006ED94 File Offset: 0x0006CF94
		// (set) Token: 0x06004F16 RID: 20246 RVA: 0x0006EDA4 File Offset: 0x0006CFA4
		public unsafe ECharViewDirectionStateType CharCameraStateRef
		{
			get
			{
				return (ECharViewDirectionStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharCameraStateRef));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_CharCameraStateRef) = (byte)value;
			}
		}

		// Token: 0x17000F22 RID: 3874
		// (get) Token: 0x06004F17 RID: 20247 RVA: 0x0006EDB5 File Offset: 0x0006CFB5
		// (set) Token: 0x06004F18 RID: 20248 RVA: 0x0006EDC5 File Offset: 0x0006CFC5
		public unsafe float BattleIdleTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BattleIdleTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_BattleIdleTimeRef) = value;
			}
		}

		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06004F19 RID: 20249 RVA: 0x0006EDD6 File Offset: 0x0006CFD6
		// (set) Token: 0x06004F1A RID: 20250 RVA: 0x0006EDE6 File Offset: 0x0006CFE6
		public unsafe float DegMovementSlopeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DegMovementSlopeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_DegMovementSlopeRef) = value;
			}
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06004F1B RID: 20251 RVA: 0x0006EDF7 File Offset: 0x0006CFF7
		// (set) Token: 0x06004F1C RID: 20252 RVA: 0x0006EE0B File Offset: 0x0006D00B
		public unsafe FVector SightDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SightDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SightDirectRef) = value;
			}
		}

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06004F1D RID: 20253 RVA: 0x0006EE20 File Offset: 0x0006D020
		// (set) Token: 0x06004F1E RID: 20254 RVA: 0x0006EE30 File Offset: 0x0006D030
		public unsafe bool RagQuitStateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RagQuitStateRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RagQuitStateRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06004F1F RID: 20255 RVA: 0x0006EE41 File Offset: 0x0006D041
		// (set) Token: 0x06004F20 RID: 20256 RVA: 0x0006EE51 File Offset: 0x0006D051
		public unsafe bool IsJumpRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsJumpRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsJumpRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06004F21 RID: 20257 RVA: 0x0006EE62 File Offset: 0x0006D062
		// (set) Token: 0x06004F22 RID: 20258 RVA: 0x0006EE76 File Offset: 0x0006D076
		public unsafe FVector AccelerationRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AccelerationRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AccelerationRef) = value;
			}
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06004F23 RID: 20259 RVA: 0x0006EE8B File Offset: 0x0006D08B
		// (set) Token: 0x06004F24 RID: 20260 RVA: 0x0006EE9B File Offset: 0x0006D09B
		public unsafe bool IsMovingRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsMovingRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsMovingRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F29 RID: 3881
		// (get) Token: 0x06004F25 RID: 20261 RVA: 0x0006EEAC File Offset: 0x0006D0AC
		// (set) Token: 0x06004F26 RID: 20262 RVA: 0x0006EEBC File Offset: 0x0006D0BC
		public unsafe float SpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SpeedRef) = value;
			}
		}

		// Token: 0x17000F2A RID: 3882
		// (get) Token: 0x06004F27 RID: 20263 RVA: 0x0006EECD File Offset: 0x0006D0CD
		// (set) Token: 0x06004F28 RID: 20264 RVA: 0x0006EEE1 File Offset: 0x0006D0E1
		public unsafe FVector InputDirectRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputDirectRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputDirectRef) = value;
			}
		}

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06004F29 RID: 20265 RVA: 0x0006EEF6 File Offset: 0x0006D0F6
		// (set) Token: 0x06004F2A RID: 20266 RVA: 0x0006EF0A File Offset: 0x0006D10A
		public unsafe FRotator InputRotatorRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputRotatorRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_InputRotatorRef) = value;
			}
		}

		// Token: 0x17000F2C RID: 3884
		// (get) Token: 0x06004F2B RID: 20267 RVA: 0x0006EF1F File Offset: 0x0006D11F
		// (set) Token: 0x06004F2C RID: 20268 RVA: 0x0006EF2F File Offset: 0x0006D12F
		public unsafe bool bUpdateInputRotatorRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUpdateInputRotatorRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUpdateInputRotatorRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F2D RID: 3885
		// (get) Token: 0x06004F2D RID: 20269 RVA: 0x0006EF40 File Offset: 0x0006D140
		// (set) Token: 0x06004F2E RID: 20270 RVA: 0x0006EF50 File Offset: 0x0006D150
		public unsafe bool IsFallingIntoWaterRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsFallingIntoWaterRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsFallingIntoWaterRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F2E RID: 3886
		// (get) Token: 0x06004F2F RID: 20271 RVA: 0x0006EF61 File Offset: 0x0006D161
		// (set) Token: 0x06004F30 RID: 20272 RVA: 0x0006EF71 File Offset: 0x0006D171
		public unsafe float GroundedTimeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_GroundedTimeRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_GroundedTimeRef) = value;
			}
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06004F31 RID: 20273 RVA: 0x0006EF82 File Offset: 0x0006D182
		// (set) Token: 0x06004F32 RID: 20274 RVA: 0x0006EF92 File Offset: 0x0006D192
		public unsafe bool HasMoveInputRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HasMoveInputRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HasMoveInputRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06004F33 RID: 20275 RVA: 0x0006EFA4 File Offset: 0x0006D1A4
		// (set) Token: 0x06004F34 RID: 20276 RVA: 0x0006EFDD File Offset: 0x0006D1DD
		public FClimbInfoStruct ClimbInfoRef
		{
			get
			{
				base.FastCheckIsValid();
				FClimbInfoStruct result;
				if ((result = this._ClimbInfoRef) == null)
				{
					result = (this._ClimbInfoRef = new FClimbInfoStruct(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbInfoRef, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClimbInfoStruct.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbInfoRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06004F35 RID: 20277 RVA: 0x0006F000 File Offset: 0x0006D200
		// (set) Token: 0x06004F36 RID: 20278 RVA: 0x0006F039 File Offset: 0x0006D239
		public FClimbStateStruct ClimbStateRef
		{
			get
			{
				base.FastCheckIsValid();
				FClimbStateStruct result;
				if ((result = this._ClimbStateRef) == null)
				{
					result = (this._ClimbStateRef = new FClimbStateStruct(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbStateRef, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FClimbStateStruct.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbStateRef, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06004F37 RID: 20279 RVA: 0x0006F05A File Offset: 0x0006D25A
		// (set) Token: 0x06004F38 RID: 20280 RVA: 0x0006F06A File Offset: 0x0006D26A
		public unsafe float ClimbOnWallAngleRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbOnWallAngleRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ClimbOnWallAngleRef) = value;
			}
		}

		// Token: 0x17000F33 RID: 3891
		// (get) Token: 0x06004F39 RID: 20281 RVA: 0x0006F07B File Offset: 0x0006D27B
		// (set) Token: 0x06004F3A RID: 20282 RVA: 0x0006F08B File Offset: 0x0006D28B
		public unsafe float SprintSwimOffsetRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetRef) = value;
			}
		}

		// Token: 0x17000F34 RID: 3892
		// (get) Token: 0x06004F3B RID: 20283 RVA: 0x0006F09C File Offset: 0x0006D29C
		// (set) Token: 0x06004F3C RID: 20284 RVA: 0x0006F0AC File Offset: 0x0006D2AC
		public unsafe float SprintSwimOffsetLerpSpeedRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetLerpSpeedRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SprintSwimOffsetLerpSpeedRef) = value;
			}
		}

		// Token: 0x17000F35 RID: 3893
		// (get) Token: 0x06004F3D RID: 20285 RVA: 0x0006F0BD File Offset: 0x0006D2BD
		// (set) Token: 0x06004F3E RID: 20286 RVA: 0x0006F0D1 File Offset: 0x0006D2D1
		public unsafe FVector SlideForwardRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideForwardRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideForwardRef) = value;
			}
		}

		// Token: 0x17000F36 RID: 3894
		// (get) Token: 0x06004F3F RID: 20287 RVA: 0x0006F0E6 File Offset: 0x0006D2E6
		// (set) Token: 0x06004F40 RID: 20288 RVA: 0x0006F0F6 File Offset: 0x0006D2F6
		public unsafe bool SlideSwitchThisFrameRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideSwitchThisFrameRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideSwitchThisFrameRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F37 RID: 3895
		// (get) Token: 0x06004F41 RID: 20289 RVA: 0x0006F107 File Offset: 0x0006D307
		// (set) Token: 0x06004F42 RID: 20290 RVA: 0x0006F117 File Offset: 0x0006D317
		public unsafe bool SlideStandModeRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideStandModeRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SlideStandModeRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F38 RID: 3896
		// (get) Token: 0x06004F43 RID: 20291 RVA: 0x0006F128 File Offset: 0x0006D328
		// (set) Token: 0x06004F44 RID: 20292 RVA: 0x0006F138 File Offset: 0x0006D338
		public unsafe float JumpUpRateRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_JumpUpRateRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_JumpUpRateRef) = value;
			}
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06004F45 RID: 20293 RVA: 0x0006F149 File Offset: 0x0006D349
		// (set) Token: 0x06004F46 RID: 20294 RVA: 0x0006F159 File Offset: 0x0006D359
		public unsafe bool ForceExitStateStopRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ForceExitStateStopRef) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_ForceExitStateStopRef) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F3A RID: 3898
		// (get) Token: 0x06004F47 RID: 20295 RVA: 0x0006F16A File Offset: 0x0006D36A
		// (set) Token: 0x06004F48 RID: 20296 RVA: 0x0006F17E File Offset: 0x0006D37E
		[Nullable(2)]
		public unsafe AActor SkillTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_SkillTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_SkillTarget, value);
			}
		}

		// Token: 0x17000F3B RID: 3899
		// (get) Token: 0x06004F49 RID: 20297 RVA: 0x0006F193 File Offset: 0x0006D393
		// (set) Token: 0x06004F4A RID: 20298 RVA: 0x0006F1A7 File Offset: 0x0006D3A7
		[Nullable(2)]
		public unsafe AActor HateTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_HateTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAbpLogicParams.__PropertyOffset_HateTarget, value);
			}
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x06004F4B RID: 20299 RVA: 0x0006F1BC File Offset: 0x0006D3BC
		// (set) Token: 0x06004F4C RID: 20300 RVA: 0x0006F1CC File Offset: 0x0006D3CC
		public unsafe float LastActiveSkillTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LastActiveSkillTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LastActiveSkillTime) = value;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x06004F4D RID: 20301 RVA: 0x0006F1DD File Offset: 0x0006D3DD
		// (set) Token: 0x06004F4E RID: 20302 RVA: 0x0006F1ED File Offset: 0x0006D3ED
		public unsafe int SitDownDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownDirect) = value;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x06004F4F RID: 20303 RVA: 0x0006F1FE File Offset: 0x0006D3FE
		// (set) Token: 0x06004F50 RID: 20304 RVA: 0x0006F20E File Offset: 0x0006D40E
		public unsafe int StandUpDirect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_StandUpDirect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_StandUpDirect) = value;
			}
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x06004F51 RID: 20305 RVA: 0x0006F21F File Offset: 0x0006D41F
		// (set) Token: 0x06004F52 RID: 20306 RVA: 0x0006F22F File Offset: 0x0006D42F
		public unsafe bool bSitDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSitDown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSitDown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x06004F53 RID: 20307 RVA: 0x0006F240 File Offset: 0x0006D440
		// (set) Token: 0x06004F54 RID: 20308 RVA: 0x0006F250 File Offset: 0x0006D450
		public unsafe int SitDownType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SitDownType) = value;
			}
		}

		// Token: 0x17000F41 RID: 3905
		// (get) Token: 0x06004F55 RID: 20309 RVA: 0x0006F261 File Offset: 0x0006D461
		// (set) Token: 0x06004F56 RID: 20310 RVA: 0x0006F271 File Offset: 0x0006D471
		public unsafe bool IsDriver
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsDriver) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsDriver) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F42 RID: 3906
		// (get) Token: 0x06004F57 RID: 20311 RVA: 0x0006F282 File Offset: 0x0006D482
		// (set) Token: 0x06004F58 RID: 20312 RVA: 0x0006F292 File Offset: 0x0006D492
		public unsafe bool IsOnVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F43 RID: 3907
		// (get) Token: 0x06004F59 RID: 20313 RVA: 0x0006F2A3 File Offset: 0x0006D4A3
		// (set) Token: 0x06004F5A RID: 20314 RVA: 0x0006F2B3 File Offset: 0x0006D4B3
		public unsafe bool IsOnVehicleWithOther
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicleWithOther) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsOnVehicleWithOther) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F44 RID: 3908
		// (get) Token: 0x06004F5B RID: 20315 RVA: 0x0006F2C4 File Offset: 0x0006D4C4
		// (set) Token: 0x06004F5C RID: 20316 RVA: 0x0006F2D4 File Offset: 0x0006D4D4
		public unsafe bool IsLeavingVehicle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsLeavingVehicle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsLeavingVehicle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F45 RID: 3909
		// (get) Token: 0x06004F5D RID: 20317 RVA: 0x0006F2E5 File Offset: 0x0006D4E5
		// (set) Token: 0x06004F5E RID: 20318 RVA: 0x0006F2F5 File Offset: 0x0006D4F5
		public unsafe int VehicleType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleType) = value;
			}
		}

		// Token: 0x17000F46 RID: 3910
		// (get) Token: 0x06004F5F RID: 20319 RVA: 0x0006F306 File Offset: 0x0006D506
		// (set) Token: 0x06004F60 RID: 20320 RVA: 0x0006F316 File Offset: 0x0006D516
		public unsafe bool IsVehicleImpact
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsVehicleImpact) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_IsVehicleImpact) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F47 RID: 3911
		// (get) Token: 0x06004F61 RID: 20321 RVA: 0x0006F327 File Offset: 0x0006D527
		// (set) Token: 0x06004F62 RID: 20322 RVA: 0x0006F337 File Offset: 0x0006D537
		public unsafe float VehicleCollisionAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionAngle) = value;
			}
		}

		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06004F63 RID: 20323 RVA: 0x0006F348 File Offset: 0x0006D548
		// (set) Token: 0x06004F64 RID: 20324 RVA: 0x0006F358 File Offset: 0x0006D558
		public unsafe float VehicleCollisionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleCollisionStrength) = value;
			}
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06004F65 RID: 20325 RVA: 0x0006F369 File Offset: 0x0006D569
		// (set) Token: 0x06004F66 RID: 20326 RVA: 0x0006F379 File Offset: 0x0006D579
		public unsafe float YawInPassengerCoordinate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_YawInPassengerCoordinate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_YawInPassengerCoordinate) = value;
			}
		}

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06004F67 RID: 20327 RVA: 0x0006F38A File Offset: 0x0006D58A
		// (set) Token: 0x06004F68 RID: 20328 RVA: 0x0006F39E File Offset: 0x0006D59E
		public unsafe FVector VehicleVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_VehicleVelocity) = value;
			}
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06004F69 RID: 20329 RVA: 0x0006F3B3 File Offset: 0x0006D5B3
		// (set) Token: 0x06004F6A RID: 20330 RVA: 0x0006F3C3 File Offset: 0x0006D5C3
		public unsafe bool bIsInPerformingPlot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInPerformingPlot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInPerformingPlot) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06004F6B RID: 20331 RVA: 0x0006F3D4 File Offset: 0x0006D5D4
		// (set) Token: 0x06004F6C RID: 20332 RVA: 0x0006F3E4 File Offset: 0x0006D5E4
		public unsafe bool bIsInSequence
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSequence) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSequence) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06004F6D RID: 20333 RVA: 0x0006F3F5 File Offset: 0x0006D5F5
		// (set) Token: 0x06004F6E RID: 20334 RVA: 0x0006F405 File Offset: 0x0006D605
		public unsafe bool bIsInSplineMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSplineMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInSplineMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06004F6F RID: 20335 RVA: 0x0006F416 File Offset: 0x0006D616
		// (set) Token: 0x06004F70 RID: 20336 RVA: 0x0006F426 File Offset: 0x0006D626
		public unsafe bool bIsInUiCamera
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInUiCamera) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsInUiCamera) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06004F71 RID: 20337 RVA: 0x0006F438 File Offset: 0x0006D638
		// (set) Token: 0x06004F72 RID: 20338 RVA: 0x0006F471 File Offset: 0x0006D671
		public FIKTarget LeftHandIKTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._LeftHandIKTargetCS) == null)
				{
					result = (this._LeftHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LeftHandIKTargetCS, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_LeftHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F50 RID: 3920
		// (get) Token: 0x06004F73 RID: 20339 RVA: 0x0006F494 File Offset: 0x0006D694
		// (set) Token: 0x06004F74 RID: 20340 RVA: 0x0006F4CD File Offset: 0x0006D6CD
		public FIKTarget RightHandIKTargetCS
		{
			get
			{
				base.FastCheckIsValid();
				FIKTarget result;
				if ((result = this._RightHandIKTargetCS) == null)
				{
					result = (this._RightHandIKTargetCS = new FIKTarget(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RightHandIKTargetCS, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FIKTarget.StaticStruct(), base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RightHandIKTargetCS, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F51 RID: 3921
		// (get) Token: 0x06004F75 RID: 20341 RVA: 0x0006F4EE File Offset: 0x0006D6EE
		// (set) Token: 0x06004F76 RID: 20342 RVA: 0x0006F4FE File Offset: 0x0006D6FE
		public unsafe bool bDisableBlink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bDisableBlink) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bDisableBlink) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F52 RID: 3922
		// (get) Token: 0x06004F77 RID: 20343 RVA: 0x0006F50F File Offset: 0x0006D70F
		// (set) Token: 0x06004F78 RID: 20344 RVA: 0x0006F51F File Offset: 0x0006D71F
		public unsafe bool bIgnoreMontageBlinkCurve
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIgnoreMontageBlinkCurve) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIgnoreMontageBlinkCurve) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F53 RID: 3923
		// (get) Token: 0x06004F79 RID: 20345 RVA: 0x0006F530 File Offset: 0x0006D730
		// (set) Token: 0x06004F7A RID: 20346 RVA: 0x0006F540 File Offset: 0x0006D740
		public unsafe bool bSwingState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSwingState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSwingState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F54 RID: 3924
		// (get) Token: 0x06004F7B RID: 20347 RVA: 0x0006F551 File Offset: 0x0006D751
		// (set) Token: 0x06004F7C RID: 20348 RVA: 0x0006F561 File Offset: 0x0006D761
		public unsafe ESwingStateType SwingStateType
		{
			get
			{
				return (ESwingStateType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SwingStateType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SwingStateType) = (byte)value;
			}
		}

		// Token: 0x17000F55 RID: 3925
		// (get) Token: 0x06004F7D RID: 20349 RVA: 0x0006F572 File Offset: 0x0006D772
		// (set) Token: 0x06004F7E RID: 20350 RVA: 0x0006F586 File Offset: 0x0006D786
		public unsafe FVector FloatingLocalDirectionRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingLocalDirectionRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingLocalDirectionRef) = value;
			}
		}

		// Token: 0x17000F56 RID: 3926
		// (get) Token: 0x06004F7F RID: 20351 RVA: 0x0006F59B File Offset: 0x0006D79B
		// (set) Token: 0x06004F80 RID: 20352 RVA: 0x0006F5AB File Offset: 0x0006D7AB
		public unsafe float FloatingMoveMixRef
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingMoveMixRef);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_FloatingMoveMixRef) = value;
			}
		}

		// Token: 0x17000F57 RID: 3927
		// (get) Token: 0x06004F81 RID: 20353 RVA: 0x0006F5BC File Offset: 0x0006D7BC
		// (set) Token: 0x06004F82 RID: 20354 RVA: 0x0006F5D0 File Offset: 0x0006D7D0
		public unsafe FVector HookTargetLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HookTargetLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_HookTargetLocation) = value;
			}
		}

		// Token: 0x17000F58 RID: 3928
		// (get) Token: 0x06004F83 RID: 20355 RVA: 0x0006F5E5 File Offset: 0x0006D7E5
		// (set) Token: 0x06004F84 RID: 20356 RVA: 0x0006F5F5 File Offset: 0x0006D7F5
		public unsafe bool bIsRailSlideMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsRailSlideMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsRailSlideMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F59 RID: 3929
		// (get) Token: 0x06004F85 RID: 20357 RVA: 0x0006F606 File Offset: 0x0006D806
		// (set) Token: 0x06004F86 RID: 20358 RVA: 0x0006F616 File Offset: 0x0006D816
		public unsafe ERailSlideAnimType RailSlideAnimType
		{
			get
			{
				return (ERailSlideAnimType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideAnimType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideAnimType) = (byte)value;
			}
		}

		// Token: 0x17000F5A RID: 3930
		// (get) Token: 0x06004F87 RID: 20359 RVA: 0x0006F627 File Offset: 0x0006D827
		// (set) Token: 0x06004F88 RID: 20360 RVA: 0x0006F637 File Offset: 0x0006D837
		public unsafe bool bIsAirRailSlideMove
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsAirRailSlideMove) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bIsAirRailSlideMove) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F5B RID: 3931
		// (get) Token: 0x06004F89 RID: 20361 RVA: 0x0006F648 File Offset: 0x0006D848
		// (set) Token: 0x06004F8A RID: 20362 RVA: 0x0006F658 File Offset: 0x0006D858
		public unsafe ERailSlideJumpType RailSlideJumpType
		{
			get
			{
				return (ERailSlideJumpType)(*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideJumpType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_RailSlideJumpType) = (byte)value;
			}
		}

		// Token: 0x17000F5C RID: 3932
		// (get) Token: 0x06004F8B RID: 20363 RVA: 0x0006F669 File Offset: 0x0006D869
		// (set) Token: 0x06004F8C RID: 20364 RVA: 0x0006F679 File Offset: 0x0006D879
		public unsafe bool bUseLandAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUseLandAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bUseLandAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F5D RID: 3933
		// (get) Token: 0x06004F8D RID: 20365 RVA: 0x0006F68A File Offset: 0x0006D88A
		// (set) Token: 0x06004F8E RID: 20366 RVA: 0x0006F69A File Offset: 0x0006D89A
		public unsafe bool bInAssistedWalking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bInAssistedWalking) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bInAssistedWalking) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F5E RID: 3934
		// (get) Token: 0x06004F8F RID: 20367 RVA: 0x0006F6AB File Offset: 0x0006D8AB
		// (set) Token: 0x06004F90 RID: 20368 RVA: 0x0006F6BB File Offset: 0x0006D8BB
		public unsafe bool bHelpedAssistedWalk
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bHelpedAssistedWalk) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bHelpedAssistedWalk) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F5F RID: 3935
		// (get) Token: 0x06004F91 RID: 20369 RVA: 0x0006F6CC File Offset: 0x0006D8CC
		// (set) Token: 0x06004F92 RID: 20370 RVA: 0x0006F6DC File Offset: 0x0006D8DC
		public unsafe bool bSkipEnterAssistedWalkAnim
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSkipEnterAssistedWalkAnim) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_bSkipEnterAssistedWalkAnim) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000F60 RID: 3936
		// (get) Token: 0x06004F93 RID: 20371 RVA: 0x0006F6ED File Offset: 0x0006D8ED
		// (set) Token: 0x06004F94 RID: 20372 RVA: 0x0006F6FD File Offset: 0x0006D8FD
		public unsafe float AssistedWalkAnimRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AssistedWalkAnimRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_AssistedWalkAnimRate) = value;
			}
		}

		// Token: 0x17000F61 RID: 3937
		// (get) Token: 0x06004F95 RID: 20373 RVA: 0x0006F70E File Offset: 0x0006D90E
		// (set) Token: 0x06004F96 RID: 20374 RVA: 0x0006F71E File Offset: 0x0006D91E
		public unsafe float SelfiePhotoArmAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SelfiePhotoArmAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAbpLogicParams.__PropertyOffset_SelfiePhotoArmAngle) = value;
			}
		}

		// Token: 0x06004F97 RID: 20375 RVA: 0x0006F72F File Offset: 0x0006D92F
		static UAbpLogicParams()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.AbpLogicParams");
		}

		// Token: 0x06004F98 RID: 20376 RVA: 0x0006F73D File Offset: 0x0006D93D
		protected UAbpLogicParams(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001FA1 RID: 8097
		public new const string __ObjectPath = "/Script/KuroAnim.AbpLogicParams";

		// Token: 0x04001FA2 RID: 8098
		private static IntPtr _ClassPtr;

		// Token: 0x04001FA3 RID: 8099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001FA4 RID: 8100
		internal static int __PropertyOffset_AcceptedNewBeHitRef;

		// Token: 0x04001FA5 RID: 8101
		internal static int __PropertyOffset_BeHitAnimRef;

		// Token: 0x04001FA6 RID: 8102
		internal static int __PropertyOffset_EnterFkRef;

		// Token: 0x04001FA7 RID: 8103
		internal static int __PropertyOffset_DoubleHitInAirRef;

		// Token: 0x04001FA8 RID: 8104
		internal static int __PropertyOffset_BeHitDirectRef;

		// Token: 0x04001FA9 RID: 8105
		internal static int __PropertyOffset_BeHitLocationRef;

		// Token: 0x04001FAA RID: 8106
		internal static int __PropertyOffset_BeHitSocketNameRef;

		// Token: 0x04001FAB RID: 8107
		internal static int __PropertyOffset_BeHitBoneRef;

		// Token: 0x04001FAC RID: 8108
		internal static int __PropertyOffset_HitInfo;

		// Token: 0x04001FAD RID: 8109
		[Nullable(2)]
		private FBoneFeedbackAnimHitInfo _HitInfo;

		// Token: 0x04001FAE RID: 8110
		internal static int __PropertyOffset_CharMoveStateRef;

		// Token: 0x04001FAF RID: 8111
		internal static int __PropertyOffset_CharPositionStateRef;

		// Token: 0x04001FB0 RID: 8112
		internal static int __PropertyOffset_CharCameraStateRef;

		// Token: 0x04001FB1 RID: 8113
		internal static int __PropertyOffset_BattleIdleTimeRef;

		// Token: 0x04001FB2 RID: 8114
		internal static int __PropertyOffset_DegMovementSlopeRef;

		// Token: 0x04001FB3 RID: 8115
		internal static int __PropertyOffset_SightDirectRef;

		// Token: 0x04001FB4 RID: 8116
		internal static int __PropertyOffset_RagQuitStateRef;

		// Token: 0x04001FB5 RID: 8117
		internal static int __PropertyOffset_IsJumpRef;

		// Token: 0x04001FB6 RID: 8118
		internal static int __PropertyOffset_AccelerationRef;

		// Token: 0x04001FB7 RID: 8119
		internal static int __PropertyOffset_IsMovingRef;

		// Token: 0x04001FB8 RID: 8120
		internal static int __PropertyOffset_SpeedRef;

		// Token: 0x04001FB9 RID: 8121
		internal static int __PropertyOffset_InputDirectRef;

		// Token: 0x04001FBA RID: 8122
		internal static int __PropertyOffset_InputRotatorRef;

		// Token: 0x04001FBB RID: 8123
		internal static int __PropertyOffset_bUpdateInputRotatorRef;

		// Token: 0x04001FBC RID: 8124
		internal static int __PropertyOffset_IsFallingIntoWaterRef;

		// Token: 0x04001FBD RID: 8125
		internal static int __PropertyOffset_GroundedTimeRef;

		// Token: 0x04001FBE RID: 8126
		internal static int __PropertyOffset_HasMoveInputRef;

		// Token: 0x04001FBF RID: 8127
		internal static int __PropertyOffset_ClimbInfoRef;

		// Token: 0x04001FC0 RID: 8128
		[Nullable(2)]
		private FClimbInfoStruct _ClimbInfoRef;

		// Token: 0x04001FC1 RID: 8129
		internal static int __PropertyOffset_ClimbStateRef;

		// Token: 0x04001FC2 RID: 8130
		[Nullable(2)]
		private FClimbStateStruct _ClimbStateRef;

		// Token: 0x04001FC3 RID: 8131
		internal static int __PropertyOffset_ClimbOnWallAngleRef;

		// Token: 0x04001FC4 RID: 8132
		internal static int __PropertyOffset_SprintSwimOffsetRef;

		// Token: 0x04001FC5 RID: 8133
		internal static int __PropertyOffset_SprintSwimOffsetLerpSpeedRef;

		// Token: 0x04001FC6 RID: 8134
		internal static int __PropertyOffset_SlideForwardRef;

		// Token: 0x04001FC7 RID: 8135
		internal static int __PropertyOffset_SlideSwitchThisFrameRef;

		// Token: 0x04001FC8 RID: 8136
		internal static int __PropertyOffset_SlideStandModeRef;

		// Token: 0x04001FC9 RID: 8137
		internal static int __PropertyOffset_JumpUpRateRef;

		// Token: 0x04001FCA RID: 8138
		internal static int __PropertyOffset_ForceExitStateStopRef;

		// Token: 0x04001FCB RID: 8139
		internal static int __PropertyOffset_SkillTarget;

		// Token: 0x04001FCC RID: 8140
		internal static int __PropertyOffset_HateTarget;

		// Token: 0x04001FCD RID: 8141
		internal static int __PropertyOffset_LastActiveSkillTime;

		// Token: 0x04001FCE RID: 8142
		internal static int __PropertyOffset_SitDownDirect;

		// Token: 0x04001FCF RID: 8143
		internal static int __PropertyOffset_StandUpDirect;

		// Token: 0x04001FD0 RID: 8144
		internal static int __PropertyOffset_bSitDown;

		// Token: 0x04001FD1 RID: 8145
		internal static int __PropertyOffset_SitDownType;

		// Token: 0x04001FD2 RID: 8146
		internal static int __PropertyOffset_IsDriver;

		// Token: 0x04001FD3 RID: 8147
		internal static int __PropertyOffset_IsOnVehicle;

		// Token: 0x04001FD4 RID: 8148
		internal static int __PropertyOffset_IsOnVehicleWithOther;

		// Token: 0x04001FD5 RID: 8149
		internal static int __PropertyOffset_IsLeavingVehicle;

		// Token: 0x04001FD6 RID: 8150
		internal static int __PropertyOffset_VehicleType;

		// Token: 0x04001FD7 RID: 8151
		internal static int __PropertyOffset_IsVehicleImpact;

		// Token: 0x04001FD8 RID: 8152
		internal static int __PropertyOffset_VehicleCollisionAngle;

		// Token: 0x04001FD9 RID: 8153
		internal static int __PropertyOffset_VehicleCollisionStrength;

		// Token: 0x04001FDA RID: 8154
		internal static int __PropertyOffset_YawInPassengerCoordinate;

		// Token: 0x04001FDB RID: 8155
		internal static int __PropertyOffset_VehicleVelocity;

		// Token: 0x04001FDC RID: 8156
		internal static int __PropertyOffset_bIsInPerformingPlot;

		// Token: 0x04001FDD RID: 8157
		internal static int __PropertyOffset_bIsInSequence;

		// Token: 0x04001FDE RID: 8158
		internal static int __PropertyOffset_bIsInSplineMove;

		// Token: 0x04001FDF RID: 8159
		internal static int __PropertyOffset_bIsInUiCamera;

		// Token: 0x04001FE0 RID: 8160
		internal static int __PropertyOffset_LeftHandIKTargetCS;

		// Token: 0x04001FE1 RID: 8161
		[Nullable(2)]
		private FIKTarget _LeftHandIKTargetCS;

		// Token: 0x04001FE2 RID: 8162
		internal static int __PropertyOffset_RightHandIKTargetCS;

		// Token: 0x04001FE3 RID: 8163
		[Nullable(2)]
		private FIKTarget _RightHandIKTargetCS;

		// Token: 0x04001FE4 RID: 8164
		internal static int __PropertyOffset_bDisableBlink;

		// Token: 0x04001FE5 RID: 8165
		internal static int __PropertyOffset_bIgnoreMontageBlinkCurve;

		// Token: 0x04001FE6 RID: 8166
		internal static int __PropertyOffset_bSwingState;

		// Token: 0x04001FE7 RID: 8167
		internal static int __PropertyOffset_SwingStateType;

		// Token: 0x04001FE8 RID: 8168
		internal static int __PropertyOffset_FloatingLocalDirectionRef;

		// Token: 0x04001FE9 RID: 8169
		internal static int __PropertyOffset_FloatingMoveMixRef;

		// Token: 0x04001FEA RID: 8170
		internal static int __PropertyOffset_HookTargetLocation;

		// Token: 0x04001FEB RID: 8171
		internal static int __PropertyOffset_bIsRailSlideMove;

		// Token: 0x04001FEC RID: 8172
		internal static int __PropertyOffset_RailSlideAnimType;

		// Token: 0x04001FED RID: 8173
		internal static int __PropertyOffset_bIsAirRailSlideMove;

		// Token: 0x04001FEE RID: 8174
		internal static int __PropertyOffset_RailSlideJumpType;

		// Token: 0x04001FEF RID: 8175
		internal static int __PropertyOffset_bUseLandAnimation;

		// Token: 0x04001FF0 RID: 8176
		internal static int __PropertyOffset_bInAssistedWalking;

		// Token: 0x04001FF1 RID: 8177
		internal static int __PropertyOffset_bHelpedAssistedWalk;

		// Token: 0x04001FF2 RID: 8178
		internal static int __PropertyOffset_bSkipEnterAssistedWalkAnim;

		// Token: 0x04001FF3 RID: 8179
		internal static int __PropertyOffset_AssistedWalkAnimRate;

		// Token: 0x04001FF4 RID: 8180
		internal static int __PropertyOffset_SelfiePhotoArmAngle;
	}
}
