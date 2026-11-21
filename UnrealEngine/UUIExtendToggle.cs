using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006FF RID: 1791
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggle")]
	[UnrealStructLayout(2272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class UUIExtendToggle : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600987A RID: 39034 RVA: 0x000E5891 File Offset: 0x000E3A91
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggle._ClassPtr;
		}

		// Token: 0x0600987B RID: 39035 RVA: 0x000E58A0 File Offset: 0x000E3AA0
		public UUIExtendToggle() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600987C RID: 39036 RVA: 0x000E58C8 File Offset: 0x000E3AC8
		public UUIExtendToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C4D RID: 7245
		// (get) Token: 0x0600987D RID: 39037 RVA: 0x000E58FC File Offset: 0x000E3AFC
		// (set) Token: 0x0600987E RID: 39038 RVA: 0x000E5935 File Offset: 0x000E3B35
		public FOnToggleStateChange OnStateChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnToggleStateChange result;
				if ((result = this._OnStateChange) == null)
				{
					result = (this._OnStateChange = new FOnToggleStateChange(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnStateChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnStateChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x0600987F RID: 39039 RVA: 0x000E5958 File Offset: 0x000E3B58
		// (set) Token: 0x06009880 RID: 39040 RVA: 0x000E5991 File Offset: 0x000E3B91
		public FCanExecuteChange CanExecuteChange
		{
			get
			{
				base.FastCheckIsValid();
				FCanExecuteChange result;
				if ((result = this._CanExecuteChange) == null)
				{
					result = (this._CanExecuteChange = new FCanExecuteChange(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_CanExecuteChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_CanExecuteChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C4F RID: 7247
		// (get) Token: 0x06009881 RID: 39041 RVA: 0x000E59B4 File Offset: 0x000E3BB4
		// (set) Token: 0x06009882 RID: 39042 RVA: 0x000E59ED File Offset: 0x000E3BED
		public FHoverEvent OnHover
		{
			get
			{
				base.FastCheckIsValid();
				FHoverEvent result;
				if ((result = this._OnHover) == null)
				{
					result = (this._OnHover = new FHoverEvent(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnHover, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnHover, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x06009883 RID: 39043 RVA: 0x000E5A10 File Offset: 0x000E3C10
		// (set) Token: 0x06009884 RID: 39044 RVA: 0x000E5A49 File Offset: 0x000E3C49
		public FHoverEvent OnUnHover
		{
			get
			{
				base.FastCheckIsValid();
				FHoverEvent result;
				if ((result = this._OnUnHover) == null)
				{
					result = (this._OnUnHover = new FHoverEvent(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnUnHover, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnUnHover, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C51 RID: 7249
		// (get) Token: 0x06009885 RID: 39045 RVA: 0x000E5A6C File Offset: 0x000E3C6C
		// (set) Token: 0x06009886 RID: 39046 RVA: 0x000E5AA5 File Offset: 0x000E3CA5
		public FOnUndeterminedClicked OnUndeterminedClicked
		{
			get
			{
				base.FastCheckIsValid();
				FOnUndeterminedClicked result;
				if ((result = this._OnUndeterminedClicked) == null)
				{
					result = (this._OnUndeterminedClicked = new FOnUndeterminedClicked(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnUndeterminedClicked, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnUndeterminedClicked, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C52 RID: 7250
		// (get) Token: 0x06009887 RID: 39047 RVA: 0x000E5AC8 File Offset: 0x000E3CC8
		// (set) Token: 0x06009888 RID: 39048 RVA: 0x000E5B01 File Offset: 0x000E3D01
		public FLGUIExtendToggleAudioDelegate OnPostAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleAudioDelegate result;
				if ((result = this._OnPostAudioEvent) == null)
				{
					result = (this._OnPostAudioEvent = new FLGUIExtendToggleAudioDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPostAudioEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPostAudioEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C53 RID: 7251
		// (get) Token: 0x06009889 RID: 39049 RVA: 0x000E5B24 File Offset: 0x000E3D24
		// (set) Token: 0x0600988A RID: 39050 RVA: 0x000E5B5D File Offset: 0x000E3D5D
		public TMap<EToggleAudioTransitionState, FSoftObjectPath> AudioConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EToggleAudioTransitionState, FSoftObjectPath> result;
				if ((result = this._AudioConfig) == null)
				{
					result = (this._AudioConfig = new TMap<EToggleAudioTransitionState, FSoftObjectPath>(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_AudioConfig, this));
				}
				return result;
			}
			set
			{
				this.AudioConfig.CopyAssign(value);
			}
		}

		// Token: 0x17001C54 RID: 7252
		// (get) Token: 0x0600988B RID: 39051 RVA: 0x000E5B6B File Offset: 0x000E3D6B
		// (set) Token: 0x0600988C RID: 39052 RVA: 0x000E5B7B File Offset: 0x000E3D7B
		public unsafe bool bIgnoreSelectedHover
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bIgnoreSelectedHover) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bIgnoreSelectedHover) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C55 RID: 7253
		// (get) Token: 0x0600988D RID: 39053 RVA: 0x000E5B8C File Offset: 0x000E3D8C
		// (set) Token: 0x0600988E RID: 39054 RVA: 0x000E5BC5 File Offset: 0x000E3DC5
		public FSoftObjectPath LongPressAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LongPressAudioEvent) == null)
				{
					result = (this._LongPressAudioEvent = new FSoftObjectPath(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_LongPressAudioEvent, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_LongPressAudioEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001C56 RID: 7254
		// (get) Token: 0x0600988F RID: 39055 RVA: 0x000E5BE8 File Offset: 0x000E3DE8
		// (set) Token: 0x06009890 RID: 39056 RVA: 0x000E5C21 File Offset: 0x000E3E21
		public FLGUIExtendToggleAudioWithStateDelegate OnPostAudioStateEvent
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleAudioWithStateDelegate result;
				if ((result = this._OnPostAudioStateEvent) == null)
				{
					result = (this._OnPostAudioStateEvent = new FLGUIExtendToggleAudioWithStateDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPostAudioStateEvent, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPostAudioStateEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C57 RID: 7255
		// (get) Token: 0x06009891 RID: 39057 RVA: 0x000E5C44 File Offset: 0x000E3E44
		// (set) Token: 0x06009892 RID: 39058 RVA: 0x000E5C7D File Offset: 0x000E3E7D
		public FLGUIExtendToggleDynamicDelegate OnPointEnterCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegate result;
				if ((result = this._OnPointEnterCallBack) == null)
				{
					result = (this._OnPointEnterCallBack = new FLGUIExtendToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointEnterCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointEnterCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C58 RID: 7256
		// (get) Token: 0x06009893 RID: 39059 RVA: 0x000E5CA0 File Offset: 0x000E3EA0
		// (set) Token: 0x06009894 RID: 39060 RVA: 0x000E5CD9 File Offset: 0x000E3ED9
		public FLGUIExtendToggleDynamicDelegate OnPointExitCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegate result;
				if ((result = this._OnPointExitCallBack) == null)
				{
					result = (this._OnPointExitCallBack = new FLGUIExtendToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointExitCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointExitCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C59 RID: 7257
		// (get) Token: 0x06009895 RID: 39061 RVA: 0x000E5CFC File Offset: 0x000E3EFC
		// (set) Token: 0x06009896 RID: 39062 RVA: 0x000E5D35 File Offset: 0x000E3F35
		public FLGUIExtendToggleDynamicDelegate OnPointDownCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegate result;
				if ((result = this._OnPointDownCallBack) == null)
				{
					result = (this._OnPointDownCallBack = new FLGUIExtendToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointDownCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointDownCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5A RID: 7258
		// (get) Token: 0x06009897 RID: 39063 RVA: 0x000E5D58 File Offset: 0x000E3F58
		// (set) Token: 0x06009898 RID: 39064 RVA: 0x000E5D91 File Offset: 0x000E3F91
		public FLGUIExtendToggleDynamicDelegate OnPointUpCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegate result;
				if ((result = this._OnPointUpCallBack) == null)
				{
					result = (this._OnPointUpCallBack = new FLGUIExtendToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointUpCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointUpCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5B RID: 7259
		// (get) Token: 0x06009899 RID: 39065 RVA: 0x000E5DB4 File Offset: 0x000E3FB4
		// (set) Token: 0x0600989A RID: 39066 RVA: 0x000E5DED File Offset: 0x000E3FED
		public FLGUIExtendToggleWithEventDataDynamicDelegate OnPointUpCallBackWithEventData
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleWithEventDataDynamicDelegate result;
				if ((result = this._OnPointUpCallBackWithEventData) == null)
				{
					result = (this._OnPointUpCallBackWithEventData = new FLGUIExtendToggleWithEventDataDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointUpCallBackWithEventData, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointUpCallBackWithEventData, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5C RID: 7260
		// (get) Token: 0x0600989B RID: 39067 RVA: 0x000E5E10 File Offset: 0x000E4010
		// (set) Token: 0x0600989C RID: 39068 RVA: 0x000E5E49 File Offset: 0x000E4049
		public FLGUIExtendToggleDynamicDelegate OnPointCancelCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegate result;
				if ((result = this._OnPointCancelCallBack) == null)
				{
					result = (this._OnPointCancelCallBack = new FLGUIExtendToggleDynamicDelegate(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointCancelCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointCancelCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5D RID: 7261
		// (get) Token: 0x0600989D RID: 39069 RVA: 0x000E5E6C File Offset: 0x000E406C
		// (set) Token: 0x0600989E RID: 39070 RVA: 0x000E5EA5 File Offset: 0x000E40A5
		public FLGUIExtendToggleDynamicDelegateOneParams OnPointerBeginDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegateOneParams result;
				if ((result = this._OnPointerBeginDragCallBack) == null)
				{
					result = (this._OnPointerBeginDragCallBack = new FLGUIExtendToggleDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerBeginDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerBeginDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5E RID: 7262
		// (get) Token: 0x0600989F RID: 39071 RVA: 0x000E5EC8 File Offset: 0x000E40C8
		// (set) Token: 0x060098A0 RID: 39072 RVA: 0x000E5F01 File Offset: 0x000E4101
		public FLGUIExtendToggleDynamicDelegateOneParams OnPointerDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegateOneParams result;
				if ((result = this._OnPointerDragCallBack) == null)
				{
					result = (this._OnPointerDragCallBack = new FLGUIExtendToggleDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C5F RID: 7263
		// (get) Token: 0x060098A1 RID: 39073 RVA: 0x000E5F24 File Offset: 0x000E4124
		// (set) Token: 0x060098A2 RID: 39074 RVA: 0x000E5F5D File Offset: 0x000E415D
		public FLGUIExtendToggleDynamicDelegateOneParams OnPointerEndDragCallBack
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIExtendToggleDynamicDelegateOneParams result;
				if ((result = this._OnPointerEndDragCallBack) == null)
				{
					result = (this._OnPointerEndDragCallBack = new FLGUIExtendToggleDynamicDelegateOneParams(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerEndDragCallBack, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_OnPointerEndDragCallBack, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C60 RID: 7264
		// (get) Token: 0x060098A3 RID: 39075 RVA: 0x000E5F7E File Offset: 0x000E417E
		// (set) Token: 0x060098A4 RID: 39076 RVA: 0x000E5F8E File Offset: 0x000E418E
		public unsafe EToggleState ToggleState
		{
			get
			{
				return (EToggleState)(*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_ToggleState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_ToggleState) = (byte)value;
			}
		}

		// Token: 0x17001C61 RID: 7265
		// (get) Token: 0x060098A5 RID: 39077 RVA: 0x000E5F9F File Offset: 0x000E419F
		// (set) Token: 0x060098A6 RID: 39078 RVA: 0x000E5FB3 File Offset: 0x000E41B3
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> ToggleGroupActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_ToggleGroupActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_ToggleGroupActor) = value;
			}
		}

		// Token: 0x17001C62 RID: 7266
		// (get) Token: 0x060098A7 RID: 39079 RVA: 0x000E5FC8 File Offset: 0x000E41C8
		// (set) Token: 0x060098A8 RID: 39080 RVA: 0x000E5FD8 File Offset: 0x000E41D8
		public unsafe bool bToggleOnSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bToggleOnSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bToggleOnSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C63 RID: 7267
		// (get) Token: 0x060098A9 RID: 39081 RVA: 0x000E5FE9 File Offset: 0x000E41E9
		// (set) Token: 0x060098AA RID: 39082 RVA: 0x000E5FF9 File Offset: 0x000E41F9
		public unsafe bool bLockStateOnSelect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bLockStateOnSelect) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bLockStateOnSelect) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C64 RID: 7268
		// (get) Token: 0x060098AB RID: 39083 RVA: 0x000E600A File Offset: 0x000E420A
		// (set) Token: 0x060098AC RID: 39084 RVA: 0x000E601A File Offset: 0x000E421A
		public unsafe bool bCheckToggleSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bCheckToggleSelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_bCheckToggleSelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C65 RID: 7269
		// (get) Token: 0x060098AD RID: 39085 RVA: 0x000E602C File Offset: 0x000E422C
		// (set) Token: 0x060098AE RID: 39086 RVA: 0x000E6065 File Offset: 0x000E4265
		public TMap<EToggleStateSwitch, FToggleAnimationPlayInfo> StateSwitchAnimations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EToggleStateSwitch, FToggleAnimationPlayInfo> result;
				if ((result = this._StateSwitchAnimations) == null)
				{
					result = (this._StateSwitchAnimations = new TMap<EToggleStateSwitch, FToggleAnimationPlayInfo>(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_StateSwitchAnimations, this));
				}
				return result;
			}
			set
			{
				this.StateSwitchAnimations.CopyAssign(value);
			}
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x000E6073 File Offset: 0x000E4273
		public void SetToggleStateForce(EToggleState State, bool bFireEvent = false, bool bIngnoreAnim = false, bool bJumpToLastFrame = false)
		{
			UUIExtendToggle.__SetToggleStateForce_Internal(base.NativePtr, State, bFireEvent, bIngnoreAnim, bJumpToLastFrame);
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x000E6085 File Offset: 0x000E4285
		public EToggleChangeStateResult SetToggleState(EToggleState State, bool bFireEvent = false, bool bIngnoreAnim = false, bool bJumpToLastFrame = false)
		{
			return UUIExtendToggle.__SetToggleState_Internal(base.NativePtr, State, bFireEvent, bIngnoreAnim, bJumpToLastFrame);
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x000E6097 File Offset: 0x000E4297
		[NullableContext(2)]
		public void SetToggleGroup(AActor TogGroupActor)
		{
			UUIExtendToggle.__SetToggleGroup_Internal(base.NativePtr, (TogGroupActor != null) ? TogGroupActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x000E60B4 File Offset: 0x000E42B4
		public void SetAllTransitionsEnable(bool bIsEnable)
		{
			UUIExtendToggle.__SetAllTransitionsEnable_Internal(base.NativePtr, bIsEnable);
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x000E60C2 File Offset: 0x000E42C2
		public EToggleState GetToggleState()
		{
			return UUIExtendToggle.__GetToggleState_Internal(base.NativePtr);
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x000E60CF File Offset: 0x000E42CF
		[NullableContext(2)]
		public UUIExtendToggleGroup GetToggleGroup()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggleGroup>(UUIExtendToggle.__GetToggleGroup_Internal(base.NativePtr));
		}

		// Token: 0x060098B5 RID: 39093
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleStateForce_Internal(IntPtr @this, EToggleState State, bool bFireEvent, bool bIngnoreAnim, bool bJumpToLastFrame);

		// Token: 0x060098B6 RID: 39094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EToggleChangeStateResult __SetToggleState_Internal(IntPtr @this, EToggleState State, bool bFireEvent, bool bIngnoreAnim, bool bJumpToLastFrame);

		// Token: 0x060098B7 RID: 39095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleGroup_Internal(IntPtr @this, IntPtr TogGroupActor);

		// Token: 0x060098B8 RID: 39096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionsEnable_Internal(IntPtr @this, bool bIsEnable);

		// Token: 0x060098B9 RID: 39097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EToggleState __GetToggleState_Internal(IntPtr @this);

		// Token: 0x060098BA RID: 39098
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToggleGroup_Internal(IntPtr @this);

		// Token: 0x060098BB RID: 39099 RVA: 0x000E60E1 File Offset: 0x000E42E1
		static UUIExtendToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggle");
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x000E60EF File Offset: 0x000E42EF
		protected UUIExtendToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004238 RID: 16952
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggle";

		// Token: 0x04004239 RID: 16953
		private static IntPtr _ClassPtr;

		// Token: 0x0400423A RID: 16954
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400423B RID: 16955
		internal static int __PropertyOffset_OnStateChange;

		// Token: 0x0400423C RID: 16956
		[Nullable(2)]
		private FOnToggleStateChange _OnStateChange;

		// Token: 0x0400423D RID: 16957
		internal static int __PropertyOffset_CanExecuteChange;

		// Token: 0x0400423E RID: 16958
		[Nullable(2)]
		private FCanExecuteChange _CanExecuteChange;

		// Token: 0x0400423F RID: 16959
		internal static int __PropertyOffset_OnHover;

		// Token: 0x04004240 RID: 16960
		[Nullable(2)]
		private FHoverEvent _OnHover;

		// Token: 0x04004241 RID: 16961
		internal static int __PropertyOffset_OnUnHover;

		// Token: 0x04004242 RID: 16962
		[Nullable(2)]
		private FHoverEvent _OnUnHover;

		// Token: 0x04004243 RID: 16963
		internal static int __PropertyOffset_OnUndeterminedClicked;

		// Token: 0x04004244 RID: 16964
		[Nullable(2)]
		private FOnUndeterminedClicked _OnUndeterminedClicked;

		// Token: 0x04004245 RID: 16965
		internal static int __PropertyOffset_OnPostAudioEvent;

		// Token: 0x04004246 RID: 16966
		[Nullable(2)]
		private FLGUIExtendToggleAudioDelegate _OnPostAudioEvent;

		// Token: 0x04004247 RID: 16967
		internal static int __PropertyOffset_AudioConfig;

		// Token: 0x04004248 RID: 16968
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleAudioTransitionState, FSoftObjectPath> _AudioConfig;

		// Token: 0x04004249 RID: 16969
		internal static int __PropertyOffset_bIgnoreSelectedHover;

		// Token: 0x0400424A RID: 16970
		internal static int __PropertyOffset_LongPressAudioEvent;

		// Token: 0x0400424B RID: 16971
		[Nullable(2)]
		private FSoftObjectPath _LongPressAudioEvent;

		// Token: 0x0400424C RID: 16972
		internal static int __PropertyOffset_OnPostAudioStateEvent;

		// Token: 0x0400424D RID: 16973
		[Nullable(2)]
		private FLGUIExtendToggleAudioWithStateDelegate _OnPostAudioStateEvent;

		// Token: 0x0400424E RID: 16974
		internal static int __PropertyOffset_OnPointEnterCallBack;

		// Token: 0x0400424F RID: 16975
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointEnterCallBack;

		// Token: 0x04004250 RID: 16976
		internal static int __PropertyOffset_OnPointExitCallBack;

		// Token: 0x04004251 RID: 16977
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointExitCallBack;

		// Token: 0x04004252 RID: 16978
		internal static int __PropertyOffset_OnPointDownCallBack;

		// Token: 0x04004253 RID: 16979
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointDownCallBack;

		// Token: 0x04004254 RID: 16980
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x04004255 RID: 16981
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointUpCallBack;

		// Token: 0x04004256 RID: 16982
		internal static int __PropertyOffset_OnPointUpCallBackWithEventData;

		// Token: 0x04004257 RID: 16983
		[Nullable(2)]
		private FLGUIExtendToggleWithEventDataDynamicDelegate _OnPointUpCallBackWithEventData;

		// Token: 0x04004258 RID: 16984
		internal static int __PropertyOffset_OnPointCancelCallBack;

		// Token: 0x04004259 RID: 16985
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointCancelCallBack;

		// Token: 0x0400425A RID: 16986
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x0400425B RID: 16987
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x0400425C RID: 16988
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x0400425D RID: 16989
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerDragCallBack;

		// Token: 0x0400425E RID: 16990
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x0400425F RID: 16991
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x04004260 RID: 16992
		internal static int __PropertyOffset_ToggleState;

		// Token: 0x04004261 RID: 16993
		internal static int __PropertyOffset_ToggleGroupActor;

		// Token: 0x04004262 RID: 16994
		internal static int __PropertyOffset_bToggleOnSelect;

		// Token: 0x04004263 RID: 16995
		internal static int __PropertyOffset_bLockStateOnSelect;

		// Token: 0x04004264 RID: 16996
		internal static int __PropertyOffset_bCheckToggleSelected;

		// Token: 0x04004265 RID: 16997
		internal static int __PropertyOffset_StateSwitchAnimations;

		// Token: 0x04004266 RID: 16998
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleStateSwitch, FToggleAnimationPlayInfo> _StateSwitchAnimations;
	}
}
