using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002626 RID: 9766
	[UnrealObjectPath("/Script/OpenCVLensDistortion.OpenCVCameraViewInfo")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FOpenCVCameraViewInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060244F2 RID: 148722 RVA: 0x0035C28D File Offset: 0x0035A48D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpenCVCameraViewInfo._ScriptStructPtr != 0) ? FOpenCVCameraViewInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OpenCVLensDistortion.OpenCVCameraViewInfo", ref FOpenCVCameraViewInfo._ScriptStructPtr);
		}

		// Token: 0x17008BD1 RID: 35793
		// (get) Token: 0x060244F3 RID: 148723 RVA: 0x0035C2B1 File Offset: 0x0035A4B1
		// (set) Token: 0x060244F4 RID: 148724 RVA: 0x0035C2C1 File Offset: 0x0035A4C1
		public unsafe float HorizontalFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_HorizontalFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_HorizontalFOV) = value;
			}
		}

		// Token: 0x17008BD2 RID: 35794
		// (get) Token: 0x060244F5 RID: 148725 RVA: 0x0035C2D2 File Offset: 0x0035A4D2
		// (set) Token: 0x060244F6 RID: 148726 RVA: 0x0035C2E2 File Offset: 0x0035A4E2
		public unsafe float VerticalFOV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_VerticalFOV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_VerticalFOV) = value;
			}
		}

		// Token: 0x17008BD3 RID: 35795
		// (get) Token: 0x060244F7 RID: 148727 RVA: 0x0035C2F3 File Offset: 0x0035A4F3
		// (set) Token: 0x060244F8 RID: 148728 RVA: 0x0035C303 File Offset: 0x0035A503
		public unsafe float FocalLengthRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_FocalLengthRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVCameraViewInfo.__PropertyOffset_FocalLengthRatio) = value;
			}
		}

		// Token: 0x060244F9 RID: 148729 RVA: 0x0035C314 File Offset: 0x0035A514
		public FOpenCVCameraViewInfo()
		{
		}

		// Token: 0x060244FA RID: 148730 RVA: 0x0035C31C File Offset: 0x0035A51C
		public FOpenCVCameraViewInfo(float HorizontalFOV, float VerticalFOV, float FocalLengthRatio)
		{
			this.HorizontalFOV = HorizontalFOV;
			this.VerticalFOV = VerticalFOV;
			this.FocalLengthRatio = FocalLengthRatio;
		}

		// Token: 0x060244FB RID: 148731 RVA: 0x0035C339 File Offset: 0x0035A539
		protected override IntPtr GetUStructPtr()
		{
			return FOpenCVCameraViewInfo.StaticStruct();
		}

		// Token: 0x060244FC RID: 148732 RVA: 0x0035C345 File Offset: 0x0035A545
		[NullableContext(2)]
		public FOpenCVCameraViewInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060244FD RID: 148733 RVA: 0x0035C34F File Offset: 0x0035A54F
		public FOpenCVCameraViewInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060244FE RID: 148734 RVA: 0x0035C35A File Offset: 0x0035A55A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpenCVCameraViewInfo(Pointer, false, true);
		}

		// Token: 0x060244FF RID: 148735 RVA: 0x0035C364 File Offset: 0x0035A564
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpenCVCameraViewInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040137A5 RID: 79781
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OpenCVLensDistortion.OpenCVCameraViewInfo";

		// Token: 0x040137A6 RID: 79782
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040137A7 RID: 79783
		internal static int __PropertyOffset_HorizontalFOV;

		// Token: 0x040137A8 RID: 79784
		internal static int __PropertyOffset_VerticalFOV;

		// Token: 0x040137A9 RID: 79785
		internal static int __PropertyOffset_FocalLengthRatio;
	}
}
