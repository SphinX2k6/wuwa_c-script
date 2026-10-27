using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200046A RID: 1130
	[UnrealObjectPath("/Script/Chaos.SolverBreakingData")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FSolverBreakingData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003C34 RID: 15412 RVA: 0x0005ACD8 File Offset: 0x00058ED8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSolverBreakingData._ScriptStructPtr != 0) ? FSolverBreakingData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Chaos.SolverBreakingData", ref FSolverBreakingData._ScriptStructPtr);
		}

		// Token: 0x17000E90 RID: 3728
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x0005ACFC File Offset: 0x00058EFC
		// (set) Token: 0x06003C36 RID: 15414 RVA: 0x0005AD10 File Offset: 0x00058F10
		public unsafe FVector Location
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Location);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Location) = value;
			}
		}

		// Token: 0x17000E91 RID: 3729
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x0005AD25 File Offset: 0x00058F25
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x0005AD39 File Offset: 0x00058F39
		public unsafe FVector Velocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Velocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Velocity) = value;
			}
		}

		// Token: 0x17000E92 RID: 3730
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x0005AD4E File Offset: 0x00058F4E
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x0005AD62 File Offset: 0x00058F62
		public unsafe FVector AngularVelocity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_AngularVelocity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_AngularVelocity) = value;
			}
		}

		// Token: 0x17000E93 RID: 3731
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x0005AD77 File Offset: 0x00058F77
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0005AD87 File Offset: 0x00058F87
		public unsafe float Mass
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Mass);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_Mass) = value;
			}
		}

		// Token: 0x17000E94 RID: 3732
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0005AD98 File Offset: 0x00058F98
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0005ADA8 File Offset: 0x00058FA8
		public unsafe int ParticleIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_ParticleIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_ParticleIndex) = value;
			}
		}

		// Token: 0x17000E95 RID: 3733
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x0005ADB9 File Offset: 0x00058FB9
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x0005ADC9 File Offset: 0x00058FC9
		public unsafe int ParticleIndexMesh
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_ParticleIndexMesh);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSolverBreakingData.__PropertyOffset_ParticleIndexMesh) = value;
			}
		}

		// Token: 0x06003C41 RID: 15425 RVA: 0x0005ADDA File Offset: 0x00058FDA
		public FSolverBreakingData()
		{
		}

		// Token: 0x06003C42 RID: 15426 RVA: 0x0005ADE2 File Offset: 0x00058FE2
		public FSolverBreakingData(FVector Location, FVector Velocity, FVector AngularVelocity, float Mass, int ParticleIndex, int ParticleIndexMesh)
		{
			this.Location = Location;
			this.Velocity = Velocity;
			this.AngularVelocity = AngularVelocity;
			this.Mass = Mass;
			this.ParticleIndex = ParticleIndex;
			this.ParticleIndexMesh = ParticleIndexMesh;
		}

		// Token: 0x06003C43 RID: 15427 RVA: 0x0005AE17 File Offset: 0x00059017
		protected override IntPtr GetUStructPtr()
		{
			return FSolverBreakingData.StaticStruct();
		}

		// Token: 0x06003C44 RID: 15428 RVA: 0x0005AE23 File Offset: 0x00059023
		[NullableContext(2)]
		public FSolverBreakingData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003C45 RID: 15429 RVA: 0x0005AE2D File Offset: 0x0005902D
		public FSolverBreakingData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003C46 RID: 15430 RVA: 0x0005AE38 File Offset: 0x00059038
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSolverBreakingData(Pointer, false, true);
		}

		// Token: 0x06003C47 RID: 15431 RVA: 0x0005AE42 File Offset: 0x00059042
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSolverBreakingData(Pointer, MemoryOwner);
		}

		// Token: 0x04001C42 RID: 7234
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Chaos.SolverBreakingData";

		// Token: 0x04001C43 RID: 7235
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001C44 RID: 7236
		internal static int __PropertyOffset_Location;

		// Token: 0x04001C45 RID: 7237
		internal static int __PropertyOffset_Velocity;

		// Token: 0x04001C46 RID: 7238
		internal static int __PropertyOffset_AngularVelocity;

		// Token: 0x04001C47 RID: 7239
		internal static int __PropertyOffset_Mass;

		// Token: 0x04001C48 RID: 7240
		internal static int __PropertyOffset_ParticleIndex;

		// Token: 0x04001C49 RID: 7241
		internal static int __PropertyOffset_ParticleIndexMesh;
	}
}
