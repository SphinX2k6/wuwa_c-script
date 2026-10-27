using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001803 RID: 6147
	[UnrealObjectPath("/Script/KuroDynamicAtlas.DynamicAtlasSlotManagedHandle")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FDynamicAtlasSlotManagedHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06016C10 RID: 93200 RVA: 0x002135AB File Offset: 0x002117AB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDynamicAtlasSlotManagedHandle._ScriptStructPtr != 0) ? FDynamicAtlasSlotManagedHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroDynamicAtlas.DynamicAtlasSlotManagedHandle", ref FDynamicAtlasSlotManagedHandle._ScriptStructPtr);
		}

		// Token: 0x06016C11 RID: 93201 RVA: 0x002135CF File Offset: 0x002117CF
		public FDynamicAtlasSlotManagedHandle()
		{
		}

		// Token: 0x06016C12 RID: 93202 RVA: 0x002135D7 File Offset: 0x002117D7
		protected override IntPtr GetUStructPtr()
		{
			return FDynamicAtlasSlotManagedHandle.StaticStruct();
		}

		// Token: 0x06016C13 RID: 93203 RVA: 0x002135E3 File Offset: 0x002117E3
		[NullableContext(2)]
		public FDynamicAtlasSlotManagedHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06016C14 RID: 93204 RVA: 0x002135ED File Offset: 0x002117ED
		public FDynamicAtlasSlotManagedHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06016C15 RID: 93205 RVA: 0x002135F8 File Offset: 0x002117F8
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDynamicAtlasSlotManagedHandle(Pointer, false, true);
		}

		// Token: 0x06016C16 RID: 93206 RVA: 0x00213602 File Offset: 0x00211802
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDynamicAtlasSlotManagedHandle(Pointer, MemoryOwner);
		}

		// Token: 0x0400C594 RID: 50580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroDynamicAtlas.DynamicAtlasSlotManagedHandle";

		// Token: 0x0400C595 RID: 50581
		private static IntPtr _ScriptStructPtr;
	}
}
