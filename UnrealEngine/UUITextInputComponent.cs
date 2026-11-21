using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000730 RID: 1840
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UITextInputComponent")]
	[UnrealStructLayout(1808, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1808)]
	public class UUITextInputComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A056 RID: 41046 RVA: 0x000ED681 File Offset: 0x000EB881
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUITextInputComponent._ClassPtr;
		}

		// Token: 0x0600A057 RID: 41047 RVA: 0x000ED690 File Offset: 0x000EB890
		public UUITextInputComponent() : this(BuiltinUtils.AllocNativeUObject(UUITextInputComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A058 RID: 41048 RVA: 0x000ED6B8 File Offset: 0x000EB8B8
		public UUITextInputComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUITextInputComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001DCE RID: 7630
		// (get) Token: 0x0600A059 RID: 41049 RVA: 0x000ED6EB File Offset: 0x000EB8EB
		// (set) Token: 0x0600A05A RID: 41050 RVA: 0x000ED6FF File Offset: 0x000EB8FF
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

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x0600A05B RID: 41051 RVA: 0x000ED714 File Offset: 0x000EB914
		// (set) Token: 0x0600A05C RID: 41052 RVA: 0x000ED728 File Offset: 0x000EB928
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

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x0600A05D RID: 41053 RVA: 0x000ED73D File Offset: 0x000EB93D
		// (set) Token: 0x0600A05E RID: 41054 RVA: 0x000ED751 File Offset: 0x000EB951
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

		// Token: 0x17001DD1 RID: 7633
		// (get) Token: 0x0600A05F RID: 41055 RVA: 0x000ED766 File Offset: 0x000EB966
		// (set) Token: 0x0600A060 RID: 41056 RVA: 0x000ED776 File Offset: 0x000EB976
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

		// Token: 0x17001DD2 RID: 7634
		// (get) Token: 0x0600A061 RID: 41057 RVA: 0x000ED787 File Offset: 0x000EB987
		// (set) Token: 0x0600A062 RID: 41058 RVA: 0x000ED79B File Offset: 0x000EB99B
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

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x0600A063 RID: 41059 RVA: 0x000ED7B0 File Offset: 0x000EB9B0
		// (set) Token: 0x0600A064 RID: 41060 RVA: 0x000ED7C0 File Offset: 0x000EB9C0
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

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x0600A065 RID: 41061 RVA: 0x000ED7D1 File Offset: 0x000EB9D1
		// (set) Token: 0x0600A066 RID: 41062 RVA: 0x000ED7E1 File Offset: 0x000EB9E1
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

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x0600A067 RID: 41063 RVA: 0x000ED7F2 File Offset: 0x000EB9F2
		// (set) Token: 0x0600A068 RID: 41064 RVA: 0x000ED802 File Offset: 0x000EBA02
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

		// Token: 0x17001DD6 RID: 7638
		// (get) Token: 0x0600A069 RID: 41065 RVA: 0x000ED813 File Offset: 0x000EBA13
		// (set) Token: 0x0600A06A RID: 41066 RVA: 0x000ED827 File Offset: 0x000EBA27
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

		// Token: 0x17001DD7 RID: 7639
		// (get) Token: 0x0600A06B RID: 41067 RVA: 0x000ED83C File Offset: 0x000EBA3C
		// (set) Token: 0x0600A06C RID: 41068 RVA: 0x000ED850 File Offset: 0x000EBA50
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

		// Token: 0x17001DD8 RID: 7640
		// (get) Token: 0x0600A06D RID: 41069 RVA: 0x000ED868 File Offset: 0x000EBA68
		// (set) Token: 0x0600A06E RID: 41070 RVA: 0x000ED8A1 File Offset: 0x000EBAA1
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

		// Token: 0x17001DD9 RID: 7641
		// (get) Token: 0x0600A06F RID: 41071 RVA: 0x000ED8B0 File Offset: 0x000EBAB0
		// (set) Token: 0x0600A070 RID: 41072 RVA: 0x000ED8E9 File Offset: 0x000EBAE9
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

		// Token: 0x17001DDA RID: 7642
		// (get) Token: 0x0600A071 RID: 41073 RVA: 0x000ED90A File Offset: 0x000EBB0A
		// (set) Token: 0x0600A072 RID: 41074 RVA: 0x000ED91A File Offset: 0x000EBB1A
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

		// Token: 0x17001DDB RID: 7643
		// (get) Token: 0x0600A073 RID: 41075 RVA: 0x000ED92B File Offset: 0x000EBB2B
		// (set) Token: 0x0600A074 RID: 41076 RVA: 0x000ED93F File Offset: 0x000EBB3F
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

		// Token: 0x17001DDC RID: 7644
		// (get) Token: 0x0600A075 RID: 41077 RVA: 0x000ED954 File Offset: 0x000EBB54
		// (set) Token: 0x0600A076 RID: 41078 RVA: 0x000ED968 File Offset: 0x000EBB68
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

		// Token: 0x17001DDD RID: 7645
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x000ED980 File Offset: 0x000EBB80
		// (set) Token: 0x0600A078 RID: 41080 RVA: 0x000ED9B9 File Offset: 0x000EBBB9
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

		// Token: 0x17001DDE RID: 7646
		// (get) Token: 0x0600A079 RID: 41081 RVA: 0x000ED9C8 File Offset: 0x000EBBC8
		// (set) Token: 0x0600A07A RID: 41082 RVA: 0x000EDA01 File Offset: 0x000EBC01
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

		// Token: 0x17001DDF RID: 7647
		// (get) Token: 0x0600A07B RID: 41083 RVA: 0x000EDA24 File Offset: 0x000EBC24
		// (set) Token: 0x0600A07C RID: 41084 RVA: 0x000EDA5D File Offset: 0x000EBC5D
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

		// Token: 0x17001DE0 RID: 7648
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x000EDA80 File Offset: 0x000EBC80
		// (set) Token: 0x0600A07E RID: 41086 RVA: 0x000EDAB9 File Offset: 0x000EBCB9
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

		// Token: 0x17001DE1 RID: 7649
		// (get) Token: 0x0600A07F RID: 41087 RVA: 0x000EDADC File Offset: 0x000EBCDC
		// (set) Token: 0x0600A080 RID: 41088 RVA: 0x000EDB15 File Offset: 0x000EBD15
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

		// Token: 0x0600A081 RID: 41089 RVA: 0x000EDB36 File Offset: 0x000EBD36
		[NullableContext(2)]
		public void UnregisterValueChangeEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterValueChangeEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600A082 RID: 41090 RVA: 0x000EDB53 File Offset: 0x000EBD53
		[NullableContext(2)]
		public void UnregisterSubmitEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterSubmitEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x000EDB70 File Offset: 0x000EBD70
		[NullableContext(2)]
		public void UnregisterInputActivateEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUITextInputComponent.__UnregisterInputActivateEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600A084 RID: 41092 RVA: 0x000EDB90 File Offset: 0x000EBD90
		public unsafe void SetText(string InText, bool InFireEvent = false)
		{
			FString fstring = FString.AllocTemp(InText);
			UUITextInputComponent.__SetText_Internal(base.NativePtr, fstring, InFireEvent);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A085 RID: 41093 RVA: 0x000EDBBB File Offset: 0x000EBDBB
		[NullableContext(2)]
		public static void SetShowKeyboardDelegate(in FLGUIShowVirtualKeyboard InDelegate)
		{
			FLGUIShowVirtualKeyboard flguishowVirtualKeyboard = InDelegate;
			UUITextInputComponent.__SetShowKeyboardDelegate_Internal((flguishowVirtualKeyboard != null) ? flguishowVirtualKeyboard.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x000EDBD1 File Offset: 0x000EBDD1
		[NullableContext(2)]
		public void SetCustomInputTypeFunction(in FLGUITextInputCustomInputTypeDynamicDelegate InFunction)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputCustomInputTypeDynamicDelegate flguitextInputCustomInputTypeDynamicDelegate = InFunction;
			UUITextInputComponent.__SetCustomInputTypeFunction_Internal(nativePtr, (flguitextInputCustomInputTypeDynamicDelegate != null) ? flguitextInputCustomInputTypeDynamicDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600A087 RID: 41095 RVA: 0x000EDBED File Offset: 0x000EBDED
		public FLGUIDelegateHandleWrapper RegisterValueChangeEvent([Nullable(2)] in FLGUITextInputDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputDynamicDelegate flguitextInputDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterValueChangeEvent_Internal(nativePtr, (flguitextInputDynamicDelegate != null) ? flguitextInputDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0600A088 RID: 41096 RVA: 0x000EDC0F File Offset: 0x000EBE0F
		public FLGUIDelegateHandleWrapper RegisterSubmitEvent([Nullable(2)] in FLGUITextInputDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUITextInputDynamicDelegate flguitextInputDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterSubmitEvent_Internal(nativePtr, (flguitextInputDynamicDelegate != null) ? flguitextInputDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x000EDC31 File Offset: 0x000EBE31
		public FLGUIDelegateHandleWrapper RegisterInputActivateEvent([Nullable(2)] in FLGUIInputActivateDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FLGUIInputActivateDynamicDelegate flguiinputActivateDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUITextInputComponent.__RegisterInputActivateEvent_Internal(nativePtr, (flguiinputActivateDynamicDelegate != null) ? flguiinputActivateDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x0600A08A RID: 41098 RVA: 0x000EDC53 File Offset: 0x000EBE53
		public bool IsInputActive()
		{
			return UUITextInputComponent.__IsInputActive_Internal(base.NativePtr);
		}

		// Token: 0x0600A08B RID: 41099 RVA: 0x000EDC60 File Offset: 0x000EBE60
		[NullableContext(2)]
		public UUIText GetTextComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIText>(UUITextInputComponent.__GetTextComponent_Internal(base.NativePtr));
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x000EDC72 File Offset: 0x000EBE72
		public string GetText()
		{
			return FString.ToStringAndDeleteNativePtr(UUITextInputComponent.__GetText_Internal(base.NativePtr));
		}

		// Token: 0x0600A08D RID: 41101 RVA: 0x000EDC84 File Offset: 0x000EBE84
		public void DeactivateInputText()
		{
			UUITextInputComponent.__DeactivateInputText_Internal(base.NativePtr);
		}

		// Token: 0x0600A08E RID: 41102 RVA: 0x000EDC91 File Offset: 0x000EBE91
		public void ClearCustomInputTypeEvent()
		{
			UUITextInputComponent.__ClearCustomInputTypeEvent_Internal(base.NativePtr);
		}

		// Token: 0x0600A08F RID: 41103 RVA: 0x000EDC9E File Offset: 0x000EBE9E
		public void ActivateInputText()
		{
			UUITextInputComponent.__ActivateInputText_Internal(base.NativePtr);
		}

		// Token: 0x0600A090 RID: 41104
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterValueChangeEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0600A091 RID: 41105
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSubmitEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0600A092 RID: 41106
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterInputActivateEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0600A093 RID: 41107
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetText_Internal(IntPtr @this, in FString InText, bool InFireEvent);

		// Token: 0x0600A094 RID: 41108
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShowKeyboardDelegate_Internal(IntPtr InDelegate);

		// Token: 0x0600A095 RID: 41109
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCustomInputTypeFunction_Internal(IntPtr @this, IntPtr InFunction);

		// Token: 0x0600A096 RID: 41110
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterValueChangeEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0600A097 RID: 41111
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSubmitEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0600A098 RID: 41112
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterInputActivateEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x0600A099 RID: 41113
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInputActive_Internal(IntPtr @this);

		// Token: 0x0600A09A RID: 41114
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTextComponent_Internal(IntPtr @this);

		// Token: 0x0600A09B RID: 41115
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetText_Internal(IntPtr @this);

		// Token: 0x0600A09C RID: 41116
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateInputText_Internal(IntPtr @this);

		// Token: 0x0600A09D RID: 41117
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearCustomInputTypeEvent_Internal(IntPtr @this);

		// Token: 0x0600A09E RID: 41118
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActivateInputText_Internal(IntPtr @this);

		// Token: 0x0600A09F RID: 41119 RVA: 0x000EDCAB File Offset: 0x000EBEAB
		static UUITextInputComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UITextInputComponent");
		}

		// Token: 0x0600A0A0 RID: 41120 RVA: 0x000EDCB9 File Offset: 0x000EBEB9
		protected UUITextInputComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040044A6 RID: 17574
		public new const string __ObjectPath = "/Script/LGUI.UITextInputComponent";

		// Token: 0x040044A7 RID: 17575
		private static IntPtr _ClassPtr;

		// Token: 0x040044A8 RID: 17576
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040044A9 RID: 17577
		internal static int __PropertyOffset_TextActor;

		// Token: 0x040044AA RID: 17578
		internal static int __PropertyOffset_Text;

		// Token: 0x040044AB RID: 17579
		internal static int __PropertyOffset_PasswordChar;

		// Token: 0x040044AC RID: 17580
		internal static int __PropertyOffset_bAllowMultiLine;

		// Token: 0x040044AD RID: 17581
		internal static int __PropertyOffset_PlaceHolderActor;

		// Token: 0x040044AE RID: 17582
		internal static int __PropertyOffset_CaretBlinkRate;

		// Token: 0x040044AF RID: 17583
		internal static int __PropertyOffset_CaretWidth;

		// Token: 0x040044B0 RID: 17584
		internal static int __PropertyOffset_IsShowDefaultText;

		// Token: 0x040044B1 RID: 17585
		internal static int __PropertyOffset_CaretColor;

		// Token: 0x040044B2 RID: 17586
		internal static int __PropertyOffset_SelectionColor;

		// Token: 0x040044B3 RID: 17587
		internal static int __PropertyOffset_IgnoreKeys;

		// Token: 0x040044B4 RID: 17588
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKey> _IgnoreKeys;

		// Token: 0x040044B5 RID: 17589
		internal static int __PropertyOffset_OnCheckTextInputDelegate;

		// Token: 0x040044B6 RID: 17590
		[Nullable(2)]
		private FCheckTextInputDelegate _OnCheckTextInputDelegate;

		// Token: 0x040044B7 RID: 17591
		internal static int __PropertyOffset_MaxInput;

		// Token: 0x040044B8 RID: 17592
		internal static int __PropertyOffset_PlayerController;

		// Token: 0x040044B9 RID: 17593
		internal static int __PropertyOffset_CaretObject;

		// Token: 0x040044BA RID: 17594
		internal static int __PropertyOffset_SelectionMaskObjectArray;

		// Token: 0x040044BB RID: 17595
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUISprite>> _SelectionMaskObjectArray;

		// Token: 0x040044BC RID: 17596
		internal static int __PropertyOffset_OnTextChange;

		// Token: 0x040044BD RID: 17597
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextChange;

		// Token: 0x040044BE RID: 17598
		internal static int __PropertyOffset_OnTextSubmit;

		// Token: 0x040044BF RID: 17599
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextSubmit;

		// Token: 0x040044C0 RID: 17600
		internal static int __PropertyOffset_OnTextClip;

		// Token: 0x040044C1 RID: 17601
		[Nullable(2)]
		private FLGUITextInputDynamicDelegate _OnTextClip;

		// Token: 0x040044C2 RID: 17602
		internal static int __PropertyOffset_OnInputActivateDelegate;

		// Token: 0x040044C3 RID: 17603
		[Nullable(2)]
		private FLGUIInputActivateDynamicDelegate _OnInputActivateDelegate;
	}
}
