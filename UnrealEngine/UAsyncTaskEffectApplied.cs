using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001950 RID: 6480
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectApplied")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAsyncTaskEffectApplied : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018030 RID: 98352 RVA: 0x00233BB7 File Offset: 0x00231DB7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectApplied._ClassPtr;
		}

		// Token: 0x06018031 RID: 98353 RVA: 0x00233BC4 File Offset: 0x00231DC4
		public UAsyncTaskEffectApplied() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectApplied.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018032 RID: 98354 RVA: 0x00233BEC File Offset: 0x00231DEC
		public UAsyncTaskEffectApplied(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectApplied.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006025 RID: 24613
		// (get) Token: 0x06018033 RID: 98355 RVA: 0x00233C20 File Offset: 0x00231E20
		// (set) Token: 0x06018034 RID: 98356 RVA: 0x00233C59 File Offset: 0x00231E59
		public FOnEffectApplied OnEffectApplied
		{
			get
			{
				base.FastCheckIsValid();
				FOnEffectApplied result;
				if ((result = this._OnEffectApplied) == null)
				{
					result = (this._OnEffectApplied = new FOnEffectApplied(base.NativePtr + (IntPtr)UAsyncTaskEffectApplied.__PropertyOffset_OnEffectApplied, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskEffectApplied.__PropertyOffset_OnEffectApplied, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x06018035 RID: 98357 RVA: 0x00233C7A File Offset: 0x00231E7A
		// (set) Token: 0x06018036 RID: 98358 RVA: 0x00233C8E File Offset: 0x00231E8E
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskEffectApplied.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskEffectApplied.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x06018037 RID: 98359 RVA: 0x00233CA4 File Offset: 0x00231EA4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskEffectApplied ListenForEffectApplied(UAbilitySystemComponent AbilitySystemComponent, FGameplayTag EffectGameplayTag, FGameplayTag IgnoreGameplayTag)
		{
			UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams* ptr = stackalloc UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectApplied.__ListenForEffectApplied_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			ptr->EffectGameplayTag = EffectGameplayTag;
			ptr->IgnoreGameplayTag = IgnoreGameplayTag;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectApplied._ClassDefaultObjectPtr, UAsyncTaskEffectApplied.__ListenForEffectApplied_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectApplied>(ptr->__Result);
		}

		// Token: 0x06018038 RID: 98360 RVA: 0x00233D12 File Offset: 0x00231F12
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectApplied.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018039 RID: 98361 RVA: 0x00233D27 File Offset: 0x00231F27
		static UAsyncTaskEffectApplied()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectApplied");
		}

		// Token: 0x0601803A RID: 98362 RVA: 0x00233D35 File Offset: 0x00231F35
		protected UAsyncTaskEffectApplied(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFCD RID: 53197
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectApplied";

		// Token: 0x0400CFCE RID: 53198
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFCF RID: 53199
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFD0 RID: 53200
		internal static int __PropertyOffset_OnEffectApplied;

		// Token: 0x0400CFD1 RID: 53201
		[Nullable(2)]
		private FOnEffectApplied _OnEffectApplied;

		// Token: 0x0400CFD2 RID: 53202
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400CFD3 RID: 53203
		private static IntPtr __ListenForEffectApplied_NativeFunctionPtr;

		// Token: 0x0400CFD4 RID: 53204
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003021 RID: 12321
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ListenForEffectApplied_FunctionParams
		{
			// Token: 0x04016C59 RID: 93273
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016C5A RID: 93274
			[FieldOffset(8)]
			public FGameplayTag EffectGameplayTag;

			// Token: 0x04016C5B RID: 93275
			[FieldOffset(20)]
			public FGameplayTag IgnoreGameplayTag;

			// Token: 0x04016C5C RID: 93276
			[FieldOffset(32)]
			public IntPtr __Result;
		}
	}
}
