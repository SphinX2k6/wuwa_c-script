using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029FF RID: 10751
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetComponent")]
	[UnrealStructLayout(1920, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1920)]
	public class UWidgetComponent : UMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027EB1 RID: 163505 RVA: 0x003CCF7D File Offset: 0x003CB17D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetComponent._ClassPtr;
		}

		// Token: 0x06027EB2 RID: 163506 RVA: 0x003CCF8C File Offset: 0x003CB18C
		public UWidgetComponent() : this(BuiltinUtils.AllocNativeUObject(UWidgetComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027EB3 RID: 163507 RVA: 0x003CCFB4 File Offset: 0x003CB1B4
		[NullableContext(1)]
		public UWidgetComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009888 RID: 39048
		// (get) Token: 0x06027EB4 RID: 163508 RVA: 0x003CCFE7 File Offset: 0x003CB1E7
		// (set) Token: 0x06027EB5 RID: 163509 RVA: 0x003CCFF7 File Offset: 0x003CB1F7
		public unsafe EWidgetSpace Space
		{
			get
			{
				return (EWidgetSpace)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x17009889 RID: 39049
		// (get) Token: 0x06027EB6 RID: 163510 RVA: 0x003CD008 File Offset: 0x003CB208
		// (set) Token: 0x06027EB7 RID: 163511 RVA: 0x003CD018 File Offset: 0x003CB218
		public unsafe EWidgetTimingPolicy TimingPolicy
		{
			get
			{
				return (EWidgetTimingPolicy)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TimingPolicy));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TimingPolicy) = (byte)value;
			}
		}

		// Token: 0x1700988A RID: 39050
		// (get) Token: 0x06027EB8 RID: 163512 RVA: 0x003CD029 File Offset: 0x003CB229
		// (set) Token: 0x06027EB9 RID: 163513 RVA: 0x003CD03D File Offset: 0x003CB23D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UUserWidget> WidgetClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WidgetClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WidgetClass) = value;
			}
		}

		// Token: 0x1700988B RID: 39051
		// (get) Token: 0x06027EBA RID: 163514 RVA: 0x003CD052 File Offset: 0x003CB252
		// (set) Token: 0x06027EBB RID: 163515 RVA: 0x003CD066 File Offset: 0x003CB266
		public unsafe FIntPoint DrawSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_DrawSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_DrawSize) = value;
			}
		}

		// Token: 0x1700988C RID: 39052
		// (get) Token: 0x06027EBC RID: 163516 RVA: 0x003CD07B File Offset: 0x003CB27B
		// (set) Token: 0x06027EBD RID: 163517 RVA: 0x003CD08B File Offset: 0x003CB28B
		public unsafe bool bManuallyRedraw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bManuallyRedraw) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bManuallyRedraw) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700988D RID: 39053
		// (get) Token: 0x06027EBE RID: 163518 RVA: 0x003CD09C File Offset: 0x003CB29C
		// (set) Token: 0x06027EBF RID: 163519 RVA: 0x003CD0AC File Offset: 0x003CB2AC
		public unsafe bool bRedrawRequested
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bRedrawRequested) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bRedrawRequested) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700988E RID: 39054
		// (get) Token: 0x06027EC0 RID: 163520 RVA: 0x003CD0BD File Offset: 0x003CB2BD
		// (set) Token: 0x06027EC1 RID: 163521 RVA: 0x003CD0CD File Offset: 0x003CB2CD
		public unsafe float RedrawTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_RedrawTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_RedrawTime) = value;
			}
		}

		// Token: 0x1700988F RID: 39055
		// (get) Token: 0x06027EC2 RID: 163522 RVA: 0x003CD0DE File Offset: 0x003CB2DE
		// (set) Token: 0x06027EC3 RID: 163523 RVA: 0x003CD0F2 File Offset: 0x003CB2F2
		public unsafe FIntPoint CurrentDrawSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CurrentDrawSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CurrentDrawSize) = value;
			}
		}

		// Token: 0x17009890 RID: 39056
		// (get) Token: 0x06027EC4 RID: 163524 RVA: 0x003CD107 File Offset: 0x003CB307
		// (set) Token: 0x06027EC5 RID: 163525 RVA: 0x003CD117 File Offset: 0x003CB317
		public unsafe bool bDrawAtDesiredSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bDrawAtDesiredSize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bDrawAtDesiredSize) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009891 RID: 39057
		// (get) Token: 0x06027EC6 RID: 163526 RVA: 0x003CD128 File Offset: 0x003CB328
		// (set) Token: 0x06027EC7 RID: 163527 RVA: 0x003CD13C File Offset: 0x003CB33C
		public unsafe FVector2D Pivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Pivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_Pivot) = value;
			}
		}

		// Token: 0x17009892 RID: 39058
		// (get) Token: 0x06027EC8 RID: 163528 RVA: 0x003CD151 File Offset: 0x003CB351
		// (set) Token: 0x06027EC9 RID: 163529 RVA: 0x003CD161 File Offset: 0x003CB361
		public unsafe bool bReceiveHardwareInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bReceiveHardwareInput) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bReceiveHardwareInput) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009893 RID: 39059
		// (get) Token: 0x06027ECA RID: 163530 RVA: 0x003CD172 File Offset: 0x003CB372
		// (set) Token: 0x06027ECB RID: 163531 RVA: 0x003CD182 File Offset: 0x003CB382
		public unsafe bool bWindowFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bWindowFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bWindowFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009894 RID: 39060
		// (get) Token: 0x06027ECC RID: 163532 RVA: 0x003CD193 File Offset: 0x003CB393
		// (set) Token: 0x06027ECD RID: 163533 RVA: 0x003CD1A3 File Offset: 0x003CB3A3
		public unsafe EWindowVisibility WindowVisibility
		{
			get
			{
				return (EWindowVisibility)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WindowVisibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_WindowVisibility) = (byte)value;
			}
		}

		// Token: 0x17009895 RID: 39061
		// (get) Token: 0x06027ECE RID: 163534 RVA: 0x003CD1B4 File Offset: 0x003CB3B4
		// (set) Token: 0x06027ECF RID: 163535 RVA: 0x003CD1C4 File Offset: 0x003CB3C4
		public unsafe bool bApplyGammaCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bApplyGammaCorrection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bApplyGammaCorrection) = (value ? 1 : 0);
			}
		}

		// Token: 0x17009896 RID: 39062
		// (get) Token: 0x06027ED0 RID: 163536 RVA: 0x003CD1D5 File Offset: 0x003CB3D5
		// (set) Token: 0x06027ED1 RID: 163537 RVA: 0x003CD1E9 File Offset: 0x003CB3E9
		public unsafe ULocalPlayer OwnerPlayer
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULocalPlayer>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OwnerPlayer);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OwnerPlayer, value);
			}
		}

		// Token: 0x17009897 RID: 39063
		// (get) Token: 0x06027ED2 RID: 163538 RVA: 0x003CD1FE File Offset: 0x003CB3FE
		// (set) Token: 0x06027ED3 RID: 163539 RVA: 0x003CD212 File Offset: 0x003CB412
		public unsafe FLinearColor BackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BackgroundColor) = value;
			}
		}

		// Token: 0x17009898 RID: 39064
		// (get) Token: 0x06027ED4 RID: 163540 RVA: 0x003CD227 File Offset: 0x003CB427
		// (set) Token: 0x06027ED5 RID: 163541 RVA: 0x003CD23B File Offset: 0x003CB43B
		public unsafe FLinearColor TintColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TintColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TintColorAndOpacity) = value;
			}
		}

		// Token: 0x17009899 RID: 39065
		// (get) Token: 0x06027ED6 RID: 163542 RVA: 0x003CD250 File Offset: 0x003CB450
		// (set) Token: 0x06027ED7 RID: 163543 RVA: 0x003CD260 File Offset: 0x003CB460
		public unsafe float OpacityFromTexture
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_OpacityFromTexture);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_OpacityFromTexture) = value;
			}
		}

		// Token: 0x1700989A RID: 39066
		// (get) Token: 0x06027ED8 RID: 163544 RVA: 0x003CD271 File Offset: 0x003CB471
		// (set) Token: 0x06027ED9 RID: 163545 RVA: 0x003CD281 File Offset: 0x003CB481
		public unsafe EWidgetBlendMode BlendMode
		{
			get
			{
				return (EWidgetBlendMode)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BlendMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_BlendMode) = (byte)value;
			}
		}

		// Token: 0x1700989B RID: 39067
		// (get) Token: 0x06027EDA RID: 163546 RVA: 0x003CD292 File Offset: 0x003CB492
		// (set) Token: 0x06027EDB RID: 163547 RVA: 0x003CD2A2 File Offset: 0x003CB4A2
		public unsafe bool bIsTwoSided
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bIsTwoSided) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bIsTwoSided) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700989C RID: 39068
		// (get) Token: 0x06027EDC RID: 163548 RVA: 0x003CD2B3 File Offset: 0x003CB4B3
		// (set) Token: 0x06027EDD RID: 163549 RVA: 0x003CD2C3 File Offset: 0x003CB4C3
		public unsafe bool TickWhenOffscreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickWhenOffscreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickWhenOffscreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700989D RID: 39069
		// (get) Token: 0x06027EDE RID: 163550 RVA: 0x003CD2D4 File Offset: 0x003CB4D4
		// (set) Token: 0x06027EDF RID: 163551 RVA: 0x003CD2E8 File Offset: 0x003CB4E8
		public unsafe UBodySetup BodySetup
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBodySetup>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_BodySetup);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_BodySetup, value);
			}
		}

		// Token: 0x1700989E RID: 39070
		// (get) Token: 0x06027EE0 RID: 163552 RVA: 0x003CD2FD File Offset: 0x003CB4FD
		// (set) Token: 0x06027EE1 RID: 163553 RVA: 0x003CD311 File Offset: 0x003CB511
		public unsafe UMaterialInterface TranslucentMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial, value);
			}
		}

		// Token: 0x1700989F RID: 39071
		// (get) Token: 0x06027EE2 RID: 163554 RVA: 0x003CD326 File Offset: 0x003CB526
		// (set) Token: 0x06027EE3 RID: 163555 RVA: 0x003CD33A File Offset: 0x003CB53A
		public unsafe UMaterialInterface TranslucentMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_TranslucentMaterial_OneSided, value);
			}
		}

		// Token: 0x170098A0 RID: 39072
		// (get) Token: 0x06027EE4 RID: 163556 RVA: 0x003CD34F File Offset: 0x003CB54F
		// (set) Token: 0x06027EE5 RID: 163557 RVA: 0x003CD363 File Offset: 0x003CB563
		public unsafe UMaterialInterface OpaqueMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial, value);
			}
		}

		// Token: 0x170098A1 RID: 39073
		// (get) Token: 0x06027EE6 RID: 163558 RVA: 0x003CD378 File Offset: 0x003CB578
		// (set) Token: 0x06027EE7 RID: 163559 RVA: 0x003CD38C File Offset: 0x003CB58C
		public unsafe UMaterialInterface OpaqueMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_OpaqueMaterial_OneSided, value);
			}
		}

		// Token: 0x170098A2 RID: 39074
		// (get) Token: 0x06027EE8 RID: 163560 RVA: 0x003CD3A1 File Offset: 0x003CB5A1
		// (set) Token: 0x06027EE9 RID: 163561 RVA: 0x003CD3B5 File Offset: 0x003CB5B5
		public unsafe UMaterialInterface MaskedMaterial
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial, value);
			}
		}

		// Token: 0x170098A3 RID: 39075
		// (get) Token: 0x06027EEA RID: 163562 RVA: 0x003CD3CA File Offset: 0x003CB5CA
		// (set) Token: 0x06027EEB RID: 163563 RVA: 0x003CD3DE File Offset: 0x003CB5DE
		public unsafe UMaterialInterface MaskedMaterial_OneSided
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial_OneSided);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaskedMaterial_OneSided, value);
			}
		}

		// Token: 0x170098A4 RID: 39076
		// (get) Token: 0x06027EEC RID: 163564 RVA: 0x003CD3F3 File Offset: 0x003CB5F3
		// (set) Token: 0x06027EED RID: 163565 RVA: 0x003CD407 File Offset: 0x003CB607
		public unsafe UTextureRenderTarget2D RenderTarget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_RenderTarget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_RenderTarget, value);
			}
		}

		// Token: 0x170098A5 RID: 39077
		// (get) Token: 0x06027EEE RID: 163566 RVA: 0x003CD41C File Offset: 0x003CB61C
		// (set) Token: 0x06027EEF RID: 163567 RVA: 0x003CD430 File Offset: 0x003CB630
		public unsafe UMaterialInstanceDynamic MaterialInstance
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInstanceDynamic>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaterialInstance);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_MaterialInstance, value);
			}
		}

		// Token: 0x170098A6 RID: 39078
		// (get) Token: 0x06027EF0 RID: 163568 RVA: 0x003CD445 File Offset: 0x003CB645
		// (set) Token: 0x06027EF1 RID: 163569 RVA: 0x003CD455 File Offset: 0x003CB655
		public unsafe bool bAddedToScreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bAddedToScreen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bAddedToScreen) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098A7 RID: 39079
		// (get) Token: 0x06027EF2 RID: 163570 RVA: 0x003CD466 File Offset: 0x003CB666
		// (set) Token: 0x06027EF3 RID: 163571 RVA: 0x003CD476 File Offset: 0x003CB676
		public unsafe bool bEditTimeUsable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bEditTimeUsable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_bEditTimeUsable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170098A8 RID: 39080
		// (get) Token: 0x06027EF4 RID: 163572 RVA: 0x003CD487 File Offset: 0x003CB687
		// (set) Token: 0x06027EF5 RID: 163573 RVA: 0x003CD49B File Offset: 0x003CB69B
		public unsafe FName SharedLayerName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_SharedLayerName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_SharedLayerName) = value;
			}
		}

		// Token: 0x170098A9 RID: 39081
		// (get) Token: 0x06027EF6 RID: 163574 RVA: 0x003CD4B0 File Offset: 0x003CB6B0
		// (set) Token: 0x06027EF7 RID: 163575 RVA: 0x003CD4C0 File Offset: 0x003CB6C0
		public unsafe int LayerZOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_LayerZOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_LayerZOrder) = value;
			}
		}

		// Token: 0x170098AA RID: 39082
		// (get) Token: 0x06027EF8 RID: 163576 RVA: 0x003CD4D1 File Offset: 0x003CB6D1
		// (set) Token: 0x06027EF9 RID: 163577 RVA: 0x003CD4E1 File Offset: 0x003CB6E1
		public unsafe EWidgetGeometryMode GeometryMode
		{
			get
			{
				return (EWidgetGeometryMode)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_GeometryMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_GeometryMode) = (byte)value;
			}
		}

		// Token: 0x170098AB RID: 39083
		// (get) Token: 0x06027EFA RID: 163578 RVA: 0x003CD4F2 File Offset: 0x003CB6F2
		// (set) Token: 0x06027EFB RID: 163579 RVA: 0x003CD502 File Offset: 0x003CB702
		public unsafe float CylinderArcAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CylinderArcAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_CylinderArcAngle) = value;
			}
		}

		// Token: 0x170098AC RID: 39084
		// (get) Token: 0x06027EFC RID: 163580 RVA: 0x003CD513 File Offset: 0x003CB713
		// (set) Token: 0x06027EFD RID: 163581 RVA: 0x003CD523 File Offset: 0x003CB723
		public unsafe ETickMode TickMode
		{
			get
			{
				return (ETickMode)(*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidgetComponent.__PropertyOffset_TickMode) = (byte)value;
			}
		}

		// Token: 0x170098AD RID: 39085
		// (get) Token: 0x06027EFE RID: 163582 RVA: 0x003CD534 File Offset: 0x003CB734
		// (set) Token: 0x06027EFF RID: 163583 RVA: 0x003CD548 File Offset: 0x003CB748
		public unsafe UUserWidget Widget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUserWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_Widget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidgetComponent.__PropertyOffset_Widget, value);
			}
		}

		// Token: 0x06027F00 RID: 163584 RVA: 0x003CD55D File Offset: 0x003CB75D
		public void SetWindowVisibility(EWindowVisibility InVisibility)
		{
			UWidgetComponent.__SetWindowVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x06027F01 RID: 163585 RVA: 0x003CD56B File Offset: 0x003CB76B
		public void SetWindowFocusable(bool bInWindowFocusable)
		{
			UWidgetComponent.__SetWindowFocusable_Internal(base.NativePtr, bInWindowFocusable);
		}

		// Token: 0x06027F02 RID: 163586 RVA: 0x003CD579 File Offset: 0x003CB779
		public void SetWidgetSpace(EWidgetSpace NewSpace)
		{
			UWidgetComponent.__SetWidgetSpace_Internal(base.NativePtr, NewSpace);
		}

		// Token: 0x06027F03 RID: 163587 RVA: 0x003CD587 File Offset: 0x003CB787
		public void SetWidget(UUserWidget Widget)
		{
			UWidgetComponent.__SetWidget_Internal(base.NativePtr, (Widget != null) ? Widget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027F04 RID: 163588 RVA: 0x003CD5A4 File Offset: 0x003CB7A4
		public void SetTwoSided(bool bWantTwoSided)
		{
			UWidgetComponent.__SetTwoSided_Internal(base.NativePtr, bWantTwoSided);
		}

		// Token: 0x06027F05 RID: 163589 RVA: 0x003CD5B2 File Offset: 0x003CB7B2
		public void SetTintColorAndOpacity(FLinearColor NewTintColorAndOpacity)
		{
			UWidgetComponent.__SetTintColorAndOpacity_Internal(base.NativePtr, NewTintColorAndOpacity);
		}

		// Token: 0x06027F06 RID: 163590 RVA: 0x003CD5C0 File Offset: 0x003CB7C0
		public void SetTickWhenOffscreen(bool bWantTickWhenOffscreen)
		{
			UWidgetComponent.__SetTickWhenOffscreen_Internal(base.NativePtr, bWantTickWhenOffscreen);
		}

		// Token: 0x06027F07 RID: 163591 RVA: 0x003CD5CE File Offset: 0x003CB7CE
		public void SetTickMode(ETickMode InTickMode)
		{
			UWidgetComponent.__SetTickMode_Internal(base.NativePtr, InTickMode);
		}

		// Token: 0x06027F08 RID: 163592 RVA: 0x003CD5DC File Offset: 0x003CB7DC
		public void SetRedrawTime(float InRedrawTime)
		{
			UWidgetComponent.__SetRedrawTime_Internal(base.NativePtr, InRedrawTime);
		}

		// Token: 0x06027F09 RID: 163593 RVA: 0x003CD5EA File Offset: 0x003CB7EA
		public void SetPivot(in FVector2D InPivot)
		{
			UWidgetComponent.__SetPivot_Internal(base.NativePtr, InPivot);
		}

		// Token: 0x06027F0A RID: 163594 RVA: 0x003CD5F8 File Offset: 0x003CB7F8
		public void SetOwnerPlayer(ULocalPlayer LocalPlayer)
		{
			UWidgetComponent.__SetOwnerPlayer_Internal(base.NativePtr, (LocalPlayer != null) ? LocalPlayer.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027F0B RID: 163595 RVA: 0x003CD615 File Offset: 0x003CB815
		public void SetManuallyRedraw(bool bUseManualRedraw)
		{
			UWidgetComponent.__SetManuallyRedraw_Internal(base.NativePtr, bUseManualRedraw);
		}

		// Token: 0x06027F0C RID: 163596 RVA: 0x003CD623 File Offset: 0x003CB823
		public void SetGeometryMode(EWidgetGeometryMode InGeometryMode)
		{
			UWidgetComponent.__SetGeometryMode_Internal(base.NativePtr, InGeometryMode);
		}

		// Token: 0x06027F0D RID: 163597 RVA: 0x003CD631 File Offset: 0x003CB831
		public void SetDrawSize(FVector2D Size)
		{
			UWidgetComponent.__SetDrawSize_Internal(base.NativePtr, Size);
		}

		// Token: 0x06027F0E RID: 163598 RVA: 0x003CD63F File Offset: 0x003CB83F
		public void SetDrawAtDesiredSize(bool bInDrawAtDesiredSize)
		{
			UWidgetComponent.__SetDrawAtDesiredSize_Internal(base.NativePtr, bInDrawAtDesiredSize);
		}

		// Token: 0x06027F0F RID: 163599 RVA: 0x003CD64D File Offset: 0x003CB84D
		public void SetCylinderArcAngle(float InCylinderArcAngle)
		{
			UWidgetComponent.__SetCylinderArcAngle_Internal(base.NativePtr, InCylinderArcAngle);
		}

		// Token: 0x06027F10 RID: 163600 RVA: 0x003CD65B File Offset: 0x003CB85B
		public void SetBackgroundColor(FLinearColor NewBackgroundColor)
		{
			UWidgetComponent.__SetBackgroundColor_Internal(base.NativePtr, NewBackgroundColor);
		}

		// Token: 0x06027F11 RID: 163601 RVA: 0x003CD669 File Offset: 0x003CB869
		public void RequestRedraw()
		{
			UWidgetComponent.__RequestRedraw_Internal(base.NativePtr);
		}

		// Token: 0x06027F12 RID: 163602 RVA: 0x003CD676 File Offset: 0x003CB876
		public bool IsWidgetVisible()
		{
			return UWidgetComponent.__IsWidgetVisible_Internal(base.NativePtr);
		}

		// Token: 0x06027F13 RID: 163603 RVA: 0x003CD683 File Offset: 0x003CB883
		public EWindowVisibility GetWindowVisiblility()
		{
			return UWidgetComponent.__GetWindowVisiblility_Internal(base.NativePtr);
		}

		// Token: 0x06027F14 RID: 163604 RVA: 0x003CD690 File Offset: 0x003CB890
		public bool GetWindowFocusable()
		{
			return UWidgetComponent.__GetWindowFocusable_Internal(base.NativePtr);
		}

		// Token: 0x06027F15 RID: 163605 RVA: 0x003CD69D File Offset: 0x003CB89D
		public EWidgetSpace GetWidgetSpace()
		{
			return UWidgetComponent.__GetWidgetSpace_Internal(base.NativePtr);
		}

		// Token: 0x06027F16 RID: 163606 RVA: 0x003CD6AA File Offset: 0x003CB8AA
		public UUserWidget GetWidget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetComponent.__GetWidget_Internal(base.NativePtr));
		}

		// Token: 0x06027F17 RID: 163607 RVA: 0x003CD6BC File Offset: 0x003CB8BC
		public UUserWidget GetUserWidgetObject()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetComponent.__GetUserWidgetObject_Internal(base.NativePtr));
		}

		// Token: 0x06027F18 RID: 163608 RVA: 0x003CD6CE File Offset: 0x003CB8CE
		public bool GetTwoSided()
		{
			return UWidgetComponent.__GetTwoSided_Internal(base.NativePtr);
		}

		// Token: 0x06027F19 RID: 163609 RVA: 0x003CD6DB File Offset: 0x003CB8DB
		public bool GetTickWhenOffscreen()
		{
			return UWidgetComponent.__GetTickWhenOffscreen_Internal(base.NativePtr);
		}

		// Token: 0x06027F1A RID: 163610 RVA: 0x003CD6E8 File Offset: 0x003CB8E8
		public UTextureRenderTarget2D GetRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(UWidgetComponent.__GetRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x06027F1B RID: 163611 RVA: 0x003CD6FA File Offset: 0x003CB8FA
		public float GetRedrawTime()
		{
			return UWidgetComponent.__GetRedrawTime_Internal(base.NativePtr);
		}

		// Token: 0x06027F1C RID: 163612 RVA: 0x003CD707 File Offset: 0x003CB907
		public FVector2D GetPivot()
		{
			return UWidgetComponent.__GetPivot_Internal(base.NativePtr);
		}

		// Token: 0x06027F1D RID: 163613 RVA: 0x003CD714 File Offset: 0x003CB914
		public ULocalPlayer GetOwnerPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULocalPlayer>(UWidgetComponent.__GetOwnerPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06027F1E RID: 163614 RVA: 0x003CD726 File Offset: 0x003CB926
		public UMaterialInstanceDynamic GetMaterialInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UWidgetComponent.__GetMaterialInstance_Internal(base.NativePtr));
		}

		// Token: 0x06027F1F RID: 163615 RVA: 0x003CD738 File Offset: 0x003CB938
		public bool GetManuallyRedraw()
		{
			return UWidgetComponent.__GetManuallyRedraw_Internal(base.NativePtr);
		}

		// Token: 0x06027F20 RID: 163616 RVA: 0x003CD745 File Offset: 0x003CB945
		public EWidgetGeometryMode GetGeometryMode()
		{
			return UWidgetComponent.__GetGeometryMode_Internal(base.NativePtr);
		}

		// Token: 0x06027F21 RID: 163617 RVA: 0x003CD752 File Offset: 0x003CB952
		public FVector2D GetDrawSize()
		{
			return UWidgetComponent.__GetDrawSize_Internal(base.NativePtr);
		}

		// Token: 0x06027F22 RID: 163618 RVA: 0x003CD75F File Offset: 0x003CB95F
		public bool GetDrawAtDesiredSize()
		{
			return UWidgetComponent.__GetDrawAtDesiredSize_Internal(base.NativePtr);
		}

		// Token: 0x06027F23 RID: 163619 RVA: 0x003CD76C File Offset: 0x003CB96C
		public float GetCylinderArcAngle()
		{
			return UWidgetComponent.__GetCylinderArcAngle_Internal(base.NativePtr);
		}

		// Token: 0x06027F24 RID: 163620 RVA: 0x003CD779 File Offset: 0x003CB979
		public FVector2D GetCurrentDrawSize()
		{
			return UWidgetComponent.__GetCurrentDrawSize_Internal(base.NativePtr);
		}

		// Token: 0x06027F25 RID: 163621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowVisibility_Internal(IntPtr @this, EWindowVisibility InVisibility);

		// Token: 0x06027F26 RID: 163622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowFocusable_Internal(IntPtr @this, bool bInWindowFocusable);

		// Token: 0x06027F27 RID: 163623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidgetSpace_Internal(IntPtr @this, EWidgetSpace NewSpace);

		// Token: 0x06027F28 RID: 163624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidget_Internal(IntPtr @this, IntPtr Widget);

		// Token: 0x06027F29 RID: 163625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTwoSided_Internal(IntPtr @this, bool bWantTwoSided);

		// Token: 0x06027F2A RID: 163626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTintColorAndOpacity_Internal(IntPtr @this, FLinearColor NewTintColorAndOpacity);

		// Token: 0x06027F2B RID: 163627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickWhenOffscreen_Internal(IntPtr @this, bool bWantTickWhenOffscreen);

		// Token: 0x06027F2C RID: 163628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTickMode_Internal(IntPtr @this, ETickMode InTickMode);

		// Token: 0x06027F2D RID: 163629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRedrawTime_Internal(IntPtr @this, float InRedrawTime);

		// Token: 0x06027F2E RID: 163630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Internal(IntPtr @this, in FVector2D InPivot);

		// Token: 0x06027F2F RID: 163631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerPlayer_Internal(IntPtr @this, IntPtr LocalPlayer);

		// Token: 0x06027F30 RID: 163632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetManuallyRedraw_Internal(IntPtr @this, bool bUseManualRedraw);

		// Token: 0x06027F31 RID: 163633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGeometryMode_Internal(IntPtr @this, EWidgetGeometryMode InGeometryMode);

		// Token: 0x06027F32 RID: 163634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawSize_Internal(IntPtr @this, FVector2D Size);

		// Token: 0x06027F33 RID: 163635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDrawAtDesiredSize_Internal(IntPtr @this, bool bInDrawAtDesiredSize);

		// Token: 0x06027F34 RID: 163636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCylinderArcAngle_Internal(IntPtr @this, float InCylinderArcAngle);

		// Token: 0x06027F35 RID: 163637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBackgroundColor_Internal(IntPtr @this, FLinearColor NewBackgroundColor);

		// Token: 0x06027F36 RID: 163638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RequestRedraw_Internal(IntPtr @this);

		// Token: 0x06027F37 RID: 163639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWidgetVisible_Internal(IntPtr @this);

		// Token: 0x06027F38 RID: 163640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWindowVisibility __GetWindowVisiblility_Internal(IntPtr @this);

		// Token: 0x06027F39 RID: 163641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetWindowFocusable_Internal(IntPtr @this);

		// Token: 0x06027F3A RID: 163642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWidgetSpace __GetWidgetSpace_Internal(IntPtr @this);

		// Token: 0x06027F3B RID: 163643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWidget_Internal(IntPtr @this);

		// Token: 0x06027F3C RID: 163644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetUserWidgetObject_Internal(IntPtr @this);

		// Token: 0x06027F3D RID: 163645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTwoSided_Internal(IntPtr @this);

		// Token: 0x06027F3E RID: 163646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetTickWhenOffscreen_Internal(IntPtr @this);

		// Token: 0x06027F3F RID: 163647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderTarget_Internal(IntPtr @this);

		// Token: 0x06027F40 RID: 163648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRedrawTime_Internal(IntPtr @this);

		// Token: 0x06027F41 RID: 163649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPivot_Internal(IntPtr @this);

		// Token: 0x06027F42 RID: 163650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwnerPlayer_Internal(IntPtr @this);

		// Token: 0x06027F43 RID: 163651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMaterialInstance_Internal(IntPtr @this);

		// Token: 0x06027F44 RID: 163652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetManuallyRedraw_Internal(IntPtr @this);

		// Token: 0x06027F45 RID: 163653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWidgetGeometryMode __GetGeometryMode_Internal(IntPtr @this);

		// Token: 0x06027F46 RID: 163654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetDrawSize_Internal(IntPtr @this);

		// Token: 0x06027F47 RID: 163655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDrawAtDesiredSize_Internal(IntPtr @this);

		// Token: 0x06027F48 RID: 163656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCylinderArcAngle_Internal(IntPtr @this);

		// Token: 0x06027F49 RID: 163657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetCurrentDrawSize_Internal(IntPtr @this);

		// Token: 0x06027F4A RID: 163658 RVA: 0x003CD786 File Offset: 0x003CB986
		static UWidgetComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetComponent");
		}

		// Token: 0x06027F4B RID: 163659 RVA: 0x003CD794 File Offset: 0x003CB994
		protected UWidgetComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CE7 RID: 89319
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetComponent";

		// Token: 0x04015CE8 RID: 89320
		private static IntPtr _ClassPtr;

		// Token: 0x04015CE9 RID: 89321
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CEA RID: 89322
		internal static int __PropertyOffset_Space;

		// Token: 0x04015CEB RID: 89323
		internal static int __PropertyOffset_TimingPolicy;

		// Token: 0x04015CEC RID: 89324
		internal static int __PropertyOffset_WidgetClass;

		// Token: 0x04015CED RID: 89325
		internal static int __PropertyOffset_DrawSize;

		// Token: 0x04015CEE RID: 89326
		internal static int __PropertyOffset_bManuallyRedraw;

		// Token: 0x04015CEF RID: 89327
		internal static int __PropertyOffset_bRedrawRequested;

		// Token: 0x04015CF0 RID: 89328
		internal static int __PropertyOffset_RedrawTime;

		// Token: 0x04015CF1 RID: 89329
		internal static int __PropertyOffset_CurrentDrawSize;

		// Token: 0x04015CF2 RID: 89330
		internal static int __PropertyOffset_bDrawAtDesiredSize;

		// Token: 0x04015CF3 RID: 89331
		internal static int __PropertyOffset_Pivot;

		// Token: 0x04015CF4 RID: 89332
		internal static int __PropertyOffset_bReceiveHardwareInput;

		// Token: 0x04015CF5 RID: 89333
		internal static int __PropertyOffset_bWindowFocusable;

		// Token: 0x04015CF6 RID: 89334
		internal static int __PropertyOffset_WindowVisibility;

		// Token: 0x04015CF7 RID: 89335
		internal static int __PropertyOffset_bApplyGammaCorrection;

		// Token: 0x04015CF8 RID: 89336
		internal static int __PropertyOffset_OwnerPlayer;

		// Token: 0x04015CF9 RID: 89337
		internal static int __PropertyOffset_BackgroundColor;

		// Token: 0x04015CFA RID: 89338
		internal static int __PropertyOffset_TintColorAndOpacity;

		// Token: 0x04015CFB RID: 89339
		internal static int __PropertyOffset_OpacityFromTexture;

		// Token: 0x04015CFC RID: 89340
		internal static int __PropertyOffset_BlendMode;

		// Token: 0x04015CFD RID: 89341
		internal static int __PropertyOffset_bIsTwoSided;

		// Token: 0x04015CFE RID: 89342
		internal static int __PropertyOffset_TickWhenOffscreen;

		// Token: 0x04015CFF RID: 89343
		internal static int __PropertyOffset_BodySetup;

		// Token: 0x04015D00 RID: 89344
		internal static int __PropertyOffset_TranslucentMaterial;

		// Token: 0x04015D01 RID: 89345
		internal static int __PropertyOffset_TranslucentMaterial_OneSided;

		// Token: 0x04015D02 RID: 89346
		internal static int __PropertyOffset_OpaqueMaterial;

		// Token: 0x04015D03 RID: 89347
		internal static int __PropertyOffset_OpaqueMaterial_OneSided;

		// Token: 0x04015D04 RID: 89348
		internal static int __PropertyOffset_MaskedMaterial;

		// Token: 0x04015D05 RID: 89349
		internal static int __PropertyOffset_MaskedMaterial_OneSided;

		// Token: 0x04015D06 RID: 89350
		internal static int __PropertyOffset_RenderTarget;

		// Token: 0x04015D07 RID: 89351
		internal static int __PropertyOffset_MaterialInstance;

		// Token: 0x04015D08 RID: 89352
		internal static int __PropertyOffset_bAddedToScreen;

		// Token: 0x04015D09 RID: 89353
		internal static int __PropertyOffset_bEditTimeUsable;

		// Token: 0x04015D0A RID: 89354
		internal static int __PropertyOffset_SharedLayerName;

		// Token: 0x04015D0B RID: 89355
		internal static int __PropertyOffset_LayerZOrder;

		// Token: 0x04015D0C RID: 89356
		internal static int __PropertyOffset_GeometryMode;

		// Token: 0x04015D0D RID: 89357
		internal static int __PropertyOffset_CylinderArcAngle;

		// Token: 0x04015D0E RID: 89358
		internal static int __PropertyOffset_TickMode;

		// Token: 0x04015D0F RID: 89359
		internal static int __PropertyOffset_Widget;
	}
}
