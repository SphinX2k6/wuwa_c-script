using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001EC RID: 492
	[UnrealObjectPath("/Script/AkAudio.AkAndroidPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkAndroidPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001D10 RID: 7440 RVA: 0x0002B4E7 File Offset: 0x000296E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkAndroidPlatformInfo._ClassPtr;
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x0002B4F4 File Offset: 0x000296F4
		public UAkAndroidPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkAndroidPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001D12 RID: 7442 RVA: 0x0002B51C File Offset: 0x0002971C
		[NullableContext(1)]
		public UAkAndroidPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkAndroidPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001D13 RID: 7443 RVA: 0x0002B54F File Offset: 0x0002974F
		static UAkAndroidPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkAndroidPlatformInfo");
		}

		// Token: 0x06001D14 RID: 7444 RVA: 0x0002B55D File Offset: 0x0002975D
		protected UAkAndroidPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400098C RID: 2444
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkAndroidPlatformInfo";

		// Token: 0x0400098D RID: 2445
		private static IntPtr _ClassPtr;

		// Token: 0x0400098E RID: 2446
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
