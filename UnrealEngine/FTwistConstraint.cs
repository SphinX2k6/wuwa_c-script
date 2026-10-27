using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001211 RID: 4625
	[UnrealObjectPath("/Script/Engine.TwistConstraint")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FTwistConstraint : FConstraintBaseParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601107A RID: 69754 RVA: 0x0018FBF2 File Offset: 0x0018DDF2
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTwistConstraint._ScriptStructPtr != 0) ? FTwistConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TwistConstraint", ref FTwistConstraint._ScriptStructPtr);
		}

		// Token: 0x1700427E RID: 17022
		// (get) Token: 0x0601107B RID: 69755 RVA: 0x0018FC16 File Offset: 0x0018DE16
		// (set) Token: 0x0601107C RID: 69756 RVA: 0x0018FC26 File Offset: 0x0018DE26
		public unsafe float TwistLimitDegrees
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTwistConstraint.__PropertyOffset_TwistLimitDegrees);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTwistConstraint.__PropertyOffset_TwistLimitDegrees) = value;
			}
		}

		// Token: 0x1700427F RID: 17023
		// (get) Token: 0x0601107D RID: 69757 RVA: 0x0018FC37 File Offset: 0x0018DE37
		// (set) Token: 0x0601107E RID: 69758 RVA: 0x0018FC4B File Offset: 0x0018DE4B
		public unsafe TEnumAsByte<EAngularConstraintMotion> TwistMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTwistConstraint.__PropertyOffset_TwistMotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTwistConstraint.__PropertyOffset_TwistMotion) = value;
			}
		}

		// Token: 0x0601107F RID: 69759 RVA: 0x0018FC60 File Offset: 0x0018DE60
		public FTwistConstraint()
		{
		}

		// Token: 0x06011080 RID: 69760 RVA: 0x0018FC68 File Offset: 0x0018DE68
		public FTwistConstraint(float TwistLimitDegrees, TEnumAsByte<EAngularConstraintMotion> TwistMotion, float Stiffness, float Damping, float Restitution, float ContactDistance, bool bSoftConstraint)
		{
			this.TwistLimitDegrees = TwistLimitDegrees;
			this.TwistMotion = TwistMotion;
			base.Stiffness = Stiffness;
			base.Damping = Damping;
			base.Restitution = Restitution;
			base.ContactDistance = ContactDistance;
			base.bSoftConstraint = bSoftConstraint;
		}

		// Token: 0x06011081 RID: 69761 RVA: 0x0018FCA5 File Offset: 0x0018DEA5
		protected override IntPtr GetUStructPtr()
		{
			return FTwistConstraint.StaticStruct();
		}

		// Token: 0x06011082 RID: 69762 RVA: 0x0018FCB1 File Offset: 0x0018DEB1
		[NullableContext(2)]
		public FTwistConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011083 RID: 69763 RVA: 0x0018FCBB File Offset: 0x0018DEBB
		public FTwistConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011084 RID: 69764 RVA: 0x0018FCC6 File Offset: 0x0018DEC6
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTwistConstraint(Pointer, false, true);
		}

		// Token: 0x06011085 RID: 69765 RVA: 0x0018FCD0 File Offset: 0x0018DED0
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTwistConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040091D8 RID: 37336
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.TwistConstraint";

		// Token: 0x040091D9 RID: 37337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091DA RID: 37338
		internal static int __PropertyOffset_TwistLimitDegrees;

		// Token: 0x040091DB RID: 37339
		internal static int __PropertyOffset_TwistMotion;
	}
}
