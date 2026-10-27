using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000250 RID: 592
	[UnrealObjectPath("/Script/AkAudio.AkTVOSPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkTVOSPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060022F1 RID: 8945 RVA: 0x00033C61 File Offset: 0x00031E61
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkTVOSPlatformInfo._ClassPtr;
		}

		// Token: 0x060022F2 RID: 8946 RVA: 0x00033C70 File Offset: 0x00031E70
		public UAkTVOSPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkTVOSPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060022F3 RID: 8947 RVA: 0x00033C98 File Offset: 0x00031E98
		[NullableContext(1)]
		public UAkTVOSPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkTVOSPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060022F4 RID: 8948 RVA: 0x00033CCB File Offset: 0x00031ECB
		static UAkTVOSPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkTVOSPlatformInfo");
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00033CD9 File Offset: 0x00031ED9
		protected UAkTVOSPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C1A RID: 3098
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkTVOSPlatformInfo";

		// Token: 0x04000C1B RID: 3099
		private static IntPtr _ClassPtr;

		// Token: 0x04000C1C RID: 3100
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
