using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200162D RID: 5677
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BranchBlendFilter")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBranchBlendFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060148B0 RID: 84144 RVA: 0x001E38BD File Offset: 0x001E1ABD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBranchBlendFilter._ScriptStructPtr != 0) ? FBranchBlendFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BranchBlendFilter", ref FBranchBlendFilter._ScriptStructPtr);
		}

		// Token: 0x170050E6 RID: 20710
		// (get) Token: 0x060148B1 RID: 84145 RVA: 0x001E38E4 File Offset: 0x001E1AE4
		// (set) Token: 0x060148B2 RID: 84146 RVA: 0x001E3927 File Offset: 0x001E1B27
		public FBoneReference BoneConfig
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._BoneConfig) == null)
				{
					result = (this._BoneConfig = new FBoneReference(base.NativePtr + (IntPtr)FBranchBlendFilter.__PropertyOffset_BoneConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBranchBlendFilter.__PropertyOffset_BoneConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050E7 RID: 20711
		// (get) Token: 0x060148B3 RID: 84147 RVA: 0x001E3948 File Offset: 0x001E1B48
		// (set) Token: 0x060148B4 RID: 84148 RVA: 0x001E3958 File Offset: 0x001E1B58
		public unsafe int BlendDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBranchBlendFilter.__PropertyOffset_BlendDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBranchBlendFilter.__PropertyOffset_BlendDepth) = value;
			}
		}

		// Token: 0x060148B5 RID: 84149 RVA: 0x001E3969 File Offset: 0x001E1B69
		public FBranchBlendFilter()
		{
		}

		// Token: 0x060148B6 RID: 84150 RVA: 0x001E3971 File Offset: 0x001E1B71
		public FBranchBlendFilter(FBoneReference BoneConfig, int BlendDepth)
		{
			this.BoneConfig = BoneConfig;
			this.BlendDepth = BlendDepth;
		}

		// Token: 0x060148B7 RID: 84151 RVA: 0x001E3987 File Offset: 0x001E1B87
		protected override IntPtr GetUStructPtr()
		{
			return FBranchBlendFilter.StaticStruct();
		}

		// Token: 0x060148B8 RID: 84152 RVA: 0x001E3993 File Offset: 0x001E1B93
		[NullableContext(2)]
		public FBranchBlendFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060148B9 RID: 84153 RVA: 0x001E399D File Offset: 0x001E1B9D
		public FBranchBlendFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060148BA RID: 84154 RVA: 0x001E39A8 File Offset: 0x001E1BA8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBranchBlendFilter(Pointer, false, true);
		}

		// Token: 0x060148BB RID: 84155 RVA: 0x001E39B2 File Offset: 0x001E1BB2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBranchBlendFilter(Pointer, MemoryOwner);
		}

		// Token: 0x0400B2BC RID: 45756
		public const string __ObjectPath = "/Script/KuroAnim.BranchBlendFilter";

		// Token: 0x0400B2BD RID: 45757
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B2BE RID: 45758
		internal static int __PropertyOffset_BoneConfig;

		// Token: 0x0400B2BF RID: 45759
		[Nullable(2)]
		private FBoneReference _BoneConfig;

		// Token: 0x0400B2C0 RID: 45760
		internal static int __PropertyOffset_BlendDepth;
	}
}
