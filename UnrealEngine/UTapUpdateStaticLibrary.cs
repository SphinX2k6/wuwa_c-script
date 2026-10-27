using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028F5 RID: 10485
	[UnrealObjectPath("/Script/TapUpdate.TapUpdateStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTapUpdateStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026E30 RID: 159280 RVA: 0x003B5157 File Offset: 0x003B3357
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapUpdateStaticLibrary._ClassPtr;
		}

		// Token: 0x06026E31 RID: 159281 RVA: 0x003B5164 File Offset: 0x003B3364
		public UTapUpdateStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UTapUpdateStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026E32 RID: 159282 RVA: 0x003B518C File Offset: 0x003B338C
		[NullableContext(1)]
		public UTapUpdateStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapUpdateStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06026E33 RID: 159283 RVA: 0x003B51C0 File Offset: 0x003B33C0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void UpdateGame(FUpdateGameCancelHandle handle)
		{
			UTapUpdateStaticLibrary.__UpdateGame_FunctionParams* ptr = stackalloc UTapUpdateStaticLibrary.__UpdateGame_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UTapUpdateStaticLibrary.__UpdateGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->handle, (handle != null) ? handle.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UTapUpdateStaticLibrary._ClassDefaultObjectPtr, UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026E34 RID: 159284 RVA: 0x003B522C File Offset: 0x003B342C
		[NullableContext(1)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void Init(string clientId, string clientToken)
		{
			UTapUpdateStaticLibrary.__Init_FunctionParams* ptr = stackalloc UTapUpdateStaticLibrary.__Init_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTapUpdateStaticLibrary.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->clientId), clientId);
			FString.CopyFrom((void*)(&ptr->clientToken), clientToken);
			UnrealReflectionUtils.CallUFunction(UTapUpdateStaticLibrary._ClassDefaultObjectPtr, UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06026E35 RID: 159285 RVA: 0x003B5296 File Offset: 0x003B3496
		static UTapUpdateStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapUpdate.TapUpdateStaticLibrary");
		}

		// Token: 0x06026E36 RID: 159286 RVA: 0x003B52A4 File Offset: 0x003B34A4
		protected UTapUpdateStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015598 RID: 87448
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapUpdate.TapUpdateStaticLibrary";

		// Token: 0x04015599 RID: 87449
		private static IntPtr _ClassPtr;

		// Token: 0x0401559A RID: 87450
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401559B RID: 87451
		private static IntPtr __UpdateGame_NativeFunctionPtr;

		// Token: 0x0401559C RID: 87452
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x02003B55 RID: 15189
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UpdateGame_FunctionParams
		{
			// Token: 0x04017CFE RID: 97534
			[FieldOffset(0)]
			public byte handle;
		}

		// Token: 0x02003B56 RID: 15190
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x04017CFF RID: 97535
			[FieldOffset(0)]
			public FString clientId;

			// Token: 0x04017D00 RID: 97536
			[FieldOffset(16)]
			public FString clientToken;
		}
	}
}
