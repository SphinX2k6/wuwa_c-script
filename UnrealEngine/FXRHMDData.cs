using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001472 RID: 5234
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRHMDData")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FXRHMDData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013171 RID: 78193 RVA: 0x001C1411 File Offset: 0x001BF611
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXRHMDData._ScriptStructPtr != 0) ? FXRHMDData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HeadMountedDisplay.XRHMDData", ref FXRHMDData._ScriptStructPtr);
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x06013172 RID: 78194 RVA: 0x001C1435 File Offset: 0x001BF635
		// (set) Token: 0x06013173 RID: 78195 RVA: 0x001C1445 File Offset: 0x001BF645
		public unsafe bool bValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_bValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_bValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x06013174 RID: 78196 RVA: 0x001C1456 File Offset: 0x001BF656
		// (set) Token: 0x06013175 RID: 78197 RVA: 0x001C146A File Offset: 0x001BF66A
		public unsafe FName DeviceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_DeviceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_DeviceName) = value;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x06013176 RID: 78198 RVA: 0x001C147F File Offset: 0x001BF67F
		// (set) Token: 0x06013177 RID: 78199 RVA: 0x001C1493 File Offset: 0x001BF693
		public unsafe FGuid ApplicationInstanceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_ApplicationInstanceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_ApplicationInstanceID) = value;
			}
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x06013178 RID: 78200 RVA: 0x001C14A8 File Offset: 0x001BF6A8
		// (set) Token: 0x06013179 RID: 78201 RVA: 0x001C14B8 File Offset: 0x001BF6B8
		public unsafe ETrackingStatus TrackingStatus
		{
			get
			{
				return (ETrackingStatus)(*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_TrackingStatus));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_TrackingStatus) = (byte)value;
			}
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x0601317A RID: 78202 RVA: 0x001C14C9 File Offset: 0x001BF6C9
		// (set) Token: 0x0601317B RID: 78203 RVA: 0x001C14DD File Offset: 0x001BF6DD
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x0601317C RID: 78204 RVA: 0x001C14F2 File Offset: 0x001BF6F2
		// (set) Token: 0x0601317D RID: 78205 RVA: 0x001C1506 File Offset: 0x001BF706
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRHMDData.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x0601317E RID: 78206 RVA: 0x001C151B File Offset: 0x001BF71B
		public FXRHMDData()
		{
		}

		// Token: 0x0601317F RID: 78207 RVA: 0x001C1523 File Offset: 0x001BF723
		public FXRHMDData(bool bValid, FName DeviceName, FGuid ApplicationInstanceID, ETrackingStatus TrackingStatus, FVector Position, FQuat Rotation)
		{
			this.bValid = bValid;
			this.DeviceName = DeviceName;
			this.ApplicationInstanceID = ApplicationInstanceID;
			this.TrackingStatus = TrackingStatus;
			this.Position = Position;
			this.Rotation = Rotation;
		}

		// Token: 0x06013180 RID: 78208 RVA: 0x001C1558 File Offset: 0x001BF758
		protected override IntPtr GetUStructPtr()
		{
			return FXRHMDData.StaticStruct();
		}

		// Token: 0x06013181 RID: 78209 RVA: 0x001C1564 File Offset: 0x001BF764
		[NullableContext(2)]
		public FXRHMDData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013182 RID: 78210 RVA: 0x001C156E File Offset: 0x001BF76E
		public FXRHMDData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013183 RID: 78211 RVA: 0x001C1579 File Offset: 0x001BF779
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXRHMDData(Pointer, false, true);
		}

		// Token: 0x06013184 RID: 78212 RVA: 0x001C1583 File Offset: 0x001BF783
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXRHMDData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A3BE RID: 41918
		[Nullable(1)]
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRHMDData";

		// Token: 0x0400A3BF RID: 41919
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A3C0 RID: 41920
		internal static int __PropertyOffset_bValid;

		// Token: 0x0400A3C1 RID: 41921
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x0400A3C2 RID: 41922
		internal static int __PropertyOffset_ApplicationInstanceID;

		// Token: 0x0400A3C3 RID: 41923
		internal static int __PropertyOffset_TrackingStatus;

		// Token: 0x0400A3C4 RID: 41924
		internal static int __PropertyOffset_Position;

		// Token: 0x0400A3C5 RID: 41925
		internal static int __PropertyOffset_Rotation;
	}
}
