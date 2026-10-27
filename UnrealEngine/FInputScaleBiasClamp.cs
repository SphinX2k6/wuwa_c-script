using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C5E RID: 3166
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InputScaleBiasClamp")]
	[UnrealStructLayout(48, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInputScaleBiasClamp : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A07B RID: 41083 RVA: 0x000E3F7E File Offset: 0x000E217E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInputScaleBiasClamp._ScriptStructPtr != 0) ? FInputScaleBiasClamp._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InputScaleBiasClamp", ref FInputScaleBiasClamp._ScriptStructPtr);
		}

		// Token: 0x17002633 RID: 9779
		// (get) Token: 0x0600A07C RID: 41084 RVA: 0x000E3FA2 File Offset: 0x000E21A2
		// (set) Token: 0x0600A07D RID: 41085 RVA: 0x000E3FB2 File Offset: 0x000E21B2
		public unsafe bool bMapRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bMapRange) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bMapRange) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002634 RID: 9780
		// (get) Token: 0x0600A07E RID: 41086 RVA: 0x000E3FC3 File Offset: 0x000E21C3
		// (set) Token: 0x0600A07F RID: 41087 RVA: 0x000E3FD3 File Offset: 0x000E21D3
		public unsafe bool bClampResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bClampResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bClampResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002635 RID: 9781
		// (get) Token: 0x0600A080 RID: 41088 RVA: 0x000E3FE4 File Offset: 0x000E21E4
		// (set) Token: 0x0600A081 RID: 41089 RVA: 0x000E3FF4 File Offset: 0x000E21F4
		public unsafe bool bInterpResult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bInterpResult) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_bInterpResult) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0600A082 RID: 41090 RVA: 0x000E4008 File Offset: 0x000E2208
		// (set) Token: 0x0600A083 RID: 41091 RVA: 0x000E404B File Offset: 0x000E224B
		public FInputRange InRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._InRange) == null)
				{
					result = (this._InRange = new FInputRange(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600A084 RID: 41092 RVA: 0x000E406C File Offset: 0x000E226C
		// (set) Token: 0x0600A085 RID: 41093 RVA: 0x000E40AF File Offset: 0x000E22AF
		public FInputRange OutRange
		{
			get
			{
				base.FastCheckIsValid();
				FInputRange result;
				if ((result = this._OutRange) == null)
				{
					result = (this._OutRange = new FInputRange(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_OutRange, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInputRange.StaticStruct(), base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_OutRange, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600A086 RID: 41094 RVA: 0x000E40D0 File Offset: 0x000E22D0
		// (set) Token: 0x0600A087 RID: 41095 RVA: 0x000E40E0 File Offset: 0x000E22E0
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600A088 RID: 41096 RVA: 0x000E40F1 File Offset: 0x000E22F1
		// (set) Token: 0x0600A089 RID: 41097 RVA: 0x000E4101 File Offset: 0x000E2301
		public unsafe float Bias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_Bias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_Bias) = value;
			}
		}

		// Token: 0x1700263A RID: 9786
		// (get) Token: 0x0600A08A RID: 41098 RVA: 0x000E4112 File Offset: 0x000E2312
		// (set) Token: 0x0600A08B RID: 41099 RVA: 0x000E4122 File Offset: 0x000E2322
		public unsafe float ClampMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_ClampMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_ClampMin) = value;
			}
		}

		// Token: 0x1700263B RID: 9787
		// (get) Token: 0x0600A08C RID: 41100 RVA: 0x000E4133 File Offset: 0x000E2333
		// (set) Token: 0x0600A08D RID: 41101 RVA: 0x000E4143 File Offset: 0x000E2343
		public unsafe float ClampMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_ClampMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_ClampMax) = value;
			}
		}

		// Token: 0x1700263C RID: 9788
		// (get) Token: 0x0600A08E RID: 41102 RVA: 0x000E4154 File Offset: 0x000E2354
		// (set) Token: 0x0600A08F RID: 41103 RVA: 0x000E4164 File Offset: 0x000E2364
		public unsafe float InterpSpeedIncreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InterpSpeedIncreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InterpSpeedIncreasing) = value;
			}
		}

		// Token: 0x1700263D RID: 9789
		// (get) Token: 0x0600A090 RID: 41104 RVA: 0x000E4175 File Offset: 0x000E2375
		// (set) Token: 0x0600A091 RID: 41105 RVA: 0x000E4185 File Offset: 0x000E2385
		public unsafe float InterpSpeedDecreasing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InterpSpeedDecreasing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInputScaleBiasClamp.__PropertyOffset_InterpSpeedDecreasing) = value;
			}
		}

		// Token: 0x0600A092 RID: 41106 RVA: 0x000E4196 File Offset: 0x000E2396
		public FInputScaleBiasClamp()
		{
		}

		// Token: 0x0600A093 RID: 41107 RVA: 0x000E41A0 File Offset: 0x000E23A0
		public FInputScaleBiasClamp(bool bMapRange, bool bClampResult, bool bInterpResult, FInputRange InRange, FInputRange OutRange, float Scale, float Bias, float ClampMin, float ClampMax, float InterpSpeedIncreasing, float InterpSpeedDecreasing)
		{
			this.bMapRange = bMapRange;
			this.bClampResult = bClampResult;
			this.bInterpResult = bInterpResult;
			this.InRange = InRange;
			this.OutRange = OutRange;
			this.Scale = Scale;
			this.Bias = Bias;
			this.ClampMin = ClampMin;
			this.ClampMax = ClampMax;
			this.InterpSpeedIncreasing = InterpSpeedIncreasing;
			this.InterpSpeedDecreasing = InterpSpeedDecreasing;
		}

		// Token: 0x0600A094 RID: 41108 RVA: 0x000E4208 File Offset: 0x000E2408
		protected override IntPtr GetUStructPtr()
		{
			return FInputScaleBiasClamp.StaticStruct();
		}

		// Token: 0x0600A095 RID: 41109 RVA: 0x000E4214 File Offset: 0x000E2414
		[NullableContext(2)]
		public FInputScaleBiasClamp(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A096 RID: 41110 RVA: 0x000E421E File Offset: 0x000E241E
		public FInputScaleBiasClamp(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A097 RID: 41111 RVA: 0x000E4229 File Offset: 0x000E2429
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInputScaleBiasClamp(Pointer, false, true);
		}

		// Token: 0x0600A098 RID: 41112 RVA: 0x000E4233 File Offset: 0x000E2433
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInputScaleBiasClamp(Pointer, MemoryOwner);
		}

		// Token: 0x0400583A RID: 22586
		public const string __ObjectPath = "/Script/Engine.InputScaleBiasClamp";

		// Token: 0x0400583B RID: 22587
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400583C RID: 22588
		internal static int __PropertyOffset_bMapRange;

		// Token: 0x0400583D RID: 22589
		internal static int __PropertyOffset_bClampResult;

		// Token: 0x0400583E RID: 22590
		internal static int __PropertyOffset_bInterpResult;

		// Token: 0x0400583F RID: 22591
		internal static int __PropertyOffset_InRange;

		// Token: 0x04005840 RID: 22592
		[Nullable(2)]
		private FInputRange _InRange;

		// Token: 0x04005841 RID: 22593
		internal static int __PropertyOffset_OutRange;

		// Token: 0x04005842 RID: 22594
		[Nullable(2)]
		private FInputRange _OutRange;

		// Token: 0x04005843 RID: 22595
		internal static int __PropertyOffset_Scale;

		// Token: 0x04005844 RID: 22596
		internal static int __PropertyOffset_Bias;

		// Token: 0x04005845 RID: 22597
		internal static int __PropertyOffset_ClampMin;

		// Token: 0x04005846 RID: 22598
		internal static int __PropertyOffset_ClampMax;

		// Token: 0x04005847 RID: 22599
		internal static int __PropertyOffset_InterpSpeedIncreasing;

		// Token: 0x04005848 RID: 22600
		internal static int __PropertyOffset_InterpSpeedDecreasing;
	}
}
