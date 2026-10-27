using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C46 RID: 3142
	[UnrealObjectPath("/Script/Engine.InertializationBoneDiff")]
	[UnrealStructLayout(60, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 60)]
	public class FInertializationBoneDiff : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009F73 RID: 40819 RVA: 0x000E29CB File Offset: 0x000E0BCB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInertializationBoneDiff._ScriptStructPtr != 0) ? FInertializationBoneDiff._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InertializationBoneDiff", ref FInertializationBoneDiff._ScriptStructPtr);
		}

		// Token: 0x06009F74 RID: 40820 RVA: 0x000E29EF File Offset: 0x000E0BEF
		public FInertializationBoneDiff()
		{
		}

		// Token: 0x06009F75 RID: 40821 RVA: 0x000E29F7 File Offset: 0x000E0BF7
		protected override IntPtr GetUStructPtr()
		{
			return FInertializationBoneDiff.StaticStruct();
		}

		// Token: 0x06009F76 RID: 40822 RVA: 0x000E2A03 File Offset: 0x000E0C03
		[NullableContext(2)]
		public FInertializationBoneDiff(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009F77 RID: 40823 RVA: 0x000E2A0D File Offset: 0x000E0C0D
		public FInertializationBoneDiff(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009F78 RID: 40824 RVA: 0x000E2A18 File Offset: 0x000E0C18
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInertializationBoneDiff(Pointer, false, true);
		}

		// Token: 0x06009F79 RID: 40825 RVA: 0x000E2A22 File Offset: 0x000E0C22
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInertializationBoneDiff(Pointer, MemoryOwner);
		}

		// Token: 0x040057C1 RID: 22465
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.InertializationBoneDiff";

		// Token: 0x040057C2 RID: 22466
		private static IntPtr _ScriptStructPtr;
	}
}
