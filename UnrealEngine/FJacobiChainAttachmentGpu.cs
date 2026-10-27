using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001786 RID: 6022
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainAttachmentGpu")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FJacobiChainAttachmentGpu : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015A56 RID: 88662 RVA: 0x001FD42E File Offset: 0x001FB62E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainAttachmentGpu._ScriptStructPtr != 0) ? FJacobiChainAttachmentGpu._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainAttachmentGpu", ref FJacobiChainAttachmentGpu._ScriptStructPtr);
		}

		// Token: 0x17005588 RID: 21896
		// (get) Token: 0x06015A57 RID: 88663 RVA: 0x001FD452 File Offset: 0x001FB652
		// (set) Token: 0x06015A58 RID: 88664 RVA: 0x001FD462 File Offset: 0x001FB662
		public unsafe uint RigidParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_RigidParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_RigidParticle) = (int)value;
			}
		}

		// Token: 0x17005589 RID: 21897
		// (get) Token: 0x06015A59 RID: 88665 RVA: 0x001FD473 File Offset: 0x001FB673
		// (set) Token: 0x06015A5A RID: 88666 RVA: 0x001FD483 File Offset: 0x001FB683
		public unsafe uint SoftParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_SoftParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_SoftParticle) = (int)value;
			}
		}

		// Token: 0x1700558A RID: 21898
		// (get) Token: 0x06015A5B RID: 88667 RVA: 0x001FD494 File Offset: 0x001FB694
		// (set) Token: 0x06015A5C RID: 88668 RVA: 0x001FD4A4 File Offset: 0x001FB6A4
		public unsafe uint RigidBodyIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_RigidBodyIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_RigidBodyIndex) = (int)value;
			}
		}

		// Token: 0x1700558B RID: 21899
		// (get) Token: 0x06015A5D RID: 88669 RVA: 0x001FD4B5 File Offset: 0x001FB6B5
		// (set) Token: 0x06015A5E RID: 88670 RVA: 0x001FD4C5 File Offset: 0x001FB6C5
		public unsafe uint Padding0
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_Padding0);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_Padding0) = (int)value;
			}
		}

		// Token: 0x1700558C RID: 21900
		// (get) Token: 0x06015A5F RID: 88671 RVA: 0x001FD4D6 File Offset: 0x001FB6D6
		// (set) Token: 0x06015A60 RID: 88672 RVA: 0x001FD4EA File Offset: 0x001FB6EA
		public unsafe FVector LocalAnchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_LocalAnchor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_LocalAnchor) = value;
			}
		}

		// Token: 0x1700558D RID: 21901
		// (get) Token: 0x06015A61 RID: 88673 RVA: 0x001FD4FF File Offset: 0x001FB6FF
		// (set) Token: 0x06015A62 RID: 88674 RVA: 0x001FD50F File Offset: 0x001FB70F
		public unsafe float Padding1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_Padding1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachmentGpu.__PropertyOffset_Padding1) = value;
			}
		}

		// Token: 0x06015A63 RID: 88675 RVA: 0x001FD520 File Offset: 0x001FB720
		public FJacobiChainAttachmentGpu()
		{
		}

		// Token: 0x06015A64 RID: 88676 RVA: 0x001FD528 File Offset: 0x001FB728
		public FJacobiChainAttachmentGpu(uint RigidParticle, uint SoftParticle, uint RigidBodyIndex, uint Padding0, FVector LocalAnchor, float Padding1)
		{
			this.RigidParticle = RigidParticle;
			this.SoftParticle = SoftParticle;
			this.RigidBodyIndex = RigidBodyIndex;
			this.Padding0 = Padding0;
			this.LocalAnchor = LocalAnchor;
			this.Padding1 = Padding1;
		}

		// Token: 0x06015A65 RID: 88677 RVA: 0x001FD55D File Offset: 0x001FB75D
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainAttachmentGpu.StaticStruct();
		}

		// Token: 0x06015A66 RID: 88678 RVA: 0x001FD569 File Offset: 0x001FB769
		[NullableContext(2)]
		public FJacobiChainAttachmentGpu(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015A67 RID: 88679 RVA: 0x001FD573 File Offset: 0x001FB773
		public FJacobiChainAttachmentGpu(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015A68 RID: 88680 RVA: 0x001FD57E File Offset: 0x001FB77E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainAttachmentGpu(Pointer, false, true);
		}

		// Token: 0x06015A69 RID: 88681 RVA: 0x001FD588 File Offset: 0x001FB788
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainAttachmentGpu(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD28 RID: 48424
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainAttachmentGpu";

		// Token: 0x0400BD29 RID: 48425
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD2A RID: 48426
		internal static int __PropertyOffset_RigidParticle;

		// Token: 0x0400BD2B RID: 48427
		internal static int __PropertyOffset_SoftParticle;

		// Token: 0x0400BD2C RID: 48428
		internal static int __PropertyOffset_RigidBodyIndex;

		// Token: 0x0400BD2D RID: 48429
		internal static int __PropertyOffset_Padding0;

		// Token: 0x0400BD2E RID: 48430
		internal static int __PropertyOffset_LocalAnchor;

		// Token: 0x0400BD2F RID: 48431
		internal static int __PropertyOffset_Padding1;
	}
}
