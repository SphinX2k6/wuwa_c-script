using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029F5 RID: 10741
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.Widget")]
	[UnrealStructLayout(656, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 656)]
	public abstract class UWidget : UVisual, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027D4F RID: 163151 RVA: 0x003CB09A File Offset: 0x003C929A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidget._ClassPtr;
		}

		// Token: 0x17009863 RID: 39011
		// (get) Token: 0x06027D50 RID: 163152 RVA: 0x003CB0A6 File Offset: 0x003C92A6
		// (set) Token: 0x06027D51 RID: 163153 RVA: 0x003CB0BA File Offset: 0x003C92BA
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

		// Token: 0x17009864 RID: 39012
		// (get) Token: 0x06027D52 RID: 163154 RVA: 0x003CB0D0 File Offset: 0x003C92D0
		// (set) Token: 0x06027D53 RID: 163155 RVA: 0x003CB109 File Offset: 0x003C9309
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

		// Token: 0x17009865 RID: 39013
		// (get) Token: 0x06027D54 RID: 163156 RVA: 0x003CB12C File Offset: 0x003C932C
		// (set) Token: 0x06027D55 RID: 163157 RVA: 0x003CB165 File Offset: 0x003C9365
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

		// Token: 0x17009866 RID: 39014
		// (get) Token: 0x06027D56 RID: 163158 RVA: 0x003CB180 File Offset: 0x003C9380
		// (set) Token: 0x06027D57 RID: 163159 RVA: 0x003CB1B9 File Offset: 0x003C93B9
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

		// Token: 0x17009867 RID: 39015
		// (get) Token: 0x06027D58 RID: 163160 RVA: 0x003CB1DA File Offset: 0x003C93DA
		// (set) Token: 0x06027D59 RID: 163161 RVA: 0x003CB1EE File Offset: 0x003C93EE
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

		// Token: 0x17009868 RID: 39016
		// (get) Token: 0x06027D5A RID: 163162 RVA: 0x003CB204 File Offset: 0x003C9404
		// (set) Token: 0x06027D5B RID: 163163 RVA: 0x003CB23D File Offset: 0x003C943D
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

		// Token: 0x17009869 RID: 39017
		// (get) Token: 0x06027D5C RID: 163164 RVA: 0x003CB260 File Offset: 0x003C9460
		// (set) Token: 0x06027D5D RID: 163165 RVA: 0x003CB299 File Offset: 0x003C9499
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

		// Token: 0x1700986A RID: 39018
		// (get) Token: 0x06027D5E RID: 163166 RVA: 0x003CB2BC File Offset: 0x003C94BC
		// (set) Token: 0x06027D5F RID: 163167 RVA: 0x003CB2F5 File Offset: 0x003C94F5
		[Nullable(1)]
		public FWidgetTransform RenderTransform
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWidgetTransform result;
				if ((result = this._RenderTransform) == null)
				{
					result = (this._RenderTransform = new FWidgetTransform(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderTransform, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWidgetTransform.StaticStruct(), base.NativePtr + (IntPtr)UWidget.__PropertyOffset_RenderTransform, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700986B RID: 39019
		// (get) Token: 0x06027D60 RID: 163168 RVA: 0x003CB316 File Offset: 0x003C9516
		// (set) Token: 0x06027D61 RID: 163169 RVA: 0x003CB32A File Offset: 0x003C952A
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

		// Token: 0x1700986C RID: 39020
		// (get) Token: 0x06027D62 RID: 163170 RVA: 0x003CB33F File Offset: 0x003C953F
		// (set) Token: 0x06027D63 RID: 163171 RVA: 0x003CB358 File Offset: 0x003C9558
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

		// Token: 0x1700986D RID: 39021
		// (get) Token: 0x06027D64 RID: 163172 RVA: 0x003CB388 File Offset: 0x003C9588
		// (set) Token: 0x06027D65 RID: 163173 RVA: 0x003CB3A1 File Offset: 0x003C95A1
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

		// Token: 0x1700986E RID: 39022
		// (get) Token: 0x06027D66 RID: 163174 RVA: 0x003CB3D1 File Offset: 0x003C95D1
		// (set) Token: 0x06027D67 RID: 163175 RVA: 0x003CB3EA File Offset: 0x003C95EA
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

		// Token: 0x1700986F RID: 39023
		// (get) Token: 0x06027D68 RID: 163176 RVA: 0x003CB41A File Offset: 0x003C961A
		// (set) Token: 0x06027D69 RID: 163177 RVA: 0x003CB433 File Offset: 0x003C9633
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

		// Token: 0x17009870 RID: 39024
		// (get) Token: 0x06027D6A RID: 163178 RVA: 0x003CB463 File Offset: 0x003C9663
		// (set) Token: 0x06027D6B RID: 163179 RVA: 0x003CB477 File Offset: 0x003C9677
		public unsafe USlateAccessibleWidgetData AccessibleWidgetData
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USlateAccessibleWidgetData>(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_AccessibleWidgetData);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_AccessibleWidgetData, value);
			}
		}

		// Token: 0x17009871 RID: 39025
		// (get) Token: 0x06027D6C RID: 163180 RVA: 0x003CB48C File Offset: 0x003C968C
		// (set) Token: 0x06027D6D RID: 163181 RVA: 0x003CB4A5 File Offset: 0x003C96A5
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

		// Token: 0x17009872 RID: 39026
		// (get) Token: 0x06027D6E RID: 163182 RVA: 0x003CB4D5 File Offset: 0x003C96D5
		// (set) Token: 0x06027D6F RID: 163183 RVA: 0x003CB4E9 File Offset: 0x003C96E9
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

		// Token: 0x17009873 RID: 39027
		// (get) Token: 0x06027D70 RID: 163184 RVA: 0x003CB4FE File Offset: 0x003C96FE
		// (set) Token: 0x06027D71 RID: 163185 RVA: 0x003CB50E File Offset: 0x003C970E
		public unsafe EWidgetClipping Clipping
		{
			get
			{
				return (EWidgetClipping)(*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Clipping));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_Clipping) = (byte)value;
			}
		}

		// Token: 0x17009874 RID: 39028
		// (get) Token: 0x06027D72 RID: 163186 RVA: 0x003CB51F File Offset: 0x003C971F
		// (set) Token: 0x06027D73 RID: 163187 RVA: 0x003CB52F File Offset: 0x003C972F
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

		// Token: 0x17009875 RID: 39029
		// (get) Token: 0x06027D74 RID: 163188 RVA: 0x003CB540 File Offset: 0x003C9740
		// (set) Token: 0x06027D75 RID: 163189 RVA: 0x003CB550 File Offset: 0x003C9750
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

		// Token: 0x17009876 RID: 39030
		// (get) Token: 0x06027D76 RID: 163190 RVA: 0x003CB561 File Offset: 0x003C9761
		// (set) Token: 0x06027D77 RID: 163191 RVA: 0x003CB575 File Offset: 0x003C9775
		public unsafe UWidgetNavigation Navigation
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetNavigation>(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_Navigation);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UWidget.__PropertyOffset_Navigation, value);
			}
		}

		// Token: 0x17009877 RID: 39031
		// (get) Token: 0x06027D78 RID: 163192 RVA: 0x003CB58A File Offset: 0x003C978A
		// (set) Token: 0x06027D79 RID: 163193 RVA: 0x003CB59A File Offset: 0x003C979A
		public unsafe EFlowDirectionPreference FlowDirectionPreference
		{
			get
			{
				return (EFlowDirectionPreference)(*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_FlowDirectionPreference));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_FlowDirectionPreference) = (byte)value;
			}
		}

		// Token: 0x17009878 RID: 39032
		// (get) Token: 0x06027D7A RID: 163194 RVA: 0x003CB5AC File Offset: 0x003C97AC
		// (set) Token: 0x06027D7B RID: 163195 RVA: 0x003CB5E5 File Offset: 0x003C97E5
		[Nullable(1)]
		public TArray<UPropertyBinding> NativeBindings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UPropertyBinding> result;
				if ((result = this._NativeBindings) == null)
				{
					result = (this._NativeBindings = new TArray<UPropertyBinding>(base.NativePtr + (IntPtr)UWidget.__PropertyOffset_NativeBindings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NativeBindings.CopyAssign(value);
			}
		}

		// Token: 0x06027D7C RID: 163196 RVA: 0x003CB5F3 File Offset: 0x003C97F3
		public void SetVisibility(ESlateVisibility InVisibility)
		{
			UWidget.__SetVisibility_Internal(base.NativePtr, InVisibility);
		}

		// Token: 0x06027D7D RID: 163197 RVA: 0x003CB601 File Offset: 0x003C9801
		public void SetUserFocus(APlayerController PlayerController)
		{
			UWidget.__SetUserFocus_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D7E RID: 163198 RVA: 0x003CB61E File Offset: 0x003C981E
		[NullableContext(1)]
		public void SetToolTipText(in FText InToolTipText)
		{
			IntPtr nativePtr = base.NativePtr;
			FText ftext = InToolTipText;
			UWidget.__SetToolTipText_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D7F RID: 163199 RVA: 0x003CB63D File Offset: 0x003C983D
		public void SetToolTip(UWidget Widget)
		{
			UWidget.__SetToolTip_Internal(base.NativePtr, (Widget != null) ? Widget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D80 RID: 163200 RVA: 0x003CB65A File Offset: 0x003C985A
		public void SetRenderTranslation(FVector2D Translation)
		{
			UWidget.__SetRenderTranslation_Internal(base.NativePtr, Translation);
		}

		// Token: 0x06027D81 RID: 163201 RVA: 0x003CB668 File Offset: 0x003C9868
		public void SetRenderTransformPivot(FVector2D Pivot)
		{
			UWidget.__SetRenderTransformPivot_Internal(base.NativePtr, Pivot);
		}

		// Token: 0x06027D82 RID: 163202 RVA: 0x003CB676 File Offset: 0x003C9876
		public void SetRenderTransformAngle(float Angle)
		{
			UWidget.__SetRenderTransformAngle_Internal(base.NativePtr, Angle);
		}

		// Token: 0x06027D83 RID: 163203 RVA: 0x003CB684 File Offset: 0x003C9884
		public void SetRenderTransform(FWidgetTransform InTransform)
		{
			UWidget.__SetRenderTransform_Internal(base.NativePtr, (InTransform ?? new FWidgetTransform()).NativePtr);
		}

		// Token: 0x06027D84 RID: 163204 RVA: 0x003CB6A0 File Offset: 0x003C98A0
		public void SetRenderShear(FVector2D Shear)
		{
			UWidget.__SetRenderShear_Internal(base.NativePtr, Shear);
		}

		// Token: 0x06027D85 RID: 163205 RVA: 0x003CB6AE File Offset: 0x003C98AE
		public void SetRenderScale(FVector2D Scale)
		{
			UWidget.__SetRenderScale_Internal(base.NativePtr, Scale);
		}

		// Token: 0x06027D86 RID: 163206 RVA: 0x003CB6BC File Offset: 0x003C98BC
		public void SetRenderOpacity(float InOpacity)
		{
			UWidget.__SetRenderOpacity_Internal(base.NativePtr, InOpacity);
		}

		// Token: 0x06027D87 RID: 163207 RVA: 0x003CB6CA File Offset: 0x003C98CA
		public void SetNavigationRuleExplicit(EUINavigation Direction, UWidget InWidget)
		{
			UWidget.__SetNavigationRuleExplicit_Internal(base.NativePtr, Direction, (InWidget != null) ? InWidget.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D88 RID: 163208 RVA: 0x003CB6E8 File Offset: 0x003C98E8
		public void SetNavigationRuleCustomBoundary(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			UWidget.__SetNavigationRuleCustomBoundary_Internal(base.NativePtr, Direction, (InCustomDelegate != null) ? InCustomDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027D89 RID: 163209 RVA: 0x003CB703 File Offset: 0x003C9903
		public void SetNavigationRuleCustom(EUINavigation Direction, FCustomWidgetNavigationDelegate InCustomDelegate)
		{
			UWidget.__SetNavigationRuleCustom_Internal(base.NativePtr, Direction, (InCustomDelegate != null) ? InCustomDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027D8A RID: 163210 RVA: 0x003CB71E File Offset: 0x003C991E
		public void SetNavigationRuleBase(EUINavigation Direction, EUINavigationRule Rule)
		{
			UWidget.__SetNavigationRuleBase_Internal(base.NativePtr, Direction, Rule);
		}

		// Token: 0x06027D8B RID: 163211 RVA: 0x003CB72D File Offset: 0x003C992D
		public void SetNavigationRule(EUINavigation Direction, EUINavigationRule Rule, FName WidgetToFocus)
		{
			UWidget.__SetNavigationRule_Internal(base.NativePtr, Direction, Rule, WidgetToFocus);
		}

		// Token: 0x06027D8C RID: 163212 RVA: 0x003CB73D File Offset: 0x003C993D
		public void SetKeyboardFocus()
		{
			UWidget.__SetKeyboardFocus_Internal(base.NativePtr);
		}

		// Token: 0x06027D8D RID: 163213 RVA: 0x003CB74A File Offset: 0x003C994A
		public void SetIsEnabled(bool bInIsEnabled)
		{
			UWidget.__SetIsEnabled_Internal(base.NativePtr, bInIsEnabled);
		}

		// Token: 0x06027D8E RID: 163214 RVA: 0x003CB758 File Offset: 0x003C9958
		public void SetFocus()
		{
			UWidget.__SetFocus_Internal(base.NativePtr);
		}

		// Token: 0x06027D8F RID: 163215 RVA: 0x003CB765 File Offset: 0x003C9965
		public void SetCursor(EMouseCursor InCursor)
		{
			UWidget.__SetCursor_Internal(base.NativePtr, InCursor);
		}

		// Token: 0x06027D90 RID: 163216 RVA: 0x003CB778 File Offset: 0x003C9978
		public void SetClipping(EWidgetClipping InClipping)
		{
			UWidget.__SetClipping_Internal(base.NativePtr, InClipping);
		}

		// Token: 0x06027D91 RID: 163217 RVA: 0x003CB786 File Offset: 0x003C9986
		public void SetAllNavigationRules(EUINavigationRule Rule, FName WidgetToFocus)
		{
			UWidget.__SetAllNavigationRules_Internal(base.NativePtr, Rule, WidgetToFocus);
		}

		// Token: 0x06027D92 RID: 163218 RVA: 0x003CB795 File Offset: 0x003C9995
		public void ResetCursor()
		{
			UWidget.__ResetCursor_Internal(base.NativePtr);
		}

		// Token: 0x06027D93 RID: 163219 RVA: 0x003CB7A2 File Offset: 0x003C99A2
		public void RemoveFromParent()
		{
			UWidget.__RemoveFromParent_Internal(base.NativePtr);
		}

		// Token: 0x06027D94 RID: 163220 RVA: 0x003CB7AF File Offset: 0x003C99AF
		public bool IsVisible()
		{
			return UWidget.__IsVisible_Internal(base.NativePtr);
		}

		// Token: 0x06027D95 RID: 163221 RVA: 0x003CB7BC File Offset: 0x003C99BC
		public bool IsHovered()
		{
			return UWidget.__IsHovered_Internal(base.NativePtr);
		}

		// Token: 0x06027D96 RID: 163222 RVA: 0x003CB7C9 File Offset: 0x003C99C9
		public void InvalidateLayoutAndVolatility()
		{
			UWidget.__InvalidateLayoutAndVolatility_Internal(base.NativePtr);
		}

		// Token: 0x06027D97 RID: 163223 RVA: 0x003CB7D6 File Offset: 0x003C99D6
		public bool HasUserFocusedDescendants(APlayerController PlayerController)
		{
			return UWidget.__HasUserFocusedDescendants_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D98 RID: 163224 RVA: 0x003CB7F3 File Offset: 0x003C99F3
		public bool HasUserFocus(APlayerController PlayerController)
		{
			return UWidget.__HasUserFocus_Internal(base.NativePtr, (PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027D99 RID: 163225 RVA: 0x003CB810 File Offset: 0x003C9A10
		public bool HasMouseCaptureByUser(int UserIndex, int PointerIndex = -1)
		{
			return UWidget.__HasMouseCaptureByUser_Internal(base.NativePtr, UserIndex, PointerIndex);
		}

		// Token: 0x06027D9A RID: 163226 RVA: 0x003CB81F File Offset: 0x003C9A1F
		public bool HasMouseCapture()
		{
			return UWidget.__HasMouseCapture_Internal(base.NativePtr);
		}

		// Token: 0x06027D9B RID: 163227 RVA: 0x003CB82C File Offset: 0x003C9A2C
		public bool HasKeyboardFocus()
		{
			return UWidget.__HasKeyboardFocus_Internal(base.NativePtr);
		}

		// Token: 0x06027D9C RID: 163228 RVA: 0x003CB839 File Offset: 0x003C9A39
		public bool HasFocusedDescendants()
		{
			return UWidget.__HasFocusedDescendants_Internal(base.NativePtr);
		}

		// Token: 0x06027D9D RID: 163229 RVA: 0x003CB846 File Offset: 0x003C9A46
		public bool HasAnyUserFocus()
		{
			return UWidget.__HasAnyUserFocus_Internal(base.NativePtr);
		}

		// Token: 0x06027D9E RID: 163230 RVA: 0x003CB853 File Offset: 0x003C9A53
		public ESlateVisibility GetVisibility()
		{
			return UWidget.__GetVisibility_Internal(base.NativePtr);
		}

		// Token: 0x06027D9F RID: 163231 RVA: 0x003CB860 File Offset: 0x003C9A60
		[NullableContext(1)]
		public FGeometry GetTickSpaceGeometry()
		{
			return new FGeometry(UWidget.__GetTickSpaceGeometry_Internal(base.NativePtr), null);
		}

		// Token: 0x06027DA0 RID: 163232 RVA: 0x003CB873 File Offset: 0x003C9A73
		public float GetRenderTransformAngle()
		{
			return UWidget.__GetRenderTransformAngle_Internal(base.NativePtr);
		}

		// Token: 0x06027DA1 RID: 163233 RVA: 0x003CB880 File Offset: 0x003C9A80
		public float GetRenderOpacity()
		{
			return UWidget.__GetRenderOpacity_Internal(base.NativePtr);
		}

		// Token: 0x06027DA2 RID: 163234 RVA: 0x003CB88D File Offset: 0x003C9A8D
		public UPanelWidget GetParent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UPanelWidget>(UWidget.__GetParent_Internal(base.NativePtr));
		}

		// Token: 0x06027DA3 RID: 163235 RVA: 0x003CB89F File Offset: 0x003C9A9F
		[NullableContext(1)]
		public FGeometry GetPaintSpaceGeometry()
		{
			return new FGeometry(UWidget.__GetPaintSpaceGeometry_Internal(base.NativePtr), null);
		}

		// Token: 0x06027DA4 RID: 163236 RVA: 0x003CB8B2 File Offset: 0x003C9AB2
		public APlayerController GetOwningPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerController>(UWidget.__GetOwningPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06027DA5 RID: 163237 RVA: 0x003CB8C4 File Offset: 0x003C9AC4
		public ULocalPlayer GetOwningLocalPlayer()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULocalPlayer>(UWidget.__GetOwningLocalPlayer_Internal(base.NativePtr));
		}

		// Token: 0x06027DA6 RID: 163238 RVA: 0x003CB8D6 File Offset: 0x003C9AD6
		public bool GetIsEnabled()
		{
			return UWidget.__GetIsEnabled_Internal(base.NativePtr);
		}

		// Token: 0x06027DA7 RID: 163239 RVA: 0x003CB8E3 File Offset: 0x003C9AE3
		public UGameInstance GetGameInstance()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGameInstance>(UWidget.__GetGameInstance_Internal(base.NativePtr));
		}

		// Token: 0x06027DA8 RID: 163240 RVA: 0x003CB8F5 File Offset: 0x003C9AF5
		public FVector2D GetDesiredSize()
		{
			return UWidget.__GetDesiredSize_Internal(base.NativePtr);
		}

		// Token: 0x06027DA9 RID: 163241 RVA: 0x003CB902 File Offset: 0x003C9B02
		public EWidgetClipping GetClipping()
		{
			return UWidget.__GetClipping_Internal(base.NativePtr);
		}

		// Token: 0x06027DAA RID: 163242 RVA: 0x003CB90F File Offset: 0x003C9B0F
		[NullableContext(1)]
		public FGeometry GetCachedGeometry()
		{
			return new FGeometry(UWidget.__GetCachedGeometry_Internal(base.NativePtr), null);
		}

		// Token: 0x06027DAB RID: 163243 RVA: 0x003CB922 File Offset: 0x003C9B22
		[NullableContext(1)]
		public FText GetAccessibleText()
		{
			return new FText(UWidget.__GetAccessibleText_Internal(base.NativePtr), null);
		}

		// Token: 0x06027DAC RID: 163244 RVA: 0x003CB935 File Offset: 0x003C9B35
		[NullableContext(1)]
		public FText GetAccessibleSummaryText()
		{
			return new FText(UWidget.__GetAccessibleSummaryText_Internal(base.NativePtr), null);
		}

		// Token: 0x06027DAD RID: 163245 RVA: 0x003CB948 File Offset: 0x003C9B48
		public void ForceVolatile(bool bForce)
		{
			UWidget.__ForceVolatile_Internal(base.NativePtr, bForce);
		}

		// Token: 0x06027DAE RID: 163246 RVA: 0x003CB956 File Offset: 0x003C9B56
		public void ForceLayoutPrepass()
		{
			UWidget.__ForceLayoutPrepass_Internal(base.NativePtr);
		}

		// Token: 0x06027DAF RID: 163247
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVisibility_Internal(IntPtr @this, ESlateVisibility InVisibility);

		// Token: 0x06027DB0 RID: 163248
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUserFocus_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x06027DB1 RID: 163249
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToolTipText_Internal(IntPtr @this, IntPtr InToolTipText);

		// Token: 0x06027DB2 RID: 163250
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToolTip_Internal(IntPtr @this, IntPtr Widget);

		// Token: 0x06027DB3 RID: 163251
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTranslation_Internal(IntPtr @this, FVector2D Translation);

		// Token: 0x06027DB4 RID: 163252
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTransformPivot_Internal(IntPtr @this, FVector2D Pivot);

		// Token: 0x06027DB5 RID: 163253
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTransformAngle_Internal(IntPtr @this, float Angle);

		// Token: 0x06027DB6 RID: 163254
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderTransform_Internal(IntPtr @this, IntPtr InTransform);

		// Token: 0x06027DB7 RID: 163255
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderShear_Internal(IntPtr @this, FVector2D Shear);

		// Token: 0x06027DB8 RID: 163256
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderScale_Internal(IntPtr @this, FVector2D Scale);

		// Token: 0x06027DB9 RID: 163257
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRenderOpacity_Internal(IntPtr @this, float InOpacity);

		// Token: 0x06027DBA RID: 163258
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleExplicit_Internal(IntPtr @this, EUINavigation Direction, IntPtr InWidget);

		// Token: 0x06027DBB RID: 163259
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleCustomBoundary_Internal(IntPtr @this, EUINavigation Direction, IntPtr InCustomDelegate);

		// Token: 0x06027DBC RID: 163260
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleCustom_Internal(IntPtr @this, EUINavigation Direction, IntPtr InCustomDelegate);

		// Token: 0x06027DBD RID: 163261
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRuleBase_Internal(IntPtr @this, EUINavigation Direction, EUINavigationRule Rule);

		// Token: 0x06027DBE RID: 163262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRule_Internal(IntPtr @this, EUINavigation Direction, EUINavigationRule Rule, FName WidgetToFocus);

		// Token: 0x06027DBF RID: 163263
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeyboardFocus_Internal(IntPtr @this);

		// Token: 0x06027DC0 RID: 163264
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsEnabled_Internal(IntPtr @this, bool bInIsEnabled);

		// Token: 0x06027DC1 RID: 163265
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFocus_Internal(IntPtr @this);

		// Token: 0x06027DC2 RID: 163266
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCursor_Internal(IntPtr @this, TEnumAsByte<EMouseCursor> InCursor);

		// Token: 0x06027DC3 RID: 163267
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetClipping_Internal(IntPtr @this, EWidgetClipping InClipping);

		// Token: 0x06027DC4 RID: 163268
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllNavigationRules_Internal(IntPtr @this, EUINavigationRule Rule, FName WidgetToFocus);

		// Token: 0x06027DC5 RID: 163269
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetCursor_Internal(IntPtr @this);

		// Token: 0x06027DC6 RID: 163270
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromParent_Internal(IntPtr @this);

		// Token: 0x06027DC7 RID: 163271
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVisible_Internal(IntPtr @this);

		// Token: 0x06027DC8 RID: 163272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsHovered_Internal(IntPtr @this);

		// Token: 0x06027DC9 RID: 163273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InvalidateLayoutAndVolatility_Internal(IntPtr @this);

		// Token: 0x06027DCA RID: 163274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasUserFocusedDescendants_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x06027DCB RID: 163275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasUserFocus_Internal(IntPtr @this, IntPtr PlayerController);

		// Token: 0x06027DCC RID: 163276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMouseCaptureByUser_Internal(IntPtr @this, int UserIndex, int PointerIndex);

		// Token: 0x06027DCD RID: 163277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasMouseCapture_Internal(IntPtr @this);

		// Token: 0x06027DCE RID: 163278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasKeyboardFocus_Internal(IntPtr @this);

		// Token: 0x06027DCF RID: 163279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasFocusedDescendants_Internal(IntPtr @this);

		// Token: 0x06027DD0 RID: 163280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasAnyUserFocus_Internal(IntPtr @this);

		// Token: 0x06027DD1 RID: 163281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESlateVisibility __GetVisibility_Internal(IntPtr @this);

		// Token: 0x06027DD2 RID: 163282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTickSpaceGeometry_Internal(IntPtr @this);

		// Token: 0x06027DD3 RID: 163283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderTransformAngle_Internal(IntPtr @this);

		// Token: 0x06027DD4 RID: 163284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRenderOpacity_Internal(IntPtr @this);

		// Token: 0x06027DD5 RID: 163285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetParent_Internal(IntPtr @this);

		// Token: 0x06027DD6 RID: 163286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPaintSpaceGeometry_Internal(IntPtr @this);

		// Token: 0x06027DD7 RID: 163287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayer_Internal(IntPtr @this);

		// Token: 0x06027DD8 RID: 163288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningLocalPlayer_Internal(IntPtr @this);

		// Token: 0x06027DD9 RID: 163289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsEnabled_Internal(IntPtr @this);

		// Token: 0x06027DDA RID: 163290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetGameInstance_Internal(IntPtr @this);

		// Token: 0x06027DDB RID: 163291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetDesiredSize_Internal(IntPtr @this);

		// Token: 0x06027DDC RID: 163292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EWidgetClipping __GetClipping_Internal(IntPtr @this);

		// Token: 0x06027DDD RID: 163293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCachedGeometry_Internal(IntPtr @this);

		// Token: 0x06027DDE RID: 163294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAccessibleText_Internal(IntPtr @this);

		// Token: 0x06027DDF RID: 163295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAccessibleSummaryText_Internal(IntPtr @this);

		// Token: 0x06027DE0 RID: 163296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceVolatile_Internal(IntPtr @this, bool bForce);

		// Token: 0x06027DE1 RID: 163297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceLayoutPrepass_Internal(IntPtr @this);

		// Token: 0x06027DE2 RID: 163298 RVA: 0x003CB963 File Offset: 0x003C9B63
		static UWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.Widget");
		}

		// Token: 0x06027DE3 RID: 163299 RVA: 0x003CB974 File Offset: 0x003C9B74
		protected UWidget() : this(BuiltinUtils.AllocNativeUObject(UWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027DE4 RID: 163300 RVA: 0x003CB99C File Offset: 0x003C9B9C
		protected UWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C7A RID: 89210
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.Widget";

		// Token: 0x04015C7B RID: 89211
		private static IntPtr _ClassPtr;

		// Token: 0x04015C7C RID: 89212
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C7D RID: 89213
		public static IntPtr __OnReply__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C7E RID: 89214
		public static IntPtr __OnPointerEvent__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C7F RID: 89215
		public static IntPtr __GetWidget__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C80 RID: 89216
		public static IntPtr __GetText__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C81 RID: 89217
		public static IntPtr __GetSlateVisibility__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C82 RID: 89218
		public static IntPtr __GetSlateColor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C83 RID: 89219
		public static IntPtr __GetSlateBrush__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C84 RID: 89220
		public static IntPtr __GetMouseCursor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C85 RID: 89221
		public static IntPtr __GetLinearColor__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C86 RID: 89222
		public static IntPtr __GetInt32__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C87 RID: 89223
		public static IntPtr __GetFloat__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C88 RID: 89224
		public static IntPtr __GetCheckBoxState__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C89 RID: 89225
		public static IntPtr __GetBool__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C8A RID: 89226
		public static IntPtr __GenerateWidgetForString__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C8B RID: 89227
		public static IntPtr __GenerateWidgetForObject__DelegateSignature_NativeFunctionPtr;

		// Token: 0x04015C8C RID: 89228
		internal static int __PropertyOffset_Slot;

		// Token: 0x04015C8D RID: 89229
		internal static int __PropertyOffset_bIsEnabledDelegate;

		// Token: 0x04015C8E RID: 89230
		private FGetBool _bIsEnabledDelegate;

		// Token: 0x04015C8F RID: 89231
		internal static int __PropertyOffset_ToolTipText;

		// Token: 0x04015C90 RID: 89232
		private FText _ToolTipText;

		// Token: 0x04015C91 RID: 89233
		internal static int __PropertyOffset_ToolTipTextDelegate;

		// Token: 0x04015C92 RID: 89234
		private FGetText _ToolTipTextDelegate;

		// Token: 0x04015C93 RID: 89235
		internal static int __PropertyOffset_ToolTipWidget;

		// Token: 0x04015C94 RID: 89236
		internal static int __PropertyOffset_ToolTipWidgetDelegate;

		// Token: 0x04015C95 RID: 89237
		private FGetWidget _ToolTipWidgetDelegate;

		// Token: 0x04015C96 RID: 89238
		internal static int __PropertyOffset_VisibilityDelegate;

		// Token: 0x04015C97 RID: 89239
		private FGetSlateVisibility _VisibilityDelegate;

		// Token: 0x04015C98 RID: 89240
		internal static int __PropertyOffset_RenderTransform;

		// Token: 0x04015C99 RID: 89241
		private FWidgetTransform _RenderTransform;

		// Token: 0x04015C9A RID: 89242
		internal static int __PropertyOffset_RenderTransformPivot;

		// Token: 0x04015C9B RID: 89243
		internal static int __PropertyOffset_bIsVariable;

		// Token: 0x04015C9C RID: 89244
		internal static byte __PropertyMask_bIsVariable;

		// Token: 0x04015C9D RID: 89245
		internal static int __PropertyOffset_bCreatedByConstructionScript;

		// Token: 0x04015C9E RID: 89246
		internal static byte __PropertyMask_bCreatedByConstructionScript;

		// Token: 0x04015C9F RID: 89247
		internal static int __PropertyOffset_bIsEnabled;

		// Token: 0x04015CA0 RID: 89248
		internal static byte __PropertyMask_bIsEnabled;

		// Token: 0x04015CA1 RID: 89249
		internal static int __PropertyOffset_bOverride_Cursor;

		// Token: 0x04015CA2 RID: 89250
		internal static byte __PropertyMask_bOverride_Cursor;

		// Token: 0x04015CA3 RID: 89251
		internal static int __PropertyOffset_AccessibleWidgetData;

		// Token: 0x04015CA4 RID: 89252
		internal static int __PropertyOffset_bIsVolatile;

		// Token: 0x04015CA5 RID: 89253
		internal static byte __PropertyMask_bIsVolatile;

		// Token: 0x04015CA6 RID: 89254
		internal static int __PropertyOffset_Cursor;

		// Token: 0x04015CA7 RID: 89255
		internal static int __PropertyOffset_Clipping;

		// Token: 0x04015CA8 RID: 89256
		internal static int __PropertyOffset_Visibility;

		// Token: 0x04015CA9 RID: 89257
		internal static int __PropertyOffset_RenderOpacity;

		// Token: 0x04015CAA RID: 89258
		internal static int __PropertyOffset_Navigation;

		// Token: 0x04015CAB RID: 89259
		internal static int __PropertyOffset_FlowDirectionPreference;

		// Token: 0x04015CAC RID: 89260
		internal static int __PropertyOffset_NativeBindings;

		// Token: 0x04015CAD RID: 89261
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPropertyBinding> _NativeBindings;
	}
}
