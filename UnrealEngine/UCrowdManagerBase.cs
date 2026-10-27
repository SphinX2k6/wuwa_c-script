using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002470 RID: 9328
	[UnrealObjectPath("/Script/NavigationSystem.CrowdManagerBase")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UCrowdManagerBase : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022ED1 RID: 143057 RVA: 0x0033A242 File Offset: 0x00338442
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCrowdManagerBase._ClassPtr;
		}

		// Token: 0x06022ED2 RID: 143058 RVA: 0x0033A24E File Offset: 0x0033844E
		static UCrowdManagerBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.CrowdManagerBase");
		}

		// Token: 0x06022ED3 RID: 143059 RVA: 0x0033A25C File Offset: 0x0033845C
		protected UCrowdManagerBase() : this(BuiltinUtils.AllocNativeUObject(UCrowdManagerBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022ED4 RID: 143060 RVA: 0x0033A284 File Offset: 0x00338484
		protected UCrowdManagerBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012A40 RID: 76352
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.CrowdManagerBase";

		// Token: 0x04012A41 RID: 76353
		private static IntPtr _ClassPtr;

		// Token: 0x04012A42 RID: 76354
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
