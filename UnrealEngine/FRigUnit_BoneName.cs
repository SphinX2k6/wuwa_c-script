using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000558 RID: 1368
	[UnrealObjectPath("/Script/ControlRig.RigUnit_BoneName")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_BoneName : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004863 RID: 18531 RVA: 0x0006B4E8 File Offset: 0x000696E8
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_BoneName._ScriptStructPtr != 0) ? FRigUnit_BoneName._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_BoneName", ref FRigUnit_BoneName._ScriptStructPtr);
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x06004864 RID: 18532 RVA: 0x0006B50C File Offset: 0x0006970C
		// (set) Token: 0x06004865 RID: 18533 RVA: 0x0006B520 File Offset: 0x00069720
		public unsafe FName Bone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_BoneName.__PropertyOffset_Bone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_BoneName.__PropertyOffset_Bone) = value;
			}
		}

		// Token: 0x06004866 RID: 18534 RVA: 0x0006B535 File Offset: 0x00069735
		public FRigUnit_BoneName()
		{
		}

		// Token: 0x06004867 RID: 18535 RVA: 0x0006B53D File Offset: 0x0006973D
		public FRigUnit_BoneName(FName Bone)
		{
			this.Bone = Bone;
		}

		// Token: 0x06004868 RID: 18536 RVA: 0x0006B54C File Offset: 0x0006974C
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_BoneName.StaticStruct();
		}

		// Token: 0x06004869 RID: 18537 RVA: 0x0006B558 File Offset: 0x00069758
		[NullableContext(2)]
		public FRigUnit_BoneName(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600486A RID: 18538 RVA: 0x0006B562 File Offset: 0x00069762
		public FRigUnit_BoneName(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600486B RID: 18539 RVA: 0x0006B56D File Offset: 0x0006976D
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_BoneName(Pointer, false, true);
		}

		// Token: 0x0600486C RID: 18540 RVA: 0x0006B577 File Offset: 0x00069777
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_BoneName(Pointer, MemoryOwner);
		}

		// Token: 0x0400231D RID: 8989
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_BoneName";

		// Token: 0x0400231E RID: 8990
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400231F RID: 8991
		internal static int __PropertyOffset_Bone;
	}
}
