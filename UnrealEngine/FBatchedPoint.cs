using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008A6 RID: 2214
	[UnrealObjectPath("/Script/Engine.BatchedPoint")]
	[UnrealStructLayout(40, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FBatchedPoint : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007931 RID: 31025 RVA: 0x000AD75D File Offset: 0x000AB95D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBatchedPoint._ScriptStructPtr != 0) ? FBatchedPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BatchedPoint", ref FBatchedPoint._ScriptStructPtr);
		}

		// Token: 0x17001CA1 RID: 7329
		// (get) Token: 0x06007932 RID: 31026 RVA: 0x000AD781 File Offset: 0x000AB981
		// (set) Token: 0x06007933 RID: 31027 RVA: 0x000AD795 File Offset: 0x000AB995
		public unsafe FVector Position
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_Position);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_Position) = value;
			}
		}

		// Token: 0x17001CA2 RID: 7330
		// (get) Token: 0x06007934 RID: 31028 RVA: 0x000AD7AA File Offset: 0x000AB9AA
		// (set) Token: 0x06007935 RID: 31029 RVA: 0x000AD7BE File Offset: 0x000AB9BE
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001CA3 RID: 7331
		// (get) Token: 0x06007936 RID: 31030 RVA: 0x000AD7D3 File Offset: 0x000AB9D3
		// (set) Token: 0x06007937 RID: 31031 RVA: 0x000AD7E3 File Offset: 0x000AB9E3
		public unsafe float PointSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_PointSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_PointSize) = value;
			}
		}

		// Token: 0x17001CA4 RID: 7332
		// (get) Token: 0x06007938 RID: 31032 RVA: 0x000AD7F4 File Offset: 0x000AB9F4
		// (set) Token: 0x06007939 RID: 31033 RVA: 0x000AD804 File Offset: 0x000ABA04
		public unsafe float RemainingLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_RemainingLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_RemainingLifeTime) = value;
			}
		}

		// Token: 0x17001CA5 RID: 7333
		// (get) Token: 0x0600793A RID: 31034 RVA: 0x000AD815 File Offset: 0x000ABA15
		// (set) Token: 0x0600793B RID: 31035 RVA: 0x000AD825 File Offset: 0x000ABA25
		public unsafe byte DepthPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_DepthPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedPoint.__PropertyOffset_DepthPriority) = value;
			}
		}

		// Token: 0x0600793C RID: 31036 RVA: 0x000AD836 File Offset: 0x000ABA36
		public FBatchedPoint()
		{
		}

		// Token: 0x0600793D RID: 31037 RVA: 0x000AD83E File Offset: 0x000ABA3E
		public FBatchedPoint(FVector Position, FLinearColor Color, float PointSize, float RemainingLifeTime, byte DepthPriority)
		{
			this.Position = Position;
			this.Color = Color;
			this.PointSize = PointSize;
			this.RemainingLifeTime = RemainingLifeTime;
			this.DepthPriority = DepthPriority;
		}

		// Token: 0x0600793E RID: 31038 RVA: 0x000AD86B File Offset: 0x000ABA6B
		protected override IntPtr GetUStructPtr()
		{
			return FBatchedPoint.StaticStruct();
		}

		// Token: 0x0600793F RID: 31039 RVA: 0x000AD877 File Offset: 0x000ABA77
		[NullableContext(2)]
		public FBatchedPoint(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007940 RID: 31040 RVA: 0x000AD881 File Offset: 0x000ABA81
		public FBatchedPoint(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007941 RID: 31041 RVA: 0x000AD88C File Offset: 0x000ABA8C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBatchedPoint(Pointer, false, true);
		}

		// Token: 0x06007942 RID: 31042 RVA: 0x000AD896 File Offset: 0x000ABA96
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBatchedPoint(Pointer, MemoryOwner);
		}

		// Token: 0x04003A30 RID: 14896
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BatchedPoint";

		// Token: 0x04003A31 RID: 14897
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A32 RID: 14898
		internal static int __PropertyOffset_Position;

		// Token: 0x04003A33 RID: 14899
		internal static int __PropertyOffset_Color;

		// Token: 0x04003A34 RID: 14900
		internal static int __PropertyOffset_PointSize;

		// Token: 0x04003A35 RID: 14901
		internal static int __PropertyOffset_RemainingLifeTime;

		// Token: 0x04003A36 RID: 14902
		internal static int __PropertyOffset_DepthPriority;
	}
}
