using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200195E RID: 6494
	[UnrealObjectPath("/Script/KuroGAS.BaseGameplayEffectExecutionCalculation")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UBaseGameplayEffectExecutionCalculation : UGameplayEffectExecutionCalculation, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018245 RID: 98885 RVA: 0x002395EA File Offset: 0x002377EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBaseGameplayEffectExecutionCalculation._ClassPtr;
		}

		// Token: 0x06018246 RID: 98886 RVA: 0x002395F8 File Offset: 0x002377F8
		public UBaseGameplayEffectExecutionCalculation() : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayEffectExecutionCalculation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018247 RID: 98887 RVA: 0x00239620 File Offset: 0x00237820
		[NullableContext(1)]
		public UBaseGameplayEffectExecutionCalculation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBaseGameplayEffectExecutionCalculation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018248 RID: 98888 RVA: 0x00239654 File Offset: 0x00237854
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ExecuteImplementation(long GameplayEffectId, float Level, int StackNum, FGameplayEffectContextHandle Context, AActor Instigator, AActor Target)
		{
			UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_FunctionParams* ptr = stackalloc UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_NativeFunctionPtr, (void*)ptr, 1);
			ptr->GameplayEffectId = GameplayEffectId;
			ptr->Level = Level;
			ptr->StackNum = StackNum;
			if (Context != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FGameplayEffectContextHandle.StaticStruct(), &ptr->Context, Context.NativePtr, 1, false);
			}
			ptr->Instigator = ((Instigator != null) ? Instigator.NativePtr : IntPtr.Zero);
			ptr->Target = ((Target != null) ? Target.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UBaseGameplayEffectExecutionCalculation.__ExecuteImplementation_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06018249 RID: 98889 RVA: 0x0023970D File Offset: 0x0023790D
		static UBaseGameplayEffectExecutionCalculation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.BaseGameplayEffectExecutionCalculation");
		}

		// Token: 0x0601824A RID: 98890 RVA: 0x0023971B File Offset: 0x0023791B
		protected UBaseGameplayEffectExecutionCalculation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D184 RID: 53636
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGAS.BaseGameplayEffectExecutionCalculation";

		// Token: 0x0400D185 RID: 53637
		private static IntPtr _ClassPtr;

		// Token: 0x0400D186 RID: 53638
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D187 RID: 53639
		private static IntPtr __ExecuteImplementation_NativeFunctionPtr;

		// Token: 0x0200304D RID: 12365
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __ExecuteImplementation_FunctionParams
		{
			// Token: 0x04016D01 RID: 93441
			[FieldOffset(0)]
			public long GameplayEffectId;

			// Token: 0x04016D02 RID: 93442
			[FieldOffset(8)]
			public float Level;

			// Token: 0x04016D03 RID: 93443
			[FieldOffset(12)]
			public int StackNum;

			// Token: 0x04016D04 RID: 93444
			[FieldOffset(16)]
			public byte Context;

			// Token: 0x04016D05 RID: 93445
			[FieldOffset(40)]
			public IntPtr Instigator;

			// Token: 0x04016D06 RID: 93446
			[FieldOffset(48)]
			public IntPtr Target;
		}
	}
}
