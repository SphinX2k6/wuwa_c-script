using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002DD RID: 733
	[UnrealObjectPath("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 472)]
	public class FAnimNode_CopyPoseFromMesh : FAnimNode_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002950 RID: 10576 RVA: 0x0003E77C File Offset: 0x0003C97C
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNode_CopyPoseFromMesh._ScriptStructPtr != 0) ? FAnimNode_CopyPoseFromMesh._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh", ref FAnimNode_CopyPoseFromMesh._ScriptStructPtr);
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06002951 RID: 10577 RVA: 0x0003E7A0 File Offset: 0x0003C9A0
		// (set) Token: 0x06002952 RID: 10578 RVA: 0x0003E7B4 File Offset: 0x0003C9B4
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_SourceMeshComponent);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_SourceMeshComponent) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06002953 RID: 10579 RVA: 0x0003E7C9 File Offset: 0x0003C9C9
		// (set) Token: 0x06002954 RID: 10580 RVA: 0x0003E7E2 File Offset: 0x0003C9E2
		public unsafe bool bUseAttachedParent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseAttachedParent) & FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseAttachedParent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseAttachedParent) = ((*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseAttachedParent) & ~FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseAttachedParent) | (value ? FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseAttachedParent : 0));
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06002955 RID: 10581 RVA: 0x0003E812 File Offset: 0x0003CA12
		// (set) Token: 0x06002956 RID: 10582 RVA: 0x0003E82B File Offset: 0x0003CA2B
		public unsafe bool bCopyCurves
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bCopyCurves) & FAnimNode_CopyPoseFromMesh.__PropertyMask_bCopyCurves) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bCopyCurves) = ((*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bCopyCurves) & ~FAnimNode_CopyPoseFromMesh.__PropertyMask_bCopyCurves) | (value ? FAnimNode_CopyPoseFromMesh.__PropertyMask_bCopyCurves : 0));
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06002957 RID: 10583 RVA: 0x0003E85B File Offset: 0x0003CA5B
		// (set) Token: 0x06002958 RID: 10584 RVA: 0x0003E86B File Offset: 0x0003CA6B
		public unsafe bool bCopyCustomAttributes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bCopyCustomAttributes) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bCopyCustomAttributes) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06002959 RID: 10585 RVA: 0x0003E87C File Offset: 0x0003CA7C
		// (set) Token: 0x0600295A RID: 10586 RVA: 0x0003E895 File Offset: 0x0003CA95
		public unsafe bool bUseMeshPose
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseMeshPose) & FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseMeshPose) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseMeshPose) = ((*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_bUseMeshPose) & ~FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseMeshPose) | (value ? FAnimNode_CopyPoseFromMesh.__PropertyMask_bUseMeshPose : 0));
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x0600295B RID: 10587 RVA: 0x0003E8C5 File Offset: 0x0003CAC5
		// (set) Token: 0x0600295C RID: 10588 RVA: 0x0003E8D9 File Offset: 0x0003CAD9
		public unsafe FName RootBoneToCopy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_RootBoneToCopy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNode_CopyPoseFromMesh.__PropertyOffset_RootBoneToCopy) = value;
			}
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x0003E8EE File Offset: 0x0003CAEE
		public FAnimNode_CopyPoseFromMesh()
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x0003E8F6 File Offset: 0x0003CAF6
		public FAnimNode_CopyPoseFromMesh([Nullable(new byte[]
		{
			0,
			1
		})] TWeakObjectPtr<USkeletalMeshComponent> SourceMeshComponent, bool bUseAttachedParent, bool bCopyCurves, bool bCopyCustomAttributes, bool bUseMeshPose, FName RootBoneToCopy)
		{
			this.SourceMeshComponent = SourceMeshComponent;
			this.bUseAttachedParent = bUseAttachedParent;
			this.bCopyCurves = bCopyCurves;
			this.bCopyCustomAttributes = bCopyCustomAttributes;
			this.bUseMeshPose = bUseMeshPose;
			this.RootBoneToCopy = RootBoneToCopy;
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x0003E92B File Offset: 0x0003CB2B
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNode_CopyPoseFromMesh.StaticStruct();
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x0003E937 File Offset: 0x0003CB37
		[NullableContext(2)]
		public FAnimNode_CopyPoseFromMesh(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0003E941 File Offset: 0x0003CB41
		public FAnimNode_CopyPoseFromMesh(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x0003E94C File Offset: 0x0003CB4C
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNode_CopyPoseFromMesh(Pointer, false, true);
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x0003E956 File Offset: 0x0003CB56
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNode_CopyPoseFromMesh(Pointer, MemoryOwner);
		}

		// Token: 0x04001090 RID: 4240
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.AnimNode_CopyPoseFromMesh";

		// Token: 0x04001091 RID: 4241
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001092 RID: 4242
		internal static int __PropertyOffset_SourceMeshComponent;

		// Token: 0x04001093 RID: 4243
		internal static int __PropertyOffset_bUseAttachedParent;

		// Token: 0x04001094 RID: 4244
		internal static byte __PropertyMask_bUseAttachedParent;

		// Token: 0x04001095 RID: 4245
		internal static int __PropertyOffset_bCopyCurves;

		// Token: 0x04001096 RID: 4246
		internal static byte __PropertyMask_bCopyCurves;

		// Token: 0x04001097 RID: 4247
		internal static int __PropertyOffset_bCopyCustomAttributes;

		// Token: 0x04001098 RID: 4248
		internal static int __PropertyOffset_bUseMeshPose;

		// Token: 0x04001099 RID: 4249
		internal static byte __PropertyMask_bUseMeshPose;

		// Token: 0x0400109A RID: 4250
		internal static int __PropertyOffset_RootBoneToCopy;
	}
}
