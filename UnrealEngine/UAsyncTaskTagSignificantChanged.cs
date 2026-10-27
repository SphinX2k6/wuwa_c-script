using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001958 RID: 6488
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskTagSignificantChanged")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAsyncTaskTagSignificantChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060180A1 RID: 98465 RVA: 0x00234E0F File Offset: 0x0023300F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskTagSignificantChanged._ClassPtr;
		}

		// Token: 0x060180A2 RID: 98466 RVA: 0x00234E1C File Offset: 0x0023301C
		public UAsyncTaskTagSignificantChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskTagSignificantChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060180A3 RID: 98467 RVA: 0x00234E44 File Offset: 0x00233044
		public UAsyncTaskTagSignificantChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskTagSignificantChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700603F RID: 24639
		// (get) Token: 0x060180A4 RID: 98468 RVA: 0x00234E78 File Offset: 0x00233078
		// (set) Token: 0x060180A5 RID: 98469 RVA: 0x00234EB1 File Offset: 0x002330B1
		public FOnTagSignificantChanged OnTagSignificantChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnTagSignificantChanged result;
				if ((result = this._OnTagSignificantChanged) == null)
				{
					result = (this._OnTagSignificantChanged = new FOnTagSignificantChanged(base.NativePtr + (IntPtr)UAsyncTaskTagSignificantChanged.__PropertyOffset_OnTagSignificantChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskTagSignificantChanged.__PropertyOffset_OnTagSignificantChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006040 RID: 24640
		// (get) Token: 0x060180A6 RID: 98470 RVA: 0x00234ED2 File Offset: 0x002330D2
		// (set) Token: 0x060180A7 RID: 98471 RVA: 0x00234EE6 File Offset: 0x002330E6
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskTagSignificantChanged.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskTagSignificantChanged.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x060180A8 RID: 98472 RVA: 0x00234EFC File Offset: 0x002330FC
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskTagSignificantChanged ListenForTagSignificantChanged(UAbilitySystemComponent AbilitySystemComponent, FGameplayTag Tag)
		{
			UAsyncTaskTagSignificantChanged.__ListenForTagSignificantChanged_FunctionParams* ptr = stackalloc UAsyncTaskTagSignificantChanged.__ListenForTagSignificantChanged_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAsyncTaskTagSignificantChanged.__ListenForTagSignificantChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskTagSignificantChanged.__ListenForTagSignificantChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskTagSignificantChanged._ClassDefaultObjectPtr, UAsyncTaskTagSignificantChanged.__ListenForTagSignificantChanged_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskTagSignificantChanged>(ptr->__Result);
		}

		// Token: 0x060180A9 RID: 98473 RVA: 0x00234F63 File Offset: 0x00233163
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskTagSignificantChanged.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060180AA RID: 98474 RVA: 0x00234F78 File Offset: 0x00233178
		static UAsyncTaskTagSignificantChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskTagSignificantChanged");
		}

		// Token: 0x060180AB RID: 98475 RVA: 0x00234F86 File Offset: 0x00233186
		protected UAsyncTaskTagSignificantChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D022 RID: 53282
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskTagSignificantChanged";

		// Token: 0x0400D023 RID: 53283
		private static IntPtr _ClassPtr;

		// Token: 0x0400D024 RID: 53284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D025 RID: 53285
		internal static int __PropertyOffset_OnTagSignificantChanged;

		// Token: 0x0400D026 RID: 53286
		[Nullable(2)]
		private FOnTagSignificantChanged _OnTagSignificantChanged;

		// Token: 0x0400D027 RID: 53287
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400D028 RID: 53288
		private static IntPtr __ListenForTagSignificantChanged_NativeFunctionPtr;

		// Token: 0x0400D029 RID: 53289
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x0200302D RID: 12333
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ListenForTagSignificantChanged_FunctionParams
		{
			// Token: 0x04016CA2 RID: 93346
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016CA3 RID: 93347
			[FieldOffset(8)]
			public FGameplayTag Tag;

			// Token: 0x04016CA4 RID: 93348
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
