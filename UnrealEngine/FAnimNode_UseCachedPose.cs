using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000824 RID: 2084
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_UseCachedPose")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FAnimNode_UseCachedPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600701A RID: 28698 RVA: 0x000A0D26 File Offset: 0x0009EF26
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_UseCachedPose._ScriptStructPtr != 0) ? FAnimNode_UseCachedPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_UseCachedPose", ref FAnimNode_UseCachedPose._ScriptStructPtr);
		}

		// Token: 0x17001A5F RID: 6751
		// (get) Token: 0x0600701B RID: 28699 RVA: 0x000A0D4C File Offset: 0x0009EF4C
		// (set) Token: 0x0600701C RID: 28700 RVA: 0x000A0D8F File Offset: 0x0009EF8F
		public FPoseLink LinkToCachingNode
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._LinkToCachingNode) == null)
				{
					result = (this._LinkToCachingNode = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_UseCachedPose.__PropertyOffset_LinkToCachingNode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_UseCachedPose.__PropertyOffset_LinkToCachingNode, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A60 RID: 6752
		// (get) Token: 0x0600701D RID: 28701 RVA: 0x000A0DB0 File Offset: 0x0009EFB0
		// (set) Token: 0x0600701E RID: 28702 RVA: 0x000A0DC4 File Offset: 0x0009EFC4
		public unsafe FName CachePoseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_UseCachedPose.__PropertyOffset_CachePoseName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_UseCachedPose.__PropertyOffset_CachePoseName) = value;
			}
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x000A0DD9 File Offset: 0x0009EFD9
		public FAnimNode_UseCachedPose()
		{
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x000A0DE1 File Offset: 0x0009EFE1
		public FAnimNode_UseCachedPose(FPoseLink LinkToCachingNode, FName CachePoseName)
		{
			this.LinkToCachingNode = LinkToCachingNode;
			this.CachePoseName = CachePoseName;
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x000A0DF7 File Offset: 0x0009EFF7
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_UseCachedPose.StaticStruct();
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x000A0E03 File Offset: 0x0009F003
		[NullableContext(2)]
		public FAnimNode_UseCachedPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x000A0E0D File Offset: 0x0009F00D
		public FAnimNode_UseCachedPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x000A0E18 File Offset: 0x0009F018
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_UseCachedPose(Pointer, false, true);
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x000A0E22 File Offset: 0x0009F022
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_UseCachedPose(Pointer, MemoryOwner);
		}

		// Token: 0x040035D7 RID: 13783
		public new const string __ObjectPath = "/Script/Engine.AnimNode_UseCachedPose";

		// Token: 0x040035D8 RID: 13784
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035D9 RID: 13785
		internal static int __PropertyOffset_LinkToCachingNode;

		// Token: 0x040035DA RID: 13786
		[Nullable(2)]
		private FPoseLink _LinkToCachingNode;

		// Token: 0x040035DB RID: 13787
		internal static int __PropertyOffset_CachePoseName;
	}
}
