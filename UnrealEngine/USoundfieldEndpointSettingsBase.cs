using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036C RID: 876
	[UnrealObjectPath("/Script/AudioExtensions.SoundfieldEndpointSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USoundfieldEndpointSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600303F RID: 12351 RVA: 0x0004ABA5 File Offset: 0x00048DA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldEndpointSettingsBase._ClassPtr;
		}

		// Token: 0x06003040 RID: 12352 RVA: 0x0004ABB1 File Offset: 0x00048DB1
		static USoundfieldEndpointSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SoundfieldEndpointSettingsBase");
		}

		// Token: 0x06003041 RID: 12353 RVA: 0x0004ABC0 File Offset: 0x00048DC0
		protected USoundfieldEndpointSettingsBase() : this(BuiltinUtils.AllocNativeUObject(USoundfieldEndpointSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003042 RID: 12354 RVA: 0x0004ABE8 File Offset: 0x00048DE8
		protected USoundfieldEndpointSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001501 RID: 5377
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SoundfieldEndpointSettingsBase";

		// Token: 0x04001502 RID: 5378
		private static IntPtr _ClassPtr;

		// Token: 0x04001503 RID: 5379
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
