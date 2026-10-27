using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002680 RID: 9856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/RawInput.RawInputSettings")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class URawInputSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060249AB RID: 149931 RVA: 0x00363089 File Offset: 0x00361289
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URawInputSettings._ClassPtr;
		}

		// Token: 0x060249AC RID: 149932 RVA: 0x00363098 File Offset: 0x00361298
		public URawInputSettings() : this(BuiltinUtils.AllocNativeUObject(URawInputSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060249AD RID: 149933 RVA: 0x003630C0 File Offset: 0x003612C0
		public URawInputSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URawInputSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008D26 RID: 36134
		// (get) Token: 0x060249AE RID: 149934 RVA: 0x003630F4 File Offset: 0x003612F4
		// (set) Token: 0x060249AF RID: 149935 RVA: 0x0036312D File Offset: 0x0036132D
		public TArray<FRawInputDeviceConfiguration> DeviceConfigurations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRawInputDeviceConfiguration> result;
				if ((result = this._DeviceConfigurations) == null)
				{
					result = (this._DeviceConfigurations = new TArray<FRawInputDeviceConfiguration>(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_DeviceConfigurations, this));
				}
				return result;
			}
			set
			{
				this.DeviceConfigurations.CopyAssign(value);
			}
		}

		// Token: 0x17008D27 RID: 36135
		// (get) Token: 0x060249B0 RID: 149936 RVA: 0x0036313B File Offset: 0x0036133B
		// (set) Token: 0x060249B1 RID: 149937 RVA: 0x0036314B File Offset: 0x0036134B
		public unsafe bool bRegisterDefaultDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bRegisterDefaultDevice) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bRegisterDefaultDevice) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D28 RID: 36136
		// (get) Token: 0x060249B2 RID: 149938 RVA: 0x0036315C File Offset: 0x0036135C
		// (set) Token: 0x060249B3 RID: 149939 RVA: 0x0036316C File Offset: 0x0036136C
		public unsafe float AxisTolerance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_AxisTolerance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_AxisTolerance) = value;
			}
		}

		// Token: 0x17008D29 RID: 36137
		// (get) Token: 0x060249B4 RID: 149940 RVA: 0x0036317D File Offset: 0x0036137D
		// (set) Token: 0x060249B5 RID: 149941 RVA: 0x0036318D File Offset: 0x0036138D
		public unsafe bool bPrintButtonLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintButtonLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintButtonLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D2A RID: 36138
		// (get) Token: 0x060249B6 RID: 149942 RVA: 0x0036319E File Offset: 0x0036139E
		// (set) Token: 0x060249B7 RID: 149943 RVA: 0x003631AE File Offset: 0x003613AE
		public unsafe bool bPrintAxisLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintAxisLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintAxisLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008D2B RID: 36139
		// (get) Token: 0x060249B8 RID: 149944 RVA: 0x003631BF File Offset: 0x003613BF
		// (set) Token: 0x060249B9 RID: 149945 RVA: 0x003631CF File Offset: 0x003613CF
		public unsafe bool bPrintAxisButtonLog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintAxisButtonLog) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URawInputSettings.__PropertyOffset_bPrintAxisButtonLog) = (value ? 1 : 0);
			}
		}

		// Token: 0x060249BA RID: 149946 RVA: 0x003631E0 File Offset: 0x003613E0
		static URawInputSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RawInput.RawInputSettings");
		}

		// Token: 0x060249BB RID: 149947 RVA: 0x003631EE File Offset: 0x003613EE
		protected URawInputSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013ACA RID: 80586
		public new const string __ObjectPath = "/Script/RawInput.RawInputSettings";

		// Token: 0x04013ACB RID: 80587
		private static IntPtr _ClassPtr;

		// Token: 0x04013ACC RID: 80588
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013ACD RID: 80589
		internal static int __PropertyOffset_DeviceConfigurations;

		// Token: 0x04013ACE RID: 80590
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRawInputDeviceConfiguration> _DeviceConfigurations;

		// Token: 0x04013ACF RID: 80591
		internal static int __PropertyOffset_bRegisterDefaultDevice;

		// Token: 0x04013AD0 RID: 80592
		internal static int __PropertyOffset_AxisTolerance;

		// Token: 0x04013AD1 RID: 80593
		internal static int __PropertyOffset_bPrintButtonLog;

		// Token: 0x04013AD2 RID: 80594
		internal static int __PropertyOffset_bPrintAxisLog;

		// Token: 0x04013AD3 RID: 80595
		internal static int __PropertyOffset_bPrintAxisButtonLog;
	}
}
