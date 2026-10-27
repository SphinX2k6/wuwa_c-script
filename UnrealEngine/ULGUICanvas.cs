using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200202D RID: 8237
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUICanvas")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public class ULGUICanvas : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601F1A1 RID: 127393 RVA: 0x002E3852 File Offset: 0x002E1A52
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICanvas._ClassPtr;
		}

		// Token: 0x0601F1A2 RID: 127394 RVA: 0x002E3860 File Offset: 0x002E1A60
		public ULGUICanvas() : this(BuiltinUtils.AllocNativeUObject(ULGUICanvas.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F1A3 RID: 127395 RVA: 0x002E3888 File Offset: 0x002E1A88
		public ULGUICanvas(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICanvas.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007B60 RID: 31584
		// (get) Token: 0x0601F1A4 RID: 127396 RVA: 0x002E38BB File Offset: 0x002E1ABB
		// (set) Token: 0x0601F1A5 RID: 127397 RVA: 0x002E38CF File Offset: 0x002E1ACF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> RootCanvasActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_RootCanvasActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_RootCanvasActor) = value;
			}
		}

		// Token: 0x17007B61 RID: 31585
		// (get) Token: 0x0601F1A6 RID: 127398 RVA: 0x002E38E4 File Offset: 0x002E1AE4
		// (set) Token: 0x0601F1A7 RID: 127399 RVA: 0x002E38F4 File Offset: 0x002E1AF4
		public unsafe ELGUIRenderMode renderMode
		{
			get
			{
				return (ELGUIRenderMode)(*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_renderMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_renderMode) = (byte)value;
			}
		}

		// Token: 0x17007B62 RID: 31586
		// (get) Token: 0x0601F1A8 RID: 127400 RVA: 0x002E3905 File Offset: 0x002E1B05
		// (set) Token: 0x0601F1A9 RID: 127401 RVA: 0x002E3919 File Offset: 0x002E1B19
		[Nullable(2)]
		public unsafe UTextureRenderTarget2D renderTarget
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureRenderTarget2D>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvas.__PropertyOffset_renderTarget);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvas.__PropertyOffset_renderTarget, value);
			}
		}

		// Token: 0x17007B63 RID: 31587
		// (get) Token: 0x0601F1AA RID: 127402 RVA: 0x002E392E File Offset: 0x002E1B2E
		// (set) Token: 0x0601F1AB RID: 127403 RVA: 0x002E393E File Offset: 0x002E1B3E
		public unsafe bool pixelPerfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_pixelPerfect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_pixelPerfect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B64 RID: 31588
		// (get) Token: 0x0601F1AC RID: 127404 RVA: 0x002E394F File Offset: 0x002E1B4F
		// (set) Token: 0x0601F1AD RID: 127405 RVA: 0x002E395F File Offset: 0x002E1B5F
		public unsafe int CanvasDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_CanvasDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_CanvasDepth) = value;
			}
		}

		// Token: 0x17007B65 RID: 31589
		// (get) Token: 0x0601F1AE RID: 127406 RVA: 0x002E3970 File Offset: 0x002E1B70
		// (set) Token: 0x0601F1AF RID: 127407 RVA: 0x002E3980 File Offset: 0x002E1B80
		public unsafe int sortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_sortOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_sortOrder) = value;
			}
		}

		// Token: 0x17007B66 RID: 31590
		// (get) Token: 0x0601F1B0 RID: 127408 RVA: 0x002E3991 File Offset: 0x002E1B91
		// (set) Token: 0x0601F1B1 RID: 127409 RVA: 0x002E39A1 File Offset: 0x002E1BA1
		public unsafe int AdditionalSortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_AdditionalSortOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_AdditionalSortOrder) = value;
			}
		}

		// Token: 0x17007B67 RID: 31591
		// (get) Token: 0x0601F1B2 RID: 127410 RVA: 0x002E39B2 File Offset: 0x002E1BB2
		// (set) Token: 0x0601F1B3 RID: 127411 RVA: 0x002E39C2 File Offset: 0x002E1BC2
		public unsafe bool bOverrideSortOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bOverrideSortOrder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bOverrideSortOrder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B68 RID: 31592
		// (get) Token: 0x0601F1B4 RID: 127412 RVA: 0x002E39D3 File Offset: 0x002E1BD3
		// (set) Token: 0x0601F1B5 RID: 127413 RVA: 0x002E39E3 File Offset: 0x002E1BE3
		public unsafe bool bIsMainLayer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bIsMainLayer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bIsMainLayer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B69 RID: 31593
		// (get) Token: 0x0601F1B6 RID: 127414 RVA: 0x002E39F4 File Offset: 0x002E1BF4
		// (set) Token: 0x0601F1B7 RID: 127415 RVA: 0x002E3A04 File Offset: 0x002E1C04
		public unsafe int SubLayerOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_SubLayerOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_SubLayerOrder) = value;
			}
		}

		// Token: 0x17007B6A RID: 31594
		// (get) Token: 0x0601F1B8 RID: 127416 RVA: 0x002E3A15 File Offset: 0x002E1C15
		// (set) Token: 0x0601F1B9 RID: 127417 RVA: 0x002E3A25 File Offset: 0x002E1C25
		public unsafe ELGUICanvasClipType clipType
		{
			get
			{
				return (ELGUICanvasClipType)(*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipType) = (byte)value;
			}
		}

		// Token: 0x17007B6B RID: 31595
		// (get) Token: 0x0601F1BA RID: 127418 RVA: 0x002E3A36 File Offset: 0x002E1C36
		// (set) Token: 0x0601F1BB RID: 127419 RVA: 0x002E3A4A File Offset: 0x002E1C4A
		public unsafe FVector2D clipFeather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipFeather);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipFeather) = value;
			}
		}

		// Token: 0x17007B6C RID: 31596
		// (get) Token: 0x0601F1BC RID: 127420 RVA: 0x002E3A5F File Offset: 0x002E1C5F
		// (set) Token: 0x0601F1BD RID: 127421 RVA: 0x002E3A73 File Offset: 0x002E1C73
		public unsafe FMargin clipFeatherNew
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipFeatherNew);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipFeatherNew) = value;
			}
		}

		// Token: 0x17007B6D RID: 31597
		// (get) Token: 0x0601F1BE RID: 127422 RVA: 0x002E3A88 File Offset: 0x002E1C88
		// (set) Token: 0x0601F1BF RID: 127423 RVA: 0x002E3A9C File Offset: 0x002E1C9C
		public unsafe FMargin clipRectOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipRectOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipRectOffset) = value;
			}
		}

		// Token: 0x17007B6E RID: 31598
		// (get) Token: 0x0601F1C0 RID: 127424 RVA: 0x002E3AB1 File Offset: 0x002E1CB1
		// (set) Token: 0x0601F1C1 RID: 127425 RVA: 0x002E3AC5 File Offset: 0x002E1CC5
		[Nullable(2)]
		public unsafe UTexture clipTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvas.__PropertyOffset_clipTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULGUICanvas.__PropertyOffset_clipTexture, value);
			}
		}

		// Token: 0x17007B6F RID: 31599
		// (get) Token: 0x0601F1C2 RID: 127426 RVA: 0x002E3ADA File Offset: 0x002E1CDA
		// (set) Token: 0x0601F1C3 RID: 127427 RVA: 0x002E3AEA File Offset: 0x002E1CEA
		public unsafe bool bEnableSliceBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableSliceBorder) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableSliceBorder) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B70 RID: 31600
		// (get) Token: 0x0601F1C4 RID: 127428 RVA: 0x002E3AFB File Offset: 0x002E1CFB
		// (set) Token: 0x0601F1C5 RID: 127429 RVA: 0x002E3B0F File Offset: 0x002E1D0F
		public unsafe FVector4 SliceBorder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_SliceBorder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_SliceBorder) = value;
			}
		}

		// Token: 0x17007B71 RID: 31601
		// (get) Token: 0x0601F1C6 RID: 127430 RVA: 0x002E3B24 File Offset: 0x002E1D24
		// (set) Token: 0x0601F1C7 RID: 127431 RVA: 0x002E3B34 File Offset: 0x002E1D34
		public unsafe float clipTextureAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipTextureAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_clipTextureAlpha) = value;
			}
		}

		// Token: 0x17007B72 RID: 31602
		// (get) Token: 0x0601F1C8 RID: 127432 RVA: 0x002E3B45 File Offset: 0x002E1D45
		// (set) Token: 0x0601F1C9 RID: 127433 RVA: 0x002E3B55 File Offset: 0x002E1D55
		public unsafe bool inheritRectClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_inheritRectClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_inheritRectClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B73 RID: 31603
		// (get) Token: 0x0601F1CA RID: 127434 RVA: 0x002E3B66 File Offset: 0x002E1D66
		// (set) Token: 0x0601F1CB RID: 127435 RVA: 0x002E3B76 File Offset: 0x002E1D76
		public unsafe bool inheritRectClipFull
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_inheritRectClipFull) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_inheritRectClipFull) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B74 RID: 31604
		// (get) Token: 0x0601F1CC RID: 127436 RVA: 0x002E3B87 File Offset: 0x002E1D87
		// (set) Token: 0x0601F1CD RID: 127437 RVA: 0x002E3B97 File Offset: 0x002E1D97
		public unsafe bool bScreenSpaceRectClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bScreenSpaceRectClip) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bScreenSpaceRectClip) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B75 RID: 31605
		// (get) Token: 0x0601F1CE RID: 127438 RVA: 0x002E3BA8 File Offset: 0x002E1DA8
		// (set) Token: 0x0601F1CF RID: 127439 RVA: 0x002E3BB8 File Offset: 0x002E1DB8
		public unsafe bool bFlipClipArea
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bFlipClipArea) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bFlipClipArea) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B76 RID: 31606
		// (get) Token: 0x0601F1D0 RID: 127440 RVA: 0x002E3BC9 File Offset: 0x002E1DC9
		// (set) Token: 0x0601F1D1 RID: 127441 RVA: 0x002E3BD9 File Offset: 0x002E1DD9
		public unsafe bool bClipWithRectOp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bClipWithRectOp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bClipWithRectOp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B77 RID: 31607
		// (get) Token: 0x0601F1D2 RID: 127442 RVA: 0x002E3BEA File Offset: 0x002E1DEA
		// (set) Token: 0x0601F1D3 RID: 127443 RVA: 0x002E3BFA File Offset: 0x002E1DFA
		public unsafe bool bPointVisibleWithFeather
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPointVisibleWithFeather) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPointVisibleWithFeather) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B78 RID: 31608
		// (get) Token: 0x0601F1D4 RID: 127444 RVA: 0x002E3C0B File Offset: 0x002E1E0B
		// (set) Token: 0x0601F1D5 RID: 127445 RVA: 0x002E3C1B File Offset: 0x002E1E1B
		public unsafe bool bForceTopmostText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bForceTopmostText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bForceTopmostText) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B79 RID: 31609
		// (get) Token: 0x0601F1D6 RID: 127446 RVA: 0x002E3C2C File Offset: 0x002E1E2C
		// (set) Token: 0x0601F1D7 RID: 127447 RVA: 0x002E3C3C File Offset: 0x002E1E3C
		public unsafe float dynamicPixelsPerUnit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_dynamicPixelsPerUnit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_dynamicPixelsPerUnit) = value;
			}
		}

		// Token: 0x17007B7A RID: 31610
		// (get) Token: 0x0601F1D8 RID: 127448 RVA: 0x002E3C4D File Offset: 0x002E1E4D
		// (set) Token: 0x0601F1D9 RID: 127449 RVA: 0x002E3C5D File Offset: 0x002E1E5D
		public unsafe sbyte additionalShaderChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_additionalShaderChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_additionalShaderChannels) = (byte)value;
			}
		}

		// Token: 0x17007B7B RID: 31611
		// (get) Token: 0x0601F1DA RID: 127450 RVA: 0x002E3C70 File Offset: 0x002E1E70
		// (set) Token: 0x0601F1DB RID: 127451 RVA: 0x002E3CAA File Offset: 0x002E1EAA
		public TFixedArray<UMaterialInterface> DefaultMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<UMaterialInterface> result;
				if ((result = this._DefaultMaterials) == null)
				{
					result = (this._DefaultMaterials = new TFixedArray<UMaterialInterface>(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_DefaultMaterials, 3, this));
				}
				return result;
			}
			set
			{
				this.DefaultMaterials.CopyAssign(value);
			}
		}

		// Token: 0x17007B7C RID: 31612
		// (get) Token: 0x0601F1DC RID: 127452 RVA: 0x002E3CB8 File Offset: 0x002E1EB8
		// (set) Token: 0x0601F1DD RID: 127453 RVA: 0x002E3CC8 File Offset: 0x002E1EC8
		public unsafe bool ownerNoSee
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_ownerNoSee) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_ownerNoSee) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B7D RID: 31613
		// (get) Token: 0x0601F1DE RID: 127454 RVA: 0x002E3CD9 File Offset: 0x002E1ED9
		// (set) Token: 0x0601F1DF RID: 127455 RVA: 0x002E3CE9 File Offset: 0x002E1EE9
		public unsafe bool onlyOwnerSee
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_onlyOwnerSee) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_onlyOwnerSee) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B7E RID: 31614
		// (get) Token: 0x0601F1E0 RID: 127456 RVA: 0x002E3CFA File Offset: 0x002E1EFA
		// (set) Token: 0x0601F1E1 RID: 127457 RVA: 0x002E3D0A File Offset: 0x002E1F0A
		public unsafe sbyte overrideParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_overrideParameters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_overrideParameters) = (byte)value;
			}
		}

		// Token: 0x17007B7F RID: 31615
		// (get) Token: 0x0601F1E2 RID: 127458 RVA: 0x002E3D1B File Offset: 0x002E1F1B
		// (set) Token: 0x0601F1E3 RID: 127459 RVA: 0x002E3D2B File Offset: 0x002E1F2B
		public unsafe bool bClipOutOfScreenRenderables
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bClipOutOfScreenRenderables) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bClipOutOfScreenRenderables) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B80 RID: 31616
		// (get) Token: 0x0601F1E4 RID: 127460 RVA: 0x002E3D3C File Offset: 0x002E1F3C
		// (set) Token: 0x0601F1E5 RID: 127461 RVA: 0x002E3D50 File Offset: 0x002E1F50
		public unsafe FVector2D ProjectCenterOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_ProjectCenterOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_ProjectCenterOffset) = value;
			}
		}

		// Token: 0x17007B81 RID: 31617
		// (get) Token: 0x0601F1E6 RID: 127462 RVA: 0x002E3D65 File Offset: 0x002E1F65
		// (set) Token: 0x0601F1E7 RID: 127463 RVA: 0x002E3D75 File Offset: 0x002E1F75
		public unsafe bool bEnableOnlyCanvasMovedOpt
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableOnlyCanvasMovedOpt) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableOnlyCanvasMovedOpt) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B82 RID: 31618
		// (get) Token: 0x0601F1E8 RID: 127464 RVA: 0x002E3D86 File Offset: 0x002E1F86
		// (set) Token: 0x0601F1E9 RID: 127465 RVA: 0x002E3D96 File Offset: 0x002E1F96
		public unsafe bool bCheckSameMaterialAndSkipBatchCal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bCheckSameMaterialAndSkipBatchCal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bCheckSameMaterialAndSkipBatchCal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B83 RID: 31619
		// (get) Token: 0x0601F1EA RID: 127466 RVA: 0x002E3DA7 File Offset: 0x002E1FA7
		// (set) Token: 0x0601F1EB RID: 127467 RVA: 0x002E3DB7 File Offset: 0x002E1FB7
		public unsafe bool bEnableCalBatchDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableCalBatchDepth) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bEnableCalBatchDepth) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B84 RID: 31620
		// (get) Token: 0x0601F1EC RID: 127468 RVA: 0x002E3DC8 File Offset: 0x002E1FC8
		// (set) Token: 0x0601F1ED RID: 127469 RVA: 0x002E3E01 File Offset: 0x002E2001
		public TSet<UUIBaseRenderable> RenderableSet
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UUIBaseRenderable> result;
				if ((result = this._RenderableSet) == null)
				{
					result = (this._RenderableSet = new TSet<UUIBaseRenderable>(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_RenderableSet, this));
				}
				return result;
			}
			set
			{
				this.RenderableSet.CopyAssign(value);
			}
		}

		// Token: 0x17007B85 RID: 31621
		// (get) Token: 0x0601F1EE RID: 127470 RVA: 0x002E3E10 File Offset: 0x002E2010
		// (set) Token: 0x0601F1EF RID: 127471 RVA: 0x002E3E49 File Offset: 0x002E2049
		public TArray<UUIBaseRenderable> ToRenderList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIBaseRenderable> result;
				if ((result = this._ToRenderList) == null)
				{
					result = (this._ToRenderList = new TArray<UUIBaseRenderable>(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_ToRenderList, this));
				}
				return result;
			}
			set
			{
				this.ToRenderList.CopyAssign(value);
			}
		}

		// Token: 0x17007B86 RID: 31622
		// (get) Token: 0x0601F1F0 RID: 127472 RVA: 0x002E3E58 File Offset: 0x002E2058
		// (set) Token: 0x0601F1F1 RID: 127473 RVA: 0x002E3E91 File Offset: 0x002E2091
		public TArray<FLGUIMaterialArrayContainer> PooledUIMaterialList
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLGUIMaterialArrayContainer> result;
				if ((result = this._PooledUIMaterialList) == null)
				{
					result = (this._PooledUIMaterialList = new TArray<FLGUIMaterialArrayContainer>(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_PooledUIMaterialList, this));
				}
				return result;
			}
			set
			{
				this.PooledUIMaterialList.CopyAssign(value);
			}
		}

		// Token: 0x17007B87 RID: 31623
		// (get) Token: 0x0601F1F2 RID: 127474 RVA: 0x002E3EA0 File Offset: 0x002E20A0
		// (set) Token: 0x0601F1F3 RID: 127475 RVA: 0x002E3ED9 File Offset: 0x002E20D9
		public TArray<UUIRenderableMask> RenderableMasks
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIRenderableMask> result;
				if ((result = this._RenderableMasks) == null)
				{
					result = (this._RenderableMasks = new TArray<UUIRenderableMask>(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_RenderableMasks, this));
				}
				return result;
			}
			set
			{
				this.RenderableMasks.CopyAssign(value);
			}
		}

		// Token: 0x17007B88 RID: 31624
		// (get) Token: 0x0601F1F4 RID: 127476 RVA: 0x002E3EE7 File Offset: 0x002E20E7
		// (set) Token: 0x0601F1F5 RID: 127477 RVA: 0x002E3F00 File Offset: 0x002E2100
		public unsafe bool IsUiScenePrimitive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_IsUiScenePrimitive) & ULGUICanvas.__PropertyMask_IsUiScenePrimitive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_IsUiScenePrimitive) = ((*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_IsUiScenePrimitive) & ~ULGUICanvas.__PropertyMask_IsUiScenePrimitive) | (value ? ULGUICanvas.__PropertyMask_IsUiScenePrimitive : 0));
			}
		}

		// Token: 0x17007B89 RID: 31625
		// (get) Token: 0x0601F1F6 RID: 127478 RVA: 0x002E3F30 File Offset: 0x002E2130
		// (set) Token: 0x0601F1F7 RID: 127479 RVA: 0x002E3F40 File Offset: 0x002E2140
		public unsafe bool bPostTickUpdate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPostTickUpdate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPostTickUpdate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B8A RID: 31626
		// (get) Token: 0x0601F1F8 RID: 127480 RVA: 0x002E3F51 File Offset: 0x002E2151
		// (set) Token: 0x0601F1F9 RID: 127481 RVA: 0x002E3F61 File Offset: 0x002E2161
		public unsafe bool bUseNewBatchDepthCalculator
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bUseNewBatchDepthCalculator) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bUseNewBatchDepthCalculator) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B8B RID: 31627
		// (get) Token: 0x0601F1FA RID: 127482 RVA: 0x002E3F72 File Offset: 0x002E2172
		// (set) Token: 0x0601F1FB RID: 127483 RVA: 0x002E3F82 File Offset: 0x002E2182
		public unsafe bool bPrintBatchDepthCost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPrintBatchDepthCost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUICanvas.__PropertyOffset_bPrintBatchDepthCost) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601F1FC RID: 127484 RVA: 0x002E3F93 File Offset: 0x002E2193
		public void SetUIRenderable(bool bNewRenderable)
		{
			ULGUICanvas.__SetUIRenderable_Internal(base.NativePtr, bNewRenderable);
		}

		// Token: 0x0601F1FD RID: 127485 RVA: 0x002E3FA1 File Offset: 0x002E21A1
		public void SetSubLayerOrder(int NewSubLayerOrder)
		{
			ULGUICanvas.__SetSubLayerOrder_Internal(base.NativePtr, NewSubLayerOrder);
		}

		// Token: 0x0601F1FE RID: 127486 RVA: 0x002E3FAF File Offset: 0x002E21AF
		public void SetSortOrderToHighestOfHierarchy(bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrderToHighestOfHierarchy_Internal(base.NativePtr, propagateToChildrenCanvas);
		}

		// Token: 0x0601F1FF RID: 127487 RVA: 0x002E3FBD File Offset: 0x002E21BD
		public void SetSortOrderNew(int newValue, bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrderNew_Internal(base.NativePtr, newValue, propagateToChildrenCanvas);
		}

		// Token: 0x0601F200 RID: 127488 RVA: 0x002E3FCC File Offset: 0x002E21CC
		public void SetSortOrder(int newValue, bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrder_Internal(base.NativePtr, newValue, propagateToChildrenCanvas);
		}

		// Token: 0x0601F201 RID: 127489 RVA: 0x002E3FDB File Offset: 0x002E21DB
		[NullableContext(2)]
		public void SetRenderTarget(UTextureRenderTarget2D value)
		{
			ULGUICanvas.__SetRenderTarget_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F202 RID: 127490 RVA: 0x002E3FF8 File Offset: 0x002E21F8
		public void SetRenderMode(ELGUIRenderMode value)
		{
			ULGUICanvas.__SetRenderMode_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F203 RID: 127491 RVA: 0x002E4006 File Offset: 0x002E2206
		public void SetRectClipOffset(FMargin newOffset)
		{
			ULGUICanvas.__SetRectClipOffset_Internal(base.NativePtr, newOffset);
		}

		// Token: 0x0601F204 RID: 127492 RVA: 0x002E4014 File Offset: 0x002E2214
		public void SetRectClipFeather(FMargin newFeather)
		{
			ULGUICanvas.__SetRectClipFeather_Internal(base.NativePtr, newFeather);
		}

		// Token: 0x0601F205 RID: 127493 RVA: 0x002E4022 File Offset: 0x002E2222
		public void SetProjectionParameters(ECameraProjectionMode InProjectionType, float InFovAngle, float InNearClipPlane, float InFarClipPlane)
		{
			ULGUICanvas.__SetProjectionParameters_Internal(base.NativePtr, InProjectionType, InFovAngle, InNearClipPlane, InFarClipPlane);
		}

		// Token: 0x0601F206 RID: 127494 RVA: 0x002E4039 File Offset: 0x002E2239
		public void SetPixelPerfect(bool value)
		{
			ULGUICanvas.__SetPixelPerfect_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F207 RID: 127495 RVA: 0x002E4047 File Offset: 0x002E2247
		public void SetOwnerNoSee(bool value)
		{
			ULGUICanvas.__SetOwnerNoSee_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F208 RID: 127496 RVA: 0x002E4055 File Offset: 0x002E2255
		public void SetOnlyOwnerSee(bool value)
		{
			ULGUICanvas.__SetOnlyOwnerSee_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F209 RID: 127497 RVA: 0x002E4063 File Offset: 0x002E2263
		public void SetInheriRectClip(bool newBool)
		{
			ULGUICanvas.__SetInheriRectClip_Internal(base.NativePtr, newBool);
		}

		// Token: 0x0601F20A RID: 127498 RVA: 0x002E4071 File Offset: 0x002E2271
		public void SetDynamicPixelsPerUnit(float newValue)
		{
			ULGUICanvas.__SetDynamicPixelsPerUnit_Internal(base.NativePtr, newValue);
		}

		// Token: 0x0601F20B RID: 127499 RVA: 0x002E407F File Offset: 0x002E227F
		public void SetClipType(ELGUICanvasClipType newClipType)
		{
			ULGUICanvas.__SetClipType_Internal(base.NativePtr, newClipType);
		}

		// Token: 0x0601F20C RID: 127500 RVA: 0x002E408D File Offset: 0x002E228D
		public void SetClipTextureAlpha(float newAlpha)
		{
			ULGUICanvas.__SetClipTextureAlpha_Internal(base.NativePtr, newAlpha);
		}

		// Token: 0x0601F20D RID: 127501 RVA: 0x002E409B File Offset: 0x002E229B
		[NullableContext(2)]
		public void SetClipTexture(UTexture newTexture)
		{
			ULGUICanvas.__SetClipTexture_Internal(base.NativePtr, (newTexture != null) ? newTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F20E RID: 127502 RVA: 0x002E40B8 File Offset: 0x002E22B8
		[NullableContext(2)]
		public bool IsUIVisible(UUIItem HitUI)
		{
			return ULGUICanvas.__IsUIVisible_Internal(base.NativePtr, (HitUI != null) ? HitUI.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F20F RID: 127503 RVA: 0x002E40D5 File Offset: 0x002E22D5
		public bool IsUIRenderable()
		{
			return ULGUICanvas.__IsUIRenderable_Internal(base.NativePtr);
		}

		// Token: 0x0601F210 RID: 127504 RVA: 0x002E40E2 File Offset: 0x002E22E2
		public bool IsPostTickUpdate()
		{
			return ULGUICanvas.__IsPostTickUpdate_Internal(base.NativePtr);
		}

		// Token: 0x0601F211 RID: 127505 RVA: 0x002E40EF File Offset: 0x002E22EF
		public FIntPoint GetViewportSize()
		{
			return ULGUICanvas.__GetViewportSize_Internal(base.NativePtr);
		}

		// Token: 0x0601F212 RID: 127506 RVA: 0x002E40FC File Offset: 0x002E22FC
		public int GetSubLayerOrder()
		{
			return ULGUICanvas.__GetSubLayerOrder_Internal(base.NativePtr);
		}

		// Token: 0x0601F213 RID: 127507 RVA: 0x002E4109 File Offset: 0x002E2309
		[NullableContext(2)]
		public ULGUICanvas GetRootCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(ULGUICanvas.__GetRootCanvas_Internal(base.NativePtr));
		}

		// Token: 0x0601F214 RID: 127508 RVA: 0x002E411B File Offset: 0x002E231B
		public bool GetRequireUV6()
		{
			return ULGUICanvas.__GetRequireUV6_Internal(base.NativePtr);
		}

		// Token: 0x0601F215 RID: 127509 RVA: 0x002E4128 File Offset: 0x002E2328
		public bool GetRequireUV5()
		{
			return ULGUICanvas.__GetRequireUV5_Internal(base.NativePtr);
		}

		// Token: 0x0601F216 RID: 127510 RVA: 0x002E4135 File Offset: 0x002E2335
		public bool GetRequireUV4()
		{
			return ULGUICanvas.__GetRequireUV4_Internal(base.NativePtr);
		}

		// Token: 0x0601F217 RID: 127511 RVA: 0x002E4142 File Offset: 0x002E2342
		public bool GetRequireUV3()
		{
			return ULGUICanvas.__GetRequireUV3_Internal(base.NativePtr);
		}

		// Token: 0x0601F218 RID: 127512 RVA: 0x002E414F File Offset: 0x002E234F
		public bool GetRequireUV2()
		{
			return ULGUICanvas.__GetRequireUV2_Internal(base.NativePtr);
		}

		// Token: 0x0601F219 RID: 127513 RVA: 0x002E415C File Offset: 0x002E235C
		public bool GetRequireUV1()
		{
			return ULGUICanvas.__GetRequireUV1_Internal(base.NativePtr);
		}

		// Token: 0x0601F21A RID: 127514 RVA: 0x002E4169 File Offset: 0x002E2369
		public bool GetRequireTangent()
		{
			return ULGUICanvas.__GetRequireTangent_Internal(base.NativePtr);
		}

		// Token: 0x0601F21B RID: 127515 RVA: 0x002E4176 File Offset: 0x002E2376
		public bool GetRequireNormal()
		{
			return ULGUICanvas.__GetRequireNormal_Internal(base.NativePtr);
		}

		// Token: 0x0601F21C RID: 127516 RVA: 0x002E4183 File Offset: 0x002E2383
		[NullableContext(2)]
		public UTextureRenderTarget2D GetRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ULGUICanvas.__GetRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x0601F21D RID: 127517 RVA: 0x002E4195 File Offset: 0x002E2395
		public ELGUIRenderMode GetRenderMode()
		{
			return ULGUICanvas.__GetRenderMode_Internal(base.NativePtr);
		}

		// Token: 0x0601F21E RID: 127518 RVA: 0x002E41A2 File Offset: 0x002E23A2
		public bool GetPixelPerfect()
		{
			return ULGUICanvas.__GetPixelPerfect_Internal(base.NativePtr);
		}

		// Token: 0x0601F21F RID: 127519 RVA: 0x002E41AF File Offset: 0x002E23AF
		public bool GetOwnerNoSee()
		{
			return ULGUICanvas.__GetOwnerNoSee_Internal(base.NativePtr);
		}

		// Token: 0x0601F220 RID: 127520 RVA: 0x002E41BC File Offset: 0x002E23BC
		public bool GetOnlyOwnerSee()
		{
			return ULGUICanvas.__GetOnlyOwnerSee_Internal(base.NativePtr);
		}

		// Token: 0x0601F221 RID: 127521 RVA: 0x002E41C9 File Offset: 0x002E23C9
		public bool GetInheritRectClip()
		{
			return ULGUICanvas.__GetInheritRectClip_Internal(base.NativePtr);
		}

		// Token: 0x0601F222 RID: 127522 RVA: 0x002E41D6 File Offset: 0x002E23D6
		public bool GetEnableSliceBorder()
		{
			return ULGUICanvas.__GetEnableSliceBorder_Internal(base.NativePtr);
		}

		// Token: 0x0601F223 RID: 127523 RVA: 0x002E41E3 File Offset: 0x002E23E3
		public float GetDynamicPixelsPerUnit()
		{
			return ULGUICanvas.__GetDynamicPixelsPerUnit_Internal(base.NativePtr);
		}

		// Token: 0x0601F224 RID: 127524 RVA: 0x002E41F0 File Offset: 0x002E23F0
		public ELGUICanvasClipType GetClipType()
		{
			return ULGUICanvas.__GetClipType_Internal(base.NativePtr);
		}

		// Token: 0x0601F225 RID: 127525 RVA: 0x002E41FD File Offset: 0x002E23FD
		public float GetClipTextureAlpha()
		{
			return ULGUICanvas.__GetClipTextureAlpha_Internal(base.NativePtr);
		}

		// Token: 0x0601F226 RID: 127526 RVA: 0x002E420A File Offset: 0x002E240A
		[NullableContext(2)]
		public UTexture GetClipTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(ULGUICanvas.__GetClipTexture_Internal(base.NativePtr));
		}

		// Token: 0x0601F227 RID: 127527 RVA: 0x002E421C File Offset: 0x002E241C
		public FVector2D GetClipRectMin()
		{
			return ULGUICanvas.__GetClipRectMin_Internal(base.NativePtr);
		}

		// Token: 0x0601F228 RID: 127528 RVA: 0x002E4229 File Offset: 0x002E2429
		public FVector2D GetClipRectMax()
		{
			return ULGUICanvas.__GetClipRectMax_Internal(base.NativePtr);
		}

		// Token: 0x0601F229 RID: 127529 RVA: 0x002E4236 File Offset: 0x002E2436
		public FVector2D GetClipFeatherRectMin()
		{
			return ULGUICanvas.__GetClipFeatherRectMin_Internal(base.NativePtr);
		}

		// Token: 0x0601F22A RID: 127530 RVA: 0x002E4243 File Offset: 0x002E2443
		public FVector2D GetClipFeatherRectMax()
		{
			return ULGUICanvas.__GetClipFeatherRectMax_Internal(base.NativePtr);
		}

		// Token: 0x0601F22B RID: 127531 RVA: 0x002E4250 File Offset: 0x002E2450
		public FMargin GetClipFeather()
		{
			return ULGUICanvas.__GetClipFeather_Internal(base.NativePtr);
		}

		// Token: 0x0601F22C RID: 127532 RVA: 0x002E425D File Offset: 0x002E245D
		public float GetCanvasScale()
		{
			return ULGUICanvas.__GetCanvasScale_Internal(base.NativePtr);
		}

		// Token: 0x0601F22D RID: 127533 RVA: 0x002E426A File Offset: 0x002E246A
		[NullableContext(2)]
		public UTextureRenderTarget2D GetActualRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ULGUICanvas.__GetActualRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x0601F22E RID: 127534 RVA: 0x002E427C File Offset: 0x002E247C
		public ELGUIRenderMode GetActualRenderMode()
		{
			return ULGUICanvas.__GetActualRenderMode_Internal(base.NativePtr);
		}

		// Token: 0x0601F22F RID: 127535 RVA: 0x002E4289 File Offset: 0x002E2489
		public bool GetActualPixelPerfect()
		{
			return ULGUICanvas.__GetActualPixelPerfect_Internal(base.NativePtr);
		}

		// Token: 0x0601F230 RID: 127536 RVA: 0x002E4296 File Offset: 0x002E2496
		public bool GetActualOwnerNoSee()
		{
			return ULGUICanvas.__GetActualOwnerNoSee_Internal(base.NativePtr);
		}

		// Token: 0x0601F231 RID: 127537 RVA: 0x002E42A3 File Offset: 0x002E24A3
		public bool GetActualOnlyOwnerSee()
		{
			return ULGUICanvas.__GetActualOnlyOwnerSee_Internal(base.NativePtr);
		}

		// Token: 0x0601F232 RID: 127538 RVA: 0x002E42B0 File Offset: 0x002E24B0
		public float GetActualDynamicPixelsPerUnit()
		{
			return ULGUICanvas.__GetActualDynamicPixelsPerUnit_Internal(base.NativePtr);
		}

		// Token: 0x0601F233 RID: 127539 RVA: 0x002E42BD File Offset: 0x002E24BD
		public ELGUICanvasClipType GetActualClipType()
		{
			return ULGUICanvas.__GetActualClipType_Internal(base.NativePtr);
		}

		// Token: 0x0601F234 RID: 127540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderable_Internal(IntPtr @this, bool bNewRenderable);

		// Token: 0x0601F235 RID: 127541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubLayerOrder_Internal(IntPtr @this, int NewSubLayerOrder);

		// Token: 0x0601F236 RID: 127542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrderToHighestOfHierarchy_Internal(IntPtr @this, bool propagateToChildrenCanvas);

		// Token: 0x0601F237 RID: 127543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrderNew_Internal(IntPtr @this, int newValue, bool propagateToChildrenCanvas);

		// Token: 0x0601F238 RID: 127544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrder_Internal(IntPtr @this, int newValue, bool propagateToChildrenCanvas);

		// Token: 0x0601F239 RID: 127545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTarget_Internal(IntPtr @this, IntPtr value);

		// Token: 0x0601F23A RID: 127546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderMode_Internal(IntPtr @this, ELGUIRenderMode value);

		// Token: 0x0601F23B RID: 127547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRectClipOffset_Internal(IntPtr @this, FMargin newOffset);

		// Token: 0x0601F23C RID: 127548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRectClipFeather_Internal(IntPtr @this, FMargin newFeather);

		// Token: 0x0601F23D RID: 127549
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionParameters_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> InProjectionType, float InFovAngle, float InNearClipPlane, float InFarClipPlane);

		// Token: 0x0601F23E RID: 127550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPixelPerfect_Internal(IntPtr @this, bool value);

		// Token: 0x0601F23F RID: 127551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerNoSee_Internal(IntPtr @this, bool value);

		// Token: 0x0601F240 RID: 127552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyOwnerSee_Internal(IntPtr @this, bool value);

		// Token: 0x0601F241 RID: 127553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInheriRectClip_Internal(IntPtr @this, bool newBool);

		// Token: 0x0601F242 RID: 127554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicPixelsPerUnit_Internal(IntPtr @this, float newValue);

		// Token: 0x0601F243 RID: 127555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipType_Internal(IntPtr @this, ELGUICanvasClipType newClipType);

		// Token: 0x0601F244 RID: 127556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTextureAlpha_Internal(IntPtr @this, float newAlpha);

		// Token: 0x0601F245 RID: 127557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTexture_Internal(IntPtr @this, IntPtr newTexture);

		// Token: 0x0601F246 RID: 127558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIVisible_Internal(IntPtr @this, IntPtr HitUI);

		// Token: 0x0601F247 RID: 127559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIRenderable_Internal(IntPtr @this);

		// Token: 0x0601F248 RID: 127560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPostTickUpdate_Internal(IntPtr @this);

		// Token: 0x0601F249 RID: 127561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetViewportSize_Internal(IntPtr @this);

		// Token: 0x0601F24A RID: 127562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSubLayerOrder_Internal(IntPtr @this);

		// Token: 0x0601F24B RID: 127563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootCanvas_Internal(IntPtr @this);

		// Token: 0x0601F24C RID: 127564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV6_Internal(IntPtr @this);

		// Token: 0x0601F24D RID: 127565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV5_Internal(IntPtr @this);

		// Token: 0x0601F24E RID: 127566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV4_Internal(IntPtr @this);

		// Token: 0x0601F24F RID: 127567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV3_Internal(IntPtr @this);

		// Token: 0x0601F250 RID: 127568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV2_Internal(IntPtr @this);

		// Token: 0x0601F251 RID: 127569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV1_Internal(IntPtr @this);

		// Token: 0x0601F252 RID: 127570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireTangent_Internal(IntPtr @this);

		// Token: 0x0601F253 RID: 127571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireNormal_Internal(IntPtr @this);

		// Token: 0x0601F254 RID: 127572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderTarget_Internal(IntPtr @this);

		// Token: 0x0601F255 RID: 127573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUIRenderMode __GetRenderMode_Internal(IntPtr @this);

		// Token: 0x0601F256 RID: 127574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPixelPerfect_Internal(IntPtr @this);

		// Token: 0x0601F257 RID: 127575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOwnerNoSee_Internal(IntPtr @this);

		// Token: 0x0601F258 RID: 127576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOnlyOwnerSee_Internal(IntPtr @this);

		// Token: 0x0601F259 RID: 127577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInheritRectClip_Internal(IntPtr @this);

		// Token: 0x0601F25A RID: 127578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableSliceBorder_Internal(IntPtr @this);

		// Token: 0x0601F25B RID: 127579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDynamicPixelsPerUnit_Internal(IntPtr @this);

		// Token: 0x0601F25C RID: 127580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUICanvasClipType __GetClipType_Internal(IntPtr @this);

		// Token: 0x0601F25D RID: 127581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClipTextureAlpha_Internal(IntPtr @this);

		// Token: 0x0601F25E RID: 127582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClipTexture_Internal(IntPtr @this);

		// Token: 0x0601F25F RID: 127583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipRectMin_Internal(IntPtr @this);

		// Token: 0x0601F260 RID: 127584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipRectMax_Internal(IntPtr @this);

		// Token: 0x0601F261 RID: 127585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipFeatherRectMin_Internal(IntPtr @this);

		// Token: 0x0601F262 RID: 127586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipFeatherRectMax_Internal(IntPtr @this);

		// Token: 0x0601F263 RID: 127587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetClipFeather_Internal(IntPtr @this);

		// Token: 0x0601F264 RID: 127588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCanvasScale_Internal(IntPtr @this);

		// Token: 0x0601F265 RID: 127589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActualRenderTarget_Internal(IntPtr @this);

		// Token: 0x0601F266 RID: 127590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUIRenderMode __GetActualRenderMode_Internal(IntPtr @this);

		// Token: 0x0601F267 RID: 127591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualPixelPerfect_Internal(IntPtr @this);

		// Token: 0x0601F268 RID: 127592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualOwnerNoSee_Internal(IntPtr @this);

		// Token: 0x0601F269 RID: 127593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualOnlyOwnerSee_Internal(IntPtr @this);

		// Token: 0x0601F26A RID: 127594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActualDynamicPixelsPerUnit_Internal(IntPtr @this);

		// Token: 0x0601F26B RID: 127595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUICanvasClipType __GetActualClipType_Internal(IntPtr @this);

		// Token: 0x0601F26C RID: 127596 RVA: 0x002E42CA File Offset: 0x002E24CA
		static ULGUICanvas()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICanvas");
		}

		// Token: 0x0601F26D RID: 127597 RVA: 0x002E42D8 File Offset: 0x002E24D8
		protected ULGUICanvas(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010DB4 RID: 69044
		public new const string __ObjectPath = "/Script/LGUI.LGUICanvas";

		// Token: 0x04010DB5 RID: 69045
		private static IntPtr _ClassPtr;

		// Token: 0x04010DB6 RID: 69046
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010DB7 RID: 69047
		internal static int __PropertyOffset_RootCanvasActor;

		// Token: 0x04010DB8 RID: 69048
		internal static int __PropertyOffset_renderMode;

		// Token: 0x04010DB9 RID: 69049
		internal static int __PropertyOffset_renderTarget;

		// Token: 0x04010DBA RID: 69050
		internal static int __PropertyOffset_pixelPerfect;

		// Token: 0x04010DBB RID: 69051
		internal static int __PropertyOffset_CanvasDepth;

		// Token: 0x04010DBC RID: 69052
		internal static int __PropertyOffset_sortOrder;

		// Token: 0x04010DBD RID: 69053
		internal static int __PropertyOffset_AdditionalSortOrder;

		// Token: 0x04010DBE RID: 69054
		internal static int __PropertyOffset_bOverrideSortOrder;

		// Token: 0x04010DBF RID: 69055
		internal static int __PropertyOffset_bIsMainLayer;

		// Token: 0x04010DC0 RID: 69056
		internal static int __PropertyOffset_SubLayerOrder;

		// Token: 0x04010DC1 RID: 69057
		internal static int __PropertyOffset_clipType;

		// Token: 0x04010DC2 RID: 69058
		internal static int __PropertyOffset_clipFeather;

		// Token: 0x04010DC3 RID: 69059
		internal static int __PropertyOffset_clipFeatherNew;

		// Token: 0x04010DC4 RID: 69060
		internal static int __PropertyOffset_clipRectOffset;

		// Token: 0x04010DC5 RID: 69061
		internal static int __PropertyOffset_clipTexture;

		// Token: 0x04010DC6 RID: 69062
		internal static int __PropertyOffset_bEnableSliceBorder;

		// Token: 0x04010DC7 RID: 69063
		internal static int __PropertyOffset_SliceBorder;

		// Token: 0x04010DC8 RID: 69064
		internal static int __PropertyOffset_clipTextureAlpha;

		// Token: 0x04010DC9 RID: 69065
		internal static int __PropertyOffset_inheritRectClip;

		// Token: 0x04010DCA RID: 69066
		internal static int __PropertyOffset_inheritRectClipFull;

		// Token: 0x04010DCB RID: 69067
		internal static int __PropertyOffset_bScreenSpaceRectClip;

		// Token: 0x04010DCC RID: 69068
		internal static int __PropertyOffset_bFlipClipArea;

		// Token: 0x04010DCD RID: 69069
		internal static int __PropertyOffset_bClipWithRectOp;

		// Token: 0x04010DCE RID: 69070
		internal static int __PropertyOffset_bPointVisibleWithFeather;

		// Token: 0x04010DCF RID: 69071
		internal static int __PropertyOffset_bForceTopmostText;

		// Token: 0x04010DD0 RID: 69072
		internal static int __PropertyOffset_dynamicPixelsPerUnit;

		// Token: 0x04010DD1 RID: 69073
		internal static int __PropertyOffset_additionalShaderChannels;

		// Token: 0x04010DD2 RID: 69074
		internal static int __PropertyOffset_DefaultMaterials;

		// Token: 0x04010DD3 RID: 69075
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UMaterialInterface> _DefaultMaterials;

		// Token: 0x04010DD4 RID: 69076
		internal static int __PropertyOffset_ownerNoSee;

		// Token: 0x04010DD5 RID: 69077
		internal static int __PropertyOffset_onlyOwnerSee;

		// Token: 0x04010DD6 RID: 69078
		internal static int __PropertyOffset_overrideParameters;

		// Token: 0x04010DD7 RID: 69079
		internal static int __PropertyOffset_bClipOutOfScreenRenderables;

		// Token: 0x04010DD8 RID: 69080
		internal static int __PropertyOffset_ProjectCenterOffset;

		// Token: 0x04010DD9 RID: 69081
		internal static int __PropertyOffset_bEnableOnlyCanvasMovedOpt;

		// Token: 0x04010DDA RID: 69082
		internal static int __PropertyOffset_bCheckSameMaterialAndSkipBatchCal;

		// Token: 0x04010DDB RID: 69083
		internal static int __PropertyOffset_bEnableCalBatchDepth;

		// Token: 0x04010DDC RID: 69084
		internal static int __PropertyOffset_RenderableSet;

		// Token: 0x04010DDD RID: 69085
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUIBaseRenderable> _RenderableSet;

		// Token: 0x04010DDE RID: 69086
		internal static int __PropertyOffset_ToRenderList;

		// Token: 0x04010DDF RID: 69087
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIBaseRenderable> _ToRenderList;

		// Token: 0x04010DE0 RID: 69088
		internal static int __PropertyOffset_PooledUIMaterialList;

		// Token: 0x04010DE1 RID: 69089
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FLGUIMaterialArrayContainer> _PooledUIMaterialList;

		// Token: 0x04010DE2 RID: 69090
		internal static int __PropertyOffset_RenderableMasks;

		// Token: 0x04010DE3 RID: 69091
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIRenderableMask> _RenderableMasks;

		// Token: 0x04010DE4 RID: 69092
		internal static int __PropertyOffset_IsUiScenePrimitive;

		// Token: 0x04010DE5 RID: 69093
		internal static byte __PropertyMask_IsUiScenePrimitive;

		// Token: 0x04010DE6 RID: 69094
		internal static int __PropertyOffset_bPostTickUpdate;

		// Token: 0x04010DE7 RID: 69095
		internal static int __PropertyOffset_bUseNewBatchDepthCalculator;

		// Token: 0x04010DE8 RID: 69096
		internal static int __PropertyOffset_bPrintBatchDepthCost;
	}
}
