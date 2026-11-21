using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006F1 RID: 1777
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDropdownComponent")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class UUIDropdownComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060096FA RID: 38650 RVA: 0x000E3DD5 File Offset: 0x000E1FD5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDropdownComponent._ClassPtr;
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x000E3DE4 File Offset: 0x000E1FE4
		public UUIDropdownComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDropdownComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x000E3E0C File Offset: 0x000E200C
		public UUIDropdownComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDropdownComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001C0D RID: 7181
		// (get) Token: 0x060096FD RID: 38653 RVA: 0x000E3E3F File Offset: 0x000E203F
		// (set) Token: 0x060096FE RID: 38654 RVA: 0x000E3E53 File Offset: 0x000E2053
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> ListRoot
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_ListRoot);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_ListRoot) = value;
			}
		}

		// Token: 0x17001C0E RID: 7182
		// (get) Token: 0x060096FF RID: 38655 RVA: 0x000E3E68 File Offset: 0x000E2068
		// (set) Token: 0x06009700 RID: 38656 RVA: 0x000E3E7C File Offset: 0x000E207C
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUITextActor> CaptionText
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_CaptionText);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_CaptionText) = value;
			}
		}

		// Token: 0x17001C0F RID: 7183
		// (get) Token: 0x06009701 RID: 38657 RVA: 0x000E3E91 File Offset: 0x000E2091
		// (set) Token: 0x06009702 RID: 38658 RVA: 0x000E3EA5 File Offset: 0x000E20A5
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUITextActor> SecondCaptionText
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_SecondCaptionText);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_SecondCaptionText) = value;
			}
		}

		// Token: 0x17001C10 RID: 7184
		// (get) Token: 0x06009703 RID: 38659 RVA: 0x000E3EBA File Offset: 0x000E20BA
		// (set) Token: 0x06009704 RID: 38660 RVA: 0x000E3ECA File Offset: 0x000E20CA
		public unsafe bool VerticalOverlap
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_VerticalOverlap) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_VerticalOverlap) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001C11 RID: 7185
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x000E3EDB File Offset: 0x000E20DB
		// (set) Token: 0x06009706 RID: 38662 RVA: 0x000E3EEB File Offset: 0x000E20EB
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x17001C12 RID: 7186
		// (get) Token: 0x06009707 RID: 38663 RVA: 0x000E3EFC File Offset: 0x000E20FC
		// (set) Token: 0x06009708 RID: 38664 RVA: 0x000E3F35 File Offset: 0x000E2135
		public TArray<FUIDropdownOptionData> Options
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FUIDropdownOptionData> result;
				if ((result = this._Options) == null)
				{
					result = (this._Options = new TArray<FUIDropdownOptionData>(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_Options, this));
				}
				return result;
			}
			set
			{
				this.Options.CopyAssign(value);
			}
		}

		// Token: 0x17001C13 RID: 7187
		// (get) Token: 0x06009709 RID: 38665 RVA: 0x000E3F44 File Offset: 0x000E2144
		// (set) Token: 0x0600970A RID: 38666 RVA: 0x000E3F7D File Offset: 0x000E217D
		public FUIDropdownComponentDynamicDelegate OnSelectChange
		{
			get
			{
				base.FastCheckIsValid();
				FUIDropdownComponentDynamicDelegate result;
				if ((result = this._OnSelectChange) == null)
				{
					result = (this._OnSelectChange = new FUIDropdownComponentDynamicDelegate(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnSelectChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnSelectChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001C14 RID: 7188
		// (get) Token: 0x0600970B RID: 38667 RVA: 0x000E3FA0 File Offset: 0x000E21A0
		// (set) Token: 0x0600970C RID: 38668 RVA: 0x000E3FD9 File Offset: 0x000E21D9
		public FUIDropdownComponentShowHideDynamicDelegate OnPanelActiveChange
		{
			get
			{
				base.FastCheckIsValid();
				FUIDropdownComponentShowHideDynamicDelegate result;
				if ((result = this._OnPanelActiveChange) == null)
				{
					result = (this._OnPanelActiveChange = new FUIDropdownComponentShowHideDynamicDelegate(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnPanelActiveChange, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnPanelActiveChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x000E3FFA File Offset: 0x000E21FA
		[NullableContext(2)]
		public void UnregisterSelectionChangeEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIDropdownComponent.__UnregisterSelectionChangeEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x000E4017 File Offset: 0x000E2217
		public void UnbindAllToggleDelegate()
		{
			UUIDropdownComponent.__UnbindAllToggleDelegate_Internal(base.NativePtr);
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x000E4024 File Offset: 0x000E2224
		public void Show()
		{
			UUIDropdownComponent.__Show_Internal(base.NativePtr);
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x000E4031 File Offset: 0x000E2231
		public void SetVerticalOverlap(bool newValue)
		{
			UUIDropdownComponent.__SetVerticalOverlap_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x000E403F File Offset: 0x000E223F
		public void SetValue(int newValue, bool fireEvent = true)
		{
			UUIDropdownComponent.__SetValue_Internal(base.NativePtr, newValue, fireEvent);
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x000E404E File Offset: 0x000E224E
		public void SetOptions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUIDropdownOptionData> InOptions)
		{
			UUIDropdownComponent.__SetOptions_Internal(base.NativePtr, (InOptions ?? new TArray<FUIDropdownOptionData>()).NativePtr);
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x000E406B File Offset: 0x000E226B
		public void SetMaxHeight(float newValue)
		{
			UUIDropdownComponent.__SetMaxHeight_Internal(base.NativePtr, newValue);
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x000E4079 File Offset: 0x000E2279
		public FLGUIDelegateHandleWrapper RegisterSelectionChangeEvent([Nullable(2)] in FUIDropdownComponentDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FUIDropdownComponentDynamicDelegate fuidropdownComponentDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIDropdownComponent.__RegisterSelectionChangeEvent_Internal(nativePtr, (fuidropdownComponentDynamicDelegate != null) ? fuidropdownComponentDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x000E409B File Offset: 0x000E229B
		public void MarkRecreateList()
		{
			UUIDropdownComponent.__MarkRecreateList_Internal(base.NativePtr);
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x000E40A8 File Offset: 0x000E22A8
		public void Hide()
		{
			UUIDropdownComponent.__Hide_Internal(base.NativePtr);
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x000E40B5 File Offset: 0x000E22B5
		public bool GetVerticalOverlap()
		{
			return UUIDropdownComponent.__GetVerticalOverlap_Internal(base.NativePtr);
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x000E40C2 File Offset: 0x000E22C2
		public int GetValue()
		{
			return UUIDropdownComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x000E40CF File Offset: 0x000E22CF
		public TArray<FUIDropdownOptionData> GetOptions()
		{
			return new TArray<FUIDropdownOptionData>(UUIDropdownComponent.__GetOptions_Internal(base.NativePtr), null);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x000E40E2 File Offset: 0x000E22E2
		public FUIDropdownOptionData GetOption(int index)
		{
			return new FUIDropdownOptionData(UUIDropdownComponent.__GetOption_Internal(base.NativePtr, index), null);
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x000E40F6 File Offset: 0x000E22F6
		public float GetMaxHeight()
		{
			return UUIDropdownComponent.__GetMaxHeight_Internal(base.NativePtr);
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x000E4103 File Offset: 0x000E2303
		public FUIDropdownOptionData GetCurrentOption()
		{
			return new FUIDropdownOptionData(UUIDropdownComponent.__GetCurrentOption_Internal(base.NativePtr), null);
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x000E4116 File Offset: 0x000E2316
		public void AddOptions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUIDropdownOptionData> InOptions)
		{
			UUIDropdownComponent.__AddOptions_Internal(base.NativePtr, (InOptions ?? new TArray<FUIDropdownOptionData>()).NativePtr);
		}

		// Token: 0x0600971E RID: 38686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSelectionChangeEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x0600971F RID: 38687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindAllToggleDelegate_Internal(IntPtr @this);

		// Token: 0x06009720 RID: 38688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Show_Internal(IntPtr @this);

		// Token: 0x06009721 RID: 38689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalOverlap_Internal(IntPtr @this, bool newValue);

		// Token: 0x06009722 RID: 38690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, int newValue, bool fireEvent);

		// Token: 0x06009723 RID: 38691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOptions_Internal(IntPtr @this, IntPtr InOptions);

		// Token: 0x06009724 RID: 38692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxHeight_Internal(IntPtr @this, float newValue);

		// Token: 0x06009725 RID: 38693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSelectionChangeEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x06009726 RID: 38694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRecreateList_Internal(IntPtr @this);

		// Token: 0x06009727 RID: 38695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Hide_Internal(IntPtr @this);

		// Token: 0x06009728 RID: 38696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVerticalOverlap_Internal(IntPtr @this);

		// Token: 0x06009729 RID: 38697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetValue_Internal(IntPtr @this);

		// Token: 0x0600972A RID: 38698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOptions_Internal(IntPtr @this);

		// Token: 0x0600972B RID: 38699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOption_Internal(IntPtr @this, int index);

		// Token: 0x0600972C RID: 38700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxHeight_Internal(IntPtr @this);

		// Token: 0x0600972D RID: 38701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentOption_Internal(IntPtr @this);

		// Token: 0x0600972E RID: 38702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOptions_Internal(IntPtr @this, IntPtr InOptions);

		// Token: 0x0600972F RID: 38703 RVA: 0x000E4133 File Offset: 0x000E2333
		static UUIDropdownComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDropdownComponent");
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x000E4141 File Offset: 0x000E2341
		protected UUIDropdownComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040041BC RID: 16828
		public new const string __ObjectPath = "/Script/LGUI.UIDropdownComponent";

		// Token: 0x040041BD RID: 16829
		private static IntPtr _ClassPtr;

		// Token: 0x040041BE RID: 16830
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040041BF RID: 16831
		internal static int __PropertyOffset_ListRoot;

		// Token: 0x040041C0 RID: 16832
		internal static int __PropertyOffset_CaptionText;

		// Token: 0x040041C1 RID: 16833
		internal static int __PropertyOffset_SecondCaptionText;

		// Token: 0x040041C2 RID: 16834
		internal static int __PropertyOffset_VerticalOverlap;

		// Token: 0x040041C3 RID: 16835
		internal static int __PropertyOffset_Value;

		// Token: 0x040041C4 RID: 16836
		internal static int __PropertyOffset_Options;

		// Token: 0x040041C5 RID: 16837
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FUIDropdownOptionData> _Options;

		// Token: 0x040041C6 RID: 16838
		internal static int __PropertyOffset_OnSelectChange;

		// Token: 0x040041C7 RID: 16839
		[Nullable(2)]
		private FUIDropdownComponentDynamicDelegate _OnSelectChange;

		// Token: 0x040041C8 RID: 16840
		internal static int __PropertyOffset_OnPanelActiveChange;

		// Token: 0x040041C9 RID: 16841
		[Nullable(2)]
		private FUIDropdownComponentShowHideDynamicDelegate _OnPanelActiveChange;
	}
}
