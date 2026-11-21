using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000861 RID: 2145
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ListView")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class UListView : UListViewBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BA6D RID: 47725 RVA: 0x0012A99B File Offset: 0x00128B9B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UListView._ClassPtr;
		}

		// Token: 0x0600BA6E RID: 47726 RVA: 0x0012A9A8 File Offset: 0x00128BA8
		public UListView() : this(BuiltinUtils.AllocNativeUObject(UListView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BA6F RID: 47727 RVA: 0x0012A9D0 File Offset: 0x00128BD0
		public UListView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UListView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170022A0 RID: 8864
		// (get) Token: 0x0600BA70 RID: 47728 RVA: 0x0012AA03 File Offset: 0x00128C03
		// (set) Token: 0x0600BA71 RID: 47729 RVA: 0x0012AA13 File Offset: 0x00128C13
		public unsafe bool bClearSelectionOnClick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bClearSelectionOnClick) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bClearSelectionOnClick) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022A1 RID: 8865
		// (get) Token: 0x0600BA72 RID: 47730 RVA: 0x0012AA24 File Offset: 0x00128C24
		// (set) Token: 0x0600BA73 RID: 47731 RVA: 0x0012AA34 File Offset: 0x00128C34
		public unsafe bool bIsFocusable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bIsFocusable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bIsFocusable) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022A2 RID: 8866
		// (get) Token: 0x0600BA74 RID: 47732 RVA: 0x0012AA45 File Offset: 0x00128C45
		// (set) Token: 0x0600BA75 RID: 47733 RVA: 0x0012AA55 File Offset: 0x00128C55
		public unsafe float EntrySpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_EntrySpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_EntrySpacing) = value;
			}
		}

		// Token: 0x170022A3 RID: 8867
		// (get) Token: 0x0600BA76 RID: 47734 RVA: 0x0012AA66 File Offset: 0x00128C66
		// (set) Token: 0x0600BA77 RID: 47735 RVA: 0x0012AA76 File Offset: 0x00128C76
		public unsafe bool bReturnFocusToSelection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bReturnFocusToSelection) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_bReturnFocusToSelection) = (value ? 1 : 0);
			}
		}

		// Token: 0x170022A4 RID: 8868
		// (get) Token: 0x0600BA78 RID: 47736 RVA: 0x0012AA88 File Offset: 0x00128C88
		// (set) Token: 0x0600BA79 RID: 47737 RVA: 0x0012AAC1 File Offset: 0x00128CC1
		public TArray<UObject> ListItems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UObject> result;
				if ((result = this._ListItems) == null)
				{
					result = (this._ListItems = new TArray<UObject>(base.NativePtr + (IntPtr)UListView.__PropertyOffset_ListItems, this));
				}
				return result;
			}
			set
			{
				this.ListItems.CopyAssign(value);
			}
		}

		// Token: 0x170022A5 RID: 8869
		// (get) Token: 0x0600BA7A RID: 47738 RVA: 0x0012AAD0 File Offset: 0x00128CD0
		// (set) Token: 0x0600BA7B RID: 47739 RVA: 0x0012AB09 File Offset: 0x00128D09
		public FOnListEntryInitializedDynamic BP_OnEntryInitialized
		{
			get
			{
				base.FastCheckIsValid();
				FOnListEntryInitializedDynamic result;
				if ((result = this._BP_OnEntryInitialized) == null)
				{
					result = (this._BP_OnEntryInitialized = new FOnListEntryInitializedDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnEntryInitialized, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnEntryInitialized, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022A6 RID: 8870
		// (get) Token: 0x0600BA7C RID: 47740 RVA: 0x0012AB2C File Offset: 0x00128D2C
		// (set) Token: 0x0600BA7D RID: 47741 RVA: 0x0012AB65 File Offset: 0x00128D65
		public FSimpleListItemEventDynamic BP_OnItemClicked
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleListItemEventDynamic result;
				if ((result = this._BP_OnItemClicked) == null)
				{
					result = (this._BP_OnItemClicked = new FSimpleListItemEventDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022A7 RID: 8871
		// (get) Token: 0x0600BA7E RID: 47742 RVA: 0x0012AB88 File Offset: 0x00128D88
		// (set) Token: 0x0600BA7F RID: 47743 RVA: 0x0012ABC1 File Offset: 0x00128DC1
		public FSimpleListItemEventDynamic BP_OnItemDoubleClicked
		{
			get
			{
				base.FastCheckIsValid();
				FSimpleListItemEventDynamic result;
				if ((result = this._BP_OnItemDoubleClicked) == null)
				{
					result = (this._BP_OnItemDoubleClicked = new FSimpleListItemEventDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemDoubleClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemDoubleClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022A8 RID: 8872
		// (get) Token: 0x0600BA80 RID: 47744 RVA: 0x0012ABE4 File Offset: 0x00128DE4
		// (set) Token: 0x0600BA81 RID: 47745 RVA: 0x0012AC1D File Offset: 0x00128E1D
		public FOnItemIsHoveredChangedDynamic BP_OnItemIsHoveredChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnItemIsHoveredChangedDynamic result;
				if ((result = this._BP_OnItemIsHoveredChanged) == null)
				{
					result = (this._BP_OnItemIsHoveredChanged = new FOnItemIsHoveredChangedDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemIsHoveredChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemIsHoveredChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022A9 RID: 8873
		// (get) Token: 0x0600BA82 RID: 47746 RVA: 0x0012AC40 File Offset: 0x00128E40
		// (set) Token: 0x0600BA83 RID: 47747 RVA: 0x0012AC79 File Offset: 0x00128E79
		public FOnListItemSelectionChangedDynamic BP_OnItemSelectionChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnListItemSelectionChangedDynamic result;
				if ((result = this._BP_OnItemSelectionChanged) == null)
				{
					result = (this._BP_OnItemSelectionChanged = new FOnListItemSelectionChangedDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemSelectionChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemSelectionChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022AA RID: 8874
		// (get) Token: 0x0600BA84 RID: 47748 RVA: 0x0012AC9C File Offset: 0x00128E9C
		// (set) Token: 0x0600BA85 RID: 47749 RVA: 0x0012ACD5 File Offset: 0x00128ED5
		public FOnListItemScrolledIntoViewDynamic BP_OnItemScrolledIntoView
		{
			get
			{
				base.FastCheckIsValid();
				FOnListItemScrolledIntoViewDynamic result;
				if ((result = this._BP_OnItemScrolledIntoView) == null)
				{
					result = (this._BP_OnItemScrolledIntoView = new FOnListItemScrolledIntoViewDynamic(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemScrolledIntoView, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UListView.__PropertyOffset_BP_OnItemScrolledIntoView, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600BA86 RID: 47750 RVA: 0x0012ACF6 File Offset: 0x00128EF6
		public void SetSelectedIndex(int Index)
		{
			UListView.__SetSelectedIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600BA87 RID: 47751 RVA: 0x0012AD04 File Offset: 0x00128F04
		public void ScrollIndexIntoView(int Index)
		{
			UListView.__ScrollIndexIntoView_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600BA88 RID: 47752 RVA: 0x0012AD12 File Offset: 0x00128F12
		[NullableContext(2)]
		public void RemoveItem(UObject Item)
		{
			UListView.__RemoveItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x0012AD2F File Offset: 0x00128F2F
		public void NavigateToIndex(int Index)
		{
			UListView.__NavigateToIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x0012AD3D File Offset: 0x00128F3D
		public bool IsRefreshPending()
		{
			return UListView.__IsRefreshPending_Internal(base.NativePtr);
		}

		// Token: 0x0600BA8B RID: 47755 RVA: 0x0012AD4A File Offset: 0x00128F4A
		public int GetNumItems()
		{
			return UListView.__GetNumItems_Internal(base.NativePtr);
		}

		// Token: 0x0600BA8C RID: 47756 RVA: 0x0012AD57 File Offset: 0x00128F57
		public TArray<UObject> GetListItems()
		{
			return new TArray<UObject>(UListView.__GetListItems_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BA8D RID: 47757 RVA: 0x0012AD6A File Offset: 0x00128F6A
		[NullableContext(2)]
		public UObject GetItemAt(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UListView.__GetItemAt_Internal(base.NativePtr, Index));
		}

		// Token: 0x0600BA8E RID: 47758 RVA: 0x0012AD7D File Offset: 0x00128F7D
		[NullableContext(2)]
		public int GetIndexForItem(UObject Item)
		{
			return UListView.__GetIndexForItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA8F RID: 47759 RVA: 0x0012AD9A File Offset: 0x00128F9A
		public void ClearListItems()
		{
			UListView.__ClearListItems_Internal(base.NativePtr);
		}

		// Token: 0x0600BA90 RID: 47760 RVA: 0x0012ADA7 File Offset: 0x00128FA7
		[NullableContext(2)]
		public void BP_SetSelectedItem(UObject Item)
		{
			UListView.__BP_SetSelectedItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA91 RID: 47761 RVA: 0x0012ADC4 File Offset: 0x00128FC4
		public void BP_SetListItems([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> InListItems)
		{
			UListView.__BP_SetListItems_Internal(base.NativePtr, (InListItems ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x0600BA92 RID: 47762 RVA: 0x0012ADE1 File Offset: 0x00128FE1
		[NullableContext(2)]
		public void BP_SetItemSelection(UObject Item, bool bSelected)
		{
			UListView.__BP_SetItemSelection_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero, bSelected);
		}

		// Token: 0x0600BA93 RID: 47763 RVA: 0x0012ADFF File Offset: 0x00128FFF
		[NullableContext(2)]
		public void BP_ScrollItemIntoView(UObject Item)
		{
			UListView.__BP_ScrollItemIntoView_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA94 RID: 47764 RVA: 0x0012AE1C File Offset: 0x0012901C
		[NullableContext(2)]
		public void BP_NavigateToItem(UObject Item)
		{
			UListView.__BP_NavigateToItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA95 RID: 47765 RVA: 0x0012AE39 File Offset: 0x00129039
		[NullableContext(2)]
		public bool BP_IsItemVisible(UObject Item)
		{
			return UListView.__BP_IsItemVisible_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA96 RID: 47766 RVA: 0x0012AE56 File Offset: 0x00129056
		public bool BP_GetSelectedItems([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> Items)
		{
			return UListView.__BP_GetSelectedItems_Internal(base.NativePtr, (Items ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x0600BA97 RID: 47767 RVA: 0x0012AE73 File Offset: 0x00129073
		[NullableContext(2)]
		public UObject BP_GetSelectedItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UListView.__BP_GetSelectedItem_Internal(base.NativePtr));
		}

		// Token: 0x0600BA98 RID: 47768 RVA: 0x0012AE85 File Offset: 0x00129085
		public int BP_GetNumItemsSelected()
		{
			return UListView.__BP_GetNumItemsSelected_Internal(base.NativePtr);
		}

		// Token: 0x0600BA99 RID: 47769 RVA: 0x0012AE92 File Offset: 0x00129092
		public void BP_ClearSelection()
		{
			UListView.__BP_ClearSelection_Internal(base.NativePtr);
		}

		// Token: 0x0600BA9A RID: 47770 RVA: 0x0012AE9F File Offset: 0x0012909F
		public void BP_CancelScrollIntoView()
		{
			UListView.__BP_CancelScrollIntoView_Internal(base.NativePtr);
		}

		// Token: 0x0600BA9B RID: 47771 RVA: 0x0012AEAC File Offset: 0x001290AC
		[NullableContext(2)]
		public void AddItem(UObject Item)
		{
			UListView.__AddItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BA9C RID: 47772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0600BA9D RID: 47773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollIndexIntoView_Internal(IntPtr @this, int Index);

		// Token: 0x0600BA9E RID: 47774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BA9F RID: 47775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateToIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0600BAA0 RID: 47776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRefreshPending_Internal(IntPtr @this);

		// Token: 0x0600BAA1 RID: 47777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumItems_Internal(IntPtr @this);

		// Token: 0x0600BAA2 RID: 47778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetListItems_Internal(IntPtr @this);

		// Token: 0x0600BAA3 RID: 47779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetItemAt_Internal(IntPtr @this, int Index);

		// Token: 0x0600BAA4 RID: 47780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIndexForItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAA5 RID: 47781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearListItems_Internal(IntPtr @this);

		// Token: 0x0600BAA6 RID: 47782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetSelectedItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAA7 RID: 47783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetListItems_Internal(IntPtr @this, IntPtr InListItems);

		// Token: 0x0600BAA8 RID: 47784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetItemSelection_Internal(IntPtr @this, IntPtr Item, bool bSelected);

		// Token: 0x0600BAA9 RID: 47785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_ScrollItemIntoView_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAAA RID: 47786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_NavigateToItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAAB RID: 47787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_IsItemVisible_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAAC RID: 47788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_GetSelectedItems_Internal(IntPtr @this, IntPtr Items);

		// Token: 0x0600BAAD RID: 47789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_GetSelectedItem_Internal(IntPtr @this);

		// Token: 0x0600BAAE RID: 47790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __BP_GetNumItemsSelected_Internal(IntPtr @this);

		// Token: 0x0600BAAF RID: 47791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_ClearSelection_Internal(IntPtr @this);

		// Token: 0x0600BAB0 RID: 47792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_CancelScrollIntoView_Internal(IntPtr @this);

		// Token: 0x0600BAB1 RID: 47793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0600BAB2 RID: 47794 RVA: 0x0012AEC9 File Offset: 0x001290C9
		static UListView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ListView");
		}

		// Token: 0x0600BAB3 RID: 47795 RVA: 0x0012AED7 File Offset: 0x001290D7
		protected UListView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005493 RID: 21651
		public new const string __ObjectPath = "/Script/UMG.ListView";

		// Token: 0x04005494 RID: 21652
		private static IntPtr _ClassPtr;

		// Token: 0x04005495 RID: 21653
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005496 RID: 21654
		internal static int __PropertyOffset_bClearSelectionOnClick;

		// Token: 0x04005497 RID: 21655
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x04005498 RID: 21656
		internal static int __PropertyOffset_EntrySpacing;

		// Token: 0x04005499 RID: 21657
		internal static int __PropertyOffset_bReturnFocusToSelection;

		// Token: 0x0400549A RID: 21658
		internal static int __PropertyOffset_ListItems;

		// Token: 0x0400549B RID: 21659
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ListItems;

		// Token: 0x0400549C RID: 21660
		internal static int __PropertyOffset_BP_OnEntryInitialized;

		// Token: 0x0400549D RID: 21661
		[Nullable(2)]
		private FOnListEntryInitializedDynamic _BP_OnEntryInitialized;

		// Token: 0x0400549E RID: 21662
		internal static int __PropertyOffset_BP_OnItemClicked;

		// Token: 0x0400549F RID: 21663
		[Nullable(2)]
		private FSimpleListItemEventDynamic _BP_OnItemClicked;

		// Token: 0x040054A0 RID: 21664
		internal static int __PropertyOffset_BP_OnItemDoubleClicked;

		// Token: 0x040054A1 RID: 21665
		[Nullable(2)]
		private FSimpleListItemEventDynamic _BP_OnItemDoubleClicked;

		// Token: 0x040054A2 RID: 21666
		internal static int __PropertyOffset_BP_OnItemIsHoveredChanged;

		// Token: 0x040054A3 RID: 21667
		[Nullable(2)]
		private FOnItemIsHoveredChangedDynamic _BP_OnItemIsHoveredChanged;

		// Token: 0x040054A4 RID: 21668
		internal static int __PropertyOffset_BP_OnItemSelectionChanged;

		// Token: 0x040054A5 RID: 21669
		[Nullable(2)]
		private FOnListItemSelectionChangedDynamic _BP_OnItemSelectionChanged;

		// Token: 0x040054A6 RID: 21670
		internal static int __PropertyOffset_BP_OnItemScrolledIntoView;

		// Token: 0x040054A7 RID: 21671
		[Nullable(2)]
		private FOnListItemScrolledIntoViewDynamic _BP_OnItemScrolledIntoView;
	}
}
