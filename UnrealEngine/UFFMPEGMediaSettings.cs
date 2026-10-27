using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020012A1 RID: 4769
	[UnrealObjectPath("/Script/FFMPEGMediaFactory.FFMPEGMediaSettings")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UFFMPEGMediaSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060117AC RID: 71596 RVA: 0x0019A92E File Offset: 0x00198B2E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UFFMPEGMediaSettings._ClassPtr;
		}

		// Token: 0x060117AD RID: 71597 RVA: 0x0019A93C File Offset: 0x00198B3C
		public UFFMPEGMediaSettings() : this(BuiltinUtils.AllocNativeUObject(UFFMPEGMediaSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060117AE RID: 71598 RVA: 0x0019A964 File Offset: 0x00198B64
		[NullableContext(1)]
		public UFFMPEGMediaSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UFFMPEGMediaSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004426 RID: 17446
		// (get) Token: 0x060117AF RID: 71599 RVA: 0x0019A997 File Offset: 0x00198B97
		// (set) Token: 0x060117B0 RID: 71600 RVA: 0x0019A9A7 File Offset: 0x00198BA7
		public unsafe bool UseInfiniteBuffer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_UseInfiniteBuffer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_UseInfiniteBuffer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004427 RID: 17447
		// (get) Token: 0x060117B1 RID: 71601 RVA: 0x0019A9B8 File Offset: 0x00198BB8
		// (set) Token: 0x060117B2 RID: 71602 RVA: 0x0019A9C8 File Offset: 0x00198BC8
		public unsafe bool AllowFrameDrop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_AllowFrameDrop) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_AllowFrameDrop) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004428 RID: 17448
		// (get) Token: 0x060117B3 RID: 71603 RVA: 0x0019A9D9 File Offset: 0x00198BD9
		// (set) Token: 0x060117B4 RID: 71604 RVA: 0x0019A9E9 File Offset: 0x00198BE9
		public unsafe bool UseHardwareAcceleratedCodecs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_UseHardwareAcceleratedCodecs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_UseHardwareAcceleratedCodecs) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004429 RID: 17449
		// (get) Token: 0x060117B5 RID: 71605 RVA: 0x0019A9FA File Offset: 0x00198BFA
		// (set) Token: 0x060117B6 RID: 71606 RVA: 0x0019AA0A File Offset: 0x00198C0A
		public unsafe bool DisableAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_DisableAudio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_DisableAudio) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442A RID: 17450
		// (get) Token: 0x060117B7 RID: 71607 RVA: 0x0019AA1B File Offset: 0x00198C1B
		// (set) Token: 0x060117B8 RID: 71608 RVA: 0x0019AA2B File Offset: 0x00198C2B
		public unsafe bool ZeroLatencyStreaming
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_ZeroLatencyStreaming) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_ZeroLatencyStreaming) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442B RID: 17451
		// (get) Token: 0x060117B9 RID: 71609 RVA: 0x0019AA3C File Offset: 0x00198C3C
		// (set) Token: 0x060117BA RID: 71610 RVA: 0x0019AA4C File Offset: 0x00198C4C
		public unsafe ERTSPTransport RtspTransport
		{
			get
			{
				return (ERTSPTransport)(*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_RtspTransport));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_RtspTransport) = (byte)value;
			}
		}

		// Token: 0x1700442C RID: 17452
		// (get) Token: 0x060117BB RID: 71611 RVA: 0x0019AA5D File Offset: 0x00198C5D
		// (set) Token: 0x060117BC RID: 71612 RVA: 0x0019AA6D File Offset: 0x00198C6D
		public unsafe bool SpeedUpTricks
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_SpeedUpTricks) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_SpeedUpTricks) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700442D RID: 17453
		// (get) Token: 0x060117BD RID: 71613 RVA: 0x0019AA7E File Offset: 0x00198C7E
		// (set) Token: 0x060117BE RID: 71614 RVA: 0x0019AA8E File Offset: 0x00198C8E
		public unsafe int AudioThreads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_AudioThreads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_AudioThreads) = value;
			}
		}

		// Token: 0x1700442E RID: 17454
		// (get) Token: 0x060117BF RID: 71615 RVA: 0x0019AA9F File Offset: 0x00198C9F
		// (set) Token: 0x060117C0 RID: 71616 RVA: 0x0019AAAF File Offset: 0x00198CAF
		public unsafe int VideoThreads
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_VideoThreads);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_VideoThreads) = value;
			}
		}

		// Token: 0x1700442F RID: 17455
		// (get) Token: 0x060117C1 RID: 71617 RVA: 0x0019AAC0 File Offset: 0x00198CC0
		// (set) Token: 0x060117C2 RID: 71618 RVA: 0x0019AAD0 File Offset: 0x00198CD0
		public unsafe ESynchronizationType SyncType
		{
			get
			{
				return (ESynchronizationType)(*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_SyncType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UFFMPEGMediaSettings.__PropertyOffset_SyncType) = (byte)value;
			}
		}

		// Token: 0x060117C3 RID: 71619 RVA: 0x0019AAE1 File Offset: 0x00198CE1
		static UFFMPEGMediaSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/FFMPEGMediaFactory.FFMPEGMediaSettings");
		}

		// Token: 0x060117C4 RID: 71620 RVA: 0x0019AAEF File Offset: 0x00198CEF
		protected UFFMPEGMediaSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040095C2 RID: 38338
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/FFMPEGMediaFactory.FFMPEGMediaSettings";

		// Token: 0x040095C3 RID: 38339
		private static IntPtr _ClassPtr;

		// Token: 0x040095C4 RID: 38340
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040095C5 RID: 38341
		internal static int __PropertyOffset_UseInfiniteBuffer;

		// Token: 0x040095C6 RID: 38342
		internal static int __PropertyOffset_AllowFrameDrop;

		// Token: 0x040095C7 RID: 38343
		internal static int __PropertyOffset_UseHardwareAcceleratedCodecs;

		// Token: 0x040095C8 RID: 38344
		internal static int __PropertyOffset_DisableAudio;

		// Token: 0x040095C9 RID: 38345
		internal static int __PropertyOffset_ZeroLatencyStreaming;

		// Token: 0x040095CA RID: 38346
		internal static int __PropertyOffset_RtspTransport;

		// Token: 0x040095CB RID: 38347
		internal static int __PropertyOffset_SpeedUpTricks;

		// Token: 0x040095CC RID: 38348
		internal static int __PropertyOffset_AudioThreads;

		// Token: 0x040095CD RID: 38349
		internal static int __PropertyOffset_VideoThreads;

		// Token: 0x040095CE RID: 38350
		internal static int __PropertyOffset_SyncType;
	}
}
