using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000534 RID: 1332
	[UnrealObjectPath("/Script/ControlRig.RigUnit_AccumulateQuatLerp")]
	[UnrealStructLayout(96, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FRigUnit_AccumulateQuatLerp : FRigUnit_SimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060045DA RID: 17882 RVA: 0x00067D20 File Offset: 0x00065F20
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_AccumulateQuatLerp._ScriptStructPtr != 0) ? FRigUnit_AccumulateQuatLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_AccumulateQuatLerp", ref FRigUnit_AccumulateQuatLerp._ScriptStructPtr);
		}

		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x060045DB RID: 17883 RVA: 0x00067D44 File Offset: 0x00065F44
		// (set) Token: 0x060045DC RID: 17884 RVA: 0x00067D58 File Offset: 0x00065F58
		public unsafe FQuat TargetValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_TargetValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_TargetValue) = value;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (get) Token: 0x060045DD RID: 17885 RVA: 0x00067D6D File Offset: 0x00065F6D
		// (set) Token: 0x060045DE RID: 17886 RVA: 0x00067D81 File Offset: 0x00065F81
		public unsafe FQuat InitialValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_InitialValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_InitialValue) = value;
			}
		}

		// Token: 0x170010F3 RID: 4339
		// (get) Token: 0x060045DF RID: 17887 RVA: 0x00067D96 File Offset: 0x00065F96
		// (set) Token: 0x060045E0 RID: 17888 RVA: 0x00067DA6 File Offset: 0x00065FA6
		public unsafe float Blend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_Blend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_Blend) = value;
			}
		}

		// Token: 0x170010F4 RID: 4340
		// (get) Token: 0x060045E1 RID: 17889 RVA: 0x00067DB7 File Offset: 0x00065FB7
		// (set) Token: 0x060045E2 RID: 17890 RVA: 0x00067DC7 File Offset: 0x00065FC7
		public unsafe bool bIntegrateDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_bIntegrateDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_bIntegrateDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x170010F5 RID: 4341
		// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00067DD8 File Offset: 0x00065FD8
		// (set) Token: 0x060045E4 RID: 17892 RVA: 0x00067DEC File Offset: 0x00065FEC
		public unsafe FQuat Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x170010F6 RID: 4342
		// (get) Token: 0x060045E5 RID: 17893 RVA: 0x00067E01 File Offset: 0x00066001
		// (set) Token: 0x060045E6 RID: 17894 RVA: 0x00067E15 File Offset: 0x00066015
		public unsafe FQuat AccumulatedValue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_AccumulatedValue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_AccumulateQuatLerp.__PropertyOffset_AccumulatedValue) = value;
			}
		}

		// Token: 0x060045E7 RID: 17895 RVA: 0x00067E2A File Offset: 0x0006602A
		public FRigUnit_AccumulateQuatLerp()
		{
		}

		// Token: 0x060045E8 RID: 17896 RVA: 0x00067E32 File Offset: 0x00066032
		public FRigUnit_AccumulateQuatLerp(FQuat TargetValue, FQuat InitialValue, float Blend, bool bIntegrateDeltaTime, FQuat Result, FQuat AccumulatedValue)
		{
			this.TargetValue = TargetValue;
			this.InitialValue = InitialValue;
			this.Blend = Blend;
			this.bIntegrateDeltaTime = bIntegrateDeltaTime;
			this.Result = Result;
			this.AccumulatedValue = AccumulatedValue;
		}

		// Token: 0x060045E9 RID: 17897 RVA: 0x00067E67 File Offset: 0x00066067
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_AccumulateQuatLerp.StaticStruct();
		}

		// Token: 0x060045EA RID: 17898 RVA: 0x00067E73 File Offset: 0x00066073
		[NullableContext(2)]
		public FRigUnit_AccumulateQuatLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060045EB RID: 17899 RVA: 0x00067E7D File Offset: 0x0006607D
		public FRigUnit_AccumulateQuatLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060045EC RID: 17900 RVA: 0x00067E88 File Offset: 0x00066088
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_AccumulateQuatLerp(Pointer, false, true);
		}

		// Token: 0x060045ED RID: 17901 RVA: 0x00067E92 File Offset: 0x00066092
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_AccumulateQuatLerp(Pointer, MemoryOwner);
		}

		// Token: 0x040021FA RID: 8698
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_AccumulateQuatLerp";

		// Token: 0x040021FB RID: 8699
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040021FC RID: 8700
		internal static int __PropertyOffset_TargetValue;

		// Token: 0x040021FD RID: 8701
		internal static int __PropertyOffset_InitialValue;

		// Token: 0x040021FE RID: 8702
		internal static int __PropertyOffset_Blend;

		// Token: 0x040021FF RID: 8703
		internal static int __PropertyOffset_bIntegrateDeltaTime;

		// Token: 0x04002200 RID: 8704
		internal static int __PropertyOffset_Result;

		// Token: 0x04002201 RID: 8705
		internal static int __PropertyOffset_AccumulatedValue;
	}
}
