using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200036A RID: 874
	[UnrealObjectPath("/Script/AudioExtensions.SoundfieldEffectSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class USoundfieldEffectSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003037 RID: 12343 RVA: 0x0004AB0D File Offset: 0x00048D0D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldEffectSettingsBase._ClassPtr;
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0004AB19 File Offset: 0x00048D19
		static USoundfieldEffectSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.SoundfieldEffectSettingsBase");
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0004AB28 File Offset: 0x00048D28
		protected USoundfieldEffectSettingsBase() : this(BuiltinUtils.AllocNativeUObject(USoundfieldEffectSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x0004AB50 File Offset: 0x00048D50
		protected USoundfieldEffectSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014FB RID: 5371
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.SoundfieldEffectSettingsBase";

		// Token: 0x040014FC RID: 5372
		private static IntPtr _ClassPtr;

		// Token: 0x040014FD RID: 5373
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
