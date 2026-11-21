using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000852 RID: 2130
	[UnrealObjectPath("/Script/TriggerEffect.KuroTriggerEffect")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UKuroTriggerEffect : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B983 RID: 47491 RVA: 0x00128D46 File Offset: 0x00126F46
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroTriggerEffect._ClassPtr;
		}

		// Token: 0x0600B984 RID: 47492 RVA: 0x00128D54 File Offset: 0x00126F54
		public UKuroTriggerEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B985 RID: 47493 RVA: 0x00128D7C File Offset: 0x00126F7C
		[NullableContext(1)]
		public UKuroTriggerEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroTriggerEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700228E RID: 8846
		// (get) Token: 0x0600B986 RID: 47494 RVA: 0x00128DAF File Offset: 0x00126FAF
		// (set) Token: 0x0600B987 RID: 47495 RVA: 0x00128DBF File Offset: 0x00126FBF
		public unsafe bool bUseEffectForThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_bUseEffectForThreshold) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_bUseEffectForThreshold) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700228F RID: 8847
		// (get) Token: 0x0600B988 RID: 47496 RVA: 0x00128DD0 File Offset: 0x00126FD0
		// (set) Token: 0x0600B989 RID: 47497 RVA: 0x00128DE0 File Offset: 0x00126FE0
		public unsafe byte AnalogThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_AnalogThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroTriggerEffect.__PropertyOffset_AnalogThreshold) = value;
			}
		}

		// Token: 0x0600B98A RID: 47498 RVA: 0x00128DF1 File Offset: 0x00126FF1
		static UKuroTriggerEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/TriggerEffect.KuroTriggerEffect");
		}

		// Token: 0x0600B98B RID: 47499 RVA: 0x00128DFF File Offset: 0x00126FFF
		protected UKuroTriggerEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400543F RID: 21567
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/TriggerEffect.KuroTriggerEffect";

		// Token: 0x04005440 RID: 21568
		private static IntPtr _ClassPtr;

		// Token: 0x04005441 RID: 21569
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005442 RID: 21570
		internal static int __PropertyOffset_bUseEffectForThreshold;

		// Token: 0x04005443 RID: 21571
		internal static int __PropertyOffset_AnalogThreshold;
	}
}
