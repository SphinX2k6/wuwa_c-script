using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200021E RID: 542
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMainOutputSettings")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FAkMainOutputSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002003 RID: 8195 RVA: 0x0002F79E File Offset: 0x0002D99E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkMainOutputSettings._ScriptStructPtr != 0) ? FAkMainOutputSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkMainOutputSettings", ref FAkMainOutputSettings._ScriptStructPtr);
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06002004 RID: 8196 RVA: 0x0002F7C2 File Offset: 0x0002D9C2
		// (set) Token: 0x06002005 RID: 8197 RVA: 0x0002F7D6 File Offset: 0x0002D9D6
		public unsafe string AudioDeviceShareSet
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAkMainOutputSettings.__PropertyOffset_AudioDeviceShareSet)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAkMainOutputSettings.__PropertyOffset_AudioDeviceShareSet)), value);
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06002006 RID: 8198 RVA: 0x0002F7EB File Offset: 0x0002D9EB
		// (set) Token: 0x06002007 RID: 8199 RVA: 0x0002F7FB File Offset: 0x0002D9FB
		public unsafe uint DeviceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_DeviceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_DeviceID) = (int)value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06002008 RID: 8200 RVA: 0x0002F80C File Offset: 0x0002DA0C
		// (set) Token: 0x06002009 RID: 8201 RVA: 0x0002F81C File Offset: 0x0002DA1C
		public unsafe EAkPanningRule PanningRule
		{
			get
			{
				return (EAkPanningRule)(*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_PanningRule));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_PanningRule) = (int)value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x0600200A RID: 8202 RVA: 0x0002F82D File Offset: 0x0002DA2D
		// (set) Token: 0x0600200B RID: 8203 RVA: 0x0002F83D File Offset: 0x0002DA3D
		public unsafe EAkChannelConfigType ChannelConfigType
		{
			get
			{
				return (EAkChannelConfigType)(*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_ChannelConfigType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_ChannelConfigType) = (int)value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x0600200C RID: 8204 RVA: 0x0002F84E File Offset: 0x0002DA4E
		// (set) Token: 0x0600200D RID: 8205 RVA: 0x0002F85E File Offset: 0x0002DA5E
		public unsafe uint ChannelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_ChannelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_ChannelMask) = (int)value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600200E RID: 8206 RVA: 0x0002F86F File Offset: 0x0002DA6F
		// (set) Token: 0x0600200F RID: 8207 RVA: 0x0002F87F File Offset: 0x0002DA7F
		public unsafe uint NumberOfChannels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_NumberOfChannels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkMainOutputSettings.__PropertyOffset_NumberOfChannels) = (int)value;
			}
		}

		// Token: 0x06002010 RID: 8208 RVA: 0x0002F890 File Offset: 0x0002DA90
		public FAkMainOutputSettings()
		{
		}

		// Token: 0x06002011 RID: 8209 RVA: 0x0002F898 File Offset: 0x0002DA98
		public FAkMainOutputSettings(string AudioDeviceShareSet, uint DeviceID, EAkPanningRule PanningRule, EAkChannelConfigType ChannelConfigType, uint ChannelMask, uint NumberOfChannels)
		{
			this.AudioDeviceShareSet = AudioDeviceShareSet;
			this.DeviceID = DeviceID;
			this.PanningRule = PanningRule;
			this.ChannelConfigType = ChannelConfigType;
			this.ChannelMask = ChannelMask;
			this.NumberOfChannels = NumberOfChannels;
		}

		// Token: 0x06002012 RID: 8210 RVA: 0x0002F8CD File Offset: 0x0002DACD
		protected override IntPtr GetUStructPtr()
		{
			return FAkMainOutputSettings.StaticStruct();
		}

		// Token: 0x06002013 RID: 8211 RVA: 0x0002F8D9 File Offset: 0x0002DAD9
		[NullableContext(2)]
		public FAkMainOutputSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x0002F8E3 File Offset: 0x0002DAE3
		public FAkMainOutputSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x0002F8EE File Offset: 0x0002DAEE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkMainOutputSettings(Pointer, false, true);
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x0002F8F8 File Offset: 0x0002DAF8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkMainOutputSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04000AB1 RID: 2737
		public const string __ObjectPath = "/Script/AkAudio.AkMainOutputSettings";

		// Token: 0x04000AB2 RID: 2738
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000AB3 RID: 2739
		internal static int __PropertyOffset_AudioDeviceShareSet;

		// Token: 0x04000AB4 RID: 2740
		internal static int __PropertyOffset_DeviceID;

		// Token: 0x04000AB5 RID: 2741
		internal static int __PropertyOffset_PanningRule;

		// Token: 0x04000AB6 RID: 2742
		internal static int __PropertyOffset_ChannelConfigType;

		// Token: 0x04000AB7 RID: 2743
		internal static int __PropertyOffset_ChannelMask;

		// Token: 0x04000AB8 RID: 2744
		internal static int __PropertyOffset_NumberOfChannels;
	}
}
