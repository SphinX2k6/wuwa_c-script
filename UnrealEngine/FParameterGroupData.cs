using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000F3E RID: 3902
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ParameterGroupData")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FParameterGroupData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600D27B RID: 53883 RVA: 0x0013478B File Offset: 0x0013298B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FParameterGroupData._ScriptStructPtr != 0) ? FParameterGroupData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ParameterGroupData", ref FParameterGroupData._ScriptStructPtr);
		}

		// Token: 0x1700312F RID: 12591
		// (get) Token: 0x0600D27C RID: 53884 RVA: 0x001347AF File Offset: 0x001329AF
		// (set) Token: 0x0600D27D RID: 53885 RVA: 0x001347C3 File Offset: 0x001329C3
		public unsafe string GroupName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FParameterGroupData.__PropertyOffset_GroupName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FParameterGroupData.__PropertyOffset_GroupName)), value);
			}
		}

		// Token: 0x17003130 RID: 12592
		// (get) Token: 0x0600D27E RID: 53886 RVA: 0x001347D8 File Offset: 0x001329D8
		// (set) Token: 0x0600D27F RID: 53887 RVA: 0x001347E8 File Offset: 0x001329E8
		public unsafe int GroupSortPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FParameterGroupData.__PropertyOffset_GroupSortPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FParameterGroupData.__PropertyOffset_GroupSortPriority) = value;
			}
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x001347F9 File Offset: 0x001329F9
		public FParameterGroupData()
		{
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x00134801 File Offset: 0x00132A01
		public FParameterGroupData(string GroupName, int GroupSortPriority)
		{
			this.GroupName = GroupName;
			this.GroupSortPriority = GroupSortPriority;
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x00134817 File Offset: 0x00132A17
		protected override IntPtr GetUStructPtr()
		{
			return FParameterGroupData.StaticStruct();
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x00134823 File Offset: 0x00132A23
		[NullableContext(2)]
		public FParameterGroupData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600D284 RID: 53892 RVA: 0x0013482D File Offset: 0x00132A2D
		public FParameterGroupData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600D285 RID: 53893 RVA: 0x00134838 File Offset: 0x00132A38
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FParameterGroupData(Pointer, false, true);
		}

		// Token: 0x0600D286 RID: 53894 RVA: 0x00134842 File Offset: 0x00132A42
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FParameterGroupData(Pointer, MemoryOwner);
		}

		// Token: 0x040070F4 RID: 28916
		public const string __ObjectPath = "/Script/Engine.ParameterGroupData";

		// Token: 0x040070F5 RID: 28917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040070F6 RID: 28918
		internal static int __PropertyOffset_GroupName;

		// Token: 0x040070F7 RID: 28919
		internal static int __PropertyOffset_GroupSortPriority;
	}
}
