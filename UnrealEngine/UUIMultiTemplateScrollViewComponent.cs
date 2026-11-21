using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000714 RID: 1812
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIMultiTemplateScrollViewComponent")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class UUIMultiTemplateScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009BC2 RID: 39874 RVA: 0x000E8CB2 File Offset: 0x000E6EB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIMultiTemplateScrollViewComponent._ClassPtr;
		}

		// Token: 0x06009BC3 RID: 39875 RVA: 0x000E8CC0 File Offset: 0x000E6EC0
		public UUIMultiTemplateScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009BC4 RID: 39876 RVA: 0x000E8CE8 File Offset: 0x000E6EE8
		public UUIMultiTemplateScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x000E8D1B File Offset: 0x000E6F1B
		// (set) Token: 0x06009BC6 RID: 39878 RVA: 0x000E8D2B File Offset: 0x000E6F2B
		public unsafe float ViewportSizeTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_ViewportSizeTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_ViewportSizeTolerance) = value;
			}
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x000E8D3C File Offset: 0x000E6F3C
		// (set) Token: 0x06009BC8 RID: 39880 RVA: 0x000E8D4C File Offset: 0x000E6F4C
		public unsafe float AreaSpacing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_AreaSpacing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_AreaSpacing) = value;
			}
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06009BC9 RID: 39881 RVA: 0x000E8D5D File Offset: 0x000E6F5D
		// (set) Token: 0x06009BCA RID: 39882 RVA: 0x000E8D71 File Offset: 0x000E6F71
		public unsafe FMargin ContentPadding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_ContentPadding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_ContentPadding) = value;
			}
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06009BCB RID: 39883 RVA: 0x000E8D88 File Offset: 0x000E6F88
		// (set) Token: 0x06009BCC RID: 39884 RVA: 0x000E8DC1 File Offset: 0x000E6FC1
		public FLGUIMultiTemplateScrollViewItemCreateDelegate OnItemCreate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIMultiTemplateScrollViewItemCreateDelegate result;
				if ((result = this._OnItemCreate) == null)
				{
					result = (this._OnItemCreate = new FLGUIMultiTemplateScrollViewItemCreateDelegate(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemCreate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemCreate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06009BCD RID: 39885 RVA: 0x000E8DE4 File Offset: 0x000E6FE4
		// (set) Token: 0x06009BCE RID: 39886 RVA: 0x000E8E1D File Offset: 0x000E701D
		public FLGUIMultiTemplateScrollViewItemRefreshDelegate OnItemRefresh
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIMultiTemplateScrollViewItemRefreshDelegate result;
				if ((result = this._OnItemRefresh) == null)
				{
					result = (this._OnItemRefresh = new FLGUIMultiTemplateScrollViewItemRefreshDelegate(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemRefresh, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemRefresh, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06009BCF RID: 39887 RVA: 0x000E8E40 File Offset: 0x000E7040
		// (set) Token: 0x06009BD0 RID: 39888 RVA: 0x000E8E79 File Offset: 0x000E7079
		public FLGUIMultiTemplateScrollViewItemClearDelegate OnItemClear
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIMultiTemplateScrollViewItemClearDelegate result;
				if ((result = this._OnItemClear) == null)
				{
					result = (this._OnItemClear = new FLGUIMultiTemplateScrollViewItemClearDelegate(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemClear, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnItemClear, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CE7 RID: 7399
		// (get) Token: 0x06009BD1 RID: 39889 RVA: 0x000E8E9C File Offset: 0x000E709C
		// (set) Token: 0x06009BD2 RID: 39890 RVA: 0x000E8ED5 File Offset: 0x000E70D5
		public FLGUIMultiTemplateScrollViewItemNavigableDelegate OnCheckItemNavigable
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIMultiTemplateScrollViewItemNavigableDelegate result;
				if ((result = this._OnCheckItemNavigable) == null)
				{
					result = (this._OnCheckItemNavigable = new FLGUIMultiTemplateScrollViewItemNavigableDelegate(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnCheckItemNavigable, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_OnCheckItemNavigable, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x000E8EF6 File Offset: 0x000E70F6
		public void TryScrollToGridIndex(int GridIndex, bool bScrollToTop)
		{
			UUIMultiTemplateScrollViewComponent.__TryScrollToGridIndex_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x000E8F05 File Offset: 0x000E7105
		public void SetContentPadding(FMargin InContentPadding)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentPadding_Internal(base.NativePtr, InContentPadding);
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x000E8F13 File Offset: 0x000E7113
		public void SetContentOffsetYWhenVertical(float NewOffset, bool bClamp = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetYWhenVertical_Internal(base.NativePtr, NewOffset, bClamp);
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x000E8F22 File Offset: 0x000E7122
		public void SetContentOffsetXWhenHorizontal(float NewOffset, bool bClamp = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetXWhenHorizontal_Internal(base.NativePtr, NewOffset, bClamp);
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x000E8F31 File Offset: 0x000E7131
		public void SetContentOffsetAlignGrid(int GridIndex, bool bClamp = true, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetAlignGrid_Internal(base.NativePtr, GridIndex, bClamp, bScrollToTop);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x000E8F41 File Offset: 0x000E7141
		public void ScrollToGridIndexLater(int GridIndex, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__ScrollToGridIndexLater_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x000E8F50 File Offset: 0x000E7150
		public void ScrollToGridIndex(int GridIndex, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__ScrollToGridIndex_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x000E8F5F File Offset: 0x000E715F
		[NullableContext(2)]
		public void RefreshByData(TArray<int> InTemplateIndexArray, bool KeepContentPosition, int ScrollToItemIndex)
		{
			UUIMultiTemplateScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (InTemplateIndexArray ?? new TArray<int>()).NativePtr, KeepContentPosition, ScrollToItemIndex);
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x000E8F7D File Offset: 0x000E717D
		public void Refresh()
		{
			UUIMultiTemplateScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x000E8F8A File Offset: 0x000E718A
		public bool IsInDisplayRange(int GridIndex, bool OnlyCheckData = true)
		{
			return UUIMultiTemplateScrollViewComponent.__IsInDisplayRange_Internal(base.NativePtr, GridIndex, OnlyCheckData);
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x000E8F99 File Offset: 0x000E7199
		public bool IsAllItemDisplayed()
		{
			return UUIMultiTemplateScrollViewComponent.__IsAllItemDisplayed_Internal(base.NativePtr);
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x000E8FA6 File Offset: 0x000E71A6
		public int GetStartDisplayGridIndex()
		{
			return UUIMultiTemplateScrollViewComponent.__GetStartDisplayGridIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x000E8FB3 File Offset: 0x000E71B3
		[NullableContext(2)]
		public UUISelectableComponent GetNavigationComponentByGridIndex(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUIMultiTemplateScrollViewComponent.__GetNavigationComponentByGridIndex_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x000E8FC6 File Offset: 0x000E71C6
		public float GetLineWidthWhenHorizontal(int InLineIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetLineWidthWhenHorizontal_Internal(base.NativePtr, InLineIndex);
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x000E8FD4 File Offset: 0x000E71D4
		public float GetLineHeightWhenVertical(int InLineIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetLineHeightWhenVertical_Internal(base.NativePtr, InLineIndex);
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x000E8FE2 File Offset: 0x000E71E2
		public int GetGridTemplateIndexInArea(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridTemplateIndexInArea_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x000E8FF0 File Offset: 0x000E71F0
		public FVector2D GetGridSpacingInArea(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridSpacingInArea_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x06009BE4 RID: 39908 RVA: 0x000E8FFE File Offset: 0x000E71FE
		[NullableContext(2)]
		public UUIItem GetGridItemByChildComponent(UUISelectableComponent Component)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIMultiTemplateScrollViewComponent.__GetGridItemByChildComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x000E9020 File Offset: 0x000E7220
		[NullableContext(2)]
		public UUIItem GetGridItem(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIMultiTemplateScrollViewComponent.__GetGridItem_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x000E9033 File Offset: 0x000E7233
		[NullableContext(2)]
		public int GetGridIndexByChildComponent(UUISelectableComponent Component)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridIndexByChildComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009BE7 RID: 39911 RVA: 0x000E9050 File Offset: 0x000E7250
		public int GetEndDisplayGridIndex()
		{
			return UUIMultiTemplateScrollViewComponent.__GetEndDisplayGridIndex_Internal(base.NativePtr);
		}

		// Token: 0x06009BE8 RID: 39912 RVA: 0x000E905D File Offset: 0x000E725D
		public FMargin GetContentPadding()
		{
			return UUIMultiTemplateScrollViewComponent.__GetContentPadding_Internal(base.NativePtr);
		}

		// Token: 0x06009BE9 RID: 39913 RVA: 0x000E906C File Offset: 0x000E726C
		public unsafe void GetAreaSize(int InAreaIndex, ref float OutWidth, ref float OutHeight)
		{
			fixed (float* ptr = &OutWidth)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &OutHeight)
				{
					void* ptr4 = (void*)ptr3;
					UUIMultiTemplateScrollViewComponent.__GetAreaSize_Internal(base.NativePtr, InAreaIndex, ref OutWidth, ref OutHeight);
					ptr = null;
				}
			}
		}

		// Token: 0x06009BEA RID: 39914 RVA: 0x000E9097 File Offset: 0x000E7297
		public FMargin GetAreaPadding(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetAreaPadding_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x06009BEB RID: 39915 RVA: 0x000E90A8 File Offset: 0x000E72A8
		public unsafe void GetAreaGridIndexRange(int InAreaIndex, ref int OutStartGridIndex, ref int OutEndGridIndex)
		{
			fixed (int* ptr = &OutStartGridIndex)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &OutEndGridIndex)
				{
					void* ptr4 = (void*)ptr3;
					UUIMultiTemplateScrollViewComponent.__GetAreaGridIndexRange_Internal(base.NativePtr, InAreaIndex, ref OutStartGridIndex, ref OutEndGridIndex);
					ptr = null;
				}
			}
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x000E90D3 File Offset: 0x000E72D3
		[NullableContext(2)]
		public int FindNavigationIndex(UUISelectableComponent Component, FVector Direction, UINavigationWrapMode WrapMode, UINavigationPriorityMode PriorityMode, float NavigateTolerance, float NavigateToleranceReverse)
		{
			return UUIMultiTemplateScrollViewComponent.__FindNavigationIndex_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, Direction, WrapMode, PriorityMode, NavigateTolerance, NavigateToleranceReverse);
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x000E90F8 File Offset: 0x000E72F8
		public bool CheckScrollViewValid()
		{
			return UUIMultiTemplateScrollViewComponent.__CheckScrollViewValid_Internal(base.NativePtr);
		}

		// Token: 0x06009BEE RID: 39918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x06009BEF RID: 39919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentPadding_Internal(IntPtr @this, FMargin InContentPadding);

		// Token: 0x06009BF0 RID: 39920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetYWhenVertical_Internal(IntPtr @this, float NewOffset, bool bClamp);

		// Token: 0x06009BF1 RID: 39921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetXWhenHorizontal_Internal(IntPtr @this, float NewOffset, bool bClamp);

		// Token: 0x06009BF2 RID: 39922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetAlignGrid_Internal(IntPtr @this, int GridIndex, bool bClamp, bool bScrollToTop);

		// Token: 0x06009BF3 RID: 39923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndexLater_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x06009BF4 RID: 39924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x06009BF5 RID: 39925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr InTemplateIndexArray, bool KeepContentPosition, int ScrollToItemIndex);

		// Token: 0x06009BF6 RID: 39926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x06009BF7 RID: 39927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInDisplayRange_Internal(IntPtr @this, int GridIndex, bool OnlyCheckData);

		// Token: 0x06009BF8 RID: 39928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllItemDisplayed_Internal(IntPtr @this);

		// Token: 0x06009BF9 RID: 39929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartDisplayGridIndex_Internal(IntPtr @this);

		// Token: 0x06009BFA RID: 39930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationComponentByGridIndex_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06009BFB RID: 39931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidthWhenHorizontal_Internal(IntPtr @this, int InLineIndex);

		// Token: 0x06009BFC RID: 39932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineHeightWhenVertical_Internal(IntPtr @this, int InLineIndex);

		// Token: 0x06009BFD RID: 39933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridTemplateIndexInArea_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x06009BFE RID: 39934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetGridSpacingInArea_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x06009BFF RID: 39935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGridItemByChildComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009C00 RID: 39936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGridItem_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06009C01 RID: 39937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridIndexByChildComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009C02 RID: 39938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndDisplayGridIndex_Internal(IntPtr @this);

		// Token: 0x06009C03 RID: 39939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetContentPadding_Internal(IntPtr @this);

		// Token: 0x06009C04 RID: 39940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAreaSize_Internal(IntPtr @this, int InAreaIndex, ref float OutWidth, ref float OutHeight);

		// Token: 0x06009C05 RID: 39941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetAreaPadding_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x06009C06 RID: 39942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAreaGridIndexRange_Internal(IntPtr @this, int InAreaIndex, ref int OutStartGridIndex, ref int OutEndGridIndex);

		// Token: 0x06009C07 RID: 39943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindNavigationIndex_Internal(IntPtr @this, IntPtr Component, FVector Direction, UINavigationWrapMode WrapMode, UINavigationPriorityMode PriorityMode, float NavigateTolerance, float NavigateToleranceReverse);

		// Token: 0x06009C08 RID: 39944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckScrollViewValid_Internal(IntPtr @this);

		// Token: 0x06009C09 RID: 39945 RVA: 0x000E9105 File Offset: 0x000E7305
		static UUIMultiTemplateScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIMultiTemplateScrollViewComponent");
		}

		// Token: 0x06009C0A RID: 39946 RVA: 0x000E9113 File Offset: 0x000E7313
		protected UUIMultiTemplateScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004332 RID: 17202
		public new const string __ObjectPath = "/Script/LGUI.UIMultiTemplateScrollViewComponent";

		// Token: 0x04004333 RID: 17203
		private static IntPtr _ClassPtr;

		// Token: 0x04004334 RID: 17204
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004335 RID: 17205
		internal static int __PropertyOffset_ViewportSizeTolerance;

		// Token: 0x04004336 RID: 17206
		internal static int __PropertyOffset_AreaSpacing;

		// Token: 0x04004337 RID: 17207
		internal static int __PropertyOffset_ContentPadding;

		// Token: 0x04004338 RID: 17208
		internal static int __PropertyOffset_OnItemCreate;

		// Token: 0x04004339 RID: 17209
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemCreateDelegate _OnItemCreate;

		// Token: 0x0400433A RID: 17210
		internal static int __PropertyOffset_OnItemRefresh;

		// Token: 0x0400433B RID: 17211
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemRefreshDelegate _OnItemRefresh;

		// Token: 0x0400433C RID: 17212
		internal static int __PropertyOffset_OnItemClear;

		// Token: 0x0400433D RID: 17213
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemClearDelegate _OnItemClear;

		// Token: 0x0400433E RID: 17214
		internal static int __PropertyOffset_OnCheckItemNavigable;

		// Token: 0x0400433F RID: 17215
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemNavigableDelegate _OnCheckItemNavigable;
	}
}
