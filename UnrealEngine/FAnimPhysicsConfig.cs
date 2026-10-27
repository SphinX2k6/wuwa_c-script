using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001625 RID: 5669
	[UnrealObjectPath("/Script/KuroAnim.AnimPhysicsConfig")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FAnimPhysicsConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601482C RID: 84012 RVA: 0x001E2CEC File Offset: 0x001E0EEC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimPhysicsConfig._ScriptStructPtr != 0) ? FAnimPhysicsConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.AnimPhysicsConfig", ref FAnimPhysicsConfig._ScriptStructPtr);
		}

		// Token: 0x170050C4 RID: 20676
		// (get) Token: 0x0601482D RID: 84013 RVA: 0x001E2D10 File Offset: 0x001E0F10
		// (set) Token: 0x0601482E RID: 84014 RVA: 0x001E2D24 File Offset: 0x001E0F24
		public unsafe FName BaseBoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_BaseBoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_BaseBoneName) = value;
			}
		}

		// Token: 0x170050C5 RID: 20677
		// (get) Token: 0x0601482F RID: 84015 RVA: 0x001E2D39 File Offset: 0x001E0F39
		// (set) Token: 0x06014830 RID: 84016 RVA: 0x001E2D49 File Offset: 0x001E0F49
		public unsafe float Stiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_Stiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_Stiffness) = value;
			}
		}

		// Token: 0x170050C6 RID: 20678
		// (get) Token: 0x06014831 RID: 84017 RVA: 0x001E2D5A File Offset: 0x001E0F5A
		// (set) Token: 0x06014832 RID: 84018 RVA: 0x001E2D6A File Offset: 0x001E0F6A
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x170050C7 RID: 20679
		// (get) Token: 0x06014833 RID: 84019 RVA: 0x001E2D7B File Offset: 0x001E0F7B
		// (set) Token: 0x06014834 RID: 84020 RVA: 0x001E2D8B File Offset: 0x001E0F8B
		public unsafe float MaxLinearForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_MaxLinearForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_MaxLinearForce) = value;
			}
		}

		// Token: 0x170050C8 RID: 20680
		// (get) Token: 0x06014835 RID: 84021 RVA: 0x001E2D9C File Offset: 0x001E0F9C
		// (set) Token: 0x06014836 RID: 84022 RVA: 0x001E2DAC File Offset: 0x001E0FAC
		public unsafe float AngularStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_AngularStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_AngularStiffness) = value;
			}
		}

		// Token: 0x170050C9 RID: 20681
		// (get) Token: 0x06014837 RID: 84023 RVA: 0x001E2DBD File Offset: 0x001E0FBD
		// (set) Token: 0x06014838 RID: 84024 RVA: 0x001E2DCD File Offset: 0x001E0FCD
		public unsafe float AngularDamping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_AngularDamping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_AngularDamping) = value;
			}
		}

		// Token: 0x170050CA RID: 20682
		// (get) Token: 0x06014839 RID: 84025 RVA: 0x001E2DDE File Offset: 0x001E0FDE
		// (set) Token: 0x0601483A RID: 84026 RVA: 0x001E2DEE File Offset: 0x001E0FEE
		public unsafe float MaxAngularForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_MaxAngularForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimPhysicsConfig.__PropertyOffset_MaxAngularForce) = value;
			}
		}

		// Token: 0x0601483B RID: 84027 RVA: 0x001E2DFF File Offset: 0x001E0FFF
		public FAnimPhysicsConfig()
		{
		}

		// Token: 0x0601483C RID: 84028 RVA: 0x001E2E07 File Offset: 0x001E1007
		public FAnimPhysicsConfig(FName BaseBoneName, float Stiffness, float Damping, float MaxLinearForce, float AngularStiffness, float AngularDamping, float MaxAngularForce)
		{
			this.BaseBoneName = BaseBoneName;
			this.Stiffness = Stiffness;
			this.Damping = Damping;
			this.MaxLinearForce = MaxLinearForce;
			this.AngularStiffness = AngularStiffness;
			this.AngularDamping = AngularDamping;
			this.MaxAngularForce = MaxAngularForce;
		}

		// Token: 0x0601483D RID: 84029 RVA: 0x001E2E44 File Offset: 0x001E1044
		protected override IntPtr GetUStructPtr()
		{
			return FAnimPhysicsConfig.StaticStruct();
		}

		// Token: 0x0601483E RID: 84030 RVA: 0x001E2E50 File Offset: 0x001E1050
		[NullableContext(2)]
		public FAnimPhysicsConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601483F RID: 84031 RVA: 0x001E2E5A File Offset: 0x001E105A
		public FAnimPhysicsConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014840 RID: 84032 RVA: 0x001E2E65 File Offset: 0x001E1065
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimPhysicsConfig(Pointer, false, true);
		}

		// Token: 0x06014841 RID: 84033 RVA: 0x001E2E6F File Offset: 0x001E106F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimPhysicsConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B27C RID: 45692
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroAnim.AnimPhysicsConfig";

		// Token: 0x0400B27D RID: 45693
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B27E RID: 45694
		internal static int __PropertyOffset_BaseBoneName;

		// Token: 0x0400B27F RID: 45695
		internal static int __PropertyOffset_Stiffness;

		// Token: 0x0400B280 RID: 45696
		internal static int __PropertyOffset_Damping;

		// Token: 0x0400B281 RID: 45697
		internal static int __PropertyOffset_MaxLinearForce;

		// Token: 0x0400B282 RID: 45698
		internal static int __PropertyOffset_AngularStiffness;

		// Token: 0x0400B283 RID: 45699
		internal static int __PropertyOffset_AngularDamping;

		// Token: 0x0400B284 RID: 45700
		internal static int __PropertyOffset_MaxAngularForce;
	}
}
