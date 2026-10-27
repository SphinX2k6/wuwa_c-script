using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001020 RID: 4128
	[UnrealObjectPath("/Script/Engine.PoseLinkBase")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FPoseLinkBase : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E1DA RID: 57818 RVA: 0x0014BED1 File Offset: 0x0014A0D1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPoseLinkBase._ScriptStructPtr != 0) ? FPoseLinkBase._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PoseLinkBase", ref FPoseLinkBase._ScriptStructPtr);
		}

		// Token: 0x17003508 RID: 13576
		// (get) Token: 0x0600E1DB RID: 57819 RVA: 0x0014BEF5 File Offset: 0x0014A0F5
		// (set) Token: 0x0600E1DC RID: 57820 RVA: 0x0014BF05 File Offset: 0x0014A105
		public unsafe int LinkID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPoseLinkBase.__PropertyOffset_LinkID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPoseLinkBase.__PropertyOffset_LinkID) = value;
			}
		}

		// Token: 0x0600E1DD RID: 57821 RVA: 0x0014BF16 File Offset: 0x0014A116
		public FPoseLinkBase()
		{
		}

		// Token: 0x0600E1DE RID: 57822 RVA: 0x0014BF1E File Offset: 0x0014A11E
		public FPoseLinkBase(int LinkID, int SourceLinkID)
		{
			this.LinkID = LinkID;
		}

		// Token: 0x0600E1DF RID: 57823 RVA: 0x0014BF2D File Offset: 0x0014A12D
		protected override IntPtr GetUStructPtr()
		{
			return FPoseLinkBase.StaticStruct();
		}

		// Token: 0x0600E1E0 RID: 57824 RVA: 0x0014BF39 File Offset: 0x0014A139
		[NullableContext(2)]
		public FPoseLinkBase(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E1E1 RID: 57825 RVA: 0x0014BF43 File Offset: 0x0014A143
		public FPoseLinkBase(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E1E2 RID: 57826 RVA: 0x0014BF4E File Offset: 0x0014A14E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPoseLinkBase(Pointer, false, true);
		}

		// Token: 0x0600E1E3 RID: 57827 RVA: 0x0014BF58 File Offset: 0x0014A158
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPoseLinkBase(Pointer, MemoryOwner);
		}

		// Token: 0x0400793B RID: 31035
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PoseLinkBase";

		// Token: 0x0400793C RID: 31036
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400793D RID: 31037
		internal static int __PropertyOffset_LinkID;
	}
}
