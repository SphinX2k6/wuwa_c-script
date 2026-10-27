using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002DF RID: 735
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CurveFix")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAnimNode_CurveFix : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002998 RID: 10648 RVA: 0x0003EEE4 File Offset: 0x0003D0E4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CurveFix._ScriptStructPtr != 0) ? FAnimNode_CurveFix._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CurveFix", ref FAnimNode_CurveFix._ScriptStructPtr);
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06002999 RID: 10649 RVA: 0x0003EF08 File Offset: 0x0003D108
		// (set) Token: 0x0600299A RID: 10650 RVA: 0x0003EF4B File Offset: 0x0003D14B
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_CurveFix.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_CurveFix.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x0600299B RID: 10651 RVA: 0x0003EF6C File Offset: 0x0003D16C
		// (set) Token: 0x0600299C RID: 10652 RVA: 0x0003EFAF File Offset: 0x0003D1AF
		public TArray<FAntiCurveMap> AntiCurveMap
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAntiCurveMap> result;
				if ((result = this._AntiCurveMap) == null)
				{
					result = (this._AntiCurveMap = new TArray<FAntiCurveMap>(base.NativePtr + (IntPtr)FAnimNode_CurveFix.__PropertyOffset_AntiCurveMap, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AntiCurveMap.CopyAssign(value);
			}
		}

		// Token: 0x0600299D RID: 10653 RVA: 0x0003EFBD File Offset: 0x0003D1BD
		public FAnimNode_CurveFix()
		{
		}

		// Token: 0x0600299E RID: 10654 RVA: 0x0003EFC5 File Offset: 0x0003D1C5
		public FAnimNode_CurveFix(FPoseLink SourcePose, TArray<FAntiCurveMap> AntiCurveMap)
		{
			this.SourcePose = SourcePose;
			this.AntiCurveMap = AntiCurveMap;
		}

		// Token: 0x0600299F RID: 10655 RVA: 0x0003EFDB File Offset: 0x0003D1DB
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CurveFix.StaticStruct();
		}

		// Token: 0x060029A0 RID: 10656 RVA: 0x0003EFE7 File Offset: 0x0003D1E7
		[NullableContext(2)]
		public FAnimNode_CurveFix(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060029A1 RID: 10657 RVA: 0x0003EFF1 File Offset: 0x0003D1F1
		public FAnimNode_CurveFix(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060029A2 RID: 10658 RVA: 0x0003EFFC File Offset: 0x0003D1FC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CurveFix(Pointer, false, true);
		}

		// Token: 0x060029A3 RID: 10659 RVA: 0x0003F006 File Offset: 0x0003D206
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CurveFix(Pointer, MemoryOwner);
		}

		// Token: 0x040010BA RID: 4282
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CurveFix";

		// Token: 0x040010BB RID: 4283
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040010BC RID: 4284
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x040010BD RID: 4285
		[Nullable(2)]
		private FPoseLink _SourcePose;

		// Token: 0x040010BE RID: 4286
		internal static int __PropertyOffset_AntiCurveMap;

		// Token: 0x040010BF RID: 4287
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAntiCurveMap> _AntiCurveMap;
	}
}
