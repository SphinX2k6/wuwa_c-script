using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000473 RID: 1139
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraLookatTrackingSettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FCameraLookatTrackingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003CEA RID: 15594 RVA: 0x0005BA7B File Offset: 0x00059C7B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraLookatTrackingSettings._ScriptStructPtr != 0) ? FCameraLookatTrackingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraLookatTrackingSettings", ref FCameraLookatTrackingSettings._ScriptStructPtr);
		}

		// Token: 0x17000EC7 RID: 3783
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x0005BA9F File Offset: 0x00059C9F
		// (set) Token: 0x06003CEC RID: 15596 RVA: 0x0005BAB8 File Offset: 0x00059CB8
		public unsafe bool bEnableLookAtTracking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bEnableLookAtTracking) & FCameraLookatTrackingSettings.__PropertyMask_bEnableLookAtTracking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bEnableLookAtTracking) = ((*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bEnableLookAtTracking) & ~FCameraLookatTrackingSettings.__PropertyMask_bEnableLookAtTracking) | (value ? FCameraLookatTrackingSettings.__PropertyMask_bEnableLookAtTracking : 0));
			}
		}

		// Token: 0x17000EC8 RID: 3784
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x0005BAE8 File Offset: 0x00059CE8
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x0005BB01 File Offset: 0x00059D01
		public unsafe bool bDrawDebugLookAtTrackingPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bDrawDebugLookAtTrackingPosition) & FCameraLookatTrackingSettings.__PropertyMask_bDrawDebugLookAtTrackingPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bDrawDebugLookAtTrackingPosition) = ((*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bDrawDebugLookAtTrackingPosition) & ~FCameraLookatTrackingSettings.__PropertyMask_bDrawDebugLookAtTrackingPosition) | (value ? FCameraLookatTrackingSettings.__PropertyMask_bDrawDebugLookAtTrackingPosition : 0));
			}
		}

		// Token: 0x17000EC9 RID: 3785
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x0005BB31 File Offset: 0x00059D31
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x0005BB41 File Offset: 0x00059D41
		public unsafe float LookAtTrackingInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_LookAtTrackingInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_LookAtTrackingInterpSpeed) = value;
			}
		}

		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x0005BB52 File Offset: 0x00059D52
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x0005BB71 File Offset: 0x00059D71
		public TSoftObjectPtr<AActor> ActorToTrack
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_ActorToTrack, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_ActorToTrack, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x0005BB96 File Offset: 0x00059D96
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x0005BBAA File Offset: 0x00059DAA
		public unsafe FVector RelativeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_RelativeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_RelativeOffset) = value;
			}
		}

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x0005BBBF File Offset: 0x00059DBF
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x0005BBD8 File Offset: 0x00059DD8
		public unsafe bool bAllowRoll
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bAllowRoll) & FCameraLookatTrackingSettings.__PropertyMask_bAllowRoll) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bAllowRoll) = ((*(base.NativePtr + (IntPtr)FCameraLookatTrackingSettings.__PropertyOffset_bAllowRoll) & ~FCameraLookatTrackingSettings.__PropertyMask_bAllowRoll) | (value ? FCameraLookatTrackingSettings.__PropertyMask_bAllowRoll : 0));
			}
		}

		// Token: 0x06003CF7 RID: 15607 RVA: 0x0005BC08 File Offset: 0x00059E08
		public FCameraLookatTrackingSettings()
		{
		}

		// Token: 0x06003CF8 RID: 15608 RVA: 0x0005BC10 File Offset: 0x00059E10
		public FCameraLookatTrackingSettings(bool bEnableLookAtTracking, bool bDrawDebugLookAtTrackingPosition, float LookAtTrackingInterpSpeed, TSoftObjectPtr<AActor> ActorToTrack, FVector RelativeOffset, bool bAllowRoll)
		{
			this.bEnableLookAtTracking = bEnableLookAtTracking;
			this.bDrawDebugLookAtTrackingPosition = bDrawDebugLookAtTrackingPosition;
			this.LookAtTrackingInterpSpeed = LookAtTrackingInterpSpeed;
			this.ActorToTrack = ActorToTrack;
			this.RelativeOffset = RelativeOffset;
			this.bAllowRoll = bAllowRoll;
		}

		// Token: 0x06003CF9 RID: 15609 RVA: 0x0005BC45 File Offset: 0x00059E45
		protected override IntPtr GetUStructPtr()
		{
			return FCameraLookatTrackingSettings.StaticStruct();
		}

		// Token: 0x06003CFA RID: 15610 RVA: 0x0005BC51 File Offset: 0x00059E51
		[NullableContext(2)]
		public FCameraLookatTrackingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003CFB RID: 15611 RVA: 0x0005BC5B File Offset: 0x00059E5B
		public FCameraLookatTrackingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0005BC66 File Offset: 0x00059E66
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraLookatTrackingSettings(Pointer, false, true);
		}

		// Token: 0x06003CFD RID: 15613 RVA: 0x0005BC70 File Offset: 0x00059E70
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraLookatTrackingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001C8F RID: 7311
		public const string __ObjectPath = "/Script/CinematicCamera.CameraLookatTrackingSettings";

		// Token: 0x04001C90 RID: 7312
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C91 RID: 7313
		internal static int __PropertyOffset_bEnableLookAtTracking;

		// Token: 0x04001C92 RID: 7314
		internal static byte __PropertyMask_bEnableLookAtTracking;

		// Token: 0x04001C93 RID: 7315
		internal static int __PropertyOffset_bDrawDebugLookAtTrackingPosition;

		// Token: 0x04001C94 RID: 7316
		internal static byte __PropertyMask_bDrawDebugLookAtTrackingPosition;

		// Token: 0x04001C95 RID: 7317
		internal static int __PropertyOffset_LookAtTrackingInterpSpeed;

		// Token: 0x04001C96 RID: 7318
		internal static int __PropertyOffset_ActorToTrack;

		// Token: 0x04001C97 RID: 7319
		internal static int __PropertyOffset_RelativeOffset;

		// Token: 0x04001C98 RID: 7320
		internal static int __PropertyOffset_bAllowRoll;

		// Token: 0x04001C99 RID: 7321
		internal static byte __PropertyMask_bAllowRoll;
	}
}
