using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022EB RID: 8939
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MIDIDevice.MIDIDeviceInputController")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UMIDIDeviceInputController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E4A RID: 138826 RVA: 0x003213BC File Offset: 0x0031F5BC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMIDIDeviceInputController._ClassPtr;
		}

		// Token: 0x06021E4B RID: 138827 RVA: 0x003213C8 File Offset: 0x0031F5C8
		public UMIDIDeviceInputController() : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceInputController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E4C RID: 138828 RVA: 0x003213F0 File Offset: 0x0031F5F0
		public UMIDIDeviceInputController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceInputController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700832C RID: 33580
		// (get) Token: 0x06021E4D RID: 138829 RVA: 0x00321424 File Offset: 0x0031F624
		// (set) Token: 0x06021E4E RID: 138830 RVA: 0x0032145D File Offset: 0x0031F65D
		public FOnMIDINoteOn OnMIDINoteOn
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDINoteOn result;
				if ((result = this._OnMIDINoteOn) == null)
				{
					result = (this._OnMIDINoteOn = new FOnMIDINoteOn(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDINoteOn, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDINoteOn, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700832D RID: 33581
		// (get) Token: 0x06021E4F RID: 138831 RVA: 0x00321480 File Offset: 0x0031F680
		// (set) Token: 0x06021E50 RID: 138832 RVA: 0x003214B9 File Offset: 0x0031F6B9
		public FOnMIDINoteOff OnMIDINoteOff
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDINoteOff result;
				if ((result = this._OnMIDINoteOff) == null)
				{
					result = (this._OnMIDINoteOff = new FOnMIDINoteOff(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDINoteOff, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDINoteOff, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700832E RID: 33582
		// (get) Token: 0x06021E51 RID: 138833 RVA: 0x003214DC File Offset: 0x0031F6DC
		// (set) Token: 0x06021E52 RID: 138834 RVA: 0x00321515 File Offset: 0x0031F715
		public FOnMIDIPitchBend OnMIDIPitchBend
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIPitchBend result;
				if ((result = this._OnMIDIPitchBend) == null)
				{
					result = (this._OnMIDIPitchBend = new FOnMIDIPitchBend(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIPitchBend, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIPitchBend, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700832F RID: 33583
		// (get) Token: 0x06021E53 RID: 138835 RVA: 0x00321538 File Offset: 0x0031F738
		// (set) Token: 0x06021E54 RID: 138836 RVA: 0x00321571 File Offset: 0x0031F771
		public FOnMIDIAftertouch OnMIDIAftertouch
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIAftertouch result;
				if ((result = this._OnMIDIAftertouch) == null)
				{
					result = (this._OnMIDIAftertouch = new FOnMIDIAftertouch(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIAftertouch, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIAftertouch, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008330 RID: 33584
		// (get) Token: 0x06021E55 RID: 138837 RVA: 0x00321594 File Offset: 0x0031F794
		// (set) Token: 0x06021E56 RID: 138838 RVA: 0x003215CD File Offset: 0x0031F7CD
		public FOnMIDIControlChange OnMIDIControlChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIControlChange result;
				if ((result = this._OnMIDIControlChange) == null)
				{
					result = (this._OnMIDIControlChange = new FOnMIDIControlChange(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIControlChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIControlChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008331 RID: 33585
		// (get) Token: 0x06021E57 RID: 138839 RVA: 0x003215F0 File Offset: 0x0031F7F0
		// (set) Token: 0x06021E58 RID: 138840 RVA: 0x00321629 File Offset: 0x0031F829
		public FOnMIDIProgramChange OnMIDIProgramChange
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIProgramChange result;
				if ((result = this._OnMIDIProgramChange) == null)
				{
					result = (this._OnMIDIProgramChange = new FOnMIDIProgramChange(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIProgramChange, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIProgramChange, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008332 RID: 33586
		// (get) Token: 0x06021E59 RID: 138841 RVA: 0x0032164C File Offset: 0x0031F84C
		// (set) Token: 0x06021E5A RID: 138842 RVA: 0x00321685 File Offset: 0x0031F885
		public FOnMIDIChannelAftertouch OnMIDIChannelAftertouch
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIChannelAftertouch result;
				if ((result = this._OnMIDIChannelAftertouch) == null)
				{
					result = (this._OnMIDIChannelAftertouch = new FOnMIDIChannelAftertouch(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIChannelAftertouch, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_OnMIDIChannelAftertouch, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008333 RID: 33587
		// (get) Token: 0x06021E5B RID: 138843 RVA: 0x003216A6 File Offset: 0x0031F8A6
		// (set) Token: 0x06021E5C RID: 138844 RVA: 0x003216B6 File Offset: 0x0031F8B6
		public unsafe int DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMIDIDeviceInputController.__PropertyOffset_DeviceID) = value;
			}
		}

		// Token: 0x17008334 RID: 33588
		// (get) Token: 0x06021E5D RID: 138845 RVA: 0x003216C7 File Offset: 0x0031F8C7
		// (set) Token: 0x06021E5E RID: 138846 RVA: 0x003216DB File Offset: 0x0031F8DB
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceInputController.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceInputController.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x06021E5F RID: 138847 RVA: 0x003216F0 File Offset: 0x0031F8F0
		static UMIDIDeviceInputController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MIDIDevice.MIDIDeviceInputController");
		}

		// Token: 0x06021E60 RID: 138848 RVA: 0x003216FE File Offset: 0x0031F8FE
		protected UMIDIDeviceInputController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012157 RID: 74071
		public new const string __ObjectPath = "/Script/MIDIDevice.MIDIDeviceInputController";

		// Token: 0x04012158 RID: 74072
		private static IntPtr _ClassPtr;

		// Token: 0x04012159 RID: 74073
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401215A RID: 74074
		internal static int __PropertyOffset_OnMIDINoteOn;

		// Token: 0x0401215B RID: 74075
		[Nullable(2)]
		private FOnMIDINoteOn _OnMIDINoteOn;

		// Token: 0x0401215C RID: 74076
		internal static int __PropertyOffset_OnMIDINoteOff;

		// Token: 0x0401215D RID: 74077
		[Nullable(2)]
		private FOnMIDINoteOff _OnMIDINoteOff;

		// Token: 0x0401215E RID: 74078
		internal static int __PropertyOffset_OnMIDIPitchBend;

		// Token: 0x0401215F RID: 74079
		[Nullable(2)]
		private FOnMIDIPitchBend _OnMIDIPitchBend;

		// Token: 0x04012160 RID: 74080
		internal static int __PropertyOffset_OnMIDIAftertouch;

		// Token: 0x04012161 RID: 74081
		[Nullable(2)]
		private FOnMIDIAftertouch _OnMIDIAftertouch;

		// Token: 0x04012162 RID: 74082
		internal static int __PropertyOffset_OnMIDIControlChange;

		// Token: 0x04012163 RID: 74083
		[Nullable(2)]
		private FOnMIDIControlChange _OnMIDIControlChange;

		// Token: 0x04012164 RID: 74084
		internal static int __PropertyOffset_OnMIDIProgramChange;

		// Token: 0x04012165 RID: 74085
		[Nullable(2)]
		private FOnMIDIProgramChange _OnMIDIProgramChange;

		// Token: 0x04012166 RID: 74086
		internal static int __PropertyOffset_OnMIDIChannelAftertouch;

		// Token: 0x04012167 RID: 74087
		[Nullable(2)]
		private FOnMIDIChannelAftertouch _OnMIDIChannelAftertouch;

		// Token: 0x04012168 RID: 74088
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04012169 RID: 74089
		internal static int __PropertyOffset_DeviceName;
	}
}
