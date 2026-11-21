using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005CC RID: 1484
	[UnrealObjectPath("/Script/KuroUtility.KuroApplicationLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroApplicationLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060083D9 RID: 33753 RVA: 0x000C38DC File Offset: 0x000C1ADC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroApplicationLibrary._ClassPtr;
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x000C38E8 File Offset: 0x000C1AE8
		public UKuroApplicationLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroApplicationLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x000C3910 File Offset: 0x000C1B10
		[NullableContext(1)]
		public UKuroApplicationLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroApplicationLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060083DC RID: 33756 RVA: 0x000C3944 File Offset: 0x000C1B44
		[SkipLocalsInit]
		public unsafe static bool UnBind()
		{
			UKuroApplicationLibrary.__UnBind_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__UnBind_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__UnBind_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__UnBind_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__UnBind_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x000C3988 File Offset: 0x000C1B88
		[SkipLocalsInit]
		public unsafe static bool Test(int Type)
		{
			UKuroApplicationLibrary.__Test_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__Test_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroApplicationLibrary.__Test_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__Test_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Type = Type;
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__Test_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x000C39D4 File Offset: 0x000C1BD4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string ProjectContentDir()
		{
			UKuroApplicationLibrary.__ProjectContentDir_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ProjectContentDir_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__ProjectContentDir_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x000C3A30 File Offset: 0x000C1C30
		[SkipLocalsInit]
		public unsafe static bool IsWithStat()
		{
			UKuroApplicationLibrary.__IsWithStat_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsWithStat_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsWithStat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsWithStat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsWithStat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x000C3A74 File Offset: 0x000C1C74
		[SkipLocalsInit]
		public unsafe static bool IsWithEditor()
		{
			UKuroApplicationLibrary.__IsWithEditor_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsWithEditor_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsWithEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsWithEditor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsWithEditor_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083E1 RID: 33761 RVA: 0x000C3AB8 File Offset: 0x000C1CB8
		[SkipLocalsInit]
		public unsafe static bool IsBuildTest()
		{
			UKuroApplicationLibrary.__IsBuildTest_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsBuildTest_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsBuildTest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsBuildTest_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsBuildTest_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083E2 RID: 33762 RVA: 0x000C3AFC File Offset: 0x000C1CFC
		[SkipLocalsInit]
		public unsafe static bool IsBuildShipping()
		{
			UKuroApplicationLibrary.__IsBuildShipping_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsBuildShipping_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsBuildShipping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsBuildShipping_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsBuildShipping_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083E3 RID: 33763 RVA: 0x000C3B40 File Offset: 0x000C1D40
		[SkipLocalsInit]
		public unsafe static bool IsAsyncLoadingThreadEnabled()
		{
			UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060083E4 RID: 33764 RVA: 0x000C3B84 File Offset: 0x000C1D84
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string IniPlatformNameIncludeEditor()
		{
			UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083E5 RID: 33765 RVA: 0x000C3BE0 File Offset: 0x000C1DE0
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string IniPlatformName()
		{
			UKuroApplicationLibrary.__IniPlatformName_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IniPlatformName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__IniPlatformName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083E6 RID: 33766 RVA: 0x000C3C3C File Offset: 0x000C1E3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetSessionCachedUserName()
		{
			UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083E7 RID: 33767 RVA: 0x000C3C98 File Offset: 0x000C1E98
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetCommandLine()
		{
			UKuroApplicationLibrary.__GetCommandLine_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetCommandLine_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetCommandLine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083E8 RID: 33768 RVA: 0x000C3CF4 File Offset: 0x000C1EF4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static string GetAppReleaseType()
		{
			UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x060083E9 RID: 33769 RVA: 0x000C3D50 File Offset: 0x000C1F50
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void ExitWithReason(bool bForceExit, string Reason)
		{
			UKuroApplicationLibrary.__ExitWithReason_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ExitWithReason_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroApplicationLibrary.__ExitWithReason_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForceExit = bForceExit;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060083EA RID: 33770 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void ExitWithCode(bool bForceExit, string Reason, int ExitCode)
		{
			UKuroApplicationLibrary.__ExitWithCode_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ExitWithCode_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroApplicationLibrary.__ExitWithCode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForceExit = bForceExit;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			ptr->ExitCode = ExitCode;
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x060083EB RID: 33771 RVA: 0x000C3E20 File Offset: 0x000C2020
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool AddWindowActivationDelegate(in FWindowActivation InDelegate)
		{
			UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FWindowActivation fwindowActivation = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fwindowActivation != null) ? fwindowActivation.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060083EC RID: 33772 RVA: 0x000C3E90 File Offset: 0x000C2090
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool AddEditorPreEndPIEDelegate(in FOnEditorPreEndPIE InDelegate)
		{
			UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FOnEditorPreEndPIE fonEditorPreEndPIE = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fonEditorPreEndPIE != null) ? fonEditorPreEndPIE.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060083ED RID: 33773 RVA: 0x000C3F00 File Offset: 0x000C2100
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool AddApplicationLifetimeDelegate(in FOnApplicationLifeTime InDelegate)
		{
			UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FOnApplicationLifeTime fonApplicationLifeTime = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fonApplicationLifeTime != null) ? fonApplicationLifeTime.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x060083EE RID: 33774 RVA: 0x000C3F70 File Offset: 0x000C2170
		static UKuroApplicationLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroApplicationLibrary");
		}

		// Token: 0x060083EF RID: 33775 RVA: 0x000C3F7E File Offset: 0x000C217E
		protected UKuroApplicationLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003999 RID: 14745
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroApplicationLibrary";

		// Token: 0x0400399A RID: 14746
		private static IntPtr _ClassPtr;

		// Token: 0x0400399B RID: 14747
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400399C RID: 14748
		private static IntPtr __UnBind_NativeFunctionPtr;

		// Token: 0x0400399D RID: 14749
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x0400399E RID: 14750
		private static IntPtr __ProjectContentDir_NativeFunctionPtr;

		// Token: 0x0400399F RID: 14751
		private static IntPtr __IsWithStat_NativeFunctionPtr;

		// Token: 0x040039A0 RID: 14752
		private static IntPtr __IsWithEditor_NativeFunctionPtr;

		// Token: 0x040039A1 RID: 14753
		private static IntPtr __IsBuildTest_NativeFunctionPtr;

		// Token: 0x040039A2 RID: 14754
		private static IntPtr __IsBuildShipping_NativeFunctionPtr;

		// Token: 0x040039A3 RID: 14755
		private static IntPtr __IsAsyncLoadingThreadEnabled_NativeFunctionPtr;

		// Token: 0x040039A4 RID: 14756
		private static IntPtr __IniPlatformNameIncludeEditor_NativeFunctionPtr;

		// Token: 0x040039A5 RID: 14757
		private static IntPtr __IniPlatformName_NativeFunctionPtr;

		// Token: 0x040039A6 RID: 14758
		private static IntPtr __GetSessionCachedUserName_NativeFunctionPtr;

		// Token: 0x040039A7 RID: 14759
		private static IntPtr __GetCommandLine_NativeFunctionPtr;

		// Token: 0x040039A8 RID: 14760
		private static IntPtr __GetAppReleaseType_NativeFunctionPtr;

		// Token: 0x040039A9 RID: 14761
		private static IntPtr __ExitWithReason_NativeFunctionPtr;

		// Token: 0x040039AA RID: 14762
		private static IntPtr __ExitWithCode_NativeFunctionPtr;

		// Token: 0x040039AB RID: 14763
		private static IntPtr __AddWindowActivationDelegate_NativeFunctionPtr;

		// Token: 0x040039AC RID: 14764
		private static IntPtr __AddEditorPreEndPIEDelegate_NativeFunctionPtr;

		// Token: 0x040039AD RID: 14765
		private static IntPtr __AddApplicationLifetimeDelegate_NativeFunctionPtr;

		// Token: 0x02000D57 RID: 3415
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UnBind_FunctionParams
		{
			// Token: 0x0400600B RID: 24587
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D58 RID: 3416
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Test_FunctionParams
		{
			// Token: 0x0400600C RID: 24588
			[FieldOffset(0)]
			public int Type;

			// Token: 0x0400600D RID: 24589
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02000D59 RID: 3417
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ProjectContentDir_FunctionParams
		{
			// Token: 0x0400600E RID: 24590
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D5A RID: 3418
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsWithStat_FunctionParams
		{
			// Token: 0x0400600F RID: 24591
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D5B RID: 3419
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsWithEditor_FunctionParams
		{
			// Token: 0x04006010 RID: 24592
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D5C RID: 3420
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsBuildTest_FunctionParams
		{
			// Token: 0x04006011 RID: 24593
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D5D RID: 3421
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsBuildShipping_FunctionParams
		{
			// Token: 0x04006012 RID: 24594
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D5E RID: 3422
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsAsyncLoadingThreadEnabled_FunctionParams
		{
			// Token: 0x04006013 RID: 24595
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000D5F RID: 3423
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IniPlatformNameIncludeEditor_FunctionParams
		{
			// Token: 0x04006014 RID: 24596
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D60 RID: 3424
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IniPlatformName_FunctionParams
		{
			// Token: 0x04006015 RID: 24597
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D61 RID: 3425
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSessionCachedUserName_FunctionParams
		{
			// Token: 0x04006016 RID: 24598
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D62 RID: 3426
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCommandLine_FunctionParams
		{
			// Token: 0x04006017 RID: 24599
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D63 RID: 3427
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAppReleaseType_FunctionParams
		{
			// Token: 0x04006018 RID: 24600
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02000D64 RID: 3428
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ExitWithReason_FunctionParams
		{
			// Token: 0x04006019 RID: 24601
			[FieldOffset(0)]
			public bool bForceExit;

			// Token: 0x0400601A RID: 24602
			[FieldOffset(8)]
			public FString Reason;
		}

		// Token: 0x02000D65 RID: 3429
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ExitWithCode_FunctionParams
		{
			// Token: 0x0400601B RID: 24603
			[FieldOffset(0)]
			public bool bForceExit;

			// Token: 0x0400601C RID: 24604
			[FieldOffset(8)]
			public FString Reason;

			// Token: 0x0400601D RID: 24605
			[FieldOffset(24)]
			public int ExitCode;
		}

		// Token: 0x02000D66 RID: 3430
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddWindowActivationDelegate_FunctionParams
		{
			// Token: 0x0400601E RID: 24606
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x0400601F RID: 24607
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000D67 RID: 3431
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddEditorPreEndPIEDelegate_FunctionParams
		{
			// Token: 0x04006020 RID: 24608
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x04006021 RID: 24609
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02000D68 RID: 3432
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddApplicationLifetimeDelegate_FunctionParams
		{
			// Token: 0x04006022 RID: 24610
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x04006023 RID: 24611
			[FieldOffset(40)]
			public bool __Result;
		}
	}
}
