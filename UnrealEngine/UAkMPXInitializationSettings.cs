using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022B RID: 555
	[UnrealObjectPath("/Script/AkAudio.AkMPXInitializationSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAkMPXInitializationSettings : UAkXboxSeriesXInitializationSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600209B RID: 8347 RVA: 0x000306C4 File Offset: 0x0002E8C4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMPXInitializationSettings._ClassPtr;
		}

		// Token: 0x0600209C RID: 8348 RVA: 0x000306D0 File Offset: 0x0002E8D0
		public UAkMPXInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkMPXInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x000306F8 File Offset: 0x0002E8F8
		[NullableContext(1)]
		public UAkMPXInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMPXInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x0003072B File Offset: 0x0002E92B
		static UAkMPXInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMPXInitializationSettings");
		}

		// Token: 0x0600209F RID: 8351 RVA: 0x00030739 File Offset: 0x0002E939
		protected UAkMPXInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AF3 RID: 2803
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkMPXInitializationSettings";

		// Token: 0x04000AF4 RID: 2804
		private static IntPtr _ClassPtr;

		// Token: 0x04000AF5 RID: 2805
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
