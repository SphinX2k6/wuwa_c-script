using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005FD RID: 1533
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathFloatGreater")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FRigUnit_MathFloatGreater : FRigUnit_MathFloatBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600524C RID: 21068 RVA: 0x00078AC9 File Offset: 0x00076CC9
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathFloatGreater._ScriptStructPtr != 0) ? FRigUnit_MathFloatGreater._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathFloatGreater", ref FRigUnit_MathFloatGreater._ScriptStructPtr);
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x0600524D RID: 21069 RVA: 0x00078AED File Offset: 0x00076CED
		// (set) Token: 0x0600524E RID: 21070 RVA: 0x00078AFD File Offset: 0x00076CFD
		public unsafe float A
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_A);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_A) = value;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600524F RID: 21071 RVA: 0x00078B0E File Offset: 0x00076D0E
		// (set) Token: 0x06005250 RID: 21072 RVA: 0x00078B1E File Offset: 0x00076D1E
		public unsafe float B
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_B);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_B) = value;
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06005251 RID: 21073 RVA: 0x00078B2F File Offset: 0x00076D2F
		// (set) Token: 0x06005252 RID: 21074 RVA: 0x00078B3F File Offset: 0x00076D3F
		public unsafe bool Result
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_Result) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathFloatGreater.__PropertyOffset_Result) = (value ? 1 : 0);
			}
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00078B50 File Offset: 0x00076D50
		public FRigUnit_MathFloatGreater()
		{
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00078B58 File Offset: 0x00076D58
		public FRigUnit_MathFloatGreater(float A, float B, bool Result)
		{
			this.A = A;
			this.B = B;
			this.Result = Result;
		}

		// Token: 0x06005255 RID: 21077 RVA: 0x00078B75 File Offset: 0x00076D75
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathFloatGreater.StaticStruct();
		}

		// Token: 0x06005256 RID: 21078 RVA: 0x00078B81 File Offset: 0x00076D81
		[NullableContext(2)]
		public FRigUnit_MathFloatGreater(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005257 RID: 21079 RVA: 0x00078B8B File Offset: 0x00076D8B
		public FRigUnit_MathFloatGreater(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005258 RID: 21080 RVA: 0x00078B96 File Offset: 0x00076D96
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathFloatGreater(Pointer, false, true);
		}

		// Token: 0x06005259 RID: 21081 RVA: 0x00078BA0 File Offset: 0x00076DA0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathFloatGreater(Pointer, MemoryOwner);
		}

		// Token: 0x0400276D RID: 10093
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathFloatGreater";

		// Token: 0x0400276E RID: 10094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400276F RID: 10095
		internal static int __PropertyOffset_A;

		// Token: 0x04002770 RID: 10096
		internal static int __PropertyOffset_B;

		// Token: 0x04002771 RID: 10097
		internal static int __PropertyOffset_Result;
	}
}
