using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200213D RID: 8509
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIDropdownComponent")]
	[UnrealStructLayout(1296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1296)]
	public class UUIDropdownComponent : UUISelectableComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020094 RID: 131220 RVA: 0x002FA5C6 File Offset: 0x002F87C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIDropdownComponent._ClassPtr;
		}

		// Token: 0x06020095 RID: 131221 RVA: 0x002FA5D4 File Offset: 0x002F87D4
		public UUIDropdownComponent() : this(BuiltinUtils.AllocNativeUObject(UUIDropdownComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020096 RID: 131222 RVA: 0x002FA5FC File Offset: 0x002F87FC
		public UUIDropdownComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIDropdownComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007DDB RID: 32219
		// (get) Token: 0x06020097 RID: 131223 RVA: 0x002FA62F File Offset: 0x002F882F
		// (set) Token: 0x06020098 RID: 131224 RVA: 0x002FA643 File Offset: 0x002F8843
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

		// Token: 0x17007DDC RID: 32220
		// (get) Token: 0x06020099 RID: 131225 RVA: 0x002FA658 File Offset: 0x002F8858
		// (set) Token: 0x0602009A RID: 131226 RVA: 0x002FA66C File Offset: 0x002F886C
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

		// Token: 0x17007DDD RID: 32221
		// (get) Token: 0x0602009B RID: 131227 RVA: 0x002FA681 File Offset: 0x002F8881
		// (set) Token: 0x0602009C RID: 131228 RVA: 0x002FA695 File Offset: 0x002F8895
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

		// Token: 0x17007DDE RID: 32222
		// (get) Token: 0x0602009D RID: 131229 RVA: 0x002FA6AA File Offset: 0x002F88AA
		// (set) Token: 0x0602009E RID: 131230 RVA: 0x002FA6BE File Offset: 0x002F88BE
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUISpriteActor> CaptionSprite
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_CaptionSprite);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_CaptionSprite) = value;
			}
		}

		// Token: 0x17007DDF RID: 32223
		// (get) Token: 0x0602009F RID: 131231 RVA: 0x002FA6D4 File Offset: 0x002F88D4
		// (set) Token: 0x060200A0 RID: 131232 RVA: 0x002FA70D File Offset: 0x002F890D
		public FLGUIComponentReference ItemTemplate
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._ItemTemplate) == null)
				{
					result = (this._ItemTemplate = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_ItemTemplate, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_ItemTemplate, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007DE0 RID: 32224
		// (get) Token: 0x060200A1 RID: 131233 RVA: 0x002FA72E File Offset: 0x002F892E
		// (set) Token: 0x060200A2 RID: 131234 RVA: 0x002FA73E File Offset: 0x002F893E
		public unsafe EUIDropdownVerticalPosition VerticalPosition
		{
			get
			{
				return (EUIDropdownVerticalPosition)(*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_VerticalPosition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_VerticalPosition) = (byte)value;
			}
		}

		// Token: 0x17007DE1 RID: 32225
		// (get) Token: 0x060200A3 RID: 131235 RVA: 0x002FA74F File Offset: 0x002F894F
		// (set) Token: 0x060200A4 RID: 131236 RVA: 0x002FA75F File Offset: 0x002F895F
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

		// Token: 0x17007DE2 RID: 32226
		// (get) Token: 0x060200A5 RID: 131237 RVA: 0x002FA770 File Offset: 0x002F8970
		// (set) Token: 0x060200A6 RID: 131238 RVA: 0x002FA780 File Offset: 0x002F8980
		public unsafe EUIDropdownHorizontalPosition HorizontalPosition
		{
			get
			{
				return (EUIDropdownHorizontalPosition)(*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_HorizontalPosition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_HorizontalPosition) = (byte)value;
			}
		}

		// Token: 0x17007DE3 RID: 32227
		// (get) Token: 0x060200A7 RID: 131239 RVA: 0x002FA791 File Offset: 0x002F8991
		// (set) Token: 0x060200A8 RID: 131240 RVA: 0x002FA7A1 File Offset: 0x002F89A1
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

		// Token: 0x17007DE4 RID: 32228
		// (get) Token: 0x060200A9 RID: 131241 RVA: 0x002FA7B4 File Offset: 0x002F89B4
		// (set) Token: 0x060200AA RID: 131242 RVA: 0x002FA7ED File Offset: 0x002F89ED
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

		// Token: 0x17007DE5 RID: 32229
		// (get) Token: 0x060200AB RID: 131243 RVA: 0x002FA7FC File Offset: 0x002F89FC
		// (set) Token: 0x060200AC RID: 131244 RVA: 0x002FA835 File Offset: 0x002F8A35
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<UUIDropdownItemComponent>> CreatedItemArray
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
				TArray<TWeakObjectPtr<UUIDropdownItemComponent>> result;
				if ((result = this._CreatedItemArray) == null)
				{
					result = (this._CreatedItemArray = new TArray<TWeakObjectPtr<UUIDropdownItemComponent>>(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_CreatedItemArray, this));
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
				this.CreatedItemArray.CopyAssign(value);
			}
		}

		// Token: 0x17007DE6 RID: 32230
		// (get) Token: 0x060200AD RID: 131245 RVA: 0x002FA844 File Offset: 0x002F8A44
		// (set) Token: 0x060200AE RID: 131246 RVA: 0x002FA87D File Offset: 0x002F8A7D
		public FLGUIDrawableEvent OnSelectionChange
		{
			get
			{
				base.FastCheckIsValid();
				FLGUIDrawableEvent result;
				if ((result = this._OnSelectionChange) == null)
				{
					result = (this._OnSelectionChange = new FLGUIDrawableEvent(base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnSelectionChange, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIDrawableEvent.StaticStruct(), base.NativePtr + (IntPtr)UUIDropdownComponent.__PropertyOffset_OnSelectionChange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007DE7 RID: 32231
		// (get) Token: 0x060200AF RID: 131247 RVA: 0x002FA8A0 File Offset: 0x002F8AA0
		// (set) Token: 0x060200B0 RID: 131248 RVA: 0x002FA8D9 File Offset: 0x002F8AD9
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

		// Token: 0x17007DE8 RID: 32232
		// (get) Token: 0x060200B1 RID: 131249 RVA: 0x002FA8FC File Offset: 0x002F8AFC
		// (set) Token: 0x060200B2 RID: 131250 RVA: 0x002FA935 File Offset: 0x002F8B35
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

		// Token: 0x060200B3 RID: 131251 RVA: 0x002FA956 File Offset: 0x002F8B56
		[NullableContext(2)]
		public void UnregisterSelectionChangeEvent(in FLGUIDelegateHandleWrapper InDelegateHandle)
		{
			UUIDropdownComponent.__UnregisterSelectionChangeEvent_Internal(base.NativePtr, (InDelegateHandle ?? new FLGUIDelegateHandleWrapper()).NativePtr);
		}

		// Token: 0x060200B4 RID: 131252 RVA: 0x002FA973 File Offset: 0x002F8B73
		public void UnbindAllToggleDelegate()
		{
			UUIDropdownComponent.__UnbindAllToggleDelegate_Internal(base.NativePtr);
		}

		// Token: 0x060200B5 RID: 131253 RVA: 0x002FA980 File Offset: 0x002F8B80
		public void Show()
		{
			UUIDropdownComponent.__Show_Internal(base.NativePtr);
		}

		// Token: 0x060200B6 RID: 131254 RVA: 0x002FA98D File Offset: 0x002F8B8D
		public void SetVerticalPosition(EUIDropdownVerticalPosition InValue)
		{
			UUIDropdownComponent.__SetVerticalPosition_Internal(base.NativePtr, InValue);
		}

		// Token: 0x060200B7 RID: 131255 RVA: 0x002FA99B File Offset: 0x002F8B9B
		public void SetVerticalOverlap(bool newValue)
		{
			UUIDropdownComponent.__SetVerticalOverlap_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060200B8 RID: 131256 RVA: 0x002FA9A9 File Offset: 0x002F8BA9
		public void SetValue(int newValue, bool fireEvent = true)
		{
			UUIDropdownComponent.__SetValue_Internal(base.NativePtr, newValue, fireEvent);
		}

		// Token: 0x060200B9 RID: 131257 RVA: 0x002FA9B8 File Offset: 0x002F8BB8
		public void SetOptions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUIDropdownOptionData> InOptions)
		{
			UUIDropdownComponent.__SetOptions_Internal(base.NativePtr, (InOptions ?? new TArray<FUIDropdownOptionData>()).NativePtr);
		}

		// Token: 0x060200BA RID: 131258 RVA: 0x002FA9D5 File Offset: 0x002F8BD5
		public void SetMaxHeight(float newValue)
		{
			UUIDropdownComponent.__SetMaxHeight_Internal(base.NativePtr, newValue);
		}

		// Token: 0x060200BB RID: 131259 RVA: 0x002FA9E3 File Offset: 0x002F8BE3
		public void SetHorizontalPosition(EUIDropdownHorizontalPosition InValue)
		{
			UUIDropdownComponent.__SetHorizontalPosition_Internal(base.NativePtr, InValue);
		}

		// Token: 0x060200BC RID: 131260 RVA: 0x002FA9F1 File Offset: 0x002F8BF1
		public FLGUIDelegateHandleWrapper RegisterSelectionChangeEvent([Nullable(2)] in FUIDropdownComponentDynamicDelegate InDelegate)
		{
			IntPtr nativePtr = base.NativePtr;
			FUIDropdownComponentDynamicDelegate fuidropdownComponentDynamicDelegate = InDelegate;
			return new FLGUIDelegateHandleWrapper(UUIDropdownComponent.__RegisterSelectionChangeEvent_Internal(nativePtr, (fuidropdownComponentDynamicDelegate != null) ? fuidropdownComponentDynamicDelegate.NativePtr : ((IntPtr)0)), null);
		}

		// Token: 0x060200BD RID: 131261 RVA: 0x002FAA13 File Offset: 0x002F8C13
		public void MarkRecreateList()
		{
			UUIDropdownComponent.__MarkRecreateList_Internal(base.NativePtr);
		}

		// Token: 0x060200BE RID: 131262 RVA: 0x002FAA20 File Offset: 0x002F8C20
		public void Hide()
		{
			UUIDropdownComponent.__Hide_Internal(base.NativePtr);
		}

		// Token: 0x060200BF RID: 131263 RVA: 0x002FAA2D File Offset: 0x002F8C2D
		public EUIDropdownVerticalPosition GetVerticalPosition()
		{
			return UUIDropdownComponent.__GetVerticalPosition_Internal(base.NativePtr);
		}

		// Token: 0x060200C0 RID: 131264 RVA: 0x002FAA3A File Offset: 0x002F8C3A
		public bool GetVerticalOverlap()
		{
			return UUIDropdownComponent.__GetVerticalOverlap_Internal(base.NativePtr);
		}

		// Token: 0x060200C1 RID: 131265 RVA: 0x002FAA47 File Offset: 0x002F8C47
		public int GetValue()
		{
			return UUIDropdownComponent.__GetValue_Internal(base.NativePtr);
		}

		// Token: 0x060200C2 RID: 131266 RVA: 0x002FAA54 File Offset: 0x002F8C54
		public TArray<FUIDropdownOptionData> GetOptions()
		{
			return new TArray<FUIDropdownOptionData>(UUIDropdownComponent.__GetOptions_Internal(base.NativePtr), null);
		}

		// Token: 0x060200C3 RID: 131267 RVA: 0x002FAA67 File Offset: 0x002F8C67
		public FUIDropdownOptionData GetOption(int index)
		{
			return new FUIDropdownOptionData(UUIDropdownComponent.__GetOption_Internal(base.NativePtr, index), null);
		}

		// Token: 0x060200C4 RID: 131268 RVA: 0x002FAA7B File Offset: 0x002F8C7B
		public float GetMaxHeight()
		{
			return UUIDropdownComponent.__GetMaxHeight_Internal(base.NativePtr);
		}

		// Token: 0x060200C5 RID: 131269 RVA: 0x002FAA88 File Offset: 0x002F8C88
		public EUIDropdownHorizontalPosition GetHorizontalPosition()
		{
			return UUIDropdownComponent.__GetHorizontalPosition_Internal(base.NativePtr);
		}

		// Token: 0x060200C6 RID: 131270 RVA: 0x002FAA95 File Offset: 0x002F8C95
		public FUIDropdownOptionData GetCurrentOption()
		{
			return new FUIDropdownOptionData(UUIDropdownComponent.__GetCurrentOption_Internal(base.NativePtr), null);
		}

		// Token: 0x060200C7 RID: 131271 RVA: 0x002FAAA8 File Offset: 0x002F8CA8
		public void AddOptions([Nullable(new byte[]
		{
			2,
			1
		})] in TArray<FUIDropdownOptionData> InOptions)
		{
			UUIDropdownComponent.__AddOptions_Internal(base.NativePtr, (InOptions ?? new TArray<FUIDropdownOptionData>()).NativePtr);
		}

		// Token: 0x060200C8 RID: 131272
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnregisterSelectionChangeEvent_Internal(IntPtr @this, IntPtr InDelegateHandle);

		// Token: 0x060200C9 RID: 131273
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnbindAllToggleDelegate_Internal(IntPtr @this);

		// Token: 0x060200CA RID: 131274
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Show_Internal(IntPtr @this);

		// Token: 0x060200CB RID: 131275
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalPosition_Internal(IntPtr @this, EUIDropdownVerticalPosition InValue);

		// Token: 0x060200CC RID: 131276
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalOverlap_Internal(IntPtr @this, bool newValue);

		// Token: 0x060200CD RID: 131277
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValue_Internal(IntPtr @this, int newValue, bool fireEvent);

		// Token: 0x060200CE RID: 131278
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOptions_Internal(IntPtr @this, IntPtr InOptions);

		// Token: 0x060200CF RID: 131279
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxHeight_Internal(IntPtr @this, float newValue);

		// Token: 0x060200D0 RID: 131280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalPosition_Internal(IntPtr @this, EUIDropdownHorizontalPosition InValue);

		// Token: 0x060200D1 RID: 131281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __RegisterSelectionChangeEvent_Internal(IntPtr @this, IntPtr InDelegate);

		// Token: 0x060200D2 RID: 131282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MarkRecreateList_Internal(IntPtr @this);

		// Token: 0x060200D3 RID: 131283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Hide_Internal(IntPtr @this);

		// Token: 0x060200D4 RID: 131284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUIDropdownVerticalPosition __GetVerticalPosition_Internal(IntPtr @this);

		// Token: 0x060200D5 RID: 131285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetVerticalOverlap_Internal(IntPtr @this);

		// Token: 0x060200D6 RID: 131286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetValue_Internal(IntPtr @this);

		// Token: 0x060200D7 RID: 131287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOptions_Internal(IntPtr @this);

		// Token: 0x060200D8 RID: 131288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetOption_Internal(IntPtr @this, int index);

		// Token: 0x060200D9 RID: 131289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetMaxHeight_Internal(IntPtr @this);

		// Token: 0x060200DA RID: 131290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUIDropdownHorizontalPosition __GetHorizontalPosition_Internal(IntPtr @this);

		// Token: 0x060200DB RID: 131291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentOption_Internal(IntPtr @this);

		// Token: 0x060200DC RID: 131292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddOptions_Internal(IntPtr @this, IntPtr InOptions);

		// Token: 0x060200DD RID: 131293 RVA: 0x002FAAC5 File Offset: 0x002F8CC5
		static UUIDropdownComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIDropdownComponent");
		}

		// Token: 0x060200DE RID: 131294 RVA: 0x002FAAD3 File Offset: 0x002F8CD3
		protected UUIDropdownComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011401 RID: 70657
		public new const string __ObjectPath = "/Script/LGUI.UIDropdownComponent";

		// Token: 0x04011402 RID: 70658
		private static IntPtr _ClassPtr;

		// Token: 0x04011403 RID: 70659
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011404 RID: 70660
		internal static int __PropertyOffset_ListRoot;

		// Token: 0x04011405 RID: 70661
		internal static int __PropertyOffset_CaptionText;

		// Token: 0x04011406 RID: 70662
		internal static int __PropertyOffset_SecondCaptionText;

		// Token: 0x04011407 RID: 70663
		internal static int __PropertyOffset_CaptionSprite;

		// Token: 0x04011408 RID: 70664
		internal static int __PropertyOffset_ItemTemplate;

		// Token: 0x04011409 RID: 70665
		[Nullable(2)]
		private FLGUIComponentReference _ItemTemplate;

		// Token: 0x0401140A RID: 70666
		internal static int __PropertyOffset_VerticalPosition;

		// Token: 0x0401140B RID: 70667
		internal static int __PropertyOffset_VerticalOverlap;

		// Token: 0x0401140C RID: 70668
		internal static int __PropertyOffset_HorizontalPosition;

		// Token: 0x0401140D RID: 70669
		internal static int __PropertyOffset_Value;

		// Token: 0x0401140E RID: 70670
		internal static int __PropertyOffset_Options;

		// Token: 0x0401140F RID: 70671
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FUIDropdownOptionData> _Options;

		// Token: 0x04011410 RID: 70672
		internal static int __PropertyOffset_CreatedItemArray;

		// Token: 0x04011411 RID: 70673
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<UUIDropdownItemComponent>> _CreatedItemArray;

		// Token: 0x04011412 RID: 70674
		internal static int __PropertyOffset_OnSelectionChange;

		// Token: 0x04011413 RID: 70675
		[Nullable(2)]
		private FLGUIDrawableEvent _OnSelectionChange;

		// Token: 0x04011414 RID: 70676
		internal static int __PropertyOffset_OnSelectChange;

		// Token: 0x04011415 RID: 70677
		[Nullable(2)]
		private FUIDropdownComponentDynamicDelegate _OnSelectChange;

		// Token: 0x04011416 RID: 70678
		internal static int __PropertyOffset_OnPanelActiveChange;

		// Token: 0x04011417 RID: 70679
		[Nullable(2)]
		private FUIDropdownComponentShowHideDynamicDelegate _OnPanelActiveChange;
	}
}
