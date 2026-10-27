using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002914 RID: 10516
	[UnrealObjectPath("/Script/TimeManagement.GenlockedCustomTimeStep")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F98 RID: 159640 RVA: 0x003B716D File Offset: 0x003B536D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGenlockedCustomTimeStep._ClassPtr;
		}

		// Token: 0x06026F99 RID: 159641 RVA: 0x003B7179 File Offset: 0x003B5379
		static UGenlockedCustomTimeStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TimeManagement.GenlockedCustomTimeStep");
		}

		// Token: 0x06026F9A RID: 159642 RVA: 0x003B7188 File Offset: 0x003B5388
		protected UGenlockedCustomTimeStep() : this(BuiltinUtils.AllocNativeUObject(UGenlockedCustomTimeStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F9B RID: 159643 RVA: 0x003B71B0 File Offset: 0x003B53B0
		protected UGenlockedCustomTimeStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015657 RID: 87639
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TimeManagement.GenlockedCustomTimeStep";

		// Token: 0x04015658 RID: 87640
		private static IntPtr _ClassPtr;

		// Token: 0x04015659 RID: 87641
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
