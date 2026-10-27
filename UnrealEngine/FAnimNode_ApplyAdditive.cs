using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CF RID: 719
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FAnimNode_ApplyAdditive : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002828 RID: 10280 RVA: 0x0003C620 File Offset: 0x0003A820
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ApplyAdditive._ScriptStructPtr != 0) ? FAnimNode_ApplyAdditive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_ApplyAdditive", ref FAnimNode_ApplyAdditive._ScriptStructPtr);
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06002829 RID: 10281 RVA: 0x0003C644 File Offset: 0x0003A844
		// (set) Token: 0x0600282A RID: 10282 RVA: 0x0003C687 File Offset: 0x0003A887
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x0600282B RID: 10283 RVA: 0x0003C6A8 File Offset: 0x0003A8A8
		// (set) Token: 0x0600282C RID: 10284 RVA: 0x0003C6EB File Offset: 0x0003A8EB
		public FPoseLink Additive
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Additive) == null)
				{
					result = (this._Additive = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Additive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Additive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x0600282D RID: 10285 RVA: 0x0003C70C File Offset: 0x0003A90C
		// (set) Token: 0x0600282E RID: 10286 RVA: 0x0003C71C File Offset: 0x0003A91C
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x0600282F RID: 10287 RVA: 0x0003C730 File Offset: 0x0003A930
		// (set) Token: 0x06002830 RID: 10288 RVA: 0x0003C773 File Offset: 0x0003A973
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06002831 RID: 10289 RVA: 0x0003C794 File Offset: 0x0003A994
		// (set) Token: 0x06002832 RID: 10290 RVA: 0x0003C7A4 File Offset: 0x0003A9A4
		public unsafe bool bOnlyAddPose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_bOnlyAddPose) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_bOnlyAddPose) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06002833 RID: 10291 RVA: 0x0003C7B5 File Offset: 0x0003A9B5
		// (set) Token: 0x06002834 RID: 10292 RVA: 0x0003C7C5 File Offset: 0x0003A9C5
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06002835 RID: 10293 RVA: 0x0003C7D8 File Offset: 0x0003A9D8
		// (set) Token: 0x06002836 RID: 10294 RVA: 0x0003C81B File Offset: 0x0003AA1B
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06002837 RID: 10295 RVA: 0x0003C83C File Offset: 0x0003AA3C
		// (set) Token: 0x06002838 RID: 10296 RVA: 0x0003C850 File Offset: 0x0003AA50
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06002839 RID: 10297 RVA: 0x0003C868 File Offset: 0x0003AA68
		// (set) Token: 0x0600283A RID: 10298 RVA: 0x0003C8AB File Offset: 0x0003AAAB
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x0600283B RID: 10299 RVA: 0x0003C8CC File Offset: 0x0003AACC
		// (set) Token: 0x0600283C RID: 10300 RVA: 0x0003C8DC File Offset: 0x0003AADC
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x0600283D RID: 10301 RVA: 0x0003C8ED File Offset: 0x0003AAED
		// (set) Token: 0x0600283E RID: 10302 RVA: 0x0003C8FD File Offset: 0x0003AAFD
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_bAlphaBoolEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyAdditive.__PropertyOffset_bAlphaBoolEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600283F RID: 10303 RVA: 0x0003C90E File Offset: 0x0003AB0E
		public FAnimNode_ApplyAdditive()
		{
		}

		// Token: 0x06002840 RID: 10304 RVA: 0x0003C918 File Offset: 0x0003AB18
		public FAnimNode_ApplyAdditive(FPoseLink Base, FPoseLink Additive, float Alpha, FInputScaleBias AlphaScaleBias, bool bOnlyAddPose, int LODThreshold, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled)
		{
			this.Base = Base;
			this.Additive = Additive;
			this.Alpha = Alpha;
			this.AlphaScaleBias = AlphaScaleBias;
			this.bOnlyAddPose = bOnlyAddPose;
			this.LODThreshold = LODThreshold;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
			this.AlphaInputType = AlphaInputType;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
		}

		// Token: 0x06002841 RID: 10305 RVA: 0x0003C980 File Offset: 0x0003AB80
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ApplyAdditive.StaticStruct();
		}

		// Token: 0x06002842 RID: 10306 RVA: 0x0003C98C File Offset: 0x0003AB8C
		[NullableContext(2)]
		public FAnimNode_ApplyAdditive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002843 RID: 10307 RVA: 0x0003C996 File Offset: 0x0003AB96
		public FAnimNode_ApplyAdditive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002844 RID: 10308 RVA: 0x0003C9A1 File Offset: 0x0003ABA1
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ApplyAdditive(Pointer, false, true);
		}

		// Token: 0x06002845 RID: 10309 RVA: 0x0003C9AB File Offset: 0x0003ABAB
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ApplyAdditive(Pointer, MemoryOwner);
		}

		// Token: 0x04000FF3 RID: 4083
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_ApplyAdditive";

		// Token: 0x04000FF4 RID: 4084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000FF5 RID: 4085
		internal static int __PropertyOffset_Base;

		// Token: 0x04000FF6 RID: 4086
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x04000FF7 RID: 4087
		internal static int __PropertyOffset_Additive;

		// Token: 0x04000FF8 RID: 4088
		[Nullable(2)]
		private FPoseLink _Additive;

		// Token: 0x04000FF9 RID: 4089
		internal static int __PropertyOffset_Alpha;

		// Token: 0x04000FFA RID: 4090
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x04000FFB RID: 4091
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x04000FFC RID: 4092
		internal static int __PropertyOffset_bOnlyAddPose;

		// Token: 0x04000FFD RID: 4093
		internal static int __PropertyOffset_LODThreshold;

		// Token: 0x04000FFE RID: 4094
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x04000FFF RID: 4095
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x04001000 RID: 4096
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x04001001 RID: 4097
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x04001002 RID: 4098
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;

		// Token: 0x04001003 RID: 4099
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x04001004 RID: 4100
		internal static int __PropertyOffset_bAlphaBoolEnabled;
	}
}
