using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071E RID: 1822
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIScrollViewComponent")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public class UUIScrollViewComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009CE3 RID: 40163 RVA: 0x000EA195 File Offset: 0x000E8395
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollViewComponent._ClassPtr;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x000EA1A4 File Offset: 0x000E83A4
		public UUIScrollViewComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x000EA1CC File Offset: 0x000E83CC
		public UUIScrollViewComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D1B RID: 7451
		// (get) Token: 0x06009CE6 RID: 40166 RVA: 0x000EA1FF File Offset: 0x000E83FF
		// (set) Token: 0x06009CE7 RID: 40167 RVA: 0x000EA213 File Offset: 0x000E8413
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

		// Token: 0x17001D1C RID: 7452
		// (get) Token: 0x06009CE8 RID: 40168 RVA: 0x000EA228 File Offset: 0x000E8428
		// (set) Token: 0x06009CE9 RID: 40169 RVA: 0x000EA238 File Offset: 0x000E8438
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

		// Token: 0x17001D1D RID: 7453
		// (get) Token: 0x06009CEA RID: 40170 RVA: 0x000EA249 File Offset: 0x000E8449
		// (set) Token: 0x06009CEB RID: 40171 RVA: 0x000EA259 File Offset: 0x000E8459
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

		// Token: 0x17001D1E RID: 7454
		// (get) Token: 0x06009CEC RID: 40172 RVA: 0x000EA26A File Offset: 0x000E846A
		// (set) Token: 0x06009CED RID: 40173 RVA: 0x000EA27A File Offset: 0x000E847A
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

		// Token: 0x17001D1F RID: 7455
		// (get) Token: 0x06009CEE RID: 40174 RVA: 0x000EA28B File Offset: 0x000E848B
		// (set) Token: 0x06009CEF RID: 40175 RVA: 0x000EA29B File Offset: 0x000E849B
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

		// Token: 0x17001D20 RID: 7456
		// (get) Token: 0x06009CF0 RID: 40176 RVA: 0x000EA2AC File Offset: 0x000E84AC
		// (set) Token: 0x06009CF1 RID: 40177 RVA: 0x000EA2BC File Offset: 0x000E84BC
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

		// Token: 0x17001D21 RID: 7457
		// (get) Token: 0x06009CF2 RID: 40178 RVA: 0x000EA2CD File Offset: 0x000E84CD
		// (set) Token: 0x06009CF3 RID: 40179 RVA: 0x000EA2DD File Offset: 0x000E84DD
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

		// Token: 0x17001D22 RID: 7458
		// (get) Token: 0x06009CF4 RID: 40180 RVA: 0x000EA2EE File Offset: 0x000E84EE
		// (set) Token: 0x06009CF5 RID: 40181 RVA: 0x000EA2FE File Offset: 0x000E84FE
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

		// Token: 0x17001D23 RID: 7459
		// (get) Token: 0x06009CF6 RID: 40182 RVA: 0x000EA30F File Offset: 0x000E850F
		// (set) Token: 0x06009CF7 RID: 40183 RVA: 0x000EA31F File Offset: 0x000E851F
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

		// Token: 0x17001D24 RID: 7460
		// (get) Token: 0x06009CF8 RID: 40184 RVA: 0x000EA330 File Offset: 0x000E8530
		// (set) Token: 0x06009CF9 RID: 40185 RVA: 0x000EA340 File Offset: 0x000E8540
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

		// Token: 0x17001D25 RID: 7461
		// (get) Token: 0x06009CFA RID: 40186 RVA: 0x000EA351 File Offset: 0x000E8551
		// (set) Token: 0x06009CFB RID: 40187 RVA: 0x000EA361 File Offset: 0x000E8561
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

		// Token: 0x17001D26 RID: 7462
		// (get) Token: 0x06009CFC RID: 40188 RVA: 0x000EA372 File Offset: 0x000E8572
		// (set) Token: 0x06009CFD RID: 40189 RVA: 0x000EA382 File Offset: 0x000E8582
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

		// Token: 0x17001D27 RID: 7463
		// (get) Token: 0x06009CFE RID: 40190 RVA: 0x000EA393 File Offset: 0x000E8593
		// (set) Token: 0x06009CFF RID: 40191 RVA: 0x000EA3A3 File Offset: 0x000E85A3
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

		// Token: 0x17001D28 RID: 7464
		// (get) Token: 0x06009D00 RID: 40192 RVA: 0x000EA3B4 File Offset: 0x000E85B4
		// (set) Token: 0x06009D01 RID: 40193 RVA: 0x000EA3C4 File Offset: 0x000E85C4
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

		// Token: 0x17001D29 RID: 7465
		// (get) Token: 0x06009D02 RID: 40194 RVA: 0x000EA3D8 File Offset: 0x000E85D8
		// (set) Token: 0x06009D03 RID: 40195 RVA: 0x000EA411 File Offset: 0x000E8611
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

		// Token: 0x17001D2A RID: 7466
		// (get) Token: 0x06009D04 RID: 40196 RVA: 0x000EA434 File Offset: 0x000E8634
		// (set) Token: 0x06009D05 RID: 40197 RVA: 0x000EA46D File Offset: 0x000E866D
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

		// Token: 0x17001D2B RID: 7467
		// (get) Token: 0x06009D06 RID: 40198 RVA: 0x000EA490 File Offset: 0x000E8690
		// (set) Token: 0x06009D07 RID: 40199 RVA: 0x000EA4C9 File Offset: 0x000E86C9
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

		// Token: 0x17001D2C RID: 7468
		// (get) Token: 0x06009D08 RID: 40200 RVA: 0x000EA4EA File Offset: 0x000E86EA
		// (set) Token: 0x06009D09 RID: 40201 RVA: 0x000EA4FE File Offset: 0x000E86FE
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

		// Token: 0x17001D2D RID: 7469
		// (get) Token: 0x06009D0A RID: 40202 RVA: 0x000EA513 File Offset: 0x000E8713
		// (set) Token: 0x06009D0B RID: 40203 RVA: 0x000EA527 File Offset: 0x000E8727
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

		// Token: 0x17001D2E RID: 7470
		// (get) Token: 0x06009D0C RID: 40204 RVA: 0x000EA53C File Offset: 0x000E873C
		// (set) Token: 0x06009D0D RID: 40205 RVA: 0x000EA550 File Offset: 0x000E8750
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

		// Token: 0x17001D2F RID: 7471
		// (get) Token: 0x06009D0E RID: 40206 RVA: 0x000EA565 File Offset: 0x000E8765
		// (set) Token: 0x06009D0F RID: 40207 RVA: 0x000EA579 File Offset: 0x000E8779
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

		// Token: 0x17001D30 RID: 7472
		// (get) Token: 0x06009D10 RID: 40208 RVA: 0x000EA590 File Offset: 0x000E8790
		// (set) Token: 0x06009D11 RID: 40209 RVA: 0x000EA5C9 File Offset: 0x000E87C9
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

		// Token: 0x06009D12 RID: 40210 RVA: 0x000EA5EA File Offset: 0x000E87EA
		[NullableContext(2)]
		public void TriggerScrollEventManually(ULGUIPointerEventData PointerEventData)
		{
			UUIScrollViewComponent.__TriggerScrollEventManually_Internal(base.NativePtr, (PointerEventData != null) ? PointerEventData.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x000EA607 File Offset: 0x000E8807
		public void StopMovement()
		{
			UUIScrollViewComponent.__StopMovement_Internal(base.NativePtr);
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x000EA614 File Offset: 0x000E8814
		public void SetVerticalVelocity(float Value)
		{
			UUIScrollViewComponent.__SetVerticalVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x000EA622 File Offset: 0x000E8822
		public void SetVertical(bool Value)
		{
			UUIScrollViewComponent.__SetVertical_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x000EA630 File Offset: 0x000E8830
		public void SetVelocity(float Value)
		{
			UUIScrollViewComponent.__SetVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x000EA63E File Offset: 0x000E883E
		public void SetUnderSizeScrollEnabled(bool bEnabled)
		{
			UUIScrollViewComponent.__SetUnderSizeScrollEnabled_Internal(base.NativePtr, bEnabled);
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x000EA64C File Offset: 0x000E884C
		public void SetScrollValue(FVector2D Value)
		{
			UUIScrollViewComponent.__SetScrollValue_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D19 RID: 40217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollUseDebug(bool value);

		// Token: 0x06009D1A RID: 40218
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollSensitivityDebug(float value);

		// Token: 0x06009D1B RID: 40219 RVA: 0x000EA65A File Offset: 0x000E885A
		public void SetScrollProgressIncrement(float Value)
		{
			UUIScrollViewComponent.__SetScrollProgressIncrement_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x000EA668 File Offset: 0x000E8868
		public void SetScrollProgress(float Value)
		{
			UUIScrollViewComponent.__SetScrollProgress_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D1D RID: 40221
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetScrollOutOfRangeModulusDebug(float value);

		// Token: 0x06009D1E RID: 40222 RVA: 0x000EA676 File Offset: 0x000E8876
		public void SetRayCastTargetForScrollView(bool newRayCastTarget)
		{
			UUIScrollViewComponent.__SetRayCastTargetForScrollView_Internal(base.NativePtr, newRayCastTarget);
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x000EA684 File Offset: 0x000E8884
		public void SetHorizontalVelocity(float Value)
		{
			UUIScrollViewComponent.__SetHorizontalVelocity_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x000EA692 File Offset: 0x000E8892
		public void SetHorizontal(bool Value)
		{
			UUIScrollViewComponent.__SetHorizontal_Internal(base.NativePtr, Value);
		}

		// Token: 0x06009D21 RID: 40225
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetElasticityDebug(float value);

		// Token: 0x06009D22 RID: 40226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetDecelerationRateDebug(float value);

		// Token: 0x06009D23 RID: 40227 RVA: 0x000EA6A0 File Offset: 0x000E88A0
		public void SetCanScroll(bool bCanScroll)
		{
			UUIScrollViewComponent.__SetCanScroll_Internal(base.NativePtr, bCanScroll);
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x000EA6AE File Offset: 0x000E88AE
		public bool GetVertical()
		{
			return UUIScrollViewComponent.__GetVertical_Internal(base.NativePtr);
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x000EA6BB File Offset: 0x000E88BB
		public FVector2D GetVelocity()
		{
			return UUIScrollViewComponent.__GetVelocity_Internal(base.NativePtr);
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x000EA6C8 File Offset: 0x000E88C8
		public bool GetUnderSizeScrollEnabled()
		{
			return UUIScrollViewComponent.__GetUnderSizeScrollEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06009D27 RID: 40231
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GetScrollUseDebug();

		// Token: 0x06009D28 RID: 40232
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetScrollSensitivityDebug();

		// Token: 0x06009D29 RID: 40233
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetScrollOutOfRangeModulusDebug();

		// Token: 0x06009D2A RID: 40234 RVA: 0x000EA6D5 File Offset: 0x000E88D5
		public bool GetRayCastTargetForScrollView()
		{
			return UUIScrollViewComponent.__GetRayCastTargetForScrollView_Internal(base.NativePtr);
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x000EA6E2 File Offset: 0x000E88E2
		public bool GetHorizontal()
		{
			return UUIScrollViewComponent.__GetHorizontal_Internal(base.NativePtr);
		}

		// Token: 0x06009D2C RID: 40236
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetElasticityDegbug();

		// Token: 0x06009D2D RID: 40237
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetDecelerationRateDegbug();

		// Token: 0x06009D2E RID: 40238 RVA: 0x000EA6EF File Offset: 0x000E88EF
		[NullableContext(2)]
		public AUIBaseActor GetContent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewComponent.__GetContent_Internal(base.NativePtr));
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x000EA701 File Offset: 0x000E8901
		public bool GetCanScroll()
		{
			return UUIScrollViewComponent.__GetCanScroll_Internal(base.NativePtr);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x000EA70E File Offset: 0x000E890E
		public bool CheckContentUnderSize()
		{
			return UUIScrollViewComponent.__CheckContentUnderSize_Internal(base.NativePtr);
		}

		// Token: 0x06009D31 RID: 40241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TriggerScrollEventManually_Internal(IntPtr @this, IntPtr PointerEventData);

		// Token: 0x06009D32 RID: 40242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopMovement_Internal(IntPtr @this);

		// Token: 0x06009D33 RID: 40243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06009D34 RID: 40244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVertical_Internal(IntPtr @this, bool Value);

		// Token: 0x06009D35 RID: 40245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06009D36 RID: 40246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUnderSizeScrollEnabled_Internal(IntPtr @this, bool bEnabled);

		// Token: 0x06009D37 RID: 40247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollValue_Internal(IntPtr @this, FVector2D Value);

		// Token: 0x06009D38 RID: 40248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollProgressIncrement_Internal(IntPtr @this, float Value);

		// Token: 0x06009D39 RID: 40249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollProgress_Internal(IntPtr @this, float Value);

		// Token: 0x06009D3A RID: 40250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRayCastTargetForScrollView_Internal(IntPtr @this, bool newRayCastTarget);

		// Token: 0x06009D3B RID: 40251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalVelocity_Internal(IntPtr @this, float Value);

		// Token: 0x06009D3C RID: 40252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontal_Internal(IntPtr @this, bool Value);

		// Token: 0x06009D3D RID: 40253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanScroll_Internal(IntPtr @this, bool bCanScroll);

		// Token: 0x06009D3E RID: 40254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVertical_Internal(IntPtr @this);

		// Token: 0x06009D3F RID: 40255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetVelocity_Internal(IntPtr @this);

		// Token: 0x06009D40 RID: 40256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUnderSizeScrollEnabled_Internal(IntPtr @this);

		// Token: 0x06009D41 RID: 40257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRayCastTargetForScrollView_Internal(IntPtr @this);

		// Token: 0x06009D42 RID: 40258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetHorizontal_Internal(IntPtr @this);

		// Token: 0x06009D43 RID: 40259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetContent_Internal(IntPtr @this);

		// Token: 0x06009D44 RID: 40260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCanScroll_Internal(IntPtr @this);

		// Token: 0x06009D45 RID: 40261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckContentUnderSize_Internal(IntPtr @this);

		// Token: 0x06009D46 RID: 40262 RVA: 0x000EA71B File Offset: 0x000E891B
		static UUIScrollViewComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollViewComponent");
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x000EA729 File Offset: 0x000E8929
		protected UUIScrollViewComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400439F RID: 17311
		public new const string __ObjectPath = "/Script/LGUI.UIScrollViewComponent";

		// Token: 0x040043A0 RID: 17312
		private static IntPtr _ClassPtr;

		// Token: 0x040043A1 RID: 17313
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043A2 RID: 17314
		internal static int __PropertyOffset_Content;

		// Token: 0x040043A3 RID: 17315
		internal static int __PropertyOffset_Horizontal;

		// Token: 0x040043A4 RID: 17316
		internal static int __PropertyOffset_Vertical;

		// Token: 0x040043A5 RID: 17317
		internal static int __PropertyOffset_ScrollSensitivity;

		// Token: 0x040043A6 RID: 17318
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040043A7 RID: 17319
		internal static int __PropertyOffset_DecelerationRate;

		// Token: 0x040043A8 RID: 17320
		internal static int __PropertyOffset_ScrollToEaseType;

		// Token: 0x040043A9 RID: 17321
		internal static int __PropertyOffset_ScrollToDuration;

		// Token: 0x040043AA RID: 17322
		internal static int __PropertyOffset_Elasticity;

		// Token: 0x040043AB RID: 17323
		internal static int __PropertyOffset_ScrollOutOfRangeModulus;

		// Token: 0x040043AC RID: 17324
		internal static int __PropertyOffset_bCallTweenerCompleteCallbackWhenKill;

		// Token: 0x040043AD RID: 17325
		internal static int __PropertyOffset_bUnderSizeScrollEnabled;

		// Token: 0x040043AE RID: 17326
		internal static int __PropertyOffset_CanScroll;

		// Token: 0x040043AF RID: 17327
		internal static int __PropertyOffset_RayCastTargetForScrollView;

		// Token: 0x040043B0 RID: 17328
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x040043B1 RID: 17329
		[Nullable(2)]
		private FLGUIDragDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x040043B2 RID: 17330
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x040043B3 RID: 17331
		[Nullable(2)]
		private FLGUIDragDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x040043B4 RID: 17332
		internal static int __PropertyOffset_OnScrollViewDownUpCallback;

		// Token: 0x040043B5 RID: 17333
		[Nullable(2)]
		private FLGUIScrollViewDownUp _OnScrollViewDownUpCallback;

		// Token: 0x040043B6 RID: 17334
		internal static int __PropertyOffset_ContentUIItem;

		// Token: 0x040043B7 RID: 17335
		internal static int __PropertyOffset_ContentParentUIItem;

		// Token: 0x040043B8 RID: 17336
		internal static int __PropertyOffset_Progress;

		// Token: 0x040043B9 RID: 17337
		internal static int __PropertyOffset_Tweener;

		// Token: 0x040043BA RID: 17338
		internal static int __PropertyOffset_OnScrollValueChange;

		// Token: 0x040043BB RID: 17339
		[Nullable(2)]
		private FLGUIScrollViewDynamicDelegate _OnScrollValueChange;
	}
}
