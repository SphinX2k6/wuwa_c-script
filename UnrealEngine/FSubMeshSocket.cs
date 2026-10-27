using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020011B5 RID: 4533
	[UnrealObjectPath("/Script/Engine.SubMeshSocket")]
	[UnrealStructLayout(64, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FSubMeshSocket : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010B66 RID: 68454 RVA: 0x0018897A File Offset: 0x00186B7A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubMeshSocket._ScriptStructPtr != 0) ? FSubMeshSocket._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SubMeshSocket", ref FSubMeshSocket._ScriptStructPtr);
		}

		// Token: 0x17004144 RID: 16708
		// (get) Token: 0x06010B67 RID: 68455 RVA: 0x0018899E File Offset: 0x00186B9E
		// (set) Token: 0x06010B68 RID: 68456 RVA: 0x001889AE File Offset: 0x00186BAE
		public unsafe int MeshIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_MeshIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_MeshIndex) = value;
			}
		}

		// Token: 0x17004145 RID: 16709
		// (get) Token: 0x06010B69 RID: 68457 RVA: 0x001889BF File Offset: 0x00186BBF
		// (set) Token: 0x06010B6A RID: 68458 RVA: 0x001889D3 File Offset: 0x00186BD3
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x17004146 RID: 16710
		// (get) Token: 0x06010B6B RID: 68459 RVA: 0x001889E8 File Offset: 0x00186BE8
		// (set) Token: 0x06010B6C RID: 68460 RVA: 0x001889FC File Offset: 0x00186BFC
		public unsafe FTransform SocketTransform
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_SocketTransform);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubMeshSocket.__PropertyOffset_SocketTransform) = value;
			}
		}

		// Token: 0x06010B6D RID: 68461 RVA: 0x00188A11 File Offset: 0x00186C11
		public FSubMeshSocket()
		{
		}

		// Token: 0x06010B6E RID: 68462 RVA: 0x00188A19 File Offset: 0x00186C19
		public FSubMeshSocket(int MeshIndex, FName SocketName, FTransform SocketTransform)
		{
			this.MeshIndex = MeshIndex;
			this.SocketName = SocketName;
			this.SocketTransform = SocketTransform;
		}

		// Token: 0x06010B6F RID: 68463 RVA: 0x00188A36 File Offset: 0x00186C36
		protected override IntPtr GetUStructPtr()
		{
			return FSubMeshSocket.StaticStruct();
		}

		// Token: 0x06010B70 RID: 68464 RVA: 0x00188A42 File Offset: 0x00186C42
		[NullableContext(2)]
		public FSubMeshSocket(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06010B71 RID: 68465 RVA: 0x00188A4C File Offset: 0x00186C4C
		public FSubMeshSocket(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06010B72 RID: 68466 RVA: 0x00188A57 File Offset: 0x00186C57
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubMeshSocket(Pointer, false, true);
		}

		// Token: 0x06010B73 RID: 68467 RVA: 0x00188A61 File Offset: 0x00186C61
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubMeshSocket(Pointer, MemoryOwner);
		}

		// Token: 0x04008EF8 RID: 36600
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SubMeshSocket";

		// Token: 0x04008EF9 RID: 36601
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008EFA RID: 36602
		internal static int __PropertyOffset_MeshIndex;

		// Token: 0x04008EFB RID: 36603
		internal static int __PropertyOffset_SocketName;

		// Token: 0x04008EFC RID: 36604
		internal static int __PropertyOffset_SocketTransform;
	}
}
