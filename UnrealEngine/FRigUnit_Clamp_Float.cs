using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000564 RID: 1380
	[UnrealObjectPath("/Script/ControlRig.RigUnit_Clamp_Float")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_Clamp_Float : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004969 RID: 18793 RVA: 0x0006CF08 File Offset: 0x0006B108
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_Clamp_Float._ScriptStructPtr != 0) ? FRigUnit_Clamp_Float._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_Clamp_Float", ref FRigUnit_Clamp_Float._ScriptStructPtr);
		}

		// Token: 0x170011F9 RID: 4601
		// (get) Token: 0x0600496A RID: 18794 RVA: 0x0006CF2C File Offset: 0x0006B12C
		// (set) Token: 0x0600496B RID: 18795 RVA: 0x0006CF3C File Offset: 0x0006B13C
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x170011FA RID: 4602
		// (get) Token: 0x0600496C RID: 18796 RVA: 0x0006CF4D File Offset: 0x0006B14D
		// (set) Token: 0x0600496D RID: 18797 RVA: 0x0006CF5D File Offset: 0x0006B15D
		public unsafe float Min
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Min);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Min) = value;
			}
		}

		// Token: 0x170011FB RID: 4603
		// (get) Token: 0x0600496E RID: 18798 RVA: 0x0006CF6E File Offset: 0x0006B16E
		// (set) Token: 0x0600496F RID: 18799 RVA: 0x0006CF7E File Offset: 0x0006B17E
		public unsafe float Max
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Max);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Max) = value;
			}
		}

		// Token: 0x170011FC RID: 4604
		// (get) Token: 0x06004970 RID: 18800 RVA: 0x0006CF8F File Offset: 0x0006B18F
		// (set) Token: 0x06004971 RID: 18801 RVA: 0x0006CF9F File Offset: 0x0006B19F
		public unsafe float Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_Clamp_Float.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06004972 RID: 18802 RVA: 0x0006CFB0 File Offset: 0x0006B1B0
		public FRigUnit_Clamp_Float()
		{
		}

		// Token: 0x06004973 RID: 18803 RVA: 0x0006CFB8 File Offset: 0x0006B1B8
		public FRigUnit_Clamp_Float(float Value, float Min, float Max, float Result)
		{
			this.Value = Value;
			this.Min = Min;
			this.Max = Max;
			this.Result = Result;
		}

		// Token: 0x06004974 RID: 18804 RVA: 0x0006CFDD File Offset: 0x0006B1DD
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_Clamp_Float.StaticStruct();
		}

		// Token: 0x06004975 RID: 18805 RVA: 0x0006CFE9 File Offset: 0x0006B1E9
		[NullableContext(2)]
		public FRigUnit_Clamp_Float(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004976 RID: 18806 RVA: 0x0006CFF3 File Offset: 0x0006B1F3
		public FRigUnit_Clamp_Float(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004977 RID: 18807 RVA: 0x0006CFFE File Offset: 0x0006B1FE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_Clamp_Float(Pointer, false, true);
		}

		// Token: 0x06004978 RID: 18808 RVA: 0x0006D008 File Offset: 0x0006B208
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_Clamp_Float(Pointer, MemoryOwner);
		}

		// Token: 0x040023A6 RID: 9126
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_Clamp_Float";

		// Token: 0x040023A7 RID: 9127
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040023A8 RID: 9128
		internal static int __PropertyOffset_Value;

		// Token: 0x040023A9 RID: 9129
		internal static int __PropertyOffset_Min;

		// Token: 0x040023AA RID: 9130
		internal static int __PropertyOffset_Max;

		// Token: 0x040023AB RID: 9131
		internal static int __PropertyOffset_Result;
	}
}
