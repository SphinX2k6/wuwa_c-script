using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200081E RID: 2078
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AnimNode_SaveCachedPose")]
	[UnrealStructLayout(432, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 432)]
	public class FAnimNode_SaveCachedPose : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006FBE RID: 28606 RVA: 0x000A05D3 File Offset: 0x0009E7D3
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_SaveCachedPose._ScriptStructPtr != 0) ? FAnimNode_SaveCachedPose._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNode_SaveCachedPose", ref FAnimNode_SaveCachedPose._ScriptStructPtr);
		}

		// Token: 0x17001A49 RID: 6729
		// (get) Token: 0x06006FBF RID: 28607 RVA: 0x000A05F8 File Offset: 0x0009E7F8
		// (set) Token: 0x06006FC0 RID: 28608 RVA: 0x000A063B File Offset: 0x0009E83B
		public FPoseLink Pose
		{
			get
			{
				base.FastCheckIsValid();
				FPoseLink result;
				if ((result = this._Pose) == null)
				{
					result = (this._Pose = new FPoseLink(base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_Pose, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FPoseLink.StaticStruct(), base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_Pose, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A4A RID: 6730
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x000A065C File Offset: 0x0009E85C
		// (set) Token: 0x06006FC2 RID: 28610 RVA: 0x000A0670 File Offset: 0x0009E870
		public unsafe FName CachePoseName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_CachePoseName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_CachePoseName) = value;
			}
		}

		// Token: 0x17001A4B RID: 6731
		// (get) Token: 0x06006FC3 RID: 28611 RVA: 0x000A0685 File Offset: 0x0009E885
		// (set) Token: 0x06006FC4 RID: 28612 RVA: 0x000A0695 File Offset: 0x0009E895
		public unsafe bool OpenReInitialize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_OpenReInitialize) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_SaveCachedPose.__PropertyOffset_OpenReInitialize) = (value ? 1 : 0);
			}
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x000A06A6 File Offset: 0x0009E8A6
		public FAnimNode_SaveCachedPose()
		{
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x000A06AE File Offset: 0x0009E8AE
		public FAnimNode_SaveCachedPose(FPoseLink Pose, FName CachePoseName, bool OpenReInitialize)
		{
			this.Pose = Pose;
			this.CachePoseName = CachePoseName;
			this.OpenReInitialize = OpenReInitialize;
		}

		// Token: 0x06006FC7 RID: 28615 RVA: 0x000A06CB File Offset: 0x0009E8CB
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_SaveCachedPose.StaticStruct();
		}

		// Token: 0x06006FC8 RID: 28616 RVA: 0x000A06D7 File Offset: 0x0009E8D7
		[NullableContext(2)]
		public FAnimNode_SaveCachedPose(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x000A06E1 File Offset: 0x0009E8E1
		public FAnimNode_SaveCachedPose(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006FCA RID: 28618 RVA: 0x000A06EC File Offset: 0x0009E8EC
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_SaveCachedPose(Pointer, false, true);
		}

		// Token: 0x06006FCB RID: 28619 RVA: 0x000A06F6 File Offset: 0x0009E8F6
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_SaveCachedPose(Pointer, MemoryOwner);
		}

		// Token: 0x040035B2 RID: 13746
		public new const string __ObjectPath = "/Script/Engine.AnimNode_SaveCachedPose";

		// Token: 0x040035B3 RID: 13747
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035B4 RID: 13748
		internal static int __PropertyOffset_Pose;

		// Token: 0x040035B5 RID: 13749
		[Nullable(2)]
		private FPoseLink _Pose;

		// Token: 0x040035B6 RID: 13750
		internal static int __PropertyOffset_CachePoseName;

		// Token: 0x040035B7 RID: 13751
		internal static int __PropertyOffset_OpenReInitialize;
	}
}
