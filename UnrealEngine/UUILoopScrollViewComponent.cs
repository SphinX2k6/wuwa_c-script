using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002186 RID: 8582
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UILoopScrollViewComponent")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class UUILoopScrollViewComponent : UUIScrollViewWithScrollbarComponent, IUnrealUObject, IUnrealObject, ILGUIPrefabCheckerInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIGridAnimationInterface
	{
		// Token: 0x060207EE RID: 133102 RVA: 0x00302579 File Offset: 0x00300779
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUILoopScrollViewComponent._ClassPtr;
		}

		// Token: 0x060207EF RID: 133103 RVA: 0x00302585 File Offset: 0x00300785
		int ILGUIPrefabCheckerInterface.InterfaceOffset()
		{
			return UUILoopScrollViewComponent.__InterfaceOffset_ILGUIPrefabCheckerInterface;
		}

		// Token: 0x060207F0 RID: 133104 RVA: 0x0030258C File Offset: 0x0030078C
		int ILGUIGridAnimationInterface.InterfaceOffset()
		{
			return UUILoopScrollViewComponent.__InterfaceOffset_ILGUIGridAnimationInterface;
		}

		// Token: 0x060207F1 RID: 133105 RVA: 0x00302594 File Offset: 0x00300794
		public UUILoopScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUILoopScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060207F2 RID: 133106 RVA: 0x003025BC File Offset: 0x003007BC
		public UUILoopScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUILoopScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007F23 RID: 32547
		// (get) Token: 0x060207F3 RID: 133107 RVA: 0x003025F0 File Offset: 0x003007F0
		// (set) Token: 0x060207F4 RID: 133108 RVA: 0x00302629 File Offset: 0x00300829
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

		// Token: 0x17007F24 RID: 32548
		// (get) Token: 0x060207F5 RID: 133109 RVA: 0x00302637 File Offset: 0x00300837
		// (set) Token: 0x060207F6 RID: 133110 RVA: 0x0030264B File Offset: 0x0030084B
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

		// Token: 0x17007F25 RID: 32549
		// (get) Token: 0x060207F7 RID: 133111 RVA: 0x00302660 File Offset: 0x00300860
		// (set) Token: 0x060207F8 RID: 133112 RVA: 0x00302670 File Offset: 0x00300870
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

		// Token: 0x17007F26 RID: 32550
		// (get) Token: 0x060207F9 RID: 133113 RVA: 0x00302681 File Offset: 0x00300881
		// (set) Token: 0x060207FA RID: 133114 RVA: 0x00302691 File Offset: 0x00300891
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

		// Token: 0x17007F27 RID: 32551
		// (get) Token: 0x060207FB RID: 133115 RVA: 0x003026A2 File Offset: 0x003008A2
		// (set) Token: 0x060207FC RID: 133116 RVA: 0x003026B2 File Offset: 0x003008B2
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

		// Token: 0x17007F28 RID: 32552
		// (get) Token: 0x060207FD RID: 133117 RVA: 0x003026C3 File Offset: 0x003008C3
		// (set) Token: 0x060207FE RID: 133118 RVA: 0x003026D3 File Offset: 0x003008D3
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

		// Token: 0x17007F29 RID: 32553
		// (get) Token: 0x060207FF RID: 133119 RVA: 0x003026E4 File Offset: 0x003008E4
		// (set) Token: 0x06020800 RID: 133120 RVA: 0x003026F4 File Offset: 0x003008F4
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

		// Token: 0x17007F2A RID: 32554
		// (get) Token: 0x06020801 RID: 133121 RVA: 0x00302705 File Offset: 0x00300905
		// (set) Token: 0x06020802 RID: 133122 RVA: 0x00302715 File Offset: 0x00300915
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

		// Token: 0x17007F2B RID: 32555
		// (get) Token: 0x06020803 RID: 133123 RVA: 0x00302726 File Offset: 0x00300926
		// (set) Token: 0x06020804 RID: 133124 RVA: 0x00302736 File Offset: 0x00300936
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

		// Token: 0x17007F2C RID: 32556
		// (get) Token: 0x06020805 RID: 133125 RVA: 0x00302747 File Offset: 0x00300947
		// (set) Token: 0x06020806 RID: 133126 RVA: 0x00302757 File Offset: 0x00300957
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

		// Token: 0x17007F2D RID: 32557
		// (get) Token: 0x06020807 RID: 133127 RVA: 0x00302768 File Offset: 0x00300968
		// (set) Token: 0x06020808 RID: 133128 RVA: 0x00302778 File Offset: 0x00300978
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

		// Token: 0x17007F2E RID: 32558
		// (get) Token: 0x06020809 RID: 133129 RVA: 0x00302789 File Offset: 0x00300989
		// (set) Token: 0x0602080A RID: 133130 RVA: 0x00302799 File Offset: 0x00300999
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

		// Token: 0x17007F2F RID: 32559
		// (get) Token: 0x0602080B RID: 133131 RVA: 0x003027AA File Offset: 0x003009AA
		// (set) Token: 0x0602080C RID: 133132 RVA: 0x003027BA File Offset: 0x003009BA
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

		// Token: 0x17007F30 RID: 32560
		// (get) Token: 0x0602080D RID: 133133 RVA: 0x003027CB File Offset: 0x003009CB
		// (set) Token: 0x0602080E RID: 133134 RVA: 0x003027DB File Offset: 0x003009DB
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

		// Token: 0x17007F31 RID: 32561
		// (get) Token: 0x0602080F RID: 133135 RVA: 0x003027EC File Offset: 0x003009EC
		// (set) Token: 0x06020810 RID: 133136 RVA: 0x00302825 File Offset: 0x00300A25
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

		// Token: 0x17007F32 RID: 32562
		// (get) Token: 0x06020811 RID: 133137 RVA: 0x00302848 File Offset: 0x00300A48
		// (set) Token: 0x06020812 RID: 133138 RVA: 0x00302881 File Offset: 0x00300A81
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

		// Token: 0x17007F33 RID: 32563
		// (get) Token: 0x06020813 RID: 133139 RVA: 0x003028A4 File Offset: 0x00300AA4
		// (set) Token: 0x06020814 RID: 133140 RVA: 0x003028DD File Offset: 0x00300ADD
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

		// Token: 0x17007F34 RID: 32564
		// (get) Token: 0x06020815 RID: 133141 RVA: 0x003028FE File Offset: 0x00300AFE
		// (set) Token: 0x06020816 RID: 133142 RVA: 0x0030290E File Offset: 0x00300B0E
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

		// Token: 0x06020817 RID: 133143 RVA: 0x0030291F File Offset: 0x00300B1F
		public void SetNavigationIndex(int GridIndex)
		{
			UUILoopScrollViewComponent.__SetNavigationIndex_Internal(base.NativePtr, GridIndex);
		}

		// Token: 0x06020818 RID: 133144 RVA: 0x0030292D File Offset: 0x00300B2D
		public void SetInAnimation(bool state)
		{
			UUILoopScrollViewComponent.__SetInAnimation_Internal(base.NativePtr, state);
		}

		// Token: 0x06020819 RID: 133145 RVA: 0x0030293B File Offset: 0x00300B3B
		public void SetGridAnimationStartTime(float value)
		{
			UUILoopScrollViewComponent.__SetGridAnimationStartTime_Internal(base.NativePtr, value);
		}

		// Token: 0x0602081A RID: 133146 RVA: 0x00302949 File Offset: 0x00300B49
		public void SetGridAnimationInterval(float value)
		{
			UUILoopScrollViewComponent.__SetGridAnimationInterval_Internal(base.NativePtr, value);
		}

		// Token: 0x0602081B RID: 133147 RVA: 0x00302957 File Offset: 0x00300B57
		public void ScrollToNextLineLater(bool bReversed = false)
		{
			UUILoopScrollViewComponent.__ScrollToNextLineLater_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x0602081C RID: 133148 RVA: 0x00302965 File Offset: 0x00300B65
		public void ScrollToNextLine(bool bReversed = false)
		{
			UUILoopScrollViewComponent.__ScrollToNextLine_Internal(base.NativePtr, bReversed);
		}

		// Token: 0x0602081D RID: 133149 RVA: 0x00302973 File Offset: 0x00300B73
		public void ScrollToGridIndexLater(int GridIndex, bool bTweenAnim = false)
		{
			UUILoopScrollViewComponent.__ScrollToGridIndexLater_Internal(base.NativePtr, GridIndex, bTweenAnim);
		}

		// Token: 0x0602081E RID: 133150 RVA: 0x00302982 File Offset: 0x00300B82
		public void ScrollToGridIndex(int GridIndex, bool bTweenAnim = false)
		{
			UUILoopScrollViewComponent.__ScrollToGridIndex_Internal(base.NativePtr, GridIndex, bTweenAnim);
		}

		// Token: 0x0602081F RID: 133151 RVA: 0x00302991 File Offset: 0x00300B91
		public void ResetPreview()
		{
			UUILoopScrollViewComponent.__ResetPreview_Internal(base.NativePtr);
		}

		// Token: 0x06020820 RID: 133152 RVA: 0x0030299E File Offset: 0x00300B9E
		[NullableContext(2)]
		public void RefreshByData(AUIBaseActor UIItem, int GridNum, bool KeepContentPosition = false)
		{
			UUILoopScrollViewComponent.__RefreshByData_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, GridNum, KeepContentPosition);
		}

		// Token: 0x06020821 RID: 133153 RVA: 0x003029BD File Offset: 0x00300BBD
		public void Refresh()
		{
			UUILoopScrollViewComponent.__Refresh_Internal(base.NativePtr);
		}

		// Token: 0x06020822 RID: 133154 RVA: 0x003029CA File Offset: 0x00300BCA
		public bool GetInAnimation()
		{
			return UUILoopScrollViewComponent.__GetInAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06020823 RID: 133155 RVA: 0x003029D7 File Offset: 0x00300BD7
		public float GetGridAnimationStartTime()
		{
			return UUILoopScrollViewComponent.__GetGridAnimationStartTime_Internal(base.NativePtr);
		}

		// Token: 0x06020824 RID: 133156 RVA: 0x003029E4 File Offset: 0x00300BE4
		public float GetGridAnimationInterval()
		{
			return UUILoopScrollViewComponent.__GetGridAnimationInterval_Internal(base.NativePtr);
		}

		// Token: 0x06020825 RID: 133157 RVA: 0x003029F1 File Offset: 0x00300BF1
		[NullableContext(2)]
		public AUIBaseActor GetGrid(int GridIndex)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUILoopScrollViewComponent.__GetGrid_Internal(base.NativePtr, GridIndex));
		}

		// Token: 0x06020826 RID: 133158
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationIndex_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06020827 RID: 133159
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInAnimation_Internal(IntPtr @this, bool state);

		// Token: 0x06020828 RID: 133160
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationStartTime_Internal(IntPtr @this, float value);

		// Token: 0x06020829 RID: 133161
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGridAnimationInterval_Internal(IntPtr @this, float value);

		// Token: 0x0602082A RID: 133162
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLineLater_Internal(IntPtr @this, bool bReversed);

		// Token: 0x0602082B RID: 133163
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToNextLine_Internal(IntPtr @this, bool bReversed);

		// Token: 0x0602082C RID: 133164
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndexLater_Internal(IntPtr @this, int GridIndex, bool bTweenAnim);

		// Token: 0x0602082D RID: 133165
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToGridIndex_Internal(IntPtr @this, int GridIndex, bool bTweenAnim);

		// Token: 0x0602082E RID: 133166
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetPreview_Internal(IntPtr @this);

		// Token: 0x0602082F RID: 133167
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshByData_Internal(IntPtr @this, IntPtr UIItem, int GridNum, bool KeepContentPosition);

		// Token: 0x06020830 RID: 133168
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Refresh_Internal(IntPtr @this);

		// Token: 0x06020831 RID: 133169
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetInAnimation_Internal(IntPtr @this);

		// Token: 0x06020832 RID: 133170
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationStartTime_Internal(IntPtr @this);

		// Token: 0x06020833 RID: 133171
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetGridAnimationInterval_Internal(IntPtr @this);

		// Token: 0x06020834 RID: 133172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGrid_Internal(IntPtr @this, int GridIndex);

		// Token: 0x06020835 RID: 133173 RVA: 0x00302A04 File Offset: 0x00300C04
		static UUILoopScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UILoopScrollViewComponent");
		}

		// Token: 0x06020836 RID: 133174 RVA: 0x00302A12 File Offset: 0x00300C12
		protected UUILoopScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011693 RID: 71315
		internal static int __InterfaceOffset_ILGUIPrefabCheckerInterface;

		// Token: 0x04011694 RID: 71316
		internal static int __InterfaceOffset_ILGUIGridAnimationInterface;

		// Token: 0x04011695 RID: 71317
		public new const string __ObjectPath = "/Script/LGUI.UILoopScrollViewComponent";

		// Token: 0x04011696 RID: 71318
		private static IntPtr _ClassPtr;

		// Token: 0x04011697 RID: 71319
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011698 RID: 71320
		internal static int __PropertyOffset_GridArray;

		// Token: 0x04011699 RID: 71321
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _GridArray;

		// Token: 0x0401169A RID: 71322
		internal static int __PropertyOffset_TemplateGrid;

		// Token: 0x0401169B RID: 71323
		internal static int __PropertyOffset_DisplayGridNum;

		// Token: 0x0401169C RID: 71324
		internal static int __PropertyOffset_TotalGridNum;

		// Token: 0x0401169D RID: 71325
		internal static int __PropertyOffset_GridDefaultUIActive;

		// Token: 0x0401169E RID: 71326
		internal static int __PropertyOffset_IsGridShrinkStrech;

		// Token: 0x0401169F RID: 71327
		internal static int __PropertyOffset_SpacingHorizontal;

		// Token: 0x040116A0 RID: 71328
		internal static int __PropertyOffset_SpacingVertical;

		// Token: 0x040116A1 RID: 71329
		internal static int __PropertyOffset_PaddingHorizontal;

		// Token: 0x040116A2 RID: 71330
		internal static int __PropertyOffset_PaddingVertical;

		// Token: 0x040116A3 RID: 71331
		internal static int __PropertyOffset_bForceSingleLine;

		// Token: 0x040116A4 RID: 71332
		internal static int __PropertyOffset_GridAnimationStartTime;

		// Token: 0x040116A5 RID: 71333
		internal static int __PropertyOffset_GridAnimationInterval;

		// Token: 0x040116A6 RID: 71334
		internal static int __PropertyOffset_IsInAnimation;

		// Token: 0x040116A7 RID: 71335
		internal static int __PropertyOffset_OnGridCreate;

		// Token: 0x040116A8 RID: 71336
		[Nullable(2)]
		private FLGUILoopScrollViewGridCreateDelegate _OnGridCreate;

		// Token: 0x040116A9 RID: 71337
		internal static int __PropertyOffset_OnGridsUpdate;

		// Token: 0x040116AA RID: 71338
		[Nullable(2)]
		private FLGUILoopScrollViewGridDelegate _OnGridsUpdate;

		// Token: 0x040116AB RID: 71339
		internal static int __PropertyOffset_OnDestroyCallBack;

		// Token: 0x040116AC RID: 71340
		[Nullable(2)]
		private FLGUILoopScrollViewDelegate _OnDestroyCallBack;

		// Token: 0x040116AD RID: 71341
		internal static int __PropertyOffset_NavigationIndex;
	}
}
