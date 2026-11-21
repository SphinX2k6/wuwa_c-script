using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A1 RID: 417
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CharacterMovementComponent")]
	[UnrealStructLayout(3680, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3680)]
	public class UCharacterMovementComponent : UPawnMovementComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001CDC RID: 7388 RVA: 0x0002A6C9 File Offset: 0x000288C9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCharacterMovementComponent._ClassPtr;
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x0002A6D8 File Offset: 0x000288D8
		public UCharacterMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UCharacterMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x0002A700 File Offset: 0x00028900
		[NullableContext(1)]
		public UCharacterMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCharacterMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001CDF RID: 7391 RVA: 0x0002A733 File Offset: 0x00028933
		// (set) Token: 0x06001CE0 RID: 7392 RVA: 0x0002A747 File Offset: 0x00028947
		public unsafe ACharacter CharacterOwner
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACharacter>(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_CharacterOwner);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_CharacterOwner, value);
			}
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x0002A75C File Offset: 0x0002895C
		// (set) Token: 0x06001CE2 RID: 7394 RVA: 0x0002A76C File Offset: 0x0002896C
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001CE3 RID: 7395 RVA: 0x0002A77D File Offset: 0x0002897D
		// (set) Token: 0x06001CE4 RID: 7396 RVA: 0x0002A78D File Offset: 0x0002898D
		public unsafe float MaxStepHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxStepHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxStepHeight) = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001CE5 RID: 7397 RVA: 0x0002A79E File Offset: 0x0002899E
		// (set) Token: 0x06001CE6 RID: 7398 RVA: 0x0002A7AE File Offset: 0x000289AE
		public unsafe float JumpZVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpZVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpZVelocity) = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x0002A7BF File Offset: 0x000289BF
		// (set) Token: 0x06001CE8 RID: 7400 RVA: 0x0002A7CF File Offset: 0x000289CF
		public unsafe float JumpOffJumpZFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpOffJumpZFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpOffJumpZFactor) = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x0002A7E0 File Offset: 0x000289E0
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x0002A7F0 File Offset: 0x000289F0
		public unsafe float WalkableFloorAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_WalkableFloorAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_WalkableFloorAngle) = value;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x0002A801 File Offset: 0x00028A01
		// (set) Token: 0x06001CEC RID: 7404 RVA: 0x0002A811 File Offset: 0x00028A11
		public unsafe float WalkableFloorZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_WalkableFloorZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_WalkableFloorZ) = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06001CED RID: 7405 RVA: 0x0002A822 File Offset: 0x00028A22
		// (set) Token: 0x06001CEE RID: 7406 RVA: 0x0002A836 File Offset: 0x00028A36
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> MovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MovementMode) = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06001CEF RID: 7407 RVA: 0x0002A84B File Offset: 0x00028A4B
		// (set) Token: 0x06001CF0 RID: 7408 RVA: 0x0002A85B File Offset: 0x00028A5B
		public unsafe byte CustomMovementMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CustomMovementMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CustomMovementMode) = value;
			}
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001CF1 RID: 7409 RVA: 0x0002A86C File Offset: 0x00028A6C
		// (set) Token: 0x06001CF2 RID: 7410 RVA: 0x0002A8A5 File Offset: 0x00028AA5
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TMap<byte, TSubclassOf<UKuroCustomMovementExtension>> KuroCustomMovementExtensionClasses
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TMap<byte, TSubclassOf<UKuroCustomMovementExtension>> result;
				if ((result = this._KuroCustomMovementExtensionClasses) == null)
				{
					result = (this._KuroCustomMovementExtensionClasses = new TMap<byte, TSubclassOf<UKuroCustomMovementExtension>>(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroCustomMovementExtensionClasses, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.KuroCustomMovementExtensionClasses.CopyAssign(value);
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001CF3 RID: 7411 RVA: 0x0002A8B4 File Offset: 0x00028AB4
		// (set) Token: 0x06001CF4 RID: 7412 RVA: 0x0002A8ED File Offset: 0x00028AED
		[Nullable(1)]
		public TMap<byte, UKuroCustomMovementExtension> KuroCustomMovementExtensionInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<byte, UKuroCustomMovementExtension> result;
				if ((result = this._KuroCustomMovementExtensionInstances) == null)
				{
					result = (this._KuroCustomMovementExtensionInstances = new TMap<byte, UKuroCustomMovementExtension>(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroCustomMovementExtensionInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.KuroCustomMovementExtensionInstances.CopyAssign(value);
			}
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001CF5 RID: 7413 RVA: 0x0002A8FB File Offset: 0x00028AFB
		// (set) Token: 0x06001CF6 RID: 7414 RVA: 0x0002A90B File Offset: 0x00028B0B
		public unsafe float GroundFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroundFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroundFriction) = value;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001CF7 RID: 7415 RVA: 0x0002A91C File Offset: 0x00028B1C
		// (set) Token: 0x06001CF8 RID: 7416 RVA: 0x0002A92C File Offset: 0x00028B2C
		public unsafe float MaxWalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxWalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxWalkSpeed) = value;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001CF9 RID: 7417 RVA: 0x0002A93D File Offset: 0x00028B3D
		// (set) Token: 0x06001CFA RID: 7418 RVA: 0x0002A94D File Offset: 0x00028B4D
		public unsafe float MaxWalkSpeedCrouched
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxWalkSpeedCrouched);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxWalkSpeedCrouched) = value;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001CFB RID: 7419 RVA: 0x0002A95E File Offset: 0x00028B5E
		// (set) Token: 0x06001CFC RID: 7420 RVA: 0x0002A96E File Offset: 0x00028B6E
		public unsafe float MaxSwimSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSwimSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSwimSpeed) = value;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001CFD RID: 7421 RVA: 0x0002A97F File Offset: 0x00028B7F
		// (set) Token: 0x06001CFE RID: 7422 RVA: 0x0002A98F File Offset: 0x00028B8F
		public unsafe float MaxFlySpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxFlySpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxFlySpeed) = value;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001CFF RID: 7423 RVA: 0x0002A9A0 File Offset: 0x00028BA0
		// (set) Token: 0x06001D00 RID: 7424 RVA: 0x0002A9B0 File Offset: 0x00028BB0
		public unsafe float MaxCustomMovementSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxCustomMovementSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxCustomMovementSpeed) = value;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06001D01 RID: 7425 RVA: 0x0002A9C1 File Offset: 0x00028BC1
		// (set) Token: 0x06001D02 RID: 7426 RVA: 0x0002A9D1 File Offset: 0x00028BD1
		public unsafe float MaxAcceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxAcceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxAcceleration) = value;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06001D03 RID: 7427 RVA: 0x0002A9E2 File Offset: 0x00028BE2
		// (set) Token: 0x06001D04 RID: 7428 RVA: 0x0002A9F2 File Offset: 0x00028BF2
		public unsafe float MinAnalogWalkSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinAnalogWalkSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinAnalogWalkSpeed) = value;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06001D05 RID: 7429 RVA: 0x0002AA03 File Offset: 0x00028C03
		// (set) Token: 0x06001D06 RID: 7430 RVA: 0x0002AA13 File Offset: 0x00028C13
		public unsafe float BrakingFrictionFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingFrictionFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingFrictionFactor) = value;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06001D07 RID: 7431 RVA: 0x0002AA24 File Offset: 0x00028C24
		// (set) Token: 0x06001D08 RID: 7432 RVA: 0x0002AA34 File Offset: 0x00028C34
		public unsafe float BrakingFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingFriction) = value;
			}
		}

		// Token: 0x170003A5 RID: 933
		// (get) Token: 0x06001D09 RID: 7433 RVA: 0x0002AA45 File Offset: 0x00028C45
		// (set) Token: 0x06001D0A RID: 7434 RVA: 0x0002AA55 File Offset: 0x00028C55
		public unsafe float BrakingSubStepTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingSubStepTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingSubStepTime) = value;
			}
		}

		// Token: 0x170003A6 RID: 934
		// (get) Token: 0x06001D0B RID: 7435 RVA: 0x0002AA66 File Offset: 0x00028C66
		// (set) Token: 0x06001D0C RID: 7436 RVA: 0x0002AA76 File Offset: 0x00028C76
		public unsafe float BrakingDecelerationWalking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationWalking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationWalking) = value;
			}
		}

		// Token: 0x170003A7 RID: 935
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x0002AA87 File Offset: 0x00028C87
		// (set) Token: 0x06001D0E RID: 7438 RVA: 0x0002AA97 File Offset: 0x00028C97
		public unsafe float BrakingDecelerationFalling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationFalling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationFalling) = value;
			}
		}

		// Token: 0x170003A8 RID: 936
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x0002AAA8 File Offset: 0x00028CA8
		// (set) Token: 0x06001D10 RID: 7440 RVA: 0x0002AAB8 File Offset: 0x00028CB8
		public unsafe float BrakingDecelerationSwimming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationSwimming);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationSwimming) = value;
			}
		}

		// Token: 0x170003A9 RID: 937
		// (get) Token: 0x06001D11 RID: 7441 RVA: 0x0002AAC9 File Offset: 0x00028CC9
		// (set) Token: 0x06001D12 RID: 7442 RVA: 0x0002AAD9 File Offset: 0x00028CD9
		public unsafe float BrakingDecelerationFlying
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationFlying);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BrakingDecelerationFlying) = value;
			}
		}

		// Token: 0x170003AA RID: 938
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x0002AAEA File Offset: 0x00028CEA
		// (set) Token: 0x06001D14 RID: 7444 RVA: 0x0002AAFA File Offset: 0x00028CFA
		public unsafe float AirControl
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControl);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControl) = value;
			}
		}

		// Token: 0x170003AB RID: 939
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x0002AB0B File Offset: 0x00028D0B
		// (set) Token: 0x06001D16 RID: 7446 RVA: 0x0002AB1B File Offset: 0x00028D1B
		public unsafe float AirControlBoostMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControlBoostMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControlBoostMultiplier) = value;
			}
		}

		// Token: 0x170003AC RID: 940
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0002AB2C File Offset: 0x00028D2C
		// (set) Token: 0x06001D18 RID: 7448 RVA: 0x0002AB3C File Offset: 0x00028D3C
		public unsafe float AirControlBoostVelocityThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControlBoostVelocityThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AirControlBoostVelocityThreshold) = value;
			}
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001D19 RID: 7449 RVA: 0x0002AB4D File Offset: 0x00028D4D
		// (set) Token: 0x06001D1A RID: 7450 RVA: 0x0002AB5D File Offset: 0x00028D5D
		public unsafe float FallingLateralFriction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_FallingLateralFriction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_FallingLateralFriction) = value;
			}
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0002AB6E File Offset: 0x00028D6E
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0002AB7E File Offset: 0x00028D7E
		public unsafe float CrouchedHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CrouchedHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CrouchedHalfHeight) = value;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x0002AB8F File Offset: 0x00028D8F
		// (set) Token: 0x06001D1E RID: 7454 RVA: 0x0002AB9F File Offset: 0x00028D9F
		public unsafe float Buoyancy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Buoyancy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Buoyancy) = value;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x0002ABB0 File Offset: 0x00028DB0
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0002ABC0 File Offset: 0x00028DC0
		public unsafe float PerchRadiusThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PerchRadiusThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PerchRadiusThreshold) = value;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0002ABD1 File Offset: 0x00028DD1
		// (set) Token: 0x06001D22 RID: 7458 RVA: 0x0002ABE1 File Offset: 0x00028DE1
		public unsafe float PerchAdditionalHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PerchAdditionalHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PerchAdditionalHeight) = value;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001D23 RID: 7459 RVA: 0x0002ABF2 File Offset: 0x00028DF2
		// (set) Token: 0x06001D24 RID: 7460 RVA: 0x0002AC06 File Offset: 0x00028E06
		public unsafe FRotator RotationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RotationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RotationRate) = value;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001D25 RID: 7461 RVA: 0x0002AC1B File Offset: 0x00028E1B
		// (set) Token: 0x06001D26 RID: 7462 RVA: 0x0002AC34 File Offset: 0x00028E34
		public unsafe bool bUseSeparateBrakingFriction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseSeparateBrakingFriction) & UCharacterMovementComponent.__PropertyMask_bUseSeparateBrakingFriction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseSeparateBrakingFriction) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseSeparateBrakingFriction) & ~UCharacterMovementComponent.__PropertyMask_bUseSeparateBrakingFriction) | (value ? UCharacterMovementComponent.__PropertyMask_bUseSeparateBrakingFriction : 0));
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0002AC64 File Offset: 0x00028E64
		// (set) Token: 0x06001D28 RID: 7464 RVA: 0x0002AC7D File Offset: 0x00028E7D
		public unsafe bool bApplyGravityWhileJumping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bApplyGravityWhileJumping) & UCharacterMovementComponent.__PropertyMask_bApplyGravityWhileJumping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bApplyGravityWhileJumping) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bApplyGravityWhileJumping) & ~UCharacterMovementComponent.__PropertyMask_bApplyGravityWhileJumping) | (value ? UCharacterMovementComponent.__PropertyMask_bApplyGravityWhileJumping : 0));
			}
		}

		// Token: 0x170003B5 RID: 949
		// (get) Token: 0x06001D29 RID: 7465 RVA: 0x0002ACAD File Offset: 0x00028EAD
		// (set) Token: 0x06001D2A RID: 7466 RVA: 0x0002ACC6 File Offset: 0x00028EC6
		public unsafe bool bUseControllerDesiredRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) & UCharacterMovementComponent.__PropertyMask_bUseControllerDesiredRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseControllerDesiredRotation) & ~UCharacterMovementComponent.__PropertyMask_bUseControllerDesiredRotation) | (value ? UCharacterMovementComponent.__PropertyMask_bUseControllerDesiredRotation : 0));
			}
		}

		// Token: 0x170003B6 RID: 950
		// (get) Token: 0x06001D2B RID: 7467 RVA: 0x0002ACF6 File Offset: 0x00028EF6
		// (set) Token: 0x06001D2C RID: 7468 RVA: 0x0002AD0F File Offset: 0x00028F0F
		public unsafe bool bOrientRotationToMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bOrientRotationToMovement) & UCharacterMovementComponent.__PropertyMask_bOrientRotationToMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bOrientRotationToMovement) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bOrientRotationToMovement) & ~UCharacterMovementComponent.__PropertyMask_bOrientRotationToMovement) | (value ? UCharacterMovementComponent.__PropertyMask_bOrientRotationToMovement : 0));
			}
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x0002AD3F File Offset: 0x00028F3F
		// (set) Token: 0x06001D2E RID: 7470 RVA: 0x0002AD58 File Offset: 0x00028F58
		public unsafe bool bRotationFollowBaseMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRotationFollowBaseMovement) & UCharacterMovementComponent.__PropertyMask_bRotationFollowBaseMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRotationFollowBaseMovement) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRotationFollowBaseMovement) & ~UCharacterMovementComponent.__PropertyMask_bRotationFollowBaseMovement) | (value ? UCharacterMovementComponent.__PropertyMask_bRotationFollowBaseMovement : 0));
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x0002AD88 File Offset: 0x00028F88
		// (set) Token: 0x06001D30 RID: 7472 RVA: 0x0002ADA1 File Offset: 0x00028FA1
		public unsafe bool bSweepWhileNavWalking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bSweepWhileNavWalking) & UCharacterMovementComponent.__PropertyMask_bSweepWhileNavWalking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bSweepWhileNavWalking) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bSweepWhileNavWalking) & ~UCharacterMovementComponent.__PropertyMask_bSweepWhileNavWalking) | (value ? UCharacterMovementComponent.__PropertyMask_bSweepWhileNavWalking : 0));
			}
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x0002ADD1 File Offset: 0x00028FD1
		// (set) Token: 0x06001D32 RID: 7474 RVA: 0x0002ADE1 File Offset: 0x00028FE1
		public unsafe bool bKuroAutoActiveNav
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroAutoActiveNav) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroAutoActiveNav) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001D33 RID: 7475 RVA: 0x0002ADF2 File Offset: 0x00028FF2
		// (set) Token: 0x06001D34 RID: 7476 RVA: 0x0002AE02 File Offset: 0x00029002
		public unsafe bool bKuroStillBlockInNav
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroStillBlockInNav) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroStillBlockInNav) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001D35 RID: 7477 RVA: 0x0002AE13 File Offset: 0x00029013
		// (set) Token: 0x06001D36 RID: 7478 RVA: 0x0002AE23 File Offset: 0x00029023
		public unsafe float OverrideTerminalVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_OverrideTerminalVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_OverrideTerminalVelocity) = value;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001D37 RID: 7479 RVA: 0x0002AE34 File Offset: 0x00029034
		// (set) Token: 0x06001D38 RID: 7480 RVA: 0x0002AE44 File Offset: 0x00029044
		public unsafe int HitPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_HitPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_HitPriority) = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001D39 RID: 7481 RVA: 0x0002AE55 File Offset: 0x00029055
		// (set) Token: 0x06001D3A RID: 7482 RVA: 0x0002AE65 File Offset: 0x00029065
		public unsafe bool GoThroughLower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GoThroughLower) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GoThroughLower) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001D3B RID: 7483 RVA: 0x0002AE76 File Offset: 0x00029076
		// (set) Token: 0x06001D3C RID: 7484 RVA: 0x0002AE86 File Offset: 0x00029086
		public unsafe int GoThroughPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GoThroughPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GoThroughPriority) = value;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001D3D RID: 7485 RVA: 0x0002AE97 File Offset: 0x00029097
		// (set) Token: 0x06001D3E RID: 7486 RVA: 0x0002AEA7 File Offset: 0x000290A7
		public unsafe bool bKuroStopUpdateBasedMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroStopUpdateBasedMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroStopUpdateBasedMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001D3F RID: 7487 RVA: 0x0002AEB8 File Offset: 0x000290B8
		// (set) Token: 0x06001D40 RID: 7488 RVA: 0x0002AEC8 File Offset: 0x000290C8
		public unsafe bool bForbiddenTickPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForbiddenTickPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForbiddenTickPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001D41 RID: 7489 RVA: 0x0002AED9 File Offset: 0x000290D9
		// (set) Token: 0x06001D42 RID: 7490 RVA: 0x0002AEE9 File Offset: 0x000290E9
		public unsafe bool bKuroWalkOnAir
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroWalkOnAir) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroWalkOnAir) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001D43 RID: 7491 RVA: 0x0002AEFA File Offset: 0x000290FA
		// (set) Token: 0x06001D44 RID: 7492 RVA: 0x0002AF0E File Offset: 0x0002910E
		public unsafe FVector ConveyDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ConveyDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ConveyDelta) = value;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001D45 RID: 7493 RVA: 0x0002AF23 File Offset: 0x00029123
		// (set) Token: 0x06001D46 RID: 7494 RVA: 0x0002AF3C File Offset: 0x0002913C
		public unsafe bool bMovementInProgress
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMovementInProgress) & UCharacterMovementComponent.__PropertyMask_bMovementInProgress) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMovementInProgress) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMovementInProgress) & ~UCharacterMovementComponent.__PropertyMask_bMovementInProgress) | (value ? UCharacterMovementComponent.__PropertyMask_bMovementInProgress : 0));
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001D47 RID: 7495 RVA: 0x0002AF6C File Offset: 0x0002916C
		// (set) Token: 0x06001D48 RID: 7496 RVA: 0x0002AF85 File Offset: 0x00029185
		public unsafe bool bEnableScopedMovementUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) & UCharacterMovementComponent.__PropertyMask_bEnableScopedMovementUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableScopedMovementUpdates) & ~UCharacterMovementComponent.__PropertyMask_bEnableScopedMovementUpdates) | (value ? UCharacterMovementComponent.__PropertyMask_bEnableScopedMovementUpdates : 0));
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001D49 RID: 7497 RVA: 0x0002AFB5 File Offset: 0x000291B5
		// (set) Token: 0x06001D4A RID: 7498 RVA: 0x0002AFCE File Offset: 0x000291CE
		public unsafe bool bEnableServerDualMoveScopedMovementUpdates
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableServerDualMoveScopedMovementUpdates) & UCharacterMovementComponent.__PropertyMask_bEnableServerDualMoveScopedMovementUpdates) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableServerDualMoveScopedMovementUpdates) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnableServerDualMoveScopedMovementUpdates) & ~UCharacterMovementComponent.__PropertyMask_bEnableServerDualMoveScopedMovementUpdates) | (value ? UCharacterMovementComponent.__PropertyMask_bEnableServerDualMoveScopedMovementUpdates : 0));
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001D4B RID: 7499 RVA: 0x0002AFFE File Offset: 0x000291FE
		// (set) Token: 0x06001D4C RID: 7500 RVA: 0x0002B017 File Offset: 0x00029217
		public unsafe bool bForceMaxAccel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceMaxAccel) & UCharacterMovementComponent.__PropertyMask_bForceMaxAccel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceMaxAccel) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceMaxAccel) & ~UCharacterMovementComponent.__PropertyMask_bForceMaxAccel) | (value ? UCharacterMovementComponent.__PropertyMask_bForceMaxAccel : 0));
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001D4D RID: 7501 RVA: 0x0002B047 File Offset: 0x00029247
		// (set) Token: 0x06001D4E RID: 7502 RVA: 0x0002B060 File Offset: 0x00029260
		public unsafe bool bRunPhysicsWithNoController
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) & UCharacterMovementComponent.__PropertyMask_bRunPhysicsWithNoController) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRunPhysicsWithNoController) & ~UCharacterMovementComponent.__PropertyMask_bRunPhysicsWithNoController) | (value ? UCharacterMovementComponent.__PropertyMask_bRunPhysicsWithNoController : 0));
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001D4F RID: 7503 RVA: 0x0002B090 File Offset: 0x00029290
		// (set) Token: 0x06001D50 RID: 7504 RVA: 0x0002B0A9 File Offset: 0x000292A9
		public unsafe bool bForceNextFloorCheck
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceNextFloorCheck) & UCharacterMovementComponent.__PropertyMask_bForceNextFloorCheck) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceNextFloorCheck) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bForceNextFloorCheck) & ~UCharacterMovementComponent.__PropertyMask_bForceNextFloorCheck) | (value ? UCharacterMovementComponent.__PropertyMask_bForceNextFloorCheck : 0));
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001D51 RID: 7505 RVA: 0x0002B0D9 File Offset: 0x000292D9
		// (set) Token: 0x06001D52 RID: 7506 RVA: 0x0002B0F2 File Offset: 0x000292F2
		public unsafe bool bShrinkProxyCapsule
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bShrinkProxyCapsule) & UCharacterMovementComponent.__PropertyMask_bShrinkProxyCapsule) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bShrinkProxyCapsule) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bShrinkProxyCapsule) & ~UCharacterMovementComponent.__PropertyMask_bShrinkProxyCapsule) | (value ? UCharacterMovementComponent.__PropertyMask_bShrinkProxyCapsule : 0));
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001D53 RID: 7507 RVA: 0x0002B122 File Offset: 0x00029322
		// (set) Token: 0x06001D54 RID: 7508 RVA: 0x0002B13B File Offset: 0x0002933B
		public unsafe bool bCanWalkOffLedges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedges) & UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedges) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedges) & ~UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedges) | (value ? UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedges : 0));
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001D55 RID: 7509 RVA: 0x0002B16B File Offset: 0x0002936B
		// (set) Token: 0x06001D56 RID: 7510 RVA: 0x0002B184 File Offset: 0x00029384
		public unsafe bool bCanWalkOffLedgesWhenCrouching
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedgesWhenCrouching) & UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedgesWhenCrouching) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedgesWhenCrouching) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCanWalkOffLedgesWhenCrouching) & ~UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedgesWhenCrouching) | (value ? UCharacterMovementComponent.__PropertyMask_bCanWalkOffLedgesWhenCrouching : 0));
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001D57 RID: 7511 RVA: 0x0002B1B4 File Offset: 0x000293B4
		// (set) Token: 0x06001D58 RID: 7512 RVA: 0x0002B1CD File Offset: 0x000293CD
		public unsafe bool bKuroCanWalkOffLedgesNav
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroCanWalkOffLedgesNav) & UCharacterMovementComponent.__PropertyMask_bKuroCanWalkOffLedgesNav) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroCanWalkOffLedgesNav) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroCanWalkOffLedgesNav) & ~UCharacterMovementComponent.__PropertyMask_bKuroCanWalkOffLedgesNav) | (value ? UCharacterMovementComponent.__PropertyMask_bKuroCanWalkOffLedgesNav : 0));
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001D59 RID: 7513 RVA: 0x0002B1FD File Offset: 0x000293FD
		// (set) Token: 0x06001D5A RID: 7514 RVA: 0x0002B216 File Offset: 0x00029416
		public unsafe bool bKuroUsePerchEdgeDirection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroUsePerchEdgeDirection) & UCharacterMovementComponent.__PropertyMask_bKuroUsePerchEdgeDirection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroUsePerchEdgeDirection) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroUsePerchEdgeDirection) & ~UCharacterMovementComponent.__PropertyMask_bKuroUsePerchEdgeDirection) | (value ? UCharacterMovementComponent.__PropertyMask_bKuroUsePerchEdgeDirection : 0));
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001D5B RID: 7515 RVA: 0x0002B246 File Offset: 0x00029446
		// (set) Token: 0x06001D5C RID: 7516 RVA: 0x0002B25F File Offset: 0x0002945F
		public unsafe bool bKuroPlanarPhysWalking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarPhysWalking) & UCharacterMovementComponent.__PropertyMask_bKuroPlanarPhysWalking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarPhysWalking) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarPhysWalking) & ~UCharacterMovementComponent.__PropertyMask_bKuroPlanarPhysWalking) | (value ? UCharacterMovementComponent.__PropertyMask_bKuroPlanarPhysWalking : 0));
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001D5D RID: 7517 RVA: 0x0002B28F File Offset: 0x0002948F
		// (set) Token: 0x06001D5E RID: 7518 RVA: 0x0002B2A8 File Offset: 0x000294A8
		public unsafe bool bKuroPlanarNeedFindFloor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarNeedFindFloor) & UCharacterMovementComponent.__PropertyMask_bKuroPlanarNeedFindFloor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarNeedFindFloor) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroPlanarNeedFindFloor) & ~UCharacterMovementComponent.__PropertyMask_bKuroPlanarNeedFindFloor) | (value ? UCharacterMovementComponent.__PropertyMask_bKuroPlanarNeedFindFloor : 0));
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001D5F RID: 7519 RVA: 0x0002B2D8 File Offset: 0x000294D8
		// (set) Token: 0x06001D60 RID: 7520 RVA: 0x0002B2F1 File Offset: 0x000294F1
		public unsafe bool bNetworkSkipProxyPredictionOnNetUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkSkipProxyPredictionOnNetUpdate) & UCharacterMovementComponent.__PropertyMask_bNetworkSkipProxyPredictionOnNetUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkSkipProxyPredictionOnNetUpdate) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkSkipProxyPredictionOnNetUpdate) & ~UCharacterMovementComponent.__PropertyMask_bNetworkSkipProxyPredictionOnNetUpdate) | (value ? UCharacterMovementComponent.__PropertyMask_bNetworkSkipProxyPredictionOnNetUpdate : 0));
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001D61 RID: 7521 RVA: 0x0002B321 File Offset: 0x00029521
		// (set) Token: 0x06001D62 RID: 7522 RVA: 0x0002B33A File Offset: 0x0002953A
		public unsafe bool bNetworkAlwaysReplicateTransformUpdateTimestamp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkAlwaysReplicateTransformUpdateTimestamp) & UCharacterMovementComponent.__PropertyMask_bNetworkAlwaysReplicateTransformUpdateTimestamp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkAlwaysReplicateTransformUpdateTimestamp) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkAlwaysReplicateTransformUpdateTimestamp) & ~UCharacterMovementComponent.__PropertyMask_bNetworkAlwaysReplicateTransformUpdateTimestamp) | (value ? UCharacterMovementComponent.__PropertyMask_bNetworkAlwaysReplicateTransformUpdateTimestamp : 0));
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001D63 RID: 7523 RVA: 0x0002B36A File Offset: 0x0002956A
		// (set) Token: 0x06001D64 RID: 7524 RVA: 0x0002B383 File Offset: 0x00029583
		public unsafe bool bDeferUpdateMoveComponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) & UCharacterMovementComponent.__PropertyMask_bDeferUpdateMoveComponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bDeferUpdateMoveComponent) & ~UCharacterMovementComponent.__PropertyMask_bDeferUpdateMoveComponent) | (value ? UCharacterMovementComponent.__PropertyMask_bDeferUpdateMoveComponent : 0));
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001D65 RID: 7525 RVA: 0x0002B3B3 File Offset: 0x000295B3
		// (set) Token: 0x06001D66 RID: 7526 RVA: 0x0002B3CC File Offset: 0x000295CC
		public unsafe bool bEnablePhysicsInteraction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnablePhysicsInteraction) & UCharacterMovementComponent.__PropertyMask_bEnablePhysicsInteraction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnablePhysicsInteraction) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bEnablePhysicsInteraction) & ~UCharacterMovementComponent.__PropertyMask_bEnablePhysicsInteraction) | (value ? UCharacterMovementComponent.__PropertyMask_bEnablePhysicsInteraction : 0));
			}
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001D67 RID: 7527 RVA: 0x0002B3FC File Offset: 0x000295FC
		// (set) Token: 0x06001D68 RID: 7528 RVA: 0x0002B415 File Offset: 0x00029615
		public unsafe bool bTouchForceScaledToMass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bTouchForceScaledToMass) & UCharacterMovementComponent.__PropertyMask_bTouchForceScaledToMass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bTouchForceScaledToMass) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bTouchForceScaledToMass) & ~UCharacterMovementComponent.__PropertyMask_bTouchForceScaledToMass) | (value ? UCharacterMovementComponent.__PropertyMask_bTouchForceScaledToMass : 0));
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001D69 RID: 7529 RVA: 0x0002B445 File Offset: 0x00029645
		// (set) Token: 0x06001D6A RID: 7530 RVA: 0x0002B45E File Offset: 0x0002965E
		public unsafe bool bPushForceScaledToMass
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceScaledToMass) & UCharacterMovementComponent.__PropertyMask_bPushForceScaledToMass) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceScaledToMass) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceScaledToMass) & ~UCharacterMovementComponent.__PropertyMask_bPushForceScaledToMass) | (value ? UCharacterMovementComponent.__PropertyMask_bPushForceScaledToMass : 0));
			}
		}

		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06001D6B RID: 7531 RVA: 0x0002B48E File Offset: 0x0002968E
		// (set) Token: 0x06001D6C RID: 7532 RVA: 0x0002B4A7 File Offset: 0x000296A7
		public unsafe bool bPushForceUsingZOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceUsingZOffset) & UCharacterMovementComponent.__PropertyMask_bPushForceUsingZOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceUsingZOffset) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPushForceUsingZOffset) & ~UCharacterMovementComponent.__PropertyMask_bPushForceUsingZOffset) | (value ? UCharacterMovementComponent.__PropertyMask_bPushForceUsingZOffset : 0));
			}
		}

		// Token: 0x170003D7 RID: 983
		// (get) Token: 0x06001D6D RID: 7533 RVA: 0x0002B4D7 File Offset: 0x000296D7
		// (set) Token: 0x06001D6E RID: 7534 RVA: 0x0002B4F0 File Offset: 0x000296F0
		public unsafe bool bScalePushForceToVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bScalePushForceToVelocity) & UCharacterMovementComponent.__PropertyMask_bScalePushForceToVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bScalePushForceToVelocity) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bScalePushForceToVelocity) & ~UCharacterMovementComponent.__PropertyMask_bScalePushForceToVelocity) | (value ? UCharacterMovementComponent.__PropertyMask_bScalePushForceToVelocity : 0));
			}
		}

		// Token: 0x170003D8 RID: 984
		// (get) Token: 0x06001D6F RID: 7535 RVA: 0x0002B520 File Offset: 0x00029720
		// (set) Token: 0x06001D70 RID: 7536 RVA: 0x0002B534 File Offset: 0x00029734
		public unsafe USceneComponent DeferredUpdatedMoveComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent, value);
			}
		}

		// Token: 0x170003D9 RID: 985
		// (get) Token: 0x06001D71 RID: 7537 RVA: 0x0002B549 File Offset: 0x00029749
		// (set) Token: 0x06001D72 RID: 7538 RVA: 0x0002B559 File Offset: 0x00029759
		public unsafe float StepUpSpeedPrecent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpSpeedPrecent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpSpeedPrecent) = value;
			}
		}

		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001D73 RID: 7539 RVA: 0x0002B56A File Offset: 0x0002976A
		// (set) Token: 0x06001D74 RID: 7540 RVA: 0x0002B57A File Offset: 0x0002977A
		public unsafe float StepDownSpeedPrecent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepDownSpeedPrecent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepDownSpeedPrecent) = value;
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001D75 RID: 7541 RVA: 0x0002B58B File Offset: 0x0002978B
		// (set) Token: 0x06001D76 RID: 7542 RVA: 0x0002B59B File Offset: 0x0002979B
		public unsafe float StepUpDeltaPrecent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpDeltaPrecent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpDeltaPrecent) = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001D77 RID: 7543 RVA: 0x0002B5AC File Offset: 0x000297AC
		// (set) Token: 0x06001D78 RID: 7544 RVA: 0x0002B5BC File Offset: 0x000297BC
		public unsafe float StepUpStandardSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpStandardSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StepUpStandardSpeed) = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x06001D79 RID: 7545 RVA: 0x0002B5CD File Offset: 0x000297CD
		// (set) Token: 0x06001D7A RID: 7546 RVA: 0x0002B5DD File Offset: 0x000297DD
		public unsafe float MaxOutOfWaterStepHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxOutOfWaterStepHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxOutOfWaterStepHeight) = value;
			}
		}

		// Token: 0x170003DE RID: 990
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x0002B5EE File Offset: 0x000297EE
		// (set) Token: 0x06001D7C RID: 7548 RVA: 0x0002B5FE File Offset: 0x000297FE
		public unsafe float OutofWaterZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_OutofWaterZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_OutofWaterZ) = value;
			}
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001D7D RID: 7549 RVA: 0x0002B60F File Offset: 0x0002980F
		// (set) Token: 0x06001D7E RID: 7550 RVA: 0x0002B61F File Offset: 0x0002981F
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D7F RID: 7551 RVA: 0x0002B630 File Offset: 0x00029830
		// (set) Token: 0x06001D80 RID: 7552 RVA: 0x0002B640 File Offset: 0x00029840
		public unsafe float StandingDownwardForceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StandingDownwardForceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_StandingDownwardForceScale) = value;
			}
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x0002B651 File Offset: 0x00029851
		// (set) Token: 0x06001D82 RID: 7554 RVA: 0x0002B661 File Offset: 0x00029861
		public unsafe float InitialPushForceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_InitialPushForceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_InitialPushForceFactor) = value;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x0002B672 File Offset: 0x00029872
		// (set) Token: 0x06001D84 RID: 7556 RVA: 0x0002B682 File Offset: 0x00029882
		public unsafe float PushForceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PushForceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PushForceFactor) = value;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x0002B693 File Offset: 0x00029893
		// (set) Token: 0x06001D86 RID: 7558 RVA: 0x0002B6A3 File Offset: 0x000298A3
		public unsafe float PushForcePointZOffsetFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PushForcePointZOffsetFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PushForcePointZOffsetFactor) = value;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001D87 RID: 7559 RVA: 0x0002B6B4 File Offset: 0x000298B4
		// (set) Token: 0x06001D88 RID: 7560 RVA: 0x0002B6C4 File Offset: 0x000298C4
		public unsafe float TouchForceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_TouchForceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_TouchForceFactor) = value;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001D89 RID: 7561 RVA: 0x0002B6D5 File Offset: 0x000298D5
		// (set) Token: 0x06001D8A RID: 7562 RVA: 0x0002B6E5 File Offset: 0x000298E5
		public unsafe float MinTouchForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinTouchForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinTouchForce) = value;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001D8B RID: 7563 RVA: 0x0002B6F6 File Offset: 0x000298F6
		// (set) Token: 0x06001D8C RID: 7564 RVA: 0x0002B706 File Offset: 0x00029906
		public unsafe float MaxTouchForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxTouchForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxTouchForce) = value;
			}
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001D8D RID: 7565 RVA: 0x0002B717 File Offset: 0x00029917
		// (set) Token: 0x06001D8E RID: 7566 RVA: 0x0002B727 File Offset: 0x00029927
		public unsafe float RepulsionForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RepulsionForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RepulsionForce) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x0002B738 File Offset: 0x00029938
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x0002B74C File Offset: 0x0002994C
		public unsafe FVector Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001D91 RID: 7569 RVA: 0x0002B761 File Offset: 0x00029961
		// (set) Token: 0x06001D92 RID: 7570 RVA: 0x0002B775 File Offset: 0x00029975
		public unsafe FQuat LastUpdateRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateRotation) = value;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001D93 RID: 7571 RVA: 0x0002B78A File Offset: 0x0002998A
		// (set) Token: 0x06001D94 RID: 7572 RVA: 0x0002B79E File Offset: 0x0002999E
		public unsafe FVector LastUpdateLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateLocation) = value;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x0002B7B3 File Offset: 0x000299B3
		// (set) Token: 0x06001D96 RID: 7574 RVA: 0x0002B7C7 File Offset: 0x000299C7
		public unsafe FVector LastUpdateVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LastUpdateVelocity) = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001D97 RID: 7575 RVA: 0x0002B7DC File Offset: 0x000299DC
		// (set) Token: 0x06001D98 RID: 7576 RVA: 0x0002B7EC File Offset: 0x000299EC
		public unsafe float ServerLastTransformUpdateTimeStamp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastTransformUpdateTimeStamp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastTransformUpdateTimeStamp) = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001D99 RID: 7577 RVA: 0x0002B7FD File Offset: 0x000299FD
		// (set) Token: 0x06001D9A RID: 7578 RVA: 0x0002B80D File Offset: 0x00029A0D
		public unsafe float ServerLastClientGoodMoveAckTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastClientGoodMoveAckTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastClientGoodMoveAckTime) = value;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x0002B81E File Offset: 0x00029A1E
		// (set) Token: 0x06001D9C RID: 7580 RVA: 0x0002B82E File Offset: 0x00029A2E
		public unsafe float ServerLastClientAdjustmentTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastClientAdjustmentTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerLastClientAdjustmentTime) = value;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x0002B83F File Offset: 0x00029A3F
		// (set) Token: 0x06001D9E RID: 7582 RVA: 0x0002B853 File Offset: 0x00029A53
		public unsafe FVector PendingImpulseToApply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingImpulseToApply);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingImpulseToApply) = value;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x0002B868 File Offset: 0x00029A68
		// (set) Token: 0x06001DA0 RID: 7584 RVA: 0x0002B87C File Offset: 0x00029A7C
		public unsafe FVector PendingForceToApply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingForceToApply);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingForceToApply) = value;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06001DA1 RID: 7585 RVA: 0x0002B891 File Offset: 0x00029A91
		// (set) Token: 0x06001DA2 RID: 7586 RVA: 0x0002B8A1 File Offset: 0x00029AA1
		public unsafe float AnalogInputModifier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnalogInputModifier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnalogInputModifier) = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06001DA3 RID: 7587 RVA: 0x0002B8B2 File Offset: 0x00029AB2
		// (set) Token: 0x06001DA4 RID: 7588 RVA: 0x0002B8C6 File Offset: 0x00029AC6
		public unsafe FVector BaseDeltaPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BaseDeltaPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BaseDeltaPosition) = value;
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06001DA5 RID: 7589 RVA: 0x0002B8DB File Offset: 0x00029ADB
		// (set) Token: 0x06001DA6 RID: 7590 RVA: 0x0002B8EF File Offset: 0x00029AEF
		public unsafe FQuat BaseDeltaQuat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BaseDeltaQuat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_BaseDeltaQuat) = value;
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x0002B904 File Offset: 0x00029B04
		// (set) Token: 0x06001DA8 RID: 7592 RVA: 0x0002B914 File Offset: 0x00029B14
		public unsafe float ReplayDriverTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ReplayDriverTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ReplayDriverTime) = value;
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x06001DA9 RID: 7593 RVA: 0x0002B925 File Offset: 0x00029B25
		// (set) Token: 0x06001DAA RID: 7594 RVA: 0x0002B935 File Offset: 0x00029B35
		public unsafe bool bKuroVelocityDebug
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroVelocityDebug) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroVelocityDebug) = (value ? 1 : 0);
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06001DAB RID: 7595 RVA: 0x0002B946 File Offset: 0x00029B46
		// (set) Token: 0x06001DAC RID: 7596 RVA: 0x0002B956 File Offset: 0x00029B56
		public unsafe float MonitorMaxVelocityZ
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MonitorMaxVelocityZ);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MonitorMaxVelocityZ) = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06001DAD RID: 7597 RVA: 0x0002B967 File Offset: 0x00029B67
		// (set) Token: 0x06001DAE RID: 7598 RVA: 0x0002B977 File Offset: 0x00029B77
		public unsafe float MaxSimulationTimeStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSimulationTimeStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSimulationTimeStep) = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06001DAF RID: 7599 RVA: 0x0002B988 File Offset: 0x00029B88
		// (set) Token: 0x06001DB0 RID: 7600 RVA: 0x0002B998 File Offset: 0x00029B98
		public unsafe int MaxSimulationIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSimulationIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxSimulationIterations) = value;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06001DB1 RID: 7601 RVA: 0x0002B9A9 File Offset: 0x00029BA9
		// (set) Token: 0x06001DB2 RID: 7602 RVA: 0x0002B9B9 File Offset: 0x00029BB9
		public unsafe int MaxJumpApexAttemptsPerSimulation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxJumpApexAttemptsPerSimulation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxJumpApexAttemptsPerSimulation) = value;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06001DB3 RID: 7603 RVA: 0x0002B9CA File Offset: 0x00029BCA
		// (set) Token: 0x06001DB4 RID: 7604 RVA: 0x0002B9DA File Offset: 0x00029BDA
		public unsafe float MaxDepenetrationWithGeometry
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometry);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometry) = value;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x0002B9EB File Offset: 0x00029BEB
		// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x0002B9FB File Offset: 0x00029BFB
		public unsafe float MaxDepenetrationWithGeometryAsProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometryAsProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithGeometryAsProxy) = value;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x0002BA0C File Offset: 0x00029C0C
		// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x0002BA1C File Offset: 0x00029C1C
		public unsafe float MaxDepenetrationWithPawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithPawn);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithPawn) = value;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x0002BA2D File Offset: 0x00029C2D
		// (set) Token: 0x06001DBA RID: 7610 RVA: 0x0002BA3D File Offset: 0x00029C3D
		public unsafe float MaxDepenetrationWithPawnAsProxy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithPawnAsProxy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationWithPawnAsProxy) = value;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001DBB RID: 7611 RVA: 0x0002BA4E File Offset: 0x00029C4E
		// (set) Token: 0x06001DBC RID: 7612 RVA: 0x0002BA5E File Offset: 0x00029C5E
		public unsafe float MaxDepenetrationPerSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationPerSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MaxDepenetrationPerSeconds) = value;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0002BA6F File Offset: 0x00029C6F
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0002BA7F File Offset: 0x00029C7F
		public unsafe float NetworkSimulatedSmoothLocationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSimulatedSmoothLocationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSimulatedSmoothLocationTime) = value;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0002BA90 File Offset: 0x00029C90
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0002BAA0 File Offset: 0x00029CA0
		public unsafe float NetworkSimulatedSmoothRotationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSimulatedSmoothRotationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSimulatedSmoothRotationTime) = value;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0002BAB1 File Offset: 0x00029CB1
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0002BAC1 File Offset: 0x00029CC1
		public unsafe float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ListenServerNetworkSimulatedSmoothLocationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ListenServerNetworkSimulatedSmoothLocationTime) = value;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0002BAD2 File Offset: 0x00029CD2
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0002BAE2 File Offset: 0x00029CE2
		public unsafe float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ListenServerNetworkSimulatedSmoothRotationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ListenServerNetworkSimulatedSmoothRotationTime) = value;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0002BAF3 File Offset: 0x00029CF3
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x0002BB03 File Offset: 0x00029D03
		public unsafe float NetProxyShrinkRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetProxyShrinkRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetProxyShrinkRadius) = value;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x0002BB14 File Offset: 0x00029D14
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0002BB24 File Offset: 0x00029D24
		public unsafe float NetProxyShrinkHalfHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetProxyShrinkHalfHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetProxyShrinkHalfHeight) = value;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x0002BB35 File Offset: 0x00029D35
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x0002BB45 File Offset: 0x00029D45
		public unsafe float NetworkMaxSmoothUpdateDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMaxSmoothUpdateDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMaxSmoothUpdateDistance) = value;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0002BB56 File Offset: 0x00029D56
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x0002BB66 File Offset: 0x00029D66
		public unsafe float NetworkNoSmoothUpdateDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkNoSmoothUpdateDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkNoSmoothUpdateDistance) = value;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0002BB77 File Offset: 0x00029D77
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0002BB87 File Offset: 0x00029D87
		public unsafe float NetworkMinTimeBetweenClientAckGoodMoves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAckGoodMoves);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAckGoodMoves) = value;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001DCF RID: 7631 RVA: 0x0002BB98 File Offset: 0x00029D98
		// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x0002BBA8 File Offset: 0x00029DA8
		public unsafe float NetworkMinTimeBetweenClientAdjustments
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAdjustments);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAdjustments) = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x0002BBB9 File Offset: 0x00029DB9
		// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x0002BBC9 File Offset: 0x00029DC9
		public unsafe float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection) = value;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x0002BBDA File Offset: 0x00029DDA
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x0002BBEA File Offset: 0x00029DEA
		public unsafe float NetworkLargeClientCorrectionDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkLargeClientCorrectionDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkLargeClientCorrectionDistance) = value;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001DD5 RID: 7637 RVA: 0x0002BBFB File Offset: 0x00029DFB
		// (set) Token: 0x06001DD6 RID: 7638 RVA: 0x0002BC0B File Offset: 0x00029E0B
		public unsafe float NetworkPredictingLinearSmoothMaxRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingLinearSmoothMaxRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingLinearSmoothMaxRange) = value;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001DD7 RID: 7639 RVA: 0x0002BC1C File Offset: 0x00029E1C
		// (set) Token: 0x06001DD8 RID: 7640 RVA: 0x0002BC2C File Offset: 0x00029E2C
		public unsafe float NetworkPredictingSmoothFactorWithDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingSmoothFactorWithDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingSmoothFactorWithDistance) = value;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x0002BC3D File Offset: 0x00029E3D
		// (set) Token: 0x06001DDA RID: 7642 RVA: 0x0002BC4D File Offset: 0x00029E4D
		public unsafe float NetworkPredictingSmoothFactorWithSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingSmoothFactorWithSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingSmoothFactorWithSpeed) = value;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001DDB RID: 7643 RVA: 0x0002BC5E File Offset: 0x00029E5E
		// (set) Token: 0x06001DDC RID: 7644 RVA: 0x0002BC6E File Offset: 0x00029E6E
		public unsafe float NetworkPredictingMinSmoothMeshSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingMinSmoothMeshSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingMinSmoothMeshSpeed) = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001DDD RID: 7645 RVA: 0x0002BC7F File Offset: 0x00029E7F
		// (set) Token: 0x06001DDE RID: 7646 RVA: 0x0002BC8F File Offset: 0x00029E8F
		public unsafe float NetworkPredictingMaxSmoothMeshSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingMaxSmoothMeshSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingMaxSmoothMeshSpeed) = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001DDF RID: 7647 RVA: 0x0002BCA0 File Offset: 0x00029EA0
		// (set) Token: 0x06001DE0 RID: 7648 RVA: 0x0002BCB0 File Offset: 0x00029EB0
		public unsafe float NetworkPredictingZSmoothTimeOnGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingZSmoothTimeOnGround);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkPredictingZSmoothTimeOnGround) = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001DE1 RID: 7649 RVA: 0x0002BCC1 File Offset: 0x00029EC1
		// (set) Token: 0x06001DE2 RID: 7650 RVA: 0x0002BCD1 File Offset: 0x00029ED1
		public unsafe float LedgeCheckThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LedgeCheckThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_LedgeCheckThreshold) = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001DE3 RID: 7651 RVA: 0x0002BCE2 File Offset: 0x00029EE2
		// (set) Token: 0x06001DE4 RID: 7652 RVA: 0x0002BCF2 File Offset: 0x00029EF2
		public unsafe float JumpOutOfWaterPitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpOutOfWaterPitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_JumpOutOfWaterPitch) = value;
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001DE5 RID: 7653 RVA: 0x0002BD04 File Offset: 0x00029F04
		// (set) Token: 0x06001DE6 RID: 7654 RVA: 0x0002BD3D File Offset: 0x00029F3D
		[Nullable(1)]
		public FFindFloorResult CurrentFloor
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FFindFloorResult result;
				if ((result = this._CurrentFloor) == null)
				{
					result = (this._CurrentFloor = new FFindFloorResult(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CurrentFloor, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFindFloorResult.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CurrentFloor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x06001DE7 RID: 7655 RVA: 0x0002BD5E File Offset: 0x00029F5E
		// (set) Token: 0x06001DE8 RID: 7656 RVA: 0x0002BD72 File Offset: 0x00029F72
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> DefaultLandMovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_DefaultLandMovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_DefaultLandMovementMode) = value;
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x06001DE9 RID: 7657 RVA: 0x0002BD87 File Offset: 0x00029F87
		// (set) Token: 0x06001DEA RID: 7658 RVA: 0x0002BD9B File Offset: 0x00029F9B
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> DefaultWaterMovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_DefaultWaterMovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_DefaultWaterMovementMode) = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x06001DEB RID: 7659 RVA: 0x0002BDB0 File Offset: 0x00029FB0
		// (set) Token: 0x06001DEC RID: 7660 RVA: 0x0002BDC0 File Offset: 0x00029FC0
		public unsafe float PredictionDataMaxMoveDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PredictionDataMaxMoveDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PredictionDataMaxMoveDeltaTime) = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001DED RID: 7661 RVA: 0x0002BDD1 File Offset: 0x00029FD1
		// (set) Token: 0x06001DEE RID: 7662 RVA: 0x0002BDE5 File Offset: 0x00029FE5
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovementMode> GroundMovementMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroundMovementMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroundMovementMode) = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0002BDFA File Offset: 0x00029FFA
		// (set) Token: 0x06001DF0 RID: 7664 RVA: 0x0002BE13 File Offset: 0x0002A013
		public unsafe bool bMaintainHorizontalGroundVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMaintainHorizontalGroundVelocity) & UCharacterMovementComponent.__PropertyMask_bMaintainHorizontalGroundVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMaintainHorizontalGroundVelocity) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bMaintainHorizontalGroundVelocity) & ~UCharacterMovementComponent.__PropertyMask_bMaintainHorizontalGroundVelocity) | (value ? UCharacterMovementComponent.__PropertyMask_bMaintainHorizontalGroundVelocity : 0));
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001DF1 RID: 7665 RVA: 0x0002BE43 File Offset: 0x0002A043
		// (set) Token: 0x06001DF2 RID: 7666 RVA: 0x0002BE5C File Offset: 0x0002A05C
		public unsafe bool bImpartBaseVelocityX
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityX) & UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityX) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityX) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityX) & ~UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityX) | (value ? UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityX : 0));
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001DF3 RID: 7667 RVA: 0x0002BE8C File Offset: 0x0002A08C
		// (set) Token: 0x06001DF4 RID: 7668 RVA: 0x0002BEA5 File Offset: 0x0002A0A5
		public unsafe bool bImpartBaseVelocityY
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityY) & UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityY) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityY) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityY) & ~UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityY) | (value ? UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityY : 0));
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0002BED5 File Offset: 0x0002A0D5
		// (set) Token: 0x06001DF6 RID: 7670 RVA: 0x0002BEEE File Offset: 0x0002A0EE
		public unsafe bool bImpartBaseVelocityZ
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityZ) & UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityZ) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityZ) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseVelocityZ) & ~UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityZ) | (value ? UCharacterMovementComponent.__PropertyMask_bImpartBaseVelocityZ : 0));
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x0002BF1E File Offset: 0x0002A11E
		// (set) Token: 0x06001DF8 RID: 7672 RVA: 0x0002BF37 File Offset: 0x0002A137
		public unsafe bool bImpartBaseAngularVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseAngularVelocity) & UCharacterMovementComponent.__PropertyMask_bImpartBaseAngularVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseAngularVelocity) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bImpartBaseAngularVelocity) & ~UCharacterMovementComponent.__PropertyMask_bImpartBaseAngularVelocity) | (value ? UCharacterMovementComponent.__PropertyMask_bImpartBaseAngularVelocity : 0));
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0002BF67 File Offset: 0x0002A167
		// (set) Token: 0x06001DFA RID: 7674 RVA: 0x0002BF80 File Offset: 0x0002A180
		public unsafe bool bJustTeleported
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bJustTeleported) & UCharacterMovementComponent.__PropertyMask_bJustTeleported) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bJustTeleported) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bJustTeleported) & ~UCharacterMovementComponent.__PropertyMask_bJustTeleported) | (value ? UCharacterMovementComponent.__PropertyMask_bJustTeleported : 0));
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001DFB RID: 7675 RVA: 0x0002BFB0 File Offset: 0x0002A1B0
		// (set) Token: 0x06001DFC RID: 7676 RVA: 0x0002BFC9 File Offset: 0x0002A1C9
		public unsafe bool bNetworkUpdateReceived
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkUpdateReceived) & UCharacterMovementComponent.__PropertyMask_bNetworkUpdateReceived) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkUpdateReceived) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkUpdateReceived) & ~UCharacterMovementComponent.__PropertyMask_bNetworkUpdateReceived) | (value ? UCharacterMovementComponent.__PropertyMask_bNetworkUpdateReceived : 0));
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001DFD RID: 7677 RVA: 0x0002BFF9 File Offset: 0x0002A1F9
		// (set) Token: 0x06001DFE RID: 7678 RVA: 0x0002C012 File Offset: 0x0002A212
		public unsafe bool bNetworkMovementModeChanged
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkMovementModeChanged) & UCharacterMovementComponent.__PropertyMask_bNetworkMovementModeChanged) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkMovementModeChanged) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNetworkMovementModeChanged) & ~UCharacterMovementComponent.__PropertyMask_bNetworkMovementModeChanged) | (value ? UCharacterMovementComponent.__PropertyMask_bNetworkMovementModeChanged : 0));
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001DFF RID: 7679 RVA: 0x0002C042 File Offset: 0x0002A242
		// (set) Token: 0x06001E00 RID: 7680 RVA: 0x0002C05B File Offset: 0x0002A25B
		public unsafe bool bIgnoreClientMovementErrorChecksAndCorrection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreClientMovementErrorChecksAndCorrection) & UCharacterMovementComponent.__PropertyMask_bIgnoreClientMovementErrorChecksAndCorrection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreClientMovementErrorChecksAndCorrection) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreClientMovementErrorChecksAndCorrection) & ~UCharacterMovementComponent.__PropertyMask_bIgnoreClientMovementErrorChecksAndCorrection) | (value ? UCharacterMovementComponent.__PropertyMask_bIgnoreClientMovementErrorChecksAndCorrection : 0));
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0002C08B File Offset: 0x0002A28B
		// (set) Token: 0x06001E02 RID: 7682 RVA: 0x0002C0A4 File Offset: 0x0002A2A4
		public unsafe bool bServerAcceptClientAuthoritativePosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bServerAcceptClientAuthoritativePosition) & UCharacterMovementComponent.__PropertyMask_bServerAcceptClientAuthoritativePosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bServerAcceptClientAuthoritativePosition) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bServerAcceptClientAuthoritativePosition) & ~UCharacterMovementComponent.__PropertyMask_bServerAcceptClientAuthoritativePosition) | (value ? UCharacterMovementComponent.__PropertyMask_bServerAcceptClientAuthoritativePosition : 0));
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001E03 RID: 7683 RVA: 0x0002C0D4 File Offset: 0x0002A2D4
		// (set) Token: 0x06001E04 RID: 7684 RVA: 0x0002C0ED File Offset: 0x0002A2ED
		public unsafe bool bNotifyApex
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNotifyApex) & UCharacterMovementComponent.__PropertyMask_bNotifyApex) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNotifyApex) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bNotifyApex) & ~UCharacterMovementComponent.__PropertyMask_bNotifyApex) | (value ? UCharacterMovementComponent.__PropertyMask_bNotifyApex : 0));
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001E05 RID: 7685 RVA: 0x0002C11D File Offset: 0x0002A31D
		// (set) Token: 0x06001E06 RID: 7686 RVA: 0x0002C136 File Offset: 0x0002A336
		public unsafe bool bCheatFlying
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCheatFlying) & UCharacterMovementComponent.__PropertyMask_bCheatFlying) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCheatFlying) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCheatFlying) & ~UCharacterMovementComponent.__PropertyMask_bCheatFlying) | (value ? UCharacterMovementComponent.__PropertyMask_bCheatFlying : 0));
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001E07 RID: 7687 RVA: 0x0002C166 File Offset: 0x0002A366
		// (set) Token: 0x06001E08 RID: 7688 RVA: 0x0002C17F File Offset: 0x0002A37F
		public unsafe bool bWantsToCrouch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToCrouch) & UCharacterMovementComponent.__PropertyMask_bWantsToCrouch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToCrouch) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToCrouch) & ~UCharacterMovementComponent.__PropertyMask_bWantsToCrouch) | (value ? UCharacterMovementComponent.__PropertyMask_bWantsToCrouch : 0));
			}
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0002C1AF File Offset: 0x0002A3AF
		// (set) Token: 0x06001E0A RID: 7690 RVA: 0x0002C1C8 File Offset: 0x0002A3C8
		public unsafe bool bCrouchMaintainsBaseLocation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCrouchMaintainsBaseLocation) & UCharacterMovementComponent.__PropertyMask_bCrouchMaintainsBaseLocation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCrouchMaintainsBaseLocation) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bCrouchMaintainsBaseLocation) & ~UCharacterMovementComponent.__PropertyMask_bCrouchMaintainsBaseLocation) | (value ? UCharacterMovementComponent.__PropertyMask_bCrouchMaintainsBaseLocation : 0));
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001E0B RID: 7691 RVA: 0x0002C1F8 File Offset: 0x0002A3F8
		// (set) Token: 0x06001E0C RID: 7692 RVA: 0x0002C211 File Offset: 0x0002A411
		public unsafe bool bIgnoreBaseRotation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreBaseRotation) & UCharacterMovementComponent.__PropertyMask_bIgnoreBaseRotation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreBaseRotation) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bIgnoreBaseRotation) & ~UCharacterMovementComponent.__PropertyMask_bIgnoreBaseRotation) | (value ? UCharacterMovementComponent.__PropertyMask_bIgnoreBaseRotation : 0));
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001E0D RID: 7693 RVA: 0x0002C241 File Offset: 0x0002A441
		// (set) Token: 0x06001E0E RID: 7694 RVA: 0x0002C25A File Offset: 0x0002A45A
		public unsafe bool bFastAttachedMove
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bFastAttachedMove) & UCharacterMovementComponent.__PropertyMask_bFastAttachedMove) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bFastAttachedMove) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bFastAttachedMove) & ~UCharacterMovementComponent.__PropertyMask_bFastAttachedMove) | (value ? UCharacterMovementComponent.__PropertyMask_bFastAttachedMove : 0));
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0002C28A File Offset: 0x0002A48A
		// (set) Token: 0x06001E10 RID: 7696 RVA: 0x0002C2A3 File Offset: 0x0002A4A3
		public unsafe bool bAlwaysCheckFloor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAlwaysCheckFloor) & UCharacterMovementComponent.__PropertyMask_bAlwaysCheckFloor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAlwaysCheckFloor) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAlwaysCheckFloor) & ~UCharacterMovementComponent.__PropertyMask_bAlwaysCheckFloor) | (value ? UCharacterMovementComponent.__PropertyMask_bAlwaysCheckFloor : 0));
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0002C2D3 File Offset: 0x0002A4D3
		// (set) Token: 0x06001E12 RID: 7698 RVA: 0x0002C2EC File Offset: 0x0002A4EC
		public unsafe bool bUseFlatBaseForFloorChecks
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseFlatBaseForFloorChecks) & UCharacterMovementComponent.__PropertyMask_bUseFlatBaseForFloorChecks) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseFlatBaseForFloorChecks) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseFlatBaseForFloorChecks) & ~UCharacterMovementComponent.__PropertyMask_bUseFlatBaseForFloorChecks) | (value ? UCharacterMovementComponent.__PropertyMask_bUseFlatBaseForFloorChecks : 0));
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0002C31C File Offset: 0x0002A51C
		// (set) Token: 0x06001E14 RID: 7700 RVA: 0x0002C335 File Offset: 0x0002A535
		public unsafe bool bPerformingJumpOff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPerformingJumpOff) & UCharacterMovementComponent.__PropertyMask_bPerformingJumpOff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPerformingJumpOff) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bPerformingJumpOff) & ~UCharacterMovementComponent.__PropertyMask_bPerformingJumpOff) | (value ? UCharacterMovementComponent.__PropertyMask_bPerformingJumpOff : 0));
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001E15 RID: 7701 RVA: 0x0002C365 File Offset: 0x0002A565
		// (set) Token: 0x06001E16 RID: 7702 RVA: 0x0002C37E File Offset: 0x0002A57E
		public unsafe bool bWantsToLeaveNavWalking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToLeaveNavWalking) & UCharacterMovementComponent.__PropertyMask_bWantsToLeaveNavWalking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToLeaveNavWalking) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWantsToLeaveNavWalking) & ~UCharacterMovementComponent.__PropertyMask_bWantsToLeaveNavWalking) | (value ? UCharacterMovementComponent.__PropertyMask_bWantsToLeaveNavWalking : 0));
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001E17 RID: 7703 RVA: 0x0002C3AE File Offset: 0x0002A5AE
		// (set) Token: 0x06001E18 RID: 7704 RVA: 0x0002C3C7 File Offset: 0x0002A5C7
		public unsafe bool bUseRVOAvoidance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseRVOAvoidance) & UCharacterMovementComponent.__PropertyMask_bUseRVOAvoidance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseRVOAvoidance) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bUseRVOAvoidance) & ~UCharacterMovementComponent.__PropertyMask_bUseRVOAvoidance) | (value ? UCharacterMovementComponent.__PropertyMask_bUseRVOAvoidance : 0));
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0002C3F7 File Offset: 0x0002A5F7
		// (set) Token: 0x06001E1A RID: 7706 RVA: 0x0002C410 File Offset: 0x0002A610
		public unsafe bool bRequestedMoveUseAcceleration
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveUseAcceleration) & UCharacterMovementComponent.__PropertyMask_bRequestedMoveUseAcceleration) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveUseAcceleration) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveUseAcceleration) & ~UCharacterMovementComponent.__PropertyMask_bRequestedMoveUseAcceleration) | (value ? UCharacterMovementComponent.__PropertyMask_bRequestedMoveUseAcceleration : 0));
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0002C440 File Offset: 0x0002A640
		// (set) Token: 0x06001E1C RID: 7708 RVA: 0x0002C459 File Offset: 0x0002A659
		public unsafe bool bWasSimulatingRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasSimulatingRootMotion) & UCharacterMovementComponent.__PropertyMask_bWasSimulatingRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasSimulatingRootMotion) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasSimulatingRootMotion) & ~UCharacterMovementComponent.__PropertyMask_bWasSimulatingRootMotion) | (value ? UCharacterMovementComponent.__PropertyMask_bWasSimulatingRootMotion : 0));
			}
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x0002C489 File Offset: 0x0002A689
		// (set) Token: 0x06001E1E RID: 7710 RVA: 0x0002C4A2 File Offset: 0x0002A6A2
		public unsafe bool bAllowPhysicsRotationDuringAnimRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAllowPhysicsRotationDuringAnimRootMotion) & UCharacterMovementComponent.__PropertyMask_bAllowPhysicsRotationDuringAnimRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAllowPhysicsRotationDuringAnimRootMotion) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bAllowPhysicsRotationDuringAnimRootMotion) & ~UCharacterMovementComponent.__PropertyMask_bAllowPhysicsRotationDuringAnimRootMotion) | (value ? UCharacterMovementComponent.__PropertyMask_bAllowPhysicsRotationDuringAnimRootMotion : 0));
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E1F RID: 7711 RVA: 0x0002C4D2 File Offset: 0x0002A6D2
		// (set) Token: 0x06001E20 RID: 7712 RVA: 0x0002C4EB File Offset: 0x0002A6EB
		public unsafe bool bHasRequestedVelocity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bHasRequestedVelocity) & UCharacterMovementComponent.__PropertyMask_bHasRequestedVelocity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bHasRequestedVelocity) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bHasRequestedVelocity) & ~UCharacterMovementComponent.__PropertyMask_bHasRequestedVelocity) | (value ? UCharacterMovementComponent.__PropertyMask_bHasRequestedVelocity : 0));
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0002C51B File Offset: 0x0002A71B
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x0002C534 File Offset: 0x0002A734
		public unsafe bool bRequestedMoveWithMaxSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveWithMaxSpeed) & UCharacterMovementComponent.__PropertyMask_bRequestedMoveWithMaxSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveWithMaxSpeed) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bRequestedMoveWithMaxSpeed) & ~UCharacterMovementComponent.__PropertyMask_bRequestedMoveWithMaxSpeed) | (value ? UCharacterMovementComponent.__PropertyMask_bRequestedMoveWithMaxSpeed : 0));
			}
		}

		// Token: 0x17000432 RID: 1074
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0002C564 File Offset: 0x0002A764
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x0002C57D File Offset: 0x0002A77D
		public unsafe bool bWasAvoidanceUpdated
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasAvoidanceUpdated) & UCharacterMovementComponent.__PropertyMask_bWasAvoidanceUpdated) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasAvoidanceUpdated) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bWasAvoidanceUpdated) & ~UCharacterMovementComponent.__PropertyMask_bWasAvoidanceUpdated) | (value ? UCharacterMovementComponent.__PropertyMask_bWasAvoidanceUpdated : 0));
			}
		}

		// Token: 0x17000433 RID: 1075
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0002C5AD File Offset: 0x0002A7AD
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x0002C5C6 File Offset: 0x0002A7C6
		public unsafe bool bProjectNavMeshWalking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshWalking) & UCharacterMovementComponent.__PropertyMask_bProjectNavMeshWalking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshWalking) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshWalking) & ~UCharacterMovementComponent.__PropertyMask_bProjectNavMeshWalking) | (value ? UCharacterMovementComponent.__PropertyMask_bProjectNavMeshWalking : 0));
			}
		}

		// Token: 0x17000434 RID: 1076
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x0002C5F6 File Offset: 0x0002A7F6
		// (set) Token: 0x06001E28 RID: 7720 RVA: 0x0002C60F File Offset: 0x0002A80F
		public unsafe bool bProjectNavMeshOnBothWorldChannels
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshOnBothWorldChannels) & UCharacterMovementComponent.__PropertyMask_bProjectNavMeshOnBothWorldChannels) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshOnBothWorldChannels) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bProjectNavMeshOnBothWorldChannels) & ~UCharacterMovementComponent.__PropertyMask_bProjectNavMeshOnBothWorldChannels) | (value ? UCharacterMovementComponent.__PropertyMask_bProjectNavMeshOnBothWorldChannels : 0));
			}
		}

		// Token: 0x17000435 RID: 1077
		// (get) Token: 0x06001E29 RID: 7721 RVA: 0x0002C63F File Offset: 0x0002A83F
		// (set) Token: 0x06001E2A RID: 7722 RVA: 0x0002C64F File Offset: 0x0002A84F
		public unsafe float AvoidanceConsiderationRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceConsiderationRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceConsiderationRadius) = value;
			}
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0002C660 File Offset: 0x0002A860
		// (set) Token: 0x06001E2C RID: 7724 RVA: 0x0002C674 File Offset: 0x0002A874
		public unsafe FVector RequestedVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RequestedVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RequestedVelocity) = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0002C689 File Offset: 0x0002A889
		// (set) Token: 0x06001E2E RID: 7726 RVA: 0x0002C699 File Offset: 0x0002A899
		public unsafe int AvoidanceUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceUID) = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E2F RID: 7727 RVA: 0x0002C6AC File Offset: 0x0002A8AC
		// (set) Token: 0x06001E30 RID: 7728 RVA: 0x0002C6E5 File Offset: 0x0002A8E5
		[Nullable(1)]
		public FNavAvoidanceMask AvoidanceGroup
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._AvoidanceGroup) == null)
				{
					result = (this._AvoidanceGroup = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceGroup, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceGroup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0002C708 File Offset: 0x0002A908
		// (set) Token: 0x06001E32 RID: 7730 RVA: 0x0002C741 File Offset: 0x0002A941
		[Nullable(1)]
		public FNavAvoidanceMask GroupsToAvoid
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._GroupsToAvoid) == null)
				{
					result = (this._GroupsToAvoid = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToAvoid, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToAvoid, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x06001E33 RID: 7731 RVA: 0x0002C764 File Offset: 0x0002A964
		// (set) Token: 0x06001E34 RID: 7732 RVA: 0x0002C79D File Offset: 0x0002A99D
		[Nullable(1)]
		public FNavAvoidanceMask GroupsToIgnore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FNavAvoidanceMask result;
				if ((result = this._GroupsToIgnore) == null)
				{
					result = (this._GroupsToIgnore = new FNavAvoidanceMask(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToIgnore, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToIgnore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x06001E35 RID: 7733 RVA: 0x0002C7BE File Offset: 0x0002A9BE
		// (set) Token: 0x06001E36 RID: 7734 RVA: 0x0002C7CE File Offset: 0x0002A9CE
		public unsafe float AvoidanceWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceWeight) = value;
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x06001E37 RID: 7735 RVA: 0x0002C7DF File Offset: 0x0002A9DF
		// (set) Token: 0x06001E38 RID: 7736 RVA: 0x0002C7EF File Offset: 0x0002A9EF
		public unsafe float AvoidancePredictAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidancePredictAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidancePredictAlpha) = value;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x06001E39 RID: 7737 RVA: 0x0002C800 File Offset: 0x0002AA00
		// (set) Token: 0x06001E3A RID: 7738 RVA: 0x0002C814 File Offset: 0x0002AA14
		public unsafe FVector PendingLaunchVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingLaunchVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PendingLaunchVelocity) = value;
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x06001E3B RID: 7739 RVA: 0x0002C829 File Offset: 0x0002AA29
		// (set) Token: 0x06001E3C RID: 7740 RVA: 0x0002C839 File Offset: 0x0002AA39
		public unsafe float NavMeshProjectionInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionInterval) = value;
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x06001E3D RID: 7741 RVA: 0x0002C84A File Offset: 0x0002AA4A
		// (set) Token: 0x06001E3E RID: 7742 RVA: 0x0002C85A File Offset: 0x0002AA5A
		public unsafe float NavMeshProjectionTimer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionTimer);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionTimer) = value;
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06001E3F RID: 7743 RVA: 0x0002C86B File Offset: 0x0002AA6B
		// (set) Token: 0x06001E40 RID: 7744 RVA: 0x0002C87B File Offset: 0x0002AA7B
		public unsafe float NavMeshProjectionInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionInterpSpeed) = value;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06001E41 RID: 7745 RVA: 0x0002C88C File Offset: 0x0002AA8C
		// (set) Token: 0x06001E42 RID: 7746 RVA: 0x0002C89C File Offset: 0x0002AA9C
		public unsafe float NavMeshProjectionHeightScaleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionHeightScaleUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionHeightScaleUp) = value;
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06001E43 RID: 7747 RVA: 0x0002C8AD File Offset: 0x0002AAAD
		// (set) Token: 0x06001E44 RID: 7748 RVA: 0x0002C8BD File Offset: 0x0002AABD
		public unsafe float NavMeshProjectionHeightScaleDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionHeightScaleDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavMeshProjectionHeightScaleDown) = value;
			}
		}

		// Token: 0x17000443 RID: 1091
		// (get) Token: 0x06001E45 RID: 7749 RVA: 0x0002C8CE File Offset: 0x0002AACE
		// (set) Token: 0x06001E46 RID: 7750 RVA: 0x0002C8DE File Offset: 0x0002AADE
		public unsafe float NavWalkingFloorDistTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavWalkingFloorDistTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NavWalkingFloorDistTolerance) = value;
			}
		}

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x06001E47 RID: 7751 RVA: 0x0002C8EF File Offset: 0x0002AAEF
		// (set) Token: 0x06001E48 RID: 7752 RVA: 0x0002C8FF File Offset: 0x0002AAFF
		public unsafe float MinTimeBetweenTimeStampResets
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinTimeBetweenTimeStampResets);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_MinTimeBetweenTimeStampResets) = value;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x06001E49 RID: 7753 RVA: 0x0002C910 File Offset: 0x0002AB10
		// (set) Token: 0x06001E4A RID: 7754 RVA: 0x0002C949 File Offset: 0x0002AB49
		[Nullable(1)]
		public FRootMotionMovementParams RootMotionParams
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FRootMotionMovementParams result;
				if ((result = this._RootMotionParams) == null)
				{
					result = (this._RootMotionParams = new FRootMotionMovementParams(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RootMotionParams, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001E4B RID: 7755 RVA: 0x0002C96A File Offset: 0x0002AB6A
		// (set) Token: 0x06001E4C RID: 7756 RVA: 0x0002C97E File Offset: 0x0002AB7E
		public unsafe FVector AnimRootMotionVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionVelocity) = value;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001E4D RID: 7757 RVA: 0x0002C993 File Offset: 0x0002AB93
		// (set) Token: 0x06001E4E RID: 7758 RVA: 0x0002C9A7 File Offset: 0x0002ABA7
		public unsafe FVector AnimRootMotionRotateAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionRotateAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionRotateAxis) = value;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001E4F RID: 7759 RVA: 0x0002C9BC File Offset: 0x0002ABBC
		// (set) Token: 0x06001E50 RID: 7760 RVA: 0x0002C9CC File Offset: 0x0002ABCC
		public unsafe float AnimRootMotionRotateSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionRotateSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AnimRootMotionRotateSpeed) = value;
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001E51 RID: 7761 RVA: 0x0002C9DD File Offset: 0x0002ABDD
		// (set) Token: 0x06001E52 RID: 7762 RVA: 0x0002C9F6 File Offset: 0x0002ABF6
		public unsafe bool bKuroAsyncRootMotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroAsyncRootMotion) & UCharacterMovementComponent.__PropertyMask_bKuroAsyncRootMotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroAsyncRootMotion) = ((*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_bKuroAsyncRootMotion) & ~UCharacterMovementComponent.__PropertyMask_bKuroAsyncRootMotion) | (value ? UCharacterMovementComponent.__PropertyMask_bKuroAsyncRootMotion : 0));
			}
		}

		// Token: 0x1700044A RID: 1098
		// (get) Token: 0x06001E53 RID: 7763 RVA: 0x0002CA26 File Offset: 0x0002AC26
		// (set) Token: 0x06001E54 RID: 7764 RVA: 0x0002CA36 File Offset: 0x0002AC36
		public unsafe byte KuroPredictMotionMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroPredictMotionMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroPredictMotionMask) = value;
			}
		}

		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001E55 RID: 7765 RVA: 0x0002CA48 File Offset: 0x0002AC48
		// (set) Token: 0x06001E56 RID: 7766 RVA: 0x0002CA81 File Offset: 0x0002AC81
		[Nullable(1)]
		public FKuroMovementSetting KuroMovementSetting
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroMovementSetting result;
				if ((result = this._KuroMovementSetting) == null)
				{
					result = (this._KuroMovementSetting = new FKuroMovementSetting(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroMovementSetting, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroMovementSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06001E57 RID: 7767 RVA: 0x0002CAA2 File Offset: 0x0002ACA2
		public void SetWalkableFloorZ(float InWalkableFloorZ)
		{
			UCharacterMovementComponent.__SetWalkableFloorZ_Internal(base.NativePtr, InWalkableFloorZ);
		}

		// Token: 0x06001E58 RID: 7768 RVA: 0x0002CAB0 File Offset: 0x0002ACB0
		public void SetWalkableFloorAngle(float InWalkableFloorAngle)
		{
			UCharacterMovementComponent.__SetWalkableFloorAngle_Internal(base.NativePtr, InWalkableFloorAngle);
		}

		// Token: 0x06001E59 RID: 7769 RVA: 0x0002CABE File Offset: 0x0002ACBE
		public void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode = 0)
		{
			UCharacterMovementComponent.__SetMovementMode_Internal(base.NativePtr, NewMovementMode, NewCustomMode);
		}

		// Token: 0x06001E5A RID: 7770 RVA: 0x0002CAD2 File Offset: 0x0002ACD2
		public void SetKuroPlanarPhysWalking(bool bEnable)
		{
			UCharacterMovementComponent.__SetKuroPlanarPhysWalking_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06001E5B RID: 7771 RVA: 0x0002CAE0 File Offset: 0x0002ACE0
		public void SetKuroMovementSettings(in FKuroMovementSetting InKuroMovementSetting)
		{
			UCharacterMovementComponent.__SetKuroMovementSettings_Internal(base.NativePtr, (InKuroMovementSetting ?? new FKuroMovementSetting()).NativePtr);
		}

		// Token: 0x06001E5C RID: 7772 RVA: 0x0002CAFD File Offset: 0x0002ACFD
		public void SetKuroAsyncRootMotion(bool enable)
		{
			UCharacterMovementComponent.__SetKuroAsyncRootMotion_Internal(base.NativePtr, enable);
		}

		// Token: 0x06001E5D RID: 7773 RVA: 0x0002CB0B File Offset: 0x0002AD0B
		public void SetGroupsToIgnoreMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetGroupsToIgnoreMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x06001E5E RID: 7774 RVA: 0x0002CB28 File Offset: 0x0002AD28
		public void SetGroupsToIgnore(int GroupFlags)
		{
			UCharacterMovementComponent.__SetGroupsToIgnore_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x06001E5F RID: 7775 RVA: 0x0002CB36 File Offset: 0x0002AD36
		public void SetGroupsToAvoidMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetGroupsToAvoidMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x06001E60 RID: 7776 RVA: 0x0002CB53 File Offset: 0x0002AD53
		public void SetGroupsToAvoid(int GroupFlags)
		{
			UCharacterMovementComponent.__SetGroupsToAvoid_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x06001E61 RID: 7777 RVA: 0x0002CB61 File Offset: 0x0002AD61
		public void SetDefaultMovementMode()
		{
			UCharacterMovementComponent.__SetDefaultMovementMode_Internal(base.NativePtr);
		}

		// Token: 0x06001E62 RID: 7778 RVA: 0x0002CB6E File Offset: 0x0002AD6E
		public void SetAvoidanceGroupMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetAvoidanceGroupMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x06001E63 RID: 7779 RVA: 0x0002CB8B File Offset: 0x0002AD8B
		public void SetAvoidanceGroup(int GroupFlags)
		{
			UCharacterMovementComponent.__SetAvoidanceGroup_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x06001E64 RID: 7780 RVA: 0x0002CB99 File Offset: 0x0002AD99
		public void SetAvoidanceEnabled(bool bEnable)
		{
			UCharacterMovementComponent.__SetAvoidanceEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0002CBA8 File Offset: 0x0002ADA8
		public unsafe void SetAddRotation(FQuat InAddRotationOffset)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InAddRotationOffset;
			UCharacterMovementComponent.__SetAddRotation_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0002CBD8 File Offset: 0x0002ADD8
		public void SetAddMove(FVectorDouble InAddMoveOffset)
		{
			UCharacterMovementComponent.__SetAddMove_Internal(base.NativePtr, InAddMoveOffset);
		}

		// Token: 0x06001E67 RID: 7783 RVA: 0x0002CBE6 File Offset: 0x0002ADE6
		public void MoveAdjust(in FVector Delta)
		{
			UCharacterMovementComponent.__MoveAdjust_Internal(base.NativePtr, Delta);
		}

		// Token: 0x06001E68 RID: 7784 RVA: 0x0002CBF4 File Offset: 0x0002ADF4
		public void KuroSwimming(float DeltaTime, bool Sweep, float Depth, float KuroBuoyancy, float Friction, float MaxSpeed, float Slope, float Accelerator, float Deceleration)
		{
			UCharacterMovementComponent.__KuroSwimming_Internal(base.NativePtr, DeltaTime, Sweep, Depth, KuroBuoyancy, Friction, MaxSpeed, Slope, Accelerator, Deceleration);
		}

		// Token: 0x06001E69 RID: 7785 RVA: 0x0002CC1C File Offset: 0x0002AE1C
		public bool KuroSlide(float DeltaTime, float AirFriction, float SlideFriction, FVector InputVelocity, float MaxSlideHorizontalSeed, FVector PrevBlockNormal, float MaxSlideVerticalSpeed = -1f, UCurveFloat SpeedReduceCurve = null)
		{
			return UCharacterMovementComponent.__KuroSlide_Internal(base.NativePtr, DeltaTime, AirFriction, SlideFriction, InputVelocity, MaxSlideHorizontalSeed, PrevBlockNormal, MaxSlideVerticalSpeed, (SpeedReduceCurve != null) ? SpeedReduceCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0002CC51 File Offset: 0x0002AE51
		public void KuroSetPredictionDataMaxMoveDeltaTime(float MaxMoveDeltaTime)
		{
			UCharacterMovementComponent.__KuroSetPredictionDataMaxMoveDeltaTime_Internal(base.NativePtr, MaxMoveDeltaTime);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0002CC5F File Offset: 0x0002AE5F
		public UKuroCustomMovementExtension KuroRegisterCustomMovementExtension(byte InCustomMovementMode, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroCustomMovementExtension> ExtensionClass, bool bOverrideExisting)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCustomMovementExtension>(UCharacterMovementComponent.__KuroRegisterCustomMovementExtension_Internal(base.NativePtr, InCustomMovementMode, ExtensionClass._NativePtr, bOverrideExisting));
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0002CC7C File Offset: 0x0002AE7C
		public void KuroPendulum(float AddVelocityX, float AddVelocityY, float AddVelocityZ, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed)
		{
			UCharacterMovementComponent.__KuroPendulum_Internal(base.NativePtr, AddVelocityX, AddVelocityY, AddVelocityZ, deltaTime, Gravity, Friction, deceleration, Accelerator, MaxSpeed, MaxFallingSpeed);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0002CCA5 File Offset: 0x0002AEA5
		public void KuroMoveAlongFloor(in FVector InVelocity, float DeltaSeconds)
		{
			UCharacterMovementComponent.__KuroMoveAlongFloor_Internal(base.NativePtr, InVelocity, DeltaSeconds);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0002CCB4 File Offset: 0x0002AEB4
		public UKuroCustomMovementExtension KuroGetCustomMovementExtension(byte InCustomMovementMode)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCustomMovementExtension>(UCharacterMovementComponent.__KuroGetCustomMovementExtension_Internal(base.NativePtr, InCustomMovementMode));
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0002CCC7 File Offset: 0x0002AEC7
		public void KuroFlying(float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed)
		{
			UCharacterMovementComponent.__KuroFlying_Internal(base.NativePtr, deltaTime, Gravity, Friction, deceleration, Accelerator, MaxSpeed, MaxFallingSpeed);
		}

		// Token: 0x06001E70 RID: 7792 RVA: 0x0002CCE0 File Offset: 0x0002AEE0
		public unsafe bool KuroFindNavFloor(in FVector TestLocation, ref FVector NavFloorLocation)
		{
			fixed (FVector* ptr = &NavFloorLocation)
			{
				void* ptr2 = (void*)ptr;
				return UCharacterMovementComponent.__KuroFindNavFloor_Internal(base.NativePtr, TestLocation, ref NavFloorLocation);
			}
		}

		// Token: 0x06001E71 RID: 7793 RVA: 0x0002CCFF File Offset: 0x0002AEFF
		public void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UCharacterMovementComponent.__Kuro_SetGravityDirect_Internal(base.NativePtr, InGravityDirect);
		}

		// Token: 0x06001E72 RID: 7794 RVA: 0x0002CD0D File Offset: 0x0002AF0D
		public int Kuro_GetKuroBlockHitIndexWhenMove()
		{
			return UCharacterMovementComponent.__Kuro_GetKuroBlockHitIndexWhenMove_Internal(base.NativePtr);
		}

		// Token: 0x06001E73 RID: 7795 RVA: 0x0002CD1A File Offset: 0x0002AF1A
		public FVector Kuro_GetGravityDirect()
		{
			return UCharacterMovementComponent.__Kuro_GetGravityDirect_Internal(base.NativePtr);
		}

		// Token: 0x06001E74 RID: 7796 RVA: 0x0002CD27 File Offset: 0x0002AF27
		public FRotator Kuro_GetGravityDeltaRot()
		{
			return UCharacterMovementComponent.__Kuro_GetGravityDeltaRot_Internal(base.NativePtr);
		}

		// Token: 0x06001E75 RID: 7797 RVA: 0x0002CD34 File Offset: 0x0002AF34
		public FVector Kuro_GetGravity()
		{
			return UCharacterMovementComponent.__Kuro_GetGravity_Internal(base.NativePtr);
		}

		// Token: 0x06001E76 RID: 7798 RVA: 0x0002CD41 File Offset: 0x0002AF41
		public FVector Kuro_GetBlockDirectWhenMove()
		{
			return UCharacterMovementComponent.__Kuro_GetBlockDirectWhenMove_Internal(base.NativePtr);
		}

		// Token: 0x06001E77 RID: 7799 RVA: 0x0002CD4E File Offset: 0x0002AF4E
		public AActor Kuro_GetBlockActorWhenMove()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UCharacterMovementComponent.__Kuro_GetBlockActorWhenMove_Internal(base.NativePtr));
		}

		// Token: 0x06001E78 RID: 7800 RVA: 0x0002CD60 File Offset: 0x0002AF60
		public void K2_KuroEndScopedMovementUpdate()
		{
			UCharacterMovementComponent.__K2_KuroEndScopedMovementUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06001E79 RID: 7801 RVA: 0x0002CD6D File Offset: 0x0002AF6D
		public void K2_KuroBeginScopedMovementUpdate()
		{
			UCharacterMovementComponent.__K2_KuroBeginScopedMovementUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06001E7A RID: 7802 RVA: 0x0002CD7A File Offset: 0x0002AF7A
		public float K2_GetWalkableFloorZ()
		{
			return UCharacterMovementComponent.__K2_GetWalkableFloorZ_Internal(base.NativePtr);
		}

		// Token: 0x06001E7B RID: 7803 RVA: 0x0002CD87 File Offset: 0x0002AF87
		public float K2_GetWalkableFloorAngle()
		{
			return UCharacterMovementComponent.__K2_GetWalkableFloorAngle_Internal(base.NativePtr);
		}

		// Token: 0x06001E7C RID: 7804 RVA: 0x0002CD94 File Offset: 0x0002AF94
		public float K2_GetModifiedMaxAcceleration()
		{
			return UCharacterMovementComponent.__K2_GetModifiedMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x06001E7D RID: 7805 RVA: 0x0002CDA1 File Offset: 0x0002AFA1
		public void K2_FindFloor(FVector CapsuleLocation, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__K2_FindFloor_Internal(base.NativePtr, CapsuleLocation, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x06001E7E RID: 7806 RVA: 0x0002CDBF File Offset: 0x0002AFBF
		public void K2_ComputeFloorDist(FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__K2_ComputeFloorDist_Internal(base.NativePtr, CapsuleLocation, LineDistance, SweepDistance, SweepRadius, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x06001E7F RID: 7807 RVA: 0x0002CDE2 File Offset: 0x0002AFE2
		public bool IsWalking()
		{
			return UCharacterMovementComponent.__IsWalking_Internal(base.NativePtr);
		}

		// Token: 0x06001E80 RID: 7808 RVA: 0x0002CDEF File Offset: 0x0002AFEF
		public bool IsWalkable(in FHitResult Hit)
		{
			return UCharacterMovementComponent.__IsWalkable_Internal(base.NativePtr, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06001E81 RID: 7809 RVA: 0x0002CE0C File Offset: 0x0002B00C
		public float GetValidPerchRadius()
		{
			return UCharacterMovementComponent.__GetValidPerchRadius_Internal(base.NativePtr);
		}

		// Token: 0x06001E82 RID: 7810 RVA: 0x0002CE19 File Offset: 0x0002B019
		public float GetPerchRadiusThreshold()
		{
			return UCharacterMovementComponent.__GetPerchRadiusThreshold_Internal(base.NativePtr);
		}

		// Token: 0x06001E83 RID: 7811 RVA: 0x0002CE26 File Offset: 0x0002B026
		public UPrimitiveComponent GetMovementBase()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UCharacterMovementComponent.__GetMovementBase_Internal(base.NativePtr));
		}

		// Token: 0x06001E84 RID: 7812 RVA: 0x0002CE38 File Offset: 0x0002B038
		public float GetMinAnalogSpeed()
		{
			return UCharacterMovementComponent.__GetMinAnalogSpeed_Internal(base.NativePtr);
		}

		// Token: 0x06001E85 RID: 7813 RVA: 0x0002CE45 File Offset: 0x0002B045
		public float GetMaxJumpHeightWithJumpTime()
		{
			return UCharacterMovementComponent.__GetMaxJumpHeightWithJumpTime_Internal(base.NativePtr);
		}

		// Token: 0x06001E86 RID: 7814 RVA: 0x0002CE52 File Offset: 0x0002B052
		public float GetMaxJumpHeight()
		{
			return UCharacterMovementComponent.__GetMaxJumpHeight_Internal(base.NativePtr);
		}

		// Token: 0x06001E87 RID: 7815 RVA: 0x0002CE5F File Offset: 0x0002B05F
		public float GetMaxBrakingDeceleration()
		{
			return UCharacterMovementComponent.__GetMaxBrakingDeceleration_Internal(base.NativePtr);
		}

		// Token: 0x06001E88 RID: 7816 RVA: 0x0002CE6C File Offset: 0x0002B06C
		public float GetMaxAcceleration()
		{
			return UCharacterMovementComponent.__GetMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x06001E89 RID: 7817 RVA: 0x0002CE79 File Offset: 0x0002B079
		public FVector GetLastUpdateVelocity()
		{
			return UCharacterMovementComponent.__GetLastUpdateVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06001E8A RID: 7818 RVA: 0x0002CE86 File Offset: 0x0002B086
		public FRotator GetLastUpdateRotation()
		{
			return UCharacterMovementComponent.__GetLastUpdateRotation_Internal(base.NativePtr);
		}

		// Token: 0x06001E8B RID: 7819 RVA: 0x0002CE93 File Offset: 0x0002B093
		public FVector GetLastUpdateLocation()
		{
			return UCharacterMovementComponent.__GetLastUpdateLocation_Internal(base.NativePtr);
		}

		// Token: 0x06001E8C RID: 7820 RVA: 0x0002CEA0 File Offset: 0x0002B0A0
		public FVector GetImpartedMovementBaseVelocity()
		{
			return UCharacterMovementComponent.__GetImpartedMovementBaseVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06001E8D RID: 7821 RVA: 0x0002CEAD File Offset: 0x0002B0AD
		public FVector GetCurrentAcceleration()
		{
			return UCharacterMovementComponent.__GetCurrentAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x06001E8E RID: 7822 RVA: 0x0002CEBA File Offset: 0x0002B0BA
		public ACharacter GetCharacterOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(UCharacterMovementComponent.__GetCharacterOwner_Internal(base.NativePtr));
		}

		// Token: 0x06001E8F RID: 7823 RVA: 0x0002CECC File Offset: 0x0002B0CC
		public float GetAnalogInputModifier()
		{
			return UCharacterMovementComponent.__GetAnalogInputModifier_Internal(base.NativePtr);
		}

		// Token: 0x06001E90 RID: 7824 RVA: 0x0002CED9 File Offset: 0x0002B0D9
		public void DisableMovement()
		{
			UCharacterMovementComponent.__DisableMovement_Internal(base.NativePtr);
		}

		// Token: 0x06001E91 RID: 7825 RVA: 0x0002CEE6 File Offset: 0x0002B0E6
		public void D_MoveAdjust(in FVectorDouble Delta)
		{
			UCharacterMovementComponent.__D_MoveAdjust_Internal(base.NativePtr, Delta);
		}

		// Token: 0x06001E92 RID: 7826 RVA: 0x0002CEF4 File Offset: 0x0002B0F4
		public void D_K2_FindFloor(FVectorDouble CapsuleLocation, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__D_K2_FindFloor_Internal(base.NativePtr, CapsuleLocation, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x06001E93 RID: 7827 RVA: 0x0002CF12 File Offset: 0x0002B112
		public void ClearAccumulatedForces()
		{
			UCharacterMovementComponent.__ClearAccumulatedForces_Internal(base.NativePtr);
		}

		// Token: 0x06001E94 RID: 7828 RVA: 0x0002CF20 File Offset: 0x0002B120
		public void CapsuleTouchedEvenBlock(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			UCharacterMovementComponent.__CapsuleTouchedEvenBlock_Internal(base.NativePtr, (OverlappedComp != null) ? OverlappedComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06001E95 RID: 7829 RVA: 0x0002CF80 File Offset: 0x0002B180
		public void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			UCharacterMovementComponent.__CapsuleTouched_Internal(base.NativePtr, (OverlappedComp != null) ? OverlappedComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x06001E96 RID: 7830 RVA: 0x0002CFDD File Offset: 0x0002B1DD
		public void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
		{
			UCharacterMovementComponent.__CalcVelocity_Internal(base.NativePtr, DeltaTime, Friction, bFluid, BrakingDeceleration);
		}

		// Token: 0x06001E97 RID: 7831 RVA: 0x0002CFF0 File Offset: 0x0002B1F0
		public unsafe void AddReplayData(ref FVector RemoteLocation, ref FRotator RemoteRotation, ref FVector RemoteVelocity, ref FVector RemoteAcceleration, byte RemoteViewPitch, float Time)
		{
			fixed (FVector* ptr = &RemoteLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &RemoteRotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &RemoteVelocity)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &RemoteAcceleration)
						{
							void* ptr8 = (void*)ptr7;
							UCharacterMovementComponent.__AddReplayData_Internal(base.NativePtr, ref RemoteLocation, ref RemoteRotation, ref RemoteVelocity, ref RemoteAcceleration, RemoteViewPitch, Time);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x06001E98 RID: 7832 RVA: 0x0002D03E File Offset: 0x0002B23E
		public void AddImpulse(FVector Impulse, bool bVelocityChange = false)
		{
			UCharacterMovementComponent.__AddImpulse_Internal(base.NativePtr, Impulse, bVelocityChange);
		}

		// Token: 0x06001E99 RID: 7833 RVA: 0x0002D04D File Offset: 0x0002B24D
		public void AddForce(FVector Force)
		{
			UCharacterMovementComponent.__AddForce_Internal(base.NativePtr, Force);
		}

		// Token: 0x06001E9A RID: 7834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWalkableFloorZ_Internal(IntPtr @this, float InWalkableFloorZ);

		// Token: 0x06001E9B RID: 7835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWalkableFloorAngle_Internal(IntPtr @this, float InWalkableFloorAngle);

		// Token: 0x06001E9C RID: 7836
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementMode_Internal(IntPtr @this, TEnumAsByte<EMovementMode> NewMovementMode, byte NewCustomMode);

		// Token: 0x06001E9D RID: 7837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroPlanarPhysWalking_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06001E9E RID: 7838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMovementSettings_Internal(IntPtr @this, IntPtr InKuroMovementSetting);

		// Token: 0x06001E9F RID: 7839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroAsyncRootMotion_Internal(IntPtr @this, bool enable);

		// Token: 0x06001EA0 RID: 7840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToIgnoreMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x06001EA1 RID: 7841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToIgnore_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x06001EA2 RID: 7842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToAvoidMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x06001EA3 RID: 7843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToAvoid_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x06001EA4 RID: 7844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultMovementMode_Internal(IntPtr @this);

		// Token: 0x06001EA5 RID: 7845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceGroupMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x06001EA6 RID: 7846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceGroup_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x06001EA7 RID: 7847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x06001EA8 RID: 7848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAddRotation_Internal(IntPtr @this, in FQuat InAddRotationOffset);

		// Token: 0x06001EA9 RID: 7849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAddMove_Internal(IntPtr @this, FVectorDouble InAddMoveOffset);

		// Token: 0x06001EAA RID: 7850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveAdjust_Internal(IntPtr @this, in FVector Delta);

		// Token: 0x06001EAB RID: 7851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSwimming_Internal(IntPtr @this, float DeltaTime, bool Sweep, float Depth, float KuroBuoyancy, float Friction, float MaxSpeed, float Slope, float Accelerator, float Deceleration);

		// Token: 0x06001EAC RID: 7852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroSlide_Internal(IntPtr @this, float DeltaTime, float AirFriction, float SlideFriction, FVector InputVelocity, float MaxSlideHorizontalSeed, FVector PrevBlockNormal, float MaxSlideVerticalSpeed, IntPtr SpeedReduceCurve);

		// Token: 0x06001EAD RID: 7853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSetPredictionDataMaxMoveDeltaTime_Internal(IntPtr @this, float MaxMoveDeltaTime);

		// Token: 0x06001EAE RID: 7854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __KuroRegisterCustomMovementExtension_Internal(IntPtr @this, byte InCustomMovementMode, IntPtr ExtensionClass, bool bOverrideExisting);

		// Token: 0x06001EAF RID: 7855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPendulum_Internal(IntPtr @this, float AddVelocityX, float AddVelocityY, float AddVelocityZ, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed);

		// Token: 0x06001EB0 RID: 7856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroMoveAlongFloor_Internal(IntPtr @this, in FVector InVelocity, float DeltaSeconds);

		// Token: 0x06001EB1 RID: 7857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __KuroGetCustomMovementExtension_Internal(IntPtr @this, byte InCustomMovementMode);

		// Token: 0x06001EB2 RID: 7858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroFlying_Internal(IntPtr @this, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed);

		// Token: 0x06001EB3 RID: 7859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroFindNavFloor_Internal(IntPtr @this, in FVector TestLocation, ref FVector NavFloorLocation);

		// Token: 0x06001EB4 RID: 7860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetGravityDirect_Internal(IntPtr @this, FVector InGravityDirect);

		// Token: 0x06001EB5 RID: 7861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Kuro_GetKuroBlockHitIndexWhenMove_Internal(IntPtr @this);

		// Token: 0x06001EB6 RID: 7862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravityDirect_Internal(IntPtr @this);

		// Token: 0x06001EB7 RID: 7863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Kuro_GetGravityDeltaRot_Internal(IntPtr @this);

		// Token: 0x06001EB8 RID: 7864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravity_Internal(IntPtr @this);

		// Token: 0x06001EB9 RID: 7865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetBlockDirectWhenMove_Internal(IntPtr @this);

		// Token: 0x06001EBA RID: 7866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Kuro_GetBlockActorWhenMove_Internal(IntPtr @this);

		// Token: 0x06001EBB RID: 7867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_KuroEndScopedMovementUpdate_Internal(IntPtr @this);

		// Token: 0x06001EBC RID: 7868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_KuroBeginScopedMovementUpdate_Internal(IntPtr @this);

		// Token: 0x06001EBD RID: 7869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetWalkableFloorZ_Internal(IntPtr @this);

		// Token: 0x06001EBE RID: 7870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetWalkableFloorAngle_Internal(IntPtr @this);

		// Token: 0x06001EBF RID: 7871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetModifiedMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x06001EC0 RID: 7872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_FindFloor_Internal(IntPtr @this, FVector CapsuleLocation, IntPtr FloorResult);

		// Token: 0x06001EC1 RID: 7873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ComputeFloorDist_Internal(IntPtr @this, FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, IntPtr FloorResult);

		// Token: 0x06001EC2 RID: 7874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWalking_Internal(IntPtr @this);

		// Token: 0x06001EC3 RID: 7875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWalkable_Internal(IntPtr @this, IntPtr Hit);

		// Token: 0x06001EC4 RID: 7876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValidPerchRadius_Internal(IntPtr @this);

		// Token: 0x06001EC5 RID: 7877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPerchRadiusThreshold_Internal(IntPtr @this);

		// Token: 0x06001EC6 RID: 7878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementBase_Internal(IntPtr @this);

		// Token: 0x06001EC7 RID: 7879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinAnalogSpeed_Internal(IntPtr @this);

		// Token: 0x06001EC8 RID: 7880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxJumpHeightWithJumpTime_Internal(IntPtr @this);

		// Token: 0x06001EC9 RID: 7881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxJumpHeight_Internal(IntPtr @this);

		// Token: 0x06001ECA RID: 7882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxBrakingDeceleration_Internal(IntPtr @this);

		// Token: 0x06001ECB RID: 7883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x06001ECC RID: 7884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastUpdateVelocity_Internal(IntPtr @this);

		// Token: 0x06001ECD RID: 7885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetLastUpdateRotation_Internal(IntPtr @this);

		// Token: 0x06001ECE RID: 7886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastUpdateLocation_Internal(IntPtr @this);

		// Token: 0x06001ECF RID: 7887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetImpartedMovementBaseVelocity_Internal(IntPtr @this);

		// Token: 0x06001ED0 RID: 7888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentAcceleration_Internal(IntPtr @this);

		// Token: 0x06001ED1 RID: 7889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterOwner_Internal(IntPtr @this);

		// Token: 0x06001ED2 RID: 7890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnalogInputModifier_Internal(IntPtr @this);

		// Token: 0x06001ED3 RID: 7891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableMovement_Internal(IntPtr @this);

		// Token: 0x06001ED4 RID: 7892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MoveAdjust_Internal(IntPtr @this, in FVectorDouble Delta);

		// Token: 0x06001ED5 RID: 7893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_FindFloor_Internal(IntPtr @this, FVectorDouble CapsuleLocation, IntPtr FloorResult);

		// Token: 0x06001ED6 RID: 7894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAccumulatedForces_Internal(IntPtr @this);

		// Token: 0x06001ED7 RID: 7895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CapsuleTouchedEvenBlock_Internal(IntPtr @this, IntPtr OverlappedComp, IntPtr Other, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06001ED8 RID: 7896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CapsuleTouched_Internal(IntPtr @this, IntPtr OverlappedComp, IntPtr Other, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06001ED9 RID: 7897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalcVelocity_Internal(IntPtr @this, float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration);

		// Token: 0x06001EDA RID: 7898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddReplayData_Internal(IntPtr @this, ref FVector RemoteLocation, ref FRotator RemoteRotation, ref FVector RemoteVelocity, ref FVector RemoteAcceleration, byte RemoteViewPitch, float Time);

		// Token: 0x06001EDB RID: 7899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulse_Internal(IntPtr @this, FVector Impulse, bool bVelocityChange);

		// Token: 0x06001EDC RID: 7900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForce_Internal(IntPtr @this, FVector Force);

		// Token: 0x06001EDD RID: 7901 RVA: 0x0002D05B File Offset: 0x0002B25B
		static UCharacterMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CharacterMovementComponent");
		}

		// Token: 0x06001EDE RID: 7902 RVA: 0x0002D069 File Offset: 0x0002B269
		protected UCharacterMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400095A RID: 2394
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.CharacterMovementComponent";

		// Token: 0x0400095B RID: 2395
		private static IntPtr _ClassPtr;

		// Token: 0x0400095C RID: 2396
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400095D RID: 2397
		internal static int __PropertyOffset_CharacterOwner;

		// Token: 0x0400095E RID: 2398
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x0400095F RID: 2399
		internal static int __PropertyOffset_MaxStepHeight;

		// Token: 0x04000960 RID: 2400
		internal static int __PropertyOffset_JumpZVelocity;

		// Token: 0x04000961 RID: 2401
		internal static int __PropertyOffset_JumpOffJumpZFactor;

		// Token: 0x04000962 RID: 2402
		internal static int __PropertyOffset_WalkableFloorAngle;

		// Token: 0x04000963 RID: 2403
		internal static int __PropertyOffset_WalkableFloorZ;

		// Token: 0x04000964 RID: 2404
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x04000965 RID: 2405
		internal static int __PropertyOffset_CustomMovementMode;

		// Token: 0x04000966 RID: 2406
		internal static int __PropertyOffset_KuroCustomMovementExtensionClasses;

		// Token: 0x04000967 RID: 2407
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<byte, TSubclassOf<UKuroCustomMovementExtension>> _KuroCustomMovementExtensionClasses;

		// Token: 0x04000968 RID: 2408
		internal static int __PropertyOffset_KuroCustomMovementExtensionInstances;

		// Token: 0x04000969 RID: 2409
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<byte, UKuroCustomMovementExtension> _KuroCustomMovementExtensionInstances;

		// Token: 0x0400096A RID: 2410
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x0400096B RID: 2411
		internal static int __PropertyOffset_MaxWalkSpeed;

		// Token: 0x0400096C RID: 2412
		internal static int __PropertyOffset_MaxWalkSpeedCrouched;

		// Token: 0x0400096D RID: 2413
		internal static int __PropertyOffset_MaxSwimSpeed;

		// Token: 0x0400096E RID: 2414
		internal static int __PropertyOffset_MaxFlySpeed;

		// Token: 0x0400096F RID: 2415
		internal static int __PropertyOffset_MaxCustomMovementSpeed;

		// Token: 0x04000970 RID: 2416
		internal static int __PropertyOffset_MaxAcceleration;

		// Token: 0x04000971 RID: 2417
		internal static int __PropertyOffset_MinAnalogWalkSpeed;

		// Token: 0x04000972 RID: 2418
		internal static int __PropertyOffset_BrakingFrictionFactor;

		// Token: 0x04000973 RID: 2419
		internal static int __PropertyOffset_BrakingFriction;

		// Token: 0x04000974 RID: 2420
		internal static int __PropertyOffset_BrakingSubStepTime;

		// Token: 0x04000975 RID: 2421
		internal static int __PropertyOffset_BrakingDecelerationWalking;

		// Token: 0x04000976 RID: 2422
		internal static int __PropertyOffset_BrakingDecelerationFalling;

		// Token: 0x04000977 RID: 2423
		internal static int __PropertyOffset_BrakingDecelerationSwimming;

		// Token: 0x04000978 RID: 2424
		internal static int __PropertyOffset_BrakingDecelerationFlying;

		// Token: 0x04000979 RID: 2425
		internal static int __PropertyOffset_AirControl;

		// Token: 0x0400097A RID: 2426
		internal static int __PropertyOffset_AirControlBoostMultiplier;

		// Token: 0x0400097B RID: 2427
		internal static int __PropertyOffset_AirControlBoostVelocityThreshold;

		// Token: 0x0400097C RID: 2428
		internal static int __PropertyOffset_FallingLateralFriction;

		// Token: 0x0400097D RID: 2429
		internal static int __PropertyOffset_CrouchedHalfHeight;

		// Token: 0x0400097E RID: 2430
		internal static int __PropertyOffset_Buoyancy;

		// Token: 0x0400097F RID: 2431
		internal static int __PropertyOffset_PerchRadiusThreshold;

		// Token: 0x04000980 RID: 2432
		internal static int __PropertyOffset_PerchAdditionalHeight;

		// Token: 0x04000981 RID: 2433
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x04000982 RID: 2434
		internal static int __PropertyOffset_bUseSeparateBrakingFriction;

		// Token: 0x04000983 RID: 2435
		internal static byte __PropertyMask_bUseSeparateBrakingFriction;

		// Token: 0x04000984 RID: 2436
		internal static int __PropertyOffset_bApplyGravityWhileJumping;

		// Token: 0x04000985 RID: 2437
		internal static byte __PropertyMask_bApplyGravityWhileJumping;

		// Token: 0x04000986 RID: 2438
		internal static int __PropertyOffset_bUseControllerDesiredRotation;

		// Token: 0x04000987 RID: 2439
		internal static byte __PropertyMask_bUseControllerDesiredRotation;

		// Token: 0x04000988 RID: 2440
		internal static int __PropertyOffset_bOrientRotationToMovement;

		// Token: 0x04000989 RID: 2441
		internal static byte __PropertyMask_bOrientRotationToMovement;

		// Token: 0x0400098A RID: 2442
		internal static int __PropertyOffset_bRotationFollowBaseMovement;

		// Token: 0x0400098B RID: 2443
		internal static byte __PropertyMask_bRotationFollowBaseMovement;

		// Token: 0x0400098C RID: 2444
		internal static int __PropertyOffset_bSweepWhileNavWalking;

		// Token: 0x0400098D RID: 2445
		internal static byte __PropertyMask_bSweepWhileNavWalking;

		// Token: 0x0400098E RID: 2446
		internal static int __PropertyOffset_bKuroAutoActiveNav;

		// Token: 0x0400098F RID: 2447
		internal static int __PropertyOffset_bKuroStillBlockInNav;

		// Token: 0x04000990 RID: 2448
		internal static int __PropertyOffset_OverrideTerminalVelocity;

		// Token: 0x04000991 RID: 2449
		internal static int __PropertyOffset_HitPriority;

		// Token: 0x04000992 RID: 2450
		internal static int __PropertyOffset_GoThroughLower;

		// Token: 0x04000993 RID: 2451
		internal static int __PropertyOffset_GoThroughPriority;

		// Token: 0x04000994 RID: 2452
		internal static int __PropertyOffset_bKuroStopUpdateBasedMovement;

		// Token: 0x04000995 RID: 2453
		internal static int __PropertyOffset_bForbiddenTickPose;

		// Token: 0x04000996 RID: 2454
		internal static int __PropertyOffset_bKuroWalkOnAir;

		// Token: 0x04000997 RID: 2455
		internal static int __PropertyOffset_ConveyDelta;

		// Token: 0x04000998 RID: 2456
		internal static int __PropertyOffset_bMovementInProgress;

		// Token: 0x04000999 RID: 2457
		internal static byte __PropertyMask_bMovementInProgress;

		// Token: 0x0400099A RID: 2458
		internal static int __PropertyOffset_bEnableScopedMovementUpdates;

		// Token: 0x0400099B RID: 2459
		internal static byte __PropertyMask_bEnableScopedMovementUpdates;

		// Token: 0x0400099C RID: 2460
		internal static int __PropertyOffset_bEnableServerDualMoveScopedMovementUpdates;

		// Token: 0x0400099D RID: 2461
		internal static byte __PropertyMask_bEnableServerDualMoveScopedMovementUpdates;

		// Token: 0x0400099E RID: 2462
		internal static int __PropertyOffset_bForceMaxAccel;

		// Token: 0x0400099F RID: 2463
		internal static byte __PropertyMask_bForceMaxAccel;

		// Token: 0x040009A0 RID: 2464
		internal static int __PropertyOffset_bRunPhysicsWithNoController;

		// Token: 0x040009A1 RID: 2465
		internal static byte __PropertyMask_bRunPhysicsWithNoController;

		// Token: 0x040009A2 RID: 2466
		internal static int __PropertyOffset_bForceNextFloorCheck;

		// Token: 0x040009A3 RID: 2467
		internal static byte __PropertyMask_bForceNextFloorCheck;

		// Token: 0x040009A4 RID: 2468
		internal static int __PropertyOffset_bShrinkProxyCapsule;

		// Token: 0x040009A5 RID: 2469
		internal static byte __PropertyMask_bShrinkProxyCapsule;

		// Token: 0x040009A6 RID: 2470
		internal static int __PropertyOffset_bCanWalkOffLedges;

		// Token: 0x040009A7 RID: 2471
		internal static byte __PropertyMask_bCanWalkOffLedges;

		// Token: 0x040009A8 RID: 2472
		internal static int __PropertyOffset_bCanWalkOffLedgesWhenCrouching;

		// Token: 0x040009A9 RID: 2473
		internal static byte __PropertyMask_bCanWalkOffLedgesWhenCrouching;

		// Token: 0x040009AA RID: 2474
		internal static int __PropertyOffset_bKuroCanWalkOffLedgesNav;

		// Token: 0x040009AB RID: 2475
		internal static byte __PropertyMask_bKuroCanWalkOffLedgesNav;

		// Token: 0x040009AC RID: 2476
		internal static int __PropertyOffset_bKuroUsePerchEdgeDirection;

		// Token: 0x040009AD RID: 2477
		internal static byte __PropertyMask_bKuroUsePerchEdgeDirection;

		// Token: 0x040009AE RID: 2478
		internal static int __PropertyOffset_bKuroPlanarPhysWalking;

		// Token: 0x040009AF RID: 2479
		internal static byte __PropertyMask_bKuroPlanarPhysWalking;

		// Token: 0x040009B0 RID: 2480
		internal static int __PropertyOffset_bKuroPlanarNeedFindFloor;

		// Token: 0x040009B1 RID: 2481
		internal static byte __PropertyMask_bKuroPlanarNeedFindFloor;

		// Token: 0x040009B2 RID: 2482
		internal static int __PropertyOffset_bNetworkSkipProxyPredictionOnNetUpdate;

		// Token: 0x040009B3 RID: 2483
		internal static byte __PropertyMask_bNetworkSkipProxyPredictionOnNetUpdate;

		// Token: 0x040009B4 RID: 2484
		internal static int __PropertyOffset_bNetworkAlwaysReplicateTransformUpdateTimestamp;

		// Token: 0x040009B5 RID: 2485
		internal static byte __PropertyMask_bNetworkAlwaysReplicateTransformUpdateTimestamp;

		// Token: 0x040009B6 RID: 2486
		internal static int __PropertyOffset_bDeferUpdateMoveComponent;

		// Token: 0x040009B7 RID: 2487
		internal static byte __PropertyMask_bDeferUpdateMoveComponent;

		// Token: 0x040009B8 RID: 2488
		internal static int __PropertyOffset_bEnablePhysicsInteraction;

		// Token: 0x040009B9 RID: 2489
		internal static byte __PropertyMask_bEnablePhysicsInteraction;

		// Token: 0x040009BA RID: 2490
		internal static int __PropertyOffset_bTouchForceScaledToMass;

		// Token: 0x040009BB RID: 2491
		internal static byte __PropertyMask_bTouchForceScaledToMass;

		// Token: 0x040009BC RID: 2492
		internal static int __PropertyOffset_bPushForceScaledToMass;

		// Token: 0x040009BD RID: 2493
		internal static byte __PropertyMask_bPushForceScaledToMass;

		// Token: 0x040009BE RID: 2494
		internal static int __PropertyOffset_bPushForceUsingZOffset;

		// Token: 0x040009BF RID: 2495
		internal static byte __PropertyMask_bPushForceUsingZOffset;

		// Token: 0x040009C0 RID: 2496
		internal static int __PropertyOffset_bScalePushForceToVelocity;

		// Token: 0x040009C1 RID: 2497
		internal static byte __PropertyMask_bScalePushForceToVelocity;

		// Token: 0x040009C2 RID: 2498
		internal static int __PropertyOffset_DeferredUpdatedMoveComponent;

		// Token: 0x040009C3 RID: 2499
		internal static int __PropertyOffset_StepUpSpeedPrecent;

		// Token: 0x040009C4 RID: 2500
		internal static int __PropertyOffset_StepDownSpeedPrecent;

		// Token: 0x040009C5 RID: 2501
		internal static int __PropertyOffset_StepUpDeltaPrecent;

		// Token: 0x040009C6 RID: 2502
		internal static int __PropertyOffset_StepUpStandardSpeed;

		// Token: 0x040009C7 RID: 2503
		internal static int __PropertyOffset_MaxOutOfWaterStepHeight;

		// Token: 0x040009C8 RID: 2504
		internal static int __PropertyOffset_OutofWaterZ;

		// Token: 0x040009C9 RID: 2505
		internal static int __PropertyOffset_Mass;

		// Token: 0x040009CA RID: 2506
		internal static int __PropertyOffset_StandingDownwardForceScale;

		// Token: 0x040009CB RID: 2507
		internal static int __PropertyOffset_InitialPushForceFactor;

		// Token: 0x040009CC RID: 2508
		internal static int __PropertyOffset_PushForceFactor;

		// Token: 0x040009CD RID: 2509
		internal static int __PropertyOffset_PushForcePointZOffsetFactor;

		// Token: 0x040009CE RID: 2510
		internal static int __PropertyOffset_TouchForceFactor;

		// Token: 0x040009CF RID: 2511
		internal static int __PropertyOffset_MinTouchForce;

		// Token: 0x040009D0 RID: 2512
		internal static int __PropertyOffset_MaxTouchForce;

		// Token: 0x040009D1 RID: 2513
		internal static int __PropertyOffset_RepulsionForce;

		// Token: 0x040009D2 RID: 2514
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x040009D3 RID: 2515
		internal static int __PropertyOffset_LastUpdateRotation;

		// Token: 0x040009D4 RID: 2516
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x040009D5 RID: 2517
		internal static int __PropertyOffset_LastUpdateVelocity;

		// Token: 0x040009D6 RID: 2518
		internal static int __PropertyOffset_ServerLastTransformUpdateTimeStamp;

		// Token: 0x040009D7 RID: 2519
		internal static int __PropertyOffset_ServerLastClientGoodMoveAckTime;

		// Token: 0x040009D8 RID: 2520
		internal static int __PropertyOffset_ServerLastClientAdjustmentTime;

		// Token: 0x040009D9 RID: 2521
		internal static int __PropertyOffset_PendingImpulseToApply;

		// Token: 0x040009DA RID: 2522
		internal static int __PropertyOffset_PendingForceToApply;

		// Token: 0x040009DB RID: 2523
		internal static int __PropertyOffset_AnalogInputModifier;

		// Token: 0x040009DC RID: 2524
		internal static int __PropertyOffset_BaseDeltaPosition;

		// Token: 0x040009DD RID: 2525
		internal static int __PropertyOffset_BaseDeltaQuat;

		// Token: 0x040009DE RID: 2526
		internal static int __PropertyOffset_ReplayDriverTime;

		// Token: 0x040009DF RID: 2527
		internal static int __PropertyOffset_bKuroVelocityDebug;

		// Token: 0x040009E0 RID: 2528
		internal static int __PropertyOffset_MonitorMaxVelocityZ;

		// Token: 0x040009E1 RID: 2529
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x040009E2 RID: 2530
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x040009E3 RID: 2531
		internal static int __PropertyOffset_MaxJumpApexAttemptsPerSimulation;

		// Token: 0x040009E4 RID: 2532
		internal static int __PropertyOffset_MaxDepenetrationWithGeometry;

		// Token: 0x040009E5 RID: 2533
		internal static int __PropertyOffset_MaxDepenetrationWithGeometryAsProxy;

		// Token: 0x040009E6 RID: 2534
		internal static int __PropertyOffset_MaxDepenetrationWithPawn;

		// Token: 0x040009E7 RID: 2535
		internal static int __PropertyOffset_MaxDepenetrationWithPawnAsProxy;

		// Token: 0x040009E8 RID: 2536
		internal static int __PropertyOffset_MaxDepenetrationPerSeconds;

		// Token: 0x040009E9 RID: 2537
		internal static int __PropertyOffset_NetworkSimulatedSmoothLocationTime;

		// Token: 0x040009EA RID: 2538
		internal static int __PropertyOffset_NetworkSimulatedSmoothRotationTime;

		// Token: 0x040009EB RID: 2539
		internal static int __PropertyOffset_ListenServerNetworkSimulatedSmoothLocationTime;

		// Token: 0x040009EC RID: 2540
		internal static int __PropertyOffset_ListenServerNetworkSimulatedSmoothRotationTime;

		// Token: 0x040009ED RID: 2541
		internal static int __PropertyOffset_NetProxyShrinkRadius;

		// Token: 0x040009EE RID: 2542
		internal static int __PropertyOffset_NetProxyShrinkHalfHeight;

		// Token: 0x040009EF RID: 2543
		internal static int __PropertyOffset_NetworkMaxSmoothUpdateDistance;

		// Token: 0x040009F0 RID: 2544
		internal static int __PropertyOffset_NetworkNoSmoothUpdateDistance;

		// Token: 0x040009F1 RID: 2545
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAckGoodMoves;

		// Token: 0x040009F2 RID: 2546
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAdjustments;

		// Token: 0x040009F3 RID: 2547
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;

		// Token: 0x040009F4 RID: 2548
		internal static int __PropertyOffset_NetworkLargeClientCorrectionDistance;

		// Token: 0x040009F5 RID: 2549
		internal static int __PropertyOffset_NetworkPredictingLinearSmoothMaxRange;

		// Token: 0x040009F6 RID: 2550
		internal static int __PropertyOffset_NetworkPredictingSmoothFactorWithDistance;

		// Token: 0x040009F7 RID: 2551
		internal static int __PropertyOffset_NetworkPredictingSmoothFactorWithSpeed;

		// Token: 0x040009F8 RID: 2552
		internal static int __PropertyOffset_NetworkPredictingMinSmoothMeshSpeed;

		// Token: 0x040009F9 RID: 2553
		internal static int __PropertyOffset_NetworkPredictingMaxSmoothMeshSpeed;

		// Token: 0x040009FA RID: 2554
		internal static int __PropertyOffset_NetworkPredictingZSmoothTimeOnGround;

		// Token: 0x040009FB RID: 2555
		internal static int __PropertyOffset_LedgeCheckThreshold;

		// Token: 0x040009FC RID: 2556
		internal static int __PropertyOffset_JumpOutOfWaterPitch;

		// Token: 0x040009FD RID: 2557
		internal static int __PropertyOffset_CurrentFloor;

		// Token: 0x040009FE RID: 2558
		private FFindFloorResult _CurrentFloor;

		// Token: 0x040009FF RID: 2559
		internal static int __PropertyOffset_DefaultLandMovementMode;

		// Token: 0x04000A00 RID: 2560
		internal static int __PropertyOffset_DefaultWaterMovementMode;

		// Token: 0x04000A01 RID: 2561
		internal static int __PropertyOffset_PredictionDataMaxMoveDeltaTime;

		// Token: 0x04000A02 RID: 2562
		internal static int __PropertyOffset_GroundMovementMode;

		// Token: 0x04000A03 RID: 2563
		internal static int __PropertyOffset_bMaintainHorizontalGroundVelocity;

		// Token: 0x04000A04 RID: 2564
		internal static byte __PropertyMask_bMaintainHorizontalGroundVelocity;

		// Token: 0x04000A05 RID: 2565
		internal static int __PropertyOffset_bImpartBaseVelocityX;

		// Token: 0x04000A06 RID: 2566
		internal static byte __PropertyMask_bImpartBaseVelocityX;

		// Token: 0x04000A07 RID: 2567
		internal static int __PropertyOffset_bImpartBaseVelocityY;

		// Token: 0x04000A08 RID: 2568
		internal static byte __PropertyMask_bImpartBaseVelocityY;

		// Token: 0x04000A09 RID: 2569
		internal static int __PropertyOffset_bImpartBaseVelocityZ;

		// Token: 0x04000A0A RID: 2570
		internal static byte __PropertyMask_bImpartBaseVelocityZ;

		// Token: 0x04000A0B RID: 2571
		internal static int __PropertyOffset_bImpartBaseAngularVelocity;

		// Token: 0x04000A0C RID: 2572
		internal static byte __PropertyMask_bImpartBaseAngularVelocity;

		// Token: 0x04000A0D RID: 2573
		internal static int __PropertyOffset_bJustTeleported;

		// Token: 0x04000A0E RID: 2574
		internal static byte __PropertyMask_bJustTeleported;

		// Token: 0x04000A0F RID: 2575
		internal static int __PropertyOffset_bNetworkUpdateReceived;

		// Token: 0x04000A10 RID: 2576
		internal static byte __PropertyMask_bNetworkUpdateReceived;

		// Token: 0x04000A11 RID: 2577
		internal static int __PropertyOffset_bNetworkMovementModeChanged;

		// Token: 0x04000A12 RID: 2578
		internal static byte __PropertyMask_bNetworkMovementModeChanged;

		// Token: 0x04000A13 RID: 2579
		internal static int __PropertyOffset_bIgnoreClientMovementErrorChecksAndCorrection;

		// Token: 0x04000A14 RID: 2580
		internal static byte __PropertyMask_bIgnoreClientMovementErrorChecksAndCorrection;

		// Token: 0x04000A15 RID: 2581
		internal static int __PropertyOffset_bServerAcceptClientAuthoritativePosition;

		// Token: 0x04000A16 RID: 2582
		internal static byte __PropertyMask_bServerAcceptClientAuthoritativePosition;

		// Token: 0x04000A17 RID: 2583
		internal static int __PropertyOffset_bNotifyApex;

		// Token: 0x04000A18 RID: 2584
		internal static byte __PropertyMask_bNotifyApex;

		// Token: 0x04000A19 RID: 2585
		internal static int __PropertyOffset_bCheatFlying;

		// Token: 0x04000A1A RID: 2586
		internal static byte __PropertyMask_bCheatFlying;

		// Token: 0x04000A1B RID: 2587
		internal static int __PropertyOffset_bWantsToCrouch;

		// Token: 0x04000A1C RID: 2588
		internal static byte __PropertyMask_bWantsToCrouch;

		// Token: 0x04000A1D RID: 2589
		internal static int __PropertyOffset_bCrouchMaintainsBaseLocation;

		// Token: 0x04000A1E RID: 2590
		internal static byte __PropertyMask_bCrouchMaintainsBaseLocation;

		// Token: 0x04000A1F RID: 2591
		internal static int __PropertyOffset_bIgnoreBaseRotation;

		// Token: 0x04000A20 RID: 2592
		internal static byte __PropertyMask_bIgnoreBaseRotation;

		// Token: 0x04000A21 RID: 2593
		internal static int __PropertyOffset_bFastAttachedMove;

		// Token: 0x04000A22 RID: 2594
		internal static byte __PropertyMask_bFastAttachedMove;

		// Token: 0x04000A23 RID: 2595
		internal static int __PropertyOffset_bAlwaysCheckFloor;

		// Token: 0x04000A24 RID: 2596
		internal static byte __PropertyMask_bAlwaysCheckFloor;

		// Token: 0x04000A25 RID: 2597
		internal static int __PropertyOffset_bUseFlatBaseForFloorChecks;

		// Token: 0x04000A26 RID: 2598
		internal static byte __PropertyMask_bUseFlatBaseForFloorChecks;

		// Token: 0x04000A27 RID: 2599
		internal static int __PropertyOffset_bPerformingJumpOff;

		// Token: 0x04000A28 RID: 2600
		internal static byte __PropertyMask_bPerformingJumpOff;

		// Token: 0x04000A29 RID: 2601
		internal static int __PropertyOffset_bWantsToLeaveNavWalking;

		// Token: 0x04000A2A RID: 2602
		internal static byte __PropertyMask_bWantsToLeaveNavWalking;

		// Token: 0x04000A2B RID: 2603
		internal static int __PropertyOffset_bUseRVOAvoidance;

		// Token: 0x04000A2C RID: 2604
		internal static byte __PropertyMask_bUseRVOAvoidance;

		// Token: 0x04000A2D RID: 2605
		internal static int __PropertyOffset_bRequestedMoveUseAcceleration;

		// Token: 0x04000A2E RID: 2606
		internal static byte __PropertyMask_bRequestedMoveUseAcceleration;

		// Token: 0x04000A2F RID: 2607
		internal static int __PropertyOffset_bWasSimulatingRootMotion;

		// Token: 0x04000A30 RID: 2608
		internal static byte __PropertyMask_bWasSimulatingRootMotion;

		// Token: 0x04000A31 RID: 2609
		internal static int __PropertyOffset_bAllowPhysicsRotationDuringAnimRootMotion;

		// Token: 0x04000A32 RID: 2610
		internal static byte __PropertyMask_bAllowPhysicsRotationDuringAnimRootMotion;

		// Token: 0x04000A33 RID: 2611
		internal static int __PropertyOffset_bHasRequestedVelocity;

		// Token: 0x04000A34 RID: 2612
		internal static byte __PropertyMask_bHasRequestedVelocity;

		// Token: 0x04000A35 RID: 2613
		internal static int __PropertyOffset_bRequestedMoveWithMaxSpeed;

		// Token: 0x04000A36 RID: 2614
		internal static byte __PropertyMask_bRequestedMoveWithMaxSpeed;

		// Token: 0x04000A37 RID: 2615
		internal static int __PropertyOffset_bWasAvoidanceUpdated;

		// Token: 0x04000A38 RID: 2616
		internal static byte __PropertyMask_bWasAvoidanceUpdated;

		// Token: 0x04000A39 RID: 2617
		internal static int __PropertyOffset_bProjectNavMeshWalking;

		// Token: 0x04000A3A RID: 2618
		internal static byte __PropertyMask_bProjectNavMeshWalking;

		// Token: 0x04000A3B RID: 2619
		internal static int __PropertyOffset_bProjectNavMeshOnBothWorldChannels;

		// Token: 0x04000A3C RID: 2620
		internal static byte __PropertyMask_bProjectNavMeshOnBothWorldChannels;

		// Token: 0x04000A3D RID: 2621
		internal static int __PropertyOffset_AvoidanceConsiderationRadius;

		// Token: 0x04000A3E RID: 2622
		internal static int __PropertyOffset_RequestedVelocity;

		// Token: 0x04000A3F RID: 2623
		internal static int __PropertyOffset_AvoidanceUID;

		// Token: 0x04000A40 RID: 2624
		internal static int __PropertyOffset_AvoidanceGroup;

		// Token: 0x04000A41 RID: 2625
		private FNavAvoidanceMask _AvoidanceGroup;

		// Token: 0x04000A42 RID: 2626
		internal static int __PropertyOffset_GroupsToAvoid;

		// Token: 0x04000A43 RID: 2627
		private FNavAvoidanceMask _GroupsToAvoid;

		// Token: 0x04000A44 RID: 2628
		internal static int __PropertyOffset_GroupsToIgnore;

		// Token: 0x04000A45 RID: 2629
		private FNavAvoidanceMask _GroupsToIgnore;

		// Token: 0x04000A46 RID: 2630
		internal static int __PropertyOffset_AvoidanceWeight;

		// Token: 0x04000A47 RID: 2631
		internal static int __PropertyOffset_AvoidancePredictAlpha;

		// Token: 0x04000A48 RID: 2632
		internal static int __PropertyOffset_PendingLaunchVelocity;

		// Token: 0x04000A49 RID: 2633
		internal static int __PropertyOffset_NavMeshProjectionInterval;

		// Token: 0x04000A4A RID: 2634
		internal static int __PropertyOffset_NavMeshProjectionTimer;

		// Token: 0x04000A4B RID: 2635
		internal static int __PropertyOffset_NavMeshProjectionInterpSpeed;

		// Token: 0x04000A4C RID: 2636
		internal static int __PropertyOffset_NavMeshProjectionHeightScaleUp;

		// Token: 0x04000A4D RID: 2637
		internal static int __PropertyOffset_NavMeshProjectionHeightScaleDown;

		// Token: 0x04000A4E RID: 2638
		internal static int __PropertyOffset_NavWalkingFloorDistTolerance;

		// Token: 0x04000A4F RID: 2639
		internal static int __PropertyOffset_MinTimeBetweenTimeStampResets;

		// Token: 0x04000A50 RID: 2640
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x04000A51 RID: 2641
		private FRootMotionMovementParams _RootMotionParams;

		// Token: 0x04000A52 RID: 2642
		internal static int __PropertyOffset_AnimRootMotionVelocity;

		// Token: 0x04000A53 RID: 2643
		internal static int __PropertyOffset_AnimRootMotionRotateAxis;

		// Token: 0x04000A54 RID: 2644
		internal static int __PropertyOffset_AnimRootMotionRotateSpeed;

		// Token: 0x04000A55 RID: 2645
		internal static int __PropertyOffset_bKuroAsyncRootMotion;

		// Token: 0x04000A56 RID: 2646
		internal static byte __PropertyMask_bKuroAsyncRootMotion;

		// Token: 0x04000A57 RID: 2647
		internal static int __PropertyOffset_KuroPredictMotionMask;

		// Token: 0x04000A58 RID: 2648
		internal static int __PropertyOffset_KuroMovementSetting;

		// Token: 0x04000A59 RID: 2649
		private FKuroMovementSetting _KuroMovementSetting;
	}
}
