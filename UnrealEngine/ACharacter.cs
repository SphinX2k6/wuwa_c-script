using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000924 RID: 2340
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.Character")]
	[UnrealStructLayout(1808, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class ACharacter : APawn, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008133 RID: 33075 RVA: 0x000B9268 File Offset: 0x000B7468
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ACharacter._ClassPtr;
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x000B9274 File Offset: 0x000B7474
		public ACharacter() : this(BuiltinUtils.AllocNativeUObject(ACharacter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x000B929C File Offset: 0x000B749C
		[NullableContext(1)]
		public ACharacter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ACharacter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E64 RID: 7780
		// (get) Token: 0x06008136 RID: 33078 RVA: 0x000B92CF File Offset: 0x000B74CF
		// (set) Token: 0x06008137 RID: 33079 RVA: 0x000B92E3 File Offset: 0x000B74E3
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

		// Token: 0x17001E65 RID: 7781
		// (get) Token: 0x06008138 RID: 33080 RVA: 0x000B92F8 File Offset: 0x000B74F8
		// (set) Token: 0x06008139 RID: 33081 RVA: 0x000B930C File Offset: 0x000B750C
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

		// Token: 0x17001E66 RID: 7782
		// (get) Token: 0x0600813A RID: 33082 RVA: 0x000B9321 File Offset: 0x000B7521
		// (set) Token: 0x0600813B RID: 33083 RVA: 0x000B9335 File Offset: 0x000B7535
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

		// Token: 0x17001E67 RID: 7783
		// (get) Token: 0x0600813C RID: 33084 RVA: 0x000B934C File Offset: 0x000B754C
		// (set) Token: 0x0600813D RID: 33085 RVA: 0x000B9385 File Offset: 0x000B7585
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

		// Token: 0x17001E68 RID: 7784
		// (get) Token: 0x0600813E RID: 33086 RVA: 0x000B93A8 File Offset: 0x000B75A8
		// (set) Token: 0x0600813F RID: 33087 RVA: 0x000B93E1 File Offset: 0x000B75E1
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

		// Token: 0x17001E69 RID: 7785
		// (get) Token: 0x06008140 RID: 33088 RVA: 0x000B9402 File Offset: 0x000B7602
		// (set) Token: 0x06008141 RID: 33089 RVA: 0x000B9412 File Offset: 0x000B7612
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

		// Token: 0x17001E6A RID: 7786
		// (get) Token: 0x06008142 RID: 33090 RVA: 0x000B9423 File Offset: 0x000B7623
		// (set) Token: 0x06008143 RID: 33091 RVA: 0x000B9437 File Offset: 0x000B7637
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

		// Token: 0x17001E6B RID: 7787
		// (get) Token: 0x06008144 RID: 33092 RVA: 0x000B944C File Offset: 0x000B764C
		// (set) Token: 0x06008145 RID: 33093 RVA: 0x000B9460 File Offset: 0x000B7660
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

		// Token: 0x17001E6C RID: 7788
		// (get) Token: 0x06008146 RID: 33094 RVA: 0x000B9475 File Offset: 0x000B7675
		// (set) Token: 0x06008147 RID: 33095 RVA: 0x000B9485 File Offset: 0x000B7685
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

		// Token: 0x17001E6D RID: 7789
		// (get) Token: 0x06008148 RID: 33096 RVA: 0x000B9496 File Offset: 0x000B7696
		// (set) Token: 0x06008149 RID: 33097 RVA: 0x000B94A6 File Offset: 0x000B76A6
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

		// Token: 0x17001E6E RID: 7790
		// (get) Token: 0x0600814A RID: 33098 RVA: 0x000B94B7 File Offset: 0x000B76B7
		// (set) Token: 0x0600814B RID: 33099 RVA: 0x000B94C7 File Offset: 0x000B76C7
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

		// Token: 0x17001E6F RID: 7791
		// (get) Token: 0x0600814C RID: 33100 RVA: 0x000B94D8 File Offset: 0x000B76D8
		// (set) Token: 0x0600814D RID: 33101 RVA: 0x000B94E8 File Offset: 0x000B76E8
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

		// Token: 0x17001E70 RID: 7792
		// (get) Token: 0x0600814E RID: 33102 RVA: 0x000B94F9 File Offset: 0x000B76F9
		// (set) Token: 0x0600814F RID: 33103 RVA: 0x000B9509 File Offset: 0x000B7709
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

		// Token: 0x17001E71 RID: 7793
		// (get) Token: 0x06008150 RID: 33104 RVA: 0x000B951A File Offset: 0x000B771A
		// (set) Token: 0x06008151 RID: 33105 RVA: 0x000B9533 File Offset: 0x000B7733
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

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x06008152 RID: 33106 RVA: 0x000B9563 File Offset: 0x000B7763
		// (set) Token: 0x06008153 RID: 33107 RVA: 0x000B957C File Offset: 0x000B777C
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

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x06008154 RID: 33108 RVA: 0x000B95AC File Offset: 0x000B77AC
		// (set) Token: 0x06008155 RID: 33109 RVA: 0x000B95C5 File Offset: 0x000B77C5
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

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x000B95F5 File Offset: 0x000B77F5
		// (set) Token: 0x06008157 RID: 33111 RVA: 0x000B960E File Offset: 0x000B780E
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

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x06008158 RID: 33112 RVA: 0x000B963E File Offset: 0x000B783E
		// (set) Token: 0x06008159 RID: 33113 RVA: 0x000B9657 File Offset: 0x000B7857
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

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x000B9687 File Offset: 0x000B7887
		// (set) Token: 0x0600815B RID: 33115 RVA: 0x000B96A0 File Offset: 0x000B78A0
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

		// Token: 0x17001E77 RID: 7799
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x000B96D0 File Offset: 0x000B78D0
		// (set) Token: 0x0600815D RID: 33117 RVA: 0x000B96E9 File Offset: 0x000B78E9
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

		// Token: 0x17001E78 RID: 7800
		// (get) Token: 0x0600815E RID: 33118 RVA: 0x000B9719 File Offset: 0x000B7919
		// (set) Token: 0x0600815F RID: 33119 RVA: 0x000B9732 File Offset: 0x000B7932
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

		// Token: 0x17001E79 RID: 7801
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x000B9762 File Offset: 0x000B7962
		// (set) Token: 0x06008161 RID: 33121 RVA: 0x000B977B File Offset: 0x000B797B
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

		// Token: 0x17001E7A RID: 7802
		// (get) Token: 0x06008162 RID: 33122 RVA: 0x000B97AB File Offset: 0x000B79AB
		// (set) Token: 0x06008163 RID: 33123 RVA: 0x000B97C4 File Offset: 0x000B79C4
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

		// Token: 0x17001E7B RID: 7803
		// (get) Token: 0x06008164 RID: 33124 RVA: 0x000B97F4 File Offset: 0x000B79F4
		// (set) Token: 0x06008165 RID: 33125 RVA: 0x000B980D File Offset: 0x000B7A0D
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

		// Token: 0x17001E7C RID: 7804
		// (get) Token: 0x06008166 RID: 33126 RVA: 0x000B983D File Offset: 0x000B7A3D
		// (set) Token: 0x06008167 RID: 33127 RVA: 0x000B984D File Offset: 0x000B7A4D
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

		// Token: 0x17001E7D RID: 7805
		// (get) Token: 0x06008168 RID: 33128 RVA: 0x000B985E File Offset: 0x000B7A5E
		// (set) Token: 0x06008169 RID: 33129 RVA: 0x000B986E File Offset: 0x000B7A6E
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

		// Token: 0x17001E7E RID: 7806
		// (get) Token: 0x0600816A RID: 33130 RVA: 0x000B987F File Offset: 0x000B7A7F
		// (set) Token: 0x0600816B RID: 33131 RVA: 0x000B988F File Offset: 0x000B7A8F
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

		// Token: 0x17001E7F RID: 7807
		// (get) Token: 0x0600816C RID: 33132 RVA: 0x000B98A0 File Offset: 0x000B7AA0
		// (set) Token: 0x0600816D RID: 33133 RVA: 0x000B98B0 File Offset: 0x000B7AB0
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

		// Token: 0x17001E80 RID: 7808
		// (get) Token: 0x0600816E RID: 33134 RVA: 0x000B98C1 File Offset: 0x000B7AC1
		// (set) Token: 0x0600816F RID: 33135 RVA: 0x000B98D1 File Offset: 0x000B7AD1
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

		// Token: 0x17001E81 RID: 7809
		// (get) Token: 0x06008170 RID: 33136 RVA: 0x000B98E2 File Offset: 0x000B7AE2
		// (set) Token: 0x06008171 RID: 33137 RVA: 0x000B98F2 File Offset: 0x000B7AF2
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

		// Token: 0x17001E82 RID: 7810
		// (get) Token: 0x06008172 RID: 33138 RVA: 0x000B9903 File Offset: 0x000B7B03
		// (set) Token: 0x06008173 RID: 33139 RVA: 0x000B9913 File Offset: 0x000B7B13
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

		// Token: 0x17001E83 RID: 7811
		// (get) Token: 0x06008174 RID: 33140 RVA: 0x000B9924 File Offset: 0x000B7B24
		// (set) Token: 0x06008175 RID: 33141 RVA: 0x000B995D File Offset: 0x000B7B5D
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

		// Token: 0x17001E84 RID: 7812
		// (get) Token: 0x06008176 RID: 33142 RVA: 0x000B9980 File Offset: 0x000B7B80
		// (set) Token: 0x06008177 RID: 33143 RVA: 0x000B99B9 File Offset: 0x000B7BB9
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

		// Token: 0x17001E85 RID: 7813
		// (get) Token: 0x06008178 RID: 33144 RVA: 0x000B99DC File Offset: 0x000B7BDC
		// (set) Token: 0x06008179 RID: 33145 RVA: 0x000B9A15 File Offset: 0x000B7C15
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

		// Token: 0x17001E86 RID: 7814
		// (get) Token: 0x0600817A RID: 33146 RVA: 0x000B9A38 File Offset: 0x000B7C38
		// (set) Token: 0x0600817B RID: 33147 RVA: 0x000B9A71 File Offset: 0x000B7C71
		[Nullable(1)]
		public FRootMotionSourceGroup SavedRootMotion
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceGroup result;
				if ((result = this._SavedRootMotion) == null)
				{
					result = (this._SavedRootMotion = new FRootMotionSourceGroup(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_SavedRootMotion, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceGroup.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_SavedRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E87 RID: 7815
		// (get) Token: 0x0600817C RID: 33148 RVA: 0x000B9A94 File Offset: 0x000B7C94
		// (set) Token: 0x0600817D RID: 33149 RVA: 0x000B9ACD File Offset: 0x000B7CCD
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

		// Token: 0x17001E88 RID: 7816
		// (get) Token: 0x0600817E RID: 33150 RVA: 0x000B9AF0 File Offset: 0x000B7CF0
		// (set) Token: 0x0600817F RID: 33151 RVA: 0x000B9B29 File Offset: 0x000B7D29
		[Nullable(1)]
		public TArray<FSimulatedRootMotionReplicatedMove> RootMotionRepMoves
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FSimulatedRootMotionReplicatedMove> result;
				if ((result = this._RootMotionRepMoves) == null)
				{
					result = (this._RootMotionRepMoves = new TArray<FSimulatedRootMotionReplicatedMove>(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_RootMotionRepMoves, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.RootMotionRepMoves.CopyAssign(value);
			}
		}

		// Token: 0x17001E89 RID: 7817
		// (get) Token: 0x06008180 RID: 33152 RVA: 0x000B9B38 File Offset: 0x000B7D38
		// (set) Token: 0x06008181 RID: 33153 RVA: 0x000B9B71 File Offset: 0x000B7D71
		[Nullable(1)]
		public FRepRootMotionMontage RepRootMotion
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRepRootMotionMontage result;
				if ((result = this._RepRootMotion) == null)
				{
					result = (this._RepRootMotion = new FRepRootMotionMontage(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_RepRootMotion, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRepRootMotionMontage.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_RepRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E8A RID: 7818
		// (get) Token: 0x06008182 RID: 33154 RVA: 0x000B9B94 File Offset: 0x000B7D94
		// (set) Token: 0x06008183 RID: 33155 RVA: 0x000B9BCD File Offset: 0x000B7DCD
		[Nullable(1)]
		public FKuroRepRootMotionMontage KuroRepRootMotion
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRepRootMotionMontage result;
				if ((result = this._KuroRepRootMotion) == null)
				{
					result = (this._KuroRepRootMotion = new FKuroRepRootMotionMontage(base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_KuroRepRootMotion, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRepRootMotionMontage.StaticStruct(), base.NativePtr + (IntPtr)ACharacter.__PropertyOffset_KuroRepRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x000B9BEE File Offset: 0x000B7DEE
		public void UnCrouch(bool bClientSimulation = false)
		{
			ACharacter.__UnCrouch_Internal(base.NativePtr, bClientSimulation);
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x000B9BFC File Offset: 0x000B7DFC
		public void StopJumping()
		{
			ACharacter.__StopJumping_Internal(base.NativePtr);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x000B9C09 File Offset: 0x000B7E09
		public void StopAnimMontage(UAnimMontage AnimMontage = null)
		{
			ACharacter.__StopAnimMontage_Internal(base.NativePtr, (AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008187 RID: 33159 RVA: 0x000B9C26 File Offset: 0x000B7E26
		public void SetKuroReplicatedMovementMode(byte Mode)
		{
			ACharacter.__SetKuroReplicatedMovementMode_Internal(base.NativePtr, Mode);
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x000B9C34 File Offset: 0x000B7E34
		public void SetAnimRootMotionTranslationScale(float InAnimRootMotionTranslationScale = 1f)
		{
			ACharacter.__SetAnimRootMotionTranslationScale_Internal(base.NativePtr, InAnimRootMotionTranslationScale);
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x000B9C42 File Offset: 0x000B7E42
		public void ServerMovePacked(in FCharacterServerMovePackedBits PackedBits)
		{
			ACharacter.__ServerMovePacked_Internal(base.NativePtr, (PackedBits ?? new FCharacterServerMovePackedBits()).NativePtr);
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x000B9C5F File Offset: 0x000B7E5F
		public void ServerMoveOld(float OldTimeStamp, FVector_NetQuantize10 OldAccel, byte OldMoveFlags)
		{
			ACharacter.__ServerMoveOld_Internal(base.NativePtr, OldTimeStamp, OldAccel, OldMoveFlags);
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x000B9C6F File Offset: 0x000B7E6F
		public void ServerMoveNoBase(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveNoBase_Internal(base.NativePtr, TimeStamp, InAccel, ClientLoc, CompressedMoveFlags, ClientRoll, View, ClientMovementMode);
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x000B9C88 File Offset: 0x000B7E88
		public void ServerMoveDualNoBase(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDualNoBase_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, ClientMovementMode);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x000B9CB4 File Offset: 0x000B7EB4
		public void ServerMoveDualHybridRootMotion(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDualHybridRootMotion_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x0600818E RID: 33166 RVA: 0x000B9CF4 File Offset: 0x000B7EF4
		public void ServerMoveDual(float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMoveDual_Internal(base.NativePtr, TimeStamp0, InAccel0, PendingFlags, View0, TimeStamp, InAccel, ClientLoc, NewFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x000B9D34 File Offset: 0x000B7F34
		public void ServerMove(float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, UPrimitiveComponent ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode)
		{
			ACharacter.__ServerMove_Internal(base.NativePtr, TimeStamp, InAccel, ClientLoc, CompressedMoveFlags, ClientRoll, View, (ClientMovementBase != null) ? ClientMovementBase.NativePtr : IntPtr.Zero, ClientBaseBoneName, ClientMovementMode);
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x000B9D6C File Offset: 0x000B7F6C
		[NullableContext(1)]
		public unsafe void RootMotionDebugClientPrintOnScreen(string InString)
		{
			FString fstring = FString.AllocTemp(InString);
			ACharacter.__RootMotionDebugClientPrintOnScreen_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x000B9D96 File Offset: 0x000B7F96
		public float PlayAnimMontage(UAnimMontage AnimMontage, float InPlayRate = 1f, FName StartSectionName = default(FName))
		{
			return ACharacter.__PlayAnimMontage_Internal(base.NativePtr, (AnimMontage != null) ? AnimMontage.NativePtr : IntPtr.Zero, InPlayRate, StartSectionName);
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x000B9DB5 File Offset: 0x000B7FB5
		public virtual void OnWalkingOffLedge(in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta)
		{
			ACharacter.__OnWalkingOffLedge_Internal(base.NativePtr, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x000B9DC7 File Offset: 0x000B7FC7
		protected virtual void OnWalkingOffLedge_Implementation(in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta)
		{
			ACharacter.__OnWalkingOffLedge_Implementation_Internal(base.NativePtr, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x000B9DD9 File Offset: 0x000B7FD9
		public void OnRep_RootMotion()
		{
			ACharacter.__OnRep_RootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x000B9DE6 File Offset: 0x000B7FE6
		public void OnRep_ReplicatedBasedMovement()
		{
			ACharacter.__OnRep_ReplicatedBasedMovement_Internal(base.NativePtr);
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x000B9DF3 File Offset: 0x000B7FF3
		public void OnRep_ReplayLastTransformUpdateTimeStamp()
		{
			ACharacter.__OnRep_ReplayLastTransformUpdateTimeStamp_Internal(base.NativePtr);
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x000B9E00 File Offset: 0x000B8000
		public void OnRep_KuroRootMotion()
		{
			ACharacter.__OnRep_KuroRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x000B9E0D File Offset: 0x000B800D
		public void OnRep_IsCrouched()
		{
			ACharacter.__OnRep_IsCrouched_Internal(base.NativePtr);
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x000B9E1A File Offset: 0x000B801A
		public virtual void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			ACharacter.__OnLaunched_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x000B9E2A File Offset: 0x000B802A
		public virtual void OnLanded(in FHitResult Hit)
		{
			ACharacter.__OnLanded_Internal(base.NativePtr, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x000B9E47 File Offset: 0x000B8047
		public virtual void OnJumped()
		{
			ACharacter.__OnJumped_Internal(base.NativePtr);
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x000B9E54 File Offset: 0x000B8054
		protected virtual void OnJumped_Implementation()
		{
			ACharacter.__OnJumped_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x000B9E61 File Offset: 0x000B8061
		public void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
		{
			ACharacter.__LaunchCharacter_Internal(base.NativePtr, LaunchVelocity, bXYOverride, bZOverride);
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x000B9E71 File Offset: 0x000B8071
		public virtual void KuroReplicateRootMotion(in FKuroRepRootMotionMontage Data)
		{
			ACharacter.__KuroReplicateRootMotion_Internal(base.NativePtr, (Data ?? new FKuroRepRootMotionMontage()).NativePtr);
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x000B9E8E File Offset: 0x000B808E
		public virtual void KuroReplicateDataToServer(in FKuroRepMovement RepMovement, byte MovementMode)
		{
			ACharacter.__KuroReplicateDataToServer_Internal(base.NativePtr, (RepMovement ?? new FKuroRepMovement()).NativePtr, MovementMode);
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x000B9EAC File Offset: 0x000B80AC
		public void KuroPreNetReceive()
		{
			ACharacter.__KuroPreNetReceive_Internal(base.NativePtr);
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x000B9EB9 File Offset: 0x000B80B9
		public void KuroPostNetReceive()
		{
			ACharacter.__KuroPostNetReceive_Internal(base.NativePtr);
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x000B9EC6 File Offset: 0x000B80C6
		public virtual void Kuro_ServerMovePacked(in FKuroCharacterNetworkMoveData Data)
		{
			ACharacter.__Kuro_ServerMovePacked_Internal(base.NativePtr, (Data ?? new FKuroCharacterNetworkMoveData()).NativePtr);
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x000B9EE3 File Offset: 0x000B80E3
		public void Kuro_OnRep_ReplicatedBasedMovement()
		{
			ACharacter.__Kuro_OnRep_ReplicatedBasedMovement_Internal(base.NativePtr);
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x000B9EF0 File Offset: 0x000B80F0
		public bool Kuro_IsJumpProvidingForce()
		{
			return ACharacter.__Kuro_IsJumpProvidingForce_Internal(base.NativePtr);
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x000B9EFD File Offset: 0x000B80FD
		public virtual void K2_UpdateCustomMovement(float DeltaTime)
		{
			ACharacter.__K2_UpdateCustomMovement_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x000B9F0B File Offset: 0x000B810B
		public virtual void K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			ACharacter.__K2_OnStartCrouch_Internal(base.NativePtr, HalfHeightAdjust, ScaledHalfHeightAdjust);
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x000B9F1A File Offset: 0x000B811A
		public virtual void K2_OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
		{
			ACharacter.__K2_OnMovementModeChanged_Internal(base.NativePtr, PrevMovementMode, NewMovementMode, PrevCustomMode, NewCustomMode);
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x000B9F36 File Offset: 0x000B8136
		public virtual void K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
		{
			ACharacter.__K2_OnEndCrouch_Internal(base.NativePtr, HalfHeightAdjust, ScaledHalfHeightAdjust);
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x000B9F45 File Offset: 0x000B8145
		public void Jump()
		{
			ACharacter.__Jump_Internal(base.NativePtr);
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x000B9F52 File Offset: 0x000B8152
		public bool IsPlayingRootMotion()
		{
			return ACharacter.__IsPlayingRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x000B9F5F File Offset: 0x000B815F
		public bool IsPlayingNetworkedRootMotionMontage()
		{
			return ACharacter.__IsPlayingNetworkedRootMotionMontage_Internal(base.NativePtr);
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x000B9F6C File Offset: 0x000B816C
		public bool IsKuroForceFlying()
		{
			return ACharacter.__IsKuroForceFlying_Internal(base.NativePtr);
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x000B9F79 File Offset: 0x000B8179
		public bool IsJumpProvidingForce()
		{
			return ACharacter.__IsJumpProvidingForce_Internal(base.NativePtr);
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x000B9F86 File Offset: 0x000B8186
		public bool HasAnyRootMotion()
		{
			return ACharacter.__HasAnyRootMotion_Internal(base.NativePtr);
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x000B9F93 File Offset: 0x000B8193
		public byte GetKuroReplicatedMovementMode()
		{
			return ACharacter.__GetKuroReplicatedMovementMode_Internal(base.NativePtr);
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x000B9FA0 File Offset: 0x000B81A0
		public UAnimMontage GetCurrentMontage()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAnimMontage>(ACharacter.__GetCurrentMontage_Internal(base.NativePtr));
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x000B9FB2 File Offset: 0x000B81B2
		public FVector GetBaseTranslationOffset()
		{
			return ACharacter.__GetBaseTranslationOffset_Internal(base.NativePtr);
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x000B9FBF File Offset: 0x000B81BF
		public FRotator GetBaseRotationOffsetRotator()
		{
			return ACharacter.__GetBaseRotationOffsetRotator_Internal(base.NativePtr);
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x000B9FCC File Offset: 0x000B81CC
		public float GetAnimRootMotionTranslationScale()
		{
			return ACharacter.__GetAnimRootMotionTranslationScale_Internal(base.NativePtr);
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x000B9FD9 File Offset: 0x000B81D9
		public void Crouch(bool bClientSimulation = false)
		{
			ACharacter.__Crouch_Internal(base.NativePtr, bClientSimulation);
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x000B9FE7 File Offset: 0x000B81E7
		public void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientVeryShortAdjustPosition_Internal(base.NativePtr, TimeStamp, NewLoc, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x000BA00E File Offset: 0x000B820E
		public void ClientMoveResponsePacked(in FCharacterMoveResponsePackedBits PackedBits)
		{
			ACharacter.__ClientMoveResponsePacked_Internal(base.NativePtr, (PackedBits ?? new FCharacterMoveResponsePackedBits()).NativePtr);
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x000BA02B File Offset: 0x000B822B
		public void ClientCheatWalk()
		{
			ACharacter.__ClientCheatWalk_Internal(base.NativePtr);
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x000BA038 File Offset: 0x000B8238
		public void ClientCheatGhost()
		{
			ACharacter.__ClientCheatGhost_Internal(base.NativePtr);
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x000BA045 File Offset: 0x000B8245
		public void ClientCheatFly()
		{
			ACharacter.__ClientCheatFly_Internal(base.NativePtr);
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x000BA054 File Offset: 0x000B8254
		public void ClientAdjustRootMotionSourcePosition(float TimeStamp, FRootMotionSourceGroup ServerRootMotion, bool bHasAnimRootMotion, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, UPrimitiveComponent ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientAdjustRootMotionSourcePosition_Internal(base.NativePtr, TimeStamp, (ServerRootMotion ?? new FRootMotionSourceGroup()).NativePtr, bHasAnimRootMotion, ServerMontageTrackPosition, ServerLoc, ServerRotation, ServerVelZ, (ServerBase != null) ? ServerBase.NativePtr : IntPtr.Zero, ServerBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x000BA0A0 File Offset: 0x000B82A0
		public void ClientAdjustRootMotionPosition(float TimeStamp, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, UPrimitiveComponent ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientAdjustRootMotionPosition_Internal(base.NativePtr, TimeStamp, ServerMontageTrackPosition, ServerLoc, ServerRotation, ServerVelZ, (ServerBase != null) ? ServerBase.NativePtr : IntPtr.Zero, ServerBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x000BA0DC File Offset: 0x000B82DC
		public void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
		{
			ACharacter.__ClientAdjustPosition_Internal(base.NativePtr, TimeStamp, NewLoc, NewVel, (NewBase != null) ? NewBase.NativePtr : IntPtr.Zero, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x000BA111 File Offset: 0x000B8311
		public void ClientAckGoodMove(float TimeStamp)
		{
			ACharacter.__ClientAckGoodMove_Internal(base.NativePtr, TimeStamp);
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x000BA11F File Offset: 0x000B831F
		public virtual bool CanJumpInternal()
		{
			return ACharacter.__CanJumpInternal_Internal(base.NativePtr);
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x000BA12C File Offset: 0x000B832C
		protected virtual bool CanJumpInternal_Implementation()
		{
			return ACharacter.__CanJumpInternal_Implementation_Internal(base.NativePtr);
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x000BA139 File Offset: 0x000B8339
		public bool CanJump()
		{
			return ACharacter.__CanJump_Internal(base.NativePtr);
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x000BA146 File Offset: 0x000B8346
		public bool CanCrouch()
		{
			return ACharacter.__CanCrouch_Internal(base.NativePtr);
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x000BA153 File Offset: 0x000B8353
		public void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
		{
			ACharacter.__CacheInitialMeshOffset_Internal(base.NativePtr, MeshRelativeLocation, MeshRelativeRotation);
		}

		// Token: 0x060081C3 RID: 33219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnCrouch_Internal(IntPtr @this, bool bClientSimulation);

		// Token: 0x060081C4 RID: 33220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopJumping_Internal(IntPtr @this);

		// Token: 0x060081C5 RID: 33221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimMontage_Internal(IntPtr @this, IntPtr AnimMontage);

		// Token: 0x060081C6 RID: 33222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroReplicatedMovementMode_Internal(IntPtr @this, byte Mode);

		// Token: 0x060081C7 RID: 33223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimRootMotionTranslationScale_Internal(IntPtr @this, float InAnimRootMotionTranslationScale);

		// Token: 0x060081C8 RID: 33224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMovePacked_Internal(IntPtr @this, IntPtr PackedBits);

		// Token: 0x060081C9 RID: 33225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveOld_Internal(IntPtr @this, float OldTimeStamp, FVector_NetQuantize10 OldAccel, byte OldMoveFlags);

		// Token: 0x060081CA RID: 33226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveNoBase_Internal(IntPtr @this, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, byte ClientMovementMode);

		// Token: 0x060081CB RID: 33227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDualNoBase_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, byte ClientMovementMode);

		// Token: 0x060081CC RID: 33228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDualHybridRootMotion_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x060081CD RID: 33229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMoveDual_Internal(IntPtr @this, float TimeStamp0, FVector_NetQuantize10 InAccel0, byte PendingFlags, uint View0, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte NewFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x060081CE RID: 33230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ServerMove_Internal(IntPtr @this, float TimeStamp, FVector_NetQuantize10 InAccel, FVector_NetQuantize100 ClientLoc, byte CompressedMoveFlags, byte ClientRoll, uint View, IntPtr ClientMovementBase, FName ClientBaseBoneName, byte ClientMovementMode);

		// Token: 0x060081CF RID: 33231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RootMotionDebugClientPrintOnScreen_Internal(IntPtr @this, in FString InString);

		// Token: 0x060081D0 RID: 33232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PlayAnimMontage_Internal(IntPtr @this, IntPtr AnimMontage, float InPlayRate, FName StartSectionName);

		// Token: 0x060081D1 RID: 33233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWalkingOffLedge_Internal(IntPtr @this, in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta);

		// Token: 0x060081D2 RID: 33234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnWalkingOffLedge_Implementation_Internal(IntPtr @this, in FVector PreviousFloorImpactNormal, in FVector PreviousFloorContactNormal, in FVector PreviousLocation, float TimeDelta);

		// Token: 0x060081D3 RID: 33235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_RootMotion_Internal(IntPtr @this);

		// Token: 0x060081D4 RID: 33236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplicatedBasedMovement_Internal(IntPtr @this);

		// Token: 0x060081D5 RID: 33237
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_ReplayLastTransformUpdateTimeStamp_Internal(IntPtr @this);

		// Token: 0x060081D6 RID: 33238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_KuroRootMotion_Internal(IntPtr @this);

		// Token: 0x060081D7 RID: 33239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRep_IsCrouched_Internal(IntPtr @this);

		// Token: 0x060081D8 RID: 33240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLaunched_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x060081D9 RID: 33241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnLanded_Internal(IntPtr @this, IntPtr Hit);

		// Token: 0x060081DA RID: 33242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnJumped_Internal(IntPtr @this);

		// Token: 0x060081DB RID: 33243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnJumped_Implementation_Internal(IntPtr @this);

		// Token: 0x060081DC RID: 33244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LaunchCharacter_Internal(IntPtr @this, FVector LaunchVelocity, bool bXYOverride, bool bZOverride);

		// Token: 0x060081DD RID: 33245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroReplicateRootMotion_Internal(IntPtr @this, IntPtr Data);

		// Token: 0x060081DE RID: 33246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroReplicateDataToServer_Internal(IntPtr @this, IntPtr RepMovement, byte MovementMode);

		// Token: 0x060081DF RID: 33247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPreNetReceive_Internal(IntPtr @this);

		// Token: 0x060081E0 RID: 33248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPostNetReceive_Internal(IntPtr @this);

		// Token: 0x060081E1 RID: 33249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_ServerMovePacked_Internal(IntPtr @this, IntPtr Data);

		// Token: 0x060081E2 RID: 33250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_OnRep_ReplicatedBasedMovement_Internal(IntPtr @this);

		// Token: 0x060081E3 RID: 33251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Kuro_IsJumpProvidingForce_Internal(IntPtr @this);

		// Token: 0x060081E4 RID: 33252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_UpdateCustomMovement_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x060081E5 RID: 33253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnStartCrouch_Internal(IntPtr @this, float HalfHeightAdjust, float ScaledHalfHeightAdjust);

		// Token: 0x060081E6 RID: 33254
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnMovementModeChanged_Internal(IntPtr @this, TEnumAsByte<EMovementMode> PrevMovementMode, TEnumAsByte<EMovementMode> NewMovementMode, byte PrevCustomMode, byte NewCustomMode);

		// Token: 0x060081E7 RID: 33255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_OnEndCrouch_Internal(IntPtr @this, float HalfHeightAdjust, float ScaledHalfHeightAdjust);

		// Token: 0x060081E8 RID: 33256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Jump_Internal(IntPtr @this);

		// Token: 0x060081E9 RID: 33257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingRootMotion_Internal(IntPtr @this);

		// Token: 0x060081EA RID: 33258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingNetworkedRootMotionMontage_Internal(IntPtr @this);

		// Token: 0x060081EB RID: 33259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsKuroForceFlying_Internal(IntPtr @this);

		// Token: 0x060081EC RID: 33260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsJumpProvidingForce_Internal(IntPtr @this);

		// Token: 0x060081ED RID: 33261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyRootMotion_Internal(IntPtr @this);

		// Token: 0x060081EE RID: 33262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetKuroReplicatedMovementMode_Internal(IntPtr @this);

		// Token: 0x060081EF RID: 33263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentMontage_Internal(IntPtr @this);

		// Token: 0x060081F0 RID: 33264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetBaseTranslationOffset_Internal(IntPtr @this);

		// Token: 0x060081F1 RID: 33265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetBaseRotationOffsetRotator_Internal(IntPtr @this);

		// Token: 0x060081F2 RID: 33266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimRootMotionTranslationScale_Internal(IntPtr @this);

		// Token: 0x060081F3 RID: 33267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Crouch_Internal(IntPtr @this, bool bClientSimulation);

		// Token: 0x060081F4 RID: 33268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientVeryShortAdjustPosition_Internal(IntPtr @this, float TimeStamp, FVector NewLoc, IntPtr NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x060081F5 RID: 33269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientMoveResponsePacked_Internal(IntPtr @this, IntPtr PackedBits);

		// Token: 0x060081F6 RID: 33270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatWalk_Internal(IntPtr @this);

		// Token: 0x060081F7 RID: 33271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatGhost_Internal(IntPtr @this);

		// Token: 0x060081F8 RID: 33272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientCheatFly_Internal(IntPtr @this);

		// Token: 0x060081F9 RID: 33273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAdjustRootMotionSourcePosition_Internal(IntPtr @this, float TimeStamp, IntPtr ServerRootMotion, bool bHasAnimRootMotion, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, IntPtr ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x060081FA RID: 33274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAdjustRootMotionPosition_Internal(IntPtr @this, float TimeStamp, float ServerMontageTrackPosition, FVector ServerLoc, FVector_NetQuantizeNormal ServerRotation, float ServerVelZ, IntPtr ServerBase, FName ServerBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x060081FB RID: 33275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAdjustPosition_Internal(IntPtr @this, float TimeStamp, FVector NewLoc, FVector NewVel, IntPtr NewBase, FName NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);

		// Token: 0x060081FC RID: 33276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClientAckGoodMove_Internal(IntPtr @this, float TimeStamp);

		// Token: 0x060081FD RID: 33277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJumpInternal_Internal(IntPtr @this);

		// Token: 0x060081FE RID: 33278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJumpInternal_Implementation_Internal(IntPtr @this);

		// Token: 0x060081FF RID: 33279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanJump_Internal(IntPtr @this);

		// Token: 0x06008200 RID: 33280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanCrouch_Internal(IntPtr @this);

		// Token: 0x06008201 RID: 33281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CacheInitialMeshOffset_Internal(IntPtr @this, FVector MeshRelativeLocation, FRotator MeshRelativeRotation);

		// Token: 0x06008202 RID: 33282 RVA: 0x000BA162 File Offset: 0x000B8362
		static ACharacter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Character");
		}

		// Token: 0x06008203 RID: 33283 RVA: 0x000BA170 File Offset: 0x000B8370
		protected ACharacter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003DD0 RID: 15824
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Character";

		// Token: 0x04003DD1 RID: 15825
		private static IntPtr _ClassPtr;

		// Token: 0x04003DD2 RID: 15826
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003DD3 RID: 15827
		internal static int __PropertyOffset_Mesh;

		// Token: 0x04003DD4 RID: 15828
		internal static int __PropertyOffset_CharacterMovement;

		// Token: 0x04003DD5 RID: 15829
		internal static int __PropertyOffset_CapsuleComponent;

		// Token: 0x04003DD6 RID: 15830
		internal static int __PropertyOffset_BasedMovement;

		// Token: 0x04003DD7 RID: 15831
		private FBasedMovementInfo _BasedMovement;

		// Token: 0x04003DD8 RID: 15832
		internal static int __PropertyOffset_ReplicatedBasedMovement;

		// Token: 0x04003DD9 RID: 15833
		private FBasedMovementInfo _ReplicatedBasedMovement;

		// Token: 0x04003DDA RID: 15834
		internal static int __PropertyOffset_AnimRootMotionTranslationScale;

		// Token: 0x04003DDB RID: 15835
		internal static int __PropertyOffset_BaseTranslationOffset;

		// Token: 0x04003DDC RID: 15836
		internal static int __PropertyOffset_BaseRotationOffset;

		// Token: 0x04003DDD RID: 15837
		internal static int __PropertyOffset_ReplicatedServerLastTransformUpdateTimeStamp;

		// Token: 0x04003DDE RID: 15838
		internal static int __PropertyOffset_ReplayLastTransformUpdateTimeStamp;

		// Token: 0x04003DDF RID: 15839
		internal static int __PropertyOffset_ReplicatedMovementMode;

		// Token: 0x04003DE0 RID: 15840
		internal static int __PropertyOffset_bInBaseReplication;

		// Token: 0x04003DE1 RID: 15841
		internal static int __PropertyOffset_CrouchedEyeHeight;

		// Token: 0x04003DE2 RID: 15842
		internal static int __PropertyOffset_bIsCrouched;

		// Token: 0x04003DE3 RID: 15843
		internal static byte __PropertyMask_bIsCrouched;

		// Token: 0x04003DE4 RID: 15844
		internal static int __PropertyOffset_bProxyIsJumpForceApplied;

		// Token: 0x04003DE5 RID: 15845
		internal static byte __PropertyMask_bProxyIsJumpForceApplied;

		// Token: 0x04003DE6 RID: 15846
		internal static int __PropertyOffset_bPressedJump;

		// Token: 0x04003DE7 RID: 15847
		internal static byte __PropertyMask_bPressedJump;

		// Token: 0x04003DE8 RID: 15848
		internal static int __PropertyOffset_bClientUpdating;

		// Token: 0x04003DE9 RID: 15849
		internal static byte __PropertyMask_bClientUpdating;

		// Token: 0x04003DEA RID: 15850
		internal static int __PropertyOffset_bClientWasFalling;

		// Token: 0x04003DEB RID: 15851
		internal static byte __PropertyMask_bClientWasFalling;

		// Token: 0x04003DEC RID: 15852
		internal static int __PropertyOffset_bClientResimulateRootMotion;

		// Token: 0x04003DED RID: 15853
		internal static byte __PropertyMask_bClientResimulateRootMotion;

		// Token: 0x04003DEE RID: 15854
		internal static int __PropertyOffset_bClientResimulateRootMotionSources;

		// Token: 0x04003DEF RID: 15855
		internal static byte __PropertyMask_bClientResimulateRootMotionSources;

		// Token: 0x04003DF0 RID: 15856
		internal static int __PropertyOffset_bSimGravityDisabled;

		// Token: 0x04003DF1 RID: 15857
		internal static byte __PropertyMask_bSimGravityDisabled;

		// Token: 0x04003DF2 RID: 15858
		internal static int __PropertyOffset_bClientCheckEncroachmentOnNetUpdate;

		// Token: 0x04003DF3 RID: 15859
		internal static byte __PropertyMask_bClientCheckEncroachmentOnNetUpdate;

		// Token: 0x04003DF4 RID: 15860
		internal static int __PropertyOffset_bServerMoveIgnoreRootMotion;

		// Token: 0x04003DF5 RID: 15861
		internal static byte __PropertyMask_bServerMoveIgnoreRootMotion;

		// Token: 0x04003DF6 RID: 15862
		internal static int __PropertyOffset_bWasJumping;

		// Token: 0x04003DF7 RID: 15863
		internal static byte __PropertyMask_bWasJumping;

		// Token: 0x04003DF8 RID: 15864
		internal static int __PropertyOffset_JumpKeyHoldTime;

		// Token: 0x04003DF9 RID: 15865
		internal static int __PropertyOffset_JumpForceTimeRemaining;

		// Token: 0x04003DFA RID: 15866
		internal static int __PropertyOffset_ProxyJumpForceStartedTime;

		// Token: 0x04003DFB RID: 15867
		internal static int __PropertyOffset_JumpMaxHoldTime;

		// Token: 0x04003DFC RID: 15868
		internal static int __PropertyOffset_JumpMaxCount;

		// Token: 0x04003DFD RID: 15869
		internal static int __PropertyOffset_JumpCurrentCount;

		// Token: 0x04003DFE RID: 15870
		internal static int __PropertyOffset_JumpCurrentCountPreJump;

		// Token: 0x04003DFF RID: 15871
		internal static int __PropertyOffset_OnReachedJumpApex;

		// Token: 0x04003E00 RID: 15872
		private FCharacterReachedApexSignature _OnReachedJumpApex;

		// Token: 0x04003E01 RID: 15873
		internal static int __PropertyOffset_MovementModeChangedDelegate;

		// Token: 0x04003E02 RID: 15874
		private FMovementModeChangedSignature _MovementModeChangedDelegate;

		// Token: 0x04003E03 RID: 15875
		internal static int __PropertyOffset_OnCharacterMovementUpdated;

		// Token: 0x04003E04 RID: 15876
		private FCharacterMovementUpdatedSignature _OnCharacterMovementUpdated;

		// Token: 0x04003E05 RID: 15877
		internal static int __PropertyOffset_SavedRootMotion;

		// Token: 0x04003E06 RID: 15878
		private FRootMotionSourceGroup _SavedRootMotion;

		// Token: 0x04003E07 RID: 15879
		internal static int __PropertyOffset_ClientRootMotionParams;

		// Token: 0x04003E08 RID: 15880
		private FRootMotionMovementParams _ClientRootMotionParams;

		// Token: 0x04003E09 RID: 15881
		internal static int __PropertyOffset_RootMotionRepMoves;

		// Token: 0x04003E0A RID: 15882
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSimulatedRootMotionReplicatedMove> _RootMotionRepMoves;

		// Token: 0x04003E0B RID: 15883
		internal static int __PropertyOffset_RepRootMotion;

		// Token: 0x04003E0C RID: 15884
		private FRepRootMotionMontage _RepRootMotion;

		// Token: 0x04003E0D RID: 15885
		internal static int __PropertyOffset_KuroRepRootMotion;

		// Token: 0x04003E0E RID: 15886
		private FKuroRepRootMotionMontage _KuroRepRootMotion;

		// Token: 0x02002CB1 RID: 11441
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __OnWalkingOffLedge_FunctionParams
		{
			// Token: 0x04016635 RID: 91701
			[FieldOffset(0)]
			public FVector PreviousFloorImpactNormal;

			// Token: 0x04016636 RID: 91702
			[FieldOffset(12)]
			public FVector PreviousFloorContactNormal;

			// Token: 0x04016637 RID: 91703
			[FieldOffset(24)]
			public FVector PreviousLocation;

			// Token: 0x04016638 RID: 91704
			[FieldOffset(36)]
			public float TimeDelta;
		}

		// Token: 0x02002CB2 RID: 11442
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnLaunched_FunctionParams
		{
			// Token: 0x04016639 RID: 91705
			[FieldOffset(0)]
			public FVector LaunchVelocity;

			// Token: 0x0401663A RID: 91706
			[FieldOffset(12)]
			public bool bXYOverride;

			// Token: 0x0401663B RID: 91707
			[FieldOffset(13)]
			public bool bZOverride;
		}

		// Token: 0x02002CB3 RID: 11443
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 148)]
		protected ref struct __OnLanded_FunctionParams
		{
			// Token: 0x0401663C RID: 91708
			[FieldOffset(0)]
			public byte Hit;
		}

		// Token: 0x02002CB4 RID: 11444
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __KuroReplicateRootMotion_FunctionParams
		{
			// Token: 0x0401663D RID: 91709
			[FieldOffset(0)]
			public byte Data;
		}

		// Token: 0x02002CB5 RID: 11445
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __KuroReplicateDataToServer_FunctionParams
		{
			// Token: 0x0401663E RID: 91710
			[FieldOffset(0)]
			public byte RepMovement;

			// Token: 0x0401663F RID: 91711
			[FieldOffset(52)]
			public byte MovementMode;
		}

		// Token: 0x02002CB6 RID: 11446
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 68)]
		protected ref struct __Kuro_ServerMovePacked_FunctionParams
		{
			// Token: 0x04016640 RID: 91712
			[FieldOffset(0)]
			public byte Data;
		}

		// Token: 0x02002CB7 RID: 11447
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_UpdateCustomMovement_FunctionParams
		{
			// Token: 0x04016641 RID: 91713
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02002CB8 RID: 11448
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnStartCrouch_FunctionParams
		{
			// Token: 0x04016642 RID: 91714
			[FieldOffset(0)]
			public float HalfHeightAdjust;

			// Token: 0x04016643 RID: 91715
			[FieldOffset(4)]
			public float ScaledHalfHeightAdjust;
		}

		// Token: 0x02002CB9 RID: 11449
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __K2_OnMovementModeChanged_FunctionParams
		{
			// Token: 0x04016644 RID: 91716
			[FieldOffset(0)]
			public TEnumAsByte<EMovementMode> PrevMovementMode;

			// Token: 0x04016645 RID: 91717
			[FieldOffset(1)]
			public TEnumAsByte<EMovementMode> NewMovementMode;

			// Token: 0x04016646 RID: 91718
			[FieldOffset(2)]
			public byte PrevCustomMode;

			// Token: 0x04016647 RID: 91719
			[FieldOffset(3)]
			public byte NewCustomMode;
		}

		// Token: 0x02002CBA RID: 11450
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __K2_OnEndCrouch_FunctionParams
		{
			// Token: 0x04016648 RID: 91720
			[FieldOffset(0)]
			public float HalfHeightAdjust;

			// Token: 0x04016649 RID: 91721
			[FieldOffset(4)]
			public float ScaledHalfHeightAdjust;
		}

		// Token: 0x02002CBB RID: 11451
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanJumpInternal_FunctionParams
		{
			// Token: 0x0401664A RID: 91722
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
