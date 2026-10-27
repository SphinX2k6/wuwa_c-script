using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001577 RID: 5495
	[UnrealObjectPath("/Script/InteractiveToolsFramework.InteractiveToolBuilder")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UInteractiveToolBuilder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013E08 RID: 81416 RVA: 0x001D302A File Offset: 0x001D122A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInteractiveToolBuilder._ClassPtr;
		}

		// Token: 0x06013E09 RID: 81417 RVA: 0x001D3036 File Offset: 0x001D1236
		static UInteractiveToolBuilder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/InteractiveToolsFramework.InteractiveToolBuilder");
		}

		// Token: 0x06013E0A RID: 81418 RVA: 0x001D3044 File Offset: 0x001D1244
		protected UInteractiveToolBuilder() : this(BuiltinUtils.AllocNativeUObject(UInteractiveToolBuilder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013E0B RID: 81419 RVA: 0x001D306C File Offset: 0x001D126C
		protected UInteractiveToolBuilder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400AC13 RID: 44051
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/InteractiveToolsFramework.InteractiveToolBuilder";

		// Token: 0x0400AC14 RID: 44052
		private static IntPtr _ClassPtr;

		// Token: 0x0400AC15 RID: 44053
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
