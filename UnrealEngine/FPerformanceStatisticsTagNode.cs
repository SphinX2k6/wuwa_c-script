using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200192B RID: 6443
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsTagNode")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FPerformanceStatisticsTagNode : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E32 RID: 97842 RVA: 0x00230284 File Offset: 0x0022E484
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsTagNode._ScriptStructPtr != 0) ? FPerformanceStatisticsTagNode._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsTagNode", ref FPerformanceStatisticsTagNode._ScriptStructPtr);
		}

		// Token: 0x17005FDA RID: 24538
		// (get) Token: 0x06017E33 RID: 97843 RVA: 0x002302A8 File Offset: 0x0022E4A8
		// (set) Token: 0x06017E34 RID: 97844 RVA: 0x002302BC File Offset: 0x0022E4BC
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17005FDB RID: 24539
		// (get) Token: 0x06017E35 RID: 97845 RVA: 0x002302D1 File Offset: 0x0022E4D1
		// (set) Token: 0x06017E36 RID: 97846 RVA: 0x002302E1 File Offset: 0x0022E4E1
		public unsafe int RecordFramesCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_RecordFramesCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_RecordFramesCount) = value;
			}
		}

		// Token: 0x17005FDC RID: 24540
		// (get) Token: 0x06017E37 RID: 97847 RVA: 0x002302F2 File Offset: 0x0022E4F2
		// (set) Token: 0x06017E38 RID: 97848 RVA: 0x00230302 File Offset: 0x0022E502
		public unsafe float TotalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_TotalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_TotalTime) = value;
			}
		}

		// Token: 0x17005FDD RID: 24541
		// (get) Token: 0x06017E39 RID: 97849 RVA: 0x00230313 File Offset: 0x0022E513
		// (set) Token: 0x06017E3A RID: 97850 RVA: 0x00230323 File Offset: 0x0022E523
		public unsafe float AverageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_AverageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_AverageTime) = value;
			}
		}

		// Token: 0x17005FDE RID: 24542
		// (get) Token: 0x06017E3B RID: 97851 RVA: 0x00230334 File Offset: 0x0022E534
		// (set) Token: 0x06017E3C RID: 97852 RVA: 0x00230344 File Offset: 0x0022E544
		public unsafe float MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_MaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNode.__PropertyOffset_MaxTime) = value;
			}
		}

		// Token: 0x06017E3D RID: 97853 RVA: 0x00230355 File Offset: 0x0022E555
		public FPerformanceStatisticsTagNode()
		{
		}

		// Token: 0x06017E3E RID: 97854 RVA: 0x0023035D File Offset: 0x0022E55D
		public FPerformanceStatisticsTagNode(FName Tag, int RecordFramesCount, float TotalTime, float AverageTime, float MaxTime)
		{
			this.Tag = Tag;
			this.RecordFramesCount = RecordFramesCount;
			this.TotalTime = TotalTime;
			this.AverageTime = AverageTime;
			this.MaxTime = MaxTime;
		}

		// Token: 0x06017E3F RID: 97855 RVA: 0x0023038A File Offset: 0x0022E58A
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsTagNode.StaticStruct();
		}

		// Token: 0x06017E40 RID: 97856 RVA: 0x00230396 File Offset: 0x0022E596
		[NullableContext(2)]
		public FPerformanceStatisticsTagNode(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E41 RID: 97857 RVA: 0x002303A0 File Offset: 0x0022E5A0
		public FPerformanceStatisticsTagNode(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E42 RID: 97858 RVA: 0x002303AB File Offset: 0x0022E5AB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsTagNode(Pointer, false, true);
		}

		// Token: 0x06017E43 RID: 97859 RVA: 0x002303B5 File Offset: 0x0022E5B5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsTagNode(Pointer, MemoryOwner);
		}

		// Token: 0x0400CEFF RID: 52991
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsTagNode";

		// Token: 0x0400CF00 RID: 52992
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF01 RID: 52993
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400CF02 RID: 52994
		internal static int __PropertyOffset_RecordFramesCount;

		// Token: 0x0400CF03 RID: 52995
		internal static int __PropertyOffset_TotalTime;

		// Token: 0x0400CF04 RID: 52996
		internal static int __PropertyOffset_AverageTime;

		// Token: 0x0400CF05 RID: 52997
		internal static int __PropertyOffset_MaxTime;
	}
}
