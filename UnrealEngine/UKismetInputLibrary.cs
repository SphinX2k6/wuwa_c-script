using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CCE RID: 3278
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetInputLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetInputLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A5B5 RID: 42421 RVA: 0x000EC5C1 File Offset: 0x000EA7C1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetInputLibrary._ClassPtr;
		}

		// Token: 0x0600A5B6 RID: 42422 RVA: 0x000EC5D0 File Offset: 0x000EA7D0
		public UKismetInputLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetInputLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A5B7 RID: 42423 RVA: 0x000EC5F8 File Offset: 0x000EA7F8
		[NullableContext(1)]
		public UKismetInputLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetInputLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A5B8 RID: 42424 RVA: 0x000EC62B File Offset: 0x000EA82B
		public static bool PointerEvent_IsTouchEvent(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_IsTouchEvent_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5B9 RID: 42425 RVA: 0x000EC642 File Offset: 0x000EA842
		public static bool PointerEvent_IsMouseButtonDown(in FPointerEvent Input, FKey MouseButton)
		{
			return UKismetInputLibrary.__PointerEvent_IsMouseButtonDown_Internal((Input ?? new FPointerEvent()).NativePtr, (MouseButton ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5BA RID: 42426 RVA: 0x000EC668 File Offset: 0x000EA868
		public static float PointerEvent_GetWheelDelta(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetWheelDelta_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5BB RID: 42427 RVA: 0x000EC67F File Offset: 0x000EA87F
		public static int PointerEvent_GetUserIndex(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetUserIndex_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5BC RID: 42428 RVA: 0x000EC696 File Offset: 0x000EA896
		public static int PointerEvent_GetTouchpadIndex(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetTouchpadIndex_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5BD RID: 42429 RVA: 0x000EC6AD File Offset: 0x000EA8AD
		public static FVector2D PointerEvent_GetScreenSpacePosition(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetScreenSpacePosition_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5BE RID: 42430 RVA: 0x000EC6C4 File Offset: 0x000EA8C4
		public static int PointerEvent_GetPointerIndex(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetPointerIndex_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5BF RID: 42431 RVA: 0x000EC6DB File Offset: 0x000EA8DB
		public static FVector2D PointerEvent_GetLastScreenSpacePosition(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetLastScreenSpacePosition_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5C0 RID: 42432 RVA: 0x000EC6F2 File Offset: 0x000EA8F2
		public static ESlateGesture PointerEvent_GetGestureType(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetGestureType_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5C1 RID: 42433 RVA: 0x000EC709 File Offset: 0x000EA909
		public static FVector2D PointerEvent_GetGestureDelta(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetGestureDelta_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5C2 RID: 42434 RVA: 0x000EC720 File Offset: 0x000EA920
		[NullableContext(1)]
		public static FKey PointerEvent_GetEffectingButton([Nullable(2)] in FPointerEvent Input)
		{
			return new FKey(UKismetInputLibrary.__PointerEvent_GetEffectingButton_Internal((Input ?? new FPointerEvent()).NativePtr), null);
		}

		// Token: 0x0600A5C3 RID: 42435 RVA: 0x000EC73D File Offset: 0x000EA93D
		public static FVector2D PointerEvent_GetCursorDelta(in FPointerEvent Input)
		{
			return UKismetInputLibrary.__PointerEvent_GetCursorDelta_Internal((Input ?? new FPointerEvent()).NativePtr);
		}

		// Token: 0x0600A5C4 RID: 42436 RVA: 0x000EC754 File Offset: 0x000EA954
		public static bool Key_IsVectorAxis(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsVectorAxis_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5C5 RID: 42437 RVA: 0x000EC76B File Offset: 0x000EA96B
		public static bool Key_IsValid(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsValid_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5C6 RID: 42438 RVA: 0x000EC782 File Offset: 0x000EA982
		public static bool Key_IsMouseButton(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsMouseButton_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5C7 RID: 42439 RVA: 0x000EC799 File Offset: 0x000EA999
		public static bool Key_IsModifierKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsModifierKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5C8 RID: 42440 RVA: 0x000EC7B0 File Offset: 0x000EA9B0
		public static bool Key_IsKeyboardKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsKeyboardKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5C9 RID: 42441 RVA: 0x000EC7C7 File Offset: 0x000EA9C7
		public static bool Key_IsGamepadKey(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsGamepadKey_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CA RID: 42442 RVA: 0x000EC7DE File Offset: 0x000EA9DE
		public static bool Key_IsDigital(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsDigital_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CB RID: 42443 RVA: 0x000EC7F5 File Offset: 0x000EA9F5
		public static bool Key_IsButtonAxis(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsButtonAxis_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CC RID: 42444 RVA: 0x000EC80C File Offset: 0x000EAA0C
		public static bool Key_IsAxis3D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis3D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CD RID: 42445 RVA: 0x000EC823 File Offset: 0x000EAA23
		public static bool Key_IsAxis2D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis2D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CE RID: 42446 RVA: 0x000EC83A File Offset: 0x000EAA3A
		public static bool Key_IsAxis1D(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAxis1D_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5CF RID: 42447 RVA: 0x000EC851 File Offset: 0x000EAA51
		public static bool Key_IsAnalog(in FKey Key)
		{
			return UKismetInputLibrary.__Key_IsAnalog_Internal((Key ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5D0 RID: 42448 RVA: 0x000EC868 File Offset: 0x000EAA68
		public static EUINavigation Key_GetNavigationDirectionFromKey(in FKeyEvent InKeyEvent)
		{
			return UKismetInputLibrary.__Key_GetNavigationDirectionFromKey_Internal((InKeyEvent ?? new FKeyEvent()).NativePtr);
		}

		// Token: 0x0600A5D1 RID: 42449 RVA: 0x000EC87F File Offset: 0x000EAA7F
		public static EUINavigation Key_GetNavigationDirectionFromAnalog(in FAnalogInputEvent InAnalogEvent)
		{
			return UKismetInputLibrary.__Key_GetNavigationDirectionFromAnalog_Internal((InAnalogEvent ?? new FAnalogInputEvent()).NativePtr);
		}

		// Token: 0x0600A5D2 RID: 42450 RVA: 0x000EC896 File Offset: 0x000EAA96
		public static EUINavigationAction Key_GetNavigationActionFromKey(in FKeyEvent InKeyEvent)
		{
			return UKismetInputLibrary.__Key_GetNavigationActionFromKey_Internal((InKeyEvent ?? new FKeyEvent()).NativePtr);
		}

		// Token: 0x0600A5D3 RID: 42451 RVA: 0x000EC8AD File Offset: 0x000EAAAD
		public static EUINavigationAction Key_GetNavigationAction(in FKey InKey)
		{
			return UKismetInputLibrary.__Key_GetNavigationAction_Internal((InKey ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5D4 RID: 42452 RVA: 0x000EC8C4 File Offset: 0x000EAAC4
		[NullableContext(1)]
		public static FText Key_GetDisplayName([Nullable(2)] in FKey Key)
		{
			return new FText(UKismetInputLibrary.__Key_GetDisplayName_Internal((Key ?? new FKey()).NativePtr), null);
		}

		// Token: 0x0600A5D5 RID: 42453 RVA: 0x000EC8E1 File Offset: 0x000EAAE1
		public static bool InputEvent_IsShiftDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsShiftDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5D6 RID: 42454 RVA: 0x000EC8F8 File Offset: 0x000EAAF8
		public static bool InputEvent_IsRightShiftDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsRightShiftDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5D7 RID: 42455 RVA: 0x000EC90F File Offset: 0x000EAB0F
		public static bool InputEvent_IsRightControlDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsRightControlDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5D8 RID: 42456 RVA: 0x000EC926 File Offset: 0x000EAB26
		public static bool InputEvent_IsRightCommandDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsRightCommandDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5D9 RID: 42457 RVA: 0x000EC93D File Offset: 0x000EAB3D
		public static bool InputEvent_IsRightAltDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsRightAltDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DA RID: 42458 RVA: 0x000EC954 File Offset: 0x000EAB54
		public static bool InputEvent_IsRepeat(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsRepeat_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DB RID: 42459 RVA: 0x000EC96B File Offset: 0x000EAB6B
		public static bool InputEvent_IsLeftShiftDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsLeftShiftDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DC RID: 42460 RVA: 0x000EC982 File Offset: 0x000EAB82
		public static bool InputEvent_IsLeftControlDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsLeftControlDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DD RID: 42461 RVA: 0x000EC999 File Offset: 0x000EAB99
		public static bool InputEvent_IsLeftCommandDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsLeftCommandDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DE RID: 42462 RVA: 0x000EC9B0 File Offset: 0x000EABB0
		public static bool InputEvent_IsLeftAltDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsLeftAltDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5DF RID: 42463 RVA: 0x000EC9C7 File Offset: 0x000EABC7
		public static bool InputEvent_IsControlDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsControlDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5E0 RID: 42464 RVA: 0x000EC9DE File Offset: 0x000EABDE
		public static bool InputEvent_IsCommandDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsCommandDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5E1 RID: 42465 RVA: 0x000EC9F5 File Offset: 0x000EABF5
		public static bool InputEvent_IsAltDown(in FInputEvent Input)
		{
			return UKismetInputLibrary.__InputEvent_IsAltDown_Internal((Input ?? new FInputEvent()).NativePtr);
		}

		// Token: 0x0600A5E2 RID: 42466 RVA: 0x000ECA0C File Offset: 0x000EAC0C
		[NullableContext(1)]
		public static FText InputChord_GetDisplayName([Nullable(2)] in FInputChord Key)
		{
			return new FText(UKismetInputLibrary.__InputChord_GetDisplayName_Internal((Key ?? new FInputChord()).NativePtr), null);
		}

		// Token: 0x0600A5E3 RID: 42467 RVA: 0x000ECA29 File Offset: 0x000EAC29
		public static int GetUserIndex(in FKeyEvent Input)
		{
			return UKismetInputLibrary.__GetUserIndex_Internal((Input ?? new FKeyEvent()).NativePtr);
		}

		// Token: 0x0600A5E4 RID: 42468 RVA: 0x000ECA40 File Offset: 0x000EAC40
		[NullableContext(1)]
		public static FKey GetKey([Nullable(2)] in FKeyEvent Input)
		{
			return new FKey(UKismetInputLibrary.__GetKey_Internal((Input ?? new FKeyEvent()).NativePtr), null);
		}

		// Token: 0x0600A5E5 RID: 42469 RVA: 0x000ECA5D File Offset: 0x000EAC5D
		public static float GetAnalogValue(in FAnalogInputEvent Input)
		{
			return UKismetInputLibrary.__GetAnalogValue_Internal((Input ?? new FAnalogInputEvent()).NativePtr);
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x000ECA74 File Offset: 0x000EAC74
		public static bool EqualEqual_KeyKey(FKey A, FKey B)
		{
			return UKismetInputLibrary.__EqualEqual_KeyKey_Internal((A ?? new FKey()).NativePtr, (B ?? new FKey()).NativePtr);
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x000ECA99 File Offset: 0x000EAC99
		public static bool EqualEqual_InputChordInputChord(FInputChord A, FInputChord B)
		{
			return UKismetInputLibrary.__EqualEqual_InputChordInputChord_Internal((A ?? new FInputChord()).NativePtr, (B ?? new FInputChord()).NativePtr);
		}

		// Token: 0x0600A5E8 RID: 42472
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void CalibrateTilt();

		// Token: 0x0600A5E9 RID: 42473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PointerEvent_IsTouchEvent_Internal(IntPtr Input);

		// Token: 0x0600A5EA RID: 42474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PointerEvent_IsMouseButtonDown_Internal(IntPtr Input, IntPtr MouseButton);

		// Token: 0x0600A5EB RID: 42475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __PointerEvent_GetWheelDelta_Internal(IntPtr Input);

		// Token: 0x0600A5EC RID: 42476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PointerEvent_GetUserIndex_Internal(IntPtr Input);

		// Token: 0x0600A5ED RID: 42477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PointerEvent_GetTouchpadIndex_Internal(IntPtr Input);

		// Token: 0x0600A5EE RID: 42478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __PointerEvent_GetScreenSpacePosition_Internal(IntPtr Input);

		// Token: 0x0600A5EF RID: 42479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __PointerEvent_GetPointerIndex_Internal(IntPtr Input);

		// Token: 0x0600A5F0 RID: 42480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __PointerEvent_GetLastScreenSpacePosition_Internal(IntPtr Input);

		// Token: 0x0600A5F1 RID: 42481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern ESlateGesture __PointerEvent_GetGestureType_Internal(IntPtr Input);

		// Token: 0x0600A5F2 RID: 42482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __PointerEvent_GetGestureDelta_Internal(IntPtr Input);

		// Token: 0x0600A5F3 RID: 42483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __PointerEvent_GetEffectingButton_Internal(IntPtr Input);

		// Token: 0x0600A5F4 RID: 42484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __PointerEvent_GetCursorDelta_Internal(IntPtr Input);

		// Token: 0x0600A5F5 RID: 42485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsVectorAxis_Internal(IntPtr Key);

		// Token: 0x0600A5F6 RID: 42486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsValid_Internal(IntPtr Key);

		// Token: 0x0600A5F7 RID: 42487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsMouseButton_Internal(IntPtr Key);

		// Token: 0x0600A5F8 RID: 42488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsModifierKey_Internal(IntPtr Key);

		// Token: 0x0600A5F9 RID: 42489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsKeyboardKey_Internal(IntPtr Key);

		// Token: 0x0600A5FA RID: 42490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsGamepadKey_Internal(IntPtr Key);

		// Token: 0x0600A5FB RID: 42491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsDigital_Internal(IntPtr Key);

		// Token: 0x0600A5FC RID: 42492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsButtonAxis_Internal(IntPtr Key);

		// Token: 0x0600A5FD RID: 42493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis3D_Internal(IntPtr Key);

		// Token: 0x0600A5FE RID: 42494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis2D_Internal(IntPtr Key);

		// Token: 0x0600A5FF RID: 42495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAxis1D_Internal(IntPtr Key);

		// Token: 0x0600A600 RID: 42496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Key_IsAnalog_Internal(IntPtr Key);

		// Token: 0x0600A601 RID: 42497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUINavigation __Key_GetNavigationDirectionFromKey_Internal(IntPtr InKeyEvent);

		// Token: 0x0600A602 RID: 42498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUINavigation __Key_GetNavigationDirectionFromAnalog_Internal(IntPtr InAnalogEvent);

		// Token: 0x0600A603 RID: 42499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUINavigationAction __Key_GetNavigationActionFromKey_Internal(IntPtr InKeyEvent);

		// Token: 0x0600A604 RID: 42500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EUINavigationAction __Key_GetNavigationAction_Internal(IntPtr InKey);

		// Token: 0x0600A605 RID: 42501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Key_GetDisplayName_Internal(IntPtr Key);

		// Token: 0x0600A606 RID: 42502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsShiftDown_Internal(IntPtr Input);

		// Token: 0x0600A607 RID: 42503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsRightShiftDown_Internal(IntPtr Input);

		// Token: 0x0600A608 RID: 42504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsRightControlDown_Internal(IntPtr Input);

		// Token: 0x0600A609 RID: 42505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsRightCommandDown_Internal(IntPtr Input);

		// Token: 0x0600A60A RID: 42506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsRightAltDown_Internal(IntPtr Input);

		// Token: 0x0600A60B RID: 42507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsRepeat_Internal(IntPtr Input);

		// Token: 0x0600A60C RID: 42508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsLeftShiftDown_Internal(IntPtr Input);

		// Token: 0x0600A60D RID: 42509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsLeftControlDown_Internal(IntPtr Input);

		// Token: 0x0600A60E RID: 42510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsLeftCommandDown_Internal(IntPtr Input);

		// Token: 0x0600A60F RID: 42511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsLeftAltDown_Internal(IntPtr Input);

		// Token: 0x0600A610 RID: 42512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsControlDown_Internal(IntPtr Input);

		// Token: 0x0600A611 RID: 42513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsCommandDown_Internal(IntPtr Input);

		// Token: 0x0600A612 RID: 42514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __InputEvent_IsAltDown_Internal(IntPtr Input);

		// Token: 0x0600A613 RID: 42515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InputChord_GetDisplayName_Internal(IntPtr Key);

		// Token: 0x0600A614 RID: 42516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetUserIndex_Internal(IntPtr Input);

		// Token: 0x0600A615 RID: 42517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetKey_Internal(IntPtr Input);

		// Token: 0x0600A616 RID: 42518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetAnalogValue_Internal(IntPtr Input);

		// Token: 0x0600A617 RID: 42519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_KeyKey_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A618 RID: 42520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_InputChordInputChord_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A619 RID: 42521 RVA: 0x000ECABE File Offset: 0x000EACBE
		static UKismetInputLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetInputLibrary");
		}

		// Token: 0x0600A61A RID: 42522 RVA: 0x000ECACC File Offset: 0x000EACCC
		protected UKismetInputLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B2D RID: 23341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetInputLibrary";

		// Token: 0x04005B2E RID: 23342
		private static IntPtr _ClassPtr;

		// Token: 0x04005B2F RID: 23343
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
