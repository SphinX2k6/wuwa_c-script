using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002913 RID: 10515
	[UnrealObjectPath("/Script/TimeManagement.FixedFrameRateCustomTimeStep")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UFixedFrameRateCustomTimeStep : UEngineCustomTimeStep, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026F92 RID: 159634 RVA: 0x003B70F6 File Offset: 0x003B52F6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFixedFrameRateCustomTimeStep._ClassPtr;
		}

		// Token: 0x1700960F RID: 38415
		// (get) Token: 0x06026F93 RID: 159635 RVA: 0x003B7102 File Offset: 0x003B5302
		// (set) Token: 0x06026F94 RID: 159636 RVA: 0x003B7116 File Offset: 0x003B5316
		public unsafe FFrameRate FixedFrameRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFixedFrameRateCustomTimeStep.__PropertyOffset_FixedFrameRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFixedFrameRateCustomTimeStep.__PropertyOffset_FixedFrameRate) = value;
			}
		}

		// Token: 0x06026F95 RID: 159637 RVA: 0x003B712B File Offset: 0x003B532B
		static UFixedFrameRateCustomTimeStep()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TimeManagement.FixedFrameRateCustomTimeStep");
		}

		// Token: 0x06026F96 RID: 159638 RVA: 0x003B713C File Offset: 0x003B533C
		protected UFixedFrameRateCustomTimeStep() : this(BuiltinUtils.AllocNativeUObject(UFixedFrameRateCustomTimeStep.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026F97 RID: 159639 RVA: 0x003B7164 File Offset: 0x003B5364
		protected UFixedFrameRateCustomTimeStep(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015653 RID: 87635
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TimeManagement.FixedFrameRateCustomTimeStep";

		// Token: 0x04015654 RID: 87636
		private static IntPtr _ClassPtr;

		// Token: 0x04015655 RID: 87637
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015656 RID: 87638
		internal static int __PropertyOffset_FixedFrameRate;
	}
}
