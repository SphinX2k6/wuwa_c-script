using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000471 RID: 1137
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraFocusSettings")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FCameraFocusSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003CBC RID: 15548 RVA: 0x0005B679 File Offset: 0x00059879
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraFocusSettings._ScriptStructPtr != 0) ? FCameraFocusSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraFocusSettings", ref FCameraFocusSettings._ScriptStructPtr);
		}

		// Token: 0x17000EB8 RID: 3768
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x0005B69D File Offset: 0x0005989D
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x0005B6AD File Offset: 0x000598AD
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x0005B6BE File Offset: 0x000598BE
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x0005B6CE File Offset: 0x000598CE
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

		// Token: 0x17000EBA RID: 3770
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x0005B6E0 File Offset: 0x000598E0
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x0005B723 File Offset: 0x00059923
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

		// Token: 0x17000EBB RID: 3771
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x0005B744 File Offset: 0x00059944
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x0005B75D File Offset: 0x0005995D
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

		// Token: 0x17000EBC RID: 3772
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x0005B78D File Offset: 0x0005998D
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x0005B7A1 File Offset: 0x000599A1
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

		// Token: 0x17000EBD RID: 3773
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x0005B7B6 File Offset: 0x000599B6
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x0005B7CF File Offset: 0x000599CF
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

		// Token: 0x17000EBE RID: 3774
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x0005B7FF File Offset: 0x000599FF
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x0005B818 File Offset: 0x00059A18
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

		// Token: 0x17000EBF RID: 3775
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x0005B848 File Offset: 0x00059A48
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x0005B858 File Offset: 0x00059A58
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

		// Token: 0x17000EC0 RID: 3776
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x0005B869 File Offset: 0x00059A69
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x0005B879 File Offset: 0x00059A79
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

		// Token: 0x06003CCF RID: 15567 RVA: 0x0005B88A File Offset: 0x00059A8A
		public FCameraFocusSettings()
		{
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x0005B894 File Offset: 0x00059A94
		public FCameraFocusSettings(ECameraFocusMethod FocusMethod, float ManualFocusDistance, FCameraTrackingFocusSettings TrackingFocusSettings, bool bDrawDebugFocusPlane, FColor DebugFocusPlaneColor, bool bSmoothFocusChanges, bool bUseForegroundBlur, float FocusSmoothingInterpSpeed, float FocusOffset)
		{
			this.FocusMethod = FocusMethod;
			this.ManualFocusDistance = ManualFocusDistance;
			this.TrackingFocusSettings = TrackingFocusSettings;
			this.bDrawDebugFocusPlane = bDrawDebugFocusPlane;
			this.DebugFocusPlaneColor = DebugFocusPlaneColor;
			this.bSmoothFocusChanges = bSmoothFocusChanges;
			this.bUseForegroundBlur = bUseForegroundBlur;
			this.FocusSmoothingInterpSpeed = FocusSmoothingInterpSpeed;
			this.FocusOffset = FocusOffset;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x0005B8EC File Offset: 0x00059AEC
		protected override IntPtr GetUStructPtr()
		{
			return FCameraFocusSettings.StaticStruct();
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x0005B8F8 File Offset: 0x00059AF8
		[NullableContext(2)]
		public FCameraFocusSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x0005B902 File Offset: 0x00059B02
		public FCameraFocusSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003CD4 RID: 15572 RVA: 0x0005B90D File Offset: 0x00059B0D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraFocusSettings(Pointer, false, true);
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x0005B917 File Offset: 0x00059B17
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraFocusSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C78 RID: 7288
		public const string __ObjectPath = "/Script/CinematicCamera.CameraFocusSettings";

		// Token: 0x04001C79 RID: 7289
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C7A RID: 7290
		internal static int __PropertyOffset_FocusMethod;

		// Token: 0x04001C7B RID: 7291
		internal static int __PropertyOffset_ManualFocusDistance;

		// Token: 0x04001C7C RID: 7292
		internal static int __PropertyOffset_TrackingFocusSettings;

		// Token: 0x04001C7D RID: 7293
		[Nullable(2)]
		private FCameraTrackingFocusSettings _TrackingFocusSettings;

		// Token: 0x04001C7E RID: 7294
		internal static int __PropertyOffset_bDrawDebugFocusPlane;

		// Token: 0x04001C7F RID: 7295
		internal static byte __PropertyMask_bDrawDebugFocusPlane;

		// Token: 0x04001C80 RID: 7296
		internal static int __PropertyOffset_DebugFocusPlaneColor;

		// Token: 0x04001C81 RID: 7297
		internal static int __PropertyOffset_bSmoothFocusChanges;

		// Token: 0x04001C82 RID: 7298
		internal static byte __PropertyMask_bSmoothFocusChanges;

		// Token: 0x04001C83 RID: 7299
		internal static int __PropertyOffset_bUseForegroundBlur;

		// Token: 0x04001C84 RID: 7300
		internal static byte __PropertyMask_bUseForegroundBlur;

		// Token: 0x04001C85 RID: 7301
		internal static int __PropertyOffset_FocusSmoothingInterpSpeed;

		// Token: 0x04001C86 RID: 7302
		internal static int __PropertyOffset_FocusOffset;
	}
}
