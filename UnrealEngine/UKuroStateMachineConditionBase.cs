using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ECE RID: 7886
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineConditionBase")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroStateMachineConditionBase : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601DEA1 RID: 122529 RVA: 0x002C3EA6 File Offset: 0x002C20A6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineConditionBase._ClassPtr;
		}

		// Token: 0x0601DEA2 RID: 122530 RVA: 0x002C3EB4 File Offset: 0x002C20B4
		public UKuroStateMachineConditionBase() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601DEA3 RID: 122531 RVA: 0x002C3EDC File Offset: 0x002C20DC
		[NullableContext(1)]
		public UKuroStateMachineConditionBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineConditionBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0601DEA4 RID: 122532 RVA: 0x002C3F0F File Offset: 0x002C210F
		static UKuroStateMachineConditionBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineConditionBase");
		}

		// Token: 0x0601DEA5 RID: 122533 RVA: 0x002C3F1D File Offset: 0x002C211D
		protected UKuroStateMachineConditionBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010325 RID: 66341
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineConditionBase";

		// Token: 0x04010326 RID: 66342
		private static IntPtr _ClassPtr;

		// Token: 0x04010327 RID: 66343
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
