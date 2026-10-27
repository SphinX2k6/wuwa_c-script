using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001581 RID: 5505
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolWithToolTargetsBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInteractiveToolWithToolTargetsBuilder : UInteractiveToolBuilder, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E38 RID: 81464 RVA: 0x001D33E5 File Offset: 0x001D15E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveToolWithToolTargetsBuilder._ClassPtr;
		}

		// Token: 0x06013E39 RID: 81465 RVA: 0x001D33F1 File Offset: 0x001D15F1
		static UInteractiveToolWithToolTargetsBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveToolWithToolTargetsBuilder");
		}

		// Token: 0x06013E3A RID: 81466 RVA: 0x001D3400 File Offset: 0x001D1600
		protected UInteractiveToolWithToolTargetsBuilder() : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolWithToolTargetsBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E3B RID: 81467 RVA: 0x001D3428 File Offset: 0x001D1628
		protected UInteractiveToolWithToolTargetsBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC32 RID: 44082
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolWithToolTargetsBuilder";

		// Token: 0x0400AC33 RID: 44083
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC34 RID: 44084
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
