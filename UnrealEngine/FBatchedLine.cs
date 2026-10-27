using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020008A5 RID: 2213
	[UnrealObjectPath("/Script/Engine.BatchedLine")]
	[UnrealStructLayout(52, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 52)]
	public class FBatchedLine : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600791D RID: 31005 RVA: 0x000AD5EA File Offset: 0x000AB7EA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FBatchedLine._ScriptStructPtr != 0) ? FBatchedLine._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.BatchedLine", ref FBatchedLine._ScriptStructPtr);
		}

		// Token: 0x17001C9B RID: 7323
		// (get) Token: 0x0600791E RID: 31006 RVA: 0x000AD60E File Offset: 0x000AB80E
		// (set) Token: 0x0600791F RID: 31007 RVA: 0x000AD622 File Offset: 0x000AB822
		public unsafe FVector Start
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Start);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Start) = value;
			}
		}

		// Token: 0x17001C9C RID: 7324
		// (get) Token: 0x06007920 RID: 31008 RVA: 0x000AD637 File Offset: 0x000AB837
		// (set) Token: 0x06007921 RID: 31009 RVA: 0x000AD64B File Offset: 0x000AB84B
		public unsafe FVector End
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_End);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_End) = value;
			}
		}

		// Token: 0x17001C9D RID: 7325
		// (get) Token: 0x06007922 RID: 31010 RVA: 0x000AD660 File Offset: 0x000AB860
		// (set) Token: 0x06007923 RID: 31011 RVA: 0x000AD674 File Offset: 0x000AB874
		public unsafe FLinearColor Color
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Color);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Color) = value;
			}
		}

		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x06007924 RID: 31012 RVA: 0x000AD689 File Offset: 0x000AB889
		// (set) Token: 0x06007925 RID: 31013 RVA: 0x000AD699 File Offset: 0x000AB899
		public unsafe float Thickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Thickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_Thickness) = value;
			}
		}

		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x06007926 RID: 31014 RVA: 0x000AD6AA File Offset: 0x000AB8AA
		// (set) Token: 0x06007927 RID: 31015 RVA: 0x000AD6BA File Offset: 0x000AB8BA
		public unsafe float RemainingLifeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_RemainingLifeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_RemainingLifeTime) = value;
			}
		}

		// Token: 0x17001CA0 RID: 7328
		// (get) Token: 0x06007928 RID: 31016 RVA: 0x000AD6CB File Offset: 0x000AB8CB
		// (set) Token: 0x06007929 RID: 31017 RVA: 0x000AD6DB File Offset: 0x000AB8DB
		public unsafe byte DepthPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_DepthPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FBatchedLine.__PropertyOffset_DepthPriority) = value;
			}
		}

		// Token: 0x0600792A RID: 31018 RVA: 0x000AD6EC File Offset: 0x000AB8EC
		public FBatchedLine()
		{
		}

		// Token: 0x0600792B RID: 31019 RVA: 0x000AD6F4 File Offset: 0x000AB8F4
		public FBatchedLine(FVector Start, FVector End, FLinearColor Color, float Thickness, float RemainingLifeTime, byte DepthPriority)
		{
			this.Start = Start;
			this.End = End;
			this.Color = Color;
			this.Thickness = Thickness;
			this.RemainingLifeTime = RemainingLifeTime;
			this.DepthPriority = DepthPriority;
		}

		// Token: 0x0600792C RID: 31020 RVA: 0x000AD729 File Offset: 0x000AB929
		protected override IntPtr GetUStructPtr()
		{
			return FBatchedLine.StaticStruct();
		}

		// Token: 0x0600792D RID: 31021 RVA: 0x000AD735 File Offset: 0x000AB935
		[NullableContext(2)]
		public FBatchedLine(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600792E RID: 31022 RVA: 0x000AD73F File Offset: 0x000AB93F
		public FBatchedLine(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600792F RID: 31023 RVA: 0x000AD74A File Offset: 0x000AB94A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FBatchedLine(Pointer, false, true);
		}

		// Token: 0x06007930 RID: 31024 RVA: 0x000AD754 File Offset: 0x000AB954
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FBatchedLine(Pointer, MemoryOwner);
		}

		// Token: 0x04003A28 RID: 14888
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.BatchedLine";

		// Token: 0x04003A29 RID: 14889
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003A2A RID: 14890
		internal static int __PropertyOffset_Start;

		// Token: 0x04003A2B RID: 14891
		internal static int __PropertyOffset_End;

		// Token: 0x04003A2C RID: 14892
		internal static int __PropertyOffset_Color;

		// Token: 0x04003A2D RID: 14893
		internal static int __PropertyOffset_Thickness;

		// Token: 0x04003A2E RID: 14894
		internal static int __PropertyOffset_RemainingLifeTime;

		// Token: 0x04003A2F RID: 14895
		internal static int __PropertyOffset_DepthPriority;
	}
}
