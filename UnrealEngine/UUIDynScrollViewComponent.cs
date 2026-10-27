using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002146 RID: 8518
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDynScrollViewComponent")]
	[UnrealStructLayout(1384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1384)]
	public class UUIDynScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject, ILGUIPrefabCheckerInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIGridAnimationInterface
	{
		// Token: 0x06020153 RID: 131411 RVA: 0x002FB65B File Offset: 0x002F985B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDynScrollViewComponent._ClassPtr;
		}

		// Token: 0x06020154 RID: 131412 RVA: 0x002FB667 File Offset: 0x002F9867
		int ILGUIPrefabCheckerInterface.InterfaceOffset()
		{
			return UUIDynScrollViewComponent.__InterfaceOffset_ILGUIPrefabCheckerInterface;
		}

		// Token: 0x06020155 RID: 131413 RVA: 0x002FB66E File Offset: 0x002F986E
		int ILGUIGridAnimationInterface.InterfaceOffset()
		{
			return UUIDynScrollViewComponent.__InterfaceOffset_ILGUIGridAnimationInterface;
		}

		// Token: 0x06020156 RID: 131414 RVA: 0x002FB678 File Offset: 0x002F9878
		public UUIDynScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDynScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020157 RID: 131415 RVA: 0x002FB6A0 File Offset: 0x002F98A0
		public UUIDynScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDynScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E00 RID: 32256
		// (get) Token: 0x06020158 RID: 131416 RVA: 0x002FB6D3 File Offset: 0x002F98D3
		// (set) Token: 0x06020159 RID: 131417 RVA: 0x002FB6E7 File Offset: 0x002F98E7
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

		// Token: 0x17007E01 RID: 32257
		// (get) Token: 0x0602015A RID: 131418 RVA: 0x002FB6FC File Offset: 0x002F98FC
		// (set) Token: 0x0602015B RID: 131419 RVA: 0x002FB70C File Offset: 0x002F990C
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

		// Token: 0x17007E02 RID: 32258
		// (get) Token: 0x0602015C RID: 131420 RVA: 0x002FB71D File Offset: 0x002F991D
		// (set) Token: 0x0602015D RID: 131421 RVA: 0x002FB72D File Offset: 0x002F992D
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

		// Token: 0x17007E03 RID: 32259
		// (get) Token: 0x0602015E RID: 131422 RVA: 0x002FB73E File Offset: 0x002F993E
		// (set) Token: 0x0602015F RID: 131423 RVA: 0x002FB74E File Offset: 0x002F994E
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

		// Token: 0x17007E04 RID: 32260
		// (get) Token: 0x06020160 RID: 131424 RVA: 0x002FB75F File Offset: 0x002F995F
		// (set) Token: 0x06020161 RID: 131425 RVA: 0x002FB76F File Offset: 0x002F996F
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

		// Token: 0x17007E05 RID: 32261
		// (get) Token: 0x06020162 RID: 131426 RVA: 0x002FB780 File Offset: 0x002F9980
		// (set) Token: 0x06020163 RID: 131427 RVA: 0x002FB790 File Offset: 0x002F9990
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

		// Token: 0x17007E06 RID: 32262
		// (get) Token: 0x06020164 RID: 131428 RVA: 0x002FB7A1 File Offset: 0x002F99A1
		// (set) Token: 0x06020165 RID: 131429 RVA: 0x002FB7B1 File Offset: 0x002F99B1
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

		// Token: 0x17007E07 RID: 32263
		// (get) Token: 0x06020166 RID: 131430 RVA: 0x002FB7C2 File Offset: 0x002F99C2
		// (set) Token: 0x06020167 RID: 131431 RVA: 0x002FB7D2 File Offset: 0x002F99D2
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

		// Token: 0x17007E08 RID: 32264
		// (get) Token: 0x06020168 RID: 131432 RVA: 0x002FB7E3 File Offset: 0x002F99E3
		// (set) Token: 0x06020169 RID: 131433 RVA: 0x002FB7F3 File Offset: 0x002F99F3
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

		// Token: 0x17007E09 RID: 32265
		// (get) Token: 0x0602016A RID: 131434 RVA: 0x002FB804 File Offset: 0x002F9A04
		// (set) Token: 0x0602016B RID: 131435 RVA: 0x002FB814 File Offset: 0x002F9A14
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

		// Token: 0x17007E0A RID: 32266
		// (get) Token: 0x0602016C RID: 131436 RVA: 0x002FB825 File Offset: 0x002F9A25
		// (set) Token: 0x0602016D RID: 131437 RVA: 0x002FB835 File Offset: 0x002F9A35
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

		// Token: 0x17007E0B RID: 32267
		// (get) Token: 0x0602016E RID: 131438 RVA: 0x002FB848 File Offset: 0x002F9A48
		// (set) Token: 0x0602016F RID: 131439 RVA: 0x002FB881 File Offset: 0x002F9A81
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

		// Token: 0x17007E0C RID: 32268
		// (get) Token: 0x06020170 RID: 131440 RVA: 0x002FB8A4 File Offset: 0x002F9AA4
		// (set) Token: 0x06020171 RID: 131441 RVA: 0x002FB8DD File Offset: 0x002F9ADD
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

		// Token: 0x17007E0D RID: 32269
		// (get) Token: 0x06020172 RID: 131442 RVA: 0x002FB900 File Offset: 0x002F9B00
		// (set) Token: 0x06020173 RID: 131443 RVA: 0x002FB939 File Offset: 0x002F9B39
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

		// Token: 0x17007E0E RID: 32270
		// (get) Token: 0x06020174 RID: 131444 RVA: 0x002FB95C File Offset: 0x002F9B5C
		// (set) Token: 0x06020175 RID: 131445 RVA: 0x002FB995 File Offset: 0x002F9B95
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

		// Token: 0x17007E0F RID: 32271
		// (get) Token: 0x06020176 RID: 131446 RVA: 0x002FB9B8 File Offset: 0x002F9BB8
		// (set) Token: 0x06020177 RID: 131447 RVA: 0x002FB9F1 File Offset: 0x002F9BF1
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

		// Token: 0x17007E10 RID: 32272
		// (get) Token: 0x06020178 RID: 131448 RVA: 0x002FBA12 File Offset: 0x002F9C12
		// (set) Token: 0x06020179 RID: 131449 RVA: 0x002FBA22 File Offset: 0x002F9C22
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

		// Token: 0x17007E11 RID: 32273
		// (get) Token: 0x0602017A RID: 131450 RVA: 0x002FBA33 File Offset: 0x002F9C33
		// (set) Token: 0x0602017B RID: 131451 RVA: 0x002FBA43 File Offset: 0x002F9C43
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

		// Token: 0x17007E12 RID: 32274
		// (get) Token: 0x0602017C RID: 131452 RVA: 0x002FBA54 File Offset: 0x002F9C54
		// (set) Token: 0x0602017D RID: 131453 RVA: 0x002FBA8D File Offset: 0x002F9C8D
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

		// Token: 0x17007E13 RID: 32275
		// (get) Token: 0x0602017E RID: 131454 RVA: 0x002FBA9C File Offset: 0x002F9C9C
		// (set) Token: 0x0602017F RID: 131455 RVA: 0x002FBAD5 File Offset: 0x002F9CD5
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

		// Token: 0x17007E14 RID: 32276
		// (get) Token: 0x06020180 RID: 131456 RVA: 0x002FBAE4 File Offset: 0x002F9CE4
		// (set) Token: 0x06020181 RID: 131457 RVA: 0x002FBB1D File Offset: 0x002F9D1D
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

		// Token: 0x17007E15 RID: 32277
		// (get) Token: 0x06020182 RID: 131458 RVA: 0x002FBB2C File Offset: 0x002F9D2C
		// (set) Token: 0x06020183 RID: 131459 RVA: 0x002FBB65 File Offset: 0x002F9D65
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

		// Token: 0x17007E16 RID: 32278
		// (get) Token: 0x06020184 RID: 131460 RVA: 0x002FBB73 File Offset: 0x002F9D73
		// (set) Token: 0x06020185 RID: 131461 RVA: 0x002FBB83 File Offset: 0x002F9D83
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

		// Token: 0x06020186 RID: 131462 RVA: 0x002FBB94 File Offset: 0x002F9D94
		public void SetScrollItemState(int ItemIndex, EScrollItemState State)
		{
			UUIDynScrollViewComponent.__SetScrollItemState_Internal(base.NativePtr, ItemIndex, State);
		}

		// Token: 0x06020187 RID: 131463 RVA: 0x002FBBA3 File Offset: 0x002F9DA3
		public void SetInAnimation(bool state)
		{
			UUIDynScrollViewComponent.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x06020188 RID: 131464 RVA: 0x002FBBB1 File Offset: 0x002F9DB1
		public void SetGridAnimationStartTime(float value)
		{
			UUIDynScrollViewComponent.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x06020189 RID: 131465 RVA: 0x002FBBBF File Offset: 0x002F9DBF
		public void SetGridAnimationInterval(float value)
		{
			UUIDynScrollViewComponent.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x0602018A RID: 131466 RVA: 0x002FBBCD File Offset: 0x002F9DCD
		[NullableContext(2)]
		public void ScrollToUIItemLater(UUIItem UIItem, bool bScrollToTop = true)
		{
			UUIDynScrollViewComponent.__ScrollToUIItemLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bScrollToTop);
		}

		// Token: 0x0602018B RID: 131467 RVA: 0x002FBBEB File Offset: 0x002F9DEB
		[NullableContext(2)]
		public void ScrollToUIItem(UUIItem UIItem, bool bScrollToTop = true)
		{
			UUIDynScrollViewComponent.__ScrollToUIItem_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bScrollToTop);
		}

		// Token: 0x0602018C RID: 131468 RVA: 0x002FBC09 File Offset: 0x002F9E09
		public void ScrollToStartItemIndexLater(bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToStartItemIndexLater_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x0602018D RID: 131469 RVA: 0x002FBC18 File Offset: 0x002F9E18
		public void ScrollToStartItemIndex(bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToStartItemIndex_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x0602018E RID: 131470 RVA: 0x002FBC27 File Offset: 0x002F9E27
		public void ScrollToOffsetLater(float Offset)
		{
			UUIDynScrollViewComponent.__ScrollToOffsetLater_Internal(base.NativePtr, Offset);
		}

		// Token: 0x0602018F RID: 131471 RVA: 0x002FBC35 File Offset: 0x002F9E35
		public void ScrollToOffset(float Offset)
		{
			UUIDynScrollViewComponent.__ScrollToOffset_Internal(base.NativePtr, Offset);
		}

		// Token: 0x06020190 RID: 131472 RVA: 0x002FBC43 File Offset: 0x002F9E43
		public void ScrollToNextLineLater(bool bReversed = false)
		{
			UUIDynScrollViewComponent.__ScrollToNextLineLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x06020191 RID: 131473 RVA: 0x002FBC51 File Offset: 0x002F9E51
		public void ScrollToNextLine(bool bReversed = false)
		{
			UUIDynScrollViewComponent.__ScrollToNextLine_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x06020192 RID: 131474 RVA: 0x002FBC5F File Offset: 0x002F9E5F
		public void ScrollToLastItemLater()
		{
			UUIDynScrollViewComponent.__ScrollToLastItemLater_Internal(base.NativePtr);
		}

		// Token: 0x06020193 RID: 131475 RVA: 0x002FBC6C File Offset: 0x002F9E6C
		public void ScrollToLastItem()
		{
			UUIDynScrollViewComponent.__ScrollToLastItem_Internal(base.NativePtr);
		}

		// Token: 0x06020194 RID: 131476 RVA: 0x002FBC79 File Offset: 0x002F9E79
		public void ScrollToItemIndexLater(int ItemIndex, bool bScrollToTop = true, float Offset = 0f, bool bTweenAnim = false)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndexLater_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset, bTweenAnim);
		}

		// Token: 0x06020195 RID: 131477 RVA: 0x002FBC8B File Offset: 0x002F9E8B
		public void ScrollToItemIndexForNavigation(int ItemIndex, bool bScrollToTop = true, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndexForNavigation_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset);
		}

		// Token: 0x06020196 RID: 131478 RVA: 0x002FBC9B File Offset: 0x002F9E9B
		public void ScrollToItemIndex(int ItemIndex, bool bScrollToTop = true, float Offset = 0f, bool bTweenAnim = false)
		{
			UUIDynScrollViewComponent.__ScrollToItemIndex_Internal(base.NativePtr, ItemIndex, bScrollToTop, Offset, bTweenAnim);
		}

		// Token: 0x06020197 RID: 131479 RVA: 0x002FBCAD File Offset: 0x002F9EAD
		public void ScrollToEndItemIndexLater(bool bScrollToTop = false, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToEndItemIndexLater_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x06020198 RID: 131480 RVA: 0x002FBCBC File Offset: 0x002F9EBC
		public void ScrollToEndItemIndex(bool bScrollToTop = false, float Offset = 0f)
		{
			UUIDynScrollViewComponent.__ScrollToEndItemIndex_Internal(base.NativePtr, bScrollToTop, Offset);
		}

		// Token: 0x06020199 RID: 131481 RVA: 0x002FBCCB File Offset: 0x002F9ECB
		public void ScrollItemIndexLater(bool bReversed)
		{
			UUIDynScrollViewComponent.__ScrollItemIndexLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x0602019A RID: 131482 RVA: 0x002FBCD9 File Offset: 0x002F9ED9
		public void ScrollItemIndex(bool bReversed)
		{
			UUIDynScrollViewComponent.__ScrollItemIndex_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x0602019B RID: 131483 RVA: 0x002FBCE7 File Offset: 0x002F9EE7
		[NullableContext(2)]
		public void RefreshByData(AUIBaseActor Item, int ItemNum, bool KeepContentPosition = false)
		{
			UUIDynScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero, ItemNum, KeepContentPosition);
		}

		// Token: 0x0602019C RID: 131484 RVA: 0x002FBD06 File Offset: 0x002F9F06
		public void Refresh()
		{
			UUIDynScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x0602019D RID: 131485 RVA: 0x002FBD13 File Offset: 0x002F9F13
		[NullableContext(2)]
		public void NavigateScrollToUIItem(UUIItem UIItem, bool bReversed, UINavigationWrapMode Mode)
		{
			UUIDynScrollViewComponent.__NavigateScrollToUIItem_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bReversed, Mode);
		}

		// Token: 0x0602019E RID: 131486 RVA: 0x002FBD32 File Offset: 0x002F9F32
		public bool IsItemInViewportEdgeByIndex(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__IsItemInViewportEdgeByIndex_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x0602019F RID: 131487 RVA: 0x002FBD40 File Offset: 0x002F9F40
		public bool IsItemInViewportByIndex(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__IsItemInViewportByIndex_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x060201A0 RID: 131488 RVA: 0x002FBD4E File Offset: 0x002F9F4E
		public bool IsAllItemDisplayed()
		{
			return UUIDynScrollViewComponent.__IsAllItemDisplayed_Internal(base.NativePtr);
		}

		// Token: 0x060201A1 RID: 131489 RVA: 0x002FBD5B File Offset: 0x002F9F5B
		public bool IsAllDisplayItemUpdateCompleted()
		{
			return UUIDynScrollViewComponent.__IsAllDisplayItemUpdateCompleted_Internal(base.NativePtr);
		}

		// Token: 0x060201A2 RID: 131490 RVA: 0x002FBD68 File Offset: 0x002F9F68
		public int GetStartItemIndex()
		{
			return UUIDynScrollViewComponent.__GetStartItemIndex_Internal(base.NativePtr);
		}

		// Token: 0x060201A3 RID: 131491 RVA: 0x002FBD75 File Offset: 0x002F9F75
		public EScrollItemState GetScrollItemState(int ItemIndex)
		{
			return UUIDynScrollViewComponent.__GetScrollItemState_Internal(base.NativePtr, ItemIndex);
		}

		// Token: 0x060201A4 RID: 131492 RVA: 0x002FBD83 File Offset: 0x002F9F83
		[NullableContext(2)]
		public AUIBaseActor GetRealUsingItem(int ItemIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIDynScrollViewComponent.__GetRealUsingItem_Internal(base.NativePtr, ItemIndex));
		}

		// Token: 0x060201A5 RID: 131493 RVA: 0x002FBD96 File Offset: 0x002F9F96
		[NullableContext(2)]
		public FVector GetItemPositionToViewport(UUIItem TargetItem)
		{
			return UUIDynScrollViewComponent.__GetItemPositionToViewport_Internal(base.NativePtr, (TargetItem != null) ? TargetItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060201A6 RID: 131494 RVA: 0x002FBDB3 File Offset: 0x002F9FB3
		[NullableContext(2)]
		public FVector GetItemPositionToContent(UUIItem TargetItem)
		{
			return UUIDynScrollViewComponent.__GetItemPositionToContent_Internal(base.NativePtr, (TargetItem != null) ? TargetItem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060201A7 RID: 131495 RVA: 0x002FBDD0 File Offset: 0x002F9FD0
		public unsafe bool GetItemIndex(int DisplayIndex, ref int ItemIndex)
		{
			fixed (int* ptr = &ItemIndex)
			{
				void* ptr2 = (void*)ptr;
				return UUIDynScrollViewComponent.__GetItemIndex_Internal(base.NativePtr, DisplayIndex, ref ItemIndex);
			}
		}

		// Token: 0x060201A8 RID: 131496 RVA: 0x002FBDF0 File Offset: 0x002F9FF0
		public unsafe bool GetItemDisplayIndex(int ItemIndex, ref int DisplayIndex)
		{
			fixed (int* ptr = &DisplayIndex)
			{
				void* ptr2 = (void*)ptr;
				return UUIDynScrollViewComponent.__GetItemDisplayIndex_Internal(base.NativePtr, ItemIndex, ref DisplayIndex);
			}
		}

		// Token: 0x060201A9 RID: 131497 RVA: 0x002FBE0F File Offset: 0x002FA00F
		[NullableContext(2)]
		public AUIBaseActor GetItem(int ItemIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIDynScrollViewComponent.__GetItem_Internal(base.NativePtr, ItemIndex));
		}

		// Token: 0x060201AA RID: 131498 RVA: 0x002FBE22 File Offset: 0x002FA022
		public bool GetInAnimation()
		{
			return UUIDynScrollViewComponent.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x060201AB RID: 131499 RVA: 0x002FBE2F File Offset: 0x002FA02F
		public float GetGridAnimationStartTime()
		{
			return UUIDynScrollViewComponent.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x060201AC RID: 131500 RVA: 0x002FBE3C File Offset: 0x002FA03C
		public float GetGridAnimationInterval()
		{
			return UUIDynScrollViewComponent.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x060201AD RID: 131501 RVA: 0x002FBE49 File Offset: 0x002FA049
		[NullableContext(2)]
		public int GetGridActorIndex(AUIBaseActor InActor)
		{
			return UUIDynScrollViewComponent.__GetGridActorIndex_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060201AE RID: 131502 RVA: 0x002FBE66 File Offset: 0x002FA066
		public int GetEndItemIndex()
		{
			return UUIDynScrollViewComponent.__GetEndItemIndex_Internal(base.NativePtr);
		}

		// Token: 0x060201AF RID: 131503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollItemState_Internal(IntPtr @this, int ItemIndex, EScrollItemState State);

		// Token: 0x060201B0 RID: 131504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x060201B1 RID: 131505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x060201B2 RID: 131506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x060201B3 RID: 131507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToUIItemLater_Internal(IntPtr @this, IntPtr UIItem, bool bScrollToTop);

		// Token: 0x060201B4 RID: 131508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToUIItem_Internal(IntPtr @this, IntPtr UIItem, bool bScrollToTop);

		// Token: 0x060201B5 RID: 131509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToStartItemIndexLater_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060201B6 RID: 131510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToStartItemIndex_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060201B7 RID: 131511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToOffsetLater_Internal(IntPtr @this, float Offset);

		// Token: 0x060201B8 RID: 131512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToOffset_Internal(IntPtr @this, float Offset);

		// Token: 0x060201B9 RID: 131513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLineLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060201BA RID: 131514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLine_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060201BB RID: 131515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLastItemLater_Internal(IntPtr @this);

		// Token: 0x060201BC RID: 131516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLastItem_Internal(IntPtr @this);

		// Token: 0x060201BD RID: 131517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndexLater_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset, bool bTweenAnim);

		// Token: 0x060201BE RID: 131518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndexForNavigation_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset);

		// Token: 0x060201BF RID: 131519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToItemIndex_Internal(IntPtr @this, int ItemIndex, bool bScrollToTop, float Offset, bool bTweenAnim);

		// Token: 0x060201C0 RID: 131520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEndItemIndexLater_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060201C1 RID: 131521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEndItemIndex_Internal(IntPtr @this, bool bScrollToTop, float Offset);

		// Token: 0x060201C2 RID: 131522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollItemIndexLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060201C3 RID: 131523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollItemIndex_Internal(IntPtr @this, bool bReversed);

		// Token: 0x060201C4 RID: 131524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr Item, int ItemNum, bool KeepContentPosition);

		// Token: 0x060201C5 RID: 131525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x060201C6 RID: 131526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateScrollToUIItem_Internal(IntPtr @this, IntPtr UIItem, bool bReversed, UINavigationWrapMode Mode);

		// Token: 0x060201C7 RID: 131527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsItemInViewportEdgeByIndex_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060201C8 RID: 131528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsItemInViewportByIndex_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060201C9 RID: 131529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllItemDisplayed_Internal(IntPtr @this);

		// Token: 0x060201CA RID: 131530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllDisplayItemUpdateCompleted_Internal(IntPtr @this);

		// Token: 0x060201CB RID: 131531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartItemIndex_Internal(IntPtr @this);

		// Token: 0x060201CC RID: 131532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EScrollItemState __GetScrollItemState_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060201CD RID: 131533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRealUsingItem_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060201CE RID: 131534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetItemPositionToViewport_Internal(IntPtr @this, IntPtr TargetItem);

		// Token: 0x060201CF RID: 131535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetItemPositionToContent_Internal(IntPtr @this, IntPtr TargetItem);

		// Token: 0x060201D0 RID: 131536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemIndex_Internal(IntPtr @this, int DisplayIndex, ref int ItemIndex);

		// Token: 0x060201D1 RID: 131537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetItemDisplayIndex_Internal(IntPtr @this, int ItemIndex, ref int DisplayIndex);

		// Token: 0x060201D2 RID: 131538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetItem_Internal(IntPtr @this, int ItemIndex);

		// Token: 0x060201D3 RID: 131539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x060201D4 RID: 131540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x060201D5 RID: 131541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x060201D6 RID: 131542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridActorIndex_Internal(IntPtr @this, IntPtr InActor);

		// Token: 0x060201D7 RID: 131543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndItemIndex_Internal(IntPtr @this);

		// Token: 0x060201D8 RID: 131544 RVA: 0x002FBE73 File Offset: 0x002FA073
		static UUIDynScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDynScrollViewComponent");
		}

		// Token: 0x060201D9 RID: 131545 RVA: 0x002FBE81 File Offset: 0x002FA081
		protected UUIDynScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011452 RID: 70738
		internal static int __InterfaceOffset_ILGUIPrefabCheckerInterface;

		// Token: 0x04011453 RID: 70739
		internal static int __InterfaceOffset_ILGUIGridAnimationInterface;

		// Token: 0x04011454 RID: 70740
		public new const string __ObjectPath = "/Script/LGUI.UIDynScrollViewComponent";

		// Token: 0x04011455 RID: 70741
		private static IntPtr _ClassPtr;

		// Token: 0x04011456 RID: 70742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011457 RID: 70743
		internal static int __PropertyOffset_TemplateItem;

		// Token: 0x04011458 RID: 70744
		internal static int __PropertyOffset_TotalItemNum;

		// Token: 0x04011459 RID: 70745
		internal static int __PropertyOffset_ItemDefaultUIActive;

		// Token: 0x0401145A RID: 70746
		internal static int __PropertyOffset_SpacingHorizontal;

		// Token: 0x0401145B RID: 70747
		internal static int __PropertyOffset_SpacingVertical;

		// Token: 0x0401145C RID: 70748
		internal static int __PropertyOffset_PaddingHorizontal;

		// Token: 0x0401145D RID: 70749
		internal static int __PropertyOffset_PaddingVertical;

		// Token: 0x0401145E RID: 70750
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x0401145F RID: 70751
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x04011460 RID: 70752
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x04011461 RID: 70753
		internal static int __PropertyOffset_SizeMatchContent;

		// Token: 0x04011462 RID: 70754
		internal static int __PropertyOffset_OnItemCreate;

		// Token: 0x04011463 RID: 70755
		[Nullable(2)]
		private FLGUIDynScrollViewItemCreateDelegate _OnItemCreate;

		// Token: 0x04011464 RID: 70756
		internal static int __PropertyOffset_OnItemUpdate;

		// Token: 0x04011465 RID: 70757
		[Nullable(2)]
		private FLGUIDynScrollViewItemUpdateDelegate _OnItemUpdate;

		// Token: 0x04011466 RID: 70758
		internal static int __PropertyOffset_ItemSizeDelegate;

		// Token: 0x04011467 RID: 70759
		[Nullable(2)]
		private FLGUIDynScrollViewItemSizeDelegate _ItemSizeDelegate;

		// Token: 0x04011468 RID: 70760
		internal static int __PropertyOffset_OnItemClear;

		// Token: 0x04011469 RID: 70761
		[Nullable(2)]
		private FLGUIDynScrollViewItemClearDelegate _OnItemClear;

		// Token: 0x0401146A RID: 70762
		internal static int __PropertyOffset_OnDestroyCallBack;

		// Token: 0x0401146B RID: 70763
		[Nullable(2)]
		private FLGUILoopScrollViewDelegate _OnDestroyCallBack;

		// Token: 0x0401146C RID: 70764
		internal static int __PropertyOffset_StartItemIndex;

		// Token: 0x0401146D RID: 70765
		internal static int __PropertyOffset_EndItemIndex;

		// Token: 0x0401146E RID: 70766
		internal static int __PropertyOffset_DisplayItemArray;

		// Token: 0x0401146F RID: 70767
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _DisplayItemArray;

		// Token: 0x04011470 RID: 70768
		internal static int __PropertyOffset_IdleItemArray;

		// Token: 0x04011471 RID: 70769
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _IdleItemArray;

		// Token: 0x04011472 RID: 70770
		internal static int __PropertyOffset_ToUsingItemMap;

		// Token: 0x04011473 RID: 70771
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<AUIBaseActor, AUIBaseActor> _ToUsingItemMap;

		// Token: 0x04011474 RID: 70772
		internal static int __PropertyOffset_ItemStateMap;

		// Token: 0x04011475 RID: 70773
		[Nullable(2)]
		private TMap<int, EScrollItemState> _ItemStateMap;

		// Token: 0x04011476 RID: 70774
		internal static int __PropertyOffset_IsNavigateScrollFixedValue;
	}
}
