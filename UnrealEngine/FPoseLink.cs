using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200101F RID: 4127
	[UnrealObjectPath("/Script/Engine.PoseLink")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPoseLink : FPoseLinkBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E1D2 RID: 57810 RVA: 0x0014BE62 File Offset: 0x0014A062
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseLink._ScriptStructPtr != 0) ? FPoseLink._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PoseLink", ref FPoseLink._ScriptStructPtr);
		}

		// Token: 0x0600E1D3 RID: 57811 RVA: 0x0014BE86 File Offset: 0x0014A086
		public FPoseLink()
		{
		}

		// Token: 0x0600E1D4 RID: 57812 RVA: 0x0014BE8E File Offset: 0x0014A08E
		public FPoseLink(int LinkID, int SourceLinkID)
		{
			base.LinkID = LinkID;
		}

		// Token: 0x0600E1D5 RID: 57813 RVA: 0x0014BE9D File Offset: 0x0014A09D
		protected override IntPtr GetUStructPtr()
		{
			return FPoseLink.StaticStruct();
		}

		// Token: 0x0600E1D6 RID: 57814 RVA: 0x0014BEA9 File Offset: 0x0014A0A9
		[NullableContext(2)]
		public FPoseLink(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E1D7 RID: 57815 RVA: 0x0014BEB3 File Offset: 0x0014A0B3
		public FPoseLink(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E1D8 RID: 57816 RVA: 0x0014BEBE File Offset: 0x0014A0BE
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseLink(Pointer, false, true);
		}

		// Token: 0x0600E1D9 RID: 57817 RVA: 0x0014BEC8 File Offset: 0x0014A0C8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseLink(Pointer, MemoryOwner);
		}

		// Token: 0x04007939 RID: 31033
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.PoseLink";

		// Token: 0x0400793A RID: 31034
		private static IntPtr _ScriptStructPtr;
	}
}
