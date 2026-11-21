using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044C RID: 1100
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroInput.KuroInputFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroInputFunctionLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006A12 RID: 27154 RVA: 0x0009AB7A File Offset: 0x00098D7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputFunctionLibrary._ClassPtr;
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x0009AB88 File Offset: 0x00098D88
		public UKuroInputFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroInputFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x0009ABB0 File Offset: 0x00098DB0
		[NullableContext(1)]
		public UKuroInputFunctionLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputFunctionLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x0009ABE3 File Offset: 0x00098DE3
		public static void TryUseHighPrecisionMouseMovement(APlayerController InPlayerController, bool bUse)
		{
			UKuroInputFunctionLibrary.__TryUseHighPrecisionMouseMovement_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, bUse);
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0009ABFC File Offset: 0x00098DFC
		[NullableContext(1)]
		public unsafe static FInputModeReply SetUIOnlyInputMode([Nullable(2)] APlayerController InPlayerController, string Reason, bool bLockMouseToViewport = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetUIOnlyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring, bLockMouseToViewport), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0009AC38 File Offset: 0x00098E38
		[NullableContext(1)]
		public unsafe static FInputModeReply SetGameOnlyInputMode([Nullable(2)] APlayerController InPlayerController, string Reason)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetGameOnlyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0009AC74 File Offset: 0x00098E74
		[NullableContext(1)]
		public unsafe static FInputModeReply SetGameAndUIInputMode([Nullable(2)] APlayerController InPlayerController, string Reason, bool bLockMouseToViewport = false, bool bHideCursorDuringCapture = false)
		{
			FString fstring = FString.AllocTemp(Reason);
			FInputModeReply result = new FInputModeReply(UKuroInputFunctionLibrary.__SetGameAndUIInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, fstring, bLockMouseToViewport, bHideCursorDuringCapture), null);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x0009ACB0 File Offset: 0x00098EB0
		public static void ResetInputMode(APlayerController InPlayerController)
		{
			UKuroInputFunctionLibrary.__ResetInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A1A RID: 27162 RVA: 0x0009ACC7 File Offset: 0x00098EC7
		public static void ReplyInputMode(APlayerController InPlayerController, FInputModeReply InputModeReply)
		{
			UKuroInputFunctionLibrary.__ReplyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero, (InputModeReply ?? new FInputModeReply()).NativePtr);
		}

		// Token: 0x06006A1B RID: 27163 RVA: 0x0009ACED File Offset: 0x00098EED
		public static bool HasInputModeReply(FInputModeReply InputModeReply)
		{
			return UKuroInputFunctionLibrary.__HasInputModeReply_Internal((InputModeReply ?? new FInputModeReply()).NativePtr);
		}

		// Token: 0x06006A1C RID: 27164 RVA: 0x0009AD03 File Offset: 0x00098F03
		public static void ClearTouchBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearTouchBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A1D RID: 27165 RVA: 0x0009AD1A File Offset: 0x00098F1A
		public static void ClearKeyBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearKeyBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A1E RID: 27166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ClearInputModeReply();

		// Token: 0x06006A1F RID: 27167 RVA: 0x0009AD31 File Offset: 0x00098F31
		public static void ClearAxisBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearAxisBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A20 RID: 27168 RVA: 0x0009AD48 File Offset: 0x00098F48
		public static void ClearActionBindings(APlayerController PlayerController)
		{
			UKuroInputFunctionLibrary.__ClearActionBindings_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A21 RID: 27169 RVA: 0x0009AD5F File Offset: 0x00098F5F
		public static void ApplyInputMode(APlayerController InPlayerController)
		{
			UKuroInputFunctionLibrary.__ApplyInputMode_Internal((InPlayerController != null) ? InPlayerController.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006A22 RID: 27170 RVA: 0x0009AD78 File Offset: 0x00098F78
		public unsafe static void AddTouchBinding(APlayerController PlayerController, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				UKuroInputFunctionLibrary.__AddTouchBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x06006A23 RID: 27171 RVA: 0x0009ADBC File Offset: 0x00098FBC
		public unsafe static void AddKeyBinding(APlayerController PlayerController, in FInputChord Chord, EInputEvent KeyEvent, UObject Object, in FName FuncName)
		{
			fixed (FName* ptr = &FuncName)
			{
				void* ptr2 = (void*)ptr;
				UKuroInputFunctionLibrary.__AddKeyBinding_Internal((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero, (Chord ?? new FInputChord()).NativePtr, KeyEvent, (Object != null) ? Object.NativePtr : IntPtr.Zero, FuncName);
			}
		}

		// Token: 0x06006A24 RID: 27172 RVA: 0x0009AE10 File Offset: 0x00099010
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

		// Token: 0x06006A25 RID: 27173 RVA: 0x0009AE54 File Offset: 0x00099054
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

		// Token: 0x06006A26 RID: 27174
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TryUseHighPrecisionMouseMovement_Internal(IntPtr InPlayerController, bool bUse);

		// Token: 0x06006A27 RID: 27175
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetUIOnlyInputMode_Internal(IntPtr InPlayerController, in FString Reason, bool bLockMouseToViewport);

		// Token: 0x06006A28 RID: 27176
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetGameOnlyInputMode_Internal(IntPtr InPlayerController, in FString Reason);

		// Token: 0x06006A29 RID: 27177
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SetGameAndUIInputMode_Internal(IntPtr InPlayerController, in FString Reason, bool bLockMouseToViewport, bool bHideCursorDuringCapture);

		// Token: 0x06006A2A RID: 27178
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetInputMode_Internal(IntPtr InPlayerController);

		// Token: 0x06006A2B RID: 27179
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReplyInputMode_Internal(IntPtr InPlayerController, IntPtr InputModeReply);

		// Token: 0x06006A2C RID: 27180
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasInputModeReply_Internal(IntPtr InputModeReply);

		// Token: 0x06006A2D RID: 27181
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearTouchBindings_Internal(IntPtr PlayerController);

		// Token: 0x06006A2E RID: 27182
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyBindings_Internal(IntPtr PlayerController);

		// Token: 0x06006A2F RID: 27183
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearAxisBindings_Internal(IntPtr PlayerController);

		// Token: 0x06006A30 RID: 27184
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearActionBindings_Internal(IntPtr PlayerController);

		// Token: 0x06006A31 RID: 27185
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyInputMode_Internal(IntPtr InPlayerController);

		// Token: 0x06006A32 RID: 27186
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddTouchBinding_Internal(IntPtr PlayerController, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x06006A33 RID: 27187
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddKeyBinding_Internal(IntPtr PlayerController, IntPtr Chord, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x06006A34 RID: 27188
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddAxisBinding_Internal(IntPtr PlayerController, in FName AxisName, IntPtr Object, in FName FuncName);

		// Token: 0x06006A35 RID: 27189
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddActionBinding_Internal(IntPtr PlayerController, in FName ActionName, TEnumAsByte<EInputEvent> KeyEvent, IntPtr Object, in FName FuncName);

		// Token: 0x06006A36 RID: 27190 RVA: 0x0009AEA0 File Offset: 0x000990A0
		static UKuroInputFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.KuroInputFunctionLibrary");
		}

		// Token: 0x06006A37 RID: 27191 RVA: 0x0009AEAE File Offset: 0x000990AE
		protected UKuroInputFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D08 RID: 11528
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.KuroInputFunctionLibrary";

		// Token: 0x04002D09 RID: 11529
		private static IntPtr _ClassPtr;

		// Token: 0x04002D0A RID: 11530
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
