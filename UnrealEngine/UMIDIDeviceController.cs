using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022E9 RID: 8937
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MIDIDevice.MIDIDeviceController")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UMIDIDeviceController : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021E2F RID: 138799 RVA: 0x00321187 File Offset: 0x0031F387
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMIDIDeviceController._ClassPtr;
		}

		// Token: 0x06021E30 RID: 138800 RVA: 0x00321194 File Offset: 0x0031F394
		public UMIDIDeviceController() : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceController.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021E31 RID: 138801 RVA: 0x003211BC File Offset: 0x0031F3BC
		public UMIDIDeviceController(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMIDIDeviceController.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008325 RID: 33573
		// (get) Token: 0x06021E32 RID: 138802 RVA: 0x003211F0 File Offset: 0x0031F3F0
		// (set) Token: 0x06021E33 RID: 138803 RVA: 0x00321229 File Offset: 0x0031F429
		public FOnMIDIEvent OnMIDIEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnMIDIEvent result;
				if ((result = this._OnMIDIEvent) == null)
				{
					result = (this._OnMIDIEvent = new FOnMIDIEvent(base.NativePtr + (IntPtr)UMIDIDeviceController.__PropertyOffset_OnMIDIEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMIDIDeviceController.__PropertyOffset_OnMIDIEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17008326 RID: 33574
		// (get) Token: 0x06021E34 RID: 138804 RVA: 0x0032124A File Offset: 0x0031F44A
		// (set) Token: 0x06021E35 RID: 138805 RVA: 0x0032125A File Offset: 0x0031F45A
		public unsafe int DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMIDIDeviceController.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMIDIDeviceController.__PropertyOffset_DeviceID) = value;
			}
		}

		// Token: 0x17008327 RID: 33575
		// (get) Token: 0x06021E36 RID: 138806 RVA: 0x0032126B File Offset: 0x0031F46B
		// (set) Token: 0x06021E37 RID: 138807 RVA: 0x0032127F File Offset: 0x0031F47F
		public unsafe string DeviceName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceController.__PropertyOffset_DeviceName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMIDIDeviceController.__PropertyOffset_DeviceName)), value);
			}
		}

		// Token: 0x06021E38 RID: 138808 RVA: 0x00321294 File Offset: 0x0031F494
		static UMIDIDeviceController()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MIDIDevice.MIDIDeviceController");
		}

		// Token: 0x06021E39 RID: 138809 RVA: 0x003212A2 File Offset: 0x0031F4A2
		protected UMIDIDeviceController(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401214A RID: 74058
		public new const string __ObjectPath = "/Script/MIDIDevice.MIDIDeviceController";

		// Token: 0x0401214B RID: 74059
		private static IntPtr _ClassPtr;

		// Token: 0x0401214C RID: 74060
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401214D RID: 74061
		internal static int __PropertyOffset_OnMIDIEvent;

		// Token: 0x0401214E RID: 74062
		[Nullable(2)]
		private FOnMIDIEvent _OnMIDIEvent;

		// Token: 0x0401214F RID: 74063
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04012150 RID: 74064
		internal static int __PropertyOffset_DeviceName;
	}
}
