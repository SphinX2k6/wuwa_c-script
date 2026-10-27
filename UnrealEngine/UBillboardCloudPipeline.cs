using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020028B9 RID: 10425
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/StandinActor.BillboardCloudPipeline")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UBillboardCloudPipeline : USimplygonStandinPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06026B82 RID: 158594 RVA: 0x003B1101 File Offset: 0x003AF301
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBillboardCloudPipeline._ClassPtr;
		}

		// Token: 0x06026B83 RID: 158595 RVA: 0x003B1110 File Offset: 0x003AF310
		public UBillboardCloudPipeline() : this(BuiltinUtils.AllocNativeUObject(UBillboardCloudPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06026B84 RID: 158596 RVA: 0x003B1138 File Offset: 0x003AF338
		public UBillboardCloudPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBillboardCloudPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700952F RID: 38191
		// (get) Token: 0x06026B85 RID: 158597 RVA: 0x003B116C File Offset: 0x003AF36C
		// (set) Token: 0x06026B86 RID: 158598 RVA: 0x003B11A5 File Offset: 0x003AF3A5
		public FBillboardCloudPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FBillboardCloudPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FBillboardCloudPipelineSettings(base.NativePtr + (IntPtr)UBillboardCloudPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBillboardCloudPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UBillboardCloudPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17009530 RID: 38192
		// (get) Token: 0x06026B87 RID: 158599 RVA: 0x003B11C8 File Offset: 0x003AF3C8
		// (set) Token: 0x06026B88 RID: 158600 RVA: 0x003B1201 File Offset: 0x003AF401
		public FStandinLightmapSettings LightmapSettings
		{
			get
			{
				base.FastCheckIsValid();
				FStandinLightmapSettings result;
				if ((result = this._LightmapSettings) == null)
				{
					result = (this._LightmapSettings = new FStandinLightmapSettings(base.NativePtr + (IntPtr)UBillboardCloudPipeline.__PropertyOffset_LightmapSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FStandinLightmapSettings.StaticStruct(), base.NativePtr + (IntPtr)UBillboardCloudPipeline.__PropertyOffset_LightmapSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06026B89 RID: 158601 RVA: 0x003B1222 File Offset: 0x003AF422
		static UBillboardCloudPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/StandinActor.BillboardCloudPipeline");
		}

		// Token: 0x06026B8A RID: 158602 RVA: 0x003B1230 File Offset: 0x003AF430
		protected UBillboardCloudPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040153F2 RID: 87026
		public new const string __ObjectPath = "/Script/StandinActor.BillboardCloudPipeline";

		// Token: 0x040153F3 RID: 87027
		private static IntPtr _ClassPtr;

		// Token: 0x040153F4 RID: 87028
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040153F5 RID: 87029
		internal static int __PropertyOffset_Settings;

		// Token: 0x040153F6 RID: 87030
		[Nullable(2)]
		private FBillboardCloudPipelineSettings _Settings;

		// Token: 0x040153F7 RID: 87031
		internal static int __PropertyOffset_LightmapSettings;

		// Token: 0x040153F8 RID: 87032
		[Nullable(2)]
		private FStandinLightmapSettings _LightmapSettings;
	}
}
