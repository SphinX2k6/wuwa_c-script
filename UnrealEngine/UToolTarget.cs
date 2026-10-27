using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200159B RID: 5531
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ToolTarget")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UToolTarget : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EED RID: 81645 RVA: 0x001D44FE File Offset: 0x001D26FE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToolTarget._ClassPtr;
		}

		// Token: 0x06013EEE RID: 81646 RVA: 0x001D450A File Offset: 0x001D270A
		static UToolTarget()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ToolTarget");
		}

		// Token: 0x06013EEF RID: 81647 RVA: 0x001D4518 File Offset: 0x001D2718
		protected UToolTarget() : this(BuiltinUtils.AllocNativeUObject(UToolTarget.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EF0 RID: 81648 RVA: 0x001D4540 File Offset: 0x001D2740
		protected UToolTarget(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACA0 RID: 44192
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ToolTarget";

		// Token: 0x0400ACA1 RID: 44193
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACA2 RID: 44194
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
