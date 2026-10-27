using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200065C RID: 1628
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathTransformMakeRelative")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FRigUnit_MathTransformMakeRelative : FRigUnit_MathTransformBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060056D0 RID: 22224 RVA: 0x0007DA9C File Offset: 0x0007BC9C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathTransformMakeRelative._ScriptStructPtr != 0) ? FRigUnit_MathTransformMakeRelative._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathTransformMakeRelative", ref FRigUnit_MathTransformMakeRelative._ScriptStructPtr);
		}

		// Token: 0x170014D4 RID: 5332
		// (get) Token: 0x060056D1 RID: 22225 RVA: 0x0007DAC0 File Offset: 0x0007BCC0
		// (set) Token: 0x060056D2 RID: 22226 RVA: 0x0007DAD4 File Offset: 0x0007BCD4
		public unsafe FTransform Global
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Global);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Global) = value;
			}
		}

		// Token: 0x170014D5 RID: 5333
		// (get) Token: 0x060056D3 RID: 22227 RVA: 0x0007DAE9 File Offset: 0x0007BCE9
		// (set) Token: 0x060056D4 RID: 22228 RVA: 0x0007DAFD File Offset: 0x0007BCFD
		public unsafe FTransform Parent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Parent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Parent) = value;
			}
		}

		// Token: 0x170014D6 RID: 5334
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x0007DB12 File Offset: 0x0007BD12
		// (set) Token: 0x060056D6 RID: 22230 RVA: 0x0007DB26 File Offset: 0x0007BD26
		public unsafe FTransform Local
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Local);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathTransformMakeRelative.__PropertyOffset_Local) = value;
			}
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x0007DB3B File Offset: 0x0007BD3B
		public FRigUnit_MathTransformMakeRelative()
		{
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x0007DB43 File Offset: 0x0007BD43
		public FRigUnit_MathTransformMakeRelative(FTransform Global, FTransform Parent, FTransform Local)
		{
			this.Global = Global;
			this.Parent = Parent;
			this.Local = Local;
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x0007DB60 File Offset: 0x0007BD60
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathTransformMakeRelative.StaticStruct();
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x0007DB6C File Offset: 0x0007BD6C
		[NullableContext(2)]
		public FRigUnit_MathTransformMakeRelative(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060056DB RID: 22235 RVA: 0x0007DB76 File Offset: 0x0007BD76
		public FRigUnit_MathTransformMakeRelative(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060056DC RID: 22236 RVA: 0x0007DB81 File Offset: 0x0007BD81
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathTransformMakeRelative(Pointer, false, true);
		}

		// Token: 0x060056DD RID: 22237 RVA: 0x0007DB8B File Offset: 0x0007BD8B
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathTransformMakeRelative(Pointer, MemoryOwner);
		}

		// Token: 0x04002902 RID: 10498
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathTransformMakeRelative";

		// Token: 0x04002903 RID: 10499
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002904 RID: 10500
		internal static int __PropertyOffset_Global;

		// Token: 0x04002905 RID: 10501
		internal static int __PropertyOffset_Parent;

		// Token: 0x04002906 RID: 10502
		internal static int __PropertyOffset_Local;
	}
}
