using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000248 RID: 584
	[UnrealObjectPath("/Script/Engine.NavigationSystemBase")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UNavigationSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003278 RID: 12920 RVA: 0x00048011 File Offset: 0x00046211
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationSystemBase._ClassPtr;
		}

		// Token: 0x06003279 RID: 12921 RVA: 0x0004801D File Offset: 0x0004621D
		static UNavigationSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.NavigationSystemBase");
		}

		// Token: 0x0600327A RID: 12922 RVA: 0x0004802C File Offset: 0x0004622C
		protected UNavigationSystemBase() : this(BuiltinUtils.AllocNativeUObject(UNavigationSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600327B RID: 12923 RVA: 0x00048054 File Offset: 0x00046254
		protected UNavigationSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001197 RID: 4503
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.NavigationSystemBase";

		// Token: 0x04001198 RID: 4504
		private static IntPtr _ClassPtr;

		// Token: 0x04001199 RID: 4505
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
