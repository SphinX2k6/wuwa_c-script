using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000511 RID: 1297
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.MovieSceneControlRigInstanceData")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 216)]
	public class FMovieSceneControlRigInstanceData : FMovieSceneSequenceInstanceData, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060043AF RID: 17327 RVA: 0x00064C1E File Offset: 0x00062E1E
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMovieSceneControlRigInstanceData._ScriptStructPtr != 0) ? FMovieSceneControlRigInstanceData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.MovieSceneControlRigInstanceData", ref FMovieSceneControlRigInstanceData._ScriptStructPtr);
		}

		// Token: 0x17001062 RID: 4194
		// (get) Token: 0x060043B0 RID: 17328 RVA: 0x00064C42 File Offset: 0x00062E42
		// (set) Token: 0x060043B1 RID: 17329 RVA: 0x00064C52 File Offset: 0x00062E52
		public unsafe bool bAdditive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_bAdditive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_bAdditive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001063 RID: 4195
		// (get) Token: 0x060043B2 RID: 17330 RVA: 0x00064C63 File Offset: 0x00062E63
		// (set) Token: 0x060043B3 RID: 17331 RVA: 0x00064C73 File Offset: 0x00062E73
		public unsafe bool bApplyBoneFilter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_bApplyBoneFilter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_bApplyBoneFilter) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001064 RID: 4196
		// (get) Token: 0x060043B4 RID: 17332 RVA: 0x00064C84 File Offset: 0x00062E84
		// (set) Token: 0x060043B5 RID: 17333 RVA: 0x00064CC7 File Offset: 0x00062EC7
		public FInputBlendPose BoneFilter
		{
			get
			{
				base.FastCheckIsValid();
				FInputBlendPose result;
				if ((result = this._BoneFilter) == null)
				{
					result = (this._BoneFilter = new FInputBlendPose(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_BoneFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputBlendPose.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_BoneFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001065 RID: 4197
		// (get) Token: 0x060043B6 RID: 17334 RVA: 0x00064CE8 File Offset: 0x00062EE8
		// (set) Token: 0x060043B7 RID: 17335 RVA: 0x00064D2B File Offset: 0x00062F2B
		public FMovieSceneFloatChannel Weight
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._Weight) == null)
				{
					result = (this._Weight = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_Weight, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_Weight, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001066 RID: 4198
		// (get) Token: 0x060043B8 RID: 17336 RVA: 0x00064D4C File Offset: 0x00062F4C
		// (set) Token: 0x060043B9 RID: 17337 RVA: 0x00064D8F File Offset: 0x00062F8F
		public FMovieSceneEvaluationOperand Operand
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneEvaluationOperand result;
				if ((result = this._Operand) == null)
				{
					result = (this._Operand = new FMovieSceneEvaluationOperand(base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_Operand, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneEvaluationOperand.StaticStruct(), base.NativePtr + (IntPtr)FMovieSceneControlRigInstanceData.__PropertyOffset_Operand, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060043BA RID: 17338 RVA: 0x00064DB0 File Offset: 0x00062FB0
		public FMovieSceneControlRigInstanceData()
		{
		}

		// Token: 0x060043BB RID: 17339 RVA: 0x00064DB8 File Offset: 0x00062FB8
		public FMovieSceneControlRigInstanceData(bool bAdditive, bool bApplyBoneFilter, FInputBlendPose BoneFilter, FMovieSceneFloatChannel Weight, FMovieSceneEvaluationOperand Operand)
		{
			this.bAdditive = bAdditive;
			this.bApplyBoneFilter = bApplyBoneFilter;
			this.BoneFilter = BoneFilter;
			this.Weight = Weight;
			this.Operand = Operand;
		}

		// Token: 0x060043BC RID: 17340 RVA: 0x00064DE5 File Offset: 0x00062FE5
		protected override IntPtr GetUStructPtr()
		{
			return FMovieSceneControlRigInstanceData.StaticStruct();
		}

		// Token: 0x060043BD RID: 17341 RVA: 0x00064DF1 File Offset: 0x00062FF1
		[NullableContext(2)]
		public FMovieSceneControlRigInstanceData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060043BE RID: 17342 RVA: 0x00064DFB File Offset: 0x00062FFB
		public FMovieSceneControlRigInstanceData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060043BF RID: 17343 RVA: 0x00064E06 File Offset: 0x00063006
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMovieSceneControlRigInstanceData(Pointer, false, true);
		}

		// Token: 0x060043C0 RID: 17344 RVA: 0x00064E10 File Offset: 0x00063010
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMovieSceneControlRigInstanceData(Pointer, MemoryOwner);
		}

		// Token: 0x040020EF RID: 8431
		public new const string __ObjectPath = "/Script/ControlRig.MovieSceneControlRigInstanceData";

		// Token: 0x040020F0 RID: 8432
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040020F1 RID: 8433
		internal static int __PropertyOffset_bAdditive;

		// Token: 0x040020F2 RID: 8434
		internal static int __PropertyOffset_bApplyBoneFilter;

		// Token: 0x040020F3 RID: 8435
		internal static int __PropertyOffset_BoneFilter;

		// Token: 0x040020F4 RID: 8436
		[Nullable(2)]
		private FInputBlendPose _BoneFilter;

		// Token: 0x040020F5 RID: 8437
		internal static int __PropertyOffset_Weight;

		// Token: 0x040020F6 RID: 8438
		[Nullable(2)]
		private FMovieSceneFloatChannel _Weight;

		// Token: 0x040020F7 RID: 8439
		internal static int __PropertyOffset_Operand;

		// Token: 0x040020F8 RID: 8440
		[Nullable(2)]
		private FMovieSceneEvaluationOperand _Operand;
	}
}
