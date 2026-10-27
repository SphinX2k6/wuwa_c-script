using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000EDF RID: 3807
	[UnrealObjectPath("/Script/Engine.NavigationSystemBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UNavigationSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600CE50 RID: 52816 RVA: 0x0012D13C File Offset: 0x0012B33C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemBase._ClassPtr;
		}

		// Token: 0x0600CE51 RID: 52817 RVA: 0x0012D148 File Offset: 0x0012B348
		static UNavigationSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationSystemBase");
		}

		// Token: 0x0600CE52 RID: 52818 RVA: 0x0012D158 File Offset: 0x0012B358
		protected UNavigationSystemBase() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600CE53 RID: 52819 RVA: 0x0012D180 File Offset: 0x0012B380
		protected UNavigationSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006F3D RID: 28477
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationSystemBase";

		// Token: 0x04006F3E RID: 28478
		private static IntPtr _ClassPtr;

		// Token: 0x04006F3F RID: 28479
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
