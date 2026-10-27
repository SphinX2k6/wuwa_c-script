using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008D1 RID: 2257
	[UnrealObjectPath("/Script/Engine.BoneFilter")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FBoneFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007C34 RID: 31796 RVA: 0x000B2332 File Offset: 0x000B0532
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneFilter._ScriptStructPtr != 0) ? FBoneFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BoneFilter", ref FBoneFilter._ScriptStructPtr);
		}

		// Token: 0x17001D3A RID: 7482
		// (get) Token: 0x06007C35 RID: 31797 RVA: 0x000B2356 File Offset: 0x000B0556
		// (set) Token: 0x06007C36 RID: 31798 RVA: 0x000B2366 File Offset: 0x000B0566
		public unsafe bool bExcludeSelf
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFilter.__PropertyOffset_bExcludeSelf) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFilter.__PropertyOffset_bExcludeSelf) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001D3B RID: 7483
		// (get) Token: 0x06007C37 RID: 31799 RVA: 0x000B2377 File Offset: 0x000B0577
		// (set) Token: 0x06007C38 RID: 31800 RVA: 0x000B238B File Offset: 0x000B058B
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneFilter.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneFilter.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x06007C39 RID: 31801 RVA: 0x000B23A0 File Offset: 0x000B05A0
		public FBoneFilter()
		{
		}

		// Token: 0x06007C3A RID: 31802 RVA: 0x000B23A8 File Offset: 0x000B05A8
		public FBoneFilter(bool bExcludeSelf, FName BoneName)
		{
			this.bExcludeSelf = bExcludeSelf;
			this.BoneName = BoneName;
		}

		// Token: 0x06007C3B RID: 31803 RVA: 0x000B23BE File Offset: 0x000B05BE
		protected override IntPtr GetUStructPtr()
		{
			return FBoneFilter.StaticStruct();
		}

		// Token: 0x06007C3C RID: 31804 RVA: 0x000B23CA File Offset: 0x000B05CA
		[NullableContext(2)]
		public FBoneFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007C3D RID: 31805 RVA: 0x000B23D4 File Offset: 0x000B05D4
		public FBoneFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007C3E RID: 31806 RVA: 0x000B23DF File Offset: 0x000B05DF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneFilter(Pointer, false, true);
		}

		// Token: 0x06007C3F RID: 31807 RVA: 0x000B23E9 File Offset: 0x000B05E9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04003B8D RID: 15245
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BoneFilter";

		// Token: 0x04003B8E RID: 15246
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003B8F RID: 15247
		internal static int __PropertyOffset_bExcludeSelf;

		// Token: 0x04003B90 RID: 15248
		internal static int __PropertyOffset_BoneName;
	}
}
