using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000101 RID: 257
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Hearing")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UAISenseConfig_Hearing : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600138F RID: 5007 RVA: 0x0001CDCF File Offset: 0x0001AFCF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Hearing._ClassPtr;
		}

		// Token: 0x06001390 RID: 5008 RVA: 0x0001CDDC File Offset: 0x0001AFDC
		public UAISenseConfig_Hearing() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Hearing.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06001391 RID: 5009 RVA: 0x0001CE04 File Offset: 0x0001B004
		[NullableContext(1)]
		public UAISenseConfig_Hearing(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Hearing.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x06001392 RID: 5010 RVA: 0x0001CE37 File Offset: 0x0001B037
		// (set) Token: 0x06001393 RID: 5011 RVA: 0x0001CE4B File Offset: 0x0001B04B
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAISense_Hearing> Implementation
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_Implementation);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_Implementation) = value;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x06001394 RID: 5012 RVA: 0x0001CE60 File Offset: 0x0001B060
		// (set) Token: 0x06001395 RID: 5013 RVA: 0x0001CE70 File Offset: 0x0001B070
		public unsafe float HearingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_HearingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_HearingRange) = value;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06001396 RID: 5014 RVA: 0x0001CE81 File Offset: 0x0001B081
		// (set) Token: 0x06001397 RID: 5015 RVA: 0x0001CE91 File Offset: 0x0001B091
		public unsafe float LoSHearingRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_LoSHearingRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_LoSHearingRange) = value;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06001398 RID: 5016 RVA: 0x0001CEA2 File Offset: 0x0001B0A2
		// (set) Token: 0x06001399 RID: 5017 RVA: 0x0001CEBB File Offset: 0x0001B0BB
		public unsafe bool bUseLoSHearing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_bUseLoSHearing) & UAISenseConfig_Hearing.__PropertyMask_bUseLoSHearing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_bUseLoSHearing) = ((*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_bUseLoSHearing) & ~UAISenseConfig_Hearing.__PropertyMask_bUseLoSHearing) | (value ? UAISenseConfig_Hearing.__PropertyMask_bUseLoSHearing : 0));
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x0600139A RID: 5018 RVA: 0x0001CEEB File Offset: 0x0001B0EB
		// (set) Token: 0x0600139B RID: 5019 RVA: 0x0001CEFF File Offset: 0x0001B0FF
		public unsafe FAISenseAffiliationFilter DetectionByAffiliation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_DetectionByAffiliation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Hearing.__PropertyOffset_DetectionByAffiliation) = value;
			}
		}

		// Token: 0x0600139C RID: 5020 RVA: 0x0001CF14 File Offset: 0x0001B114
		static UAISenseConfig_Hearing()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Hearing");
		}

		// Token: 0x0600139D RID: 5021 RVA: 0x0001CF22 File Offset: 0x0001B122
		protected UAISenseConfig_Hearing(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003A2 RID: 930
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Hearing";

		// Token: 0x040003A3 RID: 931
		private static IntPtr _ClassPtr;

		// Token: 0x040003A4 RID: 932
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003A5 RID: 933
		internal static int __PropertyOffset_Implementation;

		// Token: 0x040003A6 RID: 934
		internal static int __PropertyOffset_HearingRange;

		// Token: 0x040003A7 RID: 935
		internal static int __PropertyOffset_LoSHearingRange;

		// Token: 0x040003A8 RID: 936
		internal static int __PropertyOffset_bUseLoSHearing;

		// Token: 0x040003A9 RID: 937
		internal static byte __PropertyMask_bUseLoSHearing;

		// Token: 0x040003AA RID: 938
		internal static int __PropertyOffset_DetectionByAffiliation;
	}
}
