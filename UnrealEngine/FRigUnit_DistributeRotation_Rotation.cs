using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200059B RID: 1435
	[UnrealObjectPath("/Script/ControlRig.RigUnit_DistributeRotation_Rotation")]
	[UnrealStructLayout(32, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FRigUnit_DistributeRotation_Rotation : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004D07 RID: 19719 RVA: 0x00071E09 File Offset: 0x00070009
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_DistributeRotation_Rotation._ScriptStructPtr != 0) ? FRigUnit_DistributeRotation_Rotation._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_DistributeRotation_Rotation", ref FRigUnit_DistributeRotation_Rotation._ScriptStructPtr);
		}

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004D08 RID: 19720 RVA: 0x00071E2D File Offset: 0x0007002D
		// (set) Token: 0x06004D09 RID: 19721 RVA: 0x00071E41 File Offset: 0x00070041
		public unsafe FQuat Rotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_Rotation.__PropertyOffset_Rotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_Rotation.__PropertyOffset_Rotation) = value;
			}
		}

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004D0A RID: 19722 RVA: 0x00071E56 File Offset: 0x00070056
		// (set) Token: 0x06004D0B RID: 19723 RVA: 0x00071E66 File Offset: 0x00070066
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_Rotation.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_DistributeRotation_Rotation.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x06004D0C RID: 19724 RVA: 0x00071E77 File Offset: 0x00070077
		public FRigUnit_DistributeRotation_Rotation()
		{
		}

		// Token: 0x06004D0D RID: 19725 RVA: 0x00071E7F File Offset: 0x0007007F
		public FRigUnit_DistributeRotation_Rotation(FQuat Rotation, float Ratio)
		{
			this.Rotation = Rotation;
			this.Ratio = Ratio;
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x00071E95 File Offset: 0x00070095
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_DistributeRotation_Rotation.StaticStruct();
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x00071EA1 File Offset: 0x000700A1
		[NullableContext(2)]
		public FRigUnit_DistributeRotation_Rotation(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x00071EAB File Offset: 0x000700AB
		public FRigUnit_DistributeRotation_Rotation(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004D11 RID: 19729 RVA: 0x00071EB6 File Offset: 0x000700B6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_DistributeRotation_Rotation(Pointer, false, true);
		}

		// Token: 0x06004D12 RID: 19730 RVA: 0x00071EC0 File Offset: 0x000700C0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_DistributeRotation_Rotation(Pointer, MemoryOwner);
		}

		// Token: 0x0400253D RID: 9533
		[Nullable(1)]
		public const string __ObjectPath = "/Script/ControlRig.RigUnit_DistributeRotation_Rotation";

		// Token: 0x0400253E RID: 9534
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400253F RID: 9535
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04002540 RID: 9536
		internal static int __PropertyOffset_Ratio;
	}
}
