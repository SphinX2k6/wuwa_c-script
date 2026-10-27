using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200073F RID: 1855
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveVector")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600629E RID: 25246 RVA: 0x0008D7E8 File Offset: 0x0008B9E8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveVector._ScriptStructPtr != 0) ? FInterpCurveVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveVector", ref FInterpCurveVector._ScriptStructPtr);
		}

		// Token: 0x17001796 RID: 6038
		// (get) Token: 0x0600629F RID: 25247 RVA: 0x0008D80C File Offset: 0x0008BA0C
		// (set) Token: 0x060062A0 RID: 25248 RVA: 0x0008D84F File Offset: 0x0008BA4F
		public TArray<FInterpCurvePointVector> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointVector> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointVector>(base.NativePtr + (IntPtr)FInterpCurveVector.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17001797 RID: 6039
		// (get) Token: 0x060062A1 RID: 25249 RVA: 0x0008D85D File Offset: 0x0008BA5D
		// (set) Token: 0x060062A2 RID: 25250 RVA: 0x0008D86D File Offset: 0x0008BA6D
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveVector.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveVector.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001798 RID: 6040
		// (get) Token: 0x060062A3 RID: 25251 RVA: 0x0008D87E File Offset: 0x0008BA7E
		// (set) Token: 0x060062A4 RID: 25252 RVA: 0x0008D88E File Offset: 0x0008BA8E
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveVector.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveVector.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x0008D89F File Offset: 0x0008BA9F
		public FInterpCurveVector()
		{
		}

		// Token: 0x060062A6 RID: 25254 RVA: 0x0008D8A7 File Offset: 0x0008BAA7
		public FInterpCurveVector(TArray<FInterpCurvePointVector> Points, bool bIsLooped, float LoopKeyOffset)
		{
			this.Points = Points;
			this.bIsLooped = bIsLooped;
			this.LoopKeyOffset = LoopKeyOffset;
		}

		// Token: 0x060062A7 RID: 25255 RVA: 0x0008D8C4 File Offset: 0x0008BAC4
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveVector.StaticStruct();
		}

		// Token: 0x060062A8 RID: 25256 RVA: 0x0008D8D0 File Offset: 0x0008BAD0
		[NullableContext(2)]
		public FInterpCurveVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060062A9 RID: 25257 RVA: 0x0008D8DA File Offset: 0x0008BADA
		public FInterpCurveVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060062AA RID: 25258 RVA: 0x0008D8E5 File Offset: 0x0008BAE5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveVector(Pointer, false, true);
		}

		// Token: 0x060062AB RID: 25259 RVA: 0x0008D8EF File Offset: 0x0008BAEF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveVector(Pointer, MemoryOwner);
		}

		// Token: 0x04002F28 RID: 12072
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveVector";

		// Token: 0x04002F29 RID: 12073
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002F2A RID: 12074
		internal static int __PropertyOffset_Points;

		// Token: 0x04002F2B RID: 12075
		[Nullable(2)]
		private TArray<FInterpCurvePointVector> _Points;

		// Token: 0x04002F2C RID: 12076
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04002F2D RID: 12077
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
