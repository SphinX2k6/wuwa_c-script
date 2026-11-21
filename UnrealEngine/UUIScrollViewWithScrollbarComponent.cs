using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200071F RID: 1823
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIScrollViewWithScrollbarComponent")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UUIScrollViewWithScrollbarComponent : UUIScrollViewComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009D48 RID: 40264 RVA: 0x000EA732 File Offset: 0x000E8932
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollViewWithScrollbarComponent._ClassPtr;
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x000EA740 File Offset: 0x000E8940
		public UUIScrollViewWithScrollbarComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewWithScrollbarComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x000EA768 File Offset: 0x000E8968
		[NullableContext(1)]
		public UUIScrollViewWithScrollbarComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewWithScrollbarComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001D31 RID: 7473
		// (get) Token: 0x06009D4B RID: 40267 RVA: 0x000EA79B File Offset: 0x000E899B
		// (set) Token: 0x06009D4C RID: 40268 RVA: 0x000EA7AF File Offset: 0x000E89AF
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> Viewport
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_Viewport);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_Viewport) = value;
			}
		}

		// Token: 0x17001D32 RID: 7474
		// (get) Token: 0x06009D4D RID: 40269 RVA: 0x000EA7C4 File Offset: 0x000E89C4
		// (set) Token: 0x06009D4E RID: 40270 RVA: 0x000EA7D8 File Offset: 0x000E89D8
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> HorizontalScrollbar
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbar);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbar) = value;
			}
		}

		// Token: 0x17001D33 RID: 7475
		// (get) Token: 0x06009D4F RID: 40271 RVA: 0x000EA7ED File Offset: 0x000E89ED
		// (set) Token: 0x06009D50 RID: 40272 RVA: 0x000EA801 File Offset: 0x000E8A01
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<AUIBaseActor> VerticalScrollbar
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbar);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbar) = value;
			}
		}

		// Token: 0x17001D34 RID: 7476
		// (get) Token: 0x06009D51 RID: 40273 RVA: 0x000EA816 File Offset: 0x000E8A16
		// (set) Token: 0x06009D52 RID: 40274 RVA: 0x000EA82A File Offset: 0x000E8A2A
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIScrollbarComponent> HorizontalScrollbarComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbarComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbarComp) = value;
			}
		}

		// Token: 0x17001D35 RID: 7477
		// (get) Token: 0x06009D53 RID: 40275 RVA: 0x000EA83F File Offset: 0x000E8A3F
		// (set) Token: 0x06009D54 RID: 40276 RVA: 0x000EA853 File Offset: 0x000E8A53
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIScrollbarComponent> VerticalScrollbarComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbarComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbarComp) = value;
			}
		}

		// Token: 0x17001D36 RID: 7478
		// (get) Token: 0x06009D55 RID: 40277 RVA: 0x000EA868 File Offset: 0x000E8A68
		// (set) Token: 0x06009D56 RID: 40278 RVA: 0x000EA878 File Offset: 0x000E8A78
		public unsafe bool IsChangeNavigation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_IsChangeNavigation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_IsChangeNavigation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D37 RID: 7479
		// (get) Token: 0x06009D57 RID: 40279 RVA: 0x000EA889 File Offset: 0x000E8A89
		// (set) Token: 0x06009D58 RID: 40280 RVA: 0x000EA899 File Offset: 0x000E8A99
		public unsafe bool AllowScrollEventBubbleUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_AllowScrollEventBubbleUp) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_AllowScrollEventBubbleUp) = (value ? 1 : 0);
			}
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x000EA8AA File Offset: 0x000E8AAA
		public void UnBindParentUIItem(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__UnBindParentUIItem_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x000EA8C7 File Offset: 0x000E8AC7
		public void ScrollToTopLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToTopLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x000EA8E8 File Offset: 0x000E8AE8
		public unsafe void ScrollToTop(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToTop_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x000EA91A File Offset: 0x000E8B1A
		public void ScrollToSelectableComponent(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToSelectableComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x000EA937 File Offset: 0x000E8B37
		public void ScrollToRightLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToRightLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x000EA958 File Offset: 0x000E8B58
		public unsafe void ScrollToRight(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToRight_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x000EA98A File Offset: 0x000E8B8A
		public void ScrollToLeftLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToLeftLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x000EA9A8 File Offset: 0x000E8BA8
		public unsafe void ScrollToLeft(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToLeft_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x000EA9DA File Offset: 0x000E8BDA
		public void ScrollToEnd()
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToEnd_Internal(base.NativePtr);
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x000EA9E7 File Offset: 0x000E8BE7
		public void ScrollToBottomLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToBottomLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x000EAA08 File Offset: 0x000E8C08
		public unsafe void ScrollToBottom(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToBottom_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x000EAA3A File Offset: 0x000E8C3A
		public void ScrollTo(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollTo_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x000EAA58 File Offset: 0x000E8C58
		public void ResetIsChangeNavigation()
		{
			UUIScrollViewWithScrollbarComponent.__ResetIsChangeNavigation_Internal(base.NativePtr);
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x000EAA65 File Offset: 0x000E8C65
		public AUIBaseActor GetViewport()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetViewport_Internal(base.NativePtr));
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x000EAA77 File Offset: 0x000E8C77
		public AUIBaseActor GetVerticalScrollbar()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetVerticalScrollbar_Internal(base.NativePtr));
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x000EAA8C File Offset: 0x000E8C8C
		public unsafe void GetOutOfBottomBoundsType(UUIItem UIItem, ref EOutOfBoundsType OutOfTopOrBottomType, ref EOutOfBoundsType OutOfLeftOrRightType, float ErrorTolerance = 0f)
		{
			fixed (EOutOfBoundsType* ptr = &OutOfTopOrBottomType)
			{
				void* ptr2 = (void*)ptr;
				fixed (EOutOfBoundsType* ptr3 = &OutOfLeftOrRightType)
				{
					void* ptr4 = (void*)ptr3;
					UUIScrollViewWithScrollbarComponent.__GetOutOfBottomBoundsType_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, ref OutOfTopOrBottomType, ref OutOfLeftOrRightType, ErrorTolerance);
					ptr = null;
				}
			}
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x000EAAC8 File Offset: 0x000E8CC8
		public AUIBaseActor GetHorizontalScrollbar()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetHorizontalScrollbar_Internal(base.NativePtr));
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x000EAADA File Offset: 0x000E8CDA
		public UUISelectableComponent FindNavigationComponent(UUISelectableComponent Component, FVector Direction, UINavigationWrapMode Mode, bool bHasOtherNode = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUIScrollViewWithScrollbarComponent.__FindNavigationComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, Direction, Mode, bHasOtherNode));
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x000EAB00 File Offset: 0x000E8D00
		public void BindParentUIItem(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__BindParentUIItem_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06009D6C RID: 40300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnBindParentUIItem_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009D6D RID: 40301
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTopLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D6E RID: 40302
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTop_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D6F RID: 40303
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToSelectableComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009D70 RID: 40304
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToRightLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D71 RID: 40305
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToRight_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D72 RID: 40306
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLeftLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D73 RID: 40307
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLeft_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D74 RID: 40308
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEnd_Internal(IntPtr @this);

		// Token: 0x06009D75 RID: 40309
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottomLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D76 RID: 40310
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottom_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D77 RID: 40311
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollTo_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06009D78 RID: 40312
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIsChangeNavigation_Internal(IntPtr @this);

		// Token: 0x06009D79 RID: 40313
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewport_Internal(IntPtr @this);

		// Token: 0x06009D7A RID: 40314
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVerticalScrollbar_Internal(IntPtr @this);

		// Token: 0x06009D7B RID: 40315
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOutOfBottomBoundsType_Internal(IntPtr @this, IntPtr UIItem, ref EOutOfBoundsType OutOfTopOrBottomType, ref EOutOfBoundsType OutOfLeftOrRightType, float ErrorTolerance);

		// Token: 0x06009D7C RID: 40316
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHorizontalScrollbar_Internal(IntPtr @this);

		// Token: 0x06009D7D RID: 40317
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNavigationComponent_Internal(IntPtr @this, IntPtr Component, FVector Direction, UINavigationWrapMode Mode, bool bHasOtherNode);

		// Token: 0x06009D7E RID: 40318
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindParentUIItem_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06009D7F RID: 40319 RVA: 0x000EAB1D File Offset: 0x000E8D1D
		static UUIScrollViewWithScrollbarComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollViewWithScrollbarComponent");
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x000EAB2B File Offset: 0x000E8D2B
		protected UUIScrollViewWithScrollbarComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043BC RID: 17340
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIScrollViewWithScrollbarComponent";

		// Token: 0x040043BD RID: 17341
		private static IntPtr _ClassPtr;

		// Token: 0x040043BE RID: 17342
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043BF RID: 17343
		internal static int __PropertyOffset_Viewport;

		// Token: 0x040043C0 RID: 17344
		internal static int __PropertyOffset_HorizontalScrollbar;

		// Token: 0x040043C1 RID: 17345
		internal static int __PropertyOffset_VerticalScrollbar;

		// Token: 0x040043C2 RID: 17346
		internal static int __PropertyOffset_HorizontalScrollbarComp;

		// Token: 0x040043C3 RID: 17347
		internal static int __PropertyOffset_VerticalScrollbarComp;

		// Token: 0x040043C4 RID: 17348
		internal static int __PropertyOffset_IsChangeNavigation;

		// Token: 0x040043C5 RID: 17349
		internal static int __PropertyOffset_AllowScrollEventBubbleUp;
	}
}
