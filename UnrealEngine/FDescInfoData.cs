using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020009B6 RID: 2486
	[UnrealObjectPath("/Script/Engine.DescInfoData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FDescInfoData : FTableRowBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008C8A RID: 35978 RVA: 0x000C9258 File Offset: 0x000C7458
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDescInfoData._ScriptStructPtr != 0) ? FDescInfoData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DescInfoData", ref FDescInfoData._ScriptStructPtr);
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x000C927C File Offset: 0x000C747C
		public FDescInfoData()
		{
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x000C9284 File Offset: 0x000C7484
		public FDescInfoData(FName ActorFullLable, FName ActorPathName, FGuid ActorGuid, FName HLODLable, FName DeletedHLODLabel)
		{
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x000C928C File Offset: 0x000C748C
		protected override IntPtr GetUStructPtr()
		{
			return FDescInfoData.StaticStruct();
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x000C9298 File Offset: 0x000C7498
		[NullableContext(2)]
		public FDescInfoData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x000C92A2 File Offset: 0x000C74A2
		public FDescInfoData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x000C92AD File Offset: 0x000C74AD
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDescInfoData(Pointer, false, true);
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x000C92B7 File Offset: 0x000C74B7
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDescInfoData(Pointer, MemoryOwner);
		}

		// Token: 0x040042B9 RID: 17081
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DescInfoData";

		// Token: 0x040042BA RID: 17082
		private static IntPtr _ScriptStructPtr;
	}
}
