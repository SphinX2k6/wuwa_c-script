using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000312 RID: 786
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.BoneSocketTarget")]
	[UnrealStructLayout(112, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FBoneSocketTarget : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002D4E RID: 11598 RVA: 0x00045804 File Offset: 0x00043A04
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneSocketTarget._ScriptStructPtr != 0) ? FBoneSocketTarget._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.BoneSocketTarget", ref FBoneSocketTarget._ScriptStructPtr);
		}

		// Token: 0x17000B42 RID: 2882
		// (get) Token: 0x06002D4F RID: 11599 RVA: 0x00045828 File Offset: 0x00043A28
		// (set) Token: 0x06002D50 RID: 11600 RVA: 0x00045838 File Offset: 0x00043A38
		public unsafe bool bUseSocket
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_bUseSocket) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_bUseSocket) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B43 RID: 2883
		// (get) Token: 0x06002D51 RID: 11601 RVA: 0x0004584C File Offset: 0x00043A4C
		// (set) Token: 0x06002D52 RID: 11602 RVA: 0x0004588F File Offset: 0x00043A8F
		public FBoneReference BoneReference
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneReference) == null)
				{
					result = (this._BoneReference = new FBoneReference(base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_BoneReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_BoneReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B44 RID: 2884
		// (get) Token: 0x06002D53 RID: 11603 RVA: 0x000458B0 File Offset: 0x00043AB0
		// (set) Token: 0x06002D54 RID: 11604 RVA: 0x000458F3 File Offset: 0x00043AF3
		public FSocketReference SocketReference
		{
			get
			{
				base.FastCheckIsValid();
				FSocketReference result;
				if ((result = this._SocketReference) == null)
				{
					result = (this._SocketReference = new FSocketReference(base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_SocketReference, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSocketReference.StaticStruct(), base.NativePtr + (IntPtr)FBoneSocketTarget.__PropertyOffset_SocketReference, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002D55 RID: 11605 RVA: 0x00045914 File Offset: 0x00043B14
		public FBoneSocketTarget()
		{
		}

		// Token: 0x06002D56 RID: 11606 RVA: 0x0004591C File Offset: 0x00043B1C
		public FBoneSocketTarget(bool bUseSocket, FBoneReference BoneReference, FSocketReference SocketReference)
		{
			this.bUseSocket = bUseSocket;
			this.BoneReference = BoneReference;
			this.SocketReference = SocketReference;
		}

		// Token: 0x06002D57 RID: 11607 RVA: 0x00045939 File Offset: 0x00043B39
		protected override IntPtr GetUStructPtr()
		{
			return FBoneSocketTarget.StaticStruct();
		}

		// Token: 0x06002D58 RID: 11608 RVA: 0x00045945 File Offset: 0x00043B45
		[NullableContext(2)]
		public FBoneSocketTarget(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002D59 RID: 11609 RVA: 0x0004594F File Offset: 0x00043B4F
		public FBoneSocketTarget(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002D5A RID: 11610 RVA: 0x0004595A File Offset: 0x00043B5A
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneSocketTarget(Pointer, false, true);
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00045964 File Offset: 0x00043B64
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneSocketTarget(Pointer, MemoryOwner);
		}

		// Token: 0x040012C8 RID: 4808
		public const string __ObjectPath = "/Script/AnimGraphRuntime.BoneSocketTarget";

		// Token: 0x040012C9 RID: 4809
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012CA RID: 4810
		internal static int __PropertyOffset_bUseSocket;

		// Token: 0x040012CB RID: 4811
		internal static int __PropertyOffset_BoneReference;

		// Token: 0x040012CC RID: 4812
		[Nullable(2)]
		private FBoneReference _BoneReference;

		// Token: 0x040012CD RID: 4813
		internal static int __PropertyOffset_SocketReference;

		// Token: 0x040012CE RID: 4814
		[Nullable(2)]
		private FSocketReference _SocketReference;
	}
}
