using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002F8 RID: 760
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_RotateRootBone")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 168)]
	public class FAnimNode_RotateRootBone : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002B6D RID: 11117 RVA: 0x00042220 File Offset: 0x00040420
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_RotateRootBone._ScriptStructPtr != 0) ? FAnimNode_RotateRootBone._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_RotateRootBone", ref FAnimNode_RotateRootBone._ScriptStructPtr);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06002B6E RID: 11118 RVA: 0x00042244 File Offset: 0x00040444
		// (set) Token: 0x06002B6F RID: 11119 RVA: 0x00042287 File Offset: 0x00040487
		public FPoseLink BasePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._BasePose) == null)
				{
					result = (this._BasePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_BasePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_BasePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06002B70 RID: 11120 RVA: 0x000422A8 File Offset: 0x000404A8
		// (set) Token: 0x06002B71 RID: 11121 RVA: 0x000422B8 File Offset: 0x000404B8
		public unsafe float Pitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_Pitch);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_Pitch) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06002B72 RID: 11122 RVA: 0x000422C9 File Offset: 0x000404C9
		// (set) Token: 0x06002B73 RID: 11123 RVA: 0x000422D9 File Offset: 0x000404D9
		public unsafe float Yaw
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_Yaw);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_Yaw) = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06002B74 RID: 11124 RVA: 0x000422EC File Offset: 0x000404EC
		// (set) Token: 0x06002B75 RID: 11125 RVA: 0x0004232F File Offset: 0x0004052F
		public FInputScaleBiasClamp PitchScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._PitchScaleBiasClamp) == null)
				{
					result = (this._PitchScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_PitchScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_PitchScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06002B76 RID: 11126 RVA: 0x00042350 File Offset: 0x00040550
		// (set) Token: 0x06002B77 RID: 11127 RVA: 0x00042393 File Offset: 0x00040593
		public FInputScaleBiasClamp YawScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._YawScaleBiasClamp) == null)
				{
					result = (this._YawScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_YawScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_YawScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06002B78 RID: 11128 RVA: 0x000423B4 File Offset: 0x000405B4
		// (set) Token: 0x06002B79 RID: 11129 RVA: 0x000423C8 File Offset: 0x000405C8
		public unsafe FRotator MeshToComponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_MeshToComponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_RotateRootBone.__PropertyOffset_MeshToComponent) = value;
			}
		}

		// Token: 0x06002B7A RID: 11130 RVA: 0x000423DD File Offset: 0x000405DD
		public FAnimNode_RotateRootBone()
		{
		}

		// Token: 0x06002B7B RID: 11131 RVA: 0x000423E5 File Offset: 0x000405E5
		public FAnimNode_RotateRootBone(FPoseLink BasePose, float Pitch, float Yaw, FInputScaleBiasClamp PitchScaleBiasClamp, FInputScaleBiasClamp YawScaleBiasClamp, FRotator MeshToComponent)
		{
			this.BasePose = BasePose;
			this.Pitch = Pitch;
			this.Yaw = Yaw;
			this.PitchScaleBiasClamp = PitchScaleBiasClamp;
			this.YawScaleBiasClamp = YawScaleBiasClamp;
			this.MeshToComponent = MeshToComponent;
		}

		// Token: 0x06002B7C RID: 11132 RVA: 0x0004241A File Offset: 0x0004061A
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_RotateRootBone.StaticStruct();
		}

		// Token: 0x06002B7D RID: 11133 RVA: 0x00042426 File Offset: 0x00040626
		[NullableContext(2)]
		public FAnimNode_RotateRootBone(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002B7E RID: 11134 RVA: 0x00042430 File Offset: 0x00040630
		public FAnimNode_RotateRootBone(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002B7F RID: 11135 RVA: 0x0004243B File Offset: 0x0004063B
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_RotateRootBone(Pointer, false, true);
		}

		// Token: 0x06002B80 RID: 11136 RVA: 0x00042445 File Offset: 0x00040645
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_RotateRootBone(Pointer, MemoryOwner);
		}

		// Token: 0x040011AC RID: 4524
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_RotateRootBone";

		// Token: 0x040011AD RID: 4525
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040011AE RID: 4526
		internal static int __PropertyOffset_BasePose;

		// Token: 0x040011AF RID: 4527
		[Nullable(2)]
		private FPoseLink _BasePose;

		// Token: 0x040011B0 RID: 4528
		internal static int __PropertyOffset_Pitch;

		// Token: 0x040011B1 RID: 4529
		internal static int __PropertyOffset_Yaw;

		// Token: 0x040011B2 RID: 4530
		internal static int __PropertyOffset_PitchScaleBiasClamp;

		// Token: 0x040011B3 RID: 4531
		[Nullable(2)]
		private FInputScaleBiasClamp _PitchScaleBiasClamp;

		// Token: 0x040011B4 RID: 4532
		internal static int __PropertyOffset_YawScaleBiasClamp;

		// Token: 0x040011B5 RID: 4533
		[Nullable(2)]
		private FInputScaleBiasClamp _YawScaleBiasClamp;

		// Token: 0x040011B6 RID: 4534
		internal static int __PropertyOffset_MeshToComponent;
	}
}
