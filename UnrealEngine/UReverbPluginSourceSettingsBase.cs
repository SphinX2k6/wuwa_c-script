using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000368 RID: 872
	[UnrealObjectPath("/Script/AudioExtensions.ReverbPluginSourceSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UReverbPluginSourceSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600302D RID: 12333 RVA: 0x0004AA4D File Offset: 0x00048C4D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UReverbPluginSourceSettingsBase._ClassPtr;
		}

		// Token: 0x0600302E RID: 12334 RVA: 0x0004AA59 File Offset: 0x00048C59
		static UReverbPluginSourceSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.ReverbPluginSourceSettingsBase");
		}

		// Token: 0x0600302F RID: 12335 RVA: 0x0004AA68 File Offset: 0x00048C68
		protected UReverbPluginSourceSettingsBase() : this(BuiltinUtils.AllocNativeUObject(UReverbPluginSourceSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003030 RID: 12336 RVA: 0x0004AA90 File Offset: 0x00048C90
		protected UReverbPluginSourceSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014F4 RID: 5364
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.ReverbPluginSourceSettingsBase";

		// Token: 0x040014F5 RID: 5365
		private static IntPtr _ClassPtr;

		// Token: 0x040014F6 RID: 5366
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
