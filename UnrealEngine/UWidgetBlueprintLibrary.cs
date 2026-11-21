using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000876 RID: 2166
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600BC92 RID: 48274 RVA: 0x0012D5C6 File Offset: 0x0012B7C6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetBlueprintLibrary._ClassPtr;
		}

		// Token: 0x0600BC93 RID: 48275 RVA: 0x0012D5D4 File Offset: 0x0012B7D4
		public UWidgetBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600BC94 RID: 48276 RVA: 0x0012D5FC File Offset: 0x0012B7FC
		[NullableContext(1)]
		public UWidgetBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600BC95 RID: 48277 RVA: 0x0012D62F File Offset: 0x0012B82F
		public static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate)
		{
			UWidgetBlueprintLibrary.__SetWindowTitleBarOnCloseClickedDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0600BC96 RID: 48278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetWindowTitleBarCloseButtonActive(bool bActive);

		// Token: 0x0600BC97 RID: 48279 RVA: 0x0012D643 File Offset: 0x0012B843
		public static void SetInputMode_UIOnly(APlayerController Target, UWidget InWidgetToFocus = null, bool bLockMouseToViewport = false)
		{
			UWidgetBlueprintLibrary.__SetInputMode_UIOnly_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, bLockMouseToViewport);
		}

		// Token: 0x0600BC98 RID: 48280 RVA: 0x0012D66B File Offset: 0x0012B86B
		public static void SetInputMode_GameOnly(APlayerController PlayerController)
		{
			UWidgetBlueprintLibrary.__SetInputMode_GameOnly_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600BC99 RID: 48281 RVA: 0x0012D682 File Offset: 0x0012B882
		public static void SetInputMode_GameAndUI(APlayerController Target, UWidget InWidgetToFocus = null, bool bLockMouseToViewport = false, bool bHideCursorDuringCapture = true)
		{
			UWidgetBlueprintLibrary.__SetInputMode_GameAndUI_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, bLockMouseToViewport, bHideCursorDuringCapture);
		}

		// Token: 0x0600BC9A RID: 48282 RVA: 0x0012D6AB File Offset: 0x0012B8AB
		public static bool SetHardwareCursor(UObject WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
		{
			return UWidgetBlueprintLibrary.__SetHardwareCursor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CursorShape, CursorName, HotSpot);
		}

		// Token: 0x0600BC9B RID: 48283
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFocusToGameViewport();

		// Token: 0x0600BC9C RID: 48284
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RestorePreviousWindowTitleBarState();

		// Token: 0x0600BC9D RID: 48285
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDragDropping();

		// Token: 0x0600BC9E RID: 48286 RVA: 0x0012D6CC File Offset: 0x0012B8CC
		public unsafe static void GetSafeZonePadding(UObject WorldContextObject, ref FVector4 SafePadding, ref FVector2D SafePaddingScale, ref FVector4 SpillOverPadding)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = SafePadding;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = SpillOverPadding;
			fixed (FVector2D* ptr3 = &SafePaddingScale)
			{
				void* ptr4 = (void*)ptr3;
				UWidgetBlueprintLibrary.__GetSafeZonePadding_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ref ptr, ref SafePaddingScale, ref ptr2);
				SafePadding = ptr;
				SpillOverPadding = ptr2;
			}
		}

		// Token: 0x0600BC9F RID: 48287 RVA: 0x0012D749 File Offset: 0x0012B949
		public static void GetAllWidgetsWithInterface(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUserWidget> FoundWidgets, UClassStackOnlyPtr Interface, bool TopLevelOnly)
		{
			UWidgetBlueprintLibrary.__GetAllWidgetsWithInterface_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FoundWidgets ?? new TArray<UUserWidget>()).NativePtr, Interface._NativePtr, TopLevelOnly);
		}

		// Token: 0x0600BCA0 RID: 48288 RVA: 0x0012D777 File Offset: 0x0012B977
		public static void GetAllWidgetsOfClass(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUserWidget> FoundWidgets, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UUserWidget> WidgetClass, bool TopLevelOnly = true)
		{
			UWidgetBlueprintLibrary.__GetAllWidgetsOfClass_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FoundWidgets ?? new TArray<UUserWidget>()).NativePtr, WidgetClass._NativePtr, TopLevelOnly);
		}

		// Token: 0x0600BCA1 RID: 48289
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DismissAllMenus();

		// Token: 0x0600BCA2 RID: 48290 RVA: 0x0012D7A5 File Offset: 0x0012B9A5
		public static UUserWidget Create(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UUserWidget> WidgetType, APlayerController OwningPlayer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetBlueprintLibrary.__Create_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WidgetType._NativePtr, (OwningPlayer != null) ? OwningPlayer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0600BCA3 RID: 48291
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelDragDrop();

		// Token: 0x0600BCA4 RID: 48292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowTitleBarOnCloseClickedDelegate_Internal(IntPtr Delegate);

		// Token: 0x0600BCA5 RID: 48293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_UIOnly_Internal(IntPtr Target, IntPtr InWidgetToFocus, bool bLockMouseToViewport);

		// Token: 0x0600BCA6 RID: 48294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_GameOnly_Internal(IntPtr PlayerController);

		// Token: 0x0600BCA7 RID: 48295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_GameAndUI_Internal(IntPtr Target, IntPtr InWidgetToFocus, bool bLockMouseToViewport, bool bHideCursorDuringCapture);

		// Token: 0x0600BCA8 RID: 48296
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetHardwareCursor_Internal(IntPtr WorldContextObject, TEnumAsByte<EMouseCursor> CursorShape, FName CursorName, FVector2D HotSpot);

		// Token: 0x0600BCA9 RID: 48297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSafeZonePadding_Internal(IntPtr WorldContextObject, ref FVector4 SafePadding, ref FVector2D SafePaddingScale, ref FVector4 SpillOverPadding);

		// Token: 0x0600BCAA RID: 48298
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllWidgetsWithInterface_Internal(IntPtr WorldContextObject, IntPtr FoundWidgets, IntPtr Interface, bool TopLevelOnly);

		// Token: 0x0600BCAB RID: 48299
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllWidgetsOfClass_Internal(IntPtr WorldContextObject, IntPtr FoundWidgets, IntPtr WidgetClass, bool TopLevelOnly);

		// Token: 0x0600BCAC RID: 48300
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Create_Internal(IntPtr WorldContextObject, IntPtr WidgetType, IntPtr OwningPlayer);

		// Token: 0x0600BCAD RID: 48301 RVA: 0x0012D7D7 File Offset: 0x0012B9D7
		static UWidgetBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetBlueprintLibrary");
		}

		// Token: 0x0600BCAE RID: 48302 RVA: 0x0012D7E5 File Offset: 0x0012B9E5
		protected UWidgetBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005546 RID: 21830
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetBlueprintLibrary";

		// Token: 0x04005547 RID: 21831
		private static IntPtr _ClassPtr;

		// Token: 0x04005548 RID: 21832
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005549 RID: 21833
		public static IntPtr __OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr;
	}
}
