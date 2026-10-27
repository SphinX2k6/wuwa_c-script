using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200297F RID: 10623
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.ListView")]
	[UnrealStructLayout(1272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1272)]
	public class UListView : UListViewBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060274CF RID: 160975 RVA: 0x003BECD2 File Offset: 0x003BCED2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UListView._ClassPtr;
		}

		// Token: 0x060274D0 RID: 160976 RVA: 0x003BECE0 File Offset: 0x003BCEE0
		public UListView() : this(BuiltinUtils.AllocNativeUObject(UListView.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060274D1 RID: 160977 RVA: 0x003BED08 File Offset: 0x003BCF08
		public UListView(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UListView.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009715 RID: 38677
		// (get) Token: 0x060274D2 RID: 160978 RVA: 0x003BED3B File Offset: 0x003BCF3B
		// (set) Token: 0x060274D3 RID: 160979 RVA: 0x003BED4F File Offset: 0x003BCF4F
		[Nullable(0)]
		public unsafe TEnumAsByte<EOrientation> Orientation
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_Orientation);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_Orientation) = value;
			}
		}

		// Token: 0x17009716 RID: 38678
		// (get) Token: 0x060274D4 RID: 160980 RVA: 0x003BED64 File Offset: 0x003BCF64
		// (set) Token: 0x060274D5 RID: 160981 RVA: 0x003BED78 File Offset: 0x003BCF78
		[Nullable(0)]
		public unsafe TEnumAsByte<ESelectionMode> SelectionMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UListView.__PropertyOffset_SelectionMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_SelectionMode) = value;
			}
		}

		// Token: 0x17009717 RID: 38679
		// (get) Token: 0x060274D6 RID: 160982 RVA: 0x003BED8D File Offset: 0x003BCF8D
		// (set) Token: 0x060274D7 RID: 160983 RVA: 0x003BED9D File Offset: 0x003BCF9D
		public unsafe EConsumeMouseWheel ConsumeMouseWheel
		{
			get
			{
				return (EConsumeMouseWheel)(*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_ConsumeMouseWheel));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UListView.__PropertyOffset_ConsumeMouseWheel) = (byte)value;
			}
		}

		// Token: 0x17009718 RID: 38680
		// (get) Token: 0x060274D8 RID: 160984 RVA: 0x003BEDAE File Offset: 0x003BCFAE
		// (set) Token: 0x060274D9 RID: 160985 RVA: 0x003BEDBE File Offset: 0x003BCFBE
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

		// Token: 0x17009719 RID: 38681
		// (get) Token: 0x060274DA RID: 160986 RVA: 0x003BEDCF File Offset: 0x003BCFCF
		// (set) Token: 0x060274DB RID: 160987 RVA: 0x003BEDDF File Offset: 0x003BCFDF
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

		// Token: 0x1700971A RID: 38682
		// (get) Token: 0x060274DC RID: 160988 RVA: 0x003BEDF0 File Offset: 0x003BCFF0
		// (set) Token: 0x060274DD RID: 160989 RVA: 0x003BEE00 File Offset: 0x003BD000
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

		// Token: 0x1700971B RID: 38683
		// (get) Token: 0x060274DE RID: 160990 RVA: 0x003BEE11 File Offset: 0x003BD011
		// (set) Token: 0x060274DF RID: 160991 RVA: 0x003BEE21 File Offset: 0x003BD021
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

		// Token: 0x1700971C RID: 38684
		// (get) Token: 0x060274E0 RID: 160992 RVA: 0x003BEE34 File Offset: 0x003BD034
		// (set) Token: 0x060274E1 RID: 160993 RVA: 0x003BEE6D File Offset: 0x003BD06D
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

		// Token: 0x1700971D RID: 38685
		// (get) Token: 0x060274E2 RID: 160994 RVA: 0x003BEE7C File Offset: 0x003BD07C
		// (set) Token: 0x060274E3 RID: 160995 RVA: 0x003BEEB5 File Offset: 0x003BD0B5
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

		// Token: 0x1700971E RID: 38686
		// (get) Token: 0x060274E4 RID: 160996 RVA: 0x003BEED8 File Offset: 0x003BD0D8
		// (set) Token: 0x060274E5 RID: 160997 RVA: 0x003BEF11 File Offset: 0x003BD111
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

		// Token: 0x1700971F RID: 38687
		// (get) Token: 0x060274E6 RID: 160998 RVA: 0x003BEF34 File Offset: 0x003BD134
		// (set) Token: 0x060274E7 RID: 160999 RVA: 0x003BEF6D File Offset: 0x003BD16D
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

		// Token: 0x17009720 RID: 38688
		// (get) Token: 0x060274E8 RID: 161000 RVA: 0x003BEF90 File Offset: 0x003BD190
		// (set) Token: 0x060274E9 RID: 161001 RVA: 0x003BEFC9 File Offset: 0x003BD1C9
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

		// Token: 0x17009721 RID: 38689
		// (get) Token: 0x060274EA RID: 161002 RVA: 0x003BEFEC File Offset: 0x003BD1EC
		// (set) Token: 0x060274EB RID: 161003 RVA: 0x003BF025 File Offset: 0x003BD225
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

		// Token: 0x17009722 RID: 38690
		// (get) Token: 0x060274EC RID: 161004 RVA: 0x003BF048 File Offset: 0x003BD248
		// (set) Token: 0x060274ED RID: 161005 RVA: 0x003BF081 File Offset: 0x003BD281
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

		// Token: 0x060274EE RID: 161006 RVA: 0x003BF0A2 File Offset: 0x003BD2A2
		public void SetSelectionMode(ESelectionMode SelectionMode)
		{
			UListView.__SetSelectionMode_Internal(base.NativePtr, SelectionMode);
		}

		// Token: 0x060274EF RID: 161007 RVA: 0x003BF0B5 File Offset: 0x003BD2B5
		public void SetSelectedIndex(int Index)
		{
			UListView.__SetSelectedIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x060274F0 RID: 161008 RVA: 0x003BF0C3 File Offset: 0x003BD2C3
		public void ScrollIndexIntoView(int Index)
		{
			UListView.__ScrollIndexIntoView_Internal(base.NativePtr, Index);
		}

		// Token: 0x060274F1 RID: 161009 RVA: 0x003BF0D1 File Offset: 0x003BD2D1
		[NullableContext(2)]
		public void RemoveItem(UObject Item)
		{
			UListView.__RemoveItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274F2 RID: 161010 RVA: 0x003BF0EE File Offset: 0x003BD2EE
		public void NavigateToIndex(int Index)
		{
			UListView.__NavigateToIndex_Internal(base.NativePtr, Index);
		}

		// Token: 0x060274F3 RID: 161011 RVA: 0x003BF0FC File Offset: 0x003BD2FC
		public bool IsRefreshPending()
		{
			return UListView.__IsRefreshPending_Internal(base.NativePtr);
		}

		// Token: 0x060274F4 RID: 161012 RVA: 0x003BF109 File Offset: 0x003BD309
		public int GetNumItems()
		{
			return UListView.__GetNumItems_Internal(base.NativePtr);
		}

		// Token: 0x060274F5 RID: 161013 RVA: 0x003BF116 File Offset: 0x003BD316
		public TArray<UObject> GetListItems()
		{
			return new TArray<UObject>(UListView.__GetListItems_Internal(base.NativePtr), null);
		}

		// Token: 0x060274F6 RID: 161014 RVA: 0x003BF129 File Offset: 0x003BD329
		[NullableContext(2)]
		public UObject GetItemAt(int Index)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UListView.__GetItemAt_Internal(base.NativePtr, Index));
		}

		// Token: 0x060274F7 RID: 161015 RVA: 0x003BF13C File Offset: 0x003BD33C
		[NullableContext(2)]
		public int GetIndexForItem(UObject Item)
		{
			return UListView.__GetIndexForItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274F8 RID: 161016 RVA: 0x003BF159 File Offset: 0x003BD359
		public void ClearListItems()
		{
			UListView.__ClearListItems_Internal(base.NativePtr);
		}

		// Token: 0x060274F9 RID: 161017 RVA: 0x003BF166 File Offset: 0x003BD366
		[NullableContext(2)]
		public void BP_SetSelectedItem(UObject Item)
		{
			UListView.__BP_SetSelectedItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274FA RID: 161018 RVA: 0x003BF183 File Offset: 0x003BD383
		public void BP_SetListItems([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<UObject> InListItems)
		{
			UListView.__BP_SetListItems_Internal(base.NativePtr, (InListItems ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x060274FB RID: 161019 RVA: 0x003BF1A0 File Offset: 0x003BD3A0
		[NullableContext(2)]
		public void BP_SetItemSelection(UObject Item, bool bSelected)
		{
			UListView.__BP_SetItemSelection_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero, bSelected);
		}

		// Token: 0x060274FC RID: 161020 RVA: 0x003BF1BE File Offset: 0x003BD3BE
		[NullableContext(2)]
		public void BP_ScrollItemIntoView(UObject Item)
		{
			UListView.__BP_ScrollItemIntoView_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274FD RID: 161021 RVA: 0x003BF1DB File Offset: 0x003BD3DB
		[NullableContext(2)]
		public void BP_NavigateToItem(UObject Item)
		{
			UListView.__BP_NavigateToItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274FE RID: 161022 RVA: 0x003BF1F8 File Offset: 0x003BD3F8
		[NullableContext(2)]
		public bool BP_IsItemVisible(UObject Item)
		{
			return UListView.__BP_IsItemVisible_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060274FF RID: 161023 RVA: 0x003BF215 File Offset: 0x003BD415
		public bool BP_GetSelectedItems([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UObject> Items)
		{
			return UListView.__BP_GetSelectedItems_Internal(base.NativePtr, (Items ?? new TArray<UObject>()).NativePtr);
		}

		// Token: 0x06027500 RID: 161024 RVA: 0x003BF232 File Offset: 0x003BD432
		[NullableContext(2)]
		public UObject BP_GetSelectedItem()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UListView.__BP_GetSelectedItem_Internal(base.NativePtr));
		}

		// Token: 0x06027501 RID: 161025 RVA: 0x003BF244 File Offset: 0x003BD444
		public int BP_GetNumItemsSelected()
		{
			return UListView.__BP_GetNumItemsSelected_Internal(base.NativePtr);
		}

		// Token: 0x06027502 RID: 161026 RVA: 0x003BF251 File Offset: 0x003BD451
		public void BP_ClearSelection()
		{
			UListView.__BP_ClearSelection_Internal(base.NativePtr);
		}

		// Token: 0x06027503 RID: 161027 RVA: 0x003BF25E File Offset: 0x003BD45E
		public void BP_CancelScrollIntoView()
		{
			UListView.__BP_CancelScrollIntoView_Internal(base.NativePtr);
		}

		// Token: 0x06027504 RID: 161028 RVA: 0x003BF26B File Offset: 0x003BD46B
		[NullableContext(2)]
		public void AddItem(UObject Item)
		{
			UListView.__AddItem_Internal(base.NativePtr, (Item != null) ? Item.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027505 RID: 161029
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectionMode_Internal(IntPtr @this, TEnumAsByte<ESelectionMode> SelectionMode);

		// Token: 0x06027506 RID: 161030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectedIndex_Internal(IntPtr @this, int Index);

		// Token: 0x06027507 RID: 161031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollIndexIntoView_Internal(IntPtr @this, int Index);

		// Token: 0x06027508 RID: 161032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x06027509 RID: 161033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NavigateToIndex_Internal(IntPtr @this, int Index);

		// Token: 0x0602750A RID: 161034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsRefreshPending_Internal(IntPtr @this);

		// Token: 0x0602750B RID: 161035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumItems_Internal(IntPtr @this);

		// Token: 0x0602750C RID: 161036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetListItems_Internal(IntPtr @this);

		// Token: 0x0602750D RID: 161037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetItemAt_Internal(IntPtr @this, int Index);

		// Token: 0x0602750E RID: 161038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetIndexForItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0602750F RID: 161039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearListItems_Internal(IntPtr @this);

		// Token: 0x06027510 RID: 161040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetSelectedItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x06027511 RID: 161041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetListItems_Internal(IntPtr @this, IntPtr InListItems);

		// Token: 0x06027512 RID: 161042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_SetItemSelection_Internal(IntPtr @this, IntPtr Item, bool bSelected);

		// Token: 0x06027513 RID: 161043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_ScrollItemIntoView_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x06027514 RID: 161044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_NavigateToItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x06027515 RID: 161045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_IsItemVisible_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x06027516 RID: 161046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __BP_GetSelectedItems_Internal(IntPtr @this, IntPtr Items);

		// Token: 0x06027517 RID: 161047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __BP_GetSelectedItem_Internal(IntPtr @this);

		// Token: 0x06027518 RID: 161048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __BP_GetNumItemsSelected_Internal(IntPtr @this);

		// Token: 0x06027519 RID: 161049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_ClearSelection_Internal(IntPtr @this);

		// Token: 0x0602751A RID: 161050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BP_CancelScrollIntoView_Internal(IntPtr @this);

		// Token: 0x0602751B RID: 161051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddItem_Internal(IntPtr @this, IntPtr Item);

		// Token: 0x0602751C RID: 161052 RVA: 0x003BF288 File Offset: 0x003BD488
		static UListView()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.ListView");
		}

		// Token: 0x0602751D RID: 161053 RVA: 0x003BF296 File Offset: 0x003BD496
		protected UListView(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015962 RID: 88418
		public new const string __ObjectPath = "/Script/UMG.ListView";

		// Token: 0x04015963 RID: 88419
		private static IntPtr _ClassPtr;

		// Token: 0x04015964 RID: 88420
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015965 RID: 88421
		internal static int __PropertyOffset_Orientation;

		// Token: 0x04015966 RID: 88422
		internal static int __PropertyOffset_SelectionMode;

		// Token: 0x04015967 RID: 88423
		internal static int __PropertyOffset_ConsumeMouseWheel;

		// Token: 0x04015968 RID: 88424
		internal static int __PropertyOffset_bClearSelectionOnClick;

		// Token: 0x04015969 RID: 88425
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x0401596A RID: 88426
		internal static int __PropertyOffset_EntrySpacing;

		// Token: 0x0401596B RID: 88427
		internal static int __PropertyOffset_bReturnFocusToSelection;

		// Token: 0x0401596C RID: 88428
		internal static int __PropertyOffset_ListItems;

		// Token: 0x0401596D RID: 88429
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UObject> _ListItems;

		// Token: 0x0401596E RID: 88430
		internal static int __PropertyOffset_BP_OnEntryInitialized;

		// Token: 0x0401596F RID: 88431
		[Nullable(2)]
		private FOnListEntryInitializedDynamic _BP_OnEntryInitialized;

		// Token: 0x04015970 RID: 88432
		internal static int __PropertyOffset_BP_OnItemClicked;

		// Token: 0x04015971 RID: 88433
		[Nullable(2)]
		private FSimpleListItemEventDynamic _BP_OnItemClicked;

		// Token: 0x04015972 RID: 88434
		internal static int __PropertyOffset_BP_OnItemDoubleClicked;

		// Token: 0x04015973 RID: 88435
		[Nullable(2)]
		private FSimpleListItemEventDynamic _BP_OnItemDoubleClicked;

		// Token: 0x04015974 RID: 88436
		internal static int __PropertyOffset_BP_OnItemIsHoveredChanged;

		// Token: 0x04015975 RID: 88437
		[Nullable(2)]
		private FOnItemIsHoveredChangedDynamic _BP_OnItemIsHoveredChanged;

		// Token: 0x04015976 RID: 88438
		internal static int __PropertyOffset_BP_OnItemSelectionChanged;

		// Token: 0x04015977 RID: 88439
		[Nullable(2)]
		private FOnListItemSelectionChangedDynamic _BP_OnItemSelectionChanged;

		// Token: 0x04015978 RID: 88440
		internal static int __PropertyOffset_BP_OnItemScrolledIntoView;

		// Token: 0x04015979 RID: 88441
		[Nullable(2)]
		private FOnListItemScrolledIntoViewDynamic _BP_OnItemScrolledIntoView;
	}
}
