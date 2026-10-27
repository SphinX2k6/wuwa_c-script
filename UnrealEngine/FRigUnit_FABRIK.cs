using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020005A5 RID: 1445
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_FABRIK")]
	[UnrealStructLayout(272, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FRigUnit_FABRIK : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D85 RID: 19845 RVA: 0x0007275A File Offset: 0x0007095A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_FABRIK._ScriptStructPtr != 0) ? FRigUnit_FABRIK._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_FABRIK", ref FRigUnit_FABRIK._ScriptStructPtr);
		}

		// Token: 0x17001304 RID: 4868
		// (get) Token: 0x06004D86 RID: 19846 RVA: 0x0007277E File Offset: 0x0007097E
		// (set) Token: 0x06004D87 RID: 19847 RVA: 0x00072792 File Offset: 0x00070992
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x17001305 RID: 4869
		// (get) Token: 0x06004D88 RID: 19848 RVA: 0x000727A7 File Offset: 0x000709A7
		// (set) Token: 0x06004D89 RID: 19849 RVA: 0x000727BB File Offset: 0x000709BB
		public unsafe FName EffectorBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_EffectorBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_EffectorBone) = value;
			}
		}

		// Token: 0x17001306 RID: 4870
		// (get) Token: 0x06004D8A RID: 19850 RVA: 0x000727D0 File Offset: 0x000709D0
		// (set) Token: 0x06004D8B RID: 19851 RVA: 0x000727E4 File Offset: 0x000709E4
		public unsafe FTransform EffectorTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_EffectorTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_EffectorTransform) = value;
			}
		}

		// Token: 0x17001307 RID: 4871
		// (get) Token: 0x06004D8C RID: 19852 RVA: 0x000727F9 File Offset: 0x000709F9
		// (set) Token: 0x06004D8D RID: 19853 RVA: 0x00072809 File Offset: 0x00070A09
		public unsafe float Precision
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_Precision);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_Precision) = value;
			}
		}

		// Token: 0x17001308 RID: 4872
		// (get) Token: 0x06004D8E RID: 19854 RVA: 0x0007281A File Offset: 0x00070A1A
		// (set) Token: 0x06004D8F RID: 19855 RVA: 0x0007282A File Offset: 0x00070A2A
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001309 RID: 4873
		// (get) Token: 0x06004D90 RID: 19856 RVA: 0x0007283B File Offset: 0x00070A3B
		// (set) Token: 0x06004D91 RID: 19857 RVA: 0x0007284B File Offset: 0x00070A4B
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700130A RID: 4874
		// (get) Token: 0x06004D92 RID: 19858 RVA: 0x0007285C File Offset: 0x00070A5C
		// (set) Token: 0x06004D93 RID: 19859 RVA: 0x0007286C File Offset: 0x00070A6C
		public unsafe int MaxIterations
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_MaxIterations);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_MaxIterations) = value;
			}
		}

		// Token: 0x1700130B RID: 4875
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x00072880 File Offset: 0x00070A80
		// (set) Token: 0x06004D95 RID: 19861 RVA: 0x000728C3 File Offset: 0x00070AC3
		public FRigUnit_FABRIK_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_FABRIK_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_FABRIK_WorkData(base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_FABRIK_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_FABRIK.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004D96 RID: 19862 RVA: 0x000728E4 File Offset: 0x00070AE4
		public FRigUnit_FABRIK()
		{
		}

		// Token: 0x06004D97 RID: 19863 RVA: 0x000728EC File Offset: 0x00070AEC
		public FRigUnit_FABRIK(FName StartBone, FName EffectorBone, FTransform EffectorTransform, float Precision, float Weight, bool bPropagateToChildren, int MaxIterations, FRigUnit_FABRIK_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EffectorBone = EffectorBone;
			this.EffectorTransform = EffectorTransform;
			this.Precision = Precision;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.MaxIterations = MaxIterations;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004D98 RID: 19864 RVA: 0x00072944 File Offset: 0x00070B44
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_FABRIK.StaticStruct();
		}

		// Token: 0x06004D99 RID: 19865 RVA: 0x00072950 File Offset: 0x00070B50
		[NullableContext(2)]
		public FRigUnit_FABRIK(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D9A RID: 19866 RVA: 0x0007295A File Offset: 0x00070B5A
		public FRigUnit_FABRIK(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D9B RID: 19867 RVA: 0x00072965 File Offset: 0x00070B65
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_FABRIK(Pointer, false, true);
		}

		// Token: 0x06004D9C RID: 19868 RVA: 0x0007296F File Offset: 0x00070B6F
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_FABRIK(Pointer, MemoryOwner);
		}

		// Token: 0x0400256D RID: 9581
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_FABRIK";

		// Token: 0x0400256E RID: 9582
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400256F RID: 9583
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04002570 RID: 9584
		internal static int __PropertyOffset_EffectorBone;

		// Token: 0x04002571 RID: 9585
		internal static int __PropertyOffset_EffectorTransform;

		// Token: 0x04002572 RID: 9586
		internal static int __PropertyOffset_Precision;

		// Token: 0x04002573 RID: 9587
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002574 RID: 9588
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002575 RID: 9589
		internal static int __PropertyOffset_MaxIterations;

		// Token: 0x04002576 RID: 9590
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002577 RID: 9591
		[Nullable(2)]
		private FRigUnit_FABRIK_WorkData _WorkData;
	}
}
