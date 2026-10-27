using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002188 RID: 8584
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIMultiTemplateScrollViewComponent")]
	[UnrealStructLayout(1200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1200)]
	public class UUIMultiTemplateScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602085A RID: 133210 RVA: 0x00302BD6 File Offset: 0x00300DD6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIMultiTemplateScrollViewComponent._ClassPtr;
		}

		// Token: 0x0602085B RID: 133211 RVA: 0x00302BE4 File Offset: 0x00300DE4
		public UUIMultiTemplateScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602085C RID: 133212 RVA: 0x00302C0C File Offset: 0x00300E0C
		public UUIMultiTemplateScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIMultiTemplateScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F3A RID: 32570
		// (get) Token: 0x0602085D RID: 133213 RVA: 0x00302C40 File Offset: 0x00300E40
		// (set) Token: 0x0602085E RID: 133214 RVA: 0x00302C79 File Offset: 0x00300E79
		public TArray<FMultiTemplateScrollViewTemplateInfo> TemplateInfoArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FMultiTemplateScrollViewTemplateInfo> result;
				if ((result = this._TemplateInfoArray) == null)
				{
					result = (this._TemplateInfoArray = new TArray<FMultiTemplateScrollViewTemplateInfo>(base.NativePtr + (IntPtr)UUIMultiTemplateScrollViewComponent.__PropertyOffset_TemplateInfoArray, this));
				}
				return result;
			}
			set
			{
				this.TemplateInfoArray.CopyAssign(value);
			}
		}

		// Token: 0x17007F3B RID: 32571
		// (get) Token: 0x0602085F RID: 133215 RVA: 0x00302C87 File Offset: 0x00300E87
		// (set) Token: 0x06020860 RID: 133216 RVA: 0x00302C97 File Offset: 0x00300E97
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

		// Token: 0x17007F3C RID: 32572
		// (get) Token: 0x06020861 RID: 133217 RVA: 0x00302CA8 File Offset: 0x00300EA8
		// (set) Token: 0x06020862 RID: 133218 RVA: 0x00302CB8 File Offset: 0x00300EB8
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

		// Token: 0x17007F3D RID: 32573
		// (get) Token: 0x06020863 RID: 133219 RVA: 0x00302CC9 File Offset: 0x00300EC9
		// (set) Token: 0x06020864 RID: 133220 RVA: 0x00302CDD File Offset: 0x00300EDD
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

		// Token: 0x17007F3E RID: 32574
		// (get) Token: 0x06020865 RID: 133221 RVA: 0x00302CF4 File Offset: 0x00300EF4
		// (set) Token: 0x06020866 RID: 133222 RVA: 0x00302D2D File Offset: 0x00300F2D
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

		// Token: 0x17007F3F RID: 32575
		// (get) Token: 0x06020867 RID: 133223 RVA: 0x00302D50 File Offset: 0x00300F50
		// (set) Token: 0x06020868 RID: 133224 RVA: 0x00302D89 File Offset: 0x00300F89
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

		// Token: 0x17007F40 RID: 32576
		// (get) Token: 0x06020869 RID: 133225 RVA: 0x00302DAC File Offset: 0x00300FAC
		// (set) Token: 0x0602086A RID: 133226 RVA: 0x00302DE5 File Offset: 0x00300FE5
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

		// Token: 0x17007F41 RID: 32577
		// (get) Token: 0x0602086B RID: 133227 RVA: 0x00302E08 File Offset: 0x00301008
		// (set) Token: 0x0602086C RID: 133228 RVA: 0x00302E41 File Offset: 0x00301041
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

		// Token: 0x0602086D RID: 133229 RVA: 0x00302E62 File Offset: 0x00301062
		public void TryScrollToGridIndex(int GridIndex, bool bScrollToTop)
		{
			UUIMultiTemplateScrollViewComponent.__TryScrollToGridIndex_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x0602086E RID: 133230 RVA: 0x00302E71 File Offset: 0x00301071
		public void SetContentPadding(FMargin InContentPadding)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentPadding_Internal(base.NativePtr, InContentPadding);
		}

		// Token: 0x0602086F RID: 133231 RVA: 0x00302E7F File Offset: 0x0030107F
		public void SetContentOffsetYWhenVertical(float NewOffset, bool bClamp = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetYWhenVertical_Internal(base.NativePtr, NewOffset, bClamp);
		}

		// Token: 0x06020870 RID: 133232 RVA: 0x00302E8E File Offset: 0x0030108E
		public void SetContentOffsetXWhenHorizontal(float NewOffset, bool bClamp = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetXWhenHorizontal_Internal(base.NativePtr, NewOffset, bClamp);
		}

		// Token: 0x06020871 RID: 133233 RVA: 0x00302E9D File Offset: 0x0030109D
		public void SetContentOffsetAlignGrid(int GridIndex, bool bClamp = true, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__SetContentOffsetAlignGrid_Internal(base.NativePtr, GridIndex, bClamp, bScrollToTop);
		}

		// Token: 0x06020872 RID: 133234 RVA: 0x00302EAD File Offset: 0x003010AD
		public void ScrollToGridIndexLater(int GridIndex, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__ScrollToGridIndexLater_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x06020873 RID: 133235 RVA: 0x00302EBC File Offset: 0x003010BC
		public void ScrollToGridIndex(int GridIndex, bool bScrollToTop = true)
		{
			UUIMultiTemplateScrollViewComponent.__ScrollToGridIndex_Internal(base.NativePtr, GridIndex, bScrollToTop);
		}

		// Token: 0x06020874 RID: 133236 RVA: 0x00302ECB File Offset: 0x003010CB
		[NullableContext(2)]
		public void RefreshByData(TArray<int> InTemplateIndexArray, bool KeepContentPosition, int ScrollToItemIndex)
		{
			UUIMultiTemplateScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (InTemplateIndexArray ?? new TArray<int>()).NativePtr, KeepContentPosition, ScrollToItemIndex);
		}

		// Token: 0x06020875 RID: 133237 RVA: 0x00302EE9 File Offset: 0x003010E9
		public void Refresh()
		{
			UUIMultiTemplateScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x06020876 RID: 133238 RVA: 0x00302EF6 File Offset: 0x003010F6
		public bool IsInDisplayRange(int GridIndex, bool OnlyCheckData = true)
		{
			return UUIMultiTemplateScrollViewComponent.__IsInDisplayRange_Internal(base.NativePtr, GridIndex, OnlyCheckData);
		}

		// Token: 0x06020877 RID: 133239 RVA: 0x00302F05 File Offset: 0x00301105
		public bool IsAllItemDisplayed()
		{
			return UUIMultiTemplateScrollViewComponent.__IsAllItemDisplayed_Internal(base.NativePtr);
		}

		// Token: 0x06020878 RID: 133240 RVA: 0x00302F12 File Offset: 0x00301112
		public int GetStartDisplayGridIndex()
		{
			return UUIMultiTemplateScrollViewComponent.__GetStartDisplayGridIndex_Internal(base.NativePtr);
		}

		// Token: 0x06020879 RID: 133241 RVA: 0x00302F1F File Offset: 0x0030111F
		[NullableContext(2)]
		public UUISelectableComponent GetNavigationComponentByGridIndex(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUIMultiTemplateScrollViewComponent.__GetNavigationComponentByGridIndex_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x0602087A RID: 133242 RVA: 0x00302F32 File Offset: 0x00301132
		public float GetLineWidthWhenHorizontal(int InLineIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetLineWidthWhenHorizontal_Internal(base.NativePtr, InLineIndex);
		}

		// Token: 0x0602087B RID: 133243 RVA: 0x00302F40 File Offset: 0x00301140
		public float GetLineHeightWhenVertical(int InLineIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetLineHeightWhenVertical_Internal(base.NativePtr, InLineIndex);
		}

		// Token: 0x0602087C RID: 133244 RVA: 0x00302F4E File Offset: 0x0030114E
		public int GetGridTemplateIndexInArea(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridTemplateIndexInArea_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x0602087D RID: 133245 RVA: 0x00302F5C File Offset: 0x0030115C
		public FVector2D GetGridSpacingInArea(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridSpacingInArea_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x0602087E RID: 133246 RVA: 0x00302F6A File Offset: 0x0030116A
		[NullableContext(2)]
		public UUIItem GetGridItemByChildComponent(UUISelectableComponent Component)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIMultiTemplateScrollViewComponent.__GetGridItemByChildComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0602087F RID: 133247 RVA: 0x00302F8C File Offset: 0x0030118C
		[NullableContext(2)]
		public UUIItem GetGridItem(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(UUIMultiTemplateScrollViewComponent.__GetGridItem_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x06020880 RID: 133248 RVA: 0x00302F9F File Offset: 0x0030119F
		[NullableContext(2)]
		public int GetGridIndexByChildComponent(UUISelectableComponent Component)
		{
			return UUIMultiTemplateScrollViewComponent.__GetGridIndexByChildComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020881 RID: 133249 RVA: 0x00302FBC File Offset: 0x003011BC
		public int GetEndDisplayGridIndex()
		{
			return UUIMultiTemplateScrollViewComponent.__GetEndDisplayGridIndex_Internal(base.NativePtr);
		}

		// Token: 0x06020882 RID: 133250 RVA: 0x00302FC9 File Offset: 0x003011C9
		public FMargin GetContentPadding()
		{
			return UUIMultiTemplateScrollViewComponent.__GetContentPadding_Internal(base.NativePtr);
		}

		// Token: 0x06020883 RID: 133251 RVA: 0x00302FD8 File Offset: 0x003011D8
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

		// Token: 0x06020884 RID: 133252 RVA: 0x00303003 File Offset: 0x00301203
		public FMargin GetAreaPadding(int InAreaIndex)
		{
			return UUIMultiTemplateScrollViewComponent.__GetAreaPadding_Internal(base.NativePtr, InAreaIndex);
		}

		// Token: 0x06020885 RID: 133253 RVA: 0x00303014 File Offset: 0x00301214
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

		// Token: 0x06020886 RID: 133254 RVA: 0x0030303F File Offset: 0x0030123F
		[NullableContext(2)]
		public int FindNavigationIndex(UUISelectableComponent Component, FVector Direction, UINavigationWrapMode WrapMode, UINavigationPriorityMode PriorityMode, float NavigateTolerance, float NavigateToleranceReverse)
		{
			return UUIMultiTemplateScrollViewComponent.__FindNavigationIndex_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, Direction, WrapMode, PriorityMode, NavigateTolerance, NavigateToleranceReverse);
		}

		// Token: 0x06020887 RID: 133255 RVA: 0x00303064 File Offset: 0x00301264
		public bool CheckScrollViewValid()
		{
			return UUIMultiTemplateScrollViewComponent.__CheckScrollViewValid_Internal(base.NativePtr);
		}

		// Token: 0x06020888 RID: 133256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x06020889 RID: 133257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentPadding_Internal(IntPtr @this, FMargin InContentPadding);

		// Token: 0x0602088A RID: 133258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetYWhenVertical_Internal(IntPtr @this, float NewOffset, bool bClamp);

		// Token: 0x0602088B RID: 133259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetXWhenHorizontal_Internal(IntPtr @this, float NewOffset, bool bClamp);

		// Token: 0x0602088C RID: 133260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetContentOffsetAlignGrid_Internal(IntPtr @this, int GridIndex, bool bClamp, bool bScrollToTop);

		// Token: 0x0602088D RID: 133261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndexLater_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x0602088E RID: 133262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bScrollToTop);

		// Token: 0x0602088F RID: 133263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr InTemplateIndexArray, bool KeepContentPosition, int ScrollToItemIndex);

		// Token: 0x06020890 RID: 133264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x06020891 RID: 133265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInDisplayRange_Internal(IntPtr @this, int GridIndex, bool OnlyCheckData);

		// Token: 0x06020892 RID: 133266
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAllItemDisplayed_Internal(IntPtr @this);

		// Token: 0x06020893 RID: 133267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetStartDisplayGridIndex_Internal(IntPtr @this);

		// Token: 0x06020894 RID: 133268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationComponentByGridIndex_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06020895 RID: 133269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineWidthWhenHorizontal_Internal(IntPtr @this, int InLineIndex);

		// Token: 0x06020896 RID: 133270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetLineHeightWhenVertical_Internal(IntPtr @this, int InLineIndex);

		// Token: 0x06020897 RID: 133271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridTemplateIndexInArea_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x06020898 RID: 133272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetGridSpacingInArea_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x06020899 RID: 133273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGridItemByChildComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x0602089A RID: 133274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGridItem_Internal(IntPtr @this, int GridIndex);

		// Token: 0x0602089B RID: 133275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetGridIndexByChildComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x0602089C RID: 133276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetEndDisplayGridIndex_Internal(IntPtr @this);

		// Token: 0x0602089D RID: 133277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetContentPadding_Internal(IntPtr @this);

		// Token: 0x0602089E RID: 133278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAreaSize_Internal(IntPtr @this, int InAreaIndex, ref float OutWidth, ref float OutHeight);

		// Token: 0x0602089F RID: 133279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMargin __GetAreaPadding_Internal(IntPtr @this, int InAreaIndex);

		// Token: 0x060208A0 RID: 133280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAreaGridIndexRange_Internal(IntPtr @this, int InAreaIndex, ref int OutStartGridIndex, ref int OutEndGridIndex);

		// Token: 0x060208A1 RID: 133281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __FindNavigationIndex_Internal(IntPtr @this, IntPtr Component, FVector Direction, UINavigationWrapMode WrapMode, UINavigationPriorityMode PriorityMode, float NavigateTolerance, float NavigateToleranceReverse);

		// Token: 0x060208A2 RID: 133282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckScrollViewValid_Internal(IntPtr @this);

		// Token: 0x060208A3 RID: 133283 RVA: 0x00303071 File Offset: 0x00301271
		static UUIMultiTemplateScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIMultiTemplateScrollViewComponent");
		}

		// Token: 0x060208A4 RID: 133284 RVA: 0x0030307F File Offset: 0x0030127F
		protected UUIMultiTemplateScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040116B6 RID: 71350
		public new const string __ObjectPath = "/Script/LGUI.UIMultiTemplateScrollViewComponent";

		// Token: 0x040116B7 RID: 71351
		private static IntPtr _ClassPtr;

		// Token: 0x040116B8 RID: 71352
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040116B9 RID: 71353
		internal static int __PropertyOffset_TemplateInfoArray;

		// Token: 0x040116BA RID: 71354
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FMultiTemplateScrollViewTemplateInfo> _TemplateInfoArray;

		// Token: 0x040116BB RID: 71355
		internal static int __PropertyOffset_ViewportSizeTolerance;

		// Token: 0x040116BC RID: 71356
		internal static int __PropertyOffset_AreaSpacing;

		// Token: 0x040116BD RID: 71357
		internal static int __PropertyOffset_ContentPadding;

		// Token: 0x040116BE RID: 71358
		internal static int __PropertyOffset_OnItemCreate;

		// Token: 0x040116BF RID: 71359
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemCreateDelegate _OnItemCreate;

		// Token: 0x040116C0 RID: 71360
		internal static int __PropertyOffset_OnItemRefresh;

		// Token: 0x040116C1 RID: 71361
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemRefreshDelegate _OnItemRefresh;

		// Token: 0x040116C2 RID: 71362
		internal static int __PropertyOffset_OnItemClear;

		// Token: 0x040116C3 RID: 71363
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemClearDelegate _OnItemClear;

		// Token: 0x040116C4 RID: 71364
		internal static int __PropertyOffset_OnCheckItemNavigable;

		// Token: 0x040116C5 RID: 71365
		[Nullable(2)]
		private FLGUIMultiTemplateScrollViewItemNavigableDelegate _OnCheckItemNavigable;
	}
}
