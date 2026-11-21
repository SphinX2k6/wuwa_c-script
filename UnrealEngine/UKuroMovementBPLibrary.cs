using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000472 RID: 1138
	[UnrealObjectPath("/Script/KuroMovement.KuroMovementBPLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMovementBPLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006C3B RID: 27707 RVA: 0x0009D709 File Offset: 0x0009B909
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMovementBPLibrary._ClassPtr;
		}

		// Token: 0x06006C3C RID: 27708 RVA: 0x0009D718 File Offset: 0x0009B918
		public UKuroMovementBPLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMovementBPLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006C3D RID: 27709 RVA: 0x0009D740 File Offset: 0x0009B940
		[NullableContext(1)]
		public UKuroMovementBPLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMovementBPLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006C3E RID: 27710 RVA: 0x0009D774 File Offset: 0x0009B974
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroSoar_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006C3F RID: 27711 RVA: 0x0009D7FC File Offset: 0x0009B9FC
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroSki_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006C40 RID: 27712 RVA: 0x0009D894 File Offset: 0x0009BA94
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroRoll_NativeFunctionPtr, (void*)ptr);
			FloorNormal = ptr->FloorNormal;
			return ptr->__Result;
		}

		// Token: 0x06006C41 RID: 27713 RVA: 0x0009D940 File Offset: 0x0009BB40
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static EMoveHitType KuroMoveByOffset(float DeltaSeconds, UCharacterMovementComponent CharMoveComp, FVector MoveDelta, EMoveSlideType SlideType = EMoveSlideType.Free, FVector SlideDirection = default(FVector))
		{
			UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroMoveByOffset_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroMoveByOffset_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaSeconds = DeltaSeconds;
			ptr->CharMoveComp = ((CharMoveComp != null) ? CharMoveComp.NativePtr : IntPtr.Zero);
			ptr->MoveDelta = MoveDelta;
			ptr->SlideType = SlideType;
			ptr->SlideDirection = SlideDirection;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroMoveByOffset_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006C42 RID: 27714 RVA: 0x0009D9B8 File Offset: 0x0009BBB8
		[NullableContext(2)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroKite_NativeFunctionPtr, (void*)ptr);
			InOutTargetForward = ptr->InOutTargetForward;
			return ptr->__Result;
		}

		// Token: 0x06006C43 RID: 27715 RVA: 0x0009DA7C File Offset: 0x0009BC7C
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroEaseSpeedTo_NativeFunctionPtr, (void*)ptr);
			int _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroMovementBPLibrary.__KuroEaseSpeedTo_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06006C44 RID: 27716 RVA: 0x0009DB14 File Offset: 0x0009BD14
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static float KuroBinarySearchCurve(UCurveFloat Curve, float Y, float From, float To, float tolerance = 0.01f)
		{
			UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams* ptr = stackalloc UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroMovementBPLibrary.__KuroBinarySearchCurve_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMovementBPLibrary.__KuroBinarySearchCurve_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Curve = ((Curve != null) ? Curve.NativePtr : IntPtr.Zero);
			ptr->Y = Y;
			ptr->From = From;
			ptr->To = To;
			ptr->tolerance = tolerance;
			UnrealReflectionUtils.CallUFunction(UKuroMovementBPLibrary._ClassDefaultObjectPtr, UKuroMovementBPLibrary.__KuroBinarySearchCurve_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06006C45 RID: 27717 RVA: 0x0009DB8B File Offset: 0x0009BD8B
		static UKuroMovementBPLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroMovementBPLibrary");
		}

		// Token: 0x06006C46 RID: 27718 RVA: 0x0009DB99 File Offset: 0x0009BD99
		protected UKuroMovementBPLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E32 RID: 11826
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroMovementBPLibrary";

		// Token: 0x04002E33 RID: 11827
		private static IntPtr _ClassPtr;

		// Token: 0x04002E34 RID: 11828
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002E35 RID: 11829
		private static IntPtr __KuroSoar_NativeFunctionPtr;

		// Token: 0x04002E36 RID: 11830
		private static IntPtr __KuroSki_NativeFunctionPtr;

		// Token: 0x04002E37 RID: 11831
		private static IntPtr __KuroRoll_NativeFunctionPtr;

		// Token: 0x04002E38 RID: 11832
		private static IntPtr __KuroMoveByOffset_NativeFunctionPtr;

		// Token: 0x04002E39 RID: 11833
		private static IntPtr __KuroKite_NativeFunctionPtr;

		// Token: 0x04002E3A RID: 11834
		private static IntPtr __KuroEaseSpeedTo_NativeFunctionPtr;

		// Token: 0x04002E3B RID: 11835
		private static IntPtr __KuroBinarySearchCurve_NativeFunctionPtr;

		// Token: 0x02000B70 RID: 2928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __KuroSoar_FunctionParams
		{
			// Token: 0x04005C95 RID: 23701
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04005C96 RID: 23702
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04005C97 RID: 23703
			[FieldOffset(16)]
			public float AirFriction;

			// Token: 0x04005C98 RID: 23704
			[FieldOffset(20)]
			public float Aerodynamics;

			// Token: 0x04005C99 RID: 23705
			[FieldOffset(24)]
			public FVector Gravity;

			// Token: 0x04005C9A RID: 23706
			[FieldOffset(36)]
			public FVector SoarPlaneNormal;

			// Token: 0x04005C9B RID: 23707
			[FieldOffset(48)]
			public float MaxSpeed;

			// Token: 0x04005C9C RID: 23708
			[FieldOffset(52)]
			public EMoveHitType __Result;
		}

		// Token: 0x02000B71 RID: 2929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __KuroSki_FunctionParams
		{
			// Token: 0x04005C9D RID: 23709
			[FieldOffset(0)]
			public float DeltaTime;

			// Token: 0x04005C9E RID: 23710
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04005C9F RID: 23711
			[FieldOffset(16)]
			public FVector PrevBlockNormal;

			// Token: 0x04005CA0 RID: 23712
			[FieldOffset(28)]
			public FVector Direction;

			// Token: 0x04005CA1 RID: 23713
			[FieldOffset(40)]
			public FVector SpeedParams;

			// Token: 0x04005CA2 RID: 23714
			[FieldOffset(52)]
			public float IgnoreStepHeight;

			// Token: 0x04005CA3 RID: 23715
			[FieldOffset(56)]
			public IntPtr SpeedReduceCurve;

			// Token: 0x04005CA4 RID: 23716
			[FieldOffset(64)]
			public int __Result;
		}

		// Token: 0x02000B72 RID: 2930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __KuroRoll_FunctionParams
		{
			// Token: 0x04005CA5 RID: 23717
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04005CA6 RID: 23718
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04005CA7 RID: 23719
			[FieldOffset(16)]
			public float TargetSpeed;

			// Token: 0x04005CA8 RID: 23720
			[FieldOffset(20)]
			public float Friction;

			// Token: 0x04005CA9 RID: 23721
			[FieldOffset(24)]
			public float AccelOnGround;

			// Token: 0x04005CAA RID: 23722
			[FieldOffset(28)]
			public FVector FloorNormal;

			// Token: 0x04005CAB RID: 23723
			[FieldOffset(40)]
			public float Gravity;

			// Token: 0x04005CAC RID: 23724
			[FieldOffset(44)]
			public float StepUpHeight;

			// Token: 0x04005CAD RID: 23725
			[FieldOffset(48)]
			public float MaxSpeed;

			// Token: 0x04005CAE RID: 23726
			[FieldOffset(52)]
			public bool __Result;
		}

		// Token: 0x02000B73 RID: 2931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __KuroMoveByOffset_FunctionParams
		{
			// Token: 0x04005CAF RID: 23727
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04005CB0 RID: 23728
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04005CB1 RID: 23729
			[FieldOffset(16)]
			public FVector MoveDelta;

			// Token: 0x04005CB2 RID: 23730
			[FieldOffset(28)]
			public EMoveSlideType SlideType;

			// Token: 0x04005CB3 RID: 23731
			[FieldOffset(32)]
			public FVector SlideDirection;

			// Token: 0x04005CB4 RID: 23732
			[FieldOffset(44)]
			public EMoveHitType __Result;
		}

		// Token: 0x02000B74 RID: 2932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __KuroKite_FunctionParams
		{
			// Token: 0x04005CB5 RID: 23733
			[FieldOffset(0)]
			public float DeltaSeconds;

			// Token: 0x04005CB6 RID: 23734
			[FieldOffset(8)]
			public IntPtr CharMoveComp;

			// Token: 0x04005CB7 RID: 23735
			[FieldOffset(16)]
			public FVector TargetPrevPos;

			// Token: 0x04005CB8 RID: 23736
			[FieldOffset(28)]
			public FVector TargetNextPos;

			// Token: 0x04005CB9 RID: 23737
			[FieldOffset(40)]
			public float MinDist;

			// Token: 0x04005CBA RID: 23738
			[FieldOffset(44)]
			public float MaxDist;

			// Token: 0x04005CBB RID: 23739
			[FieldOffset(48)]
			public float MinAccel;

			// Token: 0x04005CBC RID: 23740
			[FieldOffset(52)]
			public float MaxAccel;

			// Token: 0x04005CBD RID: 23741
			[FieldOffset(56)]
			public float Friction;

			// Token: 0x04005CBE RID: 23742
			[FieldOffset(60)]
			public FVector InOutTargetForward;

			// Token: 0x04005CBF RID: 23743
			[FieldOffset(72)]
			public float FacingLerpSpeed;

			// Token: 0x04005CC0 RID: 23744
			[FieldOffset(76)]
			public float FacingLerpRate;

			// Token: 0x04005CC1 RID: 23745
			[FieldOffset(80)]
			public bool __Result;
		}

		// Token: 0x02000B75 RID: 2933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __KuroEaseSpeedTo_FunctionParams
		{
			// Token: 0x04005CC2 RID: 23746
			[FieldOffset(0)]
			public IntPtr PawnMoveComp;

			// Token: 0x04005CC3 RID: 23747
			[FieldOffset(8)]
			public float TargetSpeed;

			// Token: 0x04005CC4 RID: 23748
			[FieldOffset(12)]
			public EKuroEasingFuncType EaseType;

			// Token: 0x04005CC5 RID: 23749
			[FieldOffset(16)]
			public float TransitionTime;

			// Token: 0x04005CC6 RID: 23750
			[FieldOffset(20)]
			public float Exponent;

			// Token: 0x04005CC7 RID: 23751
			[FieldOffset(24)]
			public FString CurvePath;

			// Token: 0x04005CC8 RID: 23752
			[FieldOffset(40)]
			public int __Result;
		}

		// Token: 0x02000B76 RID: 2934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __KuroBinarySearchCurve_FunctionParams
		{
			// Token: 0x04005CC9 RID: 23753
			[FieldOffset(0)]
			public IntPtr Curve;

			// Token: 0x04005CCA RID: 23754
			[FieldOffset(8)]
			public float Y;

			// Token: 0x04005CCB RID: 23755
			[FieldOffset(12)]
			public float From;

			// Token: 0x04005CCC RID: 23756
			[FieldOffset(16)]
			public float To;

			// Token: 0x04005CCD RID: 23757
			[FieldOffset(20)]
			public float tolerance;

			// Token: 0x04005CCE RID: 23758
			[FieldOffset(24)]
			public float __Result;
		}
	}
}
