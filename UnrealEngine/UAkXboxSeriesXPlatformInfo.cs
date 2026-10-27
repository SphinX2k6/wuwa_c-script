using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000267 RID: 615
	[UnrealObjectPath("/Script/AkAudio.AkXboxSeriesXPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkXboxSeriesXPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060023E8 RID: 9192 RVA: 0x000353FB File Offset: 0x000335FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkXboxSeriesXPlatformInfo._ClassPtr;
		}

		// Token: 0x060023E9 RID: 9193 RVA: 0x00035408 File Offset: 0x00033608
		public UAkXboxSeriesXPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkXboxSeriesXPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060023EA RID: 9194 RVA: 0x00035430 File Offset: 0x00033630
		[NullableContext(1)]
		public UAkXboxSeriesXPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkXboxSeriesXPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060023EB RID: 9195 RVA: 0x00035463 File Offset: 0x00033663
		static UAkXboxSeriesXPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkXboxSeriesXPlatformInfo");
		}

		// Token: 0x060023EC RID: 9196 RVA: 0x00035471 File Offset: 0x00033671
		protected UAkXboxSeriesXPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000C7D RID: 3197
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkXboxSeriesXPlatformInfo";

		// Token: 0x04000C7E RID: 3198
		private static IntPtr _ClassPtr;

		// Token: 0x04000C7F RID: 3199
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
