using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025E RID: 606
	[UnrealObjectPath("/Script/AkAudio.AkWindowsPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkWindowsPlatformInfo : UAkWin64PlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002386 RID: 9094 RVA: 0x00034987 File Offset: 0x00032B87
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkWindowsPlatformInfo._ClassPtr;
		}

		// Token: 0x06002387 RID: 9095 RVA: 0x00034994 File Offset: 0x00032B94
		public UAkWindowsPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkWindowsPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002388 RID: 9096 RVA: 0x000349BC File Offset: 0x00032BBC
		[NullableContext(1)]
		public UAkWindowsPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkWindowsPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002389 RID: 9097 RVA: 0x000349EF File Offset: 0x00032BEF
		static UAkWindowsPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkWindowsPlatformInfo");
		}

		// Token: 0x0600238A RID: 9098 RVA: 0x000349FD File Offset: 0x00032BFD
		protected UAkWindowsPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C49 RID: 3145
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkWindowsPlatformInfo";

		// Token: 0x04000C4A RID: 3146
		private static IntPtr _ClassPtr;

		// Token: 0x04000C4B RID: 3147
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
