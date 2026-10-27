using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028BC RID: 10428
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.SimplygonStandinPipeline")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public abstract class USimplygonStandinPipeline : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B9F RID: 158623 RVA: 0x003B13B0 File Offset: 0x003AF5B0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USimplygonStandinPipeline._ClassPtr;
		}

		// Token: 0x17009537 RID: 38199
		// (get) Token: 0x06026BA0 RID: 158624 RVA: 0x003B13BC File Offset: 0x003AF5BC
		// (set) Token: 0x06026BA1 RID: 158625 RVA: 0x003B13F5 File Offset: 0x003AF5F5
		public FChartAggregatorSettings ChartAggregatorSettings
		{
			get
			{
				base.FastCheckIsValid();
				FChartAggregatorSettings result;
				if ((result = this._ChartAggregatorSettings) == null)
				{
					result = (this._ChartAggregatorSettings = new FChartAggregatorSettings(base.NativePtr + (IntPtr)USimplygonStandinPipeline.__PropertyOffset_ChartAggregatorSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FChartAggregatorSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonStandinPipeline.__PropertyOffset_ChartAggregatorSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009538 RID: 38200
		// (get) Token: 0x06026BA2 RID: 158626 RVA: 0x003B1418 File Offset: 0x003AF618
		// (set) Token: 0x06026BA3 RID: 158627 RVA: 0x003B1451 File Offset: 0x003AF651
		public FMaterialOutputSettings MaterialOutputSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMaterialOutputSettings result;
				if ((result = this._MaterialOutputSettings) == null)
				{
					result = (this._MaterialOutputSettings = new FMaterialOutputSettings(base.NativePtr + (IntPtr)USimplygonStandinPipeline.__PropertyOffset_MaterialOutputSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMaterialOutputSettings.StaticStruct(), base.NativePtr + (IntPtr)USimplygonStandinPipeline.__PropertyOffset_MaterialOutputSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026BA4 RID: 158628 RVA: 0x003B1472 File Offset: 0x003AF672
		static USimplygonStandinPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.SimplygonStandinPipeline");
		}

		// Token: 0x06026BA5 RID: 158629 RVA: 0x003B1480 File Offset: 0x003AF680
		protected USimplygonStandinPipeline() : this(BuiltinUtils.AllocNativeUObject(USimplygonStandinPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BA6 RID: 158630 RVA: 0x003B14A8 File Offset: 0x003AF6A8
		protected USimplygonStandinPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04015405 RID: 87045
		public new const string __ObjectPath = "/Script/StandinActor.SimplygonStandinPipeline";

		// Token: 0x04015406 RID: 87046
		private static IntPtr _ClassPtr;

		// Token: 0x04015407 RID: 87047
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04015408 RID: 87048
		internal static int __PropertyOffset_ChartAggregatorSettings;

		// Token: 0x04015409 RID: 87049
		[Nullable(2)]
		private FChartAggregatorSettings _ChartAggregatorSettings;

		// Token: 0x0401540A RID: 87050
		internal static int __PropertyOffset_MaterialOutputSettings;

		// Token: 0x0401540B RID: 87051
		[Nullable(2)]
		private FMaterialOutputSettings _MaterialOutputSettings;
	}
}
