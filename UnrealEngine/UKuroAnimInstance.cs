using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002EE RID: 750
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.KuroAnimInstance")]
	[UnrealStructLayout(2576, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2576)]
	public class UKuroAnimInstance : UAnimInstance, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004FE0 RID: 20448 RVA: 0x0006FC6D File Offset: 0x0006DE6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAnimInstance._ClassPtr;
		}

		// Token: 0x06004FE1 RID: 20449 RVA: 0x0006FC7C File Offset: 0x0006DE7C
		public UKuroAnimInstance() : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004FE2 RID: 20450 RVA: 0x0006FCA4 File Offset: 0x0006DEA4
		[NullableContext(1)]
		public UKuroAnimInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAnimInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000F75 RID: 3957
		// (get) Token: 0x06004FE3 RID: 20451 RVA: 0x0006FCD7 File Offset: 0x0006DED7
		// (set) Token: 0x06004FE4 RID: 20452 RVA: 0x0006FCEB File Offset: 0x0006DEEB
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

		// Token: 0x17000F76 RID: 3958
		// (get) Token: 0x06004FE5 RID: 20453 RVA: 0x0006FD00 File Offset: 0x0006DF00
		// (set) Token: 0x06004FE6 RID: 20454 RVA: 0x0006FD14 File Offset: 0x0006DF14
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

		// Token: 0x17000F77 RID: 3959
		// (get) Token: 0x06004FE7 RID: 20455 RVA: 0x0006FD29 File Offset: 0x0006DF29
		// (set) Token: 0x06004FE8 RID: 20456 RVA: 0x0006FD39 File Offset: 0x0006DF39
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

		// Token: 0x17000F78 RID: 3960
		// (get) Token: 0x06004FE9 RID: 20457 RVA: 0x0006FD4A File Offset: 0x0006DF4A
		// (set) Token: 0x06004FEA RID: 20458 RVA: 0x0006FD5A File Offset: 0x0006DF5A
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

		// Token: 0x17000F79 RID: 3961
		// (get) Token: 0x06004FEB RID: 20459 RVA: 0x0006FD6B File Offset: 0x0006DF6B
		// (set) Token: 0x06004FEC RID: 20460 RVA: 0x0006FD7B File Offset: 0x0006DF7B
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

		// Token: 0x17000F7A RID: 3962
		// (get) Token: 0x06004FED RID: 20461 RVA: 0x0006FD8C File Offset: 0x0006DF8C
		// (set) Token: 0x06004FEE RID: 20462 RVA: 0x0006FD9C File Offset: 0x0006DF9C
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

		// Token: 0x17000F7B RID: 3963
		// (get) Token: 0x06004FEF RID: 20463 RVA: 0x0006FDAD File Offset: 0x0006DFAD
		// (set) Token: 0x06004FF0 RID: 20464 RVA: 0x0006FDBD File Offset: 0x0006DFBD
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

		// Token: 0x17000F7C RID: 3964
		// (get) Token: 0x06004FF1 RID: 20465 RVA: 0x0006FDCE File Offset: 0x0006DFCE
		// (set) Token: 0x06004FF2 RID: 20466 RVA: 0x0006FDDE File Offset: 0x0006DFDE
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

		// Token: 0x17000F7D RID: 3965
		// (get) Token: 0x06004FF3 RID: 20467 RVA: 0x0006FDF0 File Offset: 0x0006DFF0
		// (set) Token: 0x06004FF4 RID: 20468 RVA: 0x0006FE29 File Offset: 0x0006E029
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

		// Token: 0x17000F7E RID: 3966
		// (get) Token: 0x06004FF5 RID: 20469 RVA: 0x0006FE37 File Offset: 0x0006E037
		// (set) Token: 0x06004FF6 RID: 20470 RVA: 0x0006FE47 File Offset: 0x0006E047
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

		// Token: 0x17000F7F RID: 3967
		// (get) Token: 0x06004FF7 RID: 20471 RVA: 0x0006FE58 File Offset: 0x0006E058
		// (set) Token: 0x06004FF8 RID: 20472 RVA: 0x0006FE68 File Offset: 0x0006E068
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

		// Token: 0x17000F80 RID: 3968
		// (get) Token: 0x06004FF9 RID: 20473 RVA: 0x0006FE79 File Offset: 0x0006E079
		// (set) Token: 0x06004FFA RID: 20474 RVA: 0x0006FE8D File Offset: 0x0006E08D
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

		// Token: 0x17000F81 RID: 3969
		// (get) Token: 0x06004FFB RID: 20475 RVA: 0x0006FEA2 File Offset: 0x0006E0A2
		// (set) Token: 0x06004FFC RID: 20476 RVA: 0x0006FEB2 File Offset: 0x0006E0B2
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

		// Token: 0x06004FFD RID: 20477 RVA: 0x0006FEC4 File Offset: 0x0006E0C4
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

		// Token: 0x06004FFE RID: 20478 RVA: 0x0006FFB4 File Offset: 0x0006E1B4
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

		// Token: 0x06004FFF RID: 20479 RVA: 0x000700EC File Offset: 0x0006E2EC
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

		// Token: 0x06005000 RID: 20480 RVA: 0x00070128 File Offset: 0x0006E328
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

		// Token: 0x06005001 RID: 20481 RVA: 0x000701D0 File Offset: 0x0006E3D0
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

		// Token: 0x06005002 RID: 20482 RVA: 0x00070338 File Offset: 0x0006E538
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

		// Token: 0x06005003 RID: 20483 RVA: 0x00070559 File Offset: 0x0006E759
		public void UpdateCharacterVar()
		{
			UKuroAnimInstance.__UpdateCharacterVar_Internal(base.NativePtr);
		}

		// Token: 0x06005004 RID: 20484 RVA: 0x00070566 File Offset: 0x0006E766
		public void UpdateBooleanVar()
		{
			UKuroAnimInstance.__UpdateBooleanVar_Internal(base.NativePtr);
		}

		// Token: 0x06005005 RID: 20485 RVA: 0x00070573 File Offset: 0x0006E773
		public void UpdateBindRoleInfo()
		{
			UKuroAnimInstance.__UpdateBindRoleInfo_Internal(base.NativePtr);
		}

		// Token: 0x06005006 RID: 20486 RVA: 0x00070580 File Offset: 0x0006E780
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

		// Token: 0x06005007 RID: 20487 RVA: 0x000705AA File Offset: 0x0006E7AA
		public void UpdateABP(float DeltaSeconds)
		{
			UKuroAnimInstance.__UpdateABP_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06005008 RID: 20488 RVA: 0x000705B8 File Offset: 0x0006E7B8
		public void UnRegisterActorAndResetInstance()
		{
			UKuroAnimInstance.__UnRegisterActorAndResetInstance_Internal(base.NativePtr);
		}

		// Token: 0x06005009 RID: 20489 RVA: 0x000705C5 File Offset: 0x0006E7C5
		public void UnfreezeExtraFollow()
		{
			UKuroAnimInstance.__UnfreezeExtraFollow_Internal(base.NativePtr);
		}

		// Token: 0x0600500A RID: 20490 RVA: 0x000705D2 File Offset: 0x0006E7D2
		public void StartABP()
		{
			UKuroAnimInstance.__StartABP_Internal(base.NativePtr);
		}

		// Token: 0x0600500B RID: 20491 RVA: 0x000705E0 File Offset: 0x0006E7E0
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

		// Token: 0x0600500C RID: 20492 RVA: 0x0007069F File Offset: 0x0006E89F
		public void SetExtraFollowFreeze(bool bFreeze)
		{
			UKuroAnimInstance.__SetExtraFollowFreeze_Internal(base.NativePtr, bFreeze);
		}

		// Token: 0x0600500D RID: 20493 RVA: 0x000706AD File Offset: 0x0006E8AD
		public void SetDebugTraceType(EDrawDebugTrace GroundTrace, EDrawDebugTrace ClimbTrace)
		{
			UKuroAnimInstance.__SetDebugTraceType_Internal(base.NativePtr, GroundTrace, ClimbTrace);
		}

		// Token: 0x0600500E RID: 20494 RVA: 0x000706C6 File Offset: 0x0006E8C6
		public void SetBoneRotateToLocationInfoStopEnd()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoStopEnd_Internal(base.NativePtr);
		}

		// Token: 0x0600500F RID: 20495 RVA: 0x000706D3 File Offset: 0x0006E8D3
		public void SetBoneRotateToLocationInfoStopBegin()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoStopBegin_Internal(base.NativePtr);
		}

		// Token: 0x06005010 RID: 20496 RVA: 0x000706E0 File Offset: 0x0006E8E0
		public void SetBoneRotateToLocationInfoRunTick(float TurnAngle, float LookUpAngle)
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunTick_Internal(base.NativePtr, TurnAngle, LookUpAngle);
		}

		// Token: 0x06005011 RID: 20497 RVA: 0x000706EF File Offset: 0x0006E8EF
		public void SetBoneRotateToLocationInfoRunEnd()
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunEnd_Internal(base.NativePtr);
		}

		// Token: 0x06005012 RID: 20498 RVA: 0x000706FC File Offset: 0x0006E8FC
		public void SetBoneRotateToLocationInfoRunBegin(float TurnAngle, float LookUpAngle, FVector2D TurnLimit, FVector2D LookUpLimit, float TurnOffset, float LookUpOffset)
		{
			UKuroAnimInstance.__SetBoneRotateToLocationInfoRunBegin_Internal(base.NativePtr, TurnAngle, LookUpAngle, TurnLimit, LookUpLimit, TurnOffset, LookUpOffset);
		}

		// Token: 0x06005013 RID: 20499 RVA: 0x00070712 File Offset: 0x0006E912
		public void SaveExtraFollowSnapshot()
		{
			UKuroAnimInstance.__SaveExtraFollowSnapshot_Internal(base.NativePtr);
		}

		// Token: 0x06005014 RID: 20500 RVA: 0x0007071F File Offset: 0x0006E91F
		public void ResigterExtraRibbenOwnerAnimInstance(UAnimInstance AnimInstance)
		{
			UKuroAnimInstance.__ResigterExtraRibbenOwnerAnimInstance_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005015 RID: 20501 RVA: 0x0007073C File Offset: 0x0006E93C
		public void RegisterExtraFollowOwnerAnimInstance(UAnimInstance AnimInstance)
		{
			UKuroAnimInstance.__RegisterExtraFollowOwnerAnimInstance_Internal(base.NativePtr, (AnimInstance != null) ? AnimInstance.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005016 RID: 20502 RVA: 0x00070759 File Offset: 0x0006E959
		public void RegisterActor(ACharacter Character)
		{
			UKuroAnimInstance.__RegisterActor_Internal(base.NativePtr, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005017 RID: 20503 RVA: 0x00070776 File Offset: 0x0006E976
		public virtual void OnComponentStart()
		{
			UKuroAnimInstance.__OnComponentStart_Internal(base.NativePtr);
		}

		// Token: 0x06005018 RID: 20504 RVA: 0x00070783 File Offset: 0x0006E983
		public bool IsSyncGroupBetweenMarkersCoarse(FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder = true)
		{
			return UKuroAnimInstance.__IsSyncGroupBetweenMarkersCoarse_Internal(base.NativePtr, InSyncGroupName, PreviousMarker, NextMarker, bRespectMarkerOrder);
		}

		// Token: 0x06005019 RID: 20505 RVA: 0x00070795 File Offset: 0x0006E995
		public float IsContainExtraRibbonAnims()
		{
			return UKuroAnimInstance.__IsContainExtraRibbonAnims_Internal(base.NativePtr);
		}

		// Token: 0x0600501A RID: 20506 RVA: 0x000707A4 File Offset: 0x0006E9A4
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

		// Token: 0x0600501B RID: 20507 RVA: 0x0007086C File Offset: 0x0006EA6C
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

		// Token: 0x0600501C RID: 20508 RVA: 0x00070986 File Offset: 0x0006EB86
		[NullableContext(1)]
		public string GetStateMachineCurrentStatesString()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnimInstance.__GetStateMachineCurrentStatesString_Internal(base.NativePtr));
		}

		// Token: 0x0600501D RID: 20509 RVA: 0x00070998 File Offset: 0x0006EB98
		[NullableContext(1)]
		public string GetDebugAnimNodeString()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroAnimInstance.__GetDebugAnimNodeString_Internal(base.NativePtr));
		}

		// Token: 0x0600501E RID: 20510 RVA: 0x000709AC File Offset: 0x0006EBAC
		public unsafe void FreezeExtraFollowAtWorldTransform(in FTransform WorldTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = WorldTransform;
			UKuroAnimInstance.__FreezeExtraFollowAtWorldTransform_Internal(base.NativePtr, ptr);
		}

		// Token: 0x0600501F RID: 20511 RVA: 0x000709E4 File Offset: 0x0006EBE4
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

		// Token: 0x06005020 RID: 20512 RVA: 0x00070BBC File Offset: 0x0006EDBC
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

		// Token: 0x06005021 RID: 20513 RVA: 0x00070C74 File Offset: 0x0006EE74
		public unsafe float CalculateWalkRunMixed(in int MoveState)
		{
			fixed (int* ptr = &MoveState)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimInstance.__CalculateWalkRunMixed_Internal(base.NativePtr, MoveState);
			}
		}

		// Token: 0x06005022 RID: 20514 RVA: 0x00070C94 File Offset: 0x0006EE94
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

		// Token: 0x06005023 RID: 20515 RVA: 0x00070D2C File Offset: 0x0006EF2C
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

		// Token: 0x06005024 RID: 20516 RVA: 0x00070D9C File Offset: 0x0006EF9C
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

		// Token: 0x06005025 RID: 20517 RVA: 0x00070E21 File Offset: 0x0006F021
		public FVector CalculateRelativeAcceleration(in FVector Speed, in FVector Acceleration, in FRotator RoleRotator, ACharacter Character)
		{
			return UKuroAnimInstance.__CalculateRelativeAcceleration_Internal(base.NativePtr, Speed, Acceleration, RoleRotator, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005026 RID: 20518 RVA: 0x00070E43 File Offset: 0x0006F043
		public FVector2D CalculateAimMixed(in FVector Speed, in FRotator RoleRotator, ACharacter Character)
		{
			return UKuroAnimInstance.__CalculateAimMixed_Internal(base.NativePtr, Speed, RoleRotator, (Character != null) ? Character.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005027 RID: 20519 RVA: 0x00070E64 File Offset: 0x0006F064
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

		// Token: 0x06005028 RID: 20520 RVA: 0x00070ECC File Offset: 0x0006F0CC
		public void BindEnumToRoleAnimInstance(UObject Component)
		{
			UKuroAnimInstance.__BindEnumToRoleAnimInstance_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06005029 RID: 20521 RVA: 0x00070EEC File Offset: 0x0006F0EC
		[NullableContext(1)]
		public unsafe void BindComponentVarToAnimInstance([Nullable(2)] UObject Component, string ComponentVarName, string InstanceVarName)
		{
			FString fstring = FString.AllocTemp(ComponentVarName);
			FString fstring2 = FString.AllocTemp(InstanceVarName);
			UKuroAnimInstance.__BindComponentVarToAnimInstance_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, fstring, fstring2);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0600502A RID: 20522 RVA: 0x00070F38 File Offset: 0x0006F138
		public unsafe void BindBooleanVarToTag(ref bool BooleanVarRef, FGameplayTag Tag)
		{
			fixed (bool* ptr = &BooleanVarRef)
			{
				void* ptr2 = (void*)ptr;
				UKuroAnimInstance.__BindBooleanVarToTag_Internal(base.NativePtr, ref BooleanVarRef, Tag);
			}
		}

		// Token: 0x0600502B RID: 20523 RVA: 0x00070F5C File Offset: 0x0006F15C
		public unsafe void BindBooleanVarToActorTag(ref bool BooleanVarRef, FName Tag)
		{
			fixed (bool* ptr = &BooleanVarRef)
			{
				void* ptr2 = (void*)ptr;
				UKuroAnimInstance.__BindBooleanVarToActorTag_Internal(base.NativePtr, ref BooleanVarRef, Tag);
			}
		}

		// Token: 0x0600502C RID: 20524 RVA: 0x00070F80 File Offset: 0x0006F180
		public unsafe float AngleConversion(in float Angle)
		{
			fixed (float* ptr = &Angle)
			{
				void* ptr2 = (void*)ptr;
				return UKuroAnimInstance.__AngleConversion_Internal(base.NativePtr, Angle);
			}
		}

		// Token: 0x0600502D RID: 20525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateRoleInfo_Internal(IntPtr @this, ref bool StateGround, ref bool StateGroundSprint, ref bool StateGroundWalk, ref bool StateGroundRun, ref bool StateRunStop, ref bool StateSprintStop, ref bool StateWalkStop, ref bool RunStop, ref bool StateClimb, ref bool StateAir, ref bool StateAirGlide, ref bool StateWater, ref bool StateView, ref bool StateAim, ref bool StateFace);

		// Token: 0x0600502E RID: 20526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMoveInfoMixed_Internal(IntPtr @this, ref IntPtr Character, ref float WalkRunMixed, in float DeltaTime, in float Slop, ref IntPtr AngleToStepFrequency, ref IntPtr AngleToStepLength, ref IntPtr WalkCurve, ref IntPtr RunCurve, in float SpeedSize, ref float StepLengthMixed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, ref float StandRate);

		// Token: 0x0600502F RID: 20527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKInfoLocalValue_Internal(IntPtr @this, IntPtr Character, ref FRotator MeshQuatInverse, ref FVector MeshWorldLocation);

		// Token: 0x06005030 RID: 20528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKinfoInOtherState_Internal(IntPtr @this, ref IntPtr Character, ref FVector OverallOffsetLocation, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref FVector LHandNormalDirection, ref FVector RHandNormalDirection, ref float HipLerpSpeed);

		// Token: 0x06005031 RID: 20529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKInfoInGroundState_Internal(IntPtr @this, in bool HasWallForward, in FVector MeshWorldLocation, in bool IsMoving, in float DegMovementSlop, ref bool bUpHill, ref bool bDownHill, ref IntPtr Character, ref IntPtr Mesh, in float Speed, in bool HasMoveInput, in float RunWalkMix, ref FVector OverallOffsetLocation, ref float HipLerpSpeed, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, IntPtr LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, IntPtr RFootHitResult, bool UseCurveFootLocation);

		// Token: 0x06005032 RID: 20530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateIKinfoInClimbState_Internal(IntPtr @this, IntPtr AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector OverallOffsetLocation, ref float ClimbIK, in float FastClimbDirection, in bool IsFastClimbState, ref IntPtr Character, ref IntPtr Mesh, ref float HipLerpSpeed, in float Speed, in bool HasMoveInput, in bool IsClimbExitState, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha);

		// Token: 0x06005033 RID: 20531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateCharacterVar_Internal(IntPtr @this);

		// Token: 0x06005034 RID: 20532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBooleanVar_Internal(IntPtr @this);

		// Token: 0x06005035 RID: 20533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBindRoleInfo_Internal(IntPtr @this);

		// Token: 0x06005036 RID: 20534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBattleIdle_Internal(IntPtr @this, in float BattleIdleTime, ref bool bBattleIdle);

		// Token: 0x06005037 RID: 20535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateABP_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06005038 RID: 20536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnRegisterActorAndResetInstance_Internal(IntPtr @this);

		// Token: 0x06005039 RID: 20537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnfreezeExtraFollow_Internal(IntPtr @this);

		// Token: 0x0600503A RID: 20538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartABP_Internal(IntPtr @this);

		// Token: 0x0600503B RID: 20539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFootOffset_Internal(IntPtr @this, in FVector SkeletionAbsoluteLocation, in FVector IKDirection, in float BenchMarkDepth, in float RotationCorrectedDistance, ref IntPtr Character, ref IntPtr Mesh, in bool HasMoveInput, ref bool bNeedIK, ref FVector OffsetLocation, ref FVector NormalDirection, IntPtr OutHitResult);

		// Token: 0x0600503C RID: 20540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExtraFollowFreeze_Internal(IntPtr @this, bool bFreeze);

		// Token: 0x0600503D RID: 20541
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDebugTraceType_Internal(IntPtr @this, TEnumAsByte<EDrawDebugTrace> GroundTrace, TEnumAsByte<EDrawDebugTrace> ClimbTrace);

		// Token: 0x0600503E RID: 20542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoStopEnd_Internal(IntPtr @this);

		// Token: 0x0600503F RID: 20543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoStopBegin_Internal(IntPtr @this);

		// Token: 0x06005040 RID: 20544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunTick_Internal(IntPtr @this, float TurnAngle, float LookUpAngle);

		// Token: 0x06005041 RID: 20545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunEnd_Internal(IntPtr @this);

		// Token: 0x06005042 RID: 20546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBoneRotateToLocationInfoRunBegin_Internal(IntPtr @this, float TurnAngle, float LookUpAngle, FVector2D TurnLimit, FVector2D LookUpLimit, float TurnOffset, float LookUpOffset);

		// Token: 0x06005043 RID: 20547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SaveExtraFollowSnapshot_Internal(IntPtr @this);

		// Token: 0x06005044 RID: 20548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResigterExtraRibbenOwnerAnimInstance_Internal(IntPtr @this, IntPtr AnimInstance);

		// Token: 0x06005045 RID: 20549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterExtraFollowOwnerAnimInstance_Internal(IntPtr @this, IntPtr AnimInstance);

		// Token: 0x06005046 RID: 20550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterActor_Internal(IntPtr @this, IntPtr Character);

		// Token: 0x06005047 RID: 20551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnComponentStart_Internal(IntPtr @this);

		// Token: 0x06005048 RID: 20552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsSyncGroupBetweenMarkersCoarse_Internal(IntPtr @this, FName InSyncGroupName, FName PreviousMarker, FName NextMarker, bool bRespectMarkerOrder);

		// Token: 0x06005049 RID: 20553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __IsContainExtraRibbonAnims_Internal(IntPtr @this);

		// Token: 0x0600504A RID: 20554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __IKInfoLerpProcess_Internal(IntPtr @this, in float DeltaTime, in float HipLerpSpeed, in FRotator QuatInverse, in FVector OverallOffsetLocation, ref FVector OverallOffsetLocationBeUsed, ref FVector LFootOffsetRelativeLocation, ref FVector LFootNormalRelativeDirection, in FVector LFootOffsetLocation, in FVector LFootNormalDirection, ref FVector RFootOffsetRelativeLocation, ref FVector RFootNormalRelativeDirection, in FVector RFootOffsetLocation, in FVector RFootNormalDirection, ref FVector LHandOffsetRelativeLocation, ref FVector LHandNormalRelativeDirection, in FVector LHandOffsetLocation, in FVector LHandNormalDirection, ref FVector RHandOffsetRelativeLocation, ref FVector RHandNormalRelativeDirection, in FVector RHandOffsetLocation, in FVector RHandNormalDirection);

		// Token: 0x0600504B RID: 20555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GroundIKProcess_Internal(IntPtr @this, in FVector MeshWorldLocation, in float DegMovementSlop, ref IntPtr Character, ref IntPtr Mesh, in bool bUpHill, in bool bDownHill, in float Speed, in bool HasMoveInput, ref bool bLFootNeedIK, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, IntPtr LFootHitResult, ref bool bRFootNeedIK, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, IntPtr RFootHitResult, bool UseCurveFootLocation);

		// Token: 0x0600504C RID: 20556
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetStateMachineCurrentStatesString_Internal(IntPtr @this);

		// Token: 0x0600504D RID: 20557
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugAnimNodeString_Internal(IntPtr @this);

		// Token: 0x0600504E RID: 20558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FreezeExtraFollowAtWorldTransform_Internal(IntPtr @this, in FTransform WorldTransform);

		// Token: 0x0600504F RID: 20559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClimbIKProcess_Internal(IntPtr @this, IntPtr AnimInstance, in FVector MeshWorldLocation, in FRotator QuatInverse, in bool IsClimbExitState, ref FVector OverallOffsetLocation, ref float ClimbIK, ref IntPtr Character, ref IntPtr Mesh, in float ClimbRadius, in FVector LFootOffsetRelativeLocation, ref FVector LFootCachedLocation, ref FVector LFootCachedNormal, ref FVector LFootOffsetLocation, ref FVector LFootNormalDirection, ref float LFootPrevFrameAlpha, in FVector RFootOffsetRelativeLocation, ref FVector RFootCachedLocation, ref FVector RFootCachedNormal, ref FVector RFootOffsetLocation, ref FVector RFootNormalDirection, ref float RFootPrevFrameAlpha, in FVector LHandOffsetRelativeLocation, ref FVector LHandCachedLocation, ref FVector LHandCachedNormal, ref FVector LHandOffsetLocation, ref FVector LHandNormalDirection, ref float LHandPrevFrameAlpha, in FVector RHandOffsetRelativeLocation, ref FVector RHandCachedLocation, ref FVector RHandCachedNormal, ref FVector RHandOffsetLocation, ref FVector RHandNormalDirection, ref float RHandPrevFrameAlpha);

		// Token: 0x06005050 RID: 20560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalucateClimbOffset_Internal(IntPtr @this, ref IntPtr Character, in FVector IKDirection, in FVector OffsetRelativeLocation, in FVector BoneLocation, float OffsetCorrection, float TraceRadius, in FVector MeshWorldLocation, in FRotator QuatInverse, ref FVector CachedLocation, ref FVector CachedNormal, in float IKCurveValue, in float ClimbRadius, ref float PrevFrameAlpha, ref FVector OutOffset, ref FVector OutNormal, ref bool bSuccess);

		// Token: 0x06005051 RID: 20561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateWalkRunMixed_Internal(IntPtr @this, in int MoveState);

		// Token: 0x06005052 RID: 20562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateStepLengthMixed_Internal(IntPtr @this, IntPtr Character, ref IntPtr AngleToStepLength, ref IntPtr WalkCurve, ref IntPtr RunCurve, in float Speed, in float Slop);

		// Token: 0x06005053 RID: 20563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __CalculateStandRate_Internal(IntPtr @this, ref IntPtr AngleToStepFrequency, in float Slop, in float Speed, in float AnimWalkSpeed, in float AnimRunSpeed, in float SprintSpeed, in float StepLengthMix);

		// Token: 0x06005054 RID: 20564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CalculateSpeedMixed_Internal(IntPtr @this, in FRotator RoleRotator, in FRotator AdditiveRotator, in FVector Speed, IntPtr Character, ref IntPtr Curve, in float DeltaTime, ref float CachedPercentFB, ref float CachedPercentLR, ref FVeloctiyBlend VelocityBlend);

		// Token: 0x06005055 RID: 20565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __CalculateRelativeAcceleration_Internal(IntPtr @this, in FVector Speed, in FVector Acceleration, in FRotator RoleRotator, IntPtr Character);

		// Token: 0x06005056 RID: 20566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __CalculateAimMixed_Internal(IntPtr @this, in FVector Speed, in FRotator RoleRotator, IntPtr Character);

		// Token: 0x06005057 RID: 20567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindVarToCharacter_Internal(IntPtr @this, ref FVector VelocityRef, ref FVector ActorForwardVectorRef, ref FRotator ActorRotationRef, ref FRotator ControlRotationRef, ref FVector CurrentAccelerationRef, ref bool bMoveBlockRef);

		// Token: 0x06005058 RID: 20568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindEnumToRoleAnimInstance_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06005059 RID: 20569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindComponentVarToAnimInstance_Internal(IntPtr @this, IntPtr Component, in FString ComponentVarName, in FString InstanceVarName);

		// Token: 0x0600505A RID: 20570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBooleanVarToTag_Internal(IntPtr @this, ref bool BooleanVarRef, FGameplayTag Tag);

		// Token: 0x0600505B RID: 20571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindBooleanVarToActorTag_Internal(IntPtr @this, ref bool BooleanVarRef, FName Tag);

		// Token: 0x0600505C RID: 20572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __AngleConversion_Internal(IntPtr @this, in float Angle);

		// Token: 0x0600505D RID: 20573 RVA: 0x00070F9E File Offset: 0x0006F19E
		static UKuroAnimInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroAnimInstance");
		}

		// Token: 0x0600505E RID: 20574 RVA: 0x00070FAC File Offset: 0x0006F1AC
		protected UKuroAnimInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002081 RID: 8321
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroAnimInstance";

		// Token: 0x04002082 RID: 8322
		private static IntPtr _ClassPtr;

		// Token: 0x04002083 RID: 8323
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002084 RID: 8324
		internal static int __PropertyOffset_TurnLimitForBoneRotateAnimNode;

		// Token: 0x04002085 RID: 8325
		internal static int __PropertyOffset_LookUpLimitForBoneRotateAnimNode;

		// Token: 0x04002086 RID: 8326
		internal static int __PropertyOffset_bRollBackToOriginForBoneRotateAnimNode;

		// Token: 0x04002087 RID: 8327
		internal static int __PropertyOffset_bStopForBoneRotateAnimNode;

		// Token: 0x04002088 RID: 8328
		internal static int __PropertyOffset_TurnAngleForBoneRotateAnimNode;

		// Token: 0x04002089 RID: 8329
		internal static int __PropertyOffset_LookUpAngleForBoneRotateAnimNode;

		// Token: 0x0400208A RID: 8330
		internal static int __PropertyOffset_TurnOffsetForBoneRotateAnimNode;

		// Token: 0x0400208B RID: 8331
		internal static int __PropertyOffset_LookUpOffsetForBoneRotateAnimNode;

		// Token: 0x0400208C RID: 8332
		internal static int __PropertyOffset_ExtraRibbonAnims;

		// Token: 0x0400208D RID: 8333
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<FName, UAnimSequence> _ExtraRibbonAnims;

		// Token: 0x0400208E RID: 8334
		internal static int __PropertyOffset_bExtraFollowFreeze;

		// Token: 0x0400208F RID: 8335
		internal static int __PropertyOffset_bRequestSaveExtraFollowSnapshot;

		// Token: 0x04002090 RID: 8336
		internal static int __PropertyOffset_ExtraFollowFrozenWorldTransform;

		// Token: 0x04002091 RID: 8337
		internal static int __PropertyOffset_bExtraFollowLockWorldTransform;
	}
}
