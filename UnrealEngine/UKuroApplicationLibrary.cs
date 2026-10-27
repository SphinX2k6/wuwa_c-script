using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EAC RID: 7852
	[UnrealObjectPath("/Script/KuroUtility.KuroApplicationLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroApplicationLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DCFE RID: 122110 RVA: 0x002C1542 File Offset: 0x002BF742
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroApplicationLibrary._ClassPtr;
		}

		// Token: 0x0601DCFF RID: 122111 RVA: 0x002C1550 File Offset: 0x002BF750
		public UKuroApplicationLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroApplicationLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD00 RID: 122112 RVA: 0x002C1578 File Offset: 0x002BF778
		[NullableContext(1)]
		public UKuroApplicationLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroApplicationLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD01 RID: 122113 RVA: 0x002C15AC File Offset: 0x002BF7AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool UnBind()
		{
			UKuroApplicationLibrary.__UnBind_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__UnBind_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__UnBind_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__UnBind_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__UnBind_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD02 RID: 122114 RVA: 0x002C15F4 File Offset: 0x002BF7F4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool Test(int Type)
		{
			UKuroApplicationLibrary.__Test_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__Test_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroApplicationLibrary.__Test_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__Test_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Type = Type;
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__Test_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD03 RID: 122115 RVA: 0x002C1640 File Offset: 0x002BF840
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string ProjectContentDir()
		{
			UKuroApplicationLibrary.__ProjectContentDir_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ProjectContentDir_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__ProjectContentDir_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ProjectContentDir_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD04 RID: 122116 RVA: 0x002C169C File Offset: 0x002BF89C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsWithStat()
		{
			UKuroApplicationLibrary.__IsWithStat_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsWithStat_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsWithStat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsWithStat_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsWithStat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD05 RID: 122117 RVA: 0x002C16E4 File Offset: 0x002BF8E4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsWithEditor()
		{
			UKuroApplicationLibrary.__IsWithEditor_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsWithEditor_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsWithEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsWithEditor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsWithEditor_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD06 RID: 122118 RVA: 0x002C172C File Offset: 0x002BF92C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsBuildTest()
		{
			UKuroApplicationLibrary.__IsBuildTest_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsBuildTest_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsBuildTest_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsBuildTest_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsBuildTest_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD07 RID: 122119 RVA: 0x002C1774 File Offset: 0x002BF974
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsBuildShipping()
		{
			UKuroApplicationLibrary.__IsBuildShipping_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsBuildShipping_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsBuildShipping_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsBuildShipping_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsBuildShipping_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD08 RID: 122120 RVA: 0x002C17BC File Offset: 0x002BF9BC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool IsAsyncLoadingThreadEnabled()
		{
			UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IsAsyncLoadingThreadEnabled_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601DD09 RID: 122121 RVA: 0x002C1804 File Offset: 0x002BFA04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string IniPlatformNameIncludeEditor()
		{
			UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__IniPlatformNameIncludeEditor_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD0A RID: 122122 RVA: 0x002C1860 File Offset: 0x002BFA60
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string IniPlatformName()
		{
			UKuroApplicationLibrary.__IniPlatformName_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__IniPlatformName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__IniPlatformName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__IniPlatformName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD0B RID: 122123 RVA: 0x002C18BC File Offset: 0x002BFABC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetSessionCachedUserName()
		{
			UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetSessionCachedUserName_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetSessionCachedUserName_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD0C RID: 122124 RVA: 0x002C1918 File Offset: 0x002BFB18
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetCommandLine()
		{
			UKuroApplicationLibrary.__GetCommandLine_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetCommandLine_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetCommandLine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetCommandLine_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD0D RID: 122125 RVA: 0x002C1974 File Offset: 0x002BFB74
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static string GetAppReleaseType()
		{
			UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroApplicationLibrary.__GetAppReleaseType_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr, 0);
			string result = FString.ToString((void*)(&ptr->__Result));
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__GetAppReleaseType_NativeFunctionPtr, (void*)ptr, 1);
			return result;
		}

		// Token: 0x0601DD0E RID: 122126 RVA: 0x002C19D0 File Offset: 0x002BFBD0
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ExitWithReason(bool bForceExit, string Reason)
		{
			UKuroApplicationLibrary.__ExitWithReason_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ExitWithReason_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKuroApplicationLibrary.__ExitWithReason_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForceExit = bForceExit;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ExitWithReason_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD0F RID: 122127 RVA: 0x002C1A34 File Offset: 0x002BFC34
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void ExitWithCode(bool bForceExit, string Reason, int ExitCode)
		{
			UKuroApplicationLibrary.__ExitWithCode_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__ExitWithCode_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UKuroApplicationLibrary.__ExitWithCode_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bForceExit = bForceExit;
			FString.CopyFrom((void*)(&ptr->Reason), Reason);
			ptr->ExitCode = ExitCode;
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__ExitWithCode_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601DD10 RID: 122128 RVA: 0x002C1AA0 File Offset: 0x002BFCA0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool AddWindowActivationDelegate(in FWindowActivation InDelegate)
		{
			UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddWindowActivationDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FWindowActivation fwindowActivation = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fwindowActivation != null) ? fwindowActivation.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddWindowActivationDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DD11 RID: 122129 RVA: 0x002C1B14 File Offset: 0x002BFD14
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool AddEditorPreEndPIEDelegate(in FOnEditorPreEndPIE InDelegate)
		{
			UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FOnEditorPreEndPIE fonEditorPreEndPIE = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fonEditorPreEndPIE != null) ? fonEditorPreEndPIE.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddEditorPreEndPIEDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DD12 RID: 122130 RVA: 0x002C1B88 File Offset: 0x002BFD88
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool AddApplicationLifetimeDelegate(in FOnApplicationLifeTime InDelegate)
		{
			UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams* ptr = stackalloc UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			IntPtr dest = &ptr->InDelegate;
			FOnApplicationLifeTime fonApplicationLifeTime = InDelegate;
			FScriptDelegate.NativeCopy(dest, (fonApplicationLifeTime != null) ? fonApplicationLifeTime.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UKuroApplicationLibrary._ClassDefaultObjectPtr, UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroApplicationLibrary.__AddApplicationLifetimeDelegate_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601DD13 RID: 122131 RVA: 0x002C1BF9 File Offset: 0x002BFDF9
		static UKuroApplicationLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroApplicationLibrary");
		}

		// Token: 0x0601DD14 RID: 122132 RVA: 0x002C1C07 File Offset: 0x002BFE07
		protected UKuroApplicationLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401027A RID: 66170
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroApplicationLibrary";

		// Token: 0x0401027B RID: 66171
		private static IntPtr _ClassPtr;

		// Token: 0x0401027C RID: 66172
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401027D RID: 66173
		private static IntPtr __UnBind_NativeFunctionPtr;

		// Token: 0x0401027E RID: 66174
		private static IntPtr __Test_NativeFunctionPtr;

		// Token: 0x0401027F RID: 66175
		private static IntPtr __ProjectContentDir_NativeFunctionPtr;

		// Token: 0x04010280 RID: 66176
		private static IntPtr __IsWithStat_NativeFunctionPtr;

		// Token: 0x04010281 RID: 66177
		private static IntPtr __IsWithEditor_NativeFunctionPtr;

		// Token: 0x04010282 RID: 66178
		private static IntPtr __IsBuildTest_NativeFunctionPtr;

		// Token: 0x04010283 RID: 66179
		private static IntPtr __IsBuildShipping_NativeFunctionPtr;

		// Token: 0x04010284 RID: 66180
		private static IntPtr __IsAsyncLoadingThreadEnabled_NativeFunctionPtr;

		// Token: 0x04010285 RID: 66181
		private static IntPtr __IniPlatformNameIncludeEditor_NativeFunctionPtr;

		// Token: 0x04010286 RID: 66182
		private static IntPtr __IniPlatformName_NativeFunctionPtr;

		// Token: 0x04010287 RID: 66183
		private static IntPtr __GetSessionCachedUserName_NativeFunctionPtr;

		// Token: 0x04010288 RID: 66184
		private static IntPtr __GetCommandLine_NativeFunctionPtr;

		// Token: 0x04010289 RID: 66185
		private static IntPtr __GetAppReleaseType_NativeFunctionPtr;

		// Token: 0x0401028A RID: 66186
		private static IntPtr __ExitWithReason_NativeFunctionPtr;

		// Token: 0x0401028B RID: 66187
		private static IntPtr __ExitWithCode_NativeFunctionPtr;

		// Token: 0x0401028C RID: 66188
		private static IntPtr __AddWindowActivationDelegate_NativeFunctionPtr;

		// Token: 0x0401028D RID: 66189
		private static IntPtr __AddEditorPreEndPIEDelegate_NativeFunctionPtr;

		// Token: 0x0401028E RID: 66190
		private static IntPtr __AddApplicationLifetimeDelegate_NativeFunctionPtr;

		// Token: 0x020032FF RID: 13055
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __UnBind_FunctionParams
		{
			// Token: 0x040171C7 RID: 94663
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003300 RID: 13056
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __Test_FunctionParams
		{
			// Token: 0x040171C8 RID: 94664
			[FieldOffset(0)]
			public int Type;

			// Token: 0x040171C9 RID: 94665
			[FieldOffset(4)]
			public bool __Result;
		}

		// Token: 0x02003301 RID: 13057
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __ProjectContentDir_FunctionParams
		{
			// Token: 0x040171CA RID: 94666
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003302 RID: 13058
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsWithStat_FunctionParams
		{
			// Token: 0x040171CB RID: 94667
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003303 RID: 13059
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsWithEditor_FunctionParams
		{
			// Token: 0x040171CC RID: 94668
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003304 RID: 13060
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsBuildTest_FunctionParams
		{
			// Token: 0x040171CD RID: 94669
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003305 RID: 13061
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsBuildShipping_FunctionParams
		{
			// Token: 0x040171CE RID: 94670
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003306 RID: 13062
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsAsyncLoadingThreadEnabled_FunctionParams
		{
			// Token: 0x040171CF RID: 94671
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02003307 RID: 13063
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IniPlatformNameIncludeEditor_FunctionParams
		{
			// Token: 0x040171D0 RID: 94672
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003308 RID: 13064
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __IniPlatformName_FunctionParams
		{
			// Token: 0x040171D1 RID: 94673
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x02003309 RID: 13065
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetSessionCachedUserName_FunctionParams
		{
			// Token: 0x040171D2 RID: 94674
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200330A RID: 13066
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetCommandLine_FunctionParams
		{
			// Token: 0x040171D3 RID: 94675
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200330B RID: 13067
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAppReleaseType_FunctionParams
		{
			// Token: 0x040171D4 RID: 94676
			[FieldOffset(0)]
			public FString __Result;
		}

		// Token: 0x0200330C RID: 13068
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __ExitWithReason_FunctionParams
		{
			// Token: 0x040171D5 RID: 94677
			[FieldOffset(0)]
			public bool bForceExit;

			// Token: 0x040171D6 RID: 94678
			[FieldOffset(8)]
			public FString Reason;
		}

		// Token: 0x0200330D RID: 13069
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __ExitWithCode_FunctionParams
		{
			// Token: 0x040171D7 RID: 94679
			[FieldOffset(0)]
			public bool bForceExit;

			// Token: 0x040171D8 RID: 94680
			[FieldOffset(8)]
			public FString Reason;

			// Token: 0x040171D9 RID: 94681
			[FieldOffset(24)]
			public int ExitCode;
		}

		// Token: 0x0200330E RID: 13070
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddWindowActivationDelegate_FunctionParams
		{
			// Token: 0x040171DA RID: 94682
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x040171DB RID: 94683
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x0200330F RID: 13071
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddEditorPreEndPIEDelegate_FunctionParams
		{
			// Token: 0x040171DC RID: 94684
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x040171DD RID: 94685
			[FieldOffset(40)]
			public bool __Result;
		}

		// Token: 0x02003310 RID: 13072
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __AddApplicationLifetimeDelegate_FunctionParams
		{
			// Token: 0x040171DE RID: 94686
			[FieldOffset(0)]
			public byte InDelegate;

			// Token: 0x040171DF RID: 94687
			[FieldOffset(40)]
			public bool __Result;
		}
	}
}
