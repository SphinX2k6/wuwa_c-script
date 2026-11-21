using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000808 RID: 2056
	[UnrealObjectPath("/Script/Sharphereal.ConsoleCommandBPL")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UConsoleCommandBPL : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B50D RID: 46349 RVA: 0x0011F8AD File Offset: 0x0011DAAD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UConsoleCommandBPL._ClassPtr;
		}

		// Token: 0x0600B50E RID: 46350 RVA: 0x0011F8BC File Offset: 0x0011DABC
		public UConsoleCommandBPL() : this(BuiltinUtils.AllocNativeUObject(UConsoleCommandBPL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B50F RID: 46351 RVA: 0x0011F8E4 File Offset: 0x0011DAE4
		[NullableContext(1)]
		public UConsoleCommandBPL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UConsoleCommandBPL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B510 RID: 46352 RVA: 0x0011F918 File Offset: 0x0011DB18
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void UnregisterConsoleObject(string Name)
		{
			UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UConsoleCommandBPL.__UnregisterConsoleObject_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__UnregisterConsoleObject_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B511 RID: 46353 RVA: 0x0011F974 File Offset: 0x0011DB74
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SetConsoleStringVariable(string Name, string Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Value), Value);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B512 RID: 46354 RVA: 0x0011F9EC File Offset: 0x0011DBEC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SetConsoleIntVariable(string Name, int Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B513 RID: 46355 RVA: 0x0011FA5C File Offset: 0x0011DC5C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SetConsoleFloatVariable(string Name, float Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B514 RID: 46356 RVA: 0x0011FACC File Offset: 0x0011DCCC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool SetConsoleBoolVariable(string Name, bool Value, uint Flags)
		{
			UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UConsoleCommandBPL.__SetConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Value = Value;
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr);
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__SetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B515 RID: 46357 RVA: 0x0011FB3C File Offset: 0x0011DD3C
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RegisterConsoleStringVariable(string Name, string DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams[(UIntPtr)71] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->DefaultValue), DefaultValue);
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B516 RID: 46358 RVA: 0x0011FBBC File Offset: 0x0011DDBC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RegisterConsoleIntVariable(string Name, int DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B517 RID: 46359 RVA: 0x0011FC34 File Offset: 0x0011DE34
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RegisterConsoleFloatVariable(string Name, float DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B518 RID: 46360 RVA: 0x0011FCAC File Offset: 0x0011DEAC
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B519 RID: 46361 RVA: 0x0011FD38 File Offset: 0x0011DF38
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithWorld_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B51A RID: 46362 RVA: 0x0011FDC4 File Offset: 0x0011DFC4
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommandWithArgs_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B51B RID: 46363 RVA: 0x0011FE50 File Offset: 0x0011E050
		[NullableContext(1)]
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleCommand_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleCommand_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B51C RID: 46364 RVA: 0x0011FEDC File Offset: 0x0011E0DC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void RegisterConsoleBoolVariable(string Name, bool DefaultValue, string Help, uint Flags)
		{
			UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams[(UIntPtr)63] + 15L / (long)sizeof(UConsoleCommandBPL.__RegisterConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->DefaultValue = DefaultValue;
			FString.CopyFrom((void*)(&ptr->Help), Help);
			ptr->Flags = Flags;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__RegisterConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B51D RID: 46365 RVA: 0x0011FF54 File Offset: 0x0011E154
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetConsoleStringVariable(string Name, ref string Result)
		{
			UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleStringVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			FString.CopyFrom((void*)(&ptr->Result), Result);
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr);
			Result = FString.ToString((void*)(&ptr->Result));
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleStringVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B51E RID: 46366 RVA: 0x0011FFD4 File Offset: 0x0011E1D4
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetConsoleIntVariable(string Name, ref int Result)
		{
			UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleIntVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleIntVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B51F RID: 46367 RVA: 0x00120048 File Offset: 0x0011E248
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetConsoleFloatVariable(string Name, ref float Result)
		{
			UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleFloatVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleFloatVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B520 RID: 46368 RVA: 0x001200BC File Offset: 0x0011E2BC
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static bool GetConsoleBoolVariable(string Name, ref bool Result)
		{
			UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams* ptr = stackalloc UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UConsoleCommandBPL.__GetConsoleBoolVariable_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->Name), Name);
			ptr->Result = Result;
			UnrealReflectionUtils.CallUFunction(UConsoleCommandBPL._ClassDefaultObjectPtr, UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr);
			Result = ptr->Result;
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UConsoleCommandBPL.__GetConsoleBoolVariable_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B521 RID: 46369 RVA: 0x0012012E File Offset: 0x0011E32E
		static UConsoleCommandBPL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.ConsoleCommandBPL");
		}

		// Token: 0x0600B522 RID: 46370 RVA: 0x0012013C File Offset: 0x0011E33C
		protected UConsoleCommandBPL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400518A RID: 20874
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.ConsoleCommandBPL";

		// Token: 0x0400518B RID: 20875
		private static IntPtr _ClassPtr;

		// Token: 0x0400518C RID: 20876
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400518D RID: 20877
		private static IntPtr __UnregisterConsoleObject_NativeFunctionPtr;

		// Token: 0x0400518E RID: 20878
		private static IntPtr __SetConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x0400518F RID: 20879
		private static IntPtr __SetConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x04005190 RID: 20880
		private static IntPtr __SetConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x04005191 RID: 20881
		private static IntPtr __SetConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x04005192 RID: 20882
		private static IntPtr __RegisterConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x04005193 RID: 20883
		private static IntPtr __RegisterConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x04005194 RID: 20884
		private static IntPtr __RegisterConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x04005195 RID: 20885
		private static IntPtr __RegisterConsoleCommandWithWorldAndArgs_NativeFunctionPtr;

		// Token: 0x04005196 RID: 20886
		private static IntPtr __RegisterConsoleCommandWithWorld_NativeFunctionPtr;

		// Token: 0x04005197 RID: 20887
		private static IntPtr __RegisterConsoleCommandWithArgs_NativeFunctionPtr;

		// Token: 0x04005198 RID: 20888
		private static IntPtr __RegisterConsoleCommand_NativeFunctionPtr;

		// Token: 0x04005199 RID: 20889
		private static IntPtr __RegisterConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x0400519A RID: 20890
		private static IntPtr __GetConsoleStringVariable_NativeFunctionPtr;

		// Token: 0x0400519B RID: 20891
		private static IntPtr __GetConsoleIntVariable_NativeFunctionPtr;

		// Token: 0x0400519C RID: 20892
		private static IntPtr __GetConsoleFloatVariable_NativeFunctionPtr;

		// Token: 0x0400519D RID: 20893
		private static IntPtr __GetConsoleBoolVariable_NativeFunctionPtr;

		// Token: 0x02001319 RID: 4889
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __UnregisterConsoleObject_FunctionParams
		{
			// Token: 0x04006725 RID: 26405
			[FieldOffset(0)]
			public FString Name;
		}

		// Token: 0x0200131A RID: 4890
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __SetConsoleStringVariable_FunctionParams
		{
			// Token: 0x04006726 RID: 26406
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006727 RID: 26407
			[FieldOffset(16)]
			public FString Value;

			// Token: 0x04006728 RID: 26408
			[FieldOffset(32)]
			public uint Flags;

			// Token: 0x04006729 RID: 26409
			[FieldOffset(36)]
			public bool __Result;
		}

		// Token: 0x0200131B RID: 4891
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleIntVariable_FunctionParams
		{
			// Token: 0x0400672A RID: 26410
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400672B RID: 26411
			[FieldOffset(16)]
			public int Value;

			// Token: 0x0400672C RID: 26412
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x0400672D RID: 26413
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x0200131C RID: 4892
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleFloatVariable_FunctionParams
		{
			// Token: 0x0400672E RID: 26414
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400672F RID: 26415
			[FieldOffset(16)]
			public float Value;

			// Token: 0x04006730 RID: 26416
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x04006731 RID: 26417
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x0200131D RID: 4893
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __SetConsoleBoolVariable_FunctionParams
		{
			// Token: 0x04006732 RID: 26418
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006733 RID: 26419
			[FieldOffset(16)]
			public bool Value;

			// Token: 0x04006734 RID: 26420
			[FieldOffset(20)]
			public uint Flags;

			// Token: 0x04006735 RID: 26421
			[FieldOffset(24)]
			public bool __Result;
		}

		// Token: 0x0200131E RID: 4894
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 56)]
		protected ref struct __RegisterConsoleStringVariable_FunctionParams
		{
			// Token: 0x04006736 RID: 26422
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006737 RID: 26423
			[FieldOffset(16)]
			public FString DefaultValue;

			// Token: 0x04006738 RID: 26424
			[FieldOffset(32)]
			public FString Help;

			// Token: 0x04006739 RID: 26425
			[FieldOffset(48)]
			public uint Flags;
		}

		// Token: 0x0200131F RID: 4895
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleIntVariable_FunctionParams
		{
			// Token: 0x0400673A RID: 26426
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400673B RID: 26427
			[FieldOffset(16)]
			public int DefaultValue;

			// Token: 0x0400673C RID: 26428
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x0400673D RID: 26429
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02001320 RID: 4896
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleFloatVariable_FunctionParams
		{
			// Token: 0x0400673E RID: 26430
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400673F RID: 26431
			[FieldOffset(16)]
			public float DefaultValue;

			// Token: 0x04006740 RID: 26432
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x04006741 RID: 26433
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02001321 RID: 4897
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithWorldAndArgs_FunctionParams
		{
			// Token: 0x04006742 RID: 26434
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006743 RID: 26435
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04006744 RID: 26436
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04006745 RID: 26437
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02001322 RID: 4898
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithWorld_FunctionParams
		{
			// Token: 0x04006746 RID: 26438
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006747 RID: 26439
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04006748 RID: 26440
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04006749 RID: 26441
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02001323 RID: 4899
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommandWithArgs_FunctionParams
		{
			// Token: 0x0400674A RID: 26442
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400674B RID: 26443
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x0400674C RID: 26444
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x0400674D RID: 26445
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02001324 RID: 4900
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __RegisterConsoleCommand_FunctionParams
		{
			// Token: 0x0400674E RID: 26446
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400674F RID: 26447
			[FieldOffset(16)]
			public FString Help;

			// Token: 0x04006750 RID: 26448
			[FieldOffset(32)]
			public byte Command;

			// Token: 0x04006751 RID: 26449
			[FieldOffset(72)]
			public uint Flags;
		}

		// Token: 0x02001325 RID: 4901
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 48)]
		protected ref struct __RegisterConsoleBoolVariable_FunctionParams
		{
			// Token: 0x04006752 RID: 26450
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006753 RID: 26451
			[FieldOffset(16)]
			public bool DefaultValue;

			// Token: 0x04006754 RID: 26452
			[FieldOffset(24)]
			public FString Help;

			// Token: 0x04006755 RID: 26453
			[FieldOffset(40)]
			public uint Flags;
		}

		// Token: 0x02001326 RID: 4902
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __GetConsoleStringVariable_FunctionParams
		{
			// Token: 0x04006756 RID: 26454
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006757 RID: 26455
			[FieldOffset(16)]
			public FString Result;

			// Token: 0x04006758 RID: 26456
			[FieldOffset(32)]
			public bool __Result;
		}

		// Token: 0x02001327 RID: 4903
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleIntVariable_FunctionParams
		{
			// Token: 0x04006759 RID: 26457
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400675A RID: 26458
			[FieldOffset(16)]
			public int Result;

			// Token: 0x0400675B RID: 26459
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02001328 RID: 4904
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleFloatVariable_FunctionParams
		{
			// Token: 0x0400675C RID: 26460
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x0400675D RID: 26461
			[FieldOffset(16)]
			public float Result;

			// Token: 0x0400675E RID: 26462
			[FieldOffset(20)]
			public bool __Result;
		}

		// Token: 0x02001329 RID: 4905
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __GetConsoleBoolVariable_FunctionParams
		{
			// Token: 0x0400675F RID: 26463
			[FieldOffset(0)]
			public FString Name;

			// Token: 0x04006760 RID: 26464
			[FieldOffset(16)]
			public bool Result;

			// Token: 0x04006761 RID: 26465
			[FieldOffset(17)]
			public bool __Result;
		}
	}
}
