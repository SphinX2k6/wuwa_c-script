using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002737 RID: 10039
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestInterface2")]
	public interface ISharpherealTestInterface2 : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x060252B7 RID: 152247
		int InterfaceOffset();

		// Token: 0x060252B8 RID: 152248 RVA: 0x00371048 File Offset: 0x0036F248
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		unsafe int Get2()
		{
			ISharpherealTestInterface2.__Get2_FunctionParams* ptr = stackalloc ISharpherealTestInterface2.__Get2_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISharpherealTestInterface2.__Get2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface2_ReflectionImplementationFields.__Get2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface2_ReflectionImplementationFields.__Get2_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x04014087 RID: 82055
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestInterface2";

		// Token: 0x020036C7 RID: 14023
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get2_FunctionParams
		{
			// Token: 0x040177EA RID: 96234
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
