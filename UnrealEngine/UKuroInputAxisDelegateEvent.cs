using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D9 RID: 6361
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputAxisDelegateEvent")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class UKuroInputAxisDelegateEvent : UKuroInputDelegateEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601791C RID: 96540 RVA: 0x00227F92 File Offset: 0x00226192
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputAxisDelegateEvent._ClassPtr;
		}

		// Token: 0x0601791D RID: 96541 RVA: 0x00227FA0 File Offset: 0x002261A0
		public UKuroInputAxisDelegateEvent() : this(BuiltinUtils.AllocNativeUObject(UKuroInputAxisDelegateEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601791E RID: 96542 RVA: 0x00227FC8 File Offset: 0x002261C8
		[NullableContext(1)]
		public UKuroInputAxisDelegateEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputAxisDelegateEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601791F RID: 96543 RVA: 0x00227FFC File Offset: 0x002261FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoAxisCallback(float Value)
		{
			UKuroInputAxisDelegateEvent.__DoAxisCallback_FunctionParams* ptr = stackalloc UKuroInputAxisDelegateEvent.__DoAxisCallback_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroInputAxisDelegateEvent.__DoAxisCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputAxisDelegateEvent.__DoAxisCallback_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Value = Value;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputAxisDelegateEvent.__DoAxisCallback_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06017920 RID: 96544 RVA: 0x00228043 File Offset: 0x00226243
		static UKuroInputAxisDelegateEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputAxisDelegateEvent");
		}

		// Token: 0x06017921 RID: 96545 RVA: 0x00228051 File Offset: 0x00226251
		protected UKuroInputAxisDelegateEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCB2 RID: 52402
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputAxisDelegateEvent";

		// Token: 0x0400CCB3 RID: 52403
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCB4 RID: 52404
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCB5 RID: 52405
		private static IntPtr __DoAxisCallback_NativeFunctionPtr;

		// Token: 0x02002FBA RID: 12218
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __DoAxisCallback_FunctionParams
		{
			// Token: 0x04016B9E RID: 93086
			[FieldOffset(0)]
			public float Value;
		}
	}
}
