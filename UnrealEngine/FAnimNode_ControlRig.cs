using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004AE RID: 1198
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.AnimNode_ControlRig")]
	[UnrealStructLayout(896, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 896)]
	public class FAnimNode_ControlRig : FAnimNode_ControlRigBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003FAC RID: 16300 RVA: 0x0005FA37 File Offset: 0x0005DC37
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ControlRig._ScriptStructPtr != 0) ? FAnimNode_ControlRig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.AnimNode_ControlRig", ref FAnimNode_ControlRig._ScriptStructPtr);
		}

		// Token: 0x17000F8F RID: 3983
		// (get) Token: 0x06003FAD RID: 16301 RVA: 0x0005FA5B File Offset: 0x0005DC5B
		// (set) Token: 0x06003FAE RID: 16302 RVA: 0x0005FA6F File Offset: 0x0005DC6F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UControlRig> ControlRigClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_ControlRigClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_ControlRigClass) = value;
			}
		}

		// Token: 0x17000F90 RID: 3984
		// (get) Token: 0x06003FAF RID: 16303 RVA: 0x0005FA84 File Offset: 0x0005DC84
		// (set) Token: 0x06003FB0 RID: 16304 RVA: 0x0005FA98 File Offset: 0x0005DC98
		[Nullable(2)]
		public unsafe UControlRig ControlRig
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UControlRig>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_ControlRig.__PropertyOffset_ControlRig);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNode_ControlRig.__PropertyOffset_ControlRig, value);
			}
		}

		// Token: 0x17000F91 RID: 3985
		// (get) Token: 0x06003FB1 RID: 16305 RVA: 0x0005FAAD File Offset: 0x0005DCAD
		// (set) Token: 0x06003FB2 RID: 16306 RVA: 0x0005FABD File Offset: 0x0005DCBD
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17000F92 RID: 3986
		// (get) Token: 0x06003FB3 RID: 16307 RVA: 0x0005FACE File Offset: 0x0005DCCE
		// (set) Token: 0x06003FB4 RID: 16308 RVA: 0x0005FADE File Offset: 0x0005DCDE
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x17000F93 RID: 3987
		// (get) Token: 0x06003FB5 RID: 16309 RVA: 0x0005FAEF File Offset: 0x0005DCEF
		// (set) Token: 0x06003FB6 RID: 16310 RVA: 0x0005FB08 File Offset: 0x0005DD08
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bAlphaBoolEnabled) & FAnimNode_ControlRig.__PropertyMask_bAlphaBoolEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bAlphaBoolEnabled) = ((*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bAlphaBoolEnabled) & ~FAnimNode_ControlRig.__PropertyMask_bAlphaBoolEnabled) | (value ? FAnimNode_ControlRig.__PropertyMask_bAlphaBoolEnabled : 0));
			}
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06003FB7 RID: 16311 RVA: 0x0005FB38 File Offset: 0x0005DD38
		// (set) Token: 0x06003FB8 RID: 16312 RVA: 0x0005FB51 File Offset: 0x0005DD51
		public unsafe bool bSetRefPoseFromSkeleton
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bSetRefPoseFromSkeleton) & FAnimNode_ControlRig.__PropertyMask_bSetRefPoseFromSkeleton) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bSetRefPoseFromSkeleton) = ((*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_bSetRefPoseFromSkeleton) & ~FAnimNode_ControlRig.__PropertyMask_bSetRefPoseFromSkeleton) | (value ? FAnimNode_ControlRig.__PropertyMask_bSetRefPoseFromSkeleton : 0));
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06003FB9 RID: 16313 RVA: 0x0005FB84 File Offset: 0x0005DD84
		// (set) Token: 0x06003FBA RID: 16314 RVA: 0x0005FBC7 File Offset: 0x0005DDC7
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F96 RID: 3990
		// (get) Token: 0x06003FBB RID: 16315 RVA: 0x0005FBE8 File Offset: 0x0005DDE8
		// (set) Token: 0x06003FBC RID: 16316 RVA: 0x0005FC2B File Offset: 0x0005DE2B
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F97 RID: 3991
		// (get) Token: 0x06003FBD RID: 16317 RVA: 0x0005FC4C File Offset: 0x0005DE4C
		// (set) Token: 0x06003FBE RID: 16318 RVA: 0x0005FC60 File Offset: 0x0005DE60
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x06003FBF RID: 16319 RVA: 0x0005FC78 File Offset: 0x0005DE78
		// (set) Token: 0x06003FC0 RID: 16320 RVA: 0x0005FCBB File Offset: 0x0005DEBB
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000F99 RID: 3993
		// (get) Token: 0x06003FC1 RID: 16321 RVA: 0x0005FCDC File Offset: 0x0005DEDC
		// (set) Token: 0x06003FC2 RID: 16322 RVA: 0x0005FD1F File Offset: 0x0005DF1F
		public TMap<FName, FName> InputMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._InputMapping) == null)
				{
					result = (this._InputMapping = new TMap<FName, FName>(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_InputMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InputMapping.CopyAssign(value);
			}
		}

		// Token: 0x17000F9A RID: 3994
		// (get) Token: 0x06003FC3 RID: 16323 RVA: 0x0005FD30 File Offset: 0x0005DF30
		// (set) Token: 0x06003FC4 RID: 16324 RVA: 0x0005FD73 File Offset: 0x0005DF73
		public TMap<FName, FName> OutputMapping
		{
			get
			{
				base.FastCheckIsValid();
				TMap<FName, FName> result;
				if ((result = this._OutputMapping) == null)
				{
					result = (this._OutputMapping = new TMap<FName, FName>(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_OutputMapping, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.OutputMapping.CopyAssign(value);
			}
		}

		// Token: 0x17000F9B RID: 3995
		// (get) Token: 0x06003FC5 RID: 16325 RVA: 0x0005FD81 File Offset: 0x0005DF81
		// (set) Token: 0x06003FC6 RID: 16326 RVA: 0x0005FD91 File Offset: 0x0005DF91
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ControlRig.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x06003FC7 RID: 16327 RVA: 0x0005FDA2 File Offset: 0x0005DFA2
		public FAnimNode_ControlRig()
		{
		}

		// Token: 0x06003FC8 RID: 16328 RVA: 0x0005FDAC File Offset: 0x0005DFAC
		public FAnimNode_ControlRig([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UControlRig> ControlRigClass, UControlRig ControlRig, float Alpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bSetRefPoseFromSkeleton, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp, TMap<FName, FName> InputMapping, TMap<FName, FName> OutputMapping, int LODThreshold, FPoseLink Source, TMap<FName, ushort> ControlRigBoneMapping, TMap<FName, ushort> ControlRigCurveMapping, TMap<FName, ushort> InputToCurveMappingUIDs, [Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<UNodeMappingContainer> NodeMappingContainer, FControlRigIOSettings InputSettings, FControlRigIOSettings OutputSettings, bool bExecute, TArray<FName> SourcePropertyNames, TArray<FName> DestPropertyNames, UObject TargetInstance)
		{
			this.ControlRigClass = ControlRigClass;
			this.ControlRig = ControlRig;
			this.Alpha = Alpha;
			this.AlphaInputType = AlphaInputType;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
			this.bSetRefPoseFromSkeleton = bSetRefPoseFromSkeleton;
			this.AlphaScaleBias = AlphaScaleBias;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
			this.InputMapping = InputMapping;
			this.OutputMapping = OutputMapping;
			this.LODThreshold = LODThreshold;
			base.Source = Source;
			base.ControlRigBoneMapping = ControlRigBoneMapping;
			base.ControlRigCurveMapping = ControlRigCurveMapping;
			base.InputToCurveMappingUIDs = InputToCurveMappingUIDs;
			base.NodeMappingContainer = NodeMappingContainer;
			base.InputSettings = InputSettings;
			base.OutputSettings = OutputSettings;
			base.bExecute = bExecute;
			base.SourcePropertyNames = SourcePropertyNames;
			base.DestPropertyNames = DestPropertyNames;
			base.TargetInstance = TargetInstance;
		}

		// Token: 0x06003FC9 RID: 16329 RVA: 0x0005FE7C File Offset: 0x0005E07C
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ControlRig.StaticStruct();
		}

		// Token: 0x06003FCA RID: 16330 RVA: 0x0005FE88 File Offset: 0x0005E088
		[NullableContext(2)]
		public FAnimNode_ControlRig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003FCB RID: 16331 RVA: 0x0005FE92 File Offset: 0x0005E092
		public FAnimNode_ControlRig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003FCC RID: 16332 RVA: 0x0005FE9D File Offset: 0x0005E09D
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ControlRig(Pointer, false, true);
		}

		// Token: 0x06003FCD RID: 16333 RVA: 0x0005FEA7 File Offset: 0x0005E0A7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ControlRig(Pointer, MemoryOwner);
		}

		// Token: 0x04001E6E RID: 7790
		public new const string __ObjectPath = "/Script/ControlRig.AnimNode_ControlRig";

		// Token: 0x04001E6F RID: 7791
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001E70 RID: 7792
		internal static int __PropertyOffset_ControlRigClass;

		// Token: 0x04001E71 RID: 7793
		internal static int __PropertyOffset_ControlRig;

		// Token: 0x04001E72 RID: 7794
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04001E73 RID: 7795
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x04001E74 RID: 7796
		internal static int __PropertyOffset_bAlphaBoolEnabled;

		// Token: 0x04001E75 RID: 7797
		internal static byte __PropertyMask_bAlphaBoolEnabled;

		// Token: 0x04001E76 RID: 7798
		internal static int __PropertyOffset_bSetRefPoseFromSkeleton;

		// Token: 0x04001E77 RID: 7799
		internal static byte __PropertyMask_bSetRefPoseFromSkeleton;

		// Token: 0x04001E78 RID: 7800
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x04001E79 RID: 7801
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x04001E7A RID: 7802
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x04001E7B RID: 7803
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x04001E7C RID: 7804
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x04001E7D RID: 7805
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x04001E7E RID: 7806
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;

		// Token: 0x04001E7F RID: 7807
		internal static int __PropertyOffset_InputMapping;

		// Token: 0x04001E80 RID: 7808
		[Nullable(2)]
		private TMap<FName, FName> _InputMapping;

		// Token: 0x04001E81 RID: 7809
		internal static int __PropertyOffset_OutputMapping;

		// Token: 0x04001E82 RID: 7810
		[Nullable(2)]
		private TMap<FName, FName> _OutputMapping;

		// Token: 0x04001E83 RID: 7811
		internal static int __PropertyOffset_LODThreshold;
	}
}
