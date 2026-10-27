using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000367 RID: 871
	[UnrealObjectPath("/Script/AudioExtensions.OcclusionPluginSourceSettingsBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UOcclusionPluginSourceSettingsBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003029 RID: 12329 RVA: 0x0004AA01 File Offset: 0x00048C01
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UOcclusionPluginSourceSettingsBase._ClassPtr;
		}

		// Token: 0x0600302A RID: 12330 RVA: 0x0004AA0D File Offset: 0x00048C0D
		static UOcclusionPluginSourceSettingsBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioExtensions.OcclusionPluginSourceSettingsBase");
		}

		// Token: 0x0600302B RID: 12331 RVA: 0x0004AA1C File Offset: 0x00048C1C
		protected UOcclusionPluginSourceSettingsBase() : this(BuiltinUtils.AllocNativeUObject(UOcclusionPluginSourceSettingsBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x0004AA44 File Offset: 0x00048C44
		protected UOcclusionPluginSourceSettingsBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040014F1 RID: 5361
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AudioExtensions.OcclusionPluginSourceSettingsBase";

		// Token: 0x040014F2 RID: 5362
		private static IntPtr _ClassPtr;

		// Token: 0x040014F3 RID: 5363
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
