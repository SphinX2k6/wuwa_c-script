using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200022C RID: 556
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMusicSyncCallbackInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkMusicSyncCallbackInfo : UAkCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060020A0 RID: 8352 RVA: 0x00030742 File Offset: 0x0002E942
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMusicSyncCallbackInfo._ClassPtr;
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00030750 File Offset: 0x0002E950
		public UAkMusicSyncCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMusicSyncCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00030778 File Offset: 0x0002E978
		public UAkMusicSyncCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMusicSyncCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060020A3 RID: 8355 RVA: 0x000307AB File Offset: 0x0002E9AB
		// (set) Token: 0x060020A4 RID: 8356 RVA: 0x000307BB File Offset: 0x0002E9BB
		public unsafe int PlayingID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_PlayingID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_PlayingID) = value;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060020A5 RID: 8357 RVA: 0x000307CC File Offset: 0x0002E9CC
		// (set) Token: 0x060020A6 RID: 8358 RVA: 0x00030805 File Offset: 0x0002EA05
		public FAkSegmentInfo SegmentInfo
		{
			get
			{
				base.FastCheckIsValid();
				FAkSegmentInfo result;
				if ((result = this._SegmentInfo) == null)
				{
					result = (this._SegmentInfo = new FAkSegmentInfo(base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_SegmentInfo, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAkSegmentInfo.StaticStruct(), base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_SegmentInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060020A7 RID: 8359 RVA: 0x00030826 File Offset: 0x0002EA26
		// (set) Token: 0x060020A8 RID: 8360 RVA: 0x00030836 File Offset: 0x0002EA36
		public unsafe EAkCallbackType MusicSyncType
		{
			get
			{
				return (EAkCallbackType)(*(base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_MusicSyncType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_MusicSyncType) = (byte)value;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060020A9 RID: 8361 RVA: 0x00030847 File Offset: 0x0002EA47
		// (set) Token: 0x060020AA RID: 8362 RVA: 0x0003085B File Offset: 0x0002EA5B
		public unsafe string UserCueName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_UserCueName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UAkMusicSyncCallbackInfo.__PropertyOffset_UserCueName)), value);
			}
		}

		// Token: 0x060020AB RID: 8363 RVA: 0x00030870 File Offset: 0x0002EA70
		static UAkMusicSyncCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMusicSyncCallbackInfo");
		}

		// Token: 0x060020AC RID: 8364 RVA: 0x0003087E File Offset: 0x0002EA7E
		protected UAkMusicSyncCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000AF6 RID: 2806
		public new const string __ObjectPath = "/Script/AkAudio.AkMusicSyncCallbackInfo";

		// Token: 0x04000AF7 RID: 2807
		private static IntPtr _ClassPtr;

		// Token: 0x04000AF8 RID: 2808
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000AF9 RID: 2809
		internal static int __PropertyOffset_PlayingID;

		// Token: 0x04000AFA RID: 2810
		internal static int __PropertyOffset_SegmentInfo;

		// Token: 0x04000AFB RID: 2811
		[Nullable(2)]
		private FAkSegmentInfo _SegmentInfo;

		// Token: 0x04000AFC RID: 2812
		internal static int __PropertyOffset_MusicSyncType;

		// Token: 0x04000AFD RID: 2813
		internal static int __PropertyOffset_UserCueName;
	}
}
