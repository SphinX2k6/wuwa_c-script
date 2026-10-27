using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200019F RID: 415
	[UnrealObjectPath("/Script/AIModule.EnvQueryItemType")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEnvQueryItemType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019B0 RID: 6576 RVA: 0x0002619E File Offset: 0x0002439E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryItemType._ClassPtr;
		}

		// Token: 0x060019B1 RID: 6577 RVA: 0x000261AA File Offset: 0x000243AA
		static UEnvQueryItemType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryItemType");
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x000261B8 File Offset: 0x000243B8
		protected UEnvQueryItemType() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryItemType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019B3 RID: 6579 RVA: 0x000261E0 File Offset: 0x000243E0
		protected UEnvQueryItemType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000788 RID: 1928
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryItemType";

		// Token: 0x04000789 RID: 1929
		private static IntPtr _ClassPtr;

		// Token: 0x0400078A RID: 1930
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
