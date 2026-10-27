using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001957 RID: 6487
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskTagCountChanged")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UAsyncTaskTagCountChanged : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018096 RID: 98454 RVA: 0x00234C8F File Offset: 0x00232E8F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskTagCountChanged._ClassPtr;
		}

		// Token: 0x06018097 RID: 98455 RVA: 0x00234C9C File Offset: 0x00232E9C
		public UAsyncTaskTagCountChanged() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskTagCountChanged.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018098 RID: 98456 RVA: 0x00234CC4 File Offset: 0x00232EC4
		public UAsyncTaskTagCountChanged(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskTagCountChanged.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700603D RID: 24637
		// (get) Token: 0x06018099 RID: 98457 RVA: 0x00234CF8 File Offset: 0x00232EF8
		// (set) Token: 0x0601809A RID: 98458 RVA: 0x00234D31 File Offset: 0x00232F31
		public FOnTagCountChanged OnTagCountChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnTagCountChanged result;
				if ((result = this._OnTagCountChanged) == null)
				{
					result = (this._OnTagCountChanged = new FOnTagCountChanged(base.NativePtr + (IntPtr)UAsyncTaskTagCountChanged.__PropertyOffset_OnTagCountChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskTagCountChanged.__PropertyOffset_OnTagCountChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700603E RID: 24638
		// (get) Token: 0x0601809B RID: 98459 RVA: 0x00234D52 File Offset: 0x00232F52
		// (set) Token: 0x0601809C RID: 98460 RVA: 0x00234D66 File Offset: 0x00232F66
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskTagCountChanged.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskTagCountChanged.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x0601809D RID: 98461 RVA: 0x00234D7C File Offset: 0x00232F7C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskTagCountChanged ListenForTagCountChanged(UAbilitySystemComponent AbilitySystemComponent, FGameplayTag Tag)
		{
			UAsyncTaskTagCountChanged.__ListenForTagCountChanged_FunctionParams* ptr = stackalloc UAsyncTaskTagCountChanged.__ListenForTagCountChanged_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UAsyncTaskTagCountChanged.__ListenForTagCountChanged_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskTagCountChanged.__ListenForTagCountChanged_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			ptr->Tag = Tag;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskTagCountChanged._ClassDefaultObjectPtr, UAsyncTaskTagCountChanged.__ListenForTagCountChanged_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskTagCountChanged>(ptr->__Result);
		}

		// Token: 0x0601809E RID: 98462 RVA: 0x00234DE3 File Offset: 0x00232FE3
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskTagCountChanged.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601809F RID: 98463 RVA: 0x00234DF8 File Offset: 0x00232FF8
		static UAsyncTaskTagCountChanged()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskTagCountChanged");
		}

		// Token: 0x060180A0 RID: 98464 RVA: 0x00234E06 File Offset: 0x00233006
		protected UAsyncTaskTagCountChanged(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D01A RID: 53274
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskTagCountChanged";

		// Token: 0x0400D01B RID: 53275
		private static IntPtr _ClassPtr;

		// Token: 0x0400D01C RID: 53276
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D01D RID: 53277
		internal static int __PropertyOffset_OnTagCountChanged;

		// Token: 0x0400D01E RID: 53278
		[Nullable(2)]
		private FOnTagCountChanged _OnTagCountChanged;

		// Token: 0x0400D01F RID: 53279
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400D020 RID: 53280
		private static IntPtr __ListenForTagCountChanged_NativeFunctionPtr;

		// Token: 0x0400D021 RID: 53281
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x0200302C RID: 12332
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ListenForTagCountChanged_FunctionParams
		{
			// Token: 0x04016C9F RID: 93343
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016CA0 RID: 93344
			[FieldOffset(8)]
			public FGameplayTag Tag;

			// Token: 0x04016CA1 RID: 93345
			[FieldOffset(24)]
			public IntPtr __Result;
		}
	}
}
