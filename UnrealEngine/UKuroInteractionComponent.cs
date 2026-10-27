using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B27 RID: 6951
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionComponent")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKuroInteractionComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601A342 RID: 107330 RVA: 0x0026AFEA File Offset: 0x002691EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInteractionComponent._ClassPtr;
		}

		// Token: 0x0601A343 RID: 107331 RVA: 0x0026AFF8 File Offset: 0x002691F8
		public UKuroInteractionComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601A344 RID: 107332 RVA: 0x0026B020 File Offset: 0x00269220
		[NullableContext(1)]
		public UKuroInteractionComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInteractionComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006962 RID: 26978
		// (get) Token: 0x0601A345 RID: 107333 RVA: 0x0026B053 File Offset: 0x00269253
		// (set) Token: 0x0601A346 RID: 107334 RVA: 0x0026B063 File Offset: 0x00269263
		public unsafe float HitDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitDistance) = value;
			}
		}

		// Token: 0x17006963 RID: 26979
		// (get) Token: 0x0601A347 RID: 107335 RVA: 0x0026B074 File Offset: 0x00269274
		// (set) Token: 0x0601A348 RID: 107336 RVA: 0x0026B084 File Offset: 0x00269284
		public unsafe int DefaultID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_DefaultID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_DefaultID) = value;
			}
		}

		// Token: 0x17006964 RID: 26980
		// (get) Token: 0x0601A349 RID: 107337 RVA: 0x0026B095 File Offset: 0x00269295
		// (set) Token: 0x0601A34A RID: 107338 RVA: 0x0026B0A5 File Offset: 0x002692A5
		public unsafe int MaxID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxID) = value;
			}
		}

		// Token: 0x17006965 RID: 26981
		// (get) Token: 0x0601A34B RID: 107339 RVA: 0x0026B0B6 File Offset: 0x002692B6
		// (set) Token: 0x0601A34C RID: 107340 RVA: 0x0026B0C6 File Offset: 0x002692C6
		public unsafe int IDIncrementStep
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_IDIncrementStep);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_IDIncrementStep) = value;
			}
		}

		// Token: 0x17006966 RID: 26982
		// (get) Token: 0x0601A34D RID: 107341 RVA: 0x0026B0D7 File Offset: 0x002692D7
		// (set) Token: 0x0601A34E RID: 107342 RVA: 0x0026B0E7 File Offset: 0x002692E7
		public unsafe float ResetDelay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_ResetDelay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_ResetDelay) = value;
			}
		}

		// Token: 0x17006967 RID: 26983
		// (get) Token: 0x0601A34F RID: 107343 RVA: 0x0026B0F8 File Offset: 0x002692F8
		// (set) Token: 0x0601A350 RID: 107344 RVA: 0x0026B108 File Offset: 0x00269308
		public unsafe float HitCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitCooldown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitCooldown) = value;
			}
		}

		// Token: 0x17006968 RID: 26984
		// (get) Token: 0x0601A351 RID: 107345 RVA: 0x0026B119 File Offset: 0x00269319
		// (set) Token: 0x0601A352 RID: 107346 RVA: 0x0026B129 File Offset: 0x00269329
		public unsafe bool bApplyFeedbackDuringCooldown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bApplyFeedbackDuringCooldown) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bApplyFeedbackDuringCooldown) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006969 RID: 26985
		// (get) Token: 0x0601A353 RID: 107347 RVA: 0x0026B13A File Offset: 0x0026933A
		// (set) Token: 0x0601A354 RID: 107348 RVA: 0x0026B14E File Offset: 0x0026934E
		public unsafe USceneComponent DetectionSourceComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_DetectionSourceComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_DetectionSourceComponent, value);
			}
		}

		// Token: 0x1700696A RID: 26986
		// (get) Token: 0x0601A355 RID: 107349 RVA: 0x0026B163 File Offset: 0x00269363
		// (set) Token: 0x0601A356 RID: 107350 RVA: 0x0026B173 File Offset: 0x00269373
		public unsafe bool bEnableHitFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bEnableHitFeedback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bEnableHitFeedback) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700696B RID: 26987
		// (get) Token: 0x0601A357 RID: 107351 RVA: 0x0026B184 File Offset: 0x00269384
		// (set) Token: 0x0601A358 RID: 107352 RVA: 0x0026B198 File Offset: 0x00269398
		public unsafe USceneComponent TargetComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_TargetComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_TargetComponent, value);
			}
		}

		// Token: 0x1700696C RID: 26988
		// (get) Token: 0x0601A359 RID: 107353 RVA: 0x0026B1AD File Offset: 0x002693AD
		// (set) Token: 0x0601A35A RID: 107354 RVA: 0x0026B1BD File Offset: 0x002693BD
		public unsafe float HitFeedbackStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitFeedbackStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_HitFeedbackStrength) = value;
			}
		}

		// Token: 0x1700696D RID: 26989
		// (get) Token: 0x0601A35B RID: 107355 RVA: 0x0026B1CE File Offset: 0x002693CE
		// (set) Token: 0x0601A35C RID: 107356 RVA: 0x0026B1DE File Offset: 0x002693DE
		public unsafe float MaxRotationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxRotationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxRotationAngle) = value;
			}
		}

		// Token: 0x1700696E RID: 26990
		// (get) Token: 0x0601A35D RID: 107357 RVA: 0x0026B1EF File Offset: 0x002693EF
		// (set) Token: 0x0601A35E RID: 107358 RVA: 0x0026B1FF File Offset: 0x002693FF
		public unsafe float SpringBackSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_SpringBackSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_SpringBackSpeed) = value;
			}
		}

		// Token: 0x1700696F RID: 26991
		// (get) Token: 0x0601A35F RID: 107359 RVA: 0x0026B210 File Offset: 0x00269410
		// (set) Token: 0x0601A360 RID: 107360 RVA: 0x0026B220 File Offset: 0x00269420
		public unsafe float DampingFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_DampingFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_DampingFactor) = value;
			}
		}

		// Token: 0x17006970 RID: 26992
		// (get) Token: 0x0601A361 RID: 107361 RVA: 0x0026B231 File Offset: 0x00269431
		// (set) Token: 0x0601A362 RID: 107362 RVA: 0x0026B241 File Offset: 0x00269441
		public unsafe bool bUsePositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bUsePositionOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bUsePositionOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006971 RID: 26993
		// (get) Token: 0x0601A363 RID: 107363 RVA: 0x0026B252 File Offset: 0x00269452
		// (set) Token: 0x0601A364 RID: 107364 RVA: 0x0026B262 File Offset: 0x00269462
		public unsafe float MaxPositionOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxPositionOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MaxPositionOffset) = value;
			}
		}

		// Token: 0x17006972 RID: 26994
		// (get) Token: 0x0601A365 RID: 107365 RVA: 0x0026B273 File Offset: 0x00269473
		// (set) Token: 0x0601A366 RID: 107366 RVA: 0x0026B283 File Offset: 0x00269483
		public unsafe float VelocityAccumulationMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_VelocityAccumulationMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_VelocityAccumulationMultiplier) = value;
			}
		}

		// Token: 0x17006973 RID: 26995
		// (get) Token: 0x0601A367 RID: 107367 RVA: 0x0026B294 File Offset: 0x00269494
		// (set) Token: 0x0601A368 RID: 107368 RVA: 0x0026B2A8 File Offset: 0x002694A8
		public unsafe UMaterialParameterCollection MaterialParameterCollection
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialParameterCollection>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_MaterialParameterCollection);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroInteractionComponent.__PropertyOffset_MaterialParameterCollection, value);
			}
		}

		// Token: 0x17006974 RID: 26996
		// (get) Token: 0x0601A369 RID: 107369 RVA: 0x0026B2BD File Offset: 0x002694BD
		// (set) Token: 0x0601A36A RID: 107370 RVA: 0x0026B2D1 File Offset: 0x002694D1
		public unsafe FName MPCParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MPCParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_MPCParameterName) = value;
			}
		}

		// Token: 0x17006975 RID: 26997
		// (get) Token: 0x0601A36B RID: 107371 RVA: 0x0026B2E6 File Offset: 0x002694E6
		// (set) Token: 0x0601A36C RID: 107372 RVA: 0x0026B2F6 File Offset: 0x002694F6
		public unsafe bool bAutoUpdateMPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAutoUpdateMPC) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAutoUpdateMPC) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006976 RID: 26998
		// (get) Token: 0x0601A36D RID: 107373 RVA: 0x0026B308 File Offset: 0x00269508
		// (set) Token: 0x0601A36E RID: 107374 RVA: 0x0026B341 File Offset: 0x00269541
		[Nullable(1)]
		public TArray<FLinearColor> IDColors
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._IDColors) == null)
				{
					result = (this._IDColors = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_IDColors, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.IDColors.CopyAssign(value);
			}
		}

		// Token: 0x17006977 RID: 26999
		// (get) Token: 0x0601A36F RID: 107375 RVA: 0x0026B34F File Offset: 0x0026954F
		// (set) Token: 0x0601A370 RID: 107376 RVA: 0x0026B35F File Offset: 0x0026955F
		public unsafe float TickInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TickInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TickInterval) = value;
			}
		}

		// Token: 0x17006978 RID: 27000
		// (get) Token: 0x0601A371 RID: 107377 RVA: 0x0026B370 File Offset: 0x00269570
		// (set) Token: 0x0601A372 RID: 107378 RVA: 0x0026B380 File Offset: 0x00269580
		public unsafe bool bAutoDisableTickWhenIdle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAutoDisableTickWhenIdle) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAutoDisableTickWhenIdle) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006979 RID: 27001
		// (get) Token: 0x0601A373 RID: 107379 RVA: 0x0026B391 File Offset: 0x00269591
		// (set) Token: 0x0601A374 RID: 107380 RVA: 0x0026B3A1 File Offset: 0x002695A1
		public unsafe bool bForceFullFramerateForHitFeedback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bForceFullFramerateForHitFeedback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bForceFullFramerateForHitFeedback) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700697A RID: 27002
		// (get) Token: 0x0601A375 RID: 107381 RVA: 0x0026B3B2 File Offset: 0x002695B2
		// (set) Token: 0x0601A376 RID: 107382 RVA: 0x0026B3C2 File Offset: 0x002695C2
		public unsafe bool bUse2DDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bUse2DDistance) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bUse2DDistance) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700697B RID: 27003
		// (get) Token: 0x0601A377 RID: 107383 RVA: 0x0026B3D3 File Offset: 0x002695D3
		// (set) Token: 0x0601A378 RID: 107384 RVA: 0x0026B3E3 File Offset: 0x002695E3
		public unsafe bool bAllowBelowDefault
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAllowBelowDefault) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bAllowBelowDefault) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700697C RID: 27004
		// (get) Token: 0x0601A379 RID: 107385 RVA: 0x0026B3F4 File Offset: 0x002695F4
		// (set) Token: 0x0601A37A RID: 107386 RVA: 0x0026B404 File Offset: 0x00269604
		public unsafe bool bSmoothIDTransition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bSmoothIDTransition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bSmoothIDTransition) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700697D RID: 27005
		// (get) Token: 0x0601A37B RID: 107387 RVA: 0x0026B415 File Offset: 0x00269615
		// (set) Token: 0x0601A37C RID: 107388 RVA: 0x0026B425 File Offset: 0x00269625
		public unsafe float SmoothTransitionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_SmoothTransitionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_SmoothTransitionSpeed) = value;
			}
		}

		// Token: 0x1700697E RID: 27006
		// (get) Token: 0x0601A37D RID: 107389 RVA: 0x0026B436 File Offset: 0x00269636
		// (set) Token: 0x0601A37E RID: 107390 RVA: 0x0026B446 File Offset: 0x00269646
		public unsafe bool bSmoothReset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bSmoothReset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bSmoothReset) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700697F RID: 27007
		// (get) Token: 0x0601A37F RID: 107391 RVA: 0x0026B457 File Offset: 0x00269657
		// (set) Token: 0x0601A380 RID: 107392 RVA: 0x0026B467 File Offset: 0x00269667
		public unsafe bool bShowDebugInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bShowDebugInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bShowDebugInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006980 RID: 27008
		// (get) Token: 0x0601A381 RID: 107393 RVA: 0x0026B478 File Offset: 0x00269678
		// (set) Token: 0x0601A382 RID: 107394 RVA: 0x0026B488 File Offset: 0x00269688
		public unsafe bool bDrawDebugLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bDrawDebugLine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bDrawDebugLine) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006981 RID: 27009
		// (get) Token: 0x0601A383 RID: 107395 RVA: 0x0026B499 File Offset: 0x00269699
		// (set) Token: 0x0601A384 RID: 107396 RVA: 0x0026B4A9 File Offset: 0x002696A9
		public unsafe float CurrentID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_CurrentID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_CurrentID) = value;
			}
		}

		// Token: 0x17006982 RID: 27010
		// (get) Token: 0x0601A385 RID: 107397 RVA: 0x0026B4BA File Offset: 0x002696BA
		// (set) Token: 0x0601A386 RID: 107398 RVA: 0x0026B4CA File Offset: 0x002696CA
		public unsafe int TargetID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TargetID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TargetID) = value;
			}
		}

		// Token: 0x17006983 RID: 27011
		// (get) Token: 0x0601A387 RID: 107399 RVA: 0x0026B4DB File Offset: 0x002696DB
		// (set) Token: 0x0601A388 RID: 107400 RVA: 0x0026B4EB File Offset: 0x002696EB
		public unsafe float CurrentDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_CurrentDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_CurrentDistance) = value;
			}
		}

		// Token: 0x17006984 RID: 27012
		// (get) Token: 0x0601A389 RID: 107401 RVA: 0x0026B4FC File Offset: 0x002696FC
		// (set) Token: 0x0601A38A RID: 107402 RVA: 0x0026B50C File Offset: 0x0026970C
		public unsafe float TimeSinceLastHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TimeSinceLastHit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TimeSinceLastHit) = value;
			}
		}

		// Token: 0x17006985 RID: 27013
		// (get) Token: 0x0601A38B RID: 107403 RVA: 0x0026B51D File Offset: 0x0026971D
		// (set) Token: 0x0601A38C RID: 107404 RVA: 0x0026B52D File Offset: 0x0026972D
		public unsafe int TotalHitCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TotalHitCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_TotalHitCount) = value;
			}
		}

		// Token: 0x17006986 RID: 27014
		// (get) Token: 0x0601A38D RID: 107405 RVA: 0x0026B540 File Offset: 0x00269740
		// (set) Token: 0x0601A38E RID: 107406 RVA: 0x0026B579 File Offset: 0x00269779
		[Nullable(1)]
		public FOnProximityTriggered OnWeaponHit
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnProximityTriggered result;
				if ((result = this._OnWeaponHit) == null)
				{
					result = (this._OnWeaponHit = new FOnProximityTriggered(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_OnWeaponHit, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_OnWeaponHit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006987 RID: 27015
		// (get) Token: 0x0601A38F RID: 107407 RVA: 0x0026B59C File Offset: 0x0026979C
		// (set) Token: 0x0601A390 RID: 107408 RVA: 0x0026B5D5 File Offset: 0x002697D5
		[Nullable(1)]
		public FOnIDChanged OnIDChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FOnIDChanged result;
				if ((result = this._OnIDChanged) == null)
				{
					result = (this._OnIDChanged = new FOnIDChanged(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_OnIDChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_OnIDChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006988 RID: 27016
		// (get) Token: 0x0601A391 RID: 107409 RVA: 0x0026B5F6 File Offset: 0x002697F6
		// (set) Token: 0x0601A392 RID: 107410 RVA: 0x0026B60A File Offset: 0x0026980A
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x17006989 RID: 27017
		// (get) Token: 0x0601A393 RID: 107411 RVA: 0x0026B61F File Offset: 0x0026981F
		// (set) Token: 0x0601A394 RID: 107412 RVA: 0x0026B62F File Offset: 0x0026982F
		public unsafe bool bInitialTransformSaved
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bInitialTransformSaved) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroInteractionComponent.__PropertyOffset_bInitialTransformSaved) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601A395 RID: 107413 RVA: 0x0026B640 File Offset: 0x00269840
		public void UpdateMPCParameter()
		{
			UKuroInteractionComponent.__UpdateMPCParameter_Internal(base.NativePtr);
		}

		// Token: 0x0601A396 RID: 107414 RVA: 0x0026B64D File Offset: 0x0026984D
		public void TriggerHit()
		{
			UKuroInteractionComponent.__TriggerHit_Internal(base.NativePtr);
		}

		// Token: 0x0601A397 RID: 107415 RVA: 0x0026B65A File Offset: 0x0026985A
		public void SetCurrentID(int NewID)
		{
			UKuroInteractionComponent.__SetCurrentID_Internal(base.NativePtr, NewID);
		}

		// Token: 0x0601A398 RID: 107416 RVA: 0x0026B668 File Offset: 0x00269868
		public void ResetInitialTransform()
		{
			UKuroInteractionComponent.__ResetInitialTransform_Internal(base.NativePtr);
		}

		// Token: 0x0601A399 RID: 107417 RVA: 0x0026B675 File Offset: 0x00269875
		public void ResetID()
		{
			UKuroInteractionComponent.__ResetID_Internal(base.NativePtr);
		}

		// Token: 0x0601A39A RID: 107418 RVA: 0x0026B682 File Offset: 0x00269882
		public bool IsInCooldown()
		{
			return UKuroInteractionComponent.__IsInCooldown_Internal(base.NativePtr);
		}

		// Token: 0x0601A39B RID: 107419 RVA: 0x0026B68F File Offset: 0x0026988F
		public float GetLastHitDistance()
		{
			return UKuroInteractionComponent.__GetLastHitDistance_Internal(base.NativePtr);
		}

		// Token: 0x0601A39C RID: 107420 RVA: 0x0026B69C File Offset: 0x0026989C
		public int GetCurrentIDInt()
		{
			return UKuroInteractionComponent.__GetCurrentIDInt_Internal(base.NativePtr);
		}

		// Token: 0x0601A39D RID: 107421 RVA: 0x0026B6A9 File Offset: 0x002698A9
		public float GetCurrentIDFloat()
		{
			return UKuroInteractionComponent.__GetCurrentIDFloat_Internal(base.NativePtr);
		}

		// Token: 0x0601A39E RID: 107422 RVA: 0x0026B6B6 File Offset: 0x002698B6
		public FLinearColor GetColorForID(int ID)
		{
			return UKuroInteractionComponent.__GetColorForID_Internal(base.NativePtr, ID);
		}

		// Token: 0x0601A39F RID: 107423 RVA: 0x0026B6C4 File Offset: 0x002698C4
		public bool CheckWeaponHitSimple(FVector WeaponPosition)
		{
			return UKuroInteractionComponent.__CheckWeaponHitSimple_Internal(base.NativePtr, WeaponPosition);
		}

		// Token: 0x0601A3A0 RID: 107424 RVA: 0x0026B6D4 File Offset: 0x002698D4
		public unsafe bool CheckWeaponHit(FVector WeaponPosition, FVector MeshPosition, ref float OutDistance)
		{
			fixed (float* ptr = &OutDistance)
			{
				void* ptr2 = (void*)ptr;
				return UKuroInteractionComponent.__CheckWeaponHit_Internal(base.NativePtr, WeaponPosition, MeshPosition, ref OutDistance);
			}
		}

		// Token: 0x0601A3A1 RID: 107425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateMPCParameter_Internal(IntPtr @this);

		// Token: 0x0601A3A2 RID: 107426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerHit_Internal(IntPtr @this);

		// Token: 0x0601A3A3 RID: 107427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCurrentID_Internal(IntPtr @this, int NewID);

		// Token: 0x0601A3A4 RID: 107428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInitialTransform_Internal(IntPtr @this);

		// Token: 0x0601A3A5 RID: 107429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetID_Internal(IntPtr @this);

		// Token: 0x0601A3A6 RID: 107430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInCooldown_Internal(IntPtr @this);

		// Token: 0x0601A3A7 RID: 107431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLastHitDistance_Internal(IntPtr @this);

		// Token: 0x0601A3A8 RID: 107432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetCurrentIDInt_Internal(IntPtr @this);

		// Token: 0x0601A3A9 RID: 107433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentIDFloat_Internal(IntPtr @this);

		// Token: 0x0601A3AA RID: 107434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetColorForID_Internal(IntPtr @this, int ID);

		// Token: 0x0601A3AB RID: 107435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckWeaponHitSimple_Internal(IntPtr @this, FVector WeaponPosition);

		// Token: 0x0601A3AC RID: 107436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckWeaponHit_Internal(IntPtr @this, FVector WeaponPosition, FVector MeshPosition, ref float OutDistance);

		// Token: 0x0601A3AD RID: 107437 RVA: 0x0026B6F4 File Offset: 0x002698F4
		static UKuroInteractionComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionComponent");
		}

		// Token: 0x0601A3AE RID: 107438 RVA: 0x0026B702 File Offset: 0x00269902
		protected UKuroInteractionComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400E3BB RID: 58299
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInteractionComponent";

		// Token: 0x0400E3BC RID: 58300
		private static IntPtr _ClassPtr;

		// Token: 0x0400E3BD RID: 58301
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400E3BE RID: 58302
		internal static int __PropertyOffset_HitDistance;

		// Token: 0x0400E3BF RID: 58303
		internal static int __PropertyOffset_DefaultID;

		// Token: 0x0400E3C0 RID: 58304
		internal static int __PropertyOffset_MaxID;

		// Token: 0x0400E3C1 RID: 58305
		internal static int __PropertyOffset_IDIncrementStep;

		// Token: 0x0400E3C2 RID: 58306
		internal static int __PropertyOffset_ResetDelay;

		// Token: 0x0400E3C3 RID: 58307
		internal static int __PropertyOffset_HitCooldown;

		// Token: 0x0400E3C4 RID: 58308
		internal static int __PropertyOffset_bApplyFeedbackDuringCooldown;

		// Token: 0x0400E3C5 RID: 58309
		internal static int __PropertyOffset_DetectionSourceComponent;

		// Token: 0x0400E3C6 RID: 58310
		internal static int __PropertyOffset_bEnableHitFeedback;

		// Token: 0x0400E3C7 RID: 58311
		internal static int __PropertyOffset_TargetComponent;

		// Token: 0x0400E3C8 RID: 58312
		internal static int __PropertyOffset_HitFeedbackStrength;

		// Token: 0x0400E3C9 RID: 58313
		internal static int __PropertyOffset_MaxRotationAngle;

		// Token: 0x0400E3CA RID: 58314
		internal static int __PropertyOffset_SpringBackSpeed;

		// Token: 0x0400E3CB RID: 58315
		internal static int __PropertyOffset_DampingFactor;

		// Token: 0x0400E3CC RID: 58316
		internal static int __PropertyOffset_bUsePositionOffset;

		// Token: 0x0400E3CD RID: 58317
		internal static int __PropertyOffset_MaxPositionOffset;

		// Token: 0x0400E3CE RID: 58318
		internal static int __PropertyOffset_VelocityAccumulationMultiplier;

		// Token: 0x0400E3CF RID: 58319
		internal static int __PropertyOffset_MaterialParameterCollection;

		// Token: 0x0400E3D0 RID: 58320
		internal static int __PropertyOffset_MPCParameterName;

		// Token: 0x0400E3D1 RID: 58321
		internal static int __PropertyOffset_bAutoUpdateMPC;

		// Token: 0x0400E3D2 RID: 58322
		internal static int __PropertyOffset_IDColors;

		// Token: 0x0400E3D3 RID: 58323
		private TArray<FLinearColor> _IDColors;

		// Token: 0x0400E3D4 RID: 58324
		internal static int __PropertyOffset_TickInterval;

		// Token: 0x0400E3D5 RID: 58325
		internal static int __PropertyOffset_bAutoDisableTickWhenIdle;

		// Token: 0x0400E3D6 RID: 58326
		internal static int __PropertyOffset_bForceFullFramerateForHitFeedback;

		// Token: 0x0400E3D7 RID: 58327
		internal static int __PropertyOffset_bUse2DDistance;

		// Token: 0x0400E3D8 RID: 58328
		internal static int __PropertyOffset_bAllowBelowDefault;

		// Token: 0x0400E3D9 RID: 58329
		internal static int __PropertyOffset_bSmoothIDTransition;

		// Token: 0x0400E3DA RID: 58330
		internal static int __PropertyOffset_SmoothTransitionSpeed;

		// Token: 0x0400E3DB RID: 58331
		internal static int __PropertyOffset_bSmoothReset;

		// Token: 0x0400E3DC RID: 58332
		internal static int __PropertyOffset_bShowDebugInfo;

		// Token: 0x0400E3DD RID: 58333
		internal static int __PropertyOffset_bDrawDebugLine;

		// Token: 0x0400E3DE RID: 58334
		internal static int __PropertyOffset_CurrentID;

		// Token: 0x0400E3DF RID: 58335
		internal static int __PropertyOffset_TargetID;

		// Token: 0x0400E3E0 RID: 58336
		internal static int __PropertyOffset_CurrentDistance;

		// Token: 0x0400E3E1 RID: 58337
		internal static int __PropertyOffset_TimeSinceLastHit;

		// Token: 0x0400E3E2 RID: 58338
		internal static int __PropertyOffset_TotalHitCount;

		// Token: 0x0400E3E3 RID: 58339
		internal static int __PropertyOffset_OnWeaponHit;

		// Token: 0x0400E3E4 RID: 58340
		private FOnProximityTriggered _OnWeaponHit;

		// Token: 0x0400E3E5 RID: 58341
		internal static int __PropertyOffset_OnIDChanged;

		// Token: 0x0400E3E6 RID: 58342
		private FOnIDChanged _OnIDChanged;

		// Token: 0x0400E3E7 RID: 58343
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x0400E3E8 RID: 58344
		internal static int __PropertyOffset_bInitialTransformSaved;
	}
}
