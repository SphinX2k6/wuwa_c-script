using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005DB RID: 1499
	[UnrealObjectPath("/Script/KuroUtility.KuroLoggingLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLoggingLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060084A1 RID: 33953 RVA: 0x000C4CC9 File Offset: 0x000C2EC9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLoggingLibraryLibrary._ClassPtr;
		}

		// Token: 0x060084A2 RID: 33954 RVA: 0x000C4CD8 File Offset: 0x000C2ED8
		public UKuroLoggingLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLoggingLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x000C4D00 File Offset: 0x000C2F00
		[NullableContext(1)]
		public UKuroLoggingLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLoggingLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060084A4 RID: 33956 RVA: 0x000C4D34 File Offset: 0x000C2F34
		[NullableContext(1)]
		public unsafe static void SetCategoryVerbosity(string CategoryName, byte Verbosity)
		{
			FString fstring = FString.AllocTemp(CategoryName);
			UKuroLoggingLibraryLibrary.__SetCategoryVerbosity_Internal(fstring, Verbosity);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060084A5 RID: 33957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGlobalLogVerbosity();

		// Token: 0x060084A6 RID: 33958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterTerminateDelegate();

		// Token: 0x060084A7 RID: 33959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PromoteGlobalLogVerbosity(byte Verbosity);

		// Token: 0x060084A8 RID: 33960 RVA: 0x000C4D59 File Offset: 0x000C2F59
		[NullableContext(1)]
		public static string GetLogFilename()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLoggingLibraryLibrary.__GetLogFilename_Internal());
		}

		// Token: 0x060084A9 RID: 33961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCategoryVerbosity_Internal(in FString CategoryName, byte Verbosity);

		// Token: 0x060084AA RID: 33962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLogFilename_Internal();

		// Token: 0x060084AB RID: 33963 RVA: 0x000C4D65 File Offset: 0x000C2F65
		static UKuroLoggingLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroLoggingLibraryLibrary");
		}

		// Token: 0x060084AC RID: 33964 RVA: 0x000C4D73 File Offset: 0x000C2F73
		protected UKuroLoggingLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039F7 RID: 14839
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroLoggingLibraryLibrary";

		// Token: 0x040039F8 RID: 14840
		private static IntPtr _ClassPtr;

		// Token: 0x040039F9 RID: 14841
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
