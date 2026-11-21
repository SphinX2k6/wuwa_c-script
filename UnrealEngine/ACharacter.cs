using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A0 RID: 416
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Character")]
	[UnrealStructLayout(1808, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class ACharacter : APawn, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001C1F RID: 7199 RVA: 0x000299ED File Offset: 0x00027BED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACharacter._ClassPtr;
		}

		// Token: 0x06001C20 RID: 7200 RVA: 0x000299FC File Offset: 0x00027BFC
		public ACharacter() : this(BuiltinUtils.AllocNativeUObject(ACharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001C21 RID: 7201 RVA: 0x00029A24 File Offset: 0x00027C24
		[NullableContext(1)]
		public ACharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001C22 RID: 7202 RVA: 0x00029A57 File Offset: 0x00027C57
		// (set) Token: 0x06001C23 RID: 7203 RVA: 0x00029A6B File Offset: 0x00027C6B
		public unsafe USkeletalMeshComponent Mesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkeletalMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_Mesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_Mesh, value);
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001C24 RID: 7204 RVA: 0x00029A80 File Offset: 0x00027C80
		// (set) Token: 0x06001C25 RID: 7205 RVA: 0x00029A94 File Offset: 0x00027C94
		public unsafe UCharacterMovementComponent CharacterMovement
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCharacterMovementComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_CharacterMovement);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_CharacterMovement, value);
			}
		}

		// Token: 0x1700036F RID: 879
		// (get) Token: 0x06001C26 RID: 7206 RVA: 0x00029AA9 File Offset: 0x00027CA9
		// (set) Token: 0x06001C27 RID: 7207 RVA: 0x00029ABD File Offset: 0x00027CBD
		public unsafe UCapsuleComponent CapsuleComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCapsuleComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_CapsuleComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ACharacter.__PropertyOffset_CapsuleComponent, value);
			}
		}

		// Token: 0x17000370 RID: 880
		// (get) Token: 0x06001C28 RID: 7208 RVA: 0x00029AD4 File Offset: 0x00027CD4
		// (set) Token: 0x06001C29 RID: 7209 RVA: 0x00029B0D File Offset: 0x00027D0D
		[Nullable(1)]
		public FBasedMovementInfo BasedMovement
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBasedMovementInfo result;
				if ((result = this._BasedMovement) == null)
				{
					result = (this._BasedMovement = new FBasedMovementInfo(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BasedMovement, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBasedMovementInfo.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BasedMovement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001C2A RID: 7210 RVA: 0x00029B30 File Offset: 0x00027D30
		// (set) Token: 0x06001C2B RID: 7211 RVA: 0x00029B69 File Offset: 0x00027D69
		[Nullable(1)]
		public FBasedMovementInfo ReplicatedBasedMovement
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FBasedMovementInfo result;
				if ((result = this._ReplicatedBasedMovement) == null)
				{
					result = (this._ReplicatedBasedMovement = new FBasedMovementInfo(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedBasedMovement, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBasedMovementInfo.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedBasedMovement, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001C2C RID: 7212 RVA: 0x00029B8A File Offset: 0x00027D8A
		// (set) Token: 0x06001C2D RID: 7213 RVA: 0x00029B9A File Offset: 0x00027D9A
		public unsafe float AnimRootMotionTranslationScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_AnimRootMotionTranslationScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_AnimRootMotionTranslationScale) = value;
			}
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001C2E RID: 7214 RVA: 0x00029BAB File Offset: 0x00027DAB
		// (set) Token: 0x06001C2F RID: 7215 RVA: 0x00029BBF File Offset: 0x00027DBF
		public unsafe FVector BaseTranslationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BaseTranslationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BaseTranslationOffset) = value;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00029BD4 File Offset: 0x00027DD4
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00029BE8 File Offset: 0x00027DE8
		public unsafe FQuat BaseRotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BaseRotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_BaseRotationOffset) = value;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00029BFD File Offset: 0x00027DFD
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00029C0D File Offset: 0x00027E0D
		public unsafe float ReplicatedServerLastTransformUpdateTimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedServerLastTransformUpdateTimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedServerLastTransformUpdateTimeStamp) = value;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001C34 RID: 7220 RVA: 0x00029C1E File Offset: 0x00027E1E
		// (set) Token: 0x06001C35 RID: 7221 RVA: 0x00029C2E File Offset: 0x00027E2E
		public unsafe float ReplayLastTransformUpdateTimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplayLastTransformUpdateTimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplayLastTransformUpdateTimeStamp) = value;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001C36 RID: 7222 RVA: 0x00029C3F File Offset: 0x00027E3F
		// (set) Token: 0x06001C37 RID: 7223 RVA: 0x00029C4F File Offset: 0x00027E4F
		public unsafe byte ReplicatedMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ReplicatedMovementMode) = value;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001C38 RID: 7224 RVA: 0x00029C60 File Offset: 0x00027E60
		// (set) Token: 0x06001C39 RID: 7225 RVA: 0x00029C70 File Offset: 0x00027E70
		public unsafe bool bInBaseReplication
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bInBaseReplication) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bInBaseReplication) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000379 RID: 889
		// (get) Token: 0x06001C3A RID: 7226 RVA: 0x00029C81 File Offset: 0x00027E81
		// (set) Token: 0x06001C3B RID: 7227 RVA: 0x00029C91 File Offset: 0x00027E91
		public unsafe float CrouchedEyeHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_CrouchedEyeHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_CrouchedEyeHeight) = value;
			}
		}

		// Token: 0x1700037A RID: 890
		// (get) Token: 0x06001C3C RID: 7228 RVA: 0x00029CA2 File Offset: 0x00027EA2
		// (set) Token: 0x06001C3D RID: 7229 RVA: 0x00029CBB File Offset: 0x00027EBB
		public unsafe bool bIsCrouched
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bIsCrouched) & ACharacter.__PropertyMask_bIsCrouched) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bIsCrouched) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bIsCrouched) & ~ACharacter.__PropertyMask_bIsCrouched) | (value ? ACharacter.__PropertyMask_bIsCrouched : 0));
			}
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001C3E RID: 7230 RVA: 0x00029CEB File Offset: 0x00027EEB
		// (set) Token: 0x06001C3F RID: 7231 RVA: 0x00029D04 File Offset: 0x00027F04
		public unsafe bool bProxyIsJumpForceApplied
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bProxyIsJumpForceApplied) & ACharacter.__PropertyMask_bProxyIsJumpForceApplied) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bProxyIsJumpForceApplied) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bProxyIsJumpForceApplied) & ~ACharacter.__PropertyMask_bProxyIsJumpForceApplied) | (value ? ACharacter.__PropertyMask_bProxyIsJumpForceApplied : 0));
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001C40 RID: 7232 RVA: 0x00029D34 File Offset: 0x00027F34
		// (set) Token: 0x06001C41 RID: 7233 RVA: 0x00029D4D File Offset: 0x00027F4D
		public unsafe bool bPressedJump
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bPressedJump) & ACharacter.__PropertyMask_bPressedJump) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bPressedJump) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bPressedJump) & ~ACharacter.__PropertyMask_bPressedJump) | (value ? ACharacter.__PropertyMask_bPressedJump : 0));
			}
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001C42 RID: 7234 RVA: 0x00029D7D File Offset: 0x00027F7D
		// (set) Token: 0x06001C43 RID: 7235 RVA: 0x00029D96 File Offset: 0x00027F96
		public unsafe bool bClientUpdating
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientUpdating) & ACharacter.__PropertyMask_bClientUpdating) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientUpdating) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientUpdating) & ~ACharacter.__PropertyMask_bClientUpdating) | (value ? ACharacter.__PropertyMask_bClientUpdating : 0));
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001C44 RID: 7236 RVA: 0x00029DC6 File Offset: 0x00027FC6
		// (set) Token: 0x06001C45 RID: 7237 RVA: 0x00029DDF File Offset: 0x00027FDF
		public unsafe bool bClientWasFalling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientWasFalling) & ACharacter.__PropertyMask_bClientWasFalling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientWasFalling) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientWasFalling) & ~ACharacter.__PropertyMask_bClientWasFalling) | (value ? ACharacter.__PropertyMask_bClientWasFalling : 0));
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001C46 RID: 7238 RVA: 0x00029E0F File Offset: 0x0002800F
		// (set) Token: 0x06001C47 RID: 7239 RVA: 0x00029E28 File Offset: 0x00028028
		public unsafe bool bClientResimulateRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotion) & ACharacter.__PropertyMask_bClientResimulateRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotion) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotion) & ~ACharacter.__PropertyMask_bClientResimulateRootMotion) | (value ? ACharacter.__PropertyMask_bClientResimulateRootMotion : 0));
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001C48 RID: 7240 RVA: 0x00029E58 File Offset: 0x00028058
		// (set) Token: 0x06001C49 RID: 7241 RVA: 0x00029E71 File Offset: 0x00028071
		public unsafe bool bClientResimulateRootMotionSources
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotionSources) & ACharacter.__PropertyMask_bClientResimulateRootMotionSources) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotionSources) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientResimulateRootMotionSources) & ~ACharacter.__PropertyMask_bClientResimulateRootMotionSources) | (value ? ACharacter.__PropertyMask_bClientResimulateRootMotionSources : 0));
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00029EA1 File Offset: 0x000280A1
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x00029EBA File Offset: 0x000280BA
		public unsafe bool bSimGravityDisabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bSimGravityDisabled) & ACharacter.__PropertyMask_bSimGravityDisabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bSimGravityDisabled) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bSimGravityDisabled) & ~ACharacter.__PropertyMask_bSimGravityDisabled) | (value ? ACharacter.__PropertyMask_bSimGravityDisabled : 0));
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x00029EEA File Offset: 0x000280EA
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00029F03 File Offset: 0x00028103
		public unsafe bool bClientCheckEncroachmentOnNetUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientCheckEncroachmentOnNetUpdate) & ACharacter.__PropertyMask_bClientCheckEncroachmentOnNetUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientCheckEncroachmentOnNetUpdate) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bClientCheckEncroachmentOnNetUpdate) & ~ACharacter.__PropertyMask_bClientCheckEncroachmentOnNetUpdate) | (value ? ACharacter.__PropertyMask_bClientCheckEncroachmentOnNetUpdate : 0));
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00029F33 File Offset: 0x00028133
		// (set) Token: 0x06001C4F RID: 7247 RVA: 0x00029F4C File Offset: 0x0002814C
		public unsafe bool bServerMoveIgnoreRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bServerMoveIgnoreRootMotion) & ACharacter.__PropertyMask_bServerMoveIgnoreRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bServerMoveIgnoreRootMotion) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bServerMoveIgnoreRootMotion) & ~ACharacter.__PropertyMask_bServerMoveIgnoreRootMotion) | (value ? ACharacter.__PropertyMask_bServerMoveIgnoreRootMotion : 0));
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00029F7C File Offset: 0x0002817C
		// (set) Token: 0x06001C51 RID: 7249 RVA: 0x00029F95 File Offset: 0x00028195
		public unsafe bool bWasJumping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bWasJumping) & ACharacter.__PropertyMask_bWasJumping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ACharacter.__PropertyOffset_bWasJumping) = ((*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_bWasJumping) & ~ACharacter.__PropertyMask_bWasJumping) | (value ? ACharacter.__PropertyMask_bWasJumping : 0));
			}
		}

		// Token: 0x17000385 RID: 901
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00029FC5 File Offset: 0x000281C5
		// (set) Token: 0x06001C53 RID: 7251 RVA: 0x00029FD5 File Offset: 0x000281D5
		public unsafe float JumpKeyHoldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpKeyHoldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpKeyHoldTime) = value;
			}
		}

		// Token: 0x17000386 RID: 902
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00029FE6 File Offset: 0x000281E6
		// (set) Token: 0x06001C55 RID: 7253 RVA: 0x00029FF6 File Offset: 0x000281F6
		public unsafe float JumpForceTimeRemaining
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpForceTimeRemaining);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpForceTimeRemaining) = value;
			}
		}

		// Token: 0x17000387 RID: 903
		// (get) Token: 0x06001C56 RID: 7254 RVA: 0x0002A007 File Offset: 0x00028207
		// (set) Token: 0x06001C57 RID: 7255 RVA: 0x0002A017 File Offset: 0x00028217
		public unsafe float ProxyJumpForceStartedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ProxyJumpForceStartedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ProxyJumpForceStartedTime) = value;
			}
		}

		// Token: 0x17000388 RID: 904
		// (get) Token: 0x06001C58 RID: 7256 RVA: 0x0002A028 File Offset: 0x00028228
		// (set) Token: 0x06001C59 RID: 7257 RVA: 0x0002A038 File Offset: 0x00028238
		public unsafe float JumpMaxHoldTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpMaxHoldTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpMaxHoldTime) = value;
			}
		}

		// Token: 0x17000389 RID: 905
		// (get) Token: 0x06001C5A RID: 7258 RVA: 0x0002A049 File Offset: 0x00028249
		// (set) Token: 0x06001C5B RID: 7259 RVA: 0x0002A059 File Offset: 0x00028259
		public unsafe int JumpMaxCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpMaxCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpMaxCount) = value;
			}
		}

		// Token: 0x1700038A RID: 906
		// (get) Token: 0x06001C5C RID: 7260 RVA: 0x0002A06A File Offset: 0x0002826A
		// (set) Token: 0x06001C5D RID: 7261 RVA: 0x0002A07A File Offset: 0x0002827A
		public unsafe int JumpCurrentCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpCurrentCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpCurrentCount) = value;
			}
		}

		// Token: 0x1700038B RID: 907
		// (get) Token: 0x06001C5E RID: 7262 RVA: 0x0002A08B File Offset: 0x0002828B
		// (set) Token: 0x06001C5F RID: 7263 RVA: 0x0002A09B File Offset: 0x0002829B
		public unsafe int JumpCurrentCountPreJump
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpCurrentCountPreJump);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_JumpCurrentCountPreJump) = value;
			}
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x06001C60 RID: 7264 RVA: 0x0002A0AC File Offset: 0x000282AC
		// (set) Token: 0x06001C61 RID: 7265 RVA: 0x0002A0E5 File Offset: 0x000282E5
		[Nullable(1)]
		public FCharacterReachedApexSignature OnReachedJumpApex
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCharacterReachedApexSignature result;
				if ((result = this._OnReachedJumpApex) == null)
				{
					result = (this._OnReachedJumpApex = new FCharacterReachedApexSignature(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_OnReachedJumpApex, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_OnReachedJumpApex, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06001C62 RID: 7266 RVA: 0x0002A108 File Offset: 0x00028308
		// (set) Token: 0x06001C63 RID: 7267 RVA: 0x0002A141 File Offset: 0x00028341
		[Nullable(1)]
		public FMovementModeChangedSignature MovementModeChangedDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FMovementModeChangedSignature result;
				if ((result = this._MovementModeChangedDelegate) == null)
				{
					result = (this._MovementModeChangedDelegate = new FMovementModeChangedSignature(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_MovementModeChangedDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_MovementModeChangedDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0002A164 File Offset: 0x00028364
		// (set) Token: 0x06001C65 RID: 7269 RVA: 0x0002A19D File Offset: 0x0002839D
		[Nullable(1)]
		public FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FCharacterMovementUpdatedSignature result;
				if ((result = this._OnCharacterMovementUpdated) == null)
				{
					result = (this._OnCharacterMovementUpdated = new FCharacterMovementUpdatedSignature(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_OnCharacterMovementUpdated, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_OnCharacterMovementUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001C66 RID: 7270 RVA: 0x0002A1C0 File Offset: 0x000283C0
		// (set) Token: 0x06001C67 RID: 7271 RVA: 0x0002A1F9 File Offset: 0x000283F9
		[Nullable(1)]
		public FRootMotionMovementParams ClientRootMotionParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRootMotionMovementParams result;
				if ((result = this._ClientRootMotionParams) == null)
				{
					result = (this._ClientRootMotionParams = new FRootMotionMovementParams(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ClientRootMotionParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_ClientRootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x0002A21A File Offset: 0x0002841A
		public void UnCrouch(bool bClientSimulation = false)
		{
			ACharacter.__UnCrouch_Internal(base.NativePtr, bClientSimulation);
		}

		// Token: 0x06001C69 RID: 7273 RVA: 0x0002A228 File Offset: 0x00028428
		public void StopJumping()
		{
			ACharacter.__StopJumping_Internal(base.NativePtr);
		}

		// Token: 0x06001C6A RID: 7274 RVA: 0x0002A235 File Offset: 0x00028435
		public void StopAnimMontage(UAnimMontage AnimMontage = null)
		{
			ACharacter.__StopAnimMontage_Internal(base.NativePtr, (AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001C6B RID: 7275 RVA: 0x0002A252 File Offset: 0x00028452
		public void SetKuroReplicatedMovementMode(byte Mode)
		{
			ACharacter.__SetKuroReplicatedMovementMode_Internal(base.NativePtr, Mode);
		}

		// Token: 0x06001C6C RID: 7276 RVA: 0x0002A260 File Offset: 0x00028460
		public void SetAnimRootMotionTranslationScale(float InAnimRootMotionTranslationScale = 1f)
		{
			ACharacter.__SetAnimRootMotionTranslationScale_Internal(base.NativePtr, InAnimRootMotionTranslationScale);
		}

		// Token: 0x06001C6D RID: 7277 RVA: 0x0002A26E File Offset: 0x0002846E
		public void ServerMoveOld(float OldTimeStamp, FVector_NetQuantize10 OldAccel, byte OldMoveFlags)
		{
			ACharacter.__ServerMoveOld_Internal(base.NativePtr, OldTimeStamp, OldAccel, OldMoveFlags);
		}

		// Token: 0x06001C6E RID: 7278 RVA: 0x0002A27E File Offset: 0x0002847E
		public void ServerMoveNoBase(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveNoBase_Internal(base.NativePtr, TimeStamp, InAccel, ClientLoc, CompressedMoveFlags, ClientRoll, View, ClientMovementMode);
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x0002A298 File Offset: 0x00028498
		public void ServerMoveDualNoBase(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDualNoBase_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, ClientMovementMode);
		}

		// Token: 0x06001C70 RID: 7280 RVA: 0x0002A2C4 File Offset: 0x000284C4
		public void ServerMoveDualHybridRootMotion(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDualHybridRootMotion_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x06001C71 RID: 7281 RVA: 0x0002A304 File Offset: 0x00028504
		public void ServerMoveDual(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDual_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x06001C72 RID: 7282 RVA: 0x0002A344 File Offset: 0x00028544
		public void ServerMove(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMove_Internal(base.NativePtr, TimeStamp, InAccel, ClientLoc, CompressedMoveFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x06001C73 RID: 7283 RVA: 0x0002A37C File Offset: 0x0002857C
		[NullableContext(1)]
		public unsafe void RootMotionDebugClientPrintOnScreen(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			ACharacter.__RootMotionDebugClientPrintOnScreen_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06001C74 RID: 7284 RVA: 0x0002A3A6 File Offset: 0x000285A6
		public float PlayAnimMontage(UAnimMontage AnimMontage, float InPlayRate = 1f, FName StartSectionName = default(FName))
		{
			return ACharacter.__PlayAnimMontage_Internal(base.NativePtr, (AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, InPlayRate, StartSectionName);
		}

		// Token: 0x06001C75 RID: 7285 RVA: 0x0002A3C5 File Offset: 0x000285C5
		public virtual void OnWalkingOffLedge(in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta)
		{
			ACharacter.__OnWalkingOffLedge_Internal(base.NativePtr, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		}

		// Token: 0x06001C76 RID: 7286 RVA: 0x0002A3D7 File Offset: 0x000285D7
		protected virtual void OnWalkingOffLedge_Implementation(in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta)
		{
			ACharacter.__OnWalkingOffLedge_Implementation_Internal(base.NativePtr, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		}

		// Token: 0x06001C77 RID: 7287 RVA: 0x0002A3E9 File Offset: 0x000285E9
		public void OnRep_RootMotion()
		{
			ACharacter.__OnRep_RootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06001C78 RID: 7288 RVA: 0x0002A3F6 File Offset: 0x000285F6
		public void OnRep_ReplicatedBasedMovement()
		{
			ACharacter.__OnRep_ReplicatedBasedMovement_Internal(base.NativePtr);
		}

		// Token: 0x06001C79 RID: 7289 RVA: 0x0002A403 File Offset: 0x00028603
		public void OnRep_ReplayLastTransformUpdateTimeStamp()
		{
			ACharacter.__OnRep_ReplayLastTransformUpdateTimeStamp_Internal(base.NativePtr);
		}

		// Token: 0x06001C7A RID: 7290 RVA: 0x0002A410 File Offset: 0x00028610
		public void OnRep_KuroRootMotion()
		{
			ACharacter.__OnRep_KuroRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06001C7B RID: 7291 RVA: 0x0002A41D File Offset: 0x0002861D
		public void OnRep_IsCrouched()
		{
			ACharacter.__OnRep_IsCrouched_Internal(base.NativePtr);
		}

		// Token: 0x06001C7C RID: 7292 RVA: 0x0002A42A File Offset: 0x0002862A
		public virtual void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			ACharacter.__OnLaunched_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x06001C7D RID: 7293 RVA: 0x0002A43A File Offset: 0x0002863A
		public virtual void OnLanded(in FHitResult Hit)
		{
			ACharacter.__OnLanded_Internal(base.NativePtr, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x0002A457 File Offset: 0x00028657
		public virtual void OnJumped()
		{
			ACharacter.__OnJumped_Internal(base.NativePtr);
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x0002A464 File Offset: 0x00028664
		protected virtual void OnJumped_Implementation()
		{
			ACharacter.__OnJumped_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x0002A471 File Offset: 0x00028671
		public void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			ACharacter.__LaunchCharacter_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x0002A481 File Offset: 0x00028681
		public void KuroPreNetReceive()
		{
			ACharacter.__KuroPreNetReceive_Internal(base.NativePtr);
		}

		// Token: 0x06001C82 RID: 7298 RVA: 0x0002A48E File Offset: 0x0002868E
		public void KuroPostNetReceive()
		{
			ACharacter.__KuroPostNetReceive_Internal(base.NativePtr);
		}

		// Token: 0x06001C83 RID: 7299 RVA: 0x0002A49B File Offset: 0x0002869B
		public void Kuro_OnRep_ReplicatedBasedMovement()
		{
			ACharacter.__Kuro_OnRep_ReplicatedBasedMovement_Internal(base.NativePtr);
		}

		// Token: 0x06001C84 RID: 7300 RVA: 0x0002A4A8 File Offset: 0x000286A8
		public bool Kuro_IsJumpProvidingForce()
		{
			return ACharacter.__Kuro_IsJumpProvidingForce_Internal(base.NativePtr);
		}

		// Token: 0x06001C85 RID: 7301 RVA: 0x0002A4B5 File Offset: 0x000286B5
		public virtual void K2_UpdateCustomMovement(float DeltaTime)
		{
			ACharacter.__K2_UpdateCustomMovement_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06001C86 RID: 7302 RVA: 0x0002A4C3 File Offset: 0x000286C3
		public virtual void K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			ACharacter.__K2_OnStartCrouch_Internal(base.NativePtr, HalfHeightAdjust, ScaledHalfHeightAdjust);
		}

		// Token: 0x06001C87 RID: 7303 RVA: 0x0002A4D2 File Offset: 0x000286D2
		public virtual void K2_OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
		{
			ACharacter.__K2_OnMovementModeChanged_Internal(base.NativePtr, PrevMovementMode, NewMovementMode, PrevCustomMode, NewCustomMode);
		}

		// Token: 0x06001C88 RID: 7304 RVA: 0x0002A4EE File Offset: 0x000286EE
		public virtual void K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			ACharacter.__K2_OnEndCrouch_Internal(base.NativePtr, HalfHeightAdjust, ScaledHalfHeightAdjust);
		}

		// Token: 0x06001C89 RID: 7305 RVA: 0x0002A4FD File Offset: 0x000286FD
		public void Jump()
		{
			ACharacter.__Jump_Internal(base.NativePtr);
		}

		// Token: 0x06001C8A RID: 7306 RVA: 0x0002A50A File Offset: 0x0002870A
		public bool IsPlayingRootMotion()
		{
			return ACharacter.__IsPlayingRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06001C8B RID: 7307 RVA: 0x0002A517 File Offset: 0x00028717
		public bool IsPlayingNetworkedRootMotionMontage()
		{
			return ACharacter.__IsPlayingNetworkedRootMotionMontage_Internal(base.NativePtr);
		}

		// Token: 0x06001C8C RID: 7308 RVA: 0x0002A524 File Offset: 0x00028724
		public bool IsKuroForceFlying()
		{
			return ACharacter.__IsKuroForceFlying_Internal(base.NativePtr);
		}

		// Token: 0x06001C8D RID: 7309 RVA: 0x0002A531 File Offset: 0x00028731
		public bool IsJumpProvidingForce()
		{
			return ACharacter.__IsJumpProvidingForce_Internal(base.NativePtr);
		}

		// Token: 0x06001C8E RID: 7310 RVA: 0x0002A53E File Offset: 0x0002873E
		public bool HasAnyRootMotion()
		{
			return ACharacter.__HasAnyRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06001C8F RID: 7311 RVA: 0x0002A54B File Offset: 0x0002874B
		public byte GetKuroReplicatedMovementMode()
		{
			return ACharacter.__GetKuroReplicatedMovementMode_Internal(base.NativePtr);
		}

		// Token: 0x06001C90 RID: 7312 RVA: 0x0002A558 File Offset: 0x00028758
		public UAnimMontage GetCurrentMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(ACharacter.__GetCurrentMontage_Internal(base.NativePtr));
		}

		// Token: 0x06001C91 RID: 7313 RVA: 0x0002A56A File Offset: 0x0002876A
		public FVector GetBaseTranslationOffset()
		{
			return ACharacter.__GetBaseTranslationOffset_Internal(base.NativePtr);
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x0002A577 File Offset: 0x00028777
		public FRotator GetBaseRotationOffsetRotator()
		{
			return ACharacter.__GetBaseRotationOffsetRotator_Internal(base.NativePtr);
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x0002A584 File Offset: 0x00028784
		public float GetAnimRootMotionTranslationScale()
		{
			return ACharacter.__GetAnimRootMotionTranslationScale_Internal(base.NativePtr);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x0002A591 File Offset: 0x00028791
		public void Crouch(bool bClientSimulation = false)
		{
			ACharacter.__Crouch_Internal(base.NativePtr, bClientSimulation);
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x0002A59F File Offset: 0x0002879F
		public void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientVeryShortAdjustPosition_Internal(base.NativePtr, TimeStamp, NewLoc, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x0002A5C6 File Offset: 0x000287C6
		public void ClientCheatWalk()
		{
			ACharacter.__ClientCheatWalk_Internal(base.NativePtr);
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x0002A5D3 File Offset: 0x000287D3
		public void ClientCheatGhost()
		{
			ACharacter.__ClientCheatGhost_Internal(base.NativePtr);
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x0002A5E0 File Offset: 0x000287E0
		public void ClientCheatFly()
		{
			ACharacter.__ClientCheatFly_Internal(base.NativePtr);
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x0002A5F0 File Offset: 0x000287F0
		public void ClientAdjustRootMotionPosition(float TimeStamp, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, UPrimitiveComponent ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientAdjustRootMotionPosition_Internal(base.NativePtr, TimeStamp, ServerMontageTrackPosition, ServerLoc, ServerRotation, ServerVelZ, (ServerBase != null) ? ServerBase.NativePtr : IntPtr.Zero, ServerBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x06001C9A RID: 7322 RVA: 0x0002A62C File Offset: 0x0002882C
		public void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientAdjustPosition_Internal(base.NativePtr, TimeStamp, NewLoc, NewVel, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x06001C9B RID: 7323 RVA: 0x0002A661 File Offset: 0x00028861
		public void ClientAckGoodMove(float TimeStamp)
		{
			ACharacter.__ClientAckGoodMove_Internal(base.NativePtr, TimeStamp);
		}

		// Token: 0x06001C9C RID: 7324 RVA: 0x0002A66F File Offset: 0x0002886F
		public virtual bool CanJumpInternal()
		{
			return ACharacter.__CanJumpInternal_Internal(base.NativePtr);
		}

		// Token: 0x06001C9D RID: 7325 RVA: 0x0002A67C File Offset: 0x0002887C
		protected virtual bool CanJumpInternal_Implementation()
		{
			return ACharacter.__CanJumpInternal_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0002A689 File Offset: 0x00028889
		public bool CanJump()
		{
			return ACharacter.__CanJump_Internal(base.NativePtr);
		}

		// Token: 0x06001C9F RID: 7327 RVA: 0x0002A696 File Offset: 0x00028896
		public bool CanCrouch()
		{
			return ACharacter.__CanCrouch_Internal(base.NativePtr);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x0002A6A3 File Offset: 0x000288A3
		public void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
		{
			ACharacter.__CacheInitialMeshOffset_Internal(base.NativePtr, MeshRelativeLocation, MeshRelativeRotation);
		}

		// Token: 0x06001CA1 RID: 7329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnCrouch_Internal(IntPtr @this, bool bClientSimulation);

		// Token: 0x06001CA2 RID: 7330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopJumping_Internal(IntPtr @this);

		// Token: 0x06001CA3 RID: 7331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimMontage_Internal(IntPtr @this, IntPtr AnimMontage);

		// Token: 0x06001CA4 RID: 7332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroReplicatedMovementMode_Internal(IntPtr @this, byte Mode);

		// Token: 0x06001CA5 RID: 7333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimRootMotionTranslationScale_Internal(IntPtr @this, float InAnimRootMotionTranslationScale);

		// Token: 0x06001CA6 RID: 7334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveOld_Internal(IntPtr @this, float OldTimeStamp, FVector_NetQuantize10 OldAccel, byte OldMoveFlags);

		// Token: 0x06001CA7 RID: 7335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveNoBase_Internal(IntPtr @this, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, byte ClientMovementMode);

		// Token: 0x06001CA8 RID: 7336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDualNoBase_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, byte ClientMovementMode);

		// Token: 0x06001CA9 RID: 7337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDualHybridRootMotion_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x06001CAA RID: 7338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDual_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x06001CAB RID: 7339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMove_Internal(IntPtr @this, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x06001CAC RID: 7340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RootMotionDebugClientPrintOnScreen_Internal(IntPtr @this, in FString InString);

		// Token: 0x06001CAD RID: 7341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PlayAnimMontage_Internal(IntPtr @this, IntPtr AnimMontage, float InPlayRate, FName StartSectionName);

		// Token: 0x06001CAE RID: 7342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWalkingOffLedge_Internal(IntPtr @this, in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta);

		// Token: 0x06001CAF RID: 7343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWalkingOffLedge_Implementation_Internal(IntPtr @this, in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta);

		// Token: 0x06001CB0 RID: 7344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_RootMotion_Internal(IntPtr @this);

		// Token: 0x06001CB1 RID: 7345
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedBasedMovement_Internal(IntPtr @this);

		// Token: 0x06001CB2 RID: 7346
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplayLastTransformUpdateTimeStamp_Internal(IntPtr @this);

		// Token: 0x06001CB3 RID: 7347
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_KuroRootMotion_Internal(IntPtr @this);

		// Token: 0x06001CB4 RID: 7348
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_IsCrouched_Internal(IntPtr @this);

		// Token: 0x06001CB5 RID: 7349
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLaunched_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x06001CB6 RID: 7350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLanded_Internal(IntPtr @this, IntPtr Hit);

		// Token: 0x06001CB7 RID: 7351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnJumped_Internal(IntPtr @this);

		// Token: 0x06001CB8 RID: 7352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnJumped_Implementation_Internal(IntPtr @this);

		// Token: 0x06001CB9 RID: 7353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchCharacter_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x06001CBA RID: 7354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPreNetReceive_Internal(IntPtr @this);

		// Token: 0x06001CBB RID: 7355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPostNetReceive_Internal(IntPtr @this);

		// Token: 0x06001CBC RID: 7356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_OnRep_ReplicatedBasedMovement_Internal(IntPtr @this);

		// Token: 0x06001CBD RID: 7357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Kuro_IsJumpProvidingForce_Internal(IntPtr @this);

		// Token: 0x06001CBE RID: 7358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UpdateCustomMovement_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06001CBF RID: 7359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnStartCrouch_Internal(IntPtr @this, float HalfHeightAdjust, float ScaledHalfHeightAdjust);

		// Token: 0x06001CC0 RID: 7360
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnMovementModeChanged_Internal(IntPtr @this, TEnumAsByte<EMovementMode> PrevMovementMode, TEnumAsByte<EMovementMode> NewMovementMode, byte PrevCustomMode, byte NewCustomMode);

		// Token: 0x06001CC1 RID: 7361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndCrouch_Internal(IntPtr @this, float HalfHeightAdjust, float ScaledHalfHeightAdjust);

		// Token: 0x06001CC2 RID: 7362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Jump_Internal(IntPtr @this);

		// Token: 0x06001CC3 RID: 7363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingRootMotion_Internal(IntPtr @this);

		// Token: 0x06001CC4 RID: 7364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingNetworkedRootMotionMontage_Internal(IntPtr @this);

		// Token: 0x06001CC5 RID: 7365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsKuroForceFlying_Internal(IntPtr @this);

		// Token: 0x06001CC6 RID: 7366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsJumpProvidingForce_Internal(IntPtr @this);

		// Token: 0x06001CC7 RID: 7367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyRootMotion_Internal(IntPtr @this);

		// Token: 0x06001CC8 RID: 7368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetKuroReplicatedMovementMode_Internal(IntPtr @this);

		// Token: 0x06001CC9 RID: 7369
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentMontage_Internal(IntPtr @this);

		// Token: 0x06001CCA RID: 7370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetBaseTranslationOffset_Internal(IntPtr @this);

		// Token: 0x06001CCB RID: 7371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBaseRotationOffsetRotator_Internal(IntPtr @this);

		// Token: 0x06001CCC RID: 7372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimRootMotionTranslationScale_Internal(IntPtr @this);

		// Token: 0x06001CCD RID: 7373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Crouch_Internal(IntPtr @this, bool bClientSimulation);

		// Token: 0x06001CCE RID: 7374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientVeryShortAdjustPosition_Internal(IntPtr @this, float TimeStamp, FVector NewLoc, IntPtr NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x06001CCF RID: 7375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatWalk_Internal(IntPtr @this);

		// Token: 0x06001CD0 RID: 7376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatGhost_Internal(IntPtr @this);

		// Token: 0x06001CD1 RID: 7377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatFly_Internal(IntPtr @this);

		// Token: 0x06001CD2 RID: 7378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAdjustRootMotionPosition_Internal(IntPtr @this, float TimeStamp, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, IntPtr ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x06001CD3 RID: 7379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAdjustPosition_Internal(IntPtr @this, float TimeStamp, FVector NewLoc, FVector NewVel, IntPtr NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x06001CD4 RID: 7380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAckGoodMove_Internal(IntPtr @this, float TimeStamp);

		// Token: 0x06001CD5 RID: 7381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJumpInternal_Internal(IntPtr @this);

		// Token: 0x06001CD6 RID: 7382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJumpInternal_Implementation_Internal(IntPtr @this);

		// Token: 0x06001CD7 RID: 7383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJump_Internal(IntPtr @this);

		// Token: 0x06001CD8 RID: 7384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCrouch_Internal(IntPtr @this);

		// Token: 0x06001CD9 RID: 7385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CacheInitialMeshOffset_Internal(IntPtr @this, FVector MeshRelativeLocation, FRotator MeshRelativeRotation);

		// Token: 0x06001CDA RID: 7386 RVA: 0x0002A6B2 File Offset: 0x000288B2
		static ACharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Character");
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x0002A6C0 File Offset: 0x000288C0
		protected ACharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000923 RID: 2339
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Character";

		// Token: 0x04000924 RID: 2340
		private static IntPtr _ClassPtr;

		// Token: 0x04000925 RID: 2341
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000926 RID: 2342
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04000927 RID: 2343
		internal static int __PropertyOffset_CharacterMovement;

		// Token: 0x04000928 RID: 2344
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x04000929 RID: 2345
		internal static int __PropertyOffset_BasedMovement;

		// Token: 0x0400092A RID: 2346
		private FBasedMovementInfo _BasedMovement;

		// Token: 0x0400092B RID: 2347
		internal static int __PropertyOffset_ReplicatedBasedMovement;

		// Token: 0x0400092C RID: 2348
		private FBasedMovementInfo _ReplicatedBasedMovement;

		// Token: 0x0400092D RID: 2349
		internal static int __PropertyOffset_AnimRootMotionTranslationScale;

		// Token: 0x0400092E RID: 2350
		internal static int __PropertyOffset_BaseTranslationOffset;

		// Token: 0x0400092F RID: 2351
		internal static int __PropertyOffset_BaseRotationOffset;

		// Token: 0x04000930 RID: 2352
		internal static int __PropertyOffset_ReplicatedServerLastTransformUpdateTimeStamp;

		// Token: 0x04000931 RID: 2353
		internal static int __PropertyOffset_ReplayLastTransformUpdateTimeStamp;

		// Token: 0x04000932 RID: 2354
		internal static int __PropertyOffset_ReplicatedMovementMode;

		// Token: 0x04000933 RID: 2355
		internal static int __PropertyOffset_bInBaseReplication;

		// Token: 0x04000934 RID: 2356
		internal static int __PropertyOffset_CrouchedEyeHeight;

		// Token: 0x04000935 RID: 2357
		internal static int __PropertyOffset_bIsCrouched;

		// Token: 0x04000936 RID: 2358
		internal static byte __PropertyMask_bIsCrouched;

		// Token: 0x04000937 RID: 2359
		internal static int __PropertyOffset_bProxyIsJumpForceApplied;

		// Token: 0x04000938 RID: 2360
		internal static byte __PropertyMask_bProxyIsJumpForceApplied;

		// Token: 0x04000939 RID: 2361
		internal static int __PropertyOffset_bPressedJump;

		// Token: 0x0400093A RID: 2362
		internal static byte __PropertyMask_bPressedJump;

		// Token: 0x0400093B RID: 2363
		internal static int __PropertyOffset_bClientUpdating;

		// Token: 0x0400093C RID: 2364
		internal static byte __PropertyMask_bClientUpdating;

		// Token: 0x0400093D RID: 2365
		internal static int __PropertyOffset_bClientWasFalling;

		// Token: 0x0400093E RID: 2366
		internal static byte __PropertyMask_bClientWasFalling;

		// Token: 0x0400093F RID: 2367
		internal static int __PropertyOffset_bClientResimulateRootMotion;

		// Token: 0x04000940 RID: 2368
		internal static byte __PropertyMask_bClientResimulateRootMotion;

		// Token: 0x04000941 RID: 2369
		internal static int __PropertyOffset_bClientResimulateRootMotionSources;

		// Token: 0x04000942 RID: 2370
		internal static byte __PropertyMask_bClientResimulateRootMotionSources;

		// Token: 0x04000943 RID: 2371
		internal static int __PropertyOffset_bSimGravityDisabled;

		// Token: 0x04000944 RID: 2372
		internal static byte __PropertyMask_bSimGravityDisabled;

		// Token: 0x04000945 RID: 2373
		internal static int __PropertyOffset_bClientCheckEncroachmentOnNetUpdate;

		// Token: 0x04000946 RID: 2374
		internal static byte __PropertyMask_bClientCheckEncroachmentOnNetUpdate;

		// Token: 0x04000947 RID: 2375
		internal static int __PropertyOffset_bServerMoveIgnoreRootMotion;

		// Token: 0x04000948 RID: 2376
		internal static byte __PropertyMask_bServerMoveIgnoreRootMotion;

		// Token: 0x04000949 RID: 2377
		internal static int __PropertyOffset_bWasJumping;

		// Token: 0x0400094A RID: 2378
		internal static byte __PropertyMask_bWasJumping;

		// Token: 0x0400094B RID: 2379
		internal static int __PropertyOffset_JumpKeyHoldTime;

		// Token: 0x0400094C RID: 2380
		internal static int __PropertyOffset_JumpForceTimeRemaining;

		// Token: 0x0400094D RID: 2381
		internal static int __PropertyOffset_ProxyJumpForceStartedTime;

		// Token: 0x0400094E RID: 2382
		internal static int __PropertyOffset_JumpMaxHoldTime;

		// Token: 0x0400094F RID: 2383
		internal static int __PropertyOffset_JumpMaxCount;

		// Token: 0x04000950 RID: 2384
		internal static int __PropertyOffset_JumpCurrentCount;

		// Token: 0x04000951 RID: 2385
		internal static int __PropertyOffset_JumpCurrentCountPreJump;

		// Token: 0x04000952 RID: 2386
		internal static int __PropertyOffset_OnReachedJumpApex;

		// Token: 0x04000953 RID: 2387
		private FCharacterReachedApexSignature _OnReachedJumpApex;

		// Token: 0x04000954 RID: 2388
		internal static int __PropertyOffset_MovementModeChangedDelegate;

		// Token: 0x04000955 RID: 2389
		private FMovementModeChangedSignature _MovementModeChangedDelegate;

		// Token: 0x04000956 RID: 2390
		internal static int __PropertyOffset_OnCharacterMovementUpdated;

		// Token: 0x04000957 RID: 2391
		private FCharacterMovementUpdatedSignature _OnCharacterMovementUpdated;

		// Token: 0x04000958 RID: 2392
		internal static int __PropertyOffset_ClientRootMotionParams;

		// Token: 0x04000959 RID: 2393
		private FRootMotionMovementParams _ClientRootMotionParams;

		// Token: 0x02000970 RID: 2416
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWalkingOffLedge_FunctionParams
		{
			// Token: 0x040058AE RID: 22702
			[FieldOffset(0)]
			public FVector PreviousFloorImpactNormal;

			// Token: 0x040058AF RID: 22703
			[FieldOffset(12)]
			public FVector PreviousFloorContactNormal;

			// Token: 0x040058B0 RID: 22704
			[FieldOffset(24)]
			public FVector PreviousLocation;

			// Token: 0x040058B1 RID: 22705
			[FieldOffset(36)]
			public float TimeDelta;
		}

		// Token: 0x02000971 RID: 2417
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnLaunched_FunctionParams
		{
			// Token: 0x040058B2 RID: 22706
			[FieldOffset(0)]
			public FVector LaunchVelocity;

			// Token: 0x040058B3 RID: 22707
			[FieldOffset(12)]
			public bool bXYOverride;

			// Token: 0x040058B4 RID: 22708
			[FieldOffset(13)]
			public bool bZOverride;
		}

		// Token: 0x02000972 RID: 2418
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 148)]
		protected ref struct __OnLanded_FunctionParams
		{
			// Token: 0x040058B5 RID: 22709
			[FieldOffset(0)]
			public byte Hit;
		}

		// Token: 0x02000973 RID: 2419
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_UpdateCustomMovement_FunctionParams
		{
			// Token: 0x040058B6 RID: 22710
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000974 RID: 2420
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnStartCrouch_FunctionParams
		{
			// Token: 0x040058B7 RID: 22711
			[FieldOffset(0)]
			public float HalfHeightAdjust;

			// Token: 0x040058B8 RID: 22712
			[FieldOffset(4)]
			public float ScaledHalfHeightAdjust;
		}

		// Token: 0x02000975 RID: 2421
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_OnMovementModeChanged_FunctionParams
		{
			// Token: 0x040058B9 RID: 22713
			[FieldOffset(0)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x040058BA RID: 22714
			[FieldOffset(1)]
			public TEnumAsByte<EMovementMode> NewMovementMode;

			// Token: 0x040058BB RID: 22715
			[FieldOffset(2)]
			public byte PrevCustomMode;

			// Token: 0x040058BC RID: 22716
			[FieldOffset(3)]
			public byte NewCustomMode;
		}

		// Token: 0x02000976 RID: 2422
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnEndCrouch_FunctionParams
		{
			// Token: 0x040058BD RID: 22717
			[FieldOffset(0)]
			public float HalfHeightAdjust;

			// Token: 0x040058BE RID: 22718
			[FieldOffset(4)]
			public float ScaledHalfHeightAdjust;
		}

		// Token: 0x02000977 RID: 2423
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanJumpInternal_FunctionParams
		{
			// Token: 0x040058BF RID: 22719
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
