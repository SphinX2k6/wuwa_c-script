using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001684 RID: 5764
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAnim.StatureConfig")]
	[UnrealStructLayout(32, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FStatureConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06014E9A RID: 85658 RVA: 0x001EBE14 File Offset: 0x001EA014
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FStatureConfig._ScriptStructPtr != 0) ? FStatureConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroAnim.StatureConfig", ref FStatureConfig._ScriptStructPtr);
		}

		// Token: 0x170052D9 RID: 21209
		// (get) Token: 0x06014E9B RID: 85659 RVA: 0x001EBE38 File Offset: 0x001EA038
		// (set) Token: 0x06014E9C RID: 85660 RVA: 0x001EBE7B File Offset: 0x001EA07B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FStatureConfig.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FStatureConfig.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170052DA RID: 21210
		// (get) Token: 0x06014E9D RID: 85661 RVA: 0x001EBE9C File Offset: 0x001EA09C
		// (set) Token: 0x06014E9E RID: 85662 RVA: 0x001EBEB0 File Offset: 0x001EA0B0
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FStatureConfig.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FStatureConfig.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x06014E9F RID: 85663 RVA: 0x001EBEC5 File Offset: 0x001EA0C5
		public FStatureConfig()
		{
		}

		// Token: 0x06014EA0 RID: 85664 RVA: 0x001EBECD File Offset: 0x001EA0CD
		public FStatureConfig(FBoneReference Bone, FVector Scale)
		{
			this.Bone = Bone;
			this.Scale = Scale;
		}

		// Token: 0x06014EA1 RID: 85665 RVA: 0x001EBEE3 File Offset: 0x001EA0E3
		protected override IntPtr GetUStructPtr()
		{
			return FStatureConfig.StaticStruct();
		}

		// Token: 0x06014EA2 RID: 85666 RVA: 0x001EBEEF File Offset: 0x001EA0EF
		[NullableContext(2)]
		public FStatureConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06014EA3 RID: 85667 RVA: 0x001EBEF9 File Offset: 0x001EA0F9
		public FStatureConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06014EA4 RID: 85668 RVA: 0x001EBF04 File Offset: 0x001EA104
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FStatureConfig(Pointer, false, true);
		}

		// Token: 0x06014EA5 RID: 85669 RVA: 0x001EBF0E File Offset: 0x001EA10E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FStatureConfig(Pointer, MemoryOwner);
		}

		// Token: 0x0400B64E RID: 46670
		public const string __ObjectPath = "/Script/KuroAnim.StatureConfig";

		// Token: 0x0400B64F RID: 46671
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B650 RID: 46672
		internal static int __PropertyOffset_Bone;

		// Token: 0x0400B651 RID: 46673
		[Nullable(2)]
		private FBoneReference _Bone;

		// Token: 0x0400B652 RID: 46674
		internal static int __PropertyOffset_Scale;
	}
}
