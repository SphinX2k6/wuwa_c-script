using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025B RID: 603
	[UnrealObjectPath("/Script/AkAudio.AkWinAnvilPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkWinAnvilPlatformInfo : UAkWinGDKPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002368 RID: 9064 RVA: 0x000345EE File Offset: 0x000327EE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWinAnvilPlatformInfo._ClassPtr;
		}

		// Token: 0x06002369 RID: 9065 RVA: 0x000345FC File Offset: 0x000327FC
		public UAkWinAnvilPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkWinAnvilPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600236A RID: 9066 RVA: 0x00034624 File Offset: 0x00032824
		[NullableContext(1)]
		public UAkWinAnvilPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWinAnvilPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600236B RID: 9067 RVA: 0x00034657 File Offset: 0x00032857
		static UAkWinAnvilPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWinAnvilPlatformInfo");
		}

		// Token: 0x0600236C RID: 9068 RVA: 0x00034665 File Offset: 0x00032865
		protected UAkWinAnvilPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C39 RID: 3129
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWinAnvilPlatformInfo";

		// Token: 0x04000C3A RID: 3130
		private static IntPtr _ClassPtr;

		// Token: 0x04000C3B RID: 3131
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
