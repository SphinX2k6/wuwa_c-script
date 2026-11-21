using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000712 RID: 1810
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILoopScrollViewComponent")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class UUILoopScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009B5E RID: 39774 RVA: 0x000E869D File Offset: 0x000E689D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILoopScrollViewComponent._ClassPtr;
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x000E86AC File Offset: 0x000E68AC
		public UUILoopScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUILoopScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x000E86D4 File Offset: 0x000E68D4
		public UUILoopScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILoopScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x06009B61 RID: 39777 RVA: 0x000E8708 File Offset: 0x000E6908
		// (set) Token: 0x06009B62 RID: 39778 RVA: 0x000E8741 File Offset: 0x000E6941
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AUIBaseActor>> GridArray
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
				if ((result = this._GridArray) == null)
				{
					result = (this._GridArray = new TArray<TWeakObjectPtr<AUIBaseActor>>(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridArray, this));
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
				this.GridArray.CopyAssign(value);
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x06009B63 RID: 39779 RVA: 0x000E874F File Offset: 0x000E694F
		// (set) Token: 0x06009B64 RID: 39780 RVA: 0x000E8763 File Offset: 0x000E6963
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TemplateGrid
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_TemplateGrid);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_TemplateGrid) = value;
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x06009B65 RID: 39781 RVA: 0x000E8778 File Offset: 0x000E6978
		// (set) Token: 0x06009B66 RID: 39782 RVA: 0x000E8788 File Offset: 0x000E6988
		public unsafe int DisplayGridNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_DisplayGridNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_DisplayGridNum) = value;
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x06009B67 RID: 39783 RVA: 0x000E8799 File Offset: 0x000E6999
		// (set) Token: 0x06009B68 RID: 39784 RVA: 0x000E87A9 File Offset: 0x000E69A9
		public unsafe int TotalGridNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_TotalGridNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_TotalGridNum) = value;
			}
		}

		// Token: 0x17001CCF RID: 7375
		// (get) Token: 0x06009B69 RID: 39785 RVA: 0x000E87BA File Offset: 0x000E69BA
		// (set) Token: 0x06009B6A RID: 39786 RVA: 0x000E87CA File Offset: 0x000E69CA
		public unsafe bool GridDefaultUIActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridDefaultUIActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridDefaultUIActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CD0 RID: 7376
		// (get) Token: 0x06009B6B RID: 39787 RVA: 0x000E87DB File Offset: 0x000E69DB
		// (set) Token: 0x06009B6C RID: 39788 RVA: 0x000E87EB File Offset: 0x000E69EB
		public unsafe bool IsGridShrinkStrech
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_IsGridShrinkStrech) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_IsGridShrinkStrech) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CD1 RID: 7377
		// (get) Token: 0x06009B6D RID: 39789 RVA: 0x000E87FC File Offset: 0x000E69FC
		// (set) Token: 0x06009B6E RID: 39790 RVA: 0x000E880C File Offset: 0x000E6A0C
		public unsafe float SpacingHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_SpacingHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_SpacingHorizontal) = value;
			}
		}

		// Token: 0x17001CD2 RID: 7378
		// (get) Token: 0x06009B6F RID: 39791 RVA: 0x000E881D File Offset: 0x000E6A1D
		// (set) Token: 0x06009B70 RID: 39792 RVA: 0x000E882D File Offset: 0x000E6A2D
		public unsafe float SpacingVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_SpacingVertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_SpacingVertical) = value;
			}
		}

		// Token: 0x17001CD3 RID: 7379
		// (get) Token: 0x06009B71 RID: 39793 RVA: 0x000E883E File Offset: 0x000E6A3E
		// (set) Token: 0x06009B72 RID: 39794 RVA: 0x000E884E File Offset: 0x000E6A4E
		public unsafe float PaddingHorizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_PaddingHorizontal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_PaddingHorizontal) = value;
			}
		}

		// Token: 0x17001CD4 RID: 7380
		// (get) Token: 0x06009B73 RID: 39795 RVA: 0x000E885F File Offset: 0x000E6A5F
		// (set) Token: 0x06009B74 RID: 39796 RVA: 0x000E886F File Offset: 0x000E6A6F
		public unsafe float PaddingVertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_PaddingVertical);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_PaddingVertical) = value;
			}
		}

		// Token: 0x17001CD5 RID: 7381
		// (get) Token: 0x06009B75 RID: 39797 RVA: 0x000E8880 File Offset: 0x000E6A80
		// (set) Token: 0x06009B76 RID: 39798 RVA: 0x000E8890 File Offset: 0x000E6A90
		public unsafe bool bForceSingleLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_bForceSingleLine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_bForceSingleLine) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CD6 RID: 7382
		// (get) Token: 0x06009B77 RID: 39799 RVA: 0x000E88A1 File Offset: 0x000E6AA1
		// (set) Token: 0x06009B78 RID: 39800 RVA: 0x000E88B1 File Offset: 0x000E6AB1
		public unsafe float GridAnimationStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridAnimationStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridAnimationStartTime) = value;
			}
		}

		// Token: 0x17001CD7 RID: 7383
		// (get) Token: 0x06009B79 RID: 39801 RVA: 0x000E88C2 File Offset: 0x000E6AC2
		// (set) Token: 0x06009B7A RID: 39802 RVA: 0x000E88D2 File Offset: 0x000E6AD2
		public unsafe float GridAnimationInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridAnimationInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_GridAnimationInterval) = value;
			}
		}

		// Token: 0x17001CD8 RID: 7384
		// (get) Token: 0x06009B7B RID: 39803 RVA: 0x000E88E3 File Offset: 0x000E6AE3
		// (set) Token: 0x06009B7C RID: 39804 RVA: 0x000E88F3 File Offset: 0x000E6AF3
		public unsafe bool IsInAnimation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_IsInAnimation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_IsInAnimation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CD9 RID: 7385
		// (get) Token: 0x06009B7D RID: 39805 RVA: 0x000E8904 File Offset: 0x000E6B04
		// (set) Token: 0x06009B7E RID: 39806 RVA: 0x000E893D File Offset: 0x000E6B3D
		public FLGUILoopScrollViewGridCreateDelegate OnGridCreate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUILoopScrollViewGridCreateDelegate result;
				if ((result = this._OnGridCreate) == null)
				{
					result = (this._OnGridCreate = new FLGUILoopScrollViewGridCreateDelegate(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnGridCreate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnGridCreate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CDA RID: 7386
		// (get) Token: 0x06009B7F RID: 39807 RVA: 0x000E8960 File Offset: 0x000E6B60
		// (set) Token: 0x06009B80 RID: 39808 RVA: 0x000E8999 File Offset: 0x000E6B99
		public FLGUILoopScrollViewGridDelegate OnGridsUpdate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUILoopScrollViewGridDelegate result;
				if ((result = this._OnGridsUpdate) == null)
				{
					result = (this._OnGridsUpdate = new FLGUILoopScrollViewGridDelegate(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnGridsUpdate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnGridsUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CDB RID: 7387
		// (get) Token: 0x06009B81 RID: 39809 RVA: 0x000E89BC File Offset: 0x000E6BBC
		// (set) Token: 0x06009B82 RID: 39810 RVA: 0x000E89F5 File Offset: 0x000E6BF5
		public FLGUILoopScrollViewDelegate OnDestroyCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUILoopScrollViewDelegate result;
				if ((result = this._OnDestroyCallBack) == null)
				{
					result = (this._OnDestroyCallBack = new FLGUILoopScrollViewDelegate(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnDestroyCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_OnDestroyCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001CDC RID: 7388
		// (get) Token: 0x06009B83 RID: 39811 RVA: 0x000E8A16 File Offset: 0x000E6C16
		// (set) Token: 0x06009B84 RID: 39812 RVA: 0x000E8A26 File Offset: 0x000E6C26
		public unsafe int NavigationIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_NavigationIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUILoopScrollViewComponent.__PropertyOffset_NavigationIndex) = value;
			}
		}

		// Token: 0x06009B85 RID: 39813 RVA: 0x000E8A37 File Offset: 0x000E6C37
		public void SetNavigationIndex(int GridIndex)
		{
			UUILoopScrollViewComponent.__SetNavigationIndex_Internal(base.NativePtr, GridIndex);
		}

		// Token: 0x06009B86 RID: 39814 RVA: 0x000E8A45 File Offset: 0x000E6C45
		public void SetInAnimation(bool state)
		{
			UUILoopScrollViewComponent.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x06009B87 RID: 39815 RVA: 0x000E8A53 File Offset: 0x000E6C53
		public void SetGridAnimationStartTime(float value)
		{
			UUILoopScrollViewComponent.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x06009B88 RID: 39816 RVA: 0x000E8A61 File Offset: 0x000E6C61
		public void SetGridAnimationInterval(float value)
		{
			UUILoopScrollViewComponent.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x06009B89 RID: 39817 RVA: 0x000E8A6F File Offset: 0x000E6C6F
		public void ScrollToNextLineLater(bool bReversed = false)
		{
			UUILoopScrollViewComponent.__ScrollToNextLineLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x06009B8A RID: 39818 RVA: 0x000E8A7D File Offset: 0x000E6C7D
		public void ScrollToNextLine(bool bReversed = false)
		{
			UUILoopScrollViewComponent.__ScrollToNextLine_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x06009B8B RID: 39819 RVA: 0x000E8A8B File Offset: 0x000E6C8B
		public void ScrollToGridIndexLater(int GridIndex, bool bTweenAnim = false)
		{
			UUILoopScrollViewComponent.__ScrollToGridIndexLater_Internal(base.NativePtr, GridIndex, bTweenAnim);
		}

		// Token: 0x06009B8C RID: 39820 RVA: 0x000E8A9A File Offset: 0x000E6C9A
		public void ScrollToGridIndex(int GridIndex, bool bTweenAnim = false)
		{
			UUILoopScrollViewComponent.__ScrollToGridIndex_Internal(base.NativePtr, GridIndex, bTweenAnim);
		}

		// Token: 0x06009B8D RID: 39821 RVA: 0x000E8AA9 File Offset: 0x000E6CA9
		public void ResetPreview()
		{
			UUILoopScrollViewComponent.__ResetPreview_Internal(base.NativePtr);
		}

		// Token: 0x06009B8E RID: 39822 RVA: 0x000E8AB6 File Offset: 0x000E6CB6
		[NullableContext(2)]
		public void RefreshByData(AUIBaseActor UIItem, int GridNum, bool KeepContentPosition = false)
		{
			UUILoopScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, GridNum, KeepContentPosition);
		}

		// Token: 0x06009B8F RID: 39823 RVA: 0x000E8AD5 File Offset: 0x000E6CD5
		public void Refresh()
		{
			UUILoopScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x06009B90 RID: 39824 RVA: 0x000E8AE2 File Offset: 0x000E6CE2
		public bool GetInAnimation()
		{
			return UUILoopScrollViewComponent.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06009B91 RID: 39825 RVA: 0x000E8AEF File Offset: 0x000E6CEF
		public float GetGridAnimationStartTime()
		{
			return UUILoopScrollViewComponent.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x06009B92 RID: 39826 RVA: 0x000E8AFC File Offset: 0x000E6CFC
		public float GetGridAnimationInterval()
		{
			return UUILoopScrollViewComponent.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x000E8B09 File Offset: 0x000E6D09
		[NullableContext(2)]
		public AUIBaseActor GetGrid(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUILoopScrollViewComponent.__GetGrid_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x06009B94 RID: 39828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationIndex_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06009B95 RID: 39829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x06009B96 RID: 39830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x06009B97 RID: 39831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x06009B98 RID: 39832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLineLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x06009B99 RID: 39833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLine_Internal(IntPtr @this, bool bReversed);

		// Token: 0x06009B9A RID: 39834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndexLater_Internal(IntPtr @this, int GridIndex, bool bTweenAnim);

		// Token: 0x06009B9B RID: 39835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bTweenAnim);

		// Token: 0x06009B9C RID: 39836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetPreview_Internal(IntPtr @this);

		// Token: 0x06009B9D RID: 39837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr UIItem, int GridNum, bool KeepContentPosition);

		// Token: 0x06009B9E RID: 39838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x06009B9F RID: 39839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x06009BA0 RID: 39840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x06009BA1 RID: 39841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x06009BA2 RID: 39842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrid_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06009BA3 RID: 39843 RVA: 0x000E8B1C File Offset: 0x000E6D1C
		static UUILoopScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILoopScrollViewComponent");
		}

		// Token: 0x06009BA4 RID: 39844 RVA: 0x000E8B2A File Offset: 0x000E6D2A
		protected UUILoopScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004312 RID: 17170
		public new const string __ObjectPath = "/Script/LGUI.UILoopScrollViewComponent";

		// Token: 0x04004313 RID: 17171
		private static IntPtr _ClassPtr;

		// Token: 0x04004314 RID: 17172
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004315 RID: 17173
		internal static int __PropertyOffset_GridArray;

		// Token: 0x04004316 RID: 17174
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _GridArray;

		// Token: 0x04004317 RID: 17175
		internal static int __PropertyOffset_TemplateGrid;

		// Token: 0x04004318 RID: 17176
		internal static int __PropertyOffset_DisplayGridNum;

		// Token: 0x04004319 RID: 17177
		internal static int __PropertyOffset_TotalGridNum;

		// Token: 0x0400431A RID: 17178
		internal static int __PropertyOffset_GridDefaultUIActive;

		// Token: 0x0400431B RID: 17179
		internal static int __PropertyOffset_IsGridShrinkStrech;

		// Token: 0x0400431C RID: 17180
		internal static int __PropertyOffset_SpacingHorizontal;

		// Token: 0x0400431D RID: 17181
		internal static int __PropertyOffset_SpacingVertical;

		// Token: 0x0400431E RID: 17182
		internal static int __PropertyOffset_PaddingHorizontal;

		// Token: 0x0400431F RID: 17183
		internal static int __PropertyOffset_PaddingVertical;

		// Token: 0x04004320 RID: 17184
		internal static int __PropertyOffset_bForceSingleLine;

		// Token: 0x04004321 RID: 17185
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x04004322 RID: 17186
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x04004323 RID: 17187
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x04004324 RID: 17188
		internal static int __PropertyOffset_OnGridCreate;

		// Token: 0x04004325 RID: 17189
		[Nullable(2)]
		private FLGUILoopScrollViewGridCreateDelegate _OnGridCreate;

		// Token: 0x04004326 RID: 17190
		internal static int __PropertyOffset_OnGridsUpdate;

		// Token: 0x04004327 RID: 17191
		[Nullable(2)]
		private FLGUILoopScrollViewGridDelegate _OnGridsUpdate;

		// Token: 0x04004328 RID: 17192
		internal static int __PropertyOffset_OnDestroyCallBack;

		// Token: 0x04004329 RID: 17193
		[Nullable(2)]
		private FLGUILoopScrollViewDelegate _OnDestroyCallBack;

		// Token: 0x0400432A RID: 17194
		internal static int __PropertyOffset_NavigationIndex;
	}
}
