using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FDB RID: 4059
	[UnrealObjectPath("/Script/Engine.PhysicalAnimationData")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FPhysicalAnimationData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DB3B RID: 56123 RVA: 0x00143088 File Offset: 0x00141288
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPhysicalAnimationData._ScriptStructPtr != 0) ? FPhysicalAnimationData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PhysicalAnimationData", ref FPhysicalAnimationData._ScriptStructPtr);
		}

		// Token: 0x170033AD RID: 13229
		// (get) Token: 0x0600DB3C RID: 56124 RVA: 0x001430AC File Offset: 0x001412AC
		// (set) Token: 0x0600DB3D RID: 56125 RVA: 0x001430C0 File Offset: 0x001412C0
		public unsafe FName BodyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_BodyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_BodyName) = value;
			}
		}

		// Token: 0x170033AE RID: 13230
		// (get) Token: 0x0600DB3E RID: 56126 RVA: 0x001430D5 File Offset: 0x001412D5
		// (set) Token: 0x0600DB3F RID: 56127 RVA: 0x001430EE File Offset: 0x001412EE
		public unsafe bool bIsLocalSimulation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_bIsLocalSimulation) & FPhysicalAnimationData.__PropertyMask_bIsLocalSimulation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_bIsLocalSimulation) = ((*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_bIsLocalSimulation) & ~FPhysicalAnimationData.__PropertyMask_bIsLocalSimulation) | (value ? FPhysicalAnimationData.__PropertyMask_bIsLocalSimulation : 0));
			}
		}

		// Token: 0x170033AF RID: 13231
		// (get) Token: 0x0600DB40 RID: 56128 RVA: 0x0014311E File Offset: 0x0014131E
		// (set) Token: 0x0600DB41 RID: 56129 RVA: 0x0014312E File Offset: 0x0014132E
		public unsafe float OrientationStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_OrientationStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_OrientationStrength) = value;
			}
		}

		// Token: 0x170033B0 RID: 13232
		// (get) Token: 0x0600DB42 RID: 56130 RVA: 0x0014313F File Offset: 0x0014133F
		// (set) Token: 0x0600DB43 RID: 56131 RVA: 0x0014314F File Offset: 0x0014134F
		public unsafe float AngularVelocityStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_AngularVelocityStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_AngularVelocityStrength) = value;
			}
		}

		// Token: 0x170033B1 RID: 13233
		// (get) Token: 0x0600DB44 RID: 56132 RVA: 0x00143160 File Offset: 0x00141360
		// (set) Token: 0x0600DB45 RID: 56133 RVA: 0x00143170 File Offset: 0x00141370
		public unsafe float PositionStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_PositionStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_PositionStrength) = value;
			}
		}

		// Token: 0x170033B2 RID: 13234
		// (get) Token: 0x0600DB46 RID: 56134 RVA: 0x00143181 File Offset: 0x00141381
		// (set) Token: 0x0600DB47 RID: 56135 RVA: 0x00143191 File Offset: 0x00141391
		public unsafe float VelocityStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_VelocityStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_VelocityStrength) = value;
			}
		}

		// Token: 0x170033B3 RID: 13235
		// (get) Token: 0x0600DB48 RID: 56136 RVA: 0x001431A2 File Offset: 0x001413A2
		// (set) Token: 0x0600DB49 RID: 56137 RVA: 0x001431B2 File Offset: 0x001413B2
		public unsafe float MaxLinearForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_MaxLinearForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_MaxLinearForce) = value;
			}
		}

		// Token: 0x170033B4 RID: 13236
		// (get) Token: 0x0600DB4A RID: 56138 RVA: 0x001431C3 File Offset: 0x001413C3
		// (set) Token: 0x0600DB4B RID: 56139 RVA: 0x001431D3 File Offset: 0x001413D3
		public unsafe float MaxAngularForce
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_MaxAngularForce);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPhysicalAnimationData.__PropertyOffset_MaxAngularForce) = value;
			}
		}

		// Token: 0x0600DB4C RID: 56140 RVA: 0x001431E4 File Offset: 0x001413E4
		public FPhysicalAnimationData()
		{
		}

		// Token: 0x0600DB4D RID: 56141 RVA: 0x001431EC File Offset: 0x001413EC
		public FPhysicalAnimationData(FName BodyName, bool bIsLocalSimulation, float OrientationStrength, float AngularVelocityStrength, float PositionStrength, float VelocityStrength, float MaxLinearForce, float MaxAngularForce)
		{
			this.BodyName = BodyName;
			this.bIsLocalSimulation = bIsLocalSimulation;
			this.OrientationStrength = OrientationStrength;
			this.AngularVelocityStrength = AngularVelocityStrength;
			this.PositionStrength = PositionStrength;
			this.VelocityStrength = VelocityStrength;
			this.MaxLinearForce = MaxLinearForce;
			this.MaxAngularForce = MaxAngularForce;
		}

		// Token: 0x0600DB4E RID: 56142 RVA: 0x0014323C File Offset: 0x0014143C
		protected override IntPtr GetUStructPtr()
		{
			return FPhysicalAnimationData.StaticStruct();
		}

		// Token: 0x0600DB4F RID: 56143 RVA: 0x00143248 File Offset: 0x00141448
		[NullableContext(2)]
		public FPhysicalAnimationData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DB50 RID: 56144 RVA: 0x00143252 File Offset: 0x00141452
		public FPhysicalAnimationData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DB51 RID: 56145 RVA: 0x0014325D File Offset: 0x0014145D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPhysicalAnimationData(Pointer, false, true);
		}

		// Token: 0x0600DB52 RID: 56146 RVA: 0x00143267 File Offset: 0x00141467
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPhysicalAnimationData(Pointer, MemoryOwner);
		}

		// Token: 0x0400769E RID: 30366
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PhysicalAnimationData";

		// Token: 0x0400769F RID: 30367
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040076A0 RID: 30368
		internal static int __PropertyOffset_BodyName;

		// Token: 0x040076A1 RID: 30369
		internal static int __PropertyOffset_bIsLocalSimulation;

		// Token: 0x040076A2 RID: 30370
		internal static byte __PropertyMask_bIsLocalSimulation;

		// Token: 0x040076A3 RID: 30371
		internal static int __PropertyOffset_OrientationStrength;

		// Token: 0x040076A4 RID: 30372
		internal static int __PropertyOffset_AngularVelocityStrength;

		// Token: 0x040076A5 RID: 30373
		internal static int __PropertyOffset_PositionStrength;

		// Token: 0x040076A6 RID: 30374
		internal static int __PropertyOffset_VelocityStrength;

		// Token: 0x040076A7 RID: 30375
		internal static int __PropertyOffset_MaxLinearForce;

		// Token: 0x040076A8 RID: 30376
		internal static int __PropertyOffset_MaxAngularForce;
	}
}
