using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005D6 RID: 1494
	[UnrealObjectPath("/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroFFXFSR3BlueprintLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008454 RID: 33876 RVA: 0x000C4743 File Offset: 0x000C2943
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroFFXFSR3BlueprintLibrary._ClassPtr;
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x000C4750 File Offset: 0x000C2950
		public UKuroFFXFSR3BlueprintLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroFFXFSR3BlueprintLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x000C4778 File Offset: 0x000C2978
		[NullableContext(1)]
		public UKuroFFXFSR3BlueprintLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroFFXFSR3BlueprintLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008457 RID: 33879
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportFSR3();

		// Token: 0x06008458 RID: 33880
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool SupportFI();

		// Token: 0x06008459 RID: 33881
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsSupported();

		// Token: 0x0600845A RID: 33882
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsGlobalSwitchOn();

		// Token: 0x0600845B RID: 33883
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsDeviceAMD();

		// Token: 0x0600845C RID: 33884
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void DumpAMDGPUInfos();

		// Token: 0x0600845D RID: 33885 RVA: 0x000C47AB File Offset: 0x000C29AB
		static UKuroFFXFSR3BlueprintLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary");
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x000C47B9 File Offset: 0x000C29B9
		protected UKuroFFXFSR3BlueprintLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040039D5 RID: 14805
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroFFXFSR3BlueprintLibrary";

		// Token: 0x040039D6 RID: 14806
		private static IntPtr _ClassPtr;

		// Token: 0x040039D7 RID: 14807
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
