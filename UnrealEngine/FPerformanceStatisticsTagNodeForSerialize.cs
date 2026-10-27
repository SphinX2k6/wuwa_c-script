using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200192C RID: 6444
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsTagNodeForSerialize")]
	[UnrealStructLayout(28, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 28)]
	public class FPerformanceStatisticsTagNodeForSerialize : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E44 RID: 97860 RVA: 0x002303BE File Offset: 0x0022E5BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsTagNodeForSerialize._ScriptStructPtr != 0) ? FPerformanceStatisticsTagNodeForSerialize._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsTagNodeForSerialize", ref FPerformanceStatisticsTagNodeForSerialize._ScriptStructPtr);
		}

		// Token: 0x17005FDF RID: 24543
		// (get) Token: 0x06017E45 RID: 97861 RVA: 0x002303E2 File Offset: 0x0022E5E2
		// (set) Token: 0x06017E46 RID: 97862 RVA: 0x002303F6 File Offset: 0x0022E5F6
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17005FE0 RID: 24544
		// (get) Token: 0x06017E47 RID: 97863 RVA: 0x0023040B File Offset: 0x0022E60B
		// (set) Token: 0x06017E48 RID: 97864 RVA: 0x0023041B File Offset: 0x0022E61B
		public unsafe int RecordFramesCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_RecordFramesCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_RecordFramesCount) = value;
			}
		}

		// Token: 0x17005FE1 RID: 24545
		// (get) Token: 0x06017E49 RID: 97865 RVA: 0x0023042C File Offset: 0x0022E62C
		// (set) Token: 0x06017E4A RID: 97866 RVA: 0x0023043C File Offset: 0x0022E63C
		public unsafe float TotalTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_TotalTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_TotalTime) = value;
			}
		}

		// Token: 0x17005FE2 RID: 24546
		// (get) Token: 0x06017E4B RID: 97867 RVA: 0x0023044D File Offset: 0x0022E64D
		// (set) Token: 0x06017E4C RID: 97868 RVA: 0x0023045D File Offset: 0x0022E65D
		public unsafe float AverageTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_AverageTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_AverageTime) = value;
			}
		}

		// Token: 0x17005FE3 RID: 24547
		// (get) Token: 0x06017E4D RID: 97869 RVA: 0x0023046E File Offset: 0x0022E66E
		// (set) Token: 0x06017E4E RID: 97870 RVA: 0x0023047E File Offset: 0x0022E67E
		public unsafe float MaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_MaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsTagNodeForSerialize.__PropertyOffset_MaxTime) = value;
			}
		}

		// Token: 0x06017E4F RID: 97871 RVA: 0x0023048F File Offset: 0x0022E68F
		public FPerformanceStatisticsTagNodeForSerialize()
		{
		}

		// Token: 0x06017E50 RID: 97872 RVA: 0x00230497 File Offset: 0x0022E697
		public FPerformanceStatisticsTagNodeForSerialize(FName Tag, int RecordFramesCount, float TotalTime, float AverageTime, float MaxTime)
		{
			this.Tag = Tag;
			this.RecordFramesCount = RecordFramesCount;
			this.TotalTime = TotalTime;
			this.AverageTime = AverageTime;
			this.MaxTime = MaxTime;
		}

		// Token: 0x06017E51 RID: 97873 RVA: 0x002304C4 File Offset: 0x0022E6C4
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsTagNodeForSerialize.StaticStruct();
		}

		// Token: 0x06017E52 RID: 97874 RVA: 0x002304D0 File Offset: 0x0022E6D0
		[NullableContext(2)]
		public FPerformanceStatisticsTagNodeForSerialize(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E53 RID: 97875 RVA: 0x002304DA File Offset: 0x0022E6DA
		public FPerformanceStatisticsTagNodeForSerialize(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E54 RID: 97876 RVA: 0x002304E5 File Offset: 0x0022E6E5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsTagNodeForSerialize(Pointer, false, true);
		}

		// Token: 0x06017E55 RID: 97877 RVA: 0x002304EF File Offset: 0x0022E6EF
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsTagNodeForSerialize(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF06 RID: 52998
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsTagNodeForSerialize";

		// Token: 0x0400CF07 RID: 52999
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF08 RID: 53000
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400CF09 RID: 53001
		internal static int __PropertyOffset_RecordFramesCount;

		// Token: 0x0400CF0A RID: 53002
		internal static int __PropertyOffset_TotalTime;

		// Token: 0x0400CF0B RID: 53003
		internal static int __PropertyOffset_AverageTime;

		// Token: 0x0400CF0C RID: 53004
		internal static int __PropertyOffset_MaxTime;
	}
}
