using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000231 RID: 561
	[UnrealObjectPath("/Script/AkAudio.AkOpenHarmonyPlatformInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkOpenHarmonyPlatformInfo : UAkPlatformInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020DA RID: 8410 RVA: 0x00030E2F File Offset: 0x0002F02F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkOpenHarmonyPlatformInfo._ClassPtr;
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00030E3C File Offset: 0x0002F03C
		public UAkOpenHarmonyPlatformInfo() : this(BuiltinUtils.AllocNativeUObject(UAkOpenHarmonyPlatformInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00030E64 File Offset: 0x0002F064
		[NullableContext(1)]
		public UAkOpenHarmonyPlatformInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkOpenHarmonyPlatformInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x00030E97 File Offset: 0x0002F097
		static UAkOpenHarmonyPlatformInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkOpenHarmonyPlatformInfo");
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00030EA5 File Offset: 0x0002F0A5
		protected UAkOpenHarmonyPlatformInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B11 RID: 2833
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkOpenHarmonyPlatformInfo";

		// Token: 0x04000B12 RID: 2834
		private static IntPtr _ClassPtr;

		// Token: 0x04000B13 RID: 2835
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
