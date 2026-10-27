using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B2A RID: 6954
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroInterpolateRangeTime : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A3E6 RID: 107494 RVA: 0x0026BB78 File Offset: 0x00269D78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInterpolateRangeTime._ScriptStructPtr != 0) ? FKuroInterpolateRangeTime._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime", ref FKuroInterpolateRangeTime._ScriptStructPtr);
		}

		// Token: 0x1700698C RID: 27020
		// (get) Token: 0x0601A3E7 RID: 107495 RVA: 0x0026BB9C File Offset: 0x00269D9C
		// (set) Token: 0x0601A3E8 RID: 107496 RVA: 0x0026BBAC File Offset: 0x00269DAC
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x1700698D RID: 27021
		// (get) Token: 0x0601A3E9 RID: 107497 RVA: 0x0026BBBD File Offset: 0x00269DBD
		// (set) Token: 0x0601A3EA RID: 107498 RVA: 0x0026BBCD File Offset: 0x00269DCD
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_Loop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_Loop) = value;
			}
		}

		// Token: 0x1700698E RID: 27022
		// (get) Token: 0x0601A3EB RID: 107499 RVA: 0x0026BBDE File Offset: 0x00269DDE
		// (set) Token: 0x0601A3EC RID: 107500 RVA: 0x0026BBEE File Offset: 0x00269DEE
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x0601A3ED RID: 107501 RVA: 0x0026BBFF File Offset: 0x00269DFF
		public FKuroInterpolateRangeTime()
		{
		}

		// Token: 0x0601A3EE RID: 107502 RVA: 0x0026BC07 File Offset: 0x00269E07
		public FKuroInterpolateRangeTime(float Start, float Loop, float End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x0601A3EF RID: 107503 RVA: 0x0026BC24 File Offset: 0x00269E24
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInterpolateRangeTime.StaticStruct();
		}

		// Token: 0x0601A3F0 RID: 107504 RVA: 0x0026BC30 File Offset: 0x00269E30
		[NullableContext(2)]
		public FKuroInterpolateRangeTime(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A3F1 RID: 107505 RVA: 0x0026BC3A File Offset: 0x00269E3A
		public FKuroInterpolateRangeTime(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A3F2 RID: 107506 RVA: 0x0026BC45 File Offset: 0x00269E45
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInterpolateRangeTime(Pointer, false, true);
		}

		// Token: 0x0601A3F3 RID: 107507 RVA: 0x0026BC4F File Offset: 0x00269E4F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInterpolateRangeTime(Pointer, MemoryOwner);
		}

		// Token: 0x0400E3F1 RID: 58353
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime";

		// Token: 0x0400E3F2 RID: 58354
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E3F3 RID: 58355
		internal static int __PropertyOffset_Start;

		// Token: 0x0400E3F4 RID: 58356
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400E3F5 RID: 58357
		internal static int __PropertyOffset_End;
	}
}
