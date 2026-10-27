using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000217 RID: 535
	[UnrealObjectPath("/Script/AkAudio.AkLinuxArm64PlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkLinuxArm64PlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FC9 RID: 8137 RVA: 0x0002F0E7 File Offset: 0x0002D2E7
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLinuxArm64PlatformInfo._ClassPtr;
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x0002F0F4 File Offset: 0x0002D2F4
		public UAkLinuxArm64PlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkLinuxArm64PlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x0002F11C File Offset: 0x0002D31C
		[NullableContext(1)]
		public UAkLinuxArm64PlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLinuxArm64PlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001FCC RID: 8140 RVA: 0x0002F14F File Offset: 0x0002D34F
		static UAkLinuxArm64PlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLinuxArm64PlatformInfo");
		}

		// Token: 0x06001FCD RID: 8141 RVA: 0x0002F15D File Offset: 0x0002D35D
		protected UAkLinuxArm64PlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A8F RID: 2703
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkLinuxArm64PlatformInfo";

		// Token: 0x04000A90 RID: 2704
		private static IntPtr _ClassPtr;

		// Token: 0x04000A91 RID: 2705
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
