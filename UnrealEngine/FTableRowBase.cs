using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011C0 RID: 4544
	[UnrealObjectPath("/Script/Engine.TableRowBase")]
	[UnrealStructLayout(8, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTableRowBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010C0C RID: 68620 RVA: 0x0018971D File Offset: 0x0018791D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTableRowBase._ScriptStructPtr != 0) ? FTableRowBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TableRowBase", ref FTableRowBase._ScriptStructPtr);
		}

		// Token: 0x06010C0D RID: 68621 RVA: 0x00189741 File Offset: 0x00187941
		public FTableRowBase()
		{
		}

		// Token: 0x06010C0E RID: 68622 RVA: 0x00189749 File Offset: 0x00187949
		protected override IntPtr GetUStructPtr()
		{
			return FTableRowBase.StaticStruct();
		}

		// Token: 0x06010C0F RID: 68623 RVA: 0x00189755 File Offset: 0x00187955
		[NullableContext(2)]
		public FTableRowBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010C10 RID: 68624 RVA: 0x0018975F File Offset: 0x0018795F
		public FTableRowBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010C11 RID: 68625 RVA: 0x0018976A File Offset: 0x0018796A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTableRowBase(Pointer, false, true);
		}

		// Token: 0x06010C12 RID: 68626 RVA: 0x00189774 File Offset: 0x00187974
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTableRowBase(Pointer, MemoryOwner);
		}

		// Token: 0x04008F45 RID: 36677
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TableRowBase";

		// Token: 0x04008F46 RID: 36678
		private static IntPtr _ScriptStructPtr;
	}
}
