using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001F9 RID: 505
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkCommonInitializationSettings")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FAkCommonInitializationSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001DBC RID: 7612 RVA: 0x0002C343 File Offset: 0x0002A543
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkCommonInitializationSettings._ScriptStructPtr != 0) ? FAkCommonInitializationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkCommonInitializationSettings", ref FAkCommonInitializationSettings._ScriptStructPtr);
		}

		// Token: 0x17000778 RID: 1912
		// (get) Token: 0x06001DBD RID: 7613 RVA: 0x0002C367 File Offset: 0x0002A567
		// (set) Token: 0x06001DBE RID: 7614 RVA: 0x0002C377 File Offset: 0x0002A577
		public unsafe uint MaximumNumberOfMemoryPools
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MaximumNumberOfMemoryPools);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MaximumNumberOfMemoryPools) = (int)value;
			}
		}

		// Token: 0x17000779 RID: 1913
		// (get) Token: 0x06001DBF RID: 7615 RVA: 0x0002C388 File Offset: 0x0002A588
		// (set) Token: 0x06001DC0 RID: 7616 RVA: 0x0002C398 File Offset: 0x0002A598
		public unsafe uint MaximumNumberOfPositioningPaths
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MaximumNumberOfPositioningPaths);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MaximumNumberOfPositioningPaths) = (int)value;
			}
		}

		// Token: 0x1700077A RID: 1914
		// (get) Token: 0x06001DC1 RID: 7617 RVA: 0x0002C3A9 File Offset: 0x0002A5A9
		// (set) Token: 0x06001DC2 RID: 7618 RVA: 0x0002C3B9 File Offset: 0x0002A5B9
		public unsafe uint CommandQueueSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_CommandQueueSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_CommandQueueSize) = (int)value;
			}
		}

		// Token: 0x1700077B RID: 1915
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x0002C3CA File Offset: 0x0002A5CA
		// (set) Token: 0x06001DC4 RID: 7620 RVA: 0x0002C3DA File Offset: 0x0002A5DA
		public unsafe uint SamplesPerFrame
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_SamplesPerFrame);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_SamplesPerFrame) = (int)value;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0002C3EC File Offset: 0x0002A5EC
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x0002C42F File Offset: 0x0002A62F
		public FAkMainOutputSettings MainOutputSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkMainOutputSettings result;
				if ((result = this._MainOutputSettings) == null)
				{
					result = (this._MainOutputSettings = new FAkMainOutputSettings(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MainOutputSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkMainOutputSettings.StaticStruct(), base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_MainOutputSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x06001DC7 RID: 7623 RVA: 0x0002C450 File Offset: 0x0002A650
		// (set) Token: 0x06001DC8 RID: 7624 RVA: 0x0002C460 File Offset: 0x0002A660
		public unsafe float StreamingLookAheadRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_StreamingLookAheadRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_StreamingLookAheadRatio) = value;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x0002C471 File Offset: 0x0002A671
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x0002C481 File Offset: 0x0002A681
		public unsafe ushort NumberOfRefillsInVoice
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_NumberOfRefillsInVoice);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_NumberOfRefillsInVoice) = (short)value;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0002C494 File Offset: 0x0002A694
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x0002C4D7 File Offset: 0x0002A6D7
		public FAkSpatialAudioSettings SpatialAudioSettings
		{
			get
			{
				base.FastCheckIsValid();
				FAkSpatialAudioSettings result;
				if ((result = this._SpatialAudioSettings) == null)
				{
					result = (this._SpatialAudioSettings = new FAkSpatialAudioSettings(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_SpatialAudioSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkSpatialAudioSettings.StaticStruct(), base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_SpatialAudioSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0002C4F8 File Offset: 0x0002A6F8
		// (set) Token: 0x06001DCE RID: 7630 RVA: 0x0002C508 File Offset: 0x0002A708
		public unsafe uint WakeupDelayMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_WakeupDelayMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkCommonInitializationSettings.__PropertyOffset_WakeupDelayMs) = (int)value;
			}
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x0002C519 File Offset: 0x0002A719
		public FAkCommonInitializationSettings()
		{
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x0002C524 File Offset: 0x0002A724
		public FAkCommonInitializationSettings(uint MaximumNumberOfMemoryPools, uint MaximumNumberOfPositioningPaths, uint CommandQueueSize, uint SamplesPerFrame, FAkMainOutputSettings MainOutputSettings, float StreamingLookAheadRatio, ushort NumberOfRefillsInVoice, FAkSpatialAudioSettings SpatialAudioSettings, uint WakeupDelayMs)
		{
			this.MaximumNumberOfMemoryPools = MaximumNumberOfMemoryPools;
			this.MaximumNumberOfPositioningPaths = MaximumNumberOfPositioningPaths;
			this.CommandQueueSize = CommandQueueSize;
			this.SamplesPerFrame = SamplesPerFrame;
			this.MainOutputSettings = MainOutputSettings;
			this.StreamingLookAheadRatio = StreamingLookAheadRatio;
			this.NumberOfRefillsInVoice = NumberOfRefillsInVoice;
			this.SpatialAudioSettings = SpatialAudioSettings;
			this.WakeupDelayMs = WakeupDelayMs;
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x0002C57C File Offset: 0x0002A77C
		protected override IntPtr GetUStructPtr()
		{
			return FAkCommonInitializationSettings.StaticStruct();
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x0002C588 File Offset: 0x0002A788
		[NullableContext(2)]
		public FAkCommonInitializationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x0002C592 File Offset: 0x0002A792
		public FAkCommonInitializationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001DD4 RID: 7636 RVA: 0x0002C59D File Offset: 0x0002A79D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkCommonInitializationSettings(Pointer, false, true);
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x0002C5A7 File Offset: 0x0002A7A7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkCommonInitializationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040009D6 RID: 2518
		public const string __ObjectPath = "/Script/AkAudio.AkCommonInitializationSettings";

		// Token: 0x040009D7 RID: 2519
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009D8 RID: 2520
		internal static int __PropertyOffset_MaximumNumberOfMemoryPools;

		// Token: 0x040009D9 RID: 2521
		internal static int __PropertyOffset_MaximumNumberOfPositioningPaths;

		// Token: 0x040009DA RID: 2522
		internal static int __PropertyOffset_CommandQueueSize;

		// Token: 0x040009DB RID: 2523
		internal static int __PropertyOffset_SamplesPerFrame;

		// Token: 0x040009DC RID: 2524
		internal static int __PropertyOffset_MainOutputSettings;

		// Token: 0x040009DD RID: 2525
		[Nullable(2)]
		private FAkMainOutputSettings _MainOutputSettings;

		// Token: 0x040009DE RID: 2526
		internal static int __PropertyOffset_StreamingLookAheadRatio;

		// Token: 0x040009DF RID: 2527
		internal static int __PropertyOffset_NumberOfRefillsInVoice;

		// Token: 0x040009E0 RID: 2528
		internal static int __PropertyOffset_SpatialAudioSettings;

		// Token: 0x040009E1 RID: 2529
		[Nullable(2)]
		private FAkSpatialAudioSettings _SpatialAudioSettings;

		// Token: 0x040009E2 RID: 2530
		internal static int __PropertyOffset_WakeupDelayMs;
	}
}
