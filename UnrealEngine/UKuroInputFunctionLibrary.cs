using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001998 RID: 6552
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInput.KuroInputFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInputFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601855E RID: 99678 RVA: 0x0023E23A File Offset: 0x0023C43A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputFunctionLibrary._ClassPtr;
		}

		// Token: 0x0601855F RID: 99679 RVA: 0x0023E248 File Offset: 0x0023C448
		public UKuroInputFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroInputFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018560 RID: 99680 RVA: 0x0023E270 File Offset: 0x0023C470
		[NullableContext(1)]
		public UKuroInputFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018561 RID: 99681 RVA: 0x0023E2A3 File Offset: 0x0023C4A3
		public static void TryUseHighPrecisionMouseMovement(APlayerController InPlayerController, bool bUse)
		{
			UKuroInputFunctionLibrary.__TryUseHighPrecisionMouseMovement_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, bUse);
		}

		// Token: 0x06018562 RID: 99682 RVA: 0x0023E2BC File Offset: 0x0023C4BC
		[NullableContext(1)]
		public unsafe static FInputModeReply SetUIOnlyInputMode([Nullable(2)] APlayerController InPlayerController, string Reason, bool bLockMouseToViewport = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetUIOnlyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring, bLockMouseToViewport), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018563 RID: 99683 RVA: 0x0023E2F8 File Offset: 0x0023C4F8
		[NullableContext(1)]
		public unsafe static FInputModeReply SetGameOnlyInputMode([Nullable(2)] APlayerController InPlayerController, string Reason)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetGameOnlyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018564 RID: 99684 RVA: 0x0023E334 File Offset: 0x0023C534
		[NullableContext(1)]
		public unsafe static FInputModeReply SetGameAndUIInputMode([Nullable(2)] APlayerController InPlayerController, string Reason, bool bLockMouseToViewport = false, bool bHideCursorDuringCapture = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetGameAndUIInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring, bLockMouseToViewport, bHideCursorDuringCapture), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06018565 RID: 99685 RVA: 0x0023E370 File Offset: 0x0023C570
		public static void ResetInputMode(APlayerController InPlayerController)
		{
			UKuroInputFunctionLibrary.__ResetInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018566 RID: 99686 RVA: 0x0023E387 File Offset: 0x0023C587
		public static void ReplyInputMode(APlayerController InPlayerController, FInputModeReply InputModeReply)
		{
			UKuroInputFunctionLibrary.__ReplyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, (InputModeReply ?? new FInputModeReply()).NativePtr);
		}

		// Token: 0x06018567 RID: 99687 RVA: 0x0023E3AD File Offset: 0x0023C5AD
		public static bool HasInputModeReply(FInputModeReply InputModeReply)
		{
			return UKuroInputFunctionLibrary.__HasInputModeReply_Internal((InputModeReply ?? new FInputModeReply()).NativePtr);
		}

		// Token: 0x06018568 RID: 99688 RVA: 0x0023E3C3 File Offset: 0x0023C5C3
		public static void ClearTouchBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearTouchBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06018569 RID: 99689 RVA: 0x0023E3DA File Offset: 0x0023C5DA
		public static void ClearKeyBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearKeyBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601856A RID: 99690
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearInputModeReply();

		// Token: 0x0601856B RID: 99691 RVA: 0x0023E3F1 File Offset: 0x0023C5F1
		public static void ClearAxisBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearAxisBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601856C RID: 99692 RVA: 0x0023E408 File Offset: 0x0023C608
		public static void ClearActionBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearActionBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601856D RID: 99693 RVA: 0x0023E41F File Offset: 0x0023C61F
		public static void ApplyInputMode(APlayerController InPlayerController)
		{
			UKuroInputFunctionLibrary.__ApplyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601856E RID: 99694 RVA: 0x0023E438 File Offset: 0x0023C638
		public unsafe static void AddTouchBinding(APlayerController PlayerController, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				UKuroInputFunctionLibrary.__AddTouchBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x0601856F RID: 99695 RVA: 0x0023E47C File Offset: 0x0023C67C
		public unsafe static void AddKeyBinding(APlayerController PlayerController, in FInputChord Chord, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				UKuroInputFunctionLibrary.__AddKeyBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, (Chord ?? new FInputChord()).NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x06018570 RID: 99696 RVA: 0x0023E4D0 File Offset: 0x0023C6D0
		public unsafe static void AddAxisBinding(APlayerController PlayerController, in FName AxisName, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &AxisName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &FuncName)
				{
					void* ptr4 = (void*)ptr3;
					UKuroInputFunctionLibrary.__AddAxisBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, AxisName, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
					ptr = null;
				}
			}
		}

		// Token: 0x06018571 RID: 99697 RVA: 0x0023E514 File Offset: 0x0023C714
		public unsafe static void AddActionBinding(APlayerController PlayerController, in FName ActionName, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &ActionName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FName* ptr3 = &FuncName)
				{
					void* ptr4 = (void*)ptr3;
					UKuroInputFunctionLibrary.__AddActionBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, ActionName, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
					ptr = null;
				}
			}
		}

		// Token: 0x06018572 RID: 99698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryUseHighPrecisionMouseMovement_Internal(IntPtr InPlayerController, bool bUse);

		// Token: 0x06018573 RID: 99699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUIOnlyInputMode_Internal(IntPtr InPlayerController, in FString Reason, bool bLockMouseToViewport);

		// Token: 0x06018574 RID: 99700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetGameOnlyInputMode_Internal(IntPtr InPlayerController, in FString Reason);

		// Token: 0x06018575 RID: 99701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetGameAndUIInputMode_Internal(IntPtr InPlayerController, in FString Reason, bool bLockMouseToViewport, bool bHideCursorDuringCapture);

		// Token: 0x06018576 RID: 99702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInputMode_Internal(IntPtr InPlayerController);

		// Token: 0x06018577 RID: 99703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplyInputMode_Internal(IntPtr InPlayerController, IntPtr InputModeReply);

		// Token: 0x06018578 RID: 99704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasInputModeReply_Internal(IntPtr InputModeReply);

		// Token: 0x06018579 RID: 99705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBindings_Internal(IntPtr PlayerController);

		// Token: 0x0601857A RID: 99706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBindings_Internal(IntPtr PlayerController);

		// Token: 0x0601857B RID: 99707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBindings_Internal(IntPtr PlayerController);

		// Token: 0x0601857C RID: 99708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBindings_Internal(IntPtr PlayerController);

		// Token: 0x0601857D RID: 99709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyInputMode_Internal(IntPtr InPlayerController);

		// Token: 0x0601857E RID: 99710
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTouchBinding_Internal(IntPtr PlayerController, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x0601857F RID: 99711
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKeyBinding_Internal(IntPtr PlayerController, IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x06018580 RID: 99712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisBinding_Internal(IntPtr PlayerController, in FName AxisName, IntPtr Object, in FName FuncName);

		// Token: 0x06018581 RID: 99713
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionBinding_Internal(IntPtr PlayerController, in FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x06018582 RID: 99714 RVA: 0x0023E560 File Offset: 0x0023C760
		static UKuroInputFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.KuroInputFunctionLibrary");
		}

		// Token: 0x06018583 RID: 99715 RVA: 0x0023E56E File Offset: 0x0023C76E
		protected UKuroInputFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D29C RID: 53916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.KuroInputFunctionLibrary";

		// Token: 0x0400D29D RID: 53917
		private static IntPtr _ClassPtr;

		// Token: 0x0400D29E RID: 53918
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
