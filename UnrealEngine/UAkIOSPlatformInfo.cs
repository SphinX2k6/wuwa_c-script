using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000210 RID: 528
	[UnrealObjectPath("/Script/AkAudio.AkIOSPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkIOSPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F70 RID: 8048 RVA: 0x0002E889 File Offset: 0x0002CA89
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkIOSPlatformInfo._ClassPtr;
		}

		// Token: 0x06001F71 RID: 8049 RVA: 0x0002E898 File Offset: 0x0002CA98
		public UAkIOSPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkIOSPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F72 RID: 8050 RVA: 0x0002E8C0 File Offset: 0x0002CAC0
		[NullableContext(1)]
		public UAkIOSPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkIOSPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001F73 RID: 8051 RVA: 0x0002E8F3 File Offset: 0x0002CAF3
		static UAkIOSPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkIOSPlatformInfo");
		}

		// Token: 0x06001F74 RID: 8052 RVA: 0x0002E901 File Offset: 0x0002CB01
		protected UAkIOSPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A64 RID: 2660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkIOSPlatformInfo";

		// Token: 0x04000A65 RID: 2661
		private static IntPtr _ClassPtr;

		// Token: 0x04000A66 RID: 2662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
