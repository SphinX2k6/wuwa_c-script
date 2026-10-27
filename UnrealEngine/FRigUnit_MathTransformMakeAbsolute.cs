using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065B RID: 1627
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathTransformMakeAbsolute : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056C2 RID: 22210 RVA: 0x0007D9A4 File Offset: 0x0007BBA4
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformMakeAbsolute._ScriptStructPtr != 0) ? FRigUnit_MathTransformMakeAbsolute._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformMakeAbsolute", ref FRigUnit_MathTransformMakeAbsolute._ScriptStructPtr);
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x060056C3 RID: 22211 RVA: 0x0007D9C8 File Offset: 0x0007BBC8
		// (set) Token: 0x060056C4 RID: 22212 RVA: 0x0007D9DC File Offset: 0x0007BBDC
		public unsafe FTransform Local
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Local);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Local) = value;
			}
		}

		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x060056C5 RID: 22213 RVA: 0x0007D9F1 File Offset: 0x0007BBF1
		// (set) Token: 0x060056C6 RID: 22214 RVA: 0x0007DA05 File Offset: 0x0007BC05
		public unsafe FTransform Parent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Parent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Parent) = value;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x060056C7 RID: 22215 RVA: 0x0007DA1A File Offset: 0x0007BC1A
		// (set) Token: 0x060056C8 RID: 22216 RVA: 0x0007DA2E File Offset: 0x0007BC2E
		public unsafe FTransform Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Global);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeAbsolute.__PropertyOffset_Global) = value;
			}
		}

		// Token: 0x060056C9 RID: 22217 RVA: 0x0007DA43 File Offset: 0x0007BC43
		public FRigUnit_MathTransformMakeAbsolute()
		{
		}

		// Token: 0x060056CA RID: 22218 RVA: 0x0007DA4B File Offset: 0x0007BC4B
		public FRigUnit_MathTransformMakeAbsolute(FTransform Local, FTransform Parent, FTransform Global)
		{
			this.Local = Local;
			this.Parent = Parent;
			this.Global = Global;
		}

		// Token: 0x060056CB RID: 22219 RVA: 0x0007DA68 File Offset: 0x0007BC68
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformMakeAbsolute.StaticStruct();
		}

		// Token: 0x060056CC RID: 22220 RVA: 0x0007DA74 File Offset: 0x0007BC74
		[NullableContext(2)]
		public FRigUnit_MathTransformMakeAbsolute(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056CD RID: 22221 RVA: 0x0007DA7E File Offset: 0x0007BC7E
		public FRigUnit_MathTransformMakeAbsolute(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056CE RID: 22222 RVA: 0x0007DA89 File Offset: 0x0007BC89
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformMakeAbsolute(Pointer, false, true);
		}

		// Token: 0x060056CF RID: 22223 RVA: 0x0007DA93 File Offset: 0x0007BC93
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformMakeAbsolute(Pointer, MemoryOwner);
		}

		// Token: 0x040028FD RID: 10493
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformMakeAbsolute";

		// Token: 0x040028FE RID: 10494
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040028FF RID: 10495
		internal static int __PropertyOffset_Local;

		// Token: 0x04002900 RID: 10496
		internal static int __PropertyOffset_Parent;

		// Token: 0x04002901 RID: 10497
		internal static int __PropertyOffset_Global;
	}
}
