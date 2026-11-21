using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000CA RID: 202
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.AkMusicSyncCallbackInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public class UAkMusicSyncCallbackInfo : UAkCallbackInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000EF2 RID: 3826 RVA: 0x000172B6 File Offset: 0x000154B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAkMusicSyncCallbackInfo._ClassPtr;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x000172C4 File Offset: 0x000154C4
		public UAkMusicSyncCallbackInfo() : this(BuiltinUtils.AllocNativeUObject(UAkMusicSyncCallbackInfo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x000172EC File Offset: 0x000154EC
		public UAkMusicSyncCallbackInfo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAkMusicSyncCallbackInfo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x06000EF5 RID: 3829 RVA: 0x0001731F File Offset: 0x0001551F
		// (set) Token: 0x06000EF6 RID: 3830 RVA: 0x0001732F File Offset: 0x0001552F
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

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00017340 File Offset: 0x00015540
		// (set) Token: 0x06000EF8 RID: 3832 RVA: 0x00017379 File Offset: 0x00015579
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

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x0001739A File Offset: 0x0001559A
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000173AA File Offset: 0x000155AA
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

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000173BB File Offset: 0x000155BB
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x000173CF File Offset: 0x000155CF
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

		// Token: 0x06000EFD RID: 3837 RVA: 0x000173E4 File Offset: 0x000155E4
		static UAkMusicSyncCallbackInfo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.AkMusicSyncCallbackInfo");
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x000173F2 File Offset: 0x000155F2
		protected UAkMusicSyncCallbackInfo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040002F2 RID: 754
		public new const string __ObjectPath = "/Script/AkAudio.AkMusicSyncCallbackInfo";

		// Token: 0x040002F3 RID: 755
		private static IntPtr _ClassPtr;

		// Token: 0x040002F4 RID: 756
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040002F5 RID: 757
		internal static int __PropertyOffset_PlayingID;

		// Token: 0x040002F6 RID: 758
		internal static int __PropertyOffset_SegmentInfo;

		// Token: 0x040002F7 RID: 759
		[Nullable(2)]
		private FAkSegmentInfo _SegmentInfo;

		// Token: 0x040002F8 RID: 760
		internal static int __PropertyOffset_MusicSyncType;

		// Token: 0x040002F9 RID: 761
		internal static int __PropertyOffset_UserCueName;
	}
}
