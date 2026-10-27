using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020006E8 RID: 1768
	[UnrealObjectPath("/Script/ControlRig.RigUnit_ToSwingAndTwist")]
	[UnrealStructLayout(80, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FRigUnit_ToSwingAndTwist : FRigUnit, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06005EF0 RID: 24304 RVA: 0x00088200 File Offset: 0x00086400
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_ToSwingAndTwist._ScriptStructPtr != 0) ? FRigUnit_ToSwingAndTwist._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_ToSwingAndTwist", ref FRigUnit_ToSwingAndTwist._ScriptStructPtr);
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06005EF1 RID: 24305 RVA: 0x00088224 File Offset: 0x00086424
		// (set) Token: 0x06005EF2 RID: 24306 RVA: 0x00088238 File Offset: 0x00086438
		public unsafe FQuat Input
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Input);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Input) = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06005EF3 RID: 24307 RVA: 0x0008824D File Offset: 0x0008644D
		// (set) Token: 0x06005EF4 RID: 24308 RVA: 0x00088261 File Offset: 0x00086461
		public unsafe FVector TwistAxis
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_TwistAxis);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_TwistAxis) = value;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06005EF5 RID: 24309 RVA: 0x00088276 File Offset: 0x00086476
		// (set) Token: 0x06005EF6 RID: 24310 RVA: 0x0008828A File Offset: 0x0008648A
		public unsafe FQuat Swing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Swing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Swing) = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06005EF7 RID: 24311 RVA: 0x0008829F File Offset: 0x0008649F
		// (set) Token: 0x06005EF8 RID: 24312 RVA: 0x000882B3 File Offset: 0x000864B3
		public unsafe FQuat Twist
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Twist);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_ToSwingAndTwist.__PropertyOffset_Twist) = value;
			}
		}

		// Token: 0x06005EF9 RID: 24313 RVA: 0x000882C8 File Offset: 0x000864C8
		public FRigUnit_ToSwingAndTwist()
		{
		}

		// Token: 0x06005EFA RID: 24314 RVA: 0x000882D0 File Offset: 0x000864D0
		public FRigUnit_ToSwingAndTwist(FQuat Input, FVector TwistAxis, FQuat Swing, FQuat Twist)
		{
			this.Input = Input;
			this.TwistAxis = TwistAxis;
			this.Swing = Swing;
			this.Twist = Twist;
		}

		// Token: 0x06005EFB RID: 24315 RVA: 0x000882F5 File Offset: 0x000864F5
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_ToSwingAndTwist.StaticStruct();
		}

		// Token: 0x06005EFC RID: 24316 RVA: 0x00088301 File Offset: 0x00086501
		[NullableContext(2)]
		public FRigUnit_ToSwingAndTwist(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06005EFD RID: 24317 RVA: 0x0008830B File Offset: 0x0008650B
		public FRigUnit_ToSwingAndTwist(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06005EFE RID: 24318 RVA: 0x00088316 File Offset: 0x00086516
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_ToSwingAndTwist(Pointer, false, true);
		}

		// Token: 0x06005EFF RID: 24319 RVA: 0x00088320 File Offset: 0x00086520
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_ToSwingAndTwist(Pointer, MemoryOwner);
		}

		// Token: 0x04002C63 RID: 11363
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_ToSwingAndTwist";

		// Token: 0x04002C64 RID: 11364
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002C65 RID: 11365
		internal static int __PropertyOffset_Input;

		// Token: 0x04002C66 RID: 11366
		internal static int __PropertyOffset_TwistAxis;

		// Token: 0x04002C67 RID: 11367
		internal static int __PropertyOffset_Swing;

		// Token: 0x04002C68 RID: 11368
		internal static int __PropertyOffset_Twist;
	}
}
