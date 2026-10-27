using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200067A RID: 1658
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FRigUnit_MathVectorMakeBezierFourPoint : FRigUnit_MathVectorBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600584D RID: 22605 RVA: 0x0007F494 File Offset: 0x0007D694
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathVectorMakeBezierFourPoint._ScriptStructPtr != 0) ? FRigUnit_MathVectorMakeBezierFourPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint", ref FRigUnit_MathVectorMakeBezierFourPoint._ScriptStructPtr);
		}

		// Token: 0x1700151B RID: 5403
		// (get) Token: 0x0600584E RID: 22606 RVA: 0x0007F4B8 File Offset: 0x0007D6B8
		// (set) Token: 0x0600584F RID: 22607 RVA: 0x0007F4FB File Offset: 0x0007D6FB
		public FCRFourPointBezier Bezier
		{
			get
			{
				base.FastCheckIsValid();
				FCRFourPointBezier result;
				if ((result = this._Bezier) == null)
				{
					result = (this._Bezier = new FCRFourPointBezier(base.NativePtr + (IntPtr)FRigUnit_MathVectorMakeBezierFourPoint.__PropertyOffset_Bezier, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FCRFourPointBezier.StaticStruct(), base.NativePtr + (IntPtr)FRigUnit_MathVectorMakeBezierFourPoint.__PropertyOffset_Bezier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06005850 RID: 22608 RVA: 0x0007F51C File Offset: 0x0007D71C
		public FRigUnit_MathVectorMakeBezierFourPoint()
		{
		}

		// Token: 0x06005851 RID: 22609 RVA: 0x0007F524 File Offset: 0x0007D724
		public FRigUnit_MathVectorMakeBezierFourPoint(FCRFourPointBezier Bezier)
		{
			this.Bezier = Bezier;
		}

		// Token: 0x06005852 RID: 22610 RVA: 0x0007F533 File Offset: 0x0007D733
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathVectorMakeBezierFourPoint.StaticStruct();
		}

		// Token: 0x06005853 RID: 22611 RVA: 0x0007F53F File Offset: 0x0007D73F
		[NullableContext(2)]
		public FRigUnit_MathVectorMakeBezierFourPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x0007F549 File Offset: 0x0007D749
		public FRigUnit_MathVectorMakeBezierFourPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x0007F554 File Offset: 0x0007D754
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathVectorMakeBezierFourPoint(Pointer, false, true);
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x0007F55E File Offset: 0x0007D75E
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathVectorMakeBezierFourPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04002987 RID: 10631
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathVectorMakeBezierFourPoint";

		// Token: 0x04002988 RID: 10632
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002989 RID: 10633
		internal static int __PropertyOffset_Bezier;

		// Token: 0x0400298A RID: 10634
		[Nullable(2)]
		private FCRFourPointBezier _Bezier;
	}
}
