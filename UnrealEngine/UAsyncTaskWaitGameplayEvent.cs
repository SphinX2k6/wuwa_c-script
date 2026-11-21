using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200042E RID: 1070
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGAS.AsyncTaskWaitGameplayEvent")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UAsyncTaskWaitGameplayEvent : UBlueprintAsyncActionBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060066BB RID: 26299 RVA: 0x000943CE File Offset: 0x000925CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAsyncTaskWaitGameplayEvent._ClassPtr;
		}

		// Token: 0x060066BC RID: 26300 RVA: 0x000943DC File Offset: 0x000925DC
		public UAsyncTaskWaitGameplayEvent() : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskWaitGameplayEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00094404 File Offset: 0x00092604
		public UAsyncTaskWaitGameplayEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAsyncTaskWaitGameplayEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x060066BE RID: 26302 RVA: 0x00094438 File Offset: 0x00092638
		// (set) Token: 0x060066BF RID: 26303 RVA: 0x00094471 File Offset: 0x00092671
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

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x060066C0 RID: 26304 RVA: 0x00094492 File Offset: 0x00092692
		// (set) Token: 0x060066C1 RID: 26305 RVA: 0x000944A6 File Offset: 0x000926A6
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

		// Token: 0x060066C2 RID: 26306 RVA: 0x000944BC File Offset: 0x000926BC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static UAsyncTaskWaitGameplayEvent ListenForGameplayEvent(UAbilitySystemComponent AbilitySystemComponent)
		{
			UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams* ptr = stackalloc UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_NativeFunctionPtr, (void*)ptr, 1);
			ptr->AbilitySystemComponent = ((AbilitySystemComponent != null) ? AbilitySystemComponent.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UAsyncTaskWaitGameplayEvent._ClassDefaultObjectPtr, UAsyncTaskWaitGameplayEvent.__ListenForGameplayEvent_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UAsyncTaskWaitGameplayEvent>(ptr->__Result);
		}

		// Token: 0x060066C3 RID: 26307 RVA: 0x0009451B File Offset: 0x0009271B
		[SkipLocalsInit]
		public void EndTask()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UAsyncTaskWaitGameplayEvent.__EndTask_NativeFunctionPtr, null);
		}

		// Token: 0x060066C4 RID: 26308 RVA: 0x0009452F File Offset: 0x0009272F
		static UAsyncTaskWaitGameplayEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGAS.AsyncTaskWaitGameplayEvent");
		}

		// Token: 0x060066C5 RID: 26309 RVA: 0x0009453D File Offset: 0x0009273D
		protected UAsyncTaskWaitGameplayEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002B48 RID: 11080
		public new const string __ObjectPath = "/Script/KuroGAS.AsyncTaskWaitGameplayEvent";

		// Token: 0x04002B49 RID: 11081
		private static IntPtr _ClassPtr;

		// Token: 0x04002B4A RID: 11082
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002B4B RID: 11083
		internal static int __PropertyOffset_EventReceived;

		// Token: 0x04002B4C RID: 11084
		[Nullable(2)]
		private FWaitGameplayEventDelegate _EventReceived;

		// Token: 0x04002B4D RID: 11085
		internal static int __PropertyOffset_AbilitySystemComponent;

		// Token: 0x04002B4E RID: 11086
		private static IntPtr __ListenForGameplayEvent_NativeFunctionPtr;

		// Token: 0x04002B4F RID: 11087
		private static IntPtr __EndTask_NativeFunctionPtr;

		// Token: 0x02000B3A RID: 2874
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ListenForGameplayEvent_FunctionParams
		{
			// Token: 0x04005C35 RID: 23605
			[FieldOffset(0)]
			public IntPtr AbilitySystemComponent;

			// Token: 0x04005C36 RID: 23606
			[FieldOffset(8)]
			public IntPtr __Result;
		}
	}
}
