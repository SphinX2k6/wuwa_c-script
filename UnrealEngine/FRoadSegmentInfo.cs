using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000419 RID: 1049
	[UnrealObjectPath("/Script/KuroGameplay.RoadSegmentInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRoadSegmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060065A4 RID: 26020 RVA: 0x0009197C File Offset: 0x0008FB7C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRoadSegmentInfo._ScriptStructPtr != 0) ? FRoadSegmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.RoadSegmentInfo", ref FRoadSegmentInfo._ScriptStructPtr);
		}

		// Token: 0x17001439 RID: 5177
		// (get) Token: 0x060065A5 RID: 26021 RVA: 0x000919A0 File Offset: 0x0008FBA0
		// (set) Token: 0x060065A6 RID: 26022 RVA: 0x000919B0 File Offset: 0x0008FBB0
		public unsafe float StartKey
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRoadSegmentInfo.__PropertyOffset_StartKey);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRoadSegmentInfo.__PropertyOffset_StartKey) = value;
			}
		}

		// Token: 0x1700143A RID: 5178
		// (get) Token: 0x060065A7 RID: 26023 RVA: 0x000919C1 File Offset: 0x0008FBC1
		// (set) Token: 0x060065A8 RID: 26024 RVA: 0x000919D5 File Offset: 0x0008FBD5
		[Nullable(2)]
		public unsafe UKuroRoadway RoadInfo
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRoadway>(base.NativePtr / (IntPtr)sizeof(void*) + FRoadSegmentInfo.__PropertyOffset_RoadInfo);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FRoadSegmentInfo.__PropertyOffset_RoadInfo, value);
			}
		}

		// Token: 0x060065A9 RID: 26025 RVA: 0x000919EA File Offset: 0x0008FBEA
		public FRoadSegmentInfo()
		{
		}

		// Token: 0x060065AA RID: 26026 RVA: 0x000919F2 File Offset: 0x0008FBF2
		protected override IntPtr GetUStructPtr()
		{
			return FRoadSegmentInfo.StaticStruct();
		}

		// Token: 0x060065AB RID: 26027 RVA: 0x000919FE File Offset: 0x0008FBFE
		[NullableContext(2)]
		public FRoadSegmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060065AC RID: 26028 RVA: 0x00091A08 File Offset: 0x0008FC08
		public FRoadSegmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060065AD RID: 26029 RVA: 0x00091A13 File Offset: 0x0008FC13
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRoadSegmentInfo(Pointer, false, true);
		}

		// Token: 0x060065AE RID: 26030 RVA: 0x00091A1D File Offset: 0x0008FC1D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRoadSegmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04002AC1 RID: 10945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.RoadSegmentInfo";

		// Token: 0x04002AC2 RID: 10946
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002AC3 RID: 10947
		internal static int __PropertyOffset_StartKey;

		// Token: 0x04002AC4 RID: 10948
		internal static int __PropertyOffset_RoadInfo;
	}
}
