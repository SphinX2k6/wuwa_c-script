using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC0 RID: 3264
	[UnrealObjectPath("/Script/Engine.ISMComponentData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FISMComponentData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4FF RID: 42239 RVA: 0x000EABA4 File Offset: 0x000E8DA4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMComponentData._ScriptStructPtr != 0) ? FISMComponentData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMComponentData", ref FISMComponentData._ScriptStructPtr);
		}

		// Token: 0x0600A500 RID: 42240 RVA: 0x000EABC8 File Offset: 0x000E8DC8
		public FISMComponentData()
		{
		}

		// Token: 0x0600A501 RID: 42241 RVA: 0x000EABD0 File Offset: 0x000E8DD0
		[NullableContext(1)]
		public FISMComponentData(TArray<FISMComponentInstance> Instances, TArray<FISMClientData> ClientInstances, UInstancedStaticMeshComponent Component)
		{
		}

		// Token: 0x0600A502 RID: 42242 RVA: 0x000EABD8 File Offset: 0x000E8DD8
		protected override IntPtr GetUStructPtr()
		{
			return FISMComponentData.StaticStruct();
		}

		// Token: 0x0600A503 RID: 42243 RVA: 0x000EABE4 File Offset: 0x000E8DE4
		[NullableContext(2)]
		public FISMComponentData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A504 RID: 42244 RVA: 0x000EABEE File Offset: 0x000E8DEE
		public FISMComponentData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A505 RID: 42245 RVA: 0x000EABF9 File Offset: 0x000E8DF9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMComponentData(Pointer, false, true);
		}

		// Token: 0x0600A506 RID: 42246 RVA: 0x000EAC03 File Offset: 0x000E8E03
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMComponentData(Pointer, MemoryOwner);
		}

		// Token: 0x04005AC9 RID: 23241
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ISMComponentData";

		// Token: 0x04005ACA RID: 23242
		private static IntPtr _ScriptStructPtr;
	}
}
