using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001626 RID: 5670
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.BoneBindInfo")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FBoneBindInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014842 RID: 84034 RVA: 0x001E2E78 File Offset: 0x001E1078
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBoneBindInfo._ScriptStructPtr != 0) ? FBoneBindInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.BoneBindInfo", ref FBoneBindInfo._ScriptStructPtr);
		}

		// Token: 0x170050CB RID: 20683
		// (get) Token: 0x06014843 RID: 84035 RVA: 0x001E2E9C File Offset: 0x001E109C
		// (set) Token: 0x06014844 RID: 84036 RVA: 0x001E2EDF File Offset: 0x001E10DF
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FBoneBindInfo.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FBoneBindInfo.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170050CC RID: 20684
		// (get) Token: 0x06014845 RID: 84037 RVA: 0x001E2F00 File Offset: 0x001E1100
		// (set) Token: 0x06014846 RID: 84038 RVA: 0x001E2F10 File Offset: 0x001E1110
		public unsafe float Weights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBoneBindInfo.__PropertyOffset_Weights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBoneBindInfo.__PropertyOffset_Weights) = value;
			}
		}

		// Token: 0x06014847 RID: 84039 RVA: 0x001E2F21 File Offset: 0x001E1121
		public FBoneBindInfo()
		{
		}

		// Token: 0x06014848 RID: 84040 RVA: 0x001E2F29 File Offset: 0x001E1129
		public FBoneBindInfo(FBoneReference Bone, float Weights)
		{
			this.Bone = Bone;
			this.Weights = Weights;
		}

		// Token: 0x06014849 RID: 84041 RVA: 0x001E2F3F File Offset: 0x001E113F
		protected override IntPtr GetUStructPtr()
		{
			return FBoneBindInfo.StaticStruct();
		}

		// Token: 0x0601484A RID: 84042 RVA: 0x001E2F4B File Offset: 0x001E114B
		[NullableContext(2)]
		public FBoneBindInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601484B RID: 84043 RVA: 0x001E2F55 File Offset: 0x001E1155
		public FBoneBindInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601484C RID: 84044 RVA: 0x001E2F60 File Offset: 0x001E1160
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBoneBindInfo(Pointer, false, true);
		}

		// Token: 0x0601484D RID: 84045 RVA: 0x001E2F6A File Offset: 0x001E116A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBoneBindInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400B285 RID: 45701
		public const string __ObjectPath = "/Script/KuroAnim.BoneBindInfo";

		// Token: 0x0400B286 RID: 45702
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B287 RID: 45703
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400B288 RID: 45704
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400B289 RID: 45705
		internal static int __PropertyOffset_Weights;
	}
}
