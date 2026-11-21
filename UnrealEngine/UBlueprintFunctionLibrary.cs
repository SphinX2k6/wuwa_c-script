using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000190 RID: 400
	[UnrealObjectPath("/Script/Engine.BlueprintFunctionLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UBlueprintFunctionLibrary : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001A08 RID: 6664 RVA: 0x0002712A File Offset: 0x0002532A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlueprintFunctionLibrary._ClassPtr;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00027136 File Offset: 0x00025336
		static UBlueprintFunctionLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlueprintFunctionLibrary");
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x00027144 File Offset: 0x00025344
		protected UBlueprintFunctionLibrary() : this(BuiltinUtils.AllocNativeUObject(UBlueprintFunctionLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0002716C File Offset: 0x0002536C
		protected UBlueprintFunctionLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000860 RID: 2144
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.BlueprintFunctionLibrary";

		// Token: 0x04000861 RID: 2145
		private static IntPtr _ClassPtr;

		// Token: 0x04000862 RID: 2146
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
