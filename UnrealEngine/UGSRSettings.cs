using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200145B RID: 5211
	[UnrealObjectPath("/Script/GSRTUModule.GSRSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UGSRSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601306C RID: 77932 RVA: 0x001BFCE2 File Offset: 0x001BDEE2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UGSRSettings._ClassPtr;
		}

		// Token: 0x0601306D RID: 77933 RVA: 0x001BFCF0 File Offset: 0x001BDEF0
		public UGSRSettings() : this(BuiltinUtils.AllocNativeUObject(UGSRSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601306E RID: 77934 RVA: 0x001BFD18 File Offset: 0x001BDF18
		[NullableContext(1)]
		public UGSRSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UGSRSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x0601306F RID: 77935 RVA: 0x001BFD4B File Offset: 0x001BDF4B
		// (set) Token: 0x06013070 RID: 77936 RVA: 0x001BFD5B File Offset: 0x001BDF5B
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x06013071 RID: 77937 RVA: 0x001BFD6C File Offset: 0x001BDF6C
		// (set) Token: 0x06013072 RID: 77938 RVA: 0x001BFD7C File Offset: 0x001BDF7C
		public unsafe bool AutoExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_AutoExposure) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_AutoExposure) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x06013073 RID: 77939 RVA: 0x001BFD8D File Offset: 0x001BDF8D
		// (set) Token: 0x06013074 RID: 77940 RVA: 0x001BFD9D File Offset: 0x001BDF9D
		public unsafe EGSRQualityMode QualityMode
		{
			get
			{
				return (EGSRQualityMode)(*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_QualityMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_QualityMode) = (int)value;
			}
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x06013075 RID: 77941 RVA: 0x001BFDAE File Offset: 0x001BDFAE
		// (set) Token: 0x06013076 RID: 77942 RVA: 0x001BFDBE File Offset: 0x001BDFBE
		public unsafe EGSRHistoryFormat HistoryFormat
		{
			get
			{
				return (EGSRHistoryFormat)(*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_HistoryFormat));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_HistoryFormat) = (int)value;
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x06013077 RID: 77943 RVA: 0x001BFDCF File Offset: 0x001BDFCF
		// (set) Token: 0x06013078 RID: 77944 RVA: 0x001BFDDF File Offset: 0x001BDFDF
		public unsafe bool AdjustMipBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_AdjustMipBias) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_AdjustMipBias) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x06013079 RID: 77945 RVA: 0x001BFDF0 File Offset: 0x001BDFF0
		// (set) Token: 0x0601307A RID: 77946 RVA: 0x001BFE00 File Offset: 0x001BE000
		public unsafe bool ForceVertexDeformationOutputsVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_ForceVertexDeformationOutputsVelocity) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UGSRSettings.__PropertyOffset_ForceVertexDeformationOutputsVelocity) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601307B RID: 77947 RVA: 0x001BFE11 File Offset: 0x001BE011
		static UGSRSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GSRTUModule.GSRSettings");
		}

		// Token: 0x0601307C RID: 77948 RVA: 0x001BFE1F File Offset: 0x001BE01F
		protected UGSRSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A326 RID: 41766
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/GSRTUModule.GSRSettings";

		// Token: 0x0400A327 RID: 41767
		private static IntPtr _ClassPtr;

		// Token: 0x0400A328 RID: 41768
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A329 RID: 41769
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400A32A RID: 41770
		internal static int __PropertyOffset_AutoExposure;

		// Token: 0x0400A32B RID: 41771
		internal static int __PropertyOffset_QualityMode;

		// Token: 0x0400A32C RID: 41772
		internal static int __PropertyOffset_HistoryFormat;

		// Token: 0x0400A32D RID: 41773
		internal static int __PropertyOffset_AdjustMipBias;

		// Token: 0x0400A32E RID: 41774
		internal static int __PropertyOffset_ForceVertexDeformationOutputsVelocity;
	}
}
