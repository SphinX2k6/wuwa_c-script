using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002672 RID: 9842
	[UnrealObjectPath("/Script/PS5AudioFeatures.AudioOut2SoundfieldEndpointSettings")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UAudioOut2SoundfieldEndpointSettings : USoundfieldEndpointSettingsBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060248E8 RID: 149736 RVA: 0x00361E07 File Offset: 0x00360007
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAudioOut2SoundfieldEndpointSettings._ClassPtr;
		}

		// Token: 0x060248E9 RID: 149737 RVA: 0x00361E14 File Offset: 0x00360014
		public UAudioOut2SoundfieldEndpointSettings() : this(BuiltinUtils.AllocNativeUObject(UAudioOut2SoundfieldEndpointSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060248EA RID: 149738 RVA: 0x00361E3C File Offset: 0x0036003C
		[NullableContext(1)]
		public UAudioOut2SoundfieldEndpointSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAudioOut2SoundfieldEndpointSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008CE7 RID: 36071
		// (get) Token: 0x060248EB RID: 149739 RVA: 0x00361E6F File Offset: 0x0036006F
		// (set) Token: 0x060248EC RID: 149740 RVA: 0x00361E7F File Offset: 0x0036007F
		public unsafe int ControllerIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAudioOut2SoundfieldEndpointSettings.__PropertyOffset_ControllerIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAudioOut2SoundfieldEndpointSettings.__PropertyOffset_ControllerIndex) = value;
			}
		}

		// Token: 0x060248ED RID: 149741 RVA: 0x00361E90 File Offset: 0x00360090
		static UAudioOut2SoundfieldEndpointSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/PS5AudioFeatures.AudioOut2SoundfieldEndpointSettings");
		}

		// Token: 0x060248EE RID: 149742 RVA: 0x00361E9E File Offset: 0x0036009E
		protected UAudioOut2SoundfieldEndpointSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013A48 RID: 80456
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/PS5AudioFeatures.AudioOut2SoundfieldEndpointSettings";

		// Token: 0x04013A49 RID: 80457
		private static IntPtr _ClassPtr;

		// Token: 0x04013A4A RID: 80458
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013A4B RID: 80459
		internal static int __PropertyOffset_ControllerIndex;
	}
}
