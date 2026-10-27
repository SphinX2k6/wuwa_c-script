using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000344 RID: 836
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.SplineIKCachedBoneData")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FSplineIKCachedBoneData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002EB4 RID: 11956 RVA: 0x000477D4 File Offset: 0x000459D4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineIKCachedBoneData._ScriptStructPtr != 0) ? FSplineIKCachedBoneData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.SplineIKCachedBoneData", ref FSplineIKCachedBoneData._ScriptStructPtr);
		}

		// Token: 0x17000B99 RID: 2969
		// (get) Token: 0x06002EB5 RID: 11957 RVA: 0x000477F8 File Offset: 0x000459F8
		// (set) Token: 0x06002EB6 RID: 11958 RVA: 0x0004783B File Offset: 0x00045A3B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FSplineIKCachedBoneData.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FSplineIKCachedBoneData.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000B9A RID: 2970
		// (get) Token: 0x06002EB7 RID: 11959 RVA: 0x0004785C File Offset: 0x00045A5C
		// (set) Token: 0x06002EB8 RID: 11960 RVA: 0x0004786C File Offset: 0x00045A6C
		public unsafe int RefSkeletonIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineIKCachedBoneData.__PropertyOffset_RefSkeletonIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineIKCachedBoneData.__PropertyOffset_RefSkeletonIndex) = value;
			}
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x0004787D File Offset: 0x00045A7D
		public FSplineIKCachedBoneData()
		{
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00047885 File Offset: 0x00045A85
		public FSplineIKCachedBoneData(FBoneReference Bone, int RefSkeletonIndex)
		{
			this.Bone = Bone;
			this.RefSkeletonIndex = RefSkeletonIndex;
		}

		// Token: 0x06002EBB RID: 11963 RVA: 0x0004789B File Offset: 0x00045A9B
		protected override IntPtr GetUStructPtr()
		{
			return FSplineIKCachedBoneData.StaticStruct();
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000478A7 File Offset: 0x00045AA7
		[NullableContext(2)]
		public FSplineIKCachedBoneData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x000478B1 File Offset: 0x00045AB1
		public FSplineIKCachedBoneData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002EBE RID: 11966 RVA: 0x000478BC File Offset: 0x00045ABC
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineIKCachedBoneData(Pointer, false, true);
		}

		// Token: 0x06002EBF RID: 11967 RVA: 0x000478C6 File Offset: 0x00045AC6
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineIKCachedBoneData(Pointer, MemoryOwner);
		}

		// Token: 0x04001404 RID: 5124
		public const string __ObjectPath = "/Script/AnimGraphRuntime.SplineIKCachedBoneData";

		// Token: 0x04001405 RID: 5125
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001406 RID: 5126
		internal static int __PropertyOffset_Bone;

		// Token: 0x04001407 RID: 5127
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x04001408 RID: 5128
		internal static int __PropertyOffset_RefSkeletonIndex;
	}
}
