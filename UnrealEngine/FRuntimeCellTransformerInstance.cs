using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010AB RID: 4267
	[UnrealObjectPath("/Script/Engine.RuntimeCellTransformerInstance")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRuntimeCellTransformerInstance : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3F5 RID: 62453 RVA: 0x00169D5B File Offset: 0x00167F5B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRuntimeCellTransformerInstance._ScriptStructPtr != 0) ? FRuntimeCellTransformerInstance._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RuntimeCellTransformerInstance", ref FRuntimeCellTransformerInstance._ScriptStructPtr);
		}

		// Token: 0x0600F3F6 RID: 62454 RVA: 0x00169D7F File Offset: 0x00167F7F
		public FRuntimeCellTransformerInstance()
		{
		}

		// Token: 0x0600F3F7 RID: 62455 RVA: 0x00169D87 File Offset: 0x00167F87
		[NullableContext(1)]
		public FRuntimeCellTransformerInstance([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UWorldPartitionRuntimeCellTransformer> Class, UWorldPartitionRuntimeCellTransformer Instance)
		{
		}

		// Token: 0x0600F3F8 RID: 62456 RVA: 0x00169D8F File Offset: 0x00167F8F
		protected override IntPtr GetUStructPtr()
		{
			return FRuntimeCellTransformerInstance.StaticStruct();
		}

		// Token: 0x0600F3F9 RID: 62457 RVA: 0x00169D9B File Offset: 0x00167F9B
		[NullableContext(2)]
		public FRuntimeCellTransformerInstance(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3FA RID: 62458 RVA: 0x00169DA5 File Offset: 0x00167FA5
		public FRuntimeCellTransformerInstance(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3FB RID: 62459 RVA: 0x00169DB0 File Offset: 0x00167FB0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRuntimeCellTransformerInstance(Pointer, false, true);
		}

		// Token: 0x0600F3FC RID: 62460 RVA: 0x00169DBA File Offset: 0x00167FBA
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRuntimeCellTransformerInstance(Pointer, MemoryOwner);
		}

		// Token: 0x0400843B RID: 33851
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.RuntimeCellTransformerInstance";

		// Token: 0x0400843C RID: 33852
		private static IntPtr _ScriptStructPtr;
	}
}
