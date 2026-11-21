using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000799 RID: 1945
	[UnrealObjectPath("/Script/NavigationSystem.NavigationQueryFilter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public abstract class UNavigationQueryFilter : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A7D6 RID: 42966 RVA: 0x000F7B90 File Offset: 0x000F5D90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationQueryFilter._ClassPtr;
		}

		// Token: 0x0600A7D7 RID: 42967 RVA: 0x000F7B9C File Offset: 0x000F5D9C
		static UNavigationQueryFilter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationQueryFilter");
		}

		// Token: 0x0600A7D8 RID: 42968 RVA: 0x000F7BAC File Offset: 0x000F5DAC
		protected UNavigationQueryFilter() : this(BuiltinUtils.AllocNativeUObject(UNavigationQueryFilter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A7D9 RID: 42969 RVA: 0x000F7BD4 File Offset: 0x000F5DD4
		protected UNavigationQueryFilter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047EE RID: 18414
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationQueryFilter";

		// Token: 0x040047EF RID: 18415
		private static IntPtr _ClassPtr;

		// Token: 0x040047F0 RID: 18416
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
