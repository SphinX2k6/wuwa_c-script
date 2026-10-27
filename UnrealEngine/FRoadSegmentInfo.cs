using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001932 RID: 6450
	[UnrealObjectPath("/Script/KuroGameplay.RoadSegmentInfo")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FRoadSegmentInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E98 RID: 97944 RVA: 0x00230B58 File Offset: 0x0022ED58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRoadSegmentInfo._ScriptStructPtr != 0) ? FRoadSegmentInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.RoadSegmentInfo", ref FRoadSegmentInfo._ScriptStructPtr);
		}

		// Token: 0x17005FF0 RID: 24560
		// (get) Token: 0x06017E99 RID: 97945 RVA: 0x00230B7C File Offset: 0x0022ED7C
		// (set) Token: 0x06017E9A RID: 97946 RVA: 0x00230B8C File Offset: 0x0022ED8C
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

		// Token: 0x17005FF1 RID: 24561
		// (get) Token: 0x06017E9B RID: 97947 RVA: 0x00230B9D File Offset: 0x0022ED9D
		// (set) Token: 0x06017E9C RID: 97948 RVA: 0x00230BB1 File Offset: 0x0022EDB1
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

		// Token: 0x06017E9D RID: 97949 RVA: 0x00230BC6 File Offset: 0x0022EDC6
		public FRoadSegmentInfo()
		{
		}

		// Token: 0x06017E9E RID: 97950 RVA: 0x00230BCE File Offset: 0x0022EDCE
		[NullableContext(1)]
		public FRoadSegmentInfo(float StartKey, UKuroRoadway RoadInfo)
		{
			this.StartKey = StartKey;
			this.RoadInfo = RoadInfo;
		}

		// Token: 0x06017E9F RID: 97951 RVA: 0x00230BE4 File Offset: 0x0022EDE4
		protected override IntPtr GetUStructPtr()
		{
			return FRoadSegmentInfo.StaticStruct();
		}

		// Token: 0x06017EA0 RID: 97952 RVA: 0x00230BF0 File Offset: 0x0022EDF0
		[NullableContext(2)]
		public FRoadSegmentInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017EA1 RID: 97953 RVA: 0x00230BFA File Offset: 0x0022EDFA
		public FRoadSegmentInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017EA2 RID: 97954 RVA: 0x00230C05 File Offset: 0x0022EE05
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRoadSegmentInfo(Pointer, false, true);
		}

		// Token: 0x06017EA3 RID: 97955 RVA: 0x00230C0F File Offset: 0x0022EE0F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRoadSegmentInfo(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF27 RID: 53031
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.RoadSegmentInfo";

		// Token: 0x0400CF28 RID: 53032
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF29 RID: 53033
		internal static int __PropertyOffset_StartKey;

		// Token: 0x0400CF2A RID: 53034
		internal static int __PropertyOffset_RoadInfo;
	}
}
