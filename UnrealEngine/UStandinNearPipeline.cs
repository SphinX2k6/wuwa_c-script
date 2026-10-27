using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028C0 RID: 10432
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.StandinNearPipeline")]
	[UnrealStructLayout(680, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 680)]
	public class UStandinNearPipeline : USimplygonStandinPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BC3 RID: 158659 RVA: 0x003B174B File Offset: 0x003AF94B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStandinNearPipeline._ClassPtr;
		}

		// Token: 0x06026BC4 RID: 158660 RVA: 0x003B1758 File Offset: 0x003AF958
		public UStandinNearPipeline() : this(BuiltinUtils.AllocNativeUObject(UStandinNearPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BC5 RID: 158661 RVA: 0x003B1780 File Offset: 0x003AF980
		public UStandinNearPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStandinNearPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700953E RID: 38206
		// (get) Token: 0x06026BC6 RID: 158662 RVA: 0x003B17B4 File Offset: 0x003AF9B4
		// (set) Token: 0x06026BC7 RID: 158663 RVA: 0x003B17ED File Offset: 0x003AF9ED
		public FAggregationPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FAggregationPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FAggregationPipelineSettings(base.NativePtr + (IntPtr)UStandinNearPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAggregationPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UStandinNearPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700953F RID: 38207
		// (get) Token: 0x06026BC8 RID: 158664 RVA: 0x003B1810 File Offset: 0x003AFA10
		// (set) Token: 0x06026BC9 RID: 158665 RVA: 0x003B1849 File Offset: 0x003AFA49
		public FNearStandinLightmapSettings LightmapSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNearStandinLightmapSettings result;
				if ((result = this._LightmapSettings) == null)
				{
					result = (this._LightmapSettings = new FNearStandinLightmapSettings(base.NativePtr + (IntPtr)UStandinNearPipeline.__PropertyOffset_LightmapSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNearStandinLightmapSettings.StaticStruct(), base.NativePtr + (IntPtr)UStandinNearPipeline.__PropertyOffset_LightmapSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026BCA RID: 158666 RVA: 0x003B186A File Offset: 0x003AFA6A
		static UStandinNearPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.StandinNearPipeline");
		}

		// Token: 0x06026BCB RID: 158667 RVA: 0x003B1878 File Offset: 0x003AFA78
		protected UStandinNearPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401541B RID: 87067
		public new const string __ObjectPath = "/Script/StandinActor.StandinNearPipeline";

		// Token: 0x0401541C RID: 87068
		private static IntPtr _ClassPtr;

		// Token: 0x0401541D RID: 87069
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401541E RID: 87070
		internal static int __PropertyOffset_Settings;

		// Token: 0x0401541F RID: 87071
		[Nullable(2)]
		private FAggregationPipelineSettings _Settings;

		// Token: 0x04015420 RID: 87072
		internal static int __PropertyOffset_LightmapSettings;

		// Token: 0x04015421 RID: 87073
		[Nullable(2)]
		private FNearStandinLightmapSettings _LightmapSettings;
	}
}
