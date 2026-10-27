using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C4A RID: 3146
	[UnrealObjectPath("/Script/Engine.Info")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public abstract class AInfo : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009F8F RID: 40847 RVA: 0x000E2B4B File Offset: 0x000E0D4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AInfo._ClassPtr;
		}

		// Token: 0x06009F90 RID: 40848 RVA: 0x000E2B57 File Offset: 0x000E0D57
		static AInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.Info");
		}

		// Token: 0x06009F91 RID: 40849 RVA: 0x000E2B68 File Offset: 0x000E0D68
		protected AInfo() : this(BuiltinUtils.AllocNativeUObject(AInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009F92 RID: 40850 RVA: 0x000E2B90 File Offset: 0x000E0D90
		protected AInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040057C9 RID: 22473
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.Info";

		// Token: 0x040057CA RID: 22474
		private static IntPtr _ClassPtr;

		// Token: 0x040057CB RID: 22475
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
