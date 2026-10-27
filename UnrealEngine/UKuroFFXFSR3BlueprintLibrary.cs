using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EB8 RID: 7864
	[UnrealObjectPath("/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroFFXFSR3BlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DD87 RID: 122247 RVA: 0x002C26A7 File Offset: 0x002C08A7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFFXFSR3BlueprintLibrary._ClassPtr;
		}

		// Token: 0x0601DD88 RID: 122248 RVA: 0x002C26B4 File Offset: 0x002C08B4
		public UKuroFFXFSR3BlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroFFXFSR3BlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DD89 RID: 122249 RVA: 0x002C26DC File Offset: 0x002C08DC
		[NullableContext(1)]
		public UKuroFFXFSR3BlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFFXFSR3BlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DD8A RID: 122250
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportFSR3();

		// Token: 0x0601DD8B RID: 122251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportFI();

		// Token: 0x0601DD8C RID: 122252
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupported();

		// Token: 0x0601DD8D RID: 122253
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsGlobalSwitchOn();

		// Token: 0x0601DD8E RID: 122254
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDeviceAMD();

		// Token: 0x0601DD8F RID: 122255
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DumpAMDGPUInfos();

		// Token: 0x0601DD90 RID: 122256 RVA: 0x002C270F File Offset: 0x002C090F
		static UKuroFFXFSR3BlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary");
		}

		// Token: 0x0601DD91 RID: 122257 RVA: 0x002C271D File Offset: 0x002C091D
		protected UKuroFFXFSR3BlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102BF RID: 66239
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary";

		// Token: 0x040102C0 RID: 66240
		private static IntPtr _ClassPtr;

		// Token: 0x040102C1 RID: 66241
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
