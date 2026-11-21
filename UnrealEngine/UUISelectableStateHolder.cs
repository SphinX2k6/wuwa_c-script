using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000722 RID: 1826
	[UnrealObjectPath("/Script/LGUI.UISelectableStateHolder")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UUISelectableStateHolder : UUISelectableTransitionComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009E4E RID: 40526 RVA: 0x000EB6D4 File Offset: 0x000E98D4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUISelectableStateHolder._ClassPtr;
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x000EB6E0 File Offset: 0x000E98E0
		public UUISelectableStateHolder() : this(BuiltinUtils.AllocNativeUObject(UUISelectableStateHolder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x000EB708 File Offset: 0x000E9908
		[NullableContext(1)]
		public UUISelectableStateHolder(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUISelectableStateHolder.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x000EB73C File Offset: 0x000E993C
		[SkipLocalsInit]
		public unsafe void SetAllTransitionsEnable(bool bEnable)
		{
			UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams* ptr = stackalloc UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UUISelectableStateHolder.__SetAllTransitionsEnable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UUISelectableStateHolder.__SetAllTransitionsEnable_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bEnable = bEnable;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UUISelectableStateHolder.__SetAllTransitionsEnable_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x000EB782 File Offset: 0x000E9982
		static UUISelectableStateHolder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UISelectableStateHolder");
		}

		// Token: 0x06009E53 RID: 40531 RVA: 0x000EB790 File Offset: 0x000E9990
		protected UUISelectableStateHolder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040043F8 RID: 17400
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UISelectableStateHolder";

		// Token: 0x040043F9 RID: 17401
		private static IntPtr _ClassPtr;

		// Token: 0x040043FA RID: 17402
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040043FB RID: 17403
		private static IntPtr __SetAllTransitionsEnable_NativeFunctionPtr;

		// Token: 0x02000F23 RID: 3875
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SetAllTransitionsEnable_FunctionParams
		{
			// Token: 0x040062F6 RID: 25334
			[FieldOffset(0)]
			public bool bEnable;
		}
	}
}
