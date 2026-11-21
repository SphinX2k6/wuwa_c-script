using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000119 RID: 281
	[UnrealObjectPath("/Script/CoreUObject.Interface")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInterface : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600118B RID: 4491 RVA: 0x0001BC62 File Offset: 0x00019E62
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterface._ClassPtr;
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x0001BC6E File Offset: 0x00019E6E
		static UInterface()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/CoreUObject.Interface");
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x0001BC7C File Offset: 0x00019E7C
		protected UInterface() : this(BuiltinUtils.AllocNativeUObject(UInterface.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x0001BCA4 File Offset: 0x00019EA4
		protected UInterface(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000516 RID: 1302
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/CoreUObject.Interface";

		// Token: 0x04000517 RID: 1303
		private static IntPtr _ClassPtr;

		// Token: 0x04000518 RID: 1304
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
