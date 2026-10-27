using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CC9 RID: 3273
	[UnrealObjectPath("/Script/Engine.KeyHandleLookupTable")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKeyHandleLookupTable : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A577 RID: 42359 RVA: 0x000EB720 File Offset: 0x000E9920
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKeyHandleLookupTable._ScriptStructPtr != 0) ? FKeyHandleLookupTable._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KeyHandleLookupTable", ref FKeyHandleLookupTable._ScriptStructPtr);
		}

		// Token: 0x0600A578 RID: 42360 RVA: 0x000EB744 File Offset: 0x000E9944
		public FKeyHandleLookupTable()
		{
		}

		// Token: 0x0600A579 RID: 42361 RVA: 0x000EB74C File Offset: 0x000E994C
		protected override IntPtr GetUStructPtr()
		{
			return FKeyHandleLookupTable.StaticStruct();
		}

		// Token: 0x0600A57A RID: 42362 RVA: 0x000EB758 File Offset: 0x000E9958
		[NullableContext(2)]
		public FKeyHandleLookupTable(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A57B RID: 42363 RVA: 0x000EB762 File Offset: 0x000E9962
		public FKeyHandleLookupTable(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A57C RID: 42364 RVA: 0x000EB76D File Offset: 0x000E996D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKeyHandleLookupTable(Pointer, false, true);
		}

		// Token: 0x0600A57D RID: 42365 RVA: 0x000EB777 File Offset: 0x000E9977
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKeyHandleLookupTable(Pointer, MemoryOwner);
		}

		// Token: 0x04005B0A RID: 23306
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KeyHandleLookupTable";

		// Token: 0x04005B0B RID: 23307
		private static IntPtr _ScriptStructPtr;
	}
}
