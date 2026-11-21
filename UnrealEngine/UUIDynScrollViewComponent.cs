using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F7 RID: 1783
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynScrollViewComponent")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class UUIDynScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600977A RID: 38778 RVA: 0x000E485E File Offset: 0x000E2A5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynScrollViewComponent._ClassPtr;
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x000E486C File Offset: 0x000E2A6C
		public UUIDynScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDynScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600977C RID: 38780 RVA: 0x000E4894 File Offset: 0x000E2A94
		public UUIDynScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C22 RID: 7202
		// (get) Token: 0x0600977D RID: 38781 RVA: 0x000E48C7 File Offset: 0x000E2AC7
		// (set) Token: 0x0600977E RID: 38782 RVA: 0x000E48DB File Offset: 0x000E2ADB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TemplateItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_TemplateItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_TemplateItem) = value;
			}
		}

		// Token: 0x17001C23 RID: 7203
		// (get) Token: 0x0600977F RID: 38783 RVA: 0x000E48F0 File Offset: 0x000E2AF0
		// (set) Token: 0x06009780 RID: 38784 RVA: 0x000E4900 File Offset: 0x000E2B00
		public unsafe int TotalItemNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_TotalItemNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_TotalItemNum) = value;
			}
		}

		// Token: 0x17001C24 RID: 7204
		// (get) Token: 0x06009781 RID: 38785 RVA: 0x000E4911 File Offset: 0x000E2B11
		// (set) Token: 0x06009782 RID: 38786 RVA: 0x000E4921 File Offset: 0x000E2B21
		public unsafe bool ItemDefaultUIActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ItemDefaultUIActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ItemDefaultUIActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C25 RID: 7205
		// (get) Token: 0x06009783 RID: 38787 RVA: 0x000E4932 File Offset: 0x000E2B32
		// (set) Token: 0x06009784 RID: 38788 RVA: 0x000E4942 File Offset: 0x000E2B42
		public unsafe float SpacingHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SpacingHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SpacingHorizontal) = value;
			}
		}

		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x06009785 RID: 38789 RVA: 0x000E4953 File Offset: 0x000E2B53
		// (set) Token: 0x06009786 RID: 38790 RVA: 0x000E4963 File Offset: 0x000E2B63
		public unsafe float SpacingVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SpacingVertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SpacingVertical) = value;
			}
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x06009787 RID: 38791 RVA: 0x000E4974 File Offset: 0x000E2B74
		// (set) Token: 0x06009788 RID: 38792 RVA: 0x000E4984 File Offset: 0x000E2B84
		public unsafe float PaddingHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_PaddingHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_PaddingHorizontal) = value;
			}
		}

		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x06009789 RID: 38793 RVA: 0x000E4995 File Offset: 0x000E2B95
		// (set) Token: 0x0600978A RID: 38794 RVA: 0x000E49A5 File Offset: 0x000E2BA5
		public unsafe float PaddingVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_PaddingVertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_PaddingVertical) = value;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x0600978B RID: 38795 RVA: 0x000E49B6 File Offset: 0x000E2BB6
		// (set) Token: 0x0600978C RID: 38796 RVA: 0x000E49C6 File Offset: 0x000E2BC6
		public unsafe float GridAnimationStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_GridAnimationStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_GridAnimationStartTime) = value;
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x0600978D RID: 38797 RVA: 0x000E49D7 File Offset: 0x000E2BD7
		// (set) Token: 0x0600978E RID: 38798 RVA: 0x000E49E7 File Offset: 0x000E2BE7
		public unsafe float GridAnimationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_GridAnimationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_GridAnimationInterval) = value;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x0600978F RID: 38799 RVA: 0x000E49F8 File Offset: 0x000E2BF8
		// (set) Token: 0x06009790 RID: 38800 RVA: 0x000E4A08 File Offset: 0x000E2C08
		public unsafe bool IsInAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_IsInAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_IsInAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x06009791 RID: 38801 RVA: 0x000E4A19 File Offset: 0x000E2C19
		// (set) Token: 0x06009792 RID: 38802 RVA: 0x000E4A29 File Offset: 0x000E2C29
		public unsafe bool SizeMatchContent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SizeMatchContent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_SizeMatchContent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x06009793 RID: 38803 RVA: 0x000E4A3C File Offset: 0x000E2C3C
		// (set) Token: 0x06009794 RID: 38804 RVA: 0x000E4A75 File Offset: 0x000E2C75
		public FLGUIDynScrollViewItemCreateDelegate OnItemCreate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDynScrollViewItemCreateDelegate result;
				if ((result = this._OnItemCreate) == null)
				{
					result = (this._OnItemCreate = new FLGUIDynScrollViewItemCreateDelegate(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemCreate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemCreate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x06009795 RID: 38805 RVA: 0x000E4A98 File Offset: 0x000E2C98
		// (set) Token: 0x06009796 RID: 38806 RVA: 0x000E4AD1 File Offset: 0x000E2CD1
		public FLGUIDynScrollViewItemUpdateDelegate OnItemUpdate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDynScrollViewItemUpdateDelegate result;
				if ((result = this._OnItemUpdate) == null)
				{
					result = (this._OnItemUpdate = new FLGUIDynScrollViewItemUpdateDelegate(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemUpdate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x06009797 RID: 38807 RVA: 0x000E4AF4 File Offset: 0x000E2CF4
		// (set) Token: 0x06009798 RID: 38808 RVA: 0x000E4B2D File Offset: 0x000E2D2D
		public FLGUIDynScrollViewItemSizeDelegate ItemSizeDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDynScrollViewItemSizeDelegate result;
				if ((result = this._ItemSizeDelegate) == null)
				{
					result = (this._ItemSizeDelegate = new FLGUIDynScrollViewItemSizeDelegate(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ItemSizeDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ItemSizeDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x06009799 RID: 38809 RVA: 0x000E4B50 File Offset: 0x000E2D50
		// (set) Token: 0x0600979A RID: 38810 RVA: 0x000E4B89 File Offset: 0x000E2D89
		public FLGUIDynScrollViewItemClearDelegate OnItemClear
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDynScrollViewItemClearDelegate result;
				if ((result = this._OnItemClear) == null)
				{
					result = (this._OnItemClear = new FLGUIDynScrollViewItemClearDelegate(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemClear, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnItemClear, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x0600979B RID: 38811 RVA: 0x000E4BAC File Offset: 0x000E2DAC
		// (set) Token: 0x0600979C RID: 38812 RVA: 0x000E4BE5 File Offset: 0x000E2DE5
		public FLGUILoopScrollViewDelegate OnDestroyCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUILoopScrollViewDelegate result;
				if ((result = this._OnDestroyCallBack) == null)
				{
					result = (this._OnDestroyCallBack = new FLGUILoopScrollViewDelegate(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnDestroyCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_OnDestroyCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x0600979D RID: 38813 RVA: 0x000E4C06 File Offset: 0x000E2E06
		// (set) Token: 0x0600979E RID: 38814 RVA: 0x000E4C16 File Offset: 0x000E2E16
		public unsafe int StartItemIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_StartItemIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_StartItemIndex) = value;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x0600979F RID: 38815 RVA: 0x000E4C27 File Offset: 0x000E2E27
		// (set) Token: 0x060097A0 RID: 38816 RVA: 0x000E4C37 File Offset: 0x000E2E37
		public unsafe int EndItemIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_EndItemIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_EndItemIndex) = value;
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x060097A1 RID: 38817 RVA: 0x000E4C48 File Offset: 0x000E2E48
		// (set) Token: 0x060097A2 RID: 38818 RVA: 0x000E4C81 File Offset: 0x000E2E81
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AUIBaseActor>> DisplayItemArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AUIBaseActor>> result;
				if ((result = this._DisplayItemArray) == null)
				{
					result = (this._DisplayItemArray = new TArray<TWeakObjectPtr<AUIBaseActor>>(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_DisplayItemArray, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.DisplayItemArray.CopyAssign(value);
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x060097A3 RID: 38819 RVA: 0x000E4C90 File Offset: 0x000E2E90
		// (set) Token: 0x060097A4 RID: 38820 RVA: 0x000E4CC9 File Offset: 0x000E2EC9
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AUIBaseActor>> IdleItemArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AUIBaseActor>> result;
				if ((result = this._IdleItemArray) == null)
				{
					result = (this._IdleItemArray = new TArray<TWeakObjectPtr<AUIBaseActor>>(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_IdleItemArray, this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.IdleItemArray.CopyAssign(value);
			}
		}

		// Token: 0x17001C36 RID: 7222
		// (get) Token: 0x060097A5 RID: 38821 RVA: 0x000E4CD8 File Offset: 0x000E2ED8
		// (set) Token: 0x060097A6 RID: 38822 RVA: 0x000E4D11 File Offset: 0x000E2F11
		public TMap<AUIBaseActor, AUIBaseActor> ToUsingItemMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<AUIBaseActor, AUIBaseActor> result;
				if ((result = this._ToUsingItemMap) == null)
				{
					result = (this._ToUsingItemMap = new TMap<AUIBaseActor, AUIBaseActor>(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ToUsingItemMap, this));
				}
				return result;
			}
			set
			{
				this.ToUsingItemMap.CopyAssign(value);
			}
		}

		// Token: 0x17001C37 RID: 7223
		// (get) Token: 0x060097A7 RID: 38823 RVA: 0x000E4D20 File Offset: 0x000E2F20
		// (set) Token: 0x060097A8 RID: 38824 RVA: 0x000E4D59 File Offset: 0x000E2F59
		public TMap<int, EScrollItemState> ItemStateMap
		{
			get
			{
				base.FastCheckIsValid();
				TMap<int, EScrollItemState> result;
				if ((result = this._ItemStateMap) == null)
				{
					result = (this._ItemStateMap = new TMap<int, EScrollItemState>(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_ItemStateMap, this));
				}
				return result;
			}
			set
			{
				this.ItemStateMap.CopyAssign(value);
			}
		}

		// Token: 0x17001C38 RID: 7224
		// (get) Token: 0x060097A9 RID: 38825 RVA: 0x000E4D67 File Offset: 0x000E2F67
		// (set) Token: 0x060097AA RID: 38826 RVA: 0x000E4D77 File Offset: 0x000E2F77
		public unsafe bool IsNavigateScrollFixedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_IsNavigateScrollFixedValue) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDynScrollViewComponent.__PropertyOffset_IsNavigateScrollFixedValue) = (value ? 1 : 0);
			}
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x000E4D88 File Offset: 0x000E2F88
		public void SetScrollItemState(int ItemIndex, EScrollItemState State)
		{
			UUIDynScrollViewComponent.__SetScrollItemState_Internal(base.NativePtr, ItemIndex, State);
		}

		// Token: 0x060097AC RID: 38828 RVA: 0x000E4D97 File Offset: 0x000E2F97
		public void SetInAnimation(bool state)
		{
			UUIDynScrollViewComponent.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x060097AD RID: 38829 RVA: 0x000E4DA5 File Offset: 0x000E2FA5
		public void SetGridAnimationStartTime(float value)
		{
			UUIDynScrollViewComponent.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x060097AE RID: 38830 RVA: 0x000E4DB3 File Offset: 0x000E2FB3
		public void SetGridAnimationInterval(float value)
		{
			UUIDynScrollViewComponent.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x060097AF RID: 38831 RVA: 0x000E4DC1 File Offset: 0x000E2FC1
		[NullableContext(2)]
		public void ScrollToUIItemLater(UUIItem UIItem, bool bScrollToTop = true)
		{
			UUIDynScrollViewComponent.__ScrollToUIItemLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bScrollToTop);
		}

		// Token: 0x060097B0 RID: 38832 RVA: 0x000E4DDF File Offset: 0x000E2FDF
		[NullableContext(2)]
		public void ScrollToUIItem(UUIItem UIItem, bool bScrollToTop = true)
		{
			UUIDynScrollViewComponent.__ScrollToUIItem_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bScrollToTop);
		}

		// Token: 0x060097B1 RID: 38833 RVA: 0x000E4DFD File Offset: 0x000E2FFD
		public void ScrollToStartItemIndexLater(bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToStartItemIndexLater_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x060097B2 RID: 38834 RVA: 0x000E4E0C File Offset: 0x000E300C
		public void ScrollToStartItemIndex(bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToStartItemIndex_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x060097B3 RID: 38835 RVA: 0x000E4E1B File Offset: 0x000E301B
		public void ScrollToOffsetLater(float Offset)
		{
			UUIDynScrollViewComponent.__ScrollToOffsetLater_Internal(base.NativePtr, Offset);
		}

		// Token: 0x060097B4 RID: 38836 RVA: 0x000E4E29 File Offset: 0x000E3029
		public void ScrollToOffset(float Offset)
		{
			UUIDynScrollViewComponent.__ScrollToOffset_Internal(base.NativePtr, Offset);
		}

		// Token: 0x060097B5 RID: 38837 RVA: 0x000E4E37 File Offset: 0x000E3037
		public void ScrollToNextLineLater(bool bReversed = false)
		{
			UUIDynScrollViewComponent.__ScrollToNextLineLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x060097B6 RID: 38838 RVA: 0x000E4E45 File Offset: 0x000E3045
		public void ScrollToNextLine(bool bReversed = false)
		{
			UUIDynScrollViewComponent.__ScrollToNextLine_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x060097B7 RID: 38839 RVA: 0x000E4E53 File Offset: 0x000E3053
		public void ScrollToLastItemLater()
		{
			UUIDynScrollViewComponent.__ScrollToLastItemLater_Internal(base.NativePtr);
		}

		// Token: 0x060097B8 RID: 38840 RVA: 0x000E4E60 File Offset: 0x000E3060
		public void ScrollToLastItem()
		{
			UUIDynScrollViewComponent.__ScrollToLastItem_Internal(base.NativePtr);
		}

		// Token: 0x060097B9 RID: 38841 RVA: 0x000E4E6D File Offset: 0x000E306D
		public void ScrollToItemIndexLater(int ItemIndex, bool bScrollToTop = true, float Offset = 0f, bool bTweenAnim = false)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndexLater_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset, bTweenAnim);
		}

		// Token: 0x060097BA RID: 38842 RVA: 0x000E4E7F File Offset: 0x000E307F
		public void ScrollToItemIndexForNavigation(int ItemIndex, bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndexForNavigation_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset);
		}

		// Token: 0x060097BB RID: 38843 RVA: 0x000E4E8F File Offset: 0x000E308F
		public void ScrollToItemIndex(int ItemIndex, bool bScrollToTop = true, float Offset = 0f, bool bTweenAnim = false)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndex_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset, bTweenAnim);
		}

		// Token: 0x060097BC RID: 38844 RVA: 0x000E4EA1 File Offset: 0x000E30A1
		public void ScrollToEndItemIndexLater(bool bScrollToTop = false, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToEndItemIndexLater_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x060097BD RID: 38845 RVA: 0x000E4EB0 File Offset: 0x000E30B0
		public void ScrollToEndItemIndex(bool bScrollToTop = false, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToEndItemIndex_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x060097BE RID: 38846 RVA: 0x000E4EBF File Offset: 0x000E30BF
		public void ScrollItemIndexLater(bool bReversed)
		{
			UUIDynScrollViewComponent.__ScrollItemIndexLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x060097BF RID: 38847 RVA: 0x000E4ECD File Offset: 0x000E30CD
		public void ScrollItemIndex(bool bReversed)
		{
			UUIDynScrollViewComponent.__ScrollItemIndex_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x060097C0 RID: 38848 RVA: 0x000E4EDB File Offset: 0x000E30DB
		[NullableContext(2)]
		public void RefreshByData(AUIBaseActor Item, int ItemNum, bool KeepContentPosition = false)
		{
			UUIDynScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero, ItemNum, KeepContentPosition);
		}

		// Token: 0x060097C1 RID: 38849 RVA: 0x000E4EFA File Offset: 0x000E30FA
		public void Refresh()
		{
			UUIDynScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x060097C2 RID: 38850 RVA: 0x000E4F07 File Offset: 0x000E3107
		[NullableContext(2)]
		public void NavigateScrollToUIItem(UUIItem UIItem, bool bReversed, UINavigationWrapMode Mode)
		{
			UUIDynScrollViewComponent.__NavigateScrollToUIItem_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bReversed, Mode);
		}

		// Token: 0x060097C3 RID: 38851 RVA: 0x000E4F26 File Offset: 0x000E3126
		public bool IsItemInViewportEdgeByIndex(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__IsItemInViewportEdgeByIndex_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x060097C4 RID: 38852 RVA: 0x000E4F34 File Offset: 0x000E3134
		public bool IsItemInViewportByIndex(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__IsItemInViewportByIndex_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x060097C5 RID: 38853 RVA: 0x000E4F42 File Offset: 0x000E3142
		public bool IsAllItemDisplayed()
		{
			return UUIDynScrollViewComponent.__IsAllItemDisplayed_Internal(base.NativePtr);
		}

		// Token: 0x060097C6 RID: 38854 RVA: 0x000E4F4F File Offset: 0x000E314F
		public bool IsAllDisplayItemUpdateCompleted()
		{
			return UUIDynScrollViewComponent.__IsAllDisplayItemUpdateCompleted_Internal(base.NativePtr);
		}

		// Token: 0x060097C7 RID: 38855 RVA: 0x000E4F5C File Offset: 0x000E315C
		public int GetStartItemIndex()
		{
			return UUIDynScrollViewComponent.__GetStartItemIndex_Internal(base.NativePtr);
		}

		// Token: 0x060097C8 RID: 38856 RVA: 0x000E4F69 File Offset: 0x000E3169
		public EScrollItemState GetScrollItemState(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__GetScrollItemState_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x060097C9 RID: 38857 RVA: 0x000E4F77 File Offset: 0x000E3177
		[NullableContext(2)]
		public AUIBaseActor GetRealUsingItem(int ItemIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIDynScrollViewComponent.__GetRealUsingItem_Internal(base.NativePtr, ItemIndex));
		}

		// Token: 0x060097CA RID: 38858 RVA: 0x000E4F8A File Offset: 0x000E318A
		[NullableContext(2)]
		public FVector GetItemPositionToViewport(UUIItem TargetItem)
		{
			return UUIDynScrollViewComponent.__GetItemPositionToViewport_Internal(base.NativePtr, (TargetItem != null) ? TargetItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097CB RID: 38859 RVA: 0x000E4FA7 File Offset: 0x000E31A7
		[NullableContext(2)]
		public FVector GetItemPositionToContent(UUIItem TargetItem)
		{
			return UUIDynScrollViewComponent.__GetItemPositionToContent_Internal(base.NativePtr, (TargetItem != null) ? TargetItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097CC RID: 38860 RVA: 0x000E4FC4 File Offset: 0x000E31C4
		public unsafe bool GetItemIndex(int DisplayIndex, ref int ItemIndex)
		{
			fixed (int* ptr = &ItemIndex)
			{
				void* ptr2 = (void*)ptr;
				return UUIDynScrollViewComponent.__GetItemIndex_Internal(base.NativePtr, DisplayIndex, ref ItemIndex);
			}
		}

		// Token: 0x060097CD RID: 38861 RVA: 0x000E4FE4 File Offset: 0x000E31E4
		public unsafe bool GetItemDisplayIndex(int ItemIndex, ref int DisplayIndex)
		{
			fixed (int* ptr = &DisplayIndex)
			{
				void* ptr2 = (void*)ptr;
				return UUIDynScrollViewComponent.__GetItemDisplayIndex_Internal(base.NativePtr, ItemIndex, ref DisplayIndex);
			}
		}

		// Token: 0x060097CE RID: 38862 RVA: 0x000E5003 File Offset: 0x000E3203
		[NullableContext(2)]
		public AUIBaseActor GetItem(int ItemIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIDynScrollViewComponent.__GetItem_Internal(base.NativePtr, ItemIndex));
		}

		// Token: 0x060097CF RID: 38863 RVA: 0x000E5016 File Offset: 0x000E3216
		public bool GetInAnimation()
		{
			return UUIDynScrollViewComponent.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x060097D0 RID: 38864 RVA: 0x000E5023 File Offset: 0x000E3223
		public float GetGridAnimationStartTime()
		{
			return UUIDynScrollViewComponent.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x060097D1 RID: 38865 RVA: 0x000E5030 File Offset: 0x000E3230
		public float GetGridAnimationInterval()
		{
			return UUIDynScrollViewComponent.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x060097D2 RID: 38866 RVA: 0x000E503D File Offset: 0x000E323D
		[NullableContext(2)]
		public int GetGridActorIndex(AUIBaseActor InActor)
		{
			return UUIDynScrollViewComponent.__GetGridActorIndex_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060097D3 RID: 38867 RVA: 0x000E505A File Offset: 0x000E325A
		public int GetEndItemIndex()
		{
			return UUIDynScrollViewComponent.__GetEndItemIndex_Internal(base.NativePtr);
		}

		// Token: 0x060097D4 RID: 38868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollItemState_Internal(IntPtr @this, int ItemIndex, EScrollItemState State);

		// Token: 0x060097D5 RID: 38869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x060097D6 RID: 38870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x060097D7 RID: 38871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x060097D8 RID: 38872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToUIItemLater_Internal(IntPtr @this, IntPtr UIItem, bool bScrollToTop);

		// Token: 0x060097D9 RID: 38873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToUIItem_Internal(IntPtr @this, IntPtr UIItem, bool bScrollToTop);

		// Token: 0x060097DA RID: 38874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToStartItemIndexLater_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060097DB RID: 38875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToStartItemIndex_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060097DC RID: 38876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToOffsetLater_Internal(IntPtr @this, float Offset);

		// Token: 0x060097DD RID: 38877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToOffset_Internal(IntPtr @this, float Offset);

		// Token: 0x060097DE RID: 38878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLineLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060097DF RID: 38879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLine_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060097E0 RID: 38880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLastItemLater_Internal(IntPtr @this);

		// Token: 0x060097E1 RID: 38881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLastItem_Internal(IntPtr @this);

		// Token: 0x060097E2 RID: 38882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndexLater_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset, bool bTweenAnim);

		// Token: 0x060097E3 RID: 38883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndexForNavigation_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset);

		// Token: 0x060097E4 RID: 38884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndex_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset, bool bTweenAnim);

		// Token: 0x060097E5 RID: 38885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEndItemIndexLater_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060097E6 RID: 38886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEndItemIndex_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060097E7 RID: 38887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollItemIndexLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060097E8 RID: 38888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollItemIndex_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060097E9 RID: 38889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr Item, int ItemNum, bool KeepContentPosition);

		// Token: 0x060097EA RID: 38890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x060097EB RID: 38891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateScrollToUIItem_Internal(IntPtr @this, IntPtr UIItem, bool bReversed, UINavigationWrapMode Mode);

		// Token: 0x060097EC RID: 38892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsItemInViewportEdgeByIndex_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060097ED RID: 38893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsItemInViewportByIndex_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060097EE RID: 38894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllItemDisplayed_Internal(IntPtr @this);

		// Token: 0x060097EF RID: 38895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllDisplayItemUpdateCompleted_Internal(IntPtr @this);

		// Token: 0x060097F0 RID: 38896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartItemIndex_Internal(IntPtr @this);

		// Token: 0x060097F1 RID: 38897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EScrollItemState __GetScrollItemState_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060097F2 RID: 38898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRealUsingItem_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060097F3 RID: 38899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetItemPositionToViewport_Internal(IntPtr @this, IntPtr TargetItem);

		// Token: 0x060097F4 RID: 38900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetItemPositionToContent_Internal(IntPtr @this, IntPtr TargetItem);

		// Token: 0x060097F5 RID: 38901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemIndex_Internal(IntPtr @this, int DisplayIndex, ref int ItemIndex);

		// Token: 0x060097F6 RID: 38902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemDisplayIndex_Internal(IntPtr @this, int ItemIndex, ref int DisplayIndex);

		// Token: 0x060097F7 RID: 38903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetItem_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060097F8 RID: 38904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x060097F9 RID: 38905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x060097FA RID: 38906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x060097FB RID: 38907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridActorIndex_Internal(IntPtr @this, IntPtr InActor);

		// Token: 0x060097FC RID: 38908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndItemIndex_Internal(IntPtr @this);

		// Token: 0x060097FD RID: 38909 RVA: 0x000E5067 File Offset: 0x000E3267
		static UUIDynScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynScrollViewComponent");
		}

		// Token: 0x060097FE RID: 38910 RVA: 0x000E5075 File Offset: 0x000E3275
		protected UUIDynScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041EA RID: 16874
		public new const string __ObjectPath = "/Script/LGUI.UIDynScrollViewComponent";

		// Token: 0x040041EB RID: 16875
		private static IntPtr _ClassPtr;

		// Token: 0x040041EC RID: 16876
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041ED RID: 16877
		internal static int __PropertyOffset_TemplateItem;

		// Token: 0x040041EE RID: 16878
		internal static int __PropertyOffset_TotalItemNum;

		// Token: 0x040041EF RID: 16879
		internal static int __PropertyOffset_ItemDefaultUIActive;

		// Token: 0x040041F0 RID: 16880
		internal static int __PropertyOffset_SpacingHorizontal;

		// Token: 0x040041F1 RID: 16881
		internal static int __PropertyOffset_SpacingVertical;

		// Token: 0x040041F2 RID: 16882
		internal static int __PropertyOffset_PaddingHorizontal;

		// Token: 0x040041F3 RID: 16883
		internal static int __PropertyOffset_PaddingVertical;

		// Token: 0x040041F4 RID: 16884
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x040041F5 RID: 16885
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x040041F6 RID: 16886
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x040041F7 RID: 16887
		internal static int __PropertyOffset_SizeMatchContent;

		// Token: 0x040041F8 RID: 16888
		internal static int __PropertyOffset_OnItemCreate;

		// Token: 0x040041F9 RID: 16889
		[Nullable(2)]
		private FLGUIDynScrollViewItemCreateDelegate _OnItemCreate;

		// Token: 0x040041FA RID: 16890
		internal static int __PropertyOffset_OnItemUpdate;

		// Token: 0x040041FB RID: 16891
		[Nullable(2)]
		private FLGUIDynScrollViewItemUpdateDelegate _OnItemUpdate;

		// Token: 0x040041FC RID: 16892
		internal static int __PropertyOffset_ItemSizeDelegate;

		// Token: 0x040041FD RID: 16893
		[Nullable(2)]
		private FLGUIDynScrollViewItemSizeDelegate _ItemSizeDelegate;

		// Token: 0x040041FE RID: 16894
		internal static int __PropertyOffset_OnItemClear;

		// Token: 0x040041FF RID: 16895
		[Nullable(2)]
		private FLGUIDynScrollViewItemClearDelegate _OnItemClear;

		// Token: 0x04004200 RID: 16896
		internal static int __PropertyOffset_OnDestroyCallBack;

		// Token: 0x04004201 RID: 16897
		[Nullable(2)]
		private FLGUILoopScrollViewDelegate _OnDestroyCallBack;

		// Token: 0x04004202 RID: 16898
		internal static int __PropertyOffset_StartItemIndex;

		// Token: 0x04004203 RID: 16899
		internal static int __PropertyOffset_EndItemIndex;

		// Token: 0x04004204 RID: 16900
		internal static int __PropertyOffset_DisplayItemArray;

		// Token: 0x04004205 RID: 16901
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _DisplayItemArray;

		// Token: 0x04004206 RID: 16902
		internal static int __PropertyOffset_IdleItemArray;

		// Token: 0x04004207 RID: 16903
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _IdleItemArray;

		// Token: 0x04004208 RID: 16904
		internal static int __PropertyOffset_ToUsingItemMap;

		// Token: 0x04004209 RID: 16905
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AUIBaseActor, AUIBaseActor> _ToUsingItemMap;

		// Token: 0x0400420A RID: 16906
		internal static int __PropertyOffset_ItemStateMap;

		// Token: 0x0400420B RID: 16907
		[Nullable(2)]
		private TMap<int, EScrollItemState> _ItemStateMap;

		// Token: 0x0400420C RID: 16908
		internal static int __PropertyOffset_IsNavigateScrollFixedValue;
	}
}
