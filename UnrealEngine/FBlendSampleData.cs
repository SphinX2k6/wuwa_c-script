using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020008B3 RID: 2227
	[UnrealObjectPath("/Script/Engine.BlendSampleData")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FBlendSampleData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060079B1 RID: 31153 RVA: 0x000AE0EB File Offset: 0x000AC2EB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBlendSampleData._ScriptStructPtr != 0) ? FBlendSampleData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BlendSampleData", ref FBlendSampleData._ScriptStructPtr);
		}

		// Token: 0x17001CBD RID: 7357
		// (get) Token: 0x060079B2 RID: 31154 RVA: 0x000AE10F File Offset: 0x000AC30F
		// (set) Token: 0x060079B3 RID: 31155 RVA: 0x000AE11F File Offset: 0x000AC31F
		public unsafe int SampleDataIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_SampleDataIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_SampleDataIndex) = value;
			}
		}

		// Token: 0x17001CBE RID: 7358
		// (get) Token: 0x060079B4 RID: 31156 RVA: 0x000AE130 File Offset: 0x000AC330
		// (set) Token: 0x060079B5 RID: 31157 RVA: 0x000AE144 File Offset: 0x000AC344
		[Nullable(2)]
		public unsafe UAnimSequence Animation
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequence>(base.NativePtr / (IntPtr)sizeof(void*) + FBlendSampleData.__PropertyOffset_Animation);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FBlendSampleData.__PropertyOffset_Animation, value);
			}
		}

		// Token: 0x17001CBF RID: 7359
		// (get) Token: 0x060079B6 RID: 31158 RVA: 0x000AE159 File Offset: 0x000AC359
		// (set) Token: 0x060079B7 RID: 31159 RVA: 0x000AE169 File Offset: 0x000AC369
		public unsafe float TotalWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_TotalWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_TotalWeight) = value;
			}
		}

		// Token: 0x17001CC0 RID: 7360
		// (get) Token: 0x060079B8 RID: 31160 RVA: 0x000AE17A File Offset: 0x000AC37A
		// (set) Token: 0x060079B9 RID: 31161 RVA: 0x000AE18A File Offset: 0x000AC38A
		public unsafe float Time
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_Time);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_Time) = value;
			}
		}

		// Token: 0x17001CC1 RID: 7361
		// (get) Token: 0x060079BA RID: 31162 RVA: 0x000AE19B File Offset: 0x000AC39B
		// (set) Token: 0x060079BB RID: 31163 RVA: 0x000AE1AB File Offset: 0x000AC3AB
		public unsafe float PreviousTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_PreviousTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_PreviousTime) = value;
			}
		}

		// Token: 0x17001CC2 RID: 7362
		// (get) Token: 0x060079BC RID: 31164 RVA: 0x000AE1BC File Offset: 0x000AC3BC
		// (set) Token: 0x060079BD RID: 31165 RVA: 0x000AE1CC File Offset: 0x000AC3CC
		public unsafe float SamplePlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_SamplePlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBlendSampleData.__PropertyOffset_SamplePlayRate) = value;
			}
		}

		// Token: 0x060079BE RID: 31166 RVA: 0x000AE1DD File Offset: 0x000AC3DD
		public FBlendSampleData()
		{
		}

		// Token: 0x060079BF RID: 31167 RVA: 0x000AE1E5 File Offset: 0x000AC3E5
		[NullableContext(1)]
		public FBlendSampleData(int SampleDataIndex, UAnimSequence Animation, float TotalWeight, float Time, float PreviousTime, float SamplePlayRate)
		{
			this.SampleDataIndex = SampleDataIndex;
			this.Animation = Animation;
			this.TotalWeight = TotalWeight;
			this.Time = Time;
			this.PreviousTime = PreviousTime;
			this.SamplePlayRate = SamplePlayRate;
		}

		// Token: 0x060079C0 RID: 31168 RVA: 0x000AE21A File Offset: 0x000AC41A
		protected override IntPtr GetUStructPtr()
		{
			return FBlendSampleData.StaticStruct();
		}

		// Token: 0x060079C1 RID: 31169 RVA: 0x000AE226 File Offset: 0x000AC426
		[NullableContext(2)]
		public FBlendSampleData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060079C2 RID: 31170 RVA: 0x000AE230 File Offset: 0x000AC430
		public FBlendSampleData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060079C3 RID: 31171 RVA: 0x000AE23B File Offset: 0x000AC43B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBlendSampleData(Pointer, false, true);
		}

		// Token: 0x060079C4 RID: 31172 RVA: 0x000AE245 File Offset: 0x000AC445
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBlendSampleData(Pointer, MemoryOwner);
		}

		// Token: 0x04003A78 RID: 14968
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BlendSampleData";

		// Token: 0x04003A79 RID: 14969
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A7A RID: 14970
		internal static int __PropertyOffset_SampleDataIndex;

		// Token: 0x04003A7B RID: 14971
		internal static int __PropertyOffset_Animation;

		// Token: 0x04003A7C RID: 14972
		internal static int __PropertyOffset_TotalWeight;

		// Token: 0x04003A7D RID: 14973
		internal static int __PropertyOffset_Time;

		// Token: 0x04003A7E RID: 14974
		internal static int __PropertyOffset_PreviousTime;

		// Token: 0x04003A7F RID: 14975
		internal static int __PropertyOffset_SamplePlayRate;
	}
}
