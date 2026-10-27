using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002628 RID: 9768
	[UnrealObjectPath("/Script/OpenCVLensDistortion.OpenCVLensDistortionParameters")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FOpenCVLensDistortionParameters : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06024509 RID: 148745 RVA: 0x0035C65C File Offset: 0x0035A85C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOpenCVLensDistortionParameters._ScriptStructPtr != 0) ? FOpenCVLensDistortionParameters._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/OpenCVLensDistortion.OpenCVLensDistortionParameters", ref FOpenCVLensDistortionParameters._ScriptStructPtr);
		}

		// Token: 0x17008BD4 RID: 35796
		// (get) Token: 0x0602450A RID: 148746 RVA: 0x0035C680 File Offset: 0x0035A880
		// (set) Token: 0x0602450B RID: 148747 RVA: 0x0035C690 File Offset: 0x0035A890
		public unsafe float K1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K1) = value;
			}
		}

		// Token: 0x17008BD5 RID: 35797
		// (get) Token: 0x0602450C RID: 148748 RVA: 0x0035C6A1 File Offset: 0x0035A8A1
		// (set) Token: 0x0602450D RID: 148749 RVA: 0x0035C6B1 File Offset: 0x0035A8B1
		public unsafe float K2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K2) = value;
			}
		}

		// Token: 0x17008BD6 RID: 35798
		// (get) Token: 0x0602450E RID: 148750 RVA: 0x0035C6C2 File Offset: 0x0035A8C2
		// (set) Token: 0x0602450F RID: 148751 RVA: 0x0035C6D2 File Offset: 0x0035A8D2
		public unsafe float P1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_P1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_P1) = value;
			}
		}

		// Token: 0x17008BD7 RID: 35799
		// (get) Token: 0x06024510 RID: 148752 RVA: 0x0035C6E3 File Offset: 0x0035A8E3
		// (set) Token: 0x06024511 RID: 148753 RVA: 0x0035C6F3 File Offset: 0x0035A8F3
		public unsafe float P2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_P2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_P2) = value;
			}
		}

		// Token: 0x17008BD8 RID: 35800
		// (get) Token: 0x06024512 RID: 148754 RVA: 0x0035C704 File Offset: 0x0035A904
		// (set) Token: 0x06024513 RID: 148755 RVA: 0x0035C714 File Offset: 0x0035A914
		public unsafe float K3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K3) = value;
			}
		}

		// Token: 0x17008BD9 RID: 35801
		// (get) Token: 0x06024514 RID: 148756 RVA: 0x0035C725 File Offset: 0x0035A925
		// (set) Token: 0x06024515 RID: 148757 RVA: 0x0035C735 File Offset: 0x0035A935
		public unsafe float K4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K4) = value;
			}
		}

		// Token: 0x17008BDA RID: 35802
		// (get) Token: 0x06024516 RID: 148758 RVA: 0x0035C746 File Offset: 0x0035A946
		// (set) Token: 0x06024517 RID: 148759 RVA: 0x0035C756 File Offset: 0x0035A956
		public unsafe float K5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K5) = value;
			}
		}

		// Token: 0x17008BDB RID: 35803
		// (get) Token: 0x06024518 RID: 148760 RVA: 0x0035C767 File Offset: 0x0035A967
		// (set) Token: 0x06024519 RID: 148761 RVA: 0x0035C777 File Offset: 0x0035A977
		public unsafe float K6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_K6) = value;
			}
		}

		// Token: 0x17008BDC RID: 35804
		// (get) Token: 0x0602451A RID: 148762 RVA: 0x0035C788 File Offset: 0x0035A988
		// (set) Token: 0x0602451B RID: 148763 RVA: 0x0035C79C File Offset: 0x0035A99C
		public unsafe FVector2D F
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_F);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_F) = value;
			}
		}

		// Token: 0x17008BDD RID: 35805
		// (get) Token: 0x0602451C RID: 148764 RVA: 0x0035C7B1 File Offset: 0x0035A9B1
		// (set) Token: 0x0602451D RID: 148765 RVA: 0x0035C7C5 File Offset: 0x0035A9C5
		public unsafe FVector2D C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_C);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_C) = value;
			}
		}

		// Token: 0x17008BDE RID: 35806
		// (get) Token: 0x0602451E RID: 148766 RVA: 0x0035C7DA File Offset: 0x0035A9DA
		// (set) Token: 0x0602451F RID: 148767 RVA: 0x0035C7EA File Offset: 0x0035A9EA
		public unsafe bool bUseFisheyeModel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_bUseFisheyeModel) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOpenCVLensDistortionParameters.__PropertyOffset_bUseFisheyeModel) = (value ? 1 : 0);
			}
		}

		// Token: 0x06024520 RID: 148768 RVA: 0x0035C7FB File Offset: 0x0035A9FB
		public FOpenCVLensDistortionParameters()
		{
		}

		// Token: 0x06024521 RID: 148769 RVA: 0x0035C804 File Offset: 0x0035AA04
		public FOpenCVLensDistortionParameters(float K1, float K2, float P1, float P2, float K3, float K4, float K5, float K6, FVector2D F, FVector2D C, bool bUseFisheyeModel)
		{
			this.K1 = K1;
			this.K2 = K2;
			this.P1 = P1;
			this.P2 = P2;
			this.K3 = K3;
			this.K4 = K4;
			this.K5 = K5;
			this.K6 = K6;
			this.F = F;
			this.C = C;
			this.bUseFisheyeModel = bUseFisheyeModel;
		}

		// Token: 0x06024522 RID: 148770 RVA: 0x0035C86C File Offset: 0x0035AA6C
		protected override IntPtr GetUStructPtr()
		{
			return FOpenCVLensDistortionParameters.StaticStruct();
		}

		// Token: 0x06024523 RID: 148771 RVA: 0x0035C878 File Offset: 0x0035AA78
		[NullableContext(2)]
		public FOpenCVLensDistortionParameters(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06024524 RID: 148772 RVA: 0x0035C882 File Offset: 0x0035AA82
		public FOpenCVLensDistortionParameters(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06024525 RID: 148773 RVA: 0x0035C88D File Offset: 0x0035AA8D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOpenCVLensDistortionParameters(Pointer, false, true);
		}

		// Token: 0x06024526 RID: 148774 RVA: 0x0035C897 File Offset: 0x0035AA97
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOpenCVLensDistortionParameters(Pointer, MemoryOwner);
		}

		// Token: 0x040137B1 RID: 79793
		[Nullable(1)]
		public const string __ObjectPath = "/Script/OpenCVLensDistortion.OpenCVLensDistortionParameters";

		// Token: 0x040137B2 RID: 79794
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040137B3 RID: 79795
		internal static int __PropertyOffset_K1;

		// Token: 0x040137B4 RID: 79796
		internal static int __PropertyOffset_K2;

		// Token: 0x040137B5 RID: 79797
		internal static int __PropertyOffset_P1;

		// Token: 0x040137B6 RID: 79798
		internal static int __PropertyOffset_P2;

		// Token: 0x040137B7 RID: 79799
		internal static int __PropertyOffset_K3;

		// Token: 0x040137B8 RID: 79800
		internal static int __PropertyOffset_K4;

		// Token: 0x040137B9 RID: 79801
		internal static int __PropertyOffset_K5;

		// Token: 0x040137BA RID: 79802
		internal static int __PropertyOffset_K6;

		// Token: 0x040137BB RID: 79803
		internal static int __PropertyOffset_F;

		// Token: 0x040137BC RID: 79804
		internal static int __PropertyOffset_C;

		// Token: 0x040137BD RID: 79805
		internal static int __PropertyOffset_bUseFisheyeModel;
	}
}
