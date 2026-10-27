using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000820 RID: 2080
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_SingleNode")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAnimNode_SingleNode : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FE4 RID: 28644 RVA: 0x000A0978 File Offset: 0x0009EB78
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SingleNode._ScriptStructPtr != 0) ? FAnimNode_SingleNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_SingleNode", ref FAnimNode_SingleNode._ScriptStructPtr);
		}

		// Token: 0x17001A54 RID: 6740
		// (get) Token: 0x06006FE5 RID: 28645 RVA: 0x000A099C File Offset: 0x0009EB9C
		// (set) Token: 0x06006FE6 RID: 28646 RVA: 0x000A09DF File Offset: 0x0009EBDF
		public FPoseLink SourcePose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._SourcePose) == null)
				{
					result = (this._SourcePose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_SingleNode.__PropertyOffset_SourcePose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SingleNode.__PropertyOffset_SourcePose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x000A0A00 File Offset: 0x0009EC00
		public FAnimNode_SingleNode()
		{
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x000A0A08 File Offset: 0x0009EC08
		public FAnimNode_SingleNode(FPoseLink SourcePose)
		{
			this.SourcePose = SourcePose;
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x000A0A17 File Offset: 0x0009EC17
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SingleNode.StaticStruct();
		}

		// Token: 0x06006FEA RID: 28650 RVA: 0x000A0A23 File Offset: 0x0009EC23
		[NullableContext(2)]
		public FAnimNode_SingleNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x000A0A2D File Offset: 0x0009EC2D
		public FAnimNode_SingleNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FEC RID: 28652 RVA: 0x000A0A38 File Offset: 0x0009EC38
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SingleNode(Pointer, false, true);
		}

		// Token: 0x06006FED RID: 28653 RVA: 0x000A0A42 File Offset: 0x0009EC42
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SingleNode(Pointer, MemoryOwner);
		}

		// Token: 0x040035C3 RID: 13763
		public new const string __ObjectPath = "/Script/Engine.AnimNode_SingleNode";

		// Token: 0x040035C4 RID: 13764
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035C5 RID: 13765
		internal static int __PropertyOffset_SourcePose;

		// Token: 0x040035C6 RID: 13766
		[Nullable(2)]
		private FPoseLink _SourcePose;
	}
}
