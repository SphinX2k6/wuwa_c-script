using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000D5B RID: 3419
	[UnrealObjectPath("/Script/Engine.LinearConstraint")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FLinearConstraint : FConstraintBaseParams, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B8A6 RID: 47270 RVA: 0x00106D08 File Offset: 0x00104F08
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLinearConstraint._ScriptStructPtr != 0) ? FLinearConstraint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LinearConstraint", ref FLinearConstraint._ScriptStructPtr);
		}

		// Token: 0x17002A4B RID: 10827
		// (get) Token: 0x0600B8A7 RID: 47271 RVA: 0x00106D2C File Offset: 0x00104F2C
		// (set) Token: 0x0600B8A8 RID: 47272 RVA: 0x00106D3C File Offset: 0x00104F3C
		public unsafe float Limit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_Limit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_Limit) = value;
			}
		}

		// Token: 0x17002A4C RID: 10828
		// (get) Token: 0x0600B8A9 RID: 47273 RVA: 0x00106D4D File Offset: 0x00104F4D
		// (set) Token: 0x0600B8AA RID: 47274 RVA: 0x00106D61 File Offset: 0x00104F61
		public unsafe TEnumAsByte<ELinearConstraintMotion> XMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_XMotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_XMotion) = value;
			}
		}

		// Token: 0x17002A4D RID: 10829
		// (get) Token: 0x0600B8AB RID: 47275 RVA: 0x00106D76 File Offset: 0x00104F76
		// (set) Token: 0x0600B8AC RID: 47276 RVA: 0x00106D8A File Offset: 0x00104F8A
		public unsafe TEnumAsByte<ELinearConstraintMotion> YMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_YMotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_YMotion) = value;
			}
		}

		// Token: 0x17002A4E RID: 10830
		// (get) Token: 0x0600B8AD RID: 47277 RVA: 0x00106D9F File Offset: 0x00104F9F
		// (set) Token: 0x0600B8AE RID: 47278 RVA: 0x00106DB3 File Offset: 0x00104FB3
		public unsafe TEnumAsByte<ELinearConstraintMotion> ZMotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_ZMotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLinearConstraint.__PropertyOffset_ZMotion) = value;
			}
		}

		// Token: 0x0600B8AF RID: 47279 RVA: 0x00106DC8 File Offset: 0x00104FC8
		public FLinearConstraint()
		{
		}

		// Token: 0x0600B8B0 RID: 47280 RVA: 0x00106DD0 File Offset: 0x00104FD0
		public FLinearConstraint(float Limit, TEnumAsByte<ELinearConstraintMotion> XMotion, TEnumAsByte<ELinearConstraintMotion> YMotion, TEnumAsByte<ELinearConstraintMotion> ZMotion, float Stiffness, float Damping, float Restitution, float ContactDistance, bool bSoftConstraint)
		{
			this.Limit = Limit;
			this.XMotion = XMotion;
			this.YMotion = YMotion;
			this.ZMotion = ZMotion;
			base.Stiffness = Stiffness;
			base.Damping = Damping;
			base.Restitution = Restitution;
			base.ContactDistance = ContactDistance;
			base.bSoftConstraint = bSoftConstraint;
		}

		// Token: 0x0600B8B1 RID: 47281 RVA: 0x00106E28 File Offset: 0x00105028
		protected override IntPtr GetUStructPtr()
		{
			return FLinearConstraint.StaticStruct();
		}

		// Token: 0x0600B8B2 RID: 47282 RVA: 0x00106E34 File Offset: 0x00105034
		[NullableContext(2)]
		public FLinearConstraint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B8B3 RID: 47283 RVA: 0x00106E3E File Offset: 0x0010503E
		public FLinearConstraint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B8B4 RID: 47284 RVA: 0x00106E49 File Offset: 0x00105049
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLinearConstraint(Pointer, false, true);
		}

		// Token: 0x0600B8B5 RID: 47285 RVA: 0x00106E53 File Offset: 0x00105053
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLinearConstraint(Pointer, MemoryOwner);
		}

		// Token: 0x040060C6 RID: 24774
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LinearConstraint";

		// Token: 0x040060C7 RID: 24775
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040060C8 RID: 24776
		internal static int __PropertyOffset_Limit;

		// Token: 0x040060C9 RID: 24777
		internal static int __PropertyOffset_XMotion;

		// Token: 0x040060CA RID: 24778
		internal static int __PropertyOffset_YMotion;

		// Token: 0x040060CB RID: 24779
		internal static int __PropertyOffset_ZMotion;
	}
}
