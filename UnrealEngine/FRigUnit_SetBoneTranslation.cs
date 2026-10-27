using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006B5 RID: 1717
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_SetBoneTranslation")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 176)]
	public class FRigUnit_SetBoneTranslation : FRigUnitMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005BAD RID: 23469 RVA: 0x00083A30 File Offset: 0x00081C30
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_SetBoneTranslation._ScriptStructPtr != 0) ? FRigUnit_SetBoneTranslation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_SetBoneTranslation", ref FRigUnit_SetBoneTranslation._ScriptStructPtr);
		}

		// Token: 0x170015E0 RID: 5600
		// (get) Token: 0x06005BAE RID: 23470 RVA: 0x00083A54 File Offset: 0x00081C54
		// (set) Token: 0x06005BAF RID: 23471 RVA: 0x00083A68 File Offset: 0x00081C68
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x170015E1 RID: 5601
		// (get) Token: 0x06005BB0 RID: 23472 RVA: 0x00083A7D File Offset: 0x00081C7D
		// (set) Token: 0x06005BB1 RID: 23473 RVA: 0x00083A91 File Offset: 0x00081C91
		public unsafe FVector Translation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Translation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Translation) = value;
			}
		}

		// Token: 0x170015E2 RID: 5602
		// (get) Token: 0x06005BB2 RID: 23474 RVA: 0x00083AA6 File Offset: 0x00081CA6
		// (set) Token: 0x06005BB3 RID: 23475 RVA: 0x00083AB6 File Offset: 0x00081CB6
		public unsafe EBoneGetterSetterMode Space
		{
			get
			{
				return (EBoneGetterSetterMode)(*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Space));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Space) = (byte)value;
			}
		}

		// Token: 0x170015E3 RID: 5603
		// (get) Token: 0x06005BB4 RID: 23476 RVA: 0x00083AC7 File Offset: 0x00081CC7
		// (set) Token: 0x06005BB5 RID: 23477 RVA: 0x00083AD7 File Offset: 0x00081CD7
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170015E4 RID: 5604
		// (get) Token: 0x06005BB6 RID: 23478 RVA: 0x00083AE8 File Offset: 0x00081CE8
		// (set) Token: 0x06005BB7 RID: 23479 RVA: 0x00083AF8 File Offset: 0x00081CF8
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170015E5 RID: 5605
		// (get) Token: 0x06005BB8 RID: 23480 RVA: 0x00083B0C File Offset: 0x00081D0C
		// (set) Token: 0x06005BB9 RID: 23481 RVA: 0x00083B4F File Offset: 0x00081D4F
		public FCachedRigElement CachedBone
		{
			get
			{
				base.FastCheckIsValid();
				FCachedRigElement result;
				if ((result = this._CachedBone) == null)
				{
					result = (this._CachedBone = new FCachedRigElement(base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_CachedBone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCachedRigElement.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_SetBoneTranslation.__PropertyOffset_CachedBone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005BBA RID: 23482 RVA: 0x00083B70 File Offset: 0x00081D70
		public FRigUnit_SetBoneTranslation()
		{
		}

		// Token: 0x06005BBB RID: 23483 RVA: 0x00083B78 File Offset: 0x00081D78
		public FRigUnit_SetBoneTranslation(FName Bone, FVector Translation, EBoneGetterSetterMode Space, float Weight, bool bPropagateToChildren, FCachedRigElement CachedBone, FControlRigExecuteContext ExecuteContext)
		{
			this.Bone = Bone;
			this.Translation = Translation;
			this.Space = Space;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.CachedBone = CachedBone;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005BBC RID: 23484 RVA: 0x00083BB5 File Offset: 0x00081DB5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_SetBoneTranslation.StaticStruct();
		}

		// Token: 0x06005BBD RID: 23485 RVA: 0x00083BC1 File Offset: 0x00081DC1
		[NullableContext(2)]
		public FRigUnit_SetBoneTranslation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005BBE RID: 23486 RVA: 0x00083BCB File Offset: 0x00081DCB
		public FRigUnit_SetBoneTranslation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005BBF RID: 23487 RVA: 0x00083BD6 File Offset: 0x00081DD6
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_SetBoneTranslation(Pointer, false, true);
		}

		// Token: 0x06005BC0 RID: 23488 RVA: 0x00083BE0 File Offset: 0x00081DE0
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_SetBoneTranslation(Pointer, MemoryOwner);
		}

		// Token: 0x04002AED RID: 10989
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_SetBoneTranslation";

		// Token: 0x04002AEE RID: 10990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AEF RID: 10991
		internal static int __PropertyOffset_Bone;

		// Token: 0x04002AF0 RID: 10992
		internal static int __PropertyOffset_Translation;

		// Token: 0x04002AF1 RID: 10993
		internal static int __PropertyOffset_Space;

		// Token: 0x04002AF2 RID: 10994
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002AF3 RID: 10995
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002AF4 RID: 10996
		internal static int __PropertyOffset_CachedBone;

		// Token: 0x04002AF5 RID: 10997
		[Nullable(2)]
		private FCachedRigElement _CachedBone;
	}
}
