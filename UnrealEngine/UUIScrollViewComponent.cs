using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A5 RID: 8613
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIScrollViewComponent")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UUIScrollViewComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIPointerDragInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerScrollInterface, ILGUIPointerDownUpInterface, ILGUIPointerInterruptInterface
	{
		// Token: 0x06020ABB RID: 133819 RVA: 0x00305747 File Offset: 0x00303947
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollViewComponent._ClassPtr;
		}

		// Token: 0x06020ABC RID: 133820 RVA: 0x00305753 File Offset: 0x00303953
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIScrollViewComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x06020ABD RID: 133821 RVA: 0x0030575A File Offset: 0x0030395A
		int ILGUIPointerScrollInterface.InterfaceOffset()
		{
			return UUIScrollViewComponent.__InterfaceOffset_ILGUIPointerScrollInterface;
		}

		// Token: 0x06020ABE RID: 133822 RVA: 0x00305761 File Offset: 0x00303961
		int ILGUIPointerDownUpInterface.InterfaceOffset()
		{
			return UUIScrollViewComponent.__InterfaceOffset_ILGUIPointerDownUpInterface;
		}

		// Token: 0x06020ABF RID: 133823 RVA: 0x00305768 File Offset: 0x00303968
		int ILGUIPointerInterruptInterface.InterfaceOffset()
		{
			return UUIScrollViewComponent.__InterfaceOffset_ILGUIPointerInterruptInterface;
		}

		// Token: 0x06020AC0 RID: 133824 RVA: 0x00305770 File Offset: 0x00303970
		public UUIScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020AC1 RID: 133825 RVA: 0x00305798 File Offset: 0x00303998
		public UUIScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FB2 RID: 32690
		// (get) Token: 0x06020AC2 RID: 133826 RVA: 0x003057CB File Offset: 0x003039CB
		// (set) Token: 0x06020AC3 RID: 133827 RVA: 0x003057DF File Offset: 0x003039DF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> Content
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Content);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Content) = value;
			}
		}

		// Token: 0x17007FB3 RID: 32691
		// (get) Token: 0x06020AC4 RID: 133828 RVA: 0x003057F4 File Offset: 0x003039F4
		// (set) Token: 0x06020AC5 RID: 133829 RVA: 0x00305804 File Offset: 0x00303A04
		public unsafe bool Horizontal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Horizontal) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Horizontal) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FB4 RID: 32692
		// (get) Token: 0x06020AC6 RID: 133830 RVA: 0x00305815 File Offset: 0x00303A15
		// (set) Token: 0x06020AC7 RID: 133831 RVA: 0x00305825 File Offset: 0x00303A25
		public unsafe bool Vertical
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Vertical) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Vertical) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FB5 RID: 32693
		// (get) Token: 0x06020AC8 RID: 133832 RVA: 0x00305836 File Offset: 0x00303A36
		// (set) Token: 0x06020AC9 RID: 133833 RVA: 0x00305846 File Offset: 0x00303A46
		public unsafe float ScrollSensitivity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollSensitivity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollSensitivity) = value;
			}
		}

		// Token: 0x17007FB6 RID: 32694
		// (get) Token: 0x06020ACA RID: 133834 RVA: 0x00305857 File Offset: 0x00303A57
		// (set) Token: 0x06020ACB RID: 133835 RVA: 0x00305867 File Offset: 0x00303A67
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FB7 RID: 32695
		// (get) Token: 0x06020ACC RID: 133836 RVA: 0x00305878 File Offset: 0x00303A78
		// (set) Token: 0x06020ACD RID: 133837 RVA: 0x00305888 File Offset: 0x00303A88
		public unsafe float DecelerationRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_DecelerationRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_DecelerationRate) = value;
			}
		}

		// Token: 0x17007FB8 RID: 32696
		// (get) Token: 0x06020ACE RID: 133838 RVA: 0x00305899 File Offset: 0x00303A99
		// (set) Token: 0x06020ACF RID: 133839 RVA: 0x003058A9 File Offset: 0x00303AA9
		public unsafe LTweenEase ScrollToEaseType
		{
			get
			{
				return (LTweenEase)(*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollToEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollToEaseType) = (byte)value;
			}
		}

		// Token: 0x17007FB9 RID: 32697
		// (get) Token: 0x06020AD0 RID: 133840 RVA: 0x003058BA File Offset: 0x00303ABA
		// (set) Token: 0x06020AD1 RID: 133841 RVA: 0x003058CA File Offset: 0x00303ACA
		public unsafe float ScrollToDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollToDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollToDuration) = value;
			}
		}

		// Token: 0x17007FBA RID: 32698
		// (get) Token: 0x06020AD2 RID: 133842 RVA: 0x003058DB File Offset: 0x00303ADB
		// (set) Token: 0x06020AD3 RID: 133843 RVA: 0x003058EB File Offset: 0x00303AEB
		public unsafe float Elasticity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Elasticity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Elasticity) = value;
			}
		}

		// Token: 0x17007FBB RID: 32699
		// (get) Token: 0x06020AD4 RID: 133844 RVA: 0x003058FC File Offset: 0x00303AFC
		// (set) Token: 0x06020AD5 RID: 133845 RVA: 0x0030590C File Offset: 0x00303B0C
		public unsafe float ScrollOutOfRangeModulus
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollOutOfRangeModulus);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ScrollOutOfRangeModulus) = value;
			}
		}

		// Token: 0x17007FBC RID: 32700
		// (get) Token: 0x06020AD6 RID: 133846 RVA: 0x0030591D File Offset: 0x00303B1D
		// (set) Token: 0x06020AD7 RID: 133847 RVA: 0x0030592D File Offset: 0x00303B2D
		public unsafe bool bCallTweenerCompleteCallbackWhenKill
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_bCallTweenerCompleteCallbackWhenKill) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_bCallTweenerCompleteCallbackWhenKill) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FBD RID: 32701
		// (get) Token: 0x06020AD8 RID: 133848 RVA: 0x0030593E File Offset: 0x00303B3E
		// (set) Token: 0x06020AD9 RID: 133849 RVA: 0x0030594E File Offset: 0x00303B4E
		public unsafe bool bUnderSizeScrollEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_bUnderSizeScrollEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_bUnderSizeScrollEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FBE RID: 32702
		// (get) Token: 0x06020ADA RID: 133850 RVA: 0x0030595F File Offset: 0x00303B5F
		// (set) Token: 0x06020ADB RID: 133851 RVA: 0x0030596F File Offset: 0x00303B6F
		public unsafe bool CanScroll
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_CanScroll) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_CanScroll) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FBF RID: 32703
		// (get) Token: 0x06020ADC RID: 133852 RVA: 0x00305980 File Offset: 0x00303B80
		// (set) Token: 0x06020ADD RID: 133853 RVA: 0x00305990 File Offset: 0x00303B90
		public unsafe bool RayCastTargetForScrollView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_RayCastTargetForScrollView) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_RayCastTargetForScrollView) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FC0 RID: 32704
		// (get) Token: 0x06020ADE RID: 133854 RVA: 0x003059A4 File Offset: 0x00303BA4
		// (set) Token: 0x06020ADF RID: 133855 RVA: 0x003059DD File Offset: 0x00303BDD
		public FLGUIDragDelegateOneParams OnPointerBeginDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDragDelegateOneParams result;
				if ((result = this._OnPointerBeginDragCallBack) == null)
				{
					result = (this._OnPointerBeginDragCallBack = new FLGUIDragDelegateOneParams(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnPointerBeginDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnPointerBeginDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007FC1 RID: 32705
		// (get) Token: 0x06020AE0 RID: 133856 RVA: 0x00305A00 File Offset: 0x00303C00
		// (set) Token: 0x06020AE1 RID: 133857 RVA: 0x00305A39 File Offset: 0x00303C39
		public FLGUIDragDelegateOneParams OnPointerEndDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDragDelegateOneParams result;
				if ((result = this._OnPointerEndDragCallBack) == null)
				{
					result = (this._OnPointerEndDragCallBack = new FLGUIDragDelegateOneParams(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnPointerEndDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnPointerEndDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007FC2 RID: 32706
		// (get) Token: 0x06020AE2 RID: 133858 RVA: 0x00305A5C File Offset: 0x00303C5C
		// (set) Token: 0x06020AE3 RID: 133859 RVA: 0x00305A95 File Offset: 0x00303C95
		public FLGUIScrollViewDownUp OnScrollViewDownUpCallback
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIScrollViewDownUp result;
				if ((result = this._OnScrollViewDownUpCallback) == null)
				{
					result = (this._OnScrollViewDownUpCallback = new FLGUIScrollViewDownUp(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnScrollViewDownUpCallback, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnScrollViewDownUpCallback, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007FC3 RID: 32707
		// (get) Token: 0x06020AE4 RID: 133860 RVA: 0x00305AB6 File Offset: 0x00303CB6
		// (set) Token: 0x06020AE5 RID: 133861 RVA: 0x00305ACA File Offset: 0x00303CCA
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> ContentUIItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ContentUIItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ContentUIItem) = value;
			}
		}

		// Token: 0x17007FC4 RID: 32708
		// (get) Token: 0x06020AE6 RID: 133862 RVA: 0x00305ADF File Offset: 0x00303CDF
		// (set) Token: 0x06020AE7 RID: 133863 RVA: 0x00305AF3 File Offset: 0x00303CF3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> ContentParentUIItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ContentParentUIItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_ContentParentUIItem) = value;
			}
		}

		// Token: 0x17007FC5 RID: 32709
		// (get) Token: 0x06020AE8 RID: 133864 RVA: 0x00305B08 File Offset: 0x00303D08
		// (set) Token: 0x06020AE9 RID: 133865 RVA: 0x00305B1C File Offset: 0x00303D1C
		public unsafe FVector2D Progress
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Progress);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_Progress) = value;
			}
		}

		// Token: 0x17007FC6 RID: 32710
		// (get) Token: 0x06020AEA RID: 133866 RVA: 0x00305B31 File Offset: 0x00303D31
		// (set) Token: 0x06020AEB RID: 133867 RVA: 0x00305B45 File Offset: 0x00303D45
		[Nullable(2)]
		public unsafe ULTweener Tweener
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUIScrollViewComponent.__PropertyOffset_Tweener);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUIScrollViewComponent.__PropertyOffset_Tweener, value);
			}
		}

		// Token: 0x17007FC7 RID: 32711
		// (get) Token: 0x06020AEC RID: 133868 RVA: 0x00305B5C File Offset: 0x00303D5C
		// (set) Token: 0x06020AED RID: 133869 RVA: 0x00305B95 File Offset: 0x00303D95
		public FLGUIScrollViewDynamicDelegate OnScrollValueChange
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIScrollViewDynamicDelegate result;
				if ((result = this._OnScrollValueChange) == null)
				{
					result = (this._OnScrollValueChange = new FLGUIScrollViewDynamicDelegate(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnScrollValueChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIScrollViewComponent.__PropertyOffset_OnScrollValueChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06020AEE RID: 133870 RVA: 0x00305BB6 File Offset: 0x00303DB6
		[NullableContext(2)]
		public void TriggerScrollEventManually(ULGUIPointerEventData PointerEventData)
		{
			UUIScrollViewComponent.__TriggerScrollEventManually_Internal(base.NativePtr, (PointerEventData != null) ? PointerEventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020AEF RID: 133871 RVA: 0x00305BD3 File Offset: 0x00303DD3
		public void StopMovement()
		{
			UUIScrollViewComponent.__StopMovement_Internal(base.NativePtr);
		}

		// Token: 0x06020AF0 RID: 133872 RVA: 0x00305BE0 File Offset: 0x00303DE0
		public void SetVerticalVelocity(float Value)
		{
			UUIScrollViewComponent.__SetVerticalVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF1 RID: 133873 RVA: 0x00305BEE File Offset: 0x00303DEE
		public void SetVertical(bool Value)
		{
			UUIScrollViewComponent.__SetVertical_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF2 RID: 133874 RVA: 0x00305BFC File Offset: 0x00303DFC
		public void SetVelocity(float Value)
		{
			UUIScrollViewComponent.__SetVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF3 RID: 133875 RVA: 0x00305C0A File Offset: 0x00303E0A
		public void SetUnderSizeScrollEnabled(bool bEnabled)
		{
			UUIScrollViewComponent.__SetUnderSizeScrollEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06020AF4 RID: 133876 RVA: 0x00305C18 File Offset: 0x00303E18
		public void SetScrollValue(FVector2D Value)
		{
			UUIScrollViewComponent.__SetScrollValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF5 RID: 133877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollUseDebug(bool value);

		// Token: 0x06020AF6 RID: 133878
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollSensitivityDebug(float value);

		// Token: 0x06020AF7 RID: 133879 RVA: 0x00305C26 File Offset: 0x00303E26
		public void SetScrollProgressIncrement(float Value)
		{
			UUIScrollViewComponent.__SetScrollProgressIncrement_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF8 RID: 133880 RVA: 0x00305C34 File Offset: 0x00303E34
		public void SetScrollProgress(float Value)
		{
			UUIScrollViewComponent.__SetScrollProgress_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AF9 RID: 133881
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollOutOfRangeModulusDebug(float value);

		// Token: 0x06020AFA RID: 133882 RVA: 0x00305C42 File Offset: 0x00303E42
		public void SetRayCastTargetForScrollView(bool newRayCastTarget)
		{
			UUIScrollViewComponent.__SetRayCastTargetForScrollView_Internal(base.NativePtr, newRayCastTarget);
		}

		// Token: 0x06020AFB RID: 133883 RVA: 0x00305C50 File Offset: 0x00303E50
		public void SetHorizontalVelocity(float Value)
		{
			UUIScrollViewComponent.__SetHorizontalVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AFC RID: 133884 RVA: 0x00305C5E File Offset: 0x00303E5E
		public void SetHorizontal(bool Value)
		{
			UUIScrollViewComponent.__SetHorizontal_Internal(base.NativePtr, Value);
		}

		// Token: 0x06020AFD RID: 133885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetElasticityDebug(float value);

		// Token: 0x06020AFE RID: 133886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDecelerationRateDebug(float value);

		// Token: 0x06020AFF RID: 133887 RVA: 0x00305C6C File Offset: 0x00303E6C
		public void SetCanScroll(bool bCanScroll)
		{
			UUIScrollViewComponent.__SetCanScroll_Internal(base.NativePtr, bCanScroll);
		}

		// Token: 0x06020B00 RID: 133888 RVA: 0x00305C7A File Offset: 0x00303E7A
		public bool GetVertical()
		{
			return UUIScrollViewComponent.__GetVertical_Internal(base.NativePtr);
		}

		// Token: 0x06020B01 RID: 133889 RVA: 0x00305C87 File Offset: 0x00303E87
		public FVector2D GetVelocity()
		{
			return UUIScrollViewComponent.__GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06020B02 RID: 133890 RVA: 0x00305C94 File Offset: 0x00303E94
		public bool GetUnderSizeScrollEnabled()
		{
			return UUIScrollViewComponent.__GetUnderSizeScrollEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06020B03 RID: 133891
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetScrollUseDebug();

		// Token: 0x06020B04 RID: 133892
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetScrollSensitivityDebug();

		// Token: 0x06020B05 RID: 133893
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetScrollOutOfRangeModulusDebug();

		// Token: 0x06020B06 RID: 133894 RVA: 0x00305CA1 File Offset: 0x00303EA1
		public bool GetRayCastTargetForScrollView()
		{
			return UUIScrollViewComponent.__GetRayCastTargetForScrollView_Internal(base.NativePtr);
		}

		// Token: 0x06020B07 RID: 133895 RVA: 0x00305CAE File Offset: 0x00303EAE
		public bool GetHorizontal()
		{
			return UUIScrollViewComponent.__GetHorizontal_Internal(base.NativePtr);
		}

		// Token: 0x06020B08 RID: 133896
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetElasticityDegbug();

		// Token: 0x06020B09 RID: 133897
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDecelerationRateDegbug();

		// Token: 0x06020B0A RID: 133898 RVA: 0x00305CBB File Offset: 0x00303EBB
		[NullableContext(2)]
		public AUIBaseActor GetContent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewComponent.__GetContent_Internal(base.NativePtr));
		}

		// Token: 0x06020B0B RID: 133899 RVA: 0x00305CCD File Offset: 0x00303ECD
		public bool GetCanScroll()
		{
			return UUIScrollViewComponent.__GetCanScroll_Internal(base.NativePtr);
		}

		// Token: 0x06020B0C RID: 133900 RVA: 0x00305CDA File Offset: 0x00303EDA
		public bool CheckContentUnderSize()
		{
			return UUIScrollViewComponent.__CheckContentUnderSize_Internal(base.NativePtr);
		}

		// Token: 0x06020B0D RID: 133901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerScrollEventManually_Internal(IntPtr @this, IntPtr PointerEventData);

		// Token: 0x06020B0E RID: 133902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovement_Internal(IntPtr @this);

		// Token: 0x06020B0F RID: 133903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06020B10 RID: 133904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertical_Internal(IntPtr @this, bool Value);

		// Token: 0x06020B11 RID: 133905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06020B12 RID: 133906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUnderSizeScrollEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06020B13 RID: 133907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollValue_Internal(IntPtr @this, FVector2D Value);

		// Token: 0x06020B14 RID: 133908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollProgressIncrement_Internal(IntPtr @this, float Value);

		// Token: 0x06020B15 RID: 133909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollProgress_Internal(IntPtr @this, float Value);

		// Token: 0x06020B16 RID: 133910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRayCastTargetForScrollView_Internal(IntPtr @this, bool newRayCastTarget);

		// Token: 0x06020B17 RID: 133911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06020B18 RID: 133912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontal_Internal(IntPtr @this, bool Value);

		// Token: 0x06020B19 RID: 133913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanScroll_Internal(IntPtr @this, bool bCanScroll);

		// Token: 0x06020B1A RID: 133914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVertical_Internal(IntPtr @this);

		// Token: 0x06020B1B RID: 133915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetVelocity_Internal(IntPtr @this);

		// Token: 0x06020B1C RID: 133916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUnderSizeScrollEnabled_Internal(IntPtr @this);

		// Token: 0x06020B1D RID: 133917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRayCastTargetForScrollView_Internal(IntPtr @this);

		// Token: 0x06020B1E RID: 133918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHorizontal_Internal(IntPtr @this);

		// Token: 0x06020B1F RID: 133919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetContent_Internal(IntPtr @this);

		// Token: 0x06020B20 RID: 133920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCanScroll_Internal(IntPtr @this);

		// Token: 0x06020B21 RID: 133921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckContentUnderSize_Internal(IntPtr @this);

		// Token: 0x06020B22 RID: 133922 RVA: 0x00305CE7 File Offset: 0x00303EE7
		static UUIScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollViewComponent");
		}

		// Token: 0x06020B23 RID: 133923 RVA: 0x00305CF5 File Offset: 0x00303EF5
		protected UUIScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117AE RID: 71598
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x040117AF RID: 71599
		internal static int __InterfaceOffset_ILGUIPointerScrollInterface;

		// Token: 0x040117B0 RID: 71600
		internal static int __InterfaceOffset_ILGUIPointerDownUpInterface;

		// Token: 0x040117B1 RID: 71601
		internal static int __InterfaceOffset_ILGUIPointerInterruptInterface;

		// Token: 0x040117B2 RID: 71602
		public new const string __ObjectPath = "/Script/LGUI.UIScrollViewComponent";

		// Token: 0x040117B3 RID: 71603
		private static IntPtr _ClassPtr;

		// Token: 0x040117B4 RID: 71604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117B5 RID: 71605
		internal static int __PropertyOffset_Content;

		// Token: 0x040117B6 RID: 71606
		internal static int __PropertyOffset_Horizontal;

		// Token: 0x040117B7 RID: 71607
		internal static int __PropertyOffset_Vertical;

		// Token: 0x040117B8 RID: 71608
		internal static int __PropertyOffset_ScrollSensitivity;

		// Token: 0x040117B9 RID: 71609
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040117BA RID: 71610
		internal static int __PropertyOffset_DecelerationRate;

		// Token: 0x040117BB RID: 71611
		internal static int __PropertyOffset_ScrollToEaseType;

		// Token: 0x040117BC RID: 71612
		internal static int __PropertyOffset_ScrollToDuration;

		// Token: 0x040117BD RID: 71613
		internal static int __PropertyOffset_Elasticity;

		// Token: 0x040117BE RID: 71614
		internal static int __PropertyOffset_ScrollOutOfRangeModulus;

		// Token: 0x040117BF RID: 71615
		internal static int __PropertyOffset_bCallTweenerCompleteCallbackWhenKill;

		// Token: 0x040117C0 RID: 71616
		internal static int __PropertyOffset_bUnderSizeScrollEnabled;

		// Token: 0x040117C1 RID: 71617
		internal static int __PropertyOffset_CanScroll;

		// Token: 0x040117C2 RID: 71618
		internal static int __PropertyOffset_RayCastTargetForScrollView;

		// Token: 0x040117C3 RID: 71619
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x040117C4 RID: 71620
		[Nullable(2)]
		private FLGUIDragDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x040117C5 RID: 71621
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x040117C6 RID: 71622
		[Nullable(2)]
		private FLGUIDragDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x040117C7 RID: 71623
		internal static int __PropertyOffset_OnScrollViewDownUpCallback;

		// Token: 0x040117C8 RID: 71624
		[Nullable(2)]
		private FLGUIScrollViewDownUp _OnScrollViewDownUpCallback;

		// Token: 0x040117C9 RID: 71625
		internal static int __PropertyOffset_ContentUIItem;

		// Token: 0x040117CA RID: 71626
		internal static int __PropertyOffset_ContentParentUIItem;

		// Token: 0x040117CB RID: 71627
		internal static int __PropertyOffset_Progress;

		// Token: 0x040117CC RID: 71628
		internal static int __PropertyOffset_Tweener;

		// Token: 0x040117CD RID: 71629
		internal static int __PropertyOffset_OnScrollValueChange;

		// Token: 0x040117CE RID: 71630
		[Nullable(2)]
		private FLGUIScrollViewDynamicDelegate _OnScrollValueChange;
	}
}
