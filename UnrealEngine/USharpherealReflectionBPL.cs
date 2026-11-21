using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000811 RID: 2065
	[UnrealObjectPath("/Script/Sharphereal.SharpherealReflectionBPL")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class USharpherealReflectionBPL : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B55F RID: 46431 RVA: 0x00120901 File Offset: 0x0011EB01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USharpherealReflectionBPL._ClassPtr;
		}

		// Token: 0x0600B560 RID: 46432 RVA: 0x00120910 File Offset: 0x0011EB10
		public USharpherealReflectionBPL() : this(BuiltinUtils.AllocNativeUObject(USharpherealReflectionBPL.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B561 RID: 46433 RVA: 0x00120938 File Offset: 0x0011EB38
		[NullableContext(1)]
		public USharpherealReflectionBPL(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USharpherealReflectionBPL.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600B562 RID: 46434 RVA: 0x0012096C File Offset: 0x0011EB6C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool GetStructDefine(UStruct Struct, ref FSharpherealReflectionStructGenerateDefine OutDefine)
		{
			USharpherealReflectionBPL.__GetStructDefine_FunctionParams* ptr = stackalloc USharpherealReflectionBPL.__GetStructDefine_FunctionParams[(UIntPtr)79] + 15L / (long)sizeof(USharpherealReflectionBPL.__GetStructDefine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Struct = ((Struct != null) ? Struct.NativePtr : IntPtr.Zero);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionStructGenerateDefine.StaticStruct(), &ptr->OutDefine, OutDefine.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionStructGenerateDefine.StaticStruct(), OutDefine.NativePtr, &ptr->OutDefine, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetStructDefine_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B563 RID: 46435 RVA: 0x00120A20 File Offset: 0x0011EC20
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static bool GetClassDefine(UClassStackOnlyPtr Class, ref FSharpherealReflectionClassGenerateDefine OutDefine)
		{
			USharpherealReflectionBPL.__GetClassDefine_FunctionParams* ptr = stackalloc USharpherealReflectionBPL.__GetClassDefine_FunctionParams[(UIntPtr)95] + 15L / (long)sizeof(USharpherealReflectionBPL.__GetClassDefine_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Class = Class;
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionClassGenerateDefine.StaticStruct(), &ptr->OutDefine, OutDefine.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr);
			if (OutDefine != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FSharpherealReflectionClassGenerateDefine.StaticStruct(), OutDefine.NativePtr, &ptr->OutDefine, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetClassDefine_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600B564 RID: 46436 RVA: 0x00120AC4 File Offset: 0x0011ECC4
		[SkipLocalsInit]
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
			UnrealReflectionUtils.CallUFunction(USharpherealReflectionBPL._ClassDefaultObjectPtr, USharpherealReflectionBPL.__GetAllBlueprintProxy_NativeFunctionPtr, (void*)ptr);
			TArray<UClass> tarray2 = Classes;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->Classes);
			}
			UnrealReflectionUtils.DestroyStruct(USharpherealReflectionBPL.__GetAllBlueprintProxy_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0600B565 RID: 46437 RVA: 0x00120B3B File Offset: 0x0011ED3B
		static USharpherealReflectionBPL()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Sharphereal.SharpherealReflectionBPL");
		}

		// Token: 0x0600B566 RID: 46438 RVA: 0x00120B49 File Offset: 0x0011ED49
		protected USharpherealReflectionBPL(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040051D8 RID: 20952
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Sharphereal.SharpherealReflectionBPL";

		// Token: 0x040051D9 RID: 20953
		private static IntPtr _ClassPtr;

		// Token: 0x040051DA RID: 20954
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040051DB RID: 20955
		private static IntPtr __GetStructDefine_NativeFunctionPtr;

		// Token: 0x040051DC RID: 20956
		private static IntPtr __GetClassDefine_NativeFunctionPtr;

		// Token: 0x040051DD RID: 20957
		private static IntPtr __GetAllBlueprintProxy_NativeFunctionPtr;

		// Token: 0x02001334 RID: 4916
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 64)]
		protected ref struct __GetStructDefine_FunctionParams
		{
			// Token: 0x0400676E RID: 26478
			[FieldOffset(0)]
			public IntPtr Struct;

			// Token: 0x0400676F RID: 26479
			[FieldOffset(8)]
			public byte OutDefine;

			// Token: 0x04006770 RID: 26480
			[FieldOffset(56)]
			public bool __Result;
		}

		// Token: 0x02001335 RID: 4917
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __GetClassDefine_FunctionParams
		{
			// Token: 0x04006771 RID: 26481
			[FieldOffset(0)]
			public UClassStackOnlyPtr Class;

			// Token: 0x04006772 RID: 26482
			[FieldOffset(8)]
			public byte OutDefine;

			// Token: 0x04006773 RID: 26483
			[FieldOffset(72)]
			public bool __Result;
		}

		// Token: 0x02001336 RID: 4918
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __GetAllBlueprintProxy_FunctionParams
		{
			// Token: 0x04006774 RID: 26484
			[FieldOffset(0)]
			public byte Classes;
		}
	}
}
