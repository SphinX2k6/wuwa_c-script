using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200143A RID: 5178
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.StaticMeshSimulationComponent")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UStaticMeshSimulationComponent : UActorComponent, IUnrealUObject, IUnrealObject, IChaosNotifyHandlerInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06012F29 RID: 77609 RVA: 0x001BDBF2 File Offset: 0x001BBDF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UStaticMeshSimulationComponent._ClassPtr;
		}

		// Token: 0x06012F2A RID: 77610 RVA: 0x001BDBFE File Offset: 0x001BBDFE
		int IChaosNotifyHandlerInterface.InterfaceOffset()
		{
			return UStaticMeshSimulationComponent.__InterfaceOffset_IChaosNotifyHandlerInterface;
		}

		// Token: 0x06012F2B RID: 77611 RVA: 0x001BDC08 File Offset: 0x001BBE08
		public UStaticMeshSimulationComponent() : this(BuiltinUtils.AllocNativeUObject(UStaticMeshSimulationComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06012F2C RID: 77612 RVA: 0x001BDC30 File Offset: 0x001BBE30
		public UStaticMeshSimulationComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UStaticMeshSimulationComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x06012F2D RID: 77613 RVA: 0x001BDC63 File Offset: 0x001BBE63
		// (set) Token: 0x06012F2E RID: 77614 RVA: 0x001BDC73 File Offset: 0x001BBE73
		public unsafe bool Simulating
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_Simulating) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_Simulating) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x06012F2F RID: 77615 RVA: 0x001BDC84 File Offset: 0x001BBE84
		// (set) Token: 0x06012F30 RID: 77616 RVA: 0x001BDC94 File Offset: 0x001BBE94
		public unsafe bool bNotifyCollisions
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_bNotifyCollisions) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_bNotifyCollisions) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x06012F31 RID: 77617 RVA: 0x001BDCA5 File Offset: 0x001BBEA5
		// (set) Token: 0x06012F32 RID: 77618 RVA: 0x001BDCB5 File Offset: 0x001BBEB5
		public unsafe EObjectStateTypeEnum ObjectType
		{
			get
			{
				return (EObjectStateTypeEnum)(*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_ObjectType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_ObjectType) = (byte)value;
			}
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x06012F33 RID: 77619 RVA: 0x001BDCC6 File Offset: 0x001BBEC6
		// (set) Token: 0x06012F34 RID: 77620 RVA: 0x001BDCD6 File Offset: 0x001BBED6
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x06012F35 RID: 77621 RVA: 0x001BDCE7 File Offset: 0x001BBEE7
		// (set) Token: 0x06012F36 RID: 77622 RVA: 0x001BDCF7 File Offset: 0x001BBEF7
		public unsafe ECollisionTypeEnum CollisionType
		{
			get
			{
				return (ECollisionTypeEnum)(*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_CollisionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_CollisionType) = (byte)value;
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x06012F37 RID: 77623 RVA: 0x001BDD08 File Offset: 0x001BBF08
		// (set) Token: 0x06012F38 RID: 77624 RVA: 0x001BDD18 File Offset: 0x001BBF18
		public unsafe EImplicitTypeEnum ImplicitType
		{
			get
			{
				return (EImplicitTypeEnum)(*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_ImplicitType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_ImplicitType) = (byte)value;
			}
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x06012F39 RID: 77625 RVA: 0x001BDD29 File Offset: 0x001BBF29
		// (set) Token: 0x06012F3A RID: 77626 RVA: 0x001BDD39 File Offset: 0x001BBF39
		public unsafe int MinLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_MinLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_MinLevelSetResolution) = value;
			}
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x06012F3B RID: 77627 RVA: 0x001BDD4A File Offset: 0x001BBF4A
		// (set) Token: 0x06012F3C RID: 77628 RVA: 0x001BDD5A File Offset: 0x001BBF5A
		public unsafe int MaxLevelSetResolution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_MaxLevelSetResolution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_MaxLevelSetResolution) = value;
			}
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x06012F3D RID: 77629 RVA: 0x001BDD6B File Offset: 0x001BBF6B
		// (set) Token: 0x06012F3E RID: 77630 RVA: 0x001BDD7B File Offset: 0x001BBF7B
		public unsafe EInitialVelocityTypeEnum InitialVelocityType
		{
			get
			{
				return (EInitialVelocityTypeEnum)(*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialVelocityType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialVelocityType) = (byte)value;
			}
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x06012F3F RID: 77631 RVA: 0x001BDD8C File Offset: 0x001BBF8C
		// (set) Token: 0x06012F40 RID: 77632 RVA: 0x001BDDA0 File Offset: 0x001BBFA0
		public unsafe FVector InitialLinearVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialLinearVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialLinearVelocity) = value;
			}
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x06012F41 RID: 77633 RVA: 0x001BDDB5 File Offset: 0x001BBFB5
		// (set) Token: 0x06012F42 RID: 77634 RVA: 0x001BDDC9 File Offset: 0x001BBFC9
		public unsafe FVector InitialAngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialAngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_InitialAngularVelocity) = value;
			}
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x06012F43 RID: 77635 RVA: 0x001BDDDE File Offset: 0x001BBFDE
		// (set) Token: 0x06012F44 RID: 77636 RVA: 0x001BDDEE File Offset: 0x001BBFEE
		public unsafe float DamageThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_DamageThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_DamageThreshold) = value;
			}
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x06012F45 RID: 77637 RVA: 0x001BDDFF File Offset: 0x001BBFFF
		// (set) Token: 0x06012F46 RID: 77638 RVA: 0x001BDE13 File Offset: 0x001BC013
		[Nullable(2)]
		public unsafe UChaosPhysicalMaterial PhysicalMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UChaosPhysicalMaterial>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshSimulationComponent.__PropertyOffset_PhysicalMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshSimulationComponent.__PropertyOffset_PhysicalMaterial, value);
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x06012F47 RID: 77639 RVA: 0x001BDE28 File Offset: 0x001BC028
		// (set) Token: 0x06012F48 RID: 77640 RVA: 0x001BDE3C File Offset: 0x001BC03C
		[Nullable(2)]
		public unsafe AChaosSolverActor ChaosSolverActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AChaosSolverActor>(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshSimulationComponent.__PropertyOffset_ChaosSolverActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UStaticMeshSimulationComponent.__PropertyOffset_ChaosSolverActor, value);
			}
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x06012F49 RID: 77641 RVA: 0x001BDE54 File Offset: 0x001BC054
		// (set) Token: 0x06012F4A RID: 77642 RVA: 0x001BDE8D File Offset: 0x001BC08D
		public FOnChaosPhysicsCollision OnChaosPhysicsCollision
		{
			get
			{
				base.FastCheckIsValid();
				FOnChaosPhysicsCollision result;
				if ((result = this._OnChaosPhysicsCollision) == null)
				{
					result = (this._OnChaosPhysicsCollision = new FOnChaosPhysicsCollision(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_OnChaosPhysicsCollision, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_OnChaosPhysicsCollision, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x06012F4B RID: 77643 RVA: 0x001BDEB0 File Offset: 0x001BC0B0
		// (set) Token: 0x06012F4C RID: 77644 RVA: 0x001BDEE9 File Offset: 0x001BC0E9
		public TArray<UPrimitiveComponent> SimulatedComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UPrimitiveComponent> result;
				if ((result = this._SimulatedComponents) == null)
				{
					result = (this._SimulatedComponents = new TArray<UPrimitiveComponent>(base.NativePtr + (IntPtr)UStaticMeshSimulationComponent.__PropertyOffset_SimulatedComponents, this));
				}
				return result;
			}
			set
			{
				this.SimulatedComponents.CopyAssign(value);
			}
		}

		// Token: 0x06012F4D RID: 77645 RVA: 0x001BDEF7 File Offset: 0x001BC0F7
		[NullableContext(2)]
		public virtual void ReceivePhysicsCollision(in FChaosPhysicsCollisionInfo CollisionInfo)
		{
			UStaticMeshSimulationComponent.__ReceivePhysicsCollision_Internal(base.NativePtr, (CollisionInfo ?? new FChaosPhysicsCollisionInfo()).NativePtr);
		}

		// Token: 0x06012F4E RID: 77646 RVA: 0x001BDF14 File Offset: 0x001BC114
		public void ForceRecreatePhysicsState()
		{
			UStaticMeshSimulationComponent.__ForceRecreatePhysicsState_Internal(base.NativePtr);
		}

		// Token: 0x06012F4F RID: 77647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ReceivePhysicsCollision_Internal(IntPtr @this, IntPtr CollisionInfo);

		// Token: 0x06012F50 RID: 77648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ForceRecreatePhysicsState_Internal(IntPtr @this);

		// Token: 0x06012F51 RID: 77649 RVA: 0x001BDF21 File Offset: 0x001BC121
		static UStaticMeshSimulationComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/GeometryCollectionEngine.StaticMeshSimulationComponent");
		}

		// Token: 0x06012F52 RID: 77650 RVA: 0x001BDF2F File Offset: 0x001BC12F
		protected UStaticMeshSimulationComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A1E8 RID: 41448
		internal static int __InterfaceOffset_IChaosNotifyHandlerInterface;

		// Token: 0x0400A1E9 RID: 41449
		public new const string __ObjectPath = "/Script/GeometryCollectionEngine.StaticMeshSimulationComponent";

		// Token: 0x0400A1EA RID: 41450
		private static IntPtr _ClassPtr;

		// Token: 0x0400A1EB RID: 41451
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A1EC RID: 41452
		internal static int __PropertyOffset_Simulating;

		// Token: 0x0400A1ED RID: 41453
		internal static int __PropertyOffset_bNotifyCollisions;

		// Token: 0x0400A1EE RID: 41454
		internal static int __PropertyOffset_ObjectType;

		// Token: 0x0400A1EF RID: 41455
		internal static int __PropertyOffset_Mass;

		// Token: 0x0400A1F0 RID: 41456
		internal static int __PropertyOffset_CollisionType;

		// Token: 0x0400A1F1 RID: 41457
		internal static int __PropertyOffset_ImplicitType;

		// Token: 0x0400A1F2 RID: 41458
		internal static int __PropertyOffset_MinLevelSetResolution;

		// Token: 0x0400A1F3 RID: 41459
		internal static int __PropertyOffset_MaxLevelSetResolution;

		// Token: 0x0400A1F4 RID: 41460
		internal static int __PropertyOffset_InitialVelocityType;

		// Token: 0x0400A1F5 RID: 41461
		internal static int __PropertyOffset_InitialLinearVelocity;

		// Token: 0x0400A1F6 RID: 41462
		internal static int __PropertyOffset_InitialAngularVelocity;

		// Token: 0x0400A1F7 RID: 41463
		internal static int __PropertyOffset_DamageThreshold;

		// Token: 0x0400A1F8 RID: 41464
		internal static int __PropertyOffset_PhysicalMaterial;

		// Token: 0x0400A1F9 RID: 41465
		internal static int __PropertyOffset_ChaosSolverActor;

		// Token: 0x0400A1FA RID: 41466
		internal static int __PropertyOffset_OnChaosPhysicsCollision;

		// Token: 0x0400A1FB RID: 41467
		[Nullable(2)]
		private FOnChaosPhysicsCollision _OnChaosPhysicsCollision;

		// Token: 0x0400A1FC RID: 41468
		internal static int __PropertyOffset_SimulatedComponents;

		// Token: 0x0400A1FD RID: 41469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UPrimitiveComponent> _SimulatedComponents;

		// Token: 0x02002E90 RID: 11920
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 112)]
		protected ref struct __ReceivePhysicsCollision_FunctionParams
		{
			// Token: 0x04016961 RID: 92513
			[FieldOffset(0)]
			public byte CollisionInfo;
		}
	}
}
