using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002BA RID: 698
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnimationCore.ConstraintDescriptionEx")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FConstraintDescriptionEx : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060026E6 RID: 9958 RVA: 0x0003A7B9 File Offset: 0x000389B9
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FConstraintDescriptionEx._ScriptStructPtr != 0) ? FConstraintDescriptionEx._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnimationCore.ConstraintDescriptionEx", ref FConstraintDescriptionEx._ScriptStructPtr);
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x0003A7E0 File Offset: 0x000389E0
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x0003A823 File Offset: 0x00038A23
		public FFilterOptionPerAxis AxesFilterOption
		{
			get
			{
				base.FastCheckIsValid();
				FFilterOptionPerAxis result;
				if ((result = this._AxesFilterOption) == null)
				{
					result = (this._AxesFilterOption = new FFilterOptionPerAxis(base.NativePtr + (IntPtr)FConstraintDescriptionEx.__PropertyOffset_AxesFilterOption, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFilterOptionPerAxis.StaticStruct(), base.NativePtr + (IntPtr)FConstraintDescriptionEx.__PropertyOffset_AxesFilterOption, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060026E9 RID: 9961 RVA: 0x0003A844 File Offset: 0x00038A44
		public FConstraintDescriptionEx()
		{
		}

		// Token: 0x060026EA RID: 9962 RVA: 0x0003A84C File Offset: 0x00038A4C
		public FConstraintDescriptionEx(FFilterOptionPerAxis AxesFilterOption)
		{
			this.AxesFilterOption = AxesFilterOption;
		}

		// Token: 0x060026EB RID: 9963 RVA: 0x0003A85B File Offset: 0x00038A5B
		protected override IntPtr GetUStructPtr()
		{
			return FConstraintDescriptionEx.StaticStruct();
		}

		// Token: 0x060026EC RID: 9964 RVA: 0x0003A867 File Offset: 0x00038A67
		[NullableContext(2)]
		public FConstraintDescriptionEx(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060026ED RID: 9965 RVA: 0x0003A871 File Offset: 0x00038A71
		public FConstraintDescriptionEx(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060026EE RID: 9966 RVA: 0x0003A87C File Offset: 0x00038A7C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FConstraintDescriptionEx(Pointer, false, true);
		}

		// Token: 0x060026EF RID: 9967 RVA: 0x0003A886 File Offset: 0x00038A86
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FConstraintDescriptionEx(Pointer, MemoryOwner);
		}

		// Token: 0x04000F4C RID: 3916
		public const string __ObjectPath = "/Script/AnimationCore.ConstraintDescriptionEx";

		// Token: 0x04000F4D RID: 3917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000F4E RID: 3918
		internal static int __PropertyOffset_AxesFilterOption;

		// Token: 0x04000F4F RID: 3919
		[Nullable(2)]
		private FFilterOptionPerAxis _AxesFilterOption;
	}
}
