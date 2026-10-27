using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001474 RID: 5236
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.XRMotionControllerData")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FXRMotionControllerData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013191 RID: 78225 RVA: 0x001C16C3 File Offset: 0x001BF8C3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXRMotionControllerData._ScriptStructPtr != 0) ? FXRMotionControllerData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/HeadMountedDisplay.XRMotionControllerData", ref FXRMotionControllerData._ScriptStructPtr);
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x06013192 RID: 78226 RVA: 0x001C16E7 File Offset: 0x001BF8E7
		// (set) Token: 0x06013193 RID: 78227 RVA: 0x001C16F7 File Offset: 0x001BF8F7
		public unsafe bool bValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_bValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_bValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x06013194 RID: 78228 RVA: 0x001C1708 File Offset: 0x001BF908
		// (set) Token: 0x06013195 RID: 78229 RVA: 0x001C171C File Offset: 0x001BF91C
		public unsafe FName DeviceName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_DeviceName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_DeviceName) = value;
			}
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x06013196 RID: 78230 RVA: 0x001C1731 File Offset: 0x001BF931
		// (set) Token: 0x06013197 RID: 78231 RVA: 0x001C1745 File Offset: 0x001BF945
		public unsafe FGuid ApplicationInstanceID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_ApplicationInstanceID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_ApplicationInstanceID) = value;
			}
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x06013198 RID: 78232 RVA: 0x001C175A File Offset: 0x001BF95A
		// (set) Token: 0x06013199 RID: 78233 RVA: 0x001C176A File Offset: 0x001BF96A
		public unsafe EXRVisualType DeviceVisualType
		{
			get
			{
				return (EXRVisualType)(*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_DeviceVisualType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_DeviceVisualType) = (byte)value;
			}
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x0601319A RID: 78234 RVA: 0x001C177B File Offset: 0x001BF97B
		// (set) Token: 0x0601319B RID: 78235 RVA: 0x001C178B File Offset: 0x001BF98B
		public unsafe EControllerHand HandIndex
		{
			get
			{
				return (EControllerHand)(*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_HandIndex));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_HandIndex) = (byte)value;
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x0601319C RID: 78236 RVA: 0x001C179C File Offset: 0x001BF99C
		// (set) Token: 0x0601319D RID: 78237 RVA: 0x001C17AC File Offset: 0x001BF9AC
		public unsafe ETrackingStatus TrackingStatus
		{
			get
			{
				return (ETrackingStatus)(*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_TrackingStatus));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_TrackingStatus) = (byte)value;
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x0601319E RID: 78238 RVA: 0x001C17BD File Offset: 0x001BF9BD
		// (set) Token: 0x0601319F RID: 78239 RVA: 0x001C17D1 File Offset: 0x001BF9D1
		public unsafe FVector GripPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_GripPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_GripPosition) = value;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x060131A0 RID: 78240 RVA: 0x001C17E6 File Offset: 0x001BF9E6
		// (set) Token: 0x060131A1 RID: 78241 RVA: 0x001C17FA File Offset: 0x001BF9FA
		public unsafe FQuat GripRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_GripRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_GripRotation) = value;
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x060131A2 RID: 78242 RVA: 0x001C180F File Offset: 0x001BFA0F
		// (set) Token: 0x060131A3 RID: 78243 RVA: 0x001C1823 File Offset: 0x001BFA23
		public unsafe FVector AimPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_AimPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_AimPosition) = value;
			}
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x060131A4 RID: 78244 RVA: 0x001C1838 File Offset: 0x001BFA38
		// (set) Token: 0x060131A5 RID: 78245 RVA: 0x001C184C File Offset: 0x001BFA4C
		public unsafe FQuat AimRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_AimRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_AimRotation) = value;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x060131A6 RID: 78246 RVA: 0x001C1864 File Offset: 0x001BFA64
		// (set) Token: 0x060131A7 RID: 78247 RVA: 0x001C18A7 File Offset: 0x001BFAA7
		public TArray<FVector> HandKeyPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._HandKeyPositions) == null)
				{
					result = (this._HandKeyPositions = new TArray<FVector>(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_HandKeyPositions, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HandKeyPositions.CopyAssign(value);
			}
		}

		// Token: 0x17004A35 RID: 18997
		// (get) Token: 0x060131A8 RID: 78248 RVA: 0x001C18B8 File Offset: 0x001BFAB8
		// (set) Token: 0x060131A9 RID: 78249 RVA: 0x001C18FB File Offset: 0x001BFAFB
		public TArray<FQuat> HandKeyRotations
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FQuat> result;
				if ((result = this._HandKeyRotations) == null)
				{
					result = (this._HandKeyRotations = new TArray<FQuat>(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_HandKeyRotations, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HandKeyRotations.CopyAssign(value);
			}
		}

		// Token: 0x17004A36 RID: 18998
		// (get) Token: 0x060131AA RID: 78250 RVA: 0x001C190C File Offset: 0x001BFB0C
		// (set) Token: 0x060131AB RID: 78251 RVA: 0x001C194F File Offset: 0x001BFB4F
		public TArray<float> HandKeyRadii
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._HandKeyRadii) == null)
				{
					result = (this._HandKeyRadii = new TArray<float>(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_HandKeyRadii, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HandKeyRadii.CopyAssign(value);
			}
		}

		// Token: 0x17004A37 RID: 18999
		// (get) Token: 0x060131AC RID: 78252 RVA: 0x001C195D File Offset: 0x001BFB5D
		// (set) Token: 0x060131AD RID: 78253 RVA: 0x001C196D File Offset: 0x001BFB6D
		public unsafe bool bIsGrasped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_bIsGrasped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXRMotionControllerData.__PropertyOffset_bIsGrasped) = (value ? 1 : 0);
			}
		}

		// Token: 0x060131AE RID: 78254 RVA: 0x001C197E File Offset: 0x001BFB7E
		public FXRMotionControllerData()
		{
		}

		// Token: 0x060131AF RID: 78255 RVA: 0x001C1988 File Offset: 0x001BFB88
		public FXRMotionControllerData(bool bValid, FName DeviceName, FGuid ApplicationInstanceID, EXRVisualType DeviceVisualType, EControllerHand HandIndex, ETrackingStatus TrackingStatus, FVector GripPosition, FQuat GripRotation, FVector AimPosition, FQuat AimRotation, TArray<FVector> HandKeyPositions, TArray<FQuat> HandKeyRotations, TArray<float> HandKeyRadii, bool bIsGrasped)
		{
			this.bValid = bValid;
			this.DeviceName = DeviceName;
			this.ApplicationInstanceID = ApplicationInstanceID;
			this.DeviceVisualType = DeviceVisualType;
			this.HandIndex = HandIndex;
			this.TrackingStatus = TrackingStatus;
			this.GripPosition = GripPosition;
			this.GripRotation = GripRotation;
			this.AimPosition = AimPosition;
			this.AimRotation = AimRotation;
			this.HandKeyPositions = HandKeyPositions;
			this.HandKeyRotations = HandKeyRotations;
			this.HandKeyRadii = HandKeyRadii;
			this.bIsGrasped = bIsGrasped;
		}

		// Token: 0x060131B0 RID: 78256 RVA: 0x001C1A08 File Offset: 0x001BFC08
		protected override IntPtr GetUStructPtr()
		{
			return FXRMotionControllerData.StaticStruct();
		}

		// Token: 0x060131B1 RID: 78257 RVA: 0x001C1A14 File Offset: 0x001BFC14
		[NullableContext(2)]
		public FXRMotionControllerData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060131B2 RID: 78258 RVA: 0x001C1A1E File Offset: 0x001BFC1E
		public FXRMotionControllerData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060131B3 RID: 78259 RVA: 0x001C1A29 File Offset: 0x001BFC29
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXRMotionControllerData(Pointer, false, true);
		}

		// Token: 0x060131B4 RID: 78260 RVA: 0x001C1A33 File Offset: 0x001BFC33
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXRMotionControllerData(Pointer, MemoryOwner);
		}

		// Token: 0x0400A3C9 RID: 41929
		public const string __ObjectPath = "/Script/HeadMountedDisplay.XRMotionControllerData";

		// Token: 0x0400A3CA RID: 41930
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400A3CB RID: 41931
		internal static int __PropertyOffset_bValid;

		// Token: 0x0400A3CC RID: 41932
		internal static int __PropertyOffset_DeviceName;

		// Token: 0x0400A3CD RID: 41933
		internal static int __PropertyOffset_ApplicationInstanceID;

		// Token: 0x0400A3CE RID: 41934
		internal static int __PropertyOffset_DeviceVisualType;

		// Token: 0x0400A3CF RID: 41935
		internal static int __PropertyOffset_HandIndex;

		// Token: 0x0400A3D0 RID: 41936
		internal static int __PropertyOffset_TrackingStatus;

		// Token: 0x0400A3D1 RID: 41937
		internal static int __PropertyOffset_GripPosition;

		// Token: 0x0400A3D2 RID: 41938
		internal static int __PropertyOffset_GripRotation;

		// Token: 0x0400A3D3 RID: 41939
		internal static int __PropertyOffset_AimPosition;

		// Token: 0x0400A3D4 RID: 41940
		internal static int __PropertyOffset_AimRotation;

		// Token: 0x0400A3D5 RID: 41941
		internal static int __PropertyOffset_HandKeyPositions;

		// Token: 0x0400A3D6 RID: 41942
		[Nullable(2)]
		private TArray<FVector> _HandKeyPositions;

		// Token: 0x0400A3D7 RID: 41943
		internal static int __PropertyOffset_HandKeyRotations;

		// Token: 0x0400A3D8 RID: 41944
		[Nullable(2)]
		private TArray<FQuat> _HandKeyRotations;

		// Token: 0x0400A3D9 RID: 41945
		internal static int __PropertyOffset_HandKeyRadii;

		// Token: 0x0400A3DA RID: 41946
		[Nullable(2)]
		private TArray<float> _HandKeyRadii;

		// Token: 0x0400A3DB RID: 41947
		internal static int __PropertyOffset_bIsGrasped;
	}
}
