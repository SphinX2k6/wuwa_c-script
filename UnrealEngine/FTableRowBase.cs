using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000296 RID: 662
	[UnrealObjectPath("/Script/Engine.TableRowBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTableRowBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600490C RID: 18700 RVA: 0x0006677C File Offset: 0x0006497C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTableRowBase._ScriptStructPtr != 0) ? FTableRowBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TableRowBase", ref FTableRowBase._ScriptStructPtr);
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x000667A0 File Offset: 0x000649A0
		public FTableRowBase()
		{
		}

		// Token: 0x0600490E RID: 18702 RVA: 0x000667A8 File Offset: 0x000649A8
		protected override IntPtr GetUStructPtr()
		{
			return FTableRowBase.StaticStruct();
		}

		// Token: 0x0600490F RID: 18703 RVA: 0x000667B4 File Offset: 0x000649B4
		[NullableContext(2)]
		public FTableRowBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004910 RID: 18704 RVA: 0x000667BE File Offset: 0x000649BE
		public FTableRowBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004911 RID: 18705 RVA: 0x000667C9 File Offset: 0x000649C9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTableRowBase(Pointer, false, true);
		}

		// Token: 0x06004912 RID: 18706 RVA: 0x000667D3 File Offset: 0x000649D3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTableRowBase(Pointer, MemoryOwner);
		}

		// Token: 0x04001C65 RID: 7269
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TableRowBase";

		// Token: 0x04001C66 RID: 7270
		private static IntPtr _ScriptStructPtr;
	}
}
