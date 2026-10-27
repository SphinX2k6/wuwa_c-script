using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000601 RID: 1537
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatLawOfCosine")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_MathFloatLawOfCosine : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005286 RID: 21126 RVA: 0x00078E72 File Offset: 0x00077072
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatLawOfCosine._ScriptStructPtr != 0) ? FRigUnit_MathFloatLawOfCosine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatLawOfCosine", ref FRigUnit_MathFloatLawOfCosine._ScriptStructPtr);
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x06005287 RID: 21127 RVA: 0x00078E96 File Offset: 0x00077096
		// (set) Token: 0x06005288 RID: 21128 RVA: 0x00078EA6 File Offset: 0x000770A6
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06005289 RID: 21129 RVA: 0x00078EB7 File Offset: 0x000770B7
		// (set) Token: 0x0600528A RID: 21130 RVA: 0x00078EC7 File Offset: 0x000770C7
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600528B RID: 21131 RVA: 0x00078ED8 File Offset: 0x000770D8
		// (set) Token: 0x0600528C RID: 21132 RVA: 0x00078EE8 File Offset: 0x000770E8
		public unsafe float C
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_C);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_C) = value;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x0600528D RID: 21133 RVA: 0x00078EF9 File Offset: 0x000770F9
		// (set) Token: 0x0600528E RID: 21134 RVA: 0x00078F09 File Offset: 0x00077109
		public unsafe float AlphaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_AlphaAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_AlphaAngle) = value;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600528F RID: 21135 RVA: 0x00078F1A File Offset: 0x0007711A
		// (set) Token: 0x06005290 RID: 21136 RVA: 0x00078F2A File Offset: 0x0007712A
		public unsafe float BetaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_BetaAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_BetaAngle) = value;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06005291 RID: 21137 RVA: 0x00078F3B File Offset: 0x0007713B
		// (set) Token: 0x06005292 RID: 21138 RVA: 0x00078F4B File Offset: 0x0007714B
		public unsafe float GammaAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_GammaAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_GammaAngle) = value;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06005293 RID: 21139 RVA: 0x00078F5C File Offset: 0x0007715C
		// (set) Token: 0x06005294 RID: 21140 RVA: 0x00078F6C File Offset: 0x0007716C
		public unsafe bool bValid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_bValid) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatLawOfCosine.__PropertyOffset_bValid) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005295 RID: 21141 RVA: 0x00078F7D File Offset: 0x0007717D
		public FRigUnit_MathFloatLawOfCosine()
		{
		}

		// Token: 0x06005296 RID: 21142 RVA: 0x00078F85 File Offset: 0x00077185
		public FRigUnit_MathFloatLawOfCosine(float A, float B, float C, float AlphaAngle, float BetaAngle, float GammaAngle, bool bValid)
		{
			this.A = A;
			this.B = B;
			this.C = C;
			this.AlphaAngle = AlphaAngle;
			this.BetaAngle = BetaAngle;
			this.GammaAngle = GammaAngle;
			this.bValid = bValid;
		}

		// Token: 0x06005297 RID: 21143 RVA: 0x00078FC2 File Offset: 0x000771C2
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatLawOfCosine.StaticStruct();
		}

		// Token: 0x06005298 RID: 21144 RVA: 0x00078FCE File Offset: 0x000771CE
		[NullableContext(2)]
		public FRigUnit_MathFloatLawOfCosine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005299 RID: 21145 RVA: 0x00078FD8 File Offset: 0x000771D8
		public FRigUnit_MathFloatLawOfCosine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600529A RID: 21146 RVA: 0x00078FE3 File Offset: 0x000771E3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatLawOfCosine(Pointer, false, true);
		}

		// Token: 0x0600529B RID: 21147 RVA: 0x00078FED File Offset: 0x000771ED
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatLawOfCosine(Pointer, MemoryOwner);
		}

		// Token: 0x04002782 RID: 10114
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatLawOfCosine";

		// Token: 0x04002783 RID: 10115
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002784 RID: 10116
		internal static int __PropertyOffset_A;

		// Token: 0x04002785 RID: 10117
		internal static int __PropertyOffset_B;

		// Token: 0x04002786 RID: 10118
		internal static int __PropertyOffset_C;

		// Token: 0x04002787 RID: 10119
		internal static int __PropertyOffset_AlphaAngle;

		// Token: 0x04002788 RID: 10120
		internal static int __PropertyOffset_BetaAngle;

		// Token: 0x04002789 RID: 10121
		internal static int __PropertyOffset_GammaAngle;

		// Token: 0x0400278A RID: 10122
		internal static int __PropertyOffset_bValid;
	}
}
