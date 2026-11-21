using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200035D RID: 861
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiSubsystem")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class UKuroCrowdAiSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060057FF RID: 22527 RVA: 0x0007BCC1 File Offset: 0x00079EC1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrowdAiSubsystem._ClassPtr;
		}

		// Token: 0x06005800 RID: 22528 RVA: 0x0007BCD0 File Offset: 0x00079ED0
		public UKuroCrowdAiSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06005801 RID: 22529 RVA: 0x0007BCF8 File Offset: 0x00079EF8
		[NullableContext(1)]
		public UKuroCrowdAiSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001168 RID: 4456
		// (get) Token: 0x06005802 RID: 22530 RVA: 0x0007BD2B File Offset: 0x00079F2B
		// (set) Token: 0x06005803 RID: 22531 RVA: 0x0007BD3B File Offset: 0x00079F3B
		public unsafe float GroupSplitRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_GroupSplitRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_GroupSplitRadius) = value;
			}
		}

		// Token: 0x17001169 RID: 4457
		// (get) Token: 0x06005804 RID: 22532 RVA: 0x0007BD4C File Offset: 0x00079F4C
		// (set) Token: 0x06005805 RID: 22533 RVA: 0x0007BD5C File Offset: 0x00079F5C
		public unsafe float GroupNavigationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_GroupNavigationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_GroupNavigationInterval) = value;
			}
		}

		// Token: 0x1700116A RID: 4458
		// (get) Token: 0x06005806 RID: 22534 RVA: 0x0007BD6D File Offset: 0x00079F6D
		// (set) Token: 0x06005807 RID: 22535 RVA: 0x0007BD7D File Offset: 0x00079F7D
		public unsafe float PauseSeekMinDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMinDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMinDist) = value;
			}
		}

		// Token: 0x1700116B RID: 4459
		// (get) Token: 0x06005808 RID: 22536 RVA: 0x0007BD8E File Offset: 0x00079F8E
		// (set) Token: 0x06005809 RID: 22537 RVA: 0x0007BD9E File Offset: 0x00079F9E
		public unsafe float PauseSeekMaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMaxTime) = value;
			}
		}

		// Token: 0x1700116C RID: 4460
		// (get) Token: 0x0600580A RID: 22538 RVA: 0x0007BDAF File Offset: 0x00079FAF
		// (set) Token: 0x0600580B RID: 22539 RVA: 0x0007BDBF File Offset: 0x00079FBF
		public unsafe float PauseSeekMaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseSeekMaxSpeed) = value;
			}
		}

		// Token: 0x1700116D RID: 4461
		// (get) Token: 0x0600580C RID: 22540 RVA: 0x0007BDD0 File Offset: 0x00079FD0
		// (set) Token: 0x0600580D RID: 22541 RVA: 0x0007BDE0 File Offset: 0x00079FE0
		public unsafe bool bEnableFollowLimitation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bEnableFollowLimitation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bEnableFollowLimitation) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700116E RID: 4462
		// (get) Token: 0x0600580E RID: 22542 RVA: 0x0007BDF1 File Offset: 0x00079FF1
		// (set) Token: 0x0600580F RID: 22543 RVA: 0x0007BE01 File Offset: 0x0007A001
		public unsafe float FanWingEdgesAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanWingEdgesAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanWingEdgesAngle) = value;
			}
		}

		// Token: 0x1700116F RID: 4463
		// (get) Token: 0x06005810 RID: 22544 RVA: 0x0007BE12 File Offset: 0x0007A012
		// (set) Token: 0x06005811 RID: 22545 RVA: 0x0007BE22 File Offset: 0x0007A022
		public unsafe float FanWingEdgesLen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanWingEdgesLen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanWingEdgesLen) = value;
			}
		}

		// Token: 0x17001170 RID: 4464
		// (get) Token: 0x06005812 RID: 22546 RVA: 0x0007BE33 File Offset: 0x0007A033
		// (set) Token: 0x06005813 RID: 22547 RVA: 0x0007BE43 File Offset: 0x0007A043
		public unsafe float FanBottomEdgeHalfLen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanBottomEdgeHalfLen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanBottomEdgeHalfLen) = value;
			}
		}

		// Token: 0x17001171 RID: 4465
		// (get) Token: 0x06005814 RID: 22548 RVA: 0x0007BE54 File Offset: 0x0007A054
		// (set) Token: 0x06005815 RID: 22549 RVA: 0x0007BE64 File Offset: 0x0007A064
		public unsafe float FanBottomEdgeDistToWatchingBoid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanBottomEdgeDistToWatchingBoid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_FanBottomEdgeDistToWatchingBoid) = value;
			}
		}

		// Token: 0x17001172 RID: 4466
		// (get) Token: 0x06005816 RID: 22550 RVA: 0x0007BE75 File Offset: 0x0007A075
		// (set) Token: 0x06005817 RID: 22551 RVA: 0x0007BE85 File Offset: 0x0007A085
		public unsafe float BornDelayMaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_BornDelayMaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_BornDelayMaxTime) = value;
			}
		}

		// Token: 0x17001173 RID: 4467
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0007BE96 File Offset: 0x0007A096
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x0007BEA6 File Offset: 0x0007A0A6
		public unsafe float DestroyDelayMaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_DestroyDelayMaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_DestroyDelayMaxTime) = value;
			}
		}

		// Token: 0x17001174 RID: 4468
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0007BEB7 File Offset: 0x0007A0B7
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x0007BEC7 File Offset: 0x0007A0C7
		public unsafe bool bEnableTeleport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bEnableTeleport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bEnableTeleport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001175 RID: 4469
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0007BED8 File Offset: 0x0007A0D8
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x0007BEE8 File Offset: 0x0007A0E8
		public unsafe float TeleportMinPlanarDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinPlanarDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinPlanarDist) = value;
			}
		}

		// Token: 0x17001176 RID: 4470
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x0007BEF9 File Offset: 0x0007A0F9
		// (set) Token: 0x0600581F RID: 22559 RVA: 0x0007BF09 File Offset: 0x0007A109
		public unsafe float TeleportMinVerticalDist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinVerticalDist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinVerticalDist) = value;
			}
		}

		// Token: 0x17001177 RID: 4471
		// (get) Token: 0x06005820 RID: 22560 RVA: 0x0007BF1A File Offset: 0x0007A11A
		// (set) Token: 0x06005821 RID: 22561 RVA: 0x0007BF2A File Offset: 0x0007A12A
		public unsafe float PauseTeleportMaxPlanarSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseTeleportMaxPlanarSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_PauseTeleportMaxPlanarSpeed) = value;
			}
		}

		// Token: 0x17001178 RID: 4472
		// (get) Token: 0x06005822 RID: 22562 RVA: 0x0007BF3B File Offset: 0x0007A13B
		// (set) Token: 0x06005823 RID: 22563 RVA: 0x0007BF4B File Offset: 0x0007A14B
		public unsafe float TeleportMinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMinTime) = value;
			}
		}

		// Token: 0x17001179 RID: 4473
		// (get) Token: 0x06005824 RID: 22564 RVA: 0x0007BF5C File Offset: 0x0007A15C
		// (set) Token: 0x06005825 RID: 22565 RVA: 0x0007BF6C File Offset: 0x0007A16C
		public unsafe float TeleportMaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportMaxTime) = value;
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06005826 RID: 22566 RVA: 0x0007BF7D File Offset: 0x0007A17D
		// (set) Token: 0x06005827 RID: 22567 RVA: 0x0007BF8D File Offset: 0x0007A18D
		public unsafe float TeleportTargetMaxRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTargetMaxRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTargetMaxRadius) = value;
			}
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x06005828 RID: 22568 RVA: 0x0007BF9E File Offset: 0x0007A19E
		// (set) Token: 0x06005829 RID: 22569 RVA: 0x0007BFAE File Offset: 0x0007A1AE
		public unsafe float TeleportTargetMinRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTargetMinRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTargetMinRadius) = value;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x0600582A RID: 22570 RVA: 0x0007BFBF File Offset: 0x0007A1BF
		// (set) Token: 0x0600582B RID: 22571 RVA: 0x0007BFCF File Offset: 0x0007A1CF
		public unsafe int TeleportTryCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTryCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_TeleportTryCount) = value;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600582C RID: 22572 RVA: 0x0007BFE0 File Offset: 0x0007A1E0
		// (set) Token: 0x0600582D RID: 22573 RVA: 0x0007BFF0 File Offset: 0x0007A1F0
		public unsafe bool bStickToGround
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bStickToGround) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCrowdAiSubsystem.__PropertyOffset_bStickToGround) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600582E RID: 22574 RVA: 0x0007C004 File Offset: 0x0007A204
		[SkipLocalsInit]
		public unsafe bool WasBoidControlledByCrowdAi(int BoidId)
		{
			UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600582F RID: 22575 RVA: 0x0007C050 File Offset: 0x0007A250
		[SkipLocalsInit]
		public unsafe void UpdateDebugNavMeshEdges(in FBox Range)
		{
			UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Range = Range;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005830 RID: 22576 RVA: 0x0007C09C File Offset: 0x0007A29C
		[SkipLocalsInit]
		public unsafe int SetWatchingBoidAndJoinGroup(int BoidId, int WatchingBoidId)
		{
			UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->WatchingBoidId = WatchingBoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005831 RID: 22577 RVA: 0x0007C0F0 File Offset: 0x0007A2F0
		[SkipLocalsInit]
		public unsafe bool SetBoidTransform(int BoidId, in FTransform NewTransform, bool bTeleport = false)
		{
			UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->NewTransform = NewTransform;
			ptr->bTeleport = bTeleport;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005832 RID: 22578 RVA: 0x0007C150 File Offset: 0x0007A350
		[SkipLocalsInit]
		public unsafe bool SetBoidScale(int BoidId, in FVector NewScale)
		{
			UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->NewScale = NewScale;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidScale_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005833 RID: 22579 RVA: 0x0007C1A8 File Offset: 0x0007A3A8
		[SkipLocalsInit]
		public unsafe bool SetBoidControlledByCrowdAi(int BoidId, bool Enable)
		{
			UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005834 RID: 22580 RVA: 0x0007C1FC File Offset: 0x0007A3FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool SetBoidAppearanceInfo(int BoidId, ref TArray<float> CustomDataArray)
		{
			UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			TArray<float> tarray = CustomDataArray;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CustomDataArray);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_NativeFunctionPtr, (void*)ptr);
			TArray<float> tarray2 = CustomDataArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CustomDataArray);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06005835 RID: 22581 RVA: 0x0007C284 File Offset: 0x0007A484
		[SkipLocalsInit]
		public unsafe bool RemoveBoid(int BoidId, bool bForce = false)
		{
			UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__RemoveBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->bForce = bForce;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__RemoveBoid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005836 RID: 22582 RVA: 0x0007C2D8 File Offset: 0x0007A4D8
		[SkipLocalsInit]
		public unsafe FVector QueryUsablePositionForBoid(in FVector QueryPosition, float QueryRadius, float BoidRadius, int MaxTryCount = 8)
		{
			UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QueryPosition = QueryPosition;
			ptr->QueryRadius = QueryRadius;
			ptr->BoidRadius = BoidRadius;
			ptr->MaxTryCount = MaxTryCount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005837 RID: 22583 RVA: 0x0007C340 File Offset: 0x0007A540
		[SkipLocalsInit]
		public unsafe void NotifyBoidsMoveTo(in FVector NewLocation)
		{
			UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewLocation = NewLocation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005838 RID: 22584 RVA: 0x0007C38B File Offset: 0x0007A58B
		[SkipLocalsInit]
		public void NotifyBoidsAround()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__NotifyBoidsAround_NativeFunctionPtr, null);
		}

		// Token: 0x06005839 RID: 22585 RVA: 0x0007C3A0 File Offset: 0x0007A5A0
		[SkipLocalsInit]
		public unsafe FVector GetBoidVelocity(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidVelocity_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600583A RID: 22586 RVA: 0x0007C3EC File Offset: 0x0007A5EC
		[SkipLocalsInit]
		public unsafe FTransform GetBoidTransform(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600583B RID: 22587 RVA: 0x0007C438 File Offset: 0x0007A638
		[SkipLocalsInit]
		public unsafe FVector GetBoidLastVelocity(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidLastVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidLastVelocity_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600583C RID: 22588 RVA: 0x0007C484 File Offset: 0x0007A684
		[SkipLocalsInit]
		public unsafe FTransform GetBoidLastTransform(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidLastTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidLastTransform_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600583D RID: 22589 RVA: 0x0007C4D0 File Offset: 0x0007A6D0
		[SkipLocalsInit]
		public unsafe int GetBoidGroupId(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidGroupId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidGroupId_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600583E RID: 22590 RVA: 0x0007C51C File Offset: 0x0007A71C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void GetAllGroupIds(ref TArray<int> OutGroupIds)
		{
			UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutGroupIds;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutGroupIds);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr);
			TArray<int> tarray2 = OutGroupIds;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutGroupIds);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x0007C594 File Offset: 0x0007A794
		[SkipLocalsInit]
		public unsafe void EnableDebugMode(bool Enable)
		{
			UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__EnableDebugMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__EnableDebugMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0007C5DC File Offset: 0x0007A7DC
		[SkipLocalsInit]
		public unsafe void EnableBoidIdlePerform(int BoidId, bool bEnable)
		{
			UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06005841 RID: 22593 RVA: 0x0007C62C File Offset: 0x0007A82C
		[SkipLocalsInit]
		public unsafe bool ChangeGroupWatchingBoid(int GroupId, int BoidId)
		{
			UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GroupId = GroupId;
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005842 RID: 22594 RVA: 0x0007C680 File Offset: 0x0007A880
		[SkipLocalsInit]
		public unsafe bool BoidStopAnimation(int BoidId, int AnimIndex, bool bImmediately = true)
		{
			UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__BoidStopAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->AnimIndex = AnimIndex;
			ptr->bImmediately = bImmediately;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__BoidStopAnimation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x0007C6DC File Offset: 0x0007A8DC
		[SkipLocalsInit]
		public unsafe bool BoidPlayAnimation(int BoidId, int AnimIndex, float PlayRate = 1f, float StartPos = 0f, bool bIsLoop = false)
		{
			UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__BoidPlayAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->AnimIndex = AnimIndex;
			ptr->PlayRate = PlayRate;
			ptr->StartPos = StartPos;
			ptr->bIsLoop = bIsLoop;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__BoidPlayAnimation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0007C746 File Offset: 0x0007A946
		static UKuroCrowdAiSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiSubsystem");
		}

		// Token: 0x06005845 RID: 22597 RVA: 0x0007C754 File Offset: 0x0007A954
		protected UKuroCrowdAiSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400244A RID: 9290
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiSubsystem";

		// Token: 0x0400244B RID: 9291
		private static IntPtr _ClassPtr;

		// Token: 0x0400244C RID: 9292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400244D RID: 9293
		internal static int __PropertyOffset_GroupSplitRadius;

		// Token: 0x0400244E RID: 9294
		internal static int __PropertyOffset_GroupNavigationInterval;

		// Token: 0x0400244F RID: 9295
		internal static int __PropertyOffset_PauseSeekMinDist;

		// Token: 0x04002450 RID: 9296
		internal static int __PropertyOffset_PauseSeekMaxTime;

		// Token: 0x04002451 RID: 9297
		internal static int __PropertyOffset_PauseSeekMaxSpeed;

		// Token: 0x04002452 RID: 9298
		internal static int __PropertyOffset_bEnableFollowLimitation;

		// Token: 0x04002453 RID: 9299
		internal static int __PropertyOffset_FanWingEdgesAngle;

		// Token: 0x04002454 RID: 9300
		internal static int __PropertyOffset_FanWingEdgesLen;

		// Token: 0x04002455 RID: 9301
		internal static int __PropertyOffset_FanBottomEdgeHalfLen;

		// Token: 0x04002456 RID: 9302
		internal static int __PropertyOffset_FanBottomEdgeDistToWatchingBoid;

		// Token: 0x04002457 RID: 9303
		internal static int __PropertyOffset_BornDelayMaxTime;

		// Token: 0x04002458 RID: 9304
		internal static int __PropertyOffset_DestroyDelayMaxTime;

		// Token: 0x04002459 RID: 9305
		internal static int __PropertyOffset_bEnableTeleport;

		// Token: 0x0400245A RID: 9306
		internal static int __PropertyOffset_TeleportMinPlanarDist;

		// Token: 0x0400245B RID: 9307
		internal static int __PropertyOffset_TeleportMinVerticalDist;

		// Token: 0x0400245C RID: 9308
		internal static int __PropertyOffset_PauseTeleportMaxPlanarSpeed;

		// Token: 0x0400245D RID: 9309
		internal static int __PropertyOffset_TeleportMinTime;

		// Token: 0x0400245E RID: 9310
		internal static int __PropertyOffset_TeleportMaxTime;

		// Token: 0x0400245F RID: 9311
		internal static int __PropertyOffset_TeleportTargetMaxRadius;

		// Token: 0x04002460 RID: 9312
		internal static int __PropertyOffset_TeleportTargetMinRadius;

		// Token: 0x04002461 RID: 9313
		internal static int __PropertyOffset_TeleportTryCount;

		// Token: 0x04002462 RID: 9314
		internal static int __PropertyOffset_bStickToGround;

		// Token: 0x04002463 RID: 9315
		private static IntPtr __WasBoidControlledByCrowdAi_NativeFunctionPtr;

		// Token: 0x04002464 RID: 9316
		private static IntPtr __UpdateDebugNavMeshEdges_NativeFunctionPtr;

		// Token: 0x04002465 RID: 9317
		private static IntPtr __SetWatchingBoidAndJoinGroup_NativeFunctionPtr;

		// Token: 0x04002466 RID: 9318
		private static IntPtr __SetBoidTransform_NativeFunctionPtr;

		// Token: 0x04002467 RID: 9319
		private static IntPtr __SetBoidScale_NativeFunctionPtr;

		// Token: 0x04002468 RID: 9320
		private static IntPtr __SetBoidControlledByCrowdAi_NativeFunctionPtr;

		// Token: 0x04002469 RID: 9321
		private static IntPtr __SetBoidAppearanceInfo_NativeFunctionPtr;

		// Token: 0x0400246A RID: 9322
		private static IntPtr __RemoveBoid_NativeFunctionPtr;

		// Token: 0x0400246B RID: 9323
		private static IntPtr __QueryUsablePositionForBoid_NativeFunctionPtr;

		// Token: 0x0400246C RID: 9324
		private static IntPtr __NotifyBoidsMoveTo_NativeFunctionPtr;

		// Token: 0x0400246D RID: 9325
		private static IntPtr __NotifyBoidsAround_NativeFunctionPtr;

		// Token: 0x0400246E RID: 9326
		private static IntPtr __GetBoidVelocity_NativeFunctionPtr;

		// Token: 0x0400246F RID: 9327
		private static IntPtr __GetBoidTransform_NativeFunctionPtr;

		// Token: 0x04002470 RID: 9328
		private static IntPtr __GetBoidLastVelocity_NativeFunctionPtr;

		// Token: 0x04002471 RID: 9329
		private static IntPtr __GetBoidLastTransform_NativeFunctionPtr;

		// Token: 0x04002472 RID: 9330
		private static IntPtr __GetBoidGroupId_NativeFunctionPtr;

		// Token: 0x04002473 RID: 9331
		private static IntPtr __GetAllGroupIds_NativeFunctionPtr;

		// Token: 0x04002474 RID: 9332
		private static IntPtr __EnableDebugMode_NativeFunctionPtr;

		// Token: 0x04002475 RID: 9333
		private static IntPtr __EnableBoidIdlePerform_NativeFunctionPtr;

		// Token: 0x04002476 RID: 9334
		private static IntPtr __ChangeGroupWatchingBoid_NativeFunctionPtr;

		// Token: 0x04002477 RID: 9335
		private static IntPtr __BoidStopAnimation_NativeFunctionPtr;

		// Token: 0x04002478 RID: 9336
		private static IntPtr __BoidPlayAnimation_NativeFunctionPtr;

		// Token: 0x02000A66 RID: 2662
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __WasBoidControlledByCrowdAi_FunctionParams
		{
			// Token: 0x04005A81 RID: 23169
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A82 RID: 23170
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000A67 RID: 2663
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __UpdateDebugNavMeshEdges_FunctionParams
		{
			// Token: 0x04005A83 RID: 23171
			[FieldOffset(0)]
			public FBox Range;
		}

		// Token: 0x02000A68 RID: 2664
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetWatchingBoidAndJoinGroup_FunctionParams
		{
			// Token: 0x04005A84 RID: 23172
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A85 RID: 23173
			[FieldOffset(4)]
			public int WatchingBoidId;

			// Token: 0x04005A86 RID: 23174
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02000A69 RID: 2665
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoidTransform_FunctionParams
		{
			// Token: 0x04005A87 RID: 23175
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A88 RID: 23176
			[FieldOffset(16)]
			public FTransform NewTransform;

			// Token: 0x04005A89 RID: 23177
			[FieldOffset(64)]
			public bool bTeleport;

			// Token: 0x04005A8A RID: 23178
			[FieldOffset(65)]
			public bool __Result;
		}

		// Token: 0x02000A6A RID: 2666
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetBoidScale_FunctionParams
		{
			// Token: 0x04005A8B RID: 23179
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A8C RID: 23180
			[FieldOffset(4)]
			public FVector NewScale;

			// Token: 0x04005A8D RID: 23181
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02000A6B RID: 2667
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetBoidControlledByCrowdAi_FunctionParams
		{
			// Token: 0x04005A8E RID: 23182
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A8F RID: 23183
			[FieldOffset(4)]
			public bool Enable;

			// Token: 0x04005A90 RID: 23184
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02000A6C RID: 2668
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetBoidAppearanceInfo_FunctionParams
		{
			// Token: 0x04005A91 RID: 23185
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A92 RID: 23186
			[FieldOffset(8)]
			public byte CustomDataArray;

			// Token: 0x04005A93 RID: 23187
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000A6D RID: 2669
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemoveBoid_FunctionParams
		{
			// Token: 0x04005A94 RID: 23188
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A95 RID: 23189
			[FieldOffset(4)]
			public bool bForce;

			// Token: 0x04005A96 RID: 23190
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02000A6E RID: 2670
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __QueryUsablePositionForBoid_FunctionParams
		{
			// Token: 0x04005A97 RID: 23191
			[FieldOffset(0)]
			public FVector QueryPosition;

			// Token: 0x04005A98 RID: 23192
			[FieldOffset(12)]
			public float QueryRadius;

			// Token: 0x04005A99 RID: 23193
			[FieldOffset(16)]
			public float BoidRadius;

			// Token: 0x04005A9A RID: 23194
			[FieldOffset(20)]
			public int MaxTryCount;

			// Token: 0x04005A9B RID: 23195
			[FieldOffset(24)]
			public FVector __Result;
		}

		// Token: 0x02000A6F RID: 2671
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __NotifyBoidsMoveTo_FunctionParams
		{
			// Token: 0x04005A9C RID: 23196
			[FieldOffset(0)]
			public FVector NewLocation;
		}

		// Token: 0x02000A70 RID: 2672
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoidVelocity_FunctionParams
		{
			// Token: 0x04005A9D RID: 23197
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005A9E RID: 23198
			[FieldOffset(4)]
			public FVector __Result;
		}

		// Token: 0x02000A71 RID: 2673
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetBoidTransform_FunctionParams
		{
			// Token: 0x04005A9F RID: 23199
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AA0 RID: 23200
			[FieldOffset(16)]
			public FTransform __Result;
		}

		// Token: 0x02000A72 RID: 2674
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoidLastVelocity_FunctionParams
		{
			// Token: 0x04005AA1 RID: 23201
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AA2 RID: 23202
			[FieldOffset(4)]
			public FVector __Result;
		}

		// Token: 0x02000A73 RID: 2675
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetBoidLastTransform_FunctionParams
		{
			// Token: 0x04005AA3 RID: 23203
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AA4 RID: 23204
			[FieldOffset(16)]
			public FTransform __Result;
		}

		// Token: 0x02000A74 RID: 2676
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetBoidGroupId_FunctionParams
		{
			// Token: 0x04005AA5 RID: 23205
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AA6 RID: 23206
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02000A75 RID: 2677
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllGroupIds_FunctionParams
		{
			// Token: 0x04005AA7 RID: 23207
			[FieldOffset(0)]
			public byte OutGroupIds;
		}

		// Token: 0x02000A76 RID: 2678
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDebugMode_FunctionParams
		{
			// Token: 0x04005AA8 RID: 23208
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02000A77 RID: 2679
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EnableBoidIdlePerform_FunctionParams
		{
			// Token: 0x04005AA9 RID: 23209
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AAA RID: 23210
			[FieldOffset(4)]
			public bool bEnable;
		}

		// Token: 0x02000A78 RID: 2680
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ChangeGroupWatchingBoid_FunctionParams
		{
			// Token: 0x04005AAB RID: 23211
			[FieldOffset(0)]
			public int GroupId;

			// Token: 0x04005AAC RID: 23212
			[FieldOffset(4)]
			public int BoidId;

			// Token: 0x04005AAD RID: 23213
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02000A79 RID: 2681
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoidStopAnimation_FunctionParams
		{
			// Token: 0x04005AAE RID: 23214
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AAF RID: 23215
			[FieldOffset(4)]
			public int AnimIndex;

			// Token: 0x04005AB0 RID: 23216
			[FieldOffset(8)]
			public bool bImmediately;

			// Token: 0x04005AB1 RID: 23217
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x02000A7A RID: 2682
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __BoidPlayAnimation_FunctionParams
		{
			// Token: 0x04005AB2 RID: 23218
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04005AB3 RID: 23219
			[FieldOffset(4)]
			public int AnimIndex;

			// Token: 0x04005AB4 RID: 23220
			[FieldOffset(8)]
			public float PlayRate;

			// Token: 0x04005AB5 RID: 23221
			[FieldOffset(12)]
			public float StartPos;

			// Token: 0x04005AB6 RID: 23222
			[FieldOffset(16)]
			public bool bIsLoop;

			// Token: 0x04005AB7 RID: 23223
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
