using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200192F RID: 6447
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.PerformanceStatisticsUnitRecord")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FPerformanceStatisticsUnitRecord : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06017E74 RID: 97908 RVA: 0x00230767 File Offset: 0x0022E967
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPerformanceStatisticsUnitRecord._ScriptStructPtr != 0) ? FPerformanceStatisticsUnitRecord._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.PerformanceStatisticsUnitRecord", ref FPerformanceStatisticsUnitRecord._ScriptStructPtr);
		}

		// Token: 0x17005FEB RID: 24555
		// (get) Token: 0x06017E75 RID: 97909 RVA: 0x0023078B File Offset: 0x0022E98B
		// (set) Token: 0x06017E76 RID: 97910 RVA: 0x0023079B File Offset: 0x0022E99B
		public unsafe int FrameCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_FrameCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_FrameCount) = value;
			}
		}

		// Token: 0x17005FEC RID: 24556
		// (get) Token: 0x06017E77 RID: 97911 RVA: 0x002307AC File Offset: 0x0022E9AC
		// (set) Token: 0x06017E78 RID: 97912 RVA: 0x002307C0 File Offset: 0x0022E9C0
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17005FED RID: 24557
		// (get) Token: 0x06017E79 RID: 97913 RVA: 0x002307D5 File Offset: 0x0022E9D5
		// (set) Token: 0x06017E7A RID: 97914 RVA: 0x002307E5 File Offset: 0x0022E9E5
		public unsafe int Mode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Mode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Mode) = value;
			}
		}

		// Token: 0x17005FEE RID: 24558
		// (get) Token: 0x06017E7B RID: 97915 RVA: 0x002307F6 File Offset: 0x0022E9F6
		// (set) Token: 0x06017E7C RID: 97916 RVA: 0x00230806 File Offset: 0x0022EA06
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17005FEF RID: 24559
		// (get) Token: 0x06017E7D RID: 97917 RVA: 0x00230817 File Offset: 0x0022EA17
		// (set) Token: 0x06017E7E RID: 97918 RVA: 0x0023082B File Offset: 0x0022EA2B
		public unsafe string UserDefineMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_UserDefineMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPerformanceStatisticsUnitRecord.__PropertyOffset_UserDefineMessage)), value);
			}
		}

		// Token: 0x06017E7F RID: 97919 RVA: 0x00230840 File Offset: 0x0022EA40
		public FPerformanceStatisticsUnitRecord()
		{
		}

		// Token: 0x06017E80 RID: 97920 RVA: 0x00230848 File Offset: 0x0022EA48
		public FPerformanceStatisticsUnitRecord(int FrameCount, FName Tag, int Mode, float Time, string UserDefineMessage)
		{
			this.FrameCount = FrameCount;
			this.Tag = Tag;
			this.Mode = Mode;
			this.Time = Time;
			this.UserDefineMessage = UserDefineMessage;
		}

		// Token: 0x06017E81 RID: 97921 RVA: 0x00230875 File Offset: 0x0022EA75
		protected override IntPtr GetUStructPtr()
		{
			return FPerformanceStatisticsUnitRecord.StaticStruct();
		}

		// Token: 0x06017E82 RID: 97922 RVA: 0x00230881 File Offset: 0x0022EA81
		[NullableContext(2)]
		public FPerformanceStatisticsUnitRecord(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06017E83 RID: 97923 RVA: 0x0023088B File Offset: 0x0022EA8B
		public FPerformanceStatisticsUnitRecord(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06017E84 RID: 97924 RVA: 0x00230896 File Offset: 0x0022EA96
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPerformanceStatisticsUnitRecord(Pointer, false, true);
		}

		// Token: 0x06017E85 RID: 97925 RVA: 0x002308A0 File Offset: 0x0022EAA0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPerformanceStatisticsUnitRecord(Pointer, MemoryOwner);
		}

		// Token: 0x0400CF1A RID: 53018
		public const string __ObjectPath = "/Script/KuroGameplay.PerformanceStatisticsUnitRecord";

		// Token: 0x0400CF1B RID: 53019
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CF1C RID: 53020
		internal static int __PropertyOffset_FrameCount;

		// Token: 0x0400CF1D RID: 53021
		internal static int __PropertyOffset_Tag;

		// Token: 0x0400CF1E RID: 53022
		internal static int __PropertyOffset_Mode;

		// Token: 0x0400CF1F RID: 53023
		internal static int __PropertyOffset_Time;

		// Token: 0x0400CF20 RID: 53024
		internal static int __PropertyOffset_UserDefineMessage;
	}
}
