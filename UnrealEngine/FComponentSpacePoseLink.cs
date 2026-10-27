using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000963 RID: 2403
	[UnrealObjectPath("/Script/Engine.ComponentSpacePoseLink")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FComponentSpacePoseLink : FPoseLinkBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060087C4 RID: 34756 RVA: 0x000C2763 File Offset: 0x000C0963
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentSpacePoseLink._ScriptStructPtr != 0) ? FComponentSpacePoseLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentSpacePoseLink", ref FComponentSpacePoseLink._ScriptStructPtr);
		}

		// Token: 0x060087C5 RID: 34757 RVA: 0x000C2787 File Offset: 0x000C0987
		public FComponentSpacePoseLink()
		{
		}

		// Token: 0x060087C6 RID: 34758 RVA: 0x000C278F File Offset: 0x000C098F
		public FComponentSpacePoseLink(int LinkID, int SourceLinkID)
		{
			base.LinkID = LinkID;
		}

		// Token: 0x060087C7 RID: 34759 RVA: 0x000C279E File Offset: 0x000C099E
		protected override IntPtr GetUStructPtr()
		{
			return FComponentSpacePoseLink.StaticStruct();
		}

		// Token: 0x060087C8 RID: 34760 RVA: 0x000C27AA File Offset: 0x000C09AA
		[NullableContext(2)]
		public FComponentSpacePoseLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060087C9 RID: 34761 RVA: 0x000C27B4 File Offset: 0x000C09B4
		public FComponentSpacePoseLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060087CA RID: 34762 RVA: 0x000C27BF File Offset: 0x000C09BF
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentSpacePoseLink(Pointer, false, true);
		}

		// Token: 0x060087CB RID: 34763 RVA: 0x000C27C9 File Offset: 0x000C09C9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentSpacePoseLink(Pointer, MemoryOwner);
		}

		// Token: 0x0400408B RID: 16523
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ComponentSpacePoseLink";

		// Token: 0x0400408C RID: 16524
		private static IntPtr _ScriptStructPtr;
	}
}
