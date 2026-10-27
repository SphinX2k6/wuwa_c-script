using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002CA RID: 714
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.AngularRangeLimit")]
	[UnrealStructLayout(44, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 44)]
	public class FAngularRangeLimit : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002791 RID: 10129 RVA: 0x0003B4E1 File Offset: 0x000396E1
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAngularRangeLimit._ScriptStructPtr != 0) ? FAngularRangeLimit._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimGraphRuntime.AngularRangeLimit", ref FAngularRangeLimit._ScriptStructPtr);
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002792 RID: 10130 RVA: 0x0003B505 File Offset: 0x00039705
		// (set) Token: 0x06002793 RID: 10131 RVA: 0x0003B519 File Offset: 0x00039719
		public unsafe FVector LimitMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_LimitMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_LimitMin) = value;
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002794 RID: 10132 RVA: 0x0003B52E File Offset: 0x0003972E
		// (set) Token: 0x06002795 RID: 10133 RVA: 0x0003B542 File Offset: 0x00039742
		public unsafe FVector LimitMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_LimitMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_LimitMax) = value;
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002796 RID: 10134 RVA: 0x0003B558 File Offset: 0x00039758
		// (set) Token: 0x06002797 RID: 10135 RVA: 0x0003B59B File Offset: 0x0003979B
		public FBoneReference Bone
		{
			get
			{
				base.FastCheckIsValid();
				FBoneReference result;
				if ((result = this._Bone) == null)
				{
					result = (this._Bone = new FBoneReference(base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_Bone, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FBoneReference.StaticStruct(), base.NativePtr + (IntPtr)FAngularRangeLimit.__PropertyOffset_Bone, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06002798 RID: 10136 RVA: 0x0003B5BC File Offset: 0x000397BC
		public FAngularRangeLimit()
		{
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0003B5C4 File Offset: 0x000397C4
		public FAngularRangeLimit(FVector LimitMin, FVector LimitMax, FBoneReference Bone)
		{
			this.LimitMin = LimitMin;
			this.LimitMax = LimitMax;
			this.Bone = Bone;
		}

		// Token: 0x0600279A RID: 10138 RVA: 0x0003B5E1 File Offset: 0x000397E1
		protected override IntPtr GetUStructPtr()
		{
			return FAngularRangeLimit.StaticStruct();
		}

		// Token: 0x0600279B RID: 10139 RVA: 0x0003B5ED File Offset: 0x000397ED
		[NullableContext(2)]
		public FAngularRangeLimit(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600279C RID: 10140 RVA: 0x0003B5F7 File Offset: 0x000397F7
		public FAngularRangeLimit(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600279D RID: 10141 RVA: 0x0003B602 File Offset: 0x00039802
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAngularRangeLimit(Pointer, false, true);
		}

		// Token: 0x0600279E RID: 10142 RVA: 0x0003B60C File Offset: 0x0003980C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAngularRangeLimit(Pointer, MemoryOwner);
		}

		// Token: 0x04000F9A RID: 3994
		public const string __ObjectPath = "/Script/AnimGraphRuntime.AngularRangeLimit";

		// Token: 0x04000F9B RID: 3995
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F9C RID: 3996
		internal static int __PropertyOffset_LimitMin;

		// Token: 0x04000F9D RID: 3997
		internal static int __PropertyOffset_LimitMax;

		// Token: 0x04000F9E RID: 3998
		internal static int __PropertyOffset_Bone;

		// Token: 0x04000F9F RID: 3999
		[Nullable(2)]
		private FBoneReference _Bone;
	}
}
