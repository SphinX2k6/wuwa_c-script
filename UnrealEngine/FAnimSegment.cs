using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000838 RID: 2104
	[UnrealObjectPath("/Script/Engine.AnimSegment")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnimSegment : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007111 RID: 28945 RVA: 0x000A2176 File Offset: 0x000A0376
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimSegment._ScriptStructPtr != 0) ? FAnimSegment._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimSegment", ref FAnimSegment._ScriptStructPtr);
		}

		// Token: 0x17001A99 RID: 6809
		// (get) Token: 0x06007112 RID: 28946 RVA: 0x000A219A File Offset: 0x000A039A
		// (set) Token: 0x06007113 RID: 28947 RVA: 0x000A21AE File Offset: 0x000A03AE
		[Nullable(2)]
		public unsafe UAnimSequenceBase AnimReference
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimSequenceBase>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimSegment.__PropertyOffset_AnimReference);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimSegment.__PropertyOffset_AnimReference, value);
			}
		}

		// Token: 0x17001A9A RID: 6810
		// (get) Token: 0x06007114 RID: 28948 RVA: 0x000A21C3 File Offset: 0x000A03C3
		// (set) Token: 0x06007115 RID: 28949 RVA: 0x000A21D3 File Offset: 0x000A03D3
		public unsafe float StartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_StartPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_StartPos) = value;
			}
		}

		// Token: 0x17001A9B RID: 6811
		// (get) Token: 0x06007116 RID: 28950 RVA: 0x000A21E4 File Offset: 0x000A03E4
		// (set) Token: 0x06007117 RID: 28951 RVA: 0x000A21F4 File Offset: 0x000A03F4
		public unsafe float AnimStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimStartTime) = value;
			}
		}

		// Token: 0x17001A9C RID: 6812
		// (get) Token: 0x06007118 RID: 28952 RVA: 0x000A2205 File Offset: 0x000A0405
		// (set) Token: 0x06007119 RID: 28953 RVA: 0x000A2215 File Offset: 0x000A0415
		public unsafe float AnimEndTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimEndTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimEndTime) = value;
			}
		}

		// Token: 0x17001A9D RID: 6813
		// (get) Token: 0x0600711A RID: 28954 RVA: 0x000A2226 File Offset: 0x000A0426
		// (set) Token: 0x0600711B RID: 28955 RVA: 0x000A2236 File Offset: 0x000A0436
		public unsafe float AnimPlayRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimPlayRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_AnimPlayRate) = value;
			}
		}

		// Token: 0x17001A9E RID: 6814
		// (get) Token: 0x0600711C RID: 28956 RVA: 0x000A2247 File Offset: 0x000A0447
		// (set) Token: 0x0600711D RID: 28957 RVA: 0x000A2257 File Offset: 0x000A0457
		public unsafe int LoopingCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_LoopingCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimSegment.__PropertyOffset_LoopingCount) = value;
			}
		}

		// Token: 0x0600711E RID: 28958 RVA: 0x000A2268 File Offset: 0x000A0468
		public FAnimSegment()
		{
		}

		// Token: 0x0600711F RID: 28959 RVA: 0x000A2270 File Offset: 0x000A0470
		[NullableContext(1)]
		public FAnimSegment(UAnimSequenceBase AnimReference, float StartPos, float AnimStartTime, float AnimEndTime, float AnimPlayRate, int LoopingCount)
		{
			this.AnimReference = AnimReference;
			this.StartPos = StartPos;
			this.AnimStartTime = AnimStartTime;
			this.AnimEndTime = AnimEndTime;
			this.AnimPlayRate = AnimPlayRate;
			this.LoopingCount = LoopingCount;
		}

		// Token: 0x06007120 RID: 28960 RVA: 0x000A22A5 File Offset: 0x000A04A5
		protected override IntPtr GetUStructPtr()
		{
			return FAnimSegment.StaticStruct();
		}

		// Token: 0x06007121 RID: 28961 RVA: 0x000A22B1 File Offset: 0x000A04B1
		[NullableContext(2)]
		public FAnimSegment(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007122 RID: 28962 RVA: 0x000A22BB File Offset: 0x000A04BB
		public FAnimSegment(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007123 RID: 28963 RVA: 0x000A22C6 File Offset: 0x000A04C6
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimSegment(Pointer, false, true);
		}

		// Token: 0x06007124 RID: 28964 RVA: 0x000A22D0 File Offset: 0x000A04D0
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimSegment(Pointer, MemoryOwner);
		}

		// Token: 0x04003653 RID: 13907
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimSegment";

		// Token: 0x04003654 RID: 13908
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003655 RID: 13909
		internal static int __PropertyOffset_AnimReference;

		// Token: 0x04003656 RID: 13910
		internal static int __PropertyOffset_StartPos;

		// Token: 0x04003657 RID: 13911
		internal static int __PropertyOffset_AnimStartTime;

		// Token: 0x04003658 RID: 13912
		internal static int __PropertyOffset_AnimEndTime;

		// Token: 0x04003659 RID: 13913
		internal static int __PropertyOffset_AnimPlayRate;

		// Token: 0x0400365A RID: 13914
		internal static int __PropertyOffset_LoopingCount;
	}
}
