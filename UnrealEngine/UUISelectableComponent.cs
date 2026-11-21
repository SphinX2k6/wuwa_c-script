using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000721 RID: 1825
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UISelectableComponent")]
	[UnrealStructLayout(1032, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1032)]
	public class UUISelectableComponent : ULGUIBehaviour, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009D88 RID: 40328 RVA: 0x000EABC0 File Offset: 0x000E8DC0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableComponent._ClassPtr;
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x000EABCC File Offset: 0x000E8DCC
		public UUISelectableComponent() : this(BuiltinUtils.AllocNativeUObject(UUISelectableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x000EABF4 File Offset: 0x000E8DF4
		[NullableContext(1)]
		public UUISelectableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D38 RID: 7480
		// (get) Token: 0x06009D8B RID: 40331 RVA: 0x000EAC27 File Offset: 0x000E8E27
		// (set) Token: 0x06009D8C RID: 40332 RVA: 0x000EAC3B File Offset: 0x000E8E3B
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

		// Token: 0x17001D39 RID: 7481
		// (get) Token: 0x06009D8D RID: 40333 RVA: 0x000EAC50 File Offset: 0x000E8E50
		// (set) Token: 0x06009D8E RID: 40334 RVA: 0x000EAC60 File Offset: 0x000E8E60
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

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06009D8F RID: 40335 RVA: 0x000EAC71 File Offset: 0x000E8E71
		// (set) Token: 0x06009D90 RID: 40336 RVA: 0x000EAC85 File Offset: 0x000E8E85
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

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06009D91 RID: 40337 RVA: 0x000EAC9A File Offset: 0x000E8E9A
		// (set) Token: 0x06009D92 RID: 40338 RVA: 0x000EACAE File Offset: 0x000E8EAE
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

		// Token: 0x17001D3C RID: 7484
		// (get) Token: 0x06009D93 RID: 40339 RVA: 0x000EACC3 File Offset: 0x000E8EC3
		// (set) Token: 0x06009D94 RID: 40340 RVA: 0x000EACD7 File Offset: 0x000E8ED7
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

		// Token: 0x17001D3D RID: 7485
		// (get) Token: 0x06009D95 RID: 40341 RVA: 0x000EACEC File Offset: 0x000E8EEC
		// (set) Token: 0x06009D96 RID: 40342 RVA: 0x000EAD00 File Offset: 0x000E8F00
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

		// Token: 0x17001D3E RID: 7486
		// (get) Token: 0x06009D97 RID: 40343 RVA: 0x000EAD15 File Offset: 0x000E8F15
		// (set) Token: 0x06009D98 RID: 40344 RVA: 0x000EAD29 File Offset: 0x000E8F29
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

		// Token: 0x17001D3F RID: 7487
		// (get) Token: 0x06009D99 RID: 40345 RVA: 0x000EAD3E File Offset: 0x000E8F3E
		// (set) Token: 0x06009D9A RID: 40346 RVA: 0x000EAD52 File Offset: 0x000E8F52
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

		// Token: 0x17001D40 RID: 7488
		// (get) Token: 0x06009D9B RID: 40347 RVA: 0x000EAD67 File Offset: 0x000E8F67
		// (set) Token: 0x06009D9C RID: 40348 RVA: 0x000EAD77 File Offset: 0x000E8F77
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

		// Token: 0x17001D41 RID: 7489
		// (get) Token: 0x06009D9D RID: 40349 RVA: 0x000EAD88 File Offset: 0x000E8F88
		// (set) Token: 0x06009D9E RID: 40350 RVA: 0x000EAD9C File Offset: 0x000E8F9C
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

		// Token: 0x17001D42 RID: 7490
		// (get) Token: 0x06009D9F RID: 40351 RVA: 0x000EADB1 File Offset: 0x000E8FB1
		// (set) Token: 0x06009DA0 RID: 40352 RVA: 0x000EADC5 File Offset: 0x000E8FC5
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

		// Token: 0x17001D43 RID: 7491
		// (get) Token: 0x06009DA1 RID: 40353 RVA: 0x000EADDA File Offset: 0x000E8FDA
		// (set) Token: 0x06009DA2 RID: 40354 RVA: 0x000EADEE File Offset: 0x000E8FEE
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

		// Token: 0x17001D44 RID: 7492
		// (get) Token: 0x06009DA3 RID: 40355 RVA: 0x000EAE03 File Offset: 0x000E9003
		// (set) Token: 0x06009DA4 RID: 40356 RVA: 0x000EAE17 File Offset: 0x000E9017
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

		// Token: 0x17001D45 RID: 7493
		// (get) Token: 0x06009DA5 RID: 40357 RVA: 0x000EAE2C File Offset: 0x000E902C
		// (set) Token: 0x06009DA6 RID: 40358 RVA: 0x000EAE40 File Offset: 0x000E9040
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

		// Token: 0x17001D46 RID: 7494
		// (get) Token: 0x06009DA7 RID: 40359 RVA: 0x000EAE55 File Offset: 0x000E9055
		// (set) Token: 0x06009DA8 RID: 40360 RVA: 0x000EAE69 File Offset: 0x000E9069
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

		// Token: 0x17001D47 RID: 7495
		// (get) Token: 0x06009DA9 RID: 40361 RVA: 0x000EAE7E File Offset: 0x000E907E
		// (set) Token: 0x06009DAA RID: 40362 RVA: 0x000EAE92 File Offset: 0x000E9092
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

		// Token: 0x17001D48 RID: 7496
		// (get) Token: 0x06009DAB RID: 40363 RVA: 0x000EAEA7 File Offset: 0x000E90A7
		// (set) Token: 0x06009DAC RID: 40364 RVA: 0x000EAEBB File Offset: 0x000E90BB
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

		// Token: 0x17001D49 RID: 7497
		// (get) Token: 0x06009DAD RID: 40365 RVA: 0x000EAED0 File Offset: 0x000E90D0
		// (set) Token: 0x06009DAE RID: 40366 RVA: 0x000EAEE4 File Offset: 0x000E90E4
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

		// Token: 0x17001D4A RID: 7498
		// (get) Token: 0x06009DAF RID: 40367 RVA: 0x000EAEF9 File Offset: 0x000E90F9
		// (set) Token: 0x06009DB0 RID: 40368 RVA: 0x000EAF0D File Offset: 0x000E910D
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

		// Token: 0x17001D4B RID: 7499
		// (get) Token: 0x06009DB1 RID: 40369 RVA: 0x000EAF22 File Offset: 0x000E9122
		// (set) Token: 0x06009DB2 RID: 40370 RVA: 0x000EAF32 File Offset: 0x000E9132
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

		// Token: 0x17001D4C RID: 7500
		// (get) Token: 0x06009DB3 RID: 40371 RVA: 0x000EAF43 File Offset: 0x000E9143
		// (set) Token: 0x06009DB4 RID: 40372 RVA: 0x000EAF53 File Offset: 0x000E9153
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

		// Token: 0x17001D4D RID: 7501
		// (get) Token: 0x06009DB5 RID: 40373 RVA: 0x000EAF64 File Offset: 0x000E9164
		// (set) Token: 0x06009DB6 RID: 40374 RVA: 0x000EAF74 File Offset: 0x000E9174
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

		// Token: 0x17001D4E RID: 7502
		// (get) Token: 0x06009DB7 RID: 40375 RVA: 0x000EAF85 File Offset: 0x000E9185
		// (set) Token: 0x06009DB8 RID: 40376 RVA: 0x000EAF99 File Offset: 0x000E9199
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

		// Token: 0x17001D4F RID: 7503
		// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x000EAFAE File Offset: 0x000E91AE
		// (set) Token: 0x06009DBA RID: 40378 RVA: 0x000EAFC2 File Offset: 0x000E91C2
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

		// Token: 0x17001D50 RID: 7504
		// (get) Token: 0x06009DBB RID: 40379 RVA: 0x000EAFD7 File Offset: 0x000E91D7
		// (set) Token: 0x06009DBC RID: 40380 RVA: 0x000EAFEB File Offset: 0x000E91EB
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

		// Token: 0x17001D51 RID: 7505
		// (get) Token: 0x06009DBD RID: 40381 RVA: 0x000EB000 File Offset: 0x000E9200
		// (set) Token: 0x06009DBE RID: 40382 RVA: 0x000EB014 File Offset: 0x000E9214
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

		// Token: 0x17001D52 RID: 7506
		// (get) Token: 0x06009DBF RID: 40383 RVA: 0x000EB029 File Offset: 0x000E9229
		// (set) Token: 0x06009DC0 RID: 40384 RVA: 0x000EB03D File Offset: 0x000E923D
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

		// Token: 0x17001D53 RID: 7507
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x000EB052 File Offset: 0x000E9252
		// (set) Token: 0x06009DC2 RID: 40386 RVA: 0x000EB066 File Offset: 0x000E9266
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

		// Token: 0x17001D54 RID: 7508
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x000EB07B File Offset: 0x000E927B
		// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x000EB08B File Offset: 0x000E928B
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

		// Token: 0x17001D55 RID: 7509
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x000EB09C File Offset: 0x000E929C
		// (set) Token: 0x06009DC6 RID: 40390 RVA: 0x000EB0AC File Offset: 0x000E92AC
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

		// Token: 0x17001D56 RID: 7510
		// (get) Token: 0x06009DC7 RID: 40391 RVA: 0x000EB0BD File Offset: 0x000E92BD
		// (set) Token: 0x06009DC8 RID: 40392 RVA: 0x000EB0CD File Offset: 0x000E92CD
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

		// Token: 0x17001D57 RID: 7511
		// (get) Token: 0x06009DC9 RID: 40393 RVA: 0x000EB0DE File Offset: 0x000E92DE
		// (set) Token: 0x06009DCA RID: 40394 RVA: 0x000EB0EE File Offset: 0x000E92EE
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

		// Token: 0x17001D58 RID: 7512
		// (get) Token: 0x06009DCB RID: 40395 RVA: 0x000EB0FF File Offset: 0x000E92FF
		// (set) Token: 0x06009DCC RID: 40396 RVA: 0x000EB10F File Offset: 0x000E930F
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

		// Token: 0x17001D59 RID: 7513
		// (get) Token: 0x06009DCD RID: 40397 RVA: 0x000EB120 File Offset: 0x000E9320
		// (set) Token: 0x06009DCE RID: 40398 RVA: 0x000EB130 File Offset: 0x000E9330
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

		// Token: 0x17001D5A RID: 7514
		// (get) Token: 0x06009DCF RID: 40399 RVA: 0x000EB144 File Offset: 0x000E9344
		// (set) Token: 0x06009DD0 RID: 40400 RVA: 0x000EB17D File Offset: 0x000E937D
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

		// Token: 0x17001D5B RID: 7515
		// (get) Token: 0x06009DD1 RID: 40401 RVA: 0x000EB18C File Offset: 0x000E938C
		// (set) Token: 0x06009DD2 RID: 40402 RVA: 0x000EB1C5 File Offset: 0x000E93C5
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

		// Token: 0x17001D5C RID: 7516
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x000EB1E6 File Offset: 0x000E93E6
		// (set) Token: 0x06009DD4 RID: 40404 RVA: 0x000EB1F6 File Offset: 0x000E93F6
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

		// Token: 0x17001D5D RID: 7517
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x000EB207 File Offset: 0x000E9407
		// (set) Token: 0x06009DD6 RID: 40406 RVA: 0x000EB217 File Offset: 0x000E9417
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

		// Token: 0x17001D5E RID: 7518
		// (get) Token: 0x06009DD7 RID: 40407 RVA: 0x000EB228 File Offset: 0x000E9428
		// (set) Token: 0x06009DD8 RID: 40408 RVA: 0x000EB261 File Offset: 0x000E9461
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

		// Token: 0x17001D5F RID: 7519
		// (get) Token: 0x06009DD9 RID: 40409 RVA: 0x000EB284 File Offset: 0x000E9484
		// (set) Token: 0x06009DDA RID: 40410 RVA: 0x000EB2BD File Offset: 0x000E94BD
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

		// Token: 0x06009DDB RID: 40411 RVA: 0x000EB2DE File Offset: 0x000E94DE
		public void SetTransitionTarget(AUIBaseActor value)
		{
			UUISelectableComponent.__SetTransitionTarget_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DDC RID: 40412
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShieldPCPress(bool Value);

		// Token: 0x06009DDD RID: 40413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetShieldMobileHighlight(bool Value);

		// Token: 0x06009DDE RID: 40414 RVA: 0x000EB2FB File Offset: 0x000E94FB
		public void SetSelfInteractive(bool InteractiveEnable)
		{
			UUISelectableComponent.__SetSelfInteractive_Internal(base.NativePtr, InteractiveEnable);
		}

		// Token: 0x06009DDF RID: 40415 RVA: 0x000EB309 File Offset: 0x000E9509
		public void SetSelectionState(EUISelectableSelectionState NewState)
		{
			UUISelectableComponent.__SetSelectionState_Internal(base.NativePtr, NewState);
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x000EB317 File Offset: 0x000E9517
		public static void SetSelectableDelegate(in FLGUISelectableDelegate Delegate)
		{
			FLGUISelectableDelegate flguiselectableDelegate = Delegate;
			UUISelectableComponent.__SetSelectableDelegate_Internal((flguiselectableDelegate != null) ? flguiselectableDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x000EB32D File Offset: 0x000E952D
		public void SetScrollView(UUIScrollViewWithScrollbarComponent Component)
		{
			UUISelectableComponent.__SetScrollView_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x000EB34A File Offset: 0x000E954A
		public void SetPressedSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetPressedSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x000EB367 File Offset: 0x000E9567
		public void SetPressedColor(FColor NewColor)
		{
			UUISelectableComponent.__SetPressedColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x000EB375 File Offset: 0x000E9575
		public void SetNormalSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetNormalSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x000EB392 File Offset: 0x000E9592
		public void SetNormalColor(FColor NewColor)
		{
			UUISelectableComponent.__SetNormalColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x000EB3A0 File Offset: 0x000E95A0
		public void SetNavigationUpExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationUpExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x000EB3BD File Offset: 0x000E95BD
		public void SetNavigationUp(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationUp_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x000EB3CB File Offset: 0x000E95CB
		public void SetNavigationRightExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationRightExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x000EB3E8 File Offset: 0x000E95E8
		public void SetNavigationRight(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationRight_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x000EB3F6 File Offset: 0x000E95F6
		public void SetNavigationPrevExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationPrevExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x000EB413 File Offset: 0x000E9613
		public void SetNavigationPrev(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationPrev_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x000EB421 File Offset: 0x000E9621
		public void SetNavigationNextExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationNextExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x000EB43E File Offset: 0x000E963E
		public void SetNavigationNext(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationNext_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x000EB44C File Offset: 0x000E964C
		public void SetNavigationLeftExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationLeftExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x000EB469 File Offset: 0x000E9669
		public void SetNavigationLeft(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationLeft_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x000EB477 File Offset: 0x000E9677
		public void SetNavigationGroupParent(UUISelectableComponent Component)
		{
			UUISelectableComponent.__SetNavigationGroupParent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x000EB494 File Offset: 0x000E9694
		public void SetNavigationDownExplicit(UUISelectableComponent value)
		{
			UUISelectableComponent.__SetNavigationDownExplicit_Internal(base.NativePtr, (value != null) ? value.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x000EB4B1 File Offset: 0x000E96B1
		public void SetNavigationDown(EUISelectableNavigationMode value)
		{
			UUISelectableComponent.__SetNavigationDown_Internal(base.NativePtr, value);
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x000EB4BF File Offset: 0x000E96BF
		public void SetIsCustomTransition(bool bIsCustomTransition)
		{
			UUISelectableComponent.__SetIsCustomTransition_Internal(base.NativePtr, bIsCustomTransition);
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x000EB4CD File Offset: 0x000E96CD
		public void SetIsCustomAnim(bool bIsCustomAnim)
		{
			UUISelectableComponent.__SetIsCustomAnim_Internal(base.NativePtr, bIsCustomAnim);
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x000EB4DB File Offset: 0x000E96DB
		public void SetHighlightedSprite(ULGUISpriteData_BaseObject NewSprite)
		{
			UUISelectableComponent.__SetHighlightedSprite_Internal(base.NativePtr, (NewSprite != null) ? NewSprite.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x000EB4F8 File Offset: 0x000E96F8
		public void SetHighlightedColor(FColor NewColor)
		{
			UUISelectableComponent.__SetHighlightedColor_Internal(base.NativePtr, NewColor);
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x000EB506 File Offset: 0x000E9706
		public void SetCanClickWhenDisable(bool CanClickEnbale)
		{
			UUISelectableComponent.__SetCanClickWhenDisable_Internal(base.NativePtr, CanClickEnbale);
		}

		// Token: 0x06009DF8 RID: 40440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetSelectableDelegate();

		// Token: 0x06009DF9 RID: 40441 RVA: 0x000EB514 File Offset: 0x000E9714
		public void NotifyUnFocusListener()
		{
			UUISelectableComponent.__NotifyUnFocusListener_Internal(base.NativePtr);
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x000EB521 File Offset: 0x000E9721
		public void NotifyFocusListener()
		{
			UUISelectableComponent.__NotifyFocusListener_Internal(base.NativePtr);
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x000EB52E File Offset: 0x000E972E
		public bool IsInteractable()
		{
			return UUISelectableComponent.__IsInteractable_Internal(base.NativePtr);
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x000EB53B File Offset: 0x000E973B
		public AUIBaseActor GetTransitionTarget()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUISelectableComponent.__GetTransitionTarget_Internal(base.NativePtr));
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x000EB54D File Offset: 0x000E974D
		public bool GetSelfInteractive()
		{
			return UUISelectableComponent.__GetSelfInteractive_Internal(base.NativePtr);
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x000EB55A File Offset: 0x000E975A
		public EUISelectableSelectionState GetSelectionState()
		{
			return UUISelectableComponent.__GetSelectionState_Internal(base.NativePtr);
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x000EB567 File Offset: 0x000E9767
		public ULGUISpriteData_BaseObject GetSelectedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetSelectedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x000EB579 File Offset: 0x000E9779
		public ULGUISpriteData_BaseObject GetPressedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetPressedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x000EB58B File Offset: 0x000E978B
		public FColor GetPressedColor()
		{
			return UUISelectableComponent.__GetPressedColor_Internal(base.NativePtr);
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x000EB598 File Offset: 0x000E9798
		public ULGUISpriteData_BaseObject GetNormalSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetNormalSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x000EB5AA File Offset: 0x000E97AA
		public FColor GetNormalColor()
		{
			return UUISelectableComponent.__GetNormalColor_Internal(base.NativePtr);
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x000EB5B7 File Offset: 0x000E97B7
		public UUISelectableComponent GetNavigationUpExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationUpExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x000EB5C9 File Offset: 0x000E97C9
		public EUISelectableNavigationMode GetNavigationUp()
		{
			return UUISelectableComponent.__GetNavigationUp_Internal(base.NativePtr);
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x000EB5D6 File Offset: 0x000E97D6
		public UUISelectableComponent GetNavigationRightExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationRightExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x000EB5E8 File Offset: 0x000E97E8
		public EUISelectableNavigationMode GetNavigationRight()
		{
			return UUISelectableComponent.__GetNavigationRight_Internal(base.NativePtr);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x000EB5F5 File Offset: 0x000E97F5
		public UUISelectableComponent GetNavigationPrevExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationPrevExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x000EB607 File Offset: 0x000E9807
		public EUISelectableNavigationMode GetNavigationPrev()
		{
			return UUISelectableComponent.__GetNavigationPrev_Internal(base.NativePtr);
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x000EB614 File Offset: 0x000E9814
		public UUISelectableComponent GetNavigationNextExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationNextExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x000EB626 File Offset: 0x000E9826
		public EUISelectableNavigationMode GetNavigationNext()
		{
			return UUISelectableComponent.__GetNavigationNext_Internal(base.NativePtr);
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x000EB633 File Offset: 0x000E9833
		public UUISelectableComponent GetNavigationLeftExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationLeftExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x000EB645 File Offset: 0x000E9845
		public EUISelectableNavigationMode GetNavigationLeft()
		{
			return UUISelectableComponent.__GetNavigationLeft_Internal(base.NativePtr);
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x000EB652 File Offset: 0x000E9852
		public UUISelectableComponent GetNavigationDownExplicit()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUISelectableComponent.__GetNavigationDownExplicit_Internal(base.NativePtr));
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x000EB664 File Offset: 0x000E9864
		public EUISelectableNavigationMode GetNavigationDown()
		{
			return UUISelectableComponent.__GetNavigationDown_Internal(base.NativePtr);
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x000EB671 File Offset: 0x000E9871
		public ULGUISpriteData_BaseObject GetHighlightedSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetHighlightedSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x000EB683 File Offset: 0x000E9883
		public FColor GetHighlightedColor()
		{
			return UUISelectableComponent.__GetHighlightedColor_Internal(base.NativePtr);
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x000EB690 File Offset: 0x000E9890
		public ULGUISpriteData_BaseObject GetDisabledSprite()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<ULGUISpriteData_BaseObject>(UUISelectableComponent.__GetDisabledSprite_Internal(base.NativePtr));
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x000EB6A2 File Offset: 0x000E98A2
		public bool GetCanClickWhenDisable()
		{
			return UUISelectableComponent.__GetCanClickWhenDisable_Internal(base.NativePtr);
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x000EB6AF File Offset: 0x000E98AF
		public void ApplySelectionState(bool bImmediateSet)
		{
			UUISelectableComponent.__ApplySelectionState_Internal(base.NativePtr, bImmediateSet);
		}

		// Token: 0x06009E15 RID: 40469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransitionTarget_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E16 RID: 40470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelfInteractive_Internal(IntPtr @this, bool InteractiveEnable);

		// Token: 0x06009E17 RID: 40471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectionState_Internal(IntPtr @this, EUISelectableSelectionState NewState);

		// Token: 0x06009E18 RID: 40472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSelectableDelegate_Internal(IntPtr Delegate);

		// Token: 0x06009E19 RID: 40473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScrollView_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009E1A RID: 40474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressedSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06009E1B RID: 40475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPressedColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06009E1C RID: 40476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNormalSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06009E1D RID: 40477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNormalColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06009E1E RID: 40478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationUpExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E1F RID: 40479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationUp_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E20 RID: 40480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRightExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E21 RID: 40481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRight_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E22 RID: 40482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationPrevExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E23 RID: 40483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationPrev_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E24 RID: 40484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationNextExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E25 RID: 40485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationNext_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E26 RID: 40486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationLeftExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E27 RID: 40487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationLeft_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E28 RID: 40488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationGroupParent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009E29 RID: 40489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationDownExplicit_Internal(IntPtr @this, IntPtr value);

		// Token: 0x06009E2A RID: 40490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationDown_Internal(IntPtr @this, EUISelectableNavigationMode value);

		// Token: 0x06009E2B RID: 40491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCustomTransition_Internal(IntPtr @this, bool bIsCustomTransition);

		// Token: 0x06009E2C RID: 40492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsCustomAnim_Internal(IntPtr @this, bool bIsCustomAnim);

		// Token: 0x06009E2D RID: 40493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHighlightedSprite_Internal(IntPtr @this, IntPtr NewSprite);

		// Token: 0x06009E2E RID: 40494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHighlightedColor_Internal(IntPtr @this, FColor NewColor);

		// Token: 0x06009E2F RID: 40495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCanClickWhenDisable_Internal(IntPtr @this, bool CanClickEnbale);

		// Token: 0x06009E30 RID: 40496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyUnFocusListener_Internal(IntPtr @this);

		// Token: 0x06009E31 RID: 40497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NotifyFocusListener_Internal(IntPtr @this);

		// Token: 0x06009E32 RID: 40498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInteractable_Internal(IntPtr @this);

		// Token: 0x06009E33 RID: 40499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTransitionTarget_Internal(IntPtr @this);

		// Token: 0x06009E34 RID: 40500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetSelfInteractive_Internal(IntPtr @this);

		// Token: 0x06009E35 RID: 40501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableSelectionState __GetSelectionState_Internal(IntPtr @this);

		// Token: 0x06009E36 RID: 40502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSelectedSprite_Internal(IntPtr @this);

		// Token: 0x06009E37 RID: 40503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPressedSprite_Internal(IntPtr @this);

		// Token: 0x06009E38 RID: 40504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetPressedColor_Internal(IntPtr @this);

		// Token: 0x06009E39 RID: 40505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNormalSprite_Internal(IntPtr @this);

		// Token: 0x06009E3A RID: 40506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetNormalColor_Internal(IntPtr @this);

		// Token: 0x06009E3B RID: 40507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationUpExplicit_Internal(IntPtr @this);

		// Token: 0x06009E3C RID: 40508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationUp_Internal(IntPtr @this);

		// Token: 0x06009E3D RID: 40509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationRightExplicit_Internal(IntPtr @this);

		// Token: 0x06009E3E RID: 40510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationRight_Internal(IntPtr @this);

		// Token: 0x06009E3F RID: 40511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationPrevExplicit_Internal(IntPtr @this);

		// Token: 0x06009E40 RID: 40512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationPrev_Internal(IntPtr @this);

		// Token: 0x06009E41 RID: 40513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationNextExplicit_Internal(IntPtr @this);

		// Token: 0x06009E42 RID: 40514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationNext_Internal(IntPtr @this);

		// Token: 0x06009E43 RID: 40515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationLeftExplicit_Internal(IntPtr @this);

		// Token: 0x06009E44 RID: 40516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationLeft_Internal(IntPtr @this);

		// Token: 0x06009E45 RID: 40517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetNavigationDownExplicit_Internal(IntPtr @this);

		// Token: 0x06009E46 RID: 40518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUISelectableNavigationMode __GetNavigationDown_Internal(IntPtr @this);

		// Token: 0x06009E47 RID: 40519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHighlightedSprite_Internal(IntPtr @this);

		// Token: 0x06009E48 RID: 40520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FColor __GetHighlightedColor_Internal(IntPtr @this);

		// Token: 0x06009E49 RID: 40521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDisabledSprite_Internal(IntPtr @this);

		// Token: 0x06009E4A RID: 40522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetCanClickWhenDisable_Internal(IntPtr @this);

		// Token: 0x06009E4B RID: 40523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplySelectionState_Internal(IntPtr @this, bool bImmediateSet);

		// Token: 0x06009E4C RID: 40524 RVA: 0x000EB6BD File Offset: 0x000E98BD
		static UUISelectableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableComponent");
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x000EB6CB File Offset: 0x000E98CB
		protected UUISelectableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043C9 RID: 17353
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableComponent";

		// Token: 0x040043CA RID: 17354
		private static IntPtr _ClassPtr;

		// Token: 0x040043CB RID: 17355
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043CC RID: 17356
		internal static int __PropertyOffset_TransitionActor;

		// Token: 0x040043CD RID: 17357
		internal static int __PropertyOffset_AllowEventBubbleUp;

		// Token: 0x040043CE RID: 17358
		internal static int __PropertyOffset_TransitionTweener;

		// Token: 0x040043CF RID: 17359
		internal static int __PropertyOffset_NormalColor;

		// Token: 0x040043D0 RID: 17360
		internal static int __PropertyOffset_HighlightedColor;

		// Token: 0x040043D1 RID: 17361
		internal static int __PropertyOffset_PressedColor;

		// Token: 0x040043D2 RID: 17362
		internal static int __PropertyOffset_DisabledColor;

		// Token: 0x040043D3 RID: 17363
		internal static int __PropertyOffset_SelectedColor;

		// Token: 0x040043D4 RID: 17364
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x040043D5 RID: 17365
		internal static int __PropertyOffset_NormalSprite;

		// Token: 0x040043D6 RID: 17366
		internal static int __PropertyOffset_HighlightedSprite;

		// Token: 0x040043D7 RID: 17367
		internal static int __PropertyOffset_PressedSprite;

		// Token: 0x040043D8 RID: 17368
		internal static int __PropertyOffset_DisabledSprite;

		// Token: 0x040043D9 RID: 17369
		internal static int __PropertyOffset_SelectedSprite;

		// Token: 0x040043DA RID: 17370
		internal static int __PropertyOffset_NormalItem;

		// Token: 0x040043DB RID: 17371
		internal static int __PropertyOffset_HighlightedItem;

		// Token: 0x040043DC RID: 17372
		internal static int __PropertyOffset_PressedItem;

		// Token: 0x040043DD RID: 17373
		internal static int __PropertyOffset_DisabledItem;

		// Token: 0x040043DE RID: 17374
		internal static int __PropertyOffset_SelectedItem;

		// Token: 0x040043DF RID: 17375
		internal static int __PropertyOffset_CurrentSelectionState;

		// Token: 0x040043E0 RID: 17376
		internal static int __PropertyOffset_bApplyColorToChildren;

		// Token: 0x040043E1 RID: 17377
		internal static int __PropertyOffset_bAutoScrollOnSelected;

		// Token: 0x040043E2 RID: 17378
		internal static int __PropertyOffset_NavigationGroupParentComponentActor;

		// Token: 0x040043E3 RID: 17379
		internal static int __PropertyOffset_NavigationGroupParentComponent;

		// Token: 0x040043E4 RID: 17380
		internal static int __PropertyOffset_NavigationGroupComponentActor;

		// Token: 0x040043E5 RID: 17381
		internal static int __PropertyOffset_ScrollViewActor;

		// Token: 0x040043E6 RID: 17382
		internal static int __PropertyOffset_ScrollViewComponent;

		// Token: 0x040043E7 RID: 17383
		internal static int __PropertyOffset_TransitionComp;

		// Token: 0x040043E8 RID: 17384
		internal static int __PropertyOffset_NavigationLeft;

		// Token: 0x040043E9 RID: 17385
		internal static int __PropertyOffset_NavigationRight;

		// Token: 0x040043EA RID: 17386
		internal static int __PropertyOffset_NavigationUp;

		// Token: 0x040043EB RID: 17387
		internal static int __PropertyOffset_NavigationDown;

		// Token: 0x040043EC RID: 17388
		internal static int __PropertyOffset_NavigationNext;

		// Token: 0x040043ED RID: 17389
		internal static int __PropertyOffset_NavigationPrev;

		// Token: 0x040043EE RID: 17390
		internal static int __PropertyOffset_AllAnims;

		// Token: 0x040043EF RID: 17391
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULevelSequence> _AllAnims;

		// Token: 0x040043F0 RID: 17392
		internal static int __PropertyOffset_OnSelfInteractiveChanged;

		// Token: 0x040043F1 RID: 17393
		private FLGUISelfInteractiveDelegate _OnSelfInteractiveChanged;

		// Token: 0x040043F2 RID: 17394
		internal static int __PropertyOffset_IsSelfInteractive;

		// Token: 0x040043F3 RID: 17395
		internal static int __PropertyOffset_bCanClickWhenDisable;

		// Token: 0x040043F4 RID: 17396
		internal static int __PropertyOffset_FocusListenerDelegate;

		// Token: 0x040043F5 RID: 17397
		private FLGUIFocusListenerDelegate _FocusListenerDelegate;

		// Token: 0x040043F6 RID: 17398
		internal static int __PropertyOffset_UnFocusListenerDelegate;

		// Token: 0x040043F7 RID: 17399
		private FLGUIUnFocusListenerDelegate _UnFocusListenerDelegate;
	}
}
