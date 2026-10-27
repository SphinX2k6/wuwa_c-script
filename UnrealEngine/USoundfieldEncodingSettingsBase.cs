using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036B RID: 875
	[UnrealObjectPath("/Script/AudioExtensions.SoundfieldEncodingSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USoundfieldEncodingSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600303B RID: 12347 RVA: 0x0004AB59 File Offset: 0x00048D59
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldEncodingSettingsBase._ClassPtr;
		}

		// Token: 0x0600303C RID: 12348 RVA: 0x0004AB65 File Offset: 0x00048D65
		static USoundfieldEncodingSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SoundfieldEncodingSettingsBase");
		}

		// Token: 0x0600303D RID: 12349 RVA: 0x0004AB74 File Offset: 0x00048D74
		protected USoundfieldEncodingSettingsBase() : this(BuiltinUtils.AllocNativeUObject(USoundfieldEncodingSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600303E RID: 12350 RVA: 0x0004AB9C File Offset: 0x00048D9C
		protected USoundfieldEncodingSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014FE RID: 5374
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SoundfieldEncodingSettingsBase";

		// Token: 0x040014FF RID: 5375
		private static IntPtr _ClassPtr;

		// Token: 0x04001500 RID: 5376
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
