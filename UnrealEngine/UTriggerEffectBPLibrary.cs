using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000853 RID: 2131
	[UnrealObjectPath("/Script/TriggerEffect.TriggerEffectBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTriggerEffectBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B98C RID: 47500 RVA: 0x00128E08 File Offset: 0x00127008
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTriggerEffectBPLibrary._ClassPtr;
		}

		// Token: 0x0600B98D RID: 47501 RVA: 0x00128E14 File Offset: 0x00127014
		public UTriggerEffectBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UTriggerEffectBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B98E RID: 47502 RVA: 0x00128E3C File Offset: 0x0012703C
		[NullableContext(1)]
		public UTriggerEffectBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTriggerEffectBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B98F RID: 47503 RVA: 0x00128E70 File Offset: 0x00127070
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetWeaponMode(APlayerController PlayerController, byte StartPosition, byte EndPosition, byte Strength, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->StartPosition = StartPosition;
			ptr->EndPosition = EndPosition;
			ptr->Strength = Strength;
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B990 RID: 47504 RVA: 0x00128EFC File Offset: 0x001270FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetVibrationMode(APlayerController PlayerController, byte Position, byte Frequency, byte Amplitude, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->Position = Position;
			ptr->Frequency = Frequency;
			ptr->Amplitude = Amplitude;
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B991 RID: 47505 RVA: 0x00128F88 File Offset: 0x00127188
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetSlopeFeedbackMode(APlayerController PlayerController, byte StartPosition, byte EndPosition, byte StartStrength, byte EndStrength, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->StartPosition = StartPosition;
			ptr->EndPosition = EndPosition;
			ptr->StartStrength = StartStrength;
			ptr->EndStrength = EndStrength;
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B992 RID: 47506 RVA: 0x0012901C File Offset: 0x0012721C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetOffModeBothControllers(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B993 RID: 47507 RVA: 0x00129070 File Offset: 0x00127270
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetOffMode(APlayerController PlayerController, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B994 RID: 47508 RVA: 0x001290D4 File Offset: 0x001272D4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetMultipositionVibrationMode(APlayerController PlayerController, byte Frequency, TArray<byte> Amplitudes, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->Frequency = Frequency;
			if (Amplitudes != null)
			{
				Amplitudes.CopyTo(&ptr->Amplitudes, default(UScriptStructStackOnlyPtr));
			}
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B995 RID: 47509 RVA: 0x00129178 File Offset: 0x00127378
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetMultipositionFeedbackMode(APlayerController PlayerController, TArray<byte> Strengths, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			if (Strengths != null)
			{
				Strengths.CopyTo(&ptr->Strengths, default(UScriptStructStackOnlyPtr));
			}
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B996 RID: 47510 RVA: 0x00129214 File Offset: 0x00127414
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void TriggerEffectSetFeedbackMode(APlayerController PlayerController, byte Position, byte Strength, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType, bool bUseEffectForThreshold = true, byte AnalogThreshold = 0)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->Position = Position;
			ptr->Strength = Strength;
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			ptr->bUseEffectForThreshold = bUseEffectForThreshold;
			ptr->AnalogThreshold = AnalogThreshold;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B997 RID: 47511 RVA: 0x00129298 File Offset: 0x00127498
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetTriggerEffectState(APlayerController PlayerController, bool bNewState)
		{
			UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetTriggerEffectState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->bNewState = bNewState;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetTriggerEffectState_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B998 RID: 47512 RVA: 0x001292F4 File Offset: 0x001274F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetPadColor(APlayerController PlayerController, FColor Color)
		{
			UTriggerEffectBPLibrary.__SetPadColor_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetPadColor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetPadColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetPadColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->Color = Color;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetPadColor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B999 RID: 47513 RVA: 0x00129350 File Offset: 0x00127550
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetLightEffectColorCycle(APlayerController PlayerController, in TArray<FColor> CycleColors, bool bSine = false, float OnTimeSec = 0f, float OffTimeSec = 0f, float BrightnessScale = 1f)
		{
			UTriggerEffectBPLibrary.__SetLightEffectColorCycle_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetLightEffectColorCycle_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetLightEffectColorCycle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetLightEffectColorCycle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			TArray<FColor> tarray = CycleColors;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->CycleColors);
			}
			ptr->bSine = bSine;
			ptr->OnTimeSec = OnTimeSec;
			ptr->OffTimeSec = OffTimeSec;
			ptr->BrightnessScale = BrightnessScale;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetLightEffectColorCycle_NativeFunctionPtr, (void*)ptr);
			TArray<FColor> tarray2 = CycleColors;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->CycleColors);
			}
			UnrealReflectionUtils.DestroyStruct(UTriggerEffectBPLibrary.__SetLightEffectColorCycle_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B99A RID: 47514 RVA: 0x001293FC File Offset: 0x001275FC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void SetLightEffect(APlayerController PlayerController, byte R, byte G, byte B, bool bSine = false, float OnTimeSec = 0f, float OffTimeSec = 0f, float BrightnessScale = 1f, byte R2 = 0, byte G2 = 0, byte B2 = 0)
		{
			UTriggerEffectBPLibrary.__SetLightEffect_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetLightEffect_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetLightEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetLightEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->R = R;
			ptr->G = G;
			ptr->B = B;
			ptr->bSine = bSine;
			ptr->OnTimeSec = OnTimeSec;
			ptr->OffTimeSec = OffTimeSec;
			ptr->BrightnessScale = BrightnessScale;
			ptr->R2 = R2;
			ptr->G2 = G2;
			ptr->B2 = B2;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetLightEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B99B RID: 47515 RVA: 0x001294A0 File Offset: 0x001276A0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ResetPadColor(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__ResetPadColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__ResetPadColor_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B99C RID: 47516 RVA: 0x001294F4 File Offset: 0x001276F4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void Play(APlayerController PlayerController, ETriggerEffectSide TriggerSide, UKuroTriggerEffect TriggerEffect)
		{
			UTriggerEffectBPLibrary.__Play_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__Play_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__Play_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->TriggerSide = TriggerSide;
			ptr->TriggerEffect = ((TriggerEffect != null) ? TriggerEffect.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__Play_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B99D RID: 47517 RVA: 0x00129568 File Offset: 0x00127768
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ClearLightEffectColorCycle(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__ClearLightEffectColorCycle_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__ClearLightEffectColorCycle_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__ClearLightEffectColorCycle_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__ClearLightEffectColorCycle_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__ClearLightEffectColorCycle_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B99E RID: 47518 RVA: 0x001295BC File Offset: 0x001277BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void ClearLightEffect(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__ClearLightEffect_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__ClearLightEffect_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__ClearLightEffect_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__ClearLightEffect_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__ClearLightEffect_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600B99F RID: 47519 RVA: 0x00129610 File Offset: 0x00127810
		static UTriggerEffectBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TriggerEffect.TriggerEffectBPLibrary");
		}

		// Token: 0x0600B9A0 RID: 47520 RVA: 0x0012961E File Offset: 0x0012781E
		protected UTriggerEffectBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005444 RID: 21572
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TriggerEffect.TriggerEffectBPLibrary";

		// Token: 0x04005445 RID: 21573
		private static IntPtr _ClassPtr;

		// Token: 0x04005446 RID: 21574
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005447 RID: 21575
		private static IntPtr __TriggerEffectSetWeaponMode_NativeFunctionPtr;

		// Token: 0x04005448 RID: 21576
		private static IntPtr __TriggerEffectSetVibrationMode_NativeFunctionPtr;

		// Token: 0x04005449 RID: 21577
		private static IntPtr __TriggerEffectSetSlopeFeedbackMode_NativeFunctionPtr;

		// Token: 0x0400544A RID: 21578
		private static IntPtr __TriggerEffectSetOffModeBothControllers_NativeFunctionPtr;

		// Token: 0x0400544B RID: 21579
		private static IntPtr __TriggerEffectSetOffMode_NativeFunctionPtr;

		// Token: 0x0400544C RID: 21580
		private static IntPtr __TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr;

		// Token: 0x0400544D RID: 21581
		private static IntPtr __TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr;

		// Token: 0x0400544E RID: 21582
		private static IntPtr __TriggerEffectSetFeedbackMode_NativeFunctionPtr;

		// Token: 0x0400544F RID: 21583
		private static IntPtr __SetTriggerEffectState_NativeFunctionPtr;

		// Token: 0x04005450 RID: 21584
		private static IntPtr __SetPadColor_NativeFunctionPtr;

		// Token: 0x04005451 RID: 21585
		private static IntPtr __SetLightEffectColorCycle_NativeFunctionPtr;

		// Token: 0x04005452 RID: 21586
		private static IntPtr __SetLightEffect_NativeFunctionPtr;

		// Token: 0x04005453 RID: 21587
		private static IntPtr __ResetPadColor_NativeFunctionPtr;

		// Token: 0x04005454 RID: 21588
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x04005455 RID: 21589
		private static IntPtr __ClearLightEffectColorCycle_NativeFunctionPtr;

		// Token: 0x04005456 RID: 21590
		private static IntPtr __ClearLightEffect_NativeFunctionPtr;

		// Token: 0x020013DD RID: 5085
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetWeaponMode_FunctionParams
		{
			// Token: 0x04006849 RID: 26697
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400684A RID: 26698
			[FieldOffset(8)]
			public byte StartPosition;

			// Token: 0x0400684B RID: 26699
			[FieldOffset(9)]
			public byte EndPosition;

			// Token: 0x0400684C RID: 26700
			[FieldOffset(10)]
			public byte Strength;

			// Token: 0x0400684D RID: 26701
			[FieldOffset(11)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x0400684E RID: 26702
			[FieldOffset(12)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x0400684F RID: 26703
			[FieldOffset(13)]
			public bool bUseEffectForThreshold;

			// Token: 0x04006850 RID: 26704
			[FieldOffset(14)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013DE RID: 5086
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetVibrationMode_FunctionParams
		{
			// Token: 0x04006851 RID: 26705
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006852 RID: 26706
			[FieldOffset(8)]
			public byte Position;

			// Token: 0x04006853 RID: 26707
			[FieldOffset(9)]
			public byte Frequency;

			// Token: 0x04006854 RID: 26708
			[FieldOffset(10)]
			public byte Amplitude;

			// Token: 0x04006855 RID: 26709
			[FieldOffset(11)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04006856 RID: 26710
			[FieldOffset(12)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04006857 RID: 26711
			[FieldOffset(13)]
			public bool bUseEffectForThreshold;

			// Token: 0x04006858 RID: 26712
			[FieldOffset(14)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013DF RID: 5087
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetSlopeFeedbackMode_FunctionParams
		{
			// Token: 0x04006859 RID: 26713
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400685A RID: 26714
			[FieldOffset(8)]
			public byte StartPosition;

			// Token: 0x0400685B RID: 26715
			[FieldOffset(9)]
			public byte EndPosition;

			// Token: 0x0400685C RID: 26716
			[FieldOffset(10)]
			public byte StartStrength;

			// Token: 0x0400685D RID: 26717
			[FieldOffset(11)]
			public byte EndStrength;

			// Token: 0x0400685E RID: 26718
			[FieldOffset(12)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x0400685F RID: 26719
			[FieldOffset(13)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04006860 RID: 26720
			[FieldOffset(14)]
			public bool bUseEffectForThreshold;

			// Token: 0x04006861 RID: 26721
			[FieldOffset(15)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013E0 RID: 5088
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TriggerEffectSetOffModeBothControllers_FunctionParams
		{
			// Token: 0x04006862 RID: 26722
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}

		// Token: 0x020013E1 RID: 5089
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetOffMode_FunctionParams
		{
			// Token: 0x04006863 RID: 26723
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006864 RID: 26724
			[FieldOffset(8)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04006865 RID: 26725
			[FieldOffset(9)]
			public ETriggerEffectControllerType ControllerType;
		}

		// Token: 0x020013E2 RID: 5090
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __TriggerEffectSetMultipositionVibrationMode_FunctionParams
		{
			// Token: 0x04006866 RID: 26726
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006867 RID: 26727
			[FieldOffset(8)]
			public byte Frequency;

			// Token: 0x04006868 RID: 26728
			[FieldOffset(16)]
			public byte Amplitudes;

			// Token: 0x04006869 RID: 26729
			[FieldOffset(32)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x0400686A RID: 26730
			[FieldOffset(33)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x0400686B RID: 26731
			[FieldOffset(34)]
			public bool bUseEffectForThreshold;

			// Token: 0x0400686C RID: 26732
			[FieldOffset(35)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013E3 RID: 5091
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TriggerEffectSetMultipositionFeedbackMode_FunctionParams
		{
			// Token: 0x0400686D RID: 26733
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400686E RID: 26734
			[FieldOffset(8)]
			public byte Strengths;

			// Token: 0x0400686F RID: 26735
			[FieldOffset(24)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04006870 RID: 26736
			[FieldOffset(25)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04006871 RID: 26737
			[FieldOffset(26)]
			public bool bUseEffectForThreshold;

			// Token: 0x04006872 RID: 26738
			[FieldOffset(27)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013E4 RID: 5092
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetFeedbackMode_FunctionParams
		{
			// Token: 0x04006873 RID: 26739
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006874 RID: 26740
			[FieldOffset(8)]
			public byte Position;

			// Token: 0x04006875 RID: 26741
			[FieldOffset(9)]
			public byte Strength;

			// Token: 0x04006876 RID: 26742
			[FieldOffset(10)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04006877 RID: 26743
			[FieldOffset(11)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04006878 RID: 26744
			[FieldOffset(12)]
			public bool bUseEffectForThreshold;

			// Token: 0x04006879 RID: 26745
			[FieldOffset(13)]
			public byte AnalogThreshold;
		}

		// Token: 0x020013E5 RID: 5093
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTriggerEffectState_FunctionParams
		{
			// Token: 0x0400687A RID: 26746
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400687B RID: 26747
			[FieldOffset(8)]
			public bool bNewState;
		}

		// Token: 0x020013E6 RID: 5094
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetPadColor_FunctionParams
		{
			// Token: 0x0400687C RID: 26748
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400687D RID: 26749
			[FieldOffset(8)]
			public FColor Color;
		}

		// Token: 0x020013E7 RID: 5095
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetLightEffectColorCycle_FunctionParams
		{
			// Token: 0x0400687E RID: 26750
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x0400687F RID: 26751
			[FieldOffset(8)]
			public byte CycleColors;

			// Token: 0x04006880 RID: 26752
			[FieldOffset(24)]
			public bool bSine;

			// Token: 0x04006881 RID: 26753
			[FieldOffset(28)]
			public float OnTimeSec;

			// Token: 0x04006882 RID: 26754
			[FieldOffset(32)]
			public float OffTimeSec;

			// Token: 0x04006883 RID: 26755
			[FieldOffset(36)]
			public float BrightnessScale;
		}

		// Token: 0x020013E8 RID: 5096
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetLightEffect_FunctionParams
		{
			// Token: 0x04006884 RID: 26756
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006885 RID: 26757
			[FieldOffset(8)]
			public byte R;

			// Token: 0x04006886 RID: 26758
			[FieldOffset(9)]
			public byte G;

			// Token: 0x04006887 RID: 26759
			[FieldOffset(10)]
			public byte B;

			// Token: 0x04006888 RID: 26760
			[FieldOffset(11)]
			public bool bSine;

			// Token: 0x04006889 RID: 26761
			[FieldOffset(12)]
			public float OnTimeSec;

			// Token: 0x0400688A RID: 26762
			[FieldOffset(16)]
			public float OffTimeSec;

			// Token: 0x0400688B RID: 26763
			[FieldOffset(20)]
			public float BrightnessScale;

			// Token: 0x0400688C RID: 26764
			[FieldOffset(24)]
			public byte R2;

			// Token: 0x0400688D RID: 26765
			[FieldOffset(25)]
			public byte G2;

			// Token: 0x0400688E RID: 26766
			[FieldOffset(26)]
			public byte B2;
		}

		// Token: 0x020013E9 RID: 5097
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetPadColor_FunctionParams
		{
			// Token: 0x0400688F RID: 26767
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}

		// Token: 0x020013EA RID: 5098
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x04006890 RID: 26768
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04006891 RID: 26769
			[FieldOffset(8)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04006892 RID: 26770
			[FieldOffset(16)]
			public IntPtr TriggerEffect;
		}

		// Token: 0x020013EB RID: 5099
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearLightEffectColorCycle_FunctionParams
		{
			// Token: 0x04006893 RID: 26771
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}

		// Token: 0x020013EC RID: 5100
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ClearLightEffect_FunctionParams
		{
			// Token: 0x04006894 RID: 26772
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}
	}
}
