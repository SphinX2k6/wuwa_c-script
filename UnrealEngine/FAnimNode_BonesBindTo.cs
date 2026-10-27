using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001605 RID: 5637
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.AnimNode_BonesBindTo")]
	[UnrealStructLayout(552, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 552)]
	public class FAnimNode_BonesBindTo : FAnimNode_SkeletalControlBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014520 RID: 83232 RVA: 0x001DDA10 File Offset: 0x001DBC10
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_BonesBindTo._ScriptStructPtr != 0) ? FAnimNode_BonesBindTo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimNode_BonesBindTo", ref FAnimNode_BonesBindTo._ScriptStructPtr);
		}

		// Token: 0x17004FBE RID: 20414
		// (get) Token: 0x06014521 RID: 83233 RVA: 0x001DDA34 File Offset: 0x001DBC34
		// (set) Token: 0x06014522 RID: 83234 RVA: 0x001DDA77 File Offset: 0x001DBC77
		public TArray<FBonesBindToConfigParams> Configs
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBonesBindToConfigParams> result;
				if ((result = this._Configs) == null)
				{
					result = (this._Configs = new TArray<FBonesBindToConfigParams>(base.NativePtr + (IntPtr)FAnimNode_BonesBindTo.__PropertyOffset_Configs, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Configs.CopyAssign(value);
			}
		}

		// Token: 0x06014523 RID: 83235 RVA: 0x001DDA85 File Offset: 0x001DBC85
		public FAnimNode_BonesBindTo()
		{
		}

		// Token: 0x06014524 RID: 83236 RVA: 0x001DDA90 File Offset: 0x001DBC90
		public FAnimNode_BonesBindTo(TArray<FBonesBindToConfigParams> Configs, bool bDebugDraw, FComponentSpacePoseLink ComponentPose, int LODThreshold, int KuroLODMask, float ActualAlpha, EAnimAlphaInputType AlphaInputType, bool bAlphaBoolEnabled, bool bParallelEvalEnabled, bool bEnableOnMobile, float Alpha, FInputScaleBias AlphaScaleBias, FInputAlphaBoolBlend AlphaBoolBlend, FName AlphaCurveName, FInputScaleBiasClamp AlphaScaleBiasClamp)
		{
			this.Configs = Configs;
			base.ComponentPose = ComponentPose;
			base.LODThreshold = LODThreshold;
			base.KuroLODMask = KuroLODMask;
			base.ActualAlpha = ActualAlpha;
			base.AlphaInputType = AlphaInputType;
			base.bAlphaBoolEnabled = bAlphaBoolEnabled;
			base.bParallelEvalEnabled = bParallelEvalEnabled;
			base.bEnableOnMobile = bEnableOnMobile;
			base.Alpha = Alpha;
			base.AlphaScaleBias = AlphaScaleBias;
			base.AlphaBoolBlend = AlphaBoolBlend;
			base.AlphaCurveName = AlphaCurveName;
			base.AlphaScaleBiasClamp = AlphaScaleBiasClamp;
		}

		// Token: 0x06014525 RID: 83237 RVA: 0x001DDB11 File Offset: 0x001DBD11
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_BonesBindTo.StaticStruct();
		}

		// Token: 0x06014526 RID: 83238 RVA: 0x001DDB1D File Offset: 0x001DBD1D
		[NullableContext(2)]
		public FAnimNode_BonesBindTo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014527 RID: 83239 RVA: 0x001DDB27 File Offset: 0x001DBD27
		public FAnimNode_BonesBindTo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014528 RID: 83240 RVA: 0x001DDB32 File Offset: 0x001DBD32
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_BonesBindTo(Pointer, false, true);
		}

		// Token: 0x06014529 RID: 83241 RVA: 0x001DDB3C File Offset: 0x001DBD3C
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_BonesBindTo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B0ED RID: 45293
		public new const string __ObjectPath = "/Script/KuroAnim.AnimNode_BonesBindTo";

		// Token: 0x0400B0EE RID: 45294
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B0EF RID: 45295
		internal static int __PropertyOffset_Configs;

		// Token: 0x0400B0F0 RID: 45296
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBonesBindToConfigParams> _Configs;
	}
}
