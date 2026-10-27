using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000259 RID: 601
	[UnrealObjectPath("/Script/AkAudio.AkWin64PlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkWin64PlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600235E RID: 9054 RVA: 0x000344EE File Offset: 0x000326EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWin64PlatformInfo._ClassPtr;
		}

		// Token: 0x0600235F RID: 9055 RVA: 0x000344FC File Offset: 0x000326FC
		public UAkWin64PlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkWin64PlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002360 RID: 9056 RVA: 0x00034524 File Offset: 0x00032724
		[NullableContext(1)]
		public UAkWin64PlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWin64PlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002361 RID: 9057 RVA: 0x00034557 File Offset: 0x00032757
		static UAkWin64PlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWin64PlatformInfo");
		}

		// Token: 0x06002362 RID: 9058 RVA: 0x00034565 File Offset: 0x00032765
		protected UAkWin64PlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C33 RID: 3123
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWin64PlatformInfo";

		// Token: 0x04000C34 RID: 3124
		private static IntPtr _ClassPtr;

		// Token: 0x04000C35 RID: 3125
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
