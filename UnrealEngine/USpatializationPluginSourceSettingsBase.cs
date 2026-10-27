using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036E RID: 878
	[UnrealObjectPath("/Script/AudioExtensions.SpatializationPluginSourceSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USpatializationPluginSourceSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003047 RID: 12359 RVA: 0x0004AC3D File Offset: 0x00048E3D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USpatializationPluginSourceSettingsBase._ClassPtr;
		}

		// Token: 0x06003048 RID: 12360 RVA: 0x0004AC49 File Offset: 0x00048E49
		static USpatializationPluginSourceSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SpatializationPluginSourceSettingsBase");
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0004AC58 File Offset: 0x00048E58
		protected USpatializationPluginSourceSettingsBase() : this(BuiltinUtils.AllocNativeUObject(USpatializationPluginSourceSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600304A RID: 12362 RVA: 0x0004AC80 File Offset: 0x00048E80
		protected USpatializationPluginSourceSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001507 RID: 5383
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SpatializationPluginSourceSettingsBase";

		// Token: 0x04001508 RID: 5384
		private static IntPtr _ClassPtr;

		// Token: 0x04001509 RID: 5385
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
