using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EC0 RID: 7872
	[UnrealObjectPath("/Script/KuroUtility.KuroMemoryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroMemoryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDF0 RID: 122352 RVA: 0x002C2E8E File Offset: 0x002C108E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroMemoryLibrary._ClassPtr;
		}

		// Token: 0x0601DDF1 RID: 122353 RVA: 0x002C2E9C File Offset: 0x002C109C
		public UKuroMemoryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroMemoryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDF2 RID: 122354 RVA: 0x002C2EC4 File Offset: 0x002C10C4
		[NullableContext(1)]
		public UKuroMemoryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroMemoryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DDF3 RID: 122355 RVA: 0x002C2EF8 File Offset: 0x002C10F8
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static void PrintUObjectMemoryInfo(UObject Object)
		{
			UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams* ptr = stackalloc UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroMemoryLibrary.__PrintUObjectMemoryInfo_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroMemoryLibrary.__PrintUObjectMemoryInfo_NativeFunctionPtr, (void*)ptr, 1);
			ptr->Object = ((Object != null) ? Object.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(UKuroMemoryLibrary._ClassDefaultObjectPtr, UKuroMemoryLibrary.__PrintUObjectMemoryInfo_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601DDF4 RID: 122356 RVA: 0x002C2F4D File Offset: 0x002C114D
		static UKuroMemoryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroMemoryLibrary");
		}

		// Token: 0x0601DDF5 RID: 122357 RVA: 0x002C2F5B File Offset: 0x002C115B
		protected UKuroMemoryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102EA RID: 66282
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroMemoryLibrary";

		// Token: 0x040102EB RID: 66283
		private static IntPtr _ClassPtr;

		// Token: 0x040102EC RID: 66284
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040102ED RID: 66285
		private static IntPtr __PrintUObjectMemoryInfo_NativeFunctionPtr;

		// Token: 0x02003313 RID: 13075
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __PrintUObjectMemoryInfo_FunctionParams
		{
			// Token: 0x040171ED RID: 94701
			[FieldOffset(0)]
			public IntPtr Object;
		}
	}
}
