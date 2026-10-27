using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000813 RID: 2067
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 232)]
	public class FAnimNode_ApplyMeshSpaceAdditive : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006F17 RID: 28439 RVA: 0x0009F628 File Offset: 0x0009D828
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_ApplyMeshSpaceAdditive._ScriptStructPtr != 0) ? FAnimNode_ApplyMeshSpaceAdditive._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_ApplyMeshSpaceAdditive", ref FAnimNode_ApplyMeshSpaceAdditive._ScriptStructPtr);
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x06006F18 RID: 28440 RVA: 0x0009F64C File Offset: 0x0009D84C
		// (set) Token: 0x06006F19 RID: 28441 RVA: 0x0009F68F File Offset: 0x0009D88F
		public FPoseLink Base
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Base) == null)
				{
					result = (this._Base = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Base, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Base, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x06006F1A RID: 28442 RVA: 0x0009F6B0 File Offset: 0x0009D8B0
		// (set) Token: 0x06006F1B RID: 28443 RVA: 0x0009F6F3 File Offset: 0x0009D8F3
		public FPoseLink Additive
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Additive) == null)
				{
					result = (this._Additive = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Additive, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Additive, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x06006F1C RID: 28444 RVA: 0x0009F714 File Offset: 0x0009D914
		// (set) Token: 0x06006F1D RID: 28445 RVA: 0x0009F724 File Offset: 0x0009D924
		public unsafe EAnimAlphaInputType AlphaInputType
		{
			get
			{
				return (EAnimAlphaInputType)(*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaInputType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaInputType) = (byte)value;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x06006F1E RID: 28446 RVA: 0x0009F735 File Offset: 0x0009D935
		// (set) Token: 0x06006F1F RID: 28447 RVA: 0x0009F745 File Offset: 0x0009D945
		public unsafe float Alpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Alpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_Alpha) = value;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x06006F20 RID: 28448 RVA: 0x0009F756 File Offset: 0x0009D956
		// (set) Token: 0x06006F21 RID: 28449 RVA: 0x0009F76F File Offset: 0x0009D96F
		public unsafe bool bAlphaBoolEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_bAlphaBoolEnabled) & FAnimNode_ApplyMeshSpaceAdditive.__PropertyMask_bAlphaBoolEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_bAlphaBoolEnabled) = ((*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_bAlphaBoolEnabled) & ~FAnimNode_ApplyMeshSpaceAdditive.__PropertyMask_bAlphaBoolEnabled) | (value ? FAnimNode_ApplyMeshSpaceAdditive.__PropertyMask_bAlphaBoolEnabled : 0));
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x06006F22 RID: 28450 RVA: 0x0009F7A0 File Offset: 0x0009D9A0
		// (set) Token: 0x06006F23 RID: 28451 RVA: 0x0009F7E3 File Offset: 0x0009D9E3
		public FInputAlphaBoolBlend AlphaBoolBlend
		{
			get
			{
				base.FastCheckIsValid();
				FInputAlphaBoolBlend result;
				if ((result = this._AlphaBoolBlend) == null)
				{
					result = (this._AlphaBoolBlend = new FInputAlphaBoolBlend(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaBoolBlend, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputAlphaBoolBlend.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaBoolBlend, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x06006F24 RID: 28452 RVA: 0x0009F804 File Offset: 0x0009DA04
		// (set) Token: 0x06006F25 RID: 28453 RVA: 0x0009F818 File Offset: 0x0009DA18
		public unsafe FName AlphaCurveName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaCurveName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaCurveName) = value;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06006F26 RID: 28454 RVA: 0x0009F830 File Offset: 0x0009DA30
		// (set) Token: 0x06006F27 RID: 28455 RVA: 0x0009F873 File Offset: 0x0009DA73
		public FInputScaleBias AlphaScaleBias
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBias result;
				if ((result = this._AlphaScaleBias) == null)
				{
					result = (this._AlphaScaleBias = new FInputScaleBias(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaScaleBias, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBias.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaScaleBias, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06006F28 RID: 28456 RVA: 0x0009F894 File Offset: 0x0009DA94
		// (set) Token: 0x06006F29 RID: 28457 RVA: 0x0009F8D7 File Offset: 0x0009DAD7
		public FInputScaleBiasClamp AlphaScaleBiasClamp
		{
			get
			{
				base.FastCheckIsValid();
				FInputScaleBiasClamp result;
				if ((result = this._AlphaScaleBiasClamp) == null)
				{
					result = (this._AlphaScaleBiasClamp = new FInputScaleBiasClamp(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaScaleBiasClamp, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputScaleBiasClamp.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_AlphaScaleBiasClamp, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06006F2A RID: 28458 RVA: 0x0009F8F8 File Offset: 0x0009DAF8
		// (set) Token: 0x06006F2B RID: 28459 RVA: 0x0009F908 File Offset: 0x0009DB08
		public unsafe int LODThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_LODThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_ApplyMeshSpaceAdditive.__PropertyOffset_LODThreshold) = value;
			}
		}

		// Token: 0x06006F2C RID: 28460 RVA: 0x0009F919 File Offset: 0x0009DB19
		public FAnimNode_ApplyMeshSpaceAdditive()
		{
		}

		// Token: 0x06006F2D RID: 28461 RVA: 0x0009F924 File Offset: 0x0009DB24
		public FAnimNode_ApplyMeshSpaceAdditive(FPoseLink Base, FPoseLink Additive, EAnimAlphaInputType AlphaInputType, float Alpha, bool bAlphaBoolEnabled, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBias AlphaScaleBias, FInputScaleBiasClamp AlphaScaleBiasClamp, int LODThreshold)
		{
			this.Base = Base;
			this.Additive = Additive;
			this.AlphaInputType = AlphaInputType;
			this.Alpha = Alpha;
			this.bAlphaBoolEnabled = bAlphaBoolEnabled;
			this.AlphaBoolBlend = AlphaBoolBlend;
			this.AlphaCurveName = AlphaCurveName;
			this.AlphaScaleBias = AlphaScaleBias;
			this.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
			this.LODThreshold = LODThreshold;
		}

		// Token: 0x06006F2E RID: 28462 RVA: 0x0009F984 File Offset: 0x0009DB84
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_ApplyMeshSpaceAdditive.StaticStruct();
		}

		// Token: 0x06006F2F RID: 28463 RVA: 0x0009F990 File Offset: 0x0009DB90
		[NullableContext(2)]
		public FAnimNode_ApplyMeshSpaceAdditive(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006F30 RID: 28464 RVA: 0x0009F99A File Offset: 0x0009DB9A
		public FAnimNode_ApplyMeshSpaceAdditive(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006F31 RID: 28465 RVA: 0x0009F9A5 File Offset: 0x0009DBA5
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_ApplyMeshSpaceAdditive(Pointer, false, true);
		}

		// Token: 0x06006F32 RID: 28466 RVA: 0x0009F9AF File Offset: 0x0009DBAF
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_ApplyMeshSpaceAdditive(Pointer, MemoryOwner);
		}

		// Token: 0x04003563 RID: 13667
		public new const string __ObjectPath = "/Script/Engine.AnimNode_ApplyMeshSpaceAdditive";

		// Token: 0x04003564 RID: 13668
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003565 RID: 13669
		internal static int __PropertyOffset_Base;

		// Token: 0x04003566 RID: 13670
		[Nullable(2)]
		private FPoseLink _Base;

		// Token: 0x04003567 RID: 13671
		internal static int __PropertyOffset_Additive;

		// Token: 0x04003568 RID: 13672
		[Nullable(2)]
		private FPoseLink _Additive;

		// Token: 0x04003569 RID: 13673
		internal static int __PropertyOffset_AlphaInputType;

		// Token: 0x0400356A RID: 13674
		internal static int __PropertyOffset_Alpha;

		// Token: 0x0400356B RID: 13675
		internal static int __PropertyOffset_bAlphaBoolEnabled;

		// Token: 0x0400356C RID: 13676
		internal static byte __PropertyMask_bAlphaBoolEnabled;

		// Token: 0x0400356D RID: 13677
		internal static int __PropertyOffset_AlphaBoolBlend;

		// Token: 0x0400356E RID: 13678
		[Nullable(2)]
		private FInputAlphaBoolBlend _AlphaBoolBlend;

		// Token: 0x0400356F RID: 13679
		internal static int __PropertyOffset_AlphaCurveName;

		// Token: 0x04003570 RID: 13680
		internal static int __PropertyOffset_AlphaScaleBias;

		// Token: 0x04003571 RID: 13681
		[Nullable(2)]
		private FInputScaleBias _AlphaScaleBias;

		// Token: 0x04003572 RID: 13682
		internal static int __PropertyOffset_AlphaScaleBiasClamp;

		// Token: 0x04003573 RID: 13683
		[Nullable(2)]
		private FInputScaleBiasClamp _AlphaScaleBiasClamp;

		// Token: 0x04003574 RID: 13684
		internal static int __PropertyOffset_LODThreshold;
	}
}
