using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004CC RID: 1228
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.ControlRigNumericalValidationPass")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 112)]
	public class UControlRigNumericalValidationPass : UControlRigValidationPass, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06004209 RID: 16905 RVA: 0x00062C02 File Offset: 0x00060E02
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UControlRigNumericalValidationPass._ClassPtr;
		}

		// Token: 0x0600420A RID: 16906 RVA: 0x00062C10 File Offset: 0x00060E10
		public UControlRigNumericalValidationPass() : this(BuiltinUtils.AllocNativeUObject(UControlRigNumericalValidationPass.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600420B RID: 16907 RVA: 0x00062C38 File Offset: 0x00060E38
		public UControlRigNumericalValidationPass(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UControlRigNumericalValidationPass.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700100D RID: 4109
		// (get) Token: 0x0600420C RID: 16908 RVA: 0x00062C6B File Offset: 0x00060E6B
		// (set) Token: 0x0600420D RID: 16909 RVA: 0x00062C7B File Offset: 0x00060E7B
		public unsafe bool bCheckControls
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckControls) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckControls) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700100E RID: 4110
		// (get) Token: 0x0600420E RID: 16910 RVA: 0x00062C8C File Offset: 0x00060E8C
		// (set) Token: 0x0600420F RID: 16911 RVA: 0x00062C9C File Offset: 0x00060E9C
		public unsafe bool bCheckBones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckBones) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckBones) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700100F RID: 4111
		// (get) Token: 0x06004210 RID: 16912 RVA: 0x00062CAD File Offset: 0x00060EAD
		// (set) Token: 0x06004211 RID: 16913 RVA: 0x00062CBD File Offset: 0x00060EBD
		public unsafe bool bCheckCurves
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckCurves) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_bCheckCurves) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001010 RID: 4112
		// (get) Token: 0x06004212 RID: 16914 RVA: 0x00062CCE File Offset: 0x00060ECE
		// (set) Token: 0x06004213 RID: 16915 RVA: 0x00062CDE File Offset: 0x00060EDE
		public unsafe float TranslationPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_TranslationPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_TranslationPrecision) = value;
			}
		}

		// Token: 0x17001011 RID: 4113
		// (get) Token: 0x06004214 RID: 16916 RVA: 0x00062CEF File Offset: 0x00060EEF
		// (set) Token: 0x06004215 RID: 16917 RVA: 0x00062CFF File Offset: 0x00060EFF
		public unsafe float RotationPrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_RotationPrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_RotationPrecision) = value;
			}
		}

		// Token: 0x17001012 RID: 4114
		// (get) Token: 0x06004216 RID: 16918 RVA: 0x00062D10 File Offset: 0x00060F10
		// (set) Token: 0x06004217 RID: 16919 RVA: 0x00062D20 File Offset: 0x00060F20
		public unsafe float ScalePrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_ScalePrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_ScalePrecision) = value;
			}
		}

		// Token: 0x17001013 RID: 4115
		// (get) Token: 0x06004218 RID: 16920 RVA: 0x00062D31 File Offset: 0x00060F31
		// (set) Token: 0x06004219 RID: 16921 RVA: 0x00062D41 File Offset: 0x00060F41
		public unsafe float CurvePrecision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_CurvePrecision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_CurvePrecision) = value;
			}
		}

		// Token: 0x17001014 RID: 4116
		// (get) Token: 0x0600421A RID: 16922 RVA: 0x00062D52 File Offset: 0x00060F52
		// (set) Token: 0x0600421B RID: 16923 RVA: 0x00062D66 File Offset: 0x00060F66
		public unsafe FName EventNameA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_EventNameA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_EventNameA) = value;
			}
		}

		// Token: 0x17001015 RID: 4117
		// (get) Token: 0x0600421C RID: 16924 RVA: 0x00062D7B File Offset: 0x00060F7B
		// (set) Token: 0x0600421D RID: 16925 RVA: 0x00062D8F File Offset: 0x00060F8F
		public unsafe FName EventNameB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_EventNameB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_EventNameB) = value;
			}
		}

		// Token: 0x17001016 RID: 4118
		// (get) Token: 0x0600421E RID: 16926 RVA: 0x00062DA4 File Offset: 0x00060FA4
		// (set) Token: 0x0600421F RID: 16927 RVA: 0x00062DDD File Offset: 0x00060FDD
		public FRigPose Pose
		{
			get
			{
				base.FastCheckIsValid();
				FRigPose result;
				if ((result = this._Pose) == null)
				{
					result = (this._Pose = new FRigPose(base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_Pose, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigPose.StaticStruct(), base.NativePtr + (IntPtr)UControlRigNumericalValidationPass.__PropertyOffset_Pose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004220 RID: 16928 RVA: 0x00062DFE File Offset: 0x00060FFE
		static UControlRigNumericalValidationPass()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/ControlRig.ControlRigNumericalValidationPass");
		}

		// Token: 0x06004221 RID: 16929 RVA: 0x00062E0C File Offset: 0x0006100C
		protected UControlRigNumericalValidationPass(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001F60 RID: 8032
		public new const string __ObjectPath = "/Script/ControlRig.ControlRigNumericalValidationPass";

		// Token: 0x04001F61 RID: 8033
		private static IntPtr _ClassPtr;

		// Token: 0x04001F62 RID: 8034
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001F63 RID: 8035
		internal static int __PropertyOffset_bCheckControls;

		// Token: 0x04001F64 RID: 8036
		internal static int __PropertyOffset_bCheckBones;

		// Token: 0x04001F65 RID: 8037
		internal static int __PropertyOffset_bCheckCurves;

		// Token: 0x04001F66 RID: 8038
		internal static int __PropertyOffset_TranslationPrecision;

		// Token: 0x04001F67 RID: 8039
		internal static int __PropertyOffset_RotationPrecision;

		// Token: 0x04001F68 RID: 8040
		internal static int __PropertyOffset_ScalePrecision;

		// Token: 0x04001F69 RID: 8041
		internal static int __PropertyOffset_CurvePrecision;

		// Token: 0x04001F6A RID: 8042
		internal static int __PropertyOffset_EventNameA;

		// Token: 0x04001F6B RID: 8043
		internal static int __PropertyOffset_EventNameB;

		// Token: 0x04001F6C RID: 8044
		internal static int __PropertyOffset_Pose;

		// Token: 0x04001F6D RID: 8045
		[Nullable(2)]
		private FRigPose _Pose;
	}
}
