using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001574 RID: 5492
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveGizmoBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInteractiveGizmoBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013DF0 RID: 81392 RVA: 0x001D2DCF File Offset: 0x001D0FCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveGizmoBuilder._ClassPtr;
		}

		// Token: 0x06013DF1 RID: 81393 RVA: 0x001D2DDB File Offset: 0x001D0FDB
		static UInteractiveGizmoBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveGizmoBuilder");
		}

		// Token: 0x06013DF2 RID: 81394 RVA: 0x001D2DEC File Offset: 0x001D0FEC
		protected UInteractiveGizmoBuilder() : this(BuiltinUtils.AllocNativeUObject(UInteractiveGizmoBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013DF3 RID: 81395 RVA: 0x001D2E14 File Offset: 0x001D1014
		protected UInteractiveGizmoBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC01 RID: 44033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveGizmoBuilder";

		// Token: 0x0400AC02 RID: 44034
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC03 RID: 44035
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
