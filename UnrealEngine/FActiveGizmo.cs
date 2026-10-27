using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001532 RID: 5426
	[UnrealObjectPath("/Script/InteractiveToolsFramework.ActiveGizmo")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FActiveGizmo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06013B3F RID: 80703 RVA: 0x001CEFE9 File Offset: 0x001CD1E9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FActiveGizmo._ScriptStructPtr != 0) ? FActiveGizmo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/InteractiveToolsFramework.ActiveGizmo", ref FActiveGizmo._ScriptStructPtr);
		}

		// Token: 0x06013B40 RID: 80704 RVA: 0x001CF00D File Offset: 0x001CD20D
		public FActiveGizmo()
		{
		}

		// Token: 0x06013B41 RID: 80705 RVA: 0x001CF015 File Offset: 0x001CD215
		protected override IntPtr GetUStructPtr()
		{
			return FActiveGizmo.StaticStruct();
		}

		// Token: 0x06013B42 RID: 80706 RVA: 0x001CF021 File Offset: 0x001CD221
		[NullableContext(2)]
		public FActiveGizmo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06013B43 RID: 80707 RVA: 0x001CF02B File Offset: 0x001CD22B
		public FActiveGizmo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06013B44 RID: 80708 RVA: 0x001CF036 File Offset: 0x001CD236
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FActiveGizmo(Pointer, false, true);
		}

		// Token: 0x06013B45 RID: 80709 RVA: 0x001CF040 File Offset: 0x001CD240
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FActiveGizmo(Pointer, MemoryOwner);
		}

		// Token: 0x0400AA8A RID: 43658
		[Nullable(1)]
		public const string __ObjectPath = "/Script/InteractiveToolsFramework.ActiveGizmo";

		// Token: 0x0400AA8B RID: 43659
		private static IntPtr _ScriptStructPtr;
	}
}
