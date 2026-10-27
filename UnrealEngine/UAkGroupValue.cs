using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200020C RID: 524
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkGroupValue")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public abstract class UAkGroupValue : UAkAudioType, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06001F48 RID: 8008 RVA: 0x0002E37A File Offset: 0x0002C57A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkGroupValue._ClassPtr;
		}

		// Token: 0x170007B0 RID: 1968
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x0002E388 File Offset: 0x0002C588
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x0002E3C1 File Offset: 0x0002C5C1
		public FWwiseGroupValueCookedData GroupValueCookedData
		{
			get
			{
				base.FastCheckIsValid();
				FWwiseGroupValueCookedData result;
				if ((result = this._GroupValueCookedData) == null)
				{
					result = (this._GroupValueCookedData = new FWwiseGroupValueCookedData(base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupValueCookedData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWwiseGroupValueCookedData.StaticStruct(), base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupValueCookedData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x0002E3E2 File Offset: 0x0002C5E2
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x0002E3F2 File Offset: 0x0002C5F2
		public unsafe uint GroupShortID_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupShortID_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkGroupValue.__PropertyOffset_GroupShortID_DEPRECATED) = (int)value;
			}
		}

		// Token: 0x06001F4D RID: 8013 RVA: 0x0002E403 File Offset: 0x0002C603
		static UAkGroupValue()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkGroupValue");
		}

		// Token: 0x06001F4E RID: 8014 RVA: 0x0002E414 File Offset: 0x0002C614
		protected UAkGroupValue() : this(BuiltinUtils.AllocNativeUObject(UAkGroupValue.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001F4F RID: 8015 RVA: 0x0002E43C File Offset: 0x0002C63C
		protected UAkGroupValue(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000A4A RID: 2634
		public new const string __ObjectPath = "/Script/AkAudio.AkGroupValue";

		// Token: 0x04000A4B RID: 2635
		private static IntPtr _ClassPtr;

		// Token: 0x04000A4C RID: 2636
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000A4D RID: 2637
		internal static int __PropertyOffset_GroupValueCookedData;

		// Token: 0x04000A4E RID: 2638
		[Nullable(2)]
		private FWwiseGroupValueCookedData _GroupValueCookedData;

		// Token: 0x04000A4F RID: 2639
		internal static int __PropertyOffset_GroupShortID_DEPRECATED;
	}
}
