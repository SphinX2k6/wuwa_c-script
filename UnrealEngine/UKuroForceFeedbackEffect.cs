using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200044B RID: 1099
	[UnrealObjectPath("/Script/KuroInput.KuroForceFeedbackEffect")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UKuroForceFeedbackEffect : UForceFeedbackEffect, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006A05 RID: 27141 RVA: 0x0009AA6D File Offset: 0x00098C6D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroForceFeedbackEffect._ClassPtr;
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x0009AA7C File Offset: 0x00098C7C
		public UKuroForceFeedbackEffect() : this(BuiltinUtils.AllocNativeUObject(UKuroForceFeedbackEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0009AAA4 File Offset: 0x00098CA4
		[NullableContext(1)]
		public UKuroForceFeedbackEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroForceFeedbackEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700150E RID: 5390
		// (get) Token: 0x06006A08 RID: 27144 RVA: 0x0009AAD7 File Offset: 0x00098CD7
		// (set) Token: 0x06006A09 RID: 27145 RVA: 0x0009AAE7 File Offset: 0x00098CE7
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

		// Token: 0x1700150F RID: 5391
		// (get) Token: 0x06006A0A RID: 27146 RVA: 0x0009AAF8 File Offset: 0x00098CF8
		// (set) Token: 0x06006A0B RID: 27147 RVA: 0x0009AB08 File Offset: 0x00098D08
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

		// Token: 0x17001510 RID: 5392
		// (get) Token: 0x06006A0C RID: 27148 RVA: 0x0009AB19 File Offset: 0x00098D19
		// (set) Token: 0x06006A0D RID: 27149 RVA: 0x0009AB2D File Offset: 0x00098D2D
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

		// Token: 0x17001511 RID: 5393
		// (get) Token: 0x06006A0E RID: 27150 RVA: 0x0009AB42 File Offset: 0x00098D42
		// (set) Token: 0x06006A0F RID: 27151 RVA: 0x0009AB52 File Offset: 0x00098D52
		public unsafe bool bUseCurveSynthHaptic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_bUseCurveSynthHaptic) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroForceFeedbackEffect.__PropertyOffset_bUseCurveSynthHaptic) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x0009AB63 File Offset: 0x00098D63
		static UKuroForceFeedbackEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroInput.KuroForceFeedbackEffect");
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x0009AB71 File Offset: 0x00098D71
		protected UKuroForceFeedbackEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002D01 RID: 11521
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroInput.KuroForceFeedbackEffect";

		// Token: 0x04002D02 RID: 11522
		private static IntPtr _ClassPtr;

		// Token: 0x04002D03 RID: 11523
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04002D04 RID: 11524
		internal static int __PropertyOffset_ColdDowm;

		// Token: 0x04002D05 RID: 11525
		internal static int __PropertyOffset_Priority;

		// Token: 0x04002D06 RID: 11526
		internal static int __PropertyOffset_KuroGuid;

		// Token: 0x04002D07 RID: 11527
		internal static int __PropertyOffset_bUseCurveSynthHaptic;
	}
}
