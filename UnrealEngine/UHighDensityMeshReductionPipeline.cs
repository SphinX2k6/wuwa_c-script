using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020027B4 RID: 10164
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.HighDensityMeshReductionPipeline")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 144)]
	public class UHighDensityMeshReductionPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025E39 RID: 155193 RVA: 0x003970A4 File Offset: 0x003952A4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHighDensityMeshReductionPipeline._ClassPtr;
		}

		// Token: 0x06025E3A RID: 155194 RVA: 0x003970B0 File Offset: 0x003952B0
		public UHighDensityMeshReductionPipeline() : this(BuiltinUtils.AllocNativeUObject(UHighDensityMeshReductionPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025E3B RID: 155195 RVA: 0x003970D8 File Offset: 0x003952D8
		public UHighDensityMeshReductionPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHighDensityMeshReductionPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700920D RID: 37389
		// (get) Token: 0x06025E3C RID: 155196 RVA: 0x0039710C File Offset: 0x0039530C
		// (set) Token: 0x06025E3D RID: 155197 RVA: 0x00397145 File Offset: 0x00395345
		public FHighDensityMeshReductionPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FHighDensityMeshReductionPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FHighDensityMeshReductionPipelineSettings(base.NativePtr + (IntPtr)UHighDensityMeshReductionPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FHighDensityMeshReductionPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UHighDensityMeshReductionPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025E3E RID: 155198 RVA: 0x00397166 File Offset: 0x00395366
		static UHighDensityMeshReductionPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.HighDensityMeshReductionPipeline");
		}

		// Token: 0x06025E3F RID: 155199 RVA: 0x00397174 File Offset: 0x00395374
		protected UHighDensityMeshReductionPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014ADB RID: 84699
		public new const string __ObjectPath = "/Script/SimplygonUObjects.HighDensityMeshReductionPipeline";

		// Token: 0x04014ADC RID: 84700
		private static IntPtr _ClassPtr;

		// Token: 0x04014ADD RID: 84701
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014ADE RID: 84702
		internal static int __PropertyOffset_Settings;

		// Token: 0x04014ADF RID: 84703
		[Nullable(2)]
		private FHighDensityMeshReductionPipelineSettings _Settings;
	}
}
