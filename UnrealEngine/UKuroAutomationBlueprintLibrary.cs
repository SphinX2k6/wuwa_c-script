using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020016A2 RID: 5794
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAutomationBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601501F RID: 86047 RVA: 0x001EDF2E File Offset: 0x001EC12E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAutomationBlueprintLibrary._ClassPtr;
		}

		// Token: 0x06015020 RID: 86048 RVA: 0x001EDF3C File Offset: 0x001EC13C
		public UKuroAutomationBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015021 RID: 86049 RVA: 0x001EDF64 File Offset: 0x001EC164
		[NullableContext(1)]
		public UKuroAutomationBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06015022 RID: 86050 RVA: 0x001EDF98 File Offset: 0x001EC198
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void DefaultValueTest(bool bExpected, bool bDefault = true)
		{
			UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams* ptr = stackalloc UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAutomationBlueprintLibrary.__DefaultValueTest_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bExpected = bExpected;
			ptr->bDefault = bDefault;
			UnrealReflectionUtils.CallUFunction(UKuroAutomationBlueprintLibrary._ClassDefaultObjectPtr, UKuroAutomationBlueprintLibrary.__DefaultValueTest_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x06015023 RID: 86051 RVA: 0x001EDFE5 File Offset: 0x001EC1E5
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static void CallMemoryOverrun()
		{
			UnrealReflectionUtils.CallUFunction(UKuroAutomationBlueprintLibrary._ClassDefaultObjectPtr, UKuroAutomationBlueprintLibrary.__CallMemoryOverrun_NativeFunctionPtr, null, 0);
		}

		// Token: 0x06015024 RID: 86052 RVA: 0x001EDFF9 File Offset: 0x001EC1F9
		static UKuroAutomationBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary");
		}

		// Token: 0x06015025 RID: 86053 RVA: 0x001EE007 File Offset: 0x001EC207
		protected UKuroAutomationBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B705 RID: 46853
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary";

		// Token: 0x0400B706 RID: 46854
		private static IntPtr _ClassPtr;

		// Token: 0x0400B707 RID: 46855
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B708 RID: 46856
		private static IntPtr __DefaultValueTest_NativeFunctionPtr;

		// Token: 0x0400B709 RID: 46857
		private static IntPtr __CallMemoryOverrun_NativeFunctionPtr;

		// Token: 0x02002EE0 RID: 12000
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __DefaultValueTest_FunctionParams
		{
			// Token: 0x040169FE RID: 92670
			[FieldOffset(0)]
			public bool bExpected;

			// Token: 0x040169FF RID: 92671
			[FieldOffset(1)]
			public bool bDefault;
		}
	}
}
