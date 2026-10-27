using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200109A RID: 4250
	[UnrealObjectPath("/Script/Engine.RoadNetNavigationSystemBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class URoadNetNavigationSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F2E8 RID: 62184 RVA: 0x001684DE File Offset: 0x001666DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationSystemBase._ClassPtr;
		}

		// Token: 0x0600F2E9 RID: 62185 RVA: 0x001684EA File Offset: 0x001666EA
		static URoadNetNavigationSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RoadNetNavigationSystemBase");
		}

		// Token: 0x0600F2EA RID: 62186 RVA: 0x001684F8 File Offset: 0x001666F8
		protected URoadNetNavigationSystemBase() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F2EB RID: 62187 RVA: 0x00168520 File Offset: 0x00166720
		protected URoadNetNavigationSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040083C1 RID: 33729
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RoadNetNavigationSystemBase";

		// Token: 0x040083C2 RID: 33730
		private static IntPtr _ClassPtr;

		// Token: 0x040083C3 RID: 33731
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
