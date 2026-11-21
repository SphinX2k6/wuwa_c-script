using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000874 RID: 2164
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Widget")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public abstract class UWidget : UVisual, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BC13 RID: 48147 RVA: 0x0012CD9E File Offset: 0x0012AF9E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidget._ClassPtr;
		}

		// Token: 0x170022D3 RID: 8915
		// (get) Token: 0x0600BC14 RID: 48148 RVA: 0x0012CDAA File Offset: 0x0012AFAA
		// (set) Token: 0x0600BC15 RID: 48149 RVA: 0x0012CDBE File Offset: 0x0012AFBE
		public unsafe UPanelSlot Slot
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPanelSlot>(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_Slot);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_Slot, value);
			}
		}

		// Token: 0x170022D4 RID: 8916
		// (get) Token: 0x0600BC16 RID: 48150 RVA: 0x0012CDD4 File Offset: 0x0012AFD4
		// (set) Token: 0x0600BC17 RID: 48151 RVA: 0x0012CE0D File Offset: 0x0012B00D
		[Nullable(1)]
		public FGetBool bIsEnabledDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetBool result;
				if ((result = this._bIsEnabledDelegate) == null)
				{
					result = (this._bIsEnabledDelegate = new FGetBool(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsEnabledDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsEnabledDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022D5 RID: 8917
		// (get) Token: 0x0600BC18 RID: 48152 RVA: 0x0012CE30 File Offset: 0x0012B030
		// (set) Token: 0x0600BC19 RID: 48153 RVA: 0x0012CE69 File Offset: 0x0012B069
		[Nullable(1)]
		public unsafe FText ToolTipText
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._ToolTipText) == null)
				{
					result = (this._ToolTipText = new FText(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_ToolTipText, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)UWidget.__PropertyOffset_ToolTipText)), value.NativePtr, 1);
			}
		}

		// Token: 0x170022D6 RID: 8918
		// (get) Token: 0x0600BC1A RID: 48154 RVA: 0x0012CE84 File Offset: 0x0012B084
		// (set) Token: 0x0600BC1B RID: 48155 RVA: 0x0012CEBD File Offset: 0x0012B0BD
		[Nullable(1)]
		public FGetText ToolTipTextDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetText result;
				if ((result = this._ToolTipTextDelegate) == null)
				{
					result = (this._ToolTipTextDelegate = new FGetText(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_ToolTipTextDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_ToolTipTextDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022D7 RID: 8919
		// (get) Token: 0x0600BC1C RID: 48156 RVA: 0x0012CEDE File Offset: 0x0012B0DE
		// (set) Token: 0x0600BC1D RID: 48157 RVA: 0x0012CEF2 File Offset: 0x0012B0F2
		public unsafe UWidget ToolTipWidget
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidget>(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_ToolTipWidget);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_ToolTipWidget, value);
			}
		}

		// Token: 0x170022D8 RID: 8920
		// (get) Token: 0x0600BC1E RID: 48158 RVA: 0x0012CF08 File Offset: 0x0012B108
		// (set) Token: 0x0600BC1F RID: 48159 RVA: 0x0012CF41 File Offset: 0x0012B141
		[Nullable(1)]
		public FGetWidget ToolTipWidgetDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetWidget result;
				if ((result = this._ToolTipWidgetDelegate) == null)
				{
					result = (this._ToolTipWidgetDelegate = new FGetWidget(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_ToolTipWidgetDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_ToolTipWidgetDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022D9 RID: 8921
		// (get) Token: 0x0600BC20 RID: 48160 RVA: 0x0012CF64 File Offset: 0x0012B164
		// (set) Token: 0x0600BC21 RID: 48161 RVA: 0x0012CF9D File Offset: 0x0012B19D
		[Nullable(1)]
		public FGetSlateVisibility VisibilityDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGetSlateVisibility result;
				if ((result = this._VisibilityDelegate) == null)
				{
					result = (this._VisibilityDelegate = new FGetSlateVisibility(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_VisibilityDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_VisibilityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022DA RID: 8922
		// (get) Token: 0x0600BC22 RID: 48162 RVA: 0x0012CFBE File Offset: 0x0012B1BE
		// (set) Token: 0x0600BC23 RID: 48163 RVA: 0x0012CFD2 File Offset: 0x0012B1D2
		public unsafe FVector2D RenderTransformPivot
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderTransformPivot);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderTransformPivot) = value;
			}
		}

		// Token: 0x170022DB RID: 8923
		// (get) Token: 0x0600BC24 RID: 48164 RVA: 0x0012CFE7 File Offset: 0x0012B1E7
		// (set) Token: 0x0600BC25 RID: 48165 RVA: 0x0012D000 File Offset: 0x0012B200
		public unsafe bool bIsVariable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVariable) & UWidget.__PropertyMask_bIsVariable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVariable) = ((*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVariable) & ~UWidget.__PropertyMask_bIsVariable) | (value ? UWidget.__PropertyMask_bIsVariable : 0));
			}
		}

		// Token: 0x170022DC RID: 8924
		// (get) Token: 0x0600BC26 RID: 48166 RVA: 0x0012D030 File Offset: 0x0012B230
		// (set) Token: 0x0600BC27 RID: 48167 RVA: 0x0012D049 File Offset: 0x0012B249
		public unsafe bool bCreatedByConstructionScript
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bCreatedByConstructionScript) & UWidget.__PropertyMask_bCreatedByConstructionScript) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidget.__PropertyOffset_bCreatedByConstructionScript) = ((*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bCreatedByConstructionScript) & ~UWidget.__PropertyMask_bCreatedByConstructionScript) | (value ? UWidget.__PropertyMask_bCreatedByConstructionScript : 0));
			}
		}

		// Token: 0x170022DD RID: 8925
		// (get) Token: 0x0600BC28 RID: 48168 RVA: 0x0012D079 File Offset: 0x0012B279
		// (set) Token: 0x0600BC29 RID: 48169 RVA: 0x0012D092 File Offset: 0x0012B292
		public unsafe bool bIsEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsEnabled) & UWidget.__PropertyMask_bIsEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsEnabled) = ((*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsEnabled) & ~UWidget.__PropertyMask_bIsEnabled) | (value ? UWidget.__PropertyMask_bIsEnabled : 0));
			}
		}

		// Token: 0x170022DE RID: 8926
		// (get) Token: 0x0600BC2A RID: 48170 RVA: 0x0012D0C2 File Offset: 0x0012B2C2
		// (set) Token: 0x0600BC2B RID: 48171 RVA: 0x0012D0DB File Offset: 0x0012B2DB
		public unsafe bool bOverride_Cursor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bOverride_Cursor) & UWidget.__PropertyMask_bOverride_Cursor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidget.__PropertyOffset_bOverride_Cursor) = ((*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bOverride_Cursor) & ~UWidget.__PropertyMask_bOverride_Cursor) | (value ? UWidget.__PropertyMask_bOverride_Cursor : 0));
			}
		}

		// Token: 0x170022DF RID: 8927
		// (get) Token: 0x0600BC2C RID: 48172 RVA: 0x0012D10B File Offset: 0x0012B30B
		// (set) Token: 0x0600BC2D RID: 48173 RVA: 0x0012D124 File Offset: 0x0012B324
		public unsafe bool bIsVolatile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVolatile) & UWidget.__PropertyMask_bIsVolatile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVolatile) = ((*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_bIsVolatile) & ~UWidget.__PropertyMask_bIsVolatile) | (value ? UWidget.__PropertyMask_bIsVolatile : 0));
			}
		}

		// Token: 0x170022E0 RID: 8928
		// (get) Token: 0x0600BC2E RID: 48174 RVA: 0x0012D154 File Offset: 0x0012B354
		// (set) Token: 0x0600BC2F RID: 48175 RVA: 0x0012D168 File Offset: 0x0012B368
		[Nullable(0)]
		public unsafe TEnumAsByte<EMouseCursor> Cursor
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Cursor);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Cursor) = value;
			}
		}

		// Token: 0x170022E1 RID: 8929
		// (get) Token: 0x0600BC30 RID: 48176 RVA: 0x0012D17D File Offset: 0x0012B37D
		// (set) Token: 0x0600BC31 RID: 48177 RVA: 0x0012D18D File Offset: 0x0012B38D
		public unsafe ESlateVisibility Visibility
		{
			get
			{
				return (ESlateVisibility)(*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Visibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Visibility) = (byte)value;
			}
		}

		// Token: 0x170022E2 RID: 8930
		// (get) Token: 0x0600BC32 RID: 48178 RVA: 0x0012D19E File Offset: 0x0012B39E
		// (set) Token: 0x0600BC33 RID: 48179 RVA: 0x0012D1AE File Offset: 0x0012B3AE
		public unsafe float RenderOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderOpacity) = value;
			}
		}

		// Token: 0x0600BC34 RID: 48180 RVA: 0x0012D1BF File Offset: 0x0012B3BF
		public void SetVisibility(ESlateVisibility InVisibility)
		{
			UWidget.__SetVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x0600BC35 RID: 48181 RVA: 0x0012D1CD File Offset: 0x0012B3CD
		public void SetUserFocus(APlayerController PlayerController)
		{
			UWidget.__SetUserFocus_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC36 RID: 48182 RVA: 0x0012D1EA File Offset: 0x0012B3EA
		[NullableContext(1)]
		public void SetToolTipText(in FText InToolTipText)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = InToolTipText;
			UWidget.__SetToolTipText_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC37 RID: 48183 RVA: 0x0012D209 File Offset: 0x0012B409
		public void SetToolTip(UWidget Widget)
		{
			UWidget.__SetToolTip_Internal(base.NativePtr, (Widget != null) ? Widget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC38 RID: 48184 RVA: 0x0012D226 File Offset: 0x0012B426
		public void SetRenderTranslation(FVector2D Translation)
		{
			UWidget.__SetRenderTranslation_Internal(base.NativePtr, Translation);
		}

		// Token: 0x0600BC39 RID: 48185 RVA: 0x0012D234 File Offset: 0x0012B434
		public void SetRenderTransformPivot(FVector2D Pivot)
		{
			UWidget.__SetRenderTransformPivot_Internal(base.NativePtr, Pivot);
		}

		// Token: 0x0600BC3A RID: 48186 RVA: 0x0012D242 File Offset: 0x0012B442
		public void SetRenderTransformAngle(float Angle)
		{
			UWidget.__SetRenderTransformAngle_Internal(base.NativePtr, Angle);
		}

		// Token: 0x0600BC3B RID: 48187 RVA: 0x0012D250 File Offset: 0x0012B450
		public void SetRenderShear(FVector2D Shear)
		{
			UWidget.__SetRenderShear_Internal(base.NativePtr, Shear);
		}

		// Token: 0x0600BC3C RID: 48188 RVA: 0x0012D25E File Offset: 0x0012B45E
		public void SetRenderScale(FVector2D Scale)
		{
			UWidget.__SetRenderScale_Internal(base.NativePtr, Scale);
		}

		// Token: 0x0600BC3D RID: 48189 RVA: 0x0012D26C File Offset: 0x0012B46C
		public void SetRenderOpacity(float InOpacity)
		{
			UWidget.__SetRenderOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x0600BC3E RID: 48190 RVA: 0x0012D27A File Offset: 0x0012B47A
		public void SetNavigationRuleExplicit(EUINavigation Direction, UWidget InWidget)
		{
			UWidget.__SetNavigationRuleExplicit_Internal(base.NativePtr, Direction, (InWidget != null) ? InWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC3F RID: 48191 RVA: 0x0012D298 File Offset: 0x0012B498
		public void SetNavigationRuleCustomBoundary(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			UWidget.__SetNavigationRuleCustomBoundary_Internal(base.NativePtr, Direction, (InCustomDelegate != null) ? InCustomDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600BC40 RID: 48192 RVA: 0x0012D2B3 File Offset: 0x0012B4B3
		public void SetNavigationRuleCustom(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			UWidget.__SetNavigationRuleCustom_Internal(base.NativePtr, Direction, (InCustomDelegate != null) ? InCustomDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600BC41 RID: 48193 RVA: 0x0012D2CE File Offset: 0x0012B4CE
		public void SetKeyboardFocus()
		{
			UWidget.__SetKeyboardFocus_Internal(base.NativePtr);
		}

		// Token: 0x0600BC42 RID: 48194 RVA: 0x0012D2DB File Offset: 0x0012B4DB
		public void SetIsEnabled(bool bInIsEnabled)
		{
			UWidget.__SetIsEnabled_Internal(base.NativePtr, bInIsEnabled);
		}

		// Token: 0x0600BC43 RID: 48195 RVA: 0x0012D2E9 File Offset: 0x0012B4E9
		public void SetFocus()
		{
			UWidget.__SetFocus_Internal(base.NativePtr);
		}

		// Token: 0x0600BC44 RID: 48196 RVA: 0x0012D2F6 File Offset: 0x0012B4F6
		public void SetCursor(EMouseCursor InCursor)
		{
			UWidget.__SetCursor_Internal(base.NativePtr, InCursor);
		}

		// Token: 0x0600BC45 RID: 48197 RVA: 0x0012D309 File Offset: 0x0012B509
		public void ResetCursor()
		{
			UWidget.__ResetCursor_Internal(base.NativePtr);
		}

		// Token: 0x0600BC46 RID: 48198 RVA: 0x0012D316 File Offset: 0x0012B516
		public void RemoveFromParent()
		{
			UWidget.__RemoveFromParent_Internal(base.NativePtr);
		}

		// Token: 0x0600BC47 RID: 48199 RVA: 0x0012D323 File Offset: 0x0012B523
		public bool IsVisible()
		{
			return UWidget.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600BC48 RID: 48200 RVA: 0x0012D330 File Offset: 0x0012B530
		public bool IsHovered()
		{
			return UWidget.__IsHovered_Internal(base.NativePtr);
		}

		// Token: 0x0600BC49 RID: 48201 RVA: 0x0012D33D File Offset: 0x0012B53D
		public void InvalidateLayoutAndVolatility()
		{
			UWidget.__InvalidateLayoutAndVolatility_Internal(base.NativePtr);
		}

		// Token: 0x0600BC4A RID: 48202 RVA: 0x0012D34A File Offset: 0x0012B54A
		public bool HasUserFocusedDescendants(APlayerController PlayerController)
		{
			return UWidget.__HasUserFocusedDescendants_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC4B RID: 48203 RVA: 0x0012D367 File Offset: 0x0012B567
		public bool HasUserFocus(APlayerController PlayerController)
		{
			return UWidget.__HasUserFocus_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC4C RID: 48204 RVA: 0x0012D384 File Offset: 0x0012B584
		public bool HasMouseCaptureByUser(int UserIndex, int PointerIndex = -1)
		{
			return UWidget.__HasMouseCaptureByUser_Internal(base.NativePtr, UserIndex, PointerIndex);
		}

		// Token: 0x0600BC4D RID: 48205 RVA: 0x0012D393 File Offset: 0x0012B593
		public bool HasMouseCapture()
		{
			return UWidget.__HasMouseCapture_Internal(base.NativePtr);
		}

		// Token: 0x0600BC4E RID: 48206 RVA: 0x0012D3A0 File Offset: 0x0012B5A0
		public bool HasKeyboardFocus()
		{
			return UWidget.__HasKeyboardFocus_Internal(base.NativePtr);
		}

		// Token: 0x0600BC4F RID: 48207 RVA: 0x0012D3AD File Offset: 0x0012B5AD
		public bool HasFocusedDescendants()
		{
			return UWidget.__HasFocusedDescendants_Internal(base.NativePtr);
		}

		// Token: 0x0600BC50 RID: 48208 RVA: 0x0012D3BA File Offset: 0x0012B5BA
		public bool HasAnyUserFocus()
		{
			return UWidget.__HasAnyUserFocus_Internal(base.NativePtr);
		}

		// Token: 0x0600BC51 RID: 48209 RVA: 0x0012D3C7 File Offset: 0x0012B5C7
		public ESlateVisibility GetVisibility()
		{
			return UWidget.__GetVisibility_Internal(base.NativePtr);
		}

		// Token: 0x0600BC52 RID: 48210 RVA: 0x0012D3D4 File Offset: 0x0012B5D4
		public float GetRenderTransformAngle()
		{
			return UWidget.__GetRenderTransformAngle_Internal(base.NativePtr);
		}

		// Token: 0x0600BC53 RID: 48211 RVA: 0x0012D3E1 File Offset: 0x0012B5E1
		public float GetRenderOpacity()
		{
			return UWidget.__GetRenderOpacity_Internal(base.NativePtr);
		}

		// Token: 0x0600BC54 RID: 48212 RVA: 0x0012D3EE File Offset: 0x0012B5EE
		public UPanelWidget GetParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelWidget>(UWidget.__GetParent_Internal(base.NativePtr));
		}

		// Token: 0x0600BC55 RID: 48213 RVA: 0x0012D400 File Offset: 0x0012B600
		public APlayerController GetOwningPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UWidget.__GetOwningPlayer_Internal(base.NativePtr));
		}

		// Token: 0x0600BC56 RID: 48214 RVA: 0x0012D412 File Offset: 0x0012B612
		public bool GetIsEnabled()
		{
			return UWidget.__GetIsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x0600BC57 RID: 48215 RVA: 0x0012D41F File Offset: 0x0012B61F
		public UGameInstance GetGameInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstance>(UWidget.__GetGameInstance_Internal(base.NativePtr));
		}

		// Token: 0x0600BC58 RID: 48216 RVA: 0x0012D431 File Offset: 0x0012B631
		public FVector2D GetDesiredSize()
		{
			return UWidget.__GetDesiredSize_Internal(base.NativePtr);
		}

		// Token: 0x0600BC59 RID: 48217 RVA: 0x0012D43E File Offset: 0x0012B63E
		[NullableContext(1)]
		public FText GetAccessibleText()
		{
			return new FText(UWidget.__GetAccessibleText_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BC5A RID: 48218 RVA: 0x0012D451 File Offset: 0x0012B651
		[NullableContext(1)]
		public FText GetAccessibleSummaryText()
		{
			return new FText(UWidget.__GetAccessibleSummaryText_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BC5B RID: 48219 RVA: 0x0012D464 File Offset: 0x0012B664
		public void ForceVolatile(bool bForce)
		{
			UWidget.__ForceVolatile_Internal(base.NativePtr, bForce);
		}

		// Token: 0x0600BC5C RID: 48220 RVA: 0x0012D472 File Offset: 0x0012B672
		public void ForceLayoutPrepass()
		{
			UWidget.__ForceLayoutPrepass_Internal(base.NativePtr);
		}

		// Token: 0x0600BC5D RID: 48221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibility_Internal(IntPtr @this, ESlateVisibility InVisibility);

		// Token: 0x0600BC5E RID: 48222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserFocus_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x0600BC5F RID: 48223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToolTipText_Internal(IntPtr @this, IntPtr InToolTipText);

		// Token: 0x0600BC60 RID: 48224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToolTip_Internal(IntPtr @this, IntPtr Widget);

		// Token: 0x0600BC61 RID: 48225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTranslation_Internal(IntPtr @this, FVector2D Translation);

		// Token: 0x0600BC62 RID: 48226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTransformPivot_Internal(IntPtr @this, FVector2D Pivot);

		// Token: 0x0600BC63 RID: 48227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTransformAngle_Internal(IntPtr @this, float Angle);

		// Token: 0x0600BC64 RID: 48228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderShear_Internal(IntPtr @this, FVector2D Shear);

		// Token: 0x0600BC65 RID: 48229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderScale_Internal(IntPtr @this, FVector2D Scale);

		// Token: 0x0600BC66 RID: 48230
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x0600BC67 RID: 48231
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleExplicit_Internal(IntPtr @this, EUINavigation Direction, IntPtr InWidget);

		// Token: 0x0600BC68 RID: 48232
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleCustomBoundary_Internal(IntPtr @this, EUINavigation Direction, IntPtr InCustomDelegate);

		// Token: 0x0600BC69 RID: 48233
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleCustom_Internal(IntPtr @this, EUINavigation Direction, IntPtr InCustomDelegate);

		// Token: 0x0600BC6A RID: 48234
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeyboardFocus_Internal(IntPtr @this);

		// Token: 0x0600BC6B RID: 48235
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsEnabled_Internal(IntPtr @this, bool bInIsEnabled);

		// Token: 0x0600BC6C RID: 48236
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFocus_Internal(IntPtr @this);

		// Token: 0x0600BC6D RID: 48237
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCursor_Internal(IntPtr @this, TEnumAsByte<EMouseCursor> InCursor);

		// Token: 0x0600BC6E RID: 48238
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetCursor_Internal(IntPtr @this);

		// Token: 0x0600BC6F RID: 48239
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromParent_Internal(IntPtr @this);

		// Token: 0x0600BC70 RID: 48240
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x0600BC71 RID: 48241
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHovered_Internal(IntPtr @this);

		// Token: 0x0600BC72 RID: 48242
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvalidateLayoutAndVolatility_Internal(IntPtr @this);

		// Token: 0x0600BC73 RID: 48243
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasUserFocusedDescendants_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x0600BC74 RID: 48244
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasUserFocus_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x0600BC75 RID: 48245
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMouseCaptureByUser_Internal(IntPtr @this, int UserIndex, int PointerIndex);

		// Token: 0x0600BC76 RID: 48246
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMouseCapture_Internal(IntPtr @this);

		// Token: 0x0600BC77 RID: 48247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKeyboardFocus_Internal(IntPtr @this);

		// Token: 0x0600BC78 RID: 48248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFocusedDescendants_Internal(IntPtr @this);

		// Token: 0x0600BC79 RID: 48249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyUserFocus_Internal(IntPtr @this);

		// Token: 0x0600BC7A RID: 48250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESlateVisibility __GetVisibility_Internal(IntPtr @this);

		// Token: 0x0600BC7B RID: 48251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderTransformAngle_Internal(IntPtr @this);

		// Token: 0x0600BC7C RID: 48252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderOpacity_Internal(IntPtr @this);

		// Token: 0x0600BC7D RID: 48253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParent_Internal(IntPtr @this);

		// Token: 0x0600BC7E RID: 48254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayer_Internal(IntPtr @this);

		// Token: 0x0600BC7F RID: 48255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsEnabled_Internal(IntPtr @this);

		// Token: 0x0600BC80 RID: 48256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstance_Internal(IntPtr @this);

		// Token: 0x0600BC81 RID: 48257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetDesiredSize_Internal(IntPtr @this);

		// Token: 0x0600BC82 RID: 48258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAccessibleText_Internal(IntPtr @this);

		// Token: 0x0600BC83 RID: 48259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAccessibleSummaryText_Internal(IntPtr @this);

		// Token: 0x0600BC84 RID: 48260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceVolatile_Internal(IntPtr @this, bool bForce);

		// Token: 0x0600BC85 RID: 48261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceLayoutPrepass_Internal(IntPtr @this);

		// Token: 0x0600BC86 RID: 48262 RVA: 0x0012D47F File Offset: 0x0012B67F
		static UWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Widget");
		}

		// Token: 0x0600BC87 RID: 48263 RVA: 0x0012D490 File Offset: 0x0012B690
		protected UWidget() : this(BuiltinUtils.AllocNativeUObject(UWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BC88 RID: 48264 RVA: 0x0012D4B8 File Offset: 0x0012B6B8
		protected UWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005517 RID: 21783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Widget";

		// Token: 0x04005518 RID: 21784
		private static IntPtr _ClassPtr;

		// Token: 0x04005519 RID: 21785
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400551A RID: 21786
		public static IntPtr __OnReply__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400551B RID: 21787
		public static IntPtr __OnPointerEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400551C RID: 21788
		public static IntPtr __GetWidget__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400551D RID: 21789
		public static IntPtr __GetText__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400551E RID: 21790
		public static IntPtr __GetSlateVisibility__DelegateSignature_NativeFunctionPtr;

		// Token: 0x0400551F RID: 21791
		public static IntPtr __GetSlateColor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005520 RID: 21792
		public static IntPtr __GetSlateBrush__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005521 RID: 21793
		public static IntPtr __GetMouseCursor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005522 RID: 21794
		public static IntPtr __GetLinearColor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005523 RID: 21795
		public static IntPtr __GetInt32__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005524 RID: 21796
		public static IntPtr __GetFloat__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005525 RID: 21797
		public static IntPtr __GetCheckBoxState__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005526 RID: 21798
		public static IntPtr __GetBool__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005527 RID: 21799
		public static IntPtr __GenerateWidgetForString__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005528 RID: 21800
		public static IntPtr __GenerateWidgetForObject__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04005529 RID: 21801
		internal static int __PropertyOffset_Slot;

		// Token: 0x0400552A RID: 21802
		internal static int __PropertyOffset_bIsEnabledDelegate;

		// Token: 0x0400552B RID: 21803
		private FGetBool _bIsEnabledDelegate;

		// Token: 0x0400552C RID: 21804
		internal static int __PropertyOffset_ToolTipText;

		// Token: 0x0400552D RID: 21805
		private FText _ToolTipText;

		// Token: 0x0400552E RID: 21806
		internal static int __PropertyOffset_ToolTipTextDelegate;

		// Token: 0x0400552F RID: 21807
		private FGetText _ToolTipTextDelegate;

		// Token: 0x04005530 RID: 21808
		internal static int __PropertyOffset_ToolTipWidget;

		// Token: 0x04005531 RID: 21809
		internal static int __PropertyOffset_ToolTipWidgetDelegate;

		// Token: 0x04005532 RID: 21810
		private FGetWidget _ToolTipWidgetDelegate;

		// Token: 0x04005533 RID: 21811
		internal static int __PropertyOffset_VisibilityDelegate;

		// Token: 0x04005534 RID: 21812
		private FGetSlateVisibility _VisibilityDelegate;

		// Token: 0x04005535 RID: 21813
		internal static int __PropertyOffset_RenderTransformPivot;

		// Token: 0x04005536 RID: 21814
		internal static int __PropertyOffset_bIsVariable;

		// Token: 0x04005537 RID: 21815
		internal static byte __PropertyMask_bIsVariable;

		// Token: 0x04005538 RID: 21816
		internal static int __PropertyOffset_bCreatedByConstructionScript;

		// Token: 0x04005539 RID: 21817
		internal static byte __PropertyMask_bCreatedByConstructionScript;

		// Token: 0x0400553A RID: 21818
		internal static int __PropertyOffset_bIsEnabled;

		// Token: 0x0400553B RID: 21819
		internal static byte __PropertyMask_bIsEnabled;

		// Token: 0x0400553C RID: 21820
		internal static int __PropertyOffset_bOverride_Cursor;

		// Token: 0x0400553D RID: 21821
		internal static byte __PropertyMask_bOverride_Cursor;

		// Token: 0x0400553E RID: 21822
		internal static int __PropertyOffset_bIsVolatile;

		// Token: 0x0400553F RID: 21823
		internal static byte __PropertyMask_bIsVolatile;

		// Token: 0x04005540 RID: 21824
		internal static int __PropertyOffset_Cursor;

		// Token: 0x04005541 RID: 21825
		internal static int __PropertyOffset_Visibility;

		// Token: 0x04005542 RID: 21826
		internal static int __PropertyOffset_RenderOpacity;
	}
}
