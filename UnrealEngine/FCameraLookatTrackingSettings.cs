using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E5 RID: 229
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraLookatTrackingSettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FCameraLookatTrackingSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001008 RID: 4104 RVA: 0x000199EC File Offset: 0x00017BEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraLookatTrackingSettings._ScriptStructPtr != 0) ? FCameraLookatTrackingSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraLookatTrackingSettings", ref FCameraLookatTrackingSettings._ScriptStructPtr);
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06001009 RID: 4105 RVA: 0x00019A10 File Offset: 0x00017C10
		// (set) Token: 0x0600100A RID: 4106 RVA: 0x00019A29 File Offset: 0x00017C29
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

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600100B RID: 4107 RVA: 0x00019A59 File Offset: 0x00017C59
		// (set) Token: 0x0600100C RID: 4108 RVA: 0x00019A72 File Offset: 0x00017C72
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

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600100D RID: 4109 RVA: 0x00019AA2 File Offset: 0x00017CA2
		// (set) Token: 0x0600100E RID: 4110 RVA: 0x00019AB2 File Offset: 0x00017CB2
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

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600100F RID: 4111 RVA: 0x00019AC3 File Offset: 0x00017CC3
		// (set) Token: 0x06001010 RID: 4112 RVA: 0x00019AE2 File Offset: 0x00017CE2
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

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06001011 RID: 4113 RVA: 0x00019B07 File Offset: 0x00017D07
		// (set) Token: 0x06001012 RID: 4114 RVA: 0x00019B1B File Offset: 0x00017D1B
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

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06001013 RID: 4115 RVA: 0x00019B30 File Offset: 0x00017D30
		// (set) Token: 0x06001014 RID: 4116 RVA: 0x00019B49 File Offset: 0x00017D49
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

		// Token: 0x06001015 RID: 4117 RVA: 0x00019B79 File Offset: 0x00017D79
		public FCameraLookatTrackingSettings()
		{
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x00019B81 File Offset: 0x00017D81
		protected override IntPtr GetUStructPtr()
		{
			return FCameraLookatTrackingSettings.StaticStruct();
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x00019B8D File Offset: 0x00017D8D
		[NullableContext(2)]
		public FCameraLookatTrackingSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x00019B97 File Offset: 0x00017D97
		public FCameraLookatTrackingSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x00019BA2 File Offset: 0x00017DA2
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraLookatTrackingSettings(Pointer, false, true);
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00019BAC File Offset: 0x00017DAC
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraLookatTrackingSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040003B4 RID: 948
		public const string __ObjectPath = "/Script/CinematicCamera.CameraLookatTrackingSettings";

		// Token: 0x040003B5 RID: 949
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003B6 RID: 950
		internal static int __PropertyOffset_bEnableLookAtTracking;

		// Token: 0x040003B7 RID: 951
		internal static byte __PropertyMask_bEnableLookAtTracking;

		// Token: 0x040003B8 RID: 952
		internal static int __PropertyOffset_bDrawDebugLookAtTrackingPosition;

		// Token: 0x040003B9 RID: 953
		internal static byte __PropertyMask_bDrawDebugLookAtTrackingPosition;

		// Token: 0x040003BA RID: 954
		internal static int __PropertyOffset_LookAtTrackingInterpSpeed;

		// Token: 0x040003BB RID: 955
		internal static int __PropertyOffset_ActorToTrack;

		// Token: 0x040003BC RID: 956
		internal static int __PropertyOffset_RelativeOffset;

		// Token: 0x040003BD RID: 957
		internal static int __PropertyOffset_bAllowRoll;

		// Token: 0x040003BE RID: 958
		internal static byte __PropertyMask_bAllowRoll;
	}
}
