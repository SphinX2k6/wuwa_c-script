using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002768 RID: 10088
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionBPL")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USharpherealReflectionBPL : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025B88 RID: 154504 RVA: 0x00392D49 File Offset: 0x00390F49
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealReflectionBPL._ClassPtr;
		}

		// Token: 0x06025B89 RID: 154505 RVA: 0x00392D58 File Offset: 0x00390F58
		public USharpherealReflectionBPL() : this(BuiltinUtils.AllocNativeUObject(USharpherealReflectionBPL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025B8A RID: 154506 RVA: 0x00392D80 File Offset: 0x00390F80
		[NullableContext(1)]
		public USharpherealReflectionBPL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealReflectionBPL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06025B8B RID: 154507 RVA: 0x00392DB4 File Offset: 0x00390FB4
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetStructDefine(UStruct Struct, ref FSharpherealReflectionStructGenerateDefine OutDefine)
		{
			USharpherealReflectionBPL.__GetStructDefine_FunctionParams* ptr = stackalloc USharpherealReflectionBPL.__GetStructDefine_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(USharpherealReflectionBPL.__GetStructDefine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Struct = ((Struct != null) ? Struct.NativePtr : IntPtr.Zero);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionStructGenerateDefine.StaticStruct(), &ptr->OutDefine, OutDefine.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr, 0);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionStructGenerateDefine.StaticStruct(), OutDefine.NativePtr, &ptr->OutDefine, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025B8C RID: 154508 RVA: 0x00392E68 File Offset: 0x00391068
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static bool GetClassDefine(UClassStackOnlyPtr Class, ref FSharpherealReflectionClassGenerateDefine OutDefine)
		{
			USharpherealReflectionBPL.__GetClassDefine_FunctionParams* ptr = stackalloc USharpherealReflectionBPL.__GetClassDefine_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USharpherealReflectionBPL.__GetClassDefine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionClassGenerateDefine.StaticStruct(), &ptr->OutDefine, OutDefine.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr, 0);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionClassGenerateDefine.StaticStruct(), OutDefine.NativePtr, &ptr->OutDefine, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06025B8D RID: 154509 RVA: 0x00392F10 File Offset: 0x00391110
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void GetAllBlueprintProxy([Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<UClass> Classes)
		{
			USharpherealReflectionBPL.__GetAllBlueprintProxy_FunctionParams* ptr = stackalloc USharpherealReflectionBPL.__GetAllBlueprintProxy_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(USharpherealReflectionBPL.__GetAllBlueprintProxy_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealReflectionBPL.__GetAllBlueprintProxy_NativeFunctionPtr, (void*)ptr, 1);
			TArray<UClass> tarray = Classes;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->Classes);
			}
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetAllBlueprintProxy_NativeFunctionPtr, (void*)ptr, 0);
			TArray<UClass> tarray2 = Classes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Classes);
			}
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetAllBlueprintProxy_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06025B8E RID: 154510 RVA: 0x00392F88 File Offset: 0x00391188
		static USharpherealReflectionBPL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.SharpherealReflectionBPL");
		}

		// Token: 0x06025B8F RID: 154511 RVA: 0x00392F96 File Offset: 0x00391196
		protected USharpherealReflectionBPL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401488A RID: 84106
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionBPL";

		// Token: 0x0401488B RID: 84107
		private static IntPtr _ClassPtr;

		// Token: 0x0401488C RID: 84108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401488D RID: 84109
		private static IntPtr __GetStructDefine_NativeFunctionPtr;

		// Token: 0x0401488E RID: 84110
		private static IntPtr __GetClassDefine_NativeFunctionPtr;

		// Token: 0x0401488F RID: 84111
		private static IntPtr __GetAllBlueprintProxy_NativeFunctionPtr;

		// Token: 0x02003A62 RID: 14946
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetStructDefine_FunctionParams
		{
			// Token: 0x04017BBB RID: 97211
			[FieldOffset(0)]
			public IntPtr Struct;

			// Token: 0x04017BBC RID: 97212
			[FieldOffset(8)]
			public byte OutDefine;

			// Token: 0x04017BBD RID: 97213
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02003A63 RID: 14947
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassDefine_FunctionParams
		{
			// Token: 0x04017BBE RID: 97214
			[FieldOffset(0)]
			public UClassStackOnlyPtr Class;

			// Token: 0x04017BBF RID: 97215
			[FieldOffset(8)]
			public byte OutDefine;

			// Token: 0x04017BC0 RID: 97216
			[FieldOffset(72)]
			public bool __Result;
		}

		// Token: 0x02003A64 RID: 14948
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllBlueprintProxy_FunctionParams
		{
			// Token: 0x04017BC1 RID: 97217
			[FieldOffset(0)]
			public byte Classes;
		}
	}
}
