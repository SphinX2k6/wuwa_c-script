using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D8 RID: 6360
	[UnrealObjectPath("/Script/KuroGameplay.KuroInputActionDelegateEvent")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 88)]
	public class UKuroInputActionDelegateEvent : UKuroInputDelegateEventBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017916 RID: 96534 RVA: 0x00227E9E File Offset: 0x0022609E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroInputActionDelegateEvent._ClassPtr;
		}

		// Token: 0x06017917 RID: 96535 RVA: 0x00227EAC File Offset: 0x002260AC
		public UKuroInputActionDelegateEvent() : this(BuiltinUtils.AllocNativeUObject(UKuroInputActionDelegateEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017918 RID: 96536 RVA: 0x00227ED4 File Offset: 0x002260D4
		[NullableContext(1)]
		public UKuroInputActionDelegateEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroInputActionDelegateEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017919 RID: 96537 RVA: 0x00227F08 File Offset: 0x00226108
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void DoActionCallback(FKey Key)
		{
			UKuroInputActionDelegateEvent.__DoActionCallback_FunctionParams* ptr = stackalloc UKuroInputActionDelegateEvent.__DoActionCallback_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroInputActionDelegateEvent.__DoActionCallback_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroInputActionDelegateEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 1);
			if (Key != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKey.StaticStruct(), &ptr->Key, Key.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroInputActionDelegateEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroInputActionDelegateEvent.__DoActionCallback_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601791A RID: 96538 RVA: 0x00227F7B File Offset: 0x0022617B
		static UKuroInputActionDelegateEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroInputActionDelegateEvent");
		}

		// Token: 0x0601791B RID: 96539 RVA: 0x00227F89 File Offset: 0x00226189
		protected UKuroInputActionDelegateEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CCAE RID: 52398
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroInputActionDelegateEvent";

		// Token: 0x0400CCAF RID: 52399
		private static IntPtr _ClassPtr;

		// Token: 0x0400CCB0 RID: 52400
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CCB1 RID: 52401
		private static IntPtr __DoActionCallback_NativeFunctionPtr;

		// Token: 0x02002FB9 RID: 12217
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __DoActionCallback_FunctionParams
		{
			// Token: 0x04016B9D RID: 93085
			[FieldOffset(0)]
			public byte Key;
		}
	}
}
