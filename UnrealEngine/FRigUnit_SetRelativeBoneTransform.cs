using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006CB RID: 1739
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetRelativeBoneTransform")]
	[UnrealStructLayout(256, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 256)]
	public class FRigUnit_SetRelativeBoneTransform : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005CF3 RID: 23795 RVA: 0x0008559A File Offset: 0x0008379A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetRelativeBoneTransform._ScriptStructPtr != 0) ? FRigUnit_SetRelativeBoneTransform._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetRelativeBoneTransform", ref FRigUnit_SetRelativeBoneTransform._ScriptStructPtr);
		}

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x06005CF4 RID: 23796 RVA: 0x000855BE File Offset: 0x000837BE
		// (set) Token: 0x06005CF5 RID: 23797 RVA: 0x000855D2 File Offset: 0x000837D2
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x06005CF6 RID: 23798 RVA: 0x000855E7 File Offset: 0x000837E7
		// (set) Token: 0x06005CF7 RID: 23799 RVA: 0x000855FB File Offset: 0x000837FB
		public unsafe FName Space
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Space);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Space) = value;
			}
		}

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x06005CF8 RID: 23800 RVA: 0x00085610 File Offset: 0x00083810
		// (set) Token: 0x06005CF9 RID: 23801 RVA: 0x00085624 File Offset: 0x00083824
		public unsafe FTransform Transform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Transform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Transform) = value;
			}
		}

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x06005CFA RID: 23802 RVA: 0x00085639 File Offset: 0x00083839
		// (set) Token: 0x06005CFB RID: 23803 RVA: 0x00085649 File Offset: 0x00083849
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x06005CFC RID: 23804 RVA: 0x0008565A File Offset: 0x0008385A
		// (set) Token: 0x06005CFD RID: 23805 RVA: 0x0008566A File Offset: 0x0008386A
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06005CFE RID: 23806 RVA: 0x0008567C File Offset: 0x0008387C
		// (set) Token: 0x06005CFF RID: 23807 RVA: 0x000856BF File Offset: 0x000838BF
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06005D00 RID: 23808 RVA: 0x000856E0 File Offset: 0x000838E0
		// (set) Token: 0x06005D01 RID: 23809 RVA: 0x00085723 File Offset: 0x00083923
		public FCachedRigElement CachedSpaceIndex
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedSpaceIndex) == null)
				{
					result = (this._CachedSpaceIndex = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_CachedSpaceIndex, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetRelativeBoneTransform.__PropertyOffset_CachedSpaceIndex, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x00085744 File Offset: 0x00083944
		public FRigUnit_SetRelativeBoneTransform()
		{
		}

		// Token: 0x06005D03 RID: 23811 RVA: 0x0008574C File Offset: 0x0008394C
		public FRigUnit_SetRelativeBoneTransform(FName Bone, FName Space, FTransform Transform, float Weight, bool bPropagateToChildren, FCachedRigElement CachedBone, FCachedRigElement CachedSpaceIndex, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Space = Space;
			this.Transform = Transform;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			this.CachedSpaceIndex = CachedSpaceIndex;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005D04 RID: 23812 RVA: 0x0008579C File Offset: 0x0008399C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetRelativeBoneTransform.StaticStruct();
		}

		// Token: 0x06005D05 RID: 23813 RVA: 0x000857A8 File Offset: 0x000839A8
		[NullableContext(2)]
		public FRigUnit_SetRelativeBoneTransform(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x000857B2 File Offset: 0x000839B2
		public FRigUnit_SetRelativeBoneTransform(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x000857BD File Offset: 0x000839BD
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetRelativeBoneTransform(Pointer, false, true);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x000857C7 File Offset: 0x000839C7
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetRelativeBoneTransform(Pointer, MemoryOwner);
		}

		// Token: 0x04002B7B RID: 11131
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetRelativeBoneTransform";

		// Token: 0x04002B7C RID: 11132
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002B7D RID: 11133
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002B7E RID: 11134
		internal static int __PropertyOffset_Space;

		// Token: 0x04002B7F RID: 11135
		internal static int __PropertyOffset_Transform;

		// Token: 0x04002B80 RID: 11136
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002B81 RID: 11137
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002B82 RID: 11138
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002B83 RID: 11139
		[Nullable(2)]
		private FCachedRigElement _CachedBone;

		// Token: 0x04002B84 RID: 11140
		internal static int __PropertyOffset_CachedSpaceIndex;

		// Token: 0x04002B85 RID: 11141
		[Nullable(2)]
		private FCachedRigElement _CachedSpaceIndex;
	}
}
