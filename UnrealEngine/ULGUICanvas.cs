using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000671 RID: 1649
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.LGUICanvas")]
	[UnrealStructLayout(1984, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1984)]
	public class ULGUICanvas : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008F03 RID: 36611 RVA: 0x000D713E File Offset: 0x000D533E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUICanvas._ClassPtr;
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x000D714C File Offset: 0x000D534C
		public ULGUICanvas() : this(BuiltinUtils.AllocNativeUObject(ULGUICanvas.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008F05 RID: 36613 RVA: 0x000D7174 File Offset: 0x000D5374
		public ULGUICanvas(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ULGUICanvas.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001AE8 RID: 6888
		// (get) Token: 0x06008F06 RID: 36614 RVA: 0x000D71A7 File Offset: 0x000D53A7
		// (set) Token: 0x06008F07 RID: 36615 RVA: 0x000D71BB File Offset: 0x000D53BB
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

		// Token: 0x17001AE9 RID: 6889
		// (get) Token: 0x06008F08 RID: 36616 RVA: 0x000D71D0 File Offset: 0x000D53D0
		// (set) Token: 0x06008F09 RID: 36617 RVA: 0x000D71E4 File Offset: 0x000D53E4
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

		// Token: 0x17001AEA RID: 6890
		// (get) Token: 0x06008F0A RID: 36618 RVA: 0x000D71F9 File Offset: 0x000D53F9
		// (set) Token: 0x06008F0B RID: 36619 RVA: 0x000D7209 File Offset: 0x000D5409
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

		// Token: 0x17001AEB RID: 6891
		// (get) Token: 0x06008F0C RID: 36620 RVA: 0x000D721A File Offset: 0x000D541A
		// (set) Token: 0x06008F0D RID: 36621 RVA: 0x000D722A File Offset: 0x000D542A
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

		// Token: 0x17001AEC RID: 6892
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x000D723B File Offset: 0x000D543B
		// (set) Token: 0x06008F0F RID: 36623 RVA: 0x000D724B File Offset: 0x000D544B
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

		// Token: 0x17001AED RID: 6893
		// (get) Token: 0x06008F10 RID: 36624 RVA: 0x000D725C File Offset: 0x000D545C
		// (set) Token: 0x06008F11 RID: 36625 RVA: 0x000D726C File Offset: 0x000D546C
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

		// Token: 0x17001AEE RID: 6894
		// (get) Token: 0x06008F12 RID: 36626 RVA: 0x000D727D File Offset: 0x000D547D
		// (set) Token: 0x06008F13 RID: 36627 RVA: 0x000D728D File Offset: 0x000D548D
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

		// Token: 0x17001AEF RID: 6895
		// (get) Token: 0x06008F14 RID: 36628 RVA: 0x000D729E File Offset: 0x000D549E
		// (set) Token: 0x06008F15 RID: 36629 RVA: 0x000D72AE File Offset: 0x000D54AE
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

		// Token: 0x17001AF0 RID: 6896
		// (get) Token: 0x06008F16 RID: 36630 RVA: 0x000D72BF File Offset: 0x000D54BF
		// (set) Token: 0x06008F17 RID: 36631 RVA: 0x000D72CF File Offset: 0x000D54CF
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

		// Token: 0x17001AF1 RID: 6897
		// (get) Token: 0x06008F18 RID: 36632 RVA: 0x000D72E0 File Offset: 0x000D54E0
		// (set) Token: 0x06008F19 RID: 36633 RVA: 0x000D72F4 File Offset: 0x000D54F4
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

		// Token: 0x17001AF2 RID: 6898
		// (get) Token: 0x06008F1A RID: 36634 RVA: 0x000D7309 File Offset: 0x000D5509
		// (set) Token: 0x06008F1B RID: 36635 RVA: 0x000D731D File Offset: 0x000D551D
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

		// Token: 0x17001AF3 RID: 6899
		// (get) Token: 0x06008F1C RID: 36636 RVA: 0x000D7332 File Offset: 0x000D5532
		// (set) Token: 0x06008F1D RID: 36637 RVA: 0x000D7346 File Offset: 0x000D5546
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

		// Token: 0x17001AF4 RID: 6900
		// (get) Token: 0x06008F1E RID: 36638 RVA: 0x000D735B File Offset: 0x000D555B
		// (set) Token: 0x06008F1F RID: 36639 RVA: 0x000D736F File Offset: 0x000D556F
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

		// Token: 0x17001AF5 RID: 6901
		// (get) Token: 0x06008F20 RID: 36640 RVA: 0x000D7384 File Offset: 0x000D5584
		// (set) Token: 0x06008F21 RID: 36641 RVA: 0x000D7394 File Offset: 0x000D5594
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

		// Token: 0x17001AF6 RID: 6902
		// (get) Token: 0x06008F22 RID: 36642 RVA: 0x000D73A5 File Offset: 0x000D55A5
		// (set) Token: 0x06008F23 RID: 36643 RVA: 0x000D73B9 File Offset: 0x000D55B9
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

		// Token: 0x17001AF7 RID: 6903
		// (get) Token: 0x06008F24 RID: 36644 RVA: 0x000D73CE File Offset: 0x000D55CE
		// (set) Token: 0x06008F25 RID: 36645 RVA: 0x000D73DE File Offset: 0x000D55DE
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

		// Token: 0x17001AF8 RID: 6904
		// (get) Token: 0x06008F26 RID: 36646 RVA: 0x000D73EF File Offset: 0x000D55EF
		// (set) Token: 0x06008F27 RID: 36647 RVA: 0x000D73FF File Offset: 0x000D55FF
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

		// Token: 0x17001AF9 RID: 6905
		// (get) Token: 0x06008F28 RID: 36648 RVA: 0x000D7410 File Offset: 0x000D5610
		// (set) Token: 0x06008F29 RID: 36649 RVA: 0x000D7420 File Offset: 0x000D5620
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

		// Token: 0x17001AFA RID: 6906
		// (get) Token: 0x06008F2A RID: 36650 RVA: 0x000D7431 File Offset: 0x000D5631
		// (set) Token: 0x06008F2B RID: 36651 RVA: 0x000D7441 File Offset: 0x000D5641
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

		// Token: 0x17001AFB RID: 6907
		// (get) Token: 0x06008F2C RID: 36652 RVA: 0x000D7452 File Offset: 0x000D5652
		// (set) Token: 0x06008F2D RID: 36653 RVA: 0x000D7462 File Offset: 0x000D5662
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

		// Token: 0x17001AFC RID: 6908
		// (get) Token: 0x06008F2E RID: 36654 RVA: 0x000D7473 File Offset: 0x000D5673
		// (set) Token: 0x06008F2F RID: 36655 RVA: 0x000D7483 File Offset: 0x000D5683
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

		// Token: 0x17001AFD RID: 6909
		// (get) Token: 0x06008F30 RID: 36656 RVA: 0x000D7494 File Offset: 0x000D5694
		// (set) Token: 0x06008F31 RID: 36657 RVA: 0x000D74A4 File Offset: 0x000D56A4
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

		// Token: 0x17001AFE RID: 6910
		// (get) Token: 0x06008F32 RID: 36658 RVA: 0x000D74B5 File Offset: 0x000D56B5
		// (set) Token: 0x06008F33 RID: 36659 RVA: 0x000D74C5 File Offset: 0x000D56C5
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

		// Token: 0x17001AFF RID: 6911
		// (get) Token: 0x06008F34 RID: 36660 RVA: 0x000D74D6 File Offset: 0x000D56D6
		// (set) Token: 0x06008F35 RID: 36661 RVA: 0x000D74E6 File Offset: 0x000D56E6
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

		// Token: 0x17001B00 RID: 6912
		// (get) Token: 0x06008F36 RID: 36662 RVA: 0x000D74F7 File Offset: 0x000D56F7
		// (set) Token: 0x06008F37 RID: 36663 RVA: 0x000D7507 File Offset: 0x000D5707
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

		// Token: 0x17001B01 RID: 6913
		// (get) Token: 0x06008F38 RID: 36664 RVA: 0x000D7518 File Offset: 0x000D5718
		// (set) Token: 0x06008F39 RID: 36665 RVA: 0x000D7552 File Offset: 0x000D5752
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

		// Token: 0x17001B02 RID: 6914
		// (get) Token: 0x06008F3A RID: 36666 RVA: 0x000D7560 File Offset: 0x000D5760
		// (set) Token: 0x06008F3B RID: 36667 RVA: 0x000D7570 File Offset: 0x000D5770
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

		// Token: 0x17001B03 RID: 6915
		// (get) Token: 0x06008F3C RID: 36668 RVA: 0x000D7581 File Offset: 0x000D5781
		// (set) Token: 0x06008F3D RID: 36669 RVA: 0x000D7591 File Offset: 0x000D5791
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

		// Token: 0x17001B04 RID: 6916
		// (get) Token: 0x06008F3E RID: 36670 RVA: 0x000D75A2 File Offset: 0x000D57A2
		// (set) Token: 0x06008F3F RID: 36671 RVA: 0x000D75B2 File Offset: 0x000D57B2
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

		// Token: 0x17001B05 RID: 6917
		// (get) Token: 0x06008F40 RID: 36672 RVA: 0x000D75C3 File Offset: 0x000D57C3
		// (set) Token: 0x06008F41 RID: 36673 RVA: 0x000D75D3 File Offset: 0x000D57D3
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

		// Token: 0x17001B06 RID: 6918
		// (get) Token: 0x06008F42 RID: 36674 RVA: 0x000D75E4 File Offset: 0x000D57E4
		// (set) Token: 0x06008F43 RID: 36675 RVA: 0x000D75F8 File Offset: 0x000D57F8
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

		// Token: 0x17001B07 RID: 6919
		// (get) Token: 0x06008F44 RID: 36676 RVA: 0x000D760D File Offset: 0x000D580D
		// (set) Token: 0x06008F45 RID: 36677 RVA: 0x000D761D File Offset: 0x000D581D
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

		// Token: 0x17001B08 RID: 6920
		// (get) Token: 0x06008F46 RID: 36678 RVA: 0x000D762E File Offset: 0x000D582E
		// (set) Token: 0x06008F47 RID: 36679 RVA: 0x000D763E File Offset: 0x000D583E
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

		// Token: 0x17001B09 RID: 6921
		// (get) Token: 0x06008F48 RID: 36680 RVA: 0x000D764F File Offset: 0x000D584F
		// (set) Token: 0x06008F49 RID: 36681 RVA: 0x000D765F File Offset: 0x000D585F
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

		// Token: 0x17001B0A RID: 6922
		// (get) Token: 0x06008F4A RID: 36682 RVA: 0x000D7670 File Offset: 0x000D5870
		// (set) Token: 0x06008F4B RID: 36683 RVA: 0x000D76A9 File Offset: 0x000D58A9
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

		// Token: 0x17001B0B RID: 6923
		// (get) Token: 0x06008F4C RID: 36684 RVA: 0x000D76B8 File Offset: 0x000D58B8
		// (set) Token: 0x06008F4D RID: 36685 RVA: 0x000D76F1 File Offset: 0x000D58F1
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

		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06008F4E RID: 36686 RVA: 0x000D7700 File Offset: 0x000D5900
		// (set) Token: 0x06008F4F RID: 36687 RVA: 0x000D7739 File Offset: 0x000D5939
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

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x06008F50 RID: 36688 RVA: 0x000D7747 File Offset: 0x000D5947
		// (set) Token: 0x06008F51 RID: 36689 RVA: 0x000D7760 File Offset: 0x000D5960
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x06008F52 RID: 36690 RVA: 0x000D7790 File Offset: 0x000D5990
		// (set) Token: 0x06008F53 RID: 36691 RVA: 0x000D77A0 File Offset: 0x000D59A0
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06008F54 RID: 36692 RVA: 0x000D77B1 File Offset: 0x000D59B1
		// (set) Token: 0x06008F55 RID: 36693 RVA: 0x000D77C1 File Offset: 0x000D59C1
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06008F56 RID: 36694 RVA: 0x000D77D2 File Offset: 0x000D59D2
		// (set) Token: 0x06008F57 RID: 36695 RVA: 0x000D77E2 File Offset: 0x000D59E2
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

		// Token: 0x06008F58 RID: 36696 RVA: 0x000D77F3 File Offset: 0x000D59F3
		public void SetUIRenderable(bool bNewRenderable)
		{
			ULGUICanvas.__SetUIRenderable_Internal(base.NativePtr, bNewRenderable);
		}

		// Token: 0x06008F59 RID: 36697 RVA: 0x000D7801 File Offset: 0x000D5A01
		public void SetSubLayerOrder(int NewSubLayerOrder)
		{
			ULGUICanvas.__SetSubLayerOrder_Internal(base.NativePtr, NewSubLayerOrder);
		}

		// Token: 0x06008F5A RID: 36698 RVA: 0x000D780F File Offset: 0x000D5A0F
		public void SetSortOrderToHighestOfHierarchy(bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrderToHighestOfHierarchy_Internal(base.NativePtr, propagateToChildrenCanvas);
		}

		// Token: 0x06008F5B RID: 36699 RVA: 0x000D781D File Offset: 0x000D5A1D
		public void SetSortOrderNew(int newValue, bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrderNew_Internal(base.NativePtr, newValue, propagateToChildrenCanvas);
		}

		// Token: 0x06008F5C RID: 36700 RVA: 0x000D782C File Offset: 0x000D5A2C
		public void SetSortOrder(int newValue, bool propagateToChildrenCanvas = true)
		{
			ULGUICanvas.__SetSortOrder_Internal(base.NativePtr, newValue, propagateToChildrenCanvas);
		}

		// Token: 0x06008F5D RID: 36701 RVA: 0x000D783B File Offset: 0x000D5A3B
		[NullableContext(2)]
		public void SetRenderTarget(UTextureRenderTarget2D value)
		{
			ULGUICanvas.__SetRenderTarget_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008F5E RID: 36702 RVA: 0x000D7858 File Offset: 0x000D5A58
		public void SetRectClipOffset(FMargin newOffset)
		{
			ULGUICanvas.__SetRectClipOffset_Internal(base.NativePtr, newOffset);
		}

		// Token: 0x06008F5F RID: 36703 RVA: 0x000D7866 File Offset: 0x000D5A66
		public void SetRectClipFeather(FMargin newFeather)
		{
			ULGUICanvas.__SetRectClipFeather_Internal(base.NativePtr, newFeather);
		}

		// Token: 0x06008F60 RID: 36704 RVA: 0x000D7874 File Offset: 0x000D5A74
		public void SetProjectionParameters(ECameraProjectionMode InProjectionType, float InFovAngle, float InNearClipPlane, float InFarClipPlane)
		{
			ULGUICanvas.__SetProjectionParameters_Internal(base.NativePtr, InProjectionType, InFovAngle, InNearClipPlane, InFarClipPlane);
		}

		// Token: 0x06008F61 RID: 36705 RVA: 0x000D788B File Offset: 0x000D5A8B
		public void SetPixelPerfect(bool value)
		{
			ULGUICanvas.__SetPixelPerfect_Internal(base.NativePtr, value);
		}

		// Token: 0x06008F62 RID: 36706 RVA: 0x000D7899 File Offset: 0x000D5A99
		public void SetOwnerNoSee(bool value)
		{
			ULGUICanvas.__SetOwnerNoSee_Internal(base.NativePtr, value);
		}

		// Token: 0x06008F63 RID: 36707 RVA: 0x000D78A7 File Offset: 0x000D5AA7
		public void SetOnlyOwnerSee(bool value)
		{
			ULGUICanvas.__SetOnlyOwnerSee_Internal(base.NativePtr, value);
		}

		// Token: 0x06008F64 RID: 36708 RVA: 0x000D78B5 File Offset: 0x000D5AB5
		public void SetInheriRectClip(bool newBool)
		{
			ULGUICanvas.__SetInheriRectClip_Internal(base.NativePtr, newBool);
		}

		// Token: 0x06008F65 RID: 36709 RVA: 0x000D78C3 File Offset: 0x000D5AC3
		public void SetDynamicPixelsPerUnit(float newValue)
		{
			ULGUICanvas.__SetDynamicPixelsPerUnit_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x000D78D1 File Offset: 0x000D5AD1
		public void SetClipTextureAlpha(float newAlpha)
		{
			ULGUICanvas.__SetClipTextureAlpha_Internal(base.NativePtr, newAlpha);
		}

		// Token: 0x06008F67 RID: 36711 RVA: 0x000D78DF File Offset: 0x000D5ADF
		[NullableContext(2)]
		public void SetClipTexture(UTexture newTexture)
		{
			ULGUICanvas.__SetClipTexture_Internal(base.NativePtr, (newTexture != null) ? newTexture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008F68 RID: 36712 RVA: 0x000D78FC File Offset: 0x000D5AFC
		[NullableContext(2)]
		public bool IsUIVisible(UUIItem HitUI)
		{
			return ULGUICanvas.__IsUIVisible_Internal(base.NativePtr, (HitUI != null) ? HitUI.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008F69 RID: 36713 RVA: 0x000D7919 File Offset: 0x000D5B19
		public bool IsUIRenderable()
		{
			return ULGUICanvas.__IsUIRenderable_Internal(base.NativePtr);
		}

		// Token: 0x06008F6A RID: 36714 RVA: 0x000D7926 File Offset: 0x000D5B26
		public bool IsPostTickUpdate()
		{
			return ULGUICanvas.__IsPostTickUpdate_Internal(base.NativePtr);
		}

		// Token: 0x06008F6B RID: 36715 RVA: 0x000D7933 File Offset: 0x000D5B33
		public FIntPoint GetViewportSize()
		{
			return ULGUICanvas.__GetViewportSize_Internal(base.NativePtr);
		}

		// Token: 0x06008F6C RID: 36716 RVA: 0x000D7940 File Offset: 0x000D5B40
		public int GetSubLayerOrder()
		{
			return ULGUICanvas.__GetSubLayerOrder_Internal(base.NativePtr);
		}

		// Token: 0x06008F6D RID: 36717 RVA: 0x000D794D File Offset: 0x000D5B4D
		[NullableContext(2)]
		public ULGUICanvas GetRootCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(ULGUICanvas.__GetRootCanvas_Internal(base.NativePtr));
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x000D795F File Offset: 0x000D5B5F
		public bool GetRequireUV6()
		{
			return ULGUICanvas.__GetRequireUV6_Internal(base.NativePtr);
		}

		// Token: 0x06008F6F RID: 36719 RVA: 0x000D796C File Offset: 0x000D5B6C
		public bool GetRequireUV5()
		{
			return ULGUICanvas.__GetRequireUV5_Internal(base.NativePtr);
		}

		// Token: 0x06008F70 RID: 36720 RVA: 0x000D7979 File Offset: 0x000D5B79
		public bool GetRequireUV4()
		{
			return ULGUICanvas.__GetRequireUV4_Internal(base.NativePtr);
		}

		// Token: 0x06008F71 RID: 36721 RVA: 0x000D7986 File Offset: 0x000D5B86
		public bool GetRequireUV3()
		{
			return ULGUICanvas.__GetRequireUV3_Internal(base.NativePtr);
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x000D7993 File Offset: 0x000D5B93
		public bool GetRequireUV2()
		{
			return ULGUICanvas.__GetRequireUV2_Internal(base.NativePtr);
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x000D79A0 File Offset: 0x000D5BA0
		public bool GetRequireUV1()
		{
			return ULGUICanvas.__GetRequireUV1_Internal(base.NativePtr);
		}

		// Token: 0x06008F74 RID: 36724 RVA: 0x000D79AD File Offset: 0x000D5BAD
		public bool GetRequireTangent()
		{
			return ULGUICanvas.__GetRequireTangent_Internal(base.NativePtr);
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x000D79BA File Offset: 0x000D5BBA
		public bool GetRequireNormal()
		{
			return ULGUICanvas.__GetRequireNormal_Internal(base.NativePtr);
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x000D79C7 File Offset: 0x000D5BC7
		[NullableContext(2)]
		public UTextureRenderTarget2D GetRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ULGUICanvas.__GetRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x06008F77 RID: 36727 RVA: 0x000D79D9 File Offset: 0x000D5BD9
		public bool GetPixelPerfect()
		{
			return ULGUICanvas.__GetPixelPerfect_Internal(base.NativePtr);
		}

		// Token: 0x06008F78 RID: 36728 RVA: 0x000D79E6 File Offset: 0x000D5BE6
		public bool GetOwnerNoSee()
		{
			return ULGUICanvas.__GetOwnerNoSee_Internal(base.NativePtr);
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x000D79F3 File Offset: 0x000D5BF3
		public bool GetOnlyOwnerSee()
		{
			return ULGUICanvas.__GetOnlyOwnerSee_Internal(base.NativePtr);
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x000D7A00 File Offset: 0x000D5C00
		public bool GetInheritRectClip()
		{
			return ULGUICanvas.__GetInheritRectClip_Internal(base.NativePtr);
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x000D7A0D File Offset: 0x000D5C0D
		public bool GetEnableSliceBorder()
		{
			return ULGUICanvas.__GetEnableSliceBorder_Internal(base.NativePtr);
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x000D7A1A File Offset: 0x000D5C1A
		public float GetDynamicPixelsPerUnit()
		{
			return ULGUICanvas.__GetDynamicPixelsPerUnit_Internal(base.NativePtr);
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x000D7A27 File Offset: 0x000D5C27
		public float GetClipTextureAlpha()
		{
			return ULGUICanvas.__GetClipTextureAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x000D7A34 File Offset: 0x000D5C34
		[NullableContext(2)]
		public UTexture GetClipTexture()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture>(ULGUICanvas.__GetClipTexture_Internal(base.NativePtr));
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x000D7A46 File Offset: 0x000D5C46
		public FVector2D GetClipRectMin()
		{
			return ULGUICanvas.__GetClipRectMin_Internal(base.NativePtr);
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x000D7A53 File Offset: 0x000D5C53
		public FVector2D GetClipRectMax()
		{
			return ULGUICanvas.__GetClipRectMax_Internal(base.NativePtr);
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x000D7A60 File Offset: 0x000D5C60
		public FVector2D GetClipFeatherRectMin()
		{
			return ULGUICanvas.__GetClipFeatherRectMin_Internal(base.NativePtr);
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x000D7A6D File Offset: 0x000D5C6D
		public FVector2D GetClipFeatherRectMax()
		{
			return ULGUICanvas.__GetClipFeatherRectMax_Internal(base.NativePtr);
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x000D7A7A File Offset: 0x000D5C7A
		public FMargin GetClipFeather()
		{
			return ULGUICanvas.__GetClipFeather_Internal(base.NativePtr);
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x000D7A87 File Offset: 0x000D5C87
		public float GetCanvasScale()
		{
			return ULGUICanvas.__GetCanvasScale_Internal(base.NativePtr);
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x000D7A94 File Offset: 0x000D5C94
		[NullableContext(2)]
		public UTextureRenderTarget2D GetActualRenderTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTextureRenderTarget2D>(ULGUICanvas.__GetActualRenderTarget_Internal(base.NativePtr));
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x000D7AA6 File Offset: 0x000D5CA6
		public bool GetActualPixelPerfect()
		{
			return ULGUICanvas.__GetActualPixelPerfect_Internal(base.NativePtr);
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x000D7AB3 File Offset: 0x000D5CB3
		public bool GetActualOwnerNoSee()
		{
			return ULGUICanvas.__GetActualOwnerNoSee_Internal(base.NativePtr);
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x000D7AC0 File Offset: 0x000D5CC0
		public bool GetActualOnlyOwnerSee()
		{
			return ULGUICanvas.__GetActualOnlyOwnerSee_Internal(base.NativePtr);
		}

		// Token: 0x06008F89 RID: 36745 RVA: 0x000D7ACD File Offset: 0x000D5CCD
		public float GetActualDynamicPixelsPerUnit()
		{
			return ULGUICanvas.__GetActualDynamicPixelsPerUnit_Internal(base.NativePtr);
		}

		// Token: 0x06008F8A RID: 36746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderable_Internal(IntPtr @this, bool bNewRenderable);

		// Token: 0x06008F8B RID: 36747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSubLayerOrder_Internal(IntPtr @this, int NewSubLayerOrder);

		// Token: 0x06008F8C RID: 36748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrderToHighestOfHierarchy_Internal(IntPtr @this, bool propagateToChildrenCanvas);

		// Token: 0x06008F8D RID: 36749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrderNew_Internal(IntPtr @this, int newValue, bool propagateToChildrenCanvas);

		// Token: 0x06008F8E RID: 36750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSortOrder_Internal(IntPtr @this, int newValue, bool propagateToChildrenCanvas);

		// Token: 0x06008F8F RID: 36751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTarget_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06008F90 RID: 36752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRectClipOffset_Internal(IntPtr @this, FMargin newOffset);

		// Token: 0x06008F91 RID: 36753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRectClipFeather_Internal(IntPtr @this, FMargin newFeather);

		// Token: 0x06008F92 RID: 36754
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetProjectionParameters_Internal(IntPtr @this, TEnumAsByte<ECameraProjectionMode> InProjectionType, float InFovAngle, float InNearClipPlane, float InFarClipPlane);

		// Token: 0x06008F93 RID: 36755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPixelPerfect_Internal(IntPtr @this, bool value);

		// Token: 0x06008F94 RID: 36756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwnerNoSee_Internal(IntPtr @this, bool value);

		// Token: 0x06008F95 RID: 36757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnlyOwnerSee_Internal(IntPtr @this, bool value);

		// Token: 0x06008F96 RID: 36758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInheriRectClip_Internal(IntPtr @this, bool newBool);

		// Token: 0x06008F97 RID: 36759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDynamicPixelsPerUnit_Internal(IntPtr @this, float newValue);

		// Token: 0x06008F98 RID: 36760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTextureAlpha_Internal(IntPtr @this, float newAlpha);

		// Token: 0x06008F99 RID: 36761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipTexture_Internal(IntPtr @this, IntPtr newTexture);

		// Token: 0x06008F9A RID: 36762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIVisible_Internal(IntPtr @this, IntPtr HitUI);

		// Token: 0x06008F9B RID: 36763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIRenderable_Internal(IntPtr @this);

		// Token: 0x06008F9C RID: 36764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPostTickUpdate_Internal(IntPtr @this);

		// Token: 0x06008F9D RID: 36765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetViewportSize_Internal(IntPtr @this);

		// Token: 0x06008F9E RID: 36766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSubLayerOrder_Internal(IntPtr @this);

		// Token: 0x06008F9F RID: 36767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootCanvas_Internal(IntPtr @this);

		// Token: 0x06008FA0 RID: 36768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV6_Internal(IntPtr @this);

		// Token: 0x06008FA1 RID: 36769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV5_Internal(IntPtr @this);

		// Token: 0x06008FA2 RID: 36770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV4_Internal(IntPtr @this);

		// Token: 0x06008FA3 RID: 36771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV3_Internal(IntPtr @this);

		// Token: 0x06008FA4 RID: 36772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV2_Internal(IntPtr @this);

		// Token: 0x06008FA5 RID: 36773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireUV1_Internal(IntPtr @this);

		// Token: 0x06008FA6 RID: 36774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireTangent_Internal(IntPtr @this);

		// Token: 0x06008FA7 RID: 36775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRequireNormal_Internal(IntPtr @this);

		// Token: 0x06008FA8 RID: 36776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderTarget_Internal(IntPtr @this);

		// Token: 0x06008FA9 RID: 36777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetPixelPerfect_Internal(IntPtr @this);

		// Token: 0x06008FAA RID: 36778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOwnerNoSee_Internal(IntPtr @this);

		// Token: 0x06008FAB RID: 36779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOnlyOwnerSee_Internal(IntPtr @this);

		// Token: 0x06008FAC RID: 36780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInheritRectClip_Internal(IntPtr @this);

		// Token: 0x06008FAD RID: 36781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnableSliceBorder_Internal(IntPtr @this);

		// Token: 0x06008FAE RID: 36782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetDynamicPixelsPerUnit_Internal(IntPtr @this);

		// Token: 0x06008FAF RID: 36783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetClipTextureAlpha_Internal(IntPtr @this);

		// Token: 0x06008FB0 RID: 36784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetClipTexture_Internal(IntPtr @this);

		// Token: 0x06008FB1 RID: 36785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipRectMin_Internal(IntPtr @this);

		// Token: 0x06008FB2 RID: 36786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipRectMax_Internal(IntPtr @this);

		// Token: 0x06008FB3 RID: 36787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipFeatherRectMin_Internal(IntPtr @this);

		// Token: 0x06008FB4 RID: 36788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetClipFeatherRectMax_Internal(IntPtr @this);

		// Token: 0x06008FB5 RID: 36789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetClipFeather_Internal(IntPtr @this);

		// Token: 0x06008FB6 RID: 36790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCanvasScale_Internal(IntPtr @this);

		// Token: 0x06008FB7 RID: 36791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActualRenderTarget_Internal(IntPtr @this);

		// Token: 0x06008FB8 RID: 36792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualPixelPerfect_Internal(IntPtr @this);

		// Token: 0x06008FB9 RID: 36793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualOwnerNoSee_Internal(IntPtr @this);

		// Token: 0x06008FBA RID: 36794
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetActualOnlyOwnerSee_Internal(IntPtr @this);

		// Token: 0x06008FBB RID: 36795
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetActualDynamicPixelsPerUnit_Internal(IntPtr @this);

		// Token: 0x06008FBC RID: 36796 RVA: 0x000D7ADA File Offset: 0x000D5CDA
		static ULGUICanvas()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUICanvas");
		}

		// Token: 0x06008FBD RID: 36797 RVA: 0x000D7AE8 File Offset: 0x000D5CE8
		protected ULGUICanvas(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003EB1 RID: 16049
		public new const string __ObjectPath = "/Script/LGUI.LGUICanvas";

		// Token: 0x04003EB2 RID: 16050
		private static IntPtr _ClassPtr;

		// Token: 0x04003EB3 RID: 16051
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003EB4 RID: 16052
		internal static int __PropertyOffset_RootCanvasActor;

		// Token: 0x04003EB5 RID: 16053
		internal static int __PropertyOffset_renderTarget;

		// Token: 0x04003EB6 RID: 16054
		internal static int __PropertyOffset_pixelPerfect;

		// Token: 0x04003EB7 RID: 16055
		internal static int __PropertyOffset_CanvasDepth;

		// Token: 0x04003EB8 RID: 16056
		internal static int __PropertyOffset_sortOrder;

		// Token: 0x04003EB9 RID: 16057
		internal static int __PropertyOffset_AdditionalSortOrder;

		// Token: 0x04003EBA RID: 16058
		internal static int __PropertyOffset_bOverrideSortOrder;

		// Token: 0x04003EBB RID: 16059
		internal static int __PropertyOffset_bIsMainLayer;

		// Token: 0x04003EBC RID: 16060
		internal static int __PropertyOffset_SubLayerOrder;

		// Token: 0x04003EBD RID: 16061
		internal static int __PropertyOffset_clipFeather;

		// Token: 0x04003EBE RID: 16062
		internal static int __PropertyOffset_clipFeatherNew;

		// Token: 0x04003EBF RID: 16063
		internal static int __PropertyOffset_clipRectOffset;

		// Token: 0x04003EC0 RID: 16064
		internal static int __PropertyOffset_clipTexture;

		// Token: 0x04003EC1 RID: 16065
		internal static int __PropertyOffset_bEnableSliceBorder;

		// Token: 0x04003EC2 RID: 16066
		internal static int __PropertyOffset_SliceBorder;

		// Token: 0x04003EC3 RID: 16067
		internal static int __PropertyOffset_clipTextureAlpha;

		// Token: 0x04003EC4 RID: 16068
		internal static int __PropertyOffset_inheritRectClip;

		// Token: 0x04003EC5 RID: 16069
		internal static int __PropertyOffset_inheritRectClipFull;

		// Token: 0x04003EC6 RID: 16070
		internal static int __PropertyOffset_bScreenSpaceRectClip;

		// Token: 0x04003EC7 RID: 16071
		internal static int __PropertyOffset_bFlipClipArea;

		// Token: 0x04003EC8 RID: 16072
		internal static int __PropertyOffset_bClipWithRectOp;

		// Token: 0x04003EC9 RID: 16073
		internal static int __PropertyOffset_bPointVisibleWithFeather;

		// Token: 0x04003ECA RID: 16074
		internal static int __PropertyOffset_bForceTopmostText;

		// Token: 0x04003ECB RID: 16075
		internal static int __PropertyOffset_dynamicPixelsPerUnit;

		// Token: 0x04003ECC RID: 16076
		internal static int __PropertyOffset_additionalShaderChannels;

		// Token: 0x04003ECD RID: 16077
		internal static int __PropertyOffset_DefaultMaterials;

		// Token: 0x04003ECE RID: 16078
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<UMaterialInterface> _DefaultMaterials;

		// Token: 0x04003ECF RID: 16079
		internal static int __PropertyOffset_ownerNoSee;

		// Token: 0x04003ED0 RID: 16080
		internal static int __PropertyOffset_onlyOwnerSee;

		// Token: 0x04003ED1 RID: 16081
		internal static int __PropertyOffset_overrideParameters;

		// Token: 0x04003ED2 RID: 16082
		internal static int __PropertyOffset_bClipOutOfScreenRenderables;

		// Token: 0x04003ED3 RID: 16083
		internal static int __PropertyOffset_ProjectCenterOffset;

		// Token: 0x04003ED4 RID: 16084
		internal static int __PropertyOffset_bEnableOnlyCanvasMovedOpt;

		// Token: 0x04003ED5 RID: 16085
		internal static int __PropertyOffset_bCheckSameMaterialAndSkipBatchCal;

		// Token: 0x04003ED6 RID: 16086
		internal static int __PropertyOffset_bEnableCalBatchDepth;

		// Token: 0x04003ED7 RID: 16087
		internal static int __PropertyOffset_RenderableSet;

		// Token: 0x04003ED8 RID: 16088
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UUIBaseRenderable> _RenderableSet;

		// Token: 0x04003ED9 RID: 16089
		internal static int __PropertyOffset_ToRenderList;

		// Token: 0x04003EDA RID: 16090
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIBaseRenderable> _ToRenderList;

		// Token: 0x04003EDB RID: 16091
		internal static int __PropertyOffset_RenderableMasks;

		// Token: 0x04003EDC RID: 16092
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIRenderableMask> _RenderableMasks;

		// Token: 0x04003EDD RID: 16093
		internal static int __PropertyOffset_IsUiScenePrimitive;

		// Token: 0x04003EDE RID: 16094
		internal static byte __PropertyMask_IsUiScenePrimitive;

		// Token: 0x04003EDF RID: 16095
		internal static int __PropertyOffset_bPostTickUpdate;

		// Token: 0x04003EE0 RID: 16096
		internal static int __PropertyOffset_bUseNewBatchDepthCalculator;

		// Token: 0x04003EE1 RID: 16097
		internal static int __PropertyOffset_bPrintBatchDepthCost;
	}
}
