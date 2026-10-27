using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020003C9 RID: 969
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AugmentedReality.ARSkeletonDefinition")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FARSkeletonDefinition : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003649 RID: 13897 RVA: 0x00052662 File Offset: 0x00050862
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FARSkeletonDefinition._ScriptStructPtr != 0) ? FARSkeletonDefinition._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AugmentedReality.ARSkeletonDefinition", ref FARSkeletonDefinition._ScriptStructPtr);
		}

		// Token: 0x17000CEB RID: 3307
		// (get) Token: 0x0600364A RID: 13898 RVA: 0x00052686 File Offset: 0x00050886
		// (set) Token: 0x0600364B RID: 13899 RVA: 0x00052696 File Offset: 0x00050896
		public unsafe int NumJoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FARSkeletonDefinition.__PropertyOffset_NumJoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FARSkeletonDefinition.__PropertyOffset_NumJoints) = value;
			}
		}

		// Token: 0x17000CEC RID: 3308
		// (get) Token: 0x0600364C RID: 13900 RVA: 0x000526A8 File Offset: 0x000508A8
		// (set) Token: 0x0600364D RID: 13901 RVA: 0x000526EB File Offset: 0x000508EB
		public TArray<FName> JointNames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._JointNames) == null)
				{
					result = (this._JointNames = new TArray<FName>(base.NativePtr + (IntPtr)FARSkeletonDefinition.__PropertyOffset_JointNames, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.JointNames.CopyAssign(value);
			}
		}

		// Token: 0x17000CED RID: 3309
		// (get) Token: 0x0600364E RID: 13902 RVA: 0x000526FC File Offset: 0x000508FC
		// (set) Token: 0x0600364F RID: 13903 RVA: 0x0005273F File Offset: 0x0005093F
		public TArray<int> ParentIndices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ParentIndices) == null)
				{
					result = (this._ParentIndices = new TArray<int>(base.NativePtr + (IntPtr)FARSkeletonDefinition.__PropertyOffset_ParentIndices, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ParentIndices.CopyAssign(value);
			}
		}

		// Token: 0x06003650 RID: 13904 RVA: 0x0005274D File Offset: 0x0005094D
		public FARSkeletonDefinition()
		{
		}

		// Token: 0x06003651 RID: 13905 RVA: 0x00052755 File Offset: 0x00050955
		public FARSkeletonDefinition(int NumJoints, TArray<FName> JointNames, TArray<int> ParentIndices)
		{
			this.NumJoints = NumJoints;
			this.JointNames = JointNames;
			this.ParentIndices = ParentIndices;
		}

		// Token: 0x06003652 RID: 13906 RVA: 0x00052772 File Offset: 0x00050972
		protected override IntPtr GetUStructPtr()
		{
			return FARSkeletonDefinition.StaticStruct();
		}

		// Token: 0x06003653 RID: 13907 RVA: 0x0005277E File Offset: 0x0005097E
		[NullableContext(2)]
		public FARSkeletonDefinition(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x00052788 File Offset: 0x00050988
		public FARSkeletonDefinition(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003655 RID: 13909 RVA: 0x00052793 File Offset: 0x00050993
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FARSkeletonDefinition(Pointer, false, true);
		}

		// Token: 0x06003656 RID: 13910 RVA: 0x0005279D File Offset: 0x0005099D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FARSkeletonDefinition(Pointer, MemoryOwner);
		}

		// Token: 0x04001776 RID: 6006
		public const string __ObjectPath = "/Script/AugmentedReality.ARSkeletonDefinition";

		// Token: 0x04001777 RID: 6007
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001778 RID: 6008
		internal static int __PropertyOffset_NumJoints;

		// Token: 0x04001779 RID: 6009
		internal static int __PropertyOffset_JointNames;

		// Token: 0x0400177A RID: 6010
		[Nullable(2)]
		private TArray<FName> _JointNames;

		// Token: 0x0400177B RID: 6011
		internal static int __PropertyOffset_ParentIndices;

		// Token: 0x0400177C RID: 6012
		[Nullable(2)]
		private TArray<int> _ParentIndices;
	}
}
