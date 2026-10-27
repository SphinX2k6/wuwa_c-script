using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A91 RID: 6801
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPUHourglassActor")]
	[UnrealStructLayout(1952, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1952)]
	public class AFallingSandGPUHourglassActor : AFallingSandGPU3DActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601912F RID: 102703 RVA: 0x00250830 File Offset: 0x0024EA30
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AFallingSandGPUHourglassActor._ClassPtr;
		}

		// Token: 0x06019130 RID: 102704 RVA: 0x0025083C File Offset: 0x0024EA3C
		public AFallingSandGPUHourglassActor() : this(BuiltinUtils.AllocNativeUObject(AFallingSandGPUHourglassActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019131 RID: 102705 RVA: 0x00250864 File Offset: 0x0024EA64
		[NullableContext(1)]
		public AFallingSandGPUHourglassActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AFallingSandGPUHourglassActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006393 RID: 25491
		// (get) Token: 0x06019132 RID: 102706 RVA: 0x00250897 File Offset: 0x0024EA97
		// (set) Token: 0x06019133 RID: 102707 RVA: 0x002508AB File Offset: 0x0024EAAB
		public unsafe FIntVector HourglassVolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVolumeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVolumeSize) = value;
			}
		}

		// Token: 0x17006394 RID: 25492
		// (get) Token: 0x06019134 RID: 102708 RVA: 0x002508C0 File Offset: 0x0024EAC0
		// (set) Token: 0x06019135 RID: 102709 RVA: 0x002508D0 File Offset: 0x0024EAD0
		public unsafe float HourglassVolumeEdgeLengthCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVolumeEdgeLengthCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVolumeEdgeLengthCm) = value;
			}
		}

		// Token: 0x17006395 RID: 25493
		// (get) Token: 0x06019136 RID: 102710 RVA: 0x002508E1 File Offset: 0x0024EAE1
		// (set) Token: 0x06019137 RID: 102711 RVA: 0x002508F1 File Offset: 0x0024EAF1
		public unsafe float HourglassInitialSandProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassInitialSandProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassInitialSandProbability) = value;
			}
		}

		// Token: 0x17006396 RID: 25494
		// (get) Token: 0x06019138 RID: 102712 RVA: 0x00250902 File Offset: 0x0024EB02
		// (set) Token: 0x06019139 RID: 102713 RVA: 0x00250912 File Offset: 0x0024EB12
		public unsafe int HourglassInitialSandTopLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassInitialSandTopLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassInitialSandTopLayers) = value;
			}
		}

		// Token: 0x17006397 RID: 25495
		// (get) Token: 0x0601913A RID: 102714 RVA: 0x00250923 File Offset: 0x0024EB23
		// (set) Token: 0x0601913B RID: 102715 RVA: 0x00250933 File Offset: 0x0024EB33
		public unsafe float PresetHourglassHalfHeightLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassHalfHeightLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassHalfHeightLp) = value;
			}
		}

		// Token: 0x17006398 RID: 25496
		// (get) Token: 0x0601913C RID: 102716 RVA: 0x00250944 File Offset: 0x0024EB44
		// (set) Token: 0x0601913D RID: 102717 RVA: 0x00250954 File Offset: 0x0024EB54
		public unsafe float PresetHourglassNeckRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassNeckRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassNeckRadiusLp) = value;
			}
		}

		// Token: 0x17006399 RID: 25497
		// (get) Token: 0x0601913E RID: 102718 RVA: 0x00250965 File Offset: 0x0024EB65
		// (set) Token: 0x0601913F RID: 102719 RVA: 0x00250975 File Offset: 0x0024EB75
		public unsafe float PresetHourglassBellyRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassBellyRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassBellyRadiusLp) = value;
			}
		}

		// Token: 0x1700639A RID: 25498
		// (get) Token: 0x06019140 RID: 102720 RVA: 0x00250986 File Offset: 0x0024EB86
		// (set) Token: 0x06019141 RID: 102721 RVA: 0x00250996 File Offset: 0x0024EB96
		public unsafe float PresetHourglassRimRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassRimRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassRimRadiusLp) = value;
			}
		}

		// Token: 0x1700639B RID: 25499
		// (get) Token: 0x06019142 RID: 102722 RVA: 0x002509A7 File Offset: 0x0024EBA7
		// (set) Token: 0x06019143 RID: 102723 RVA: 0x002509B7 File Offset: 0x0024EBB7
		public unsafe float PresetHourglassBellyPositionU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassBellyPositionU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_PresetHourglassBellyPositionU) = value;
			}
		}

		// Token: 0x1700639C RID: 25500
		// (get) Token: 0x06019144 RID: 102724 RVA: 0x002509C8 File Offset: 0x0024EBC8
		// (set) Token: 0x06019145 RID: 102725 RVA: 0x002509D8 File Offset: 0x0024EBD8
		public unsafe bool bHourglassDebugDrawContainer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassDebugDrawContainer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassDebugDrawContainer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700639D RID: 25501
		// (get) Token: 0x06019146 RID: 102726 RVA: 0x002509E9 File Offset: 0x0024EBE9
		// (set) Token: 0x06019147 RID: 102727 RVA: 0x002509F9 File Offset: 0x0024EBF9
		public unsafe float HourglassSandFlow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSandFlow);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSandFlow) = value;
			}
		}

		// Token: 0x1700639E RID: 25502
		// (get) Token: 0x06019148 RID: 102728 RVA: 0x00250A0A File Offset: 0x0024EC0A
		// (set) Token: 0x06019149 RID: 102729 RVA: 0x00250A1A File Offset: 0x0024EC1A
		public unsafe float HourglassPileStability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassPileStability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassPileStability) = value;
			}
		}

		// Token: 0x1700639F RID: 25503
		// (get) Token: 0x0601914A RID: 102730 RVA: 0x00250A2B File Offset: 0x0024EC2B
		// (set) Token: 0x0601914B RID: 102731 RVA: 0x00250A3B File Offset: 0x0024EC3B
		public unsafe int HourglassRayMarchMaxSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchMaxSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchMaxSteps) = value;
			}
		}

		// Token: 0x170063A0 RID: 25504
		// (get) Token: 0x0601914C RID: 102732 RVA: 0x00250A4C File Offset: 0x0024EC4C
		// (set) Token: 0x0601914D RID: 102733 RVA: 0x00250A5C File Offset: 0x0024EC5C
		public unsafe float HourglassRayMarchDither
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchDither);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchDither) = value;
			}
		}

		// Token: 0x170063A1 RID: 25505
		// (get) Token: 0x0601914E RID: 102734 RVA: 0x00250A6D File Offset: 0x0024EC6D
		// (set) Token: 0x0601914F RID: 102735 RVA: 0x00250A7D File Offset: 0x0024EC7D
		public unsafe float HourglassRayMarchOpacityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchOpacityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassRayMarchOpacityScale) = value;
			}
		}

		// Token: 0x170063A2 RID: 25506
		// (get) Token: 0x06019150 RID: 102736 RVA: 0x00250A8E File Offset: 0x0024EC8E
		// (set) Token: 0x06019151 RID: 102737 RVA: 0x00250A9E File Offset: 0x0024EC9E
		public unsafe int HourglassSimPassesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSimPassesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSimPassesPerFrame) = value;
			}
		}

		// Token: 0x170063A3 RID: 25507
		// (get) Token: 0x06019152 RID: 102738 RVA: 0x00250AAF File Offset: 0x0024ECAF
		// (set) Token: 0x06019153 RID: 102739 RVA: 0x00250ABF File Offset: 0x0024ECBF
		public unsafe float HourglassSimUpdateHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSimUpdateHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassSimUpdateHz) = value;
			}
		}

		// Token: 0x170063A4 RID: 25508
		// (get) Token: 0x06019154 RID: 102740 RVA: 0x00250AD0 File Offset: 0x0024ECD0
		// (set) Token: 0x06019155 RID: 102741 RVA: 0x00250AE0 File Offset: 0x0024ECE0
		public unsafe bool bHourglassLimitSimToContainer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassLimitSimToContainer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassLimitSimToContainer) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063A5 RID: 25509
		// (get) Token: 0x06019156 RID: 102742 RVA: 0x00250AF1 File Offset: 0x0024ECF1
		// (set) Token: 0x06019157 RID: 102743 RVA: 0x00250B01 File Offset: 0x0024ED01
		public unsafe bool bHourglassAutoSleepCAWhenStill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassAutoSleepCAWhenStill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassAutoSleepCAWhenStill) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063A6 RID: 25510
		// (get) Token: 0x06019158 RID: 102744 RVA: 0x00250B12 File Offset: 0x0024ED12
		// (set) Token: 0x06019159 RID: 102745 RVA: 0x00250B22 File Offset: 0x0024ED22
		public unsafe float HourglassAutoSleepCAStillDelaySec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassAutoSleepCAStillDelaySec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassAutoSleepCAStillDelaySec) = value;
			}
		}

		// Token: 0x170063A7 RID: 25511
		// (get) Token: 0x0601915A RID: 102746 RVA: 0x00250B33 File Offset: 0x0024ED33
		// (set) Token: 0x0601915B RID: 102747 RVA: 0x00250B43 File Offset: 0x0024ED43
		public unsafe bool bHourglassPaused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassPaused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassPaused) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063A8 RID: 25512
		// (get) Token: 0x0601915C RID: 102748 RVA: 0x00250B54 File Offset: 0x0024ED54
		// (set) Token: 0x0601915D RID: 102749 RVA: 0x00250B64 File Offset: 0x0024ED64
		public unsafe bool bHourglassRigidPullbackFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassRigidPullbackFollow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_bHourglassRigidPullbackFollow) = (value ? 1 : 0);
			}
		}

		// Token: 0x170063A9 RID: 25513
		// (get) Token: 0x0601915E RID: 102750 RVA: 0x00250B75 File Offset: 0x0024ED75
		// (set) Token: 0x0601915F RID: 102751 RVA: 0x00250B85 File Offset: 0x0024ED85
		public unsafe float HourglassPullbackMinRotAngleDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassPullbackMinRotAngleDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPUHourglassActor.__PropertyOffset_HourglassPullbackMinRotAngleDeg) = value;
			}
		}

		// Token: 0x170063AA RID: 25514
		// (get) Token: 0x06019160 RID: 102752 RVA: 0x00250B96 File Offset: 0x0024ED96
		// (set) Token: 0x06019161 RID: 102753 RVA: 0x00250BAA File Offset: 0x0024EDAA
		public unsafe UStaticMeshComponent HourglassVisualMesh
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVisualMesh);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVisualMesh, value);
			}
		}

		// Token: 0x170063AB RID: 25515
		// (get) Token: 0x06019162 RID: 102754 RVA: 0x00250BBF File Offset: 0x0024EDBF
		// (set) Token: 0x06019163 RID: 102755 RVA: 0x00250BD3 File Offset: 0x0024EDD3
		public unsafe USceneComponent SceneRoot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_SceneRoot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_SceneRoot, value);
			}
		}

		// Token: 0x170063AC RID: 25516
		// (get) Token: 0x06019164 RID: 102756 RVA: 0x00250BE8 File Offset: 0x0024EDE8
		// (set) Token: 0x06019165 RID: 102757 RVA: 0x00250BFC File Offset: 0x0024EDFC
		public unsafe USceneComponent HourglassVisualPivot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVisualPivot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AFallingSandGPUHourglassActor.__PropertyOffset_HourglassVisualPivot, value);
			}
		}

		// Token: 0x06019166 RID: 102758 RVA: 0x00250C11 File Offset: 0x0024EE11
		public void HourglassSwayLeftRight()
		{
			AFallingSandGPUHourglassActor.__HourglassSwayLeftRight_Internal(base.NativePtr);
		}

		// Token: 0x06019167 RID: 102759 RVA: 0x00250C1E File Offset: 0x0024EE1E
		public void HourglassRotate360AroundX()
		{
			AFallingSandGPUHourglassActor.__HourglassRotate360AroundX_Internal(base.NativePtr);
		}

		// Token: 0x06019168 RID: 102760 RVA: 0x00250C2B File Offset: 0x0024EE2B
		public void HourglassRotate180AroundX()
		{
			AFallingSandGPUHourglassActor.__HourglassRotate180AroundX_Internal(base.NativePtr);
		}

		// Token: 0x06019169 RID: 102761 RVA: 0x00250C38 File Offset: 0x0024EE38
		public void HourglassPanLeftRight()
		{
			AFallingSandGPUHourglassActor.__HourglassPanLeftRight_Internal(base.NativePtr);
		}

		// Token: 0x0601916A RID: 102762 RVA: 0x00250C45 File Offset: 0x0024EE45
		public void HourglassClearSand()
		{
			AFallingSandGPUHourglassActor.__HourglassClearSand_Internal(base.NativePtr);
		}

		// Token: 0x0601916B RID: 102763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HourglassSwayLeftRight_Internal(IntPtr @this);

		// Token: 0x0601916C RID: 102764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HourglassRotate360AroundX_Internal(IntPtr @this);

		// Token: 0x0601916D RID: 102765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HourglassRotate180AroundX_Internal(IntPtr @this);

		// Token: 0x0601916E RID: 102766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HourglassPanLeftRight_Internal(IntPtr @this);

		// Token: 0x0601916F RID: 102767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __HourglassClearSand_Internal(IntPtr @this);

		// Token: 0x06019170 RID: 102768 RVA: 0x00250C52 File Offset: 0x0024EE52
		static AFallingSandGPUHourglassActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPUHourglassActor");
		}

		// Token: 0x06019171 RID: 102769 RVA: 0x00250C60 File Offset: 0x0024EE60
		protected AFallingSandGPUHourglassActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DAAD RID: 55981
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPUHourglassActor";

		// Token: 0x0400DAAE RID: 55982
		private static IntPtr _ClassPtr;

		// Token: 0x0400DAAF RID: 55983
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DAB0 RID: 55984
		internal static int __PropertyOffset_HourglassVolumeSize;

		// Token: 0x0400DAB1 RID: 55985
		internal static int __PropertyOffset_HourglassVolumeEdgeLengthCm;

		// Token: 0x0400DAB2 RID: 55986
		internal static int __PropertyOffset_HourglassInitialSandProbability;

		// Token: 0x0400DAB3 RID: 55987
		internal static int __PropertyOffset_HourglassInitialSandTopLayers;

		// Token: 0x0400DAB4 RID: 55988
		internal static int __PropertyOffset_PresetHourglassHalfHeightLp;

		// Token: 0x0400DAB5 RID: 55989
		internal static int __PropertyOffset_PresetHourglassNeckRadiusLp;

		// Token: 0x0400DAB6 RID: 55990
		internal static int __PropertyOffset_PresetHourglassBellyRadiusLp;

		// Token: 0x0400DAB7 RID: 55991
		internal static int __PropertyOffset_PresetHourglassRimRadiusLp;

		// Token: 0x0400DAB8 RID: 55992
		internal static int __PropertyOffset_PresetHourglassBellyPositionU;

		// Token: 0x0400DAB9 RID: 55993
		internal static int __PropertyOffset_bHourglassDebugDrawContainer;

		// Token: 0x0400DABA RID: 55994
		internal static int __PropertyOffset_HourglassSandFlow;

		// Token: 0x0400DABB RID: 55995
		internal static int __PropertyOffset_HourglassPileStability;

		// Token: 0x0400DABC RID: 55996
		internal static int __PropertyOffset_HourglassRayMarchMaxSteps;

		// Token: 0x0400DABD RID: 55997
		internal static int __PropertyOffset_HourglassRayMarchDither;

		// Token: 0x0400DABE RID: 55998
		internal static int __PropertyOffset_HourglassRayMarchOpacityScale;

		// Token: 0x0400DABF RID: 55999
		internal static int __PropertyOffset_HourglassSimPassesPerFrame;

		// Token: 0x0400DAC0 RID: 56000
		internal static int __PropertyOffset_HourglassSimUpdateHz;

		// Token: 0x0400DAC1 RID: 56001
		internal static int __PropertyOffset_bHourglassLimitSimToContainer;

		// Token: 0x0400DAC2 RID: 56002
		internal static int __PropertyOffset_bHourglassAutoSleepCAWhenStill;

		// Token: 0x0400DAC3 RID: 56003
		internal static int __PropertyOffset_HourglassAutoSleepCAStillDelaySec;

		// Token: 0x0400DAC4 RID: 56004
		internal static int __PropertyOffset_bHourglassPaused;

		// Token: 0x0400DAC5 RID: 56005
		internal static int __PropertyOffset_bHourglassRigidPullbackFollow;

		// Token: 0x0400DAC6 RID: 56006
		internal static int __PropertyOffset_HourglassPullbackMinRotAngleDeg;

		// Token: 0x0400DAC7 RID: 56007
		internal static int __PropertyOffset_HourglassVisualMesh;

		// Token: 0x0400DAC8 RID: 56008
		internal static int __PropertyOffset_SceneRoot;

		// Token: 0x0400DAC9 RID: 56009
		internal static int __PropertyOffset_HourglassVisualPivot;
	}
}
