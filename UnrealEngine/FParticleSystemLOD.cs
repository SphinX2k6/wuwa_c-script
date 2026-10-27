using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FC6 RID: 4038
	[UnrealObjectPath("/Script/Engine.ParticleSystemLOD")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FParticleSystemLOD : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D9FC RID: 55804 RVA: 0x00141C81 File Offset: 0x0013FE81
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParticleSystemLOD._ScriptStructPtr != 0) ? FParticleSystemLOD._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParticleSystemLOD", ref FParticleSystemLOD._ScriptStructPtr);
		}

		// Token: 0x0600D9FD RID: 55805 RVA: 0x00141CA5 File Offset: 0x0013FEA5
		public FParticleSystemLOD()
		{
		}

		// Token: 0x0600D9FE RID: 55806 RVA: 0x00141CAD File Offset: 0x0013FEAD
		protected override IntPtr GetUStructPtr()
		{
			return FParticleSystemLOD.StaticStruct();
		}

		// Token: 0x0600D9FF RID: 55807 RVA: 0x00141CB9 File Offset: 0x0013FEB9
		[NullableContext(2)]
		public FParticleSystemLOD(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DA00 RID: 55808 RVA: 0x00141CC3 File Offset: 0x0013FEC3
		public FParticleSystemLOD(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DA01 RID: 55809 RVA: 0x00141CCE File Offset: 0x0013FECE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParticleSystemLOD(Pointer, false, true);
		}

		// Token: 0x0600DA02 RID: 55810 RVA: 0x00141CD8 File Offset: 0x0013FED8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParticleSystemLOD(Pointer, MemoryOwner);
		}

		// Token: 0x04007630 RID: 30256
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ParticleSystemLOD";

		// Token: 0x04007631 RID: 30257
		private static IntPtr _ScriptStructPtr;
	}
}
