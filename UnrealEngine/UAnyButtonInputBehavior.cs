using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001533 RID: 5427
	[UnrealObjectPath("/Script/InteractiveToolsFramework.AnyButtonInputBehavior")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UAnyButtonInputBehavior : UInputBehavior, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013B46 RID: 80710 RVA: 0x001CF049 File Offset: 0x001CD249
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnyButtonInputBehavior._ClassPtr;
		}

		// Token: 0x06013B47 RID: 80711 RVA: 0x001CF058 File Offset: 0x001CD258
		public UAnyButtonInputBehavior() : this(BuiltinUtils.AllocNativeUObject(UAnyButtonInputBehavior.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013B48 RID: 80712 RVA: 0x001CF080 File Offset: 0x001CD280
		[NullableContext(1)]
		public UAnyButtonInputBehavior(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnyButtonInputBehavior.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06013B49 RID: 80713 RVA: 0x001CF0B3 File Offset: 0x001CD2B3
		static UAnyButtonInputBehavior()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.AnyButtonInputBehavior");
		}

		// Token: 0x06013B4A RID: 80714 RVA: 0x001CF0C1 File Offset: 0x001CD2C1
		protected UAnyButtonInputBehavior(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AA8C RID: 43660
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.AnyButtonInputBehavior";

		// Token: 0x0400AA8D RID: 43661
		private static IntPtr _ClassPtr;

		// Token: 0x0400AA8E RID: 43662
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
