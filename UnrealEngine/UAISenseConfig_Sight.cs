using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000103 RID: 259
	[UnrealObjectPath("/Script/AIModule.AISenseConfig_Sight")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAISenseConfig_Sight : UAISenseConfig, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x0001CFAA File Offset: 0x0001B1AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISenseConfig_Sight._ClassPtr;
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		public UAISenseConfig_Sight() : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Sight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0001CFE0 File Offset: 0x0001B1E0
		[NullableContext(1)]
		public UAISenseConfig_Sight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISenseConfig_Sight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700054F RID: 1359
		// (get) Token: 0x060013A6 RID: 5030 RVA: 0x0001D013 File Offset: 0x0001B213
		// (set) Token: 0x060013A7 RID: 5031 RVA: 0x0001D027 File Offset: 0x0001B227
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAISense_Sight> Implementation
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_Implementation);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_Implementation) = value;
			}
		}

		// Token: 0x17000550 RID: 1360
		// (get) Token: 0x060013A8 RID: 5032 RVA: 0x0001D03C File Offset: 0x0001B23C
		// (set) Token: 0x060013A9 RID: 5033 RVA: 0x0001D04C File Offset: 0x0001B24C
		public unsafe float SightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_SightRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_SightRadius) = value;
			}
		}

		// Token: 0x17000551 RID: 1361
		// (get) Token: 0x060013AA RID: 5034 RVA: 0x0001D05D File Offset: 0x0001B25D
		// (set) Token: 0x060013AB RID: 5035 RVA: 0x0001D06D File Offset: 0x0001B26D
		public unsafe float LoseSightRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_LoseSightRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_LoseSightRadius) = value;
			}
		}

		// Token: 0x17000552 RID: 1362
		// (get) Token: 0x060013AC RID: 5036 RVA: 0x0001D07E File Offset: 0x0001B27E
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0001D08E File Offset: 0x0001B28E
		public unsafe float PeripheralVisionAngleDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_PeripheralVisionAngleDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_PeripheralVisionAngleDegrees) = value;
			}
		}

		// Token: 0x17000553 RID: 1363
		// (get) Token: 0x060013AE RID: 5038 RVA: 0x0001D09F File Offset: 0x0001B29F
		// (set) Token: 0x060013AF RID: 5039 RVA: 0x0001D0B3 File Offset: 0x0001B2B3
		public unsafe FAISenseAffiliationFilter DetectionByAffiliation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_DetectionByAffiliation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_DetectionByAffiliation) = value;
			}
		}

		// Token: 0x17000554 RID: 1364
		// (get) Token: 0x060013B0 RID: 5040 RVA: 0x0001D0C8 File Offset: 0x0001B2C8
		// (set) Token: 0x060013B1 RID: 5041 RVA: 0x0001D0D8 File Offset: 0x0001B2D8
		public unsafe float AutoSuccessRangeFromLastSeenLocation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_AutoSuccessRangeFromLastSeenLocation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_AutoSuccessRangeFromLastSeenLocation) = value;
			}
		}

		// Token: 0x17000555 RID: 1365
		// (get) Token: 0x060013B2 RID: 5042 RVA: 0x0001D0E9 File Offset: 0x0001B2E9
		// (set) Token: 0x060013B3 RID: 5043 RVA: 0x0001D0F9 File Offset: 0x0001B2F9
		public unsafe float PointOfViewBackwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_PointOfViewBackwardOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_PointOfViewBackwardOffset) = value;
			}
		}

		// Token: 0x17000556 RID: 1366
		// (get) Token: 0x060013B4 RID: 5044 RVA: 0x0001D10A File Offset: 0x0001B30A
		// (set) Token: 0x060013B5 RID: 5045 RVA: 0x0001D11A File Offset: 0x0001B31A
		public unsafe float NearClippingRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_NearClippingRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISenseConfig_Sight.__PropertyOffset_NearClippingRadius) = value;
			}
		}

		// Token: 0x060013B6 RID: 5046 RVA: 0x0001D12B File Offset: 0x0001B32B
		static UAISenseConfig_Sight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISenseConfig_Sight");
		}

		// Token: 0x060013B7 RID: 5047 RVA: 0x0001D139 File Offset: 0x0001B339
		protected UAISenseConfig_Sight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003AE RID: 942
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISenseConfig_Sight";

		// Token: 0x040003AF RID: 943
		private static IntPtr _ClassPtr;

		// Token: 0x040003B0 RID: 944
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003B1 RID: 945
		internal static int __PropertyOffset_Implementation;

		// Token: 0x040003B2 RID: 946
		internal static int __PropertyOffset_SightRadius;

		// Token: 0x040003B3 RID: 947
		internal static int __PropertyOffset_LoseSightRadius;

		// Token: 0x040003B4 RID: 948
		internal static int __PropertyOffset_PeripheralVisionAngleDegrees;

		// Token: 0x040003B5 RID: 949
		internal static int __PropertyOffset_DetectionByAffiliation;

		// Token: 0x040003B6 RID: 950
		internal static int __PropertyOffset_AutoSuccessRangeFromLastSeenLocation;

		// Token: 0x040003B7 RID: 951
		internal static int __PropertyOffset_PointOfViewBackwardOffset;

		// Token: 0x040003B8 RID: 952
		internal static int __PropertyOffset_NearClippingRadius;
	}
}
