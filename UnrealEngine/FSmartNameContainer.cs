using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200111D RID: 4381
	[UnrealObjectPath("/Script/Engine.SmartNameContainer")]
	[UnrealStructLayout(160, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 160)]
	public class FSmartNameContainer : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010009 RID: 65545 RVA: 0x0017908A File Offset: 0x0017728A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSmartNameContainer._ScriptStructPtr != 0) ? FSmartNameContainer._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SmartNameContainer", ref FSmartNameContainer._ScriptStructPtr);
		}

		// Token: 0x0601000A RID: 65546 RVA: 0x001790AE File Offset: 0x001772AE
		public FSmartNameContainer()
		{
		}

		// Token: 0x0601000B RID: 65547 RVA: 0x001790B6 File Offset: 0x001772B6
		protected override IntPtr GetUStructPtr()
		{
			return FSmartNameContainer.StaticStruct();
		}

		// Token: 0x0601000C RID: 65548 RVA: 0x001790C2 File Offset: 0x001772C2
		[NullableContext(2)]
		public FSmartNameContainer(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601000D RID: 65549 RVA: 0x001790CC File Offset: 0x001772CC
		public FSmartNameContainer(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601000E RID: 65550 RVA: 0x001790D7 File Offset: 0x001772D7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSmartNameContainer(Pointer, false, true);
		}

		// Token: 0x0601000F RID: 65551 RVA: 0x001790E1 File Offset: 0x001772E1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSmartNameContainer(Pointer, MemoryOwner);
		}

		// Token: 0x04008990 RID: 35216
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SmartNameContainer";

		// Token: 0x04008991 RID: 35217
		private static IntPtr _ScriptStructPtr;
	}
}
