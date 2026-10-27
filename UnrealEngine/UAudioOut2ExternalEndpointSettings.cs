using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002671 RID: 9841
	[UnrealObjectPath("/Script/PS5AudioFeatures.AudioOut2ExternalEndpointSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAudioOut2ExternalEndpointSettings : UAudioEndpointSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248E1 RID: 149729 RVA: 0x00361D68 File Offset: 0x0035FF68
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioOut2ExternalEndpointSettings._ClassPtr;
		}

		// Token: 0x060248E2 RID: 149730 RVA: 0x00361D74 File Offset: 0x0035FF74
		public UAudioOut2ExternalEndpointSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioOut2ExternalEndpointSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060248E3 RID: 149731 RVA: 0x00361D9C File Offset: 0x0035FF9C
		[NullableContext(1)]
		public UAudioOut2ExternalEndpointSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioOut2ExternalEndpointSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008CE6 RID: 36070
		// (get) Token: 0x060248E4 RID: 149732 RVA: 0x00361DCF File Offset: 0x0035FFCF
		// (set) Token: 0x060248E5 RID: 149733 RVA: 0x00361DDF File Offset: 0x0035FFDF
		public unsafe int ControllerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioOut2ExternalEndpointSettings.__PropertyOffset_ControllerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioOut2ExternalEndpointSettings.__PropertyOffset_ControllerIndex) = value;
			}
		}

		// Token: 0x060248E6 RID: 149734 RVA: 0x00361DF0 File Offset: 0x0035FFF0
		static UAudioOut2ExternalEndpointSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PS5AudioFeatures.AudioOut2ExternalEndpointSettings");
		}

		// Token: 0x060248E7 RID: 149735 RVA: 0x00361DFE File Offset: 0x0035FFFE
		protected UAudioOut2ExternalEndpointSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A44 RID: 80452
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PS5AudioFeatures.AudioOut2ExternalEndpointSettings";

		// Token: 0x04013A45 RID: 80453
		private static IntPtr _ClassPtr;

		// Token: 0x04013A46 RID: 80454
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A47 RID: 80455
		internal static int __PropertyOffset_ControllerIndex;
	}
}
