using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002930 RID: 10544
	[UnrealObjectPath("/Script/TriggerEffect.TriggerEffectBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTriggerEffectBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06027021 RID: 159777 RVA: 0x003B7BB4 File Offset: 0x003B5DB4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTriggerEffectBPLibrary._ClassPtr;
		}

		// Token: 0x06027022 RID: 159778 RVA: 0x003B7BC0 File Offset: 0x003B5DC0
		public UTriggerEffectBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UTriggerEffectBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06027023 RID: 159779 RVA: 0x003B7BE8 File Offset: 0x003B5DE8
		[NullableContext(1)]
		public UTriggerEffectBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTriggerEffectBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06027024 RID: 159780 RVA: 0x003B7C1C File Offset: 0x003B5E1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetWeaponMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027025 RID: 159781 RVA: 0x003B7CA8 File Offset: 0x003B5EA8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetVibrationMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x003B7D34 File Offset: 0x003B5F34
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetSlopeFeedbackMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027027 RID: 159783 RVA: 0x003B7DC8 File Offset: 0x003B5FC8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TriggerEffectSetOffModeBothControllers(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetOffModeBothControllers_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027028 RID: 159784 RVA: 0x003B7E20 File Offset: 0x003B6020
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void TriggerEffectSetOffMode(APlayerController PlayerController, ETriggerEffectSide TriggerSide, ETriggerEffectControllerType ControllerType)
		{
			UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->TriggerSide = TriggerSide;
			ptr->ControllerType = ControllerType;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetOffMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027029 RID: 159785 RVA: 0x003B7E84 File Offset: 0x003B6084
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702A RID: 159786 RVA: 0x003B7F2C File Offset: 0x003B612C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTriggerEffectBPLibrary.__TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0602702B RID: 159787 RVA: 0x003B7FCC File Offset: 0x003B61CC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__TriggerEffectSetFeedbackMode_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602702C RID: 159788 RVA: 0x003B8050 File Offset: 0x003B6250
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetTriggerEffectState(APlayerController PlayerController, bool bNewState)
		{
			UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetTriggerEffectState_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetTriggerEffectState_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->bNewState = bNewState;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetTriggerEffectState_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602702D RID: 159789 RVA: 0x003B80AC File Offset: 0x003B62AC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void SetPadColor(APlayerController PlayerController, FColor Color)
		{
			UTriggerEffectBPLibrary.__SetPadColor_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__SetPadColor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__SetPadColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__SetPadColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->Color = Color;
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__SetPadColor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602702E RID: 159790 RVA: 0x003B8108 File Offset: 0x003B6308
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ResetPadColor(APlayerController PlayerController)
		{
			UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__ResetPadColor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__ResetPadColor_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__ResetPadColor_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0602702F RID: 159791 RVA: 0x003B8160 File Offset: 0x003B6360
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Play(APlayerController PlayerController, ETriggerEffectSide TriggerSide, UKuroTriggerEffect TriggerEffect)
		{
			UTriggerEffectBPLibrary.__Play_FunctionParams* ptr = stackalloc UTriggerEffectBPLibrary.__Play_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UTriggerEffectBPLibrary.__Play_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTriggerEffectBPLibrary.__Play_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PlayerController = ((PlayerController != null) ? PlayerController.NativePtr : IntPtr.Zero);
			ptr->TriggerSide = TriggerSide;
			ptr->TriggerEffect = ((TriggerEffect != null) ? TriggerEffect.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UTriggerEffectBPLibrary._ClassDefaultObjectPtr, UTriggerEffectBPLibrary.__Play_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06027030 RID: 159792 RVA: 0x003B81D2 File Offset: 0x003B63D2
		static UTriggerEffectBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TriggerEffect.TriggerEffectBPLibrary");
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x003B81E0 File Offset: 0x003B63E0
		protected UTriggerEffectBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040156F0 RID: 87792
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TriggerEffect.TriggerEffectBPLibrary";

		// Token: 0x040156F1 RID: 87793
		private static IntPtr _ClassPtr;

		// Token: 0x040156F2 RID: 87794
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040156F3 RID: 87795
		private static IntPtr __TriggerEffectSetWeaponMode_NativeFunctionPtr;

		// Token: 0x040156F4 RID: 87796
		private static IntPtr __TriggerEffectSetVibrationMode_NativeFunctionPtr;

		// Token: 0x040156F5 RID: 87797
		private static IntPtr __TriggerEffectSetSlopeFeedbackMode_NativeFunctionPtr;

		// Token: 0x040156F6 RID: 87798
		private static IntPtr __TriggerEffectSetOffModeBothControllers_NativeFunctionPtr;

		// Token: 0x040156F7 RID: 87799
		private static IntPtr __TriggerEffectSetOffMode_NativeFunctionPtr;

		// Token: 0x040156F8 RID: 87800
		private static IntPtr __TriggerEffectSetMultipositionVibrationMode_NativeFunctionPtr;

		// Token: 0x040156F9 RID: 87801
		private static IntPtr __TriggerEffectSetMultipositionFeedbackMode_NativeFunctionPtr;

		// Token: 0x040156FA RID: 87802
		private static IntPtr __TriggerEffectSetFeedbackMode_NativeFunctionPtr;

		// Token: 0x040156FB RID: 87803
		private static IntPtr __SetTriggerEffectState_NativeFunctionPtr;

		// Token: 0x040156FC RID: 87804
		private static IntPtr __SetPadColor_NativeFunctionPtr;

		// Token: 0x040156FD RID: 87805
		private static IntPtr __ResetPadColor_NativeFunctionPtr;

		// Token: 0x040156FE RID: 87806
		private static IntPtr __Play_NativeFunctionPtr;

		// Token: 0x02003B5A RID: 15194
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetWeaponMode_FunctionParams
		{
			// Token: 0x04017D04 RID: 97540
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D05 RID: 97541
			[FieldOffset(8)]
			public byte StartPosition;

			// Token: 0x04017D06 RID: 97542
			[FieldOffset(9)]
			public byte EndPosition;

			// Token: 0x04017D07 RID: 97543
			[FieldOffset(10)]
			public byte Strength;

			// Token: 0x04017D08 RID: 97544
			[FieldOffset(11)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D09 RID: 97545
			[FieldOffset(12)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D0A RID: 97546
			[FieldOffset(13)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D0B RID: 97547
			[FieldOffset(14)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B5B RID: 15195
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetVibrationMode_FunctionParams
		{
			// Token: 0x04017D0C RID: 97548
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D0D RID: 97549
			[FieldOffset(8)]
			public byte Position;

			// Token: 0x04017D0E RID: 97550
			[FieldOffset(9)]
			public byte Frequency;

			// Token: 0x04017D0F RID: 97551
			[FieldOffset(10)]
			public byte Amplitude;

			// Token: 0x04017D10 RID: 97552
			[FieldOffset(11)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D11 RID: 97553
			[FieldOffset(12)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D12 RID: 97554
			[FieldOffset(13)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D13 RID: 97555
			[FieldOffset(14)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B5C RID: 15196
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetSlopeFeedbackMode_FunctionParams
		{
			// Token: 0x04017D14 RID: 97556
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D15 RID: 97557
			[FieldOffset(8)]
			public byte StartPosition;

			// Token: 0x04017D16 RID: 97558
			[FieldOffset(9)]
			public byte EndPosition;

			// Token: 0x04017D17 RID: 97559
			[FieldOffset(10)]
			public byte StartStrength;

			// Token: 0x04017D18 RID: 97560
			[FieldOffset(11)]
			public byte EndStrength;

			// Token: 0x04017D19 RID: 97561
			[FieldOffset(12)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D1A RID: 97562
			[FieldOffset(13)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D1B RID: 97563
			[FieldOffset(14)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D1C RID: 97564
			[FieldOffset(15)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B5D RID: 15197
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __TriggerEffectSetOffModeBothControllers_FunctionParams
		{
			// Token: 0x04017D1D RID: 97565
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}

		// Token: 0x02003B5E RID: 15198
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetOffMode_FunctionParams
		{
			// Token: 0x04017D1E RID: 97566
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D1F RID: 97567
			[FieldOffset(8)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D20 RID: 97568
			[FieldOffset(9)]
			public ETriggerEffectControllerType ControllerType;
		}

		// Token: 0x02003B5F RID: 15199
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __TriggerEffectSetMultipositionVibrationMode_FunctionParams
		{
			// Token: 0x04017D21 RID: 97569
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D22 RID: 97570
			[FieldOffset(8)]
			public byte Frequency;

			// Token: 0x04017D23 RID: 97571
			[FieldOffset(16)]
			public byte Amplitudes;

			// Token: 0x04017D24 RID: 97572
			[FieldOffset(32)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D25 RID: 97573
			[FieldOffset(33)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D26 RID: 97574
			[FieldOffset(34)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D27 RID: 97575
			[FieldOffset(35)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B60 RID: 15200
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __TriggerEffectSetMultipositionFeedbackMode_FunctionParams
		{
			// Token: 0x04017D28 RID: 97576
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D29 RID: 97577
			[FieldOffset(8)]
			public byte Strengths;

			// Token: 0x04017D2A RID: 97578
			[FieldOffset(24)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D2B RID: 97579
			[FieldOffset(25)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D2C RID: 97580
			[FieldOffset(26)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D2D RID: 97581
			[FieldOffset(27)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B61 RID: 15201
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __TriggerEffectSetFeedbackMode_FunctionParams
		{
			// Token: 0x04017D2E RID: 97582
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D2F RID: 97583
			[FieldOffset(8)]
			public byte Position;

			// Token: 0x04017D30 RID: 97584
			[FieldOffset(9)]
			public byte Strength;

			// Token: 0x04017D31 RID: 97585
			[FieldOffset(10)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D32 RID: 97586
			[FieldOffset(11)]
			public ETriggerEffectControllerType ControllerType;

			// Token: 0x04017D33 RID: 97587
			[FieldOffset(12)]
			public bool bUseEffectForThreshold;

			// Token: 0x04017D34 RID: 97588
			[FieldOffset(13)]
			public byte AnalogThreshold;
		}

		// Token: 0x02003B62 RID: 15202
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetTriggerEffectState_FunctionParams
		{
			// Token: 0x04017D35 RID: 97589
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D36 RID: 97590
			[FieldOffset(8)]
			public bool bNewState;
		}

		// Token: 0x02003B63 RID: 15203
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __SetPadColor_FunctionParams
		{
			// Token: 0x04017D37 RID: 97591
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D38 RID: 97592
			[FieldOffset(8)]
			public FColor Color;
		}

		// Token: 0x02003B64 RID: 15204
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __ResetPadColor_FunctionParams
		{
			// Token: 0x04017D39 RID: 97593
			[FieldOffset(0)]
			public IntPtr PlayerController;
		}

		// Token: 0x02003B65 RID: 15205
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __Play_FunctionParams
		{
			// Token: 0x04017D3A RID: 97594
			[FieldOffset(0)]
			public IntPtr PlayerController;

			// Token: 0x04017D3B RID: 97595
			[FieldOffset(8)]
			public ETriggerEffectSide TriggerSide;

			// Token: 0x04017D3C RID: 97596
			[FieldOffset(16)]
			public IntPtr TriggerEffect;
		}
	}
}
