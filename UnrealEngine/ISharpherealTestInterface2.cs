using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007EC RID: 2028
	[UnrealObjectPath("/Script/SharpherealTest.SharpherealTestInterface2")]
	public interface ISharpherealTestInterface2 : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0600ADA7 RID: 44455
		int InterfaceOffset();

		// Token: 0x0600ADA8 RID: 44456 RVA: 0x0010102C File Offset: 0x000FF22C
		[SkipLocalsInit]
		unsafe int Get2()
		{
			ISharpherealTestInterface2.__Get2_FunctionParams* ptr = stackalloc ISharpherealTestInterface2.__Get2_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(ISharpherealTestInterface2.__Get2_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(ISharpherealTestInterface2_ReflectionImplementationFields.__Get2_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(this.NativePtr, ISharpherealTestInterface2_ReflectionImplementationFields.__Get2_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x04004AEA RID: 19178
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SharpherealTest.SharpherealTestInterface2";

		// Token: 0x02000F99 RID: 3993
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Get2_FunctionParams
		{
			// Token: 0x0400639D RID: 25501
			[FieldOffset(0)]
			public int __Result;
		}
	}
}
