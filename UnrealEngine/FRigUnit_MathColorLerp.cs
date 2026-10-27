using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005E8 RID: 1512
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathColorLerp")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FRigUnit_MathColorLerp : FRigUnit_MathColorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600517B RID: 20859 RVA: 0x00077E2A File Offset: 0x0007602A
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathColorLerp._ScriptStructPtr != 0) ? FRigUnit_MathColorLerp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathColorLerp", ref FRigUnit_MathColorLerp._ScriptStructPtr);
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x0600517C RID: 20860 RVA: 0x00077E4E File Offset: 0x0007604E
		// (set) Token: 0x0600517D RID: 20861 RVA: 0x00077E62 File Offset: 0x00076062
		public unsafe FLinearColor A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x0600517E RID: 20862 RVA: 0x00077E77 File Offset: 0x00076077
		// (set) Token: 0x0600517F RID: 20863 RVA: 0x00077E8B File Offset: 0x0007608B
		public unsafe FLinearColor B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x06005180 RID: 20864 RVA: 0x00077EA0 File Offset: 0x000760A0
		// (set) Token: 0x06005181 RID: 20865 RVA: 0x00077EB0 File Offset: 0x000760B0
		public unsafe float T
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_T);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_T) = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x06005182 RID: 20866 RVA: 0x00077EC1 File Offset: 0x000760C1
		// (set) Token: 0x06005183 RID: 20867 RVA: 0x00077ED5 File Offset: 0x000760D5
		public unsafe FLinearColor Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_Result);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathColorLerp.__PropertyOffset_Result) = value;
			}
		}

		// Token: 0x06005184 RID: 20868 RVA: 0x00077EEA File Offset: 0x000760EA
		public FRigUnit_MathColorLerp()
		{
		}

		// Token: 0x06005185 RID: 20869 RVA: 0x00077EF2 File Offset: 0x000760F2
		public FRigUnit_MathColorLerp(FLinearColor A, FLinearColor B, float T, FLinearColor Result)
		{
			this.A = A;
			this.B = B;
			this.T = T;
			this.Result = Result;
		}

		// Token: 0x06005186 RID: 20870 RVA: 0x00077F17 File Offset: 0x00076117
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathColorLerp.StaticStruct();
		}

		// Token: 0x06005187 RID: 20871 RVA: 0x00077F23 File Offset: 0x00076123
		[NullableContext(2)]
		public FRigUnit_MathColorLerp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005188 RID: 20872 RVA: 0x00077F2D File Offset: 0x0007612D
		public FRigUnit_MathColorLerp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005189 RID: 20873 RVA: 0x00077F38 File Offset: 0x00076138
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathColorLerp(Pointer, false, true);
		}

		// Token: 0x0600518A RID: 20874 RVA: 0x00077F42 File Offset: 0x00076142
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathColorLerp(Pointer, MemoryOwner);
		}

		// Token: 0x0400272E RID: 10030
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathColorLerp";

		// Token: 0x0400272F RID: 10031
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002730 RID: 10032
		internal static int __PropertyOffset_A;

		// Token: 0x04002731 RID: 10033
		internal static int __PropertyOffset_B;

		// Token: 0x04002732 RID: 10034
		internal static int __PropertyOffset_T;

		// Token: 0x04002733 RID: 10035
		internal static int __PropertyOffset_Result;
	}
}
