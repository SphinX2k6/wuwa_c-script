using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028BD RID: 10429
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.StandinFarPipeline")]
	[UnrealStructLayout(720, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 720)]
	public class UStandinFarPipeline : USimplygonStandinPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026BA7 RID: 158631 RVA: 0x003B14B1 File Offset: 0x003AF6B1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStandinFarPipeline._ClassPtr;
		}

		// Token: 0x06026BA8 RID: 158632 RVA: 0x003B14C0 File Offset: 0x003AF6C0
		public UStandinFarPipeline() : this(BuiltinUtils.AllocNativeUObject(UStandinFarPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026BA9 RID: 158633 RVA: 0x003B14E8 File Offset: 0x003AF6E8
		public UStandinFarPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStandinFarPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17009539 RID: 38201
		// (get) Token: 0x06026BAA RID: 158634 RVA: 0x003B151C File Offset: 0x003AF71C
		// (set) Token: 0x06026BAB RID: 158635 RVA: 0x003B1555 File Offset: 0x003AF755
		public FRemeshingPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FRemeshingPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FRemeshingPipelineSettings(base.NativePtr + (IntPtr)UStandinFarPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRemeshingPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UStandinFarPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700953A RID: 38202
		// (get) Token: 0x06026BAC RID: 158636 RVA: 0x003B1578 File Offset: 0x003AF778
		// (set) Token: 0x06026BAD RID: 158637 RVA: 0x003B15B1 File Offset: 0x003AF7B1
		public FStandinLightmapSettings LightmapSettings
		{
			get
			{
				base.FastCheckIsValid();
				FStandinLightmapSettings result;
				if ((result = this._LightmapSettings) == null)
				{
					result = (this._LightmapSettings = new FStandinLightmapSettings(base.NativePtr + (IntPtr)UStandinFarPipeline.__PropertyOffset_LightmapSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStandinLightmapSettings.StaticStruct(), base.NativePtr + (IntPtr)UStandinFarPipeline.__PropertyOffset_LightmapSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026BAE RID: 158638 RVA: 0x003B15D2 File Offset: 0x003AF7D2
		static UStandinFarPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.StandinFarPipeline");
		}

		// Token: 0x06026BAF RID: 158639 RVA: 0x003B15E0 File Offset: 0x003AF7E0
		protected UStandinFarPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401540C RID: 87052
		public new const string __ObjectPath = "/Script/StandinActor.StandinFarPipeline";

		// Token: 0x0401540D RID: 87053
		private static IntPtr _ClassPtr;

		// Token: 0x0401540E RID: 87054
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401540F RID: 87055
		internal static int __PropertyOffset_Settings;

		// Token: 0x04015410 RID: 87056
		[Nullable(2)]
		private FRemeshingPipelineSettings _Settings;

		// Token: 0x04015411 RID: 87057
		internal static int __PropertyOffset_LightmapSettings;

		// Token: 0x04015412 RID: 87058
		[Nullable(2)]
		private FStandinLightmapSettings _LightmapSettings;
	}
}
