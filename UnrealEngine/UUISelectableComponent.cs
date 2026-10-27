using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A9 RID: 8617
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISelectableComponent")]
	[UnrealStructLayout(1032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1032)]
	public class UUISelectableComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject, ILGUIPointerEnterExitInterface, IUnrealNativeInterface, IUnrealInterface, ILGUIPointerDownUpInterface, ILGUIPointerSelectDeselectInterface, ILGUIPointerClickInterface
	{
		// Token: 0x06020B77 RID: 134007 RVA: 0x003062AC File Offset: 0x003044AC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableComponent._ClassPtr;
		}

		// Token: 0x06020B78 RID: 134008 RVA: 0x003062B8 File Offset: 0x003044B8
		int ILGUIPointerEnterExitInterface.InterfaceOffset()
		{
			return UUISelectableComponent.__InterfaceOffset_ILGUIPointerEnterExitInterface;
		}

		// Token: 0x06020B79 RID: 134009 RVA: 0x003062BF File Offset: 0x003044BF
		int ILGUIPointerDownUpInterface.InterfaceOffset()
		{
			return UUISelectableComponent.__InterfaceOffset_ILGUIPointerDownUpInterface;
		}

		// Token: 0x06020B7A RID: 134010 RVA: 0x003062C6 File Offset: 0x003044C6
		int ILGUIPointerSelectDeselectInterface.InterfaceOffset()
		{
			return UUISelectableComponent.__InterfaceOffset_ILGUIPointerSelectDeselectInterface;
		}

		// Token: 0x06020B7B RID: 134011 RVA: 0x003062CD File Offset: 0x003044CD
		int ILGUIPointerClickInterface.InterfaceOffset()
		{
			return UUISelectableComponent.__InterfaceOffset_ILGUIPointerClickInterface;
		}

		// Token: 0x06020B7C RID: 134012 RVA: 0x003062D4 File Offset: 0x003044D4
		public UUISelectableComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B7D RID: 134013 RVA: 0x003062FC File Offset: 0x003044FC
		[NullableContext(1)]
		public UUISelectableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FD2 RID: 32722
		// (get) Token: 0x06020B7E RID: 134014 RVA: 0x0030632F File Offset: 0x0030452F
		// (set) Token: 0x06020B7F RID: 134015 RVA: 0x00306343 File Offset: 0x00304543
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> TransitionActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_TransitionActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_TransitionActor) = value;
			}
		}

		// Token: 0x17007FD3 RID: 32723
		// (get) Token: 0x06020B80 RID: 134016 RVA: 0x00306358 File Offset: 0x00304558
		// (set) Token: 0x06020B81 RID: 134017 RVA: 0x00306368 File Offset: 0x00304568
		public unsafe bool AllowEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_AllowEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_AllowEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FD4 RID: 32724
		// (get) Token: 0x06020B82 RID: 134018 RVA: 0x00306379 File Offset: 0x00304579
		// (set) Token: 0x06020B83 RID: 134019 RVA: 0x00306389 File Offset: 0x00304589
		public unsafe UISelectableTransitionType Transition
		{
			get
			{
				return (UISelectableTransitionType)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_Transition));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_Transition) = (byte)value;
			}
		}

		// Token: 0x17007FD5 RID: 32725
		// (get) Token: 0x06020B84 RID: 134020 RVA: 0x0030639A File Offset: 0x0030459A
		// (set) Token: 0x06020B85 RID: 134021 RVA: 0x003063AE File Offset: 0x003045AE
		public unsafe ULTweener TransitionTweener
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULTweener>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_TransitionTweener);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_TransitionTweener, value);
			}
		}

		// Token: 0x17007FD6 RID: 32726
		// (get) Token: 0x06020B86 RID: 134022 RVA: 0x003063C3 File Offset: 0x003045C3
		// (set) Token: 0x06020B87 RID: 134023 RVA: 0x003063D7 File Offset: 0x003045D7
		public unsafe FColor NormalColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NormalColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NormalColor) = value;
			}
		}

		// Token: 0x17007FD7 RID: 32727
		// (get) Token: 0x06020B88 RID: 134024 RVA: 0x003063EC File Offset: 0x003045EC
		// (set) Token: 0x06020B89 RID: 134025 RVA: 0x00306400 File Offset: 0x00304600
		public unsafe FColor HighlightedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_HighlightedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_HighlightedColor) = value;
			}
		}

		// Token: 0x17007FD8 RID: 32728
		// (get) Token: 0x06020B8A RID: 134026 RVA: 0x00306415 File Offset: 0x00304615
		// (set) Token: 0x06020B8B RID: 134027 RVA: 0x00306429 File Offset: 0x00304629
		public unsafe FColor PressedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_PressedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_PressedColor) = value;
			}
		}

		// Token: 0x17007FD9 RID: 32729
		// (get) Token: 0x06020B8C RID: 134028 RVA: 0x0030643E File Offset: 0x0030463E
		// (set) Token: 0x06020B8D RID: 134029 RVA: 0x00306452 File Offset: 0x00304652
		public unsafe FColor DisabledColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_DisabledColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_DisabledColor) = value;
			}
		}

		// Token: 0x17007FDA RID: 32730
		// (get) Token: 0x06020B8E RID: 134030 RVA: 0x00306467 File Offset: 0x00304667
		// (set) Token: 0x06020B8F RID: 134031 RVA: 0x0030647B File Offset: 0x0030467B
		public unsafe FColor SelectedColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_SelectedColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_SelectedColor) = value;
			}
		}

		// Token: 0x17007FDB RID: 32731
		// (get) Token: 0x06020B90 RID: 134032 RVA: 0x00306490 File Offset: 0x00304690
		// (set) Token: 0x06020B91 RID: 134033 RVA: 0x003064A0 File Offset: 0x003046A0
		public unsafe float FadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_FadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_FadeDuration) = value;
			}
		}

		// Token: 0x17007FDC RID: 32732
		// (get) Token: 0x06020B92 RID: 134034 RVA: 0x003064B1 File Offset: 0x003046B1
		// (set) Token: 0x06020B93 RID: 134035 RVA: 0x003064C5 File Offset: 0x003046C5
		public unsafe ULGUISpriteData_BaseObject NormalSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_NormalSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_NormalSprite, value);
			}
		}

		// Token: 0x17007FDD RID: 32733
		// (get) Token: 0x06020B94 RID: 134036 RVA: 0x003064DA File Offset: 0x003046DA
		// (set) Token: 0x06020B95 RID: 134037 RVA: 0x003064EE File Offset: 0x003046EE
		public unsafe ULGUISpriteData_BaseObject HighlightedSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_HighlightedSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_HighlightedSprite, value);
			}
		}

		// Token: 0x17007FDE RID: 32734
		// (get) Token: 0x06020B96 RID: 134038 RVA: 0x00306503 File Offset: 0x00304703
		// (set) Token: 0x06020B97 RID: 134039 RVA: 0x00306517 File Offset: 0x00304717
		public unsafe ULGUISpriteData_BaseObject PressedSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_PressedSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_PressedSprite, value);
			}
		}

		// Token: 0x17007FDF RID: 32735
		// (get) Token: 0x06020B98 RID: 134040 RVA: 0x0030652C File Offset: 0x0030472C
		// (set) Token: 0x06020B99 RID: 134041 RVA: 0x00306540 File Offset: 0x00304740
		public unsafe ULGUISpriteData_BaseObject DisabledSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_DisabledSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_DisabledSprite, value);
			}
		}

		// Token: 0x17007FE0 RID: 32736
		// (get) Token: 0x06020B9A RID: 134042 RVA: 0x00306555 File Offset: 0x00304755
		// (set) Token: 0x06020B9B RID: 134043 RVA: 0x00306569 File Offset: 0x00304769
		public unsafe ULGUISpriteData_BaseObject SelectedSprite
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULGUISpriteData_BaseObject>(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_SelectedSprite);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UUISelectableComponent.__PropertyOffset_SelectedSprite, value);
			}
		}

		// Token: 0x17007FE1 RID: 32737
		// (get) Token: 0x06020B9C RID: 134044 RVA: 0x0030657E File Offset: 0x0030477E
		// (set) Token: 0x06020B9D RID: 134045 RVA: 0x00306592 File Offset: 0x00304792
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> NormalItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NormalItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NormalItem) = value;
			}
		}

		// Token: 0x17007FE2 RID: 32738
		// (get) Token: 0x06020B9E RID: 134046 RVA: 0x003065A7 File Offset: 0x003047A7
		// (set) Token: 0x06020B9F RID: 134047 RVA: 0x003065BB File Offset: 0x003047BB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> HighlightedItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_HighlightedItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_HighlightedItem) = value;
			}
		}

		// Token: 0x17007FE3 RID: 32739
		// (get) Token: 0x06020BA0 RID: 134048 RVA: 0x003065D0 File Offset: 0x003047D0
		// (set) Token: 0x06020BA1 RID: 134049 RVA: 0x003065E4 File Offset: 0x003047E4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> PressedItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_PressedItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_PressedItem) = value;
			}
		}

		// Token: 0x17007FE4 RID: 32740
		// (get) Token: 0x06020BA2 RID: 134050 RVA: 0x003065F9 File Offset: 0x003047F9
		// (set) Token: 0x06020BA3 RID: 134051 RVA: 0x0030660D File Offset: 0x0030480D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> DisabledItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_DisabledItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_DisabledItem) = value;
			}
		}

		// Token: 0x17007FE5 RID: 32741
		// (get) Token: 0x06020BA4 RID: 134052 RVA: 0x00306622 File Offset: 0x00304822
		// (set) Token: 0x06020BA5 RID: 134053 RVA: 0x00306636 File Offset: 0x00304836
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> SelectedItem
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_SelectedItem);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_SelectedItem) = value;
			}
		}

		// Token: 0x17007FE6 RID: 32742
		// (get) Token: 0x06020BA6 RID: 134054 RVA: 0x0030664B File Offset: 0x0030484B
		// (set) Token: 0x06020BA7 RID: 134055 RVA: 0x0030665B File Offset: 0x0030485B
		public unsafe EUISelectableSelectionState CurrentSelectionState
		{
			get
			{
				return (EUISelectableSelectionState)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_CurrentSelectionState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_CurrentSelectionState) = (byte)value;
			}
		}

		// Token: 0x17007FE7 RID: 32743
		// (get) Token: 0x06020BA8 RID: 134056 RVA: 0x0030666C File Offset: 0x0030486C
		// (set) Token: 0x06020BA9 RID: 134057 RVA: 0x0030667C File Offset: 0x0030487C
		public unsafe bool bApplyColorToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bApplyColorToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bApplyColorToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FE8 RID: 32744
		// (get) Token: 0x06020BAA RID: 134058 RVA: 0x0030668D File Offset: 0x0030488D
		// (set) Token: 0x06020BAB RID: 134059 RVA: 0x0030669D File Offset: 0x0030489D
		public unsafe bool bAutoScrollOnSelected
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bAutoScrollOnSelected) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bAutoScrollOnSelected) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007FE9 RID: 32745
		// (get) Token: 0x06020BAC RID: 134060 RVA: 0x003066AE File Offset: 0x003048AE
		// (set) Token: 0x06020BAD RID: 134061 RVA: 0x003066C2 File Offset: 0x003048C2
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> NavigationGroupParentComponentActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupParentComponentActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupParentComponentActor) = value;
			}
		}

		// Token: 0x17007FEA RID: 32746
		// (get) Token: 0x06020BAE RID: 134062 RVA: 0x003066D7 File Offset: 0x003048D7
		// (set) Token: 0x06020BAF RID: 134063 RVA: 0x003066EB File Offset: 0x003048EB
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableComponent> NavigationGroupParentComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupParentComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupParentComponent) = value;
			}
		}

		// Token: 0x17007FEB RID: 32747
		// (get) Token: 0x06020BB0 RID: 134064 RVA: 0x00306700 File Offset: 0x00304900
		// (set) Token: 0x06020BB1 RID: 134065 RVA: 0x00306714 File Offset: 0x00304914
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> NavigationGroupComponentActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupComponentActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupComponentActor) = value;
			}
		}

		// Token: 0x17007FEC RID: 32748
		// (get) Token: 0x06020BB2 RID: 134066 RVA: 0x00306729 File Offset: 0x00304929
		// (set) Token: 0x06020BB3 RID: 134067 RVA: 0x0030673D File Offset: 0x0030493D
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUINavigationGroupComponent> NavigationGroupComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationGroupComponent) = value;
			}
		}

		// Token: 0x17007FED RID: 32749
		// (get) Token: 0x06020BB4 RID: 134068 RVA: 0x00306752 File Offset: 0x00304952
		// (set) Token: 0x06020BB5 RID: 134069 RVA: 0x00306766 File Offset: 0x00304966
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AActor> ScrollViewActor
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_ScrollViewActor);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_ScrollViewActor) = value;
			}
		}

		// Token: 0x17007FEE RID: 32750
		// (get) Token: 0x06020BB6 RID: 134070 RVA: 0x0030677B File Offset: 0x0030497B
		// (set) Token: 0x06020BB7 RID: 134071 RVA: 0x0030678F File Offset: 0x0030498F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIScrollViewWithScrollbarComponent> ScrollViewComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_ScrollViewComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_ScrollViewComponent) = value;
			}
		}

		// Token: 0x17007FEF RID: 32751
		// (get) Token: 0x06020BB8 RID: 134072 RVA: 0x003067A4 File Offset: 0x003049A4
		// (set) Token: 0x06020BB9 RID: 134073 RVA: 0x003067B8 File Offset: 0x003049B8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUISelectableTransitionComponent> TransitionComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_TransitionComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_TransitionComp) = value;
			}
		}

		// Token: 0x17007FF0 RID: 32752
		// (get) Token: 0x06020BBA RID: 134074 RVA: 0x003067CD File Offset: 0x003049CD
		// (set) Token: 0x06020BBB RID: 134075 RVA: 0x003067DD File Offset: 0x003049DD
		public unsafe EUISelectableNavigationMode NavigationLeft
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationLeft));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationLeft) = (byte)value;
			}
		}

		// Token: 0x17007FF1 RID: 32753
		// (get) Token: 0x06020BBC RID: 134076 RVA: 0x003067F0 File Offset: 0x003049F0
		// (set) Token: 0x06020BBD RID: 134077 RVA: 0x00306829 File Offset: 0x00304A29
		[Nullable(1)]
		public FLGUIComponentReference NavigationLeftSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationLeftSpecific) == null)
				{
					result = (this._NavigationLeftSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationLeftSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationLeftSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FF2 RID: 32754
		// (get) Token: 0x06020BBE RID: 134078 RVA: 0x0030684A File Offset: 0x00304A4A
		// (set) Token: 0x06020BBF RID: 134079 RVA: 0x0030685A File Offset: 0x00304A5A
		public unsafe EUISelectableNavigationMode NavigationRight
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationRight));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationRight) = (byte)value;
			}
		}

		// Token: 0x17007FF3 RID: 32755
		// (get) Token: 0x06020BC0 RID: 134080 RVA: 0x0030686C File Offset: 0x00304A6C
		// (set) Token: 0x06020BC1 RID: 134081 RVA: 0x003068A5 File Offset: 0x00304AA5
		[Nullable(1)]
		public FLGUIComponentReference NavigationRightSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationRightSpecific) == null)
				{
					result = (this._NavigationRightSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationRightSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationRightSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FF4 RID: 32756
		// (get) Token: 0x06020BC2 RID: 134082 RVA: 0x003068C6 File Offset: 0x00304AC6
		// (set) Token: 0x06020BC3 RID: 134083 RVA: 0x003068D6 File Offset: 0x00304AD6
		public unsafe EUISelectableNavigationMode NavigationUp
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationUp));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationUp) = (byte)value;
			}
		}

		// Token: 0x17007FF5 RID: 32757
		// (get) Token: 0x06020BC4 RID: 134084 RVA: 0x003068E8 File Offset: 0x00304AE8
		// (set) Token: 0x06020BC5 RID: 134085 RVA: 0x00306921 File Offset: 0x00304B21
		[Nullable(1)]
		public FLGUIComponentReference NavigationUpSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationUpSpecific) == null)
				{
					result = (this._NavigationUpSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationUpSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationUpSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FF6 RID: 32758
		// (get) Token: 0x06020BC6 RID: 134086 RVA: 0x00306942 File Offset: 0x00304B42
		// (set) Token: 0x06020BC7 RID: 134087 RVA: 0x00306952 File Offset: 0x00304B52
		public unsafe EUISelectableNavigationMode NavigationDown
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationDown));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationDown) = (byte)value;
			}
		}

		// Token: 0x17007FF7 RID: 32759
		// (get) Token: 0x06020BC8 RID: 134088 RVA: 0x00306964 File Offset: 0x00304B64
		// (set) Token: 0x06020BC9 RID: 134089 RVA: 0x0030699D File Offset: 0x00304B9D
		[Nullable(1)]
		public FLGUIComponentReference NavigationDownSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationDownSpecific) == null)
				{
					result = (this._NavigationDownSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationDownSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationDownSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FF8 RID: 32760
		// (get) Token: 0x06020BCA RID: 134090 RVA: 0x003069BE File Offset: 0x00304BBE
		// (set) Token: 0x06020BCB RID: 134091 RVA: 0x003069CE File Offset: 0x00304BCE
		public unsafe EUISelectableNavigationMode NavigationNext
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationNext));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationNext) = (byte)value;
			}
		}

		// Token: 0x17007FF9 RID: 32761
		// (get) Token: 0x06020BCC RID: 134092 RVA: 0x003069E0 File Offset: 0x00304BE0
		// (set) Token: 0x06020BCD RID: 134093 RVA: 0x00306A19 File Offset: 0x00304C19
		[Nullable(1)]
		public FLGUIComponentReference NavigationNextSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationNextSpecific) == null)
				{
					result = (this._NavigationNextSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationNextSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationNextSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FFA RID: 32762
		// (get) Token: 0x06020BCE RID: 134094 RVA: 0x00306A3A File Offset: 0x00304C3A
		// (set) Token: 0x06020BCF RID: 134095 RVA: 0x00306A4A File Offset: 0x00304C4A
		public unsafe EUISelectableNavigationMode NavigationPrev
		{
			get
			{
				return (EUISelectableNavigationMode)(*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationPrev));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationPrev) = (byte)value;
			}
		}

		// Token: 0x17007FFB RID: 32763
		// (get) Token: 0x06020BD0 RID: 134096 RVA: 0x00306A5C File Offset: 0x00304C5C
		// (set) Token: 0x06020BD1 RID: 134097 RVA: 0x00306A95 File Offset: 0x00304C95
		[Nullable(1)]
		public FLGUIComponentReference NavigationPrevSpecific
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIComponentReference result;
				if ((result = this._NavigationPrevSpecific) == null)
				{
					result = (this._NavigationPrevSpecific = new FLGUIComponentReference(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationPrevSpecific, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLGUIComponentReference.StaticStruct(), base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_NavigationPrevSpecific, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007FFC RID: 32764
		// (get) Token: 0x06020BD2 RID: 134098 RVA: 0x00306AB8 File Offset: 0x00304CB8
		// (set) Token: 0x06020BD3 RID: 134099 RVA: 0x00306AF1 File Offset: 0x00304CF1
		[Nullable(1)]
		public TMap<EStateTransferType, FAnimationPlayInfo> AnimationConfig
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TMap<EStateTransferType, FAnimationPlayInfo> result;
				if ((result = this._AnimationConfig) == null)
				{
					result = (this._AnimationConfig = new TMap<EStateTransferType, FAnimationPlayInfo>(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_AnimationConfig, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AnimationConfig.CopyAssign(value);
			}
		}

		// Token: 0x17007FFD RID: 32765
		// (get) Token: 0x06020BD4 RID: 134100 RVA: 0x00306B00 File Offset: 0x00304D00
		// (set) Token: 0x06020BD5 RID: 134101 RVA: 0x00306B39 File Offset: 0x00304D39
		[Nullable(1)]
		public TArray<ULevelSequence> AllAnims
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<ULevelSequence> result;
				if ((result = this._AllAnims) == null)
				{
					result = (this._AllAnims = new TArray<ULevelSequence>(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_AllAnims, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.AllAnims.CopyAssign(value);
			}
		}

		// Token: 0x17007FFE RID: 32766
		// (get) Token: 0x06020BD6 RID: 134102 RVA: 0x00306B48 File Offset: 0x00304D48
		// (set) Token: 0x06020BD7 RID: 134103 RVA: 0x00306B81 File Offset: 0x00304D81
		[Nullable(1)]
		public FLGUISelfInteractiveDelegate OnSelfInteractiveChanged
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUISelfInteractiveDelegate result;
				if ((result = this._OnSelfInteractiveChanged) == null)
				{
					result = (this._OnSelfInteractiveChanged = new FLGUISelfInteractiveDelegate(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_OnSelfInteractiveChanged, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_OnSelfInteractiveChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007FFF RID: 32767
		// (get) Token: 0x06020BD8 RID: 134104 RVA: 0x00306BA2 File Offset: 0x00304DA2
		// (set) Token: 0x06020BD9 RID: 134105 RVA: 0x00306BB2 File Offset: 0x00304DB2
		public unsafe bool IsSelfInteractive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_IsSelfInteractive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_IsSelfInteractive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008000 RID: 32768
		// (get) Token: 0x06020BDA RID: 134106 RVA: 0x00306BC3 File Offset: 0x00304DC3
		// (set) Token: 0x06020BDB RID: 134107 RVA: 0x00306BD3 File Offset: 0x00304DD3
		public unsafe bool bCanClickWhenDisable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bCanClickWhenDisable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_bCanClickWhenDisable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008001 RID: 32769
		// (get) Token: 0x06020BDC RID: 134108 RVA: 0x00306BE4 File Offset: 0x00304DE4
		// (set) Token: 0x06020BDD RID: 134109 RVA: 0x00306C1D File Offset: 0x00304E1D
		[Nullable(1)]
		public FLGUIFocusListenerDelegate FocusListenerDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIFocusListenerDelegate result;
				if ((result = this._FocusListenerDelegate) == null)
				{
					result = (this._FocusListenerDelegate = new FLGUIFocusListenerDelegate(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_FocusListenerDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_FocusListenerDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008002 RID: 32770
		// (get) Token: 0x06020BDE RID: 134110 RVA: 0x00306C40 File Offset: 0x00304E40
		// (set) Token: 0x06020BDF RID: 134111 RVA: 0x00306C79 File Offset: 0x00304E79
		[Nullable(1)]
		public FLGUIUnFocusListenerDelegate UnFocusListenerDelegate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIUnFocusListenerDelegate result;
				if ((result = this._UnFocusListenerDelegate) == null)
				{
					result = (this._UnFocusListenerDelegate = new FLGUIUnFocusListenerDelegate(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_UnFocusListenerDelegate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UUISelectableComponent.__PropertyOffset_UnFocusListenerDelegate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x06020BE0 RID: 134112 RVA: 0x00306C9A File Offset: 0x00304E9A
		public void SetTransitionTarget(AUIBaseActor value)
		{
			UUISelectableComponent.__SetTransitionTarget_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BE1 RID: 134113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShieldPCPress(bool Value);

		// Token: 0x06020BE2 RID: 134114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShieldMobileHighlight(bool Value);

		// Token: 0x06020BE3 RID: 134115 RVA: 0x00306CB7 File Offset: 0x00304EB7
		public void SetSelfInteractive(bool InteractiveEnable)
		{
			UUISelectableComponent.__SetSelfInteractive_Internal(base.NativePtr, InteractiveEnable);
		}

		// Token: 0x06020BE4 RID: 134116 RVA: 0x00306CC5 File Offset: 0x00304EC5
		public void SetSelectionState(EUISelectableSelectionState NewState)
		{
			UUISelectableComponent.__SetSelectionState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x06020BE5 RID: 134117 RVA: 0x00306CD3 File Offset: 0x00304ED3
		public static void SetSelectableDelegate(in FLGUISelectableDelegate Delegate)
		{
			FLGUISelectableDelegate flguiselectableDelegate = Delegate;
			UUISelectableComponent.__SetSelectableDelegate_Internal((flguiselectableDelegate != null) ? flguiselectableDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06020BE6 RID: 134118 RVA: 0x00306CE9 File Offset: 0x00304EE9
		public void SetScrollView(UUIScrollViewWithScrollbarComponent Component)
		{
			UUISelectableComponent.__SetScrollView_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BE7 RID: 134119 RVA: 0x00306D06 File Offset: 0x00304F06
		public void SetPressedSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetPressedSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BE8 RID: 134120 RVA: 0x00306D23 File Offset: 0x00304F23
		public void SetPressedColor(FColor NewColor)
		{
			UUISelectableComponent.__SetPressedColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06020BE9 RID: 134121 RVA: 0x00306D31 File Offset: 0x00304F31
		public void SetNormalSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetNormalSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BEA RID: 134122 RVA: 0x00306D4E File Offset: 0x00304F4E
		public void SetNormalColor(FColor NewColor)
		{
			UUISelectableComponent.__SetNormalColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06020BEB RID: 134123 RVA: 0x00306D5C File Offset: 0x00304F5C
		public void SetNavigationUpExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationUpExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BEC RID: 134124 RVA: 0x00306D79 File Offset: 0x00304F79
		public void SetNavigationUp(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationUp_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BED RID: 134125 RVA: 0x00306D87 File Offset: 0x00304F87
		public void SetNavigationRightExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationRightExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BEE RID: 134126 RVA: 0x00306DA4 File Offset: 0x00304FA4
		public void SetNavigationRight(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationRight_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BEF RID: 134127 RVA: 0x00306DB2 File Offset: 0x00304FB2
		public void SetNavigationPrevExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationPrevExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF0 RID: 134128 RVA: 0x00306DCF File Offset: 0x00304FCF
		public void SetNavigationPrev(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationPrev_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BF1 RID: 134129 RVA: 0x00306DDD File Offset: 0x00304FDD
		public void SetNavigationNextExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationNextExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF2 RID: 134130 RVA: 0x00306DFA File Offset: 0x00304FFA
		public void SetNavigationNext(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationNext_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BF3 RID: 134131 RVA: 0x00306E08 File Offset: 0x00305008
		public void SetNavigationLeftExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationLeftExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF4 RID: 134132 RVA: 0x00306E25 File Offset: 0x00305025
		public void SetNavigationLeft(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationLeft_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BF5 RID: 134133 RVA: 0x00306E33 File Offset: 0x00305033
		public void SetNavigationGroupParent(UUISelectableComponent Component)
		{
			UUISelectableComponent.__SetNavigationGroupParent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF6 RID: 134134 RVA: 0x00306E50 File Offset: 0x00305050
		public void SetNavigationGroup(UUINavigationGroupComponent Component)
		{
			UUISelectableComponent.__SetNavigationGroup_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF7 RID: 134135 RVA: 0x00306E6D File Offset: 0x0030506D
		public void SetNavigationDownExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationDownExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BF8 RID: 134136 RVA: 0x00306E8A File Offset: 0x0030508A
		public void SetNavigationDown(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationDown_Internal(base.NativePtr, value);
		}

		// Token: 0x06020BF9 RID: 134137 RVA: 0x00306E98 File Offset: 0x00305098
		public void SetIsCustomTransition(bool bIsCustomTransition)
		{
			UUISelectableComponent.__SetIsCustomTransition_Internal(base.NativePtr, bIsCustomTransition);
		}

		// Token: 0x06020BFA RID: 134138 RVA: 0x00306EA6 File Offset: 0x003050A6
		public void SetIsCustomAnim(bool bIsCustomAnim)
		{
			UUISelectableComponent.__SetIsCustomAnim_Internal(base.NativePtr, bIsCustomAnim);
		}

		// Token: 0x06020BFB RID: 134139 RVA: 0x00306EB4 File Offset: 0x003050B4
		public void SetHighlightedSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetHighlightedSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020BFC RID: 134140 RVA: 0x00306ED1 File Offset: 0x003050D1
		public void SetHighlightedColor(FColor NewColor)
		{
			UUISelectableComponent.__SetHighlightedColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06020BFD RID: 134141 RVA: 0x00306EDF File Offset: 0x003050DF
		public void SetCanClickWhenDisable(bool CanClickEnbale)
		{
			UUISelectableComponent.__SetCanClickWhenDisable_Internal(base.NativePtr, CanClickEnbale);
		}

		// Token: 0x06020BFE RID: 134142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetSelectableDelegate();

		// Token: 0x06020BFF RID: 134143 RVA: 0x00306EED File Offset: 0x003050ED
		public void PlayUIAnimationByPlayInfo(FAnimationPlayInfo PlayInfo)
		{
			UUISelectableComponent.__PlayUIAnimationByPlayInfo_Internal(base.NativePtr, (PlayInfo ?? new FAnimationPlayInfo()).NativePtr);
		}

		// Token: 0x06020C00 RID: 134144 RVA: 0x00306F09 File Offset: 0x00305109
		public void NotifyUnFocusListener()
		{
			UUISelectableComponent.__NotifyUnFocusListener_Internal(base.NativePtr);
		}

		// Token: 0x06020C01 RID: 134145 RVA: 0x00306F16 File Offset: 0x00305116
		public void NotifyFocusListener()
		{
			UUISelectableComponent.__NotifyFocusListener_Internal(base.NativePtr);
		}

		// Token: 0x06020C02 RID: 134146 RVA: 0x00306F23 File Offset: 0x00305123
		public bool IsInteractable()
		{
			return UUISelectableComponent.__IsInteractable_Internal(base.NativePtr);
		}

		// Token: 0x06020C03 RID: 134147 RVA: 0x00306F30 File Offset: 0x00305130
		public AUIBaseActor GetTransitionTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUISelectableComponent.__GetTransitionTarget_Internal(base.NativePtr));
		}

		// Token: 0x06020C04 RID: 134148 RVA: 0x00306F42 File Offset: 0x00305142
		public bool GetSelfInteractive()
		{
			return UUISelectableComponent.__GetSelfInteractive_Internal(base.NativePtr);
		}

		// Token: 0x06020C05 RID: 134149 RVA: 0x00306F4F File Offset: 0x0030514F
		public EUISelectableSelectionState GetSelectionState()
		{
			return UUISelectableComponent.__GetSelectionState_Internal(base.NativePtr);
		}

		// Token: 0x06020C06 RID: 134150 RVA: 0x00306F5C File Offset: 0x0030515C
		public ULGUISpriteData_BaseObject GetSelectedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetSelectedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020C07 RID: 134151 RVA: 0x00306F6E File Offset: 0x0030516E
		public ULGUISpriteData_BaseObject GetPressedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetPressedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020C08 RID: 134152 RVA: 0x00306F80 File Offset: 0x00305180
		public FColor GetPressedColor()
		{
			return UUISelectableComponent.__GetPressedColor_Internal(base.NativePtr);
		}

		// Token: 0x06020C09 RID: 134153 RVA: 0x00306F8D File Offset: 0x0030518D
		public ULGUISpriteData_BaseObject GetNormalSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetNormalSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020C0A RID: 134154 RVA: 0x00306F9F File Offset: 0x0030519F
		public FColor GetNormalColor()
		{
			return UUISelectableComponent.__GetNormalColor_Internal(base.NativePtr);
		}

		// Token: 0x06020C0B RID: 134155 RVA: 0x00306FAC File Offset: 0x003051AC
		public UUISelectableComponent GetNavigationUpExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationUpExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C0C RID: 134156 RVA: 0x00306FBE File Offset: 0x003051BE
		public EUISelectableNavigationMode GetNavigationUp()
		{
			return UUISelectableComponent.__GetNavigationUp_Internal(base.NativePtr);
		}

		// Token: 0x06020C0D RID: 134157 RVA: 0x00306FCB File Offset: 0x003051CB
		public UUISelectableComponent GetNavigationRightExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationRightExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C0E RID: 134158 RVA: 0x00306FDD File Offset: 0x003051DD
		public EUISelectableNavigationMode GetNavigationRight()
		{
			return UUISelectableComponent.__GetNavigationRight_Internal(base.NativePtr);
		}

		// Token: 0x06020C0F RID: 134159 RVA: 0x00306FEA File Offset: 0x003051EA
		public UUISelectableComponent GetNavigationPrevExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationPrevExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C10 RID: 134160 RVA: 0x00306FFC File Offset: 0x003051FC
		public EUISelectableNavigationMode GetNavigationPrev()
		{
			return UUISelectableComponent.__GetNavigationPrev_Internal(base.NativePtr);
		}

		// Token: 0x06020C11 RID: 134161 RVA: 0x00307009 File Offset: 0x00305209
		public UUISelectableComponent GetNavigationNextExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationNextExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C12 RID: 134162 RVA: 0x0030701B File Offset: 0x0030521B
		public EUISelectableNavigationMode GetNavigationNext()
		{
			return UUISelectableComponent.__GetNavigationNext_Internal(base.NativePtr);
		}

		// Token: 0x06020C13 RID: 134163 RVA: 0x00307028 File Offset: 0x00305228
		public UUISelectableComponent GetNavigationLeftExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationLeftExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C14 RID: 134164 RVA: 0x0030703A File Offset: 0x0030523A
		public EUISelectableNavigationMode GetNavigationLeft()
		{
			return UUISelectableComponent.__GetNavigationLeft_Internal(base.NativePtr);
		}

		// Token: 0x06020C15 RID: 134165 RVA: 0x00307047 File Offset: 0x00305247
		public UUISelectableComponent GetNavigationDownExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationDownExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06020C16 RID: 134166 RVA: 0x00307059 File Offset: 0x00305259
		public EUISelectableNavigationMode GetNavigationDown()
		{
			return UUISelectableComponent.__GetNavigationDown_Internal(base.NativePtr);
		}

		// Token: 0x06020C17 RID: 134167 RVA: 0x00307066 File Offset: 0x00305266
		public ULGUISpriteData_BaseObject GetHighlightedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetHighlightedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020C18 RID: 134168 RVA: 0x00307078 File Offset: 0x00305278
		public FColor GetHighlightedColor()
		{
			return UUISelectableComponent.__GetHighlightedColor_Internal(base.NativePtr);
		}

		// Token: 0x06020C19 RID: 134169 RVA: 0x00307085 File Offset: 0x00305285
		public ULGUISpriteData_BaseObject GetDisabledSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetDisabledSprite_Internal(base.NativePtr));
		}

		// Token: 0x06020C1A RID: 134170 RVA: 0x00307097 File Offset: 0x00305297
		public bool GetCanClickWhenDisable()
		{
			return UUISelectableComponent.__GetCanClickWhenDisable_Internal(base.NativePtr);
		}

		// Token: 0x06020C1B RID: 134171 RVA: 0x003070A4 File Offset: 0x003052A4
		public void ApplySelectionState(bool bImmediateSet)
		{
			UUISelectableComponent.__ApplySelectionState_Internal(base.NativePtr, bImmediateSet);
		}

		// Token: 0x06020C1C RID: 134172
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransitionTarget_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C1D RID: 134173
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelfInteractive_Internal(IntPtr @this, bool InteractiveEnable);

		// Token: 0x06020C1E RID: 134174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectionState_Internal(IntPtr @this, EUISelectableSelectionState NewState);

		// Token: 0x06020C1F RID: 134175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectableDelegate_Internal(IntPtr Delegate);

		// Token: 0x06020C20 RID: 134176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollView_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020C21 RID: 134177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressedSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06020C22 RID: 134178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressedColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06020C23 RID: 134179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNormalSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06020C24 RID: 134180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNormalColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06020C25 RID: 134181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationUpExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C26 RID: 134182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationUp_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C27 RID: 134183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRightExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C28 RID: 134184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRight_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C29 RID: 134185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationPrevExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C2A RID: 134186
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationPrev_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C2B RID: 134187
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationNextExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C2C RID: 134188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationNext_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C2D RID: 134189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationLeftExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C2E RID: 134190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationLeft_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C2F RID: 134191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationGroupParent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020C30 RID: 134192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationGroup_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020C31 RID: 134193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationDownExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06020C32 RID: 134194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationDown_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06020C33 RID: 134195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCustomTransition_Internal(IntPtr @this, bool bIsCustomTransition);

		// Token: 0x06020C34 RID: 134196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCustomAnim_Internal(IntPtr @this, bool bIsCustomAnim);

		// Token: 0x06020C35 RID: 134197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHighlightedSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06020C36 RID: 134198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHighlightedColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06020C37 RID: 134199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanClickWhenDisable_Internal(IntPtr @this, bool CanClickEnbale);

		// Token: 0x06020C38 RID: 134200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayUIAnimationByPlayInfo_Internal(IntPtr @this, IntPtr PlayInfo);

		// Token: 0x06020C39 RID: 134201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyUnFocusListener_Internal(IntPtr @this);

		// Token: 0x06020C3A RID: 134202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyFocusListener_Internal(IntPtr @this);

		// Token: 0x06020C3B RID: 134203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInteractable_Internal(IntPtr @this);

		// Token: 0x06020C3C RID: 134204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTransitionTarget_Internal(IntPtr @this);

		// Token: 0x06020C3D RID: 134205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSelfInteractive_Internal(IntPtr @this);

		// Token: 0x06020C3E RID: 134206
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableSelectionState __GetSelectionState_Internal(IntPtr @this);

		// Token: 0x06020C3F RID: 134207
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelectedSprite_Internal(IntPtr @this);

		// Token: 0x06020C40 RID: 134208
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPressedSprite_Internal(IntPtr @this);

		// Token: 0x06020C41 RID: 134209
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetPressedColor_Internal(IntPtr @this);

		// Token: 0x06020C42 RID: 134210
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNormalSprite_Internal(IntPtr @this);

		// Token: 0x06020C43 RID: 134211
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetNormalColor_Internal(IntPtr @this);

		// Token: 0x06020C44 RID: 134212
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationUpExplicit_Internal(IntPtr @this);

		// Token: 0x06020C45 RID: 134213
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationUp_Internal(IntPtr @this);

		// Token: 0x06020C46 RID: 134214
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationRightExplicit_Internal(IntPtr @this);

		// Token: 0x06020C47 RID: 134215
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationRight_Internal(IntPtr @this);

		// Token: 0x06020C48 RID: 134216
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationPrevExplicit_Internal(IntPtr @this);

		// Token: 0x06020C49 RID: 134217
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationPrev_Internal(IntPtr @this);

		// Token: 0x06020C4A RID: 134218
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationNextExplicit_Internal(IntPtr @this);

		// Token: 0x06020C4B RID: 134219
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationNext_Internal(IntPtr @this);

		// Token: 0x06020C4C RID: 134220
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationLeftExplicit_Internal(IntPtr @this);

		// Token: 0x06020C4D RID: 134221
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationLeft_Internal(IntPtr @this);

		// Token: 0x06020C4E RID: 134222
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationDownExplicit_Internal(IntPtr @this);

		// Token: 0x06020C4F RID: 134223
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationDown_Internal(IntPtr @this);

		// Token: 0x06020C50 RID: 134224
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHighlightedSprite_Internal(IntPtr @this);

		// Token: 0x06020C51 RID: 134225
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetHighlightedColor_Internal(IntPtr @this);

		// Token: 0x06020C52 RID: 134226
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDisabledSprite_Internal(IntPtr @this);

		// Token: 0x06020C53 RID: 134227
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCanClickWhenDisable_Internal(IntPtr @this);

		// Token: 0x06020C54 RID: 134228
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySelectionState_Internal(IntPtr @this, bool bImmediateSet);

		// Token: 0x06020C55 RID: 134229 RVA: 0x003070B2 File Offset: 0x003052B2
		static UUISelectableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableComponent");
		}

		// Token: 0x06020C56 RID: 134230 RVA: 0x003070C0 File Offset: 0x003052C0
		protected UUISelectableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117E2 RID: 71650
		internal static int __InterfaceOffset_ILGUIPointerEnterExitInterface;

		// Token: 0x040117E3 RID: 71651
		internal static int __InterfaceOffset_ILGUIPointerDownUpInterface;

		// Token: 0x040117E4 RID: 71652
		internal static int __InterfaceOffset_ILGUIPointerSelectDeselectInterface;

		// Token: 0x040117E5 RID: 71653
		internal static int __InterfaceOffset_ILGUIPointerClickInterface;

		// Token: 0x040117E6 RID: 71654
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableComponent";

		// Token: 0x040117E7 RID: 71655
		private static IntPtr _ClassPtr;

		// Token: 0x040117E8 RID: 71656
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117E9 RID: 71657
		internal static int __PropertyOffset_TransitionActor;

		// Token: 0x040117EA RID: 71658
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040117EB RID: 71659
		internal static int __PropertyOffset_Transition;

		// Token: 0x040117EC RID: 71660
		internal static int __PropertyOffset_TransitionTweener;

		// Token: 0x040117ED RID: 71661
		internal static int __PropertyOffset_NormalColor;

		// Token: 0x040117EE RID: 71662
		internal static int __PropertyOffset_HighlightedColor;

		// Token: 0x040117EF RID: 71663
		internal static int __PropertyOffset_PressedColor;

		// Token: 0x040117F0 RID: 71664
		internal static int __PropertyOffset_DisabledColor;

		// Token: 0x040117F1 RID: 71665
		internal static int __PropertyOffset_SelectedColor;

		// Token: 0x040117F2 RID: 71666
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x040117F3 RID: 71667
		internal static int __PropertyOffset_NormalSprite;

		// Token: 0x040117F4 RID: 71668
		internal static int __PropertyOffset_HighlightedSprite;

		// Token: 0x040117F5 RID: 71669
		internal static int __PropertyOffset_PressedSprite;

		// Token: 0x040117F6 RID: 71670
		internal static int __PropertyOffset_DisabledSprite;

		// Token: 0x040117F7 RID: 71671
		internal static int __PropertyOffset_SelectedSprite;

		// Token: 0x040117F8 RID: 71672
		internal static int __PropertyOffset_NormalItem;

		// Token: 0x040117F9 RID: 71673
		internal static int __PropertyOffset_HighlightedItem;

		// Token: 0x040117FA RID: 71674
		internal static int __PropertyOffset_PressedItem;

		// Token: 0x040117FB RID: 71675
		internal static int __PropertyOffset_DisabledItem;

		// Token: 0x040117FC RID: 71676
		internal static int __PropertyOffset_SelectedItem;

		// Token: 0x040117FD RID: 71677
		internal static int __PropertyOffset_CurrentSelectionState;

		// Token: 0x040117FE RID: 71678
		internal static int __PropertyOffset_bApplyColorToChildren;

		// Token: 0x040117FF RID: 71679
		internal static int __PropertyOffset_bAutoScrollOnSelected;

		// Token: 0x04011800 RID: 71680
		internal static int __PropertyOffset_NavigationGroupParentComponentActor;

		// Token: 0x04011801 RID: 71681
		internal static int __PropertyOffset_NavigationGroupParentComponent;

		// Token: 0x04011802 RID: 71682
		internal static int __PropertyOffset_NavigationGroupComponentActor;

		// Token: 0x04011803 RID: 71683
		internal static int __PropertyOffset_NavigationGroupComponent;

		// Token: 0x04011804 RID: 71684
		internal static int __PropertyOffset_ScrollViewActor;

		// Token: 0x04011805 RID: 71685
		internal static int __PropertyOffset_ScrollViewComponent;

		// Token: 0x04011806 RID: 71686
		internal static int __PropertyOffset_TransitionComp;

		// Token: 0x04011807 RID: 71687
		internal static int __PropertyOffset_NavigationLeft;

		// Token: 0x04011808 RID: 71688
		internal static int __PropertyOffset_NavigationLeftSpecific;

		// Token: 0x04011809 RID: 71689
		private FLGUIComponentReference _NavigationLeftSpecific;

		// Token: 0x0401180A RID: 71690
		internal static int __PropertyOffset_NavigationRight;

		// Token: 0x0401180B RID: 71691
		internal static int __PropertyOffset_NavigationRightSpecific;

		// Token: 0x0401180C RID: 71692
		private FLGUIComponentReference _NavigationRightSpecific;

		// Token: 0x0401180D RID: 71693
		internal static int __PropertyOffset_NavigationUp;

		// Token: 0x0401180E RID: 71694
		internal static int __PropertyOffset_NavigationUpSpecific;

		// Token: 0x0401180F RID: 71695
		private FLGUIComponentReference _NavigationUpSpecific;

		// Token: 0x04011810 RID: 71696
		internal static int __PropertyOffset_NavigationDown;

		// Token: 0x04011811 RID: 71697
		internal static int __PropertyOffset_NavigationDownSpecific;

		// Token: 0x04011812 RID: 71698
		private FLGUIComponentReference _NavigationDownSpecific;

		// Token: 0x04011813 RID: 71699
		internal static int __PropertyOffset_NavigationNext;

		// Token: 0x04011814 RID: 71700
		internal static int __PropertyOffset_NavigationNextSpecific;

		// Token: 0x04011815 RID: 71701
		private FLGUIComponentReference _NavigationNextSpecific;

		// Token: 0x04011816 RID: 71702
		internal static int __PropertyOffset_NavigationPrev;

		// Token: 0x04011817 RID: 71703
		internal static int __PropertyOffset_NavigationPrevSpecific;

		// Token: 0x04011818 RID: 71704
		private FLGUIComponentReference _NavigationPrevSpecific;

		// Token: 0x04011819 RID: 71705
		internal static int __PropertyOffset_AnimationConfig;

		// Token: 0x0401181A RID: 71706
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EStateTransferType, FAnimationPlayInfo> _AnimationConfig;

		// Token: 0x0401181B RID: 71707
		internal static int __PropertyOffset_AllAnims;

		// Token: 0x0401181C RID: 71708
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _AllAnims;

		// Token: 0x0401181D RID: 71709
		internal static int __PropertyOffset_OnSelfInteractiveChanged;

		// Token: 0x0401181E RID: 71710
		private FLGUISelfInteractiveDelegate _OnSelfInteractiveChanged;

		// Token: 0x0401181F RID: 71711
		internal static int __PropertyOffset_IsSelfInteractive;

		// Token: 0x04011820 RID: 71712
		internal static int __PropertyOffset_bCanClickWhenDisable;

		// Token: 0x04011821 RID: 71713
		internal static int __PropertyOffset_FocusListenerDelegate;

		// Token: 0x04011822 RID: 71714
		private FLGUIFocusListenerDelegate _FocusListenerDelegate;

		// Token: 0x04011823 RID: 71715
		internal static int __PropertyOffset_UnFocusListenerDelegate;

		// Token: 0x04011824 RID: 71716
		private FLGUIUnFocusListenerDelegate _UnFocusListenerDelegate;
	}
}
