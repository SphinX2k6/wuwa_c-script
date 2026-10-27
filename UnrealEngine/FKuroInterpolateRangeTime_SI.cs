using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001B2B RID: 6955
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime_SI")]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 12)]
	public class FKuroInterpolateRangeTime_SI : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601A3F4 RID: 107508 RVA: 0x0026BC58 File Offset: 0x00269E58
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroInterpolateRangeTime_SI._ScriptStructPtr != 0) ? FKuroInterpolateRangeTime_SI._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime_SI", ref FKuroInterpolateRangeTime_SI._ScriptStructPtr);
		}

		// Token: 0x1700698F RID: 27023
		// (get) Token: 0x0601A3F5 RID: 107509 RVA: 0x0026BC7C File Offset: 0x00269E7C
		// (set) Token: 0x0601A3F6 RID: 107510 RVA: 0x0026BC8C File Offset: 0x00269E8C
		public unsafe float Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17006990 RID: 27024
		// (get) Token: 0x0601A3F7 RID: 107511 RVA: 0x0026BC9D File Offset: 0x00269E9D
		// (set) Token: 0x0601A3F8 RID: 107512 RVA: 0x0026BCAD File Offset: 0x00269EAD
		public unsafe float Loop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_Loop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_Loop) = value;
			}
		}

		// Token: 0x17006991 RID: 27025
		// (get) Token: 0x0601A3F9 RID: 107513 RVA: 0x0026BCBE File Offset: 0x00269EBE
		// (set) Token: 0x0601A3FA RID: 107514 RVA: 0x0026BCCE File Offset: 0x00269ECE
		public unsafe float End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroInterpolateRangeTime_SI.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x0601A3FB RID: 107515 RVA: 0x0026BCDF File Offset: 0x00269EDF
		public FKuroInterpolateRangeTime_SI()
		{
		}

		// Token: 0x0601A3FC RID: 107516 RVA: 0x0026BCE7 File Offset: 0x00269EE7
		public FKuroInterpolateRangeTime_SI(float Start, float Loop, float End)
		{
			this.Start = Start;
			this.Loop = Loop;
			this.End = End;
		}

		// Token: 0x0601A3FD RID: 107517 RVA: 0x0026BD04 File Offset: 0x00269F04
		protected override IntPtr GetUStructPtr()
		{
			return FKuroInterpolateRangeTime_SI.StaticStruct();
		}

		// Token: 0x0601A3FE RID: 107518 RVA: 0x0026BD10 File Offset: 0x00269F10
		[NullableContext(2)]
		public FKuroInterpolateRangeTime_SI(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601A3FF RID: 107519 RVA: 0x0026BD1A File Offset: 0x00269F1A
		public FKuroInterpolateRangeTime_SI(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601A400 RID: 107520 RVA: 0x0026BD25 File Offset: 0x00269F25
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroInterpolateRangeTime_SI(Pointer, false, true);
		}

		// Token: 0x0601A401 RID: 107521 RVA: 0x0026BD2F File Offset: 0x00269F2F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroInterpolateRangeTime_SI(Pointer, MemoryOwner);
		}

		// Token: 0x0400E3F6 RID: 58358
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroInterpolateRangeTime_SI";

		// Token: 0x0400E3F7 RID: 58359
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E3F8 RID: 58360
		internal static int __PropertyOffset_Start;

		// Token: 0x0400E3F9 RID: 58361
		internal static int __PropertyOffset_Loop;

		// Token: 0x0400E3FA RID: 58362
		internal static int __PropertyOffset_End;
	}
}
