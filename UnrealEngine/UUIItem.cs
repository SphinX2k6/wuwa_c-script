using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200070D RID: 1805
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIItem")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UUIItem : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060099FC RID: 39420 RVA: 0x000E75EA File Offset: 0x000E57EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIItem._ClassPtr;
		}

		// Token: 0x060099FD RID: 39421 RVA: 0x000E75F8 File Offset: 0x000E57F8
		public UUIItem() : this(BuiltinUtils.AllocNativeUObject(UUIItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060099FE RID: 39422 RVA: 0x000E7620 File Offset: 0x000E5820
		public UUIItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x060099FF RID: 39423 RVA: 0x000E7654 File Offset: 0x000E5854
		// (set) Token: 0x06009A00 RID: 39424 RVA: 0x000E768D File Offset: 0x000E588D
		public FUIWidget widget
		{
			get
			{
				base.FastCheckIsValid();
				FUIWidget result;
				if ((result = this._widget) == null)
				{
					result = (this._widget = new FUIWidget(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_widget, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FUIWidget.StaticStruct(), base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_widget, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06009A01 RID: 39425 RVA: 0x000E76B0 File Offset: 0x000E58B0
		// (set) Token: 0x06009A02 RID: 39426 RVA: 0x000E76E9 File Offset: 0x000E58E9
		public TArray<UUIItem> UIChildren
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UUIItem> result;
				if ((result = this._UIChildren) == null)
				{
					result = (this._UIChildren = new TArray<UUIItem>(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_UIChildren, this));
				}
				return result;
			}
			set
			{
				this.UIChildren.CopyAssign(value);
			}
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06009A03 RID: 39427 RVA: 0x000E76F7 File Offset: 0x000E58F7
		// (set) Token: 0x06009A04 RID: 39428 RVA: 0x000E7707 File Offset: 0x000E5907
		public unsafe bool inheritAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_inheritAlpha) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_inheritAlpha) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06009A05 RID: 39429 RVA: 0x000E7718 File Offset: 0x000E5918
		// (set) Token: 0x06009A06 RID: 39430 RVA: 0x000E7728 File Offset: 0x000E5928
		public unsafe bool bInheritColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bInheritColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bInheritColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06009A07 RID: 39431 RVA: 0x000E7739 File Offset: 0x000E5939
		// (set) Token: 0x06009A08 RID: 39432 RVA: 0x000E774D File Offset: 0x000E594D
		public unsafe FColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06009A09 RID: 39433 RVA: 0x000E7762 File Offset: 0x000E5962
		// (set) Token: 0x06009A0A RID: 39434 RVA: 0x000E7772 File Offset: 0x000E5972
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x06009A0B RID: 39435 RVA: 0x000E7783 File Offset: 0x000E5983
		// (set) Token: 0x06009A0C RID: 39436 RVA: 0x000E7793 File Offset: 0x000E5993
		public unsafe float Width
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Width);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Width) = value;
			}
		}

		// Token: 0x17001CA6 RID: 7334
		// (get) Token: 0x06009A0D RID: 39437 RVA: 0x000E77A4 File Offset: 0x000E59A4
		// (set) Token: 0x06009A0E RID: 39438 RVA: 0x000E77B4 File Offset: 0x000E59B4
		public unsafe float Height
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Height);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_Height) = value;
			}
		}

		// Token: 0x17001CA7 RID: 7335
		// (get) Token: 0x06009A0F RID: 39439 RVA: 0x000E77C5 File Offset: 0x000E59C5
		// (set) Token: 0x06009A10 RID: 39440 RVA: 0x000E77D5 File Offset: 0x000E59D5
		public unsafe bool useChangeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_useChangeColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_useChangeColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CA8 RID: 7336
		// (get) Token: 0x06009A11 RID: 39441 RVA: 0x000E77E6 File Offset: 0x000E59E6
		// (set) Token: 0x06009A12 RID: 39442 RVA: 0x000E77FA File Offset: 0x000E59FA
		public unsafe FColor changeColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_changeColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_changeColor) = value;
			}
		}

		// Token: 0x17001CA9 RID: 7337
		// (get) Token: 0x06009A13 RID: 39443 RVA: 0x000E7810 File Offset: 0x000E5A10
		// (set) Token: 0x06009A14 RID: 39444 RVA: 0x000E7849 File Offset: 0x000E5A49
		public TMap<string, FSequenceInfo> LevelSequences
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FSequenceInfo> result;
				if ((result = this._LevelSequences) == null)
				{
					result = (this._LevelSequences = new TMap<string, FSequenceInfo>(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_LevelSequences, this));
				}
				return result;
			}
			set
			{
				this.LevelSequences.CopyAssign(value);
			}
		}

		// Token: 0x17001CAA RID: 7338
		// (get) Token: 0x06009A15 RID: 39445 RVA: 0x000E7858 File Offset: 0x000E5A58
		// (set) Token: 0x06009A16 RID: 39446 RVA: 0x000E7891 File Offset: 0x000E5A91
		public TArray<UObject> HardRefAssets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._HardRefAssets) == null)
				{
					result = (this._HardRefAssets = new TArray<UObject>(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_HardRefAssets, this));
				}
				return result;
			}
			set
			{
				this.HardRefAssets.CopyAssign(value);
			}
		}

		// Token: 0x17001CAB RID: 7339
		// (get) Token: 0x06009A17 RID: 39447 RVA: 0x000E789F File Offset: 0x000E5A9F
		// (set) Token: 0x06009A18 RID: 39448 RVA: 0x000E78B3 File Offset: 0x000E5AB3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> RenderCanvasActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_RenderCanvasActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_RenderCanvasActor) = value;
			}
		}

		// Token: 0x17001CAC RID: 7340
		// (get) Token: 0x06009A19 RID: 39449 RVA: 0x000E78C8 File Offset: 0x000E5AC8
		// (set) Token: 0x06009A1A RID: 39450 RVA: 0x000E78D8 File Offset: 0x000E5AD8
		public unsafe bool bIsRenderAfterBlur
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderAfterBlur) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderAfterBlur) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CAD RID: 7341
		// (get) Token: 0x06009A1B RID: 39451 RVA: 0x000E78E9 File Offset: 0x000E5AE9
		// (set) Token: 0x06009A1C RID: 39452 RVA: 0x000E78F9 File Offset: 0x000E5AF9
		public unsafe bool bIsRenderBeforeBloom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderBeforeBloom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderBeforeBloom) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CAE RID: 7342
		// (get) Token: 0x06009A1D RID: 39453 RVA: 0x000E790A File Offset: 0x000E5B0A
		// (set) Token: 0x06009A1E RID: 39454 RVA: 0x000E791A File Offset: 0x000E5B1A
		public unsafe bool bIsRenderBeforeUpScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderBeforeUpScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderBeforeUpScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CAF RID: 7343
		// (get) Token: 0x06009A1F RID: 39455 RVA: 0x000E792B File Offset: 0x000E5B2B
		// (set) Token: 0x06009A20 RID: 39456 RVA: 0x000E793B File Offset: 0x000E5B3B
		public unsafe bool bIsRenderAsMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderAsMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsRenderAsMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CB0 RID: 7344
		// (get) Token: 0x06009A21 RID: 39457 RVA: 0x000E794C File Offset: 0x000E5B4C
		// (set) Token: 0x06009A22 RID: 39458 RVA: 0x000E795C File Offset: 0x000E5B5C
		public unsafe bool bIsReadMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsReadMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsReadMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CB1 RID: 7345
		// (get) Token: 0x06009A23 RID: 39459 RVA: 0x000E796D File Offset: 0x000E5B6D
		// (set) Token: 0x06009A24 RID: 39460 RVA: 0x000E797D File Offset: 0x000E5B7D
		public unsafe bool bIsUIActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsUIActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bIsUIActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CB2 RID: 7346
		// (get) Token: 0x06009A25 RID: 39461 RVA: 0x000E798E File Offset: 0x000E5B8E
		// (set) Token: 0x06009A26 RID: 39462 RVA: 0x000E799E File Offset: 0x000E5B9E
		public unsafe bool bClipOutOfViewport
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bClipOutOfViewport) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bClipOutOfViewport) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CB3 RID: 7347
		// (get) Token: 0x06009A27 RID: 39463 RVA: 0x000E79AF File Offset: 0x000E5BAF
		// (set) Token: 0x06009A28 RID: 39464 RVA: 0x000E79BF File Offset: 0x000E5BBF
		public unsafe int hierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_hierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_hierarchyIndex) = value;
			}
		}

		// Token: 0x17001CB4 RID: 7348
		// (get) Token: 0x06009A29 RID: 39465 RVA: 0x000E79D0 File Offset: 0x000E5BD0
		// (set) Token: 0x06009A2A RID: 39466 RVA: 0x000E79E0 File Offset: 0x000E5BE0
		public unsafe int flattenHierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_flattenHierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_flattenHierarchyIndex) = value;
			}
		}

		// Token: 0x17001CB5 RID: 7349
		// (get) Token: 0x06009A2B RID: 39467 RVA: 0x000E79F1 File Offset: 0x000E5BF1
		// (set) Token: 0x06009A2C RID: 39468 RVA: 0x000E7A01 File Offset: 0x000E5C01
		public unsafe int inCanvasFlattenHierarchyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_inCanvasFlattenHierarchyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_inCanvasFlattenHierarchyIndex) = value;
			}
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06009A2D RID: 39469 RVA: 0x000E7A12 File Offset: 0x000E5C12
		// (set) Token: 0x06009A2E RID: 39470 RVA: 0x000E7A22 File Offset: 0x000E5C22
		public unsafe int AdditionalIndexDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_AdditionalIndexDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_AdditionalIndexDelta) = value;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06009A2F RID: 39471 RVA: 0x000E7A33 File Offset: 0x000E5C33
		// (set) Token: 0x06009A30 RID: 39472 RVA: 0x000E7A47 File Offset: 0x000E5C47
		public unsafe string displayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUIItem.__PropertyOffset_displayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUIItem.__PropertyOffset_displayName)), value);
			}
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x06009A31 RID: 39473 RVA: 0x000E7A5C File Offset: 0x000E5C5C
		// (set) Token: 0x06009A32 RID: 39474 RVA: 0x000E7A6C File Offset: 0x000E5C6C
		public unsafe bool bRaycastTarget
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bRaycastTarget) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bRaycastTarget) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x06009A33 RID: 39475 RVA: 0x000E7A7D File Offset: 0x000E5C7D
		// (set) Token: 0x06009A34 RID: 39476 RVA: 0x000E7A8D File Offset: 0x000E5C8D
		public unsafe bool bBubbleUpToParent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bBubbleUpToParent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_bBubbleUpToParent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CBA RID: 7354
		// (get) Token: 0x06009A35 RID: 39477 RVA: 0x000E7A9E File Offset: 0x000E5C9E
		// (set) Token: 0x06009A36 RID: 39478 RVA: 0x000E7AB2 File Offset: 0x000E5CB2
		[Nullable(0)]
		public unsafe TEnumAsByte<ETraceTypeQuery> traceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_traceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_traceChannel) = value;
			}
		}

		// Token: 0x17001CBB RID: 7355
		// (get) Token: 0x06009A37 RID: 39479 RVA: 0x000E7AC7 File Offset: 0x000E5CC7
		// (set) Token: 0x06009A38 RID: 39480 RVA: 0x000E7ADB File Offset: 0x000E5CDB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> DebugCollisionLine
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_DebugCollisionLine);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_DebugCollisionLine) = value;
			}
		}

		// Token: 0x17001CBC RID: 7356
		// (get) Token: 0x06009A39 RID: 39481 RVA: 0x000E7AF0 File Offset: 0x000E5CF0
		// (set) Token: 0x06009A3A RID: 39482 RVA: 0x000E7B00 File Offset: 0x000E5D00
		public unsafe int AdditionalRenderOrder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_AdditionalRenderOrder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_AdditionalRenderOrder) = value;
			}
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x000E7B11 File Offset: 0x000E5D11
		public void SetWidth(float NewWidth)
		{
			UUIItem.__SetWidth_Internal(base.NativePtr, NewWidth);
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x000E7B1F File Offset: 0x000E5D1F
		[NullableContext(2)]
		public void SetWidget(in FUIWidget inWidget)
		{
			UUIItem.__SetWidget_Internal(base.NativePtr, (inWidget ?? new FUIWidget()).NativePtr);
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x000E7B3C File Offset: 0x000E5D3C
		public void SetVerticalStretch(FVector2D newStretch)
		{
			UUIItem.__SetVerticalStretch_Internal(base.NativePtr, newStretch);
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x000E7B4A File Offset: 0x000E5D4A
		public void SetUIWorldScale(in FVector NewScale)
		{
			UUIItem.__SetUIWorldScale_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x06009A3F RID: 39487 RVA: 0x000E7B58 File Offset: 0x000E5D58
		public void SetUIWorldRotation(in FRotator NewRotation)
		{
			UUIItem.__SetUIWorldRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x000E7B66 File Offset: 0x000E5D66
		public void SetUIWorldLocation(in FVector NewLocation)
		{
			UUIItem.__SetUIWorldLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x000E7B74 File Offset: 0x000E5D74
		public void SetUIRenderBeforeUpScale(bool bBeforeUpScale)
		{
			UUIItem.__SetUIRenderBeforeUpScale_Internal(base.NativePtr, bBeforeUpScale);
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x000E7B82 File Offset: 0x000E5D82
		public void SetUIRenderBeforeBloom(bool bBeforeBloom)
		{
			UUIItem.__SetUIRenderBeforeBloom_Internal(base.NativePtr, bBeforeBloom);
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x000E7B90 File Offset: 0x000E5D90
		public void SetUIRenderAfterBlur(bool bAfterBlur)
		{
			UUIItem.__SetUIRenderAfterBlur_Internal(base.NativePtr, bAfterBlur);
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x000E7B9E File Offset: 0x000E5D9E
		public void SetUIRelativeScale3D(in FVector NewScale3D)
		{
			UUIItem.__SetUIRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x000E7BAC File Offset: 0x000E5DAC
		public void SetUIRelativeRotation(in FRotator NewRotation)
		{
			UUIItem.__SetUIRelativeRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x000E7BBA File Offset: 0x000E5DBA
		public void SetUIRelativeLocation(FVector NewLocation)
		{
			UUIItem.__SetUIRelativeLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x000E7BC8 File Offset: 0x000E5DC8
		[NullableContext(2)]
		public void SetUIParent(UUIItem InParent, bool KeepWorldTransform = false)
		{
			UUIItem.__SetUIParent_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, KeepWorldTransform);
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x000E7BE6 File Offset: 0x000E5DE6
		public void SetUIItemScale(FVector Value)
		{
			UUIItem.__SetUIItemScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x000E7BF4 File Offset: 0x000E5DF4
		public void SetUIItemAlpha(float Value)
		{
			UUIItem.__SetUIItemAlpha_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x000E7C02 File Offset: 0x000E5E02
		public void SetUIActive(bool bActive)
		{
			UUIItem.__SetUIActive_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x000E7C10 File Offset: 0x000E5E10
		public void SetTraceChannel(ETraceTypeQuery InTraceChannel)
		{
			UUIItem.__SetTraceChannel_Internal(base.NativePtr, InTraceChannel);
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x000E7C23 File Offset: 0x000E5E23
		public void SetStretchTop(float newTop)
		{
			UUIItem.__SetStretchTop_Internal(base.NativePtr, newTop);
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x000E7C31 File Offset: 0x000E5E31
		public void SetStretchRight(float newRight)
		{
			UUIItem.__SetStretchRight_Internal(base.NativePtr, newRight);
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x000E7C3F File Offset: 0x000E5E3F
		public void SetStretchLeft(float newLeft)
		{
			UUIItem.__SetStretchLeft_Internal(base.NativePtr, newLeft);
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x000E7C4D File Offset: 0x000E5E4D
		public void SetStretchBottom(float newBottom)
		{
			UUIItem.__SetStretchBottom_Internal(base.NativePtr, newBottom);
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x000E7C5B File Offset: 0x000E5E5B
		public void SetRaycastTarget(bool NewBool)
		{
			UUIItem.__SetRaycastTarget_Internal(base.NativePtr, NewBool);
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x000E7C69 File Offset: 0x000E5E69
		public void SetPivot_Raw(FVector2D NewPivot, bool bAdjustLocation = true)
		{
			UUIItem.__SetPivot_Raw_Internal(base.NativePtr, NewPivot, bAdjustLocation);
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x000E7C78 File Offset: 0x000E5E78
		public void SetPivot(FVector2D NewPivot)
		{
			UUIItem.__SetPivot_Internal(base.NativePtr, NewPivot);
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x000E7C86 File Offset: 0x000E5E86
		public void SetLGUISpaceAbsolutePosition(in FVector Pos)
		{
			UUIItem.__SetLGUISpaceAbsolutePosition_Internal(base.NativePtr, Pos);
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x000E7C94 File Offset: 0x000E5E94
		public void SetIsUIActive(bool active)
		{
			UUIItem.__SetIsUIActive_Internal(base.NativePtr, active);
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x000E7CA2 File Offset: 0x000E5EA2
		public void SetHorizontalStretch(FVector2D newStretch)
		{
			UUIItem.__SetHorizontalStretch_Internal(base.NativePtr, newStretch);
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x000E7CB0 File Offset: 0x000E5EB0
		public void SetHierarchyIndex(int InInt)
		{
			UUIItem.__SetHierarchyIndex_Internal(base.NativePtr, InInt);
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x000E7CBE File Offset: 0x000E5EBE
		public void SetHeight(float NewHeight)
		{
			UUIItem.__SetHeight_Internal(base.NativePtr, NewHeight);
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x000E7CCC File Offset: 0x000E5ECC
		public unsafe void SetDisplayName(string InName)
		{
			FString fstring = FString.AllocTemp(InName);
			UUIItem.__SetDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x000E7CF6 File Offset: 0x000E5EF6
		public void SetDepth(int depth, bool propagateToChildren = false)
		{
			UUIItem.__SetDepth_Internal(base.NativePtr, depth, propagateToChildren);
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x000E7D05 File Offset: 0x000E5F05
		public void SetColor(FColor NewColor)
		{
			UUIItem.__SetColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x000E7D13 File Offset: 0x000E5F13
		public void SetChildrenAdditionalRenderOrder(int InAdditionalRenderOrder, bool bIncludeSelf = true)
		{
			UUIItem.__SetChildrenAdditionalRenderOrder_Internal(base.NativePtr, InAdditionalRenderOrder, bIncludeSelf);
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x000E7D24 File Offset: 0x000E5F24
		public void SetChangeColor(bool bUseChangeColor, in FColor? NewColor = null)
		{
			IntPtr nativePtr = base.NativePtr;
			FColor? fcolor = NewColor;
			FColor fcolor2;
			FColor fcolor3;
			if (fcolor == null)
			{
				fcolor2 = new FColor
				{
					R = byte.MaxValue,
					G = byte.MaxValue,
					B = byte.MaxValue,
					A = byte.MaxValue
				};
				fcolor3 = fcolor2;
			}
			else
			{
				fcolor3 = fcolor.GetValueOrDefault();
			}
			fcolor2 = fcolor3;
			UUIItem.__SetChangeColor_Internal(nativePtr, bUseChangeColor, fcolor2);
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x000E7D91 File Offset: 0x000E5F91
		public void SetBubbleUpToParent(bool NewBool)
		{
			UUIItem.__SetBubbleUpToParent_Internal(base.NativePtr, NewBool);
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x000E7D9F File Offset: 0x000E5F9F
		public void SetAsLastHierarchy()
		{
			UUIItem.__SetAsLastHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x000E7DAC File Offset: 0x000E5FAC
		public void SetAsFirstHierarchy()
		{
			UUIItem.__SetAsFirstHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x000E7DB9 File Offset: 0x000E5FB9
		public void SetAnchorVAlign(UIAnchorVerticalAlign align)
		{
			UUIItem.__SetAnchorVAlign_Internal(base.NativePtr, align);
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x000E7DC7 File Offset: 0x000E5FC7
		public void SetAnchorOffsetY(float NewOffset)
		{
			UUIItem.__SetAnchorOffsetY_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x000E7DD5 File Offset: 0x000E5FD5
		public void SetAnchorOffsetX(float NewOffset)
		{
			UUIItem.__SetAnchorOffsetX_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x000E7DE3 File Offset: 0x000E5FE3
		public void SetAnchorOffset(FVector2D NewOffset)
		{
			UUIItem.__SetAnchorOffset_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x000E7DF1 File Offset: 0x000E5FF1
		public void SetAnchorHAlign(UIAnchorHorizontalAlign align)
		{
			UUIItem.__SetAnchorHAlign_Internal(base.NativePtr, align);
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x000E7DFF File Offset: 0x000E5FFF
		public void SetAnchorAlign(UIAnchorHorizontalAlign HAlign, UIAnchorVerticalAlign VAlign)
		{
			UUIItem.__SetAnchorAlign_Internal(base.NativePtr, HAlign, VAlign);
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x000E7E0E File Offset: 0x000E600E
		public void SetAlpha(float newAlpha)
		{
			UUIItem.__SetAlpha_Internal(base.NativePtr, newAlpha);
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x000E7E1C File Offset: 0x000E601C
		public void SetAdditionalRenderOrder(int InAdditionalRenderOrder)
		{
			UUIItem.__SetAdditionalRenderOrder_Internal(base.NativePtr, InAdditionalRenderOrder);
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x000E7E2A File Offset: 0x000E602A
		public void ReverseChildrenIndex()
		{
			UUIItem.__ReverseChildrenIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x000E7E37 File Offset: 0x000E6037
		public void PlayUIItemScaleTween(float StartValue, float EndValue, float Duration)
		{
			UUIItem.__PlayUIItemScaleTween_Internal(base.NativePtr, StartValue, EndValue, Duration);
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x000E7E47 File Offset: 0x000E6047
		public void PlayUIItemAlphaTween(float StartValue, float EndValue, float Duration)
		{
			UUIItem.__PlayUIItemAlphaTween_Internal(base.NativePtr, StartValue, EndValue, Duration);
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x000E7E57 File Offset: 0x000E6057
		public bool IsWorldSpaceUI()
		{
			return UUIItem.__IsWorldSpaceUI_Internal(base.NativePtr);
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x000E7E64 File Offset: 0x000E6064
		public bool IsUsedCustomMinMaxAnchor()
		{
			return UUIItem.__IsUsedCustomMinMaxAnchor_Internal(base.NativePtr);
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x000E7E71 File Offset: 0x000E6071
		public bool IsUIActiveSelf()
		{
			return UUIItem.__IsUIActiveSelf_Internal(base.NativePtr);
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x000E7E7E File Offset: 0x000E607E
		public bool IsUIActiveInHierarchy()
		{
			return UUIItem.__IsUIActiveInHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x000E7E8B File Offset: 0x000E608B
		public bool IsScreenSpaceOverlayUI()
		{
			return UUIItem.__IsScreenSpaceOverlayUI_Internal(base.NativePtr);
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x000E7E98 File Offset: 0x000E6098
		public bool IsRenderTargetUI()
		{
			return UUIItem.__IsRenderTargetUI_Internal(base.NativePtr);
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x000E7EA5 File Offset: 0x000E60A5
		public bool IsRaycastTarget()
		{
			return UUIItem.__IsRaycastTarget_Internal(base.NativePtr);
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x000E7EB2 File Offset: 0x000E60B2
		public bool IsBubbleUpToParent()
		{
			return UUIItem.__IsBubbleUpToParent_Internal(base.NativePtr);
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x000E7EBF File Offset: 0x000E60BF
		public bool IsBoundOutOfScreen()
		{
			return UUIItem.__IsBoundOutOfScreen_Internal(base.NativePtr);
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x000E7ECC File Offset: 0x000E60CC
		public float GetWidth()
		{
			return UUIItem.__GetWidth_Internal(base.NativePtr);
		}

		// Token: 0x06009A75 RID: 39541 RVA: 0x000E7ED9 File Offset: 0x000E60D9
		public FUIWidget GetWidget()
		{
			return new FUIWidget(UUIItem.__GetWidget_Internal(base.NativePtr), null);
		}

		// Token: 0x06009A76 RID: 39542 RVA: 0x000E7EEC File Offset: 0x000E60EC
		public FVector GetUIWorldPosition()
		{
			return UUIItem.__GetUIWorldPosition_Internal(base.NativePtr);
		}

		// Token: 0x06009A77 RID: 39543 RVA: 0x000E7EF9 File Offset: 0x000E60F9
		[NullableContext(0)]
		public TEnumAsByte<ETraceTypeQuery> GetTraceChannel()
		{
			return UUIItem.__GetTraceChannel_Internal(base.NativePtr);
		}

		// Token: 0x06009A78 RID: 39544 RVA: 0x000E7F06 File Offset: 0x000E6106
		public float GetStretchTop()
		{
			return UUIItem.__GetStretchTop_Internal(base.NativePtr);
		}

		// Token: 0x06009A79 RID: 39545 RVA: 0x000E7F13 File Offset: 0x000E6113
		public float GetStretchRight()
		{
			return UUIItem.__GetStretchRight_Internal(base.NativePtr);
		}

		// Token: 0x06009A7A RID: 39546 RVA: 0x000E7F20 File Offset: 0x000E6120
		public float GetStretchLeft()
		{
			return UUIItem.__GetStretchLeft_Internal(base.NativePtr);
		}

		// Token: 0x06009A7B RID: 39547 RVA: 0x000E7F2D File Offset: 0x000E612D
		public float GetStretchBottom()
		{
			return UUIItem.__GetStretchBottom_Internal(base.NativePtr);
		}

		// Token: 0x06009A7C RID: 39548 RVA: 0x000E7F3A File Offset: 0x000E613A
		[NullableContext(2)]
		public ULGUICanvas GetRootCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(UUIItem.__GetRootCanvas_Internal(base.NativePtr));
		}

		// Token: 0x06009A7D RID: 39549 RVA: 0x000E7F4C File Offset: 0x000E614C
		[NullableContext(2)]
		public ULGUICanvas GetRenderCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(UUIItem.__GetRenderCanvas_Internal(base.NativePtr));
		}

		// Token: 0x06009A7E RID: 39550 RVA: 0x000E7F5E File Offset: 0x000E615E
		public FVector2D GetPositionInViewportWithPivotNormalized(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInViewportWithPivotNormalized_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x06009A7F RID: 39551 RVA: 0x000E7F6D File Offset: 0x000E616D
		public FVector2D GetPositionInViewportWithPivot(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInViewportWithPivot_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x06009A80 RID: 39552 RVA: 0x000E7F7C File Offset: 0x000E617C
		public FVector2D GetPositionInViewPortOld(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInViewPortOld_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x06009A81 RID: 39553 RVA: 0x000E7F8A File Offset: 0x000E618A
		public FVector2D GetPositionInViewPort(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInViewPort_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x06009A82 RID: 39554 RVA: 0x000E7F98 File Offset: 0x000E6198
		public FVector2D GetPositionInScreenWithPivot(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInScreenWithPivot_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x06009A83 RID: 39555 RVA: 0x000E7FA7 File Offset: 0x000E61A7
		public FVector2D GetPositionInScreen(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInScreen_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x06009A84 RID: 39556 RVA: 0x000E7FB5 File Offset: 0x000E61B5
		public FVector2D GetPivot()
		{
			return UUIItem.__GetPivot_Internal(base.NativePtr);
		}

		// Token: 0x06009A85 RID: 39557 RVA: 0x000E7FC2 File Offset: 0x000E61C2
		[NullableContext(2)]
		public UUIItem GetParentAsUIItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIItem.__GetParentAsUIItem_Internal(base.NativePtr));
		}

		// Token: 0x06009A86 RID: 39558 RVA: 0x000E7FD4 File Offset: 0x000E61D4
		[NullableContext(2)]
		public bool GetOverlapWith(UUIItem UIItem)
		{
			return UUIItem.__GetOverlapWith_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009A87 RID: 39559 RVA: 0x000E7FF1 File Offset: 0x000E61F1
		public float GetLocalSpaceTop()
		{
			return UUIItem.__GetLocalSpaceTop_Internal(base.NativePtr);
		}

		// Token: 0x06009A88 RID: 39560 RVA: 0x000E7FFE File Offset: 0x000E61FE
		public FVector2D GetLocalSpaceRightTopPoint()
		{
			return UUIItem.__GetLocalSpaceRightTopPoint_Internal(base.NativePtr);
		}

		// Token: 0x06009A89 RID: 39561 RVA: 0x000E800B File Offset: 0x000E620B
		public float GetLocalSpaceRight()
		{
			return UUIItem.__GetLocalSpaceRight_Internal(base.NativePtr);
		}

		// Token: 0x06009A8A RID: 39562 RVA: 0x000E8018 File Offset: 0x000E6218
		public FVector2D GetLocalSpaceLeftBottomPoint()
		{
			return UUIItem.__GetLocalSpaceLeftBottomPoint_Internal(base.NativePtr);
		}

		// Token: 0x06009A8B RID: 39563 RVA: 0x000E8025 File Offset: 0x000E6225
		public float GetLocalSpaceLeft()
		{
			return UUIItem.__GetLocalSpaceLeft_Internal(base.NativePtr);
		}

		// Token: 0x06009A8C RID: 39564 RVA: 0x000E8032 File Offset: 0x000E6232
		public FVector2D GetLocalSpaceCenter()
		{
			return UUIItem.__GetLocalSpaceCenter_Internal(base.NativePtr);
		}

		// Token: 0x06009A8D RID: 39565 RVA: 0x000E803F File Offset: 0x000E623F
		public float GetLocalSpaceBottom()
		{
			return UUIItem.__GetLocalSpaceBottom_Internal(base.NativePtr);
		}

		// Token: 0x06009A8E RID: 39566 RVA: 0x000E804C File Offset: 0x000E624C
		public FVector GetLGUISpaceCenterAbsolutePosition()
		{
			return UUIItem.__GetLGUISpaceCenterAbsolutePosition_Internal(base.NativePtr);
		}

		// Token: 0x06009A8F RID: 39567 RVA: 0x000E8059 File Offset: 0x000E6259
		public FVector GetLGUISpaceAbsolutePositionByPivot(in FVector2D Pivot)
		{
			return UUIItem.__GetLGUISpaceAbsolutePositionByPivot_Internal(base.NativePtr, Pivot);
		}

		// Token: 0x06009A90 RID: 39568 RVA: 0x000E8067 File Offset: 0x000E6267
		public FVector GetLGUISpaceAbsolutePosition()
		{
			return UUIItem.__GetLGUISpaceAbsolutePosition_Internal(base.NativePtr);
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x000E8074 File Offset: 0x000E6274
		public bool GetInheritAlpha()
		{
			return UUIItem.__GetInheritAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x000E8081 File Offset: 0x000E6281
		public int GetInCanvasFlattenHierarchyIndex()
		{
			return UUIItem.__GetInCanvasFlattenHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x000E808E File Offset: 0x000E628E
		public int GetHierarchyIndex()
		{
			return UUIItem.__GetHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x000E809B File Offset: 0x000E629B
		public float GetHeight()
		{
			return UUIItem.__GetHeight_Internal(base.NativePtr);
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x000E80A8 File Offset: 0x000E62A8
		public int GetFlattenHierarchyIndexV2()
		{
			return UUIItem.__GetFlattenHierarchyIndexV2_Internal(base.NativePtr);
		}

		// Token: 0x06009A96 RID: 39574 RVA: 0x000E80B5 File Offset: 0x000E62B5
		public int GetFlattenHierarchyIndexClassic()
		{
			return UUIItem.__GetFlattenHierarchyIndexClassic_Internal(base.NativePtr);
		}

		// Token: 0x06009A97 RID: 39575 RVA: 0x000E80C2 File Offset: 0x000E62C2
		public int GetFlattenHierarchyIndex()
		{
			return UUIItem.__GetFlattenHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009A98 RID: 39576 RVA: 0x000E80CF File Offset: 0x000E62CF
		public string GetDisplayName()
		{
			return FString.ToStringAndDeleteNativePtr(UUIItem.__GetDisplayName_Internal(base.NativePtr));
		}

		// Token: 0x06009A99 RID: 39577 RVA: 0x000E80E1 File Offset: 0x000E62E1
		public int GetDepth()
		{
			return UUIItem.__GetDepth_Internal(base.NativePtr);
		}

		// Token: 0x06009A9A RID: 39578 RVA: 0x000E80EE File Offset: 0x000E62EE
		public FColor GetColor()
		{
			return UUIItem.__GetColor_Internal(base.NativePtr);
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x000E80FB File Offset: 0x000E62FB
		[NullableContext(2)]
		public ULGUICanvasScaler GetCanvasScaler()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvasScaler>(UUIItem.__GetCanvasScaler_Internal(base.NativePtr));
		}

		// Token: 0x06009A9C RID: 39580 RVA: 0x000E810D File Offset: 0x000E630D
		public FVector GetCalculatedParentColor()
		{
			return UUIItem.__GetCalculatedParentColor_Internal(base.NativePtr);
		}

		// Token: 0x06009A9D RID: 39581 RVA: 0x000E811A File Offset: 0x000E631A
		public float GetCalculatedParentAlpha()
		{
			return UUIItem.__GetCalculatedParentAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06009A9E RID: 39582 RVA: 0x000E8127 File Offset: 0x000E6327
		public TArray<UUIItem> GetAttachUIChildren()
		{
			return new TArray<UUIItem>(UUIItem.__GetAttachUIChildren_Internal(base.NativePtr), null);
		}

		// Token: 0x06009A9F RID: 39583 RVA: 0x000E813A File Offset: 0x000E633A
		[NullableContext(2)]
		public UUIItem GetAttachUIChild(int index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIItem.__GetAttachUIChild_Internal(base.NativePtr, index));
		}

		// Token: 0x06009AA0 RID: 39584 RVA: 0x000E814D File Offset: 0x000E634D
		public UIAnchorVerticalAlign GetAnchorVAlign()
		{
			return UUIItem.__GetAnchorVAlign_Internal(base.NativePtr);
		}

		// Token: 0x06009AA1 RID: 39585 RVA: 0x000E815A File Offset: 0x000E635A
		public float GetAnchorOffsetY()
		{
			return UUIItem.__GetAnchorOffsetY_Internal(base.NativePtr);
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x000E8167 File Offset: 0x000E6367
		public float GetAnchorOffsetX()
		{
			return UUIItem.__GetAnchorOffsetX_Internal(base.NativePtr);
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x000E8174 File Offset: 0x000E6374
		public FVector2D GetAnchorOffset()
		{
			return UUIItem.__GetAnchorOffset_Internal(base.NativePtr);
		}

		// Token: 0x06009AA4 RID: 39588 RVA: 0x000E8181 File Offset: 0x000E6381
		public UIAnchorHorizontalAlign GetAnchorHAlign()
		{
			return UUIItem.__GetAnchorHAlign_Internal(base.NativePtr);
		}

		// Token: 0x06009AA5 RID: 39589 RVA: 0x000E818E File Offset: 0x000E638E
		public float GetAlpha()
		{
			return UUIItem.__GetAlpha_Internal(base.NativePtr);
		}

		// Token: 0x06009AA6 RID: 39590 RVA: 0x000E819B File Offset: 0x000E639B
		public void GetAllAttachUIChildren([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> OutArray)
		{
			UUIItem.__GetAllAttachUIChildren_Internal(base.NativePtr, (OutArray ?? new TArray<UUIItem>()).NativePtr);
		}

		// Token: 0x06009AA7 RID: 39591 RVA: 0x000E81B8 File Offset: 0x000E63B8
		public int GetAdditionalRenderOrder()
		{
			return UUIItem.__GetAdditionalRenderOrder_Internal(base.NativePtr);
		}

		// Token: 0x06009AA8 RID: 39592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidth_Internal(IntPtr @this, float NewWidth);

		// Token: 0x06009AA9 RID: 39593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidget_Internal(IntPtr @this, IntPtr inWidget);

		// Token: 0x06009AAA RID: 39594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalStretch_Internal(IntPtr @this, FVector2D newStretch);

		// Token: 0x06009AAB RID: 39595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldScale_Internal(IntPtr @this, in FVector NewScale);

		// Token: 0x06009AAC RID: 39596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x06009AAD RID: 39597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldLocation_Internal(IntPtr @this, in FVector NewLocation);

		// Token: 0x06009AAE RID: 39598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderBeforeUpScale_Internal(IntPtr @this, bool bBeforeUpScale);

		// Token: 0x06009AAF RID: 39599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderBeforeBloom_Internal(IntPtr @this, bool bBeforeBloom);

		// Token: 0x06009AB0 RID: 39600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderAfterBlur_Internal(IntPtr @this, bool bAfterBlur);

		// Token: 0x06009AB1 RID: 39601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeScale3D_Internal(IntPtr @this, in FVector NewScale3D);

		// Token: 0x06009AB2 RID: 39602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x06009AB3 RID: 39603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeLocation_Internal(IntPtr @this, FVector NewLocation);

		// Token: 0x06009AB4 RID: 39604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIParent_Internal(IntPtr @this, IntPtr InParent, bool KeepWorldTransform);

		// Token: 0x06009AB5 RID: 39605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIItemScale_Internal(IntPtr @this, FVector Value);

		// Token: 0x06009AB6 RID: 39606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIItemAlpha_Internal(IntPtr @this, float Value);

		// Token: 0x06009AB7 RID: 39607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIActive_Internal(IntPtr @this, bool bActive);

		// Token: 0x06009AB8 RID: 39608
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceChannel_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> InTraceChannel);

		// Token: 0x06009AB9 RID: 39609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchTop_Internal(IntPtr @this, float newTop);

		// Token: 0x06009ABA RID: 39610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchRight_Internal(IntPtr @this, float newRight);

		// Token: 0x06009ABB RID: 39611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchLeft_Internal(IntPtr @this, float newLeft);

		// Token: 0x06009ABC RID: 39612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchBottom_Internal(IntPtr @this, float newBottom);

		// Token: 0x06009ABD RID: 39613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastTarget_Internal(IntPtr @this, bool NewBool);

		// Token: 0x06009ABE RID: 39614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Raw_Internal(IntPtr @this, FVector2D NewPivot, bool bAdjustLocation);

		// Token: 0x06009ABF RID: 39615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Internal(IntPtr @this, FVector2D NewPivot);

		// Token: 0x06009AC0 RID: 39616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUISpaceAbsolutePosition_Internal(IntPtr @this, in FVector Pos);

		// Token: 0x06009AC1 RID: 39617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIActive_Internal(IntPtr @this, bool active);

		// Token: 0x06009AC2 RID: 39618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalStretch_Internal(IntPtr @this, FVector2D newStretch);

		// Token: 0x06009AC3 RID: 39619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHierarchyIndex_Internal(IntPtr @this, int InInt);

		// Token: 0x06009AC4 RID: 39620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeight_Internal(IntPtr @this, float NewHeight);

		// Token: 0x06009AC5 RID: 39621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisplayName_Internal(IntPtr @this, in FString InName);

		// Token: 0x06009AC6 RID: 39622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDepth_Internal(IntPtr @this, int depth, bool propagateToChildren);

		// Token: 0x06009AC7 RID: 39623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06009AC8 RID: 39624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChildrenAdditionalRenderOrder_Internal(IntPtr @this, int InAdditionalRenderOrder, bool bIncludeSelf);

		// Token: 0x06009AC9 RID: 39625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChangeColor_Internal(IntPtr @this, bool bUseChangeColor, in FColor NewColor);

		// Token: 0x06009ACA RID: 39626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBubbleUpToParent_Internal(IntPtr @this, bool NewBool);

		// Token: 0x06009ACB RID: 39627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsLastHierarchy_Internal(IntPtr @this);

		// Token: 0x06009ACC RID: 39628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsFirstHierarchy_Internal(IntPtr @this);

		// Token: 0x06009ACD RID: 39629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorVAlign_Internal(IntPtr @this, UIAnchorVerticalAlign align);

		// Token: 0x06009ACE RID: 39630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffsetY_Internal(IntPtr @this, float NewOffset);

		// Token: 0x06009ACF RID: 39631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffsetX_Internal(IntPtr @this, float NewOffset);

		// Token: 0x06009AD0 RID: 39632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffset_Internal(IntPtr @this, FVector2D NewOffset);

		// Token: 0x06009AD1 RID: 39633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorHAlign_Internal(IntPtr @this, UIAnchorHorizontalAlign align);

		// Token: 0x06009AD2 RID: 39634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorAlign_Internal(IntPtr @this, UIAnchorHorizontalAlign HAlign, UIAnchorVerticalAlign VAlign);

		// Token: 0x06009AD3 RID: 39635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlpha_Internal(IntPtr @this, float newAlpha);

		// Token: 0x06009AD4 RID: 39636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalRenderOrder_Internal(IntPtr @this, int InAdditionalRenderOrder);

		// Token: 0x06009AD5 RID: 39637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReverseChildrenIndex_Internal(IntPtr @this);

		// Token: 0x06009AD6 RID: 39638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayUIItemScaleTween_Internal(IntPtr @this, float StartValue, float EndValue, float Duration);

		// Token: 0x06009AD7 RID: 39639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayUIItemAlphaTween_Internal(IntPtr @this, float StartValue, float EndValue, float Duration);

		// Token: 0x06009AD8 RID: 39640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldSpaceUI_Internal(IntPtr @this);

		// Token: 0x06009AD9 RID: 39641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUsedCustomMinMaxAnchor_Internal(IntPtr @this);

		// Token: 0x06009ADA RID: 39642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIActiveSelf_Internal(IntPtr @this);

		// Token: 0x06009ADB RID: 39643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIActiveInHierarchy_Internal(IntPtr @this);

		// Token: 0x06009ADC RID: 39644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsScreenSpaceOverlayUI_Internal(IntPtr @this);

		// Token: 0x06009ADD RID: 39645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderTargetUI_Internal(IntPtr @this);

		// Token: 0x06009ADE RID: 39646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRaycastTarget_Internal(IntPtr @this);

		// Token: 0x06009ADF RID: 39647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBubbleUpToParent_Internal(IntPtr @this);

		// Token: 0x06009AE0 RID: 39648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoundOutOfScreen_Internal(IntPtr @this);

		// Token: 0x06009AE1 RID: 39649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWidth_Internal(IntPtr @this);

		// Token: 0x06009AE2 RID: 39650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWidget_Internal(IntPtr @this);

		// Token: 0x06009AE3 RID: 39651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUIWorldPosition_Internal(IntPtr @this);

		// Token: 0x06009AE4 RID: 39652
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ETraceTypeQuery> __GetTraceChannel_Internal(IntPtr @this);

		// Token: 0x06009AE5 RID: 39653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchTop_Internal(IntPtr @this);

		// Token: 0x06009AE6 RID: 39654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchRight_Internal(IntPtr @this);

		// Token: 0x06009AE7 RID: 39655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchLeft_Internal(IntPtr @this);

		// Token: 0x06009AE8 RID: 39656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchBottom_Internal(IntPtr @this);

		// Token: 0x06009AE9 RID: 39657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootCanvas_Internal(IntPtr @this);

		// Token: 0x06009AEA RID: 39658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderCanvas_Internal(IntPtr @this);

		// Token: 0x06009AEB RID: 39659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewportWithPivotNormalized_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x06009AEC RID: 39660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewportWithPivot_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x06009AED RID: 39661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewPortOld_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06009AEE RID: 39662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewPort_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06009AEF RID: 39663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInScreenWithPivot_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x06009AF0 RID: 39664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInScreen_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06009AF1 RID: 39665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPivot_Internal(IntPtr @this);

		// Token: 0x06009AF2 RID: 39666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentAsUIItem_Internal(IntPtr @this);

		// Token: 0x06009AF3 RID: 39667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOverlapWith_Internal(IntPtr @this, IntPtr UIItem);

		// Token: 0x06009AF4 RID: 39668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceTop_Internal(IntPtr @this);

		// Token: 0x06009AF5 RID: 39669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceRightTopPoint_Internal(IntPtr @this);

		// Token: 0x06009AF6 RID: 39670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceRight_Internal(IntPtr @this);

		// Token: 0x06009AF7 RID: 39671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceLeftBottomPoint_Internal(IntPtr @this);

		// Token: 0x06009AF8 RID: 39672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceLeft_Internal(IntPtr @this);

		// Token: 0x06009AF9 RID: 39673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceCenter_Internal(IntPtr @this);

		// Token: 0x06009AFA RID: 39674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceBottom_Internal(IntPtr @this);

		// Token: 0x06009AFB RID: 39675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceCenterAbsolutePosition_Internal(IntPtr @this);

		// Token: 0x06009AFC RID: 39676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceAbsolutePositionByPivot_Internal(IntPtr @this, in FVector2D Pivot);

		// Token: 0x06009AFD RID: 39677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceAbsolutePosition_Internal(IntPtr @this);

		// Token: 0x06009AFE RID: 39678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInheritAlpha_Internal(IntPtr @this);

		// Token: 0x06009AFF RID: 39679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInCanvasFlattenHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06009B00 RID: 39680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06009B01 RID: 39681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHeight_Internal(IntPtr @this);

		// Token: 0x06009B02 RID: 39682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndexV2_Internal(IntPtr @this);

		// Token: 0x06009B03 RID: 39683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndexClassic_Internal(IntPtr @this);

		// Token: 0x06009B04 RID: 39684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06009B05 RID: 39685
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDisplayName_Internal(IntPtr @this);

		// Token: 0x06009B06 RID: 39686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDepth_Internal(IntPtr @this);

		// Token: 0x06009B07 RID: 39687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetColor_Internal(IntPtr @this);

		// Token: 0x06009B08 RID: 39688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCanvasScaler_Internal(IntPtr @this);

		// Token: 0x06009B09 RID: 39689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCalculatedParentColor_Internal(IntPtr @this);

		// Token: 0x06009B0A RID: 39690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCalculatedParentAlpha_Internal(IntPtr @this);

		// Token: 0x06009B0B RID: 39691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachUIChildren_Internal(IntPtr @this);

		// Token: 0x06009B0C RID: 39692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachUIChild_Internal(IntPtr @this, int index);

		// Token: 0x06009B0D RID: 39693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIAnchorVerticalAlign __GetAnchorVAlign_Internal(IntPtr @this);

		// Token: 0x06009B0E RID: 39694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnchorOffsetY_Internal(IntPtr @this);

		// Token: 0x06009B0F RID: 39695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnchorOffsetX_Internal(IntPtr @this);

		// Token: 0x06009B10 RID: 39696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAnchorOffset_Internal(IntPtr @this);

		// Token: 0x06009B11 RID: 39697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIAnchorHorizontalAlign __GetAnchorHAlign_Internal(IntPtr @this);

		// Token: 0x06009B12 RID: 39698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAlpha_Internal(IntPtr @this);

		// Token: 0x06009B13 RID: 39699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllAttachUIChildren_Internal(IntPtr @this, IntPtr OutArray);

		// Token: 0x06009B14 RID: 39700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAdditionalRenderOrder_Internal(IntPtr @this);

		// Token: 0x06009B15 RID: 39701 RVA: 0x000E81C5 File Offset: 0x000E63C5
		static UUIItem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIItem");
		}

		// Token: 0x06009B16 RID: 39702 RVA: 0x000E81D3 File Offset: 0x000E63D3
		protected UUIItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042D0 RID: 17104
		public new const string __ObjectPath = "/Script/LGUI.UIItem";

		// Token: 0x040042D1 RID: 17105
		private static IntPtr _ClassPtr;

		// Token: 0x040042D2 RID: 17106
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042D3 RID: 17107
		internal static int __PropertyOffset_widget;

		// Token: 0x040042D4 RID: 17108
		[Nullable(2)]
		private FUIWidget _widget;

		// Token: 0x040042D5 RID: 17109
		internal static int __PropertyOffset_UIChildren;

		// Token: 0x040042D6 RID: 17110
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> _UIChildren;

		// Token: 0x040042D7 RID: 17111
		internal static int __PropertyOffset_inheritAlpha;

		// Token: 0x040042D8 RID: 17112
		internal static int __PropertyOffset_bInheritColor;

		// Token: 0x040042D9 RID: 17113
		internal static int __PropertyOffset_Color;

		// Token: 0x040042DA RID: 17114
		internal static int __PropertyOffset_Alpha;

		// Token: 0x040042DB RID: 17115
		internal static int __PropertyOffset_Width;

		// Token: 0x040042DC RID: 17116
		internal static int __PropertyOffset_Height;

		// Token: 0x040042DD RID: 17117
		internal static int __PropertyOffset_useChangeColor;

		// Token: 0x040042DE RID: 17118
		internal static int __PropertyOffset_changeColor;

		// Token: 0x040042DF RID: 17119
		internal static int __PropertyOffset_LevelSequences;

		// Token: 0x040042E0 RID: 17120
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FSequenceInfo> _LevelSequences;

		// Token: 0x040042E1 RID: 17121
		internal static int __PropertyOffset_HardRefAssets;

		// Token: 0x040042E2 RID: 17122
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _HardRefAssets;

		// Token: 0x040042E3 RID: 17123
		internal static int __PropertyOffset_RenderCanvasActor;

		// Token: 0x040042E4 RID: 17124
		internal static int __PropertyOffset_bIsRenderAfterBlur;

		// Token: 0x040042E5 RID: 17125
		internal static int __PropertyOffset_bIsRenderBeforeBloom;

		// Token: 0x040042E6 RID: 17126
		internal static int __PropertyOffset_bIsRenderBeforeUpScale;

		// Token: 0x040042E7 RID: 17127
		internal static int __PropertyOffset_bIsRenderAsMask;

		// Token: 0x040042E8 RID: 17128
		internal static int __PropertyOffset_bIsReadMask;

		// Token: 0x040042E9 RID: 17129
		internal static int __PropertyOffset_bIsUIActive;

		// Token: 0x040042EA RID: 17130
		internal static int __PropertyOffset_bClipOutOfViewport;

		// Token: 0x040042EB RID: 17131
		internal static int __PropertyOffset_hierarchyIndex;

		// Token: 0x040042EC RID: 17132
		internal static int __PropertyOffset_flattenHierarchyIndex;

		// Token: 0x040042ED RID: 17133
		internal static int __PropertyOffset_inCanvasFlattenHierarchyIndex;

		// Token: 0x040042EE RID: 17134
		internal static int __PropertyOffset_AdditionalIndexDelta;

		// Token: 0x040042EF RID: 17135
		internal static int __PropertyOffset_displayName;

		// Token: 0x040042F0 RID: 17136
		internal static int __PropertyOffset_bRaycastTarget;

		// Token: 0x040042F1 RID: 17137
		internal static int __PropertyOffset_bBubbleUpToParent;

		// Token: 0x040042F2 RID: 17138
		internal static int __PropertyOffset_traceChannel;

		// Token: 0x040042F3 RID: 17139
		internal static int __PropertyOffset_DebugCollisionLine;

		// Token: 0x040042F4 RID: 17140
		internal static int __PropertyOffset_AdditionalRenderOrder;
	}
}
