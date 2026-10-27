using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C6 RID: 710
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.TransformConstraint")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FTransformConstraint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600275B RID: 10075 RVA: 0x0003B053 File Offset: 0x00039253
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformConstraint._ScriptStructPtr != 0) ? FTransformConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.TransformConstraint", ref FTransformConstraint._ScriptStructPtr);
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x0600275C RID: 10076 RVA: 0x0003B078 File Offset: 0x00039278
		// (set) Token: 0x0600275D RID: 10077 RVA: 0x0003B0BB File Offset: 0x000392BB
		public FConstraintDescription Operator
		{
			get
			{
				base.FastCheckIsValid();
				FConstraintDescription result;
				if ((result = this._Operator) == null)
				{
					result = (this._Operator = new FConstraintDescription(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_Operator, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FConstraintDescription.StaticStruct(), base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_Operator, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x0600275E RID: 10078 RVA: 0x0003B0DC File Offset: 0x000392DC
		// (set) Token: 0x0600275F RID: 10079 RVA: 0x0003B0F0 File Offset: 0x000392F0
		public unsafe FName SourceNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_SourceNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_SourceNode) = value;
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002760 RID: 10080 RVA: 0x0003B105 File Offset: 0x00039305
		// (set) Token: 0x06002761 RID: 10081 RVA: 0x0003B119 File Offset: 0x00039319
		public unsafe FName TargetNode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_TargetNode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_TargetNode) = value;
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002762 RID: 10082 RVA: 0x0003B12E File Offset: 0x0003932E
		// (set) Token: 0x06002763 RID: 10083 RVA: 0x0003B13E File Offset: 0x0003933E
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x06002764 RID: 10084 RVA: 0x0003B14F File Offset: 0x0003934F
		// (set) Token: 0x06002765 RID: 10085 RVA: 0x0003B15F File Offset: 0x0003935F
		public unsafe bool bMaintainOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_bMaintainOffset) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTransformConstraint.__PropertyOffset_bMaintainOffset) = (value ? 1 : 0);
			}
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0003B170 File Offset: 0x00039370
		public FTransformConstraint()
		{
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x0003B178 File Offset: 0x00039378
		public FTransformConstraint(FConstraintDescription Operator, FName SourceNode, FName TargetNode, float Weight, bool bMaintainOffset)
		{
			this.Operator = Operator;
			this.SourceNode = SourceNode;
			this.TargetNode = TargetNode;
			this.Weight = Weight;
			this.bMaintainOffset = bMaintainOffset;
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0003B1A5 File Offset: 0x000393A5
		protected override IntPtr GetUStructPtr()
		{
			return FTransformConstraint.StaticStruct();
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x0003B1B1 File Offset: 0x000393B1
		[NullableContext(2)]
		public FTransformConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x0003B1BB File Offset: 0x000393BB
		public FTransformConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x0003B1C6 File Offset: 0x000393C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformConstraint(Pointer, false, true);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x0003B1D0 File Offset: 0x000393D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x04000F83 RID: 3971
		public const string __ObjectPath = "/Script/AnimationCore.TransformConstraint";

		// Token: 0x04000F84 RID: 3972
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F85 RID: 3973
		internal static int __PropertyOffset_Operator;

		// Token: 0x04000F86 RID: 3974
		[Nullable(2)]
		private FConstraintDescription _Operator;

		// Token: 0x04000F87 RID: 3975
		internal static int __PropertyOffset_SourceNode;

		// Token: 0x04000F88 RID: 3976
		internal static int __PropertyOffset_TargetNode;

		// Token: 0x04000F89 RID: 3977
		internal static int __PropertyOffset_Weight;

		// Token: 0x04000F8A RID: 3978
		internal static int __PropertyOffset_bMaintainOffset;
	}
}
