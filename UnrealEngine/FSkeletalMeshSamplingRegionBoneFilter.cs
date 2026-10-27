using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001106 RID: 4358
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingRegionBoneFilter")]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSkeletalMeshSamplingRegionBoneFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCEF RID: 64751 RVA: 0x001758E6 File Offset: 0x00173AE6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingRegionBoneFilter._ScriptStructPtr != 0) ? FSkeletalMeshSamplingRegionBoneFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingRegionBoneFilter", ref FSkeletalMeshSamplingRegionBoneFilter._ScriptStructPtr);
		}

		// Token: 0x17003DB6 RID: 15798
		// (get) Token: 0x0600FCF0 RID: 64752 RVA: 0x0017590A File Offset: 0x00173B0A
		// (set) Token: 0x0600FCF1 RID: 64753 RVA: 0x0017591E File Offset: 0x00173B1E
		public unsafe FName BoneName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_BoneName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_BoneName) = value;
			}
		}

		// Token: 0x17003DB7 RID: 15799
		// (get) Token: 0x0600FCF2 RID: 64754 RVA: 0x00175933 File Offset: 0x00173B33
		// (set) Token: 0x0600FCF3 RID: 64755 RVA: 0x0017594C File Offset: 0x00173B4C
		public unsafe bool bIncludeOrExclude
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bIncludeOrExclude) & FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bIncludeOrExclude) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bIncludeOrExclude) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bIncludeOrExclude) & ~FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bIncludeOrExclude) | (value ? FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bIncludeOrExclude : 0));
			}
		}

		// Token: 0x17003DB8 RID: 15800
		// (get) Token: 0x0600FCF4 RID: 64756 RVA: 0x0017597C File Offset: 0x00173B7C
		// (set) Token: 0x0600FCF5 RID: 64757 RVA: 0x00175995 File Offset: 0x00173B95
		public unsafe bool bApplyToChildren
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bApplyToChildren) & FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bApplyToChildren) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bApplyToChildren) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegionBoneFilter.__PropertyOffset_bApplyToChildren) & ~FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bApplyToChildren) | (value ? FSkeletalMeshSamplingRegionBoneFilter.__PropertyMask_bApplyToChildren : 0));
			}
		}

		// Token: 0x0600FCF6 RID: 64758 RVA: 0x001759C5 File Offset: 0x00173BC5
		public FSkeletalMeshSamplingRegionBoneFilter()
		{
		}

		// Token: 0x0600FCF7 RID: 64759 RVA: 0x001759CD File Offset: 0x00173BCD
		public FSkeletalMeshSamplingRegionBoneFilter(FName BoneName, bool bIncludeOrExclude, bool bApplyToChildren)
		{
			this.BoneName = BoneName;
			this.bIncludeOrExclude = bIncludeOrExclude;
			this.bApplyToChildren = bApplyToChildren;
		}

		// Token: 0x0600FCF8 RID: 64760 RVA: 0x001759EA File Offset: 0x00173BEA
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingRegionBoneFilter.StaticStruct();
		}

		// Token: 0x0600FCF9 RID: 64761 RVA: 0x001759F6 File Offset: 0x00173BF6
		[NullableContext(2)]
		public FSkeletalMeshSamplingRegionBoneFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCFA RID: 64762 RVA: 0x00175A00 File Offset: 0x00173C00
		public FSkeletalMeshSamplingRegionBoneFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCFB RID: 64763 RVA: 0x00175A0B File Offset: 0x00173C0B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingRegionBoneFilter(Pointer, false, true);
		}

		// Token: 0x0600FCFC RID: 64764 RVA: 0x00175A15 File Offset: 0x00173C15
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingRegionBoneFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04008858 RID: 34904
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingRegionBoneFilter";

		// Token: 0x04008859 RID: 34905
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400885A RID: 34906
		internal static int __PropertyOffset_BoneName;

		// Token: 0x0400885B RID: 34907
		internal static int __PropertyOffset_bIncludeOrExclude;

		// Token: 0x0400885C RID: 34908
		internal static byte __PropertyMask_bIncludeOrExclude;

		// Token: 0x0400885D RID: 34909
		internal static int __PropertyOffset_bApplyToChildren;

		// Token: 0x0400885E RID: 34910
		internal static byte __PropertyMask_bApplyToChildren;
	}
}
