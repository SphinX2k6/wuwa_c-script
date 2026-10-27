using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000926 RID: 2342
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.CharacterMovementComponent")]
	[UnrealStructLayout(3632, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 3632)]
	public class UCharacterMovementComponent : UPawnMovementComponent, IUnrealUObject, IUnrealObject, IRVOAvoidanceInterface, IUnrealNativeInterface, IUnrealInterface, INetworkPredictionInterface
	{
		// Token: 0x06008221 RID: 33313 RVA: 0x000BA3C3 File Offset: 0x000B85C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCharacterMovementComponent._ClassPtr;
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x000BA3CF File Offset: 0x000B85CF
		int IRVOAvoidanceInterface.InterfaceOffset()
		{
			return UCharacterMovementComponent.__InterfaceOffset_IRVOAvoidanceInterface;
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x000BA3D6 File Offset: 0x000B85D6
		int INetworkPredictionInterface.InterfaceOffset()
		{
			return UCharacterMovementComponent.__InterfaceOffset_INetworkPredictionInterface;
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x000BA3E0 File Offset: 0x000B85E0
		public UCharacterMovementComponent() : this(BuiltinUtils.AllocNativeUObject(UCharacterMovementComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x000BA408 File Offset: 0x000B8608
		public UCharacterMovementComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCharacterMovementComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E96 RID: 7830
		// (get) Token: 0x06008226 RID: 33318 RVA: 0x000BA43B File Offset: 0x000B863B
		// (set) Token: 0x06008227 RID: 33319 RVA: 0x000BA44F File Offset: 0x000B864F
		[Nullable(2)]
		public unsafe ACharacter CharacterOwner
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ACharacter>(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_CharacterOwner);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_CharacterOwner, value);
			}
		}

		// Token: 0x17001E97 RID: 7831
		// (get) Token: 0x06008228 RID: 33320 RVA: 0x000BA464 File Offset: 0x000B8664
		// (set) Token: 0x06008229 RID: 33321 RVA: 0x000BA474 File Offset: 0x000B8674
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

		// Token: 0x17001E98 RID: 7832
		// (get) Token: 0x0600822A RID: 33322 RVA: 0x000BA485 File Offset: 0x000B8685
		// (set) Token: 0x0600822B RID: 33323 RVA: 0x000BA495 File Offset: 0x000B8695
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

		// Token: 0x17001E99 RID: 7833
		// (get) Token: 0x0600822C RID: 33324 RVA: 0x000BA4A6 File Offset: 0x000B86A6
		// (set) Token: 0x0600822D RID: 33325 RVA: 0x000BA4B6 File Offset: 0x000B86B6
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

		// Token: 0x17001E9A RID: 7834
		// (get) Token: 0x0600822E RID: 33326 RVA: 0x000BA4C7 File Offset: 0x000B86C7
		// (set) Token: 0x0600822F RID: 33327 RVA: 0x000BA4D7 File Offset: 0x000B86D7
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

		// Token: 0x17001E9B RID: 7835
		// (get) Token: 0x06008230 RID: 33328 RVA: 0x000BA4E8 File Offset: 0x000B86E8
		// (set) Token: 0x06008231 RID: 33329 RVA: 0x000BA4F8 File Offset: 0x000B86F8
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

		// Token: 0x17001E9C RID: 7836
		// (get) Token: 0x06008232 RID: 33330 RVA: 0x000BA509 File Offset: 0x000B8709
		// (set) Token: 0x06008233 RID: 33331 RVA: 0x000BA519 File Offset: 0x000B8719
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

		// Token: 0x17001E9D RID: 7837
		// (get) Token: 0x06008234 RID: 33332 RVA: 0x000BA52A File Offset: 0x000B872A
		// (set) Token: 0x06008235 RID: 33333 RVA: 0x000BA53E File Offset: 0x000B873E
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

		// Token: 0x17001E9E RID: 7838
		// (get) Token: 0x06008236 RID: 33334 RVA: 0x000BA553 File Offset: 0x000B8753
		// (set) Token: 0x06008237 RID: 33335 RVA: 0x000BA563 File Offset: 0x000B8763
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

		// Token: 0x17001E9F RID: 7839
		// (get) Token: 0x06008238 RID: 33336 RVA: 0x000BA574 File Offset: 0x000B8774
		// (set) Token: 0x06008239 RID: 33337 RVA: 0x000BA5AD File Offset: 0x000B87AD
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

		// Token: 0x17001EA0 RID: 7840
		// (get) Token: 0x0600823A RID: 33338 RVA: 0x000BA5BC File Offset: 0x000B87BC
		// (set) Token: 0x0600823B RID: 33339 RVA: 0x000BA5F5 File Offset: 0x000B87F5
		public TMap<byte, UKuroCustomMovementExtension> KuroCustomMovementExtensionInstances
		{
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
			set
			{
				this.KuroCustomMovementExtensionInstances.CopyAssign(value);
			}
		}

		// Token: 0x17001EA1 RID: 7841
		// (get) Token: 0x0600823C RID: 33340 RVA: 0x000BA603 File Offset: 0x000B8803
		// (set) Token: 0x0600823D RID: 33341 RVA: 0x000BA613 File Offset: 0x000B8813
		public unsafe ENetworkSmoothingMode NetworkSmoothingMode
		{
			get
			{
				return (ENetworkSmoothingMode)(*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSmoothingMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_NetworkSmoothingMode) = (byte)value;
			}
		}

		// Token: 0x17001EA2 RID: 7842
		// (get) Token: 0x0600823E RID: 33342 RVA: 0x000BA624 File Offset: 0x000B8824
		// (set) Token: 0x0600823F RID: 33343 RVA: 0x000BA634 File Offset: 0x000B8834
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

		// Token: 0x17001EA3 RID: 7843
		// (get) Token: 0x06008240 RID: 33344 RVA: 0x000BA645 File Offset: 0x000B8845
		// (set) Token: 0x06008241 RID: 33345 RVA: 0x000BA655 File Offset: 0x000B8855
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

		// Token: 0x17001EA4 RID: 7844
		// (get) Token: 0x06008242 RID: 33346 RVA: 0x000BA666 File Offset: 0x000B8866
		// (set) Token: 0x06008243 RID: 33347 RVA: 0x000BA676 File Offset: 0x000B8876
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

		// Token: 0x17001EA5 RID: 7845
		// (get) Token: 0x06008244 RID: 33348 RVA: 0x000BA687 File Offset: 0x000B8887
		// (set) Token: 0x06008245 RID: 33349 RVA: 0x000BA697 File Offset: 0x000B8897
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

		// Token: 0x17001EA6 RID: 7846
		// (get) Token: 0x06008246 RID: 33350 RVA: 0x000BA6A8 File Offset: 0x000B88A8
		// (set) Token: 0x06008247 RID: 33351 RVA: 0x000BA6B8 File Offset: 0x000B88B8
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

		// Token: 0x17001EA7 RID: 7847
		// (get) Token: 0x06008248 RID: 33352 RVA: 0x000BA6C9 File Offset: 0x000B88C9
		// (set) Token: 0x06008249 RID: 33353 RVA: 0x000BA6D9 File Offset: 0x000B88D9
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

		// Token: 0x17001EA8 RID: 7848
		// (get) Token: 0x0600824A RID: 33354 RVA: 0x000BA6EA File Offset: 0x000B88EA
		// (set) Token: 0x0600824B RID: 33355 RVA: 0x000BA6FA File Offset: 0x000B88FA
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

		// Token: 0x17001EA9 RID: 7849
		// (get) Token: 0x0600824C RID: 33356 RVA: 0x000BA70B File Offset: 0x000B890B
		// (set) Token: 0x0600824D RID: 33357 RVA: 0x000BA71B File Offset: 0x000B891B
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

		// Token: 0x17001EAA RID: 7850
		// (get) Token: 0x0600824E RID: 33358 RVA: 0x000BA72C File Offset: 0x000B892C
		// (set) Token: 0x0600824F RID: 33359 RVA: 0x000BA73C File Offset: 0x000B893C
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

		// Token: 0x17001EAB RID: 7851
		// (get) Token: 0x06008250 RID: 33360 RVA: 0x000BA74D File Offset: 0x000B894D
		// (set) Token: 0x06008251 RID: 33361 RVA: 0x000BA75D File Offset: 0x000B895D
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

		// Token: 0x17001EAC RID: 7852
		// (get) Token: 0x06008252 RID: 33362 RVA: 0x000BA76E File Offset: 0x000B896E
		// (set) Token: 0x06008253 RID: 33363 RVA: 0x000BA77E File Offset: 0x000B897E
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

		// Token: 0x17001EAD RID: 7853
		// (get) Token: 0x06008254 RID: 33364 RVA: 0x000BA78F File Offset: 0x000B898F
		// (set) Token: 0x06008255 RID: 33365 RVA: 0x000BA79F File Offset: 0x000B899F
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

		// Token: 0x17001EAE RID: 7854
		// (get) Token: 0x06008256 RID: 33366 RVA: 0x000BA7B0 File Offset: 0x000B89B0
		// (set) Token: 0x06008257 RID: 33367 RVA: 0x000BA7C0 File Offset: 0x000B89C0
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

		// Token: 0x17001EAF RID: 7855
		// (get) Token: 0x06008258 RID: 33368 RVA: 0x000BA7D1 File Offset: 0x000B89D1
		// (set) Token: 0x06008259 RID: 33369 RVA: 0x000BA7E1 File Offset: 0x000B89E1
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

		// Token: 0x17001EB0 RID: 7856
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x000BA7F2 File Offset: 0x000B89F2
		// (set) Token: 0x0600825B RID: 33371 RVA: 0x000BA802 File Offset: 0x000B8A02
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

		// Token: 0x17001EB1 RID: 7857
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x000BA813 File Offset: 0x000B8A13
		// (set) Token: 0x0600825D RID: 33373 RVA: 0x000BA823 File Offset: 0x000B8A23
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

		// Token: 0x17001EB2 RID: 7858
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x000BA834 File Offset: 0x000B8A34
		// (set) Token: 0x0600825F RID: 33375 RVA: 0x000BA844 File Offset: 0x000B8A44
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

		// Token: 0x17001EB3 RID: 7859
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x000BA855 File Offset: 0x000B8A55
		// (set) Token: 0x06008261 RID: 33377 RVA: 0x000BA865 File Offset: 0x000B8A65
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

		// Token: 0x17001EB4 RID: 7860
		// (get) Token: 0x06008262 RID: 33378 RVA: 0x000BA876 File Offset: 0x000B8A76
		// (set) Token: 0x06008263 RID: 33379 RVA: 0x000BA886 File Offset: 0x000B8A86
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

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06008264 RID: 33380 RVA: 0x000BA897 File Offset: 0x000B8A97
		// (set) Token: 0x06008265 RID: 33381 RVA: 0x000BA8A7 File Offset: 0x000B8AA7
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06008266 RID: 33382 RVA: 0x000BA8B8 File Offset: 0x000B8AB8
		// (set) Token: 0x06008267 RID: 33383 RVA: 0x000BA8C8 File Offset: 0x000B8AC8
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06008268 RID: 33384 RVA: 0x000BA8D9 File Offset: 0x000B8AD9
		// (set) Token: 0x06008269 RID: 33385 RVA: 0x000BA8E9 File Offset: 0x000B8AE9
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

		// Token: 0x17001EB8 RID: 7864
		// (get) Token: 0x0600826A RID: 33386 RVA: 0x000BA8FA File Offset: 0x000B8AFA
		// (set) Token: 0x0600826B RID: 33387 RVA: 0x000BA90A File Offset: 0x000B8B0A
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

		// Token: 0x17001EB9 RID: 7865
		// (get) Token: 0x0600826C RID: 33388 RVA: 0x000BA91B File Offset: 0x000B8B1B
		// (set) Token: 0x0600826D RID: 33389 RVA: 0x000BA92F File Offset: 0x000B8B2F
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

		// Token: 0x17001EBA RID: 7866
		// (get) Token: 0x0600826E RID: 33390 RVA: 0x000BA944 File Offset: 0x000B8B44
		// (set) Token: 0x0600826F RID: 33391 RVA: 0x000BA95D File Offset: 0x000B8B5D
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

		// Token: 0x17001EBB RID: 7867
		// (get) Token: 0x06008270 RID: 33392 RVA: 0x000BA98D File Offset: 0x000B8B8D
		// (set) Token: 0x06008271 RID: 33393 RVA: 0x000BA9A6 File Offset: 0x000B8BA6
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

		// Token: 0x17001EBC RID: 7868
		// (get) Token: 0x06008272 RID: 33394 RVA: 0x000BA9D6 File Offset: 0x000B8BD6
		// (set) Token: 0x06008273 RID: 33395 RVA: 0x000BA9EF File Offset: 0x000B8BEF
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

		// Token: 0x17001EBD RID: 7869
		// (get) Token: 0x06008274 RID: 33396 RVA: 0x000BAA1F File Offset: 0x000B8C1F
		// (set) Token: 0x06008275 RID: 33397 RVA: 0x000BAA38 File Offset: 0x000B8C38
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

		// Token: 0x17001EBE RID: 7870
		// (get) Token: 0x06008276 RID: 33398 RVA: 0x000BAA68 File Offset: 0x000B8C68
		// (set) Token: 0x06008277 RID: 33399 RVA: 0x000BAA81 File Offset: 0x000B8C81
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

		// Token: 0x17001EBF RID: 7871
		// (get) Token: 0x06008278 RID: 33400 RVA: 0x000BAAB1 File Offset: 0x000B8CB1
		// (set) Token: 0x06008279 RID: 33401 RVA: 0x000BAACA File Offset: 0x000B8CCA
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

		// Token: 0x17001EC0 RID: 7872
		// (get) Token: 0x0600827A RID: 33402 RVA: 0x000BAAFA File Offset: 0x000B8CFA
		// (set) Token: 0x0600827B RID: 33403 RVA: 0x000BAB0A File Offset: 0x000B8D0A
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

		// Token: 0x17001EC1 RID: 7873
		// (get) Token: 0x0600827C RID: 33404 RVA: 0x000BAB1B File Offset: 0x000B8D1B
		// (set) Token: 0x0600827D RID: 33405 RVA: 0x000BAB2B File Offset: 0x000B8D2B
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

		// Token: 0x17001EC2 RID: 7874
		// (get) Token: 0x0600827E RID: 33406 RVA: 0x000BAB3C File Offset: 0x000B8D3C
		// (set) Token: 0x0600827F RID: 33407 RVA: 0x000BAB4C File Offset: 0x000B8D4C
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

		// Token: 0x17001EC3 RID: 7875
		// (get) Token: 0x06008280 RID: 33408 RVA: 0x000BAB5D File Offset: 0x000B8D5D
		// (set) Token: 0x06008281 RID: 33409 RVA: 0x000BAB6D File Offset: 0x000B8D6D
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

		// Token: 0x17001EC4 RID: 7876
		// (get) Token: 0x06008282 RID: 33410 RVA: 0x000BAB7E File Offset: 0x000B8D7E
		// (set) Token: 0x06008283 RID: 33411 RVA: 0x000BAB8E File Offset: 0x000B8D8E
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

		// Token: 0x17001EC5 RID: 7877
		// (get) Token: 0x06008284 RID: 33412 RVA: 0x000BAB9F File Offset: 0x000B8D9F
		// (set) Token: 0x06008285 RID: 33413 RVA: 0x000BABAF File Offset: 0x000B8DAF
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

		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x06008286 RID: 33414 RVA: 0x000BABC0 File Offset: 0x000B8DC0
		// (set) Token: 0x06008287 RID: 33415 RVA: 0x000BABD0 File Offset: 0x000B8DD0
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

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06008288 RID: 33416 RVA: 0x000BABE1 File Offset: 0x000B8DE1
		// (set) Token: 0x06008289 RID: 33417 RVA: 0x000BABF1 File Offset: 0x000B8DF1
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

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x0600828A RID: 33418 RVA: 0x000BAC02 File Offset: 0x000B8E02
		// (set) Token: 0x0600828B RID: 33419 RVA: 0x000BAC12 File Offset: 0x000B8E12
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

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x0600828C RID: 33420 RVA: 0x000BAC23 File Offset: 0x000B8E23
		// (set) Token: 0x0600828D RID: 33421 RVA: 0x000BAC37 File Offset: 0x000B8E37
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

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600828E RID: 33422 RVA: 0x000BAC4C File Offset: 0x000B8E4C
		// (set) Token: 0x0600828F RID: 33423 RVA: 0x000BAC60 File Offset: 0x000B8E60
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UTerrainSurveyCreateBase> TerrainSurveyCreateClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_TerrainSurveyCreateClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_TerrainSurveyCreateClass) = value;
			}
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x06008290 RID: 33424 RVA: 0x000BAC75 File Offset: 0x000B8E75
		// (set) Token: 0x06008291 RID: 33425 RVA: 0x000BAC8E File Offset: 0x000B8E8E
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

		// Token: 0x17001ECC RID: 7884
		// (get) Token: 0x06008292 RID: 33426 RVA: 0x000BACBE File Offset: 0x000B8EBE
		// (set) Token: 0x06008293 RID: 33427 RVA: 0x000BACD7 File Offset: 0x000B8ED7
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

		// Token: 0x17001ECD RID: 7885
		// (get) Token: 0x06008294 RID: 33428 RVA: 0x000BAD07 File Offset: 0x000B8F07
		// (set) Token: 0x06008295 RID: 33429 RVA: 0x000BAD20 File Offset: 0x000B8F20
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

		// Token: 0x17001ECE RID: 7886
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x000BAD50 File Offset: 0x000B8F50
		// (set) Token: 0x06008297 RID: 33431 RVA: 0x000BAD69 File Offset: 0x000B8F69
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

		// Token: 0x17001ECF RID: 7887
		// (get) Token: 0x06008298 RID: 33432 RVA: 0x000BAD99 File Offset: 0x000B8F99
		// (set) Token: 0x06008299 RID: 33433 RVA: 0x000BADB2 File Offset: 0x000B8FB2
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

		// Token: 0x17001ED0 RID: 7888
		// (get) Token: 0x0600829A RID: 33434 RVA: 0x000BADE2 File Offset: 0x000B8FE2
		// (set) Token: 0x0600829B RID: 33435 RVA: 0x000BADFB File Offset: 0x000B8FFB
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

		// Token: 0x17001ED1 RID: 7889
		// (get) Token: 0x0600829C RID: 33436 RVA: 0x000BAE2B File Offset: 0x000B902B
		// (set) Token: 0x0600829D RID: 33437 RVA: 0x000BAE44 File Offset: 0x000B9044
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

		// Token: 0x17001ED2 RID: 7890
		// (get) Token: 0x0600829E RID: 33438 RVA: 0x000BAE74 File Offset: 0x000B9074
		// (set) Token: 0x0600829F RID: 33439 RVA: 0x000BAE8D File Offset: 0x000B908D
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

		// Token: 0x17001ED3 RID: 7891
		// (get) Token: 0x060082A0 RID: 33440 RVA: 0x000BAEBD File Offset: 0x000B90BD
		// (set) Token: 0x060082A1 RID: 33441 RVA: 0x000BAED6 File Offset: 0x000B90D6
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

		// Token: 0x17001ED4 RID: 7892
		// (get) Token: 0x060082A2 RID: 33442 RVA: 0x000BAF06 File Offset: 0x000B9106
		// (set) Token: 0x060082A3 RID: 33443 RVA: 0x000BAF1F File Offset: 0x000B911F
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

		// Token: 0x17001ED5 RID: 7893
		// (get) Token: 0x060082A4 RID: 33444 RVA: 0x000BAF4F File Offset: 0x000B914F
		// (set) Token: 0x060082A5 RID: 33445 RVA: 0x000BAF68 File Offset: 0x000B9168
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

		// Token: 0x17001ED6 RID: 7894
		// (get) Token: 0x060082A6 RID: 33446 RVA: 0x000BAF98 File Offset: 0x000B9198
		// (set) Token: 0x060082A7 RID: 33447 RVA: 0x000BAFB1 File Offset: 0x000B91B1
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

		// Token: 0x17001ED7 RID: 7895
		// (get) Token: 0x060082A8 RID: 33448 RVA: 0x000BAFE1 File Offset: 0x000B91E1
		// (set) Token: 0x060082A9 RID: 33449 RVA: 0x000BAFFA File Offset: 0x000B91FA
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

		// Token: 0x17001ED8 RID: 7896
		// (get) Token: 0x060082AA RID: 33450 RVA: 0x000BB02A File Offset: 0x000B922A
		// (set) Token: 0x060082AB RID: 33451 RVA: 0x000BB043 File Offset: 0x000B9243
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

		// Token: 0x17001ED9 RID: 7897
		// (get) Token: 0x060082AC RID: 33452 RVA: 0x000BB073 File Offset: 0x000B9273
		// (set) Token: 0x060082AD RID: 33453 RVA: 0x000BB08C File Offset: 0x000B928C
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

		// Token: 0x17001EDA RID: 7898
		// (get) Token: 0x060082AE RID: 33454 RVA: 0x000BB0BC File Offset: 0x000B92BC
		// (set) Token: 0x060082AF RID: 33455 RVA: 0x000BB0D5 File Offset: 0x000B92D5
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

		// Token: 0x17001EDB RID: 7899
		// (get) Token: 0x060082B0 RID: 33456 RVA: 0x000BB105 File Offset: 0x000B9305
		// (set) Token: 0x060082B1 RID: 33457 RVA: 0x000BB11E File Offset: 0x000B931E
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

		// Token: 0x17001EDC RID: 7900
		// (get) Token: 0x060082B2 RID: 33458 RVA: 0x000BB14E File Offset: 0x000B934E
		// (set) Token: 0x060082B3 RID: 33459 RVA: 0x000BB167 File Offset: 0x000B9367
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

		// Token: 0x17001EDD RID: 7901
		// (get) Token: 0x060082B4 RID: 33460 RVA: 0x000BB197 File Offset: 0x000B9397
		// (set) Token: 0x060082B5 RID: 33461 RVA: 0x000BB1B0 File Offset: 0x000B93B0
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

		// Token: 0x17001EDE RID: 7902
		// (get) Token: 0x060082B6 RID: 33462 RVA: 0x000BB1E0 File Offset: 0x000B93E0
		// (set) Token: 0x060082B7 RID: 33463 RVA: 0x000BB1F9 File Offset: 0x000B93F9
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

		// Token: 0x17001EDF RID: 7903
		// (get) Token: 0x060082B8 RID: 33464 RVA: 0x000BB229 File Offset: 0x000B9429
		// (set) Token: 0x060082B9 RID: 33465 RVA: 0x000BB242 File Offset: 0x000B9442
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

		// Token: 0x17001EE0 RID: 7904
		// (get) Token: 0x060082BA RID: 33466 RVA: 0x000BB272 File Offset: 0x000B9472
		// (set) Token: 0x060082BB RID: 33467 RVA: 0x000BB286 File Offset: 0x000B9486
		[Nullable(2)]
		public unsafe USceneComponent DeferredUpdatedMoveComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCharacterMovementComponent.__PropertyOffset_DeferredUpdatedMoveComponent, value);
			}
		}

		// Token: 0x17001EE1 RID: 7905
		// (get) Token: 0x060082BC RID: 33468 RVA: 0x000BB29B File Offset: 0x000B949B
		// (set) Token: 0x060082BD RID: 33469 RVA: 0x000BB2AB File Offset: 0x000B94AB
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

		// Token: 0x17001EE2 RID: 7906
		// (get) Token: 0x060082BE RID: 33470 RVA: 0x000BB2BC File Offset: 0x000B94BC
		// (set) Token: 0x060082BF RID: 33471 RVA: 0x000BB2CC File Offset: 0x000B94CC
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

		// Token: 0x17001EE3 RID: 7907
		// (get) Token: 0x060082C0 RID: 33472 RVA: 0x000BB2DD File Offset: 0x000B94DD
		// (set) Token: 0x060082C1 RID: 33473 RVA: 0x000BB2ED File Offset: 0x000B94ED
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

		// Token: 0x17001EE4 RID: 7908
		// (get) Token: 0x060082C2 RID: 33474 RVA: 0x000BB2FE File Offset: 0x000B94FE
		// (set) Token: 0x060082C3 RID: 33475 RVA: 0x000BB30E File Offset: 0x000B950E
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

		// Token: 0x17001EE5 RID: 7909
		// (get) Token: 0x060082C4 RID: 33476 RVA: 0x000BB31F File Offset: 0x000B951F
		// (set) Token: 0x060082C5 RID: 33477 RVA: 0x000BB32F File Offset: 0x000B952F
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

		// Token: 0x17001EE6 RID: 7910
		// (get) Token: 0x060082C6 RID: 33478 RVA: 0x000BB340 File Offset: 0x000B9540
		// (set) Token: 0x060082C7 RID: 33479 RVA: 0x000BB350 File Offset: 0x000B9550
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

		// Token: 0x17001EE7 RID: 7911
		// (get) Token: 0x060082C8 RID: 33480 RVA: 0x000BB361 File Offset: 0x000B9561
		// (set) Token: 0x060082C9 RID: 33481 RVA: 0x000BB371 File Offset: 0x000B9571
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

		// Token: 0x17001EE8 RID: 7912
		// (get) Token: 0x060082CA RID: 33482 RVA: 0x000BB382 File Offset: 0x000B9582
		// (set) Token: 0x060082CB RID: 33483 RVA: 0x000BB392 File Offset: 0x000B9592
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

		// Token: 0x17001EE9 RID: 7913
		// (get) Token: 0x060082CC RID: 33484 RVA: 0x000BB3A3 File Offset: 0x000B95A3
		// (set) Token: 0x060082CD RID: 33485 RVA: 0x000BB3B3 File Offset: 0x000B95B3
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

		// Token: 0x17001EEA RID: 7914
		// (get) Token: 0x060082CE RID: 33486 RVA: 0x000BB3C4 File Offset: 0x000B95C4
		// (set) Token: 0x060082CF RID: 33487 RVA: 0x000BB3D4 File Offset: 0x000B95D4
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

		// Token: 0x17001EEB RID: 7915
		// (get) Token: 0x060082D0 RID: 33488 RVA: 0x000BB3E5 File Offset: 0x000B95E5
		// (set) Token: 0x060082D1 RID: 33489 RVA: 0x000BB3F5 File Offset: 0x000B95F5
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

		// Token: 0x17001EEC RID: 7916
		// (get) Token: 0x060082D2 RID: 33490 RVA: 0x000BB406 File Offset: 0x000B9606
		// (set) Token: 0x060082D3 RID: 33491 RVA: 0x000BB416 File Offset: 0x000B9616
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

		// Token: 0x17001EED RID: 7917
		// (get) Token: 0x060082D4 RID: 33492 RVA: 0x000BB427 File Offset: 0x000B9627
		// (set) Token: 0x060082D5 RID: 33493 RVA: 0x000BB437 File Offset: 0x000B9637
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

		// Token: 0x17001EEE RID: 7918
		// (get) Token: 0x060082D6 RID: 33494 RVA: 0x000BB448 File Offset: 0x000B9648
		// (set) Token: 0x060082D7 RID: 33495 RVA: 0x000BB458 File Offset: 0x000B9658
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

		// Token: 0x17001EEF RID: 7919
		// (get) Token: 0x060082D8 RID: 33496 RVA: 0x000BB469 File Offset: 0x000B9669
		// (set) Token: 0x060082D9 RID: 33497 RVA: 0x000BB479 File Offset: 0x000B9679
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

		// Token: 0x17001EF0 RID: 7920
		// (get) Token: 0x060082DA RID: 33498 RVA: 0x000BB48A File Offset: 0x000B968A
		// (set) Token: 0x060082DB RID: 33499 RVA: 0x000BB49E File Offset: 0x000B969E
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

		// Token: 0x17001EF1 RID: 7921
		// (get) Token: 0x060082DC RID: 33500 RVA: 0x000BB4B3 File Offset: 0x000B96B3
		// (set) Token: 0x060082DD RID: 33501 RVA: 0x000BB4C7 File Offset: 0x000B96C7
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

		// Token: 0x17001EF2 RID: 7922
		// (get) Token: 0x060082DE RID: 33502 RVA: 0x000BB4DC File Offset: 0x000B96DC
		// (set) Token: 0x060082DF RID: 33503 RVA: 0x000BB4F0 File Offset: 0x000B96F0
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

		// Token: 0x17001EF3 RID: 7923
		// (get) Token: 0x060082E0 RID: 33504 RVA: 0x000BB505 File Offset: 0x000B9705
		// (set) Token: 0x060082E1 RID: 33505 RVA: 0x000BB519 File Offset: 0x000B9719
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

		// Token: 0x17001EF4 RID: 7924
		// (get) Token: 0x060082E2 RID: 33506 RVA: 0x000BB52E File Offset: 0x000B972E
		// (set) Token: 0x060082E3 RID: 33507 RVA: 0x000BB53E File Offset: 0x000B973E
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

		// Token: 0x17001EF5 RID: 7925
		// (get) Token: 0x060082E4 RID: 33508 RVA: 0x000BB54F File Offset: 0x000B974F
		// (set) Token: 0x060082E5 RID: 33509 RVA: 0x000BB55F File Offset: 0x000B975F
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

		// Token: 0x17001EF6 RID: 7926
		// (get) Token: 0x060082E6 RID: 33510 RVA: 0x000BB570 File Offset: 0x000B9770
		// (set) Token: 0x060082E7 RID: 33511 RVA: 0x000BB580 File Offset: 0x000B9780
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

		// Token: 0x17001EF7 RID: 7927
		// (get) Token: 0x060082E8 RID: 33512 RVA: 0x000BB591 File Offset: 0x000B9791
		// (set) Token: 0x060082E9 RID: 33513 RVA: 0x000BB5A5 File Offset: 0x000B97A5
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

		// Token: 0x17001EF8 RID: 7928
		// (get) Token: 0x060082EA RID: 33514 RVA: 0x000BB5BA File Offset: 0x000B97BA
		// (set) Token: 0x060082EB RID: 33515 RVA: 0x000BB5CE File Offset: 0x000B97CE
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

		// Token: 0x17001EF9 RID: 7929
		// (get) Token: 0x060082EC RID: 33516 RVA: 0x000BB5E3 File Offset: 0x000B97E3
		// (set) Token: 0x060082ED RID: 33517 RVA: 0x000BB5F3 File Offset: 0x000B97F3
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

		// Token: 0x17001EFA RID: 7930
		// (get) Token: 0x060082EE RID: 33518 RVA: 0x000BB604 File Offset: 0x000B9804
		// (set) Token: 0x060082EF RID: 33519 RVA: 0x000BB618 File Offset: 0x000B9818
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

		// Token: 0x17001EFB RID: 7931
		// (get) Token: 0x060082F0 RID: 33520 RVA: 0x000BB62D File Offset: 0x000B982D
		// (set) Token: 0x060082F1 RID: 33521 RVA: 0x000BB641 File Offset: 0x000B9841
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

		// Token: 0x17001EFC RID: 7932
		// (get) Token: 0x060082F2 RID: 33522 RVA: 0x000BB656 File Offset: 0x000B9856
		// (set) Token: 0x060082F3 RID: 33523 RVA: 0x000BB666 File Offset: 0x000B9866
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

		// Token: 0x17001EFD RID: 7933
		// (get) Token: 0x060082F4 RID: 33524 RVA: 0x000BB677 File Offset: 0x000B9877
		// (set) Token: 0x060082F5 RID: 33525 RVA: 0x000BB687 File Offset: 0x000B9887
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

		// Token: 0x17001EFE RID: 7934
		// (get) Token: 0x060082F6 RID: 33526 RVA: 0x000BB698 File Offset: 0x000B9898
		// (set) Token: 0x060082F7 RID: 33527 RVA: 0x000BB6A8 File Offset: 0x000B98A8
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

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x060082F8 RID: 33528 RVA: 0x000BB6B9 File Offset: 0x000B98B9
		// (set) Token: 0x060082F9 RID: 33529 RVA: 0x000BB6C9 File Offset: 0x000B98C9
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

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x060082FA RID: 33530 RVA: 0x000BB6DA File Offset: 0x000B98DA
		// (set) Token: 0x060082FB RID: 33531 RVA: 0x000BB6EA File Offset: 0x000B98EA
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

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x060082FC RID: 33532 RVA: 0x000BB6FB File Offset: 0x000B98FB
		// (set) Token: 0x060082FD RID: 33533 RVA: 0x000BB70B File Offset: 0x000B990B
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

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x060082FE RID: 33534 RVA: 0x000BB71C File Offset: 0x000B991C
		// (set) Token: 0x060082FF RID: 33535 RVA: 0x000BB72C File Offset: 0x000B992C
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

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x06008300 RID: 33536 RVA: 0x000BB73D File Offset: 0x000B993D
		// (set) Token: 0x06008301 RID: 33537 RVA: 0x000BB74D File Offset: 0x000B994D
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

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x06008302 RID: 33538 RVA: 0x000BB75E File Offset: 0x000B995E
		// (set) Token: 0x06008303 RID: 33539 RVA: 0x000BB76E File Offset: 0x000B996E
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

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x06008304 RID: 33540 RVA: 0x000BB77F File Offset: 0x000B997F
		// (set) Token: 0x06008305 RID: 33541 RVA: 0x000BB78F File Offset: 0x000B998F
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

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x06008306 RID: 33542 RVA: 0x000BB7A0 File Offset: 0x000B99A0
		// (set) Token: 0x06008307 RID: 33543 RVA: 0x000BB7B0 File Offset: 0x000B99B0
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

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x06008308 RID: 33544 RVA: 0x000BB7C1 File Offset: 0x000B99C1
		// (set) Token: 0x06008309 RID: 33545 RVA: 0x000BB7D1 File Offset: 0x000B99D1
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

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600830A RID: 33546 RVA: 0x000BB7E2 File Offset: 0x000B99E2
		// (set) Token: 0x0600830B RID: 33547 RVA: 0x000BB7F2 File Offset: 0x000B99F2
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

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600830C RID: 33548 RVA: 0x000BB803 File Offset: 0x000B9A03
		// (set) Token: 0x0600830D RID: 33549 RVA: 0x000BB813 File Offset: 0x000B9A13
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

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600830E RID: 33550 RVA: 0x000BB824 File Offset: 0x000B9A24
		// (set) Token: 0x0600830F RID: 33551 RVA: 0x000BB834 File Offset: 0x000B9A34
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

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x06008310 RID: 33552 RVA: 0x000BB845 File Offset: 0x000B9A45
		// (set) Token: 0x06008311 RID: 33553 RVA: 0x000BB855 File Offset: 0x000B9A55
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

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x06008312 RID: 33554 RVA: 0x000BB866 File Offset: 0x000B9A66
		// (set) Token: 0x06008313 RID: 33555 RVA: 0x000BB876 File Offset: 0x000B9A76
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

		// Token: 0x17001F0D RID: 7949
		// (get) Token: 0x06008314 RID: 33556 RVA: 0x000BB887 File Offset: 0x000B9A87
		// (set) Token: 0x06008315 RID: 33557 RVA: 0x000BB897 File Offset: 0x000B9A97
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

		// Token: 0x17001F0E RID: 7950
		// (get) Token: 0x06008316 RID: 33558 RVA: 0x000BB8A8 File Offset: 0x000B9AA8
		// (set) Token: 0x06008317 RID: 33559 RVA: 0x000BB8B8 File Offset: 0x000B9AB8
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

		// Token: 0x17001F0F RID: 7951
		// (get) Token: 0x06008318 RID: 33560 RVA: 0x000BB8C9 File Offset: 0x000B9AC9
		// (set) Token: 0x06008319 RID: 33561 RVA: 0x000BB8D9 File Offset: 0x000B9AD9
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

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x0600831A RID: 33562 RVA: 0x000BB8EA File Offset: 0x000B9AEA
		// (set) Token: 0x0600831B RID: 33563 RVA: 0x000BB8FA File Offset: 0x000B9AFA
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

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x0600831C RID: 33564 RVA: 0x000BB90B File Offset: 0x000B9B0B
		// (set) Token: 0x0600831D RID: 33565 RVA: 0x000BB91B File Offset: 0x000B9B1B
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

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x0600831E RID: 33566 RVA: 0x000BB92C File Offset: 0x000B9B2C
		// (set) Token: 0x0600831F RID: 33567 RVA: 0x000BB93C File Offset: 0x000B9B3C
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

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06008320 RID: 33568 RVA: 0x000BB94D File Offset: 0x000B9B4D
		// (set) Token: 0x06008321 RID: 33569 RVA: 0x000BB95D File Offset: 0x000B9B5D
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

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06008322 RID: 33570 RVA: 0x000BB96E File Offset: 0x000B9B6E
		// (set) Token: 0x06008323 RID: 33571 RVA: 0x000BB97E File Offset: 0x000B9B7E
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

		// Token: 0x17001F15 RID: 7957
		// (get) Token: 0x06008324 RID: 33572 RVA: 0x000BB98F File Offset: 0x000B9B8F
		// (set) Token: 0x06008325 RID: 33573 RVA: 0x000BB99F File Offset: 0x000B9B9F
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

		// Token: 0x17001F16 RID: 7958
		// (get) Token: 0x06008326 RID: 33574 RVA: 0x000BB9B0 File Offset: 0x000B9BB0
		// (set) Token: 0x06008327 RID: 33575 RVA: 0x000BB9C0 File Offset: 0x000B9BC0
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

		// Token: 0x17001F17 RID: 7959
		// (get) Token: 0x06008328 RID: 33576 RVA: 0x000BB9D1 File Offset: 0x000B9BD1
		// (set) Token: 0x06008329 RID: 33577 RVA: 0x000BB9E1 File Offset: 0x000B9BE1
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

		// Token: 0x17001F18 RID: 7960
		// (get) Token: 0x0600832A RID: 33578 RVA: 0x000BB9F2 File Offset: 0x000B9BF2
		// (set) Token: 0x0600832B RID: 33579 RVA: 0x000BBA02 File Offset: 0x000B9C02
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

		// Token: 0x17001F19 RID: 7961
		// (get) Token: 0x0600832C RID: 33580 RVA: 0x000BBA13 File Offset: 0x000B9C13
		// (set) Token: 0x0600832D RID: 33581 RVA: 0x000BBA23 File Offset: 0x000B9C23
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

		// Token: 0x17001F1A RID: 7962
		// (get) Token: 0x0600832E RID: 33582 RVA: 0x000BBA34 File Offset: 0x000B9C34
		// (set) Token: 0x0600832F RID: 33583 RVA: 0x000BBA44 File Offset: 0x000B9C44
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

		// Token: 0x17001F1B RID: 7963
		// (get) Token: 0x06008330 RID: 33584 RVA: 0x000BBA58 File Offset: 0x000B9C58
		// (set) Token: 0x06008331 RID: 33585 RVA: 0x000BBA91 File Offset: 0x000B9C91
		public FFindFloorResult CurrentFloor
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFindFloorResult.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CurrentFloor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F1C RID: 7964
		// (get) Token: 0x06008332 RID: 33586 RVA: 0x000BBAB2 File Offset: 0x000B9CB2
		// (set) Token: 0x06008333 RID: 33587 RVA: 0x000BBAC6 File Offset: 0x000B9CC6
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

		// Token: 0x17001F1D RID: 7965
		// (get) Token: 0x06008334 RID: 33588 RVA: 0x000BBADB File Offset: 0x000B9CDB
		// (set) Token: 0x06008335 RID: 33589 RVA: 0x000BBAEF File Offset: 0x000B9CEF
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

		// Token: 0x17001F1E RID: 7966
		// (get) Token: 0x06008336 RID: 33590 RVA: 0x000BBB04 File Offset: 0x000B9D04
		// (set) Token: 0x06008337 RID: 33591 RVA: 0x000BBB14 File Offset: 0x000B9D14
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

		// Token: 0x17001F1F RID: 7967
		// (get) Token: 0x06008338 RID: 33592 RVA: 0x000BBB25 File Offset: 0x000B9D25
		// (set) Token: 0x06008339 RID: 33593 RVA: 0x000BBB39 File Offset: 0x000B9D39
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

		// Token: 0x17001F20 RID: 7968
		// (get) Token: 0x0600833A RID: 33594 RVA: 0x000BBB4E File Offset: 0x000B9D4E
		// (set) Token: 0x0600833B RID: 33595 RVA: 0x000BBB67 File Offset: 0x000B9D67
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

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x0600833C RID: 33596 RVA: 0x000BBB97 File Offset: 0x000B9D97
		// (set) Token: 0x0600833D RID: 33597 RVA: 0x000BBBB0 File Offset: 0x000B9DB0
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

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x0600833E RID: 33598 RVA: 0x000BBBE0 File Offset: 0x000B9DE0
		// (set) Token: 0x0600833F RID: 33599 RVA: 0x000BBBF9 File Offset: 0x000B9DF9
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

		// Token: 0x17001F23 RID: 7971
		// (get) Token: 0x06008340 RID: 33600 RVA: 0x000BBC29 File Offset: 0x000B9E29
		// (set) Token: 0x06008341 RID: 33601 RVA: 0x000BBC42 File Offset: 0x000B9E42
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

		// Token: 0x17001F24 RID: 7972
		// (get) Token: 0x06008342 RID: 33602 RVA: 0x000BBC72 File Offset: 0x000B9E72
		// (set) Token: 0x06008343 RID: 33603 RVA: 0x000BBC8B File Offset: 0x000B9E8B
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

		// Token: 0x17001F25 RID: 7973
		// (get) Token: 0x06008344 RID: 33604 RVA: 0x000BBCBB File Offset: 0x000B9EBB
		// (set) Token: 0x06008345 RID: 33605 RVA: 0x000BBCD4 File Offset: 0x000B9ED4
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

		// Token: 0x17001F26 RID: 7974
		// (get) Token: 0x06008346 RID: 33606 RVA: 0x000BBD04 File Offset: 0x000B9F04
		// (set) Token: 0x06008347 RID: 33607 RVA: 0x000BBD1D File Offset: 0x000B9F1D
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

		// Token: 0x17001F27 RID: 7975
		// (get) Token: 0x06008348 RID: 33608 RVA: 0x000BBD4D File Offset: 0x000B9F4D
		// (set) Token: 0x06008349 RID: 33609 RVA: 0x000BBD66 File Offset: 0x000B9F66
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

		// Token: 0x17001F28 RID: 7976
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x000BBD96 File Offset: 0x000B9F96
		// (set) Token: 0x0600834B RID: 33611 RVA: 0x000BBDAF File Offset: 0x000B9FAF
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

		// Token: 0x17001F29 RID: 7977
		// (get) Token: 0x0600834C RID: 33612 RVA: 0x000BBDDF File Offset: 0x000B9FDF
		// (set) Token: 0x0600834D RID: 33613 RVA: 0x000BBDF8 File Offset: 0x000B9FF8
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

		// Token: 0x17001F2A RID: 7978
		// (get) Token: 0x0600834E RID: 33614 RVA: 0x000BBE28 File Offset: 0x000BA028
		// (set) Token: 0x0600834F RID: 33615 RVA: 0x000BBE41 File Offset: 0x000BA041
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

		// Token: 0x17001F2B RID: 7979
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x000BBE71 File Offset: 0x000BA071
		// (set) Token: 0x06008351 RID: 33617 RVA: 0x000BBE8A File Offset: 0x000BA08A
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

		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x000BBEBA File Offset: 0x000BA0BA
		// (set) Token: 0x06008353 RID: 33619 RVA: 0x000BBED3 File Offset: 0x000BA0D3
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

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06008354 RID: 33620 RVA: 0x000BBF03 File Offset: 0x000BA103
		// (set) Token: 0x06008355 RID: 33621 RVA: 0x000BBF1C File Offset: 0x000BA11C
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

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06008356 RID: 33622 RVA: 0x000BBF4C File Offset: 0x000BA14C
		// (set) Token: 0x06008357 RID: 33623 RVA: 0x000BBF65 File Offset: 0x000BA165
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

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06008358 RID: 33624 RVA: 0x000BBF95 File Offset: 0x000BA195
		// (set) Token: 0x06008359 RID: 33625 RVA: 0x000BBFAE File Offset: 0x000BA1AE
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

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x000BBFDE File Offset: 0x000BA1DE
		// (set) Token: 0x0600835B RID: 33627 RVA: 0x000BBFF7 File Offset: 0x000BA1F7
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

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600835C RID: 33628 RVA: 0x000BC027 File Offset: 0x000BA227
		// (set) Token: 0x0600835D RID: 33629 RVA: 0x000BC040 File Offset: 0x000BA240
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

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600835E RID: 33630 RVA: 0x000BC070 File Offset: 0x000BA270
		// (set) Token: 0x0600835F RID: 33631 RVA: 0x000BC089 File Offset: 0x000BA289
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

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x06008360 RID: 33632 RVA: 0x000BC0B9 File Offset: 0x000BA2B9
		// (set) Token: 0x06008361 RID: 33633 RVA: 0x000BC0D2 File Offset: 0x000BA2D2
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

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06008362 RID: 33634 RVA: 0x000BC102 File Offset: 0x000BA302
		// (set) Token: 0x06008363 RID: 33635 RVA: 0x000BC11B File Offset: 0x000BA31B
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

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06008364 RID: 33636 RVA: 0x000BC14B File Offset: 0x000BA34B
		// (set) Token: 0x06008365 RID: 33637 RVA: 0x000BC164 File Offset: 0x000BA364
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

		// Token: 0x17001F36 RID: 7990
		// (get) Token: 0x06008366 RID: 33638 RVA: 0x000BC194 File Offset: 0x000BA394
		// (set) Token: 0x06008367 RID: 33639 RVA: 0x000BC1AD File Offset: 0x000BA3AD
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

		// Token: 0x17001F37 RID: 7991
		// (get) Token: 0x06008368 RID: 33640 RVA: 0x000BC1DD File Offset: 0x000BA3DD
		// (set) Token: 0x06008369 RID: 33641 RVA: 0x000BC1F6 File Offset: 0x000BA3F6
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

		// Token: 0x17001F38 RID: 7992
		// (get) Token: 0x0600836A RID: 33642 RVA: 0x000BC226 File Offset: 0x000BA426
		// (set) Token: 0x0600836B RID: 33643 RVA: 0x000BC23F File Offset: 0x000BA43F
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

		// Token: 0x17001F39 RID: 7993
		// (get) Token: 0x0600836C RID: 33644 RVA: 0x000BC26F File Offset: 0x000BA46F
		// (set) Token: 0x0600836D RID: 33645 RVA: 0x000BC288 File Offset: 0x000BA488
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

		// Token: 0x17001F3A RID: 7994
		// (get) Token: 0x0600836E RID: 33646 RVA: 0x000BC2B8 File Offset: 0x000BA4B8
		// (set) Token: 0x0600836F RID: 33647 RVA: 0x000BC2D1 File Offset: 0x000BA4D1
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

		// Token: 0x17001F3B RID: 7995
		// (get) Token: 0x06008370 RID: 33648 RVA: 0x000BC301 File Offset: 0x000BA501
		// (set) Token: 0x06008371 RID: 33649 RVA: 0x000BC31A File Offset: 0x000BA51A
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

		// Token: 0x17001F3C RID: 7996
		// (get) Token: 0x06008372 RID: 33650 RVA: 0x000BC34A File Offset: 0x000BA54A
		// (set) Token: 0x06008373 RID: 33651 RVA: 0x000BC363 File Offset: 0x000BA563
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

		// Token: 0x17001F3D RID: 7997
		// (get) Token: 0x06008374 RID: 33652 RVA: 0x000BC393 File Offset: 0x000BA593
		// (set) Token: 0x06008375 RID: 33653 RVA: 0x000BC3A3 File Offset: 0x000BA5A3
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

		// Token: 0x17001F3E RID: 7998
		// (get) Token: 0x06008376 RID: 33654 RVA: 0x000BC3B4 File Offset: 0x000BA5B4
		// (set) Token: 0x06008377 RID: 33655 RVA: 0x000BC3C8 File Offset: 0x000BA5C8
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

		// Token: 0x17001F3F RID: 7999
		// (get) Token: 0x06008378 RID: 33656 RVA: 0x000BC3DD File Offset: 0x000BA5DD
		// (set) Token: 0x06008379 RID: 33657 RVA: 0x000BC3ED File Offset: 0x000BA5ED
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

		// Token: 0x17001F40 RID: 8000
		// (get) Token: 0x0600837A RID: 33658 RVA: 0x000BC400 File Offset: 0x000BA600
		// (set) Token: 0x0600837B RID: 33659 RVA: 0x000BC439 File Offset: 0x000BA639
		public FNavAvoidanceMask AvoidanceGroup
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_AvoidanceGroup, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F41 RID: 8001
		// (get) Token: 0x0600837C RID: 33660 RVA: 0x000BC45C File Offset: 0x000BA65C
		// (set) Token: 0x0600837D RID: 33661 RVA: 0x000BC495 File Offset: 0x000BA695
		public FNavAvoidanceMask GroupsToAvoid
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToAvoid, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F42 RID: 8002
		// (get) Token: 0x0600837E RID: 33662 RVA: 0x000BC4B8 File Offset: 0x000BA6B8
		// (set) Token: 0x0600837F RID: 33663 RVA: 0x000BC4F1 File Offset: 0x000BA6F1
		public FNavAvoidanceMask GroupsToIgnore
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNavAvoidanceMask.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_GroupsToIgnore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F43 RID: 8003
		// (get) Token: 0x06008380 RID: 33664 RVA: 0x000BC512 File Offset: 0x000BA712
		// (set) Token: 0x06008381 RID: 33665 RVA: 0x000BC522 File Offset: 0x000BA722
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

		// Token: 0x17001F44 RID: 8004
		// (get) Token: 0x06008382 RID: 33666 RVA: 0x000BC533 File Offset: 0x000BA733
		// (set) Token: 0x06008383 RID: 33667 RVA: 0x000BC543 File Offset: 0x000BA743
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

		// Token: 0x17001F45 RID: 8005
		// (get) Token: 0x06008384 RID: 33668 RVA: 0x000BC554 File Offset: 0x000BA754
		// (set) Token: 0x06008385 RID: 33669 RVA: 0x000BC568 File Offset: 0x000BA768
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

		// Token: 0x17001F46 RID: 8006
		// (get) Token: 0x06008386 RID: 33670 RVA: 0x000BC57D File Offset: 0x000BA77D
		// (set) Token: 0x06008387 RID: 33671 RVA: 0x000BC58D File Offset: 0x000BA78D
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

		// Token: 0x17001F47 RID: 8007
		// (get) Token: 0x06008388 RID: 33672 RVA: 0x000BC59E File Offset: 0x000BA79E
		// (set) Token: 0x06008389 RID: 33673 RVA: 0x000BC5AE File Offset: 0x000BA7AE
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

		// Token: 0x17001F48 RID: 8008
		// (get) Token: 0x0600838A RID: 33674 RVA: 0x000BC5BF File Offset: 0x000BA7BF
		// (set) Token: 0x0600838B RID: 33675 RVA: 0x000BC5CF File Offset: 0x000BA7CF
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

		// Token: 0x17001F49 RID: 8009
		// (get) Token: 0x0600838C RID: 33676 RVA: 0x000BC5E0 File Offset: 0x000BA7E0
		// (set) Token: 0x0600838D RID: 33677 RVA: 0x000BC5F0 File Offset: 0x000BA7F0
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

		// Token: 0x17001F4A RID: 8010
		// (get) Token: 0x0600838E RID: 33678 RVA: 0x000BC601 File Offset: 0x000BA801
		// (set) Token: 0x0600838F RID: 33679 RVA: 0x000BC611 File Offset: 0x000BA811
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

		// Token: 0x17001F4B RID: 8011
		// (get) Token: 0x06008390 RID: 33680 RVA: 0x000BC622 File Offset: 0x000BA822
		// (set) Token: 0x06008391 RID: 33681 RVA: 0x000BC632 File Offset: 0x000BA832
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

		// Token: 0x17001F4C RID: 8012
		// (get) Token: 0x06008392 RID: 33682 RVA: 0x000BC644 File Offset: 0x000BA844
		// (set) Token: 0x06008393 RID: 33683 RVA: 0x000BC67D File Offset: 0x000BA87D
		public FCharacterMovementComponentPostPhysicsTickFunction PostPhysicsTickFunction
		{
			get
			{
				base.FastCheckIsValid();
				FCharacterMovementComponentPostPhysicsTickFunction result;
				if ((result = this._PostPhysicsTickFunction) == null)
				{
					result = (this._PostPhysicsTickFunction = new FCharacterMovementComponentPostPhysicsTickFunction(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PostPhysicsTickFunction, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCharacterMovementComponentPostPhysicsTickFunction.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_PostPhysicsTickFunction, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F4D RID: 8013
		// (get) Token: 0x06008394 RID: 33684 RVA: 0x000BC69E File Offset: 0x000BA89E
		// (set) Token: 0x06008395 RID: 33685 RVA: 0x000BC6AE File Offset: 0x000BA8AE
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

		// Token: 0x17001F4E RID: 8014
		// (get) Token: 0x06008396 RID: 33686 RVA: 0x000BC6C0 File Offset: 0x000BA8C0
		// (set) Token: 0x06008397 RID: 33687 RVA: 0x000BC6F9 File Offset: 0x000BA8F9
		public FRootMotionSourceGroup CurrentRootMotion
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceGroup result;
				if ((result = this._CurrentRootMotion) == null)
				{
					result = (this._CurrentRootMotion = new FRootMotionSourceGroup(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CurrentRootMotion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceGroup.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_CurrentRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F4F RID: 8015
		// (get) Token: 0x06008398 RID: 33688 RVA: 0x000BC71C File Offset: 0x000BA91C
		// (set) Token: 0x06008399 RID: 33689 RVA: 0x000BC755 File Offset: 0x000BA955
		public FRootMotionSourceGroup ServerCorrectionRootMotion
		{
			get
			{
				base.FastCheckIsValid();
				FRootMotionSourceGroup result;
				if ((result = this._ServerCorrectionRootMotion) == null)
				{
					result = (this._ServerCorrectionRootMotion = new FRootMotionSourceGroup(base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerCorrectionRootMotion, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionSourceGroup.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_ServerCorrectionRootMotion, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F50 RID: 8016
		// (get) Token: 0x0600839A RID: 33690 RVA: 0x000BC778 File Offset: 0x000BA978
		// (set) Token: 0x0600839B RID: 33691 RVA: 0x000BC7B1 File Offset: 0x000BA9B1
		public FRootMotionMovementParams RootMotionParams
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRootMotionMovementParams.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_RootMotionParams, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F51 RID: 8017
		// (get) Token: 0x0600839C RID: 33692 RVA: 0x000BC7D2 File Offset: 0x000BA9D2
		// (set) Token: 0x0600839D RID: 33693 RVA: 0x000BC7E6 File Offset: 0x000BA9E6
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

		// Token: 0x17001F52 RID: 8018
		// (get) Token: 0x0600839E RID: 33694 RVA: 0x000BC7FB File Offset: 0x000BA9FB
		// (set) Token: 0x0600839F RID: 33695 RVA: 0x000BC80F File Offset: 0x000BAA0F
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

		// Token: 0x17001F53 RID: 8019
		// (get) Token: 0x060083A0 RID: 33696 RVA: 0x000BC824 File Offset: 0x000BAA24
		// (set) Token: 0x060083A1 RID: 33697 RVA: 0x000BC834 File Offset: 0x000BAA34
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

		// Token: 0x17001F54 RID: 8020
		// (get) Token: 0x060083A2 RID: 33698 RVA: 0x000BC845 File Offset: 0x000BAA45
		// (set) Token: 0x060083A3 RID: 33699 RVA: 0x000BC85E File Offset: 0x000BAA5E
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

		// Token: 0x17001F55 RID: 8021
		// (get) Token: 0x060083A4 RID: 33700 RVA: 0x000BC890 File Offset: 0x000BAA90
		// (set) Token: 0x060083A5 RID: 33701 RVA: 0x000BC8C9 File Offset: 0x000BAAC9
		public FKuroMovementSetting KuroMovementSetting
		{
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
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroMovementSetting.StaticStruct(), base.NativePtr + (IntPtr)UCharacterMovementComponent.__PropertyOffset_KuroMovementSetting, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060083A6 RID: 33702 RVA: 0x000BC8EA File Offset: 0x000BAAEA
		public void SetWalkableFloorZ(float InWalkableFloorZ)
		{
			UCharacterMovementComponent.__SetWalkableFloorZ_Internal(base.NativePtr, InWalkableFloorZ);
		}

		// Token: 0x060083A7 RID: 33703 RVA: 0x000BC8F8 File Offset: 0x000BAAF8
		public void SetWalkableFloorAngle(float InWalkableFloorAngle)
		{
			UCharacterMovementComponent.__SetWalkableFloorAngle_Internal(base.NativePtr, InWalkableFloorAngle);
		}

		// Token: 0x060083A8 RID: 33704 RVA: 0x000BC906 File Offset: 0x000BAB06
		public void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode = 0)
		{
			UCharacterMovementComponent.__SetMovementMode_Internal(base.NativePtr, NewMovementMode, NewCustomMode);
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x000BC91A File Offset: 0x000BAB1A
		public void SetKuroPlanarPhysWalking(bool bEnable)
		{
			UCharacterMovementComponent.__SetKuroPlanarPhysWalking_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060083AA RID: 33706 RVA: 0x000BC928 File Offset: 0x000BAB28
		[NullableContext(2)]
		public void SetKuroMovementSettings(in FKuroMovementSetting InKuroMovementSetting)
		{
			UCharacterMovementComponent.__SetKuroMovementSettings_Internal(base.NativePtr, (InKuroMovementSetting ?? new FKuroMovementSetting()).NativePtr);
		}

		// Token: 0x060083AB RID: 33707 RVA: 0x000BC945 File Offset: 0x000BAB45
		public void SetKuroAsyncRootMotion(bool enable)
		{
			UCharacterMovementComponent.__SetKuroAsyncRootMotion_Internal(base.NativePtr, enable);
		}

		// Token: 0x060083AC RID: 33708 RVA: 0x000BC953 File Offset: 0x000BAB53
		[NullableContext(2)]
		public void SetGroupsToIgnoreMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetGroupsToIgnoreMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x060083AD RID: 33709 RVA: 0x000BC970 File Offset: 0x000BAB70
		public void SetGroupsToIgnore(int GroupFlags)
		{
			UCharacterMovementComponent.__SetGroupsToIgnore_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x000BC97E File Offset: 0x000BAB7E
		[NullableContext(2)]
		public void SetGroupsToAvoidMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetGroupsToAvoidMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x060083AF RID: 33711 RVA: 0x000BC99B File Offset: 0x000BAB9B
		public void SetGroupsToAvoid(int GroupFlags)
		{
			UCharacterMovementComponent.__SetGroupsToAvoid_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x000BC9A9 File Offset: 0x000BABA9
		public void SetDefaultMovementMode()
		{
			UCharacterMovementComponent.__SetDefaultMovementMode_Internal(base.NativePtr);
		}

		// Token: 0x060083B1 RID: 33713 RVA: 0x000BC9B6 File Offset: 0x000BABB6
		[NullableContext(2)]
		public void SetAvoidanceGroupMask(in FNavAvoidanceMask GroupMask)
		{
			UCharacterMovementComponent.__SetAvoidanceGroupMask_Internal(base.NativePtr, (GroupMask ?? new FNavAvoidanceMask()).NativePtr);
		}

		// Token: 0x060083B2 RID: 33714 RVA: 0x000BC9D3 File Offset: 0x000BABD3
		public void SetAvoidanceGroup(int GroupFlags)
		{
			UCharacterMovementComponent.__SetAvoidanceGroup_Internal(base.NativePtr, GroupFlags);
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x000BC9E1 File Offset: 0x000BABE1
		public void SetAvoidanceEnabled(bool bEnable)
		{
			UCharacterMovementComponent.__SetAvoidanceEnabled_Internal(base.NativePtr, bEnable);
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x000BC9F0 File Offset: 0x000BABF0
		public unsafe void SetAddRotation(FQuat InAddRotationOffset)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InAddRotationOffset;
			UCharacterMovementComponent.__SetAddRotation_Internal(base.NativePtr, ptr);
		}

		// Token: 0x060083B5 RID: 33717 RVA: 0x000BCA20 File Offset: 0x000BAC20
		public void SetAddMove(FVectorDouble InAddMoveOffset)
		{
			UCharacterMovementComponent.__SetAddMove_Internal(base.NativePtr, InAddMoveOffset);
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x000BCA2E File Offset: 0x000BAC2E
		public void MoveAdjust(in FVector Delta)
		{
			UCharacterMovementComponent.__MoveAdjust_Internal(base.NativePtr, Delta);
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x000BCA3C File Offset: 0x000BAC3C
		public void KuroSwimming(float DeltaTime, bool Sweep, float Depth, float KuroBuoyancy, float Friction, float MaxSpeed, float Slope, float Accelerator, float Deceleration)
		{
			UCharacterMovementComponent.__KuroSwimming_Internal(base.NativePtr, DeltaTime, Sweep, Depth, KuroBuoyancy, Friction, MaxSpeed, Slope, Accelerator, Deceleration);
		}

		// Token: 0x060083B8 RID: 33720 RVA: 0x000BCA64 File Offset: 0x000BAC64
		[NullableContext(2)]
		public bool KuroSlide(float DeltaTime, float AirFriction, float SlideFriction, FVector InputVelocity, float MaxSlideHorizontalSeed, FVector PrevBlockNormal, float MaxSlideVerticalSpeed = -1f, UCurveFloat SpeedReduceCurve = null)
		{
			return UCharacterMovementComponent.__KuroSlide_Internal(base.NativePtr, DeltaTime, AirFriction, SlideFriction, InputVelocity, MaxSlideHorizontalSeed, PrevBlockNormal, MaxSlideVerticalSpeed, (SpeedReduceCurve != null) ? SpeedReduceCurve.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060083B9 RID: 33721 RVA: 0x000BCA99 File Offset: 0x000BAC99
		public void KuroSetPredictionDataMaxMoveDeltaTime(float MaxMoveDeltaTime)
		{
			UCharacterMovementComponent.__KuroSetPredictionDataMaxMoveDeltaTime_Internal(base.NativePtr, MaxMoveDeltaTime);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x000BCAA7 File Offset: 0x000BACA7
		[NullableContext(2)]
		public UKuroCustomMovementExtension KuroRegisterCustomMovementExtension(byte InCustomMovementMode, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UKuroCustomMovementExtension> ExtensionClass, bool bOverrideExisting)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCustomMovementExtension>(UCharacterMovementComponent.__KuroRegisterCustomMovementExtension_Internal(base.NativePtr, InCustomMovementMode, ExtensionClass._NativePtr, bOverrideExisting));
		}

		// Token: 0x060083BB RID: 33723 RVA: 0x000BCAC4 File Offset: 0x000BACC4
		public void KuroPendulum(float AddVelocityX, float AddVelocityY, float AddVelocityZ, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed)
		{
			UCharacterMovementComponent.__KuroPendulum_Internal(base.NativePtr, AddVelocityX, AddVelocityY, AddVelocityZ, deltaTime, Gravity, Friction, deceleration, Accelerator, MaxSpeed, MaxFallingSpeed);
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x000BCAED File Offset: 0x000BACED
		public void KuroMoveAlongFloor(in FVector InVelocity, float DeltaSeconds)
		{
			UCharacterMovementComponent.__KuroMoveAlongFloor_Internal(base.NativePtr, InVelocity, DeltaSeconds);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x000BCAFC File Offset: 0x000BACFC
		[NullableContext(2)]
		public UKuroCustomMovementExtension KuroGetCustomMovementExtension(byte InCustomMovementMode)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCustomMovementExtension>(UCharacterMovementComponent.__KuroGetCustomMovementExtension_Internal(base.NativePtr, InCustomMovementMode));
		}

		// Token: 0x060083BE RID: 33726 RVA: 0x000BCB0F File Offset: 0x000BAD0F
		public void KuroFlying(float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed)
		{
			UCharacterMovementComponent.__KuroFlying_Internal(base.NativePtr, deltaTime, Gravity, Friction, deceleration, Accelerator, MaxSpeed, MaxFallingSpeed);
		}

		// Token: 0x060083BF RID: 33727 RVA: 0x000BCB28 File Offset: 0x000BAD28
		public unsafe bool KuroFindNavFloor(in FVector TestLocation, ref FVector NavFloorLocation)
		{
			fixed (FVector* ptr = &NavFloorLocation)
			{
				void* ptr2 = (void*)ptr;
				return UCharacterMovementComponent.__KuroFindNavFloor_Internal(base.NativePtr, TestLocation, ref NavFloorLocation);
			}
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x000BCB47 File Offset: 0x000BAD47
		public void Kuro_SetGravityDirect(FVector InGravityDirect)
		{
			UCharacterMovementComponent.__Kuro_SetGravityDirect_Internal(base.NativePtr, InGravityDirect);
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x000BCB55 File Offset: 0x000BAD55
		public int Kuro_GetKuroBlockHitIndexWhenMove()
		{
			return UCharacterMovementComponent.__Kuro_GetKuroBlockHitIndexWhenMove_Internal(base.NativePtr);
		}

		// Token: 0x060083C2 RID: 33730 RVA: 0x000BCB62 File Offset: 0x000BAD62
		public FVector Kuro_GetGravityDirect()
		{
			return UCharacterMovementComponent.__Kuro_GetGravityDirect_Internal(base.NativePtr);
		}

		// Token: 0x060083C3 RID: 33731 RVA: 0x000BCB6F File Offset: 0x000BAD6F
		public FRotator Kuro_GetGravityDeltaRot()
		{
			return UCharacterMovementComponent.__Kuro_GetGravityDeltaRot_Internal(base.NativePtr);
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x000BCB7C File Offset: 0x000BAD7C
		public FVector Kuro_GetGravity()
		{
			return UCharacterMovementComponent.__Kuro_GetGravity_Internal(base.NativePtr);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x000BCB89 File Offset: 0x000BAD89
		public FVector Kuro_GetBlockDirectWhenMove()
		{
			return UCharacterMovementComponent.__Kuro_GetBlockDirectWhenMove_Internal(base.NativePtr);
		}

		// Token: 0x060083C6 RID: 33734 RVA: 0x000BCB96 File Offset: 0x000BAD96
		[NullableContext(2)]
		public AActor Kuro_GetBlockActorWhenMove()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(UCharacterMovementComponent.__Kuro_GetBlockActorWhenMove_Internal(base.NativePtr));
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x000BCBA8 File Offset: 0x000BADA8
		public void K2_KuroEndScopedMovementUpdate()
		{
			UCharacterMovementComponent.__K2_KuroEndScopedMovementUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x000BCBB5 File Offset: 0x000BADB5
		public void K2_KuroBeginScopedMovementUpdate()
		{
			UCharacterMovementComponent.__K2_KuroBeginScopedMovementUpdate_Internal(base.NativePtr);
		}

		// Token: 0x060083C9 RID: 33737 RVA: 0x000BCBC2 File Offset: 0x000BADC2
		public float K2_GetWalkableFloorZ()
		{
			return UCharacterMovementComponent.__K2_GetWalkableFloorZ_Internal(base.NativePtr);
		}

		// Token: 0x060083CA RID: 33738 RVA: 0x000BCBCF File Offset: 0x000BADCF
		public float K2_GetWalkableFloorAngle()
		{
			return UCharacterMovementComponent.__K2_GetWalkableFloorAngle_Internal(base.NativePtr);
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x000BCBDC File Offset: 0x000BADDC
		public float K2_GetModifiedMaxAcceleration()
		{
			return UCharacterMovementComponent.__K2_GetModifiedMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x000BCBE9 File Offset: 0x000BADE9
		[NullableContext(2)]
		public void K2_FindFloor(FVector CapsuleLocation, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__K2_FindFloor_Internal(base.NativePtr, CapsuleLocation, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x060083CD RID: 33741 RVA: 0x000BCC07 File Offset: 0x000BAE07
		[NullableContext(2)]
		public void K2_ComputeFloorDist(FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__K2_ComputeFloorDist_Internal(base.NativePtr, CapsuleLocation, LineDistance, SweepDistance, SweepRadius, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x000BCC2A File Offset: 0x000BAE2A
		public bool IsWalking()
		{
			return UCharacterMovementComponent.__IsWalking_Internal(base.NativePtr);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x000BCC37 File Offset: 0x000BAE37
		[NullableContext(2)]
		public bool IsWalkable(in FHitResult Hit)
		{
			return UCharacterMovementComponent.__IsWalkable_Internal(base.NativePtr, (Hit ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060083D0 RID: 33744 RVA: 0x000BCC54 File Offset: 0x000BAE54
		public float GetValidPerchRadius()
		{
			return UCharacterMovementComponent.__GetValidPerchRadius_Internal(base.NativePtr);
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x000BCC61 File Offset: 0x000BAE61
		public float GetPerchRadiusThreshold()
		{
			return UCharacterMovementComponent.__GetPerchRadiusThreshold_Internal(base.NativePtr);
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x000BCC6E File Offset: 0x000BAE6E
		[NullableContext(2)]
		public UPrimitiveComponent GetMovementBase()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPrimitiveComponent>(UCharacterMovementComponent.__GetMovementBase_Internal(base.NativePtr));
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x000BCC80 File Offset: 0x000BAE80
		public float GetMinAnalogSpeed()
		{
			return UCharacterMovementComponent.__GetMinAnalogSpeed_Internal(base.NativePtr);
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x000BCC8D File Offset: 0x000BAE8D
		public float GetMaxJumpHeightWithJumpTime()
		{
			return UCharacterMovementComponent.__GetMaxJumpHeightWithJumpTime_Internal(base.NativePtr);
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x000BCC9A File Offset: 0x000BAE9A
		public float GetMaxJumpHeight()
		{
			return UCharacterMovementComponent.__GetMaxJumpHeight_Internal(base.NativePtr);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x000BCCA7 File Offset: 0x000BAEA7
		public float GetMaxBrakingDeceleration()
		{
			return UCharacterMovementComponent.__GetMaxBrakingDeceleration_Internal(base.NativePtr);
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x000BCCB4 File Offset: 0x000BAEB4
		public float GetMaxAcceleration()
		{
			return UCharacterMovementComponent.__GetMaxAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x000BCCC1 File Offset: 0x000BAEC1
		public FVector GetLastUpdateVelocity()
		{
			return UCharacterMovementComponent.__GetLastUpdateVelocity_Internal(base.NativePtr);
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x000BCCCE File Offset: 0x000BAECE
		public FRotator GetLastUpdateRotation()
		{
			return UCharacterMovementComponent.__GetLastUpdateRotation_Internal(base.NativePtr);
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x000BCCDB File Offset: 0x000BAEDB
		public FVector GetLastUpdateLocation()
		{
			return UCharacterMovementComponent.__GetLastUpdateLocation_Internal(base.NativePtr);
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x000BCCE8 File Offset: 0x000BAEE8
		public FVector GetImpartedMovementBaseVelocity()
		{
			return UCharacterMovementComponent.__GetImpartedMovementBaseVelocity_Internal(base.NativePtr);
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x000BCCF5 File Offset: 0x000BAEF5
		public FVector GetCurrentAcceleration()
		{
			return UCharacterMovementComponent.__GetCurrentAcceleration_Internal(base.NativePtr);
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x000BCD02 File Offset: 0x000BAF02
		[NullableContext(2)]
		public ACharacter GetCharacterOwner()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(UCharacterMovementComponent.__GetCharacterOwner_Internal(base.NativePtr));
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x000BCD14 File Offset: 0x000BAF14
		public float GetAnalogInputModifier()
		{
			return UCharacterMovementComponent.__GetAnalogInputModifier_Internal(base.NativePtr);
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x000BCD21 File Offset: 0x000BAF21
		public void DisableMovement()
		{
			UCharacterMovementComponent.__DisableMovement_Internal(base.NativePtr);
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x000BCD2E File Offset: 0x000BAF2E
		public void D_MoveAdjust(in FVectorDouble Delta)
		{
			UCharacterMovementComponent.__D_MoveAdjust_Internal(base.NativePtr, Delta);
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x000BCD3C File Offset: 0x000BAF3C
		[NullableContext(2)]
		public void D_K2_FindFloor(FVectorDouble CapsuleLocation, ref FFindFloorResult FloorResult)
		{
			UCharacterMovementComponent.__D_K2_FindFloor_Internal(base.NativePtr, CapsuleLocation, (FloorResult ?? new FFindFloorResult()).NativePtr);
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x000BCD5A File Offset: 0x000BAF5A
		public void ClearAccumulatedForces()
		{
			UCharacterMovementComponent.__ClearAccumulatedForces_Internal(base.NativePtr);
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x000BCD68 File Offset: 0x000BAF68
		[NullableContext(2)]
		public void CapsuleTouchedEvenBlock(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			UCharacterMovementComponent.__CapsuleTouchedEvenBlock_Internal(base.NativePtr, (OverlappedComp != null) ? OverlappedComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x000BCDC8 File Offset: 0x000BAFC8
		[NullableContext(2)]
		public void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, in FHitResult SweepResult)
		{
			UCharacterMovementComponent.__CapsuleTouched_Internal(base.NativePtr, (OverlappedComp != null) ? OverlappedComp.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero, (OtherComp != null) ? OtherComp.NativePtr : IntPtr.Zero, OtherBodyIndex, bFromSweep, (SweepResult ?? new FHitResult()).NativePtr);
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x000BCE25 File Offset: 0x000BB025
		public void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
		{
			UCharacterMovementComponent.__CalcVelocity_Internal(base.NativePtr, DeltaTime, Friction, bFluid, BrakingDeceleration);
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x000BCE38 File Offset: 0x000BB038
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

		// Token: 0x060083E7 RID: 33767 RVA: 0x000BCE86 File Offset: 0x000BB086
		public void AddImpulse(FVector Impulse, bool bVelocityChange = false)
		{
			UCharacterMovementComponent.__AddImpulse_Internal(base.NativePtr, Impulse, bVelocityChange);
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x000BCE95 File Offset: 0x000BB095
		public void AddForce(FVector Force)
		{
			UCharacterMovementComponent.__AddForce_Internal(base.NativePtr, Force);
		}

		// Token: 0x060083E9 RID: 33769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWalkableFloorZ_Internal(IntPtr @this, float InWalkableFloorZ);

		// Token: 0x060083EA RID: 33770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWalkableFloorAngle_Internal(IntPtr @this, float InWalkableFloorAngle);

		// Token: 0x060083EB RID: 33771
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMovementMode_Internal(IntPtr @this, TEnumAsByte<EMovementMode> NewMovementMode, byte NewCustomMode);

		// Token: 0x060083EC RID: 33772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroPlanarPhysWalking_Internal(IntPtr @this, bool bEnable);

		// Token: 0x060083ED RID: 33773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroMovementSettings_Internal(IntPtr @this, IntPtr InKuroMovementSetting);

		// Token: 0x060083EE RID: 33774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKuroAsyncRootMotion_Internal(IntPtr @this, bool enable);

		// Token: 0x060083EF RID: 33775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToIgnoreMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x060083F0 RID: 33776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToIgnore_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x060083F1 RID: 33777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToAvoidMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x060083F2 RID: 33778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroupsToAvoid_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x060083F3 RID: 33779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDefaultMovementMode_Internal(IntPtr @this);

		// Token: 0x060083F4 RID: 33780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceGroupMask_Internal(IntPtr @this, IntPtr GroupMask);

		// Token: 0x060083F5 RID: 33781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceGroup_Internal(IntPtr @this, int GroupFlags);

		// Token: 0x060083F6 RID: 33782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAvoidanceEnabled_Internal(IntPtr @this, bool bEnable);

		// Token: 0x060083F7 RID: 33783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAddRotation_Internal(IntPtr @this, in FQuat InAddRotationOffset);

		// Token: 0x060083F8 RID: 33784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAddMove_Internal(IntPtr @this, FVectorDouble InAddMoveOffset);

		// Token: 0x060083F9 RID: 33785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MoveAdjust_Internal(IntPtr @this, in FVector Delta);

		// Token: 0x060083FA RID: 33786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSwimming_Internal(IntPtr @this, float DeltaTime, bool Sweep, float Depth, float KuroBuoyancy, float Friction, float MaxSpeed, float Slope, float Accelerator, float Deceleration);

		// Token: 0x060083FB RID: 33787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroSlide_Internal(IntPtr @this, float DeltaTime, float AirFriction, float SlideFriction, FVector InputVelocity, float MaxSlideHorizontalSeed, FVector PrevBlockNormal, float MaxSlideVerticalSpeed, IntPtr SpeedReduceCurve);

		// Token: 0x060083FC RID: 33788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroSetPredictionDataMaxMoveDeltaTime_Internal(IntPtr @this, float MaxMoveDeltaTime);

		// Token: 0x060083FD RID: 33789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __KuroRegisterCustomMovementExtension_Internal(IntPtr @this, byte InCustomMovementMode, IntPtr ExtensionClass, bool bOverrideExisting);

		// Token: 0x060083FE RID: 33790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroPendulum_Internal(IntPtr @this, float AddVelocityX, float AddVelocityY, float AddVelocityZ, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed);

		// Token: 0x060083FF RID: 33791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroMoveAlongFloor_Internal(IntPtr @this, in FVector InVelocity, float DeltaSeconds);

		// Token: 0x06008400 RID: 33792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __KuroGetCustomMovementExtension_Internal(IntPtr @this, byte InCustomMovementMode);

		// Token: 0x06008401 RID: 33793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __KuroFlying_Internal(IntPtr @this, float deltaTime, float Gravity, float Friction, float deceleration, float Accelerator, float MaxSpeed, float MaxFallingSpeed);

		// Token: 0x06008402 RID: 33794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __KuroFindNavFloor_Internal(IntPtr @this, in FVector TestLocation, ref FVector NavFloorLocation);

		// Token: 0x06008403 RID: 33795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Kuro_SetGravityDirect_Internal(IntPtr @this, FVector InGravityDirect);

		// Token: 0x06008404 RID: 33796
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __Kuro_GetKuroBlockHitIndexWhenMove_Internal(IntPtr @this);

		// Token: 0x06008405 RID: 33797
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravityDirect_Internal(IntPtr @this);

		// Token: 0x06008406 RID: 33798
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Kuro_GetGravityDeltaRot_Internal(IntPtr @this);

		// Token: 0x06008407 RID: 33799
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetGravity_Internal(IntPtr @this);

		// Token: 0x06008408 RID: 33800
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Kuro_GetBlockDirectWhenMove_Internal(IntPtr @this);

		// Token: 0x06008409 RID: 33801
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Kuro_GetBlockActorWhenMove_Internal(IntPtr @this);

		// Token: 0x0600840A RID: 33802
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_KuroEndScopedMovementUpdate_Internal(IntPtr @this);

		// Token: 0x0600840B RID: 33803
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_KuroBeginScopedMovementUpdate_Internal(IntPtr @this);

		// Token: 0x0600840C RID: 33804
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetWalkableFloorZ_Internal(IntPtr @this);

		// Token: 0x0600840D RID: 33805
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetWalkableFloorAngle_Internal(IntPtr @this);

		// Token: 0x0600840E RID: 33806
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_GetModifiedMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x0600840F RID: 33807
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_FindFloor_Internal(IntPtr @this, FVector CapsuleLocation, IntPtr FloorResult);

		// Token: 0x06008410 RID: 33808
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __K2_ComputeFloorDist_Internal(IntPtr @this, FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, IntPtr FloorResult);

		// Token: 0x06008411 RID: 33809
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWalking_Internal(IntPtr @this);

		// Token: 0x06008412 RID: 33810
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWalkable_Internal(IntPtr @this, IntPtr Hit);

		// Token: 0x06008413 RID: 33811
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValidPerchRadius_Internal(IntPtr @this);

		// Token: 0x06008414 RID: 33812
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPerchRadiusThreshold_Internal(IntPtr @this);

		// Token: 0x06008415 RID: 33813
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMovementBase_Internal(IntPtr @this);

		// Token: 0x06008416 RID: 33814
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMinAnalogSpeed_Internal(IntPtr @this);

		// Token: 0x06008417 RID: 33815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxJumpHeightWithJumpTime_Internal(IntPtr @this);

		// Token: 0x06008418 RID: 33816
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxJumpHeight_Internal(IntPtr @this);

		// Token: 0x06008419 RID: 33817
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxBrakingDeceleration_Internal(IntPtr @this);

		// Token: 0x0600841A RID: 33818
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxAcceleration_Internal(IntPtr @this);

		// Token: 0x0600841B RID: 33819
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastUpdateVelocity_Internal(IntPtr @this);

		// Token: 0x0600841C RID: 33820
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetLastUpdateRotation_Internal(IntPtr @this);

		// Token: 0x0600841D RID: 33821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLastUpdateLocation_Internal(IntPtr @this);

		// Token: 0x0600841E RID: 33822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetImpartedMovementBaseVelocity_Internal(IntPtr @this);

		// Token: 0x0600841F RID: 33823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCurrentAcceleration_Internal(IntPtr @this);

		// Token: 0x06008420 RID: 33824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCharacterOwner_Internal(IntPtr @this);

		// Token: 0x06008421 RID: 33825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnalogInputModifier_Internal(IntPtr @this);

		// Token: 0x06008422 RID: 33826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DisableMovement_Internal(IntPtr @this);

		// Token: 0x06008423 RID: 33827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MoveAdjust_Internal(IntPtr @this, in FVectorDouble Delta);

		// Token: 0x06008424 RID: 33828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_K2_FindFloor_Internal(IntPtr @this, FVectorDouble CapsuleLocation, IntPtr FloorResult);

		// Token: 0x06008425 RID: 33829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAccumulatedForces_Internal(IntPtr @this);

		// Token: 0x06008426 RID: 33830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CapsuleTouchedEvenBlock_Internal(IntPtr @this, IntPtr OverlappedComp, IntPtr Other, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06008427 RID: 33831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CapsuleTouched_Internal(IntPtr @this, IntPtr OverlappedComp, IntPtr Other, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);

		// Token: 0x06008428 RID: 33832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalcVelocity_Internal(IntPtr @this, float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration);

		// Token: 0x06008429 RID: 33833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddReplayData_Internal(IntPtr @this, ref FVector RemoteLocation, ref FRotator RemoteRotation, ref FVector RemoteVelocity, ref FVector RemoteAcceleration, byte RemoteViewPitch, float Time);

		// Token: 0x0600842A RID: 33834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddImpulse_Internal(IntPtr @this, FVector Impulse, bool bVelocityChange);

		// Token: 0x0600842B RID: 33835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddForce_Internal(IntPtr @this, FVector Force);

		// Token: 0x0600842C RID: 33836 RVA: 0x000BCEA3 File Offset: 0x000BB0A3
		static UCharacterMovementComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.CharacterMovementComponent");
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x000BCEB1 File Offset: 0x000BB0B1
		protected UCharacterMovementComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E1D RID: 15901
		internal static int __InterfaceOffset_IRVOAvoidanceInterface;

		// Token: 0x04003E1E RID: 15902
		internal static int __InterfaceOffset_INetworkPredictionInterface;

		// Token: 0x04003E1F RID: 15903
		public new const string __ObjectPath = "/Script/Engine.CharacterMovementComponent";

		// Token: 0x04003E20 RID: 15904
		private static IntPtr _ClassPtr;

		// Token: 0x04003E21 RID: 15905
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E22 RID: 15906
		internal static int __PropertyOffset_CharacterOwner;

		// Token: 0x04003E23 RID: 15907
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04003E24 RID: 15908
		internal static int __PropertyOffset_MaxStepHeight;

		// Token: 0x04003E25 RID: 15909
		internal static int __PropertyOffset_JumpZVelocity;

		// Token: 0x04003E26 RID: 15910
		internal static int __PropertyOffset_JumpOffJumpZFactor;

		// Token: 0x04003E27 RID: 15911
		internal static int __PropertyOffset_WalkableFloorAngle;

		// Token: 0x04003E28 RID: 15912
		internal static int __PropertyOffset_WalkableFloorZ;

		// Token: 0x04003E29 RID: 15913
		internal static int __PropertyOffset_MovementMode;

		// Token: 0x04003E2A RID: 15914
		internal static int __PropertyOffset_CustomMovementMode;

		// Token: 0x04003E2B RID: 15915
		internal static int __PropertyOffset_KuroCustomMovementExtensionClasses;

		// Token: 0x04003E2C RID: 15916
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TMap<byte, TSubclassOf<UKuroCustomMovementExtension>> _KuroCustomMovementExtensionClasses;

		// Token: 0x04003E2D RID: 15917
		internal static int __PropertyOffset_KuroCustomMovementExtensionInstances;

		// Token: 0x04003E2E RID: 15918
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<byte, UKuroCustomMovementExtension> _KuroCustomMovementExtensionInstances;

		// Token: 0x04003E2F RID: 15919
		internal static int __PropertyOffset_NetworkSmoothingMode;

		// Token: 0x04003E30 RID: 15920
		internal static int __PropertyOffset_GroundFriction;

		// Token: 0x04003E31 RID: 15921
		internal static int __PropertyOffset_MaxWalkSpeed;

		// Token: 0x04003E32 RID: 15922
		internal static int __PropertyOffset_MaxWalkSpeedCrouched;

		// Token: 0x04003E33 RID: 15923
		internal static int __PropertyOffset_MaxSwimSpeed;

		// Token: 0x04003E34 RID: 15924
		internal static int __PropertyOffset_MaxFlySpeed;

		// Token: 0x04003E35 RID: 15925
		internal static int __PropertyOffset_MaxCustomMovementSpeed;

		// Token: 0x04003E36 RID: 15926
		internal static int __PropertyOffset_MaxAcceleration;

		// Token: 0x04003E37 RID: 15927
		internal static int __PropertyOffset_MinAnalogWalkSpeed;

		// Token: 0x04003E38 RID: 15928
		internal static int __PropertyOffset_BrakingFrictionFactor;

		// Token: 0x04003E39 RID: 15929
		internal static int __PropertyOffset_BrakingFriction;

		// Token: 0x04003E3A RID: 15930
		internal static int __PropertyOffset_BrakingSubStepTime;

		// Token: 0x04003E3B RID: 15931
		internal static int __PropertyOffset_BrakingDecelerationWalking;

		// Token: 0x04003E3C RID: 15932
		internal static int __PropertyOffset_BrakingDecelerationFalling;

		// Token: 0x04003E3D RID: 15933
		internal static int __PropertyOffset_BrakingDecelerationSwimming;

		// Token: 0x04003E3E RID: 15934
		internal static int __PropertyOffset_BrakingDecelerationFlying;

		// Token: 0x04003E3F RID: 15935
		internal static int __PropertyOffset_AirControl;

		// Token: 0x04003E40 RID: 15936
		internal static int __PropertyOffset_AirControlBoostMultiplier;

		// Token: 0x04003E41 RID: 15937
		internal static int __PropertyOffset_AirControlBoostVelocityThreshold;

		// Token: 0x04003E42 RID: 15938
		internal static int __PropertyOffset_FallingLateralFriction;

		// Token: 0x04003E43 RID: 15939
		internal static int __PropertyOffset_CrouchedHalfHeight;

		// Token: 0x04003E44 RID: 15940
		internal static int __PropertyOffset_Buoyancy;

		// Token: 0x04003E45 RID: 15941
		internal static int __PropertyOffset_PerchRadiusThreshold;

		// Token: 0x04003E46 RID: 15942
		internal static int __PropertyOffset_PerchAdditionalHeight;

		// Token: 0x04003E47 RID: 15943
		internal static int __PropertyOffset_RotationRate;

		// Token: 0x04003E48 RID: 15944
		internal static int __PropertyOffset_bUseSeparateBrakingFriction;

		// Token: 0x04003E49 RID: 15945
		internal static byte __PropertyMask_bUseSeparateBrakingFriction;

		// Token: 0x04003E4A RID: 15946
		internal static int __PropertyOffset_bApplyGravityWhileJumping;

		// Token: 0x04003E4B RID: 15947
		internal static byte __PropertyMask_bApplyGravityWhileJumping;

		// Token: 0x04003E4C RID: 15948
		internal static int __PropertyOffset_bUseControllerDesiredRotation;

		// Token: 0x04003E4D RID: 15949
		internal static byte __PropertyMask_bUseControllerDesiredRotation;

		// Token: 0x04003E4E RID: 15950
		internal static int __PropertyOffset_bOrientRotationToMovement;

		// Token: 0x04003E4F RID: 15951
		internal static byte __PropertyMask_bOrientRotationToMovement;

		// Token: 0x04003E50 RID: 15952
		internal static int __PropertyOffset_bRotationFollowBaseMovement;

		// Token: 0x04003E51 RID: 15953
		internal static byte __PropertyMask_bRotationFollowBaseMovement;

		// Token: 0x04003E52 RID: 15954
		internal static int __PropertyOffset_bSweepWhileNavWalking;

		// Token: 0x04003E53 RID: 15955
		internal static byte __PropertyMask_bSweepWhileNavWalking;

		// Token: 0x04003E54 RID: 15956
		internal static int __PropertyOffset_bKuroAutoActiveNav;

		// Token: 0x04003E55 RID: 15957
		internal static int __PropertyOffset_bKuroStillBlockInNav;

		// Token: 0x04003E56 RID: 15958
		internal static int __PropertyOffset_OverrideTerminalVelocity;

		// Token: 0x04003E57 RID: 15959
		internal static int __PropertyOffset_HitPriority;

		// Token: 0x04003E58 RID: 15960
		internal static int __PropertyOffset_GoThroughLower;

		// Token: 0x04003E59 RID: 15961
		internal static int __PropertyOffset_GoThroughPriority;

		// Token: 0x04003E5A RID: 15962
		internal static int __PropertyOffset_bKuroStopUpdateBasedMovement;

		// Token: 0x04003E5B RID: 15963
		internal static int __PropertyOffset_bForbiddenTickPose;

		// Token: 0x04003E5C RID: 15964
		internal static int __PropertyOffset_bKuroWalkOnAir;

		// Token: 0x04003E5D RID: 15965
		internal static int __PropertyOffset_ConveyDelta;

		// Token: 0x04003E5E RID: 15966
		internal static int __PropertyOffset_TerrainSurveyCreateClass;

		// Token: 0x04003E5F RID: 15967
		internal static int __PropertyOffset_bMovementInProgress;

		// Token: 0x04003E60 RID: 15968
		internal static byte __PropertyMask_bMovementInProgress;

		// Token: 0x04003E61 RID: 15969
		internal static int __PropertyOffset_bEnableScopedMovementUpdates;

		// Token: 0x04003E62 RID: 15970
		internal static byte __PropertyMask_bEnableScopedMovementUpdates;

		// Token: 0x04003E63 RID: 15971
		internal static int __PropertyOffset_bEnableServerDualMoveScopedMovementUpdates;

		// Token: 0x04003E64 RID: 15972
		internal static byte __PropertyMask_bEnableServerDualMoveScopedMovementUpdates;

		// Token: 0x04003E65 RID: 15973
		internal static int __PropertyOffset_bForceMaxAccel;

		// Token: 0x04003E66 RID: 15974
		internal static byte __PropertyMask_bForceMaxAccel;

		// Token: 0x04003E67 RID: 15975
		internal static int __PropertyOffset_bRunPhysicsWithNoController;

		// Token: 0x04003E68 RID: 15976
		internal static byte __PropertyMask_bRunPhysicsWithNoController;

		// Token: 0x04003E69 RID: 15977
		internal static int __PropertyOffset_bForceNextFloorCheck;

		// Token: 0x04003E6A RID: 15978
		internal static byte __PropertyMask_bForceNextFloorCheck;

		// Token: 0x04003E6B RID: 15979
		internal static int __PropertyOffset_bShrinkProxyCapsule;

		// Token: 0x04003E6C RID: 15980
		internal static byte __PropertyMask_bShrinkProxyCapsule;

		// Token: 0x04003E6D RID: 15981
		internal static int __PropertyOffset_bCanWalkOffLedges;

		// Token: 0x04003E6E RID: 15982
		internal static byte __PropertyMask_bCanWalkOffLedges;

		// Token: 0x04003E6F RID: 15983
		internal static int __PropertyOffset_bCanWalkOffLedgesWhenCrouching;

		// Token: 0x04003E70 RID: 15984
		internal static byte __PropertyMask_bCanWalkOffLedgesWhenCrouching;

		// Token: 0x04003E71 RID: 15985
		internal static int __PropertyOffset_bKuroCanWalkOffLedgesNav;

		// Token: 0x04003E72 RID: 15986
		internal static byte __PropertyMask_bKuroCanWalkOffLedgesNav;

		// Token: 0x04003E73 RID: 15987
		internal static int __PropertyOffset_bKuroUsePerchEdgeDirection;

		// Token: 0x04003E74 RID: 15988
		internal static byte __PropertyMask_bKuroUsePerchEdgeDirection;

		// Token: 0x04003E75 RID: 15989
		internal static int __PropertyOffset_bKuroPlanarPhysWalking;

		// Token: 0x04003E76 RID: 15990
		internal static byte __PropertyMask_bKuroPlanarPhysWalking;

		// Token: 0x04003E77 RID: 15991
		internal static int __PropertyOffset_bKuroPlanarNeedFindFloor;

		// Token: 0x04003E78 RID: 15992
		internal static byte __PropertyMask_bKuroPlanarNeedFindFloor;

		// Token: 0x04003E79 RID: 15993
		internal static int __PropertyOffset_bNetworkSkipProxyPredictionOnNetUpdate;

		// Token: 0x04003E7A RID: 15994
		internal static byte __PropertyMask_bNetworkSkipProxyPredictionOnNetUpdate;

		// Token: 0x04003E7B RID: 15995
		internal static int __PropertyOffset_bNetworkAlwaysReplicateTransformUpdateTimestamp;

		// Token: 0x04003E7C RID: 15996
		internal static byte __PropertyMask_bNetworkAlwaysReplicateTransformUpdateTimestamp;

		// Token: 0x04003E7D RID: 15997
		internal static int __PropertyOffset_bDeferUpdateMoveComponent;

		// Token: 0x04003E7E RID: 15998
		internal static byte __PropertyMask_bDeferUpdateMoveComponent;

		// Token: 0x04003E7F RID: 15999
		internal static int __PropertyOffset_bEnablePhysicsInteraction;

		// Token: 0x04003E80 RID: 16000
		internal static byte __PropertyMask_bEnablePhysicsInteraction;

		// Token: 0x04003E81 RID: 16001
		internal static int __PropertyOffset_bTouchForceScaledToMass;

		// Token: 0x04003E82 RID: 16002
		internal static byte __PropertyMask_bTouchForceScaledToMass;

		// Token: 0x04003E83 RID: 16003
		internal static int __PropertyOffset_bPushForceScaledToMass;

		// Token: 0x04003E84 RID: 16004
		internal static byte __PropertyMask_bPushForceScaledToMass;

		// Token: 0x04003E85 RID: 16005
		internal static int __PropertyOffset_bPushForceUsingZOffset;

		// Token: 0x04003E86 RID: 16006
		internal static byte __PropertyMask_bPushForceUsingZOffset;

		// Token: 0x04003E87 RID: 16007
		internal static int __PropertyOffset_bScalePushForceToVelocity;

		// Token: 0x04003E88 RID: 16008
		internal static byte __PropertyMask_bScalePushForceToVelocity;

		// Token: 0x04003E89 RID: 16009
		internal static int __PropertyOffset_DeferredUpdatedMoveComponent;

		// Token: 0x04003E8A RID: 16010
		internal static int __PropertyOffset_StepUpSpeedPrecent;

		// Token: 0x04003E8B RID: 16011
		internal static int __PropertyOffset_StepDownSpeedPrecent;

		// Token: 0x04003E8C RID: 16012
		internal static int __PropertyOffset_StepUpDeltaPrecent;

		// Token: 0x04003E8D RID: 16013
		internal static int __PropertyOffset_StepUpStandardSpeed;

		// Token: 0x04003E8E RID: 16014
		internal static int __PropertyOffset_MaxOutOfWaterStepHeight;

		// Token: 0x04003E8F RID: 16015
		internal static int __PropertyOffset_OutofWaterZ;

		// Token: 0x04003E90 RID: 16016
		internal static int __PropertyOffset_Mass;

		// Token: 0x04003E91 RID: 16017
		internal static int __PropertyOffset_StandingDownwardForceScale;

		// Token: 0x04003E92 RID: 16018
		internal static int __PropertyOffset_InitialPushForceFactor;

		// Token: 0x04003E93 RID: 16019
		internal static int __PropertyOffset_PushForceFactor;

		// Token: 0x04003E94 RID: 16020
		internal static int __PropertyOffset_PushForcePointZOffsetFactor;

		// Token: 0x04003E95 RID: 16021
		internal static int __PropertyOffset_TouchForceFactor;

		// Token: 0x04003E96 RID: 16022
		internal static int __PropertyOffset_MinTouchForce;

		// Token: 0x04003E97 RID: 16023
		internal static int __PropertyOffset_MaxTouchForce;

		// Token: 0x04003E98 RID: 16024
		internal static int __PropertyOffset_RepulsionForce;

		// Token: 0x04003E99 RID: 16025
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x04003E9A RID: 16026
		internal static int __PropertyOffset_LastUpdateRotation;

		// Token: 0x04003E9B RID: 16027
		internal static int __PropertyOffset_LastUpdateLocation;

		// Token: 0x04003E9C RID: 16028
		internal static int __PropertyOffset_LastUpdateVelocity;

		// Token: 0x04003E9D RID: 16029
		internal static int __PropertyOffset_ServerLastTransformUpdateTimeStamp;

		// Token: 0x04003E9E RID: 16030
		internal static int __PropertyOffset_ServerLastClientGoodMoveAckTime;

		// Token: 0x04003E9F RID: 16031
		internal static int __PropertyOffset_ServerLastClientAdjustmentTime;

		// Token: 0x04003EA0 RID: 16032
		internal static int __PropertyOffset_PendingImpulseToApply;

		// Token: 0x04003EA1 RID: 16033
		internal static int __PropertyOffset_PendingForceToApply;

		// Token: 0x04003EA2 RID: 16034
		internal static int __PropertyOffset_AnalogInputModifier;

		// Token: 0x04003EA3 RID: 16035
		internal static int __PropertyOffset_BaseDeltaPosition;

		// Token: 0x04003EA4 RID: 16036
		internal static int __PropertyOffset_BaseDeltaQuat;

		// Token: 0x04003EA5 RID: 16037
		internal static int __PropertyOffset_ReplayDriverTime;

		// Token: 0x04003EA6 RID: 16038
		internal static int __PropertyOffset_bKuroVelocityDebug;

		// Token: 0x04003EA7 RID: 16039
		internal static int __PropertyOffset_MonitorMaxVelocityZ;

		// Token: 0x04003EA8 RID: 16040
		internal static int __PropertyOffset_MaxSimulationTimeStep;

		// Token: 0x04003EA9 RID: 16041
		internal static int __PropertyOffset_MaxSimulationIterations;

		// Token: 0x04003EAA RID: 16042
		internal static int __PropertyOffset_MaxJumpApexAttemptsPerSimulation;

		// Token: 0x04003EAB RID: 16043
		internal static int __PropertyOffset_MaxDepenetrationWithGeometry;

		// Token: 0x04003EAC RID: 16044
		internal static int __PropertyOffset_MaxDepenetrationWithGeometryAsProxy;

		// Token: 0x04003EAD RID: 16045
		internal static int __PropertyOffset_MaxDepenetrationWithPawn;

		// Token: 0x04003EAE RID: 16046
		internal static int __PropertyOffset_MaxDepenetrationWithPawnAsProxy;

		// Token: 0x04003EAF RID: 16047
		internal static int __PropertyOffset_MaxDepenetrationPerSeconds;

		// Token: 0x04003EB0 RID: 16048
		internal static int __PropertyOffset_NetworkSimulatedSmoothLocationTime;

		// Token: 0x04003EB1 RID: 16049
		internal static int __PropertyOffset_NetworkSimulatedSmoothRotationTime;

		// Token: 0x04003EB2 RID: 16050
		internal static int __PropertyOffset_ListenServerNetworkSimulatedSmoothLocationTime;

		// Token: 0x04003EB3 RID: 16051
		internal static int __PropertyOffset_ListenServerNetworkSimulatedSmoothRotationTime;

		// Token: 0x04003EB4 RID: 16052
		internal static int __PropertyOffset_NetProxyShrinkRadius;

		// Token: 0x04003EB5 RID: 16053
		internal static int __PropertyOffset_NetProxyShrinkHalfHeight;

		// Token: 0x04003EB6 RID: 16054
		internal static int __PropertyOffset_NetworkMaxSmoothUpdateDistance;

		// Token: 0x04003EB7 RID: 16055
		internal static int __PropertyOffset_NetworkNoSmoothUpdateDistance;

		// Token: 0x04003EB8 RID: 16056
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAckGoodMoves;

		// Token: 0x04003EB9 RID: 16057
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAdjustments;

		// Token: 0x04003EBA RID: 16058
		internal static int __PropertyOffset_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection;

		// Token: 0x04003EBB RID: 16059
		internal static int __PropertyOffset_NetworkLargeClientCorrectionDistance;

		// Token: 0x04003EBC RID: 16060
		internal static int __PropertyOffset_NetworkPredictingLinearSmoothMaxRange;

		// Token: 0x04003EBD RID: 16061
		internal static int __PropertyOffset_NetworkPredictingSmoothFactorWithDistance;

		// Token: 0x04003EBE RID: 16062
		internal static int __PropertyOffset_NetworkPredictingSmoothFactorWithSpeed;

		// Token: 0x04003EBF RID: 16063
		internal static int __PropertyOffset_NetworkPredictingMinSmoothMeshSpeed;

		// Token: 0x04003EC0 RID: 16064
		internal static int __PropertyOffset_NetworkPredictingMaxSmoothMeshSpeed;

		// Token: 0x04003EC1 RID: 16065
		internal static int __PropertyOffset_NetworkPredictingZSmoothTimeOnGround;

		// Token: 0x04003EC2 RID: 16066
		internal static int __PropertyOffset_LedgeCheckThreshold;

		// Token: 0x04003EC3 RID: 16067
		internal static int __PropertyOffset_JumpOutOfWaterPitch;

		// Token: 0x04003EC4 RID: 16068
		internal static int __PropertyOffset_CurrentFloor;

		// Token: 0x04003EC5 RID: 16069
		[Nullable(2)]
		private FFindFloorResult _CurrentFloor;

		// Token: 0x04003EC6 RID: 16070
		internal static int __PropertyOffset_DefaultLandMovementMode;

		// Token: 0x04003EC7 RID: 16071
		internal static int __PropertyOffset_DefaultWaterMovementMode;

		// Token: 0x04003EC8 RID: 16072
		internal static int __PropertyOffset_PredictionDataMaxMoveDeltaTime;

		// Token: 0x04003EC9 RID: 16073
		internal static int __PropertyOffset_GroundMovementMode;

		// Token: 0x04003ECA RID: 16074
		internal static int __PropertyOffset_bMaintainHorizontalGroundVelocity;

		// Token: 0x04003ECB RID: 16075
		internal static byte __PropertyMask_bMaintainHorizontalGroundVelocity;

		// Token: 0x04003ECC RID: 16076
		internal static int __PropertyOffset_bImpartBaseVelocityX;

		// Token: 0x04003ECD RID: 16077
		internal static byte __PropertyMask_bImpartBaseVelocityX;

		// Token: 0x04003ECE RID: 16078
		internal static int __PropertyOffset_bImpartBaseVelocityY;

		// Token: 0x04003ECF RID: 16079
		internal static byte __PropertyMask_bImpartBaseVelocityY;

		// Token: 0x04003ED0 RID: 16080
		internal static int __PropertyOffset_bImpartBaseVelocityZ;

		// Token: 0x04003ED1 RID: 16081
		internal static byte __PropertyMask_bImpartBaseVelocityZ;

		// Token: 0x04003ED2 RID: 16082
		internal static int __PropertyOffset_bImpartBaseAngularVelocity;

		// Token: 0x04003ED3 RID: 16083
		internal static byte __PropertyMask_bImpartBaseAngularVelocity;

		// Token: 0x04003ED4 RID: 16084
		internal static int __PropertyOffset_bJustTeleported;

		// Token: 0x04003ED5 RID: 16085
		internal static byte __PropertyMask_bJustTeleported;

		// Token: 0x04003ED6 RID: 16086
		internal static int __PropertyOffset_bNetworkUpdateReceived;

		// Token: 0x04003ED7 RID: 16087
		internal static byte __PropertyMask_bNetworkUpdateReceived;

		// Token: 0x04003ED8 RID: 16088
		internal static int __PropertyOffset_bNetworkMovementModeChanged;

		// Token: 0x04003ED9 RID: 16089
		internal static byte __PropertyMask_bNetworkMovementModeChanged;

		// Token: 0x04003EDA RID: 16090
		internal static int __PropertyOffset_bIgnoreClientMovementErrorChecksAndCorrection;

		// Token: 0x04003EDB RID: 16091
		internal static byte __PropertyMask_bIgnoreClientMovementErrorChecksAndCorrection;

		// Token: 0x04003EDC RID: 16092
		internal static int __PropertyOffset_bServerAcceptClientAuthoritativePosition;

		// Token: 0x04003EDD RID: 16093
		internal static byte __PropertyMask_bServerAcceptClientAuthoritativePosition;

		// Token: 0x04003EDE RID: 16094
		internal static int __PropertyOffset_bNotifyApex;

		// Token: 0x04003EDF RID: 16095
		internal static byte __PropertyMask_bNotifyApex;

		// Token: 0x04003EE0 RID: 16096
		internal static int __PropertyOffset_bCheatFlying;

		// Token: 0x04003EE1 RID: 16097
		internal static byte __PropertyMask_bCheatFlying;

		// Token: 0x04003EE2 RID: 16098
		internal static int __PropertyOffset_bWantsToCrouch;

		// Token: 0x04003EE3 RID: 16099
		internal static byte __PropertyMask_bWantsToCrouch;

		// Token: 0x04003EE4 RID: 16100
		internal static int __PropertyOffset_bCrouchMaintainsBaseLocation;

		// Token: 0x04003EE5 RID: 16101
		internal static byte __PropertyMask_bCrouchMaintainsBaseLocation;

		// Token: 0x04003EE6 RID: 16102
		internal static int __PropertyOffset_bIgnoreBaseRotation;

		// Token: 0x04003EE7 RID: 16103
		internal static byte __PropertyMask_bIgnoreBaseRotation;

		// Token: 0x04003EE8 RID: 16104
		internal static int __PropertyOffset_bFastAttachedMove;

		// Token: 0x04003EE9 RID: 16105
		internal static byte __PropertyMask_bFastAttachedMove;

		// Token: 0x04003EEA RID: 16106
		internal static int __PropertyOffset_bAlwaysCheckFloor;

		// Token: 0x04003EEB RID: 16107
		internal static byte __PropertyMask_bAlwaysCheckFloor;

		// Token: 0x04003EEC RID: 16108
		internal static int __PropertyOffset_bUseFlatBaseForFloorChecks;

		// Token: 0x04003EED RID: 16109
		internal static byte __PropertyMask_bUseFlatBaseForFloorChecks;

		// Token: 0x04003EEE RID: 16110
		internal static int __PropertyOffset_bPerformingJumpOff;

		// Token: 0x04003EEF RID: 16111
		internal static byte __PropertyMask_bPerformingJumpOff;

		// Token: 0x04003EF0 RID: 16112
		internal static int __PropertyOffset_bWantsToLeaveNavWalking;

		// Token: 0x04003EF1 RID: 16113
		internal static byte __PropertyMask_bWantsToLeaveNavWalking;

		// Token: 0x04003EF2 RID: 16114
		internal static int __PropertyOffset_bUseRVOAvoidance;

		// Token: 0x04003EF3 RID: 16115
		internal static byte __PropertyMask_bUseRVOAvoidance;

		// Token: 0x04003EF4 RID: 16116
		internal static int __PropertyOffset_bRequestedMoveUseAcceleration;

		// Token: 0x04003EF5 RID: 16117
		internal static byte __PropertyMask_bRequestedMoveUseAcceleration;

		// Token: 0x04003EF6 RID: 16118
		internal static int __PropertyOffset_bWasSimulatingRootMotion;

		// Token: 0x04003EF7 RID: 16119
		internal static byte __PropertyMask_bWasSimulatingRootMotion;

		// Token: 0x04003EF8 RID: 16120
		internal static int __PropertyOffset_bAllowPhysicsRotationDuringAnimRootMotion;

		// Token: 0x04003EF9 RID: 16121
		internal static byte __PropertyMask_bAllowPhysicsRotationDuringAnimRootMotion;

		// Token: 0x04003EFA RID: 16122
		internal static int __PropertyOffset_bHasRequestedVelocity;

		// Token: 0x04003EFB RID: 16123
		internal static byte __PropertyMask_bHasRequestedVelocity;

		// Token: 0x04003EFC RID: 16124
		internal static int __PropertyOffset_bRequestedMoveWithMaxSpeed;

		// Token: 0x04003EFD RID: 16125
		internal static byte __PropertyMask_bRequestedMoveWithMaxSpeed;

		// Token: 0x04003EFE RID: 16126
		internal static int __PropertyOffset_bWasAvoidanceUpdated;

		// Token: 0x04003EFF RID: 16127
		internal static byte __PropertyMask_bWasAvoidanceUpdated;

		// Token: 0x04003F00 RID: 16128
		internal static int __PropertyOffset_bProjectNavMeshWalking;

		// Token: 0x04003F01 RID: 16129
		internal static byte __PropertyMask_bProjectNavMeshWalking;

		// Token: 0x04003F02 RID: 16130
		internal static int __PropertyOffset_bProjectNavMeshOnBothWorldChannels;

		// Token: 0x04003F03 RID: 16131
		internal static byte __PropertyMask_bProjectNavMeshOnBothWorldChannels;

		// Token: 0x04003F04 RID: 16132
		internal static int __PropertyOffset_AvoidanceConsiderationRadius;

		// Token: 0x04003F05 RID: 16133
		internal static int __PropertyOffset_RequestedVelocity;

		// Token: 0x04003F06 RID: 16134
		internal static int __PropertyOffset_AvoidanceUID;

		// Token: 0x04003F07 RID: 16135
		internal static int __PropertyOffset_AvoidanceGroup;

		// Token: 0x04003F08 RID: 16136
		[Nullable(2)]
		private FNavAvoidanceMask _AvoidanceGroup;

		// Token: 0x04003F09 RID: 16137
		internal static int __PropertyOffset_GroupsToAvoid;

		// Token: 0x04003F0A RID: 16138
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToAvoid;

		// Token: 0x04003F0B RID: 16139
		internal static int __PropertyOffset_GroupsToIgnore;

		// Token: 0x04003F0C RID: 16140
		[Nullable(2)]
		private FNavAvoidanceMask _GroupsToIgnore;

		// Token: 0x04003F0D RID: 16141
		internal static int __PropertyOffset_AvoidanceWeight;

		// Token: 0x04003F0E RID: 16142
		internal static int __PropertyOffset_AvoidancePredictAlpha;

		// Token: 0x04003F0F RID: 16143
		internal static int __PropertyOffset_PendingLaunchVelocity;

		// Token: 0x04003F10 RID: 16144
		internal static int __PropertyOffset_NavMeshProjectionInterval;

		// Token: 0x04003F11 RID: 16145
		internal static int __PropertyOffset_NavMeshProjectionTimer;

		// Token: 0x04003F12 RID: 16146
		internal static int __PropertyOffset_NavMeshProjectionInterpSpeed;

		// Token: 0x04003F13 RID: 16147
		internal static int __PropertyOffset_NavMeshProjectionHeightScaleUp;

		// Token: 0x04003F14 RID: 16148
		internal static int __PropertyOffset_NavMeshProjectionHeightScaleDown;

		// Token: 0x04003F15 RID: 16149
		internal static int __PropertyOffset_NavWalkingFloorDistTolerance;

		// Token: 0x04003F16 RID: 16150
		internal static int __PropertyOffset_PostPhysicsTickFunction;

		// Token: 0x04003F17 RID: 16151
		[Nullable(2)]
		private FCharacterMovementComponentPostPhysicsTickFunction _PostPhysicsTickFunction;

		// Token: 0x04003F18 RID: 16152
		internal static int __PropertyOffset_MinTimeBetweenTimeStampResets;

		// Token: 0x04003F19 RID: 16153
		internal static int __PropertyOffset_CurrentRootMotion;

		// Token: 0x04003F1A RID: 16154
		[Nullable(2)]
		private FRootMotionSourceGroup _CurrentRootMotion;

		// Token: 0x04003F1B RID: 16155
		internal static int __PropertyOffset_ServerCorrectionRootMotion;

		// Token: 0x04003F1C RID: 16156
		[Nullable(2)]
		private FRootMotionSourceGroup _ServerCorrectionRootMotion;

		// Token: 0x04003F1D RID: 16157
		internal static int __PropertyOffset_RootMotionParams;

		// Token: 0x04003F1E RID: 16158
		[Nullable(2)]
		private FRootMotionMovementParams _RootMotionParams;

		// Token: 0x04003F1F RID: 16159
		internal static int __PropertyOffset_AnimRootMotionVelocity;

		// Token: 0x04003F20 RID: 16160
		internal static int __PropertyOffset_AnimRootMotionRotateAxis;

		// Token: 0x04003F21 RID: 16161
		internal static int __PropertyOffset_AnimRootMotionRotateSpeed;

		// Token: 0x04003F22 RID: 16162
		internal static int __PropertyOffset_bKuroAsyncRootMotion;

		// Token: 0x04003F23 RID: 16163
		internal static byte __PropertyMask_bKuroAsyncRootMotion;

		// Token: 0x04003F24 RID: 16164
		internal static int __PropertyOffset_KuroMovementSetting;

		// Token: 0x04003F25 RID: 16165
		[Nullable(2)]
		private FKuroMovementSetting _KuroMovementSetting;
	}
}
