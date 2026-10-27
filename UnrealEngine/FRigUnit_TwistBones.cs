using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020006EF RID: 1775
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_TwistBones")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FRigUnit_TwistBones : FRigUnit_HighlevelBaseMutable, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005F5C RID: 24412 RVA: 0x00088B5F File Offset: 0x00086D5F
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_TwistBones._ScriptStructPtr != 0) ? FRigUnit_TwistBones._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_TwistBones", ref FRigUnit_TwistBones._ScriptStructPtr);
		}

		// Token: 0x170016D0 RID: 5840
		// (get) Token: 0x06005F5D RID: 24413 RVA: 0x00088B83 File Offset: 0x00086D83
		// (set) Token: 0x06005F5E RID: 24414 RVA: 0x00088B97 File Offset: 0x00086D97
		public unsafe FName StartBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_StartBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_StartBone) = value;
			}
		}

		// Token: 0x170016D1 RID: 5841
		// (get) Token: 0x06005F5F RID: 24415 RVA: 0x00088BAC File Offset: 0x00086DAC
		// (set) Token: 0x06005F60 RID: 24416 RVA: 0x00088BC0 File Offset: 0x00086DC0
		public unsafe FName EndBone
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_EndBone);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_EndBone) = value;
			}
		}

		// Token: 0x170016D2 RID: 5842
		// (get) Token: 0x06005F61 RID: 24417 RVA: 0x00088BD5 File Offset: 0x00086DD5
		// (set) Token: 0x06005F62 RID: 24418 RVA: 0x00088BE9 File Offset: 0x00086DE9
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x170016D3 RID: 5843
		// (get) Token: 0x06005F63 RID: 24419 RVA: 0x00088BFE File Offset: 0x00086DFE
		// (set) Token: 0x06005F64 RID: 24420 RVA: 0x00088C12 File Offset: 0x00086E12
		public unsafe FVector PoleAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_PoleAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_PoleAxis) = value;
			}
		}

		// Token: 0x170016D4 RID: 5844
		// (get) Token: 0x06005F65 RID: 24421 RVA: 0x00088C27 File Offset: 0x00086E27
		// (set) Token: 0x06005F66 RID: 24422 RVA: 0x00088C37 File Offset: 0x00086E37
		public unsafe EControlRigAnimEasingType TwistEaseType
		{
			get
			{
				return (EControlRigAnimEasingType)(*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_TwistEaseType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_TwistEaseType) = (byte)value;
			}
		}

		// Token: 0x170016D5 RID: 5845
		// (get) Token: 0x06005F67 RID: 24423 RVA: 0x00088C48 File Offset: 0x00086E48
		// (set) Token: 0x06005F68 RID: 24424 RVA: 0x00088C58 File Offset: 0x00086E58
		public unsafe float Weight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_Weight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_Weight) = value;
			}
		}

		// Token: 0x170016D6 RID: 5846
		// (get) Token: 0x06005F69 RID: 24425 RVA: 0x00088C69 File Offset: 0x00086E69
		// (set) Token: 0x06005F6A RID: 24426 RVA: 0x00088C79 File Offset: 0x00086E79
		public unsafe bool bPropagateToChildren
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_bPropagateToChildren) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_bPropagateToChildren) = (value ? 1 : 0);
			}
		}

		// Token: 0x170016D7 RID: 5847
		// (get) Token: 0x06005F6B RID: 24427 RVA: 0x00088C8C File Offset: 0x00086E8C
		// (set) Token: 0x06005F6C RID: 24428 RVA: 0x00088CCF File Offset: 0x00086ECF
		public FRigUnit_TwistBones_WorkData WorkData
		{
			get
			{
				base.FastCheckIsValid();
				FRigUnit_TwistBones_WorkData result;
				if ((result = this._WorkData) == null)
				{
					result = (this._WorkData = new FRigUnit_TwistBones_WorkData(base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_WorkData, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRigUnit_TwistBones_WorkData.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_TwistBones.__PropertyOffset_WorkData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005F6D RID: 24429 RVA: 0x00088CF0 File Offset: 0x00086EF0
		public FRigUnit_TwistBones()
		{
		}

		// Token: 0x06005F6E RID: 24430 RVA: 0x00088CF8 File Offset: 0x00086EF8
		public FRigUnit_TwistBones(FName StartBone, FName EndBone, FVector TwistAxis, FVector PoleAxis, EControlRigAnimEasingType TwistEaseType, float Weight, bool bPropagateToChildren, FRigUnit_TwistBones_WorkData WorkData, FControlRigExecuteContext ExecuteContext)
		{
			this.StartBone = StartBone;
			this.EndBone = EndBone;
			this.TwistAxis = TwistAxis;
			this.PoleAxis = PoleAxis;
			this.TwistEaseType = TwistEaseType;
			this.Weight = Weight;
			this.bPropagateToChildren = bPropagateToChildren;
			this.WorkData = WorkData;
			base.ExecuteContext = ExecuteContext;
		}

		// Token: 0x06005F6F RID: 24431 RVA: 0x00088D50 File Offset: 0x00086F50
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_TwistBones.StaticStruct();
		}

		// Token: 0x06005F70 RID: 24432 RVA: 0x00088D5C File Offset: 0x00086F5C
		[NullableContext(2)]
		public FRigUnit_TwistBones(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005F71 RID: 24433 RVA: 0x00088D66 File Offset: 0x00086F66
		public FRigUnit_TwistBones(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005F72 RID: 24434 RVA: 0x00088D71 File Offset: 0x00086F71
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_TwistBones(Pointer, false, true);
		}

		// Token: 0x06005F73 RID: 24435 RVA: 0x00088D7B File Offset: 0x00086F7B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_TwistBones(Pointer, MemoryOwner);
		}

		// Token: 0x04002C93 RID: 11411
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_TwistBones";

		// Token: 0x04002C94 RID: 11412
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C95 RID: 11413
		internal static int __PropertyOffset_StartBone;

		// Token: 0x04002C96 RID: 11414
		internal static int __PropertyOffset_EndBone;

		// Token: 0x04002C97 RID: 11415
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x04002C98 RID: 11416
		internal static int __PropertyOffset_PoleAxis;

		// Token: 0x04002C99 RID: 11417
		internal static int __PropertyOffset_TwistEaseType;

		// Token: 0x04002C9A RID: 11418
		internal static int __PropertyOffset_Weight;

		// Token: 0x04002C9B RID: 11419
		internal static int __PropertyOffset_bPropagateToChildren;

		// Token: 0x04002C9C RID: 11420
		internal static int __PropertyOffset_WorkData;

		// Token: 0x04002C9D RID: 11421
		[Nullable(2)]
		private FRigUnit_TwistBones_WorkData _WorkData;
	}
}
