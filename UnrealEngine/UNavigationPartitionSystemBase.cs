using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EDD RID: 3805
	[UnrealObjectPath("/Script/Engine.NavigationPartitionSystemBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNavigationPartitionSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE3C RID: 52796 RVA: 0x0012CEB1 File Offset: 0x0012B0B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPartitionSystemBase._ClassPtr;
		}

		// Token: 0x0600CE3D RID: 52797 RVA: 0x0012CEBD File Offset: 0x0012B0BD
		static UNavigationPartitionSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationPartitionSystemBase");
		}

		// Token: 0x0600CE3E RID: 52798 RVA: 0x0012CECC File Offset: 0x0012B0CC
		protected UNavigationPartitionSystemBase() : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE3F RID: 52799 RVA: 0x0012CEF4 File Offset: 0x0012B0F4
		protected UNavigationPartitionSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F34 RID: 28468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationPartitionSystemBase";

		// Token: 0x04006F35 RID: 28469
		private static IntPtr _ClassPtr;

		// Token: 0x04006F36 RID: 28470
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
