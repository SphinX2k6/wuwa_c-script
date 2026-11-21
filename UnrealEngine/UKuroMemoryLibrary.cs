using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DC RID: 1500
	[UnrealObjectPath("/Script/KuroUtility.KuroMemoryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMemoryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084AD RID: 33965 RVA: 0x000C4D7C File Offset: 0x000C2F7C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMemoryLibrary._ClassPtr;
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x000C4D88 File Offset: 0x000C2F88
		public UKuroMemoryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMemoryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x000C4DB0 File Offset: 0x000C2FB0
		[NullableContext(1)]
		public UKuroMemoryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMemoryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084B0 RID: 33968 RVA: 0x000C4DE4 File Offset: 0x000C2FE4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe static void PrintUObjectMemoryInfo(UObject Object)
		{
			UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams* ptr = stackalloc UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemoryLibrary.__PrintUObjectMemoryInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroMemoryLibrary._ClassDefaultObjectPtr, UKuroMemoryLibrary.__PrintUObjectMemoryInfo_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x000C4E38 File Offset: 0x000C3038
		static UKuroMemoryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMemoryLibrary");
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x000C4E46 File Offset: 0x000C3046
		protected UKuroMemoryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039FA RID: 14842
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMemoryLibrary";

		// Token: 0x040039FB RID: 14843
		private static IntPtr _ClassPtr;

		// Token: 0x040039FC RID: 14844
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040039FD RID: 14845
		private static IntPtr __PrintUObjectMemoryInfo_NativeFunctionPtr;

		// Token: 0x02000D69 RID: 3433
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __PrintUObjectMemoryInfo_FunctionParams
		{
			// Token: 0x04006024 RID: 24612
			[FieldOffset(0)]
			public IntPtr Object;
		}
	}
}
