using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB0 RID: 3248
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackMove")]
	[UnrealStructLayout(264, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 264)]
	public class UInterpTrackMove : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A439 RID: 42041 RVA: 0x000E97C3 File Offset: 0x000E79C3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackMove._ClassPtr;
		}

		// Token: 0x0600A43A RID: 42042 RVA: 0x000E97D0 File Offset: 0x000E79D0
		public UInterpTrackMove() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackMove.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x000E97F8 File Offset: 0x000E79F8
		public UInterpTrackMove(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackMove.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700270D RID: 9997
		// (get) Token: 0x0600A43C RID: 42044 RVA: 0x000E982C File Offset: 0x000E7A2C
		// (set) Token: 0x0600A43D RID: 42045 RVA: 0x000E9865 File Offset: 0x000E7A65
		public FInterpCurveVector PosTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._PosTrack) == null)
				{
					result = (this._PosTrack = new FInterpCurveVector(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_PosTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_PosTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700270E RID: 9998
		// (get) Token: 0x0600A43E RID: 42046 RVA: 0x000E9888 File Offset: 0x000E7A88
		// (set) Token: 0x0600A43F RID: 42047 RVA: 0x000E98C1 File Offset: 0x000E7AC1
		public FInterpCurveVector EulerTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._EulerTrack) == null)
				{
					result = (this._EulerTrack = new FInterpCurveVector(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_EulerTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_EulerTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700270F RID: 9999
		// (get) Token: 0x0600A440 RID: 42048 RVA: 0x000E98E4 File Offset: 0x000E7AE4
		// (set) Token: 0x0600A441 RID: 42049 RVA: 0x000E991D File Offset: 0x000E7B1D
		public FInterpLookupTrack LookupTrack
		{
			get
			{
				base.FastCheckIsValid();
				FInterpLookupTrack result;
				if ((result = this._LookupTrack) == null)
				{
					result = (this._LookupTrack = new FInterpLookupTrack(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LookupTrack, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpLookupTrack.StaticStruct(), base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LookupTrack, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x0600A442 RID: 42050 RVA: 0x000E993E File Offset: 0x000E7B3E
		// (set) Token: 0x0600A443 RID: 42051 RVA: 0x000E9952 File Offset: 0x000E7B52
		public unsafe FName LookAtGroupName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LookAtGroupName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LookAtGroupName) = value;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x0600A444 RID: 42052 RVA: 0x000E9967 File Offset: 0x000E7B67
		// (set) Token: 0x0600A445 RID: 42053 RVA: 0x000E9977 File Offset: 0x000E7B77
		public unsafe float LinCurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LinCurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_LinCurveTension) = value;
			}
		}

		// Token: 0x17002712 RID: 10002
		// (get) Token: 0x0600A446 RID: 42054 RVA: 0x000E9988 File Offset: 0x000E7B88
		// (set) Token: 0x0600A447 RID: 42055 RVA: 0x000E9998 File Offset: 0x000E7B98
		public unsafe float AngCurveTension
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_AngCurveTension);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_AngCurveTension) = value;
			}
		}

		// Token: 0x17002713 RID: 10003
		// (get) Token: 0x0600A448 RID: 42056 RVA: 0x000E99A9 File Offset: 0x000E7BA9
		// (set) Token: 0x0600A449 RID: 42057 RVA: 0x000E99C2 File Offset: 0x000E7BC2
		public unsafe bool bUseQuatInterpolation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bUseQuatInterpolation) & UInterpTrackMove.__PropertyMask_bUseQuatInterpolation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bUseQuatInterpolation) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bUseQuatInterpolation) & ~UInterpTrackMove.__PropertyMask_bUseQuatInterpolation) | (value ? UInterpTrackMove.__PropertyMask_bUseQuatInterpolation : 0));
			}
		}

		// Token: 0x17002714 RID: 10004
		// (get) Token: 0x0600A44A RID: 42058 RVA: 0x000E99F2 File Offset: 0x000E7BF2
		// (set) Token: 0x0600A44B RID: 42059 RVA: 0x000E9A0B File Offset: 0x000E7C0B
		public unsafe bool bShowArrowAtKeys
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowArrowAtKeys) & UInterpTrackMove.__PropertyMask_bShowArrowAtKeys) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowArrowAtKeys) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowArrowAtKeys) & ~UInterpTrackMove.__PropertyMask_bShowArrowAtKeys) | (value ? UInterpTrackMove.__PropertyMask_bShowArrowAtKeys : 0));
			}
		}

		// Token: 0x17002715 RID: 10005
		// (get) Token: 0x0600A44C RID: 42060 RVA: 0x000E9A3B File Offset: 0x000E7C3B
		// (set) Token: 0x0600A44D RID: 42061 RVA: 0x000E9A54 File Offset: 0x000E7C54
		public unsafe bool bDisableMovement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bDisableMovement) & UInterpTrackMove.__PropertyMask_bDisableMovement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bDisableMovement) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bDisableMovement) & ~UInterpTrackMove.__PropertyMask_bDisableMovement) | (value ? UInterpTrackMove.__PropertyMask_bDisableMovement : 0));
			}
		}

		// Token: 0x17002716 RID: 10006
		// (get) Token: 0x0600A44E RID: 42062 RVA: 0x000E9A84 File Offset: 0x000E7C84
		// (set) Token: 0x0600A44F RID: 42063 RVA: 0x000E9A9D File Offset: 0x000E7C9D
		public unsafe bool bShowTranslationOnCurveEd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowTranslationOnCurveEd) & UInterpTrackMove.__PropertyMask_bShowTranslationOnCurveEd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowTranslationOnCurveEd) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowTranslationOnCurveEd) & ~UInterpTrackMove.__PropertyMask_bShowTranslationOnCurveEd) | (value ? UInterpTrackMove.__PropertyMask_bShowTranslationOnCurveEd : 0));
			}
		}

		// Token: 0x17002717 RID: 10007
		// (get) Token: 0x0600A450 RID: 42064 RVA: 0x000E9ACD File Offset: 0x000E7CCD
		// (set) Token: 0x0600A451 RID: 42065 RVA: 0x000E9AE6 File Offset: 0x000E7CE6
		public unsafe bool bShowRotationOnCurveEd
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowRotationOnCurveEd) & UInterpTrackMove.__PropertyMask_bShowRotationOnCurveEd) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowRotationOnCurveEd) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bShowRotationOnCurveEd) & ~UInterpTrackMove.__PropertyMask_bShowRotationOnCurveEd) | (value ? UInterpTrackMove.__PropertyMask_bShowRotationOnCurveEd : 0));
			}
		}

		// Token: 0x17002718 RID: 10008
		// (get) Token: 0x0600A452 RID: 42066 RVA: 0x000E9B16 File Offset: 0x000E7D16
		// (set) Token: 0x0600A453 RID: 42067 RVA: 0x000E9B2F File Offset: 0x000E7D2F
		public unsafe bool bHide3DTrack
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bHide3DTrack) & UInterpTrackMove.__PropertyMask_bHide3DTrack) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bHide3DTrack) = ((*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_bHide3DTrack) & ~UInterpTrackMove.__PropertyMask_bHide3DTrack) | (value ? UInterpTrackMove.__PropertyMask_bHide3DTrack : 0));
			}
		}

		// Token: 0x17002719 RID: 10009
		// (get) Token: 0x0600A454 RID: 42068 RVA: 0x000E9B5F File Offset: 0x000E7D5F
		// (set) Token: 0x0600A455 RID: 42069 RVA: 0x000E9B73 File Offset: 0x000E7D73
		[Nullable(0)]
		public unsafe TEnumAsByte<EInterpTrackMoveRotMode> RotMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_RotMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackMove.__PropertyOffset_RotMode) = value;
			}
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x000E9B88 File Offset: 0x000E7D88
		static UInterpTrackMove()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackMove");
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x000E9B96 File Offset: 0x000E7D96
		protected UInterpTrackMove(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A4A RID: 23114
		public new const string __ObjectPath = "/Script/Engine.InterpTrackMove";

		// Token: 0x04005A4B RID: 23115
		private static IntPtr _ClassPtr;

		// Token: 0x04005A4C RID: 23116
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A4D RID: 23117
		internal static int __PropertyOffset_PosTrack;

		// Token: 0x04005A4E RID: 23118
		[Nullable(2)]
		private FInterpCurveVector _PosTrack;

		// Token: 0x04005A4F RID: 23119
		internal static int __PropertyOffset_EulerTrack;

		// Token: 0x04005A50 RID: 23120
		[Nullable(2)]
		private FInterpCurveVector _EulerTrack;

		// Token: 0x04005A51 RID: 23121
		internal static int __PropertyOffset_LookupTrack;

		// Token: 0x04005A52 RID: 23122
		[Nullable(2)]
		private FInterpLookupTrack _LookupTrack;

		// Token: 0x04005A53 RID: 23123
		internal static int __PropertyOffset_LookAtGroupName;

		// Token: 0x04005A54 RID: 23124
		internal static int __PropertyOffset_LinCurveTension;

		// Token: 0x04005A55 RID: 23125
		internal static int __PropertyOffset_AngCurveTension;

		// Token: 0x04005A56 RID: 23126
		internal static int __PropertyOffset_bUseQuatInterpolation;

		// Token: 0x04005A57 RID: 23127
		internal static byte __PropertyMask_bUseQuatInterpolation;

		// Token: 0x04005A58 RID: 23128
		internal static int __PropertyOffset_bShowArrowAtKeys;

		// Token: 0x04005A59 RID: 23129
		internal static byte __PropertyMask_bShowArrowAtKeys;

		// Token: 0x04005A5A RID: 23130
		internal static int __PropertyOffset_bDisableMovement;

		// Token: 0x04005A5B RID: 23131
		internal static byte __PropertyMask_bDisableMovement;

		// Token: 0x04005A5C RID: 23132
		internal static int __PropertyOffset_bShowTranslationOnCurveEd;

		// Token: 0x04005A5D RID: 23133
		internal static byte __PropertyMask_bShowTranslationOnCurveEd;

		// Token: 0x04005A5E RID: 23134
		internal static int __PropertyOffset_bShowRotationOnCurveEd;

		// Token: 0x04005A5F RID: 23135
		internal static byte __PropertyMask_bShowRotationOnCurveEd;

		// Token: 0x04005A60 RID: 23136
		internal static int __PropertyOffset_bHide3DTrack;

		// Token: 0x04005A61 RID: 23137
		internal static byte __PropertyMask_bHide3DTrack;

		// Token: 0x04005A62 RID: 23138
		internal static int __PropertyOffset_RotMode;
	}
}
