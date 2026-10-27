using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002754 RID: 10068
	[UnrealObjectPath("/Script/Sharphereal.ConsoleCommandBPL")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UConsoleCommandBPL : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025A30 RID: 154160 RVA: 0x003904CE File Offset: 0x0038E6CE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConsoleCommandBPL._ClassPtr;
		}

		// Token: 0x06025A31 RID: 154161 RVA: 0x003904DC File Offset: 0x0038E6DC
		public UConsoleCommandBPL() : this(BuiltinUtils.AllocNativeUObject(UConsoleCommandBPL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025A32 RID: 154162 RVA: 0x00390504 File Offset: 0x0038E704
		[NullableContext(1)]
		public UConsoleCommandBPL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConsoleCommandBPL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025A33 RID: 154163 RVA: 0x00390538 File Offset: 0x0038E738
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UnregisterConsoleObject(string Name)
		{
			UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A34 RID: 154164 RVA: 0x00390598 File Offset: 0x0038E798
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetConsoleStringVariable(string Name, string Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A35 RID: 154165 RVA: 0x00390610 File Offset: 0x0038E810
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetConsoleIntVariable(string Name, int Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A36 RID: 154166 RVA: 0x00390684 File Offset: 0x0038E884
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetConsoleFloatVariable(string Name, float Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A37 RID: 154167 RVA: 0x003906F8 File Offset: 0x0038E8F8
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool SetConsoleBoolVariable(string Name, bool Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 0);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A38 RID: 154168 RVA: 0x0039076C File Offset: 0x0038E96C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleStringVariable(string Name, string DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->DefaultValue), DefaultValue);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A39 RID: 154169 RVA: 0x003907EC File Offset: 0x0038E9EC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleIntVariable(string Name, int DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3A RID: 154170 RVA: 0x00390864 File Offset: 0x0038EA64
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleFloatVariable(string Name, float DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3B RID: 154171 RVA: 0x003908DC File Offset: 0x0038EADC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleCommandWithWorldAndArgs(string Name, string Help, [Nullable(2)] in FSharpherealConsoleCommandWithWorldAndArgsDelegate Command, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			IntPtr dest = &ptr->Command;
			FSharpherealConsoleCommandWithWorldAndArgsDelegate fsharpherealConsoleCommandWithWorldAndArgsDelegate = Command;
			FScriptDelegate.NativeCopy(dest, (fsharpherealConsoleCommandWithWorldAndArgsDelegate != null) ? fsharpherealConsoleCommandWithWorldAndArgsDelegate.NativePtr : ((IntPtr)0));
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3C RID: 154172 RVA: 0x00390968 File Offset: 0x0038EB68
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleCommandWithWorld(string Name, string Help, [Nullable(2)] in FSharpherealConsoleCommandWithWorldDelegate Command, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			IntPtr dest = &ptr->Command;
			FSharpherealConsoleCommandWithWorldDelegate fsharpherealConsoleCommandWithWorldDelegate = Command;
			FScriptDelegate.NativeCopy(dest, (fsharpherealConsoleCommandWithWorldDelegate != null) ? fsharpherealConsoleCommandWithWorldDelegate.NativePtr : ((IntPtr)0));
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3D RID: 154173 RVA: 0x003909F4 File Offset: 0x0038EBF4
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleCommandWithArgs(string Name, string Help, [Nullable(2)] in FSharpherealConsoleCommandWithArgsDelegate Command, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			IntPtr dest = &ptr->Command;
			FSharpherealConsoleCommandWithArgsDelegate fsharpherealConsoleCommandWithArgsDelegate = Command;
			FScriptDelegate.NativeCopy(dest, (fsharpherealConsoleCommandWithArgsDelegate != null) ? fsharpherealConsoleCommandWithArgsDelegate.NativePtr : ((IntPtr)0));
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3E RID: 154174 RVA: 0x00390A80 File Offset: 0x0038EC80
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleCommand(string Name, string Help, [Nullable(2)] in FSharpherealConsoleCommandDelegate Command, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleCommand_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleCommand_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleCommand_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleCommand_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			IntPtr dest = &ptr->Command;
			FSharpherealConsoleCommandDelegate fsharpherealConsoleCommandDelegate = Command;
			FScriptDelegate.NativeCopy(dest, (fsharpherealConsoleCommandDelegate != null) ? fsharpherealConsoleCommandDelegate.NativePtr : ((IntPtr)0));
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommand_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommand_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A3F RID: 154175 RVA: 0x00390B0C File Offset: 0x0038ED0C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void RegisterConsoleBoolVariable(string Name, bool DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025A40 RID: 154176 RVA: 0x00390B84 File Offset: 0x0038ED84
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetConsoleStringVariable(string Name, ref string Result)
		{
			UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 0);
			Result = FString.ToString((void*)(&ptr->Result));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A41 RID: 154177 RVA: 0x00390C04 File Offset: 0x0038EE04
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetConsoleIntVariable(string Name, ref int Result)
		{
			UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 0);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A42 RID: 154178 RVA: 0x00390C78 File Offset: 0x0038EE78
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetConsoleFloatVariable(string Name, ref float Result)
		{
			UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 0);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A43 RID: 154179 RVA: 0x00390CEC File Offset: 0x0038EEEC
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetConsoleBoolVariable(string Name, ref bool Result)
		{
			UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 0);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025A44 RID: 154180 RVA: 0x00390D5F File Offset: 0x0038EF5F
		static UConsoleCommandBPL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.ConsoleCommandBPL");
		}

		// Token: 0x06025A45 RID: 154181 RVA: 0x00390D6D File Offset: 0x0038EF6D
		protected UConsoleCommandBPL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401472B RID: 83755
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.ConsoleCommandBPL";

		// Token: 0x0401472C RID: 83756
		private static IntPtr _ClassPtr;

		// Token: 0x0401472D RID: 83757
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401472E RID: 83758
		private static IntPtr __UnregisterConsoleObject_NativeFunctionPtr;

		// Token: 0x0401472F RID: 83759
		private static IntPtr __SetConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x04014730 RID: 83760
		private static IntPtr __SetConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x04014731 RID: 83761
		private static IntPtr __SetConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x04014732 RID: 83762
		private static IntPtr __SetConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x04014733 RID: 83763
		private static IntPtr __RegisterConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x04014734 RID: 83764
		private static IntPtr __RegisterConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x04014735 RID: 83765
		private static IntPtr __RegisterConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x04014736 RID: 83766
		private static IntPtr __RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr;

		// Token: 0x04014737 RID: 83767
		private static IntPtr __RegisterConsoleCommandWithWorld_NativeFunctionPtr;

		// Token: 0x04014738 RID: 83768
		private static IntPtr __RegisterConsoleCommandWithArgs_NativeFunctionPtr;

		// Token: 0x04014739 RID: 83769
		private static IntPtr __RegisterConsoleCommand_NativeFunctionPtr;

		// Token: 0x0401473A RID: 83770
		private static IntPtr __RegisterConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x0401473B RID: 83771
		private static IntPtr __GetConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x0401473C RID: 83772
		private static IntPtr __GetConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x0401473D RID: 83773
		private static IntPtr __GetConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x0401473E RID: 83774
		private static IntPtr __GetConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x02003A47 RID: 14919
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnregisterConsoleObject_FunctionParams
		{
			// Token: 0x04017B72 RID: 97138
			[FieldOffset(0)]
			public FString Name;
		}

		// Token: 0x02003A48 RID: 14920
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetConsoleStringVariable_FunctionParams
		{
			// Token: 0x04017B73 RID: 97139
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B74 RID: 97140
			[FieldOffset(16)]
			public FString Value;

			// Token: 0x04017B75 RID: 97141
			[FieldOffset(32)]
			public uint Flags;

			// Token: 0x04017B76 RID: 97142
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x02003A49 RID: 14921
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleIntVariable_FunctionParams
		{
			// Token: 0x04017B77 RID: 97143
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B78 RID: 97144
			[FieldOffset(16)]
			public int Value;

			// Token: 0x04017B79 RID: 97145
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x04017B7A RID: 97146
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003A4A RID: 14922
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleFloatVariable_FunctionParams
		{
			// Token: 0x04017B7B RID: 97147
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B7C RID: 97148
			[FieldOffset(16)]
			public float Value;

			// Token: 0x04017B7D RID: 97149
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x04017B7E RID: 97150
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003A4B RID: 14923
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleBoolVariable_FunctionParams
		{
			// Token: 0x04017B7F RID: 97151
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B80 RID: 97152
			[FieldOffset(16)]
			public bool Value;

			// Token: 0x04017B81 RID: 97153
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x04017B82 RID: 97154
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x02003A4C RID: 14924
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RegisterConsoleStringVariable_FunctionParams
		{
			// Token: 0x04017B83 RID: 97155
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B84 RID: 97156
			[FieldOffset(16)]
			public FString DefaultValue;

			// Token: 0x04017B85 RID: 97157
			[FieldOffset(32)]
			public FString Help;

			// Token: 0x04017B86 RID: 97158
			[FieldOffset(48)]
			public uint Flags;
		}

		// Token: 0x02003A4D RID: 14925
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleIntVariable_FunctionParams
		{
			// Token: 0x04017B87 RID: 97159
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B88 RID: 97160
			[FieldOffset(16)]
			public int DefaultValue;

			// Token: 0x04017B89 RID: 97161
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x04017B8A RID: 97162
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02003A4E RID: 14926
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleFloatVariable_FunctionParams
		{
			// Token: 0x04017B8B RID: 97163
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B8C RID: 97164
			[FieldOffset(16)]
			public float DefaultValue;

			// Token: 0x04017B8D RID: 97165
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x04017B8E RID: 97166
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02003A4F RID: 14927
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithWorldAndArgs_FunctionParams
		{
			// Token: 0x04017B8F RID: 97167
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B90 RID: 97168
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04017B91 RID: 97169
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04017B92 RID: 97170
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02003A50 RID: 14928
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithWorld_FunctionParams
		{
			// Token: 0x04017B93 RID: 97171
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B94 RID: 97172
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04017B95 RID: 97173
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04017B96 RID: 97174
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02003A51 RID: 14929
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithArgs_FunctionParams
		{
			// Token: 0x04017B97 RID: 97175
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B98 RID: 97176
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04017B99 RID: 97177
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04017B9A RID: 97178
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02003A52 RID: 14930
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommand_FunctionParams
		{
			// Token: 0x04017B9B RID: 97179
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017B9C RID: 97180
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04017B9D RID: 97181
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04017B9E RID: 97182
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02003A53 RID: 14931
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleBoolVariable_FunctionParams
		{
			// Token: 0x04017B9F RID: 97183
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017BA0 RID: 97184
			[FieldOffset(16)]
			public bool DefaultValue;

			// Token: 0x04017BA1 RID: 97185
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x04017BA2 RID: 97186
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02003A54 RID: 14932
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetConsoleStringVariable_FunctionParams
		{
			// Token: 0x04017BA3 RID: 97187
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017BA4 RID: 97188
			[FieldOffset(16)]
			public FString Result;

			// Token: 0x04017BA5 RID: 97189
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02003A55 RID: 14933
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleIntVariable_FunctionParams
		{
			// Token: 0x04017BA6 RID: 97190
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017BA7 RID: 97191
			[FieldOffset(16)]
			public int Result;

			// Token: 0x04017BA8 RID: 97192
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02003A56 RID: 14934
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleFloatVariable_FunctionParams
		{
			// Token: 0x04017BA9 RID: 97193
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017BAA RID: 97194
			[FieldOffset(16)]
			public float Result;

			// Token: 0x04017BAB RID: 97195
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02003A57 RID: 14935
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleBoolVariable_FunctionParams
		{
			// Token: 0x04017BAC RID: 97196
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04017BAD RID: 97197
			[FieldOffset(16)]
			public bool Result;

			// Token: 0x04017BAE RID: 97198
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
