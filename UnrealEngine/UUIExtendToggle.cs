using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002167 RID: 8551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIExtendToggle")]
	[UnrealStructLayout(2272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2272)]
	public class UUIExtendToggle : UUISelectableComponent, IUnrealUObject, IUnrealObject, ISequenceCustomGuidGetterInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerDragInterface
	{
		// Token: 0x0602043F RID: 132159 RVA: 0x002FE8A2 File Offset: 0x002FCAA2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIExtendToggle._ClassPtr;
		}

		// Token: 0x06020440 RID: 132160 RVA: 0x002FE8AE File Offset: 0x002FCAAE
		int ISequenceCustomGuidGetterInterface.InterfaceOffset()
		{
			return UUIExtendToggle.__InterfaceOffset_ISequenceCustomGuidGetterInterface;
		}

		// Token: 0x06020441 RID: 132161 RVA: 0x002FE8B5 File Offset: 0x002FCAB5
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUIExtendToggle.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x06020442 RID: 132162 RVA: 0x002FE8BC File Offset: 0x002FCABC
		public UUIExtendToggle() : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020443 RID: 132163 RVA: 0x002FE8E4 File Offset: 0x002FCAE4
		public UUIExtendToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIExtendToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E73 RID: 32371
		// (get) Token: 0x06020444 RID: 132164 RVA: 0x002FE918 File Offset: 0x002FCB18
		// (set) Token: 0x06020445 RID: 132165 RVA: 0x002FE951 File Offset: 0x002FCB51
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

		// Token: 0x17007E74 RID: 32372
		// (get) Token: 0x06020446 RID: 132166 RVA: 0x002FE974 File Offset: 0x002FCB74
		// (set) Token: 0x06020447 RID: 132167 RVA: 0x002FE9AD File Offset: 0x002FCBAD
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

		// Token: 0x17007E75 RID: 32373
		// (get) Token: 0x06020448 RID: 132168 RVA: 0x002FE9D0 File Offset: 0x002FCBD0
		// (set) Token: 0x06020449 RID: 132169 RVA: 0x002FEA09 File Offset: 0x002FCC09
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

		// Token: 0x17007E76 RID: 32374
		// (get) Token: 0x0602044A RID: 132170 RVA: 0x002FEA2C File Offset: 0x002FCC2C
		// (set) Token: 0x0602044B RID: 132171 RVA: 0x002FEA65 File Offset: 0x002FCC65
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

		// Token: 0x17007E77 RID: 32375
		// (get) Token: 0x0602044C RID: 132172 RVA: 0x002FEA88 File Offset: 0x002FCC88
		// (set) Token: 0x0602044D RID: 132173 RVA: 0x002FEAC1 File Offset: 0x002FCCC1
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

		// Token: 0x17007E78 RID: 32376
		// (get) Token: 0x0602044E RID: 132174 RVA: 0x002FEAE4 File Offset: 0x002FCCE4
		// (set) Token: 0x0602044F RID: 132175 RVA: 0x002FEB1D File Offset: 0x002FCD1D
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

		// Token: 0x17007E79 RID: 32377
		// (get) Token: 0x06020450 RID: 132176 RVA: 0x002FEB40 File Offset: 0x002FCD40
		// (set) Token: 0x06020451 RID: 132177 RVA: 0x002FEB79 File Offset: 0x002FCD79
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

		// Token: 0x17007E7A RID: 32378
		// (get) Token: 0x06020452 RID: 132178 RVA: 0x002FEB87 File Offset: 0x002FCD87
		// (set) Token: 0x06020453 RID: 132179 RVA: 0x002FEB97 File Offset: 0x002FCD97
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

		// Token: 0x17007E7B RID: 32379
		// (get) Token: 0x06020454 RID: 132180 RVA: 0x002FEBA8 File Offset: 0x002FCDA8
		// (set) Token: 0x06020455 RID: 132181 RVA: 0x002FEBE1 File Offset: 0x002FCDE1
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

		// Token: 0x17007E7C RID: 32380
		// (get) Token: 0x06020456 RID: 132182 RVA: 0x002FEC04 File Offset: 0x002FCE04
		// (set) Token: 0x06020457 RID: 132183 RVA: 0x002FEC3D File Offset: 0x002FCE3D
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

		// Token: 0x17007E7D RID: 32381
		// (get) Token: 0x06020458 RID: 132184 RVA: 0x002FEC60 File Offset: 0x002FCE60
		// (set) Token: 0x06020459 RID: 132185 RVA: 0x002FEC99 File Offset: 0x002FCE99
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

		// Token: 0x17007E7E RID: 32382
		// (get) Token: 0x0602045A RID: 132186 RVA: 0x002FECBC File Offset: 0x002FCEBC
		// (set) Token: 0x0602045B RID: 132187 RVA: 0x002FECF5 File Offset: 0x002FCEF5
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

		// Token: 0x17007E7F RID: 32383
		// (get) Token: 0x0602045C RID: 132188 RVA: 0x002FED18 File Offset: 0x002FCF18
		// (set) Token: 0x0602045D RID: 132189 RVA: 0x002FED51 File Offset: 0x002FCF51
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

		// Token: 0x17007E80 RID: 32384
		// (get) Token: 0x0602045E RID: 132190 RVA: 0x002FED74 File Offset: 0x002FCF74
		// (set) Token: 0x0602045F RID: 132191 RVA: 0x002FEDAD File Offset: 0x002FCFAD
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

		// Token: 0x17007E81 RID: 32385
		// (get) Token: 0x06020460 RID: 132192 RVA: 0x002FEDD0 File Offset: 0x002FCFD0
		// (set) Token: 0x06020461 RID: 132193 RVA: 0x002FEE09 File Offset: 0x002FD009
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

		// Token: 0x17007E82 RID: 32386
		// (get) Token: 0x06020462 RID: 132194 RVA: 0x002FEE2C File Offset: 0x002FD02C
		// (set) Token: 0x06020463 RID: 132195 RVA: 0x002FEE65 File Offset: 0x002FD065
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

		// Token: 0x17007E83 RID: 32387
		// (get) Token: 0x06020464 RID: 132196 RVA: 0x002FEE88 File Offset: 0x002FD088
		// (set) Token: 0x06020465 RID: 132197 RVA: 0x002FEEC1 File Offset: 0x002FD0C1
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

		// Token: 0x17007E84 RID: 32388
		// (get) Token: 0x06020466 RID: 132198 RVA: 0x002FEEE4 File Offset: 0x002FD0E4
		// (set) Token: 0x06020467 RID: 132199 RVA: 0x002FEF1D File Offset: 0x002FD11D
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

		// Token: 0x17007E85 RID: 32389
		// (get) Token: 0x06020468 RID: 132200 RVA: 0x002FEF40 File Offset: 0x002FD140
		// (set) Token: 0x06020469 RID: 132201 RVA: 0x002FEF79 File Offset: 0x002FD179
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

		// Token: 0x17007E86 RID: 32390
		// (get) Token: 0x0602046A RID: 132202 RVA: 0x002FEF9A File Offset: 0x002FD19A
		// (set) Token: 0x0602046B RID: 132203 RVA: 0x002FEFAA File Offset: 0x002FD1AA
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

		// Token: 0x17007E87 RID: 32391
		// (get) Token: 0x0602046C RID: 132204 RVA: 0x002FEFBB File Offset: 0x002FD1BB
		// (set) Token: 0x0602046D RID: 132205 RVA: 0x002FEFCF File Offset: 0x002FD1CF
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

		// Token: 0x17007E88 RID: 32392
		// (get) Token: 0x0602046E RID: 132206 RVA: 0x002FEFE4 File Offset: 0x002FD1E4
		// (set) Token: 0x0602046F RID: 132207 RVA: 0x002FEFF4 File Offset: 0x002FD1F4
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

		// Token: 0x17007E89 RID: 32393
		// (get) Token: 0x06020470 RID: 132208 RVA: 0x002FF005 File Offset: 0x002FD205
		// (set) Token: 0x06020471 RID: 132209 RVA: 0x002FF015 File Offset: 0x002FD215
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

		// Token: 0x17007E8A RID: 32394
		// (get) Token: 0x06020472 RID: 132210 RVA: 0x002FF026 File Offset: 0x002FD226
		// (set) Token: 0x06020473 RID: 132211 RVA: 0x002FF036 File Offset: 0x002FD236
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

		// Token: 0x17007E8B RID: 32395
		// (get) Token: 0x06020474 RID: 132212 RVA: 0x002FF048 File Offset: 0x002FD248
		// (set) Token: 0x06020475 RID: 132213 RVA: 0x002FF081 File Offset: 0x002FD281
		public TMap<EToggleAnimationType, FToggleAnimationPlayInfo> ToggleAnimations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EToggleAnimationType, FToggleAnimationPlayInfo> result;
				if ((result = this._ToggleAnimations) == null)
				{
					result = (this._ToggleAnimations = new TMap<EToggleAnimationType, FToggleAnimationPlayInfo>(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_ToggleAnimations, this));
				}
				return result;
			}
			set
			{
				this.ToggleAnimations.CopyAssign(value);
			}
		}

		// Token: 0x17007E8C RID: 32396
		// (get) Token: 0x06020476 RID: 132214 RVA: 0x002FF090 File Offset: 0x002FD290
		// (set) Token: 0x06020477 RID: 132215 RVA: 0x002FF0C9 File Offset: 0x002FD2C9
		public TMap<EUISelectableInteractionState, FToggleStateAnimation> InteractiveAnimations
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EUISelectableInteractionState, FToggleStateAnimation> result;
				if ((result = this._InteractiveAnimations) == null)
				{
					result = (this._InteractiveAnimations = new TMap<EUISelectableInteractionState, FToggleStateAnimation>(base.NativePtr + (IntPtr)UUIExtendToggle.__PropertyOffset_InteractiveAnimations, this));
				}
				return result;
			}
			set
			{
				this.InteractiveAnimations.CopyAssign(value);
			}
		}

		// Token: 0x17007E8D RID: 32397
		// (get) Token: 0x06020478 RID: 132216 RVA: 0x002FF0D8 File Offset: 0x002FD2D8
		// (set) Token: 0x06020479 RID: 132217 RVA: 0x002FF111 File Offset: 0x002FD311
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

		// Token: 0x0602047A RID: 132218 RVA: 0x002FF11F File Offset: 0x002FD31F
		public void SetToggleStateForce(EToggleState State, bool bFireEvent = false, bool bIngnoreAnim = false, bool bJumpToLastFrame = false)
		{
			UUIExtendToggle.__SetToggleStateForce_Internal(base.NativePtr, State, bFireEvent, bIngnoreAnim, bJumpToLastFrame);
		}

		// Token: 0x0602047B RID: 132219 RVA: 0x002FF131 File Offset: 0x002FD331
		public EToggleChangeStateResult SetToggleState(EToggleState State, bool bFireEvent = false, bool bIngnoreAnim = false, bool bJumpToLastFrame = false)
		{
			return UUIExtendToggle.__SetToggleState_Internal(base.NativePtr, State, bFireEvent, bIngnoreAnim, bJumpToLastFrame);
		}

		// Token: 0x0602047C RID: 132220 RVA: 0x002FF143 File Offset: 0x002FD343
		[NullableContext(2)]
		public void SetToggleGroup(AActor TogGroupActor)
		{
			UUIExtendToggle.__SetToggleGroup_Internal(base.NativePtr, (TogGroupActor != null) ? TogGroupActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0602047D RID: 132221 RVA: 0x002FF160 File Offset: 0x002FD360
		public void SetAllTransitionsEnable(bool bIsEnable)
		{
			UUIExtendToggle.__SetAllTransitionsEnable_Internal(base.NativePtr, bIsEnable);
		}

		// Token: 0x0602047E RID: 132222 RVA: 0x002FF16E File Offset: 0x002FD36E
		public EToggleState GetToggleState()
		{
			return UUIExtendToggle.__GetToggleState_Internal(base.NativePtr);
		}

		// Token: 0x0602047F RID: 132223 RVA: 0x002FF17B File Offset: 0x002FD37B
		[NullableContext(2)]
		public UUIExtendToggleGroup GetToggleGroup()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIExtendToggleGroup>(UUIExtendToggle.__GetToggleGroup_Internal(base.NativePtr));
		}

		// Token: 0x06020480 RID: 132224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleStateForce_Internal(IntPtr @this, EToggleState State, bool bFireEvent, bool bIngnoreAnim, bool bJumpToLastFrame);

		// Token: 0x06020481 RID: 132225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EToggleChangeStateResult __SetToggleState_Internal(IntPtr @this, EToggleState State, bool bFireEvent, bool bIngnoreAnim, bool bJumpToLastFrame);

		// Token: 0x06020482 RID: 132226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToggleGroup_Internal(IntPtr @this, IntPtr TogGroupActor);

		// Token: 0x06020483 RID: 132227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAllTransitionsEnable_Internal(IntPtr @this, bool bIsEnable);

		// Token: 0x06020484 RID: 132228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EToggleState __GetToggleState_Internal(IntPtr @this);

		// Token: 0x06020485 RID: 132229
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetToggleGroup_Internal(IntPtr @this);

		// Token: 0x06020486 RID: 132230 RVA: 0x002FF18D File Offset: 0x002FD38D
		static UUIExtendToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIExtendToggle");
		}

		// Token: 0x06020487 RID: 132231 RVA: 0x002FF19B File Offset: 0x002FD39B
		protected UUIExtendToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011554 RID: 70996
		internal static int __InterfaceOffset_ISequenceCustomGuidGetterInterface;

		// Token: 0x04011555 RID: 70997
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x04011556 RID: 70998
		public new const string __ObjectPath = "/Script/LGUI.UIExtendToggle";

		// Token: 0x04011557 RID: 70999
		private static IntPtr _ClassPtr;

		// Token: 0x04011558 RID: 71000
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011559 RID: 71001
		internal static int __PropertyOffset_OnStateChange;

		// Token: 0x0401155A RID: 71002
		[Nullable(2)]
		private FOnToggleStateChange _OnStateChange;

		// Token: 0x0401155B RID: 71003
		internal static int __PropertyOffset_CanExecuteChange;

		// Token: 0x0401155C RID: 71004
		[Nullable(2)]
		private FCanExecuteChange _CanExecuteChange;

		// Token: 0x0401155D RID: 71005
		internal static int __PropertyOffset_OnHover;

		// Token: 0x0401155E RID: 71006
		[Nullable(2)]
		private FHoverEvent _OnHover;

		// Token: 0x0401155F RID: 71007
		internal static int __PropertyOffset_OnUnHover;

		// Token: 0x04011560 RID: 71008
		[Nullable(2)]
		private FHoverEvent _OnUnHover;

		// Token: 0x04011561 RID: 71009
		internal static int __PropertyOffset_OnUndeterminedClicked;

		// Token: 0x04011562 RID: 71010
		[Nullable(2)]
		private FOnUndeterminedClicked _OnUndeterminedClicked;

		// Token: 0x04011563 RID: 71011
		internal static int __PropertyOffset_OnPostAudioEvent;

		// Token: 0x04011564 RID: 71012
		[Nullable(2)]
		private FLGUIExtendToggleAudioDelegate _OnPostAudioEvent;

		// Token: 0x04011565 RID: 71013
		internal static int __PropertyOffset_AudioConfig;

		// Token: 0x04011566 RID: 71014
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleAudioTransitionState, FSoftObjectPath> _AudioConfig;

		// Token: 0x04011567 RID: 71015
		internal static int __PropertyOffset_bIgnoreSelectedHover;

		// Token: 0x04011568 RID: 71016
		internal static int __PropertyOffset_LongPressAudioEvent;

		// Token: 0x04011569 RID: 71017
		[Nullable(2)]
		private FSoftObjectPath _LongPressAudioEvent;

		// Token: 0x0401156A RID: 71018
		internal static int __PropertyOffset_OnPostAudioStateEvent;

		// Token: 0x0401156B RID: 71019
		[Nullable(2)]
		private FLGUIExtendToggleAudioWithStateDelegate _OnPostAudioStateEvent;

		// Token: 0x0401156C RID: 71020
		internal static int __PropertyOffset_OnPointEnterCallBack;

		// Token: 0x0401156D RID: 71021
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointEnterCallBack;

		// Token: 0x0401156E RID: 71022
		internal static int __PropertyOffset_OnPointExitCallBack;

		// Token: 0x0401156F RID: 71023
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointExitCallBack;

		// Token: 0x04011570 RID: 71024
		internal static int __PropertyOffset_OnPointDownCallBack;

		// Token: 0x04011571 RID: 71025
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointDownCallBack;

		// Token: 0x04011572 RID: 71026
		internal static int __PropertyOffset_OnPointUpCallBack;

		// Token: 0x04011573 RID: 71027
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointUpCallBack;

		// Token: 0x04011574 RID: 71028
		internal static int __PropertyOffset_OnPointUpCallBackWithEventData;

		// Token: 0x04011575 RID: 71029
		[Nullable(2)]
		private FLGUIExtendToggleWithEventDataDynamicDelegate _OnPointUpCallBackWithEventData;

		// Token: 0x04011576 RID: 71030
		internal static int __PropertyOffset_OnPointCancelCallBack;

		// Token: 0x04011577 RID: 71031
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegate _OnPointCancelCallBack;

		// Token: 0x04011578 RID: 71032
		internal static int __PropertyOffset_OnPointerBeginDragCallBack;

		// Token: 0x04011579 RID: 71033
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerBeginDragCallBack;

		// Token: 0x0401157A RID: 71034
		internal static int __PropertyOffset_OnPointerDragCallBack;

		// Token: 0x0401157B RID: 71035
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerDragCallBack;

		// Token: 0x0401157C RID: 71036
		internal static int __PropertyOffset_OnPointerEndDragCallBack;

		// Token: 0x0401157D RID: 71037
		[Nullable(2)]
		private FLGUIExtendToggleDynamicDelegateOneParams _OnPointerEndDragCallBack;

		// Token: 0x0401157E RID: 71038
		internal static int __PropertyOffset_ToggleState;

		// Token: 0x0401157F RID: 71039
		internal static int __PropertyOffset_ToggleGroupActor;

		// Token: 0x04011580 RID: 71040
		internal static int __PropertyOffset_bToggleOnSelect;

		// Token: 0x04011581 RID: 71041
		internal static int __PropertyOffset_bLockStateOnSelect;

		// Token: 0x04011582 RID: 71042
		internal static int __PropertyOffset_bCheckToggleSelected;

		// Token: 0x04011583 RID: 71043
		internal static int __PropertyOffset_ToggleAnimations;

		// Token: 0x04011584 RID: 71044
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleAnimationType, FToggleAnimationPlayInfo> _ToggleAnimations;

		// Token: 0x04011585 RID: 71045
		internal static int __PropertyOffset_InteractiveAnimations;

		// Token: 0x04011586 RID: 71046
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EUISelectableInteractionState, FToggleStateAnimation> _InteractiveAnimations;

		// Token: 0x04011587 RID: 71047
		internal static int __PropertyOffset_StateSwitchAnimations;

		// Token: 0x04011588 RID: 71048
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleStateSwitch, FToggleAnimationPlayInfo> _StateSwitchAnimations;
	}
}
