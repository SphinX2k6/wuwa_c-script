using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017F0 RID: 6128
	[UnrealObjectPath("/Script/KuroCrowdAi.KuroCrowdAiSubsystem")]
	[UnrealStructLayout(1408, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1408)]
	public class UKuroCrowdAiSubsystem : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016A57 RID: 92759 RVA: 0x002108C2 File Offset: 0x0020EAC2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCrowdAiSubsystem._ClassPtr;
		}

		// Token: 0x06016A58 RID: 92760 RVA: 0x002108D0 File Offset: 0x0020EAD0
		public UKuroCrowdAiSubsystem() : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiSubsystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016A59 RID: 92761 RVA: 0x002108F8 File Offset: 0x0020EAF8
		[NullableContext(1)]
		public UKuroCrowdAiSubsystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCrowdAiSubsystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B90 RID: 23440
		// (get) Token: 0x06016A5A RID: 92762 RVA: 0x0021092B File Offset: 0x0020EB2B
		// (set) Token: 0x06016A5B RID: 92763 RVA: 0x0021093B File Offset: 0x0020EB3B
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

		// Token: 0x17005B91 RID: 23441
		// (get) Token: 0x06016A5C RID: 92764 RVA: 0x0021094C File Offset: 0x0020EB4C
		// (set) Token: 0x06016A5D RID: 92765 RVA: 0x0021095C File Offset: 0x0020EB5C
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

		// Token: 0x17005B92 RID: 23442
		// (get) Token: 0x06016A5E RID: 92766 RVA: 0x0021096D File Offset: 0x0020EB6D
		// (set) Token: 0x06016A5F RID: 92767 RVA: 0x0021097D File Offset: 0x0020EB7D
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

		// Token: 0x17005B93 RID: 23443
		// (get) Token: 0x06016A60 RID: 92768 RVA: 0x0021098E File Offset: 0x0020EB8E
		// (set) Token: 0x06016A61 RID: 92769 RVA: 0x0021099E File Offset: 0x0020EB9E
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

		// Token: 0x17005B94 RID: 23444
		// (get) Token: 0x06016A62 RID: 92770 RVA: 0x002109AF File Offset: 0x0020EBAF
		// (set) Token: 0x06016A63 RID: 92771 RVA: 0x002109BF File Offset: 0x0020EBBF
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

		// Token: 0x17005B95 RID: 23445
		// (get) Token: 0x06016A64 RID: 92772 RVA: 0x002109D0 File Offset: 0x0020EBD0
		// (set) Token: 0x06016A65 RID: 92773 RVA: 0x002109E0 File Offset: 0x0020EBE0
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

		// Token: 0x17005B96 RID: 23446
		// (get) Token: 0x06016A66 RID: 92774 RVA: 0x002109F1 File Offset: 0x0020EBF1
		// (set) Token: 0x06016A67 RID: 92775 RVA: 0x00210A01 File Offset: 0x0020EC01
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

		// Token: 0x17005B97 RID: 23447
		// (get) Token: 0x06016A68 RID: 92776 RVA: 0x00210A12 File Offset: 0x0020EC12
		// (set) Token: 0x06016A69 RID: 92777 RVA: 0x00210A22 File Offset: 0x0020EC22
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

		// Token: 0x17005B98 RID: 23448
		// (get) Token: 0x06016A6A RID: 92778 RVA: 0x00210A33 File Offset: 0x0020EC33
		// (set) Token: 0x06016A6B RID: 92779 RVA: 0x00210A43 File Offset: 0x0020EC43
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

		// Token: 0x17005B99 RID: 23449
		// (get) Token: 0x06016A6C RID: 92780 RVA: 0x00210A54 File Offset: 0x0020EC54
		// (set) Token: 0x06016A6D RID: 92781 RVA: 0x00210A64 File Offset: 0x0020EC64
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

		// Token: 0x17005B9A RID: 23450
		// (get) Token: 0x06016A6E RID: 92782 RVA: 0x00210A75 File Offset: 0x0020EC75
		// (set) Token: 0x06016A6F RID: 92783 RVA: 0x00210A85 File Offset: 0x0020EC85
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

		// Token: 0x17005B9B RID: 23451
		// (get) Token: 0x06016A70 RID: 92784 RVA: 0x00210A96 File Offset: 0x0020EC96
		// (set) Token: 0x06016A71 RID: 92785 RVA: 0x00210AA6 File Offset: 0x0020ECA6
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

		// Token: 0x17005B9C RID: 23452
		// (get) Token: 0x06016A72 RID: 92786 RVA: 0x00210AB7 File Offset: 0x0020ECB7
		// (set) Token: 0x06016A73 RID: 92787 RVA: 0x00210AC7 File Offset: 0x0020ECC7
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

		// Token: 0x17005B9D RID: 23453
		// (get) Token: 0x06016A74 RID: 92788 RVA: 0x00210AD8 File Offset: 0x0020ECD8
		// (set) Token: 0x06016A75 RID: 92789 RVA: 0x00210AE8 File Offset: 0x0020ECE8
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

		// Token: 0x17005B9E RID: 23454
		// (get) Token: 0x06016A76 RID: 92790 RVA: 0x00210AF9 File Offset: 0x0020ECF9
		// (set) Token: 0x06016A77 RID: 92791 RVA: 0x00210B09 File Offset: 0x0020ED09
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

		// Token: 0x17005B9F RID: 23455
		// (get) Token: 0x06016A78 RID: 92792 RVA: 0x00210B1A File Offset: 0x0020ED1A
		// (set) Token: 0x06016A79 RID: 92793 RVA: 0x00210B2A File Offset: 0x0020ED2A
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

		// Token: 0x17005BA0 RID: 23456
		// (get) Token: 0x06016A7A RID: 92794 RVA: 0x00210B3B File Offset: 0x0020ED3B
		// (set) Token: 0x06016A7B RID: 92795 RVA: 0x00210B4B File Offset: 0x0020ED4B
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

		// Token: 0x17005BA1 RID: 23457
		// (get) Token: 0x06016A7C RID: 92796 RVA: 0x00210B5C File Offset: 0x0020ED5C
		// (set) Token: 0x06016A7D RID: 92797 RVA: 0x00210B6C File Offset: 0x0020ED6C
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

		// Token: 0x17005BA2 RID: 23458
		// (get) Token: 0x06016A7E RID: 92798 RVA: 0x00210B7D File Offset: 0x0020ED7D
		// (set) Token: 0x06016A7F RID: 92799 RVA: 0x00210B8D File Offset: 0x0020ED8D
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

		// Token: 0x17005BA3 RID: 23459
		// (get) Token: 0x06016A80 RID: 92800 RVA: 0x00210B9E File Offset: 0x0020ED9E
		// (set) Token: 0x06016A81 RID: 92801 RVA: 0x00210BAE File Offset: 0x0020EDAE
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

		// Token: 0x17005BA4 RID: 23460
		// (get) Token: 0x06016A82 RID: 92802 RVA: 0x00210BBF File Offset: 0x0020EDBF
		// (set) Token: 0x06016A83 RID: 92803 RVA: 0x00210BCF File Offset: 0x0020EDCF
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

		// Token: 0x17005BA5 RID: 23461
		// (get) Token: 0x06016A84 RID: 92804 RVA: 0x00210BE0 File Offset: 0x0020EDE0
		// (set) Token: 0x06016A85 RID: 92805 RVA: 0x00210BF0 File Offset: 0x0020EDF0
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

		// Token: 0x06016A86 RID: 92806 RVA: 0x00210C04 File Offset: 0x0020EE04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool WasBoidControlledByCrowdAi(int BoidId)
		{
			UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__WasBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A87 RID: 92807 RVA: 0x00210C54 File Offset: 0x0020EE54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void UpdateDebugNavMeshEdges(in FBox Range)
		{
			UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams[(UIntPtr)43] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Range = Range;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__UpdateDebugNavMeshEdges_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016A88 RID: 92808 RVA: 0x00210CA0 File Offset: 0x0020EEA0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int SetWatchingBoidAndJoinGroup(int BoidId, int WatchingBoidId)
		{
			UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->WatchingBoidId = WatchingBoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetWatchingBoidAndJoinGroup_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A89 RID: 92809 RVA: 0x00210CF4 File Offset: 0x0020EEF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetBoidTransform(int BoidId, in FTransform NewTransform, bool bTeleport = false)
		{
			UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->NewTransform = NewTransform;
			ptr->bTeleport = bTeleport;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A8A RID: 92810 RVA: 0x00210D54 File Offset: 0x0020EF54
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetBoidScale(int BoidId, in FVector NewScale)
		{
			UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidScale_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidScale_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->NewScale = NewScale;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidScale_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A8B RID: 92811 RVA: 0x00210DB0 File Offset: 0x0020EFB0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SetBoidControlledByCrowdAi(int BoidId, bool Enable)
		{
			UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidControlledByCrowdAi_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A8C RID: 92812 RVA: 0x00210E04 File Offset: 0x0020F004
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_NativeFunctionPtr, (void*)ptr, 0);
			TArray<float> tarray2 = CustomDataArray;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CustomDataArray);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroCrowdAiSubsystem.__SetBoidAppearanceInfo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06016A8D RID: 92813 RVA: 0x00210E8C File Offset: 0x0020F08C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool RemoveBoid(int BoidId, bool bForce = false)
		{
			UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__RemoveBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__RemoveBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->bForce = bForce;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__RemoveBoid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A8E RID: 92814 RVA: 0x00210EE0 File Offset: 0x0020F0E0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector QueryUsablePositionForBoid(in FVector QueryPosition, float QueryRadius, float BoidRadius, int MaxTryCount = 8)
		{
			UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->QueryPosition = QueryPosition;
			ptr->QueryRadius = QueryRadius;
			ptr->BoidRadius = BoidRadius;
			ptr->MaxTryCount = MaxTryCount;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__QueryUsablePositionForBoid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A8F RID: 92815 RVA: 0x00210F48 File Offset: 0x0020F148
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void NotifyBoidsMoveTo(in FVector NewLocation)
		{
			UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NewLocation = NewLocation;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__NotifyBoidsMoveTo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016A90 RID: 92816 RVA: 0x00210F94 File Offset: 0x0020F194
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void NotifyBoidsAround()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__NotifyBoidsAround_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06016A91 RID: 92817 RVA: 0x00210FAC File Offset: 0x0020F1AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetBoidVelocity(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidVelocity_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A92 RID: 92818 RVA: 0x00210FFC File Offset: 0x0020F1FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform GetBoidTransform(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A93 RID: 92819 RVA: 0x0021104C File Offset: 0x0020F24C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FVector GetBoidLastVelocity(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidLastVelocity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidLastVelocity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidLastVelocity_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A94 RID: 92820 RVA: 0x0021109C File Offset: 0x0020F29C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FTransform GetBoidLastTransform(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidLastTransform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidLastTransform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidLastTransform_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A95 RID: 92821 RVA: 0x002110EC File Offset: 0x0020F2EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetBoidGroupId(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidGroupId_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidGroupId_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidGroupId_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A96 RID: 92822 RVA: 0x0021113C File Offset: 0x0020F33C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroCrowdAiBoidAnimUpdater GetBoidAnimUpdater(int BoidId)
		{
			UKuroCrowdAiSubsystem.__GetBoidAnimUpdater_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetBoidAnimUpdater_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetBoidAnimUpdater_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetBoidAnimUpdater_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetBoidAnimUpdater_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroCrowdAiBoidAnimUpdater>(ptr->__Result);
		}

		// Token: 0x06016A97 RID: 92823 RVA: 0x00211190 File Offset: 0x0020F390
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void GetAllGroupIds(ref TArray<int> OutGroupIds)
		{
			UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__GetAllGroupIds_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr, 1);
			TArray<int> tarray = OutGroupIds;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->OutGroupIds);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr, 0);
			TArray<int> tarray2 = OutGroupIds;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->OutGroupIds);
			}
			UnrealReflectionUtils.DestroyStruct(UKuroCrowdAiSubsystem.__GetAllGroupIds_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06016A98 RID: 92824 RVA: 0x0021120C File Offset: 0x0020F40C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableDebugMode(bool Enable)
		{
			UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__EnableDebugMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__EnableDebugMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Enable = Enable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__EnableDebugMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016A99 RID: 92825 RVA: 0x00211254 File Offset: 0x0020F454
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void EnableBoidIdlePerform(int BoidId, bool bEnable)
		{
			UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__EnableBoidIdlePerform_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06016A9A RID: 92826 RVA: 0x002112A4 File Offset: 0x0020F4A4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ChangeGroupWatchingBoid(int GroupId, int BoidId)
		{
			UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GroupId = GroupId;
			ptr->BoidId = BoidId;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__ChangeGroupWatchingBoid_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A9B RID: 92827 RVA: 0x002112F8 File Offset: 0x0020F4F8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoidStopAnimation(int BoidId, int AnimIndex, bool bImmediately = true)
		{
			UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__BoidStopAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__BoidStopAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->AnimIndex = AnimIndex;
			ptr->bImmediately = bImmediately;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__BoidStopAnimation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A9C RID: 92828 RVA: 0x00211354 File Offset: 0x0020F554
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool BoidPlayAnimation(int BoidId, int AnimIndex, float PlayRate = 1f, float StartPos = 0f, bool bIsLoop = false)
		{
			UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams* ptr = stackalloc UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams[(UIntPtr)35] + 15L / (long)sizeof(UKuroCrowdAiSubsystem.__BoidPlayAnimation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroCrowdAiSubsystem.__BoidPlayAnimation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->BoidId = BoidId;
			ptr->AnimIndex = AnimIndex;
			ptr->PlayRate = PlayRate;
			ptr->StartPos = StartPos;
			ptr->bIsLoop = bIsLoop;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroCrowdAiSubsystem.__BoidPlayAnimation_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06016A9D RID: 92829 RVA: 0x002113BF File Offset: 0x0020F5BF
		static UKuroCrowdAiSubsystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroCrowdAi.KuroCrowdAiSubsystem");
		}

		// Token: 0x06016A9E RID: 92830 RVA: 0x002113CD File Offset: 0x0020F5CD
		protected UKuroCrowdAiSubsystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C4BD RID: 50365
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroCrowdAi.KuroCrowdAiSubsystem";

		// Token: 0x0400C4BE RID: 50366
		private static IntPtr _ClassPtr;

		// Token: 0x0400C4BF RID: 50367
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C4C0 RID: 50368
		internal static int __PropertyOffset_GroupSplitRadius;

		// Token: 0x0400C4C1 RID: 50369
		internal static int __PropertyOffset_GroupNavigationInterval;

		// Token: 0x0400C4C2 RID: 50370
		internal static int __PropertyOffset_PauseSeekMinDist;

		// Token: 0x0400C4C3 RID: 50371
		internal static int __PropertyOffset_PauseSeekMaxTime;

		// Token: 0x0400C4C4 RID: 50372
		internal static int __PropertyOffset_PauseSeekMaxSpeed;

		// Token: 0x0400C4C5 RID: 50373
		internal static int __PropertyOffset_bEnableFollowLimitation;

		// Token: 0x0400C4C6 RID: 50374
		internal static int __PropertyOffset_FanWingEdgesAngle;

		// Token: 0x0400C4C7 RID: 50375
		internal static int __PropertyOffset_FanWingEdgesLen;

		// Token: 0x0400C4C8 RID: 50376
		internal static int __PropertyOffset_FanBottomEdgeHalfLen;

		// Token: 0x0400C4C9 RID: 50377
		internal static int __PropertyOffset_FanBottomEdgeDistToWatchingBoid;

		// Token: 0x0400C4CA RID: 50378
		internal static int __PropertyOffset_BornDelayMaxTime;

		// Token: 0x0400C4CB RID: 50379
		internal static int __PropertyOffset_DestroyDelayMaxTime;

		// Token: 0x0400C4CC RID: 50380
		internal static int __PropertyOffset_bEnableTeleport;

		// Token: 0x0400C4CD RID: 50381
		internal static int __PropertyOffset_TeleportMinPlanarDist;

		// Token: 0x0400C4CE RID: 50382
		internal static int __PropertyOffset_TeleportMinVerticalDist;

		// Token: 0x0400C4CF RID: 50383
		internal static int __PropertyOffset_PauseTeleportMaxPlanarSpeed;

		// Token: 0x0400C4D0 RID: 50384
		internal static int __PropertyOffset_TeleportMinTime;

		// Token: 0x0400C4D1 RID: 50385
		internal static int __PropertyOffset_TeleportMaxTime;

		// Token: 0x0400C4D2 RID: 50386
		internal static int __PropertyOffset_TeleportTargetMaxRadius;

		// Token: 0x0400C4D3 RID: 50387
		internal static int __PropertyOffset_TeleportTargetMinRadius;

		// Token: 0x0400C4D4 RID: 50388
		internal static int __PropertyOffset_TeleportTryCount;

		// Token: 0x0400C4D5 RID: 50389
		internal static int __PropertyOffset_bStickToGround;

		// Token: 0x0400C4D6 RID: 50390
		private static IntPtr __WasBoidControlledByCrowdAi_NativeFunctionPtr;

		// Token: 0x0400C4D7 RID: 50391
		private static IntPtr __UpdateDebugNavMeshEdges_NativeFunctionPtr;

		// Token: 0x0400C4D8 RID: 50392
		private static IntPtr __SetWatchingBoidAndJoinGroup_NativeFunctionPtr;

		// Token: 0x0400C4D9 RID: 50393
		private static IntPtr __SetBoidTransform_NativeFunctionPtr;

		// Token: 0x0400C4DA RID: 50394
		private static IntPtr __SetBoidScale_NativeFunctionPtr;

		// Token: 0x0400C4DB RID: 50395
		private static IntPtr __SetBoidControlledByCrowdAi_NativeFunctionPtr;

		// Token: 0x0400C4DC RID: 50396
		private static IntPtr __SetBoidAppearanceInfo_NativeFunctionPtr;

		// Token: 0x0400C4DD RID: 50397
		private static IntPtr __RemoveBoid_NativeFunctionPtr;

		// Token: 0x0400C4DE RID: 50398
		private static IntPtr __QueryUsablePositionForBoid_NativeFunctionPtr;

		// Token: 0x0400C4DF RID: 50399
		private static IntPtr __NotifyBoidsMoveTo_NativeFunctionPtr;

		// Token: 0x0400C4E0 RID: 50400
		private static IntPtr __NotifyBoidsAround_NativeFunctionPtr;

		// Token: 0x0400C4E1 RID: 50401
		private static IntPtr __GetBoidVelocity_NativeFunctionPtr;

		// Token: 0x0400C4E2 RID: 50402
		private static IntPtr __GetBoidTransform_NativeFunctionPtr;

		// Token: 0x0400C4E3 RID: 50403
		private static IntPtr __GetBoidLastVelocity_NativeFunctionPtr;

		// Token: 0x0400C4E4 RID: 50404
		private static IntPtr __GetBoidLastTransform_NativeFunctionPtr;

		// Token: 0x0400C4E5 RID: 50405
		private static IntPtr __GetBoidGroupId_NativeFunctionPtr;

		// Token: 0x0400C4E6 RID: 50406
		private static IntPtr __GetBoidAnimUpdater_NativeFunctionPtr;

		// Token: 0x0400C4E7 RID: 50407
		private static IntPtr __GetAllGroupIds_NativeFunctionPtr;

		// Token: 0x0400C4E8 RID: 50408
		private static IntPtr __EnableDebugMode_NativeFunctionPtr;

		// Token: 0x0400C4E9 RID: 50409
		private static IntPtr __EnableBoidIdlePerform_NativeFunctionPtr;

		// Token: 0x0400C4EA RID: 50410
		private static IntPtr __ChangeGroupWatchingBoid_NativeFunctionPtr;

		// Token: 0x0400C4EB RID: 50411
		private static IntPtr __BoidStopAnimation_NativeFunctionPtr;

		// Token: 0x0400C4EC RID: 50412
		private static IntPtr __BoidPlayAnimation_NativeFunctionPtr;

		// Token: 0x02002F35 RID: 12085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __WasBoidControlledByCrowdAi_FunctionParams
		{
			// Token: 0x04016AB2 RID: 92850
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AB3 RID: 92851
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02002F36 RID: 12086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 28)]
		protected ref struct __UpdateDebugNavMeshEdges_FunctionParams
		{
			// Token: 0x04016AB4 RID: 92852
			[FieldOffset(0)]
			public FBox Range;
		}

		// Token: 0x02002F37 RID: 12087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __SetWatchingBoidAndJoinGroup_FunctionParams
		{
			// Token: 0x04016AB5 RID: 92853
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AB6 RID: 92854
			[FieldOffset(4)]
			public int WatchingBoidId;

			// Token: 0x04016AB7 RID: 92855
			[FieldOffset(8)]
			public int __Result;
		}

		// Token: 0x02002F38 RID: 12088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __SetBoidTransform_FunctionParams
		{
			// Token: 0x04016AB8 RID: 92856
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AB9 RID: 92857
			[FieldOffset(16)]
			public FTransform NewTransform;

			// Token: 0x04016ABA RID: 92858
			[FieldOffset(64)]
			public bool bTeleport;

			// Token: 0x04016ABB RID: 92859
			[FieldOffset(65)]
			public bool __Result;
		}

		// Token: 0x02002F39 RID: 12089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __SetBoidScale_FunctionParams
		{
			// Token: 0x04016ABC RID: 92860
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016ABD RID: 92861
			[FieldOffset(4)]
			public FVector NewScale;

			// Token: 0x04016ABE RID: 92862
			[FieldOffset(16)]
			public bool __Result;
		}

		// Token: 0x02002F3A RID: 12090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __SetBoidControlledByCrowdAi_FunctionParams
		{
			// Token: 0x04016ABF RID: 92863
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AC0 RID: 92864
			[FieldOffset(4)]
			public bool Enable;

			// Token: 0x04016AC1 RID: 92865
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02002F3B RID: 12091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetBoidAppearanceInfo_FunctionParams
		{
			// Token: 0x04016AC2 RID: 92866
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AC3 RID: 92867
			[FieldOffset(8)]
			public byte CustomDataArray;

			// Token: 0x04016AC4 RID: 92868
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02002F3C RID: 12092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __RemoveBoid_FunctionParams
		{
			// Token: 0x04016AC5 RID: 92869
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AC6 RID: 92870
			[FieldOffset(4)]
			public bool bForce;

			// Token: 0x04016AC7 RID: 92871
			[FieldOffset(5)]
			public bool __Result;
		}

		// Token: 0x02002F3D RID: 12093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __QueryUsablePositionForBoid_FunctionParams
		{
			// Token: 0x04016AC8 RID: 92872
			[FieldOffset(0)]
			public FVector QueryPosition;

			// Token: 0x04016AC9 RID: 92873
			[FieldOffset(12)]
			public float QueryRadius;

			// Token: 0x04016ACA RID: 92874
			[FieldOffset(16)]
			public float BoidRadius;

			// Token: 0x04016ACB RID: 92875
			[FieldOffset(20)]
			public int MaxTryCount;

			// Token: 0x04016ACC RID: 92876
			[FieldOffset(24)]
			public FVector __Result;
		}

		// Token: 0x02002F3E RID: 12094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __NotifyBoidsMoveTo_FunctionParams
		{
			// Token: 0x04016ACD RID: 92877
			[FieldOffset(0)]
			public FVector NewLocation;
		}

		// Token: 0x02002F3F RID: 12095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoidVelocity_FunctionParams
		{
			// Token: 0x04016ACE RID: 92878
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016ACF RID: 92879
			[FieldOffset(4)]
			public FVector __Result;
		}

		// Token: 0x02002F40 RID: 12096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetBoidTransform_FunctionParams
		{
			// Token: 0x04016AD0 RID: 92880
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AD1 RID: 92881
			[FieldOffset(16)]
			public FTransform __Result;
		}

		// Token: 0x02002F41 RID: 12097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoidLastVelocity_FunctionParams
		{
			// Token: 0x04016AD2 RID: 92882
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AD3 RID: 92883
			[FieldOffset(4)]
			public FVector __Result;
		}

		// Token: 0x02002F42 RID: 12098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetBoidLastTransform_FunctionParams
		{
			// Token: 0x04016AD4 RID: 92884
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AD5 RID: 92885
			[FieldOffset(16)]
			public FTransform __Result;
		}

		// Token: 0x02002F43 RID: 12099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetBoidGroupId_FunctionParams
		{
			// Token: 0x04016AD6 RID: 92886
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AD7 RID: 92887
			[FieldOffset(4)]
			public int __Result;
		}

		// Token: 0x02002F44 RID: 12100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetBoidAnimUpdater_FunctionParams
		{
			// Token: 0x04016AD8 RID: 92888
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AD9 RID: 92889
			[FieldOffset(8)]
			public IntPtr __Result;
		}

		// Token: 0x02002F45 RID: 12101
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllGroupIds_FunctionParams
		{
			// Token: 0x04016ADA RID: 92890
			[FieldOffset(0)]
			public byte OutGroupIds;
		}

		// Token: 0x02002F46 RID: 12102
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __EnableDebugMode_FunctionParams
		{
			// Token: 0x04016ADB RID: 92891
			[FieldOffset(0)]
			public bool Enable;
		}

		// Token: 0x02002F47 RID: 12103
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __EnableBoidIdlePerform_FunctionParams
		{
			// Token: 0x04016ADC RID: 92892
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016ADD RID: 92893
			[FieldOffset(4)]
			public bool bEnable;
		}

		// Token: 0x02002F48 RID: 12104
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __ChangeGroupWatchingBoid_FunctionParams
		{
			// Token: 0x04016ADE RID: 92894
			[FieldOffset(0)]
			public int GroupId;

			// Token: 0x04016ADF RID: 92895
			[FieldOffset(4)]
			public int BoidId;

			// Token: 0x04016AE0 RID: 92896
			[FieldOffset(8)]
			public bool __Result;
		}

		// Token: 0x02002F49 RID: 12105
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __BoidStopAnimation_FunctionParams
		{
			// Token: 0x04016AE1 RID: 92897
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AE2 RID: 92898
			[FieldOffset(4)]
			public int AnimIndex;

			// Token: 0x04016AE3 RID: 92899
			[FieldOffset(8)]
			public bool bImmediately;

			// Token: 0x04016AE4 RID: 92900
			[FieldOffset(9)]
			public bool __Result;
		}

		// Token: 0x02002F4A RID: 12106
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 20)]
		protected ref struct __BoidPlayAnimation_FunctionParams
		{
			// Token: 0x04016AE5 RID: 92901
			[FieldOffset(0)]
			public int BoidId;

			// Token: 0x04016AE6 RID: 92902
			[FieldOffset(4)]
			public int AnimIndex;

			// Token: 0x04016AE7 RID: 92903
			[FieldOffset(8)]
			public float PlayRate;

			// Token: 0x04016AE8 RID: 92904
			[FieldOffset(12)]
			public float StartPos;

			// Token: 0x04016AE9 RID: 92905
			[FieldOffset(16)]
			public bool bIsLoop;

			// Token: 0x04016AEA RID: 92906
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
