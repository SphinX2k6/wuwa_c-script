using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200063F RID: 1599
	[UnrealObjectPath("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_MathQuaternionSwingTwist : FRigUnit_MathQuaternionBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005556 RID: 21846 RVA: 0x0007BC31 File Offset: 0x00079E31
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_MathQuaternionSwingTwist._ScriptStructPtr != 0) ? FRigUnit_MathQuaternionSwingTwist._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_MathQuaternionSwingTwist", ref FRigUnit_MathQuaternionSwingTwist._ScriptStructPtr);
		}

		// Token: 0x17001489 RID: 5257
		// (get) Token: 0x06005557 RID: 21847 RVA: 0x0007BC55 File Offset: 0x00079E55
		// (set) Token: 0x06005558 RID: 21848 RVA: 0x0007BC69 File Offset: 0x00079E69
		public unsafe FQuat Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x1700148A RID: 5258
		// (get) Token: 0x06005559 RID: 21849 RVA: 0x0007BC7E File Offset: 0x00079E7E
		// (set) Token: 0x0600555A RID: 21850 RVA: 0x0007BC92 File Offset: 0x00079E92
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x1700148B RID: 5259
		// (get) Token: 0x0600555B RID: 21851 RVA: 0x0007BCA7 File Offset: 0x00079EA7
		// (set) Token: 0x0600555C RID: 21852 RVA: 0x0007BCBB File Offset: 0x00079EBB
		public unsafe FQuat Swing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Swing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Swing) = value;
			}
		}

		// Token: 0x1700148C RID: 5260
		// (get) Token: 0x0600555D RID: 21853 RVA: 0x0007BCD0 File Offset: 0x00079ED0
		// (set) Token: 0x0600555E RID: 21854 RVA: 0x0007BCE4 File Offset: 0x00079EE4
		public unsafe FQuat Twist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Twist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_MathQuaternionSwingTwist.__PropertyOffset_Twist) = value;
			}
		}

		// Token: 0x0600555F RID: 21855 RVA: 0x0007BCF9 File Offset: 0x00079EF9
		public FRigUnit_MathQuaternionSwingTwist()
		{
		}

		// Token: 0x06005560 RID: 21856 RVA: 0x0007BD01 File Offset: 0x00079F01
		public FRigUnit_MathQuaternionSwingTwist(FQuat Input, FVector TwistAxis, FQuat Swing, FQuat Twist)
		{
			this.Input = Input;
			this.TwistAxis = TwistAxis;
			this.Swing = Swing;
			this.Twist = Twist;
		}

		// Token: 0x06005561 RID: 21857 RVA: 0x0007BD26 File Offset: 0x00079F26
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_MathQuaternionSwingTwist.StaticStruct();
		}

		// Token: 0x06005562 RID: 21858 RVA: 0x0007BD32 File Offset: 0x00079F32
		[NullableContext(2)]
		public FRigUnit_MathQuaternionSwingTwist(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005563 RID: 21859 RVA: 0x0007BD3C File Offset: 0x00079F3C
		public FRigUnit_MathQuaternionSwingTwist(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005564 RID: 21860 RVA: 0x0007BD47 File Offset: 0x00079F47
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_MathQuaternionSwingTwist(Pointer, false, true);
		}

		// Token: 0x06005565 RID: 21861 RVA: 0x0007BD51 File Offset: 0x00079F51
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_MathQuaternionSwingTwist(Pointer, MemoryOwner);
		}

		// Token: 0x0400286F RID: 10351
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_MathQuaternionSwingTwist";

		// Token: 0x04002870 RID: 10352
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002871 RID: 10353
		internal static int __PropertyOffset_Input;

		// Token: 0x04002872 RID: 10354
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x04002873 RID: 10355
		internal static int __PropertyOffset_Swing;

		// Token: 0x04002874 RID: 10356
		internal static int __PropertyOffset_Twist;
	}
}
