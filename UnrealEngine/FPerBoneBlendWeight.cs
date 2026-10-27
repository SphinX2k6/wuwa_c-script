using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000FD3 RID: 4051
	[UnrealObjectPath("/Script/Engine.PerBoneBlendWeight")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FPerBoneBlendWeight : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600DADC RID: 56028 RVA: 0x00142A84 File Offset: 0x00140C84
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerBoneBlendWeight._ScriptStructPtr != 0) ? FPerBoneBlendWeight._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PerBoneBlendWeight", ref FPerBoneBlendWeight._ScriptStructPtr);
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600DADD RID: 56029 RVA: 0x00142AA8 File Offset: 0x00140CA8
		// (set) Token: 0x0600DADE RID: 56030 RVA: 0x00142AB8 File Offset: 0x00140CB8
		public unsafe int SourceIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerBoneBlendWeight.__PropertyOffset_SourceIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerBoneBlendWeight.__PropertyOffset_SourceIndex) = value;
			}
		}

		// Token: 0x170033A3 RID: 13219
		// (get) Token: 0x0600DADF RID: 56031 RVA: 0x00142AC9 File Offset: 0x00140CC9
		// (set) Token: 0x0600DAE0 RID: 56032 RVA: 0x00142AD9 File Offset: 0x00140CD9
		public unsafe float BlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerBoneBlendWeight.__PropertyOffset_BlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerBoneBlendWeight.__PropertyOffset_BlendWeight) = value;
			}
		}

		// Token: 0x0600DAE1 RID: 56033 RVA: 0x00142AEA File Offset: 0x00140CEA
		public FPerBoneBlendWeight()
		{
		}

		// Token: 0x0600DAE2 RID: 56034 RVA: 0x00142AF2 File Offset: 0x00140CF2
		public FPerBoneBlendWeight(int SourceIndex, float BlendWeight)
		{
			this.SourceIndex = SourceIndex;
			this.BlendWeight = BlendWeight;
		}

		// Token: 0x0600DAE3 RID: 56035 RVA: 0x00142B08 File Offset: 0x00140D08
		protected override IntPtr GetUStructPtr()
		{
			return FPerBoneBlendWeight.StaticStruct();
		}

		// Token: 0x0600DAE4 RID: 56036 RVA: 0x00142B14 File Offset: 0x00140D14
		[NullableContext(2)]
		public FPerBoneBlendWeight(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600DAE5 RID: 56037 RVA: 0x00142B1E File Offset: 0x00140D1E
		public FPerBoneBlendWeight(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600DAE6 RID: 56038 RVA: 0x00142B29 File Offset: 0x00140D29
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerBoneBlendWeight(Pointer, false, true);
		}

		// Token: 0x0600DAE7 RID: 56039 RVA: 0x00142B33 File Offset: 0x00140D33
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerBoneBlendWeight(Pointer, MemoryOwner);
		}

		// Token: 0x04007680 RID: 30336
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PerBoneBlendWeight";

		// Token: 0x04007681 RID: 30337
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007682 RID: 30338
		internal static int __PropertyOffset_SourceIndex;

		// Token: 0x04007683 RID: 30339
		internal static int __PropertyOffset_BlendWeight;
	}
}
