using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005E4 RID: 1508
	[UnrealObjectPath("/Script/KuroUtility.KuroStateMachineGroup")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroStateMachineGroup : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008532 RID: 34098 RVA: 0x000C5872 File Offset: 0x000C3A72
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStateMachineGroup._ClassPtr;
		}

		// Token: 0x06008533 RID: 34099 RVA: 0x000C5880 File Offset: 0x000C3A80
		public UKuroStateMachineGroup() : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineGroup.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008534 RID: 34100 RVA: 0x000C58A8 File Offset: 0x000C3AA8
		[NullableContext(1)]
		public UKuroStateMachineGroup(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroStateMachineGroup.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06008535 RID: 34101 RVA: 0x000C58DB File Offset: 0x000C3ADB
		static UKuroStateMachineGroup()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroStateMachineGroup");
		}

		// Token: 0x06008536 RID: 34102 RVA: 0x000C58E9 File Offset: 0x000C3AE9
		protected UKuroStateMachineGroup(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A1C RID: 14876
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroStateMachineGroup";

		// Token: 0x04003A1D RID: 14877
		private static IntPtr _ClassPtr;

		// Token: 0x04003A1E RID: 14878
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
