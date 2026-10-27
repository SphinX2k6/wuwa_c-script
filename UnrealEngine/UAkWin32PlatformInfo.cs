using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000258 RID: 600
	[UnrealObjectPath("/Script/AkAudio.AkWin32PlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkWin32PlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002359 RID: 9049 RVA: 0x0003446F File Offset: 0x0003266F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWin32PlatformInfo._ClassPtr;
		}

		// Token: 0x0600235A RID: 9050 RVA: 0x0003447C File Offset: 0x0003267C
		public UAkWin32PlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkWin32PlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600235B RID: 9051 RVA: 0x000344A4 File Offset: 0x000326A4
		[NullableContext(1)]
		public UAkWin32PlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWin32PlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600235C RID: 9052 RVA: 0x000344D7 File Offset: 0x000326D7
		static UAkWin32PlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWin32PlatformInfo");
		}

		// Token: 0x0600235D RID: 9053 RVA: 0x000344E5 File Offset: 0x000326E5
		protected UAkWin32PlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C30 RID: 3120
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWin32PlatformInfo";

		// Token: 0x04000C31 RID: 3121
		private static IntPtr _ClassPtr;

		// Token: 0x04000C32 RID: 3122
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
