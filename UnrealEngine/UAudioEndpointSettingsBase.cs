using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000366 RID: 870
	[UnrealObjectPath("/Script/AudioExtensions.AudioEndpointSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAudioEndpointSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003025 RID: 12325 RVA: 0x0004A9B5 File Offset: 0x00048BB5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioEndpointSettingsBase._ClassPtr;
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x0004A9C1 File Offset: 0x00048BC1
		static UAudioEndpointSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.AudioEndpointSettingsBase");
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x0004A9D0 File Offset: 0x00048BD0
		protected UAudioEndpointSettingsBase() : this(BuiltinUtils.AllocNativeUObject(UAudioEndpointSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x0004A9F8 File Offset: 0x00048BF8
		protected UAudioEndpointSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014EE RID: 5358
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.AudioEndpointSettingsBase";

		// Token: 0x040014EF RID: 5359
		private static IntPtr _ClassPtr;

		// Token: 0x040014F0 RID: 5360
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
