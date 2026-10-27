using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200217B RID: 8571
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIItem")]
	[UnrealStructLayout(1600, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1600)]
	public class UUIItem : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602064A RID: 132682 RVA: 0x0030111E File Offset: 0x002FF31E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIItem._ClassPtr;
		}

		// Token: 0x0602064B RID: 132683 RVA: 0x0030112C File Offset: 0x002FF32C
		public UUIItem() : this(BuiltinUtils.AllocNativeUObject(UUIItem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602064C RID: 132684 RVA: 0x00301154 File Offset: 0x002FF354
		public UUIItem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIItem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007EED RID: 32493
		// (get) Token: 0x0602064D RID: 132685 RVA: 0x00301188 File Offset: 0x002FF388
		// (set) Token: 0x0602064E RID: 132686 RVA: 0x003011C1 File Offset: 0x002FF3C1
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

		// Token: 0x17007EEE RID: 32494
		// (get) Token: 0x0602064F RID: 132687 RVA: 0x003011E4 File Offset: 0x002FF3E4
		// (set) Token: 0x06020650 RID: 132688 RVA: 0x0030121D File Offset: 0x002FF41D
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

		// Token: 0x17007EEF RID: 32495
		// (get) Token: 0x06020651 RID: 132689 RVA: 0x0030122B File Offset: 0x002FF42B
		// (set) Token: 0x06020652 RID: 132690 RVA: 0x0030123B File Offset: 0x002FF43B
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

		// Token: 0x17007EF0 RID: 32496
		// (get) Token: 0x06020653 RID: 132691 RVA: 0x0030124C File Offset: 0x002FF44C
		// (set) Token: 0x06020654 RID: 132692 RVA: 0x0030125C File Offset: 0x002FF45C
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

		// Token: 0x17007EF1 RID: 32497
		// (get) Token: 0x06020655 RID: 132693 RVA: 0x0030126D File Offset: 0x002FF46D
		// (set) Token: 0x06020656 RID: 132694 RVA: 0x00301281 File Offset: 0x002FF481
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

		// Token: 0x17007EF2 RID: 32498
		// (get) Token: 0x06020657 RID: 132695 RVA: 0x00301296 File Offset: 0x002FF496
		// (set) Token: 0x06020658 RID: 132696 RVA: 0x003012A6 File Offset: 0x002FF4A6
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

		// Token: 0x17007EF3 RID: 32499
		// (get) Token: 0x06020659 RID: 132697 RVA: 0x003012B7 File Offset: 0x002FF4B7
		// (set) Token: 0x0602065A RID: 132698 RVA: 0x003012C7 File Offset: 0x002FF4C7
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

		// Token: 0x17007EF4 RID: 32500
		// (get) Token: 0x0602065B RID: 132699 RVA: 0x003012D8 File Offset: 0x002FF4D8
		// (set) Token: 0x0602065C RID: 132700 RVA: 0x003012E8 File Offset: 0x002FF4E8
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

		// Token: 0x17007EF5 RID: 32501
		// (get) Token: 0x0602065D RID: 132701 RVA: 0x003012F9 File Offset: 0x002FF4F9
		// (set) Token: 0x0602065E RID: 132702 RVA: 0x00301309 File Offset: 0x002FF509
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

		// Token: 0x17007EF6 RID: 32502
		// (get) Token: 0x0602065F RID: 132703 RVA: 0x0030131A File Offset: 0x002FF51A
		// (set) Token: 0x06020660 RID: 132704 RVA: 0x0030132E File Offset: 0x002FF52E
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

		// Token: 0x17007EF7 RID: 32503
		// (get) Token: 0x06020661 RID: 132705 RVA: 0x00301344 File Offset: 0x002FF544
		// (set) Token: 0x06020662 RID: 132706 RVA: 0x0030137D File Offset: 0x002FF57D
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

		// Token: 0x17007EF8 RID: 32504
		// (get) Token: 0x06020663 RID: 132707 RVA: 0x0030138C File Offset: 0x002FF58C
		// (set) Token: 0x06020664 RID: 132708 RVA: 0x003013C5 File Offset: 0x002FF5C5
		public TMap<FSoftObjectPath, FLGUILevelSequenceBindings> LevelSequenceBindings
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FSoftObjectPath, FLGUILevelSequenceBindings> result;
				if ((result = this._LevelSequenceBindings) == null)
				{
					result = (this._LevelSequenceBindings = new TMap<FSoftObjectPath, FLGUILevelSequenceBindings>(base.NativePtr + (IntPtr)UUIItem.__PropertyOffset_LevelSequenceBindings, this));
				}
				return result;
			}
			set
			{
				this.LevelSequenceBindings.CopyAssign(value);
			}
		}

		// Token: 0x17007EF9 RID: 32505
		// (get) Token: 0x06020665 RID: 132709 RVA: 0x003013D4 File Offset: 0x002FF5D4
		// (set) Token: 0x06020666 RID: 132710 RVA: 0x0030140D File Offset: 0x002FF60D
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

		// Token: 0x17007EFA RID: 32506
		// (get) Token: 0x06020667 RID: 132711 RVA: 0x0030141B File Offset: 0x002FF61B
		// (set) Token: 0x06020668 RID: 132712 RVA: 0x0030142F File Offset: 0x002FF62F
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

		// Token: 0x17007EFB RID: 32507
		// (get) Token: 0x06020669 RID: 132713 RVA: 0x00301444 File Offset: 0x002FF644
		// (set) Token: 0x0602066A RID: 132714 RVA: 0x00301454 File Offset: 0x002FF654
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

		// Token: 0x17007EFC RID: 32508
		// (get) Token: 0x0602066B RID: 132715 RVA: 0x00301465 File Offset: 0x002FF665
		// (set) Token: 0x0602066C RID: 132716 RVA: 0x00301475 File Offset: 0x002FF675
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

		// Token: 0x17007EFD RID: 32509
		// (get) Token: 0x0602066D RID: 132717 RVA: 0x00301486 File Offset: 0x002FF686
		// (set) Token: 0x0602066E RID: 132718 RVA: 0x00301496 File Offset: 0x002FF696
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

		// Token: 0x17007EFE RID: 32510
		// (get) Token: 0x0602066F RID: 132719 RVA: 0x003014A7 File Offset: 0x002FF6A7
		// (set) Token: 0x06020670 RID: 132720 RVA: 0x003014B7 File Offset: 0x002FF6B7
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

		// Token: 0x17007EFF RID: 32511
		// (get) Token: 0x06020671 RID: 132721 RVA: 0x003014C8 File Offset: 0x002FF6C8
		// (set) Token: 0x06020672 RID: 132722 RVA: 0x003014D8 File Offset: 0x002FF6D8
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

		// Token: 0x17007F00 RID: 32512
		// (get) Token: 0x06020673 RID: 132723 RVA: 0x003014E9 File Offset: 0x002FF6E9
		// (set) Token: 0x06020674 RID: 132724 RVA: 0x003014F9 File Offset: 0x002FF6F9
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

		// Token: 0x17007F01 RID: 32513
		// (get) Token: 0x06020675 RID: 132725 RVA: 0x0030150A File Offset: 0x002FF70A
		// (set) Token: 0x06020676 RID: 132726 RVA: 0x0030151A File Offset: 0x002FF71A
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

		// Token: 0x17007F02 RID: 32514
		// (get) Token: 0x06020677 RID: 132727 RVA: 0x0030152B File Offset: 0x002FF72B
		// (set) Token: 0x06020678 RID: 132728 RVA: 0x0030153B File Offset: 0x002FF73B
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

		// Token: 0x17007F03 RID: 32515
		// (get) Token: 0x06020679 RID: 132729 RVA: 0x0030154C File Offset: 0x002FF74C
		// (set) Token: 0x0602067A RID: 132730 RVA: 0x0030155C File Offset: 0x002FF75C
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

		// Token: 0x17007F04 RID: 32516
		// (get) Token: 0x0602067B RID: 132731 RVA: 0x0030156D File Offset: 0x002FF76D
		// (set) Token: 0x0602067C RID: 132732 RVA: 0x0030157D File Offset: 0x002FF77D
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

		// Token: 0x17007F05 RID: 32517
		// (get) Token: 0x0602067D RID: 132733 RVA: 0x0030158E File Offset: 0x002FF78E
		// (set) Token: 0x0602067E RID: 132734 RVA: 0x0030159E File Offset: 0x002FF79E
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

		// Token: 0x17007F06 RID: 32518
		// (get) Token: 0x0602067F RID: 132735 RVA: 0x003015AF File Offset: 0x002FF7AF
		// (set) Token: 0x06020680 RID: 132736 RVA: 0x003015C3 File Offset: 0x002FF7C3
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

		// Token: 0x17007F07 RID: 32519
		// (get) Token: 0x06020681 RID: 132737 RVA: 0x003015D8 File Offset: 0x002FF7D8
		// (set) Token: 0x06020682 RID: 132738 RVA: 0x003015E8 File Offset: 0x002FF7E8
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

		// Token: 0x17007F08 RID: 32520
		// (get) Token: 0x06020683 RID: 132739 RVA: 0x003015F9 File Offset: 0x002FF7F9
		// (set) Token: 0x06020684 RID: 132740 RVA: 0x00301609 File Offset: 0x002FF809
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

		// Token: 0x17007F09 RID: 32521
		// (get) Token: 0x06020685 RID: 132741 RVA: 0x0030161A File Offset: 0x002FF81A
		// (set) Token: 0x06020686 RID: 132742 RVA: 0x0030162E File Offset: 0x002FF82E
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

		// Token: 0x17007F0A RID: 32522
		// (get) Token: 0x06020687 RID: 132743 RVA: 0x00301643 File Offset: 0x002FF843
		// (set) Token: 0x06020688 RID: 132744 RVA: 0x00301657 File Offset: 0x002FF857
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

		// Token: 0x17007F0B RID: 32523
		// (get) Token: 0x06020689 RID: 132745 RVA: 0x0030166C File Offset: 0x002FF86C
		// (set) Token: 0x0602068A RID: 132746 RVA: 0x0030167C File Offset: 0x002FF87C
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

		// Token: 0x0602068B RID: 132747 RVA: 0x0030168D File Offset: 0x002FF88D
		public void SetWidth(float NewWidth)
		{
			UUIItem.__SetWidth_Internal(base.NativePtr, NewWidth);
		}

		// Token: 0x0602068C RID: 132748 RVA: 0x0030169B File Offset: 0x002FF89B
		[NullableContext(2)]
		public void SetWidget(in FUIWidget inWidget)
		{
			UUIItem.__SetWidget_Internal(base.NativePtr, (inWidget ?? new FUIWidget()).NativePtr);
		}

		// Token: 0x0602068D RID: 132749 RVA: 0x003016B8 File Offset: 0x002FF8B8
		public void SetVerticalStretch(FVector2D newStretch)
		{
			UUIItem.__SetVerticalStretch_Internal(base.NativePtr, newStretch);
		}

		// Token: 0x0602068E RID: 132750 RVA: 0x003016C6 File Offset: 0x002FF8C6
		public void SetUIWorldScale(in FVector NewScale)
		{
			UUIItem.__SetUIWorldScale_Internal(base.NativePtr, NewScale);
		}

		// Token: 0x0602068F RID: 132751 RVA: 0x003016D4 File Offset: 0x002FF8D4
		public void SetUIWorldRotation(in FRotator NewRotation)
		{
			UUIItem.__SetUIWorldRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x06020690 RID: 132752 RVA: 0x003016E2 File Offset: 0x002FF8E2
		public void SetUIWorldLocation(in FVector NewLocation)
		{
			UUIItem.__SetUIWorldLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x06020691 RID: 132753 RVA: 0x003016F0 File Offset: 0x002FF8F0
		public void SetUIRenderBeforeUpScale(bool bBeforeUpScale)
		{
			UUIItem.__SetUIRenderBeforeUpScale_Internal(base.NativePtr, bBeforeUpScale);
		}

		// Token: 0x06020692 RID: 132754 RVA: 0x003016FE File Offset: 0x002FF8FE
		public void SetUIRenderBeforeBloom(bool bBeforeBloom)
		{
			UUIItem.__SetUIRenderBeforeBloom_Internal(base.NativePtr, bBeforeBloom);
		}

		// Token: 0x06020693 RID: 132755 RVA: 0x0030170C File Offset: 0x002FF90C
		public void SetUIRenderAfterBlur(bool bAfterBlur)
		{
			UUIItem.__SetUIRenderAfterBlur_Internal(base.NativePtr, bAfterBlur);
		}

		// Token: 0x06020694 RID: 132756 RVA: 0x0030171A File Offset: 0x002FF91A
		public void SetUIRelativeScale3D(in FVector NewScale3D)
		{
			UUIItem.__SetUIRelativeScale3D_Internal(base.NativePtr, NewScale3D);
		}

		// Token: 0x06020695 RID: 132757 RVA: 0x00301728 File Offset: 0x002FF928
		public void SetUIRelativeRotation(in FRotator NewRotation)
		{
			UUIItem.__SetUIRelativeRotation_Internal(base.NativePtr, NewRotation);
		}

		// Token: 0x06020696 RID: 132758 RVA: 0x00301736 File Offset: 0x002FF936
		public void SetUIRelativeLocation(FVector NewLocation)
		{
			UUIItem.__SetUIRelativeLocation_Internal(base.NativePtr, NewLocation);
		}

		// Token: 0x06020697 RID: 132759 RVA: 0x00301744 File Offset: 0x002FF944
		[NullableContext(2)]
		public void SetUIParent(UUIItem InParent, bool KeepWorldTransform = false)
		{
			UUIItem.__SetUIParent_Internal(base.NativePtr, (InParent != null) ? InParent.NativePtr : IntPtr.Zero, KeepWorldTransform);
		}

		// Token: 0x06020698 RID: 132760 RVA: 0x00301762 File Offset: 0x002FF962
		public void SetUIItemScale(FVector Value)
		{
			UUIItem.__SetUIItemScale_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020699 RID: 132761 RVA: 0x00301770 File Offset: 0x002FF970
		public void SetUIItemAlpha(float Value)
		{
			UUIItem.__SetUIItemAlpha_Internal(base.NativePtr, Value);
		}

		// Token: 0x0602069A RID: 132762 RVA: 0x0030177E File Offset: 0x002FF97E
		public void SetUIActive(bool bActive)
		{
			UUIItem.__SetUIActive_Internal(base.NativePtr, bActive);
		}

		// Token: 0x0602069B RID: 132763 RVA: 0x0030178C File Offset: 0x002FF98C
		public void SetTraceChannel(ETraceTypeQuery InTraceChannel)
		{
			UUIItem.__SetTraceChannel_Internal(base.NativePtr, InTraceChannel);
		}

		// Token: 0x0602069C RID: 132764 RVA: 0x0030179F File Offset: 0x002FF99F
		public void SetStretchTop(float newTop)
		{
			UUIItem.__SetStretchTop_Internal(base.NativePtr, newTop);
		}

		// Token: 0x0602069D RID: 132765 RVA: 0x003017AD File Offset: 0x002FF9AD
		public void SetStretchRight(float newRight)
		{
			UUIItem.__SetStretchRight_Internal(base.NativePtr, newRight);
		}

		// Token: 0x0602069E RID: 132766 RVA: 0x003017BB File Offset: 0x002FF9BB
		public void SetStretchLeft(float newLeft)
		{
			UUIItem.__SetStretchLeft_Internal(base.NativePtr, newLeft);
		}

		// Token: 0x0602069F RID: 132767 RVA: 0x003017C9 File Offset: 0x002FF9C9
		public void SetStretchBottom(float newBottom)
		{
			UUIItem.__SetStretchBottom_Internal(base.NativePtr, newBottom);
		}

		// Token: 0x060206A0 RID: 132768 RVA: 0x003017D7 File Offset: 0x002FF9D7
		public void SetRaycastTarget(bool NewBool)
		{
			UUIItem.__SetRaycastTarget_Internal(base.NativePtr, NewBool);
		}

		// Token: 0x060206A1 RID: 132769 RVA: 0x003017E5 File Offset: 0x002FF9E5
		public void SetPivot_Raw(FVector2D NewPivot, bool bAdjustLocation = true)
		{
			UUIItem.__SetPivot_Raw_Internal(base.NativePtr, NewPivot, bAdjustLocation);
		}

		// Token: 0x060206A2 RID: 132770 RVA: 0x003017F4 File Offset: 0x002FF9F4
		public void SetPivot(FVector2D NewPivot)
		{
			UUIItem.__SetPivot_Internal(base.NativePtr, NewPivot);
		}

		// Token: 0x060206A3 RID: 132771 RVA: 0x00301802 File Offset: 0x002FFA02
		public void SetLGUISpaceAbsolutePosition(in FVector Pos)
		{
			UUIItem.__SetLGUISpaceAbsolutePosition_Internal(base.NativePtr, Pos);
		}

		// Token: 0x060206A4 RID: 132772 RVA: 0x00301810 File Offset: 0x002FFA10
		public void SetIsUIActive(bool active)
		{
			UUIItem.__SetIsUIActive_Internal(base.NativePtr, active);
		}

		// Token: 0x060206A5 RID: 132773 RVA: 0x0030181E File Offset: 0x002FFA1E
		public void SetHorizontalStretch(FVector2D newStretch)
		{
			UUIItem.__SetHorizontalStretch_Internal(base.NativePtr, newStretch);
		}

		// Token: 0x060206A6 RID: 132774 RVA: 0x0030182C File Offset: 0x002FFA2C
		public void SetHierarchyIndex(int InInt)
		{
			UUIItem.__SetHierarchyIndex_Internal(base.NativePtr, InInt);
		}

		// Token: 0x060206A7 RID: 132775 RVA: 0x0030183A File Offset: 0x002FFA3A
		public void SetHeight(float NewHeight)
		{
			UUIItem.__SetHeight_Internal(base.NativePtr, NewHeight);
		}

		// Token: 0x060206A8 RID: 132776 RVA: 0x00301848 File Offset: 0x002FFA48
		public unsafe void SetDisplayName(string InName)
		{
			FString fstring = FString.AllocTemp(InName);
			UUIItem.__SetDisplayName_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060206A9 RID: 132777 RVA: 0x00301872 File Offset: 0x002FFA72
		public void SetDepth(int depth, bool propagateToChildren = false)
		{
			UUIItem.__SetDepth_Internal(base.NativePtr, depth, propagateToChildren);
		}

		// Token: 0x060206AA RID: 132778 RVA: 0x00301881 File Offset: 0x002FFA81
		public void SetColor(FColor NewColor)
		{
			UUIItem.__SetColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x060206AB RID: 132779 RVA: 0x0030188F File Offset: 0x002FFA8F
		public void SetChildrenAdditionalRenderOrder(int InAdditionalRenderOrder, bool bIncludeSelf = true)
		{
			UUIItem.__SetChildrenAdditionalRenderOrder_Internal(base.NativePtr, InAdditionalRenderOrder, bIncludeSelf);
		}

		// Token: 0x060206AC RID: 132780 RVA: 0x003018A0 File Offset: 0x002FFAA0
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

		// Token: 0x060206AD RID: 132781 RVA: 0x0030190D File Offset: 0x002FFB0D
		public void SetBubbleUpToParent(bool NewBool)
		{
			UUIItem.__SetBubbleUpToParent_Internal(base.NativePtr, NewBool);
		}

		// Token: 0x060206AE RID: 132782 RVA: 0x0030191B File Offset: 0x002FFB1B
		public void SetAsLastHierarchy()
		{
			UUIItem.__SetAsLastHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x060206AF RID: 132783 RVA: 0x00301928 File Offset: 0x002FFB28
		public void SetAsFirstHierarchy()
		{
			UUIItem.__SetAsFirstHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x060206B0 RID: 132784 RVA: 0x00301935 File Offset: 0x002FFB35
		public void SetAnchorVAlign(UIAnchorVerticalAlign align)
		{
			UUIItem.__SetAnchorVAlign_Internal(base.NativePtr, align);
		}

		// Token: 0x060206B1 RID: 132785 RVA: 0x00301943 File Offset: 0x002FFB43
		public void SetAnchorOffsetY(float NewOffset)
		{
			UUIItem.__SetAnchorOffsetY_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x060206B2 RID: 132786 RVA: 0x00301951 File Offset: 0x002FFB51
		public void SetAnchorOffsetX(float NewOffset)
		{
			UUIItem.__SetAnchorOffsetX_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x060206B3 RID: 132787 RVA: 0x0030195F File Offset: 0x002FFB5F
		public void SetAnchorOffset(FVector2D NewOffset)
		{
			UUIItem.__SetAnchorOffset_Internal(base.NativePtr, NewOffset);
		}

		// Token: 0x060206B4 RID: 132788 RVA: 0x0030196D File Offset: 0x002FFB6D
		public void SetAnchorHAlign(UIAnchorHorizontalAlign align)
		{
			UUIItem.__SetAnchorHAlign_Internal(base.NativePtr, align);
		}

		// Token: 0x060206B5 RID: 132789 RVA: 0x0030197B File Offset: 0x002FFB7B
		public void SetAnchorAlign(UIAnchorHorizontalAlign HAlign, UIAnchorVerticalAlign VAlign)
		{
			UUIItem.__SetAnchorAlign_Internal(base.NativePtr, HAlign, VAlign);
		}

		// Token: 0x060206B6 RID: 132790 RVA: 0x0030198A File Offset: 0x002FFB8A
		public void SetAlpha(float newAlpha)
		{
			UUIItem.__SetAlpha_Internal(base.NativePtr, newAlpha);
		}

		// Token: 0x060206B7 RID: 132791 RVA: 0x00301998 File Offset: 0x002FFB98
		public void SetAdditionalRenderOrder(int InAdditionalRenderOrder)
		{
			UUIItem.__SetAdditionalRenderOrder_Internal(base.NativePtr, InAdditionalRenderOrder);
		}

		// Token: 0x060206B8 RID: 132792 RVA: 0x003019A6 File Offset: 0x002FFBA6
		public void ReverseChildrenIndex()
		{
			UUIItem.__ReverseChildrenIndex_Internal(base.NativePtr);
		}

		// Token: 0x060206B9 RID: 132793 RVA: 0x003019B3 File Offset: 0x002FFBB3
		public void PlayUIItemScaleTween(float StartValue, float EndValue, float Duration)
		{
			UUIItem.__PlayUIItemScaleTween_Internal(base.NativePtr, StartValue, EndValue, Duration);
		}

		// Token: 0x060206BA RID: 132794 RVA: 0x003019C3 File Offset: 0x002FFBC3
		public void PlayUIItemAlphaTween(float StartValue, float EndValue, float Duration)
		{
			UUIItem.__PlayUIItemAlphaTween_Internal(base.NativePtr, StartValue, EndValue, Duration);
		}

		// Token: 0x060206BB RID: 132795 RVA: 0x003019D3 File Offset: 0x002FFBD3
		public bool IsWorldSpaceUI()
		{
			return UUIItem.__IsWorldSpaceUI_Internal(base.NativePtr);
		}

		// Token: 0x060206BC RID: 132796 RVA: 0x003019E0 File Offset: 0x002FFBE0
		public bool IsUsedCustomMinMaxAnchor()
		{
			return UUIItem.__IsUsedCustomMinMaxAnchor_Internal(base.NativePtr);
		}

		// Token: 0x060206BD RID: 132797 RVA: 0x003019ED File Offset: 0x002FFBED
		public bool IsUIActiveSelf()
		{
			return UUIItem.__IsUIActiveSelf_Internal(base.NativePtr);
		}

		// Token: 0x060206BE RID: 132798 RVA: 0x003019FA File Offset: 0x002FFBFA
		public bool IsUIActiveInHierarchy()
		{
			return UUIItem.__IsUIActiveInHierarchy_Internal(base.NativePtr);
		}

		// Token: 0x060206BF RID: 132799 RVA: 0x00301A07 File Offset: 0x002FFC07
		public bool IsScreenSpaceOverlayUI()
		{
			return UUIItem.__IsScreenSpaceOverlayUI_Internal(base.NativePtr);
		}

		// Token: 0x060206C0 RID: 132800 RVA: 0x00301A14 File Offset: 0x002FFC14
		public bool IsRenderTargetUI()
		{
			return UUIItem.__IsRenderTargetUI_Internal(base.NativePtr);
		}

		// Token: 0x060206C1 RID: 132801 RVA: 0x00301A21 File Offset: 0x002FFC21
		public bool IsRaycastTarget()
		{
			return UUIItem.__IsRaycastTarget_Internal(base.NativePtr);
		}

		// Token: 0x060206C2 RID: 132802 RVA: 0x00301A2E File Offset: 0x002FFC2E
		public bool IsBubbleUpToParent()
		{
			return UUIItem.__IsBubbleUpToParent_Internal(base.NativePtr);
		}

		// Token: 0x060206C3 RID: 132803 RVA: 0x00301A3B File Offset: 0x002FFC3B
		public bool IsBoundOutOfScreen()
		{
			return UUIItem.__IsBoundOutOfScreen_Internal(base.NativePtr);
		}

		// Token: 0x060206C4 RID: 132804 RVA: 0x00301A48 File Offset: 0x002FFC48
		public float GetWidth()
		{
			return UUIItem.__GetWidth_Internal(base.NativePtr);
		}

		// Token: 0x060206C5 RID: 132805 RVA: 0x00301A55 File Offset: 0x002FFC55
		public FUIWidget GetWidget()
		{
			return new FUIWidget(UUIItem.__GetWidget_Internal(base.NativePtr), null);
		}

		// Token: 0x060206C6 RID: 132806 RVA: 0x00301A68 File Offset: 0x002FFC68
		public FVector GetUIWorldPosition()
		{
			return UUIItem.__GetUIWorldPosition_Internal(base.NativePtr);
		}

		// Token: 0x060206C7 RID: 132807 RVA: 0x00301A75 File Offset: 0x002FFC75
		public UIItemType GetUIItemType()
		{
			return UUIItem.__GetUIItemType_Internal(base.NativePtr);
		}

		// Token: 0x060206C8 RID: 132808 RVA: 0x00301A82 File Offset: 0x002FFC82
		[NullableContext(0)]
		public TEnumAsByte<ETraceTypeQuery> GetTraceChannel()
		{
			return UUIItem.__GetTraceChannel_Internal(base.NativePtr);
		}

		// Token: 0x060206C9 RID: 132809 RVA: 0x00301A8F File Offset: 0x002FFC8F
		public float GetStretchTop()
		{
			return UUIItem.__GetStretchTop_Internal(base.NativePtr);
		}

		// Token: 0x060206CA RID: 132810 RVA: 0x00301A9C File Offset: 0x002FFC9C
		public float GetStretchRight()
		{
			return UUIItem.__GetStretchRight_Internal(base.NativePtr);
		}

		// Token: 0x060206CB RID: 132811 RVA: 0x00301AA9 File Offset: 0x002FFCA9
		public float GetStretchLeft()
		{
			return UUIItem.__GetStretchLeft_Internal(base.NativePtr);
		}

		// Token: 0x060206CC RID: 132812 RVA: 0x00301AB6 File Offset: 0x002FFCB6
		public float GetStretchBottom()
		{
			return UUIItem.__GetStretchBottom_Internal(base.NativePtr);
		}

		// Token: 0x060206CD RID: 132813 RVA: 0x00301AC3 File Offset: 0x002FFCC3
		[NullableContext(2)]
		public ULGUICanvas GetRootCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(UUIItem.__GetRootCanvas_Internal(base.NativePtr));
		}

		// Token: 0x060206CE RID: 132814 RVA: 0x00301AD5 File Offset: 0x002FFCD5
		[NullableContext(2)]
		public ULGUICanvas GetRenderCanvas()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvas>(UUIItem.__GetRenderCanvas_Internal(base.NativePtr));
		}

		// Token: 0x060206CF RID: 132815 RVA: 0x00301AE7 File Offset: 0x002FFCE7
		public FVector2D GetPositionInViewportWithPivotNormalized(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInViewportWithPivotNormalized_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x060206D0 RID: 132816 RVA: 0x00301AF6 File Offset: 0x002FFCF6
		public FVector2D GetPositionInViewportWithPivot(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInViewportWithPivot_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x060206D1 RID: 132817 RVA: 0x00301B05 File Offset: 0x002FFD05
		public FVector2D GetPositionInViewPortOld(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInViewPortOld_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x060206D2 RID: 132818 RVA: 0x00301B13 File Offset: 0x002FFD13
		public FVector2D GetPositionInViewPort(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInViewPort_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x060206D3 RID: 132819 RVA: 0x00301B21 File Offset: 0x002FFD21
		public FVector2D GetPositionInScreenWithPivot(bool bIsScaledByDPI, in FVector2D SpecifiedPivot)
		{
			return UUIItem.__GetPositionInScreenWithPivot_Internal(base.NativePtr, bIsScaledByDPI, SpecifiedPivot);
		}

		// Token: 0x060206D4 RID: 132820 RVA: 0x00301B30 File Offset: 0x002FFD30
		public FVector2D GetPositionInScreen(bool bIsScaledByDPI)
		{
			return UUIItem.__GetPositionInScreen_Internal(base.NativePtr, bIsScaledByDPI);
		}

		// Token: 0x060206D5 RID: 132821 RVA: 0x00301B3E File Offset: 0x002FFD3E
		public FVector2D GetPivot()
		{
			return UUIItem.__GetPivot_Internal(base.NativePtr);
		}

		// Token: 0x060206D6 RID: 132822 RVA: 0x00301B4B File Offset: 0x002FFD4B
		[NullableContext(2)]
		public UUIItem GetParentAsUIItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIItem.__GetParentAsUIItem_Internal(base.NativePtr));
		}

		// Token: 0x060206D7 RID: 132823 RVA: 0x00301B5D File Offset: 0x002FFD5D
		[NullableContext(2)]
		public bool GetOverlapWith(UUIItem UIItem)
		{
			return UUIItem.__GetOverlapWith_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060206D8 RID: 132824 RVA: 0x00301B7A File Offset: 0x002FFD7A
		public float GetLocalSpaceTop()
		{
			return UUIItem.__GetLocalSpaceTop_Internal(base.NativePtr);
		}

		// Token: 0x060206D9 RID: 132825 RVA: 0x00301B87 File Offset: 0x002FFD87
		public FVector2D GetLocalSpaceRightTopPoint()
		{
			return UUIItem.__GetLocalSpaceRightTopPoint_Internal(base.NativePtr);
		}

		// Token: 0x060206DA RID: 132826 RVA: 0x00301B94 File Offset: 0x002FFD94
		public float GetLocalSpaceRight()
		{
			return UUIItem.__GetLocalSpaceRight_Internal(base.NativePtr);
		}

		// Token: 0x060206DB RID: 132827 RVA: 0x00301BA1 File Offset: 0x002FFDA1
		public FVector2D GetLocalSpaceLeftBottomPoint()
		{
			return UUIItem.__GetLocalSpaceLeftBottomPoint_Internal(base.NativePtr);
		}

		// Token: 0x060206DC RID: 132828 RVA: 0x00301BAE File Offset: 0x002FFDAE
		public float GetLocalSpaceLeft()
		{
			return UUIItem.__GetLocalSpaceLeft_Internal(base.NativePtr);
		}

		// Token: 0x060206DD RID: 132829 RVA: 0x00301BBB File Offset: 0x002FFDBB
		public FVector2D GetLocalSpaceCenter()
		{
			return UUIItem.__GetLocalSpaceCenter_Internal(base.NativePtr);
		}

		// Token: 0x060206DE RID: 132830 RVA: 0x00301BC8 File Offset: 0x002FFDC8
		public float GetLocalSpaceBottom()
		{
			return UUIItem.__GetLocalSpaceBottom_Internal(base.NativePtr);
		}

		// Token: 0x060206DF RID: 132831 RVA: 0x00301BD5 File Offset: 0x002FFDD5
		public FVector GetLGUISpaceCenterAbsolutePosition()
		{
			return UUIItem.__GetLGUISpaceCenterAbsolutePosition_Internal(base.NativePtr);
		}

		// Token: 0x060206E0 RID: 132832 RVA: 0x00301BE2 File Offset: 0x002FFDE2
		public FVector GetLGUISpaceAbsolutePositionByPivot(in FVector2D Pivot)
		{
			return UUIItem.__GetLGUISpaceAbsolutePositionByPivot_Internal(base.NativePtr, Pivot);
		}

		// Token: 0x060206E1 RID: 132833 RVA: 0x00301BF0 File Offset: 0x002FFDF0
		public FVector GetLGUISpaceAbsolutePosition()
		{
			return UUIItem.__GetLGUISpaceAbsolutePosition_Internal(base.NativePtr);
		}

		// Token: 0x060206E2 RID: 132834 RVA: 0x00301BFD File Offset: 0x002FFDFD
		public bool GetInheritAlpha()
		{
			return UUIItem.__GetInheritAlpha_Internal(base.NativePtr);
		}

		// Token: 0x060206E3 RID: 132835 RVA: 0x00301C0A File Offset: 0x002FFE0A
		public int GetInCanvasFlattenHierarchyIndex()
		{
			return UUIItem.__GetInCanvasFlattenHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x060206E4 RID: 132836 RVA: 0x00301C17 File Offset: 0x002FFE17
		public int GetHierarchyIndex()
		{
			return UUIItem.__GetHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x060206E5 RID: 132837 RVA: 0x00301C24 File Offset: 0x002FFE24
		public float GetHeight()
		{
			return UUIItem.__GetHeight_Internal(base.NativePtr);
		}

		// Token: 0x060206E6 RID: 132838 RVA: 0x00301C31 File Offset: 0x002FFE31
		public int GetFlattenHierarchyIndexV2()
		{
			return UUIItem.__GetFlattenHierarchyIndexV2_Internal(base.NativePtr);
		}

		// Token: 0x060206E7 RID: 132839 RVA: 0x00301C3E File Offset: 0x002FFE3E
		public int GetFlattenHierarchyIndexClassic()
		{
			return UUIItem.__GetFlattenHierarchyIndexClassic_Internal(base.NativePtr);
		}

		// Token: 0x060206E8 RID: 132840 RVA: 0x00301C4B File Offset: 0x002FFE4B
		public int GetFlattenHierarchyIndex()
		{
			return UUIItem.__GetFlattenHierarchyIndex_Internal(base.NativePtr);
		}

		// Token: 0x060206E9 RID: 132841 RVA: 0x00301C58 File Offset: 0x002FFE58
		public string GetDisplayName()
		{
			return FString.ToStringAndDeleteNativePtr(UUIItem.__GetDisplayName_Internal(base.NativePtr));
		}

		// Token: 0x060206EA RID: 132842 RVA: 0x00301C6A File Offset: 0x002FFE6A
		public int GetDepth()
		{
			return UUIItem.__GetDepth_Internal(base.NativePtr);
		}

		// Token: 0x060206EB RID: 132843 RVA: 0x00301C77 File Offset: 0x002FFE77
		public FColor GetColor()
		{
			return UUIItem.__GetColor_Internal(base.NativePtr);
		}

		// Token: 0x060206EC RID: 132844 RVA: 0x00301C84 File Offset: 0x002FFE84
		[NullableContext(2)]
		public ULGUICanvasScaler GetCanvasScaler()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUICanvasScaler>(UUIItem.__GetCanvasScaler_Internal(base.NativePtr));
		}

		// Token: 0x060206ED RID: 132845 RVA: 0x00301C96 File Offset: 0x002FFE96
		public FVector GetCalculatedParentColor()
		{
			return UUIItem.__GetCalculatedParentColor_Internal(base.NativePtr);
		}

		// Token: 0x060206EE RID: 132846 RVA: 0x00301CA3 File Offset: 0x002FFEA3
		public float GetCalculatedParentAlpha()
		{
			return UUIItem.__GetCalculatedParentAlpha_Internal(base.NativePtr);
		}

		// Token: 0x060206EF RID: 132847 RVA: 0x00301CB0 File Offset: 0x002FFEB0
		public TArray<UUIItem> GetAttachUIChildren()
		{
			return new TArray<UUIItem>(UUIItem.__GetAttachUIChildren_Internal(base.NativePtr), null);
		}

		// Token: 0x060206F0 RID: 132848 RVA: 0x00301CC3 File Offset: 0x002FFEC3
		[NullableContext(2)]
		public UUIItem GetAttachUIChild(int index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIItem.__GetAttachUIChild_Internal(base.NativePtr, index));
		}

		// Token: 0x060206F1 RID: 132849 RVA: 0x00301CD6 File Offset: 0x002FFED6
		public UIAnchorVerticalAlign GetAnchorVAlign()
		{
			return UUIItem.__GetAnchorVAlign_Internal(base.NativePtr);
		}

		// Token: 0x060206F2 RID: 132850 RVA: 0x00301CE3 File Offset: 0x002FFEE3
		public float GetAnchorOffsetY()
		{
			return UUIItem.__GetAnchorOffsetY_Internal(base.NativePtr);
		}

		// Token: 0x060206F3 RID: 132851 RVA: 0x00301CF0 File Offset: 0x002FFEF0
		public float GetAnchorOffsetX()
		{
			return UUIItem.__GetAnchorOffsetX_Internal(base.NativePtr);
		}

		// Token: 0x060206F4 RID: 132852 RVA: 0x00301CFD File Offset: 0x002FFEFD
		public FVector2D GetAnchorOffset()
		{
			return UUIItem.__GetAnchorOffset_Internal(base.NativePtr);
		}

		// Token: 0x060206F5 RID: 132853 RVA: 0x00301D0A File Offset: 0x002FFF0A
		public UIAnchorHorizontalAlign GetAnchorHAlign()
		{
			return UUIItem.__GetAnchorHAlign_Internal(base.NativePtr);
		}

		// Token: 0x060206F6 RID: 132854 RVA: 0x00301D17 File Offset: 0x002FFF17
		public float GetAlpha()
		{
			return UUIItem.__GetAlpha_Internal(base.NativePtr);
		}

		// Token: 0x060206F7 RID: 132855 RVA: 0x00301D24 File Offset: 0x002FFF24
		public void GetAllAttachUIChildren([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUIItem> OutArray)
		{
			UUIItem.__GetAllAttachUIChildren_Internal(base.NativePtr, (OutArray ?? new TArray<UUIItem>()).NativePtr);
		}

		// Token: 0x060206F8 RID: 132856 RVA: 0x00301D41 File Offset: 0x002FFF41
		public int GetAdditionalRenderOrder()
		{
			return UUIItem.__GetAdditionalRenderOrder_Internal(base.NativePtr);
		}

		// Token: 0x060206F9 RID: 132857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidth_Internal(IntPtr @this, float NewWidth);

		// Token: 0x060206FA RID: 132858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWidget_Internal(IntPtr @this, IntPtr inWidget);

		// Token: 0x060206FB RID: 132859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalStretch_Internal(IntPtr @this, FVector2D newStretch);

		// Token: 0x060206FC RID: 132860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldScale_Internal(IntPtr @this, in FVector NewScale);

		// Token: 0x060206FD RID: 132861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x060206FE RID: 132862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIWorldLocation_Internal(IntPtr @this, in FVector NewLocation);

		// Token: 0x060206FF RID: 132863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderBeforeUpScale_Internal(IntPtr @this, bool bBeforeUpScale);

		// Token: 0x06020700 RID: 132864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderBeforeBloom_Internal(IntPtr @this, bool bBeforeBloom);

		// Token: 0x06020701 RID: 132865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRenderAfterBlur_Internal(IntPtr @this, bool bAfterBlur);

		// Token: 0x06020702 RID: 132866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeScale3D_Internal(IntPtr @this, in FVector NewScale3D);

		// Token: 0x06020703 RID: 132867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeRotation_Internal(IntPtr @this, in FRotator NewRotation);

		// Token: 0x06020704 RID: 132868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIRelativeLocation_Internal(IntPtr @this, FVector NewLocation);

		// Token: 0x06020705 RID: 132869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIParent_Internal(IntPtr @this, IntPtr InParent, bool KeepWorldTransform);

		// Token: 0x06020706 RID: 132870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIItemScale_Internal(IntPtr @this, FVector Value);

		// Token: 0x06020707 RID: 132871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIItemAlpha_Internal(IntPtr @this, float Value);

		// Token: 0x06020708 RID: 132872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUIActive_Internal(IntPtr @this, bool bActive);

		// Token: 0x06020709 RID: 132873
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTraceChannel_Internal(IntPtr @this, TEnumAsByte<ETraceTypeQuery> InTraceChannel);

		// Token: 0x0602070A RID: 132874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchTop_Internal(IntPtr @this, float newTop);

		// Token: 0x0602070B RID: 132875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchRight_Internal(IntPtr @this, float newRight);

		// Token: 0x0602070C RID: 132876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchLeft_Internal(IntPtr @this, float newLeft);

		// Token: 0x0602070D RID: 132877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStretchBottom_Internal(IntPtr @this, float newBottom);

		// Token: 0x0602070E RID: 132878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaycastTarget_Internal(IntPtr @this, bool NewBool);

		// Token: 0x0602070F RID: 132879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Raw_Internal(IntPtr @this, FVector2D NewPivot, bool bAdjustLocation);

		// Token: 0x06020710 RID: 132880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPivot_Internal(IntPtr @this, FVector2D NewPivot);

		// Token: 0x06020711 RID: 132881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLGUISpaceAbsolutePosition_Internal(IntPtr @this, in FVector Pos);

		// Token: 0x06020712 RID: 132882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIActive_Internal(IntPtr @this, bool active);

		// Token: 0x06020713 RID: 132883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalStretch_Internal(IntPtr @this, FVector2D newStretch);

		// Token: 0x06020714 RID: 132884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHierarchyIndex_Internal(IntPtr @this, int InInt);

		// Token: 0x06020715 RID: 132885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeight_Internal(IntPtr @this, float NewHeight);

		// Token: 0x06020716 RID: 132886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisplayName_Internal(IntPtr @this, in FString InName);

		// Token: 0x06020717 RID: 132887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDepth_Internal(IntPtr @this, int depth, bool propagateToChildren);

		// Token: 0x06020718 RID: 132888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06020719 RID: 132889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChildrenAdditionalRenderOrder_Internal(IntPtr @this, int InAdditionalRenderOrder, bool bIncludeSelf);

		// Token: 0x0602071A RID: 132890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetChangeColor_Internal(IntPtr @this, bool bUseChangeColor, in FColor NewColor);

		// Token: 0x0602071B RID: 132891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBubbleUpToParent_Internal(IntPtr @this, bool NewBool);

		// Token: 0x0602071C RID: 132892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsLastHierarchy_Internal(IntPtr @this);

		// Token: 0x0602071D RID: 132893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAsFirstHierarchy_Internal(IntPtr @this);

		// Token: 0x0602071E RID: 132894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorVAlign_Internal(IntPtr @this, UIAnchorVerticalAlign align);

		// Token: 0x0602071F RID: 132895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffsetY_Internal(IntPtr @this, float NewOffset);

		// Token: 0x06020720 RID: 132896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffsetX_Internal(IntPtr @this, float NewOffset);

		// Token: 0x06020721 RID: 132897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorOffset_Internal(IntPtr @this, FVector2D NewOffset);

		// Token: 0x06020722 RID: 132898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorHAlign_Internal(IntPtr @this, UIAnchorHorizontalAlign align);

		// Token: 0x06020723 RID: 132899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorAlign_Internal(IntPtr @this, UIAnchorHorizontalAlign HAlign, UIAnchorVerticalAlign VAlign);

		// Token: 0x06020724 RID: 132900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlpha_Internal(IntPtr @this, float newAlpha);

		// Token: 0x06020725 RID: 132901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAdditionalRenderOrder_Internal(IntPtr @this, int InAdditionalRenderOrder);

		// Token: 0x06020726 RID: 132902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReverseChildrenIndex_Internal(IntPtr @this);

		// Token: 0x06020727 RID: 132903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayUIItemScaleTween_Internal(IntPtr @this, float StartValue, float EndValue, float Duration);

		// Token: 0x06020728 RID: 132904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayUIItemAlphaTween_Internal(IntPtr @this, float StartValue, float EndValue, float Duration);

		// Token: 0x06020729 RID: 132905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsWorldSpaceUI_Internal(IntPtr @this);

		// Token: 0x0602072A RID: 132906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUsedCustomMinMaxAnchor_Internal(IntPtr @this);

		// Token: 0x0602072B RID: 132907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIActiveSelf_Internal(IntPtr @this);

		// Token: 0x0602072C RID: 132908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsUIActiveInHierarchy_Internal(IntPtr @this);

		// Token: 0x0602072D RID: 132909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsScreenSpaceOverlayUI_Internal(IntPtr @this);

		// Token: 0x0602072E RID: 132910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRenderTargetUI_Internal(IntPtr @this);

		// Token: 0x0602072F RID: 132911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRaycastTarget_Internal(IntPtr @this);

		// Token: 0x06020730 RID: 132912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBubbleUpToParent_Internal(IntPtr @this);

		// Token: 0x06020731 RID: 132913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBoundOutOfScreen_Internal(IntPtr @this);

		// Token: 0x06020732 RID: 132914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWidth_Internal(IntPtr @this);

		// Token: 0x06020733 RID: 132915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetWidget_Internal(IntPtr @this);

		// Token: 0x06020734 RID: 132916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetUIWorldPosition_Internal(IntPtr @this);

		// Token: 0x06020735 RID: 132917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIItemType __GetUIItemType_Internal(IntPtr @this);

		// Token: 0x06020736 RID: 132918
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ETraceTypeQuery> __GetTraceChannel_Internal(IntPtr @this);

		// Token: 0x06020737 RID: 132919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchTop_Internal(IntPtr @this);

		// Token: 0x06020738 RID: 132920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchRight_Internal(IntPtr @this);

		// Token: 0x06020739 RID: 132921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchLeft_Internal(IntPtr @this);

		// Token: 0x0602073A RID: 132922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetStretchBottom_Internal(IntPtr @this);

		// Token: 0x0602073B RID: 132923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootCanvas_Internal(IntPtr @this);

		// Token: 0x0602073C RID: 132924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRenderCanvas_Internal(IntPtr @this);

		// Token: 0x0602073D RID: 132925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewportWithPivotNormalized_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x0602073E RID: 132926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewportWithPivot_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x0602073F RID: 132927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewPortOld_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06020740 RID: 132928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInViewPort_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06020741 RID: 132929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInScreenWithPivot_Internal(IntPtr @this, bool bIsScaledByDPI, in FVector2D SpecifiedPivot);

		// Token: 0x06020742 RID: 132930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPositionInScreen_Internal(IntPtr @this, bool bIsScaledByDPI);

		// Token: 0x06020743 RID: 132931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetPivot_Internal(IntPtr @this);

		// Token: 0x06020744 RID: 132932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParentAsUIItem_Internal(IntPtr @this);

		// Token: 0x06020745 RID: 132933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetOverlapWith_Internal(IntPtr @this, IntPtr UIItem);

		// Token: 0x06020746 RID: 132934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceTop_Internal(IntPtr @this);

		// Token: 0x06020747 RID: 132935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceRightTopPoint_Internal(IntPtr @this);

		// Token: 0x06020748 RID: 132936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceRight_Internal(IntPtr @this);

		// Token: 0x06020749 RID: 132937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceLeftBottomPoint_Internal(IntPtr @this);

		// Token: 0x0602074A RID: 132938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceLeft_Internal(IntPtr @this);

		// Token: 0x0602074B RID: 132939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetLocalSpaceCenter_Internal(IntPtr @this);

		// Token: 0x0602074C RID: 132940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLocalSpaceBottom_Internal(IntPtr @this);

		// Token: 0x0602074D RID: 132941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceCenterAbsolutePosition_Internal(IntPtr @this);

		// Token: 0x0602074E RID: 132942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceAbsolutePositionByPivot_Internal(IntPtr @this, in FVector2D Pivot);

		// Token: 0x0602074F RID: 132943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetLGUISpaceAbsolutePosition_Internal(IntPtr @this);

		// Token: 0x06020750 RID: 132944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInheritAlpha_Internal(IntPtr @this);

		// Token: 0x06020751 RID: 132945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetInCanvasFlattenHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06020752 RID: 132946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06020753 RID: 132947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHeight_Internal(IntPtr @this);

		// Token: 0x06020754 RID: 132948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndexV2_Internal(IntPtr @this);

		// Token: 0x06020755 RID: 132949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndexClassic_Internal(IntPtr @this);

		// Token: 0x06020756 RID: 132950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFlattenHierarchyIndex_Internal(IntPtr @this);

		// Token: 0x06020757 RID: 132951
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDisplayName_Internal(IntPtr @this);

		// Token: 0x06020758 RID: 132952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDepth_Internal(IntPtr @this);

		// Token: 0x06020759 RID: 132953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetColor_Internal(IntPtr @this);

		// Token: 0x0602075A RID: 132954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCanvasScaler_Internal(IntPtr @this);

		// Token: 0x0602075B RID: 132955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetCalculatedParentColor_Internal(IntPtr @this);

		// Token: 0x0602075C RID: 132956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCalculatedParentAlpha_Internal(IntPtr @this);

		// Token: 0x0602075D RID: 132957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachUIChildren_Internal(IntPtr @this);

		// Token: 0x0602075E RID: 132958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAttachUIChild_Internal(IntPtr @this, int index);

		// Token: 0x0602075F RID: 132959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIAnchorVerticalAlign __GetAnchorVAlign_Internal(IntPtr @this);

		// Token: 0x06020760 RID: 132960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnchorOffsetY_Internal(IntPtr @this);

		// Token: 0x06020761 RID: 132961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnchorOffsetX_Internal(IntPtr @this);

		// Token: 0x06020762 RID: 132962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAnchorOffset_Internal(IntPtr @this);

		// Token: 0x06020763 RID: 132963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern UIAnchorHorizontalAlign __GetAnchorHAlign_Internal(IntPtr @this);

		// Token: 0x06020764 RID: 132964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAlpha_Internal(IntPtr @this);

		// Token: 0x06020765 RID: 132965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllAttachUIChildren_Internal(IntPtr @this, IntPtr OutArray);

		// Token: 0x06020766 RID: 132966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAdditionalRenderOrder_Internal(IntPtr @this);

		// Token: 0x06020767 RID: 132967 RVA: 0x00301D4E File Offset: 0x002FFF4E
		static UUIItem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIItem");
		}

		// Token: 0x06020768 RID: 132968 RVA: 0x00301D5C File Offset: 0x002FFF5C
		protected UUIItem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401162F RID: 71215
		public new const string __ObjectPath = "/Script/LGUI.UIItem";

		// Token: 0x04011630 RID: 71216
		private static IntPtr _ClassPtr;

		// Token: 0x04011631 RID: 71217
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011632 RID: 71218
		internal static int __PropertyOffset_widget;

		// Token: 0x04011633 RID: 71219
		[Nullable(2)]
		private FUIWidget _widget;

		// Token: 0x04011634 RID: 71220
		internal static int __PropertyOffset_UIChildren;

		// Token: 0x04011635 RID: 71221
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUIItem> _UIChildren;

		// Token: 0x04011636 RID: 71222
		internal static int __PropertyOffset_inheritAlpha;

		// Token: 0x04011637 RID: 71223
		internal static int __PropertyOffset_bInheritColor;

		// Token: 0x04011638 RID: 71224
		internal static int __PropertyOffset_Color;

		// Token: 0x04011639 RID: 71225
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0401163A RID: 71226
		internal static int __PropertyOffset_Width;

		// Token: 0x0401163B RID: 71227
		internal static int __PropertyOffset_Height;

		// Token: 0x0401163C RID: 71228
		internal static int __PropertyOffset_useChangeColor;

		// Token: 0x0401163D RID: 71229
		internal static int __PropertyOffset_changeColor;

		// Token: 0x0401163E RID: 71230
		internal static int __PropertyOffset_LevelSequences;

		// Token: 0x0401163F RID: 71231
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FSequenceInfo> _LevelSequences;

		// Token: 0x04011640 RID: 71232
		internal static int __PropertyOffset_LevelSequenceBindings;

		// Token: 0x04011641 RID: 71233
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<FSoftObjectPath, FLGUILevelSequenceBindings> _LevelSequenceBindings;

		// Token: 0x04011642 RID: 71234
		internal static int __PropertyOffset_HardRefAssets;

		// Token: 0x04011643 RID: 71235
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _HardRefAssets;

		// Token: 0x04011644 RID: 71236
		internal static int __PropertyOffset_RenderCanvasActor;

		// Token: 0x04011645 RID: 71237
		internal static int __PropertyOffset_bIsRenderAfterBlur;

		// Token: 0x04011646 RID: 71238
		internal static int __PropertyOffset_bIsRenderBeforeBloom;

		// Token: 0x04011647 RID: 71239
		internal static int __PropertyOffset_bIsRenderBeforeUpScale;

		// Token: 0x04011648 RID: 71240
		internal static int __PropertyOffset_bIsRenderAsMask;

		// Token: 0x04011649 RID: 71241
		internal static int __PropertyOffset_bIsReadMask;

		// Token: 0x0401164A RID: 71242
		internal static int __PropertyOffset_bIsUIActive;

		// Token: 0x0401164B RID: 71243
		internal static int __PropertyOffset_bClipOutOfViewport;

		// Token: 0x0401164C RID: 71244
		internal static int __PropertyOffset_hierarchyIndex;

		// Token: 0x0401164D RID: 71245
		internal static int __PropertyOffset_flattenHierarchyIndex;

		// Token: 0x0401164E RID: 71246
		internal static int __PropertyOffset_inCanvasFlattenHierarchyIndex;

		// Token: 0x0401164F RID: 71247
		internal static int __PropertyOffset_AdditionalIndexDelta;

		// Token: 0x04011650 RID: 71248
		internal static int __PropertyOffset_displayName;

		// Token: 0x04011651 RID: 71249
		internal static int __PropertyOffset_bRaycastTarget;

		// Token: 0x04011652 RID: 71250
		internal static int __PropertyOffset_bBubbleUpToParent;

		// Token: 0x04011653 RID: 71251
		internal static int __PropertyOffset_traceChannel;

		// Token: 0x04011654 RID: 71252
		internal static int __PropertyOffset_DebugCollisionLine;

		// Token: 0x04011655 RID: 71253
		internal static int __PropertyOffset_AdditionalRenderOrder;
	}
}
