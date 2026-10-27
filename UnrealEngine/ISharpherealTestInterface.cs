using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002736 RID: 10038
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestInterface")]
	public interface ISharpherealTestInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060252B3 RID: 152243
		int InterfaceOffset();

		// Token: 0x060252B4 RID: 152244 RVA: 0x00370F10 File Offset: 0x0036F110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int Get1()
		{
			ISharpherealTestInterface.__Get1_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Get1_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISharpherealTestInterface.__Get1_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Get1_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Get1_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x060252B5 RID: 152245 RVA: 0x00370F58 File Offset: 0x0036F158
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe bool Cast(UObject Src, ref ISharpherealTestInterface Out)
		{
			ISharpherealTestInterface.__Cast_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Cast_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(ISharpherealTestInterface.__Cast_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Cast_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Src = ((Src != null) ? Src.NativePtr : IntPtr.Zero);
			ref ISharpherealTestInterface.__Cast_FunctionParams ptr2 = ref *ptr;
			IUnrealNativeInterface @object = Out;
			ISharpherealTestInterface sharpherealTestInterface = Out;
			ptr2.Out = new FScriptInterface(@object, (sharpherealTestInterface != null) ? sharpherealTestInterface.InterfaceOffset() : 0);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Cast_NativeFunctionPtr, (void*)ptr, 0);
			Out = (BuiltinUtils.GetOrCreateUObjectByNativePointer(ptr->Out.ObjectPointer) as ISharpherealTestInterface);
			return ptr->__Result;
		}

		// Token: 0x060252B6 RID: 152246 RVA: 0x00370FE8 File Offset: 0x0036F1E8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe FVector Add(in FVector A, in FVector B)
		{
			ISharpherealTestInterface.__Add_FunctionParams* ptr = stackalloc ISharpherealTestInterface.__Add_FunctionParams[(UIntPtr)51] + 15L / (long)sizeof(ISharpherealTestInterface.__Add_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface_ReflectionImplementationFields.__Add_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface_ReflectionImplementationFields.__Add_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04014086 RID: 82054
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestInterface";

		// Token: 0x020036C4 RID: 14020
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get1_FunctionParams
		{
			// Token: 0x040177E3 RID: 96227
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020036C5 RID: 14021
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Cast_FunctionParams
		{
			// Token: 0x040177E4 RID: 96228
			[FieldOffset(0)]
			public IntPtr Src;

			// Token: 0x040177E5 RID: 96229
			[FieldOffset(8)]
			public FScriptInterface Out;

			// Token: 0x040177E6 RID: 96230
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x020036C6 RID: 14022
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 36)]
		protected ref struct __Add_FunctionParams
		{
			// Token: 0x040177E7 RID: 96231
			[FieldOffset(0)]
			public FVector A;

			// Token: 0x040177E8 RID: 96232
			[FieldOffset(12)]
			public FVector B;

			// Token: 0x040177E9 RID: 96233
			[FieldOffset(24)]
			public FVector __Result;
		}
	}
}
