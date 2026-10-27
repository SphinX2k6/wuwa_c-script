using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052C RID: 1324
	[UnrealObjectPath("/Script/ControlRig.RigSpace")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FRigSpace : FRigElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600455F RID: 17759 RVA: 0x00067428 File Offset: 0x00065628
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigSpace._ScriptStructPtr != 0) ? FRigSpace._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigSpace", ref FRigSpace._ScriptStructPtr);
		}

		// Token: 0x170010D3 RID: 4307
		// (get) Token: 0x06004560 RID: 17760 RVA: 0x0006744C File Offset: 0x0006564C
		// (set) Token: 0x06004561 RID: 17761 RVA: 0x0006745C File Offset: 0x0006565C
		public unsafe ERigSpaceType SpaceType
		{
			get
			{
				return (ERigSpaceType)(*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_SpaceType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_SpaceType) = (byte)value;
			}
		}

		// Token: 0x170010D4 RID: 4308
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x0006746D File Offset: 0x0006566D
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x00067481 File Offset: 0x00065681
		public unsafe FName ParentName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_ParentName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_ParentName) = value;
			}
		}

		// Token: 0x170010D5 RID: 4309
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x00067496 File Offset: 0x00065696
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x000674A6 File Offset: 0x000656A6
		public unsafe int ParentIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_ParentIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_ParentIndex) = value;
			}
		}

		// Token: 0x170010D6 RID: 4310
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x000674B7 File Offset: 0x000656B7
		// (set) Token: 0x06004567 RID: 17767 RVA: 0x000674CB File Offset: 0x000656CB
		public unsafe FTransform InitialTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_InitialTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_InitialTransform) = value;
			}
		}

		// Token: 0x170010D7 RID: 4311
		// (get) Token: 0x06004568 RID: 17768 RVA: 0x000674E0 File Offset: 0x000656E0
		// (set) Token: 0x06004569 RID: 17769 RVA: 0x000674F4 File Offset: 0x000656F4
		public unsafe FTransform LocalTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_LocalTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigSpace.__PropertyOffset_LocalTransform) = value;
			}
		}

		// Token: 0x0600456A RID: 17770 RVA: 0x00067509 File Offset: 0x00065709
		public FRigSpace()
		{
		}

		// Token: 0x0600456B RID: 17771 RVA: 0x00067511 File Offset: 0x00065711
		public FRigSpace(ERigSpaceType SpaceType, FName ParentName, int ParentIndex, FTransform InitialTransform, FTransform LocalTransform, FName Name, int Index)
		{
			this.SpaceType = SpaceType;
			this.ParentName = ParentName;
			this.ParentIndex = ParentIndex;
			this.InitialTransform = InitialTransform;
			this.LocalTransform = LocalTransform;
			base.Name = Name;
			base.Index = Index;
		}

		// Token: 0x0600456C RID: 17772 RVA: 0x0006754E File Offset: 0x0006574E
		protected override IntPtr GetUStructPtr()
		{
			return FRigSpace.StaticStruct();
		}

		// Token: 0x0600456D RID: 17773 RVA: 0x0006755A File Offset: 0x0006575A
		[NullableContext(2)]
		public FRigSpace(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600456E RID: 17774 RVA: 0x00067564 File Offset: 0x00065764
		public FRigSpace(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600456F RID: 17775 RVA: 0x0006756F File Offset: 0x0006576F
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigSpace(Pointer, false, true);
		}

		// Token: 0x06004570 RID: 17776 RVA: 0x00067579 File Offset: 0x00065779
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigSpace(Pointer, MemoryOwner);
		}

		// Token: 0x040021C8 RID: 8648
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigSpace";

		// Token: 0x040021C9 RID: 8649
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021CA RID: 8650
		internal static int __PropertyOffset_SpaceType;

		// Token: 0x040021CB RID: 8651
		internal static int __PropertyOffset_ParentName;

		// Token: 0x040021CC RID: 8652
		internal static int __PropertyOffset_ParentIndex;

		// Token: 0x040021CD RID: 8653
		internal static int __PropertyOffset_InitialTransform;

		// Token: 0x040021CE RID: 8654
		internal static int __PropertyOffset_LocalTransform;
	}
}
