using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000274 RID: 628
	[UnrealObjectPath("/Script/Engine.RoadNetNavigationSystemBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class URoadNetNavigationSystemBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004046 RID: 16454 RVA: 0x0005C4B1 File Offset: 0x0005A6B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetNavigationSystemBase._ClassPtr;
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0005C4BD File Offset: 0x0005A6BD
		static URoadNetNavigationSystemBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RoadNetNavigationSystemBase");
		}

		// Token: 0x06004048 RID: 16456 RVA: 0x0005C4CC File Offset: 0x0005A6CC
		protected URoadNetNavigationSystemBase() : this(BuiltinUtils.AllocNativeUObject(URoadNetNavigationSystemBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0005C4F4 File Offset: 0x0005A6F4
		protected URoadNetNavigationSystemBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400192E RID: 6446
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RoadNetNavigationSystemBase";

		// Token: 0x0400192F RID: 6447
		private static IntPtr _ClassPtr;

		// Token: 0x04001930 RID: 6448
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
