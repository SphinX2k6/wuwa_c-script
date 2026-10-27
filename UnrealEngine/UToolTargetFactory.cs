using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200159C RID: 5532
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ToolTargetFactory")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UToolTargetFactory : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013EF1 RID: 81649 RVA: 0x001D4549 File Offset: 0x001D2749
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UToolTargetFactory._ClassPtr;
		}

		// Token: 0x06013EF2 RID: 81650 RVA: 0x001D4555 File Offset: 0x001D2755
		static UToolTargetFactory()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.ToolTargetFactory");
		}

		// Token: 0x06013EF3 RID: 81651 RVA: 0x001D4564 File Offset: 0x001D2764
		protected UToolTargetFactory() : this(BuiltinUtils.AllocNativeUObject(UToolTargetFactory.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013EF4 RID: 81652 RVA: 0x001D458C File Offset: 0x001D278C
		protected UToolTargetFactory(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ACA3 RID: 44195
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.ToolTargetFactory";

		// Token: 0x0400ACA4 RID: 44196
		private static IntPtr _ClassPtr;

		// Token: 0x0400ACA5 RID: 44197
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
