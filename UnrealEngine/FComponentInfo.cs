using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000959 RID: 2393
	[UnrealObjectPath("/Script/Engine.ComponentInfo")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FComponentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008753 RID: 34643 RVA: 0x000C196A File Offset: 0x000BFB6A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FComponentInfo._ScriptStructPtr != 0) ? FComponentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ComponentInfo", ref FComponentInfo._ScriptStructPtr);
		}

		// Token: 0x17001FFD RID: 8189
		// (get) Token: 0x06008754 RID: 34644 RVA: 0x000C198E File Offset: 0x000BFB8E
		// (set) Token: 0x06008755 RID: 34645 RVA: 0x000C19A2 File Offset: 0x000BFBA2
		public unsafe FName CompName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentInfo.__PropertyOffset_CompName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentInfo.__PropertyOffset_CompName) = value;
			}
		}

		// Token: 0x17001FFE RID: 8190
		// (get) Token: 0x06008756 RID: 34646 RVA: 0x000C19B7 File Offset: 0x000BFBB7
		// (set) Token: 0x06008757 RID: 34647 RVA: 0x000C19C7 File Offset: 0x000BFBC7
		public unsafe int VisibilityId
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FComponentInfo.__PropertyOffset_VisibilityId);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FComponentInfo.__PropertyOffset_VisibilityId) = value;
			}
		}

		// Token: 0x06008758 RID: 34648 RVA: 0x000C19D8 File Offset: 0x000BFBD8
		public FComponentInfo()
		{
		}

		// Token: 0x06008759 RID: 34649 RVA: 0x000C19E0 File Offset: 0x000BFBE0
		public FComponentInfo(FName CompName, int VisibilityId)
		{
			this.CompName = CompName;
			this.VisibilityId = VisibilityId;
		}

		// Token: 0x0600875A RID: 34650 RVA: 0x000C19F6 File Offset: 0x000BFBF6
		protected override IntPtr GetUStructPtr()
		{
			return FComponentInfo.StaticStruct();
		}

		// Token: 0x0600875B RID: 34651 RVA: 0x000C1A02 File Offset: 0x000BFC02
		[NullableContext(2)]
		public FComponentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600875C RID: 34652 RVA: 0x000C1A0C File Offset: 0x000BFC0C
		public FComponentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600875D RID: 34653 RVA: 0x000C1A17 File Offset: 0x000BFC17
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FComponentInfo(Pointer, false, true);
		}

		// Token: 0x0600875E RID: 34654 RVA: 0x000C1A21 File Offset: 0x000BFC21
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FComponentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04004060 RID: 16480
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ComponentInfo";

		// Token: 0x04004061 RID: 16481
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04004062 RID: 16482
		internal static int __PropertyOffset_CompName;

		// Token: 0x04004063 RID: 16483
		internal static int __PropertyOffset_VisibilityId;
	}
}
