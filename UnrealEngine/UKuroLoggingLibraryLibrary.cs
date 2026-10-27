using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EBE RID: 7870
	[UnrealObjectPath("/Script/KuroUtility.KuroLoggingLibraryLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroLoggingLibraryLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDDB RID: 122331 RVA: 0x002C2D5E File Offset: 0x002C0F5E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroLoggingLibraryLibrary._ClassPtr;
		}

		// Token: 0x0601DDDC RID: 122332 RVA: 0x002C2D6C File Offset: 0x002C0F6C
		public UKuroLoggingLibraryLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroLoggingLibraryLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDDD RID: 122333 RVA: 0x002C2D94 File Offset: 0x002C0F94
		[NullableContext(1)]
		public UKuroLoggingLibraryLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroLoggingLibraryLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DDDE RID: 122334 RVA: 0x002C2DC8 File Offset: 0x002C0FC8
		[NullableContext(1)]
		public unsafe static void SetCategoryVerbosity(string CategoryName, byte Verbosity)
		{
			FString fstring = FString.AllocTemp(CategoryName);
			UKuroLoggingLibraryLibrary.__SetCategoryVerbosity_Internal(fstring, Verbosity);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601DDDF RID: 122335
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetGlobalLogVerbosity();

		// Token: 0x0601DDE0 RID: 122336
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RegisterTerminateDelegate();

		// Token: 0x0601DDE1 RID: 122337
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void PromoteGlobalLogVerbosity(byte Verbosity);

		// Token: 0x0601DDE2 RID: 122338 RVA: 0x002C2DED File Offset: 0x002C0FED
		[NullableContext(1)]
		public static string GetLogFilename()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroLoggingLibraryLibrary.__GetLogFilename_Internal());
		}

		// Token: 0x0601DDE3 RID: 122339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCategoryVerbosity_Internal(in FString CategoryName, byte Verbosity);

		// Token: 0x0601DDE4 RID: 122340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetLogFilename_Internal();

		// Token: 0x0601DDE5 RID: 122341 RVA: 0x002C2DF9 File Offset: 0x002C0FF9
		static UKuroLoggingLibraryLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroLoggingLibraryLibrary");
		}

		// Token: 0x0601DDE6 RID: 122342 RVA: 0x002C2E07 File Offset: 0x002C1007
		protected UKuroLoggingLibraryLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102E4 RID: 66276
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroLoggingLibraryLibrary";

		// Token: 0x040102E5 RID: 66277
		private static IntPtr _ClassPtr;

		// Token: 0x040102E6 RID: 66278
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
