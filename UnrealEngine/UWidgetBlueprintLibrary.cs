using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020029FE RID: 10750
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/UMG.WidgetBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UWidgetBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027E45 RID: 163397 RVA: 0x003CC66A File Offset: 0x003CA86A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UWidgetBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06027E46 RID: 163398 RVA: 0x003CC678 File Offset: 0x003CA878
		public UWidgetBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027E47 RID: 163399 RVA: 0x003CC6A0 File Offset: 0x003CA8A0
		[NullableContext(1)]
		public UWidgetBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UWidgetBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027E48 RID: 163400 RVA: 0x003CC6D3 File Offset: 0x003CA8D3
		[NullableContext(1)]
		public static FEventReply UnlockMouse([Nullable(2)] ref FEventReply Reply)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__UnlockMouse_Internal((Reply ?? new FEventReply()).NativePtr), null);
		}

		// Token: 0x06027E49 RID: 163401 RVA: 0x003CC6F0 File Offset: 0x003CA8F0
		[NullableContext(1)]
		public static FEventReply Unhandled()
		{
			return new FEventReply(UWidgetBlueprintLibrary.__Unhandled_Internal(), null);
		}

		// Token: 0x06027E4A RID: 163402 RVA: 0x003CC6FD File Offset: 0x003CA8FD
		public static void SetWindowTitleBarState(UWidget TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible)
		{
			UWidgetBlueprintLibrary.__SetWindowTitleBarState_Internal((TitleBarContent != null) ? TitleBarContent.NativePtr : IntPtr.Zero, Mode, bTitleBarDragEnabled, bWindowButtonsVisible, bTitleBarVisible);
		}

		// Token: 0x06027E4B RID: 163403 RVA: 0x003CC719 File Offset: 0x003CA919
		public static void SetWindowTitleBarOnCloseClickedDelegate(FOnGameWindowCloseButtonClickedDelegate Delegate)
		{
			UWidgetBlueprintLibrary.__SetWindowTitleBarOnCloseClickedDelegate_Internal((Delegate != null) ? Delegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x06027E4C RID: 163404
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetWindowTitleBarCloseButtonActive(bool bActive);

		// Token: 0x06027E4D RID: 163405 RVA: 0x003CC72D File Offset: 0x003CA92D
		[return: Nullable(1)]
		public static FEventReply SetUserFocus(ref FEventReply Reply, UWidget FocusWidget, bool bInAllUsers = false)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__SetUserFocus_Internal((Reply ?? new FEventReply()).NativePtr, (FocusWidget != null) ? FocusWidget.NativePtr : IntPtr.Zero, bInAllUsers), null);
		}

		// Token: 0x06027E4E RID: 163406 RVA: 0x003CC75B File Offset: 0x003CA95B
		[NullableContext(1)]
		public static FEventReply SetMousePosition([Nullable(2)] ref FEventReply Reply, FVector2D NewMousePosition)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__SetMousePosition_Internal((Reply ?? new FEventReply()).NativePtr, NewMousePosition), null);
		}

		// Token: 0x06027E4F RID: 163407 RVA: 0x003CC779 File Offset: 0x003CA979
		public static void SetInputMode_UIOnlyEx(APlayerController PlayerController, UWidget InWidgetToFocus = null, EMouseLockMode InMouseLockMode = EMouseLockMode.DoNotLock)
		{
			UWidgetBlueprintLibrary.__SetInputMode_UIOnlyEx_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, InMouseLockMode);
		}

		// Token: 0x06027E50 RID: 163408 RVA: 0x003CC7A1 File Offset: 0x003CA9A1
		public static void SetInputMode_UIOnly(APlayerController Target, UWidget InWidgetToFocus = null, bool bLockMouseToViewport = false)
		{
			UWidgetBlueprintLibrary.__SetInputMode_UIOnly_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, bLockMouseToViewport);
		}

		// Token: 0x06027E51 RID: 163409 RVA: 0x003CC7C9 File Offset: 0x003CA9C9
		public static void SetInputMode_GameOnly(APlayerController PlayerController)
		{
			UWidgetBlueprintLibrary.__SetInputMode_GameOnly_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027E52 RID: 163410 RVA: 0x003CC7E0 File Offset: 0x003CA9E0
		public static void SetInputMode_GameAndUIEx(APlayerController PlayerController, UWidget InWidgetToFocus = null, EMouseLockMode InMouseLockMode = EMouseLockMode.DoNotLock, bool bHideCursorDuringCapture = true)
		{
			UWidgetBlueprintLibrary.__SetInputMode_GameAndUIEx_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, InMouseLockMode, bHideCursorDuringCapture);
		}

		// Token: 0x06027E53 RID: 163411 RVA: 0x003CC809 File Offset: 0x003CAA09
		public static void SetInputMode_GameAndUI(APlayerController Target, UWidget InWidgetToFocus = null, bool bLockMouseToViewport = false, bool bHideCursorDuringCapture = true)
		{
			UWidgetBlueprintLibrary.__SetInputMode_GameAndUI_Internal((Target != null) ? Target.NativePtr : IntPtr.Zero, (InWidgetToFocus != null) ? InWidgetToFocus.NativePtr : IntPtr.Zero, bLockMouseToViewport, bHideCursorDuringCapture);
		}

		// Token: 0x06027E54 RID: 163412 RVA: 0x003CC832 File Offset: 0x003CAA32
		public static bool SetHardwareCursor(UObject WorldContextObject, EMouseCursor CursorShape, FName CursorName, FVector2D HotSpot)
		{
			return UWidgetBlueprintLibrary.__SetHardwareCursor_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, CursorShape, CursorName, HotSpot);
		}

		// Token: 0x06027E55 RID: 163413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetFocusToGameViewport();

		// Token: 0x06027E56 RID: 163414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetColorVisionDeficiencyType(EColorVisionDeficiency Type, float Severity, bool CorrectDeficiency, bool ShowCorrectionWithDeficiency);

		// Token: 0x06027E57 RID: 163415 RVA: 0x003CC851 File Offset: 0x003CAA51
		public static void SetBrushResourceToTexture(ref FSlateBrush Brush, UTexture2D Texture)
		{
			UWidgetBlueprintLibrary.__SetBrushResourceToTexture_Internal((Brush ?? new FSlateBrush()).NativePtr, (Texture != null) ? Texture.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027E58 RID: 163416 RVA: 0x003CC878 File Offset: 0x003CAA78
		public static void SetBrushResourceToMaterial(ref FSlateBrush Brush, UMaterialInterface Material)
		{
			UWidgetBlueprintLibrary.__SetBrushResourceToMaterial_Internal((Brush ?? new FSlateBrush()).NativePtr, (Material != null) ? Material.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06027E59 RID: 163417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RestorePreviousWindowTitleBarState();

		// Token: 0x06027E5A RID: 163418 RVA: 0x003CC89F File Offset: 0x003CAA9F
		[NullableContext(1)]
		public static FEventReply ReleaseMouseCapture([Nullable(2)] ref FEventReply Reply)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__ReleaseMouseCapture_Internal((Reply ?? new FEventReply()).NativePtr), null);
		}

		// Token: 0x06027E5B RID: 163419 RVA: 0x003CC8BC File Offset: 0x003CAABC
		[NullableContext(1)]
		public static FEventReply ReleaseJoystickCapture([Nullable(2)] ref FEventReply Reply, bool bInAllJoysticks = false)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__ReleaseJoystickCapture_Internal((Reply ?? new FEventReply()).NativePtr, bInAllJoysticks), null);
		}

		// Token: 0x06027E5C RID: 163420 RVA: 0x003CC8DA File Offset: 0x003CAADA
		[NullableContext(1)]
		public static FSlateBrush NoResourceBrush()
		{
			return new FSlateBrush(UWidgetBlueprintLibrary.__NoResourceBrush_Internal(), null);
		}

		// Token: 0x06027E5D RID: 163421 RVA: 0x003CC8E7 File Offset: 0x003CAAE7
		[NullableContext(1)]
		public static FSlateBrush MakeBrushFromTexture([Nullable(2)] UTexture2D Texture, int Width = 0, int Height = 0)
		{
			return new FSlateBrush(UWidgetBlueprintLibrary.__MakeBrushFromTexture_Internal((Texture != null) ? Texture.NativePtr : IntPtr.Zero, Width, Height), null);
		}

		// Token: 0x06027E5E RID: 163422 RVA: 0x003CC906 File Offset: 0x003CAB06
		[NullableContext(1)]
		public static FSlateBrush MakeBrushFromMaterial([Nullable(2)] UMaterialInterface Material, int Width = 32, int Height = 32)
		{
			return new FSlateBrush(UWidgetBlueprintLibrary.__MakeBrushFromMaterial_Internal((Material != null) ? Material.NativePtr : IntPtr.Zero, Width, Height), null);
		}

		// Token: 0x06027E5F RID: 163423 RVA: 0x003CC925 File Offset: 0x003CAB25
		[NullableContext(1)]
		public static FSlateBrush MakeBrushFromAsset([Nullable(2)] USlateBrushAsset BrushAsset)
		{
			return new FSlateBrush(UWidgetBlueprintLibrary.__MakeBrushFromAsset_Internal((BrushAsset != null) ? BrushAsset.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06027E60 RID: 163424 RVA: 0x003CC942 File Offset: 0x003CAB42
		[return: Nullable(1)]
		public static FEventReply LockMouse(ref FEventReply Reply, UWidget CapturingWidget)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__LockMouse_Internal((Reply ?? new FEventReply()).NativePtr, (CapturingWidget != null) ? CapturingWidget.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06027E61 RID: 163425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDragDropping();

		// Token: 0x06027E62 RID: 163426 RVA: 0x003CC96F File Offset: 0x003CAB6F
		[NullableContext(1)]
		public static FEventReply Handled()
		{
			return new FEventReply(UWidgetBlueprintLibrary.__Handled_Internal(), null);
		}

		// Token: 0x06027E63 RID: 163427 RVA: 0x003CC97C File Offset: 0x003CAB7C
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

		// Token: 0x06027E64 RID: 163428 RVA: 0x003CC9F9 File Offset: 0x003CABF9
		[NullableContext(1)]
		public static FKeyEvent GetKeyEventFromAnalogInputEvent([Nullable(2)] in FAnalogInputEvent Event)
		{
			return new FKeyEvent(UWidgetBlueprintLibrary.__GetKeyEventFromAnalogInputEvent_Internal((Event ?? new FAnalogInputEvent()).NativePtr), null);
		}

		// Token: 0x06027E65 RID: 163429 RVA: 0x003CCA16 File Offset: 0x003CAC16
		[NullableContext(1)]
		public static FInputEvent GetInputEventFromPointerEvent([Nullable(2)] in FPointerEvent Event)
		{
			return new FInputEvent(UWidgetBlueprintLibrary.__GetInputEventFromPointerEvent_Internal((Event ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x06027E66 RID: 163430 RVA: 0x003CCA33 File Offset: 0x003CAC33
		[NullableContext(1)]
		public static FInputEvent GetInputEventFromNavigationEvent([Nullable(2)] in FNavigationEvent Event)
		{
			return new FInputEvent(UWidgetBlueprintLibrary.__GetInputEventFromNavigationEvent_Internal((Event ?? new FNavigationEvent()).NativePtr), null);
		}

		// Token: 0x06027E67 RID: 163431 RVA: 0x003CCA50 File Offset: 0x003CAC50
		[NullableContext(1)]
		public static FInputEvent GetInputEventFromKeyEvent([Nullable(2)] in FKeyEvent Event)
		{
			return new FInputEvent(UWidgetBlueprintLibrary.__GetInputEventFromKeyEvent_Internal((Event ?? new FKeyEvent()).NativePtr), null);
		}

		// Token: 0x06027E68 RID: 163432 RVA: 0x003CCA6D File Offset: 0x003CAC6D
		[NullableContext(1)]
		public static FInputEvent GetInputEventFromCharacterEvent([Nullable(2)] in FCharacterEvent Event)
		{
			return new FInputEvent(UWidgetBlueprintLibrary.__GetInputEventFromCharacterEvent_Internal((Event ?? new FCharacterEvent()).NativePtr), null);
		}

		// Token: 0x06027E69 RID: 163433 RVA: 0x003CCA8A File Offset: 0x003CAC8A
		public static UMaterialInstanceDynamic GetDynamicMaterial(ref FSlateBrush Brush)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInstanceDynamic>(UWidgetBlueprintLibrary.__GetDynamicMaterial_Internal((Brush ?? new FSlateBrush()).NativePtr));
		}

		// Token: 0x06027E6A RID: 163434 RVA: 0x003CCAA6 File Offset: 0x003CACA6
		public static UDragDropOperation GetDragDroppingContent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDragDropOperation>(UWidgetBlueprintLibrary.__GetDragDroppingContent_Internal());
		}

		// Token: 0x06027E6B RID: 163435 RVA: 0x003CCAB2 File Offset: 0x003CACB2
		public static UTexture2D GetBrushResourceAsTexture2D(in FSlateBrush Brush)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UTexture2D>(UWidgetBlueprintLibrary.__GetBrushResourceAsTexture2D_Internal((Brush ?? new FSlateBrush()).NativePtr));
		}

		// Token: 0x06027E6C RID: 163436 RVA: 0x003CCACE File Offset: 0x003CACCE
		public static UMaterialInterface GetBrushResourceAsMaterial(in FSlateBrush Brush)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMaterialInterface>(UWidgetBlueprintLibrary.__GetBrushResourceAsMaterial_Internal((Brush ?? new FSlateBrush()).NativePtr));
		}

		// Token: 0x06027E6D RID: 163437 RVA: 0x003CCAEA File Offset: 0x003CACEA
		public static UObject GetBrushResource(in FSlateBrush Brush)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UWidgetBlueprintLibrary.__GetBrushResource_Internal((Brush ?? new FSlateBrush()).NativePtr));
		}

		// Token: 0x06027E6E RID: 163438 RVA: 0x003CCB06 File Offset: 0x003CAD06
		public static void GetAllWidgetsWithInterface(UObject WorldContextObject, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UUserWidget> FoundWidgets, UClassStackOnlyPtr Interface, bool TopLevelOnly)
		{
			UWidgetBlueprintLibrary.__GetAllWidgetsWithInterface_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (FoundWidgets ?? new TArray<UUserWidget>()).NativePtr, Interface._NativePtr, TopLevelOnly);
		}

		// Token: 0x06027E6F RID: 163439 RVA: 0x003CCB34 File Offset: 0x003CAD34
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

		// Token: 0x06027E70 RID: 163440 RVA: 0x003CCB62 File Offset: 0x003CAD62
		[NullableContext(1)]
		public static FEventReply EndDragDrop([Nullable(2)] ref FEventReply Reply)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__EndDragDrop_Internal((Reply ?? new FEventReply()).NativePtr), null);
		}

		// Token: 0x06027E71 RID: 163441 RVA: 0x003CCB80 File Offset: 0x003CAD80
		public static void DrawTextFormatted(ref FPaintContext Context, [Nullable(1)] in FText Text, FVector2D Position, UFont Font, int FontSize = 16, FName? FontTypeFace = null, FLinearColor? Tint = null)
		{
			IntPtr nativePtr = (Context ?? new FPaintContext()).NativePtr;
			FText ftext = Text;
			UWidgetBlueprintLibrary.__DrawTextFormatted_Internal(nativePtr, (ftext != null) ? ftext.NativePtr : IntPtr.Zero, Position, (Font != null) ? Font.NativePtr : IntPtr.Zero, FontSize, FontTypeFace ?? new FName("Regular"), Tint ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06027E72 RID: 163442 RVA: 0x003CCC34 File Offset: 0x003CAE34
		[NullableContext(1)]
		public unsafe static void DrawText([Nullable(2)] ref FPaintContext Context, string InString, FVector2D Position, FLinearColor? Tint = null)
		{
			FString fstring = FString.AllocTemp(InString);
			UWidgetBlueprintLibrary.__DrawText_Internal((Context ?? new FPaintContext()).NativePtr, fstring, Position, Tint ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06027E73 RID: 163443 RVA: 0x003CCCB8 File Offset: 0x003CAEB8
		public static void DrawLines(ref FPaintContext Context, in TArray<FVector2D> Points, FLinearColor? Tint = null, bool bAntiAlias = true, float Thickness = 1f)
		{
			UWidgetBlueprintLibrary.__DrawLines_Internal((Context ?? new FPaintContext()).NativePtr, (Points ?? new TArray<FVector2D>()).NativePtr, Tint ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, bAntiAlias, Thickness);
		}

		// Token: 0x06027E74 RID: 163444 RVA: 0x003CCD3C File Offset: 0x003CAF3C
		public static void DrawLine(ref FPaintContext Context, FVector2D PositionA, FVector2D PositionB, FLinearColor? Tint = null, bool bAntiAlias = true, float Thickness = 1f)
		{
			UWidgetBlueprintLibrary.__DrawLine_Internal((Context ?? new FPaintContext()).NativePtr, PositionA, PositionB, Tint ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			}, bAntiAlias, Thickness);
		}

		// Token: 0x06027E75 RID: 163445 RVA: 0x003CCDB0 File Offset: 0x003CAFB0
		public static void DrawBox(ref FPaintContext Context, FVector2D Position, FVector2D Size, USlateBrushAsset Brush, FLinearColor? Tint = null)
		{
			UWidgetBlueprintLibrary.__DrawBox_Internal((Context ?? new FPaintContext()).NativePtr, Position, Size, (Brush != null) ? Brush.NativePtr : IntPtr.Zero, Tint ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x06027E76 RID: 163446
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DismissAllMenus();

		// Token: 0x06027E77 RID: 163447 RVA: 0x003CCE31 File Offset: 0x003CB031
		[return: Nullable(1)]
		public static FEventReply DetectDragIfPressed(in FPointerEvent PointerEvent, UWidget WidgetDetectingDrag, FKey DragKey)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__DetectDragIfPressed_Internal((PointerEvent ?? new FPointerEvent()).NativePtr, (WidgetDetectingDrag != null) ? WidgetDetectingDrag.NativePtr : IntPtr.Zero, (DragKey ?? new FKey()).NativePtr), null);
		}

		// Token: 0x06027E78 RID: 163448 RVA: 0x003CCE6D File Offset: 0x003CB06D
		[return: Nullable(1)]
		public static FEventReply DetectDrag(ref FEventReply Reply, UWidget WidgetDetectingDrag, FKey DragKey)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__DetectDrag_Internal((Reply ?? new FEventReply()).NativePtr, (WidgetDetectingDrag != null) ? WidgetDetectingDrag.NativePtr : IntPtr.Zero, (DragKey ?? new FKey()).NativePtr), null);
		}

		// Token: 0x06027E79 RID: 163449 RVA: 0x003CCEA9 File Offset: 0x003CB0A9
		public static UDragDropOperation CreateDragDropOperation([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UDragDropOperation> OperationClass)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UDragDropOperation>(UWidgetBlueprintLibrary.__CreateDragDropOperation_Internal(OperationClass._NativePtr));
		}

		// Token: 0x06027E7A RID: 163450 RVA: 0x003CCEBB File Offset: 0x003CB0BB
		public static UUserWidget Create(UObject WorldContextObject, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UUserWidget> WidgetType, APlayerController OwningPlayer)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUserWidget>(UWidgetBlueprintLibrary.__Create_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, WidgetType._NativePtr, (OwningPlayer != null) ? OwningPlayer.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06027E7B RID: 163451 RVA: 0x003CCEED File Offset: 0x003CB0ED
		[NullableContext(1)]
		public static FEventReply ClearUserFocus([Nullable(2)] ref FEventReply Reply, bool bInAllUsers = false)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__ClearUserFocus_Internal((Reply ?? new FEventReply()).NativePtr, bInAllUsers), null);
		}

		// Token: 0x06027E7C RID: 163452 RVA: 0x003CCF0B File Offset: 0x003CB10B
		[return: Nullable(1)]
		public static FEventReply CaptureMouse(ref FEventReply Reply, UWidget CapturingWidget)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__CaptureMouse_Internal((Reply ?? new FEventReply()).NativePtr, (CapturingWidget != null) ? CapturingWidget.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06027E7D RID: 163453 RVA: 0x003CCF38 File Offset: 0x003CB138
		[return: Nullable(1)]
		public static FEventReply CaptureJoystick(ref FEventReply Reply, UWidget CapturingWidget, bool bInAllJoysticks = false)
		{
			return new FEventReply(UWidgetBlueprintLibrary.__CaptureJoystick_Internal((Reply ?? new FEventReply()).NativePtr, (CapturingWidget != null) ? CapturingWidget.NativePtr : IntPtr.Zero, bInAllJoysticks), null);
		}

		// Token: 0x06027E7E RID: 163454
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CancelDragDrop();

		// Token: 0x06027E7F RID: 163455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __UnlockMouse_Internal(IntPtr Reply);

		// Token: 0x06027E80 RID: 163456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Unhandled_Internal();

		// Token: 0x06027E81 RID: 163457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowTitleBarState_Internal(IntPtr TitleBarContent, EWindowTitleBarMode Mode, bool bTitleBarDragEnabled, bool bWindowButtonsVisible, bool bTitleBarVisible);

		// Token: 0x06027E82 RID: 163458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetWindowTitleBarOnCloseClickedDelegate_Internal(IntPtr Delegate);

		// Token: 0x06027E83 RID: 163459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUserFocus_Internal(IntPtr Reply, IntPtr FocusWidget, bool bInAllUsers);

		// Token: 0x06027E84 RID: 163460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetMousePosition_Internal(IntPtr Reply, FVector2D NewMousePosition);

		// Token: 0x06027E85 RID: 163461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_UIOnlyEx_Internal(IntPtr PlayerController, IntPtr InWidgetToFocus, EMouseLockMode InMouseLockMode);

		// Token: 0x06027E86 RID: 163462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_UIOnly_Internal(IntPtr Target, IntPtr InWidgetToFocus, bool bLockMouseToViewport);

		// Token: 0x06027E87 RID: 163463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_GameOnly_Internal(IntPtr PlayerController);

		// Token: 0x06027E88 RID: 163464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_GameAndUIEx_Internal(IntPtr PlayerController, IntPtr InWidgetToFocus, EMouseLockMode InMouseLockMode, bool bHideCursorDuringCapture);

		// Token: 0x06027E89 RID: 163465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetInputMode_GameAndUI_Internal(IntPtr Target, IntPtr InWidgetToFocus, bool bLockMouseToViewport, bool bHideCursorDuringCapture);

		// Token: 0x06027E8A RID: 163466
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetHardwareCursor_Internal(IntPtr WorldContextObject, TEnumAsByte<EMouseCursor> CursorShape, FName CursorName, FVector2D HotSpot);

		// Token: 0x06027E8B RID: 163467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushResourceToTexture_Internal(IntPtr Brush, IntPtr Texture);

		// Token: 0x06027E8C RID: 163468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBrushResourceToMaterial_Internal(IntPtr Brush, IntPtr Material);

		// Token: 0x06027E8D RID: 163469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ReleaseMouseCapture_Internal(IntPtr Reply);

		// Token: 0x06027E8E RID: 163470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ReleaseJoystickCapture_Internal(IntPtr Reply, bool bInAllJoysticks);

		// Token: 0x06027E8F RID: 163471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __NoResourceBrush_Internal();

		// Token: 0x06027E90 RID: 163472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeBrushFromTexture_Internal(IntPtr Texture, int Width, int Height);

		// Token: 0x06027E91 RID: 163473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeBrushFromMaterial_Internal(IntPtr Material, int Width, int Height);

		// Token: 0x06027E92 RID: 163474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeBrushFromAsset_Internal(IntPtr BrushAsset);

		// Token: 0x06027E93 RID: 163475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __LockMouse_Internal(IntPtr Reply, IntPtr CapturingWidget);

		// Token: 0x06027E94 RID: 163476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Handled_Internal();

		// Token: 0x06027E95 RID: 163477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSafeZonePadding_Internal(IntPtr WorldContextObject, ref FVector4 SafePadding, ref FVector2D SafePaddingScale, ref FVector4 SpillOverPadding);

		// Token: 0x06027E96 RID: 163478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKeyEventFromAnalogInputEvent_Internal(IntPtr Event);

		// Token: 0x06027E97 RID: 163479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputEventFromPointerEvent_Internal(IntPtr Event);

		// Token: 0x06027E98 RID: 163480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputEventFromNavigationEvent_Internal(IntPtr Event);

		// Token: 0x06027E99 RID: 163481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputEventFromKeyEvent_Internal(IntPtr Event);

		// Token: 0x06027E9A RID: 163482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetInputEventFromCharacterEvent_Internal(IntPtr Event);

		// Token: 0x06027E9B RID: 163483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDynamicMaterial_Internal(IntPtr Brush);

		// Token: 0x06027E9C RID: 163484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDragDroppingContent_Internal();

		// Token: 0x06027E9D RID: 163485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBrushResourceAsTexture2D_Internal(IntPtr Brush);

		// Token: 0x06027E9E RID: 163486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBrushResourceAsMaterial_Internal(IntPtr Brush);

		// Token: 0x06027E9F RID: 163487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBrushResource_Internal(IntPtr Brush);

		// Token: 0x06027EA0 RID: 163488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllWidgetsWithInterface_Internal(IntPtr WorldContextObject, IntPtr FoundWidgets, IntPtr Interface, bool TopLevelOnly);

		// Token: 0x06027EA1 RID: 163489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAllWidgetsOfClass_Internal(IntPtr WorldContextObject, IntPtr FoundWidgets, IntPtr WidgetClass, bool TopLevelOnly);

		// Token: 0x06027EA2 RID: 163490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __EndDragDrop_Internal(IntPtr Reply);

		// Token: 0x06027EA3 RID: 163491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawTextFormatted_Internal(IntPtr Context, IntPtr Text, FVector2D Position, IntPtr Font, int FontSize, FName FontTypeFace, FLinearColor Tint);

		// Token: 0x06027EA4 RID: 163492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawText_Internal(IntPtr Context, in FString InString, FVector2D Position, FLinearColor Tint);

		// Token: 0x06027EA5 RID: 163493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawLines_Internal(IntPtr Context, IntPtr Points, FLinearColor Tint, bool bAntiAlias, float Thickness);

		// Token: 0x06027EA6 RID: 163494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawLine_Internal(IntPtr Context, FVector2D PositionA, FVector2D PositionB, FLinearColor Tint, bool bAntiAlias, float Thickness);

		// Token: 0x06027EA7 RID: 163495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DrawBox_Internal(IntPtr Context, FVector2D Position, FVector2D Size, IntPtr Brush, FLinearColor Tint);

		// Token: 0x06027EA8 RID: 163496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DetectDragIfPressed_Internal(IntPtr PointerEvent, IntPtr WidgetDetectingDrag, IntPtr DragKey);

		// Token: 0x06027EA9 RID: 163497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DetectDrag_Internal(IntPtr Reply, IntPtr WidgetDetectingDrag, IntPtr DragKey);

		// Token: 0x06027EAA RID: 163498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CreateDragDropOperation_Internal(IntPtr OperationClass);

		// Token: 0x06027EAB RID: 163499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Create_Internal(IntPtr WorldContextObject, IntPtr WidgetType, IntPtr OwningPlayer);

		// Token: 0x06027EAC RID: 163500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __ClearUserFocus_Internal(IntPtr Reply, bool bInAllUsers);

		// Token: 0x06027EAD RID: 163501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CaptureMouse_Internal(IntPtr Reply, IntPtr CapturingWidget);

		// Token: 0x06027EAE RID: 163502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __CaptureJoystick_Internal(IntPtr Reply, IntPtr CapturingWidget, bool bInAllJoysticks);

		// Token: 0x06027EAF RID: 163503 RVA: 0x003CCF66 File Offset: 0x003CB166
		static UWidgetBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/UMG.WidgetBlueprintLibrary");
		}

		// Token: 0x06027EB0 RID: 163504 RVA: 0x003CCF74 File Offset: 0x003CB174
		protected UWidgetBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015CE3 RID: 89315
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/UMG.WidgetBlueprintLibrary";

		// Token: 0x04015CE4 RID: 89316
		private static IntPtr _ClassPtr;

		// Token: 0x04015CE5 RID: 89317
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015CE6 RID: 89318
		public static IntPtr __OnGameWindowCloseButtonClickedDelegate__DelegateSignature_NativeFunctionPtr;
	}
}
