using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200217E RID: 8574
	[UnrealObjectPath("/Script/LGUI.UIItemInfo")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FUIItemInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06020772 RID: 132978 RVA: 0x00301E38 File Offset: 0x00300038
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIItemInfo._ScriptStructPtr != 0) ? FUIItemInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIItemInfo", ref FUIItemInfo._ScriptStructPtr);
		}

		// Token: 0x06020773 RID: 132979 RVA: 0x00301E5C File Offset: 0x0030005C
		public FUIItemInfo()
		{
		}

		// Token: 0x06020774 RID: 132980 RVA: 0x00301E64 File Offset: 0x00300064
		[NullableContext(1)]
		public FUIItemInfo(string ClassNames, string ItemPath)
		{
		}

		// Token: 0x06020775 RID: 132981 RVA: 0x00301E6C File Offset: 0x0030006C
		protected override IntPtr GetUStructPtr()
		{
			return FUIItemInfo.StaticStruct();
		}

		// Token: 0x06020776 RID: 132982 RVA: 0x00301E78 File Offset: 0x00300078
		[NullableContext(2)]
		public FUIItemInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06020777 RID: 132983 RVA: 0x00301E82 File Offset: 0x00300082
		public FUIItemInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06020778 RID: 132984 RVA: 0x00301E8D File Offset: 0x0030008D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIItemInfo(Pointer, false, true);
		}

		// Token: 0x06020779 RID: 132985 RVA: 0x00301E97 File Offset: 0x00300097
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIItemInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011661 RID: 71265
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.UIItemInfo";

		// Token: 0x04011662 RID: 71266
		private static IntPtr _ScriptStructPtr;
	}
}
