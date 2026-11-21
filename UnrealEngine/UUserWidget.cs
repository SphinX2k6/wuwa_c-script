using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000872 RID: 2162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.UserWidget")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public abstract class UUserWidget : UWidget, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BBA4 RID: 48036 RVA: 0x0012C6ED File Offset: 0x0012A8ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserWidget._ClassPtr;
		}

		// Token: 0x170022C5 RID: 8901
		// (get) Token: 0x0600BBA5 RID: 48037 RVA: 0x0012C6F9 File Offset: 0x0012A8F9
		// (set) Token: 0x0600BBA6 RID: 48038 RVA: 0x0012C70D File Offset: 0x0012A90D
		public unsafe FLinearColor ColorAndOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ColorAndOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ColorAndOpacity) = value;
			}
		}

		// Token: 0x170022C6 RID: 8902
		// (get) Token: 0x0600BBA7 RID: 48039 RVA: 0x0012C724 File Offset: 0x0012A924
		// (set) Token: 0x0600BBA8 RID: 48040 RVA: 0x0012C75D File Offset: 0x0012A95D
		public FGetLinearColor ColorAndOpacityDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetLinearColor result;
				if ((result = this._ColorAndOpacityDelegate) == null)
				{
					result = (this._ColorAndOpacityDelegate = new FGetLinearColor(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ColorAndOpacityDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022C7 RID: 8903
		// (get) Token: 0x0600BBA9 RID: 48041 RVA: 0x0012C780 File Offset: 0x0012A980
		// (set) Token: 0x0600BBAA RID: 48042 RVA: 0x0012C7B9 File Offset: 0x0012A9B9
		public FSlateColor ForegroundColor
		{
			get
			{
				base.FastCheckIsValid();
				FSlateColor result;
				if ((result = this._ForegroundColor) == null)
				{
					result = (this._ForegroundColor = new FSlateColor(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColor, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x0600BBAB RID: 48043 RVA: 0x0012C7DC File Offset: 0x0012A9DC
		// (set) Token: 0x0600BBAC RID: 48044 RVA: 0x0012C815 File Offset: 0x0012AA15
		public FGetSlateColor ForegroundColorDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FGetSlateColor result;
				if ((result = this._ForegroundColorDelegate) == null)
				{
					result = (this._ForegroundColorDelegate = new FGetSlateColor(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColorDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColorDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x0600BBAD RID: 48045 RVA: 0x0012C838 File Offset: 0x0012AA38
		// (set) Token: 0x0600BBAE RID: 48046 RVA: 0x0012C871 File Offset: 0x0012AA71
		public FOnVisibilityChangedEvent OnVisibilityChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnVisibilityChangedEvent result;
				if ((result = this._OnVisibilityChanged) == null)
				{
					result = (this._OnVisibilityChanged = new FOnVisibilityChangedEvent(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_OnVisibilityChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_OnVisibilityChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x0600BBAF RID: 48047 RVA: 0x0012C892 File Offset: 0x0012AA92
		// (set) Token: 0x0600BBB0 RID: 48048 RVA: 0x0012C8A6 File Offset: 0x0012AAA6
		public unsafe FMargin Padding
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_Padding);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_Padding) = value;
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x0600BBB1 RID: 48049 RVA: 0x0012C8BB File Offset: 0x0012AABB
		// (set) Token: 0x0600BBB2 RID: 48050 RVA: 0x0012C8CF File Offset: 0x0012AACF
		[Nullable(2)]
		public unsafe UWidgetTree WidgetTree
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetTree>(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_WidgetTree);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_WidgetTree, value);
			}
		}

		// Token: 0x170022CC RID: 8908
		// (get) Token: 0x0600BBB3 RID: 48051 RVA: 0x0012C8E4 File Offset: 0x0012AAE4
		// (set) Token: 0x0600BBB4 RID: 48052 RVA: 0x0012C8F4 File Offset: 0x0012AAF4
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x170022CD RID: 8909
		// (get) Token: 0x0600BBB5 RID: 48053 RVA: 0x0012C905 File Offset: 0x0012AB05
		// (set) Token: 0x0600BBB6 RID: 48054 RVA: 0x0012C91E File Offset: 0x0012AB1E
		public unsafe bool bSupportsKeyboardFocus_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bSupportsKeyboardFocus_DEPRECATED) & UUserWidget.__PropertyMask_bSupportsKeyboardFocus_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bSupportsKeyboardFocus_DEPRECATED) = ((*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bSupportsKeyboardFocus_DEPRECATED) & ~UUserWidget.__PropertyMask_bSupportsKeyboardFocus_DEPRECATED) | (value ? UUserWidget.__PropertyMask_bSupportsKeyboardFocus_DEPRECATED : 0));
			}
		}

		// Token: 0x170022CE RID: 8910
		// (get) Token: 0x0600BBB7 RID: 48055 RVA: 0x0012C94E File Offset: 0x0012AB4E
		// (set) Token: 0x0600BBB8 RID: 48056 RVA: 0x0012C967 File Offset: 0x0012AB67
		public unsafe bool bIsFocusable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bIsFocusable) & UUserWidget.__PropertyMask_bIsFocusable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bIsFocusable) = ((*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bIsFocusable) & ~UUserWidget.__PropertyMask_bIsFocusable) | (value ? UUserWidget.__PropertyMask_bIsFocusable : 0));
			}
		}

		// Token: 0x170022CF RID: 8911
		// (get) Token: 0x0600BBB9 RID: 48057 RVA: 0x0012C997 File Offset: 0x0012AB97
		// (set) Token: 0x0600BBBA RID: 48058 RVA: 0x0012C9B0 File Offset: 0x0012ABB0
		public unsafe bool bStopAction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bStopAction) & UUserWidget.__PropertyMask_bStopAction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bStopAction) = ((*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bStopAction) & ~UUserWidget.__PropertyMask_bStopAction) | (value ? UUserWidget.__PropertyMask_bStopAction : 0));
			}
		}

		// Token: 0x170022D0 RID: 8912
		// (get) Token: 0x0600BBBB RID: 48059 RVA: 0x0012C9E0 File Offset: 0x0012ABE0
		// (set) Token: 0x0600BBBC RID: 48060 RVA: 0x0012C9F9 File Offset: 0x0012ABF9
		public unsafe bool bHasScriptImplementedTick
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedTick) & UUserWidget.__PropertyMask_bHasScriptImplementedTick) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedTick) = ((*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedTick) & ~UUserWidget.__PropertyMask_bHasScriptImplementedTick) | (value ? UUserWidget.__PropertyMask_bHasScriptImplementedTick : 0));
			}
		}

		// Token: 0x170022D1 RID: 8913
		// (get) Token: 0x0600BBBD RID: 48061 RVA: 0x0012CA29 File Offset: 0x0012AC29
		// (set) Token: 0x0600BBBE RID: 48062 RVA: 0x0012CA42 File Offset: 0x0012AC42
		public unsafe bool bHasScriptImplementedPaint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedPaint) & UUserWidget.__PropertyMask_bHasScriptImplementedPaint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedPaint) = ((*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bHasScriptImplementedPaint) & ~UUserWidget.__PropertyMask_bHasScriptImplementedPaint) | (value ? UUserWidget.__PropertyMask_bHasScriptImplementedPaint : 0));
			}
		}

		// Token: 0x170022D2 RID: 8914
		// (get) Token: 0x0600BBBF RID: 48063 RVA: 0x0012CA72 File Offset: 0x0012AC72
		// (set) Token: 0x0600BBC0 RID: 48064 RVA: 0x0012CA82 File Offset: 0x0012AC82
		public unsafe bool bRemovedFromWorld
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bRemovedFromWorld) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_bRemovedFromWorld) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600BBC1 RID: 48065 RVA: 0x0012CA93 File Offset: 0x0012AC93
		public void UnregisterInputComponent()
		{
			UUserWidget.__UnregisterInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x0600BBC2 RID: 48066 RVA: 0x0012CAA0 File Offset: 0x0012ACA0
		public void StopListeningForInputAction(FName ActionName, EInputEvent EventType)
		{
			UUserWidget.__StopListeningForInputAction_Internal(base.NativePtr, ActionName, EventType);
		}

		// Token: 0x0600BBC3 RID: 48067 RVA: 0x0012CAB4 File Offset: 0x0012ACB4
		public void StopListeningForAllInputActions()
		{
			UUserWidget.__StopListeningForAllInputActions_Internal(base.NativePtr);
		}

		// Token: 0x0600BBC4 RID: 48068 RVA: 0x0012CAC1 File Offset: 0x0012ACC1
		public void StopAnimationsAndLatentActions()
		{
			UUserWidget.__StopAnimationsAndLatentActions_Internal(base.NativePtr);
		}

		// Token: 0x0600BBC5 RID: 48069 RVA: 0x0012CACE File Offset: 0x0012ACCE
		public void StopAllAnimations()
		{
			UUserWidget.__StopAllAnimations_Internal(base.NativePtr);
		}

		// Token: 0x0600BBC6 RID: 48070 RVA: 0x0012CADB File Offset: 0x0012ACDB
		public void SetPositionInViewport(FVector2D Position, bool bRemoveDPIScale = true)
		{
			UUserWidget.__SetPositionInViewport_Internal(base.NativePtr, Position, bRemoveDPIScale);
		}

		// Token: 0x0600BBC7 RID: 48071 RVA: 0x0012CAEA File Offset: 0x0012ACEA
		public void SetPadding(FMargin InPadding)
		{
			UUserWidget.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x0600BBC8 RID: 48072 RVA: 0x0012CAF8 File Offset: 0x0012ACF8
		[NullableContext(2)]
		public void SetOwningPlayer(APlayerController LocalPlayerController)
		{
			UUserWidget.__SetOwningPlayer_Internal(base.NativePtr, (LocalPlayerController != null) ? LocalPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BBC9 RID: 48073 RVA: 0x0012CB15 File Offset: 0x0012AD15
		public void SetInputActionPriority(int NewPriority)
		{
			UUserWidget.__SetInputActionPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x0600BBCA RID: 48074 RVA: 0x0012CB23 File Offset: 0x0012AD23
		public void SetInputActionBlocking(bool bShouldBlock)
		{
			UUserWidget.__SetInputActionBlocking_Internal(base.NativePtr, bShouldBlock);
		}

		// Token: 0x0600BBCB RID: 48075 RVA: 0x0012CB31 File Offset: 0x0012AD31
		[NullableContext(2)]
		public void SetForegroundColor(FSlateColor InForegroundColor)
		{
			UUserWidget.__SetForegroundColor_Internal(base.NativePtr, (InForegroundColor ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x0600BBCC RID: 48076 RVA: 0x0012CB4D File Offset: 0x0012AD4D
		public void SetDesiredSizeInViewport(FVector2D Size)
		{
			UUserWidget.__SetDesiredSizeInViewport_Internal(base.NativePtr, Size);
		}

		// Token: 0x0600BBCD RID: 48077 RVA: 0x0012CB5B File Offset: 0x0012AD5B
		public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			UUserWidget.__SetColorAndOpacity_Internal(base.NativePtr, InColorAndOpacity);
		}

		// Token: 0x0600BBCE RID: 48078 RVA: 0x0012CB69 File Offset: 0x0012AD69
		[NullableContext(2)]
		public void SetAnchorsInViewport(FAnchors Anchors)
		{
			UUserWidget.__SetAnchorsInViewport_Internal(base.NativePtr, (Anchors ?? new FAnchors()).NativePtr);
		}

		// Token: 0x0600BBCF RID: 48079 RVA: 0x0012CB85 File Offset: 0x0012AD85
		public void SetAlignmentInViewport(FVector2D Alignment)
		{
			UUserWidget.__SetAlignmentInViewport_Internal(base.NativePtr, Alignment);
		}

		// Token: 0x0600BBD0 RID: 48080 RVA: 0x0012CB93 File Offset: 0x0012AD93
		public void RemoveFromViewport()
		{
			UUserWidget.__RemoveFromViewport_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD1 RID: 48081 RVA: 0x0012CBA0 File Offset: 0x0012ADA0
		public void RegisterInputComponent()
		{
			UUserWidget.__RegisterInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD2 RID: 48082 RVA: 0x0012CBAD File Offset: 0x0012ADAD
		public virtual void PreConstruct(bool IsDesignTime)
		{
			UUserWidget.__PreConstruct_Internal(base.NativePtr, IsDesignTime);
		}

		// Token: 0x0600BBD3 RID: 48083 RVA: 0x0012CBBB File Offset: 0x0012ADBB
		public virtual void OnMouseCaptureLost()
		{
			UUserWidget.__OnMouseCaptureLost_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD4 RID: 48084 RVA: 0x0012CBC8 File Offset: 0x0012ADC8
		public virtual void OnInitialized()
		{
			UUserWidget.__OnInitialized_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD5 RID: 48085 RVA: 0x0012CBD5 File Offset: 0x0012ADD5
		[NullableContext(2)]
		public void ListenForInputAction(FName ActionName, EInputEvent EventType, bool bConsume, FOnInputAction Callback)
		{
			UUserWidget.__ListenForInputAction_Internal(base.NativePtr, ActionName, EventType, bConsume, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600BBD6 RID: 48086 RVA: 0x0012CBF9 File Offset: 0x0012ADF9
		public bool IsPlayingAnimation()
		{
			return UUserWidget.__IsPlayingAnimation_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD7 RID: 48087 RVA: 0x0012CC06 File Offset: 0x0012AE06
		public bool IsListeningForInputAction(FName ActionName)
		{
			return UUserWidget.__IsListeningForInputAction_Internal(base.NativePtr, ActionName);
		}

		// Token: 0x0600BBD8 RID: 48088 RVA: 0x0012CC14 File Offset: 0x0012AE14
		public bool IsInViewport()
		{
			return UUserWidget.__IsInViewport_Internal(base.NativePtr);
		}

		// Token: 0x0600BBD9 RID: 48089 RVA: 0x0012CC21 File Offset: 0x0012AE21
		public virtual bool IsInteractable()
		{
			return UUserWidget.__IsInteractable_Internal(base.NativePtr);
		}

		// Token: 0x0600BBDA RID: 48090 RVA: 0x0012CC2E File Offset: 0x0012AE2E
		public bool IsAnyAnimationPlaying()
		{
			return UUserWidget.__IsAnyAnimationPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0600BBDB RID: 48091 RVA: 0x0012CC3B File Offset: 0x0012AE3B
		[NullableContext(2)]
		public APawn GetOwningPlayerPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UUserWidget.__GetOwningPlayerPawn_Internal(base.NativePtr));
		}

		// Token: 0x0600BBDC RID: 48092 RVA: 0x0012CC4D File Offset: 0x0012AE4D
		[NullableContext(2)]
		public APlayerCameraManager GetOwningPlayerCameraManager()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(UUserWidget.__GetOwningPlayerCameraManager_Internal(base.NativePtr));
		}

		// Token: 0x0600BBDD RID: 48093 RVA: 0x0012CC5F File Offset: 0x0012AE5F
		public bool GetIsVisible()
		{
			return UUserWidget.__GetIsVisible_Internal(base.NativePtr);
		}

		// Token: 0x0600BBDE RID: 48094 RVA: 0x0012CC6C File Offset: 0x0012AE6C
		public FAnchors GetAnchorsInViewport()
		{
			return new FAnchors(UUserWidget.__GetAnchorsInViewport_Internal(base.NativePtr), null);
		}

		// Token: 0x0600BBDF RID: 48095 RVA: 0x0012CC7F File Offset: 0x0012AE7F
		public FVector2D GetAlignmentInViewport()
		{
			return UUserWidget.__GetAlignmentInViewport_Internal(base.NativePtr);
		}

		// Token: 0x0600BBE0 RID: 48096 RVA: 0x0012CC8C File Offset: 0x0012AE8C
		public void FlushAnimations()
		{
			UUserWidget.__FlushAnimations_Internal(base.NativePtr);
		}

		// Token: 0x0600BBE1 RID: 48097 RVA: 0x0012CC99 File Offset: 0x0012AE99
		public virtual void Destruct()
		{
			UUserWidget.__Destruct_Internal(base.NativePtr);
		}

		// Token: 0x0600BBE2 RID: 48098 RVA: 0x0012CCA6 File Offset: 0x0012AEA6
		public virtual void Construct()
		{
			UUserWidget.__Construct_Internal(base.NativePtr);
		}

		// Token: 0x0600BBE3 RID: 48099 RVA: 0x0012CCB3 File Offset: 0x0012AEB3
		public void CancelLatentActions()
		{
			UUserWidget.__CancelLatentActions_Internal(base.NativePtr);
		}

		// Token: 0x0600BBE4 RID: 48100 RVA: 0x0012CCC0 File Offset: 0x0012AEC0
		public void AddToViewport(int ZOrder = 0)
		{
			UUserWidget.__AddToViewport_Internal(base.NativePtr, ZOrder);
		}

		// Token: 0x0600BBE5 RID: 48101 RVA: 0x0012CCCE File Offset: 0x0012AECE
		public bool AddToPlayerScreen(int ZOrder = 0)
		{
			return UUserWidget.__AddToPlayerScreen_Internal(base.NativePtr, ZOrder);
		}

		// Token: 0x0600BBE6 RID: 48102
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputComponent_Internal(IntPtr @this);

		// Token: 0x0600BBE7 RID: 48103
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopListeningForInputAction_Internal(IntPtr @this, FName ActionName, TEnumAsByte<EInputEvent> EventType);

		// Token: 0x0600BBE8 RID: 48104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopListeningForAllInputActions_Internal(IntPtr @this);

		// Token: 0x0600BBE9 RID: 48105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimationsAndLatentActions_Internal(IntPtr @this);

		// Token: 0x0600BBEA RID: 48106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllAnimations_Internal(IntPtr @this);

		// Token: 0x0600BBEB RID: 48107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPositionInViewport_Internal(IntPtr @this, FVector2D Position, bool bRemoveDPIScale);

		// Token: 0x0600BBEC RID: 48108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x0600BBED RID: 48109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwningPlayer_Internal(IntPtr @this, IntPtr LocalPlayerController);

		// Token: 0x0600BBEE RID: 48110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputActionPriority_Internal(IntPtr @this, int NewPriority);

		// Token: 0x0600BBEF RID: 48111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputActionBlocking_Internal(IntPtr @this, bool bShouldBlock);

		// Token: 0x0600BBF0 RID: 48112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForegroundColor_Internal(IntPtr @this, IntPtr InForegroundColor);

		// Token: 0x0600BBF1 RID: 48113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredSizeInViewport_Internal(IntPtr @this, FVector2D Size);

		// Token: 0x0600BBF2 RID: 48114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, FLinearColor InColorAndOpacity);

		// Token: 0x0600BBF3 RID: 48115
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorsInViewport_Internal(IntPtr @this, IntPtr Anchors);

		// Token: 0x0600BBF4 RID: 48116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignmentInViewport_Internal(IntPtr @this, FVector2D Alignment);

		// Token: 0x0600BBF5 RID: 48117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromViewport_Internal(IntPtr @this);

		// Token: 0x0600BBF6 RID: 48118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterInputComponent_Internal(IntPtr @this);

		// Token: 0x0600BBF7 RID: 48119
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreConstruct_Internal(IntPtr @this, bool IsDesignTime);

		// Token: 0x0600BBF8 RID: 48120
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMouseCaptureLost_Internal(IntPtr @this);

		// Token: 0x0600BBF9 RID: 48121
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInitialized_Internal(IntPtr @this);

		// Token: 0x0600BBFA RID: 48122
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ListenForInputAction_Internal(IntPtr @this, FName ActionName, TEnumAsByte<EInputEvent> EventType, bool bConsume, IntPtr Callback);

		// Token: 0x0600BBFB RID: 48123
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingAnimation_Internal(IntPtr @this);

		// Token: 0x0600BBFC RID: 48124
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsListeningForInputAction_Internal(IntPtr @this, FName ActionName);

		// Token: 0x0600BBFD RID: 48125
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInViewport_Internal(IntPtr @this);

		// Token: 0x0600BBFE RID: 48126
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInteractable_Internal(IntPtr @this);

		// Token: 0x0600BBFF RID: 48127
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyAnimationPlaying_Internal(IntPtr @this);

		// Token: 0x0600BC00 RID: 48128
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerPawn_Internal(IntPtr @this);

		// Token: 0x0600BC01 RID: 48129
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerCameraManager_Internal(IntPtr @this);

		// Token: 0x0600BC02 RID: 48130
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsVisible_Internal(IntPtr @this);

		// Token: 0x0600BC03 RID: 48131
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnchorsInViewport_Internal(IntPtr @this);

		// Token: 0x0600BC04 RID: 48132
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAlignmentInViewport_Internal(IntPtr @this);

		// Token: 0x0600BC05 RID: 48133
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushAnimations_Internal(IntPtr @this);

		// Token: 0x0600BC06 RID: 48134
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Destruct_Internal(IntPtr @this);

		// Token: 0x0600BC07 RID: 48135
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Construct_Internal(IntPtr @this);

		// Token: 0x0600BC08 RID: 48136
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelLatentActions_Internal(IntPtr @this);

		// Token: 0x0600BC09 RID: 48137
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddToViewport_Internal(IntPtr @this, int ZOrder);

		// Token: 0x0600BC0A RID: 48138
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddToPlayerScreen_Internal(IntPtr @this, int ZOrder);

		// Token: 0x0600BC0B RID: 48139 RVA: 0x0012CCDC File Offset: 0x0012AEDC
		static UUserWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UserWidget");
		}

		// Token: 0x0600BC0C RID: 48140 RVA: 0x0012CCEC File Offset: 0x0012AEEC
		protected UUserWidget() : this(BuiltinUtils.AllocNativeUObject(UUserWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BC0D RID: 48141 RVA: 0x0012CD14 File Offset: 0x0012AF14
		protected UUserWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040054FA RID: 21754
		public new const string __ObjectPath = "/Script/UMG.UserWidget";

		// Token: 0x040054FB RID: 21755
		private static IntPtr _ClassPtr;

		// Token: 0x040054FC RID: 21756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040054FD RID: 21757
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x040054FE RID: 21758
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x040054FF RID: 21759
		[Nullable(2)]
		private FGetLinearColor _ColorAndOpacityDelegate;

		// Token: 0x04005500 RID: 21760
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04005501 RID: 21761
		[Nullable(2)]
		private FSlateColor _ForegroundColor;

		// Token: 0x04005502 RID: 21762
		internal static int __PropertyOffset_ForegroundColorDelegate;

		// Token: 0x04005503 RID: 21763
		[Nullable(2)]
		private FGetSlateColor _ForegroundColorDelegate;

		// Token: 0x04005504 RID: 21764
		internal static int __PropertyOffset_OnVisibilityChanged;

		// Token: 0x04005505 RID: 21765
		[Nullable(2)]
		private FOnVisibilityChangedEvent _OnVisibilityChanged;

		// Token: 0x04005506 RID: 21766
		internal static int __PropertyOffset_Padding;

		// Token: 0x04005507 RID: 21767
		internal static int __PropertyOffset_WidgetTree;

		// Token: 0x04005508 RID: 21768
		internal static int __PropertyOffset_Priority;

		// Token: 0x04005509 RID: 21769
		internal static int __PropertyOffset_bSupportsKeyboardFocus_DEPRECATED;

		// Token: 0x0400550A RID: 21770
		internal static byte __PropertyMask_bSupportsKeyboardFocus_DEPRECATED;

		// Token: 0x0400550B RID: 21771
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x0400550C RID: 21772
		internal static byte __PropertyMask_bIsFocusable;

		// Token: 0x0400550D RID: 21773
		internal static int __PropertyOffset_bStopAction;

		// Token: 0x0400550E RID: 21774
		internal static byte __PropertyMask_bStopAction;

		// Token: 0x0400550F RID: 21775
		internal static int __PropertyOffset_bHasScriptImplementedTick;

		// Token: 0x04005510 RID: 21776
		internal static byte __PropertyMask_bHasScriptImplementedTick;

		// Token: 0x04005511 RID: 21777
		internal static int __PropertyOffset_bHasScriptImplementedPaint;

		// Token: 0x04005512 RID: 21778
		internal static byte __PropertyMask_bHasScriptImplementedPaint;

		// Token: 0x04005513 RID: 21779
		internal static int __PropertyOffset_bRemovedFromWorld;

		// Token: 0x02001410 RID: 5136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PreConstruct_FunctionParams
		{
			// Token: 0x040068BE RID: 26814
			[FieldOffset(0)]
			public bool IsDesignTime;
		}

		// Token: 0x02001411 RID: 5137
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInteractable_FunctionParams
		{
			// Token: 0x040068BF RID: 26815
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
