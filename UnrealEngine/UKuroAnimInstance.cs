using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001655 RID: 5717
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstance")]
	[UnrealStructLayout(2560, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2560)]
	public class UKuroAnimInstance : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601492B RID: 84267 RVA: 0x001E421C File Offset: 0x001E241C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstance._ClassPtr;
		}

		// Token: 0x0601492C RID: 84268 RVA: 0x001E4228 File Offset: 0x001E2428
		public UKuroAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601492D RID: 84269 RVA: 0x001E4250 File Offset: 0x001E2450
		[NullableContext(1)]
		public UKuroAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005100 RID: 20736
		// (get) Token: 0x0601492E RID: 84270 RVA: 0x001E4283 File Offset: 0x001E2483
		// (set) Token: 0x0601492F RID: 84271 RVA: 0x001E4297 File Offset: 0x001E2497
		public unsafe FVector2D TurnLimitForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnLimitForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnLimitForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005101 RID: 20737
		// (get) Token: 0x06014930 RID: 84272 RVA: 0x001E42AC File Offset: 0x001E24AC
		// (set) Token: 0x06014931 RID: 84273 RVA: 0x001E42C0 File Offset: 0x001E24C0
		public unsafe FVector2D LookUpLimitForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpLimitForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpLimitForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005102 RID: 20738
		// (get) Token: 0x06014932 RID: 84274 RVA: 0x001E42D5 File Offset: 0x001E24D5
		// (set) Token: 0x06014933 RID: 84275 RVA: 0x001E42E5 File Offset: 0x001E24E5
		public unsafe bool bRollBackToOriginForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bRollBackToOriginForBoneRotateAnimNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bRollBackToOriginForBoneRotateAnimNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005103 RID: 20739
		// (get) Token: 0x06014934 RID: 84276 RVA: 0x001E42F6 File Offset: 0x001E24F6
		// (set) Token: 0x06014935 RID: 84277 RVA: 0x001E4306 File Offset: 0x001E2506
		public unsafe bool bStopForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bStopForBoneRotateAnimNode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bStopForBoneRotateAnimNode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005104 RID: 20740
		// (get) Token: 0x06014936 RID: 84278 RVA: 0x001E4317 File Offset: 0x001E2517
		// (set) Token: 0x06014937 RID: 84279 RVA: 0x001E4327 File Offset: 0x001E2527
		public unsafe float TurnAngleForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnAngleForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnAngleForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005105 RID: 20741
		// (get) Token: 0x06014938 RID: 84280 RVA: 0x001E4338 File Offset: 0x001E2538
		// (set) Token: 0x06014939 RID: 84281 RVA: 0x001E4348 File Offset: 0x001E2548
		public unsafe float LookUpAngleForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpAngleForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpAngleForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005106 RID: 20742
		// (get) Token: 0x0601493A RID: 84282 RVA: 0x001E4359 File Offset: 0x001E2559
		// (set) Token: 0x0601493B RID: 84283 RVA: 0x001E4369 File Offset: 0x001E2569
		public unsafe float TurnOffsetForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnOffsetForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_TurnOffsetForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005107 RID: 20743
		// (get) Token: 0x0601493C RID: 84284 RVA: 0x001E437A File Offset: 0x001E257A
		// (set) Token: 0x0601493D RID: 84285 RVA: 0x001E438A File Offset: 0x001E258A
		public unsafe float LookUpOffsetForBoneRotateAnimNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpOffsetForBoneRotateAnimNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_LookUpOffsetForBoneRotateAnimNode) = value;
			}
		}

		// Token: 0x17005108 RID: 20744
		// (get) Token: 0x0601493E RID: 84286 RVA: 0x001E439C File Offset: 0x001E259C
		// (set) Token: 0x0601493F RID: 84287 RVA: 0x001E43D5 File Offset: 0x001E25D5
		[Nullable(1)]
		public TMap<FName, UAnimSequence> ExtraRibbonAnims
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, UAnimSequence> result;
				if ((result = this._ExtraRibbonAnims) == null)
				{
					result = (this._ExtraRibbonAnims = new TMap<FName, UAnimSequence>(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_ExtraRibbonAnims, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ExtraRibbonAnims.CopyAssign(value);
			}
		}

		// Token: 0x17005109 RID: 20745
		// (get) Token: 0x06014940 RID: 84288 RVA: 0x001E43E4 File Offset: 0x001E25E4
		// (set) Token: 0x06014941 RID: 84289 RVA: 0x001E441D File Offset: 0x001E261D
		[Nullable(1)]
		public TMap<FName, FExtraFollowTable> SecondaryExtraFollowAnims
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FExtraFollowTable> result;
				if ((result = this._SecondaryExtraFollowAnims) == null)
				{
					result = (this._SecondaryExtraFollowAnims = new TMap<FName, FExtraFollowTable>(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_SecondaryExtraFollowAnims, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SecondaryExtraFollowAnims.CopyAssign(value);
			}
		}

		// Token: 0x1700510A RID: 20746
		// (get) Token: 0x06014942 RID: 84290 RVA: 0x001E442B File Offset: 0x001E262B
		// (set) Token: 0x06014943 RID: 84291 RVA: 0x001E443B File Offset: 0x001E263B
		public unsafe bool bExtraFollowFreeze
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bExtraFollowFreeze) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bExtraFollowFreeze) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700510B RID: 20747
		// (get) Token: 0x06014944 RID: 84292 RVA: 0x001E444C File Offset: 0x001E264C
		// (set) Token: 0x06014945 RID: 84293 RVA: 0x001E445C File Offset: 0x001E265C
		public unsafe bool bRequestSaveExtraFollowSnapshot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bRequestSaveExtraFollowSnapshot) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bRequestSaveExtraFollowSnapshot) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700510C RID: 20748
		// (get) Token: 0x06014946 RID: 84294 RVA: 0x001E446D File Offset: 0x001E266D
		// (set) Token: 0x06014947 RID: 84295 RVA: 0x001E4481 File Offset: 0x001E2681
		public unsafe FTransform ExtraFollowFrozenWorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_ExtraFollowFrozenWorldTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_ExtraFollowFrozenWorldTransform) = value;
			}
		}

		// Token: 0x1700510D RID: 20749
		// (get) Token: 0x06014948 RID: 84296 RVA: 0x001E4496 File Offset: 0x001E2696
		// (set) Token: 0x06014949 RID: 84297 RVA: 0x001E44A6 File Offset: 0x001E26A6
		public unsafe bool bExtraFollowLockWorldTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bExtraFollowLockWorldTransform) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroAnimInstance.__PropertyOffset_bExtraFollowLockWorldTransform) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601494A RID: 84298 RVA: 0x001E44B8 File Offset: 0x001E26B8
		public unsafe void UpdateSkillMoveInfo(in float DeltaTime, in FRotator RoleRotator, in FVector Speed, ref ACharacter Character, ref float RotatorMixed, in FVector Acceleration, ref FVector RelativeAcceleration, ref FLeanAmount LeanAmount, in float GroundLeanAmountLerpSpeed, in FRotator AimRotator, ref float AimAngle, ref FVector2D AimMoveMixed, in float RotatorSpeed, AActor SkillTarget, in FVectorDouble CachedActorLocation)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &RotatorMixed)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &RelativeAcceleration)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &GroundLeanAmountLerpSpeed)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &AimAngle)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector2D* ptr11 = &AimMoveMixed)
								{
									void* ptr12 = (void*)ptr11;
									fixed (float* ptr13 = &RotatorSpeed)
									{
										void* ptr14 = (void*)ptr13;
										UKuroAnimInstance.__UpdateSkillMoveInfo_Internal(base.NativePtr, DeltaTime, RoleRotator, Speed, ref nativeObjectPtr, ref RotatorMixed, Acceleration, ref RelativeAcceleration, (LeanAmount ?? new FLeanAmount()).NativePtr, GroundLeanAmountLerpSpeed, AimRotator, ref AimAngle, ref AimMoveMixed, RotatorSpeed, (SkillTarget != null) ? SkillTarget.NativePtr : IntPtr.Zero, CachedActorLocation);
										Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
										ptr = null;
										ptr3 = null;
										ptr5 = null;
										ptr7 = null;
										ptr9 = null;
										ptr11 = null;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601494B RID: 84299 RVA: 0x001E4580 File Offset: 0x001E2780
		public unsafe void UpdateRoleInfo(ref bool StateGround, ref bool StateGroundSprint, ref bool StateGroundWalk, ref bool StateGroundRun, ref bool StateRunStop, ref bool StateSprintStop, ref bool StateWalkStop, ref bool RunStop, ref bool StateClimb, ref bool StateAir, ref bool StateAirGlide, ref bool StateWater, ref bool StateView, ref bool StateAim, ref bool StateFace)
		{
			fixed (bool* ptr = &StateGround)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &StateGroundSprint)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &StateGroundWalk)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &StateGroundRun)
						{
							void* ptr8 = (void*)ptr7;
							fixed (bool* ptr9 = &StateRunStop)
							{
								void* ptr10 = (void*)ptr9;
								fixed (bool* ptr11 = &StateSprintStop)
								{
									void* ptr12 = (void*)ptr11;
									fixed (bool* ptr13 = &StateWalkStop)
									{
										void* ptr14 = (void*)ptr13;
										fixed (bool* ptr15 = &RunStop)
										{
											void* ptr16 = (void*)ptr15;
											fixed (bool* ptr17 = &StateClimb)
											{
												void* ptr18 = (void*)ptr17;
												fixed (bool* ptr19 = &StateAir)
												{
													void* ptr20 = (void*)ptr19;
													fixed (bool* ptr21 = &StateAirGlide)
													{
														void* ptr22 = (void*)ptr21;
														fixed (bool* ptr23 = &StateWater)
														{
															void* ptr24 = (void*)ptr23;
															fixed (bool* ptr25 = &StateView)
															{
																void* ptr26 = (void*)ptr25;
																fixed (bool* ptr27 = &StateAim)
																{
																	void* ptr28 = (void*)ptr27;
																	fixed (bool* ptr29 = &StateFace)
																	{
																		void* ptr30 = (void*)ptr29;
																		UKuroAnimInstance.__UpdateRoleInfo_Internal(base.NativePtr, ref StateGround, ref StateGroundSprint, ref StateGroundWalk, ref StateGroundRun, ref StateRunStop, ref StateSprintStop, ref StateWalkStop, ref RunStop, ref StateClimb, ref StateAir, ref StateAirGlide, ref StateWater, ref StateView, ref StateAim, ref StateFace);
																		ptr = null;
																		ptr3 = null;
																		ptr5 = null;
																		ptr7 = null;
																		ptr9 = null;
																		ptr11 = null;
																		ptr13 = null;
																		ptr15 = null;
																		ptr17 = null;
																		ptr19 = null;
																		ptr21 = null;
																		ptr23 = null;
																		ptr25 = null;
																		ptr27 = null;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601494C RID: 84300 RVA: 0x001E4670 File Offset: 0x001E2870
		public unsafe void UpdateMoveInfoMixed(ref ACharacter Character, ref float WalkRunMixed, in float DeltaTime, in float Slop, ref UCurveFloat AngleToStepFrequency, ref UCurveFloat AngleToStepLength, ref UCurveFloat WalkCurve, ref UCurveFloat RunCurve, in float SpeedSize, ref float StepLengthMixed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, ref float StandRate)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat = AngleToStepFrequency;
			IntPtr nativeObjectPtr2 = (ucurveFloat != null) ? ucurveFloat.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat2 = AngleToStepLength;
			IntPtr nativeObjectPtr3 = (ucurveFloat2 != null) ? ucurveFloat2.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat3 = WalkCurve;
			IntPtr nativeObjectPtr4 = (ucurveFloat3 != null) ? ucurveFloat3.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat4 = RunCurve;
			IntPtr nativeObjectPtr5 = (ucurveFloat4 != null) ? ucurveFloat4.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &WalkRunMixed)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DeltaTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Slop)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &SpeedSize)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &StepLengthMixed)
							{
								void* ptr10 = (void*)ptr9;
								fixed (float* ptr11 = &AnimWalkSpeed)
								{
									void* ptr12 = (void*)ptr11;
									fixed (float* ptr13 = &AnimRunSpeed)
									{
										void* ptr14 = (void*)ptr13;
										fixed (float* ptr15 = &SprintSpeed)
										{
											void* ptr16 = (void*)ptr15;
											fixed (float* ptr17 = &StandRate)
											{
												void* ptr18 = (void*)ptr17;
												UKuroAnimInstance.__UpdateMoveInfoMixed_Internal(base.NativePtr, ref nativeObjectPtr, ref WalkRunMixed, DeltaTime, Slop, ref nativeObjectPtr2, ref nativeObjectPtr3, ref nativeObjectPtr4, ref nativeObjectPtr5, SpeedSize, ref StepLengthMixed, AnimWalkSpeed, AnimRunSpeed, SprintSpeed, ref StandRate);
												Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
												AngleToStepFrequency = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr2);
												AngleToStepLength = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr3);
												WalkCurve = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr4);
												RunCurve = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr5);
												ptr = null;
												ptr3 = null;
												ptr5 = null;
												ptr7 = null;
												ptr9 = null;
												ptr11 = null;
												ptr13 = null;
												ptr15 = null;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601494D RID: 84301 RVA: 0x001E47A8 File Offset: 0x001E29A8
		public unsafe void UpdateIKInfoLocalValue(ACharacter Character, ref FRotator MeshQuatInverse, ref FVector MeshWorldLocation)
		{
			fixed (FRotator* ptr = &MeshQuatInverse)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &MeshWorldLocation)
				{
					void* ptr4 = (void*)ptr3;
					UKuroAnimInstance.__UpdateIKInfoLocalValue_Internal(base.NativePtr, (Character != null) ? Character.NativePtr : IntPtr.Zero, ref MeshQuatInverse, ref MeshWorldLocation);
					ptr = null;
				}
			}
		}

		// Token: 0x0601494E RID: 84302 RVA: 0x001E47E4 File Offset: 0x001E29E4
		public unsafe void UpdateIKinfoInOtherState(ref ACharacter Character, ref FVector OverallOffsetLocation, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref FVector LHandNormalDirection, ref FVector RHandNormalDirection, ref float HipLerpSpeed)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			fixed (FVector* ptr = &OverallOffsetLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &LFootOffsetLocation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &LFootNormalDirection)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &RFootOffsetLocation)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &RFootNormalDirection)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &LHandNormalDirection)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &RHandNormalDirection)
									{
										void* ptr14 = (void*)ptr13;
										fixed (float* ptr15 = &HipLerpSpeed)
										{
											void* ptr16 = (void*)ptr15;
											UKuroAnimInstance.__UpdateIKinfoInOtherState_Internal(base.NativePtr, ref nativeObjectPtr, ref OverallOffsetLocation, ref LFootOffsetLocation, ref LFootNormalDirection, ref RFootOffsetLocation, ref RFootNormalDirection, ref LHandNormalDirection, ref RHandNormalDirection, ref HipLerpSpeed);
											Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
											ptr = null;
											ptr3 = null;
											ptr5 = null;
											ptr7 = null;
											ptr9 = null;
											ptr11 = null;
											ptr13 = null;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601494F RID: 84303 RVA: 0x001E488C File Offset: 0x001E2A8C
		public unsafe void UpdateIKInfoInGroundState(in bool HasWallForward, in FVector MeshWorldLocation, in bool IsMoving, in float DegMovementSlop, ref bool bUpHill, ref bool bDownHill, ref ACharacter Character, ref USkeletalMeshComponent Mesh, in float Speed, in bool HasMoveInput, in float RunWalkMix, ref FVector OverallOffsetLocation, ref float HipLerpSpeed, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref FHitResult LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref FHitResult RFootHitResult, bool UseCurveFootLocation)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			IntPtr nativeObjectPtr2 = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero;
			fixed (bool* ptr = &HasWallForward)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &IsMoving)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &DegMovementSlop)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &bUpHill)
						{
							void* ptr8 = (void*)ptr7;
							fixed (bool* ptr9 = &bDownHill)
							{
								void* ptr10 = (void*)ptr9;
								fixed (float* ptr11 = &Speed)
								{
									void* ptr12 = (void*)ptr11;
									fixed (bool* ptr13 = &HasMoveInput)
									{
										void* ptr14 = (void*)ptr13;
										fixed (float* ptr15 = &RunWalkMix)
										{
											void* ptr16 = (void*)ptr15;
											fixed (FVector* ptr17 = &OverallOffsetLocation)
											{
												void* ptr18 = (void*)ptr17;
												fixed (float* ptr19 = &HipLerpSpeed)
												{
													void* ptr20 = (void*)ptr19;
													fixed (bool* ptr21 = &bLFootNeedIK)
													{
														void* ptr22 = (void*)ptr21;
														fixed (FVector* ptr23 = &LFootOffsetLocation)
														{
															void* ptr24 = (void*)ptr23;
															fixed (FVector* ptr25 = &LFootNormalDirection)
															{
																void* ptr26 = (void*)ptr25;
																fixed (bool* ptr27 = &bRFootNeedIK)
																{
																	void* ptr28 = (void*)ptr27;
																	fixed (FVector* ptr29 = &RFootOffsetLocation)
																	{
																		void* ptr30 = (void*)ptr29;
																		fixed (FVector* ptr31 = &RFootNormalDirection)
																		{
																			void* ptr32 = (void*)ptr31;
																			UKuroAnimInstance.__UpdateIKInfoInGroundState_Internal(base.NativePtr, HasWallForward, MeshWorldLocation, IsMoving, DegMovementSlop, ref bUpHill, ref bDownHill, ref nativeObjectPtr, ref nativeObjectPtr2, Speed, HasMoveInput, RunWalkMix, ref OverallOffsetLocation, ref HipLerpSpeed, ref bLFootNeedIK, ref LFootOffsetLocation, ref LFootNormalDirection, (LFootHitResult ?? new FHitResult()).NativePtr, ref bRFootNeedIK, ref RFootOffsetLocation, ref RFootNormalDirection, (RFootHitResult ?? new FHitResult()).NativePtr, UseCurveFootLocation);
																			Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
																			Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(nativeObjectPtr2);
																			ptr = null;
																			ptr3 = null;
																			ptr5 = null;
																			ptr7 = null;
																			ptr9 = null;
																			ptr11 = null;
																			ptr13 = null;
																			ptr15 = null;
																			ptr17 = null;
																			ptr19 = null;
																			ptr21 = null;
																			ptr23 = null;
																			ptr25 = null;
																			ptr27 = null;
																			ptr29 = null;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014950 RID: 84304 RVA: 0x001E49F4 File Offset: 0x001E2BF4
		public unsafe void UpdateIKinfoInClimbState(UAnimInstance AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector OverallOffsetLocation, ref float ClimbIK, in float FastClimbDirection, in bool IsFastClimbState, ref ACharacter Character, ref USkeletalMeshComponent Mesh, ref float HipLerpSpeed, in float Speed, in bool HasMoveInput, in bool IsClimbExitState, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			IntPtr nativeObjectPtr2 = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero;
			fixed (FVector* ptr = &OverallOffsetLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &ClimbIK)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &FastClimbDirection)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &IsFastClimbState)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &HipLerpSpeed)
							{
								void* ptr10 = (void*)ptr9;
								fixed (float* ptr11 = &Speed)
								{
									void* ptr12 = (void*)ptr11;
									fixed (bool* ptr13 = &HasMoveInput)
									{
										void* ptr14 = (void*)ptr13;
										fixed (bool* ptr15 = &IsClimbExitState)
										{
											void* ptr16 = (void*)ptr15;
											fixed (float* ptr17 = &ClimbRadius)
											{
												void* ptr18 = (void*)ptr17;
												fixed (FVector* ptr19 = &LFootCachedLocation)
												{
													void* ptr20 = (void*)ptr19;
													fixed (FVector* ptr21 = &LFootCachedNormal)
													{
														void* ptr22 = (void*)ptr21;
														fixed (FVector* ptr23 = &LFootOffsetLocation)
														{
															void* ptr24 = (void*)ptr23;
															fixed (FVector* ptr25 = &LFootNormalDirection)
															{
																void* ptr26 = (void*)ptr25;
																fixed (float* ptr27 = &LFootPrevFrameAlpha)
																{
																	void* ptr28 = (void*)ptr27;
																	fixed (FVector* ptr29 = &RFootCachedLocation)
																	{
																		void* ptr30 = (void*)ptr29;
																		fixed (FVector* ptr31 = &RFootCachedNormal)
																		{
																			void* ptr32 = (void*)ptr31;
																			fixed (FVector* ptr33 = &RFootOffsetLocation)
																			{
																				void* ptr34 = (void*)ptr33;
																				fixed (FVector* ptr35 = &RFootNormalDirection)
																				{
																					void* ptr36 = (void*)ptr35;
																					fixed (float* ptr37 = &RFootPrevFrameAlpha)
																					{
																						void* ptr38 = (void*)ptr37;
																						fixed (FVector* ptr39 = &LHandCachedLocation)
																						{
																							void* ptr40 = (void*)ptr39;
																							fixed (FVector* ptr41 = &LHandCachedNormal)
																							{
																								void* ptr42 = (void*)ptr41;
																								fixed (FVector* ptr43 = &LHandOffsetLocation)
																								{
																									void* ptr44 = (void*)ptr43;
																									fixed (FVector* ptr45 = &LHandNormalDirection)
																									{
																										void* ptr46 = (void*)ptr45;
																										fixed (float* ptr47 = &LHandPrevFrameAlpha)
																										{
																											void* ptr48 = (void*)ptr47;
																											fixed (FVector* ptr49 = &RHandCachedLocation)
																											{
																												void* ptr50 = (void*)ptr49;
																												fixed (FVector* ptr51 = &RHandCachedNormal)
																												{
																													void* ptr52 = (void*)ptr51;
																													fixed (FVector* ptr53 = &RHandOffsetLocation)
																													{
																														void* ptr54 = (void*)ptr53;
																														fixed (FVector* ptr55 = &RHandNormalDirection)
																														{
																															void* ptr56 = (void*)ptr55;
																															fixed (float* ptr57 = &RHandPrevFrameAlpha)
																															{
																																void* ptr58 = (void*)ptr57;
																																UKuroAnimInstance.__UpdateIKinfoInClimbState_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, MeshWorldLocation, QuatInverse, ref OverallOffsetLocation, ref ClimbIK, FastClimbDirection, IsFastClimbState, ref nativeObjectPtr, ref nativeObjectPtr2, ref HipLerpSpeed, Speed, HasMoveInput, IsClimbExitState, ClimbRadius, LFootOffsetRelativeLocation, ref LFootCachedLocation, ref LFootCachedNormal, ref LFootOffsetLocation, ref LFootNormalDirection, ref LFootPrevFrameAlpha, RFootOffsetRelativeLocation, ref RFootCachedLocation, ref RFootCachedNormal, ref RFootOffsetLocation, ref RFootNormalDirection, ref RFootPrevFrameAlpha, LHandOffsetRelativeLocation, ref LHandCachedLocation, ref LHandCachedNormal, ref LHandOffsetLocation, ref LHandNormalDirection, ref LHandPrevFrameAlpha, RHandOffsetRelativeLocation, ref RHandCachedLocation, ref RHandCachedNormal, ref RHandOffsetLocation, ref RHandNormalDirection, ref RHandPrevFrameAlpha);
																																Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
																																Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(nativeObjectPtr2);
																																ptr = null;
																																ptr3 = null;
																																ptr5 = null;
																																ptr7 = null;
																																ptr9 = null;
																																ptr11 = null;
																																ptr13 = null;
																																ptr15 = null;
																																ptr17 = null;
																																ptr19 = null;
																																ptr21 = null;
																																ptr23 = null;
																																ptr25 = null;
																																ptr27 = null;
																																ptr29 = null;
																																ptr31 = null;
																																ptr33 = null;
																																ptr35 = null;
																																ptr37 = null;
																																ptr39 = null;
																																ptr41 = null;
																																ptr43 = null;
																																ptr45 = null;
																																ptr47 = null;
																																ptr49 = null;
																																ptr51 = null;
																																ptr53 = null;
																																ptr55 = null;
																															}
																														}
																													}
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014951 RID: 84305 RVA: 0x001E4C15 File Offset: 0x001E2E15
		public void UpdateCharacterVar()
		{
			UKuroAnimInstance.__UpdateCharacterVar_Internal(base.NativePtr);
		}

		// Token: 0x06014952 RID: 84306 RVA: 0x001E4C24 File Offset: 0x001E2E24
		public unsafe void UpdateCameraStateMoveInfo(in FVector Speed, ref ACharacter Character, in FRotator RoleRotator, in FVector Acceleration, ref float RotatorMixed, in float DeltaTime, ref FVector RelativeAcceleration, ref FLeanAmount LeanAmount, in float GroundLeanAmountLerpSpeed, in FRotator AimRotator, ref float AimAngle)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &RotatorMixed)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &DeltaTime)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &RelativeAcceleration)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &GroundLeanAmountLerpSpeed)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &AimAngle)
							{
								void* ptr10 = (void*)ptr9;
								UKuroAnimInstance.__UpdateCameraStateMoveInfo_Internal(base.NativePtr, Speed, ref nativeObjectPtr, RoleRotator, Acceleration, ref RotatorMixed, DeltaTime, ref RelativeAcceleration, (LeanAmount ?? new FLeanAmount()).NativePtr, GroundLeanAmountLerpSpeed, AimRotator, ref AimAngle);
								Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x06014953 RID: 84307 RVA: 0x001E4CB8 File Offset: 0x001E2EB8
		public void UpdateBooleanVar()
		{
			UKuroAnimInstance.__UpdateBooleanVar_Internal(base.NativePtr);
		}

		// Token: 0x06014954 RID: 84308 RVA: 0x001E4CC5 File Offset: 0x001E2EC5
		public void UpdateBindRoleInfo()
		{
			UKuroAnimInstance.__UpdateBindRoleInfo_Internal(base.NativePtr);
		}

		// Token: 0x06014955 RID: 84309 RVA: 0x001E4CD4 File Offset: 0x001E2ED4
		public unsafe void UpdateBattleIdle(in float BattleIdleTime, ref bool bBattleIdle)
		{
			fixed (float* ptr = &BattleIdleTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bBattleIdle)
				{
					void* ptr4 = (void*)ptr3;
					UKuroAnimInstance.__UpdateBattleIdle_Internal(base.NativePtr, BattleIdleTime, ref bBattleIdle);
					ptr = null;
				}
			}
		}

		// Token: 0x06014956 RID: 84310 RVA: 0x001E4D00 File Offset: 0x001E2F00
		public unsafe void UpdateAdditiveBlendInfo(UAnimInstance AnimInstance, in bool bUsingAdditiveBlend, in bool bUsingWholeBodyBlend, ref float AdditiveBlendAlpha, ref FAdditiveBlendAlpha Pelvis, ref FAdditiveBlendAlpha Spine, ref FAdditiveBlendAlpha Spine1, ref FAdditiveBlendAlpha Spine2, ref FAdditiveBlendAlpha Head, ref FAdditiveBlendAlpha ArmL, ref FAdditiveBlendAlpha ArmR, ref FAdditiveBlendAlpha Leg)
		{
			fixed (bool* ptr = &bUsingAdditiveBlend)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bUsingWholeBodyBlend)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &AdditiveBlendAlpha)
					{
						void* ptr6 = (void*)ptr5;
						UKuroAnimInstance.__UpdateAdditiveBlendInfo_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, bUsingAdditiveBlend, bUsingWholeBodyBlend, ref AdditiveBlendAlpha, (Pelvis ?? new FAdditiveBlendAlpha()).NativePtr, (Spine ?? new FAdditiveBlendAlpha()).NativePtr, (Spine1 ?? new FAdditiveBlendAlpha()).NativePtr, (Spine2 ?? new FAdditiveBlendAlpha()).NativePtr, (Head ?? new FAdditiveBlendAlpha()).NativePtr, (ArmL ?? new FAdditiveBlendAlpha()).NativePtr, (ArmR ?? new FAdditiveBlendAlpha()).NativePtr, (Leg ?? new FAdditiveBlendAlpha()).NativePtr);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x06014957 RID: 84311 RVA: 0x001E4DD3 File Offset: 0x001E2FD3
		public void UpdateABP(float DeltaSeconds)
		{
			UKuroAnimInstance.__UpdateABP_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06014958 RID: 84312 RVA: 0x001E4DE1 File Offset: 0x001E2FE1
		public void UnRegisterActorAndResetInstance()
		{
			UKuroAnimInstance.__UnRegisterActorAndResetInstance_Internal(base.NativePtr);
		}

		// Token: 0x06014959 RID: 84313 RVA: 0x001E4DEE File Offset: 0x001E2FEE
		public void UnfreezeExtraFollow()
		{
			UKuroAnimInstance.__UnfreezeExtraFollow_Internal(base.NativePtr);
		}

		// Token: 0x0601495A RID: 84314 RVA: 0x001E4DFB File Offset: 0x001E2FFB
		public void StartABP()
		{
			UKuroAnimInstance.__StartABP_Internal(base.NativePtr);
		}

		// Token: 0x0601495B RID: 84315 RVA: 0x001E4E08 File Offset: 0x001E3008
		public unsafe void SetFootOffset(in FVector SkeletionAbsoluteLocation, in FVector IKDirection, in float BenchMarkDepth, in float RotationCorrectedDistance, ref ACharacter Character, ref USkeletalMeshComponent Mesh, in bool HasMoveInput, ref bool bNeedIK, ref FVector OffsetLocation, ref FVector NormalDirection, ref FHitResult OutHitResult)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			IntPtr nativeObjectPtr2 = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &BenchMarkDepth)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &RotationCorrectedDistance)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &HasMoveInput)
					{
						void* ptr6 = (void*)ptr5;
						fixed (bool* ptr7 = &bNeedIK)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &OffsetLocation)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &NormalDirection)
								{
									void* ptr12 = (void*)ptr11;
									UKuroAnimInstance.__SetFootOffset_Internal(base.NativePtr, SkeletionAbsoluteLocation, IKDirection, BenchMarkDepth, RotationCorrectedDistance, ref nativeObjectPtr, ref nativeObjectPtr2, HasMoveInput, ref bNeedIK, ref OffsetLocation, ref NormalDirection, (OutHitResult ?? new FHitResult()).NativePtr);
									Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
									Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(nativeObjectPtr2);
									ptr = null;
									ptr3 = null;
									ptr5 = null;
									ptr7 = null;
									ptr9 = null;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601495C RID: 84316 RVA: 0x001E4EC7 File Offset: 0x001E30C7
		public void SetExtraFollowFreeze(bool bFreeze)
		{
			UKuroAnimInstance.__SetExtraFollowFreeze_Internal(base.NativePtr, bFreeze);
		}

		// Token: 0x0601495D RID: 84317 RVA: 0x001E4ED5 File Offset: 0x001E30D5
		public void SetDebugTraceType(EDrawDebugTrace GroundTrace, EDrawDebugTrace ClimbTrace)
		{
			UKuroAnimInstance.__SetDebugTraceType_Internal(base.NativePtr, GroundTrace, ClimbTrace);
		}

		// Token: 0x0601495E RID: 84318 RVA: 0x001E4EEE File Offset: 0x001E30EE
		public void SetBoneRotateToLocationInfoStopEnd()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoStopEnd_Internal(base.NativePtr);
		}

		// Token: 0x0601495F RID: 84319 RVA: 0x001E4EFB File Offset: 0x001E30FB
		public void SetBoneRotateToLocationInfoStopBegin()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoStopBegin_Internal(base.NativePtr);
		}

		// Token: 0x06014960 RID: 84320 RVA: 0x001E4F08 File Offset: 0x001E3108
		public void SetBoneRotateToLocationInfoRunTick(float TurnAngle, float LookUpAngle)
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunTick_Internal(base.NativePtr, TurnAngle, LookUpAngle);
		}

		// Token: 0x06014961 RID: 84321 RVA: 0x001E4F17 File Offset: 0x001E3117
		public void SetBoneRotateToLocationInfoRunEnd()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunEnd_Internal(base.NativePtr);
		}

		// Token: 0x06014962 RID: 84322 RVA: 0x001E4F24 File Offset: 0x001E3124
		public void SetBoneRotateToLocationInfoRunBegin(float TurnAngle, float LookUpAngle, FVector2D TurnLimit, FVector2D LookUpLimit, float TurnOffset, float LookUpOffset)
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunBegin_Internal(base.NativePtr, TurnAngle, LookUpAngle, TurnLimit, LookUpLimit, TurnOffset, LookUpOffset);
		}

		// Token: 0x06014963 RID: 84323 RVA: 0x001E4F3A File Offset: 0x001E313A
		public void SaveExtraFollowSnapshot()
		{
			UKuroAnimInstance.__SaveExtraFollowSnapshot_Internal(base.NativePtr);
		}

		// Token: 0x06014964 RID: 84324 RVA: 0x001E4F47 File Offset: 0x001E3147
		public void ResigterExtraRibbenOwnerAnimInstance(UAnimInstance AnimInstance)
		{
			UKuroAnimInstance.__ResigterExtraRibbenOwnerAnimInstance_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014965 RID: 84325 RVA: 0x001E4F64 File Offset: 0x001E3164
		public void RegisterExtraFollowOwnerAnimInstance(UAnimInstance AnimInstance)
		{
			UKuroAnimInstance.__RegisterExtraFollowOwnerAnimInstance_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014966 RID: 84326 RVA: 0x001E4F81 File Offset: 0x001E3181
		public void RegisterActor(ACharacter Character)
		{
			UKuroAnimInstance.__RegisterActor_Internal(base.NativePtr, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014967 RID: 84327 RVA: 0x001E4F9E File Offset: 0x001E319E
		public virtual void OnComponentStart()
		{
			UKuroAnimInstance.__OnComponentStart_Internal(base.NativePtr);
		}

		// Token: 0x06014968 RID: 84328 RVA: 0x001E4FAB File Offset: 0x001E31AB
		public bool IsSyncGroupBetweenMarkersCoarse(FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder = true)
		{
			return UKuroAnimInstance.__IsSyncGroupBetweenMarkersCoarse_Internal(base.NativePtr, InSyncGroupName, PreviousMarker, NextMarker, bRespectMarkerOrder);
		}

		// Token: 0x06014969 RID: 84329 RVA: 0x001E4FBD File Offset: 0x001E31BD
		public float IsContainExtraRibbonAnims()
		{
			return UKuroAnimInstance.__IsContainExtraRibbonAnims_Internal(base.NativePtr);
		}

		// Token: 0x0601496A RID: 84330 RVA: 0x001E4FCA File Offset: 0x001E31CA
		[return: Nullable(1)]
		public FLeanAmount InterpLeanAmountTo(in FLeanAmount Current, in FLeanAmount Target, float DeltaTime, float InterpSpeed)
		{
			return new FLeanAmount(UKuroAnimInstance.__InterpLeanAmountTo_Internal(base.NativePtr, (Current ?? new FLeanAmount()).NativePtr, (Target ?? new FLeanAmount()).NativePtr, DeltaTime, InterpSpeed), null);
		}

		// Token: 0x0601496B RID: 84331 RVA: 0x001E5000 File Offset: 0x001E3200
		public unsafe void IKInfoLerpProcess(in float DeltaTime, in float HipLerpSpeed, in FRotator QuatInverse, in FVector OverallOffsetLocation, ref FVector OverallOffsetLocationBeUsed, ref FVector LFootOffsetRelativeLocation, ref FVector LFootNormalRelativeDirection, in FVector LFootOffsetLocation, in FVector LFootNormalDirection, ref FVector RFootOffsetRelativeLocation, ref FVector RFootNormalRelativeDirection, in FVector RFootOffsetLocation, in FVector RFootNormalDirection, ref FVector LHandOffsetRelativeLocation, ref FVector LHandNormalRelativeDirection, in FVector LHandOffsetLocation, in FVector LHandNormalDirection, ref FVector RHandOffsetRelativeLocation, ref FVector RHandNormalRelativeDirection, in FVector RHandOffsetLocation, in FVector RHandNormalDirection)
		{
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &HipLerpSpeed)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &OverallOffsetLocationBeUsed)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVector* ptr7 = &LFootOffsetRelativeLocation)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &LFootNormalRelativeDirection)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &RFootOffsetRelativeLocation)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &RFootNormalRelativeDirection)
									{
										void* ptr14 = (void*)ptr13;
										fixed (FVector* ptr15 = &LHandOffsetRelativeLocation)
										{
											void* ptr16 = (void*)ptr15;
											fixed (FVector* ptr17 = &LHandNormalRelativeDirection)
											{
												void* ptr18 = (void*)ptr17;
												fixed (FVector* ptr19 = &RHandOffsetRelativeLocation)
												{
													void* ptr20 = (void*)ptr19;
													fixed (FVector* ptr21 = &RHandNormalRelativeDirection)
													{
														void* ptr22 = (void*)ptr21;
														UKuroAnimInstance.__IKInfoLerpProcess_Internal(base.NativePtr, DeltaTime, HipLerpSpeed, QuatInverse, OverallOffsetLocation, ref OverallOffsetLocationBeUsed, ref LFootOffsetRelativeLocation, ref LFootNormalRelativeDirection, LFootOffsetLocation, LFootNormalDirection, ref RFootOffsetRelativeLocation, ref RFootNormalRelativeDirection, RFootOffsetLocation, RFootNormalDirection, ref LHandOffsetRelativeLocation, ref LHandNormalRelativeDirection, LHandOffsetLocation, LHandNormalDirection, ref RHandOffsetRelativeLocation, ref RHandNormalRelativeDirection, RHandOffsetLocation, RHandNormalDirection);
														ptr = null;
														ptr3 = null;
														ptr5 = null;
														ptr7 = null;
														ptr9 = null;
														ptr11 = null;
														ptr13 = null;
														ptr15 = null;
														ptr17 = null;
														ptr19 = null;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601496C RID: 84332 RVA: 0x001E50C8 File Offset: 0x001E32C8
		public unsafe void GroundIKProcess(in FVector MeshWorldLocation, in float DegMovementSlop, ref ACharacter Character, ref USkeletalMeshComponent Mesh, in bool bUpHill, in bool bDownHill, in float Speed, in bool HasMoveInput, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref FHitResult LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref FHitResult RFootHitResult, bool UseCurveFootLocation)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			IntPtr nativeObjectPtr2 = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &DegMovementSlop)
			{
				void* ptr2 = (void*)ptr;
				fixed (bool* ptr3 = &bUpHill)
				{
					void* ptr4 = (void*)ptr3;
					fixed (bool* ptr5 = &bDownHill)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &Speed)
						{
							void* ptr8 = (void*)ptr7;
							fixed (bool* ptr9 = &HasMoveInput)
							{
								void* ptr10 = (void*)ptr9;
								fixed (bool* ptr11 = &bLFootNeedIK)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &LFootOffsetLocation)
									{
										void* ptr14 = (void*)ptr13;
										fixed (FVector* ptr15 = &LFootNormalDirection)
										{
											void* ptr16 = (void*)ptr15;
											fixed (bool* ptr17 = &bRFootNeedIK)
											{
												void* ptr18 = (void*)ptr17;
												fixed (FVector* ptr19 = &RFootOffsetLocation)
												{
													void* ptr20 = (void*)ptr19;
													fixed (FVector* ptr21 = &RFootNormalDirection)
													{
														void* ptr22 = (void*)ptr21;
														UKuroAnimInstance.__GroundIKProcess_Internal(base.NativePtr, MeshWorldLocation, DegMovementSlop, ref nativeObjectPtr, ref nativeObjectPtr2, bUpHill, bDownHill, Speed, HasMoveInput, ref bLFootNeedIK, ref LFootOffsetLocation, ref LFootNormalDirection, (LFootHitResult ?? new FHitResult()).NativePtr, ref bRFootNeedIK, ref RFootOffsetLocation, ref RFootNormalDirection, (RFootHitResult ?? new FHitResult()).NativePtr, UseCurveFootLocation);
														Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
														Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(nativeObjectPtr2);
														ptr = null;
														ptr3 = null;
														ptr5 = null;
														ptr7 = null;
														ptr9 = null;
														ptr11 = null;
														ptr13 = null;
														ptr15 = null;
														ptr17 = null;
														ptr19 = null;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0601496D RID: 84333 RVA: 0x001E51E2 File Offset: 0x001E33E2
		[NullableContext(1)]
		public string GetStateMachineCurrentStatesString()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnimInstance.__GetStateMachineCurrentStatesString_Internal(base.NativePtr));
		}

		// Token: 0x0601496E RID: 84334 RVA: 0x001E51F4 File Offset: 0x001E33F4
		[NullableContext(1)]
		public string GetDebugAnimNodeString()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnimInstance.__GetDebugAnimNodeString_Internal(base.NativePtr));
		}

		// Token: 0x0601496F RID: 84335 RVA: 0x001E5208 File Offset: 0x001E3408
		public unsafe void FreezeExtraFollowAtWorldTransform(in FTransform WorldTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = WorldTransform;
			UKuroAnimInstance.__FreezeExtraFollowAtWorldTransform_Internal(base.NativePtr, ptr);
		}

		// Token: 0x06014970 RID: 84336 RVA: 0x001E5240 File Offset: 0x001E3440
		public unsafe void ClimbIKProcess(UAnimInstance AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, in bool IsClimbExitState, ref FVector OverallOffsetLocation, ref float ClimbIK, ref ACharacter Character, ref USkeletalMeshComponent Mesh, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			USkeletalMeshComponent uskeletalMeshComponent = Mesh;
			IntPtr nativeObjectPtr2 = (uskeletalMeshComponent != null) ? uskeletalMeshComponent.NativePtr : IntPtr.Zero;
			fixed (bool* ptr = &IsClimbExitState)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &OverallOffsetLocation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &ClimbIK)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &ClimbRadius)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &LFootCachedLocation)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &LFootCachedNormal)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &LFootOffsetLocation)
									{
										void* ptr14 = (void*)ptr13;
										fixed (FVector* ptr15 = &LFootNormalDirection)
										{
											void* ptr16 = (void*)ptr15;
											fixed (float* ptr17 = &LFootPrevFrameAlpha)
											{
												void* ptr18 = (void*)ptr17;
												fixed (FVector* ptr19 = &RFootCachedLocation)
												{
													void* ptr20 = (void*)ptr19;
													fixed (FVector* ptr21 = &RFootCachedNormal)
													{
														void* ptr22 = (void*)ptr21;
														fixed (FVector* ptr23 = &RFootOffsetLocation)
														{
															void* ptr24 = (void*)ptr23;
															fixed (FVector* ptr25 = &RFootNormalDirection)
															{
																void* ptr26 = (void*)ptr25;
																fixed (float* ptr27 = &RFootPrevFrameAlpha)
																{
																	void* ptr28 = (void*)ptr27;
																	fixed (FVector* ptr29 = &LHandCachedLocation)
																	{
																		void* ptr30 = (void*)ptr29;
																		fixed (FVector* ptr31 = &LHandCachedNormal)
																		{
																			void* ptr32 = (void*)ptr31;
																			fixed (FVector* ptr33 = &LHandOffsetLocation)
																			{
																				void* ptr34 = (void*)ptr33;
																				fixed (FVector* ptr35 = &LHandNormalDirection)
																				{
																					void* ptr36 = (void*)ptr35;
																					fixed (float* ptr37 = &LHandPrevFrameAlpha)
																					{
																						void* ptr38 = (void*)ptr37;
																						fixed (FVector* ptr39 = &RHandCachedLocation)
																						{
																							void* ptr40 = (void*)ptr39;
																							fixed (FVector* ptr41 = &RHandCachedNormal)
																							{
																								void* ptr42 = (void*)ptr41;
																								fixed (FVector* ptr43 = &RHandOffsetLocation)
																								{
																									void* ptr44 = (void*)ptr43;
																									fixed (FVector* ptr45 = &RHandNormalDirection)
																									{
																										void* ptr46 = (void*)ptr45;
																										fixed (float* ptr47 = &RHandPrevFrameAlpha)
																										{
																											void* ptr48 = (void*)ptr47;
																											UKuroAnimInstance.__ClimbIKProcess_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero, MeshWorldLocation, QuatInverse, IsClimbExitState, ref OverallOffsetLocation, ref ClimbIK, ref nativeObjectPtr, ref nativeObjectPtr2, ClimbRadius, LFootOffsetRelativeLocation, ref LFootCachedLocation, ref LFootCachedNormal, ref LFootOffsetLocation, ref LFootNormalDirection, ref LFootPrevFrameAlpha, RFootOffsetRelativeLocation, ref RFootCachedLocation, ref RFootCachedNormal, ref RFootOffsetLocation, ref RFootNormalDirection, ref RFootPrevFrameAlpha, LHandOffsetRelativeLocation, ref LHandCachedLocation, ref LHandCachedNormal, ref LHandOffsetLocation, ref LHandNormalDirection, ref LHandPrevFrameAlpha, RHandOffsetRelativeLocation, ref RHandCachedLocation, ref RHandCachedNormal, ref RHandOffsetLocation, ref RHandNormalDirection, ref RHandPrevFrameAlpha);
																											Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
																											Mesh = BuiltinUtils.GetOrCreateUObjectByNativePointer<USkeletalMeshComponent>(nativeObjectPtr2);
																											ptr = null;
																											ptr3 = null;
																											ptr5 = null;
																											ptr7 = null;
																											ptr9 = null;
																											ptr11 = null;
																											ptr13 = null;
																											ptr15 = null;
																											ptr17 = null;
																											ptr19 = null;
																											ptr21 = null;
																											ptr23 = null;
																											ptr25 = null;
																											ptr27 = null;
																											ptr29 = null;
																											ptr31 = null;
																											ptr33 = null;
																											ptr35 = null;
																											ptr37 = null;
																											ptr39 = null;
																											ptr41 = null;
																											ptr43 = null;
																											ptr45 = null;
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014971 RID: 84337 RVA: 0x001E5418 File Offset: 0x001E3618
		public unsafe void CalucateClimbOffset(ref ACharacter Character, in FVector IKDirection, in FVector OffsetRelativeLocation, in FVector BoneLocation, float OffsetCorrection, float TraceRadius, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector CachedLocation, ref FVector CachedNormal, in float IKCurveValue, in float ClimbRadius, ref float PrevFrameAlpha, ref FVector OutOffset, ref FVector OutNormal, ref bool bSuccess)
		{
			ACharacter acharacter = Character;
			IntPtr nativeObjectPtr = (acharacter != null) ? acharacter.NativePtr : IntPtr.Zero;
			fixed (FVector* ptr = &CachedLocation)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &CachedNormal)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &IKCurveValue)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &ClimbRadius)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &PrevFrameAlpha)
							{
								void* ptr10 = (void*)ptr9;
								fixed (FVector* ptr11 = &OutOffset)
								{
									void* ptr12 = (void*)ptr11;
									fixed (FVector* ptr13 = &OutNormal)
									{
										void* ptr14 = (void*)ptr13;
										fixed (bool* ptr15 = &bSuccess)
										{
											void* ptr16 = (void*)ptr15;
											UKuroAnimInstance.__CalucateClimbOffset_Internal(base.NativePtr, ref nativeObjectPtr, IKDirection, OffsetRelativeLocation, BoneLocation, OffsetCorrection, TraceRadius, MeshWorldLocation, QuatInverse, ref CachedLocation, ref CachedNormal, IKCurveValue, ClimbRadius, ref PrevFrameAlpha, ref OutOffset, ref OutNormal, ref bSuccess);
											Character = BuiltinUtils.GetOrCreateUObjectByNativePointer<ACharacter>(nativeObjectPtr);
											ptr = null;
											ptr3 = null;
											ptr5 = null;
											ptr7 = null;
											ptr9 = null;
											ptr11 = null;
											ptr13 = null;
										}
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014972 RID: 84338 RVA: 0x001E54D0 File Offset: 0x001E36D0
		public unsafe float CalculateWalkRunMixed(in int MoveState)
		{
			fixed (int* ptr = &MoveState)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimInstance.__CalculateWalkRunMixed_Internal(base.NativePtr, MoveState);
			}
		}

		// Token: 0x06014973 RID: 84339 RVA: 0x001E54F0 File Offset: 0x001E36F0
		public unsafe float CalculateStepLengthMixed(ACharacter Character, ref UCurveFloat AngleToStepLength, ref UCurveFloat WalkCurve, ref UCurveFloat RunCurve, in float Speed, in float Slop)
		{
			UCurveFloat ucurveFloat = AngleToStepLength;
			IntPtr nativeObjectPtr = (ucurveFloat != null) ? ucurveFloat.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat2 = WalkCurve;
			IntPtr nativeObjectPtr2 = (ucurveFloat2 != null) ? ucurveFloat2.NativePtr : IntPtr.Zero;
			UCurveFloat ucurveFloat3 = RunCurve;
			IntPtr nativeObjectPtr3 = (ucurveFloat3 != null) ? ucurveFloat3.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &Speed)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Slop)
				{
					void* ptr4 = (void*)ptr3;
					float result = UKuroAnimInstance.__CalculateStepLengthMixed_Internal(base.NativePtr, (Character != null) ? Character.NativePtr : IntPtr.Zero, ref nativeObjectPtr, ref nativeObjectPtr2, ref nativeObjectPtr3, Speed, Slop);
					AngleToStepLength = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr);
					WalkCurve = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr2);
					RunCurve = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr3);
					return result;
				}
			}
		}

		// Token: 0x06014974 RID: 84340 RVA: 0x001E5588 File Offset: 0x001E3788
		public unsafe float CalculateStandRate(ref UCurveFloat AngleToStepFrequency, in float Slop, in float Speed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, in float StepLengthMix)
		{
			UCurveFloat ucurveFloat = AngleToStepFrequency;
			IntPtr nativeObjectPtr = (ucurveFloat != null) ? ucurveFloat.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &Slop)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Speed)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &AnimWalkSpeed)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &AnimRunSpeed)
						{
							void* ptr8 = (void*)ptr7;
							fixed (float* ptr9 = &SprintSpeed)
							{
								void* ptr10 = (void*)ptr9;
								fixed (float* ptr11 = &StepLengthMix)
								{
									void* ptr12 = (void*)ptr11;
									float result = UKuroAnimInstance.__CalculateStandRate_Internal(base.NativePtr, ref nativeObjectPtr, Slop, Speed, AnimWalkSpeed, AnimRunSpeed, SprintSpeed, StepLengthMix);
									AngleToStepFrequency = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr);
									return result;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014975 RID: 84341 RVA: 0x001E55F8 File Offset: 0x001E37F8
		public unsafe void CalculateSpeedMixed(in FRotator RoleRotator, in FRotator AdditiveRotator, in FVector Speed, ACharacter Character, ref UCurveFloat Curve, in float DeltaTime, ref float CachedPercentFB, ref float CachedPercentLR, ref FVeloctiyBlend VelocityBlend)
		{
			UCurveFloat ucurveFloat = Curve;
			IntPtr nativeObjectPtr = (ucurveFloat != null) ? ucurveFloat.NativePtr : IntPtr.Zero;
			fixed (float* ptr = &DeltaTime)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &CachedPercentFB)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &CachedPercentLR)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FVeloctiyBlend* ptr7 = &VelocityBlend)
						{
							void* ptr8 = (void*)ptr7;
							UKuroAnimInstance.__CalculateSpeedMixed_Internal(base.NativePtr, RoleRotator, AdditiveRotator, Speed, (Character != null) ? Character.NativePtr : IntPtr.Zero, ref nativeObjectPtr, DeltaTime, ref CachedPercentFB, ref CachedPercentLR, ref VelocityBlend);
							Curve = BuiltinUtils.GetOrCreateUObjectByNativePointer<UCurveFloat>(nativeObjectPtr);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x06014976 RID: 84342 RVA: 0x001E567D File Offset: 0x001E387D
		public FVector CalculateRelativeAcceleration(in FVector Speed, in FVector Acceleration, in FRotator RoleRotator, ACharacter Character)
		{
			return UKuroAnimInstance.__CalculateRelativeAcceleration_Internal(base.NativePtr, Speed, Acceleration, RoleRotator, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014977 RID: 84343 RVA: 0x001E569F File Offset: 0x001E389F
		public FVector2D CalculateAimMixed(in FVector Speed, in FRotator RoleRotator, ACharacter Character)
		{
			return UKuroAnimInstance.__CalculateAimMixed_Internal(base.NativePtr, Speed, RoleRotator, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06014978 RID: 84344 RVA: 0x001E56C0 File Offset: 0x001E38C0
		public unsafe void BindVarToCharacter(ref FVector VelocityRef, ref FVector ActorForwardVectorRef, ref FRotator ActorRotationRef, ref FRotator ControlRotationRef, ref FVector CurrentAccelerationRef, ref bool bMoveBlockRef)
		{
			fixed (FVector* ptr = &VelocityRef)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &ActorForwardVectorRef)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FRotator* ptr5 = &ActorRotationRef)
					{
						void* ptr6 = (void*)ptr5;
						fixed (FRotator* ptr7 = &ControlRotationRef)
						{
							void* ptr8 = (void*)ptr7;
							fixed (FVector* ptr9 = &CurrentAccelerationRef)
							{
								void* ptr10 = (void*)ptr9;
								fixed (bool* ptr11 = &bMoveBlockRef)
								{
									void* ptr12 = (void*)ptr11;
									UKuroAnimInstance.__BindVarToCharacter_Internal(base.NativePtr, ref VelocityRef, ref ActorForwardVectorRef, ref ActorRotationRef, ref ControlRotationRef, ref CurrentAccelerationRef, ref bMoveBlockRef);
									ptr = null;
									ptr3 = null;
									ptr5 = null;
									ptr7 = null;
									ptr9 = null;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06014979 RID: 84345 RVA: 0x001E5728 File Offset: 0x001E3928
		public void BindEnumToRoleAnimInstance(UObject Component)
		{
			UKuroAnimInstance.__BindEnumToRoleAnimInstance_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601497A RID: 84346 RVA: 0x001E5748 File Offset: 0x001E3948
		[NullableContext(1)]
		public unsafe void BindComponentVarToAnimInstance([Nullable(2)] UObject Component, string ComponentVarName, string InstanceVarName)
		{
			FString fstring = FString.AllocTemp(ComponentVarName);
			FString fstring2 = FString.AllocTemp(InstanceVarName);
			UKuroAnimInstance.__BindComponentVarToAnimInstance_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601497B RID: 84347 RVA: 0x001E5794 File Offset: 0x001E3994
		public unsafe void BindBooleanVarToTag(ref bool BooleanVarRef, FGameplayTag Tag)
		{
			fixed (bool* ptr = &BooleanVarRef)
			{
				void* ptr2 = (void*)ptr;
				UKuroAnimInstance.__BindBooleanVarToTag_Internal(base.NativePtr, ref BooleanVarRef, Tag);
			}
		}

		// Token: 0x0601497C RID: 84348 RVA: 0x001E57B8 File Offset: 0x001E39B8
		public unsafe void BindBooleanVarToActorTag(ref bool BooleanVarRef, FName Tag)
		{
			fixed (bool* ptr = &BooleanVarRef)
			{
				void* ptr2 = (void*)ptr;
				UKuroAnimInstance.__BindBooleanVarToActorTag_Internal(base.NativePtr, ref BooleanVarRef, Tag);
			}
		}

		// Token: 0x0601497D RID: 84349 RVA: 0x001E57DC File Offset: 0x001E39DC
		public unsafe float AngleConversion(in float Angle)
		{
			fixed (float* ptr = &Angle)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimInstance.__AngleConversion_Internal(base.NativePtr, Angle);
			}
		}

		// Token: 0x0601497E RID: 84350
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateSkillMoveInfo_Internal(IntPtr @this, in float DeltaTime, in FRotator RoleRotator, in FVector Speed, ref IntPtr Character, ref float RotatorMixed, in FVector Acceleration, ref FVector RelativeAcceleration, IntPtr LeanAmount, in float GroundLeanAmountLerpSpeed, in FRotator AimRotator, ref float AimAngle, ref FVector2D AimMoveMixed, in float RotatorSpeed, IntPtr SkillTarget, in FVectorDouble CachedActorLocation);

		// Token: 0x0601497F RID: 84351
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateRoleInfo_Internal(IntPtr @this, ref bool StateGround, ref bool StateGroundSprint, ref bool StateGroundWalk, ref bool StateGroundRun, ref bool StateRunStop, ref bool StateSprintStop, ref bool StateWalkStop, ref bool RunStop, ref bool StateClimb, ref bool StateAir, ref bool StateAirGlide, ref bool StateWater, ref bool StateView, ref bool StateAim, ref bool StateFace);

		// Token: 0x06014980 RID: 84352
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMoveInfoMixed_Internal(IntPtr @this, ref IntPtr Character, ref float WalkRunMixed, in float DeltaTime, in float Slop, ref IntPtr AngleToStepFrequency, ref IntPtr AngleToStepLength, ref IntPtr WalkCurve, ref IntPtr RunCurve, in float SpeedSize, ref float StepLengthMixed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, ref float StandRate);

		// Token: 0x06014981 RID: 84353
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKInfoLocalValue_Internal(IntPtr @this, IntPtr Character, ref FRotator MeshQuatInverse, ref FVector MeshWorldLocation);

		// Token: 0x06014982 RID: 84354
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKinfoInOtherState_Internal(IntPtr @this, ref IntPtr Character, ref FVector OverallOffsetLocation, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref FVector LHandNormalDirection, ref FVector RHandNormalDirection, ref float HipLerpSpeed);

		// Token: 0x06014983 RID: 84355
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKInfoInGroundState_Internal(IntPtr @this, in bool HasWallForward, in FVector MeshWorldLocation, in bool IsMoving, in float DegMovementSlop, ref bool bUpHill, ref bool bDownHill, ref IntPtr Character, ref IntPtr Mesh, in float Speed, in bool HasMoveInput, in float RunWalkMix, ref FVector OverallOffsetLocation, ref float HipLerpSpeed, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, IntPtr LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, IntPtr RFootHitResult, bool UseCurveFootLocation);

		// Token: 0x06014984 RID: 84356
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKinfoInClimbState_Internal(IntPtr @this, IntPtr AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector OverallOffsetLocation, ref float ClimbIK, in float FastClimbDirection, in bool IsFastClimbState, ref IntPtr Character, ref IntPtr Mesh, ref float HipLerpSpeed, in float Speed, in bool HasMoveInput, in bool IsClimbExitState, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha);

		// Token: 0x06014985 RID: 84357
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharacterVar_Internal(IntPtr @this);

		// Token: 0x06014986 RID: 84358
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCameraStateMoveInfo_Internal(IntPtr @this, in FVector Speed, ref IntPtr Character, in FRotator RoleRotator, in FVector Acceleration, ref float RotatorMixed, in float DeltaTime, ref FVector RelativeAcceleration, IntPtr LeanAmount, in float GroundLeanAmountLerpSpeed, in FRotator AimRotator, ref float AimAngle);

		// Token: 0x06014987 RID: 84359
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBooleanVar_Internal(IntPtr @this);

		// Token: 0x06014988 RID: 84360
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBindRoleInfo_Internal(IntPtr @this);

		// Token: 0x06014989 RID: 84361
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBattleIdle_Internal(IntPtr @this, in float BattleIdleTime, ref bool bBattleIdle);

		// Token: 0x0601498A RID: 84362
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateAdditiveBlendInfo_Internal(IntPtr @this, IntPtr AnimInstance, in bool bUsingAdditiveBlend, in bool bUsingWholeBodyBlend, ref float AdditiveBlendAlpha, IntPtr Pelvis, IntPtr Spine, IntPtr Spine1, IntPtr Spine2, IntPtr Head, IntPtr ArmL, IntPtr ArmR, IntPtr Leg);

		// Token: 0x0601498B RID: 84363
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateABP_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601498C RID: 84364
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterActorAndResetInstance_Internal(IntPtr @this);

		// Token: 0x0601498D RID: 84365
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnfreezeExtraFollow_Internal(IntPtr @this);

		// Token: 0x0601498E RID: 84366
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartABP_Internal(IntPtr @this);

		// Token: 0x0601498F RID: 84367
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFootOffset_Internal(IntPtr @this, in FVector SkeletionAbsoluteLocation, in FVector IKDirection, in float BenchMarkDepth, in float RotationCorrectedDistance, ref IntPtr Character, ref IntPtr Mesh, in bool HasMoveInput, ref bool bNeedIK, ref FVector OffsetLocation, ref FVector NormalDirection, IntPtr OutHitResult);

		// Token: 0x06014990 RID: 84368
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExtraFollowFreeze_Internal(IntPtr @this, bool bFreeze);

		// Token: 0x06014991 RID: 84369
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugTraceType_Internal(IntPtr @this, TEnumAsByte<EDrawDebugTrace> GroundTrace, TEnumAsByte<EDrawDebugTrace> ClimbTrace);

		// Token: 0x06014992 RID: 84370
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoStopEnd_Internal(IntPtr @this);

		// Token: 0x06014993 RID: 84371
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoStopBegin_Internal(IntPtr @this);

		// Token: 0x06014994 RID: 84372
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunTick_Internal(IntPtr @this, float TurnAngle, float LookUpAngle);

		// Token: 0x06014995 RID: 84373
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunEnd_Internal(IntPtr @this);

		// Token: 0x06014996 RID: 84374
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunBegin_Internal(IntPtr @this, float TurnAngle, float LookUpAngle, FVector2D TurnLimit, FVector2D LookUpLimit, float TurnOffset, float LookUpOffset);

		// Token: 0x06014997 RID: 84375
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveExtraFollowSnapshot_Internal(IntPtr @this);

		// Token: 0x06014998 RID: 84376
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResigterExtraRibbenOwnerAnimInstance_Internal(IntPtr @this, IntPtr AnimInstance);

		// Token: 0x06014999 RID: 84377
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterExtraFollowOwnerAnimInstance_Internal(IntPtr @this, IntPtr AnimInstance);

		// Token: 0x0601499A RID: 84378
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterActor_Internal(IntPtr @this, IntPtr Character);

		// Token: 0x0601499B RID: 84379
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentStart_Internal(IntPtr @this);

		// Token: 0x0601499C RID: 84380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSyncGroupBetweenMarkersCoarse_Internal(IntPtr @this, FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder);

		// Token: 0x0601499D RID: 84381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __IsContainExtraRibbonAnims_Internal(IntPtr @this);

		// Token: 0x0601499E RID: 84382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InterpLeanAmountTo_Internal(IntPtr @this, IntPtr Current, IntPtr Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0601499F RID: 84383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IKInfoLerpProcess_Internal(IntPtr @this, in float DeltaTime, in float HipLerpSpeed, in FRotator QuatInverse, in FVector OverallOffsetLocation, ref FVector OverallOffsetLocationBeUsed, ref FVector LFootOffsetRelativeLocation, ref FVector LFootNormalRelativeDirection, in FVector LFootOffsetLocation, in FVector LFootNormalDirection, ref FVector RFootOffsetRelativeLocation, ref FVector RFootNormalRelativeDirection, in FVector RFootOffsetLocation, in FVector RFootNormalDirection, ref FVector LHandOffsetRelativeLocation, ref FVector LHandNormalRelativeDirection, in FVector LHandOffsetLocation, in FVector LHandNormalDirection, ref FVector RHandOffsetRelativeLocation, ref FVector RHandNormalRelativeDirection, in FVector RHandOffsetLocation, in FVector RHandNormalDirection);

		// Token: 0x060149A0 RID: 84384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GroundIKProcess_Internal(IntPtr @this, in FVector MeshWorldLocation, in float DegMovementSlop, ref IntPtr Character, ref IntPtr Mesh, in bool bUpHill, in bool bDownHill, in float Speed, in bool HasMoveInput, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, IntPtr LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, IntPtr RFootHitResult, bool UseCurveFootLocation);

		// Token: 0x060149A1 RID: 84385
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStateMachineCurrentStatesString_Internal(IntPtr @this);

		// Token: 0x060149A2 RID: 84386
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugAnimNodeString_Internal(IntPtr @this);

		// Token: 0x060149A3 RID: 84387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeExtraFollowAtWorldTransform_Internal(IntPtr @this, in FTransform WorldTransform);

		// Token: 0x060149A4 RID: 84388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClimbIKProcess_Internal(IntPtr @this, IntPtr AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, in bool IsClimbExitState, ref FVector OverallOffsetLocation, ref float ClimbIK, ref IntPtr Character, ref IntPtr Mesh, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha);

		// Token: 0x060149A5 RID: 84389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalucateClimbOffset_Internal(IntPtr @this, ref IntPtr Character, in FVector IKDirection, in FVector OffsetRelativeLocation, in FVector BoneLocation, float OffsetCorrection, float TraceRadius, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector CachedLocation, ref FVector CachedNormal, in float IKCurveValue, in float ClimbRadius, ref float PrevFrameAlpha, ref FVector OutOffset, ref FVector OutNormal, ref bool bSuccess);

		// Token: 0x060149A6 RID: 84390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateWalkRunMixed_Internal(IntPtr @this, in int MoveState);

		// Token: 0x060149A7 RID: 84391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateStepLengthMixed_Internal(IntPtr @this, IntPtr Character, ref IntPtr AngleToStepLength, ref IntPtr WalkCurve, ref IntPtr RunCurve, in float Speed, in float Slop);

		// Token: 0x060149A8 RID: 84392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateStandRate_Internal(IntPtr @this, ref IntPtr AngleToStepFrequency, in float Slop, in float Speed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, in float StepLengthMix);

		// Token: 0x060149A9 RID: 84393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateSpeedMixed_Internal(IntPtr @this, in FRotator RoleRotator, in FRotator AdditiveRotator, in FVector Speed, IntPtr Character, ref IntPtr Curve, in float DeltaTime, ref float CachedPercentFB, ref float CachedPercentLR, ref FVeloctiyBlend VelocityBlend);

		// Token: 0x060149AA RID: 84394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CalculateRelativeAcceleration_Internal(IntPtr @this, in FVector Speed, in FVector Acceleration, in FRotator RoleRotator, IntPtr Character);

		// Token: 0x060149AB RID: 84395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __CalculateAimMixed_Internal(IntPtr @this, in FVector Speed, in FRotator RoleRotator, IntPtr Character);

		// Token: 0x060149AC RID: 84396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindVarToCharacter_Internal(IntPtr @this, ref FVector VelocityRef, ref FVector ActorForwardVectorRef, ref FRotator ActorRotationRef, ref FRotator ControlRotationRef, ref FVector CurrentAccelerationRef, ref bool bMoveBlockRef);

		// Token: 0x060149AD RID: 84397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEnumToRoleAnimInstance_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x060149AE RID: 84398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindComponentVarToAnimInstance_Internal(IntPtr @this, IntPtr Component, in FString ComponentVarName, in FString InstanceVarName);

		// Token: 0x060149AF RID: 84399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBooleanVarToTag_Internal(IntPtr @this, ref bool BooleanVarRef, FGameplayTag Tag);

		// Token: 0x060149B0 RID: 84400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBooleanVarToActorTag_Internal(IntPtr @this, ref bool BooleanVarRef, FName Tag);

		// Token: 0x060149B1 RID: 84401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __AngleConversion_Internal(IntPtr @this, in float Angle);

		// Token: 0x060149B2 RID: 84402 RVA: 0x001E57FA File Offset: 0x001E39FA
		static UKuroAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstance");
		}

		// Token: 0x060149B3 RID: 84403 RVA: 0x001E5808 File Offset: 0x001E3A08
		protected UKuroAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B3BE RID: 46014
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstance";

		// Token: 0x0400B3BF RID: 46015
		private static IntPtr _ClassPtr;

		// Token: 0x0400B3C0 RID: 46016
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B3C1 RID: 46017
		internal static int __PropertyOffset_TurnLimitForBoneRotateAnimNode;

		// Token: 0x0400B3C2 RID: 46018
		internal static int __PropertyOffset_LookUpLimitForBoneRotateAnimNode;

		// Token: 0x0400B3C3 RID: 46019
		internal static int __PropertyOffset_bRollBackToOriginForBoneRotateAnimNode;

		// Token: 0x0400B3C4 RID: 46020
		internal static int __PropertyOffset_bStopForBoneRotateAnimNode;

		// Token: 0x0400B3C5 RID: 46021
		internal static int __PropertyOffset_TurnAngleForBoneRotateAnimNode;

		// Token: 0x0400B3C6 RID: 46022
		internal static int __PropertyOffset_LookUpAngleForBoneRotateAnimNode;

		// Token: 0x0400B3C7 RID: 46023
		internal static int __PropertyOffset_TurnOffsetForBoneRotateAnimNode;

		// Token: 0x0400B3C8 RID: 46024
		internal static int __PropertyOffset_LookUpOffsetForBoneRotateAnimNode;

		// Token: 0x0400B3C9 RID: 46025
		internal static int __PropertyOffset_ExtraRibbonAnims;

		// Token: 0x0400B3CA RID: 46026
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UAnimSequence> _ExtraRibbonAnims;

		// Token: 0x0400B3CB RID: 46027
		internal static int __PropertyOffset_SecondaryExtraFollowAnims;

		// Token: 0x0400B3CC RID: 46028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, FExtraFollowTable> _SecondaryExtraFollowAnims;

		// Token: 0x0400B3CD RID: 46029
		internal static int __PropertyOffset_bExtraFollowFreeze;

		// Token: 0x0400B3CE RID: 46030
		internal static int __PropertyOffset_bRequestSaveExtraFollowSnapshot;

		// Token: 0x0400B3CF RID: 46031
		internal static int __PropertyOffset_ExtraFollowFrozenWorldTransform;

		// Token: 0x0400B3D0 RID: 46032
		internal static int __PropertyOffset_bExtraFollowLockWorldTransform;
	}
}
