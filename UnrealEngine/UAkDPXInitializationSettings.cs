using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001FF RID: 511
	[UnrealObjectPath("/Script/AkAudio.AkDPXInitializationSettings")]
	[UnrealStructLayout(296, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 296)]
	public class UAkDPXInitializationSettings : UAkPS5InitializationSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001E23 RID: 7715 RVA: 0x0002CB0E File Offset: 0x0002AD0E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkDPXInitializationSettings._ClassPtr;
		}

		// Token: 0x06001E24 RID: 7716 RVA: 0x0002CB1C File Offset: 0x0002AD1C
		public UAkDPXInitializationSettings() : this(BuiltinUtils.AllocNativeUObject(UAkDPXInitializationSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001E25 RID: 7717 RVA: 0x0002CB44 File Offset: 0x0002AD44
		[NullableContext(1)]
		public UAkDPXInitializationSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkDPXInitializationSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0002CB77 File Offset: 0x0002AD77
		static UAkDPXInitializationSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkDPXInitializationSettings");
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0002CB85 File Offset: 0x0002AD85
		protected UAkDPXInitializationSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040009F9 RID: 2553
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkDPXInitializationSettings";

		// Token: 0x040009FA RID: 2554
		private static IntPtr _ClassPtr;

		// Token: 0x040009FB RID: 2555
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
