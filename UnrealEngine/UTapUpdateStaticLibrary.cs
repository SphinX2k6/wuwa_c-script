using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000849 RID: 2121
	[UnrealObjectPath("/Script/TapUpdate.TapUpdateStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UTapUpdateStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B8EA RID: 47338 RVA: 0x00128063 File Offset: 0x00126263
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UTapUpdateStaticLibrary._ClassPtr;
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x00128070 File Offset: 0x00126270
		public UTapUpdateStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UTapUpdateStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x00128098 File Offset: 0x00126298
		[NullableContext(1)]
		public UTapUpdateStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UTapUpdateStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x001280CC File Offset: 0x001262CC
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void UpdateGame(FUpdateGameCancelHandle handle)
		{
			UTapUpdateStaticLibrary.__UpdateGame_FunctionParams* ptr = stackalloc UTapUpdateStaticLibrary.__UpdateGame_FunctionParams[(UIntPtr)55] + 15L / (long)sizeof(UTapUpdateStaticLibrary.__UpdateGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr, 1);
			FScriptDelegate.NativeCopy(&ptr->handle, (handle != null) ? handle.NativePtr : ((IntPtr)0));
			UnrealReflectionUtils.CallUFunction(UTapUpdateStaticLibrary._ClassDefaultObjectPtr, UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTapUpdateStaticLibrary.__UpdateGame_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B8EE RID: 47342 RVA: 0x00128134 File Offset: 0x00126334
		[NullableContext(1)]
		[SkipLocalsInit]
		public unsafe static void Init(string clientId, string clientToken)
		{
			UTapUpdateStaticLibrary.__Init_FunctionParams* ptr = stackalloc UTapUpdateStaticLibrary.__Init_FunctionParams[(UIntPtr)47] + 15L / (long)sizeof(UTapUpdateStaticLibrary.__Init_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->clientId), clientId);
			FString.CopyFrom((void*)(&ptr->clientToken), clientToken);
			UnrealReflectionUtils.CallUFunction(UTapUpdateStaticLibrary._ClassDefaultObjectPtr, UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UTapUpdateStaticLibrary.__Init_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B8EF RID: 47343 RVA: 0x0012819D File Offset: 0x0012639D
		static UTapUpdateStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TapUpdate.TapUpdateStaticLibrary");
		}

		// Token: 0x0600B8F0 RID: 47344 RVA: 0x001281AB File Offset: 0x001263AB
		protected UTapUpdateStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040053FD RID: 21501
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TapUpdate.TapUpdateStaticLibrary";

		// Token: 0x040053FE RID: 21502
		private static IntPtr _ClassPtr;

		// Token: 0x040053FF RID: 21503
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005400 RID: 21504
		private static IntPtr __UpdateGame_NativeFunctionPtr;

		// Token: 0x04005401 RID: 21505
		private static IntPtr __Init_NativeFunctionPtr;

		// Token: 0x020013D8 RID: 5080
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 40)]
		protected ref struct __UpdateGame_FunctionParams
		{
			// Token: 0x04006843 RID: 26691
			[FieldOffset(0)]
			public byte handle;
		}

		// Token: 0x020013D9 RID: 5081
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 32)]
		protected ref struct __Init_FunctionParams
		{
			// Token: 0x04006844 RID: 26692
			[FieldOffset(0)]
			public FString clientId;

			// Token: 0x04006845 RID: 26693
			[FieldOffset(16)]
			public FString clientToken;
		}
	}
}
