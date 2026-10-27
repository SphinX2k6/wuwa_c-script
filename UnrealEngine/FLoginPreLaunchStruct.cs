using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001740 RID: 5952
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroCloudGame.LoginPreLaunchStruct")]
	[UnrealStructLayout(144, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FLoginPreLaunchStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060156A5 RID: 87717 RVA: 0x001F78E6 File Offset: 0x001F5AE6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoginPreLaunchStruct._ScriptStructPtr != 0) ? FLoginPreLaunchStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroCloudGame.LoginPreLaunchStruct", ref FLoginPreLaunchStruct._ScriptStructPtr);
		}

		// Token: 0x17005491 RID: 21649
		// (get) Token: 0x060156A6 RID: 87718 RVA: 0x001F790A File Offset: 0x001F5B0A
		// (set) Token: 0x060156A7 RID: 87719 RVA: 0x001F791E File Offset: 0x001F5B1E
		public unsafe string Device
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Device)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Device)), value);
			}
		}

		// Token: 0x17005492 RID: 21650
		// (get) Token: 0x060156A8 RID: 87720 RVA: 0x001F7933 File Offset: 0x001F5B33
		// (set) Token: 0x060156A9 RID: 87721 RVA: 0x001F7947 File Offset: 0x001F5B47
		public unsafe string Platform
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Platform)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Platform)), value);
			}
		}

		// Token: 0x17005493 RID: 21651
		// (get) Token: 0x060156AA RID: 87722 RVA: 0x001F795C File Offset: 0x001F5B5C
		// (set) Token: 0x060156AB RID: 87723 RVA: 0x001F796C File Offset: 0x001F5B6C
		public unsafe int Dpi
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Dpi);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Dpi) = value;
			}
		}

		// Token: 0x17005494 RID: 21652
		// (get) Token: 0x060156AC RID: 87724 RVA: 0x001F797D File Offset: 0x001F5B7D
		// (set) Token: 0x060156AD RID: 87725 RVA: 0x001F798D File Offset: 0x001F5B8D
		public unsafe int Fps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Fps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_Fps) = value;
			}
		}

		// Token: 0x17005495 RID: 21653
		// (get) Token: 0x060156AE RID: 87726 RVA: 0x001F799E File Offset: 0x001F5B9E
		// (set) Token: 0x060156AF RID: 87727 RVA: 0x001F79B2 File Offset: 0x001F5BB2
		public unsafe string TraceId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_TraceId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginPreLaunchStruct.__PropertyOffset_TraceId)), value);
			}
		}

		// Token: 0x17005496 RID: 21654
		// (get) Token: 0x060156B0 RID: 87728 RVA: 0x001F79C7 File Offset: 0x001F5BC7
		// (set) Token: 0x060156B1 RID: 87729 RVA: 0x001F79DB File Offset: 0x001F5BDB
		public unsafe FDeviceResolution DeviceResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_DeviceResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_DeviceResolution) = value;
			}
		}

		// Token: 0x17005497 RID: 21655
		// (get) Token: 0x060156B2 RID: 87730 RVA: 0x001F79F0 File Offset: 0x001F5BF0
		// (set) Token: 0x060156B3 RID: 87731 RVA: 0x001F7A04 File Offset: 0x001F5C04
		public unsafe FScreenResolution ScreenResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_ScreenResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_ScreenResolution) = value;
			}
		}

		// Token: 0x17005498 RID: 21656
		// (get) Token: 0x060156B4 RID: 87732 RVA: 0x001F7A1C File Offset: 0x001F5C1C
		// (set) Token: 0x060156B5 RID: 87733 RVA: 0x001F7A5F File Offset: 0x001F5C5F
		public FLoginInfo LoginInfo
		{
			get
			{
				base.FastCheckIsValid();
				FLoginInfo result;
				if ((result = this._LoginInfo) == null)
				{
					result = (this._LoginInfo = new FLoginInfo(base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_LoginInfo, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLoginInfo.StaticStruct(), base.NativePtr + (IntPtr)FLoginPreLaunchStruct.__PropertyOffset_LoginInfo, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060156B6 RID: 87734 RVA: 0x001F7A80 File Offset: 0x001F5C80
		public FLoginPreLaunchStruct()
		{
		}

		// Token: 0x060156B7 RID: 87735 RVA: 0x001F7A88 File Offset: 0x001F5C88
		public FLoginPreLaunchStruct(string Device, string Platform, int Dpi, int Fps, string TraceId, FDeviceResolution DeviceResolution, FScreenResolution ScreenResolution, FLoginInfo LoginInfo)
		{
			this.Device = Device;
			this.Platform = Platform;
			this.Dpi = Dpi;
			this.Fps = Fps;
			this.TraceId = TraceId;
			this.DeviceResolution = DeviceResolution;
			this.ScreenResolution = ScreenResolution;
			this.LoginInfo = LoginInfo;
		}

		// Token: 0x060156B8 RID: 87736 RVA: 0x001F7AD8 File Offset: 0x001F5CD8
		protected override IntPtr GetUStructPtr()
		{
			return FLoginPreLaunchStruct.StaticStruct();
		}

		// Token: 0x060156B9 RID: 87737 RVA: 0x001F7AE4 File Offset: 0x001F5CE4
		[NullableContext(2)]
		public FLoginPreLaunchStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060156BA RID: 87738 RVA: 0x001F7AEE File Offset: 0x001F5CEE
		public FLoginPreLaunchStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060156BB RID: 87739 RVA: 0x001F7AF9 File Offset: 0x001F5CF9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoginPreLaunchStruct(Pointer, false, true);
		}

		// Token: 0x060156BC RID: 87740 RVA: 0x001F7B03 File Offset: 0x001F5D03
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoginPreLaunchStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400BAD2 RID: 47826
		public const string __ObjectPath = "/Script/KuroCloudGame.LoginPreLaunchStruct";

		// Token: 0x0400BAD3 RID: 47827
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BAD4 RID: 47828
		internal static int __PropertyOffset_Device;

		// Token: 0x0400BAD5 RID: 47829
		internal static int __PropertyOffset_Platform;

		// Token: 0x0400BAD6 RID: 47830
		internal static int __PropertyOffset_Dpi;

		// Token: 0x0400BAD7 RID: 47831
		internal static int __PropertyOffset_Fps;

		// Token: 0x0400BAD8 RID: 47832
		internal static int __PropertyOffset_TraceId;

		// Token: 0x0400BAD9 RID: 47833
		internal static int __PropertyOffset_DeviceResolution;

		// Token: 0x0400BADA RID: 47834
		internal static int __PropertyOffset_ScreenResolution;

		// Token: 0x0400BADB RID: 47835
		internal static int __PropertyOffset_LoginInfo;

		// Token: 0x0400BADC RID: 47836
		[Nullable(2)]
		private FLoginInfo _LoginInfo;
	}
}
