using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000234 RID: 564
	[UnrealObjectPath("/Script/AkAudio.AkPlatformInitializationSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UAkPlatformInitializationSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020F4 RID: 8436 RVA: 0x0003103E File Offset: 0x0002F23E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkPlatformInitializationSettingsBase._ClassPtr;
		}

		// Token: 0x060020F5 RID: 8437 RVA: 0x0003104A File Offset: 0x0002F24A
		static UAkPlatformInitializationSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkPlatformInitializationSettingsBase");
		}

		// Token: 0x060020F6 RID: 8438 RVA: 0x00031058 File Offset: 0x0002F258
		protected UAkPlatformInitializationSettingsBase() : this(BuiltinUtils.AllocNativeUObject(UAkPlatformInitializationSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020F7 RID: 8439 RVA: 0x00031080 File Offset: 0x0002F280
		protected UAkPlatformInitializationSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000B1D RID: 2845
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.AkPlatformInitializationSettingsBase";

		// Token: 0x04000B1E RID: 2846
		private static IntPtr _ClassPtr;

		// Token: 0x04000B1F RID: 2847
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
