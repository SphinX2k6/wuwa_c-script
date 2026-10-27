using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001954 RID: 6484
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskGameplayCueNotify")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskGameplayCueNotify : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018058 RID: 98392 RVA: 0x00234170 File Offset: 0x00232370
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskGameplayCueNotify._ClassPtr;
		}

		// Token: 0x06018059 RID: 98393 RVA: 0x0023417C File Offset: 0x0023237C
		public UAsyncTaskGameplayCueNotify() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskGameplayCueNotify.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601805A RID: 98394 RVA: 0x002341A4 File Offset: 0x002323A4
		public UAsyncTaskGameplayCueNotify(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskGameplayCueNotify.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700602B RID: 24619
		// (get) Token: 0x0601805B RID: 98395 RVA: 0x002341D8 File Offset: 0x002323D8
		// (set) Token: 0x0601805C RID: 98396 RVA: 0x00234211 File Offset: 0x00232411
		public FOnGameplayCueNotify GameplayCueEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameplayCueNotify result;
				if ((result = this._GameplayCueEvent) == null)
				{
					result = (this._GameplayCueEvent = new FOnGameplayCueNotify(base.NativePtr + (IntPtr)UAsyncTaskGameplayCueNotify.__PropertyOffset_GameplayCueEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskGameplayCueNotify.__PropertyOffset_GameplayCueEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700602C RID: 24620
		// (get) Token: 0x0601805D RID: 98397 RVA: 0x00234232 File Offset: 0x00232432
		// (set) Token: 0x0601805E RID: 98398 RVA: 0x00234246 File Offset: 0x00232446
		[Nullable(2)]
		public unsafe UAbilitySystemComponent ASC
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskGameplayCueNotify.__PropertyOffset_ASC);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskGameplayCueNotify.__PropertyOffset_ASC, value);
			}
		}

		// Token: 0x0601805F RID: 98399 RVA: 0x0023425C File Offset: 0x0023245C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskGameplayCueNotify ListenForGameplayCueNotify(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskGameplayCueNotify.__ListenForGameplayCueNotify_FunctionParams* ptr = stackalloc UAsyncTaskGameplayCueNotify.__ListenForGameplayCueNotify_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskGameplayCueNotify.__ListenForGameplayCueNotify_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskGameplayCueNotify.__ListenForGameplayCueNotify_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskGameplayCueNotify._ClassDefaultObjectPtr, UAsyncTaskGameplayCueNotify.__ListenForGameplayCueNotify_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskGameplayCueNotify>(ptr->__Result);
		}

		// Token: 0x06018060 RID: 98400 RVA: 0x002342BC File Offset: 0x002324BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskGameplayCueNotify.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06018061 RID: 98401 RVA: 0x002342D1 File Offset: 0x002324D1
		static UAsyncTaskGameplayCueNotify()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskGameplayCueNotify");
		}

		// Token: 0x06018062 RID: 98402 RVA: 0x002342DF File Offset: 0x002324DF
		protected UAsyncTaskGameplayCueNotify(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CFEB RID: 53227
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskGameplayCueNotify";

		// Token: 0x0400CFEC RID: 53228
		private static IntPtr _ClassPtr;

		// Token: 0x0400CFED RID: 53229
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CFEE RID: 53230
		internal static int __PropertyOffset_GameplayCueEvent;

		// Token: 0x0400CFEF RID: 53231
		[Nullable(2)]
		private FOnGameplayCueNotify _GameplayCueEvent;

		// Token: 0x0400CFF0 RID: 53232
		internal static int __PropertyOffset_ASC;

		// Token: 0x0400CFF1 RID: 53233
		private static IntPtr __ListenForGameplayCueNotify_NativeFunctionPtr;

		// Token: 0x0400CFF2 RID: 53234
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02003025 RID: 12325
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForGameplayCueNotify_FunctionParams
		{
			// Token: 0x04016C63 RID: 93283
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016C64 RID: 93284
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
