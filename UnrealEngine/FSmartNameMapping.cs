using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200111E RID: 4382
	[UnrealObjectPath("/Script/Engine.SmartNameMapping")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FSmartNameMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010010 RID: 65552 RVA: 0x001790EA File Offset: 0x001772EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSmartNameMapping._ScriptStructPtr != 0) ? FSmartNameMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SmartNameMapping", ref FSmartNameMapping._ScriptStructPtr);
		}

		// Token: 0x06010011 RID: 65553 RVA: 0x0017910E File Offset: 0x0017730E
		public FSmartNameMapping()
		{
		}

		// Token: 0x06010012 RID: 65554 RVA: 0x00179116 File Offset: 0x00177316
		protected override IntPtr GetUStructPtr()
		{
			return FSmartNameMapping.StaticStruct();
		}

		// Token: 0x06010013 RID: 65555 RVA: 0x00179122 File Offset: 0x00177322
		[NullableContext(2)]
		public FSmartNameMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010014 RID: 65556 RVA: 0x0017912C File Offset: 0x0017732C
		public FSmartNameMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010015 RID: 65557 RVA: 0x00179137 File Offset: 0x00177337
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSmartNameMapping(Pointer, false, true);
		}

		// Token: 0x06010016 RID: 65558 RVA: 0x00179141 File Offset: 0x00177341
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSmartNameMapping(Pointer, MemoryOwner);
		}

		// Token: 0x04008992 RID: 35218
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SmartNameMapping";

		// Token: 0x04008993 RID: 35219
		private static IntPtr _ScriptStructPtr;
	}
}
