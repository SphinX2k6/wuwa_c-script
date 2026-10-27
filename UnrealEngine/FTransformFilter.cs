using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002C8 RID: 712
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.TransformFilter")]
	[UnrealStructLayout(9, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 9)]
	public class FTransformFilter : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002777 RID: 10103 RVA: 0x0003B270 File Offset: 0x00039470
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTransformFilter._ScriptStructPtr != 0) ? FTransformFilter._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.TransformFilter", ref FTransformFilter._ScriptStructPtr);
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06002778 RID: 10104 RVA: 0x0003B294 File Offset: 0x00039494
		// (set) Token: 0x06002779 RID: 10105 RVA: 0x0003B2D7 File Offset: 0x000394D7
		public FFilterOptionPerAxis TranslationFilter
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._TranslationFilter) == null)
				{
					result = (this._TranslationFilter = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_TranslationFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_TranslationFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x0003B2F8 File Offset: 0x000394F8
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x0003B33B File Offset: 0x0003953B
		public FFilterOptionPerAxis RotationFilter
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._RotationFilter) == null)
				{
					result = (this._RotationFilter = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_RotationFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_RotationFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0003B35C File Offset: 0x0003955C
		// (set) Token: 0x0600277D RID: 10109 RVA: 0x0003B39F File Offset: 0x0003959F
		public FFilterOptionPerAxis ScaleFilter
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._ScaleFilter) == null)
				{
					result = (this._ScaleFilter = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_ScaleFilter, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FTransformFilter.__PropertyOffset_ScaleFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600277E RID: 10110 RVA: 0x0003B3C0 File Offset: 0x000395C0
		public FTransformFilter()
		{
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x0003B3C8 File Offset: 0x000395C8
		public FTransformFilter(FFilterOptionPerAxis TranslationFilter, FFilterOptionPerAxis RotationFilter, FFilterOptionPerAxis ScaleFilter)
		{
			this.TranslationFilter = TranslationFilter;
			this.RotationFilter = RotationFilter;
			this.ScaleFilter = ScaleFilter;
		}

		// Token: 0x06002780 RID: 10112 RVA: 0x0003B3E5 File Offset: 0x000395E5
		protected override IntPtr GetUStructPtr()
		{
			return FTransformFilter.StaticStruct();
		}

		// Token: 0x06002781 RID: 10113 RVA: 0x0003B3F1 File Offset: 0x000395F1
		[NullableContext(2)]
		public FTransformFilter(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06002782 RID: 10114 RVA: 0x0003B3FB File Offset: 0x000395FB
		public FTransformFilter(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x0003B406 File Offset: 0x00039606
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTransformFilter(Pointer, false, true);
		}

		// Token: 0x06002784 RID: 10116 RVA: 0x0003B410 File Offset: 0x00039610
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTransformFilter(Pointer, MemoryOwner);
		}

		// Token: 0x04000F8E RID: 3982
		public const string __ObjectPath = "/Script/AnimationCore.TransformFilter";

		// Token: 0x04000F8F RID: 3983
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F90 RID: 3984
		internal static int __PropertyOffset_TranslationFilter;

		// Token: 0x04000F91 RID: 3985
		[Nullable(2)]
		private FFilterOptionPerAxis _TranslationFilter;

		// Token: 0x04000F92 RID: 3986
		internal static int __PropertyOffset_RotationFilter;

		// Token: 0x04000F93 RID: 3987
		[Nullable(2)]
		private FFilterOptionPerAxis _RotationFilter;

		// Token: 0x04000F94 RID: 3988
		internal static int __PropertyOffset_ScaleFilter;

		// Token: 0x04000F95 RID: 3989
		[Nullable(2)]
		private FFilterOptionPerAxis _ScaleFilter;
	}
}
