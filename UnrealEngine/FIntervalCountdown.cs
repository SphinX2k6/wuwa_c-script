using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001CC RID: 460
	[UnrealObjectPath("/Script/AIModule.IntervalCountdown")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FIntervalCountdown : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001B2D RID: 6957 RVA: 0x00028911 File Offset: 0x00026B11
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntervalCountdown._ScriptStructPtr != 0) ? FIntervalCountdown._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.IntervalCountdown", ref FIntervalCountdown._ScriptStructPtr);
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x06001B2E RID: 6958 RVA: 0x00028935 File Offset: 0x00026B35
		// (set) Token: 0x06001B2F RID: 6959 RVA: 0x00028945 File Offset: 0x00026B45
		public unsafe float Interval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FIntervalCountdown.__PropertyOffset_Interval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FIntervalCountdown.__PropertyOffset_Interval) = value;
			}
		}

		// Token: 0x06001B30 RID: 6960 RVA: 0x00028956 File Offset: 0x00026B56
		public FIntervalCountdown()
		{
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x0002895E File Offset: 0x00026B5E
		public FIntervalCountdown(float Interval)
		{
			this.Interval = Interval;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x0002896D File Offset: 0x00026B6D
		protected override IntPtr GetUStructPtr()
		{
			return FIntervalCountdown.StaticStruct();
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00028979 File Offset: 0x00026B79
		[NullableContext(2)]
		public FIntervalCountdown(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x00028983 File Offset: 0x00026B83
		public FIntervalCountdown(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x0002898E File Offset: 0x00026B8E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FIntervalCountdown(Pointer, false, true);
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x00028998 File Offset: 0x00026B98
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FIntervalCountdown(Pointer, MemoryOwner);
		}

		// Token: 0x040008B2 RID: 2226
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.IntervalCountdown";

		// Token: 0x040008B3 RID: 2227
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040008B4 RID: 2228
		internal static int __PropertyOffset_Interval;
	}
}
