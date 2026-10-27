using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020017A8 RID: 6056
	[UnrealObjectPath("/Script/KuroComputeShader.KuroCSClothInstance_jacobiCloth")]
	[UnrealStructLayout(144, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FKuroCSClothInstance_jacobiCloth : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015E87 RID: 89735 RVA: 0x00202427 File Offset: 0x00200627
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCSClothInstance_jacobiCloth._ScriptStructPtr != 0) ? FKuroCSClothInstance_jacobiCloth._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.KuroCSClothInstance_jacobiCloth", ref FKuroCSClothInstance_jacobiCloth._ScriptStructPtr);
		}

		// Token: 0x06015E88 RID: 89736 RVA: 0x0020244B File Offset: 0x0020064B
		public FKuroCSClothInstance_jacobiCloth()
		{
		}

		// Token: 0x06015E89 RID: 89737 RVA: 0x00202453 File Offset: 0x00200653
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCSClothInstance_jacobiCloth.StaticStruct();
		}

		// Token: 0x06015E8A RID: 89738 RVA: 0x0020245F File Offset: 0x0020065F
		[NullableContext(2)]
		public FKuroCSClothInstance_jacobiCloth(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015E8B RID: 89739 RVA: 0x00202469 File Offset: 0x00200669
		public FKuroCSClothInstance_jacobiCloth(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015E8C RID: 89740 RVA: 0x00202474 File Offset: 0x00200674
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCSClothInstance_jacobiCloth(Pointer, false, true);
		}

		// Token: 0x06015E8D RID: 89741 RVA: 0x0020247E File Offset: 0x0020067E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCSClothInstance_jacobiCloth(Pointer, MemoryOwner);
		}

		// Token: 0x0400BF10 RID: 48912
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.KuroCSClothInstance_jacobiCloth";

		// Token: 0x0400BF11 RID: 48913
		private static IntPtr _ScriptStructPtr;
	}
}
