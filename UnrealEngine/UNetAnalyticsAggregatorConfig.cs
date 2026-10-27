using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C2 RID: 9410
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NetCore.NetAnalyticsAggregatorConfig")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UNetAnalyticsAggregatorConfig : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602336C RID: 144236 RVA: 0x003416BE File Offset: 0x0033F8BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNetAnalyticsAggregatorConfig._ClassPtr;
		}

		// Token: 0x0602336D RID: 144237 RVA: 0x003416CC File Offset: 0x0033F8CC
		public UNetAnalyticsAggregatorConfig() : this(BuiltinUtils.AllocNativeUObject(UNetAnalyticsAggregatorConfig.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602336E RID: 144238 RVA: 0x003416F4 File Offset: 0x0033F8F4
		public UNetAnalyticsAggregatorConfig(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNetAnalyticsAggregatorConfig.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008764 RID: 34660
		// (get) Token: 0x0602336F RID: 144239 RVA: 0x00341728 File Offset: 0x0033F928
		// (set) Token: 0x06023370 RID: 144240 RVA: 0x00341761 File Offset: 0x0033F961
		public TArray<FNetAnalyticsDataConfig> NetAnalyticsData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNetAnalyticsDataConfig> result;
				if ((result = this._NetAnalyticsData) == null)
				{
					result = (this._NetAnalyticsData = new TArray<FNetAnalyticsDataConfig>(base.NativePtr + (IntPtr)UNetAnalyticsAggregatorConfig.__PropertyOffset_NetAnalyticsData, this));
				}
				return result;
			}
			set
			{
				this.NetAnalyticsData.CopyAssign(value);
			}
		}

		// Token: 0x06023371 RID: 144241 RVA: 0x0034176F File Offset: 0x0033F96F
		static UNetAnalyticsAggregatorConfig()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NetCore.NetAnalyticsAggregatorConfig");
		}

		// Token: 0x06023372 RID: 144242 RVA: 0x0034177D File Offset: 0x0033F97D
		protected UNetAnalyticsAggregatorConfig(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012CEF RID: 77039
		public new const string __ObjectPath = "/Script/NetCore.NetAnalyticsAggregatorConfig";

		// Token: 0x04012CF0 RID: 77040
		private static IntPtr _ClassPtr;

		// Token: 0x04012CF1 RID: 77041
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012CF2 RID: 77042
		internal static int __PropertyOffset_NetAnalyticsData;

		// Token: 0x04012CF3 RID: 77043
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNetAnalyticsDataConfig> _NetAnalyticsData;
	}
}
