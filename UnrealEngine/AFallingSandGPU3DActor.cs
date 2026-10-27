using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001A90 RID: 6800
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPU3DActor")]
	[UnrealStructLayout(1824, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1824)]
	public class AFallingSandGPU3DActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06019096 RID: 102550 RVA: 0x0024FE9C File Offset: 0x0024E09C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AFallingSandGPU3DActor._ClassPtr;
		}

		// Token: 0x06019097 RID: 102551 RVA: 0x0024FEA8 File Offset: 0x0024E0A8
		public AFallingSandGPU3DActor() : this(BuiltinUtils.AllocNativeUObject(AFallingSandGPU3DActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06019098 RID: 102552 RVA: 0x0024FED0 File Offset: 0x0024E0D0
		[NullableContext(1)]
		public AFallingSandGPU3DActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AFallingSandGPU3DActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006350 RID: 25424
		// (get) Token: 0x06019099 RID: 102553 RVA: 0x0024FF03 File Offset: 0x0024E103
		// (set) Token: 0x0601909A RID: 102554 RVA: 0x0024FF17 File Offset: 0x0024E117
		public unsafe FIntVector VolumeSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VolumeSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VolumeSize) = value;
			}
		}

		// Token: 0x17006351 RID: 25425
		// (get) Token: 0x0601909B RID: 102555 RVA: 0x0024FF2C File Offset: 0x0024E12C
		// (set) Token: 0x0601909C RID: 102556 RVA: 0x0024FF3C File Offset: 0x0024E13C
		public unsafe float VolumeEdgeLengthCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VolumeEdgeLengthCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VolumeEdgeLengthCm) = value;
			}
		}

		// Token: 0x17006352 RID: 25426
		// (get) Token: 0x0601909D RID: 102557 RVA: 0x0024FF4D File Offset: 0x0024E14D
		// (set) Token: 0x0601909E RID: 102558 RVA: 0x0024FF5D File Offset: 0x0024E15D
		public unsafe float InitialSandProbability
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_InitialSandProbability);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_InitialSandProbability) = value;
			}
		}

		// Token: 0x17006353 RID: 25427
		// (get) Token: 0x0601909F RID: 102559 RVA: 0x0024FF6E File Offset: 0x0024E16E
		// (set) Token: 0x060190A0 RID: 102560 RVA: 0x0024FF7E File Offset: 0x0024E17E
		public unsafe int InitialSandTopLayers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_InitialSandTopLayers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_InitialSandTopLayers) = value;
			}
		}

		// Token: 0x17006354 RID: 25428
		// (get) Token: 0x060190A1 RID: 102561 RVA: 0x0024FF8F File Offset: 0x0024E18F
		// (set) Token: 0x060190A2 RID: 102562 RVA: 0x0024FF9F File Offset: 0x0024E19F
		public unsafe bool bRainSandEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRainSandEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRainSandEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006355 RID: 25429
		// (get) Token: 0x060190A3 RID: 102563 RVA: 0x0024FFB0 File Offset: 0x0024E1B0
		// (set) Token: 0x060190A4 RID: 102564 RVA: 0x0024FFC0 File Offset: 0x0024E1C0
		public unsafe float RainSandRadiusCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RainSandRadiusCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RainSandRadiusCm) = value;
			}
		}

		// Token: 0x17006356 RID: 25430
		// (get) Token: 0x060190A5 RID: 102565 RVA: 0x0024FFD1 File Offset: 0x0024E1D1
		// (set) Token: 0x060190A6 RID: 102566 RVA: 0x0024FFE1 File Offset: 0x0024E1E1
		public unsafe float RainSandInsetFromTopCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RainSandInsetFromTopCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RainSandInsetFromTopCm) = value;
			}
		}

		// Token: 0x17006357 RID: 25431
		// (get) Token: 0x060190A7 RID: 102567 RVA: 0x0024FFF2 File Offset: 0x0024E1F2
		// (set) Token: 0x060190A8 RID: 102568 RVA: 0x00250002 File Offset: 0x0024E202
		public unsafe bool bVirtualSqrt2SandCube
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bVirtualSqrt2SandCube) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bVirtualSqrt2SandCube) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006358 RID: 25432
		// (get) Token: 0x060190A9 RID: 102569 RVA: 0x00250013 File Offset: 0x0024E213
		// (set) Token: 0x060190AA RID: 102570 RVA: 0x00250023 File Offset: 0x0024E223
		public unsafe float VirtualSandCubeHalfEdge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VirtualSandCubeHalfEdge);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VirtualSandCubeHalfEdge) = value;
			}
		}

		// Token: 0x17006359 RID: 25433
		// (get) Token: 0x060190AB RID: 102571 RVA: 0x00250034 File Offset: 0x0024E234
		// (set) Token: 0x060190AC RID: 102572 RVA: 0x00250044 File Offset: 0x0024E244
		public unsafe bool bFP32SimVolume
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bFP32SimVolume) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bFP32SimVolume) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635A RID: 25434
		// (get) Token: 0x060190AD RID: 102573 RVA: 0x00250055 File Offset: 0x0024E255
		// (set) Token: 0x060190AE RID: 102574 RVA: 0x00250065 File Offset: 0x0024E265
		public unsafe bool bExtendedSandDensityEncoding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bExtendedSandDensityEncoding) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bExtendedSandDensityEncoding) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635B RID: 25435
		// (get) Token: 0x060190AF RID: 102575 RVA: 0x00250076 File Offset: 0x0024E276
		// (set) Token: 0x060190B0 RID: 102576 RVA: 0x00250086 File Offset: 0x0024E286
		public unsafe bool bLdsHaloPurify
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLdsHaloPurify) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLdsHaloPurify) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635C RID: 25436
		// (get) Token: 0x060190B1 RID: 102577 RVA: 0x00250097 File Offset: 0x0024E297
		// (set) Token: 0x060190B2 RID: 102578 RVA: 0x002500A7 File Offset: 0x0024E2A7
		public unsafe bool bRainSandUseVirtualCubeTopCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRainSandUseVirtualCubeTopCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRainSandUseVirtualCubeTopCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635D RID: 25437
		// (get) Token: 0x060190B3 RID: 102579 RVA: 0x002500B8 File Offset: 0x0024E2B8
		// (set) Token: 0x060190B4 RID: 102580 RVA: 0x002500C8 File Offset: 0x0024E2C8
		public unsafe bool bDebugDrawSandContainer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawSandContainer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawSandContainer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635E RID: 25438
		// (get) Token: 0x060190B5 RID: 102581 RVA: 0x002500D9 File Offset: 0x0024E2D9
		// (set) Token: 0x060190B6 RID: 102582 RVA: 0x002500E9 File Offset: 0x0024E2E9
		public unsafe bool bVirtualHourglassContainer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bVirtualHourglassContainer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bVirtualHourglassContainer) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700635F RID: 25439
		// (get) Token: 0x060190B7 RID: 102583 RVA: 0x002500FA File Offset: 0x0024E2FA
		// (set) Token: 0x060190B8 RID: 102584 RVA: 0x0025010A File Offset: 0x0024E30A
		public unsafe float HourglassHalfHeightLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassHalfHeightLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassHalfHeightLp) = value;
			}
		}

		// Token: 0x17006360 RID: 25440
		// (get) Token: 0x060190B9 RID: 102585 RVA: 0x0025011B File Offset: 0x0024E31B
		// (set) Token: 0x060190BA RID: 102586 RVA: 0x0025012B File Offset: 0x0024E32B
		public unsafe float HourglassNeckRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassNeckRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassNeckRadiusLp) = value;
			}
		}

		// Token: 0x17006361 RID: 25441
		// (get) Token: 0x060190BB RID: 102587 RVA: 0x0025013C File Offset: 0x0024E33C
		// (set) Token: 0x060190BC RID: 102588 RVA: 0x0025014C File Offset: 0x0024E34C
		public unsafe float HourglassBellyRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassBellyRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassBellyRadiusLp) = value;
			}
		}

		// Token: 0x17006362 RID: 25442
		// (get) Token: 0x060190BD RID: 102589 RVA: 0x0025015D File Offset: 0x0024E35D
		// (set) Token: 0x060190BE RID: 102590 RVA: 0x0025016D File Offset: 0x0024E36D
		public unsafe float HourglassRimRadiusLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassRimRadiusLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassRimRadiusLp) = value;
			}
		}

		// Token: 0x17006363 RID: 25443
		// (get) Token: 0x060190BF RID: 102591 RVA: 0x0025017E File Offset: 0x0024E37E
		// (set) Token: 0x060190C0 RID: 102592 RVA: 0x0025018E File Offset: 0x0024E38E
		public unsafe float HourglassBellyPositionU
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassBellyPositionU);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassBellyPositionU) = value;
			}
		}

		// Token: 0x17006364 RID: 25444
		// (get) Token: 0x060190C1 RID: 102593 RVA: 0x0025019F File Offset: 0x0024E39F
		// (set) Token: 0x060190C2 RID: 102594 RVA: 0x002501AF File Offset: 0x0024E3AF
		public unsafe float HourglassSmoothBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassSmoothBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_HourglassSmoothBlend) = value;
			}
		}

		// Token: 0x17006365 RID: 25445
		// (get) Token: 0x060190C3 RID: 102595 RVA: 0x002501C0 File Offset: 0x0024E3C0
		// (set) Token: 0x060190C4 RID: 102596 RVA: 0x002501D0 File Offset: 0x0024E3D0
		public unsafe int RayMarchMaxSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchMaxSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchMaxSteps) = value;
			}
		}

		// Token: 0x17006366 RID: 25446
		// (get) Token: 0x060190C5 RID: 102597 RVA: 0x002501E1 File Offset: 0x0024E3E1
		// (set) Token: 0x060190C6 RID: 102598 RVA: 0x002501F1 File Offset: 0x0024E3F1
		public unsafe float RayMarchJitterStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchJitterStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchJitterStrength) = value;
			}
		}

		// Token: 0x17006367 RID: 25447
		// (get) Token: 0x060190C7 RID: 102599 RVA: 0x00250202 File Offset: 0x0024E402
		// (set) Token: 0x060190C8 RID: 102600 RVA: 0x00250212 File Offset: 0x0024E412
		public unsafe float RayMarchSelfShadowStepCm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSelfShadowStepCm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSelfShadowStepCm) = value;
			}
		}

		// Token: 0x17006368 RID: 25448
		// (get) Token: 0x060190C9 RID: 102601 RVA: 0x00250223 File Offset: 0x0024E423
		// (set) Token: 0x060190CA RID: 102602 RVA: 0x00250233 File Offset: 0x0024E433
		public unsafe int RayMarchSelfShadowMaxSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSelfShadowMaxSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSelfShadowMaxSteps) = value;
			}
		}

		// Token: 0x17006369 RID: 25449
		// (get) Token: 0x060190CB RID: 102603 RVA: 0x00250244 File Offset: 0x0024E444
		// (set) Token: 0x060190CC RID: 102604 RVA: 0x00250254 File Offset: 0x0024E454
		public unsafe float RayMarchSandOpacityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSandOpacityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchSandOpacityScale) = value;
			}
		}

		// Token: 0x1700636A RID: 25450
		// (get) Token: 0x060190CD RID: 102605 RVA: 0x00250265 File Offset: 0x0024E465
		// (set) Token: 0x060190CE RID: 102606 RVA: 0x00250275 File Offset: 0x0024E475
		public unsafe bool bRayMarchShowSandOutsideVirtualCube
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRayMarchShowSandOutsideVirtualCube) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRayMarchShowSandOutsideVirtualCube) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700636B RID: 25451
		// (get) Token: 0x060190CF RID: 102607 RVA: 0x00250286 File Offset: 0x0024E486
		// (set) Token: 0x060190D0 RID: 102608 RVA: 0x00250296 File Offset: 0x0024E496
		public unsafe float RayMarchPowderGradScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchPowderGradScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchPowderGradScale) = value;
			}
		}

		// Token: 0x1700636C RID: 25452
		// (get) Token: 0x060190D1 RID: 102609 RVA: 0x002502A7 File Offset: 0x0024E4A7
		// (set) Token: 0x060190D2 RID: 102610 RVA: 0x002502B7 File Offset: 0x0024E4B7
		public unsafe float RayMarchPowderRgbDarken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchPowderRgbDarken);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchPowderRgbDarken) = value;
			}
		}

		// Token: 0x1700636D RID: 25453
		// (get) Token: 0x060190D3 RID: 102611 RVA: 0x002502C8 File Offset: 0x0024E4C8
		// (set) Token: 0x060190D4 RID: 102612 RVA: 0x002502D8 File Offset: 0x0024E4D8
		public unsafe float RayMarchDensVisDeadZone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchDensVisDeadZone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RayMarchDensVisDeadZone) = value;
			}
		}

		// Token: 0x1700636E RID: 25454
		// (get) Token: 0x060190D5 RID: 102613 RVA: 0x002502E9 File Offset: 0x0024E4E9
		// (set) Token: 0x060190D6 RID: 102614 RVA: 0x002502F9 File Offset: 0x0024E4F9
		public unsafe bool bDebugDrawVolumeBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawVolumeBounds) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawVolumeBounds) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700636F RID: 25455
		// (get) Token: 0x060190D7 RID: 102615 RVA: 0x0025030A File Offset: 0x0024E50A
		// (set) Token: 0x060190D8 RID: 102616 RVA: 0x0025031A File Offset: 0x0024E51A
		public unsafe float DiagonalSlideChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_DiagonalSlideChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_DiagonalSlideChance) = value;
			}
		}

		// Token: 0x17006370 RID: 25456
		// (get) Token: 0x060190D9 RID: 102617 RVA: 0x0025032B File Offset: 0x0024E52B
		// (set) Token: 0x060190DA RID: 102618 RVA: 0x0025033B File Offset: 0x0024E53B
		public unsafe float SurfaceShuffleChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SurfaceShuffleChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SurfaceShuffleChance) = value;
			}
		}

		// Token: 0x17006371 RID: 25457
		// (get) Token: 0x060190DB RID: 102619 RVA: 0x0025034C File Offset: 0x0024E54C
		// (set) Token: 0x060190DC RID: 102620 RVA: 0x0025035C File Offset: 0x0024E55C
		public unsafe float VerticalFallChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VerticalFallChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_VerticalFallChance) = value;
			}
		}

		// Token: 0x17006372 RID: 25458
		// (get) Token: 0x060190DD RID: 102621 RVA: 0x0025036D File Offset: 0x0024E56D
		// (set) Token: 0x060190DE RID: 102622 RVA: 0x0025037D File Offset: 0x0024E57D
		public unsafe int SimPassesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SimPassesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SimPassesPerFrame) = value;
			}
		}

		// Token: 0x17006373 RID: 25459
		// (get) Token: 0x060190DF RID: 102623 RVA: 0x0025038E File Offset: 0x0024E58E
		// (set) Token: 0x060190E0 RID: 102624 RVA: 0x0025039E File Offset: 0x0024E59E
		public unsafe float SimUpdateHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SimUpdateHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SimUpdateHz) = value;
			}
		}

		// Token: 0x17006374 RID: 25460
		// (get) Token: 0x060190E1 RID: 102625 RVA: 0x002503AF File Offset: 0x0024E5AF
		// (set) Token: 0x060190E2 RID: 102626 RVA: 0x002503BF File Offset: 0x0024E5BF
		public unsafe int MaxSimTicksPerRender
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_MaxSimTicksPerRender);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_MaxSimTicksPerRender) = value;
			}
		}

		// Token: 0x17006375 RID: 25461
		// (get) Token: 0x060190E3 RID: 102627 RVA: 0x002503D0 File Offset: 0x0024E5D0
		// (set) Token: 0x060190E4 RID: 102628 RVA: 0x002503E0 File Offset: 0x0024E5E0
		public unsafe bool bLimitSimDispatchToVirtualContainer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLimitSimDispatchToVirtualContainer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLimitSimDispatchToVirtualContainer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006376 RID: 25462
		// (get) Token: 0x060190E5 RID: 102629 RVA: 0x002503F1 File Offset: 0x0024E5F1
		// (set) Token: 0x060190E6 RID: 102630 RVA: 0x00250401 File Offset: 0x0024E601
		public unsafe bool bAutoSleepCAWhenStill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bAutoSleepCAWhenStill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bAutoSleepCAWhenStill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006377 RID: 25463
		// (get) Token: 0x060190E7 RID: 102631 RVA: 0x00250412 File Offset: 0x0024E612
		// (set) Token: 0x060190E8 RID: 102632 RVA: 0x00250422 File Offset: 0x0024E622
		public unsafe float AutoSleepCAStillDelaySec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_AutoSleepCAStillDelaySec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_AutoSleepCAStillDelaySec) = value;
			}
		}

		// Token: 0x17006378 RID: 25464
		// (get) Token: 0x060190E9 RID: 102633 RVA: 0x00250433 File Offset: 0x0024E633
		// (set) Token: 0x060190EA RID: 102634 RVA: 0x00250443 File Offset: 0x0024E643
		public unsafe float ShallowBedSlideChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlideChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlideChance) = value;
			}
		}

		// Token: 0x17006379 RID: 25465
		// (get) Token: 0x060190EB RID: 102635 RVA: 0x00250454 File Offset: 0x0024E654
		// (set) Token: 0x060190EC RID: 102636 RVA: 0x00250464 File Offset: 0x0024E664
		public unsafe float ShallowBedSlopeMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlopeMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlopeMin) = value;
			}
		}

		// Token: 0x1700637A RID: 25466
		// (get) Token: 0x060190ED RID: 102637 RVA: 0x00250475 File Offset: 0x0024E675
		// (set) Token: 0x060190EE RID: 102638 RVA: 0x00250485 File Offset: 0x0024E685
		public unsafe float ShallowBedSlopeFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlopeFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedSlopeFade) = value;
			}
		}

		// Token: 0x1700637B RID: 25467
		// (get) Token: 0x060190EF RID: 102639 RVA: 0x00250496 File Offset: 0x0024E696
		// (set) Token: 0x060190F0 RID: 102640 RVA: 0x002504A6 File Offset: 0x0024E6A6
		public unsafe float ShallowBedPlateauMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedPlateauMul);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_ShallowBedPlateauMul) = value;
			}
		}

		// Token: 0x1700637C RID: 25468
		// (get) Token: 0x060190F1 RID: 102641 RVA: 0x002504B7 File Offset: 0x0024E6B7
		// (set) Token: 0x060190F2 RID: 102642 RVA: 0x002504C7 File Offset: 0x0024E6C7
		public unsafe bool bBottomSandSinkEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bBottomSandSinkEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bBottomSandSinkEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700637D RID: 25469
		// (get) Token: 0x060190F3 RID: 102643 RVA: 0x002504D8 File Offset: 0x0024E6D8
		// (set) Token: 0x060190F4 RID: 102644 RVA: 0x002504E8 File Offset: 0x0024E6E8
		public unsafe float BottomSandSinkRadiusVoxels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_BottomSandSinkRadiusVoxels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_BottomSandSinkRadiusVoxels) = value;
			}
		}

		// Token: 0x1700637E RID: 25470
		// (get) Token: 0x060190F5 RID: 102645 RVA: 0x002504F9 File Offset: 0x0024E6F9
		// (set) Token: 0x060190F6 RID: 102646 RVA: 0x00250509 File Offset: 0x0024E709
		public unsafe bool bDebugDrawBottomSandSink
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawBottomSandSink) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugDrawBottomSandSink) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700637F RID: 25471
		// (get) Token: 0x060190F7 RID: 102647 RVA: 0x0025051A File Offset: 0x0024E71A
		// (set) Token: 0x060190F8 RID: 102648 RVA: 0x0025052E File Offset: 0x0024E72E
		public unsafe FQuat SandContainerRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotation) = value;
			}
		}

		// Token: 0x17006380 RID: 25472
		// (get) Token: 0x060190F9 RID: 102649 RVA: 0x00250543 File Offset: 0x0024E743
		// (set) Token: 0x060190FA RID: 102650 RVA: 0x00250553 File Offset: 0x0024E753
		public unsafe bool bPaused
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bPaused) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bPaused) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006381 RID: 25473
		// (get) Token: 0x060190FB RID: 102651 RVA: 0x00250564 File Offset: 0x0024E764
		// (set) Token: 0x060190FC RID: 102652 RVA: 0x00250574 File Offset: 0x0024E774
		public unsafe float SandContainerRotate360DurationSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotate360DurationSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotate360DurationSec) = value;
			}
		}

		// Token: 0x17006382 RID: 25474
		// (get) Token: 0x060190FD RID: 102653 RVA: 0x00250585 File Offset: 0x0024E785
		// (set) Token: 0x060190FE RID: 102654 RVA: 0x00250595 File Offset: 0x0024E795
		public unsafe float SandContainerRotate180DurationSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotate180DurationSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerRotate180DurationSec) = value;
			}
		}

		// Token: 0x17006383 RID: 25475
		// (get) Token: 0x060190FF RID: 102655 RVA: 0x002505A6 File Offset: 0x0024E7A6
		// (set) Token: 0x06019100 RID: 102656 RVA: 0x002505B6 File Offset: 0x0024E7B6
		public unsafe float SandContainerSwayDurationSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayDurationSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayDurationSec) = value;
			}
		}

		// Token: 0x17006384 RID: 25476
		// (get) Token: 0x06019101 RID: 102657 RVA: 0x002505C7 File Offset: 0x0024E7C7
		// (set) Token: 0x06019102 RID: 102658 RVA: 0x002505D7 File Offset: 0x0024E7D7
		public unsafe float SandContainerSwayAmplitudeDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayAmplitudeDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayAmplitudeDeg) = value;
			}
		}

		// Token: 0x17006385 RID: 25477
		// (get) Token: 0x06019103 RID: 102659 RVA: 0x002505E8 File Offset: 0x0024E7E8
		// (set) Token: 0x06019104 RID: 102660 RVA: 0x002505F8 File Offset: 0x0024E7F8
		public unsafe float SandContainerSwayFrequencyHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayFrequencyHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerSwayFrequencyHz) = value;
			}
		}

		// Token: 0x17006386 RID: 25478
		// (get) Token: 0x06019105 RID: 102661 RVA: 0x00250609 File Offset: 0x0024E809
		// (set) Token: 0x06019106 RID: 102662 RVA: 0x0025061D File Offset: 0x0024E81D
		public unsafe FVector SandContainerTranslateLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerTranslateLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerTranslateLp) = value;
			}
		}

		// Token: 0x17006387 RID: 25479
		// (get) Token: 0x06019107 RID: 102663 RVA: 0x00250632 File Offset: 0x0024E832
		// (set) Token: 0x06019108 RID: 102664 RVA: 0x00250642 File Offset: 0x0024E842
		public unsafe float SandContainerPanDurationSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanDurationSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanDurationSec) = value;
			}
		}

		// Token: 0x17006388 RID: 25480
		// (get) Token: 0x06019109 RID: 102665 RVA: 0x00250653 File Offset: 0x0024E853
		// (set) Token: 0x0601910A RID: 102666 RVA: 0x00250663 File Offset: 0x0024E863
		public unsafe float SandContainerPanAmplitudeLp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanAmplitudeLp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanAmplitudeLp) = value;
			}
		}

		// Token: 0x17006389 RID: 25481
		// (get) Token: 0x0601910B RID: 102667 RVA: 0x00250674 File Offset: 0x0024E874
		// (set) Token: 0x0601910C RID: 102668 RVA: 0x00250684 File Offset: 0x0024E884
		public unsafe float SandContainerPanFrequencyHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanFrequencyHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_SandContainerPanFrequencyHz) = value;
			}
		}

		// Token: 0x1700638A RID: 25482
		// (get) Token: 0x0601910D RID: 102669 RVA: 0x00250695 File Offset: 0x0024E895
		// (set) Token: 0x0601910E RID: 102670 RVA: 0x002506A5 File Offset: 0x0024E8A5
		public unsafe bool bRigidSandPullbackFollow
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRigidSandPullbackFollow) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bRigidSandPullbackFollow) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700638B RID: 25483
		// (get) Token: 0x0601910F RID: 102671 RVA: 0x002506B6 File Offset: 0x0024E8B6
		// (set) Token: 0x06019110 RID: 102672 RVA: 0x002506C6 File Offset: 0x0024E8C6
		public unsafe float RigidSandPullbackBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackBlend) = value;
			}
		}

		// Token: 0x1700638C RID: 25484
		// (get) Token: 0x06019111 RID: 102673 RVA: 0x002506D7 File Offset: 0x0024E8D7
		// (set) Token: 0x06019112 RID: 102674 RVA: 0x002506E7 File Offset: 0x0024E8E7
		public unsafe float RigidSandPullbackGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackGain) = value;
			}
		}

		// Token: 0x1700638D RID: 25485
		// (get) Token: 0x06019113 RID: 102675 RVA: 0x002506F8 File Offset: 0x0024E8F8
		// (set) Token: 0x06019114 RID: 102676 RVA: 0x00250708 File Offset: 0x0024E908
		public unsafe float RigidSandPullbackMinRotAngleDeg
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackMinRotAngleDeg);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackMinRotAngleDeg) = value;
			}
		}

		// Token: 0x1700638E RID: 25486
		// (get) Token: 0x06019115 RID: 102677 RVA: 0x00250719 File Offset: 0x0024E919
		// (set) Token: 0x06019116 RID: 102678 RVA: 0x00250729 File Offset: 0x0024E929
		public unsafe float RigidSandPullbackTranslateGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackTranslateGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_RigidSandPullbackTranslateGain) = value;
			}
		}

		// Token: 0x1700638F RID: 25487
		// (get) Token: 0x06019117 RID: 102679 RVA: 0x0025073A File Offset: 0x0024E93A
		// (set) Token: 0x06019118 RID: 102680 RVA: 0x0025074A File Offset: 0x0024E94A
		public unsafe bool bDebugSkipCAUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugSkipCAUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bDebugSkipCAUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006390 RID: 25488
		// (get) Token: 0x06019119 RID: 102681 RVA: 0x0025075B File Offset: 0x0024E95B
		// (set) Token: 0x0601911A RID: 102682 RVA: 0x0025076B File Offset: 0x0024E96B
		public unsafe bool bHidePlayerCharacter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bHidePlayerCharacter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bHidePlayerCharacter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006391 RID: 25489
		// (get) Token: 0x0601911B RID: 102683 RVA: 0x0025077C File Offset: 0x0024E97C
		// (set) Token: 0x0601911C RID: 102684 RVA: 0x0025078C File Offset: 0x0024E98C
		public unsafe bool bLockFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLockFrameRate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_bLockFrameRate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006392 RID: 25490
		// (get) Token: 0x0601911D RID: 102685 RVA: 0x0025079D File Offset: 0x0024E99D
		// (set) Token: 0x0601911E RID: 102686 RVA: 0x002507AD File Offset: 0x0024E9AD
		public unsafe float LockedFrameRateFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_LockedFrameRateFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AFallingSandGPU3DActor.__PropertyOffset_LockedFrameRateFPS) = value;
			}
		}

		// Token: 0x0601911F RID: 102687 RVA: 0x002507BE File Offset: 0x0024E9BE
		public void StopRain()
		{
			AFallingSandGPU3DActor.__StopRain_Internal(base.NativePtr);
		}

		// Token: 0x06019120 RID: 102688 RVA: 0x002507CB File Offset: 0x0024E9CB
		public void StartSandContainerSwayLeftRight()
		{
			AFallingSandGPU3DActor.__StartSandContainerSwayLeftRight_Internal(base.NativePtr);
		}

		// Token: 0x06019121 RID: 102689 RVA: 0x002507D8 File Offset: 0x0024E9D8
		public void StartSandContainerRotate360AroundVoxelX()
		{
			AFallingSandGPU3DActor.__StartSandContainerRotate360AroundVoxelX_Internal(base.NativePtr);
		}

		// Token: 0x06019122 RID: 102690 RVA: 0x002507E5 File Offset: 0x0024E9E5
		public void StartSandContainerRotate180AroundVoxelX()
		{
			AFallingSandGPU3DActor.__StartSandContainerRotate180AroundVoxelX_Internal(base.NativePtr);
		}

		// Token: 0x06019123 RID: 102691 RVA: 0x002507F2 File Offset: 0x0024E9F2
		public void StartSandContainerPanLeftRight()
		{
			AFallingSandGPU3DActor.__StartSandContainerPanLeftRight_Internal(base.NativePtr);
		}

		// Token: 0x06019124 RID: 102692 RVA: 0x002507FF File Offset: 0x0024E9FF
		public void StartRain()
		{
			AFallingSandGPU3DActor.__StartRain_Internal(base.NativePtr);
		}

		// Token: 0x06019125 RID: 102693 RVA: 0x0025080C File Offset: 0x0024EA0C
		public void ClearSand()
		{
			AFallingSandGPU3DActor.__ClearSand_Internal(base.NativePtr);
		}

		// Token: 0x06019126 RID: 102694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopRain_Internal(IntPtr @this);

		// Token: 0x06019127 RID: 102695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSandContainerSwayLeftRight_Internal(IntPtr @this);

		// Token: 0x06019128 RID: 102696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSandContainerRotate360AroundVoxelX_Internal(IntPtr @this);

		// Token: 0x06019129 RID: 102697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSandContainerRotate180AroundVoxelX_Internal(IntPtr @this);

		// Token: 0x0601912A RID: 102698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartSandContainerPanLeftRight_Internal(IntPtr @this);

		// Token: 0x0601912B RID: 102699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartRain_Internal(IntPtr @this);

		// Token: 0x0601912C RID: 102700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearSand_Internal(IntPtr @this);

		// Token: 0x0601912D RID: 102701 RVA: 0x00250819 File Offset: 0x0024EA19
		static AFallingSandGPU3DActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPU3DActor");
		}

		// Token: 0x0601912E RID: 102702 RVA: 0x00250827 File Offset: 0x0024EA27
		protected AFallingSandGPU3DActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DA67 RID: 55911
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.FallingSandGPU3DActor";

		// Token: 0x0400DA68 RID: 55912
		private static IntPtr _ClassPtr;

		// Token: 0x0400DA69 RID: 55913
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DA6A RID: 55914
		internal static int __PropertyOffset_VolumeSize;

		// Token: 0x0400DA6B RID: 55915
		internal static int __PropertyOffset_VolumeEdgeLengthCm;

		// Token: 0x0400DA6C RID: 55916
		internal static int __PropertyOffset_InitialSandProbability;

		// Token: 0x0400DA6D RID: 55917
		internal static int __PropertyOffset_InitialSandTopLayers;

		// Token: 0x0400DA6E RID: 55918
		internal static int __PropertyOffset_bRainSandEnabled;

		// Token: 0x0400DA6F RID: 55919
		internal static int __PropertyOffset_RainSandRadiusCm;

		// Token: 0x0400DA70 RID: 55920
		internal static int __PropertyOffset_RainSandInsetFromTopCm;

		// Token: 0x0400DA71 RID: 55921
		internal static int __PropertyOffset_bVirtualSqrt2SandCube;

		// Token: 0x0400DA72 RID: 55922
		internal static int __PropertyOffset_VirtualSandCubeHalfEdge;

		// Token: 0x0400DA73 RID: 55923
		internal static int __PropertyOffset_bFP32SimVolume;

		// Token: 0x0400DA74 RID: 55924
		internal static int __PropertyOffset_bExtendedSandDensityEncoding;

		// Token: 0x0400DA75 RID: 55925
		internal static int __PropertyOffset_bLdsHaloPurify;

		// Token: 0x0400DA76 RID: 55926
		internal static int __PropertyOffset_bRainSandUseVirtualCubeTopCenter;

		// Token: 0x0400DA77 RID: 55927
		internal static int __PropertyOffset_bDebugDrawSandContainer;

		// Token: 0x0400DA78 RID: 55928
		internal static int __PropertyOffset_bVirtualHourglassContainer;

		// Token: 0x0400DA79 RID: 55929
		internal static int __PropertyOffset_HourglassHalfHeightLp;

		// Token: 0x0400DA7A RID: 55930
		internal static int __PropertyOffset_HourglassNeckRadiusLp;

		// Token: 0x0400DA7B RID: 55931
		internal static int __PropertyOffset_HourglassBellyRadiusLp;

		// Token: 0x0400DA7C RID: 55932
		internal static int __PropertyOffset_HourglassRimRadiusLp;

		// Token: 0x0400DA7D RID: 55933
		internal static int __PropertyOffset_HourglassBellyPositionU;

		// Token: 0x0400DA7E RID: 55934
		internal static int __PropertyOffset_HourglassSmoothBlend;

		// Token: 0x0400DA7F RID: 55935
		internal static int __PropertyOffset_RayMarchMaxSteps;

		// Token: 0x0400DA80 RID: 55936
		internal static int __PropertyOffset_RayMarchJitterStrength;

		// Token: 0x0400DA81 RID: 55937
		internal static int __PropertyOffset_RayMarchSelfShadowStepCm;

		// Token: 0x0400DA82 RID: 55938
		internal static int __PropertyOffset_RayMarchSelfShadowMaxSteps;

		// Token: 0x0400DA83 RID: 55939
		internal static int __PropertyOffset_RayMarchSandOpacityScale;

		// Token: 0x0400DA84 RID: 55940
		internal static int __PropertyOffset_bRayMarchShowSandOutsideVirtualCube;

		// Token: 0x0400DA85 RID: 55941
		internal static int __PropertyOffset_RayMarchPowderGradScale;

		// Token: 0x0400DA86 RID: 55942
		internal static int __PropertyOffset_RayMarchPowderRgbDarken;

		// Token: 0x0400DA87 RID: 55943
		internal static int __PropertyOffset_RayMarchDensVisDeadZone;

		// Token: 0x0400DA88 RID: 55944
		internal static int __PropertyOffset_bDebugDrawVolumeBounds;

		// Token: 0x0400DA89 RID: 55945
		internal static int __PropertyOffset_DiagonalSlideChance;

		// Token: 0x0400DA8A RID: 55946
		internal static int __PropertyOffset_SurfaceShuffleChance;

		// Token: 0x0400DA8B RID: 55947
		internal static int __PropertyOffset_VerticalFallChance;

		// Token: 0x0400DA8C RID: 55948
		internal static int __PropertyOffset_SimPassesPerFrame;

		// Token: 0x0400DA8D RID: 55949
		internal static int __PropertyOffset_SimUpdateHz;

		// Token: 0x0400DA8E RID: 55950
		internal static int __PropertyOffset_MaxSimTicksPerRender;

		// Token: 0x0400DA8F RID: 55951
		internal static int __PropertyOffset_bLimitSimDispatchToVirtualContainer;

		// Token: 0x0400DA90 RID: 55952
		internal static int __PropertyOffset_bAutoSleepCAWhenStill;

		// Token: 0x0400DA91 RID: 55953
		internal static int __PropertyOffset_AutoSleepCAStillDelaySec;

		// Token: 0x0400DA92 RID: 55954
		internal static int __PropertyOffset_ShallowBedSlideChance;

		// Token: 0x0400DA93 RID: 55955
		internal static int __PropertyOffset_ShallowBedSlopeMin;

		// Token: 0x0400DA94 RID: 55956
		internal static int __PropertyOffset_ShallowBedSlopeFade;

		// Token: 0x0400DA95 RID: 55957
		internal static int __PropertyOffset_ShallowBedPlateauMul;

		// Token: 0x0400DA96 RID: 55958
		internal static int __PropertyOffset_bBottomSandSinkEnabled;

		// Token: 0x0400DA97 RID: 55959
		internal static int __PropertyOffset_BottomSandSinkRadiusVoxels;

		// Token: 0x0400DA98 RID: 55960
		internal static int __PropertyOffset_bDebugDrawBottomSandSink;

		// Token: 0x0400DA99 RID: 55961
		internal static int __PropertyOffset_SandContainerRotation;

		// Token: 0x0400DA9A RID: 55962
		internal static int __PropertyOffset_bPaused;

		// Token: 0x0400DA9B RID: 55963
		internal static int __PropertyOffset_SandContainerRotate360DurationSec;

		// Token: 0x0400DA9C RID: 55964
		internal static int __PropertyOffset_SandContainerRotate180DurationSec;

		// Token: 0x0400DA9D RID: 55965
		internal static int __PropertyOffset_SandContainerSwayDurationSec;

		// Token: 0x0400DA9E RID: 55966
		internal static int __PropertyOffset_SandContainerSwayAmplitudeDeg;

		// Token: 0x0400DA9F RID: 55967
		internal static int __PropertyOffset_SandContainerSwayFrequencyHz;

		// Token: 0x0400DAA0 RID: 55968
		internal static int __PropertyOffset_SandContainerTranslateLp;

		// Token: 0x0400DAA1 RID: 55969
		internal static int __PropertyOffset_SandContainerPanDurationSec;

		// Token: 0x0400DAA2 RID: 55970
		internal static int __PropertyOffset_SandContainerPanAmplitudeLp;

		// Token: 0x0400DAA3 RID: 55971
		internal static int __PropertyOffset_SandContainerPanFrequencyHz;

		// Token: 0x0400DAA4 RID: 55972
		internal static int __PropertyOffset_bRigidSandPullbackFollow;

		// Token: 0x0400DAA5 RID: 55973
		internal static int __PropertyOffset_RigidSandPullbackBlend;

		// Token: 0x0400DAA6 RID: 55974
		internal static int __PropertyOffset_RigidSandPullbackGain;

		// Token: 0x0400DAA7 RID: 55975
		internal static int __PropertyOffset_RigidSandPullbackMinRotAngleDeg;

		// Token: 0x0400DAA8 RID: 55976
		internal static int __PropertyOffset_RigidSandPullbackTranslateGain;

		// Token: 0x0400DAA9 RID: 55977
		internal static int __PropertyOffset_bDebugSkipCAUpdate;

		// Token: 0x0400DAAA RID: 55978
		internal static int __PropertyOffset_bHidePlayerCharacter;

		// Token: 0x0400DAAB RID: 55979
		internal static int __PropertyOffset_bLockFrameRate;

		// Token: 0x0400DAAC RID: 55980
		internal static int __PropertyOffset_LockedFrameRateFPS;
	}
}
