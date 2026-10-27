using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008EB RID: 2283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.BPEditorBookmarkNode")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FBPEditorBookmarkNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007D37 RID: 32055 RVA: 0x000B378D File Offset: 0x000B198D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBPEditorBookmarkNode._ScriptStructPtr != 0) ? FBPEditorBookmarkNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BPEditorBookmarkNode", ref FBPEditorBookmarkNode._ScriptStructPtr);
		}

		// Token: 0x17001D66 RID: 7526
		// (get) Token: 0x06007D38 RID: 32056 RVA: 0x000B37B1 File Offset: 0x000B19B1
		// (set) Token: 0x06007D39 RID: 32057 RVA: 0x000B37C5 File Offset: 0x000B19C5
		public unsafe FGuid NodeGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPEditorBookmarkNode.__PropertyOffset_NodeGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPEditorBookmarkNode.__PropertyOffset_NodeGuid) = value;
			}
		}

		// Token: 0x17001D67 RID: 7527
		// (get) Token: 0x06007D3A RID: 32058 RVA: 0x000B37DA File Offset: 0x000B19DA
		// (set) Token: 0x06007D3B RID: 32059 RVA: 0x000B37EE File Offset: 0x000B19EE
		public unsafe FGuid ParentGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBPEditorBookmarkNode.__PropertyOffset_ParentGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBPEditorBookmarkNode.__PropertyOffset_ParentGuid) = value;
			}
		}

		// Token: 0x17001D68 RID: 7528
		// (get) Token: 0x06007D3C RID: 32060 RVA: 0x000B3804 File Offset: 0x000B1A04
		// (set) Token: 0x06007D3D RID: 32061 RVA: 0x000B3847 File Offset: 0x000B1A47
		public unsafe FText DisplayName
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._DisplayName) == null)
				{
					result = (this._DisplayName = new FText(base.NativePtr + (IntPtr)FBPEditorBookmarkNode.__PropertyOffset_DisplayName, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FBPEditorBookmarkNode.__PropertyOffset_DisplayName)), value.NativePtr, 1);
			}
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x000B3862 File Offset: 0x000B1A62
		public FBPEditorBookmarkNode()
		{
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x000B386A File Offset: 0x000B1A6A
		public FBPEditorBookmarkNode(FGuid NodeGuid, FGuid ParentGuid, FText DisplayName)
		{
			this.NodeGuid = NodeGuid;
			this.ParentGuid = ParentGuid;
			this.DisplayName = DisplayName;
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x000B3887 File Offset: 0x000B1A87
		protected override IntPtr GetUStructPtr()
		{
			return FBPEditorBookmarkNode.StaticStruct();
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x000B3893 File Offset: 0x000B1A93
		[NullableContext(2)]
		public FBPEditorBookmarkNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x000B389D File Offset: 0x000B1A9D
		public FBPEditorBookmarkNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x000B38A8 File Offset: 0x000B1AA8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBPEditorBookmarkNode(Pointer, false, true);
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x000B38B2 File Offset: 0x000B1AB2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBPEditorBookmarkNode(Pointer, MemoryOwner);
		}

		// Token: 0x04003C01 RID: 15361
		public const string __ObjectPath = "/Script/Engine.BPEditorBookmarkNode";

		// Token: 0x04003C02 RID: 15362
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003C03 RID: 15363
		internal static int __PropertyOffset_NodeGuid;

		// Token: 0x04003C04 RID: 15364
		internal static int __PropertyOffset_ParentGuid;

		// Token: 0x04003C05 RID: 15365
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x04003C06 RID: 15366
		[Nullable(2)]
		private FText _DisplayName;
	}
}
