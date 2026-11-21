using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000E6 RID: 230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraTrackingFocusSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FCameraTrackingFocusSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600101B RID: 4123 RVA: 0x00019BB5 File Offset: 0x00017DB5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraTrackingFocusSettings._ScriptStructPtr != 0) ? FCameraTrackingFocusSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraTrackingFocusSettings", ref FCameraTrackingFocusSettings._ScriptStructPtr);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x0600101C RID: 4124 RVA: 0x00019BD9 File Offset: 0x00017DD9
		// (set) Token: 0x0600101D RID: 4125 RVA: 0x00019BF8 File Offset: 0x00017DF8
		public TSoftObjectPtr<AActor> ActorToTrack
		{
			get
			{
				return new TSoftObjectPtr<AActor>(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_ActorToTrack, base.MemoryOwner ?? this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_ActorToTrack, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x0600101E RID: 4126 RVA: 0x00019C1D File Offset: 0x00017E1D
		// (set) Token: 0x0600101F RID: 4127 RVA: 0x00019C31 File Offset: 0x00017E31
		public unsafe FVector RelativeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_RelativeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_RelativeOffset) = value;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06001020 RID: 4128 RVA: 0x00019C46 File Offset: 0x00017E46
		// (set) Token: 0x06001021 RID: 4129 RVA: 0x00019C5F File Offset: 0x00017E5F
		public unsafe bool bDrawDebugTrackingFocusPoint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_bDrawDebugTrackingFocusPoint) & FCameraTrackingFocusSettings.__PropertyMask_bDrawDebugTrackingFocusPoint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_bDrawDebugTrackingFocusPoint) = ((*(base.NativePtr + (IntPtr)FCameraTrackingFocusSettings.__PropertyOffset_bDrawDebugTrackingFocusPoint) & ~FCameraTrackingFocusSettings.__PropertyMask_bDrawDebugTrackingFocusPoint) | (value ? FCameraTrackingFocusSettings.__PropertyMask_bDrawDebugTrackingFocusPoint : 0));
			}
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x00019C8F File Offset: 0x00017E8F
		public FCameraTrackingFocusSettings()
		{
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x00019C97 File Offset: 0x00017E97
		protected override IntPtr GetUStructPtr()
		{
			return FCameraTrackingFocusSettings.StaticStruct();
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00019CA3 File Offset: 0x00017EA3
		[NullableContext(2)]
		public FCameraTrackingFocusSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x00019CAD File Offset: 0x00017EAD
		public FCameraTrackingFocusSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x00019CB8 File Offset: 0x00017EB8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraTrackingFocusSettings(Pointer, false, true);
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00019CC2 File Offset: 0x00017EC2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraTrackingFocusSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040003BF RID: 959
		public const string __ObjectPath = "/Script/CinematicCamera.CameraTrackingFocusSettings";

		// Token: 0x040003C0 RID: 960
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040003C1 RID: 961
		internal static int __PropertyOffset_ActorToTrack;

		// Token: 0x040003C2 RID: 962
		internal static int __PropertyOffset_RelativeOffset;

		// Token: 0x040003C3 RID: 963
		internal static int __PropertyOffset_bDrawDebugTrackingFocusPoint;

		// Token: 0x040003C4 RID: 964
		internal static byte __PropertyMask_bDrawDebugTrackingFocusPoint;
	}
}
