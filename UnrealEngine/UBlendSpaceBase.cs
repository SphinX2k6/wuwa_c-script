using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B6 RID: 2230
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BlendSpaceBase")]
	[UnrealStructLayout(504, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 504)]
	public class UBlendSpaceBase : UAnimationAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079D3 RID: 31187 RVA: 0x000AE397 File Offset: 0x000AC597
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlendSpaceBase._ClassPtr;
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x000AE3A4 File Offset: 0x000AC5A4
		public UBlendSpaceBase() : this(BuiltinUtils.AllocNativeUObject(UBlendSpaceBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x000AE3CC File Offset: 0x000AC5CC
		public UBlendSpaceBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlendSpaceBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001CC5 RID: 7365
		// (get) Token: 0x060079D6 RID: 31190 RVA: 0x000AE3FF File Offset: 0x000AC5FF
		// (set) Token: 0x060079D7 RID: 31191 RVA: 0x000AE40F File Offset: 0x000AC60F
		public unsafe bool bRotationBlendInMeshSpace
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_bRotationBlendInMeshSpace) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_bRotationBlendInMeshSpace) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001CC6 RID: 7366
		// (get) Token: 0x060079D8 RID: 31192 RVA: 0x000AE420 File Offset: 0x000AC620
		// (set) Token: 0x060079D9 RID: 31193 RVA: 0x000AE430 File Offset: 0x000AC630
		public unsafe float AnimLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_AnimLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_AnimLength) = value;
			}
		}

		// Token: 0x17001CC7 RID: 7367
		// (get) Token: 0x060079DA RID: 31194 RVA: 0x000AE444 File Offset: 0x000AC644
		// (set) Token: 0x060079DB RID: 31195 RVA: 0x000AE47E File Offset: 0x000AC67E
		public TFixedArray<FInterpolationParameter> InterpolationParam
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FInterpolationParameter> result;
				if ((result = this._InterpolationParam) == null)
				{
					result = (this._InterpolationParam = new TFixedArray<FInterpolationParameter>(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_InterpolationParam, 3, this));
				}
				return result;
			}
			set
			{
				this.InterpolationParam.CopyAssign(value);
			}
		}

		// Token: 0x17001CC8 RID: 7368
		// (get) Token: 0x060079DC RID: 31196 RVA: 0x000AE48C File Offset: 0x000AC68C
		// (set) Token: 0x060079DD RID: 31197 RVA: 0x000AE49C File Offset: 0x000AC69C
		public unsafe float TargetWeightInterpolationSpeedPerSec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_TargetWeightInterpolationSpeedPerSec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_TargetWeightInterpolationSpeedPerSec) = value;
			}
		}

		// Token: 0x17001CC9 RID: 7369
		// (get) Token: 0x060079DE RID: 31198 RVA: 0x000AE4AD File Offset: 0x000AC6AD
		// (set) Token: 0x060079DF RID: 31199 RVA: 0x000AE4C1 File Offset: 0x000AC6C1
		[Nullable(0)]
		public unsafe TEnumAsByte<ENotifyTriggerMode> NotifyTriggerMode
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_NotifyTriggerMode);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_NotifyTriggerMode) = value;
			}
		}

		// Token: 0x17001CCA RID: 7370
		// (get) Token: 0x060079E0 RID: 31200 RVA: 0x000AE4D8 File Offset: 0x000AC6D8
		// (set) Token: 0x060079E1 RID: 31201 RVA: 0x000AE511 File Offset: 0x000AC711
		public TArray<FPerBoneInterpolation> PerBoneBlend
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FPerBoneInterpolation> result;
				if ((result = this._PerBoneBlend) == null)
				{
					result = (this._PerBoneBlend = new TArray<FPerBoneInterpolation>(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_PerBoneBlend, this));
				}
				return result;
			}
			set
			{
				this.PerBoneBlend.CopyAssign(value);
			}
		}

		// Token: 0x17001CCB RID: 7371
		// (get) Token: 0x060079E2 RID: 31202 RVA: 0x000AE51F File Offset: 0x000AC71F
		// (set) Token: 0x060079E3 RID: 31203 RVA: 0x000AE52F File Offset: 0x000AC72F
		public unsafe int SampleIndexWithMarkers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_SampleIndexWithMarkers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_SampleIndexWithMarkers) = value;
			}
		}

		// Token: 0x17001CCC RID: 7372
		// (get) Token: 0x060079E4 RID: 31204 RVA: 0x000AE540 File Offset: 0x000AC740
		// (set) Token: 0x060079E5 RID: 31205 RVA: 0x000AE579 File Offset: 0x000AC779
		public TArray<FBlendSample> SampleData
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBlendSample> result;
				if ((result = this._SampleData) == null)
				{
					result = (this._SampleData = new TArray<FBlendSample>(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_SampleData, this));
				}
				return result;
			}
			set
			{
				this.SampleData.CopyAssign(value);
			}
		}

		// Token: 0x17001CCD RID: 7373
		// (get) Token: 0x060079E6 RID: 31206 RVA: 0x000AE588 File Offset: 0x000AC788
		// (set) Token: 0x060079E7 RID: 31207 RVA: 0x000AE5C1 File Offset: 0x000AC7C1
		public TArray<FEditorElement> GridSamples
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FEditorElement> result;
				if ((result = this._GridSamples) == null)
				{
					result = (this._GridSamples = new TArray<FEditorElement>(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_GridSamples, this));
				}
				return result;
			}
			set
			{
				this.GridSamples.CopyAssign(value);
			}
		}

		// Token: 0x17001CCE RID: 7374
		// (get) Token: 0x060079E8 RID: 31208 RVA: 0x000AE5D0 File Offset: 0x000AC7D0
		// (set) Token: 0x060079E9 RID: 31209 RVA: 0x000AE60A File Offset: 0x000AC80A
		public TFixedArray<FBlendParameter> BlendParameters
		{
			get
			{
				base.FastCheckIsValid();
				TFixedArray<FBlendParameter> result;
				if ((result = this._BlendParameters) == null)
				{
					result = (this._BlendParameters = new TFixedArray<FBlendParameter>(base.NativePtr + (IntPtr)UBlendSpaceBase.__PropertyOffset_BlendParameters, 3, this));
				}
				return result;
			}
			set
			{
				this.BlendParameters.CopyAssign(value);
			}
		}

		// Token: 0x060079EA RID: 31210 RVA: 0x000AE618 File Offset: 0x000AC818
		static UBlendSpaceBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.BlendSpaceBase");
		}

		// Token: 0x060079EB RID: 31211 RVA: 0x000AE626 File Offset: 0x000AC826
		protected UBlendSpaceBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003A88 RID: 14984
		public new const string __ObjectPath = "/Script/Engine.BlendSpaceBase";

		// Token: 0x04003A89 RID: 14985
		private static IntPtr _ClassPtr;

		// Token: 0x04003A8A RID: 14986
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003A8B RID: 14987
		internal static int __PropertyOffset_bRotationBlendInMeshSpace;

		// Token: 0x04003A8C RID: 14988
		internal static int __PropertyOffset_AnimLength;

		// Token: 0x04003A8D RID: 14989
		internal static int __PropertyOffset_InterpolationParam;

		// Token: 0x04003A8E RID: 14990
		[Nullable(2)]
		private TFixedArray<FInterpolationParameter> _InterpolationParam;

		// Token: 0x04003A8F RID: 14991
		internal static int __PropertyOffset_TargetWeightInterpolationSpeedPerSec;

		// Token: 0x04003A90 RID: 14992
		internal static int __PropertyOffset_NotifyTriggerMode;

		// Token: 0x04003A91 RID: 14993
		internal static int __PropertyOffset_PerBoneBlend;

		// Token: 0x04003A92 RID: 14994
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FPerBoneInterpolation> _PerBoneBlend;

		// Token: 0x04003A93 RID: 14995
		internal static int __PropertyOffset_SampleIndexWithMarkers;

		// Token: 0x04003A94 RID: 14996
		internal static int __PropertyOffset_SampleData;

		// Token: 0x04003A95 RID: 14997
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBlendSample> _SampleData;

		// Token: 0x04003A96 RID: 14998
		internal static int __PropertyOffset_GridSamples;

		// Token: 0x04003A97 RID: 14999
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FEditorElement> _GridSamples;

		// Token: 0x04003A98 RID: 15000
		internal static int __PropertyOffset_BlendParameters;

		// Token: 0x04003A99 RID: 15001
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TFixedArray<FBlendParameter> _BlendParameters;
	}
}
