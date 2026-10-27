using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200010D RID: 269
	[UnrealObjectPath("/Script/AIModule.AISense_Sight")]
	[UnrealStructLayout(384, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 384)]
	public class UAISense_Sight : UAISense, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x0001D976 File Offset: 0x0001BB76
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAISense_Sight._ClassPtr;
		}

		// Token: 0x0600140C RID: 5132 RVA: 0x0001D984 File Offset: 0x0001BB84
		public UAISense_Sight() : this(BuiltinUtils.AllocNativeUObject(UAISense_Sight.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x0001D9AC File Offset: 0x0001BBAC
		[NullableContext(1)]
		public UAISense_Sight(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAISense_Sight.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x0001D9DF File Offset: 0x0001BBDF
		// (set) Token: 0x0600140F RID: 5135 RVA: 0x0001D9EF File Offset: 0x0001BBEF
		public unsafe int MaxTracesPerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxTracesPerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxTracesPerTick) = value;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x0001DA00 File Offset: 0x0001BC00
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x0001DA10 File Offset: 0x0001BC10
		public unsafe int MinQueriesPerTimeSliceCheck
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MinQueriesPerTimeSliceCheck);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MinQueriesPerTimeSliceCheck) = value;
			}
		}

		// Token: 0x17000562 RID: 1378
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0001DA21 File Offset: 0x0001BC21
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x0001DA31 File Offset: 0x0001BC31
		public unsafe double MaxTimeSlicePerTick
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxTimeSlicePerTick);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxTimeSlicePerTick) = value;
			}
		}

		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0001DA42 File Offset: 0x0001BC42
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x0001DA52 File Offset: 0x0001BC52
		public unsafe float HighImportanceQueryDistanceThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_HighImportanceQueryDistanceThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_HighImportanceQueryDistanceThreshold) = value;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0001DA63 File Offset: 0x0001BC63
		// (set) Token: 0x06001417 RID: 5143 RVA: 0x0001DA73 File Offset: 0x0001BC73
		public unsafe float MaxQueryImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxQueryImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_MaxQueryImportance) = value;
			}
		}

		// Token: 0x17000565 RID: 1381
		// (get) Token: 0x06001418 RID: 5144 RVA: 0x0001DA84 File Offset: 0x0001BC84
		// (set) Token: 0x06001419 RID: 5145 RVA: 0x0001DA94 File Offset: 0x0001BC94
		public unsafe float SightLimitQueryImportance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_SightLimitQueryImportance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAISense_Sight.__PropertyOffset_SightLimitQueryImportance) = value;
			}
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0001DAA5 File Offset: 0x0001BCA5
		static UAISense_Sight()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.AISense_Sight");
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0001DAB3 File Offset: 0x0001BCB3
		protected UAISense_Sight(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040003E4 RID: 996
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.AISense_Sight";

		// Token: 0x040003E5 RID: 997
		private static IntPtr _ClassPtr;

		// Token: 0x040003E6 RID: 998
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040003E7 RID: 999
		internal static int __PropertyOffset_MaxTracesPerTick;

		// Token: 0x040003E8 RID: 1000
		internal static int __PropertyOffset_MinQueriesPerTimeSliceCheck;

		// Token: 0x040003E9 RID: 1001
		internal static int __PropertyOffset_MaxTimeSlicePerTick;

		// Token: 0x040003EA RID: 1002
		internal static int __PropertyOffset_HighImportanceQueryDistanceThreshold;

		// Token: 0x040003EB RID: 1003
		internal static int __PropertyOffset_MaxQueryImportance;

		// Token: 0x040003EC RID: 1004
		internal static int __PropertyOffset_SightLimitQueryImportance;
	}
}
