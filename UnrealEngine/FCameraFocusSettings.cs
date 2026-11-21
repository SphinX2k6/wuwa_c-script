using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000E3 RID: 227
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraFocusSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCameraFocusSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06000FDC RID: 4060 RVA: 0x00019677 File Offset: 0x00017877
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraFocusSettings._ScriptStructPtr != 0) ? FCameraFocusSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraFocusSettings", ref FCameraFocusSettings._ScriptStructPtr);
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06000FDD RID: 4061 RVA: 0x0001969B File Offset: 0x0001789B
		// (set) Token: 0x06000FDE RID: 4062 RVA: 0x000196AB File Offset: 0x000178AB
		public unsafe ECameraFocusMethod FocusMethod
		{
			get
			{
				return (ECameraFocusMethod)(*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusMethod) = (byte)value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000FDF RID: 4063 RVA: 0x000196BC File Offset: 0x000178BC
		// (set) Token: 0x06000FE0 RID: 4064 RVA: 0x000196CC File Offset: 0x000178CC
		public unsafe float ManualFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_ManualFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_ManualFocusDistance) = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000196E0 File Offset: 0x000178E0
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x00019723 File Offset: 0x00017923
		public FCameraTrackingFocusSettings TrackingFocusSettings
		{
			get
			{
				base.FastCheckIsValid();
				FCameraTrackingFocusSettings result;
				if ((result = this._TrackingFocusSettings) == null)
				{
					result = (this._TrackingFocusSettings = new FCameraTrackingFocusSettings(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_TrackingFocusSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCameraTrackingFocusSettings.StaticStruct(), base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_TrackingFocusSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x00019744 File Offset: 0x00017944
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x0001975D File Offset: 0x0001795D
		public unsafe bool bDrawDebugFocusPlane
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bDrawDebugFocusPlane) & FCameraFocusSettings.__PropertyMask_bDrawDebugFocusPlane) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bDrawDebugFocusPlane) = ((*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bDrawDebugFocusPlane) & ~FCameraFocusSettings.__PropertyMask_bDrawDebugFocusPlane) | (value ? FCameraFocusSettings.__PropertyMask_bDrawDebugFocusPlane : 0));
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000FE5 RID: 4069 RVA: 0x0001978D File Offset: 0x0001798D
		// (set) Token: 0x06000FE6 RID: 4070 RVA: 0x000197A1 File Offset: 0x000179A1
		public unsafe FColor DebugFocusPlaneColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_DebugFocusPlaneColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_DebugFocusPlaneColor) = value;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000FE7 RID: 4071 RVA: 0x000197B6 File Offset: 0x000179B6
		// (set) Token: 0x06000FE8 RID: 4072 RVA: 0x000197CF File Offset: 0x000179CF
		public unsafe bool bSmoothFocusChanges
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bSmoothFocusChanges) & FCameraFocusSettings.__PropertyMask_bSmoothFocusChanges) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bSmoothFocusChanges) = ((*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bSmoothFocusChanges) & ~FCameraFocusSettings.__PropertyMask_bSmoothFocusChanges) | (value ? FCameraFocusSettings.__PropertyMask_bSmoothFocusChanges : 0));
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000FE9 RID: 4073 RVA: 0x000197FF File Offset: 0x000179FF
		// (set) Token: 0x06000FEA RID: 4074 RVA: 0x00019818 File Offset: 0x00017A18
		public unsafe bool bUseForegroundBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bUseForegroundBlur) & FCameraFocusSettings.__PropertyMask_bUseForegroundBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bUseForegroundBlur) = ((*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_bUseForegroundBlur) & ~FCameraFocusSettings.__PropertyMask_bUseForegroundBlur) | (value ? FCameraFocusSettings.__PropertyMask_bUseForegroundBlur : 0));
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000FEB RID: 4075 RVA: 0x00019848 File Offset: 0x00017A48
		// (set) Token: 0x06000FEC RID: 4076 RVA: 0x00019858 File Offset: 0x00017A58
		public unsafe float FocusSmoothingInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusSmoothingInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusSmoothingInterpSpeed) = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000FED RID: 4077 RVA: 0x00019869 File Offset: 0x00017A69
		// (set) Token: 0x06000FEE RID: 4078 RVA: 0x00019879 File Offset: 0x00017A79
		public unsafe float FocusOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraFocusSettings.__PropertyOffset_FocusOffset) = value;
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x0001988A File Offset: 0x00017A8A
		public FCameraFocusSettings()
		{
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00019892 File Offset: 0x00017A92
		protected override IntPtr GetUStructPtr()
		{
			return FCameraFocusSettings.StaticStruct();
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x0001989E File Offset: 0x00017A9E
		[NullableContext(2)]
		public FCameraFocusSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x000198A8 File Offset: 0x00017AA8
		public FCameraFocusSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x000198B3 File Offset: 0x00017AB3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraFocusSettings(Pointer, false, true);
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x000198BD File Offset: 0x00017ABD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraFocusSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400039D RID: 925
		public const string __ObjectPath = "/Script/CinematicCamera.CameraFocusSettings";

		// Token: 0x0400039E RID: 926
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400039F RID: 927
		internal static int __PropertyOffset_FocusMethod;

		// Token: 0x040003A0 RID: 928
		internal static int __PropertyOffset_ManualFocusDistance;

		// Token: 0x040003A1 RID: 929
		internal static int __PropertyOffset_TrackingFocusSettings;

		// Token: 0x040003A2 RID: 930
		[Nullable(2)]
		private FCameraTrackingFocusSettings _TrackingFocusSettings;

		// Token: 0x040003A3 RID: 931
		internal static int __PropertyOffset_bDrawDebugFocusPlane;

		// Token: 0x040003A4 RID: 932
		internal static byte __PropertyMask_bDrawDebugFocusPlane;

		// Token: 0x040003A5 RID: 933
		internal static int __PropertyOffset_DebugFocusPlaneColor;

		// Token: 0x040003A6 RID: 934
		internal static int __PropertyOffset_bSmoothFocusChanges;

		// Token: 0x040003A7 RID: 935
		internal static byte __PropertyMask_bSmoothFocusChanges;

		// Token: 0x040003A8 RID: 936
		internal static int __PropertyOffset_bUseForegroundBlur;

		// Token: 0x040003A9 RID: 937
		internal static byte __PropertyMask_bUseForegroundBlur;

		// Token: 0x040003AA RID: 938
		internal static int __PropertyOffset_FocusSmoothingInterpSpeed;

		// Token: 0x040003AB RID: 939
		internal static int __PropertyOffset_FocusOffset;
	}
}
