using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200093A RID: 2362
	[UnrealObjectPath("/Script/Engine.ClothPhysicsProperties_Legacy")]
	[UnrealStructLayout(80, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FClothPhysicsProperties_Legacy : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008572 RID: 34162 RVA: 0x000BE4F1 File Offset: 0x000BC6F1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FClothPhysicsProperties_Legacy._ScriptStructPtr != 0) ? FClothPhysicsProperties_Legacy._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ClothPhysicsProperties_Legacy", ref FClothPhysicsProperties_Legacy._ScriptStructPtr);
		}

		// Token: 0x17001F7B RID: 8059
		// (get) Token: 0x06008573 RID: 34163 RVA: 0x000BE515 File Offset: 0x000BC715
		// (set) Token: 0x06008574 RID: 34164 RVA: 0x000BE525 File Offset: 0x000BC725
		public unsafe float VerticalResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_VerticalResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_VerticalResistance) = value;
			}
		}

		// Token: 0x17001F7C RID: 8060
		// (get) Token: 0x06008575 RID: 34165 RVA: 0x000BE536 File Offset: 0x000BC736
		// (set) Token: 0x06008576 RID: 34166 RVA: 0x000BE546 File Offset: 0x000BC746
		public unsafe float HorizontalResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_HorizontalResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_HorizontalResistance) = value;
			}
		}

		// Token: 0x17001F7D RID: 8061
		// (get) Token: 0x06008577 RID: 34167 RVA: 0x000BE557 File Offset: 0x000BC757
		// (set) Token: 0x06008578 RID: 34168 RVA: 0x000BE567 File Offset: 0x000BC767
		public unsafe float BendResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_BendResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_BendResistance) = value;
			}
		}

		// Token: 0x17001F7E RID: 8062
		// (get) Token: 0x06008579 RID: 34169 RVA: 0x000BE578 File Offset: 0x000BC778
		// (set) Token: 0x0600857A RID: 34170 RVA: 0x000BE588 File Offset: 0x000BC788
		public unsafe float ShearResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_ShearResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_ShearResistance) = value;
			}
		}

		// Token: 0x17001F7F RID: 8063
		// (get) Token: 0x0600857B RID: 34171 RVA: 0x000BE599 File Offset: 0x000BC799
		// (set) Token: 0x0600857C RID: 34172 RVA: 0x000BE5A9 File Offset: 0x000BC7A9
		public unsafe float Friction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Friction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Friction) = value;
			}
		}

		// Token: 0x17001F80 RID: 8064
		// (get) Token: 0x0600857D RID: 34173 RVA: 0x000BE5BA File Offset: 0x000BC7BA
		// (set) Token: 0x0600857E RID: 34174 RVA: 0x000BE5CA File Offset: 0x000BC7CA
		public unsafe float Damping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Damping);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Damping) = value;
			}
		}

		// Token: 0x17001F81 RID: 8065
		// (get) Token: 0x0600857F RID: 34175 RVA: 0x000BE5DB File Offset: 0x000BC7DB
		// (set) Token: 0x06008580 RID: 34176 RVA: 0x000BE5EB File Offset: 0x000BC7EB
		public unsafe float TetherStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_TetherStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_TetherStiffness) = value;
			}
		}

		// Token: 0x17001F82 RID: 8066
		// (get) Token: 0x06008581 RID: 34177 RVA: 0x000BE5FC File Offset: 0x000BC7FC
		// (set) Token: 0x06008582 RID: 34178 RVA: 0x000BE60C File Offset: 0x000BC80C
		public unsafe float TetherLimit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_TetherLimit);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_TetherLimit) = value;
			}
		}

		// Token: 0x17001F83 RID: 8067
		// (get) Token: 0x06008583 RID: 34179 RVA: 0x000BE61D File Offset: 0x000BC81D
		// (set) Token: 0x06008584 RID: 34180 RVA: 0x000BE62D File Offset: 0x000BC82D
		public unsafe float Drag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Drag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_Drag) = value;
			}
		}

		// Token: 0x17001F84 RID: 8068
		// (get) Token: 0x06008585 RID: 34181 RVA: 0x000BE63E File Offset: 0x000BC83E
		// (set) Token: 0x06008586 RID: 34182 RVA: 0x000BE64E File Offset: 0x000BC84E
		public unsafe float StiffnessFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_StiffnessFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_StiffnessFrequency) = value;
			}
		}

		// Token: 0x17001F85 RID: 8069
		// (get) Token: 0x06008587 RID: 34183 RVA: 0x000BE65F File Offset: 0x000BC85F
		// (set) Token: 0x06008588 RID: 34184 RVA: 0x000BE66F File Offset: 0x000BC86F
		public unsafe float GravityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_GravityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_GravityScale) = value;
			}
		}

		// Token: 0x17001F86 RID: 8070
		// (get) Token: 0x06008589 RID: 34185 RVA: 0x000BE680 File Offset: 0x000BC880
		// (set) Token: 0x0600858A RID: 34186 RVA: 0x000BE690 File Offset: 0x000BC890
		public unsafe float MassScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_MassScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_MassScale) = value;
			}
		}

		// Token: 0x17001F87 RID: 8071
		// (get) Token: 0x0600858B RID: 34187 RVA: 0x000BE6A1 File Offset: 0x000BC8A1
		// (set) Token: 0x0600858C RID: 34188 RVA: 0x000BE6B1 File Offset: 0x000BC8B1
		public unsafe float InertiaBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_InertiaBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_InertiaBlend) = value;
			}
		}

		// Token: 0x17001F88 RID: 8072
		// (get) Token: 0x0600858D RID: 34189 RVA: 0x000BE6C2 File Offset: 0x000BC8C2
		// (set) Token: 0x0600858E RID: 34190 RVA: 0x000BE6D2 File Offset: 0x000BC8D2
		public unsafe float SelfCollisionThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionThickness) = value;
			}
		}

		// Token: 0x17001F89 RID: 8073
		// (get) Token: 0x0600858F RID: 34191 RVA: 0x000BE6E3 File Offset: 0x000BC8E3
		// (set) Token: 0x06008590 RID: 34192 RVA: 0x000BE6F3 File Offset: 0x000BC8F3
		public unsafe float SelfCollisionSquashScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionSquashScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionSquashScale) = value;
			}
		}

		// Token: 0x17001F8A RID: 8074
		// (get) Token: 0x06008591 RID: 34193 RVA: 0x000BE704 File Offset: 0x000BC904
		// (set) Token: 0x06008592 RID: 34194 RVA: 0x000BE714 File Offset: 0x000BC914
		public unsafe float SelfCollisionStiffness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionStiffness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SelfCollisionStiffness) = value;
			}
		}

		// Token: 0x17001F8B RID: 8075
		// (get) Token: 0x06008593 RID: 34195 RVA: 0x000BE725 File Offset: 0x000BC925
		// (set) Token: 0x06008594 RID: 34196 RVA: 0x000BE735 File Offset: 0x000BC935
		public unsafe float SolverFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SolverFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_SolverFrequency) = value;
			}
		}

		// Token: 0x17001F8C RID: 8076
		// (get) Token: 0x06008595 RID: 34197 RVA: 0x000BE746 File Offset: 0x000BC946
		// (set) Token: 0x06008596 RID: 34198 RVA: 0x000BE756 File Offset: 0x000BC956
		public unsafe float FiberCompression
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberCompression);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberCompression) = value;
			}
		}

		// Token: 0x17001F8D RID: 8077
		// (get) Token: 0x06008597 RID: 34199 RVA: 0x000BE767 File Offset: 0x000BC967
		// (set) Token: 0x06008598 RID: 34200 RVA: 0x000BE777 File Offset: 0x000BC977
		public unsafe float FiberExpansion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberExpansion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberExpansion) = value;
			}
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06008599 RID: 34201 RVA: 0x000BE788 File Offset: 0x000BC988
		// (set) Token: 0x0600859A RID: 34202 RVA: 0x000BE798 File Offset: 0x000BC998
		public unsafe float FiberResistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberResistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FClothPhysicsProperties_Legacy.__PropertyOffset_FiberResistance) = value;
			}
		}

		// Token: 0x0600859B RID: 34203 RVA: 0x000BE7A9 File Offset: 0x000BC9A9
		public FClothPhysicsProperties_Legacy()
		{
		}

		// Token: 0x0600859C RID: 34204 RVA: 0x000BE7B4 File Offset: 0x000BC9B4
		public FClothPhysicsProperties_Legacy(float VerticalResistance, float HorizontalResistance, float BendResistance, float ShearResistance, float Friction, float Damping, float TetherStiffness, float TetherLimit, float Drag, float StiffnessFrequency, float GravityScale, float MassScale, float InertiaBlend, float SelfCollisionThickness, float SelfCollisionSquashScale, float SelfCollisionStiffness, float SolverFrequency, float FiberCompression, float FiberExpansion, float FiberResistance)
		{
			this.VerticalResistance = VerticalResistance;
			this.HorizontalResistance = HorizontalResistance;
			this.BendResistance = BendResistance;
			this.ShearResistance = ShearResistance;
			this.Friction = Friction;
			this.Damping = Damping;
			this.TetherStiffness = TetherStiffness;
			this.TetherLimit = TetherLimit;
			this.Drag = Drag;
			this.StiffnessFrequency = StiffnessFrequency;
			this.GravityScale = GravityScale;
			this.MassScale = MassScale;
			this.InertiaBlend = InertiaBlend;
			this.SelfCollisionThickness = SelfCollisionThickness;
			this.SelfCollisionSquashScale = SelfCollisionSquashScale;
			this.SelfCollisionStiffness = SelfCollisionStiffness;
			this.SolverFrequency = SolverFrequency;
			this.FiberCompression = FiberCompression;
			this.FiberExpansion = FiberExpansion;
			this.FiberResistance = FiberResistance;
		}

		// Token: 0x0600859D RID: 34205 RVA: 0x000BE864 File Offset: 0x000BCA64
		protected override IntPtr GetUStructPtr()
		{
			return FClothPhysicsProperties_Legacy.StaticStruct();
		}

		// Token: 0x0600859E RID: 34206 RVA: 0x000BE870 File Offset: 0x000BCA70
		[NullableContext(2)]
		public FClothPhysicsProperties_Legacy(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600859F RID: 34207 RVA: 0x000BE87A File Offset: 0x000BCA7A
		public FClothPhysicsProperties_Legacy(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060085A0 RID: 34208 RVA: 0x000BE885 File Offset: 0x000BCA85
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FClothPhysicsProperties_Legacy(Pointer, false, true);
		}

		// Token: 0x060085A1 RID: 34209 RVA: 0x000BE88F File Offset: 0x000BCA8F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FClothPhysicsProperties_Legacy(Pointer, MemoryOwner);
		}

		// Token: 0x04003F80 RID: 16256
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ClothPhysicsProperties_Legacy";

		// Token: 0x04003F81 RID: 16257
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003F82 RID: 16258
		internal static int __PropertyOffset_VerticalResistance;

		// Token: 0x04003F83 RID: 16259
		internal static int __PropertyOffset_HorizontalResistance;

		// Token: 0x04003F84 RID: 16260
		internal static int __PropertyOffset_BendResistance;

		// Token: 0x04003F85 RID: 16261
		internal static int __PropertyOffset_ShearResistance;

		// Token: 0x04003F86 RID: 16262
		internal static int __PropertyOffset_Friction;

		// Token: 0x04003F87 RID: 16263
		internal static int __PropertyOffset_Damping;

		// Token: 0x04003F88 RID: 16264
		internal static int __PropertyOffset_TetherStiffness;

		// Token: 0x04003F89 RID: 16265
		internal static int __PropertyOffset_TetherLimit;

		// Token: 0x04003F8A RID: 16266
		internal static int __PropertyOffset_Drag;

		// Token: 0x04003F8B RID: 16267
		internal static int __PropertyOffset_StiffnessFrequency;

		// Token: 0x04003F8C RID: 16268
		internal static int __PropertyOffset_GravityScale;

		// Token: 0x04003F8D RID: 16269
		internal static int __PropertyOffset_MassScale;

		// Token: 0x04003F8E RID: 16270
		internal static int __PropertyOffset_InertiaBlend;

		// Token: 0x04003F8F RID: 16271
		internal static int __PropertyOffset_SelfCollisionThickness;

		// Token: 0x04003F90 RID: 16272
		internal static int __PropertyOffset_SelfCollisionSquashScale;

		// Token: 0x04003F91 RID: 16273
		internal static int __PropertyOffset_SelfCollisionStiffness;

		// Token: 0x04003F92 RID: 16274
		internal static int __PropertyOffset_SolverFrequency;

		// Token: 0x04003F93 RID: 16275
		internal static int __PropertyOffset_FiberCompression;

		// Token: 0x04003F94 RID: 16276
		internal static int __PropertyOffset_FiberExpansion;

		// Token: 0x04003F95 RID: 16277
		internal static int __PropertyOffset_FiberResistance;
	}
}
