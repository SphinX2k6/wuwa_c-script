using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002492 RID: 9362
	[UnrealObjectPath("/Script/NavigationSystem.NavigationPartitionPathBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UNavigationPartitionPathBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602302C RID: 143404 RVA: 0x0033C43C File Offset: 0x0033A63C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPartitionPathBase._ClassPtr;
		}

		// Token: 0x0602302D RID: 143405 RVA: 0x0033C448 File Offset: 0x0033A648
		static UNavigationPartitionPathBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationPartitionPathBase");
		}

		// Token: 0x0602302E RID: 143406 RVA: 0x0033C458 File Offset: 0x0033A658
		protected UNavigationPartitionPathBase() : this(BuiltinUtils.AllocNativeUObject(UNavigationPartitionPathBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602302F RID: 143407 RVA: 0x0033C480 File Offset: 0x0033A680
		protected UNavigationPartitionPathBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012B19 RID: 76569
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationPartitionPathBase";

		// Token: 0x04012B1A RID: 76570
		private static IntPtr _ClassPtr;

		// Token: 0x04012B1B RID: 76571
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
