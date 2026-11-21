using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000454 RID: 1108
	[UnrealObjectPath("/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroiOSDelegateStaticLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B0E RID: 27406 RVA: 0x0009BDFD File Offset: 0x00099FFD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroiOSDelegateStaticLibrary._ClassPtr;
		}

		// Token: 0x06006B0F RID: 27407 RVA: 0x0009BE0C File Offset: 0x0009A00C
		public UKuroiOSDelegateStaticLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroiOSDelegateStaticLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B10 RID: 27408 RVA: 0x0009BE34 File Offset: 0x0009A034
		[NullableContext(1)]
		public UKuroiOSDelegateStaticLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroiOSDelegateStaticLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B11 RID: 27409 RVA: 0x0009BE67 File Offset: 0x0009A067
		[SkipLocalsInit]
		public static void DispatchCacheMessage()
		{
			UnrealReflectionUtils.CallUFunction(UKuroiOSDelegateStaticLibrary._ClassDefaultObjectPtr, UKuroiOSDelegateStaticLibrary.__DispatchCacheMessage_NativeFunctionPtr, null);
		}

		// Token: 0x06006B12 RID: 27410 RVA: 0x0009BE7A File Offset: 0x0009A07A
		static UKuroiOSDelegateStaticLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary");
		}

		// Token: 0x06006B13 RID: 27411 RVA: 0x0009BE88 File Offset: 0x0009A088
		protected UKuroiOSDelegateStaticLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D65 RID: 11621
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroiOSDelegate.KuroiOSDelegateStaticLibrary";

		// Token: 0x04002D66 RID: 11622
		private static IntPtr _ClassPtr;

		// Token: 0x04002D67 RID: 11623
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002D68 RID: 11624
		private static IntPtr __DispatchCacheMessage_NativeFunctionPtr;
	}
}
