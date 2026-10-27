using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EBD RID: 7869
	[UnrealObjectPath("/Script/KuroUtility.KuroJsStatsLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroJsStatsLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DDD6 RID: 122326 RVA: 0x002C2CDD File Offset: 0x002C0EDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroJsStatsLibrary._ClassPtr;
		}

		// Token: 0x0601DDD7 RID: 122327 RVA: 0x002C2CEC File Offset: 0x002C0EEC
		public UKuroJsStatsLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroJsStatsLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DDD8 RID: 122328 RVA: 0x002C2D14 File Offset: 0x002C0F14
		[NullableContext(1)]
		public UKuroJsStatsLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroJsStatsLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DDD9 RID: 122329 RVA: 0x002C2D47 File Offset: 0x002C0F47
		static UKuroJsStatsLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroJsStatsLibrary");
		}

		// Token: 0x0601DDDA RID: 122330 RVA: 0x002C2D55 File Offset: 0x002C0F55
		protected UKuroJsStatsLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040102E1 RID: 66273
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroJsStatsLibrary";

		// Token: 0x040102E2 RID: 66274
		private static IntPtr _ClassPtr;

		// Token: 0x040102E3 RID: 66275
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
