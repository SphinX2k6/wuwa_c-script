using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046E RID: 1134
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Chaos.SolverTrailingData")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSolverTrailingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C8A RID: 15498 RVA: 0x0005B31D File Offset: 0x0005951D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverTrailingData._ScriptStructPtr != 0) ? FSolverTrailingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverTrailingData", ref FSolverTrailingData._ScriptStructPtr);
		}

		// Token: 0x17000EAB RID: 3755
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x0005B341 File Offset: 0x00059541
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x0005B355 File Offset: 0x00059555
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000EAC RID: 3756
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x0005B36A File Offset: 0x0005956A
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x0005B37E File Offset: 0x0005957E
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17000EAD RID: 3757
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x0005B393 File Offset: 0x00059593
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x0005B3A7 File Offset: 0x000595A7
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17000EAE RID: 3758
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x0005B3BC File Offset: 0x000595BC
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x0005B3CC File Offset: 0x000595CC
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x17000EAF RID: 3759
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x0005B3DD File Offset: 0x000595DD
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x0005B3ED File Offset: 0x000595ED
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x17000EB0 RID: 3760
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x0005B3FE File Offset: 0x000595FE
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x0005B40E File Offset: 0x0005960E
		public unsafe int ParticleIndexMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_ParticleIndexMesh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverTrailingData.__PropertyOffset_ParticleIndexMesh) = value;
			}
		}

		// Token: 0x06003C97 RID: 15511 RVA: 0x0005B41F File Offset: 0x0005961F
		public FSolverTrailingData()
		{
		}

		// Token: 0x06003C98 RID: 15512 RVA: 0x0005B427 File Offset: 0x00059627
		public FSolverTrailingData(FVector Location, FVector Velocity, FVector AngularVelocity, float Mass, int ParticleIndex, int ParticleIndexMesh)
		{
			this.Location = Location;
			this.Velocity = Velocity;
			this.AngularVelocity = AngularVelocity;
			this.Mass = Mass;
			this.ParticleIndex = ParticleIndex;
			this.ParticleIndexMesh = ParticleIndexMesh;
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x0005B45C File Offset: 0x0005965C
		protected override IntPtr GetUStructPtr()
		{
			return FSolverTrailingData.StaticStruct();
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x0005B468 File Offset: 0x00059668
		[NullableContext(2)]
		public FSolverTrailingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x0005B472 File Offset: 0x00059672
		public FSolverTrailingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x0005B47D File Offset: 0x0005967D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverTrailingData(Pointer, false, true);
		}

		// Token: 0x06003C9D RID: 15517 RVA: 0x0005B487 File Offset: 0x00059687
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverTrailingData(Pointer, MemoryOwner);
		}

		// Token: 0x04001C65 RID: 7269
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverTrailingData";

		// Token: 0x04001C66 RID: 7270
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C67 RID: 7271
		internal static int __PropertyOffset_Location;

		// Token: 0x04001C68 RID: 7272
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001C69 RID: 7273
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04001C6A RID: 7274
		internal static int __PropertyOffset_Mass;

		// Token: 0x04001C6B RID: 7275
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x04001C6C RID: 7276
		internal static int __PropertyOffset_ParticleIndexMesh;
	}
}
