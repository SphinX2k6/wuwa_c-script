using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000750 RID: 1872
	[UnrealObjectPath("/Script/CoreUObject.Object")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UObject : UnrealUObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006305 RID: 25349 RVA: 0x0008E1E1 File Offset: 0x0008C3E1
		public static UClassStackOnlyPtr StaticClass()
		{
			return UObject._ClassPtr;
		}

		// Token: 0x06006306 RID: 25350 RVA: 0x0008E1F0 File Offset: 0x0008C3F0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe virtual void ExecuteUbergraph(int EntryPoint)
		{
			UObject.__ExecuteUbergraph_FunctionParams* ptr = stackalloc UObject.__ExecuteUbergraph_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UObject.__ExecuteUbergraph_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UObject.__ExecuteUbergraph_NativeFunctionPtr, (void*)ptr, 1);
			ptr->EntryPoint = EntryPoint;
			UnrealReflectionUtils.CallVirtualUFunction(base.NativePtr, UObject.__ExecuteUbergraph_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06006307 RID: 25351 RVA: 0x0008E236 File Offset: 0x0008C436
		static UObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Object");
		}

		// Token: 0x06006308 RID: 25352 RVA: 0x0008E244 File Offset: 0x0008C444
		protected UObject() : this(BuiltinUtils.AllocNativeUObject(UObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006309 RID: 25353 RVA: 0x0008E26C File Offset: 0x0008C46C
		protected UObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002F67 RID: 12135
		[Nullable(1)]
		public const string __ObjectPath = "/Script/CoreUObject.Object";

		// Token: 0x04002F68 RID: 12136
		private static IntPtr _ClassPtr;

		// Token: 0x04002F69 RID: 12137
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002F6A RID: 12138
		private static IntPtr __ExecuteUbergraph_NativeFunctionPtr;

		// Token: 0x02002C49 RID: 11337
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __ExecuteUbergraph_FunctionParams
		{
			// Token: 0x04016552 RID: 91474
			[FieldOffset(0)]
			public int EntryPoint;
		}
	}
}
