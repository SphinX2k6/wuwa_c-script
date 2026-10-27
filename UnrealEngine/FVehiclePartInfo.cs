using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C35 RID: 7221
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.VehiclePartInfo")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FVehiclePartInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BFAC RID: 114604 RVA: 0x00292B9D File Offset: 0x00290D9D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVehiclePartInfo._ScriptStructPtr != 0) ? FVehiclePartInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.VehiclePartInfo", ref FVehiclePartInfo._ScriptStructPtr);
		}

		// Token: 0x170070FF RID: 28927
		// (get) Token: 0x0601BFAD RID: 114605 RVA: 0x00292BC1 File Offset: 0x00290DC1
		// (set) Token: 0x0601BFAE RID: 114606 RVA: 0x00292BD5 File Offset: 0x00290DD5
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17007100 RID: 28928
		// (get) Token: 0x0601BFAF RID: 114607 RVA: 0x00292BEA File Offset: 0x00290DEA
		// (set) Token: 0x0601BFB0 RID: 114608 RVA: 0x00292BFA File Offset: 0x00290DFA
		public unsafe float MaxHP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_MaxHP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_MaxHP) = value;
			}
		}

		// Token: 0x17007101 RID: 28929
		// (get) Token: 0x0601BFB1 RID: 114609 RVA: 0x00292C0B File Offset: 0x00290E0B
		// (set) Token: 0x0601BFB2 RID: 114610 RVA: 0x00292C1B File Offset: 0x00290E1B
		public unsafe float CurHP
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_CurHP);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_CurHP) = value;
			}
		}

		// Token: 0x17007102 RID: 28930
		// (get) Token: 0x0601BFB3 RID: 114611 RVA: 0x00292C2C File Offset: 0x00290E2C
		// (set) Token: 0x0601BFB4 RID: 114612 RVA: 0x00292C40 File Offset: 0x00290E40
		public unsafe UPhysicsConstraintComponent Constraint
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UPhysicsConstraintComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_Constraint);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_Constraint, value);
			}
		}

		// Token: 0x17007103 RID: 28931
		// (get) Token: 0x0601BFB5 RID: 114613 RVA: 0x00292C55 File Offset: 0x00290E55
		// (set) Token: 0x0601BFB6 RID: 114614 RVA: 0x00292C69 File Offset: 0x00290E69
		public unsafe UStaticMeshComponent MeshComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_MeshComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_MeshComponent, value);
			}
		}

		// Token: 0x17007104 RID: 28932
		// (get) Token: 0x0601BFB7 RID: 114615 RVA: 0x00292C7E File Offset: 0x00290E7E
		// (set) Token: 0x0601BFB8 RID: 114616 RVA: 0x00292C92 File Offset: 0x00290E92
		public unsafe FVector PhysicsEnableForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_PhysicsEnableForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_PhysicsEnableForce) = value;
			}
		}

		// Token: 0x17007105 RID: 28933
		// (get) Token: 0x0601BFB9 RID: 114617 RVA: 0x00292CA7 File Offset: 0x00290EA7
		// (set) Token: 0x0601BFBA RID: 114618 RVA: 0x00292CBB File Offset: 0x00290EBB
		public unsafe FVector ConstraintBreakForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_ConstraintBreakForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_ConstraintBreakForce) = value;
			}
		}

		// Token: 0x17007106 RID: 28934
		// (get) Token: 0x0601BFBB RID: 114619 RVA: 0x00292CD0 File Offset: 0x00290ED0
		// (set) Token: 0x0601BFBC RID: 114620 RVA: 0x00292CE0 File Offset: 0x00290EE0
		public unsafe bool bImpulseUseVelocityChange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bImpulseUseVelocityChange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bImpulseUseVelocityChange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007107 RID: 28935
		// (get) Token: 0x0601BFBD RID: 114621 RVA: 0x00292CF1 File Offset: 0x00290EF1
		// (set) Token: 0x0601BFBE RID: 114622 RVA: 0x00292D01 File Offset: 0x00290F01
		public unsafe bool bPhysicsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bPhysicsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bPhysicsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007108 RID: 28936
		// (get) Token: 0x0601BFBF RID: 114623 RVA: 0x00292D12 File Offset: 0x00290F12
		// (set) Token: 0x0601BFC0 RID: 114624 RVA: 0x00292D22 File Offset: 0x00290F22
		public unsafe bool bConstraintBroken
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bConstraintBroken) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bConstraintBroken) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007109 RID: 28937
		// (get) Token: 0x0601BFC1 RID: 114625 RVA: 0x00292D33 File Offset: 0x00290F33
		// (set) Token: 0x0601BFC2 RID: 114626 RVA: 0x00292D43 File Offset: 0x00290F43
		public unsafe float InstantBreakRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_InstantBreakRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_InstantBreakRadius) = value;
			}
		}

		// Token: 0x1700710A RID: 28938
		// (get) Token: 0x0601BFC3 RID: 114627 RVA: 0x00292D54 File Offset: 0x00290F54
		// (set) Token: 0x0601BFC4 RID: 114628 RVA: 0x00292D64 File Offset: 0x00290F64
		public unsafe bool bAlsoUseRadiusHit
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bAlsoUseRadiusHit) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_bAlsoUseRadiusHit) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700710B RID: 28939
		// (get) Token: 0x0601BFC5 RID: 114629 RVA: 0x00292D75 File Offset: 0x00290F75
		// (set) Token: 0x0601BFC6 RID: 114630 RVA: 0x00292D89 File Offset: 0x00290F89
		public unsafe UStaticMeshComponent FatherComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_FatherComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVehiclePartInfo.__PropertyOffset_FatherComponent, value);
			}
		}

		// Token: 0x1700710C RID: 28940
		// (get) Token: 0x0601BFC7 RID: 114631 RVA: 0x00292DA0 File Offset: 0x00290FA0
		// (set) Token: 0x0601BFC8 RID: 114632 RVA: 0x00292DE3 File Offset: 0x00290FE3
		[Nullable(1)]
		public TArray<UStaticMeshComponent> FatherComponents
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._FatherComponents) == null)
				{
					result = (this._FatherComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)FVehiclePartInfo.__PropertyOffset_FatherComponents, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.FatherComponents.CopyAssign(value);
			}
		}

		// Token: 0x0601BFC9 RID: 114633 RVA: 0x00292DF1 File Offset: 0x00290FF1
		public FVehiclePartInfo()
		{
		}

		// Token: 0x0601BFCA RID: 114634 RVA: 0x00292DFC File Offset: 0x00290FFC
		[NullableContext(1)]
		public FVehiclePartInfo(FName Name, float MaxHP, float CurHP, UPhysicsConstraintComponent Constraint, UStaticMeshComponent MeshComponent, FVector PhysicsEnableForce, FVector ConstraintBreakForce, bool bImpulseUseVelocityChange, bool bPhysicsEnabled, bool bConstraintBroken, float InstantBreakRadius, bool bAlsoUseRadiusHit, UStaticMeshComponent FatherComponent, TArray<UStaticMeshComponent> FatherComponents)
		{
			this.Name = Name;
			this.MaxHP = MaxHP;
			this.CurHP = CurHP;
			this.Constraint = Constraint;
			this.MeshComponent = MeshComponent;
			this.PhysicsEnableForce = PhysicsEnableForce;
			this.ConstraintBreakForce = ConstraintBreakForce;
			this.bImpulseUseVelocityChange = bImpulseUseVelocityChange;
			this.bPhysicsEnabled = bPhysicsEnabled;
			this.bConstraintBroken = bConstraintBroken;
			this.InstantBreakRadius = InstantBreakRadius;
			this.bAlsoUseRadiusHit = bAlsoUseRadiusHit;
			this.FatherComponent = FatherComponent;
			this.FatherComponents = FatherComponents;
		}

		// Token: 0x0601BFCB RID: 114635 RVA: 0x00292E7C File Offset: 0x0029107C
		protected override IntPtr GetUStructPtr()
		{
			return FVehiclePartInfo.StaticStruct();
		}

		// Token: 0x0601BFCC RID: 114636 RVA: 0x00292E88 File Offset: 0x00291088
		public FVehiclePartInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BFCD RID: 114637 RVA: 0x00292E92 File Offset: 0x00291092
		public FVehiclePartInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BFCE RID: 114638 RVA: 0x00292E9D File Offset: 0x0029109D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVehiclePartInfo(Pointer, false, true);
		}

		// Token: 0x0601BFCF RID: 114639 RVA: 0x00292EA7 File Offset: 0x002910A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVehiclePartInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400F063 RID: 61539
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.VehiclePartInfo";

		// Token: 0x0400F064 RID: 61540
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F065 RID: 61541
		internal static int __PropertyOffset_Name;

		// Token: 0x0400F066 RID: 61542
		internal static int __PropertyOffset_MaxHP;

		// Token: 0x0400F067 RID: 61543
		internal static int __PropertyOffset_CurHP;

		// Token: 0x0400F068 RID: 61544
		internal static int __PropertyOffset_Constraint;

		// Token: 0x0400F069 RID: 61545
		internal static int __PropertyOffset_MeshComponent;

		// Token: 0x0400F06A RID: 61546
		internal static int __PropertyOffset_PhysicsEnableForce;

		// Token: 0x0400F06B RID: 61547
		internal static int __PropertyOffset_ConstraintBreakForce;

		// Token: 0x0400F06C RID: 61548
		internal static int __PropertyOffset_bImpulseUseVelocityChange;

		// Token: 0x0400F06D RID: 61549
		internal static int __PropertyOffset_bPhysicsEnabled;

		// Token: 0x0400F06E RID: 61550
		internal static int __PropertyOffset_bConstraintBroken;

		// Token: 0x0400F06F RID: 61551
		internal static int __PropertyOffset_InstantBreakRadius;

		// Token: 0x0400F070 RID: 61552
		internal static int __PropertyOffset_bAlsoUseRadiusHit;

		// Token: 0x0400F071 RID: 61553
		internal static int __PropertyOffset_FatherComponent;

		// Token: 0x0400F072 RID: 61554
		internal static int __PropertyOffset_FatherComponents;

		// Token: 0x0400F073 RID: 61555
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _FatherComponents;
	}
}
