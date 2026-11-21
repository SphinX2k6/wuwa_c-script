using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042A RID: 1066
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectApplied")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAsyncTaskEffectApplied : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006673 RID: 26227 RVA: 0x000937DF File Offset: 0x000919DF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectApplied._ClassPtr;
		}

		// Token: 0x06006674 RID: 26228 RVA: 0x000937EC File Offset: 0x000919EC
		public UAsyncTaskEffectApplied() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectApplied.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006675 RID: 26229 RVA: 0x00093814 File Offset: 0x00091A14
		public UAsyncTaskEffectApplied(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectApplied.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700144C RID: 5196
		// (get) Token: 0x06006676 RID: 26230 RVA: 0x00093848 File Offset: 0x00091A48
		// (set) Token: 0x06006677 RID: 26231 RVA: 0x00093881 File Offset: 0x00091A81
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

		// Token: 0x1700144D RID: 5197
		// (get) Token: 0x06006678 RID: 26232 RVA: 0x000938A2 File Offset: 0x00091AA2
		// (set) Token: 0x06006679 RID: 26233 RVA: 0x000938B6 File Offset: 0x00091AB6
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

		// Token: 0x0600667A RID: 26234 RVA: 0x000938CC File Offset: 0x00091ACC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UAsyncTaskEffectApplied ListenForEffectApplied(UAbilitySystemComponent AbilitySystemComponent, FGameplayTag EffectGameplayTag, FGameplayTag IgnoreGameplayTag)
		{
			UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams* ptr = stackalloc UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UAsyncTaskEffectApplied.__ListenForEffectApplied_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectApplied.__ListenForEffectApplied_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			ptr->EffectGameplayTag = EffectGameplayTag;
			ptr->IgnoreGameplayTag = IgnoreGameplayTag;
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectApplied._ClassDefaultObjectPtr, UAsyncTaskEffectApplied.__ListenForEffectApplied_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectApplied>(ptr->__Result);
		}

		// Token: 0x0600667B RID: 26235 RVA: 0x00093939 File Offset: 0x00091B39
		[SkipLocalsInit]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectApplied.__EndTask_NativeFunctionPtr, null);
		}

		// Token: 0x0600667C RID: 26236 RVA: 0x0009394D File Offset: 0x00091B4D
		static UAsyncTaskEffectApplied()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectApplied");
		}

		// Token: 0x0600667D RID: 26237 RVA: 0x0009395B File Offset: 0x00091B5B
		protected UAsyncTaskEffectApplied(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B12 RID: 11026
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectApplied";

		// Token: 0x04002B13 RID: 11027
		private static IntPtr _ClassPtr;

		// Token: 0x04002B14 RID: 11028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B15 RID: 11029
		internal static int __PropertyOffset_OnEffectApplied;

		// Token: 0x04002B16 RID: 11030
		[Nullable(2)]
		private FOnEffectApplied _OnEffectApplied;

		// Token: 0x04002B17 RID: 11031
		internal static int __PropertyOffset_ASC;

		// Token: 0x04002B18 RID: 11032
		private static IntPtr __ListenForEffectApplied_NativeFunctionPtr;

		// Token: 0x04002B19 RID: 11033
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02000B33 RID: 2867
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __ListenForEffectApplied_FunctionParams
		{
			// Token: 0x04005BFE RID: 23550
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04005BFF RID: 23551
			[FieldOffset(8)]
			public FGameplayTag EffectGameplayTag;

			// Token: 0x04005C00 RID: 23552
			[FieldOffset(20)]
			public FGameplayTag IgnoreGameplayTag;

			// Token: 0x04005C01 RID: 23553
			[FieldOffset(32)]
			public IntPtr __Result;
		}
	}
}
