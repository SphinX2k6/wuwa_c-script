using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001EDA RID: 7898
	[UnrealObjectPath("/Script/KuroUtility.KuroTriggerVolume")]
	[UnrealStructLayout(1120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1120)]
	public class AKuroTriggerVolume : AVolume, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E09E RID: 123038 RVA: 0x002C93B1 File Offset: 0x002C75B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroTriggerVolume._ClassPtr;
		}

		// Token: 0x0601E09F RID: 123039 RVA: 0x002C93C0 File Offset: 0x002C75C0
		public AKuroTriggerVolume() : this(BuiltinUtils.AllocNativeUObject(AKuroTriggerVolume.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E0A0 RID: 123040 RVA: 0x002C93E8 File Offset: 0x002C75E8
		[NullableContext(1)]
		public AKuroTriggerVolume(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroTriggerVolume.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170077BB RID: 30651
		// (get) Token: 0x0601E0A1 RID: 123041 RVA: 0x002C941B File Offset: 0x002C761B
		// (set) Token: 0x0601E0A2 RID: 123042 RVA: 0x002C942F File Offset: 0x002C762F
		public unsafe FName VolumeId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroTriggerVolume.__PropertyOffset_VolumeId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroTriggerVolume.__PropertyOffset_VolumeId) = value;
			}
		}

		// Token: 0x0601E0A3 RID: 123043 RVA: 0x002C9444 File Offset: 0x002C7644
		static AKuroTriggerVolume()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroUtility.KuroTriggerVolume");
		}

		// Token: 0x0601E0A4 RID: 123044 RVA: 0x002C9452 File Offset: 0x002C7652
		protected AKuroTriggerVolume(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040103E1 RID: 66529
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroUtility.KuroTriggerVolume";

		// Token: 0x040103E2 RID: 66530
		private static IntPtr _ClassPtr;

		// Token: 0x040103E3 RID: 66531
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040103E4 RID: 66532
		internal static int __PropertyOffset_VolumeId;
	}
}
