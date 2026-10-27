using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017A9 RID: 6057
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSClothInstance_staticBatchCloth")]
	[UnrealStructLayout(288, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 288)]
	public class FKuroCSClothInstance_staticBatchCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015E8E RID: 89742 RVA: 0x00202487 File Offset: 0x00200687
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSClothInstance_staticBatchCloth._ScriptStructPtr != 0) ? FKuroCSClothInstance_staticBatchCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSClothInstance_staticBatchCloth", ref FKuroCSClothInstance_staticBatchCloth._ScriptStructPtr);
		}

		// Token: 0x06015E8F RID: 89743 RVA: 0x002024AB File Offset: 0x002006AB
		public FKuroCSClothInstance_staticBatchCloth()
		{
		}

		// Token: 0x06015E90 RID: 89744 RVA: 0x002024B3 File Offset: 0x002006B3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSClothInstance_staticBatchCloth.StaticStruct();
		}

		// Token: 0x06015E91 RID: 89745 RVA: 0x002024BF File Offset: 0x002006BF
		[NullableContext(2)]
		public FKuroCSClothInstance_staticBatchCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015E92 RID: 89746 RVA: 0x002024C9 File Offset: 0x002006C9
		public FKuroCSClothInstance_staticBatchCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015E93 RID: 89747 RVA: 0x002024D4 File Offset: 0x002006D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSClothInstance_staticBatchCloth(Pointer, false, true);
		}

		// Token: 0x06015E94 RID: 89748 RVA: 0x002024DE File Offset: 0x002006DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSClothInstance_staticBatchCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400BF12 RID: 48914
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSClothInstance_staticBatchCloth";

		// Token: 0x0400BF13 RID: 48915
		private static IntPtr _ScriptStructPtr;
	}
}
