using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002A02 RID: 10754
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetLayoutLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWidgetLayoutLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027F9D RID: 163741 RVA: 0x003CDD7A File Offset: 0x003CBF7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetLayoutLibrary._ClassPtr;
		}

		// Token: 0x06027F9E RID: 163742 RVA: 0x003CDD88 File Offset: 0x003CBF88
		public UWidgetLayoutLibrary() : this(BuiltinUtils.AllocNativeUObject(UWidgetLayoutLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027F9F RID: 163743 RVA: 0x003CDDB0 File Offset: 0x003CBFB0
		[NullableContext(1)]
		public UWidgetLayoutLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetLayoutLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027FA0 RID: 163744 RVA: 0x003CDDE3 File Offset: 0x003CBFE3
		public static UWrapBoxSlot SlotAsWrapBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWrapBoxSlot>(UWidgetLayoutLibrary.__SlotAsWrapBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA1 RID: 163745 RVA: 0x003CDDFF File Offset: 0x003CBFFF
		public static UWidgetSwitcherSlot SlotAsWidgetSwitcherSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UWidgetSwitcherSlot>(UWidgetLayoutLibrary.__SlotAsWidgetSwitcherSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA2 RID: 163746 RVA: 0x003CDE1B File Offset: 0x003CC01B
		public static UVerticalBoxSlot SlotAsVerticalBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UVerticalBoxSlot>(UWidgetLayoutLibrary.__SlotAsVerticalBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA3 RID: 163747 RVA: 0x003CDE37 File Offset: 0x003CC037
		public static UUniformGridSlot SlotAsUniformGridSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUniformGridSlot>(UWidgetLayoutLibrary.__SlotAsUniformGridSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA4 RID: 163748 RVA: 0x003CDE53 File Offset: 0x003CC053
		public static USizeBoxSlot SlotAsSizeBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USizeBoxSlot>(UWidgetLayoutLibrary.__SlotAsSizeBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA5 RID: 163749 RVA: 0x003CDE6F File Offset: 0x003CC06F
		public static UScrollBoxSlot SlotAsScrollBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UScrollBoxSlot>(UWidgetLayoutLibrary.__SlotAsScrollBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA6 RID: 163750 RVA: 0x003CDE8B File Offset: 0x003CC08B
		public static UScaleBoxSlot SlotAsScaleBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UScaleBoxSlot>(UWidgetLayoutLibrary.__SlotAsScaleBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA7 RID: 163751 RVA: 0x003CDEA7 File Offset: 0x003CC0A7
		public static USafeZoneSlot SlotAsSafeBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USafeZoneSlot>(UWidgetLayoutLibrary.__SlotAsSafeBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA8 RID: 163752 RVA: 0x003CDEC3 File Offset: 0x003CC0C3
		public static UOverlaySlot SlotAsOverlaySlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UOverlaySlot>(UWidgetLayoutLibrary.__SlotAsOverlaySlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FA9 RID: 163753 RVA: 0x003CDEDF File Offset: 0x003CC0DF
		public static UHorizontalBoxSlot SlotAsHorizontalBoxSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UHorizontalBoxSlot>(UWidgetLayoutLibrary.__SlotAsHorizontalBoxSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FAA RID: 163754 RVA: 0x003CDEFB File Offset: 0x003CC0FB
		public static UGridSlot SlotAsGridSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UGridSlot>(UWidgetLayoutLibrary.__SlotAsGridSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FAB RID: 163755 RVA: 0x003CDF17 File Offset: 0x003CC117
		public static UCanvasPanelSlot SlotAsCanvasSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UCanvasPanelSlot>(UWidgetLayoutLibrary.__SlotAsCanvasSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FAC RID: 163756 RVA: 0x003CDF33 File Offset: 0x003CC133
		public static UBorderSlot SlotAsBorderSlot(UWidget Widget)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UBorderSlot>(UWidgetLayoutLibrary.__SlotAsBorderSlot_Internal((Widget != null) ? Widget.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027FAD RID: 163757 RVA: 0x003CDF4F File Offset: 0x003CC14F
		public static void RemoveAllWidgets(UObject WorldContextObject)
		{
			UWidgetLayoutLibrary.__RemoveAllWidgets_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027FAE RID: 163758 RVA: 0x003CDF68 File Offset: 0x003CC168
		public unsafe static bool ProjectWorldLocationToWidgetPosition(APlayerController PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative)
		{
			fixed (FVector2D* ptr = &ScreenPosition)
			{
				void* ptr2 = (void*)ptr;
				return UWidgetLayoutLibrary.__ProjectWorldLocationToWidgetPosition_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, WorldLocation, ref ScreenPosition, bPlayerViewportRelative);
			}
		}

		// Token: 0x06027FAF RID: 163759 RVA: 0x003CDF92 File Offset: 0x003CC192
		[NullableContext(1)]
		public static FGeometry GetViewportWidgetGeometry([Nullable(2)] UObject WorldContextObject)
		{
			return new FGeometry(UWidgetLayoutLibrary.__GetViewportWidgetGeometry_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06027FB0 RID: 163760 RVA: 0x003CDFAF File Offset: 0x003CC1AF
		public static FVector2D GetViewportSize(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetViewportSize_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027FB1 RID: 163761 RVA: 0x003CDFC6 File Offset: 0x003CC1C6
		public static float GetViewportScale(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetViewportScale_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027FB2 RID: 163762 RVA: 0x003CDFDD File Offset: 0x003CC1DD
		[NullableContext(1)]
		public static FGeometry GetPlayerScreenWidgetGeometry([Nullable(2)] APlayerController PlayerController)
		{
			return new FGeometry(UWidgetLayoutLibrary.__GetPlayerScreenWidgetGeometry_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06027FB3 RID: 163763 RVA: 0x003CDFFC File Offset: 0x003CC1FC
		public unsafe static bool GetMousePositionScaledByDPI(APlayerController Player, ref float LocationX, ref float LocationY)
		{
			fixed (float* ptr = &LocationX)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &LocationY)
				{
					void* ptr4 = (void*)ptr3;
					return UWidgetLayoutLibrary.__GetMousePositionScaledByDPI_Internal((Player != null) ? Player.NativePtr : IntPtr.Zero, ref LocationX, ref LocationY);
				}
			}
		}

		// Token: 0x06027FB4 RID: 163764 RVA: 0x003CE02A File Offset: 0x003CC22A
		public static FVector2D GetMousePositionOnViewport(UObject WorldContextObject)
		{
			return UWidgetLayoutLibrary.__GetMousePositionOnViewport_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027FB5 RID: 163765
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetMousePositionOnPlatform();

		// Token: 0x06027FB6 RID: 163766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsWrapBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FB7 RID: 163767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsWidgetSwitcherSlot_Internal(IntPtr Widget);

		// Token: 0x06027FB8 RID: 163768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsVerticalBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FB9 RID: 163769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsUniformGridSlot_Internal(IntPtr Widget);

		// Token: 0x06027FBA RID: 163770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsSizeBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FBB RID: 163771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsScrollBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FBC RID: 163772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsScaleBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FBD RID: 163773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsSafeBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FBE RID: 163774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsOverlaySlot_Internal(IntPtr Widget);

		// Token: 0x06027FBF RID: 163775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsHorizontalBoxSlot_Internal(IntPtr Widget);

		// Token: 0x06027FC0 RID: 163776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsGridSlot_Internal(IntPtr Widget);

		// Token: 0x06027FC1 RID: 163777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsCanvasSlot_Internal(IntPtr Widget);

		// Token: 0x06027FC2 RID: 163778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SlotAsBorderSlot_Internal(IntPtr Widget);

		// Token: 0x06027FC3 RID: 163779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveAllWidgets_Internal(IntPtr WorldContextObject);

		// Token: 0x06027FC4 RID: 163780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProjectWorldLocationToWidgetPosition_Internal(IntPtr PlayerController, FVector WorldLocation, ref FVector2D ScreenPosition, bool bPlayerViewportRelative);

		// Token: 0x06027FC5 RID: 163781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetViewportWidgetGeometry_Internal(IntPtr WorldContextObject);

		// Token: 0x06027FC6 RID: 163782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetViewportSize_Internal(IntPtr WorldContextObject);

		// Token: 0x06027FC7 RID: 163783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetViewportScale_Internal(IntPtr WorldContextObject);

		// Token: 0x06027FC8 RID: 163784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlayerScreenWidgetGeometry_Internal(IntPtr PlayerController);

		// Token: 0x06027FC9 RID: 163785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetMousePositionScaledByDPI_Internal(IntPtr Player, ref float LocationX, ref float LocationY);

		// Token: 0x06027FCA RID: 163786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __GetMousePositionOnViewport_Internal(IntPtr WorldContextObject);

		// Token: 0x06027FCB RID: 163787 RVA: 0x003CE041 File Offset: 0x003CC241
		static UWidgetLayoutLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetLayoutLibrary");
		}

		// Token: 0x06027FCC RID: 163788 RVA: 0x003CE04F File Offset: 0x003CC24F
		protected UWidgetLayoutLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015D2B RID: 89387
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetLayoutLibrary";

		// Token: 0x04015D2C RID: 89388
		private static IntPtr _ClassPtr;

		// Token: 0x04015D2D RID: 89389
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
