using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D7 RID: 1495
	[UnrealObjectPath("/Script/KuroUtility.KuroGasStaticLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroGasStaticLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600845F RID: 33887 RVA: 0x000C47C2 File Offset: 0x000C29C2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroGasStaticLibraryLibrary._ClassPtr;
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x000C47D0 File Offset: 0x000C29D0
		public UKuroGasStaticLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroGasStaticLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x000C47F8 File Offset: 0x000C29F8
		[NullableContext(1)]
		public UKuroGasStaticLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroGasStaticLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x000C482C File Offset: 0x000C2A2C
		[NullableContext(2)]
		public static void SetMultiAttributesValue(UBaseAttributeSet AttributeSet, ref TArray<int> AttributeTypes, ref TArray<float> BaseValues, ref TArray<float> CurrentValues)
		{
			UKuroGasStaticLibraryLibrary.__SetMultiAttributesValue_Internal((AttributeSet != null) ? AttributeSet.NativePtr : IntPtr.Zero, (AttributeTypes ?? new TArray<int>()).NativePtr, (BaseValues ?? new TArray<float>()).NativePtr, (CurrentValues ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06008463 RID: 33891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMultiAttributesValue_Internal(IntPtr AttributeSet, IntPtr AttributeTypes, IntPtr BaseValues, IntPtr CurrentValues);

		// Token: 0x06008464 RID: 33892 RVA: 0x000C487E File Offset: 0x000C2A7E
		static UKuroGasStaticLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroGasStaticLibraryLibrary");
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x000C488C File Offset: 0x000C2A8C
		protected UKuroGasStaticLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039D8 RID: 14808
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroGasStaticLibraryLibrary";

		// Token: 0x040039D9 RID: 14809
		private static IntPtr _ClassPtr;

		// Token: 0x040039DA RID: 14810
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
