using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000317 RID: 791
	[UnrealObjectPath("/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroAutomationBlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060053C1 RID: 21441 RVA: 0x000750FE File Offset: 0x000732FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAutomationBlueprintLibrary._ClassPtr;
		}

		// Token: 0x060053C2 RID: 21442 RVA: 0x0007510C File Offset: 0x0007330C
		public UKuroAutomationBlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationBlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060053C3 RID: 21443 RVA: 0x00075134 File Offset: 0x00073334
		[NullableContext(1)]
		public UKuroAutomationBlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAutomationBlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060053C4 RID: 21444 RVA: 0x00075168 File Offset: 0x00073368
		[SkipLocalsInit]
		public unsafe static void DefaultValueTest(bool bExpected, bool bDefault = true)
		{
			UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams* ptr = stackalloc UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroAutomationBlueprintLibrary.__DefaultValueTest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroAutomationBlueprintLibrary.__DefaultValueTest_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bExpected = bExpected;
			ptr->bDefault = bDefault;
			UnrealReflectionUtils.CallUFunction(UKuroAutomationBlueprintLibrary._ClassDefaultObjectPtr, UKuroAutomationBlueprintLibrary.__DefaultValueTest_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060053C5 RID: 21445 RVA: 0x000751B4 File Offset: 0x000733B4
		[SkipLocalsInit]
		public static void CallMemoryOverrun()
		{
			UnrealReflectionUtils.CallUFunction(UKuroAutomationBlueprintLibrary._ClassDefaultObjectPtr, UKuroAutomationBlueprintLibrary.__CallMemoryOverrun_NativeFunctionPtr, null);
		}

		// Token: 0x060053C6 RID: 21446 RVA: 0x000751C7 File Offset: 0x000733C7
		static UKuroAutomationBlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary");
		}

		// Token: 0x060053C7 RID: 21447 RVA: 0x000751D5 File Offset: 0x000733D5
		protected UKuroAutomationBlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002235 RID: 8757
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAutomationTool.KuroAutomationBlueprintLibrary";

		// Token: 0x04002236 RID: 8758
		private static IntPtr _ClassPtr;

		// Token: 0x04002237 RID: 8759
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002238 RID: 8760
		private static IntPtr __DefaultValueTest_NativeFunctionPtr;

		// Token: 0x04002239 RID: 8761
		private static IntPtr __CallMemoryOverrun_NativeFunctionPtr;

		// Token: 0x02000A19 RID: 2585
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __DefaultValueTest_FunctionParams
		{
			// Token: 0x040059D9 RID: 23001
			[FieldOffset(0)]
			public bool bExpected;

			// Token: 0x040059DA RID: 23002
			[FieldOffset(1)]
			public bool bDefault;
		}
	}
}
