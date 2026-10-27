using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020017DF RID: 6111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroComputeShader.StamFluidGPU2DActor")]
	[UnrealStructLayout(2144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2144)]
	public class AStamFluidGPU2DActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060168BC RID: 92348 RVA: 0x0020EB43 File Offset: 0x0020CD43
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AStamFluidGPU2DActor._ClassPtr;
		}

		// Token: 0x060168BD RID: 92349 RVA: 0x0020EB50 File Offset: 0x0020CD50
		public AStamFluidGPU2DActor() : this(BuiltinUtils.AllocNativeUObject(AStamFluidGPU2DActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060168BE RID: 92350 RVA: 0x0020EB78 File Offset: 0x0020CD78
		public AStamFluidGPU2DActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AStamFluidGPU2DActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x060168BF RID: 92351 RVA: 0x0020EBAB File Offset: 0x0020CDAB
		// (set) Token: 0x060168C0 RID: 92352 RVA: 0x0020EBBB File Offset: 0x0020CDBB
		public unsafe int GridN
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_GridN);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_GridN) = value;
			}
		}

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x060168C1 RID: 92353 RVA: 0x0020EBCC File Offset: 0x0020CDCC
		// (set) Token: 0x060168C2 RID: 92354 RVA: 0x0020EBDC File Offset: 0x0020CDDC
		public unsafe float VelocityDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_VelocityDecay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_VelocityDecay) = value;
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x060168C3 RID: 92355 RVA: 0x0020EBED File Offset: 0x0020CDED
		// (set) Token: 0x060168C4 RID: 92356 RVA: 0x0020EBFD File Offset: 0x0020CDFD
		public unsafe float DensityDecay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DensityDecay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DensityDecay) = value;
			}
		}

		// Token: 0x17005B0B RID: 23307
		// (get) Token: 0x060168C5 RID: 92357 RVA: 0x0020EC0E File Offset: 0x0020CE0E
		// (set) Token: 0x060168C6 RID: 92358 RVA: 0x0020EC1E File Offset: 0x0020CE1E
		public unsafe int PressureIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_PressureIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_PressureIterations) = value;
			}
		}

		// Token: 0x17005B0C RID: 23308
		// (get) Token: 0x060168C7 RID: 92359 RVA: 0x0020EC2F File Offset: 0x0020CE2F
		// (set) Token: 0x060168C8 RID: 92360 RVA: 0x0020EC3F File Offset: 0x0020CE3F
		public unsafe int AdvectIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_AdvectIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_AdvectIterations) = value;
			}
		}

		// Token: 0x17005B0D RID: 23309
		// (get) Token: 0x060168C9 RID: 92361 RVA: 0x0020EC50 File Offset: 0x0020CE50
		// (set) Token: 0x060168CA RID: 92362 RVA: 0x0020EC60 File Offset: 0x0020CE60
		public unsafe float VortexIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_VortexIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_VortexIntensity) = value;
			}
		}

		// Token: 0x17005B0E RID: 23310
		// (get) Token: 0x060168CB RID: 92363 RVA: 0x0020EC71 File Offset: 0x0020CE71
		// (set) Token: 0x060168CC RID: 92364 RVA: 0x0020EC81 File Offset: 0x0020CE81
		public unsafe float MaxVortexKick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxVortexKick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxVortexKick) = value;
			}
		}

		// Token: 0x17005B0F RID: 23311
		// (get) Token: 0x060168CD RID: 92365 RVA: 0x0020EC92 File Offset: 0x0020CE92
		// (set) Token: 0x060168CE RID: 92366 RVA: 0x0020ECA2 File Offset: 0x0020CEA2
		public unsafe float InjectVortexSuppression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVortexSuppression);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVortexSuppression) = value;
			}
		}

		// Token: 0x17005B10 RID: 23312
		// (get) Token: 0x060168CF RID: 92367 RVA: 0x0020ECB3 File Offset: 0x0020CEB3
		// (set) Token: 0x060168D0 RID: 92368 RVA: 0x0020ECC3 File Offset: 0x0020CEC3
		public unsafe float MaxSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxSpeed) = value;
			}
		}

		// Token: 0x17005B11 RID: 23313
		// (get) Token: 0x060168D1 RID: 92369 RVA: 0x0020ECD4 File Offset: 0x0020CED4
		// (set) Token: 0x060168D2 RID: 92370 RVA: 0x0020ECE4 File Offset: 0x0020CEE4
		public unsafe float SimDtScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimDtScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimDtScale) = value;
			}
		}

		// Token: 0x17005B12 RID: 23314
		// (get) Token: 0x060168D3 RID: 92371 RVA: 0x0020ECF5 File Offset: 0x0020CEF5
		// (set) Token: 0x060168D4 RID: 92372 RVA: 0x0020ED05 File Offset: 0x0020CF05
		public unsafe int SimHz
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimHz);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimHz) = value;
			}
		}

		// Token: 0x17005B13 RID: 23315
		// (get) Token: 0x060168D5 RID: 92373 RVA: 0x0020ED16 File Offset: 0x0020CF16
		// (set) Token: 0x060168D6 RID: 92374 RVA: 0x0020ED26 File Offset: 0x0020CF26
		public unsafe int MaxSimSubstepsPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxSimSubstepsPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxSimSubstepsPerFrame) = value;
			}
		}

		// Token: 0x17005B14 RID: 23316
		// (get) Token: 0x060168D7 RID: 92375 RVA: 0x0020ED37 File Offset: 0x0020CF37
		// (set) Token: 0x060168D8 RID: 92376 RVA: 0x0020ED47 File Offset: 0x0020CF47
		public unsafe float InjectDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectDensity) = value;
			}
		}

		// Token: 0x17005B15 RID: 23317
		// (get) Token: 0x060168D9 RID: 92377 RVA: 0x0020ED58 File Offset: 0x0020CF58
		// (set) Token: 0x060168DA RID: 92378 RVA: 0x0020ED68 File Offset: 0x0020CF68
		public unsafe float InjectSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectSpeed) = value;
			}
		}

		// Token: 0x17005B16 RID: 23318
		// (get) Token: 0x060168DB RID: 92379 RVA: 0x0020ED79 File Offset: 0x0020CF79
		// (set) Token: 0x060168DC RID: 92380 RVA: 0x0020ED89 File Offset: 0x0020CF89
		public unsafe float InjectVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVelocityScale) = value;
			}
		}

		// Token: 0x17005B17 RID: 23319
		// (get) Token: 0x060168DD RID: 92381 RVA: 0x0020ED9A File Offset: 0x0020CF9A
		// (set) Token: 0x060168DE RID: 92382 RVA: 0x0020EDAA File Offset: 0x0020CFAA
		public unsafe float InjectVelocityCoupling
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVelocityCoupling);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectVelocityCoupling) = value;
			}
		}

		// Token: 0x17005B18 RID: 23320
		// (get) Token: 0x060168DF RID: 92383 RVA: 0x0020EDBB File Offset: 0x0020CFBB
		// (set) Token: 0x060168E0 RID: 92384 RVA: 0x0020EDCB File Offset: 0x0020CFCB
		public unsafe float DirectVelocityInjectionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DirectVelocityInjectionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DirectVelocityInjectionScale) = value;
			}
		}

		// Token: 0x17005B19 RID: 23321
		// (get) Token: 0x060168E1 RID: 92385 RVA: 0x0020EDDC File Offset: 0x0020CFDC
		// (set) Token: 0x060168E2 RID: 92386 RVA: 0x0020EDEC File Offset: 0x0020CFEC
		public unsafe float InjectReferenceWorldSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectReferenceWorldSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InjectReferenceWorldSpeed) = value;
			}
		}

		// Token: 0x17005B1A RID: 23322
		// (get) Token: 0x060168E3 RID: 92387 RVA: 0x0020EDFD File Offset: 0x0020CFFD
		// (set) Token: 0x060168E4 RID: 92388 RVA: 0x0020EE0D File Offset: 0x0020D00D
		public unsafe float MinInjectWorldSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MinInjectWorldSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MinInjectWorldSpeed) = value;
			}
		}

		// Token: 0x17005B1B RID: 23323
		// (get) Token: 0x060168E5 RID: 92389 RVA: 0x0020EE1E File Offset: 0x0020D01E
		// (set) Token: 0x060168E6 RID: 92390 RVA: 0x0020EE2E File Offset: 0x0020D02E
		public unsafe float BrushWorldRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BrushWorldRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BrushWorldRadius) = value;
			}
		}

		// Token: 0x17005B1C RID: 23324
		// (get) Token: 0x060168E7 RID: 92391 RVA: 0x0020EE40 File Offset: 0x0020D040
		// (set) Token: 0x060168E8 RID: 92392 RVA: 0x0020EE79 File Offset: 0x0020D079
		public TArray<FName> FootBoneNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._FootBoneNames) == null)
				{
					result = (this._FootBoneNames = new TArray<FName>(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_FootBoneNames, this));
				}
				return result;
			}
			set
			{
				this.FootBoneNames.CopyAssign(value);
			}
		}

		// Token: 0x17005B1D RID: 23325
		// (get) Token: 0x060168E9 RID: 92393 RVA: 0x0020EE87 File Offset: 0x0020D087
		// (set) Token: 0x060168EA RID: 92394 RVA: 0x0020EE9B File Offset: 0x0020D09B
		public unsafe string InteractionVolumeComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionVolumeComponentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionVolumeComponentName)), value);
			}
		}

		// Token: 0x17005B1E RID: 23326
		// (get) Token: 0x060168EB RID: 92395 RVA: 0x0020EEB0 File Offset: 0x0020D0B0
		// (set) Token: 0x060168EC RID: 92396 RVA: 0x0020EEC4 File Offset: 0x0020D0C4
		public unsafe FName InteractionVolumeComponentTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionVolumeComponentTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionVolumeComponentTag) = value;
			}
		}

		// Token: 0x17005B1F RID: 23327
		// (get) Token: 0x060168ED RID: 92397 RVA: 0x0020EED9 File Offset: 0x0020D0D9
		// (set) Token: 0x060168EE RID: 92398 RVA: 0x0020EEED File Offset: 0x0020D0ED
		public unsafe string ActivateVolumeComponentName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)AStamFluidGPU2DActor.__PropertyOffset_ActivateVolumeComponentName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)AStamFluidGPU2DActor.__PropertyOffset_ActivateVolumeComponentName)), value);
			}
		}

		// Token: 0x17005B20 RID: 23328
		// (get) Token: 0x060168EF RID: 92399 RVA: 0x0020EF02 File Offset: 0x0020D102
		// (set) Token: 0x060168F0 RID: 92400 RVA: 0x0020EF16 File Offset: 0x0020D116
		public unsafe FName ActivateVolumeComponentTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_ActivateVolumeComponentTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_ActivateVolumeComponentTag) = value;
			}
		}

		// Token: 0x17005B21 RID: 23329
		// (get) Token: 0x060168F1 RID: 92401 RVA: 0x0020EF2C File Offset: 0x0020D12C
		// (set) Token: 0x060168F2 RID: 92402 RVA: 0x0020EF65 File Offset: 0x0020D165
		public FStamFluidGPU2DActivationVolumeEvent OnPawnEnteredActivateVolume
		{
			get
			{
				base.FastCheckIsValid();
				FStamFluidGPU2DActivationVolumeEvent result;
				if ((result = this._OnPawnEnteredActivateVolume) == null)
				{
					result = (this._OnPawnEnteredActivateVolume = new FStamFluidGPU2DActivationVolumeEvent(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OnPawnEnteredActivateVolume, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OnPawnEnteredActivateVolume, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005B22 RID: 23330
		// (get) Token: 0x060168F3 RID: 92403 RVA: 0x0020EF88 File Offset: 0x0020D188
		// (set) Token: 0x060168F4 RID: 92404 RVA: 0x0020EFC1 File Offset: 0x0020D1C1
		public FStamFluidGPU2DActivationVolumeEvent OnPawnExitedActivateVolume
		{
			get
			{
				base.FastCheckIsValid();
				FStamFluidGPU2DActivationVolumeEvent result;
				if ((result = this._OnPawnExitedActivateVolume) == null)
				{
					result = (this._OnPawnExitedActivateVolume = new FStamFluidGPU2DActivationVolumeEvent(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OnPawnExitedActivateVolume, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OnPawnExitedActivateVolume, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17005B23 RID: 23331
		// (get) Token: 0x060168F5 RID: 92405 RVA: 0x0020EFE2 File Offset: 0x0020D1E2
		// (set) Token: 0x060168F6 RID: 92406 RVA: 0x0020EFF6 File Offset: 0x0020D1F6
		public unsafe FName FluidTriggerTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_FluidTriggerTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_FluidTriggerTag) = value;
			}
		}

		// Token: 0x17005B24 RID: 23332
		// (get) Token: 0x060168F7 RID: 92407 RVA: 0x0020F00B File Offset: 0x0020D20B
		// (set) Token: 0x060168F8 RID: 92408 RVA: 0x0020F01B File Offset: 0x0020D21B
		public unsafe int MaxInteractionBrushes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxInteractionBrushes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxInteractionBrushes) = value;
			}
		}

		// Token: 0x17005B25 RID: 23333
		// (get) Token: 0x060168F9 RID: 92409 RVA: 0x0020F02C File Offset: 0x0020D22C
		// (set) Token: 0x060168FA RID: 92410 RVA: 0x0020F03C File Offset: 0x0020D23C
		public unsafe float BlueprintBrushVelocityHistoryTimeout
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushVelocityHistoryTimeout);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushVelocityHistoryTimeout) = value;
			}
		}

		// Token: 0x17005B26 RID: 23334
		// (get) Token: 0x060168FB RID: 92411 RVA: 0x0020F04D File Offset: 0x0020D24D
		// (set) Token: 0x060168FC RID: 92412 RVA: 0x0020F05D File Offset: 0x0020D25D
		public unsafe bool bUseCatmullRomForFastBlueprintBrushes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bUseCatmullRomForFastBlueprintBrushes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bUseCatmullRomForFastBlueprintBrushes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B27 RID: 23335
		// (get) Token: 0x060168FD RID: 92413 RVA: 0x0020F06E File Offset: 0x0020D26E
		// (set) Token: 0x060168FE RID: 92414 RVA: 0x0020F07E File Offset: 0x0020D27E
		public unsafe float BlueprintBrushCatmullMinSegmentWorldDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullMinSegmentWorldDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullMinSegmentWorldDistance) = value;
			}
		}

		// Token: 0x17005B28 RID: 23336
		// (get) Token: 0x060168FF RID: 92415 RVA: 0x0020F08F File Offset: 0x0020D28F
		// (set) Token: 0x06016900 RID: 92416 RVA: 0x0020F09F File Offset: 0x0020D29F
		public unsafe float BlueprintBrushCatmullMinWorldSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullMinWorldSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullMinWorldSpeed) = value;
			}
		}

		// Token: 0x17005B29 RID: 23337
		// (get) Token: 0x06016901 RID: 92417 RVA: 0x0020F0B0 File Offset: 0x0020D2B0
		// (set) Token: 0x06016902 RID: 92418 RVA: 0x0020F0C0 File Offset: 0x0020D2C0
		public unsafe float BlueprintBrushCatmullTargetSegmentWorldDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullTargetSegmentWorldDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullTargetSegmentWorldDistance) = value;
			}
		}

		// Token: 0x17005B2A RID: 23338
		// (get) Token: 0x06016903 RID: 92419 RVA: 0x0020F0D1 File Offset: 0x0020D2D1
		// (set) Token: 0x06016904 RID: 92420 RVA: 0x0020F0E1 File Offset: 0x0020D2E1
		public unsafe int MaxBlueprintBrushCatmullSubsteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxBlueprintBrushCatmullSubsteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxBlueprintBrushCatmullSubsteps) = value;
			}
		}

		// Token: 0x17005B2B RID: 23339
		// (get) Token: 0x06016905 RID: 92421 RVA: 0x0020F0F2 File Offset: 0x0020D2F2
		// (set) Token: 0x06016906 RID: 92422 RVA: 0x0020F102 File Offset: 0x0020D302
		public unsafe float BlueprintBrushCatmullAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullAlpha) = value;
			}
		}

		// Token: 0x17005B2C RID: 23340
		// (get) Token: 0x06016907 RID: 92423 RVA: 0x0020F113 File Offset: 0x0020D313
		// (set) Token: 0x06016908 RID: 92424 RVA: 0x0020F123 File Offset: 0x0020D323
		public unsafe float BlueprintBrushCatmullTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_BlueprintBrushCatmullTension) = value;
			}
		}

		// Token: 0x17005B2D RID: 23341
		// (get) Token: 0x06016909 RID: 92425 RVA: 0x0020F134 File Offset: 0x0020D334
		// (set) Token: 0x0601690A RID: 92426 RVA: 0x0020F144 File Offset: 0x0020D344
		public unsafe bool bRunSimulationStepForBlueprintBrushes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bRunSimulationStepForBlueprintBrushes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bRunSimulationStepForBlueprintBrushes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B2E RID: 23342
		// (get) Token: 0x0601690B RID: 92427 RVA: 0x0020F155 File Offset: 0x0020D355
		// (set) Token: 0x0601690C RID: 92428 RVA: 0x0020F165 File Offset: 0x0020D365
		public unsafe int InteractionWarmupFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionWarmupFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_InteractionWarmupFrames) = value;
			}
		}

		// Token: 0x17005B2F RID: 23343
		// (get) Token: 0x0601690D RID: 92429 RVA: 0x0020F176 File Offset: 0x0020D376
		// (set) Token: 0x0601690E RID: 92430 RVA: 0x0020F186 File Offset: 0x0020D386
		public unsafe float MaxAutomaticBrushSegmentWorldDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxAutomaticBrushSegmentWorldDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_MaxAutomaticBrushSegmentWorldDistance) = value;
			}
		}

		// Token: 0x17005B30 RID: 23344
		// (get) Token: 0x0601690F RID: 92431 RVA: 0x0020F197 File Offset: 0x0020D397
		// (set) Token: 0x06016910 RID: 92432 RVA: 0x0020F1A7 File Offset: 0x0020D3A7
		public unsafe float DisplaySize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DisplaySize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DisplaySize) = value;
			}
		}

		// Token: 0x17005B31 RID: 23345
		// (get) Token: 0x06016911 RID: 92433 RVA: 0x0020F1B8 File Offset: 0x0020D3B8
		// (set) Token: 0x06016912 RID: 92434 RVA: 0x0020F1C8 File Offset: 0x0020D3C8
		public unsafe bool bShowInjectSphere
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bShowInjectSphere) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bShowInjectSphere) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B32 RID: 23346
		// (get) Token: 0x06016913 RID: 92435 RVA: 0x0020F1D9 File Offset: 0x0020D3D9
		// (set) Token: 0x06016914 RID: 92436 RVA: 0x0020F1E9 File Offset: 0x0020D3E9
		public unsafe float DebugInjectSphereLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DebugInjectSphereLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_DebugInjectSphereLifeTime) = value;
			}
		}

		// Token: 0x17005B33 RID: 23347
		// (get) Token: 0x06016915 RID: 92437 RVA: 0x0020F1FA File Offset: 0x0020D3FA
		// (set) Token: 0x06016916 RID: 92438 RVA: 0x0020F20A File Offset: 0x0020D40A
		public unsafe bool bCenterSimulationOnPlayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bCenterSimulationOnPlayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bCenterSimulationOnPlayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B34 RID: 23348
		// (get) Token: 0x06016917 RID: 92439 RVA: 0x0020F21B File Offset: 0x0020D41B
		// (set) Token: 0x06016918 RID: 92440 RVA: 0x0020F22F File Offset: 0x0020D42F
		[Nullable(2)]
		public unsafe AActor SimulationCenterFollowActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_SimulationCenterFollowActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_SimulationCenterFollowActor, value);
			}
		}

		// Token: 0x17005B35 RID: 23349
		// (get) Token: 0x06016919 RID: 92441 RVA: 0x0020F244 File Offset: 0x0020D444
		// (set) Token: 0x0601691A RID: 92442 RVA: 0x0020F254 File Offset: 0x0020D454
		public unsafe bool bSmoothSimulationRebase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bSmoothSimulationRebase) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bSmoothSimulationRebase) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B36 RID: 23350
		// (get) Token: 0x0601691B RID: 92443 RVA: 0x0020F265 File Offset: 0x0020D465
		// (set) Token: 0x0601691C RID: 92444 RVA: 0x0020F279 File Offset: 0x0020D479
		public unsafe FVector SimulationCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimulationCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_SimulationCenter) = value;
			}
		}

		// Token: 0x17005B37 RID: 23351
		// (get) Token: 0x0601691D RID: 92445 RVA: 0x0020F28E File Offset: 0x0020D48E
		// (set) Token: 0x0601691E RID: 92446 RVA: 0x0020F29E File Offset: 0x0020D49E
		public unsafe bool bWriteDensityToRenderTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bWriteDensityToRenderTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bWriteDensityToRenderTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B38 RID: 23352
		// (get) Token: 0x0601691F RID: 92447 RVA: 0x0020F2AF File Offset: 0x0020D4AF
		// (set) Token: 0x06016920 RID: 92448 RVA: 0x0020F2BF File Offset: 0x0020D4BF
		public unsafe bool bAutoCreateOutputRenderTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bAutoCreateOutputRenderTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bAutoCreateOutputRenderTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B39 RID: 23353
		// (get) Token: 0x06016921 RID: 92449 RVA: 0x0020F2D0 File Offset: 0x0020D4D0
		// (set) Token: 0x06016922 RID: 92450 RVA: 0x0020F2E0 File Offset: 0x0020D4E0
		public unsafe bool bResizeOutputRenderTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bResizeOutputRenderTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_bResizeOutputRenderTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005B3A RID: 23354
		// (get) Token: 0x06016923 RID: 92451 RVA: 0x0020F2F1 File Offset: 0x0020D4F1
		// (set) Token: 0x06016924 RID: 92452 RVA: 0x0020F301 File Offset: 0x0020D501
		public unsafe float OutputVelocityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OutputVelocityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OutputVelocityScale) = value;
			}
		}

		// Token: 0x17005B3B RID: 23355
		// (get) Token: 0x06016925 RID: 92453 RVA: 0x0020F312 File Offset: 0x0020D512
		// (set) Token: 0x06016926 RID: 92454 RVA: 0x0020F322 File Offset: 0x0020D522
		public unsafe EStamFluidGPU2DOutputDebugMode OutputDebugMode
		{
			get
			{
				return (EStamFluidGPU2DOutputDebugMode)(*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OutputDebugMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStamFluidGPU2DActor.__PropertyOffset_OutputDebugMode) = (byte)value;
			}
		}

		// Token: 0x17005B3C RID: 23356
		// (get) Token: 0x06016927 RID: 92455 RVA: 0x0020F333 File Offset: 0x0020D533
		// (set) Token: 0x06016928 RID: 92456 RVA: 0x0020F347 File Offset: 0x0020D547
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D OutputRenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_OutputRenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_OutputRenderTarget, value);
			}
		}

		// Token: 0x17005B3D RID: 23357
		// (get) Token: 0x06016929 RID: 92457 RVA: 0x0020F35C File Offset: 0x0020D55C
		// (set) Token: 0x0601692A RID: 92458 RVA: 0x0020F370 File Offset: 0x0020D570
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D RuntimeOutputRenderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_RuntimeOutputRenderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStamFluidGPU2DActor.__PropertyOffset_RuntimeOutputRenderTarget, value);
			}
		}

		// Token: 0x0601692B RID: 92459 RVA: 0x0020F385 File Offset: 0x0020D585
		public void ResetInteractionBrushHistory(FName BrushId = default(FName))
		{
			AStamFluidGPU2DActor.__ResetInteractionBrushHistory_Internal(base.NativePtr, BrushId);
		}

		// Token: 0x0601692C RID: 92460 RVA: 0x0020F393 File Offset: 0x0020D593
		public void ResetFluid()
		{
			AStamFluidGPU2DActor.__ResetFluid_Internal(base.NativePtr);
		}

		// Token: 0x0601692D RID: 92461 RVA: 0x0020F3A0 File Offset: 0x0020D5A0
		public void RefreshInteractionVolumeComponent()
		{
			AStamFluidGPU2DActor.__RefreshInteractionVolumeComponent_Internal(base.NativePtr);
		}

		// Token: 0x0601692E RID: 92462 RVA: 0x0020F3AD File Offset: 0x0020D5AD
		public void LogStamFluidGPU2DState()
		{
			AStamFluidGPU2DActor.__LogStamFluidGPU2DState_Internal(base.NativePtr);
		}

		// Token: 0x0601692F RID: 92463 RVA: 0x0020F3BA File Offset: 0x0020D5BA
		public void LogOutputRenderTargetCenterPixel()
		{
			AStamFluidGPU2DActor.__LogOutputRenderTargetCenterPixel_Internal(base.NativePtr);
		}

		// Token: 0x06016930 RID: 92464 RVA: 0x0020F3C7 File Offset: 0x0020D5C7
		public void LogInteractionVolumeCandidates()
		{
			AStamFluidGPU2DActor.__LogInteractionVolumeCandidates_Internal(base.NativePtr);
		}

		// Token: 0x06016931 RID: 92465 RVA: 0x0020F3D4 File Offset: 0x0020D5D4
		public bool IsFluidSimulationActiveNow()
		{
			return AStamFluidGPU2DActor.__IsFluidSimulationActiveNow_Internal(base.NativePtr);
		}

		// Token: 0x06016932 RID: 92466 RVA: 0x0020F3E1 File Offset: 0x0020D5E1
		public FVector GetSimulationCenter()
		{
			return AStamFluidGPU2DActor.__GetSimulationCenter_Internal(base.NativePtr);
		}

		// Token: 0x06016933 RID: 92467 RVA: 0x0020F3EE File Offset: 0x0020D5EE
		[NullableContext(2)]
		public UTextureRenderTarget2D GetOutputRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(AStamFluidGPU2DActor.__GetOutputRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x06016934 RID: 92468 RVA: 0x0020F400 File Offset: 0x0020D600
		public void AddInteractionBrushAtWorldLocationWithVelocity(FVector WorldLocation, float RadiusWorld, FVector WorldVelocity, float DensityScale = 1f, float VelocityCoupling = 1f)
		{
			AStamFluidGPU2DActor.__AddInteractionBrushAtWorldLocationWithVelocity_Internal(base.NativePtr, WorldLocation, RadiusWorld, WorldVelocity, DensityScale, VelocityCoupling);
		}

		// Token: 0x06016935 RID: 92469 RVA: 0x0020F414 File Offset: 0x0020D614
		public void AddInteractionBrushAtWorldLocation(FVector WorldLocation, float RadiusWorld, float DensityScale = 1f, FName BrushId = default(FName))
		{
			AStamFluidGPU2DActor.__AddInteractionBrushAtWorldLocation_Internal(base.NativePtr, WorldLocation, RadiusWorld, DensityScale, BrushId);
		}

		// Token: 0x06016936 RID: 92470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInteractionBrushHistory_Internal(IntPtr @this, FName BrushId);

		// Token: 0x06016937 RID: 92471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetFluid_Internal(IntPtr @this);

		// Token: 0x06016938 RID: 92472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshInteractionVolumeComponent_Internal(IntPtr @this);

		// Token: 0x06016939 RID: 92473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogStamFluidGPU2DState_Internal(IntPtr @this);

		// Token: 0x0601693A RID: 92474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogOutputRenderTargetCenterPixel_Internal(IntPtr @this);

		// Token: 0x0601693B RID: 92475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LogInteractionVolumeCandidates_Internal(IntPtr @this);

		// Token: 0x0601693C RID: 92476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFluidSimulationActiveNow_Internal(IntPtr @this);

		// Token: 0x0601693D RID: 92477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSimulationCenter_Internal(IntPtr @this);

		// Token: 0x0601693E RID: 92478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOutputRenderTarget_Internal(IntPtr @this);

		// Token: 0x0601693F RID: 92479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInteractionBrushAtWorldLocationWithVelocity_Internal(IntPtr @this, FVector WorldLocation, float RadiusWorld, FVector WorldVelocity, float DensityScale, float VelocityCoupling);

		// Token: 0x06016940 RID: 92480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddInteractionBrushAtWorldLocation_Internal(IntPtr @this, FVector WorldLocation, float RadiusWorld, float DensityScale, FName BrushId);

		// Token: 0x06016941 RID: 92481 RVA: 0x0020F426 File Offset: 0x0020D626
		static AStamFluidGPU2DActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.StamFluidGPU2DActor");
		}

		// Token: 0x06016942 RID: 92482 RVA: 0x0020F434 File Offset: 0x0020D634
		protected AStamFluidGPU2DActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C3EC RID: 50156
		public new const string __ObjectPath = "/Script/KuroComputeShader.StamFluidGPU2DActor";

		// Token: 0x0400C3ED RID: 50157
		private static IntPtr _ClassPtr;

		// Token: 0x0400C3EE RID: 50158
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C3EF RID: 50159
		internal static int __PropertyOffset_GridN;

		// Token: 0x0400C3F0 RID: 50160
		internal static int __PropertyOffset_VelocityDecay;

		// Token: 0x0400C3F1 RID: 50161
		internal static int __PropertyOffset_DensityDecay;

		// Token: 0x0400C3F2 RID: 50162
		internal static int __PropertyOffset_PressureIterations;

		// Token: 0x0400C3F3 RID: 50163
		internal static int __PropertyOffset_AdvectIterations;

		// Token: 0x0400C3F4 RID: 50164
		internal static int __PropertyOffset_VortexIntensity;

		// Token: 0x0400C3F5 RID: 50165
		internal static int __PropertyOffset_MaxVortexKick;

		// Token: 0x0400C3F6 RID: 50166
		internal static int __PropertyOffset_InjectVortexSuppression;

		// Token: 0x0400C3F7 RID: 50167
		internal static int __PropertyOffset_MaxSpeed;

		// Token: 0x0400C3F8 RID: 50168
		internal static int __PropertyOffset_SimDtScale;

		// Token: 0x0400C3F9 RID: 50169
		internal static int __PropertyOffset_SimHz;

		// Token: 0x0400C3FA RID: 50170
		internal static int __PropertyOffset_MaxSimSubstepsPerFrame;

		// Token: 0x0400C3FB RID: 50171
		internal static int __PropertyOffset_InjectDensity;

		// Token: 0x0400C3FC RID: 50172
		internal static int __PropertyOffset_InjectSpeed;

		// Token: 0x0400C3FD RID: 50173
		internal static int __PropertyOffset_InjectVelocityScale;

		// Token: 0x0400C3FE RID: 50174
		internal static int __PropertyOffset_InjectVelocityCoupling;

		// Token: 0x0400C3FF RID: 50175
		internal static int __PropertyOffset_DirectVelocityInjectionScale;

		// Token: 0x0400C400 RID: 50176
		internal static int __PropertyOffset_InjectReferenceWorldSpeed;

		// Token: 0x0400C401 RID: 50177
		internal static int __PropertyOffset_MinInjectWorldSpeed;

		// Token: 0x0400C402 RID: 50178
		internal static int __PropertyOffset_BrushWorldRadius;

		// Token: 0x0400C403 RID: 50179
		internal static int __PropertyOffset_FootBoneNames;

		// Token: 0x0400C404 RID: 50180
		[Nullable(2)]
		private TArray<FName> _FootBoneNames;

		// Token: 0x0400C405 RID: 50181
		internal static int __PropertyOffset_InteractionVolumeComponentName;

		// Token: 0x0400C406 RID: 50182
		internal static int __PropertyOffset_InteractionVolumeComponentTag;

		// Token: 0x0400C407 RID: 50183
		internal static int __PropertyOffset_ActivateVolumeComponentName;

		// Token: 0x0400C408 RID: 50184
		internal static int __PropertyOffset_ActivateVolumeComponentTag;

		// Token: 0x0400C409 RID: 50185
		internal static int __PropertyOffset_OnPawnEnteredActivateVolume;

		// Token: 0x0400C40A RID: 50186
		[Nullable(2)]
		private FStamFluidGPU2DActivationVolumeEvent _OnPawnEnteredActivateVolume;

		// Token: 0x0400C40B RID: 50187
		internal static int __PropertyOffset_OnPawnExitedActivateVolume;

		// Token: 0x0400C40C RID: 50188
		[Nullable(2)]
		private FStamFluidGPU2DActivationVolumeEvent _OnPawnExitedActivateVolume;

		// Token: 0x0400C40D RID: 50189
		internal static int __PropertyOffset_FluidTriggerTag;

		// Token: 0x0400C40E RID: 50190
		internal static int __PropertyOffset_MaxInteractionBrushes;

		// Token: 0x0400C40F RID: 50191
		internal static int __PropertyOffset_BlueprintBrushVelocityHistoryTimeout;

		// Token: 0x0400C410 RID: 50192
		internal static int __PropertyOffset_bUseCatmullRomForFastBlueprintBrushes;

		// Token: 0x0400C411 RID: 50193
		internal static int __PropertyOffset_BlueprintBrushCatmullMinSegmentWorldDistance;

		// Token: 0x0400C412 RID: 50194
		internal static int __PropertyOffset_BlueprintBrushCatmullMinWorldSpeed;

		// Token: 0x0400C413 RID: 50195
		internal static int __PropertyOffset_BlueprintBrushCatmullTargetSegmentWorldDistance;

		// Token: 0x0400C414 RID: 50196
		internal static int __PropertyOffset_MaxBlueprintBrushCatmullSubsteps;

		// Token: 0x0400C415 RID: 50197
		internal static int __PropertyOffset_BlueprintBrushCatmullAlpha;

		// Token: 0x0400C416 RID: 50198
		internal static int __PropertyOffset_BlueprintBrushCatmullTension;

		// Token: 0x0400C417 RID: 50199
		internal static int __PropertyOffset_bRunSimulationStepForBlueprintBrushes;

		// Token: 0x0400C418 RID: 50200
		internal static int __PropertyOffset_InteractionWarmupFrames;

		// Token: 0x0400C419 RID: 50201
		internal static int __PropertyOffset_MaxAutomaticBrushSegmentWorldDistance;

		// Token: 0x0400C41A RID: 50202
		internal static int __PropertyOffset_DisplaySize;

		// Token: 0x0400C41B RID: 50203
		internal static int __PropertyOffset_bShowInjectSphere;

		// Token: 0x0400C41C RID: 50204
		internal static int __PropertyOffset_DebugInjectSphereLifeTime;

		// Token: 0x0400C41D RID: 50205
		internal static int __PropertyOffset_bCenterSimulationOnPlayer;

		// Token: 0x0400C41E RID: 50206
		internal static int __PropertyOffset_SimulationCenterFollowActor;

		// Token: 0x0400C41F RID: 50207
		internal static int __PropertyOffset_bSmoothSimulationRebase;

		// Token: 0x0400C420 RID: 50208
		internal static int __PropertyOffset_SimulationCenter;

		// Token: 0x0400C421 RID: 50209
		internal static int __PropertyOffset_bWriteDensityToRenderTarget;

		// Token: 0x0400C422 RID: 50210
		internal static int __PropertyOffset_bAutoCreateOutputRenderTarget;

		// Token: 0x0400C423 RID: 50211
		internal static int __PropertyOffset_bResizeOutputRenderTarget;

		// Token: 0x0400C424 RID: 50212
		internal static int __PropertyOffset_OutputVelocityScale;

		// Token: 0x0400C425 RID: 50213
		internal static int __PropertyOffset_OutputDebugMode;

		// Token: 0x0400C426 RID: 50214
		internal static int __PropertyOffset_OutputRenderTarget;

		// Token: 0x0400C427 RID: 50215
		internal static int __PropertyOffset_RuntimeOutputRenderTarget;
	}
}
