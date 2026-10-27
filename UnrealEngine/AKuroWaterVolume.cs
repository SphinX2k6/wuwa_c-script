using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDC RID: 7900
	[UnrealObjectPath("/Script/KuroUtility.KuroWaterVolume")]
	[UnrealStructLayout(1168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1168)]
	public class AKuroWaterVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E0B2 RID: 123058 RVA: 0x002C95ED File Offset: 0x002C77ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWaterVolume._ClassPtr;
		}

		// Token: 0x0601E0B3 RID: 123059 RVA: 0x002C95FC File Offset: 0x002C77FC
		public AKuroWaterVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroWaterVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0B4 RID: 123060 RVA: 0x002C9624 File Offset: 0x002C7824
		[NullableContext(1)]
		public AKuroWaterVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWaterVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601E0B5 RID: 123061 RVA: 0x002C9657 File Offset: 0x002C7857
		static AKuroWaterVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroWaterVolume");
		}

		// Token: 0x0601E0B6 RID: 123062 RVA: 0x002C9665 File Offset: 0x002C7865
		protected AKuroWaterVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103EE RID: 66542
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroWaterVolume";

		// Token: 0x040103EF RID: 66543
		private static IntPtr _ClassPtr;

		// Token: 0x040103F0 RID: 66544
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
