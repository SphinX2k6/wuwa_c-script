using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200011C RID: 284
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveLinearColor")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveLinearColor : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011A1 RID: 4513 RVA: 0x0001BE23 File Offset: 0x0001A023
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveLinearColor._ScriptStructPtr != 0) ? FInterpCurveLinearColor._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveLinearColor", ref FInterpCurveLinearColor._ScriptStructPtr);
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x0001BE48 File Offset: 0x0001A048
		// (set) Token: 0x060011A3 RID: 4515 RVA: 0x0001BE8B File Offset: 0x0001A08B
		public TArray<FInterpCurvePointLinearColor> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointLinearColor> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointLinearColor>(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x060011A4 RID: 4516 RVA: 0x0001BE99 File Offset: 0x0001A099
		// (set) Token: 0x060011A5 RID: 4517 RVA: 0x0001BEA9 File Offset: 0x0001A0A9
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x060011A6 RID: 4518 RVA: 0x0001BEBA File Offset: 0x0001A0BA
		// (set) Token: 0x060011A7 RID: 4519 RVA: 0x0001BECA File Offset: 0x0001A0CA
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveLinearColor.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x0001BEDB File Offset: 0x0001A0DB
		public FInterpCurveLinearColor()
		{
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x0001BEE3 File Offset: 0x0001A0E3
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveLinearColor.StaticStruct();
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x0001BEEF File Offset: 0x0001A0EF
		[NullableContext(2)]
		public FInterpCurveLinearColor(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0001BEF9 File Offset: 0x0001A0F9
		public FInterpCurveLinearColor(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0001BF04 File Offset: 0x0001A104
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveLinearColor(Pointer, false, true);
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x0001BF0E File Offset: 0x0001A10E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveLinearColor(Pointer, MemoryOwner);
		}

		// Token: 0x04000522 RID: 1314
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveLinearColor";

		// Token: 0x04000523 RID: 1315
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000524 RID: 1316
		internal static int __PropertyOffset_Points;

		// Token: 0x04000525 RID: 1317
		[Nullable(2)]
		private TArray<FInterpCurvePointLinearColor> _Points;

		// Token: 0x04000526 RID: 1318
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04000527 RID: 1319
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
