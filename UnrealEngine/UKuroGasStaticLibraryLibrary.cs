using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB9 RID: 7865
	[UnrealObjectPath("/Script/KuroUtility.KuroGasStaticLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGasStaticLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD92 RID: 122258 RVA: 0x002C2726 File Offset: 0x002C0926
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGasStaticLibraryLibrary._ClassPtr;
		}

		// Token: 0x0601DD93 RID: 122259 RVA: 0x002C2734 File Offset: 0x002C0934
		public UKuroGasStaticLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroGasStaticLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD94 RID: 122260 RVA: 0x002C275C File Offset: 0x002C095C
		[NullableContext(1)]
		public UKuroGasStaticLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGasStaticLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD95 RID: 122261 RVA: 0x002C2790 File Offset: 0x002C0990
		[NullableContext(2)]
		public static void SetMultiAttributesValue(UBaseAttributeSet AttributeSet, ref TArray<int> AttributeTypes, ref TArray<float> BaseValues, ref TArray<float> CurrentValues)
		{
			UKuroGasStaticLibraryLibrary.__SetMultiAttributesValue_Internal((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero, (AttributeTypes ?? new TArray<int>()).NativePtr, (BaseValues ?? new TArray<float>()).NativePtr, (CurrentValues ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x0601DD96 RID: 122262
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMultiAttributesValue_Internal(IntPtr AttributeSet, IntPtr AttributeTypes, IntPtr BaseValues, IntPtr CurrentValues);

		// Token: 0x0601DD97 RID: 122263 RVA: 0x002C27E2 File Offset: 0x002C09E2
		static UKuroGasStaticLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroGasStaticLibraryLibrary");
		}

		// Token: 0x0601DD98 RID: 122264 RVA: 0x002C27F0 File Offset: 0x002C09F0
		protected UKuroGasStaticLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102C2 RID: 66242
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroGasStaticLibraryLibrary";

		// Token: 0x040102C3 RID: 66243
		private static IntPtr _ClassPtr;

		// Token: 0x040102C4 RID: 66244
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
