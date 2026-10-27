using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200053C RID: 1340
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AddBoneTransform")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FRigUnit_AddBoneTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004674 RID: 18036 RVA: 0x00068885 File Offset: 0x00066A85
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AddBoneTransform._ScriptStructPtr != 0) ? FRigUnit_AddBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AddBoneTransform", ref FRigUnit_AddBoneTransform._ScriptStructPtr);
		}

		// Token: 0x1700111E RID: 4382
		// (get) Token: 0x06004675 RID: 18037 RVA: 0x000688A9 File Offset: 0x00066AA9
		// (set) Token: 0x06004676 RID: 18038 RVA: 0x000688BD File Offset: 0x00066ABD
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x1700111F RID: 4383
		// (get) Token: 0x06004677 RID: 18039 RVA: 0x000688D2 File Offset: 0x00066AD2
		// (set) Token: 0x06004678 RID: 18040 RVA: 0x000688E6 File Offset: 0x00066AE6
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x17001120 RID: 4384
		// (get) Token: 0x06004679 RID: 18041 RVA: 0x000688FB File Offset: 0x00066AFB
		// (set) Token: 0x0600467A RID: 18042 RVA: 0x0006890B File Offset: 0x00066B0B
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x17001121 RID: 4385
		// (get) Token: 0x0600467B RID: 18043 RVA: 0x0006891C File Offset: 0x00066B1C
		// (set) Token: 0x0600467C RID: 18044 RVA: 0x0006892C File Offset: 0x00066B2C
		public unsafe bool bPostMultiply
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_bPostMultiply) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_bPostMultiply) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001122 RID: 4386
		// (get) Token: 0x0600467D RID: 18045 RVA: 0x0006893D File Offset: 0x00066B3D
		// (set) Token: 0x0600467E RID: 18046 RVA: 0x0006894D File Offset: 0x00066B4D
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001123 RID: 4387
		// (get) Token: 0x0600467F RID: 18047 RVA: 0x00068960 File Offset: 0x00066B60
		// (set) Token: 0x06004680 RID: 18048 RVA: 0x000689A3 File Offset: 0x00066BA3
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_AddBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x000689C4 File Offset: 0x00066BC4
		public FRigUnit_AddBoneTransform()
		{
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x000689CC File Offset: 0x00066BCC
		public FRigUnit_AddBoneTransform(FName Bone, FTransform Transform, float Weight, bool bPostMultiply, bool bPropagateToChildren, FCachedRigElement CachedBone, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Transform = Transform;
			this.Weight = Weight;
			this.bPostMultiply = bPostMultiply;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00068A09 File Offset: 0x00066C09
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AddBoneTransform.StaticStruct();
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x00068A15 File Offset: 0x00066C15
		[NullableContext(2)]
		public FRigUnit_AddBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x00068A1F File Offset: 0x00066C1F
		public FRigUnit_AddBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x00068A2A File Offset: 0x00066C2A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AddBoneTransform(Pointer, false, true);
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x00068A34 File Offset: 0x00066C34
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AddBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002237 RID: 8759
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AddBoneTransform";

		// Token: 0x04002238 RID: 8760
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002239 RID: 8761
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400223A RID: 8762
		internal static int __PropertyOffset_Transform;

		// Token: 0x0400223B RID: 8763
		internal static int __PropertyOffset_Weight;

		// Token: 0x0400223C RID: 8764
		internal static int __PropertyOffset_bPostMultiply;

		// Token: 0x0400223D RID: 8765
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x0400223E RID: 8766
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x0400223F RID: 8767
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
