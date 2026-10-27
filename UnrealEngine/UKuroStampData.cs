using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC7 RID: 7111
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroStampData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public abstract class UKuroStampData : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B490 RID: 111760 RVA: 0x002834ED File Offset: 0x002816ED
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroStampData._ClassPtr;
		}

		// Token: 0x0601B491 RID: 111761 RVA: 0x002834F9 File Offset: 0x002816F9
		static UKuroStampData()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroStampData");
		}

		// Token: 0x0601B492 RID: 111762 RVA: 0x00283508 File Offset: 0x00281708
		protected UKuroStampData() : this(BuiltinUtils.AllocNativeUObject(UKuroStampData.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B493 RID: 111763 RVA: 0x00283530 File Offset: 0x00281730
		protected UKuroStampData(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EB1C RID: 60188
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroStampData";

		// Token: 0x0400EB1D RID: 60189
		private static IntPtr _ClassPtr;

		// Token: 0x0400EB1E RID: 60190
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
