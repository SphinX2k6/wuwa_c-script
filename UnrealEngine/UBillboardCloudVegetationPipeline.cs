using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200277F RID: 10111
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/SimplygonUObjects.BillboardCloudVegetationPipeline")]
	[UnrealStructLayout(360, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 360)]
	public class UBillboardCloudVegetationPipeline : USimplygonPipeline, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06025CC9 RID: 154825 RVA: 0x00394DF8 File Offset: 0x00392FF8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBillboardCloudVegetationPipeline._ClassPtr;
		}

		// Token: 0x06025CCA RID: 154826 RVA: 0x00394E04 File Offset: 0x00393004
		public UBillboardCloudVegetationPipeline() : this(BuiltinUtils.AllocNativeUObject(UBillboardCloudVegetationPipeline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06025CCB RID: 154827 RVA: 0x00394E2C File Offset: 0x0039302C
		public UBillboardCloudVegetationPipeline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBillboardCloudVegetationPipeline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700918F RID: 37263
		// (get) Token: 0x06025CCC RID: 154828 RVA: 0x00394E60 File Offset: 0x00393060
		// (set) Token: 0x06025CCD RID: 154829 RVA: 0x00394E99 File Offset: 0x00393099
		public FBillboardCloudVegetationPipelineSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FBillboardCloudVegetationPipelineSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FBillboardCloudVegetationPipelineSettings(base.NativePtr + (IntPtr)UBillboardCloudVegetationPipeline.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBillboardCloudVegetationPipelineSettings.StaticStruct(), base.NativePtr + (IntPtr)UBillboardCloudVegetationPipeline.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06025CCE RID: 154830 RVA: 0x00394EBA File Offset: 0x003930BA
		static UBillboardCloudVegetationPipeline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/SimplygonUObjects.BillboardCloudVegetationPipeline");
		}

		// Token: 0x06025CCF RID: 154831 RVA: 0x00394EC8 File Offset: 0x003930C8
		protected UBillboardCloudVegetationPipeline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04014940 RID: 84288
		public new const string __ObjectPath = "/Script/SimplygonUObjects.BillboardCloudVegetationPipeline";

		// Token: 0x04014941 RID: 84289
		private static IntPtr _ClassPtr;

		// Token: 0x04014942 RID: 84290
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04014943 RID: 84291
		internal static int __PropertyOffset_Settings;

		// Token: 0x04014944 RID: 84292
		[Nullable(2)]
		private FBillboardCloudVegetationPipelineSettings _Settings;
	}
}
