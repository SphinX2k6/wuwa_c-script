using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200246C RID: 9324
	[UnrealObjectPath("/Script/MRMesh.MRMeshConfiguration")]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 1)]
	public class FMRMeshConfiguration : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06022EB6 RID: 143030 RVA: 0x00339E2F File Offset: 0x0033802F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMRMeshConfiguration._ScriptStructPtr != 0) ? FMRMeshConfiguration._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/MRMesh.MRMeshConfiguration", ref FMRMeshConfiguration._ScriptStructPtr);
		}

		// Token: 0x06022EB7 RID: 143031 RVA: 0x00339E53 File Offset: 0x00338053
		public FMRMeshConfiguration()
		{
		}

		// Token: 0x06022EB8 RID: 143032 RVA: 0x00339E5B File Offset: 0x0033805B
		protected override IntPtr GetUStructPtr()
		{
			return FMRMeshConfiguration.StaticStruct();
		}

		// Token: 0x06022EB9 RID: 143033 RVA: 0x00339E67 File Offset: 0x00338067
		[NullableContext(2)]
		public FMRMeshConfiguration(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06022EBA RID: 143034 RVA: 0x00339E71 File Offset: 0x00338071
		public FMRMeshConfiguration(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06022EBB RID: 143035 RVA: 0x00339E7C File Offset: 0x0033807C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMRMeshConfiguration(Pointer, false, true);
		}

		// Token: 0x06022EBC RID: 143036 RVA: 0x00339E86 File Offset: 0x00338086
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMRMeshConfiguration(Pointer, MemoryOwner);
		}

		// Token: 0x04012A36 RID: 76342
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MRMesh.MRMeshConfiguration";

		// Token: 0x04012A37 RID: 76343
		private static IntPtr _ScriptStructPtr;
	}
}
