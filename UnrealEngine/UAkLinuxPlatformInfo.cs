using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000219 RID: 537
	[UnrealObjectPath("/Script/AkAudio.AkLinuxPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkLinuxPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001FDB RID: 8155 RVA: 0x0002F307 File Offset: 0x0002D507
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkLinuxPlatformInfo._ClassPtr;
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0002F314 File Offset: 0x0002D514
		public UAkLinuxPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkLinuxPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0002F33C File Offset: 0x0002D53C
		[NullableContext(1)]
		public UAkLinuxPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkLinuxPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0002F36F File Offset: 0x0002D56F
		static UAkLinuxPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkLinuxPlatformInfo");
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0002F37D File Offset: 0x0002D57D
		protected UAkLinuxPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A9B RID: 2715
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkLinuxPlatformInfo";

		// Token: 0x04000A9C RID: 2716
		private static IntPtr _ClassPtr;

		// Token: 0x04000A9D RID: 2717
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
