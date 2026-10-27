using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001997 RID: 6551
	[UnrealObjectPath("/Script/KuroInput.KuroForceFeedbackEffect")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UKuroForceFeedbackEffect : UForceFeedbackEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018551 RID: 99665 RVA: 0x0023E12F File Offset: 0x0023C32F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroForceFeedbackEffect._ClassPtr;
		}

		// Token: 0x06018552 RID: 99666 RVA: 0x0023E13C File Offset: 0x0023C33C
		public UKuroForceFeedbackEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroForceFeedbackEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018553 RID: 99667 RVA: 0x0023E164 File Offset: 0x0023C364
		[NullableContext(1)]
		public UKuroForceFeedbackEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroForceFeedbackEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700611C RID: 24860
		// (get) Token: 0x06018554 RID: 99668 RVA: 0x0023E197 File Offset: 0x0023C397
		// (set) Token: 0x06018555 RID: 99669 RVA: 0x0023E1A7 File Offset: 0x0023C3A7
		public unsafe float ColdDowm
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_ColdDowm);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_ColdDowm) = value;
			}
		}

		// Token: 0x1700611D RID: 24861
		// (get) Token: 0x06018556 RID: 99670 RVA: 0x0023E1B8 File Offset: 0x0023C3B8
		// (set) Token: 0x06018557 RID: 99671 RVA: 0x0023E1C8 File Offset: 0x0023C3C8
		public unsafe EKuroForceFeedbackType Type
		{
			get
			{
				return (EKuroForceFeedbackType)(*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_Type));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_Type) = (byte)value;
			}
		}

		// Token: 0x1700611E RID: 24862
		// (get) Token: 0x06018558 RID: 99672 RVA: 0x0023E1D9 File Offset: 0x0023C3D9
		// (set) Token: 0x06018559 RID: 99673 RVA: 0x0023E1E9 File Offset: 0x0023C3E9
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x1700611F RID: 24863
		// (get) Token: 0x0601855A RID: 99674 RVA: 0x0023E1FA File Offset: 0x0023C3FA
		// (set) Token: 0x0601855B RID: 99675 RVA: 0x0023E20E File Offset: 0x0023C40E
		public unsafe FGuid KuroGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_KuroGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_KuroGuid) = value;
			}
		}

		// Token: 0x0601855C RID: 99676 RVA: 0x0023E223 File Offset: 0x0023C423
		static UKuroForceFeedbackEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.KuroForceFeedbackEffect");
		}

		// Token: 0x0601855D RID: 99677 RVA: 0x0023E231 File Offset: 0x0023C431
		protected UKuroForceFeedbackEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D295 RID: 53909
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.KuroForceFeedbackEffect";

		// Token: 0x0400D296 RID: 53910
		private static IntPtr _ClassPtr;

		// Token: 0x0400D297 RID: 53911
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400D298 RID: 53912
		internal static int __PropertyOffset_ColdDowm;

		// Token: 0x0400D299 RID: 53913
		internal static int __PropertyOffset_Type;

		// Token: 0x0400D29A RID: 53914
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400D29B RID: 53915
		internal static int __PropertyOffset_KuroGuid;
	}
}
