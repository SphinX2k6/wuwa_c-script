using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200038A RID: 906
	[UnrealObjectPath("/Script/AudioSynesthesia.AudioSynesthesiaNRTSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public abstract class UAudioSynesthesiaNRTSettings : UAudioAnalyzerNRTSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060031F9 RID: 12793 RVA: 0x0004D2F1 File Offset: 0x0004B4F1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioSynesthesiaNRTSettings._ClassPtr;
		}

		// Token: 0x060031FA RID: 12794 RVA: 0x0004D2FD File Offset: 0x0004B4FD
		static UAudioSynesthesiaNRTSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioSynesthesia.AudioSynesthesiaNRTSettings");
		}

		// Token: 0x060031FB RID: 12795 RVA: 0x0004D30C File Offset: 0x0004B50C
		protected UAudioSynesthesiaNRTSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioSynesthesiaNRTSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060031FC RID: 12796 RVA: 0x0004D334 File Offset: 0x0004B534
		protected UAudioSynesthesiaNRTSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040015D4 RID: 5588
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioSynesthesia.AudioSynesthesiaNRTSettings";

		// Token: 0x040015D5 RID: 5589
		private static IntPtr _ClassPtr;

		// Token: 0x040015D6 RID: 5590
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
