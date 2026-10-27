using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E4 RID: 6628
	[UnrealObjectPath("/Script/KuroMovement.KuroMovementBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMovementBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018980 RID: 100736 RVA: 0x00243770 File Offset: 0x00241970
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMovementBPLibrary._ClassPtr;
		}

		// Token: 0x06018981 RID: 100737 RVA: 0x0024377C File Offset: 0x0024197C
		public UKuroMovementBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMovementBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018982 RID: 100738 RVA: 0x002437A4 File Offset: 0x002419A4
		[NullableContext(1)]
		public UKuroMovementBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMovementBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018983 RID: 100739 RVA: 0x002437D8 File Offset: 0x002419D8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EMoveHitType KuroSoar(float DeltaSeconds, UCharacterMovementComponent CharMoveComp, float AirFriction, float Aerodynamics, FVector Gravity, FVector SoarPlaneNormal, float MaxSpeed = 3000f)
		{
			UKuroMovementBPLibrary.__KuroSoar_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroSoar_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroSoar_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroSoar_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->AirFriction = AirFriction;
			ptr->Aerodynamics = Aerodynamics;
			ptr->Gravity = Gravity;
			ptr->SoarPlaneNormal = SoarPlaneNormal;
			ptr->MaxSpeed = MaxSpeed;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroSoar_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018984 RID: 100740 RVA: 0x00243860 File Offset: 0x00241A60
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int KuroSki(float DeltaTime, UCharacterMovementComponent CharMoveComp, FVector PrevBlockNormal, FVector Direction, FVector SpeedParams, float IgnoreStepHeight, UCurveFloat SpeedReduceCurve = null)
		{
			UKuroMovementBPLibrary.__KuroSki_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroSki_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroSki_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroSki_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->PrevBlockNormal = PrevBlockNormal;
			ptr->Direction = Direction;
			ptr->SpeedParams = SpeedParams;
			ptr->IgnoreStepHeight = IgnoreStepHeight;
			ptr->SpeedReduceCurve = ((SpeedReduceCurve != null) ? SpeedReduceCurve.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroSki_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018985 RID: 100741 RVA: 0x002438F8 File Offset: 0x00241AF8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool KuroRoll(float DeltaSeconds, UCharacterMovementComponent CharMoveComp, float TargetSpeed, float Friction, float AccelOnGround, ref FVector FloorNormal, float Gravity, float StepUpHeight, float MaxSpeed)
		{
			UKuroMovementBPLibrary.__KuroRoll_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroRoll_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroRoll_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroRoll_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->TargetSpeed = TargetSpeed;
			ptr->Friction = Friction;
			ptr->AccelOnGround = AccelOnGround;
			ptr->FloorNormal = FloorNormal;
			ptr->Gravity = Gravity;
			ptr->StepUpHeight = StepUpHeight;
			ptr->MaxSpeed = MaxSpeed;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroRoll_NativeFunctionPtr, (void*)ptr, 0);
			FloorNormal = ptr->FloorNormal;
			return ptr->__Result;
		}

		// Token: 0x06018986 RID: 100742 RVA: 0x002439A4 File Offset: 0x00241BA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static EMoveHitType KuroMoveByOffset(float DeltaSeconds, UCharacterMovementComponent CharMoveComp, FVector MoveDelta, EMoveSlideType SlideType = EMoveSlideType.Free, FVector SlideDirection = default(FVector))
		{
			UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroMoveByOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->MoveDelta = MoveDelta;
			ptr->SlideType = SlideType;
			ptr->SlideDirection = SlideDirection;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroMoveByOffset_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x06018987 RID: 100743 RVA: 0x00243A1C File Offset: 0x00241C1C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool KuroKite(float DeltaSeconds, UCharacterMovementComponent CharMoveComp, FVector TargetPrevPos, FVector TargetNextPos, float MinDist, float MaxDist, float MinAccel, float MaxAccel, float Friction, ref FVector InOutTargetForward, float FacingLerpSpeed, float FacingLerpRate)
		{
			UKuroMovementBPLibrary.__KuroKite_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroKite_FunctionParams[(UIntPtr)103] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroKite_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroKite_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->TargetPrevPos = TargetPrevPos;
			ptr->TargetNextPos = TargetNextPos;
			ptr->MinDist = MinDist;
			ptr->MaxDist = MaxDist;
			ptr->MinAccel = MinAccel;
			ptr->MaxAccel = MaxAccel;
			ptr->Friction = Friction;
			ptr->InOutTargetForward = InOutTargetForward;
			ptr->FacingLerpSpeed = FacingLerpSpeed;
			ptr->FacingLerpRate = FacingLerpRate;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroKite_NativeFunctionPtr, (void*)ptr, 0);
			InOutTargetForward = ptr->InOutTargetForward;
			return ptr->__Result;
		}

		// Token: 0x06018988 RID: 100744 RVA: 0x00243AE0 File Offset: 0x00241CE0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static int KuroEaseSpeedTo([Nullable(2)] UPawnMovementComponent PawnMoveComp, float TargetSpeed, EKuroEasingFuncType EaseType, float TransitionTime, float Exponent = 1f, string CurvePath = "")
		{
			UKuroMovementBPLibrary.__KuroEaseSpeedTo_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroEaseSpeedTo_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroEaseSpeedTo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroEaseSpeedTo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->PawnMoveComp = ((PawnMoveComp != null) ? PawnMoveComp.NativePtr : IntPtr.Zero);
			ptr->TargetSpeed = TargetSpeed;
			ptr->EaseType = EaseType;
			ptr->TransitionTime = TransitionTime;
			ptr->Exponent = Exponent;
			FString.CopyFrom((void*)(&ptr->CurvePath), CurvePath);
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroEaseSpeedTo_NativeFunctionPtr, (void*)ptr, 0);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroMovementBPLibrary.__KuroEaseSpeedTo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06018989 RID: 100745 RVA: 0x00243B78 File Offset: 0x00241D78
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float KuroBinarySearchCurve(UCurveFloat Curve, float Y, float From, float To, float tolerance = 0.01f)
		{
			UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroBinarySearchCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Curve = ((Curve != null) ? Curve.NativePtr : IntPtr.Zero);
			ptr->Y = Y;
			ptr->From = From;
			ptr->To = To;
			ptr->tolerance = tolerance;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroBinarySearchCurve_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601898A RID: 100746 RVA: 0x00243BF0 File Offset: 0x00241DF0
		static UKuroMovementBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMovementBPLibrary");
		}

		// Token: 0x0601898B RID: 100747 RVA: 0x00243BFE File Offset: 0x00241DFE
		protected UKuroMovementBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D4AD RID: 54445
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMovementBPLibrary";

		// Token: 0x0400D4AE RID: 54446
		private static IntPtr _ClassPtr;

		// Token: 0x0400D4AF RID: 54447
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D4B0 RID: 54448
		private static IntPtr __KuroSoar_NativeFunctionPtr;

		// Token: 0x0400D4B1 RID: 54449
		private static IntPtr __KuroSki_NativeFunctionPtr;

		// Token: 0x0400D4B2 RID: 54450
		private static IntPtr __KuroRoll_NativeFunctionPtr;

		// Token: 0x0400D4B3 RID: 54451
		private static IntPtr __KuroMoveByOffset_NativeFunctionPtr;

		// Token: 0x0400D4B4 RID: 54452
		private static IntPtr __KuroKite_NativeFunctionPtr;

		// Token: 0x0400D4B5 RID: 54453
		private static IntPtr __KuroEaseSpeedTo_NativeFunctionPtr;

		// Token: 0x0400D4B6 RID: 54454
		private static IntPtr __KuroBinarySearchCurve_NativeFunctionPtr;

		// Token: 0x0200308C RID: 12428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __KuroSoar_FunctionParams
		{
			// Token: 0x04016D77 RID: 93559
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04016D78 RID: 93560
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04016D79 RID: 93561
			[FieldOffset(16)]
			public float AirFriction;

			// Token: 0x04016D7A RID: 93562
			[FieldOffset(20)]
			public float Aerodynamics;

			// Token: 0x04016D7B RID: 93563
			[FieldOffset(24)]
			public FVector Gravity;

			// Token: 0x04016D7C RID: 93564
			[FieldOffset(36)]
			public FVector SoarPlaneNormal;

			// Token: 0x04016D7D RID: 93565
			[FieldOffset(48)]
			public float MaxSpeed;

			// Token: 0x04016D7E RID: 93566
			[FieldOffset(52)]
			public EMoveHitType __Result;
		}

		// Token: 0x0200308D RID: 12429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __KuroSki_FunctionParams
		{
			// Token: 0x04016D7F RID: 93567
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04016D80 RID: 93568
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04016D81 RID: 93569
			[FieldOffset(16)]
			public FVector PrevBlockNormal;

			// Token: 0x04016D82 RID: 93570
			[FieldOffset(28)]
			public FVector Direction;

			// Token: 0x04016D83 RID: 93571
			[FieldOffset(40)]
			public FVector SpeedParams;

			// Token: 0x04016D84 RID: 93572
			[FieldOffset(52)]
			public float IgnoreStepHeight;

			// Token: 0x04016D85 RID: 93573
			[FieldOffset(56)]
			public IntPtr SpeedReduceCurve;

			// Token: 0x04016D86 RID: 93574
			[FieldOffset(64)]
			public int __Result;
		}

		// Token: 0x0200308E RID: 12430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __KuroRoll_FunctionParams
		{
			// Token: 0x04016D87 RID: 93575
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04016D88 RID: 93576
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04016D89 RID: 93577
			[FieldOffset(16)]
			public float TargetSpeed;

			// Token: 0x04016D8A RID: 93578
			[FieldOffset(20)]
			public float Friction;

			// Token: 0x04016D8B RID: 93579
			[FieldOffset(24)]
			public float AccelOnGround;

			// Token: 0x04016D8C RID: 93580
			[FieldOffset(28)]
			public FVector FloorNormal;

			// Token: 0x04016D8D RID: 93581
			[FieldOffset(40)]
			public float Gravity;

			// Token: 0x04016D8E RID: 93582
			[FieldOffset(44)]
			public float StepUpHeight;

			// Token: 0x04016D8F RID: 93583
			[FieldOffset(48)]
			public float MaxSpeed;

			// Token: 0x04016D90 RID: 93584
			[FieldOffset(52)]
			public bool __Result;
		}

		// Token: 0x0200308F RID: 12431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __KuroMoveByOffset_FunctionParams
		{
			// Token: 0x04016D91 RID: 93585
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04016D92 RID: 93586
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04016D93 RID: 93587
			[FieldOffset(16)]
			public FVector MoveDelta;

			// Token: 0x04016D94 RID: 93588
			[FieldOffset(28)]
			public EMoveSlideType SlideType;

			// Token: 0x04016D95 RID: 93589
			[FieldOffset(32)]
			public FVector SlideDirection;

			// Token: 0x04016D96 RID: 93590
			[FieldOffset(44)]
			public EMoveHitType __Result;
		}

		// Token: 0x02003090 RID: 12432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __KuroKite_FunctionParams
		{
			// Token: 0x04016D97 RID: 93591
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04016D98 RID: 93592
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04016D99 RID: 93593
			[FieldOffset(16)]
			public FVector TargetPrevPos;

			// Token: 0x04016D9A RID: 93594
			[FieldOffset(28)]
			public FVector TargetNextPos;

			// Token: 0x04016D9B RID: 93595
			[FieldOffset(40)]
			public float MinDist;

			// Token: 0x04016D9C RID: 93596
			[FieldOffset(44)]
			public float MaxDist;

			// Token: 0x04016D9D RID: 93597
			[FieldOffset(48)]
			public float MinAccel;

			// Token: 0x04016D9E RID: 93598
			[FieldOffset(52)]
			public float MaxAccel;

			// Token: 0x04016D9F RID: 93599
			[FieldOffset(56)]
			public float Friction;

			// Token: 0x04016DA0 RID: 93600
			[FieldOffset(60)]
			public FVector InOutTargetForward;

			// Token: 0x04016DA1 RID: 93601
			[FieldOffset(72)]
			public float FacingLerpSpeed;

			// Token: 0x04016DA2 RID: 93602
			[FieldOffset(76)]
			public float FacingLerpRate;

			// Token: 0x04016DA3 RID: 93603
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02003091 RID: 12433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __KuroEaseSpeedTo_FunctionParams
		{
			// Token: 0x04016DA4 RID: 93604
			[FieldOffset(0)]
			public IntPtr PawnMoveComp;

			// Token: 0x04016DA5 RID: 93605
			[FieldOffset(8)]
			public float TargetSpeed;

			// Token: 0x04016DA6 RID: 93606
			[FieldOffset(12)]
			public EKuroEasingFuncType EaseType;

			// Token: 0x04016DA7 RID: 93607
			[FieldOffset(16)]
			public float TransitionTime;

			// Token: 0x04016DA8 RID: 93608
			[FieldOffset(20)]
			public float Exponent;

			// Token: 0x04016DA9 RID: 93609
			[FieldOffset(24)]
			public FString CurvePath;

			// Token: 0x04016DAA RID: 93610
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x02003092 RID: 12434
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __KuroBinarySearchCurve_FunctionParams
		{
			// Token: 0x04016DAB RID: 93611
			[FieldOffset(0)]
			public IntPtr Curve;

			// Token: 0x04016DAC RID: 93612
			[FieldOffset(8)]
			public float Y;

			// Token: 0x04016DAD RID: 93613
			[FieldOffset(12)]
			public float From;

			// Token: 0x04016DAE RID: 93614
			[FieldOffset(16)]
			public float To;

			// Token: 0x04016DAF RID: 93615
			[FieldOffset(20)]
			public float tolerance;

			// Token: 0x04016DB0 RID: 93616
			[FieldOffset(24)]
			public float __Result;
		}
	}
}
