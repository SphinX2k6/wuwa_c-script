using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001785 RID: 6021
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainAttachment")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FJacobiChainAttachment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015A48 RID: 88648 RVA: 0x001FD346 File Offset: 0x001FB546
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FJacobiChainAttachment._ScriptStructPtr != 0) ? FJacobiChainAttachment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroComputeShader.JacobiChainAttachment", ref FJacobiChainAttachment._ScriptStructPtr);
		}

		// Token: 0x17005585 RID: 21893
		// (get) Token: 0x06015A49 RID: 88649 RVA: 0x001FD36A File Offset: 0x001FB56A
		// (set) Token: 0x06015A4A RID: 88650 RVA: 0x001FD37A File Offset: 0x001FB57A
		public unsafe int RigidParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_RigidParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_RigidParticle) = value;
			}
		}

		// Token: 0x17005586 RID: 21894
		// (get) Token: 0x06015A4B RID: 88651 RVA: 0x001FD38B File Offset: 0x001FB58B
		// (set) Token: 0x06015A4C RID: 88652 RVA: 0x001FD39B File Offset: 0x001FB59B
		public unsafe int SoftParticle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_SoftParticle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_SoftParticle) = value;
			}
		}

		// Token: 0x17005587 RID: 21895
		// (get) Token: 0x06015A4D RID: 88653 RVA: 0x001FD3AC File Offset: 0x001FB5AC
		// (set) Token: 0x06015A4E RID: 88654 RVA: 0x001FD3C0 File Offset: 0x001FB5C0
		public unsafe FVector LocalAnchor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_LocalAnchor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FJacobiChainAttachment.__PropertyOffset_LocalAnchor) = value;
			}
		}

		// Token: 0x06015A4F RID: 88655 RVA: 0x001FD3D5 File Offset: 0x001FB5D5
		public FJacobiChainAttachment()
		{
		}

		// Token: 0x06015A50 RID: 88656 RVA: 0x001FD3DD File Offset: 0x001FB5DD
		public FJacobiChainAttachment(int RigidParticle, int SoftParticle, FVector LocalAnchor)
		{
			this.RigidParticle = RigidParticle;
			this.SoftParticle = SoftParticle;
			this.LocalAnchor = LocalAnchor;
		}

		// Token: 0x06015A51 RID: 88657 RVA: 0x001FD3FA File Offset: 0x001FB5FA
		protected override IntPtr GetUStructPtr()
		{
			return FJacobiChainAttachment.StaticStruct();
		}

		// Token: 0x06015A52 RID: 88658 RVA: 0x001FD406 File Offset: 0x001FB606
		[NullableContext(2)]
		public FJacobiChainAttachment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015A53 RID: 88659 RVA: 0x001FD410 File Offset: 0x001FB610
		public FJacobiChainAttachment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015A54 RID: 88660 RVA: 0x001FD41B File Offset: 0x001FB61B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FJacobiChainAttachment(Pointer, false, true);
		}

		// Token: 0x06015A55 RID: 88661 RVA: 0x001FD425 File Offset: 0x001FB625
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FJacobiChainAttachment(Pointer, MemoryOwner);
		}

		// Token: 0x0400BD23 RID: 48419
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainAttachment";

		// Token: 0x0400BD24 RID: 48420
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400BD25 RID: 48421
		internal static int __PropertyOffset_RigidParticle;

		// Token: 0x0400BD26 RID: 48422
		internal static int __PropertyOffset_SoftParticle;

		// Token: 0x0400BD27 RID: 48423
		internal static int __PropertyOffset_LocalAnchor;
	}
}
