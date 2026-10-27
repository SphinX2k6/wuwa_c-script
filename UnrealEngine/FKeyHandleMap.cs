using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CCA RID: 3274
	[UnrealObjectPath("/Script/Engine.KeyHandleMap")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 96)]
	public class FKeyHandleMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A57E RID: 42366 RVA: 0x000EB780 File Offset: 0x000E9980
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKeyHandleMap._ScriptStructPtr != 0) ? FKeyHandleMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KeyHandleMap", ref FKeyHandleMap._ScriptStructPtr);
		}

		// Token: 0x0600A57F RID: 42367 RVA: 0x000EB7A4 File Offset: 0x000E99A4
		public FKeyHandleMap()
		{
		}

		// Token: 0x0600A580 RID: 42368 RVA: 0x000EB7AC File Offset: 0x000E99AC
		protected override IntPtr GetUStructPtr()
		{
			return FKeyHandleMap.StaticStruct();
		}

		// Token: 0x0600A581 RID: 42369 RVA: 0x000EB7B8 File Offset: 0x000E99B8
		[NullableContext(2)]
		public FKeyHandleMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A582 RID: 42370 RVA: 0x000EB7C2 File Offset: 0x000E99C2
		public FKeyHandleMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A583 RID: 42371 RVA: 0x000EB7CD File Offset: 0x000E99CD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKeyHandleMap(Pointer, false, true);
		}

		// Token: 0x0600A584 RID: 42372 RVA: 0x000EB7D7 File Offset: 0x000E99D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKeyHandleMap(Pointer, MemoryOwner);
		}

		// Token: 0x04005B0C RID: 23308
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.KeyHandleMap";

		// Token: 0x04005B0D RID: 23309
		private static IntPtr _ScriptStructPtr;
	}
}
