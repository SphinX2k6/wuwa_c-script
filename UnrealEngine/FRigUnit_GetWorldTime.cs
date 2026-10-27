using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020005C1 RID: 1473
	[UnrealObjectPath("/Script/ControlRig.RigUnit_GetWorldTime")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRigUnit_GetWorldTime : FRigUnit_AnimBase, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004F95 RID: 20373 RVA: 0x00075801 File Offset: 0x00073A01
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRigUnit_GetWorldTime._ScriptStructPtr != 0) ? FRigUnit_GetWorldTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ControlRig.RigUnit_GetWorldTime", ref FRigUnit_GetWorldTime._ScriptStructPtr);
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06004F96 RID: 20374 RVA: 0x00075825 File Offset: 0x00073A25
		// (set) Token: 0x06004F97 RID: 20375 RVA: 0x00075835 File Offset: 0x00073A35
		public unsafe float Year
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Year);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Year) = value;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06004F98 RID: 20376 RVA: 0x00075846 File Offset: 0x00073A46
		// (set) Token: 0x06004F99 RID: 20377 RVA: 0x00075856 File Offset: 0x00073A56
		public unsafe float Month
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Month);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Month) = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06004F9A RID: 20378 RVA: 0x00075867 File Offset: 0x00073A67
		// (set) Token: 0x06004F9B RID: 20379 RVA: 0x00075877 File Offset: 0x00073A77
		public unsafe float Day
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Day);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Day) = value;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06004F9C RID: 20380 RVA: 0x00075888 File Offset: 0x00073A88
		// (set) Token: 0x06004F9D RID: 20381 RVA: 0x00075898 File Offset: 0x00073A98
		public unsafe float WeekDay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_WeekDay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_WeekDay) = value;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06004F9E RID: 20382 RVA: 0x000758A9 File Offset: 0x00073AA9
		// (set) Token: 0x06004F9F RID: 20383 RVA: 0x000758B9 File Offset: 0x00073AB9
		public unsafe float Hours
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Hours);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Hours) = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06004FA0 RID: 20384 RVA: 0x000758CA File Offset: 0x00073ACA
		// (set) Token: 0x06004FA1 RID: 20385 RVA: 0x000758DA File Offset: 0x00073ADA
		public unsafe float Minutes
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Minutes);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Minutes) = value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x06004FA2 RID: 20386 RVA: 0x000758EB File Offset: 0x00073AEB
		// (set) Token: 0x06004FA3 RID: 20387 RVA: 0x000758FB File Offset: 0x00073AFB
		public unsafe float Seconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Seconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_Seconds) = value;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x06004FA4 RID: 20388 RVA: 0x0007590C File Offset: 0x00073B0C
		// (set) Token: 0x06004FA5 RID: 20389 RVA: 0x0007591C File Offset: 0x00073B1C
		public unsafe float OverallSeconds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_OverallSeconds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRigUnit_GetWorldTime.__PropertyOffset_OverallSeconds) = value;
			}
		}

		// Token: 0x06004FA6 RID: 20390 RVA: 0x0007592D File Offset: 0x00073B2D
		public FRigUnit_GetWorldTime()
		{
		}

		// Token: 0x06004FA7 RID: 20391 RVA: 0x00075938 File Offset: 0x00073B38
		public FRigUnit_GetWorldTime(float Year, float Month, float Day, float WeekDay, float Hours, float Minutes, float Seconds, float OverallSeconds)
		{
			this.Year = Year;
			this.Month = Month;
			this.Day = Day;
			this.WeekDay = WeekDay;
			this.Hours = Hours;
			this.Minutes = Minutes;
			this.Seconds = Seconds;
			this.OverallSeconds = OverallSeconds;
		}

		// Token: 0x06004FA8 RID: 20392 RVA: 0x00075988 File Offset: 0x00073B88
		protected override IntPtr GetUStructPtr()
		{
			return FRigUnit_GetWorldTime.StaticStruct();
		}

		// Token: 0x06004FA9 RID: 20393 RVA: 0x00075994 File Offset: 0x00073B94
		[NullableContext(2)]
		public FRigUnit_GetWorldTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004FAA RID: 20394 RVA: 0x0007599E File Offset: 0x00073B9E
		public FRigUnit_GetWorldTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004FAB RID: 20395 RVA: 0x000759A9 File Offset: 0x00073BA9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRigUnit_GetWorldTime(Pointer, false, true);
		}

		// Token: 0x06004FAC RID: 20396 RVA: 0x000759B3 File Offset: 0x00073BB3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRigUnit_GetWorldTime(Pointer, MemoryOwner);
		}

		// Token: 0x0400266A RID: 9834
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/ControlRig.RigUnit_GetWorldTime";

		// Token: 0x0400266B RID: 9835
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400266C RID: 9836
		internal static int __PropertyOffset_Year;

		// Token: 0x0400266D RID: 9837
		internal static int __PropertyOffset_Month;

		// Token: 0x0400266E RID: 9838
		internal static int __PropertyOffset_Day;

		// Token: 0x0400266F RID: 9839
		internal static int __PropertyOffset_WeekDay;

		// Token: 0x04002670 RID: 9840
		internal static int __PropertyOffset_Hours;

		// Token: 0x04002671 RID: 9841
		internal static int __PropertyOffset_Minutes;

		// Token: 0x04002672 RID: 9842
		internal static int __PropertyOffset_Seconds;

		// Token: 0x04002673 RID: 9843
		internal static int __PropertyOffset_OverallSeconds;
	}
}
