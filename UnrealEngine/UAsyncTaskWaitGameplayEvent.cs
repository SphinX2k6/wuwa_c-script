using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001959 RID: 6489
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskWaitGameplayEvent")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskWaitGameplayEvent : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060180AC RID: 98476 RVA: 0x00234F8F File Offset: 0x0023318F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskWaitGameplayEvent._ClassPtr;
		}

		// Token: 0x060180AD RID: 98477 RVA: 0x00234F9C File Offset: 0x0023319C
		public UAsyncTaskWaitGameplayEvent() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskWaitGameplayEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060180AE RID: 98478 RVA: 0x00234FC4 File Offset: 0x002331C4
		public UAsyncTaskWaitGameplayEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskWaitGameplayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006041 RID: 24641
		// (get) Token: 0x060180AF RID: 98479 RVA: 0x00234FF8 File Offset: 0x002331F8
		// (set) Token: 0x060180B0 RID: 98480 RVA: 0x00235031 File Offset: 0x00233231
		public FWaitGameplayEventDelegate EventReceived
		{
			get
			{
				base.FastCheckIsValid();
				FWaitGameplayEventDelegate result;
				if ((result = this._EventReceived) == null)
				{
					result = (this._EventReceived = new FWaitGameplayEventDelegate(base.NativePtr + (IntPtr)UAsyncTaskWaitGameplayEvent.__PropertyOffset_EventReceived, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UAsyncTaskWaitGameplayEvent.__PropertyOffset_EventReceived, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17006042 RID: 24642
		// (get) Token: 0x060180B1 RID: 98481 RVA: 0x00235052 File Offset: 0x00233252
		// (set) Token: 0x060180B2 RID: 98482 RVA: 0x00235066 File Offset: 0x00233266
		[Nullable(2)]
		public unsafe UAbilitySystemComponent AbilitySystemComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAbilitySystemComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskWaitGameplayEvent.__PropertyOffset_AbilitySystemComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAsyncTaskWaitGameplayEvent.__PropertyOffset_AbilitySystemComponent, value);
			}
		}

		// Token: 0x060180B3 RID: 98483 RVA: 0x0023507C File Offset: 0x0023327C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static UAsyncTaskWaitGameplayEvent ListenForGameplayEvent(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams* ptr = stackalloc UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskWaitGameplayEvent._ClassDefaultObjectPtr, UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskWaitGameplayEvent>(ptr->__Result);
		}

		// Token: 0x060180B4 RID: 98484 RVA: 0x002350DC File Offset: 0x002332DC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskWaitGameplayEvent.__EndTask_NativeFunctionPtr, null, 0);
		}

		// Token: 0x060180B5 RID: 98485 RVA: 0x002350F1 File Offset: 0x002332F1
		static UAsyncTaskWaitGameplayEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskWaitGameplayEvent");
		}

		// Token: 0x060180B6 RID: 98486 RVA: 0x002350FF File Offset: 0x002332FF
		protected UAsyncTaskWaitGameplayEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D02A RID: 53290
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskWaitGameplayEvent";

		// Token: 0x0400D02B RID: 53291
		private static IntPtr _ClassPtr;

		// Token: 0x0400D02C RID: 53292
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D02D RID: 53293
		internal static int __PropertyOffset_EventReceived;

		// Token: 0x0400D02E RID: 53294
		[Nullable(2)]
		private FWaitGameplayEventDelegate _EventReceived;

		// Token: 0x0400D02F RID: 53295
		internal static int __PropertyOffset_AbilitySystemComponent;

		// Token: 0x0400D030 RID: 53296
		private static IntPtr __ListenForGameplayEvent_NativeFunctionPtr;

		// Token: 0x0400D031 RID: 53297
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x0200302E RID: 12334
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForGameplayEvent_FunctionParams
		{
			// Token: 0x04016CA5 RID: 93349
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04016CA6 RID: 93350
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
