using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020021A7 RID: 8615
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIScrollViewWithScrollbarComponent")]
	[UnrealStructLayout(728, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 728)]
	public class UUIScrollViewWithScrollbarComponent : UUIScrollViewComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020B2B RID: 133931 RVA: 0x00305DA7 File Offset: 0x00303FA7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIScrollViewWithScrollbarComponent._ClassPtr;
		}

		// Token: 0x06020B2C RID: 133932 RVA: 0x00305DB4 File Offset: 0x00303FB4
		public UUIScrollViewWithScrollbarComponent() : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewWithScrollbarComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020B2D RID: 133933 RVA: 0x00305DDC File Offset: 0x00303FDC
		[NullableContext(1)]
		public UUIScrollViewWithScrollbarComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIScrollViewWithScrollbarComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007FC9 RID: 32713
		// (get) Token: 0x06020B2E RID: 133934 RVA: 0x00305E0F File Offset: 0x0030400F
		// (set) Token: 0x06020B2F RID: 133935 RVA: 0x00305E23 File Offset: 0x00304023
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

		// Token: 0x17007FCA RID: 32714
		// (get) Token: 0x06020B30 RID: 133936 RVA: 0x00305E38 File Offset: 0x00304038
		// (set) Token: 0x06020B31 RID: 133937 RVA: 0x00305E4C File Offset: 0x0030404C
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

		// Token: 0x17007FCB RID: 32715
		// (get) Token: 0x06020B32 RID: 133938 RVA: 0x00305E61 File Offset: 0x00304061
		// (set) Token: 0x06020B33 RID: 133939 RVA: 0x00305E71 File Offset: 0x00304071
		public unsafe EScrollViewScrollbarVisibility HorizontalScrollbarVisibility
		{
			get
			{
				return (EScrollViewScrollbarVisibility)(*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbarVisibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_HorizontalScrollbarVisibility) = (byte)value;
			}
		}

		// Token: 0x17007FCC RID: 32716
		// (get) Token: 0x06020B34 RID: 133940 RVA: 0x00305E82 File Offset: 0x00304082
		// (set) Token: 0x06020B35 RID: 133941 RVA: 0x00305E96 File Offset: 0x00304096
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

		// Token: 0x17007FCD RID: 32717
		// (get) Token: 0x06020B36 RID: 133942 RVA: 0x00305EAB File Offset: 0x003040AB
		// (set) Token: 0x06020B37 RID: 133943 RVA: 0x00305EBB File Offset: 0x003040BB
		public unsafe EScrollViewScrollbarVisibility VerticalScrollbarVisibility
		{
			get
			{
				return (EScrollViewScrollbarVisibility)(*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbarVisibility));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIScrollViewWithScrollbarComponent.__PropertyOffset_VerticalScrollbarVisibility) = (byte)value;
			}
		}

		// Token: 0x17007FCE RID: 32718
		// (get) Token: 0x06020B38 RID: 133944 RVA: 0x00305ECC File Offset: 0x003040CC
		// (set) Token: 0x06020B39 RID: 133945 RVA: 0x00305EE0 File Offset: 0x003040E0
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

		// Token: 0x17007FCF RID: 32719
		// (get) Token: 0x06020B3A RID: 133946 RVA: 0x00305EF5 File Offset: 0x003040F5
		// (set) Token: 0x06020B3B RID: 133947 RVA: 0x00305F09 File Offset: 0x00304109
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

		// Token: 0x17007FD0 RID: 32720
		// (get) Token: 0x06020B3C RID: 133948 RVA: 0x00305F1E File Offset: 0x0030411E
		// (set) Token: 0x06020B3D RID: 133949 RVA: 0x00305F2E File Offset: 0x0030412E
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

		// Token: 0x17007FD1 RID: 32721
		// (get) Token: 0x06020B3E RID: 133950 RVA: 0x00305F3F File Offset: 0x0030413F
		// (set) Token: 0x06020B3F RID: 133951 RVA: 0x00305F4F File Offset: 0x0030414F
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

		// Token: 0x06020B40 RID: 133952 RVA: 0x00305F60 File Offset: 0x00304160
		public void UnBindParentUIItem(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__UnBindParentUIItem_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020B41 RID: 133953 RVA: 0x00305F7D File Offset: 0x0030417D
		public void SetVerticalScrollbarVisibility(EScrollViewScrollbarVisibility value)
		{
			UUIScrollViewWithScrollbarComponent.__SetVerticalScrollbarVisibility_Internal(base.NativePtr, value);
		}

		// Token: 0x06020B42 RID: 133954 RVA: 0x00305F8B File Offset: 0x0030418B
		public void SetHorizontalScrollbarVisibility(EScrollViewScrollbarVisibility value)
		{
			UUIScrollViewWithScrollbarComponent.__SetHorizontalScrollbarVisibility_Internal(base.NativePtr, value);
		}

		// Token: 0x06020B43 RID: 133955 RVA: 0x00305F99 File Offset: 0x00304199
		public void ScrollToTopLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToTopLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06020B44 RID: 133956 RVA: 0x00305FB8 File Offset: 0x003041B8
		public unsafe void ScrollToTop(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToTop_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06020B45 RID: 133957 RVA: 0x00305FEA File Offset: 0x003041EA
		public void ScrollToSelectableComponent(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToSelectableComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020B46 RID: 133958 RVA: 0x00306007 File Offset: 0x00304207
		public void ScrollToRightLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToRightLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06020B47 RID: 133959 RVA: 0x00306028 File Offset: 0x00304228
		public unsafe void ScrollToRight(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToRight_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06020B48 RID: 133960 RVA: 0x0030605A File Offset: 0x0030425A
		public void ScrollToLeftLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToLeftLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06020B49 RID: 133961 RVA: 0x00306078 File Offset: 0x00304278
		public unsafe void ScrollToLeft(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToLeft_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06020B4A RID: 133962 RVA: 0x003060AA File Offset: 0x003042AA
		public void ScrollToEnd()
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToEnd_Internal(base.NativePtr);
		}

		// Token: 0x06020B4B RID: 133963 RVA: 0x003060B7 File Offset: 0x003042B7
		public void ScrollToBottomLater(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollToBottomLater_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06020B4C RID: 133964 RVA: 0x003060D8 File Offset: 0x003042D8
		public unsafe void ScrollToBottom(ref FVector2D NewPosition, UUIItem UIItem, bool bTweenAnim = false)
		{
			fixed (FVector2D* ptr = &NewPosition)
			{
				void* ptr2 = (void*)ptr;
				UUIScrollViewWithScrollbarComponent.__ScrollToBottom_Internal(base.NativePtr, ref NewPosition, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
			}
		}

		// Token: 0x06020B4D RID: 133965 RVA: 0x0030610A File Offset: 0x0030430A
		public void ScrollTo(UUIItem UIItem, bool bTweenAnim = false)
		{
			UUIScrollViewWithScrollbarComponent.__ScrollTo_Internal(base.NativePtr, (UIItem != null) ? UIItem.NativePtr : IntPtr.Zero, bTweenAnim);
		}

		// Token: 0x06020B4E RID: 133966 RVA: 0x00306128 File Offset: 0x00304328
		public void ResetIsChangeNavigation()
		{
			UUIScrollViewWithScrollbarComponent.__ResetIsChangeNavigation_Internal(base.NativePtr);
		}

		// Token: 0x06020B4F RID: 133967 RVA: 0x00306135 File Offset: 0x00304335
		public AUIBaseActor GetViewport()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetViewport_Internal(base.NativePtr));
		}

		// Token: 0x06020B50 RID: 133968 RVA: 0x00306147 File Offset: 0x00304347
		public EScrollViewScrollbarVisibility GetVerticalScrollbarVisibility()
		{
			return UUIScrollViewWithScrollbarComponent.__GetVerticalScrollbarVisibility_Internal(base.NativePtr);
		}

		// Token: 0x06020B51 RID: 133969 RVA: 0x00306154 File Offset: 0x00304354
		public AUIBaseActor GetVerticalScrollbar()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetVerticalScrollbar_Internal(base.NativePtr));
		}

		// Token: 0x06020B52 RID: 133970 RVA: 0x00306168 File Offset: 0x00304368
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

		// Token: 0x06020B53 RID: 133971 RVA: 0x003061A4 File Offset: 0x003043A4
		public EScrollViewScrollbarVisibility GetHorizontalScrollbarVisibility()
		{
			return UUIScrollViewWithScrollbarComponent.__GetHorizontalScrollbarVisibility_Internal(base.NativePtr);
		}

		// Token: 0x06020B54 RID: 133972 RVA: 0x003061B1 File Offset: 0x003043B1
		public AUIBaseActor GetHorizontalScrollbar()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AUIBaseActor>(UUIScrollViewWithScrollbarComponent.__GetHorizontalScrollbar_Internal(base.NativePtr));
		}

		// Token: 0x06020B55 RID: 133973 RVA: 0x003061C3 File Offset: 0x003043C3
		public UUISelectableComponent FindNavigationComponent(UUISelectableComponent Component, FVector Direction, UINavigationWrapMode Mode, bool bHasOtherNode = false)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUISelectableComponent>(UUIScrollViewWithScrollbarComponent.__FindNavigationComponent_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero, Direction, Mode, bHasOtherNode));
		}

		// Token: 0x06020B56 RID: 133974 RVA: 0x003061E9 File Offset: 0x003043E9
		public void BindParentUIItem(UUISelectableComponent Component)
		{
			UUIScrollViewWithScrollbarComponent.__BindParentUIItem_Internal(base.NativePtr, (Component != null) ? Component.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06020B57 RID: 133975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UnBindParentUIItem_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020B58 RID: 133976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVerticalScrollbarVisibility_Internal(IntPtr @this, EScrollViewScrollbarVisibility value);

		// Token: 0x06020B59 RID: 133977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHorizontalScrollbarVisibility_Internal(IntPtr @this, EScrollViewScrollbarVisibility value);

		// Token: 0x06020B5A RID: 133978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTopLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B5B RID: 133979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToTop_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B5C RID: 133980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToSelectableComponent_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020B5D RID: 133981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToRightLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B5E RID: 133982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToRight_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B5F RID: 133983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLeftLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B60 RID: 133984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToLeft_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B61 RID: 133985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToEnd_Internal(IntPtr @this);

		// Token: 0x06020B62 RID: 133986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottomLater_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B63 RID: 133987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollToBottom_Internal(IntPtr @this, ref FVector2D NewPosition, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B64 RID: 133988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrollTo_Internal(IntPtr @this, IntPtr UIItem, bool bTweenAnim);

		// Token: 0x06020B65 RID: 133989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetIsChangeNavigation_Internal(IntPtr @this);

		// Token: 0x06020B66 RID: 133990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewport_Internal(IntPtr @this);

		// Token: 0x06020B67 RID: 133991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EScrollViewScrollbarVisibility __GetVerticalScrollbarVisibility_Internal(IntPtr @this);

		// Token: 0x06020B68 RID: 133992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetVerticalScrollbar_Internal(IntPtr @this);

		// Token: 0x06020B69 RID: 133993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetOutOfBottomBoundsType_Internal(IntPtr @this, IntPtr UIItem, ref EOutOfBoundsType OutOfTopOrBottomType, ref EOutOfBoundsType OutOfLeftOrRightType, float ErrorTolerance);

		// Token: 0x06020B6A RID: 133994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EScrollViewScrollbarVisibility __GetHorizontalScrollbarVisibility_Internal(IntPtr @this);

		// Token: 0x06020B6B RID: 133995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetHorizontalScrollbar_Internal(IntPtr @this);

		// Token: 0x06020B6C RID: 133996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FindNavigationComponent_Internal(IntPtr @this, IntPtr Component, FVector Direction, UINavigationWrapMode Mode, bool bHasOtherNode);

		// Token: 0x06020B6D RID: 133997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BindParentUIItem_Internal(IntPtr @this, IntPtr Component);

		// Token: 0x06020B6E RID: 133998 RVA: 0x00306206 File Offset: 0x00304406
		static UUIScrollViewWithScrollbarComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIScrollViewWithScrollbarComponent");
		}

		// Token: 0x06020B6F RID: 133999 RVA: 0x00306214 File Offset: 0x00304414
		protected UUIScrollViewWithScrollbarComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040117D3 RID: 71635
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIScrollViewWithScrollbarComponent";

		// Token: 0x040117D4 RID: 71636
		private static IntPtr _ClassPtr;

		// Token: 0x040117D5 RID: 71637
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040117D6 RID: 71638
		internal static int __PropertyOffset_Viewport;

		// Token: 0x040117D7 RID: 71639
		internal static int __PropertyOffset_HorizontalScrollbar;

		// Token: 0x040117D8 RID: 71640
		internal static int __PropertyOffset_HorizontalScrollbarVisibility;

		// Token: 0x040117D9 RID: 71641
		internal static int __PropertyOffset_VerticalScrollbar;

		// Token: 0x040117DA RID: 71642
		internal static int __PropertyOffset_VerticalScrollbarVisibility;

		// Token: 0x040117DB RID: 71643
		internal static int __PropertyOffset_HorizontalScrollbarComp;

		// Token: 0x040117DC RID: 71644
		internal static int __PropertyOffset_VerticalScrollbarComp;

		// Token: 0x040117DD RID: 71645
		internal static int __PropertyOffset_IsChangeNavigation;

		// Token: 0x040117DE RID: 71646
		internal static int __PropertyOffset_AllowScrollEventBubbleUp;
	}
}
