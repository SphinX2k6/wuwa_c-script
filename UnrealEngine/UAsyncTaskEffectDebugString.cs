using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001951 RID: 6481
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectDebugString")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskEffectDebugString : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601803B RID: 98363 RVA: 0x00233D3E File Offset: 0x00231F3E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectDebugString._ClassPtr;
		}

		// Token: 0x0601803C RID: 98364 RVA: 0x00233D4C File Offset: 0x00231F4C
		public UAsyncTaskEffectDebugString() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectDebugString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601803D RID: 98365 RVA: 0x00233D74 File Offset: 0x00231F74
		public UAsyncTaskEffectDebugString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectDebugString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x0601803E RID: 98366 RVA: 0x00233DA8 File Offset: 0x00231FA8
		// (set) Token: 0x0601803F RID: 98367 RVA: 0x00233DE1 File Offset: 0x00231FE1
		public FOnGameplayEffectExecuted OnAnyGameplayEffectExecuted
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameplayEffectExecuted result;
				if ((result = this._OnAnyGameplayEffectExecuted) == null)
				{
					result = (this._OnAnyGameplayEffectExecuted = new FOnGameplayEffectExecuted(base.NativePtr + (IntPtr)UAsyncTaskEffectDebugString.__PropertyOffset_OnAnyGameplayEffectExecuted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskEffectDebugString.__PropertyOffset_OnAnyGameplayEffectExecuted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x06018040 RID: 98368 RVA: 0x00233E02 File Offset: 0x00232002
		// (set) Token: 0x06018041 RID: 98369 RVA: 0x00233E16 File Offset: 0x00232016
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskEffectDebugString.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskEffectDebugString.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x06018042 RID: 98370 RVA: 0x00233E2C File Offset: 0x0023202C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskEffectDebugString ListenForGameplayEffectExecutedDebugString(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams* ptr = stackalloc UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectDebugString._ClassDefaultObjectPtr, UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectDebugString>(ptr->__Result);
		}

		// Token: 0x06018043 RID: 98371 RVA: 0x00233E8C File Offset: 0x0023208C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectDebugString.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018044 RID: 98372 RVA: 0x00233EA1 File Offset: 0x002320A1
		static UAsyncTaskEffectDebugString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectDebugString");
		}

		// Token: 0x06018045 RID: 98373 RVA: 0x00233EAF File Offset: 0x002320AF
		protected UAsyncTaskEffectDebugString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFD5 RID: 53205
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectDebugString";

		// Token: 0x0400CFD6 RID: 53206
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFD7 RID: 53207
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFD8 RID: 53208
		internal static int __PropertyOffset_OnAnyGameplayEffectExecuted;

		// Token: 0x0400CFD9 RID: 53209
		[Nullable(2)]
		private FOnGameplayEffectExecuted _OnAnyGameplayEffectExecuted;

		// Token: 0x0400CFDA RID: 53210
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400CFDB RID: 53211
		private static IntPtr __ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr;

		// Token: 0x0400CFDC RID: 53212
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003022 RID: 12322
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForGameplayEffectExecutedDebugString_FunctionParams
		{
			// Token: 0x04016C5D RID: 93277
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016C5E RID: 93278
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
