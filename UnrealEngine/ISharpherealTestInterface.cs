using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EB RID: 2027
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestInterface")]
	public interface ISharpherealTestInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600ADA3 RID: 44451
		int InterfaceOffset();

		// Token: 0x0600ADA4 RID: 44452 RVA: 0x00100EF4 File Offset: 0x000FF0F4
		[SkipLocalsInit]
		unsafe int Get1()
		{
			ISharpherealTestInterface.__Get1_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Get1_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISharpherealTestInterface.__Get1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Get1_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Get1_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600ADA5 RID: 44453 RVA: 0x00100F3C File Offset: 0x000FF13C
		[NullableContext(2)]
		[SkipLocalsInit]
		unsafe bool Cast(UObject Src, ref ISharpherealTestInterface Out)
		{
			ISharpherealTestInterface.__Cast_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Cast_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ISharpherealTestInterface.__Cast_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Cast_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Src = ((Src != null) ? Src.NativePtr : IntPtr.Zero);
			ref ISharpherealTestInterface.__Cast_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = Out;
			ISharpherealTestInterface sharpherealTestInterface = Out;
			ptr2.Out = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Cast_NativeFunctionPtr, (void*)ptr);
			Out = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->Out.ObjectPointer) as ISharpherealTestInterface);
			return ptr->__Result;
		}

		// Token: 0x0600ADA6 RID: 44454 RVA: 0x00100FCC File Offset: 0x000FF1CC
		[SkipLocalsInit]
		unsafe FVector Add(in FVector A, in FVector B)
		{
			ISharpherealTestInterface.__Add_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Add_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(ISharpherealTestInterface.__Add_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Add_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Add_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x04004AE9 RID: 19177
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestInterface";

		// Token: 0x02000F96 RID: 3990
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get1_FunctionParams
		{
			// Token: 0x04006396 RID: 25494
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000F97 RID: 3991
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Cast_FunctionParams
		{
			// Token: 0x04006397 RID: 25495
			[FieldOffset(0)]
			public IntPtr Src;

			// Token: 0x04006398 RID: 25496
			[FieldOffset(8)]
			public FScriptInterface Out;

			// Token: 0x04006399 RID: 25497
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02000F98 RID: 3992
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __Add_FunctionParams
		{
			// Token: 0x0400639A RID: 25498
			[FieldOffset(0)]
			public FVector A;

			// Token: 0x0400639B RID: 25499
			[FieldOffset(12)]
			public FVector B;

			// Token: 0x0400639C RID: 25500
			[FieldOffset(24)]
			public FVector __Result;
		}
	}
}
