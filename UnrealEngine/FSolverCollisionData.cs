using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046C RID: 1132
	[UnrealObjectPath("/Script/Chaos.SolverCollisionData")]
	[UnrealStructLayout(108, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 108)]
	public class FSolverCollisionData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C58 RID: 15448 RVA: 0x0005AF54 File Offset: 0x00059154
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverCollisionData._ScriptStructPtr != 0) ? FSolverCollisionData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverCollisionData", ref FSolverCollisionData._ScriptStructPtr);
		}

		// Token: 0x17000E9A RID: 3738
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x0005AF78 File Offset: 0x00059178
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x0005AF8C File Offset: 0x0005918C
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000E9B RID: 3739
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x0005AFA1 File Offset: 0x000591A1
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x0005AFB5 File Offset: 0x000591B5
		public unsafe FVector AccumulatedImpulse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AccumulatedImpulse);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AccumulatedImpulse) = value;
			}
		}

		// Token: 0x17000E9C RID: 3740
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x0005AFCA File Offset: 0x000591CA
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x0005AFDE File Offset: 0x000591DE
		public unsafe FVector Normal
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Normal);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Normal) = value;
			}
		}

		// Token: 0x17000E9D RID: 3741
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x0005AFF3 File Offset: 0x000591F3
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x0005B007 File Offset: 0x00059207
		public unsafe FVector Velocity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Velocity1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Velocity1) = value;
			}
		}

		// Token: 0x17000E9E RID: 3742
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x0005B01C File Offset: 0x0005921C
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x0005B030 File Offset: 0x00059230
		public unsafe FVector Velocity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Velocity2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Velocity2) = value;
			}
		}

		// Token: 0x17000E9F RID: 3743
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x0005B045 File Offset: 0x00059245
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x0005B059 File Offset: 0x00059259
		public unsafe FVector AngularVelocity1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AngularVelocity1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AngularVelocity1) = value;
			}
		}

		// Token: 0x17000EA0 RID: 3744
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x0005B06E File Offset: 0x0005926E
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x0005B082 File Offset: 0x00059282
		public unsafe FVector AngularVelocity2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AngularVelocity2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_AngularVelocity2) = value;
			}
		}

		// Token: 0x17000EA1 RID: 3745
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0005B097 File Offset: 0x00059297
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x0005B0A7 File Offset: 0x000592A7
		public unsafe float Mass1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Mass1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Mass1) = value;
			}
		}

		// Token: 0x17000EA2 RID: 3746
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x0005B0B8 File Offset: 0x000592B8
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x0005B0C8 File Offset: 0x000592C8
		public unsafe float Mass2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Mass2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_Mass2) = value;
			}
		}

		// Token: 0x17000EA3 RID: 3747
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x0005B0D9 File Offset: 0x000592D9
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x0005B0E9 File Offset: 0x000592E9
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x17000EA4 RID: 3748
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x0005B0FA File Offset: 0x000592FA
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x0005B10A File Offset: 0x0005930A
		public unsafe int LevelsetIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_LevelsetIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_LevelsetIndex) = value;
			}
		}

		// Token: 0x17000EA5 RID: 3749
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x0005B11B File Offset: 0x0005931B
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x0005B12B File Offset: 0x0005932B
		public unsafe int ParticleIndexMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_ParticleIndexMesh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_ParticleIndexMesh) = value;
			}
		}

		// Token: 0x17000EA6 RID: 3750
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x0005B13C File Offset: 0x0005933C
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x0005B14C File Offset: 0x0005934C
		public unsafe int LevelsetIndexMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_LevelsetIndexMesh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverCollisionData.__PropertyOffset_LevelsetIndexMesh) = value;
			}
		}

		// Token: 0x06003C73 RID: 15475 RVA: 0x0005B15D File Offset: 0x0005935D
		public FSolverCollisionData()
		{
		}

		// Token: 0x06003C74 RID: 15476 RVA: 0x0005B168 File Offset: 0x00059368
		public FSolverCollisionData(FVector Location, FVector AccumulatedImpulse, FVector Normal, FVector Velocity1, FVector Velocity2, FVector AngularVelocity1, FVector AngularVelocity2, float Mass1, float Mass2, int ParticleIndex, int LevelsetIndex, int ParticleIndexMesh, int LevelsetIndexMesh)
		{
			this.Location = Location;
			this.AccumulatedImpulse = AccumulatedImpulse;
			this.Normal = Normal;
			this.Velocity1 = Velocity1;
			this.Velocity2 = Velocity2;
			this.AngularVelocity1 = AngularVelocity1;
			this.AngularVelocity2 = AngularVelocity2;
			this.Mass1 = Mass1;
			this.Mass2 = Mass2;
			this.ParticleIndex = ParticleIndex;
			this.LevelsetIndex = LevelsetIndex;
			this.ParticleIndexMesh = ParticleIndexMesh;
			this.LevelsetIndexMesh = LevelsetIndexMesh;
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x0005B1E0 File Offset: 0x000593E0
		protected override IntPtr GetUStructPtr()
		{
			return FSolverCollisionData.StaticStruct();
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x0005B1EC File Offset: 0x000593EC
		[NullableContext(2)]
		public FSolverCollisionData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x0005B1F6 File Offset: 0x000593F6
		public FSolverCollisionData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x0005B201 File Offset: 0x00059401
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverCollisionData(Pointer, false, true);
		}

		// Token: 0x06003C79 RID: 15481 RVA: 0x0005B20B File Offset: 0x0005940B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverCollisionData(Pointer, MemoryOwner);
		}

		// Token: 0x04001C50 RID: 7248
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverCollisionData";

		// Token: 0x04001C51 RID: 7249
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C52 RID: 7250
		internal static int __PropertyOffset_Location;

		// Token: 0x04001C53 RID: 7251
		internal static int __PropertyOffset_AccumulatedImpulse;

		// Token: 0x04001C54 RID: 7252
		internal static int __PropertyOffset_Normal;

		// Token: 0x04001C55 RID: 7253
		internal static int __PropertyOffset_Velocity1;

		// Token: 0x04001C56 RID: 7254
		internal static int __PropertyOffset_Velocity2;

		// Token: 0x04001C57 RID: 7255
		internal static int __PropertyOffset_AngularVelocity1;

		// Token: 0x04001C58 RID: 7256
		internal static int __PropertyOffset_AngularVelocity2;

		// Token: 0x04001C59 RID: 7257
		internal static int __PropertyOffset_Mass1;

		// Token: 0x04001C5A RID: 7258
		internal static int __PropertyOffset_Mass2;

		// Token: 0x04001C5B RID: 7259
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x04001C5C RID: 7260
		internal static int __PropertyOffset_LevelsetIndex;

		// Token: 0x04001C5D RID: 7261
		internal static int __PropertyOffset_ParticleIndexMesh;

		// Token: 0x04001C5E RID: 7262
		internal static int __PropertyOffset_LevelsetIndexMesh;
	}
}
