using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000476 RID: 1142
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CinematicCamera.CameraTrackingFocusSettings")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FCameraTrackingFocusSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003D26 RID: 15654 RVA: 0x0005BF91 File Offset: 0x0005A191
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCameraTrackingFocusSettings._ScriptStructPtr != 0) ? FCameraTrackingFocusSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CinematicCamera.CameraTrackingFocusSettings", ref FCameraTrackingFocusSettings._ScriptStructPtr);
		}

		// Token: 0x17000EDB RID: 3803
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x0005BFB5 File Offset: 0x0005A1B5
		// (set) Token: 0x06003D28 RID: 15656 RVA: 0x0005BFD4 File Offset: 0x0005A1D4
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

		// Token: 0x17000EDC RID: 3804
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x0005BFF9 File Offset: 0x0005A1F9
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x0005C00D File Offset: 0x0005A20D
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

		// Token: 0x17000EDD RID: 3805
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x0005C022 File Offset: 0x0005A222
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x0005C03B File Offset: 0x0005A23B
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

		// Token: 0x06003D2D RID: 15661 RVA: 0x0005C06B File Offset: 0x0005A26B
		public FCameraTrackingFocusSettings()
		{
		}

		// Token: 0x06003D2E RID: 15662 RVA: 0x0005C073 File Offset: 0x0005A273
		public FCameraTrackingFocusSettings(TSoftObjectPtr<AActor> ActorToTrack, FVector RelativeOffset, bool bDrawDebugTrackingFocusPoint)
		{
			this.ActorToTrack = ActorToTrack;
			this.RelativeOffset = RelativeOffset;
			this.bDrawDebugTrackingFocusPoint = bDrawDebugTrackingFocusPoint;
		}

		// Token: 0x06003D2F RID: 15663 RVA: 0x0005C090 File Offset: 0x0005A290
		protected override IntPtr GetUStructPtr()
		{
			return FCameraTrackingFocusSettings.StaticStruct();
		}

		// Token: 0x06003D30 RID: 15664 RVA: 0x0005C09C File Offset: 0x0005A29C
		[NullableContext(2)]
		public FCameraTrackingFocusSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003D31 RID: 15665 RVA: 0x0005C0A6 File Offset: 0x0005A2A6
		public FCameraTrackingFocusSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x0005C0B1 File Offset: 0x0005A2B1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCameraTrackingFocusSettings(Pointer, false, true);
		}

		// Token: 0x06003D33 RID: 15667 RVA: 0x0005C0BB File Offset: 0x0005A2BB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCameraTrackingFocusSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001CAE RID: 7342
		public const string __ObjectPath = "/Script/CinematicCamera.CameraTrackingFocusSettings";

		// Token: 0x04001CAF RID: 7343
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001CB0 RID: 7344
		internal static int __PropertyOffset_ActorToTrack;

		// Token: 0x04001CB1 RID: 7345
		internal static int __PropertyOffset_RelativeOffset;

		// Token: 0x04001CB2 RID: 7346
		internal static int __PropertyOffset_bDrawDebugTrackingFocusPoint;

		// Token: 0x04001CB3 RID: 7347
		internal static byte __PropertyMask_bDrawDebugTrackingFocusPoint;
	}
}
