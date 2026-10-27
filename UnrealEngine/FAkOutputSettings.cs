using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000232 RID: 562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkOutputSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAkOutputSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060020DF RID: 8415 RVA: 0x00030EAE File Offset: 0x0002F0AE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkOutputSettings._ScriptStructPtr != 0) ? FAkOutputSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkOutputSettings", ref FAkOutputSettings._ScriptStructPtr);
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x060020E0 RID: 8416 RVA: 0x00030ED2 File Offset: 0x0002F0D2
		// (set) Token: 0x060020E1 RID: 8417 RVA: 0x00030EE6 File Offset: 0x0002F0E6
		public unsafe string AudioDeviceShareSetName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkOutputSettings.__PropertyOffset_AudioDeviceShareSetName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkOutputSettings.__PropertyOffset_AudioDeviceShareSetName)), value);
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x00030EFB File Offset: 0x0002F0FB
		// (set) Token: 0x060020E3 RID: 8419 RVA: 0x00030F0B File Offset: 0x0002F10B
		public unsafe int IdDevice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_IdDevice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_IdDevice) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x00030F1C File Offset: 0x0002F11C
		// (set) Token: 0x060020E5 RID: 8421 RVA: 0x00030F2C File Offset: 0x0002F12C
		public unsafe PanningRule PanRule
		{
			get
			{
				return (PanningRule)(*(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_PanRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_PanRule) = (byte)value;
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x00030F3D File Offset: 0x0002F13D
		// (set) Token: 0x060020E7 RID: 8423 RVA: 0x00030F4D File Offset: 0x0002F14D
		public unsafe EAkChannelConfiguration ChannelConfig
		{
			get
			{
				return (EAkChannelConfiguration)(*(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_ChannelConfig));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkOutputSettings.__PropertyOffset_ChannelConfig) = (byte)value;
			}
		}

		// Token: 0x060020E8 RID: 8424 RVA: 0x00030F5E File Offset: 0x0002F15E
		public FAkOutputSettings()
		{
		}

		// Token: 0x060020E9 RID: 8425 RVA: 0x00030F66 File Offset: 0x0002F166
		public FAkOutputSettings(string AudioDeviceShareSetName, int IdDevice, PanningRule PanRule, EAkChannelConfiguration ChannelConfig)
		{
			this.AudioDeviceShareSetName = AudioDeviceShareSetName;
			this.IdDevice = IdDevice;
			this.PanRule = PanRule;
			this.ChannelConfig = ChannelConfig;
		}

		// Token: 0x060020EA RID: 8426 RVA: 0x00030F8B File Offset: 0x0002F18B
		protected override IntPtr GetUStructPtr()
		{
			return FAkOutputSettings.StaticStruct();
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00030F97 File Offset: 0x0002F197
		[NullableContext(2)]
		public FAkOutputSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00030FA1 File Offset: 0x0002F1A1
		public FAkOutputSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00030FAC File Offset: 0x0002F1AC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkOutputSettings(Pointer, false, true);
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00030FB6 File Offset: 0x0002F1B6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkOutputSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000B14 RID: 2836
		public const string __ObjectPath = "/Script/AkAudio.AkOutputSettings";

		// Token: 0x04000B15 RID: 2837
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000B16 RID: 2838
		internal static int __PropertyOffset_AudioDeviceShareSetName;

		// Token: 0x04000B17 RID: 2839
		internal static int __PropertyOffset_IdDevice;

		// Token: 0x04000B18 RID: 2840
		internal static int __PropertyOffset_PanRule;

		// Token: 0x04000B19 RID: 2841
		internal static int __PropertyOffset_ChannelConfig;
	}
}
