using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B3 RID: 1715
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetBoneRotation")]
	[UnrealStructLayout(192, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 192)]
	public class FRigUnit_SetBoneRotation : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005B83 RID: 23427 RVA: 0x00083685 File Offset: 0x00081885
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetBoneRotation._ScriptStructPtr != 0) ? FRigUnit_SetBoneRotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetBoneRotation", ref FRigUnit_SetBoneRotation._ScriptStructPtr);
		}

		// Token: 0x170015D3 RID: 5587
		// (get) Token: 0x06005B84 RID: 23428 RVA: 0x000836A9 File Offset: 0x000818A9
		// (set) Token: 0x06005B85 RID: 23429 RVA: 0x000836BD File Offset: 0x000818BD
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06005B86 RID: 23430 RVA: 0x000836D2 File Offset: 0x000818D2
		// (set) Token: 0x06005B87 RID: 23431 RVA: 0x000836E6 File Offset: 0x000818E6
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x06005B88 RID: 23432 RVA: 0x000836FB File Offset: 0x000818FB
		// (set) Token: 0x06005B89 RID: 23433 RVA: 0x0008370B File Offset: 0x0008190B
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x06005B8A RID: 23434 RVA: 0x0008371C File Offset: 0x0008191C
		// (set) Token: 0x06005B8B RID: 23435 RVA: 0x0008372C File Offset: 0x0008192C
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x06005B8C RID: 23436 RVA: 0x0008373D File Offset: 0x0008193D
		// (set) Token: 0x06005B8D RID: 23437 RVA: 0x0008374D File Offset: 0x0008194D
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06005B8E RID: 23438 RVA: 0x00083760 File Offset: 0x00081960
		// (set) Token: 0x06005B8F RID: 23439 RVA: 0x000837A3 File Offset: 0x000819A3
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetBoneRotation.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005B90 RID: 23440 RVA: 0x000837C4 File Offset: 0x000819C4
		public FRigUnit_SetBoneRotation()
		{
		}

		// Token: 0x06005B91 RID: 23441 RVA: 0x000837CC File Offset: 0x000819CC
		public FRigUnit_SetBoneRotation(FName Bone, FQuat Rotation, EBoneGetterSetterMode Space, float Weight, bool bPropagateToChildren, FCachedRigElement CachedBone, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Rotation = Rotation;
			this.Space = Space;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005B92 RID: 23442 RVA: 0x00083809 File Offset: 0x00081A09
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetBoneRotation.StaticStruct();
		}

		// Token: 0x06005B93 RID: 23443 RVA: 0x00083815 File Offset: 0x00081A15
		[NullableContext(2)]
		public FRigUnit_SetBoneRotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005B94 RID: 23444 RVA: 0x0008381F File Offset: 0x00081A1F
		public FRigUnit_SetBoneRotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005B95 RID: 23445 RVA: 0x0008382A File Offset: 0x00081A2A
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetBoneRotation(Pointer, false, true);
		}

		// Token: 0x06005B96 RID: 23446 RVA: 0x00083834 File Offset: 0x00081A34
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetBoneRotation(Pointer, MemoryOwner);
		}

		// Token: 0x04002ADA RID: 10970
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetBoneRotation";

		// Token: 0x04002ADB RID: 10971
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002ADC RID: 10972
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002ADD RID: 10973
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002ADE RID: 10974
		internal static int __PropertyOffset_Space;

		// Token: 0x04002ADF RID: 10975
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002AE0 RID: 10976
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002AE1 RID: 10977
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002AE2 RID: 10978
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
