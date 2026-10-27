using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000740 RID: 1856
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveVector2D")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveVector2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060062AC RID: 25260 RVA: 0x0008D8F8 File Offset: 0x0008BAF8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveVector2D._ScriptStructPtr != 0) ? FInterpCurveVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveVector2D", ref FInterpCurveVector2D._ScriptStructPtr);
		}

		// Token: 0x17001799 RID: 6041
		// (get) Token: 0x060062AD RID: 25261 RVA: 0x0008D91C File Offset: 0x0008BB1C
		// (set) Token: 0x060062AE RID: 25262 RVA: 0x0008D95F File Offset: 0x0008BB5F
		public TArray<FInterpCurvePointVector2D> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointVector2D> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointVector2D>(base.NativePtr + (IntPtr)FInterpCurveVector2D.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x1700179A RID: 6042
		// (get) Token: 0x060062AF RID: 25263 RVA: 0x0008D96D File Offset: 0x0008BB6D
		// (set) Token: 0x060062B0 RID: 25264 RVA: 0x0008D97D File Offset: 0x0008BB7D
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveVector2D.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveVector2D.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700179B RID: 6043
		// (get) Token: 0x060062B1 RID: 25265 RVA: 0x0008D98E File Offset: 0x0008BB8E
		// (set) Token: 0x060062B2 RID: 25266 RVA: 0x0008D99E File Offset: 0x0008BB9E
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveVector2D.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveVector2D.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x0008D9AF File Offset: 0x0008BBAF
		public FInterpCurveVector2D()
		{
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0008D9B7 File Offset: 0x0008BBB7
		public FInterpCurveVector2D(TArray<FInterpCurvePointVector2D> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x060062B5 RID: 25269 RVA: 0x0008D9D4 File Offset: 0x0008BBD4
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveVector2D.StaticStruct();
		}

		// Token: 0x060062B6 RID: 25270 RVA: 0x0008D9E0 File Offset: 0x0008BBE0
		[NullableContext(2)]
		public FInterpCurveVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060062B7 RID: 25271 RVA: 0x0008D9EA File Offset: 0x0008BBEA
		public FInterpCurveVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060062B8 RID: 25272 RVA: 0x0008D9F5 File Offset: 0x0008BBF5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveVector2D(Pointer, false, true);
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x0008D9FF File Offset: 0x0008BBFF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x04002F2E RID: 12078
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveVector2D";

		// Token: 0x04002F2F RID: 12079
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F30 RID: 12080
		internal static int __PropertyOffset_Points;

		// Token: 0x04002F31 RID: 12081
		[Nullable(2)]
		private TArray<FInterpCurvePointVector2D> _Points;

		// Token: 0x04002F32 RID: 12082
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002F33 RID: 12083
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
