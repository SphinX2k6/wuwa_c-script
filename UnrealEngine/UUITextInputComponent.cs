using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021CE RID: 8654
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextInputComponent")]
	[UnrealStructLayout(1808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class UUITextInputComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject, ILGUIPointerDragInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06020F62 RID: 135010 RVA: 0x0030A467 File Offset: 0x00308667
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextInputComponent._ClassPtr;
		}

		// Token: 0x06020F63 RID: 135011 RVA: 0x0030A473 File Offset: 0x00308673
		int ILGUIPointerDragInterface.InterfaceOffset()
		{
			return UUITextInputComponent.__InterfaceOffset_ILGUIPointerDragInterface;
		}

		// Token: 0x06020F64 RID: 135012 RVA: 0x0030A47C File Offset: 0x0030867C
		public UUITextInputComponent() : this(BuiltinUtils.AllocNativeUObject(UUITextInputComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020F65 RID: 135013 RVA: 0x0030A4A4 File Offset: 0x003086A4
		public UUITextInputComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextInputComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170080AA RID: 32938
		// (get) Token: 0x06020F66 RID: 135014 RVA: 0x0030A4D7 File Offset: 0x003086D7
		// (set) Token: 0x06020F67 RID: 135015 RVA: 0x0030A4EB File Offset: 0x003086EB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUITextActor> TextActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_TextActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_TextActor) = value;
			}
		}

		// Token: 0x170080AB RID: 32939
		// (get) Token: 0x06020F68 RID: 135016 RVA: 0x0030A500 File Offset: 0x00308700
		// (set) Token: 0x06020F69 RID: 135017 RVA: 0x0030A514 File Offset: 0x00308714
		public unsafe string Text
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUITextInputComponent.__PropertyOffset_Text)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUITextInputComponent.__PropertyOffset_Text)), value);
			}
		}

		// Token: 0x170080AC RID: 32940
		// (get) Token: 0x06020F6A RID: 135018 RVA: 0x0030A529 File Offset: 0x00308729
		// (set) Token: 0x06020F6B RID: 135019 RVA: 0x0030A539 File Offset: 0x00308739
		public unsafe ELGUITextInputType InputType
		{
			get
			{
				return (ELGUITextInputType)(*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_InputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_InputType) = (byte)value;
			}
		}

		// Token: 0x170080AD RID: 32941
		// (get) Token: 0x06020F6C RID: 135020 RVA: 0x0030A54A File Offset: 0x0030874A
		// (set) Token: 0x06020F6D RID: 135021 RVA: 0x0030A55E File Offset: 0x0030875E
		public unsafe string PasswordChar
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UUITextInputComponent.__PropertyOffset_PasswordChar)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UUITextInputComponent.__PropertyOffset_PasswordChar)), value);
			}
		}

		// Token: 0x170080AE RID: 32942
		// (get) Token: 0x06020F6E RID: 135022 RVA: 0x0030A573 File Offset: 0x00308773
		// (set) Token: 0x06020F6F RID: 135023 RVA: 0x0030A583 File Offset: 0x00308783
		public unsafe bool bAllowMultiLine
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_bAllowMultiLine) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_bAllowMultiLine) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080AF RID: 32943
		// (get) Token: 0x06020F70 RID: 135024 RVA: 0x0030A594 File Offset: 0x00308794
		// (set) Token: 0x06020F71 RID: 135025 RVA: 0x0030A5A8 File Offset: 0x003087A8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> PlaceHolderActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_PlaceHolderActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_PlaceHolderActor) = value;
			}
		}

		// Token: 0x170080B0 RID: 32944
		// (get) Token: 0x06020F72 RID: 135026 RVA: 0x0030A5BD File Offset: 0x003087BD
		// (set) Token: 0x06020F73 RID: 135027 RVA: 0x0030A5CD File Offset: 0x003087CD
		public unsafe float CaretBlinkRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretBlinkRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretBlinkRate) = value;
			}
		}

		// Token: 0x170080B1 RID: 32945
		// (get) Token: 0x06020F74 RID: 135028 RVA: 0x0030A5DE File Offset: 0x003087DE
		// (set) Token: 0x06020F75 RID: 135029 RVA: 0x0030A5EE File Offset: 0x003087EE
		public unsafe float CaretWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretWidth) = value;
			}
		}

		// Token: 0x170080B2 RID: 32946
		// (get) Token: 0x06020F76 RID: 135030 RVA: 0x0030A5FF File Offset: 0x003087FF
		// (set) Token: 0x06020F77 RID: 135031 RVA: 0x0030A60F File Offset: 0x0030880F
		public unsafe bool IsShowDefaultText
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_IsShowDefaultText) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_IsShowDefaultText) = (value ? 1 : 0);
			}
		}

		// Token: 0x170080B3 RID: 32947
		// (get) Token: 0x06020F78 RID: 135032 RVA: 0x0030A620 File Offset: 0x00308820
		// (set) Token: 0x06020F79 RID: 135033 RVA: 0x0030A634 File Offset: 0x00308834
		public unsafe FColor CaretColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretColor) = value;
			}
		}

		// Token: 0x170080B4 RID: 32948
		// (get) Token: 0x06020F7A RID: 135034 RVA: 0x0030A649 File Offset: 0x00308849
		// (set) Token: 0x06020F7B RID: 135035 RVA: 0x0030A65D File Offset: 0x0030885D
		public unsafe FColor SelectionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_SelectionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_SelectionColor) = value;
			}
		}

		// Token: 0x170080B5 RID: 32949
		// (get) Token: 0x06020F7C RID: 135036 RVA: 0x0030A674 File Offset: 0x00308874
		// (set) Token: 0x06020F7D RID: 135037 RVA: 0x0030A6AD File Offset: 0x003088AD
		public FVirtualKeyboardOptions VirtualKeyboradOptions
		{
			get
			{
				base.FastCheckIsValid();
				FVirtualKeyboardOptions result;
				if ((result = this._VirtualKeyboradOptions) == null)
				{
					result = (this._VirtualKeyboradOptions = new FVirtualKeyboardOptions(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_VirtualKeyboradOptions, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FVirtualKeyboardOptions.StaticStruct(), base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_VirtualKeyboradOptions, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080B6 RID: 32950
		// (get) Token: 0x06020F7E RID: 135038 RVA: 0x0030A6D0 File Offset: 0x003088D0
		// (set) Token: 0x06020F7F RID: 135039 RVA: 0x0030A709 File Offset: 0x00308909
		public TArray<FKey> IgnoreKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKey> result;
				if ((result = this._IgnoreKeys) == null)
				{
					result = (this._IgnoreKeys = new TArray<FKey>(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_IgnoreKeys, this));
				}
				return result;
			}
			set
			{
				this.IgnoreKeys.CopyAssign(value);
			}
		}

		// Token: 0x170080B7 RID: 32951
		// (get) Token: 0x06020F80 RID: 135040 RVA: 0x0030A718 File Offset: 0x00308918
		// (set) Token: 0x06020F81 RID: 135041 RVA: 0x0030A751 File Offset: 0x00308951
		public FLGUIDrawableEvent OnValueChange
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnValueChange) == null)
				{
					result = (this._OnValueChange = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnValueChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnValueChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080B8 RID: 32952
		// (get) Token: 0x06020F82 RID: 135042 RVA: 0x0030A774 File Offset: 0x00308974
		// (set) Token: 0x06020F83 RID: 135043 RVA: 0x0030A7AD File Offset: 0x003089AD
		public FLGUIDrawableEvent OnSubmit
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnSubmit) == null)
				{
					result = (this._OnSubmit = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnSubmit, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnSubmit, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080B9 RID: 32953
		// (get) Token: 0x06020F84 RID: 135044 RVA: 0x0030A7D0 File Offset: 0x003089D0
		// (set) Token: 0x06020F85 RID: 135045 RVA: 0x0030A809 File Offset: 0x00308A09
		public FLGUIDrawableEvent OnInputActivate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnInputActivate) == null)
				{
					result = (this._OnInputActivate = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnInputActivate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnInputActivate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170080BA RID: 32954
		// (get) Token: 0x06020F86 RID: 135046 RVA: 0x0030A82C File Offset: 0x00308A2C
		// (set) Token: 0x06020F87 RID: 135047 RVA: 0x0030A865 File Offset: 0x00308A65
		public FCheckTextInputDelegate OnCheckTextInputDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FCheckTextInputDelegate result;
				if ((result = this._OnCheckTextInputDelegate) == null)
				{
					result = (this._OnCheckTextInputDelegate = new FCheckTextInputDelegate(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnCheckTextInputDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnCheckTextInputDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170080BB RID: 32955
		// (get) Token: 0x06020F88 RID: 135048 RVA: 0x0030A886 File Offset: 0x00308A86
		// (set) Token: 0x06020F89 RID: 135049 RVA: 0x0030A896 File Offset: 0x00308A96
		public unsafe uint MaxInput
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_MaxInput);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_MaxInput) = (int)value;
			}
		}

		// Token: 0x170080BC RID: 32956
		// (get) Token: 0x06020F8A RID: 135050 RVA: 0x0030A8A7 File Offset: 0x00308AA7
		// (set) Token: 0x06020F8B RID: 135051 RVA: 0x0030A8BB File Offset: 0x00308ABB
		[Nullable(2)]
		public unsafe APlayerController PlayerController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<APlayerController>(base.NativePtr / (IntPtr)sizeof(void*) + UUITextInputComponent.__PropertyOffset_PlayerController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUITextInputComponent.__PropertyOffset_PlayerController, value);
			}
		}

		// Token: 0x170080BD RID: 32957
		// (get) Token: 0x06020F8C RID: 135052 RVA: 0x0030A8D0 File Offset: 0x00308AD0
		// (set) Token: 0x06020F8D RID: 135053 RVA: 0x0030A8E4 File Offset: 0x00308AE4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISprite> CaretObject
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretObject);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_CaretObject) = value;
			}
		}

		// Token: 0x170080BE RID: 32958
		// (get) Token: 0x06020F8E RID: 135054 RVA: 0x0030A8FC File Offset: 0x00308AFC
		// (set) Token: 0x06020F8F RID: 135055 RVA: 0x0030A935 File Offset: 0x00308B35
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUISprite>> SelectionMaskObjectArray
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
				TArray<TWeakObjectPtr<UUISprite>> result;
				if ((result = this._SelectionMaskObjectArray) == null)
				{
					result = (this._SelectionMaskObjectArray = new TArray<TWeakObjectPtr<UUISprite>>(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_SelectionMaskObjectArray, this));
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
				this.SelectionMaskObjectArray.CopyAssign(value);
			}
		}

		// Token: 0x170080BF RID: 32959
		// (get) Token: 0x06020F90 RID: 135056 RVA: 0x0030A944 File Offset: 0x00308B44
		// (set) Token: 0x06020F91 RID: 135057 RVA: 0x0030A97D File Offset: 0x00308B7D
		public FLGUITextInputDynamicDelegate OnTextChange
		{
			get
			{
				base.FastCheckIsValid();
				FLGUITextInputDynamicDelegate result;
				if ((result = this._OnTextChange) == null)
				{
					result = (this._OnTextChange = new FLGUITextInputDynamicDelegate(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170080C0 RID: 32960
		// (get) Token: 0x06020F92 RID: 135058 RVA: 0x0030A9A0 File Offset: 0x00308BA0
		// (set) Token: 0x06020F93 RID: 135059 RVA: 0x0030A9D9 File Offset: 0x00308BD9
		public FLGUITextInputDynamicDelegate OnTextSubmit
		{
			get
			{
				base.FastCheckIsValid();
				FLGUITextInputDynamicDelegate result;
				if ((result = this._OnTextSubmit) == null)
				{
					result = (this._OnTextSubmit = new FLGUITextInputDynamicDelegate(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextSubmit, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextSubmit, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170080C1 RID: 32961
		// (get) Token: 0x06020F94 RID: 135060 RVA: 0x0030A9FC File Offset: 0x00308BFC
		// (set) Token: 0x06020F95 RID: 135061 RVA: 0x0030AA35 File Offset: 0x00308C35
		public FLGUITextInputDynamicDelegate OnTextClip
		{
			get
			{
				base.FastCheckIsValid();
				FLGUITextInputDynamicDelegate result;
				if ((result = this._OnTextClip) == null)
				{
					result = (this._OnTextClip = new FLGUITextInputDynamicDelegate(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextClip, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnTextClip, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170080C2 RID: 32962
		// (get) Token: 0x06020F96 RID: 135062 RVA: 0x0030AA58 File Offset: 0x00308C58
		// (set) Token: 0x06020F97 RID: 135063 RVA: 0x0030AA91 File Offset: 0x00308C91
		public FLGUIInputActivateDynamicDelegate OnInputActivateDelegate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIInputActivateDynamicDelegate result;
				if ((result = this._OnInputActivateDelegate) == null)
				{
					result = (this._OnInputActivateDelegate = new FLGUIInputActivateDynamicDelegate(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnInputActivateDelegate, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUITextInputComponent.__PropertyOffset_OnInputActivateDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06020F98 RID: 135064 RVA: 0x0030AAB2 File Offset: 0x00308CB2
		[NullableContext(2)]
		public void UnregisterValueChangeEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterValueChangeEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020F99 RID: 135065 RVA: 0x0030AACF File Offset: 0x00308CCF
		[NullableContext(2)]
		public void UnregisterSubmitEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterSubmitEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020F9A RID: 135066 RVA: 0x0030AAEC File Offset: 0x00308CEC
		[NullableContext(2)]
		public void UnregisterInputActivateEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterInputActivateEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x06020F9B RID: 135067 RVA: 0x0030AB0C File Offset: 0x00308D0C
		public unsafe void SetText(string InText, bool InFireEvent = false)
		{
			FString fstring = FString.AllocTemp(InText);
			UUITextInputComponent.__SetText_Internal(base.NativePtr, fstring, InFireEvent);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06020F9C RID: 135068 RVA: 0x0030AB37 File Offset: 0x00308D37
		[NullableContext(2)]
		public static void SetShowKeyboardDelegate(in FLGUIShowVirtualKeyboard InDelegate)
		{
			FLGUIShowVirtualKeyboard flguishowVirtualKeyboard = InDelegate;
			UUITextInputComponent.__SetShowKeyboardDelegate_Internal((flguishowVirtualKeyboard != null) ? flguishowVirtualKeyboard.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020F9D RID: 135069 RVA: 0x0030AB4D File Offset: 0x00308D4D
		public void SetInputType(ELGUITextInputType newValue)
		{
			UUITextInputComponent.__SetInputType_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06020F9E RID: 135070 RVA: 0x0030AB5B File Offset: 0x00308D5B
		[NullableContext(2)]
		public void SetCustomInputTypeFunction(in FLGUITextInputCustomInputTypeDynamicDelegate InFunction)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputCustomInputTypeDynamicDelegate flguitextInputCustomInputTypeDynamicDelegate = InFunction;
			UUITextInputComponent.__SetCustomInputTypeFunction_Internal(nativePtr, (flguitextInputCustomInputTypeDynamicDelegate != null) ? flguitextInputCustomInputTypeDynamicDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020F9F RID: 135071 RVA: 0x0030AB77 File Offset: 0x00308D77
		public FLGUIDelegateHandleWrapper RegisterValueChangeEvent([Nullable(2)] in FLGUITextInputDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputDynamicDelegate flguitextInputDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterValueChangeEvent_Internal(nativePtr, (flguitextInputDynamicDelegate != null) ? flguitextInputDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020FA0 RID: 135072 RVA: 0x0030AB99 File Offset: 0x00308D99
		public FLGUIDelegateHandleWrapper RegisterSubmitEvent([Nullable(2)] in FLGUITextInputDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputDynamicDelegate flguitextInputDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterSubmitEvent_Internal(nativePtr, (flguitextInputDynamicDelegate != null) ? flguitextInputDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020FA1 RID: 135073 RVA: 0x0030ABBB File Offset: 0x00308DBB
		public FLGUIDelegateHandleWrapper RegisterInputActivateEvent([Nullable(2)] in FLGUIInputActivateDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIInputActivateDynamicDelegate flguiinputActivateDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterInputActivateEvent_Internal(nativePtr, (flguiinputActivateDynamicDelegate != null) ? flguiinputActivateDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06020FA2 RID: 135074 RVA: 0x0030ABDD File Offset: 0x00308DDD
		public bool IsInputActive()
		{
			return UUITextInputComponent.__IsInputActive_Internal(base.NativePtr);
		}

		// Token: 0x06020FA3 RID: 135075 RVA: 0x0030ABEA File Offset: 0x00308DEA
		[NullableContext(2)]
		public UUIText GetTextComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(UUITextInputComponent.__GetTextComponent_Internal(base.NativePtr));
		}

		// Token: 0x06020FA4 RID: 135076 RVA: 0x0030ABFC File Offset: 0x00308DFC
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUITextInputComponent.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x06020FA5 RID: 135077 RVA: 0x0030AC0E File Offset: 0x00308E0E
		public ELGUITextInputType GetInputType()
		{
			return UUITextInputComponent.__GetInputType_Internal(base.NativePtr);
		}

		// Token: 0x06020FA6 RID: 135078 RVA: 0x0030AC1B File Offset: 0x00308E1B
		public void DeactivateInputText()
		{
			UUITextInputComponent.__DeactivateInputText_Internal(base.NativePtr);
		}

		// Token: 0x06020FA7 RID: 135079 RVA: 0x0030AC28 File Offset: 0x00308E28
		public void ClearCustomInputTypeEvent()
		{
			UUITextInputComponent.__ClearCustomInputTypeEvent_Internal(base.NativePtr);
		}

		// Token: 0x06020FA8 RID: 135080 RVA: 0x0030AC35 File Offset: 0x00308E35
		public void ActivateInputText()
		{
			UUITextInputComponent.__ActivateInputText_Internal(base.NativePtr);
		}

		// Token: 0x06020FA9 RID: 135081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterValueChangeEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020FAA RID: 135082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSubmitEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020FAB RID: 135083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputActivateEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x06020FAC RID: 135084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString InText, bool InFireEvent);

		// Token: 0x06020FAD RID: 135085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowKeyboardDelegate_Internal(IntPtr InDelegate);

		// Token: 0x06020FAE RID: 135086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputType_Internal(IntPtr @this, ELGUITextInputType newValue);

		// Token: 0x06020FAF RID: 135087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomInputTypeFunction_Internal(IntPtr @this, IntPtr InFunction);

		// Token: 0x06020FB0 RID: 135088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterValueChangeEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020FB1 RID: 135089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSubmitEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020FB2 RID: 135090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterInputActivateEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06020FB3 RID: 135091
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInputActive_Internal(IntPtr @this);

		// Token: 0x06020FB4 RID: 135092
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTextComponent_Internal(IntPtr @this);

		// Token: 0x06020FB5 RID: 135093
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x06020FB6 RID: 135094
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ELGUITextInputType __GetInputType_Internal(IntPtr @this);

		// Token: 0x06020FB7 RID: 135095
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateInputText_Internal(IntPtr @this);

		// Token: 0x06020FB8 RID: 135096
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCustomInputTypeEvent_Internal(IntPtr @this);

		// Token: 0x06020FB9 RID: 135097
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateInputText_Internal(IntPtr @this);

		// Token: 0x06020FBA RID: 135098 RVA: 0x0030AC42 File Offset: 0x00308E42
		static UUITextInputComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextInputComponent");
		}

		// Token: 0x06020FBB RID: 135099 RVA: 0x0030AC50 File Offset: 0x00308E50
		protected UUITextInputComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401197B RID: 72059
		internal static int __InterfaceOffset_ILGUIPointerDragInterface;

		// Token: 0x0401197C RID: 72060
		public new const string __ObjectPath = "/Script/LGUI.UITextInputComponent";

		// Token: 0x0401197D RID: 72061
		private static IntPtr _ClassPtr;

		// Token: 0x0401197E RID: 72062
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401197F RID: 72063
		internal static int __PropertyOffset_TextActor;

		// Token: 0x04011980 RID: 72064
		internal static int __PropertyOffset_Text;

		// Token: 0x04011981 RID: 72065
		internal static int __PropertyOffset_InputType;

		// Token: 0x04011982 RID: 72066
		internal static int __PropertyOffset_PasswordChar;

		// Token: 0x04011983 RID: 72067
		internal static int __PropertyOffset_bAllowMultiLine;

		// Token: 0x04011984 RID: 72068
		internal static int __PropertyOffset_PlaceHolderActor;

		// Token: 0x04011985 RID: 72069
		internal static int __PropertyOffset_CaretBlinkRate;

		// Token: 0x04011986 RID: 72070
		internal static int __PropertyOffset_CaretWidth;

		// Token: 0x04011987 RID: 72071
		internal static int __PropertyOffset_IsShowDefaultText;

		// Token: 0x04011988 RID: 72072
		internal static int __PropertyOffset_CaretColor;

		// Token: 0x04011989 RID: 72073
		internal static int __PropertyOffset_SelectionColor;

		// Token: 0x0401198A RID: 72074
		internal static int __PropertyOffset_VirtualKeyboradOptions;

		// Token: 0x0401198B RID: 72075
		[Nullable(2)]
		private FVirtualKeyboardOptions _VirtualKeyboradOptions;

		// Token: 0x0401198C RID: 72076
		internal static int __PropertyOffset_IgnoreKeys;

		// Token: 0x0401198D RID: 72077
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _IgnoreKeys;

		// Token: 0x0401198E RID: 72078
		internal static int __PropertyOffset_OnValueChange;

		// Token: 0x0401198F RID: 72079
		[Nullable(2)]
		private FLGUIDrawableEvent _OnValueChange;

		// Token: 0x04011990 RID: 72080
		internal static int __PropertyOffset_OnSubmit;

		// Token: 0x04011991 RID: 72081
		[Nullable(2)]
		private FLGUIDrawableEvent _OnSubmit;

		// Token: 0x04011992 RID: 72082
		internal static int __PropertyOffset_OnInputActivate;

		// Token: 0x04011993 RID: 72083
		[Nullable(2)]
		private FLGUIDrawableEvent _OnInputActivate;

		// Token: 0x04011994 RID: 72084
		internal static int __PropertyOffset_OnCheckTextInputDelegate;

		// Token: 0x04011995 RID: 72085
		[Nullable(2)]
		private FCheckTextInputDelegate _OnCheckTextInputDelegate;

		// Token: 0x04011996 RID: 72086
		internal static int __PropertyOffset_MaxInput;

		// Token: 0x04011997 RID: 72087
		internal static int __PropertyOffset_PlayerController;

		// Token: 0x04011998 RID: 72088
		internal static int __PropertyOffset_CaretObject;

		// Token: 0x04011999 RID: 72089
		internal static int __PropertyOffset_SelectionMaskObjectArray;

		// Token: 0x0401199A RID: 72090
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUISprite>> _SelectionMaskObjectArray;

		// Token: 0x0401199B RID: 72091
		internal static int __PropertyOffset_OnTextChange;

		// Token: 0x0401199C RID: 72092
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextChange;

		// Token: 0x0401199D RID: 72093
		internal static int __PropertyOffset_OnTextSubmit;

		// Token: 0x0401199E RID: 72094
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextSubmit;

		// Token: 0x0401199F RID: 72095
		internal static int __PropertyOffset_OnTextClip;

		// Token: 0x040119A0 RID: 72096
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextClip;

		// Token: 0x040119A1 RID: 72097
		internal static int __PropertyOffset_OnInputActivateDelegate;

		// Token: 0x040119A2 RID: 72098
		[Nullable(2)]
		private FLGUIInputActivateDynamicDelegate _OnInputActivateDelegate;
	}
}
