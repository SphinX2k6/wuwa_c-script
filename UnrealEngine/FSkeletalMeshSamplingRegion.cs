using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001105 RID: 4357
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshSamplingRegion")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FSkeletalMeshSamplingRegion : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600FCDD RID: 64733 RVA: 0x0017571E File Offset: 0x0017391E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkeletalMeshSamplingRegion._ScriptStructPtr != 0) ? FSkeletalMeshSamplingRegion._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SkeletalMeshSamplingRegion", ref FSkeletalMeshSamplingRegion._ScriptStructPtr);
		}

		// Token: 0x17003DB1 RID: 15793
		// (get) Token: 0x0600FCDE RID: 64734 RVA: 0x00175742 File Offset: 0x00173942
		// (set) Token: 0x0600FCDF RID: 64735 RVA: 0x00175756 File Offset: 0x00173956
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x17003DB2 RID: 15794
		// (get) Token: 0x0600FCE0 RID: 64736 RVA: 0x0017576B File Offset: 0x0017396B
		// (set) Token: 0x0600FCE1 RID: 64737 RVA: 0x0017577B File Offset: 0x0017397B
		public unsafe int LODIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_LODIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_LODIndex) = value;
			}
		}

		// Token: 0x17003DB3 RID: 15795
		// (get) Token: 0x0600FCE2 RID: 64738 RVA: 0x0017578C File Offset: 0x0017398C
		// (set) Token: 0x0600FCE3 RID: 64739 RVA: 0x001757A5 File Offset: 0x001739A5
		public unsafe bool bSupportUniformlyDistributedSampling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_bSupportUniformlyDistributedSampling) & FSkeletalMeshSamplingRegion.__PropertyMask_bSupportUniformlyDistributedSampling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_bSupportUniformlyDistributedSampling) = ((*(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_bSupportUniformlyDistributedSampling) & ~FSkeletalMeshSamplingRegion.__PropertyMask_bSupportUniformlyDistributedSampling) | (value ? FSkeletalMeshSamplingRegion.__PropertyMask_bSupportUniformlyDistributedSampling : 0));
			}
		}

		// Token: 0x17003DB4 RID: 15796
		// (get) Token: 0x0600FCE4 RID: 64740 RVA: 0x001757D8 File Offset: 0x001739D8
		// (set) Token: 0x0600FCE5 RID: 64741 RVA: 0x0017581B File Offset: 0x00173A1B
		public TArray<FSkeletalMeshSamplingRegionMaterialFilter> MaterialFilters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshSamplingRegionMaterialFilter> result;
				if ((result = this._MaterialFilters) == null)
				{
					result = (this._MaterialFilters = new TArray<FSkeletalMeshSamplingRegionMaterialFilter>(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_MaterialFilters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.MaterialFilters.CopyAssign(value);
			}
		}

		// Token: 0x17003DB5 RID: 15797
		// (get) Token: 0x0600FCE6 RID: 64742 RVA: 0x0017582C File Offset: 0x00173A2C
		// (set) Token: 0x0600FCE7 RID: 64743 RVA: 0x0017586F File Offset: 0x00173A6F
		public TArray<FSkeletalMeshSamplingRegionBoneFilter> BoneFilters
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSkeletalMeshSamplingRegionBoneFilter> result;
				if ((result = this._BoneFilters) == null)
				{
					result = (this._BoneFilters = new TArray<FSkeletalMeshSamplingRegionBoneFilter>(base.NativePtr + (IntPtr)FSkeletalMeshSamplingRegion.__PropertyOffset_BoneFilters, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.BoneFilters.CopyAssign(value);
			}
		}

		// Token: 0x0600FCE8 RID: 64744 RVA: 0x0017587D File Offset: 0x00173A7D
		public FSkeletalMeshSamplingRegion()
		{
		}

		// Token: 0x0600FCE9 RID: 64745 RVA: 0x00175885 File Offset: 0x00173A85
		public FSkeletalMeshSamplingRegion(FName Name, int LODIndex, bool bSupportUniformlyDistributedSampling, TArray<FSkeletalMeshSamplingRegionMaterialFilter> MaterialFilters, TArray<FSkeletalMeshSamplingRegionBoneFilter> BoneFilters)
		{
			this.Name = Name;
			this.LODIndex = LODIndex;
			this.bSupportUniformlyDistributedSampling = bSupportUniformlyDistributedSampling;
			this.MaterialFilters = MaterialFilters;
			this.BoneFilters = BoneFilters;
		}

		// Token: 0x0600FCEA RID: 64746 RVA: 0x001758B2 File Offset: 0x00173AB2
		protected override IntPtr GetUStructPtr()
		{
			return FSkeletalMeshSamplingRegion.StaticStruct();
		}

		// Token: 0x0600FCEB RID: 64747 RVA: 0x001758BE File Offset: 0x00173ABE
		[NullableContext(2)]
		public FSkeletalMeshSamplingRegion(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600FCEC RID: 64748 RVA: 0x001758C8 File Offset: 0x00173AC8
		public FSkeletalMeshSamplingRegion(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600FCED RID: 64749 RVA: 0x001758D3 File Offset: 0x00173AD3
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkeletalMeshSamplingRegion(Pointer, false, true);
		}

		// Token: 0x0600FCEE RID: 64750 RVA: 0x001758DD File Offset: 0x00173ADD
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkeletalMeshSamplingRegion(Pointer, MemoryOwner);
		}

		// Token: 0x0400884E RID: 34894
		public const string __ObjectPath = "/Script/Engine.SkeletalMeshSamplingRegion";

		// Token: 0x0400884F RID: 34895
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008850 RID: 34896
		internal static int __PropertyOffset_Name;

		// Token: 0x04008851 RID: 34897
		internal static int __PropertyOffset_LODIndex;

		// Token: 0x04008852 RID: 34898
		internal static int __PropertyOffset_bSupportUniformlyDistributedSampling;

		// Token: 0x04008853 RID: 34899
		internal static byte __PropertyMask_bSupportUniformlyDistributedSampling;

		// Token: 0x04008854 RID: 34900
		internal static int __PropertyOffset_MaterialFilters;

		// Token: 0x04008855 RID: 34901
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshSamplingRegionMaterialFilter> _MaterialFilters;

		// Token: 0x04008856 RID: 34902
		internal static int __PropertyOffset_BoneFilters;

		// Token: 0x04008857 RID: 34903
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSkeletalMeshSamplingRegionBoneFilter> _BoneFilters;
	}
}
