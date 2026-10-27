using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195F RID: 6495
	[UnrealObjectPath("/Script/KuroGAS.BaseGameplayModMagnitudeCalculation")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UBaseGameplayModMagnitudeCalculation : UGameplayModMagnitudeCalculation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601824B RID: 98891 RVA: 0x00239724 File Offset: 0x00237924
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseGameplayModMagnitudeCalculation._ClassPtr;
		}

		// Token: 0x0601824C RID: 98892 RVA: 0x00239730 File Offset: 0x00237930
		public UBaseGameplayModMagnitudeCalculation() : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayModMagnitudeCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601824D RID: 98893 RVA: 0x00239758 File Offset: 0x00237958
		[NullableContext(1)]
		public UBaseGameplayModMagnitudeCalculation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayModMagnitudeCalculation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601824E RID: 98894 RVA: 0x0023978C File Offset: 0x0023798C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual float CalculationImplementation(long GameplayEffectId, float Level, int stackNum, AActor Instigator, AActor Target)
		{
			UBaseGameplayModMagnitudeCalculation.__CalculationImplementation_FunctionParams* ptr = stackalloc UBaseGameplayModMagnitudeCalculation.__CalculationImplementation_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UBaseGameplayModMagnitudeCalculation.__CalculationImplementation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseGameplayModMagnitudeCalculation.__CalculationImplementation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectId = GameplayEffectId;
			ptr->Level = Level;
			ptr->stackNum = stackNum;
			ptr->Instigator = ((Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UBaseGameplayModMagnitudeCalculation.__CalculationImplementation_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0601824F RID: 98895 RVA: 0x00239816 File Offset: 0x00237A16
		static UBaseGameplayModMagnitudeCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseGameplayModMagnitudeCalculation");
		}

		// Token: 0x06018250 RID: 98896 RVA: 0x00239824 File Offset: 0x00237A24
		protected UBaseGameplayModMagnitudeCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D188 RID: 53640
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseGameplayModMagnitudeCalculation";

		// Token: 0x0400D189 RID: 53641
		private static IntPtr _ClassPtr;

		// Token: 0x0400D18A RID: 53642
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D18B RID: 53643
		private static IntPtr __CalculationImplementation_NativeFunctionPtr;

		// Token: 0x0200304E RID: 12366
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __CalculationImplementation_FunctionParams
		{
			// Token: 0x04016D07 RID: 93447
			[FieldOffset(0)]
			public long GameplayEffectId;

			// Token: 0x04016D08 RID: 93448
			[FieldOffset(8)]
			public float Level;

			// Token: 0x04016D09 RID: 93449
			[FieldOffset(12)]
			public int stackNum;

			// Token: 0x04016D0A RID: 93450
			[FieldOffset(16)]
			public IntPtr Instigator;

			// Token: 0x04016D0B RID: 93451
			[FieldOffset(24)]
			public IntPtr Target;

			// Token: 0x04016D0C RID: 93452
			[FieldOffset(32)]
			public float __Result;
		}
	}
}
