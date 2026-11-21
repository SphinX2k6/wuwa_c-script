using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042B RID: 1067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskEffectDebugString")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskEffectDebugString : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600667E RID: 26238 RVA: 0x00093964 File Offset: 0x00091B64
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskEffectDebugString._ClassPtr;
		}

		// Token: 0x0600667F RID: 26239 RVA: 0x00093970 File Offset: 0x00091B70
		public UAsyncTaskEffectDebugString() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectDebugString.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006680 RID: 26240 RVA: 0x00093998 File Offset: 0x00091B98
		public UAsyncTaskEffectDebugString(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskEffectDebugString.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700144E RID: 5198
		// (get) Token: 0x06006681 RID: 26241 RVA: 0x000939CC File Offset: 0x00091BCC
		// (set) Token: 0x06006682 RID: 26242 RVA: 0x00093A05 File Offset: 0x00091C05
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

		// Token: 0x1700144F RID: 5199
		// (get) Token: 0x06006683 RID: 26243 RVA: 0x00093A26 File Offset: 0x00091C26
		// (set) Token: 0x06006684 RID: 26244 RVA: 0x00093A3A File Offset: 0x00091C3A
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

		// Token: 0x06006685 RID: 26245 RVA: 0x00093A50 File Offset: 0x00091C50
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UAsyncTaskEffectDebugString ListenForGameplayEffectExecutedDebugString(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams* ptr = stackalloc UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskEffectDebugString._ClassDefaultObjectPtr, UAsyncTaskEffectDebugString.__ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskEffectDebugString>(ptr->__Result);
		}

		// Token: 0x06006686 RID: 26246 RVA: 0x00093AAF File Offset: 0x00091CAF
		[SkipLocalsInit]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskEffectDebugString.__EndTask_NativeFunctionPtr, null);
		}

		// Token: 0x06006687 RID: 26247 RVA: 0x00093AC3 File Offset: 0x00091CC3
		static UAsyncTaskEffectDebugString()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskEffectDebugString");
		}

		// Token: 0x06006688 RID: 26248 RVA: 0x00093AD1 File Offset: 0x00091CD1
		protected UAsyncTaskEffectDebugString(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B1A RID: 11034
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskEffectDebugString";

		// Token: 0x04002B1B RID: 11035
		private static IntPtr _ClassPtr;

		// Token: 0x04002B1C RID: 11036
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B1D RID: 11037
		internal static int __PropertyOffset_OnAnyGameplayEffectExecuted;

		// Token: 0x04002B1E RID: 11038
		[Nullable(2)]
		private FOnGameplayEffectExecuted _OnAnyGameplayEffectExecuted;

		// Token: 0x04002B1F RID: 11039
		internal static int __PropertyOffset_ASC;

		// Token: 0x04002B20 RID: 11040
		private static IntPtr __ListenForGameplayEffectExecutedDebugString_NativeFunctionPtr;

		// Token: 0x04002B21 RID: 11041
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02000B34 RID: 2868
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForGameplayEffectExecutedDebugString_FunctionParams
		{
			// Token: 0x04005C02 RID: 23554
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04005C03 RID: 23555
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
