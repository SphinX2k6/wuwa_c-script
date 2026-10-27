using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200194E RID: 6478
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskAnyEffectRemoved")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAsyncTaskAnyEffectRemoved : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018018 RID: 98328 RVA: 0x00233913 File Offset: 0x00231B13
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskAnyEffectRemoved._ClassPtr;
		}

		// Token: 0x06018019 RID: 98329 RVA: 0x00233920 File Offset: 0x00231B20
		public UAsyncTaskAnyEffectRemoved() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectRemoved.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601801A RID: 98330 RVA: 0x00233948 File Offset: 0x00231B48
		public UAsyncTaskAnyEffectRemoved(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskAnyEffectRemoved.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006021 RID: 24609
		// (get) Token: 0x0601801B RID: 98331 RVA: 0x0023397C File Offset: 0x00231B7C
		// (set) Token: 0x0601801C RID: 98332 RVA: 0x002339B5 File Offset: 0x00231BB5
		public FOnGameplayEffectRemoved OnEffectRemoved
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameplayEffectRemoved result;
				if ((result = this._OnEffectRemoved) == null)
				{
					result = (this._OnEffectRemoved = new FOnGameplayEffectRemoved(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectRemoved.__PropertyOffset_OnEffectRemoved, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskAnyEffectRemoved.__PropertyOffset_OnEffectRemoved, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006022 RID: 24610
		// (get) Token: 0x0601801D RID: 98333 RVA: 0x002339D6 File Offset: 0x00231BD6
		// (set) Token: 0x0601801E RID: 98334 RVA: 0x002339EA File Offset: 0x00231BEA
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectRemoved.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskAnyEffectRemoved.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x0601801F RID: 98335 RVA: 0x00233A00 File Offset: 0x00231C00
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskAnyEffectRemoved ListenForAnyEffectRemoved(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskAnyEffectRemoved.__ListenForAnyEffectRemoved_FunctionParams* ptr = stackalloc UAsyncTaskAnyEffectRemoved.__ListenForAnyEffectRemoved_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskAnyEffectRemoved.__ListenForAnyEffectRemoved_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskAnyEffectRemoved.__ListenForAnyEffectRemoved_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskAnyEffectRemoved._ClassDefaultObjectPtr, UAsyncTaskAnyEffectRemoved.__ListenForAnyEffectRemoved_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskAnyEffectRemoved>(ptr->__Result);
		}

		// Token: 0x06018020 RID: 98336 RVA: 0x00233A60 File Offset: 0x00231C60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskAnyEffectRemoved.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018021 RID: 98337 RVA: 0x00233A75 File Offset: 0x00231C75
		static UAsyncTaskAnyEffectRemoved()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskAnyEffectRemoved");
		}

		// Token: 0x06018022 RID: 98338 RVA: 0x00233A83 File Offset: 0x00231C83
		protected UAsyncTaskAnyEffectRemoved(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFBF RID: 53183
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskAnyEffectRemoved";

		// Token: 0x0400CFC0 RID: 53184
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFC1 RID: 53185
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFC2 RID: 53186
		internal static int __PropertyOffset_OnEffectRemoved;

		// Token: 0x0400CFC3 RID: 53187
		[Nullable(2)]
		private FOnGameplayEffectRemoved _OnEffectRemoved;

		// Token: 0x0400CFC4 RID: 53188
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400CFC5 RID: 53189
		private static IntPtr __ListenForAnyEffectRemoved_NativeFunctionPtr;

		// Token: 0x0400CFC6 RID: 53190
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003020 RID: 12320
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForAnyEffectRemoved_FunctionParams
		{
			// Token: 0x04016C57 RID: 93271
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016C58 RID: 93272
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
