using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200025D RID: 605
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class APhysicsConstraintActor : ARigidBodyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060033B3 RID: 13235 RVA: 0x00049EBE File Offset: 0x000480BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APhysicsConstraintActor._ClassPtr;
		}

		// Token: 0x060033B4 RID: 13236 RVA: 0x00049ECC File Offset: 0x000480CC
		public APhysicsConstraintActor() : this(BuiltinUtils.AllocNativeUObject(APhysicsConstraintActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060033B5 RID: 13237 RVA: 0x00049EF4 File Offset: 0x000480F4
		[NullableContext(1)]
		public APhysicsConstraintActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APhysicsConstraintActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x00049F27 File Offset: 0x00048127
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x00049F3B File Offset: 0x0004813B
		public unsafe UPhysicsConstraintComponent ConstraintComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintComp, value);
			}
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x00049F50 File Offset: 0x00048150
		// (set) Token: 0x060033B9 RID: 13241 RVA: 0x00049F64 File Offset: 0x00048164
		public unsafe AActor ConstraintActor1_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintActor1_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintActor1_DEPRECATED, value);
			}
		}

		// Token: 0x17000735 RID: 1845
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x00049F79 File Offset: 0x00048179
		// (set) Token: 0x060033BB RID: 13243 RVA: 0x00049F8D File Offset: 0x0004818D
		public unsafe AActor ConstraintActor2_DEPRECATED
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintActor2_DEPRECATED);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + APhysicsConstraintActor.__PropertyOffset_ConstraintActor2_DEPRECATED, value);
			}
		}

		// Token: 0x17000736 RID: 1846
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x00049FA2 File Offset: 0x000481A2
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x00049FBB File Offset: 0x000481BB
		public unsafe bool bDisableCollision_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)APhysicsConstraintActor.__PropertyOffset_bDisableCollision_DEPRECATED) & APhysicsConstraintActor.__PropertyMask_bDisableCollision_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)APhysicsConstraintActor.__PropertyOffset_bDisableCollision_DEPRECATED) = ((*(base.NativePtr + (IntPtr)APhysicsConstraintActor.__PropertyOffset_bDisableCollision_DEPRECATED) & ~APhysicsConstraintActor.__PropertyMask_bDisableCollision_DEPRECATED) | (value ? APhysicsConstraintActor.__PropertyMask_bDisableCollision_DEPRECATED : 0));
			}
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x00049FEB File Offset: 0x000481EB
		static APhysicsConstraintActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsConstraintActor");
		}

		// Token: 0x060033BF RID: 13247 RVA: 0x00049FF9 File Offset: 0x000481F9
		protected APhysicsConstraintActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040011FA RID: 4602
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsConstraintActor";

		// Token: 0x040011FB RID: 4603
		private static IntPtr _ClassPtr;

		// Token: 0x040011FC RID: 4604
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040011FD RID: 4605
		internal static int __PropertyOffset_ConstraintComp;

		// Token: 0x040011FE RID: 4606
		internal static int __PropertyOffset_ConstraintActor1_DEPRECATED;

		// Token: 0x040011FF RID: 4607
		internal static int __PropertyOffset_ConstraintActor2_DEPRECATED;

		// Token: 0x04001200 RID: 4608
		internal static int __PropertyOffset_bDisableCollision_DEPRECATED;

		// Token: 0x04001201 RID: 4609
		internal static byte __PropertyMask_bDisableCollision_DEPRECATED;
	}
}
