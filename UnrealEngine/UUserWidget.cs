using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029EE RID: 10734
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.UserWidget")]
	[UnrealStructLayout(1160, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1160)]
	public abstract class UUserWidget : UWidget, IUnrealUObject, IUnrealObject, INamedSlotInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06027C1F RID: 162847 RVA: 0x003C9A5C File Offset: 0x003C7C5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUserWidget._ClassPtr;
		}

		// Token: 0x06027C20 RID: 162848 RVA: 0x003C9A68 File Offset: 0x003C7C68
		int INamedSlotInterface.InterfaceOffset()
		{
			return UUserWidget.__InterfaceOffset_INamedSlotInterface;
		}

		// Token: 0x17009847 RID: 38983
		// (get) Token: 0x06027C21 RID: 162849 RVA: 0x003C9A6F File Offset: 0x003C7C6F
		// (set) Token: 0x06027C22 RID: 162850 RVA: 0x003C9A83 File Offset: 0x003C7C83
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

		// Token: 0x17009848 RID: 38984
		// (get) Token: 0x06027C23 RID: 162851 RVA: 0x003C9A98 File Offset: 0x003C7C98
		// (set) Token: 0x06027C24 RID: 162852 RVA: 0x003C9AD1 File Offset: 0x003C7CD1
		[Nullable(1)]
		public FGetLinearColor ColorAndOpacityDelegate
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ColorAndOpacityDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17009849 RID: 38985
		// (get) Token: 0x06027C25 RID: 162853 RVA: 0x003C9AF4 File Offset: 0x003C7CF4
		// (set) Token: 0x06027C26 RID: 162854 RVA: 0x003C9B2D File Offset: 0x003C7D2D
		[Nullable(1)]
		public FSlateColor ForegroundColor
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSlateColor.StaticStruct(), base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColor, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700984A RID: 38986
		// (get) Token: 0x06027C27 RID: 162855 RVA: 0x003C9B50 File Offset: 0x003C7D50
		// (set) Token: 0x06027C28 RID: 162856 RVA: 0x003C9B89 File Offset: 0x003C7D89
		[Nullable(1)]
		public FGetSlateColor ForegroundColorDelegate
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ForegroundColorDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700984B RID: 38987
		// (get) Token: 0x06027C29 RID: 162857 RVA: 0x003C9BAC File Offset: 0x003C7DAC
		// (set) Token: 0x06027C2A RID: 162858 RVA: 0x003C9BE5 File Offset: 0x003C7DE5
		[Nullable(1)]
		public FOnVisibilityChangedEvent OnVisibilityChanged
		{
			[NullableContext(1)]
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
			[NullableContext(1)]
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_OnVisibilityChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700984C RID: 38988
		// (get) Token: 0x06027C2B RID: 162859 RVA: 0x003C9C06 File Offset: 0x003C7E06
		// (set) Token: 0x06027C2C RID: 162860 RVA: 0x003C9C1A File Offset: 0x003C7E1A
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

		// Token: 0x1700984D RID: 38989
		// (get) Token: 0x06027C2D RID: 162861 RVA: 0x003C9C30 File Offset: 0x003C7E30
		// (set) Token: 0x06027C2E RID: 162862 RVA: 0x003C9C69 File Offset: 0x003C7E69
		[Nullable(1)]
		public TArray<UUMGSequencePlayer> ActiveSequencePlayers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUMGSequencePlayer> result;
				if ((result = this._ActiveSequencePlayers) == null)
				{
					result = (this._ActiveSequencePlayers = new TArray<UUMGSequencePlayer>(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_ActiveSequencePlayers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.ActiveSequencePlayers.CopyAssign(value);
			}
		}

		// Token: 0x1700984E RID: 38990
		// (get) Token: 0x06027C2F RID: 162863 RVA: 0x003C9C77 File Offset: 0x003C7E77
		// (set) Token: 0x06027C30 RID: 162864 RVA: 0x003C9C8B File Offset: 0x003C7E8B
		public unsafe UUMGSequenceTickManager AnimationTickManager
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUMGSequenceTickManager>(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_AnimationTickManager);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_AnimationTickManager, value);
			}
		}

		// Token: 0x1700984F RID: 38991
		// (get) Token: 0x06027C31 RID: 162865 RVA: 0x003C9CA0 File Offset: 0x003C7EA0
		// (set) Token: 0x06027C32 RID: 162866 RVA: 0x003C9CD9 File Offset: 0x003C7ED9
		[Nullable(1)]
		public TArray<UUMGSequencePlayer> StoppedSequencePlayers
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UUMGSequencePlayer> result;
				if ((result = this._StoppedSequencePlayers) == null)
				{
					result = (this._StoppedSequencePlayers = new TArray<UUMGSequencePlayer>(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_StoppedSequencePlayers, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.StoppedSequencePlayers.CopyAssign(value);
			}
		}

		// Token: 0x17009850 RID: 38992
		// (get) Token: 0x06027C33 RID: 162867 RVA: 0x003C9CE8 File Offset: 0x003C7EE8
		// (set) Token: 0x06027C34 RID: 162868 RVA: 0x003C9D21 File Offset: 0x003C7F21
		[Nullable(1)]
		public TArray<FNamedSlotBinding> NamedSlotBindings
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FNamedSlotBinding> result;
				if ((result = this._NamedSlotBindings) == null)
				{
					result = (this._NamedSlotBindings = new TArray<FNamedSlotBinding>(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_NamedSlotBindings, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.NamedSlotBindings.CopyAssign(value);
			}
		}

		// Token: 0x17009851 RID: 38993
		// (get) Token: 0x06027C35 RID: 162869 RVA: 0x003C9D2F File Offset: 0x003C7F2F
		// (set) Token: 0x06027C36 RID: 162870 RVA: 0x003C9D43 File Offset: 0x003C7F43
		public unsafe UWidgetTree WidgetTree
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UWidgetTree>(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_WidgetTree);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_WidgetTree, value);
			}
		}

		// Token: 0x17009852 RID: 38994
		// (get) Token: 0x06027C37 RID: 162871 RVA: 0x003C9D58 File Offset: 0x003C7F58
		// (set) Token: 0x06027C38 RID: 162872 RVA: 0x003C9D68 File Offset: 0x003C7F68
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

		// Token: 0x17009853 RID: 38995
		// (get) Token: 0x06027C39 RID: 162873 RVA: 0x003C9D79 File Offset: 0x003C7F79
		// (set) Token: 0x06027C3A RID: 162874 RVA: 0x003C9D92 File Offset: 0x003C7F92
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

		// Token: 0x17009854 RID: 38996
		// (get) Token: 0x06027C3B RID: 162875 RVA: 0x003C9DC2 File Offset: 0x003C7FC2
		// (set) Token: 0x06027C3C RID: 162876 RVA: 0x003C9DDB File Offset: 0x003C7FDB
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

		// Token: 0x17009855 RID: 38997
		// (get) Token: 0x06027C3D RID: 162877 RVA: 0x003C9E0B File Offset: 0x003C800B
		// (set) Token: 0x06027C3E RID: 162878 RVA: 0x003C9E24 File Offset: 0x003C8024
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

		// Token: 0x17009856 RID: 38998
		// (get) Token: 0x06027C3F RID: 162879 RVA: 0x003C9E54 File Offset: 0x003C8054
		// (set) Token: 0x06027C40 RID: 162880 RVA: 0x003C9E6D File Offset: 0x003C806D
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

		// Token: 0x17009857 RID: 38999
		// (get) Token: 0x06027C41 RID: 162881 RVA: 0x003C9E9D File Offset: 0x003C809D
		// (set) Token: 0x06027C42 RID: 162882 RVA: 0x003C9EB6 File Offset: 0x003C80B6
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

		// Token: 0x17009858 RID: 39000
		// (get) Token: 0x06027C43 RID: 162883 RVA: 0x003C9EE6 File Offset: 0x003C80E6
		// (set) Token: 0x06027C44 RID: 162884 RVA: 0x003C9EF6 File Offset: 0x003C80F6
		public unsafe EWidgetTickFrequency TickFrequency
		{
			get
			{
				return (EWidgetTickFrequency)(*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_TickFrequency));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_TickFrequency) = (byte)value;
			}
		}

		// Token: 0x17009859 RID: 39001
		// (get) Token: 0x06027C45 RID: 162885 RVA: 0x003C9F07 File Offset: 0x003C8107
		// (set) Token: 0x06027C46 RID: 162886 RVA: 0x003C9F1B File Offset: 0x003C811B
		public unsafe UInputComponent InputComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UInputComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_InputComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUserWidget.__PropertyOffset_InputComponent, value);
			}
		}

		// Token: 0x1700985A RID: 39002
		// (get) Token: 0x06027C47 RID: 162887 RVA: 0x003C9F30 File Offset: 0x003C8130
		// (set) Token: 0x06027C48 RID: 162888 RVA: 0x003C9F69 File Offset: 0x003C8169
		[Nullable(1)]
		public TArray<FAnimationEventBinding> AnimationCallbacks
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FAnimationEventBinding> result;
				if ((result = this._AnimationCallbacks) == null)
				{
					result = (this._AnimationCallbacks = new TArray<FAnimationEventBinding>(base.NativePtr + (IntPtr)UUserWidget.__PropertyOffset_AnimationCallbacks, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimationCallbacks.CopyAssign(value);
			}
		}

		// Token: 0x1700985B RID: 39003
		// (get) Token: 0x06027C49 RID: 162889 RVA: 0x003C9F77 File Offset: 0x003C8177
		// (set) Token: 0x06027C4A RID: 162890 RVA: 0x003C9F87 File Offset: 0x003C8187
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

		// Token: 0x06027C4B RID: 162891 RVA: 0x003C9F98 File Offset: 0x003C8198
		public void UnregisterInputComponent()
		{
			UUserWidget.__UnregisterInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x06027C4C RID: 162892 RVA: 0x003C9FA5 File Offset: 0x003C81A5
		public void UnbindFromAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			UUserWidget.__UnbindFromAnimationStarted_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027C4D RID: 162893 RVA: 0x003C9FCF File Offset: 0x003C81CF
		public void UnbindFromAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			UUserWidget.__UnbindFromAnimationFinished_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027C4E RID: 162894 RVA: 0x003C9FF9 File Offset: 0x003C81F9
		public void UnbindAllFromAnimationStarted(UWidgetAnimation Animation)
		{
			UUserWidget.__UnbindAllFromAnimationStarted_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C4F RID: 162895 RVA: 0x003CA016 File Offset: 0x003C8216
		public void UnbindAllFromAnimationFinished(UWidgetAnimation Animation)
		{
			UUserWidget.__UnbindAllFromAnimationFinished_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C50 RID: 162896 RVA: 0x003CA033 File Offset: 0x003C8233
		public virtual void Tick(FGeometry MyGeometry, float InDeltaTime)
		{
			UUserWidget.__Tick_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, InDeltaTime);
		}

		// Token: 0x06027C51 RID: 162897 RVA: 0x003CA050 File Offset: 0x003C8250
		public void StopListeningForInputAction(FName ActionName, EInputEvent EventType)
		{
			UUserWidget.__StopListeningForInputAction_Internal(base.NativePtr, ActionName, EventType);
		}

		// Token: 0x06027C52 RID: 162898 RVA: 0x003CA064 File Offset: 0x003C8264
		public void StopListeningForAllInputActions()
		{
			UUserWidget.__StopListeningForAllInputActions_Internal(base.NativePtr);
		}

		// Token: 0x06027C53 RID: 162899 RVA: 0x003CA071 File Offset: 0x003C8271
		public void StopAnimationsAndLatentActions()
		{
			UUserWidget.__StopAnimationsAndLatentActions_Internal(base.NativePtr);
		}

		// Token: 0x06027C54 RID: 162900 RVA: 0x003CA07E File Offset: 0x003C827E
		public void StopAnimation(UWidgetAnimation InAnimation)
		{
			UUserWidget.__StopAnimation_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C55 RID: 162901 RVA: 0x003CA09B File Offset: 0x003C829B
		public void StopAllAnimations()
		{
			UUserWidget.__StopAllAnimations_Internal(base.NativePtr);
		}

		// Token: 0x06027C56 RID: 162902 RVA: 0x003CA0A8 File Offset: 0x003C82A8
		public void SetPositionInViewport(FVector2D Position, bool bRemoveDPIScale = true)
		{
			UUserWidget.__SetPositionInViewport_Internal(base.NativePtr, Position, bRemoveDPIScale);
		}

		// Token: 0x06027C57 RID: 162903 RVA: 0x003CA0B7 File Offset: 0x003C82B7
		public void SetPlaybackSpeed(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f)
		{
			UUserWidget.__SetPlaybackSpeed_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, PlaybackSpeed);
		}

		// Token: 0x06027C58 RID: 162904 RVA: 0x003CA0D5 File Offset: 0x003C82D5
		public void SetPadding(FMargin InPadding)
		{
			UUserWidget.__SetPadding_Internal(base.NativePtr, InPadding);
		}

		// Token: 0x06027C59 RID: 162905 RVA: 0x003CA0E3 File Offset: 0x003C82E3
		public void SetOwningPlayer(APlayerController LocalPlayerController)
		{
			UUserWidget.__SetOwningPlayer_Internal(base.NativePtr, (LocalPlayerController != null) ? LocalPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C5A RID: 162906 RVA: 0x003CA100 File Offset: 0x003C8300
		public void SetNumLoopsToPlay(UWidgetAnimation InAnimation, int NumLoopsToPlay)
		{
			UUserWidget.__SetNumLoopsToPlay_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, NumLoopsToPlay);
		}

		// Token: 0x06027C5B RID: 162907 RVA: 0x003CA11E File Offset: 0x003C831E
		public void SetInputActionPriority(int NewPriority)
		{
			UUserWidget.__SetInputActionPriority_Internal(base.NativePtr, NewPriority);
		}

		// Token: 0x06027C5C RID: 162908 RVA: 0x003CA12C File Offset: 0x003C832C
		public void SetInputActionBlocking(bool bShouldBlock)
		{
			UUserWidget.__SetInputActionBlocking_Internal(base.NativePtr, bShouldBlock);
		}

		// Token: 0x06027C5D RID: 162909 RVA: 0x003CA13A File Offset: 0x003C833A
		public void SetForegroundColor(FSlateColor InForegroundColor)
		{
			UUserWidget.__SetForegroundColor_Internal(base.NativePtr, (InForegroundColor ?? new FSlateColor()).NativePtr);
		}

		// Token: 0x06027C5E RID: 162910 RVA: 0x003CA156 File Offset: 0x003C8356
		public void SetDesiredSizeInViewport(FVector2D Size)
		{
			UUserWidget.__SetDesiredSizeInViewport_Internal(base.NativePtr, Size);
		}

		// Token: 0x06027C5F RID: 162911 RVA: 0x003CA164 File Offset: 0x003C8364
		public void SetColorAndOpacity(FLinearColor InColorAndOpacity)
		{
			UUserWidget.__SetColorAndOpacity_Internal(base.NativePtr, InColorAndOpacity);
		}

		// Token: 0x06027C60 RID: 162912 RVA: 0x003CA172 File Offset: 0x003C8372
		public void SetAnimationCurrentTime(UWidgetAnimation InAnimation, float InTime)
		{
			UUserWidget.__SetAnimationCurrentTime_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, InTime);
		}

		// Token: 0x06027C61 RID: 162913 RVA: 0x003CA190 File Offset: 0x003C8390
		public void SetAnchorsInViewport(FAnchors Anchors)
		{
			UUserWidget.__SetAnchorsInViewport_Internal(base.NativePtr, (Anchors ?? new FAnchors()).NativePtr);
		}

		// Token: 0x06027C62 RID: 162914 RVA: 0x003CA1AC File Offset: 0x003C83AC
		public void SetAlignmentInViewport(FVector2D Alignment)
		{
			UUserWidget.__SetAlignmentInViewport_Internal(base.NativePtr, Alignment);
		}

		// Token: 0x06027C63 RID: 162915 RVA: 0x003CA1BA File Offset: 0x003C83BA
		public void ReverseAnimation(UWidgetAnimation InAnimation)
		{
			UUserWidget.__ReverseAnimation_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C64 RID: 162916 RVA: 0x003CA1D7 File Offset: 0x003C83D7
		public void RemoveFromViewport()
		{
			UUserWidget.__RemoveFromViewport_Internal(base.NativePtr);
		}

		// Token: 0x06027C65 RID: 162917 RVA: 0x003CA1E4 File Offset: 0x003C83E4
		public void RegisterInputComponent()
		{
			UUserWidget.__RegisterInputComponent_Internal(base.NativePtr);
		}

		// Token: 0x06027C66 RID: 162918 RVA: 0x003CA1F1 File Offset: 0x003C83F1
		public virtual void PreConstruct(bool IsDesignTime)
		{
			UUserWidget.__PreConstruct_Internal(base.NativePtr, IsDesignTime);
		}

		// Token: 0x06027C67 RID: 162919 RVA: 0x003CA1FF File Offset: 0x003C83FF
		public void PlaySound(USoundBase SoundToPlay)
		{
			UUserWidget.__PlaySound_Internal(base.NativePtr, (SoundToPlay != null) ? SoundToPlay.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C68 RID: 162920 RVA: 0x003CA21C File Offset: 0x003C841C
		public UUMGSequencePlayer PlayAnimationTimeRange(UWidgetAnimation InAnimation, float StartAtTime = 0f, float EndAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f, bool bRestoreState = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(UUserWidget.__PlayAnimationTimeRange_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, StartAtTime, EndAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed, bRestoreState));
		}

		// Token: 0x06027C69 RID: 162921 RVA: 0x003CA24D File Offset: 0x003C844D
		public UUMGSequencePlayer PlayAnimationReverse(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f, bool bRestoreState = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(UUserWidget.__PlayAnimationReverse_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, PlaybackSpeed, bRestoreState));
		}

		// Token: 0x06027C6A RID: 162922 RVA: 0x003CA271 File Offset: 0x003C8471
		public UUMGSequencePlayer PlayAnimationForward(UWidgetAnimation InAnimation, float PlaybackSpeed = 1f, bool bRestoreState = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(UUserWidget.__PlayAnimationForward_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, PlaybackSpeed, bRestoreState));
		}

		// Token: 0x06027C6B RID: 162923 RVA: 0x003CA295 File Offset: 0x003C8495
		public UUMGSequencePlayer PlayAnimation(UWidgetAnimation InAnimation, float StartAtTime = 0f, int NumLoopsToPlay = 1, EUMGSequencePlayMode PlayMode = EUMGSequencePlayMode.Forward, float PlaybackSpeed = 1f, bool bRestoreState = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUMGSequencePlayer>(UUserWidget.__PlayAnimation_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero, StartAtTime, NumLoopsToPlay, PlayMode, PlaybackSpeed, bRestoreState));
		}

		// Token: 0x06027C6C RID: 162924 RVA: 0x003CA2C4 File Offset: 0x003C84C4
		public float PauseAnimation(UWidgetAnimation InAnimation)
		{
			return UUserWidget.__PauseAnimation_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C6D RID: 162925 RVA: 0x003CA2E1 File Offset: 0x003C84E1
		[return: Nullable(1)]
		public virtual FEventReply OnTouchStarted(FGeometry MyGeometry, in FPointerEvent InTouchEvent)
		{
			return new FEventReply(UUserWidget.__OnTouchStarted_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InTouchEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C6E RID: 162926 RVA: 0x003CA313 File Offset: 0x003C8513
		[return: Nullable(1)]
		public virtual FEventReply OnTouchMoved(FGeometry MyGeometry, in FPointerEvent InTouchEvent)
		{
			return new FEventReply(UUserWidget.__OnTouchMoved_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InTouchEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C6F RID: 162927 RVA: 0x003CA345 File Offset: 0x003C8545
		[return: Nullable(1)]
		public virtual FEventReply OnTouchGesture(FGeometry MyGeometry, in FPointerEvent GestureEvent)
		{
			return new FEventReply(UUserWidget.__OnTouchGesture_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (GestureEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C70 RID: 162928 RVA: 0x003CA377 File Offset: 0x003C8577
		[return: Nullable(1)]
		public virtual FEventReply OnTouchForceChanged(FGeometry MyGeometry, in FPointerEvent InTouchEvent)
		{
			return new FEventReply(UUserWidget.__OnTouchForceChanged_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InTouchEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C71 RID: 162929 RVA: 0x003CA3A9 File Offset: 0x003C85A9
		[return: Nullable(1)]
		public virtual FEventReply OnTouchEnded(FGeometry MyGeometry, in FPointerEvent InTouchEvent)
		{
			return new FEventReply(UUserWidget.__OnTouchEnded_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InTouchEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C72 RID: 162930 RVA: 0x003CA3DB File Offset: 0x003C85DB
		public virtual void OnRemovedFromFocusPath(FFocusEvent InFocusEvent)
		{
			UUserWidget.__OnRemovedFromFocusPath_Internal(base.NativePtr, (InFocusEvent ?? new FFocusEvent()).NativePtr);
		}

		// Token: 0x06027C73 RID: 162931 RVA: 0x003CA3F7 File Offset: 0x003C85F7
		[return: Nullable(1)]
		public virtual FEventReply OnPreviewMouseButtonDown(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			return new FEventReply(UUserWidget.__OnPreviewMouseButtonDown_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C74 RID: 162932 RVA: 0x003CA429 File Offset: 0x003C8629
		[return: Nullable(1)]
		public virtual FEventReply OnPreviewKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			return new FEventReply(UUserWidget.__OnPreviewKeyDown_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InKeyEvent ?? new FKeyEvent()).NativePtr), null);
		}

		// Token: 0x06027C75 RID: 162933 RVA: 0x003CA45A File Offset: 0x003C865A
		public virtual void OnPaint(ref FPaintContext Context)
		{
			UUserWidget.__OnPaint_Internal(base.NativePtr, (Context ?? new FPaintContext()).NativePtr);
		}

		// Token: 0x06027C76 RID: 162934 RVA: 0x003CA477 File Offset: 0x003C8677
		[return: Nullable(1)]
		public virtual FEventReply OnMouseWheel(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			return new FEventReply(UUserWidget.__OnMouseWheel_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C77 RID: 162935 RVA: 0x003CA4A9 File Offset: 0x003C86A9
		[return: Nullable(1)]
		public virtual FEventReply OnMouseMove(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			return new FEventReply(UUserWidget.__OnMouseMove_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C78 RID: 162936 RVA: 0x003CA4DB File Offset: 0x003C86DB
		public virtual void OnMouseLeave(in FPointerEvent MouseEvent)
		{
			UUserWidget.__OnMouseLeave_Internal(base.NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x06027C79 RID: 162937 RVA: 0x003CA4F8 File Offset: 0x003C86F8
		public virtual void OnMouseEnter(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			UUserWidget.__OnMouseEnter_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x06027C7A RID: 162938 RVA: 0x003CA524 File Offset: 0x003C8724
		public virtual void OnMouseCaptureLost()
		{
			UUserWidget.__OnMouseCaptureLost_Internal(base.NativePtr);
		}

		// Token: 0x06027C7B RID: 162939 RVA: 0x003CA531 File Offset: 0x003C8731
		[return: Nullable(1)]
		public virtual FEventReply OnMouseButtonUp(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			return new FEventReply(UUserWidget.__OnMouseButtonUp_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C7C RID: 162940 RVA: 0x003CA563 File Offset: 0x003C8763
		[return: Nullable(1)]
		public virtual FEventReply OnMouseButtonDown(FGeometry MyGeometry, in FPointerEvent MouseEvent)
		{
			return new FEventReply(UUserWidget.__OnMouseButtonDown_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (MouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C7D RID: 162941 RVA: 0x003CA595 File Offset: 0x003C8795
		[return: Nullable(1)]
		public virtual FEventReply OnMouseButtonDoubleClick(FGeometry InMyGeometry, in FPointerEvent InMouseEvent)
		{
			return new FEventReply(UUserWidget.__OnMouseButtonDoubleClick_Internal(base.NativePtr, (InMyGeometry ?? new FGeometry()).NativePtr, (InMouseEvent ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027C7E RID: 162942 RVA: 0x003CA5C7 File Offset: 0x003C87C7
		[return: Nullable(1)]
		public virtual FEventReply OnMotionDetected(FGeometry MyGeometry, FMotionEvent InMotionEvent)
		{
			return new FEventReply(UUserWidget.__OnMotionDetected_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InMotionEvent ?? new FMotionEvent()).NativePtr), null);
		}

		// Token: 0x06027C7F RID: 162943 RVA: 0x003CA5F8 File Offset: 0x003C87F8
		[return: Nullable(1)]
		public virtual FEventReply OnKeyUp(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			return new FEventReply(UUserWidget.__OnKeyUp_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InKeyEvent ?? new FKeyEvent()).NativePtr), null);
		}

		// Token: 0x06027C80 RID: 162944 RVA: 0x003CA629 File Offset: 0x003C8829
		[return: Nullable(1)]
		public virtual FEventReply OnKeyDown(FGeometry MyGeometry, FKeyEvent InKeyEvent)
		{
			return new FEventReply(UUserWidget.__OnKeyDown_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InKeyEvent ?? new FKeyEvent()).NativePtr), null);
		}

		// Token: 0x06027C81 RID: 162945 RVA: 0x003CA65A File Offset: 0x003C885A
		[return: Nullable(1)]
		public virtual FEventReply OnKeyChar(FGeometry MyGeometry, FCharacterEvent InCharacterEvent)
		{
			return new FEventReply(UUserWidget.__OnKeyChar_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InCharacterEvent ?? new FCharacterEvent()).NativePtr), null);
		}

		// Token: 0x06027C82 RID: 162946 RVA: 0x003CA68B File Offset: 0x003C888B
		public virtual void OnInitialized()
		{
			UUserWidget.__OnInitialized_Internal(base.NativePtr);
		}

		// Token: 0x06027C83 RID: 162947 RVA: 0x003CA698 File Offset: 0x003C8898
		[return: Nullable(1)]
		public virtual FEventReply OnFocusReceived(FGeometry MyGeometry, FFocusEvent InFocusEvent)
		{
			return new FEventReply(UUserWidget.__OnFocusReceived_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InFocusEvent ?? new FFocusEvent()).NativePtr), null);
		}

		// Token: 0x06027C84 RID: 162948 RVA: 0x003CA6C9 File Offset: 0x003C88C9
		public virtual void OnFocusLost(FFocusEvent InFocusEvent)
		{
			UUserWidget.__OnFocusLost_Internal(base.NativePtr, (InFocusEvent ?? new FFocusEvent()).NativePtr);
		}

		// Token: 0x06027C85 RID: 162949 RVA: 0x003CA6E5 File Offset: 0x003C88E5
		public virtual bool OnDrop(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			return UUserWidget.__OnDrop_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, (Operation != null) ? Operation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C86 RID: 162950 RVA: 0x003CA720 File Offset: 0x003C8920
		public virtual bool OnDragOver(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			return UUserWidget.__OnDragOver_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, (Operation != null) ? Operation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C87 RID: 162951 RVA: 0x003CA75B File Offset: 0x003C895B
		public virtual void OnDragLeave(FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			UUserWidget.__OnDragLeave_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, (Operation != null) ? Operation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C88 RID: 162952 RVA: 0x003CA787 File Offset: 0x003C8987
		public virtual void OnDragEnter(FGeometry MyGeometry, FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			UUserWidget.__OnDragEnter_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, (Operation != null) ? Operation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C89 RID: 162953 RVA: 0x003CA7C4 File Offset: 0x003C89C4
		public virtual void OnDragDetected(FGeometry MyGeometry, in FPointerEvent PointerEvent, ref UDragDropOperation Operation)
		{
			UDragDropOperation udragDropOperation = Operation;
			IntPtr nativeObjectPtr = (udragDropOperation != null) ? udragDropOperation.NativePtr : IntPtr.Zero;
			UUserWidget.__OnDragDetected_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, ref nativeObjectPtr);
			Operation = BuiltinUtils.GetOrCreateUObjectByNativePointer<UDragDropOperation>(nativeObjectPtr);
		}

		// Token: 0x06027C8A RID: 162954 RVA: 0x003CA818 File Offset: 0x003C8A18
		public virtual void OnDragCancelled(in FPointerEvent PointerEvent, UDragDropOperation Operation)
		{
			UUserWidget.__OnDragCancelled_Internal(base.NativePtr, (PointerEvent ?? new FPointerEvent()).NativePtr, (Operation != null) ? Operation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C8B RID: 162955 RVA: 0x003CA845 File Offset: 0x003C8A45
		public virtual void OnAnimationStarted(UWidgetAnimation Animation)
		{
			UUserWidget.__OnAnimationStarted_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C8C RID: 162956 RVA: 0x003CA862 File Offset: 0x003C8A62
		protected virtual void OnAnimationStarted_Implementation(UWidgetAnimation Animation)
		{
			UUserWidget.__OnAnimationStarted_Implementation_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C8D RID: 162957 RVA: 0x003CA87F File Offset: 0x003C8A7F
		public virtual void OnAnimationFinished(UWidgetAnimation Animation)
		{
			UUserWidget.__OnAnimationFinished_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C8E RID: 162958 RVA: 0x003CA89C File Offset: 0x003C8A9C
		protected virtual void OnAnimationFinished_Implementation(UWidgetAnimation Animation)
		{
			UUserWidget.__OnAnimationFinished_Implementation_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C8F RID: 162959 RVA: 0x003CA8B9 File Offset: 0x003C8AB9
		[return: Nullable(1)]
		public virtual FEventReply OnAnalogValueChanged(FGeometry MyGeometry, FAnalogInputEvent InAnalogInputEvent)
		{
			return new FEventReply(UUserWidget.__OnAnalogValueChanged_Internal(base.NativePtr, (MyGeometry ?? new FGeometry()).NativePtr, (InAnalogInputEvent ?? new FAnalogInputEvent()).NativePtr), null);
		}

		// Token: 0x06027C90 RID: 162960 RVA: 0x003CA8EA File Offset: 0x003C8AEA
		public virtual void OnAddedToFocusPath(FFocusEvent InFocusEvent)
		{
			UUserWidget.__OnAddedToFocusPath_Internal(base.NativePtr, (InFocusEvent ?? new FFocusEvent()).NativePtr);
		}

		// Token: 0x06027C91 RID: 162961 RVA: 0x003CA906 File Offset: 0x003C8B06
		public void ListenForInputAction(FName ActionName, EInputEvent EventType, bool bConsume, FOnInputAction Callback)
		{
			UUserWidget.__ListenForInputAction_Internal(base.NativePtr, ActionName, EventType, bConsume, (Callback != null) ? Callback.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027C92 RID: 162962 RVA: 0x003CA92A File Offset: 0x003C8B2A
		public bool IsPlayingAnimation()
		{
			return UUserWidget.__IsPlayingAnimation_Internal(base.NativePtr);
		}

		// Token: 0x06027C93 RID: 162963 RVA: 0x003CA937 File Offset: 0x003C8B37
		public bool IsListeningForInputAction(FName ActionName)
		{
			return UUserWidget.__IsListeningForInputAction_Internal(base.NativePtr, ActionName);
		}

		// Token: 0x06027C94 RID: 162964 RVA: 0x003CA945 File Offset: 0x003C8B45
		public bool IsInViewport()
		{
			return UUserWidget.__IsInViewport_Internal(base.NativePtr);
		}

		// Token: 0x06027C95 RID: 162965 RVA: 0x003CA952 File Offset: 0x003C8B52
		public virtual bool IsInteractable()
		{
			return UUserWidget.__IsInteractable_Internal(base.NativePtr);
		}

		// Token: 0x06027C96 RID: 162966 RVA: 0x003CA95F File Offset: 0x003C8B5F
		public bool IsAnyAnimationPlaying()
		{
			return UUserWidget.__IsAnyAnimationPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06027C97 RID: 162967 RVA: 0x003CA96C File Offset: 0x003C8B6C
		public bool IsAnimationPlayingForward(UWidgetAnimation InAnimation)
		{
			return UUserWidget.__IsAnimationPlayingForward_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C98 RID: 162968 RVA: 0x003CA989 File Offset: 0x003C8B89
		public bool IsAnimationPlaying(UWidgetAnimation InAnimation)
		{
			return UUserWidget.__IsAnimationPlaying_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C99 RID: 162969 RVA: 0x003CA9A6 File Offset: 0x003C8BA6
		public APawn GetOwningPlayerPawn()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APawn>(UUserWidget.__GetOwningPlayerPawn_Internal(base.NativePtr));
		}

		// Token: 0x06027C9A RID: 162970 RVA: 0x003CA9B8 File Offset: 0x003C8BB8
		public APlayerCameraManager GetOwningPlayerCameraManager()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<APlayerCameraManager>(UUserWidget.__GetOwningPlayerCameraManager_Internal(base.NativePtr));
		}

		// Token: 0x06027C9B RID: 162971 RVA: 0x003CA9CA File Offset: 0x003C8BCA
		public bool GetIsVisible()
		{
			return UUserWidget.__GetIsVisible_Internal(base.NativePtr);
		}

		// Token: 0x06027C9C RID: 162972 RVA: 0x003CA9D7 File Offset: 0x003C8BD7
		public float GetAnimationCurrentTime(UWidgetAnimation InAnimation)
		{
			return UUserWidget.__GetAnimationCurrentTime_Internal(base.NativePtr, (InAnimation != null) ? InAnimation.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027C9D RID: 162973 RVA: 0x003CA9F4 File Offset: 0x003C8BF4
		[NullableContext(1)]
		public FAnchors GetAnchorsInViewport()
		{
			return new FAnchors(UUserWidget.__GetAnchorsInViewport_Internal(base.NativePtr), null);
		}

		// Token: 0x06027C9E RID: 162974 RVA: 0x003CAA07 File Offset: 0x003C8C07
		public FVector2D GetAlignmentInViewport()
		{
			return UUserWidget.__GetAlignmentInViewport_Internal(base.NativePtr);
		}

		// Token: 0x06027C9F RID: 162975 RVA: 0x003CAA14 File Offset: 0x003C8C14
		public void FlushAnimations()
		{
			UUserWidget.__FlushAnimations_Internal(base.NativePtr);
		}

		// Token: 0x06027CA0 RID: 162976 RVA: 0x003CAA21 File Offset: 0x003C8C21
		public virtual void Destruct()
		{
			UUserWidget.__Destruct_Internal(base.NativePtr);
		}

		// Token: 0x06027CA1 RID: 162977 RVA: 0x003CAA2E File Offset: 0x003C8C2E
		public virtual void Construct()
		{
			UUserWidget.__Construct_Internal(base.NativePtr);
		}

		// Token: 0x06027CA2 RID: 162978 RVA: 0x003CAA3B File Offset: 0x003C8C3B
		public void CancelLatentActions()
		{
			UUserWidget.__CancelLatentActions_Internal(base.NativePtr);
		}

		// Token: 0x06027CA3 RID: 162979 RVA: 0x003CAA48 File Offset: 0x003C8C48
		public void BindToAnimationStarted(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			UUserWidget.__BindToAnimationStarted_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027CA4 RID: 162980 RVA: 0x003CAA72 File Offset: 0x003C8C72
		public void BindToAnimationFinished(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate)
		{
			UUserWidget.__BindToAnimationFinished_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027CA5 RID: 162981 RVA: 0x003CAA9C File Offset: 0x003C8C9C
		public void BindToAnimationEvent(UWidgetAnimation Animation, FWidgetAnimationDynamicEvent Delegate, EWidgetAnimationEvent AnimationEvent, FName UserTag = default(FName))
		{
			UUserWidget.__BindToAnimationEvent_Internal(base.NativePtr, (Animation != null) ? Animation.NativePtr : IntPtr.Zero, (Delegate != null) ? Delegate.NativePtr : ((IntPtr)0), AnimationEvent, UserTag);
		}

		// Token: 0x06027CA6 RID: 162982 RVA: 0x003CAAC9 File Offset: 0x003C8CC9
		public void AddToViewport(int ZOrder = 0)
		{
			UUserWidget.__AddToViewport_Internal(base.NativePtr, ZOrder);
		}

		// Token: 0x06027CA7 RID: 162983 RVA: 0x003CAAD7 File Offset: 0x003C8CD7
		public bool AddToPlayerScreen(int ZOrder = 0)
		{
			return UUserWidget.__AddToPlayerScreen_Internal(base.NativePtr, ZOrder);
		}

		// Token: 0x06027CA8 RID: 162984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputComponent_Internal(IntPtr @this);

		// Token: 0x06027CA9 RID: 162985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindFromAnimationStarted_Internal(IntPtr @this, IntPtr Animation, IntPtr Delegate);

		// Token: 0x06027CAA RID: 162986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindFromAnimationFinished_Internal(IntPtr @this, IntPtr Animation, IntPtr Delegate);

		// Token: 0x06027CAB RID: 162987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindAllFromAnimationStarted_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CAC RID: 162988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindAllFromAnimationFinished_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CAD RID: 162989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Tick_Internal(IntPtr @this, IntPtr MyGeometry, float InDeltaTime);

		// Token: 0x06027CAE RID: 162990
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopListeningForInputAction_Internal(IntPtr @this, FName ActionName, TEnumAsByte<EInputEvent> EventType);

		// Token: 0x06027CAF RID: 162991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopListeningForAllInputActions_Internal(IntPtr @this);

		// Token: 0x06027CB0 RID: 162992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimationsAndLatentActions_Internal(IntPtr @this);

		// Token: 0x06027CB1 RID: 162993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAnimation_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CB2 RID: 162994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAllAnimations_Internal(IntPtr @this);

		// Token: 0x06027CB3 RID: 162995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPositionInViewport_Internal(IntPtr @this, FVector2D Position, bool bRemoveDPIScale);

		// Token: 0x06027CB4 RID: 162996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackSpeed_Internal(IntPtr @this, IntPtr InAnimation, float PlaybackSpeed);

		// Token: 0x06027CB5 RID: 162997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPadding_Internal(IntPtr @this, FMargin InPadding);

		// Token: 0x06027CB6 RID: 162998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOwningPlayer_Internal(IntPtr @this, IntPtr LocalPlayerController);

		// Token: 0x06027CB7 RID: 162999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNumLoopsToPlay_Internal(IntPtr @this, IntPtr InAnimation, int NumLoopsToPlay);

		// Token: 0x06027CB8 RID: 163000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputActionPriority_Internal(IntPtr @this, int NewPriority);

		// Token: 0x06027CB9 RID: 163001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputActionBlocking_Internal(IntPtr @this, bool bShouldBlock);

		// Token: 0x06027CBA RID: 163002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForegroundColor_Internal(IntPtr @this, IntPtr InForegroundColor);

		// Token: 0x06027CBB RID: 163003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredSizeInViewport_Internal(IntPtr @this, FVector2D Size);

		// Token: 0x06027CBC RID: 163004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetColorAndOpacity_Internal(IntPtr @this, FLinearColor InColorAndOpacity);

		// Token: 0x06027CBD RID: 163005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnimationCurrentTime_Internal(IntPtr @this, IntPtr InAnimation, float InTime);

		// Token: 0x06027CBE RID: 163006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAnchorsInViewport_Internal(IntPtr @this, IntPtr Anchors);

		// Token: 0x06027CBF RID: 163007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAlignmentInViewport_Internal(IntPtr @this, FVector2D Alignment);

		// Token: 0x06027CC0 RID: 163008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReverseAnimation_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CC1 RID: 163009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveFromViewport_Internal(IntPtr @this);

		// Token: 0x06027CC2 RID: 163010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterInputComponent_Internal(IntPtr @this);

		// Token: 0x06027CC3 RID: 163011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PreConstruct_Internal(IntPtr @this, bool IsDesignTime);

		// Token: 0x06027CC4 RID: 163012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlaySound_Internal(IntPtr @this, IntPtr SoundToPlay);

		// Token: 0x06027CC5 RID: 163013
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlayAnimationTimeRange_Internal(IntPtr @this, IntPtr InAnimation, float StartAtTime, float EndAtTime, int NumLoopsToPlay, TEnumAsByte<EUMGSequencePlayMode> PlayMode, float PlaybackSpeed, bool bRestoreState);

		// Token: 0x06027CC6 RID: 163014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlayAnimationReverse_Internal(IntPtr @this, IntPtr InAnimation, float PlaybackSpeed, bool bRestoreState);

		// Token: 0x06027CC7 RID: 163015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlayAnimationForward_Internal(IntPtr @this, IntPtr InAnimation, float PlaybackSpeed, bool bRestoreState);

		// Token: 0x06027CC8 RID: 163016
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PlayAnimation_Internal(IntPtr @this, IntPtr InAnimation, float StartAtTime, int NumLoopsToPlay, TEnumAsByte<EUMGSequencePlayMode> PlayMode, float PlaybackSpeed, bool bRestoreState);

		// Token: 0x06027CC9 RID: 163017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PauseAnimation_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CCA RID: 163018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnTouchStarted_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InTouchEvent);

		// Token: 0x06027CCB RID: 163019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnTouchMoved_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InTouchEvent);

		// Token: 0x06027CCC RID: 163020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnTouchGesture_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr GestureEvent);

		// Token: 0x06027CCD RID: 163021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnTouchForceChanged_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InTouchEvent);

		// Token: 0x06027CCE RID: 163022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnTouchEnded_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InTouchEvent);

		// Token: 0x06027CCF RID: 163023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnRemovedFromFocusPath_Internal(IntPtr @this, IntPtr InFocusEvent);

		// Token: 0x06027CD0 RID: 163024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnPreviewMouseButtonDown_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CD1 RID: 163025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnPreviewKeyDown_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InKeyEvent);

		// Token: 0x06027CD2 RID: 163026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPaint_Internal(IntPtr @this, IntPtr Context);

		// Token: 0x06027CD3 RID: 163027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMouseWheel_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CD4 RID: 163028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMouseMove_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CD5 RID: 163029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMouseLeave_Internal(IntPtr @this, IntPtr MouseEvent);

		// Token: 0x06027CD6 RID: 163030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMouseEnter_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CD7 RID: 163031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnMouseCaptureLost_Internal(IntPtr @this);

		// Token: 0x06027CD8 RID: 163032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMouseButtonUp_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CD9 RID: 163033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMouseButtonDown_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr MouseEvent);

		// Token: 0x06027CDA RID: 163034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMouseButtonDoubleClick_Internal(IntPtr @this, IntPtr InMyGeometry, IntPtr InMouseEvent);

		// Token: 0x06027CDB RID: 163035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnMotionDetected_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InMotionEvent);

		// Token: 0x06027CDC RID: 163036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnKeyUp_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InKeyEvent);

		// Token: 0x06027CDD RID: 163037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnKeyDown_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InKeyEvent);

		// Token: 0x06027CDE RID: 163038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnKeyChar_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InCharacterEvent);

		// Token: 0x06027CDF RID: 163039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnInitialized_Internal(IntPtr @this);

		// Token: 0x06027CE0 RID: 163040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnFocusReceived_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InFocusEvent);

		// Token: 0x06027CE1 RID: 163041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnFocusLost_Internal(IntPtr @this, IntPtr InFocusEvent);

		// Token: 0x06027CE2 RID: 163042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnDrop_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr PointerEvent, IntPtr Operation);

		// Token: 0x06027CE3 RID: 163043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OnDragOver_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr PointerEvent, IntPtr Operation);

		// Token: 0x06027CE4 RID: 163044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDragLeave_Internal(IntPtr @this, IntPtr PointerEvent, IntPtr Operation);

		// Token: 0x06027CE5 RID: 163045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDragEnter_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr PointerEvent, IntPtr Operation);

		// Token: 0x06027CE6 RID: 163046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDragDetected_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr PointerEvent, ref IntPtr Operation);

		// Token: 0x06027CE7 RID: 163047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDragCancelled_Internal(IntPtr @this, IntPtr PointerEvent, IntPtr Operation);

		// Token: 0x06027CE8 RID: 163048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAnimationStarted_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CE9 RID: 163049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAnimationStarted_Implementation_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CEA RID: 163050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAnimationFinished_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CEB RID: 163051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAnimationFinished_Implementation_Internal(IntPtr @this, IntPtr Animation);

		// Token: 0x06027CEC RID: 163052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __OnAnalogValueChanged_Internal(IntPtr @this, IntPtr MyGeometry, IntPtr InAnalogInputEvent);

		// Token: 0x06027CED RID: 163053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnAddedToFocusPath_Internal(IntPtr @this, IntPtr InFocusEvent);

		// Token: 0x06027CEE RID: 163054
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ListenForInputAction_Internal(IntPtr @this, FName ActionName, TEnumAsByte<EInputEvent> EventType, bool bConsume, IntPtr Callback);

		// Token: 0x06027CEF RID: 163055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlayingAnimation_Internal(IntPtr @this);

		// Token: 0x06027CF0 RID: 163056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsListeningForInputAction_Internal(IntPtr @this, FName ActionName);

		// Token: 0x06027CF1 RID: 163057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInViewport_Internal(IntPtr @this);

		// Token: 0x06027CF2 RID: 163058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInteractable_Internal(IntPtr @this);

		// Token: 0x06027CF3 RID: 163059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnyAnimationPlaying_Internal(IntPtr @this);

		// Token: 0x06027CF4 RID: 163060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnimationPlayingForward_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CF5 RID: 163061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAnimationPlaying_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CF6 RID: 163062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerPawn_Internal(IntPtr @this);

		// Token: 0x06027CF7 RID: 163063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOwningPlayerCameraManager_Internal(IntPtr @this);

		// Token: 0x06027CF8 RID: 163064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsVisible_Internal(IntPtr @this);

		// Token: 0x06027CF9 RID: 163065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnimationCurrentTime_Internal(IntPtr @this, IntPtr InAnimation);

		// Token: 0x06027CFA RID: 163066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetAnchorsInViewport_Internal(IntPtr @this);

		// Token: 0x06027CFB RID: 163067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetAlignmentInViewport_Internal(IntPtr @this);

		// Token: 0x06027CFC RID: 163068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __FlushAnimations_Internal(IntPtr @this);

		// Token: 0x06027CFD RID: 163069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Destruct_Internal(IntPtr @this);

		// Token: 0x06027CFE RID: 163070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Construct_Internal(IntPtr @this);

		// Token: 0x06027CFF RID: 163071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelLatentActions_Internal(IntPtr @this);

		// Token: 0x06027D00 RID: 163072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindToAnimationStarted_Internal(IntPtr @this, IntPtr Animation, IntPtr Delegate);

		// Token: 0x06027D01 RID: 163073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindToAnimationFinished_Internal(IntPtr @this, IntPtr Animation, IntPtr Delegate);

		// Token: 0x06027D02 RID: 163074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindToAnimationEvent_Internal(IntPtr @this, IntPtr Animation, IntPtr Delegate, EWidgetAnimationEvent AnimationEvent, FName UserTag);

		// Token: 0x06027D03 RID: 163075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddToViewport_Internal(IntPtr @this, int ZOrder);

		// Token: 0x06027D04 RID: 163076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AddToPlayerScreen_Internal(IntPtr @this, int ZOrder);

		// Token: 0x06027D05 RID: 163077 RVA: 0x003CAAE5 File Offset: 0x003C8CE5
		static UUserWidget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.UserWidget");
		}

		// Token: 0x06027D06 RID: 163078 RVA: 0x003CAAF4 File Offset: 0x003C8CF4
		protected UUserWidget() : this(BuiltinUtils.AllocNativeUObject(UUserWidget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027D07 RID: 163079 RVA: 0x003CAB1C File Offset: 0x003C8D1C
		protected UUserWidget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015C39 RID: 89145
		internal static int __InterfaceOffset_INamedSlotInterface;

		// Token: 0x04015C3A RID: 89146
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.UserWidget";

		// Token: 0x04015C3B RID: 89147
		private static IntPtr _ClassPtr;

		// Token: 0x04015C3C RID: 89148
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015C3D RID: 89149
		internal static int __PropertyOffset_ColorAndOpacity;

		// Token: 0x04015C3E RID: 89150
		internal static int __PropertyOffset_ColorAndOpacityDelegate;

		// Token: 0x04015C3F RID: 89151
		private FGetLinearColor _ColorAndOpacityDelegate;

		// Token: 0x04015C40 RID: 89152
		internal static int __PropertyOffset_ForegroundColor;

		// Token: 0x04015C41 RID: 89153
		private FSlateColor _ForegroundColor;

		// Token: 0x04015C42 RID: 89154
		internal static int __PropertyOffset_ForegroundColorDelegate;

		// Token: 0x04015C43 RID: 89155
		private FGetSlateColor _ForegroundColorDelegate;

		// Token: 0x04015C44 RID: 89156
		internal static int __PropertyOffset_OnVisibilityChanged;

		// Token: 0x04015C45 RID: 89157
		private FOnVisibilityChangedEvent _OnVisibilityChanged;

		// Token: 0x04015C46 RID: 89158
		internal static int __PropertyOffset_Padding;

		// Token: 0x04015C47 RID: 89159
		internal static int __PropertyOffset_ActiveSequencePlayers;

		// Token: 0x04015C48 RID: 89160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUMGSequencePlayer> _ActiveSequencePlayers;

		// Token: 0x04015C49 RID: 89161
		internal static int __PropertyOffset_AnimationTickManager;

		// Token: 0x04015C4A RID: 89162
		internal static int __PropertyOffset_StoppedSequencePlayers;

		// Token: 0x04015C4B RID: 89163
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UUMGSequencePlayer> _StoppedSequencePlayers;

		// Token: 0x04015C4C RID: 89164
		internal static int __PropertyOffset_NamedSlotBindings;

		// Token: 0x04015C4D RID: 89165
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNamedSlotBinding> _NamedSlotBindings;

		// Token: 0x04015C4E RID: 89166
		internal static int __PropertyOffset_WidgetTree;

		// Token: 0x04015C4F RID: 89167
		internal static int __PropertyOffset_Priority;

		// Token: 0x04015C50 RID: 89168
		internal static int __PropertyOffset_bSupportsKeyboardFocus_DEPRECATED;

		// Token: 0x04015C51 RID: 89169
		internal static byte __PropertyMask_bSupportsKeyboardFocus_DEPRECATED;

		// Token: 0x04015C52 RID: 89170
		internal static int __PropertyOffset_bIsFocusable;

		// Token: 0x04015C53 RID: 89171
		internal static byte __PropertyMask_bIsFocusable;

		// Token: 0x04015C54 RID: 89172
		internal static int __PropertyOffset_bStopAction;

		// Token: 0x04015C55 RID: 89173
		internal static byte __PropertyMask_bStopAction;

		// Token: 0x04015C56 RID: 89174
		internal static int __PropertyOffset_bHasScriptImplementedTick;

		// Token: 0x04015C57 RID: 89175
		internal static byte __PropertyMask_bHasScriptImplementedTick;

		// Token: 0x04015C58 RID: 89176
		internal static int __PropertyOffset_bHasScriptImplementedPaint;

		// Token: 0x04015C59 RID: 89177
		internal static byte __PropertyMask_bHasScriptImplementedPaint;

		// Token: 0x04015C5A RID: 89178
		internal static int __PropertyOffset_TickFrequency;

		// Token: 0x04015C5B RID: 89179
		internal static int __PropertyOffset_InputComponent;

		// Token: 0x04015C5C RID: 89180
		internal static int __PropertyOffset_AnimationCallbacks;

		// Token: 0x04015C5D RID: 89181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAnimationEventBinding> _AnimationCallbacks;

		// Token: 0x04015C5E RID: 89182
		internal static int __PropertyOffset_bRemovedFromWorld;

		// Token: 0x02003BD5 RID: 15317
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 60)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04017DBF RID: 97727
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DC0 RID: 97728
			[FieldOffset(56)]
			public float InDeltaTime;
		}

		// Token: 0x02003BD6 RID: 15318
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __PreConstruct_FunctionParams
		{
			// Token: 0x04017DC1 RID: 97729
			[FieldOffset(0)]
			public bool IsDesignTime;
		}

		// Token: 0x02003BD7 RID: 15319
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnTouchStarted_FunctionParams
		{
			// Token: 0x04017DC2 RID: 97730
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DC3 RID: 97731
			[FieldOffset(56)]
			public byte InTouchEvent;

			// Token: 0x04017DC4 RID: 97732
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BD8 RID: 15320
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnTouchMoved_FunctionParams
		{
			// Token: 0x04017DC5 RID: 97733
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DC6 RID: 97734
			[FieldOffset(56)]
			public byte InTouchEvent;

			// Token: 0x04017DC7 RID: 97735
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BD9 RID: 15321
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnTouchGesture_FunctionParams
		{
			// Token: 0x04017DC8 RID: 97736
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DC9 RID: 97737
			[FieldOffset(56)]
			public byte GestureEvent;

			// Token: 0x04017DCA RID: 97738
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BDA RID: 15322
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnTouchForceChanged_FunctionParams
		{
			// Token: 0x04017DCB RID: 97739
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DCC RID: 97740
			[FieldOffset(56)]
			public byte InTouchEvent;

			// Token: 0x04017DCD RID: 97741
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BDB RID: 15323
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnTouchEnded_FunctionParams
		{
			// Token: 0x04017DCE RID: 97742
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DCF RID: 97743
			[FieldOffset(56)]
			public byte InTouchEvent;

			// Token: 0x04017DD0 RID: 97744
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BDC RID: 15324
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnRemovedFromFocusPath_FunctionParams
		{
			// Token: 0x04017DD1 RID: 97745
			[FieldOffset(0)]
			public byte InFocusEvent;
		}

		// Token: 0x02003BDD RID: 15325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnPreviewMouseButtonDown_FunctionParams
		{
			// Token: 0x04017DD2 RID: 97746
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DD3 RID: 97747
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DD4 RID: 97748
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BDE RID: 15326
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __OnPreviewKeyDown_FunctionParams
		{
			// Token: 0x04017DD5 RID: 97749
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DD6 RID: 97750
			[FieldOffset(56)]
			public byte InKeyEvent;

			// Token: 0x04017DD7 RID: 97751
			[FieldOffset(120)]
			public byte __Result;
		}

		// Token: 0x02003BDF RID: 15327
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __OnPaint_FunctionParams
		{
			// Token: 0x04017DD8 RID: 97752
			[FieldOffset(0)]
			public byte Context;
		}

		// Token: 0x02003BE0 RID: 15328
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnMouseWheel_FunctionParams
		{
			// Token: 0x04017DD9 RID: 97753
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DDA RID: 97754
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DDB RID: 97755
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BE1 RID: 15329
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnMouseMove_FunctionParams
		{
			// Token: 0x04017DDC RID: 97756
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DDD RID: 97757
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DDE RID: 97758
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BE2 RID: 15330
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __OnMouseLeave_FunctionParams
		{
			// Token: 0x04017DDF RID: 97759
			[FieldOffset(0)]
			public byte MouseEvent;
		}

		// Token: 0x02003BE3 RID: 15331
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 176)]
		protected ref struct __OnMouseEnter_FunctionParams
		{
			// Token: 0x04017DE0 RID: 97760
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DE1 RID: 97761
			[FieldOffset(56)]
			public byte MouseEvent;
		}

		// Token: 0x02003BE4 RID: 15332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnMouseButtonUp_FunctionParams
		{
			// Token: 0x04017DE2 RID: 97762
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DE3 RID: 97763
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DE4 RID: 97764
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BE5 RID: 15333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnMouseButtonDown_FunctionParams
		{
			// Token: 0x04017DE5 RID: 97765
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DE6 RID: 97766
			[FieldOffset(56)]
			public byte MouseEvent;

			// Token: 0x04017DE7 RID: 97767
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BE6 RID: 15334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 368)]
		protected ref struct __OnMouseButtonDoubleClick_FunctionParams
		{
			// Token: 0x04017DE8 RID: 97768
			[FieldOffset(0)]
			public byte InMyGeometry;

			// Token: 0x04017DE9 RID: 97769
			[FieldOffset(56)]
			public byte InMouseEvent;

			// Token: 0x04017DEA RID: 97770
			[FieldOffset(176)]
			public byte __Result;
		}

		// Token: 0x02003BE7 RID: 15335
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __OnMotionDetected_FunctionParams
		{
			// Token: 0x04017DEB RID: 97771
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DEC RID: 97772
			[FieldOffset(56)]
			public byte InMotionEvent;

			// Token: 0x04017DED RID: 97773
			[FieldOffset(128)]
			public byte __Result;
		}

		// Token: 0x02003BE8 RID: 15336
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __OnKeyUp_FunctionParams
		{
			// Token: 0x04017DEE RID: 97774
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DEF RID: 97775
			[FieldOffset(56)]
			public byte InKeyEvent;

			// Token: 0x04017DF0 RID: 97776
			[FieldOffset(120)]
			public byte __Result;
		}

		// Token: 0x02003BE9 RID: 15337
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __OnKeyDown_FunctionParams
		{
			// Token: 0x04017DF1 RID: 97777
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DF2 RID: 97778
			[FieldOffset(56)]
			public byte InKeyEvent;

			// Token: 0x04017DF3 RID: 97779
			[FieldOffset(120)]
			public byte __Result;
		}

		// Token: 0x02003BEA RID: 15338
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 280)]
		protected ref struct __OnKeyChar_FunctionParams
		{
			// Token: 0x04017DF4 RID: 97780
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DF5 RID: 97781
			[FieldOffset(56)]
			public byte InCharacterEvent;

			// Token: 0x04017DF6 RID: 97782
			[FieldOffset(88)]
			public byte __Result;
		}

		// Token: 0x02003BEB RID: 15339
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 256)]
		protected ref struct __OnFocusReceived_FunctionParams
		{
			// Token: 0x04017DF7 RID: 97783
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DF8 RID: 97784
			[FieldOffset(56)]
			public byte InFocusEvent;

			// Token: 0x04017DF9 RID: 97785
			[FieldOffset(64)]
			public byte __Result;
		}

		// Token: 0x02003BEC RID: 15340
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnFocusLost_FunctionParams
		{
			// Token: 0x04017DFA RID: 97786
			[FieldOffset(0)]
			public byte InFocusEvent;
		}

		// Token: 0x02003BED RID: 15341
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __OnDrop_FunctionParams
		{
			// Token: 0x04017DFB RID: 97787
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017DFC RID: 97788
			[FieldOffset(56)]
			public byte PointerEvent;

			// Token: 0x04017DFD RID: 97789
			[FieldOffset(176)]
			public IntPtr Operation;

			// Token: 0x04017DFE RID: 97790
			[FieldOffset(184)]
			public bool __Result;
		}

		// Token: 0x02003BEE RID: 15342
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 192)]
		protected ref struct __OnDragOver_FunctionParams
		{
			// Token: 0x04017DFF RID: 97791
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017E00 RID: 97792
			[FieldOffset(56)]
			public byte PointerEvent;

			// Token: 0x04017E01 RID: 97793
			[FieldOffset(176)]
			public IntPtr Operation;

			// Token: 0x04017E02 RID: 97794
			[FieldOffset(184)]
			public bool __Result;
		}

		// Token: 0x02003BEF RID: 15343
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __OnDragLeave_FunctionParams
		{
			// Token: 0x04017E03 RID: 97795
			[FieldOffset(0)]
			public byte PointerEvent;

			// Token: 0x04017E04 RID: 97796
			[FieldOffset(120)]
			public IntPtr Operation;
		}

		// Token: 0x02003BF0 RID: 15344
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __OnDragEnter_FunctionParams
		{
			// Token: 0x04017E05 RID: 97797
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017E06 RID: 97798
			[FieldOffset(56)]
			public byte PointerEvent;

			// Token: 0x04017E07 RID: 97799
			[FieldOffset(176)]
			public IntPtr Operation;
		}

		// Token: 0x02003BF1 RID: 15345
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 184)]
		protected ref struct __OnDragDetected_FunctionParams
		{
			// Token: 0x04017E08 RID: 97800
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017E09 RID: 97801
			[FieldOffset(56)]
			public byte PointerEvent;

			// Token: 0x04017E0A RID: 97802
			[FieldOffset(176)]
			public IntPtr Operation;
		}

		// Token: 0x02003BF2 RID: 15346
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 128)]
		protected ref struct __OnDragCancelled_FunctionParams
		{
			// Token: 0x04017E0B RID: 97803
			[FieldOffset(0)]
			public byte PointerEvent;

			// Token: 0x04017E0C RID: 97804
			[FieldOffset(120)]
			public IntPtr Operation;
		}

		// Token: 0x02003BF3 RID: 15347
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnAnimationStarted_FunctionParams
		{
			// Token: 0x04017E0D RID: 97805
			[FieldOffset(0)]
			public IntPtr Animation;
		}

		// Token: 0x02003BF4 RID: 15348
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnAnimationFinished_FunctionParams
		{
			// Token: 0x04017E0E RID: 97806
			[FieldOffset(0)]
			public IntPtr Animation;
		}

		// Token: 0x02003BF5 RID: 15349
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 320)]
		protected ref struct __OnAnalogValueChanged_FunctionParams
		{
			// Token: 0x04017E0F RID: 97807
			[FieldOffset(0)]
			public byte MyGeometry;

			// Token: 0x04017E10 RID: 97808
			[FieldOffset(56)]
			public byte InAnalogInputEvent;

			// Token: 0x04017E11 RID: 97809
			[FieldOffset(128)]
			public byte __Result;
		}

		// Token: 0x02003BF6 RID: 15350
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnAddedToFocusPath_FunctionParams
		{
			// Token: 0x04017E12 RID: 97810
			[FieldOffset(0)]
			public byte InFocusEvent;
		}

		// Token: 0x02003BF7 RID: 15351
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsInteractable_FunctionParams
		{
			// Token: 0x04017E13 RID: 97811
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
