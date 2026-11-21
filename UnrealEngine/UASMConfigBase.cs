using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000824 RID: 2084
	[UnrealObjectPath("/Script/SMSystem.ASMConfigBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UASMConfigBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B610 RID: 46608 RVA: 0x00121976 File Offset: 0x0011FB76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UASMConfigBase._ClassPtr;
		}

		// Token: 0x0600B611 RID: 46609 RVA: 0x00121984 File Offset: 0x0011FB84
		[SkipLocalsInit]
		public unsafe virtual bool CanUseInAnimStateMachine()
		{
			UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams* ptr = stackalloc UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UASMConfigBase.__CanUseInAnimStateMachine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UASMConfigBase.__CanUseInAnimStateMachine_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B612 RID: 46610 RVA: 0x001219CC File Offset: 0x0011FBCC
		[SkipLocalsInit]
		protected unsafe virtual bool CanUseInAnimStateMachine_Implementation()
		{
			UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams* ptr = stackalloc UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UASMConfigBase.__CanUseInAnimStateMachine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UASMConfigBase.__CanUseInAnimStateMachine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UASMConfigBase.__CanUseInAnimStateMachine_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600B613 RID: 46611 RVA: 0x00121A11 File Offset: 0x0011FC11
		static UASMConfigBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SMSystem.ASMConfigBase");
		}

		// Token: 0x0600B614 RID: 46612 RVA: 0x00121A20 File Offset: 0x0011FC20
		protected UASMConfigBase() : this(BuiltinUtils.AllocNativeUObject(UASMConfigBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B615 RID: 46613 RVA: 0x00121A48 File Offset: 0x0011FC48
		protected UASMConfigBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005248 RID: 21064
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.ASMConfigBase";

		// Token: 0x04005249 RID: 21065
		private static IntPtr _ClassPtr;

		// Token: 0x0400524A RID: 21066
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400524B RID: 21067
		private static IntPtr __CanUseInAnimStateMachine_NativeFunctionPtr;

		// Token: 0x02001337 RID: 4919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __CanUseInAnimStateMachine_FunctionParams
		{
			// Token: 0x04006775 RID: 26485
			[FieldOffset(0)]
			public bool __Result;
		}
	}
}
