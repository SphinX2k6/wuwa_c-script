using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000822 RID: 2082
	[UnrealObjectPath("/Script/Engine.AnimNode_TransitionPoseEvaluator")]
	[UnrealStructLayout(320, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 320)]
	public class FAnimNode_TransitionPoseEvaluator : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007002 RID: 28674 RVA: 0x000A0BA6 File Offset: 0x0009EDA6
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_TransitionPoseEvaluator._ScriptStructPtr != 0) ? FAnimNode_TransitionPoseEvaluator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_TransitionPoseEvaluator", ref FAnimNode_TransitionPoseEvaluator._ScriptStructPtr);
		}

		// Token: 0x17001A5B RID: 6747
		// (get) Token: 0x06007003 RID: 28675 RVA: 0x000A0BCA File Offset: 0x0009EDCA
		// (set) Token: 0x06007004 RID: 28676 RVA: 0x000A0BDA File Offset: 0x0009EDDA
		public unsafe int FramesToCachePose
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_FramesToCachePose);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_FramesToCachePose) = value;
			}
		}

		// Token: 0x17001A5C RID: 6748
		// (get) Token: 0x06007005 RID: 28677 RVA: 0x000A0BEB File Offset: 0x0009EDEB
		// (set) Token: 0x06007006 RID: 28678 RVA: 0x000A0BFF File Offset: 0x0009EDFF
		public unsafe TEnumAsByte<EEvaluatorDataSource> DataSource
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_DataSource);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_DataSource) = value;
			}
		}

		// Token: 0x17001A5D RID: 6749
		// (get) Token: 0x06007007 RID: 28679 RVA: 0x000A0C14 File Offset: 0x0009EE14
		// (set) Token: 0x06007008 RID: 28680 RVA: 0x000A0C28 File Offset: 0x0009EE28
		public unsafe TEnumAsByte<EEvaluatorMode> EvaluatorMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_EvaluatorMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_TransitionPoseEvaluator.__PropertyOffset_EvaluatorMode) = value;
			}
		}

		// Token: 0x06007009 RID: 28681 RVA: 0x000A0C3D File Offset: 0x0009EE3D
		public FAnimNode_TransitionPoseEvaluator()
		{
		}

		// Token: 0x0600700A RID: 28682 RVA: 0x000A0C45 File Offset: 0x0009EE45
		public FAnimNode_TransitionPoseEvaluator(int FramesToCachePose, TEnumAsByte<EEvaluatorDataSource> DataSource, TEnumAsByte<EEvaluatorMode> EvaluatorMode)
		{
			this.FramesToCachePose = FramesToCachePose;
			this.DataSource = DataSource;
			this.EvaluatorMode = EvaluatorMode;
		}

		// Token: 0x0600700B RID: 28683 RVA: 0x000A0C62 File Offset: 0x0009EE62
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_TransitionPoseEvaluator.StaticStruct();
		}

		// Token: 0x0600700C RID: 28684 RVA: 0x000A0C6E File Offset: 0x0009EE6E
		[NullableContext(2)]
		public FAnimNode_TransitionPoseEvaluator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600700D RID: 28685 RVA: 0x000A0C78 File Offset: 0x0009EE78
		public FAnimNode_TransitionPoseEvaluator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600700E RID: 28686 RVA: 0x000A0C83 File Offset: 0x0009EE83
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_TransitionPoseEvaluator(Pointer, false, true);
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x000A0C8D File Offset: 0x0009EE8D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_TransitionPoseEvaluator(Pointer, MemoryOwner);
		}

		// Token: 0x040035CF RID: 13775
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNode_TransitionPoseEvaluator";

		// Token: 0x040035D0 RID: 13776
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035D1 RID: 13777
		internal static int __PropertyOffset_FramesToCachePose;

		// Token: 0x040035D2 RID: 13778
		internal static int __PropertyOffset_DataSource;

		// Token: 0x040035D3 RID: 13779
		internal static int __PropertyOffset_EvaluatorMode;
	}
}
