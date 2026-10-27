using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000FE1 RID: 4065
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PhysicsConstraintActor")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class APhysicsConstraintActor : ARigidBodyBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600DB97 RID: 56215 RVA: 0x001438AE File Offset: 0x00141AAE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return APhysicsConstraintActor._ClassPtr;
		}

		// Token: 0x0600DB98 RID: 56216 RVA: 0x001438BC File Offset: 0x00141ABC
		public APhysicsConstraintActor() : this(BuiltinUtils.AllocNativeUObject(APhysicsConstraintActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600DB99 RID: 56217 RVA: 0x001438E4 File Offset: 0x00141AE4
		[NullableContext(1)]
		public APhysicsConstraintActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(APhysicsConstraintActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170033C7 RID: 13255
		// (get) Token: 0x0600DB9A RID: 56218 RVA: 0x00143917 File Offset: 0x00141B17
		// (set) Token: 0x0600DB9B RID: 56219 RVA: 0x0014392B File Offset: 0x00141B2B
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

		// Token: 0x170033C8 RID: 13256
		// (get) Token: 0x0600DB9C RID: 56220 RVA: 0x00143940 File Offset: 0x00141B40
		// (set) Token: 0x0600DB9D RID: 56221 RVA: 0x00143954 File Offset: 0x00141B54
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

		// Token: 0x170033C9 RID: 13257
		// (get) Token: 0x0600DB9E RID: 56222 RVA: 0x00143969 File Offset: 0x00141B69
		// (set) Token: 0x0600DB9F RID: 56223 RVA: 0x0014397D File Offset: 0x00141B7D
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

		// Token: 0x170033CA RID: 13258
		// (get) Token: 0x0600DBA0 RID: 56224 RVA: 0x00143992 File Offset: 0x00141B92
		// (set) Token: 0x0600DBA1 RID: 56225 RVA: 0x001439AB File Offset: 0x00141BAB
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

		// Token: 0x0600DBA2 RID: 56226 RVA: 0x001439DB File Offset: 0x00141BDB
		static APhysicsConstraintActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.PhysicsConstraintActor");
		}

		// Token: 0x0600DBA3 RID: 56227 RVA: 0x001439E9 File Offset: 0x00141BE9
		protected APhysicsConstraintActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040076D0 RID: 30416
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PhysicsConstraintActor";

		// Token: 0x040076D1 RID: 30417
		private static IntPtr _ClassPtr;

		// Token: 0x040076D2 RID: 30418
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040076D3 RID: 30419
		internal static int __PropertyOffset_ConstraintComp;

		// Token: 0x040076D4 RID: 30420
		internal static int __PropertyOffset_ConstraintActor1_DEPRECATED;

		// Token: 0x040076D5 RID: 30421
		internal static int __PropertyOffset_ConstraintActor2_DEPRECATED;

		// Token: 0x040076D6 RID: 30422
		internal static int __PropertyOffset_bDisableCollision_DEPRECATED;

		// Token: 0x040076D7 RID: 30423
		internal static byte __PropertyMask_bDisableCollision_DEPRECATED;
	}
}
