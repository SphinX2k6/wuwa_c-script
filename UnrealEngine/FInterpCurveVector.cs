using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000125 RID: 293
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveVector")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveVector : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060011FC RID: 4604 RVA: 0x0001C79F File Offset: 0x0001A99F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveVector._ScriptStructPtr != 0) ? FInterpCurveVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveVector", ref FInterpCurveVector._ScriptStructPtr);
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0001C7C4 File Offset: 0x0001A9C4
		// (set) Token: 0x060011FE RID: 4606 RVA: 0x0001C807 File Offset: 0x0001AA07
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

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060011FF RID: 4607 RVA: 0x0001C815 File Offset: 0x0001AA15
		// (set) Token: 0x06001200 RID: 4608 RVA: 0x0001C825 File Offset: 0x0001AA25
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

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0001C836 File Offset: 0x0001AA36
		// (set) Token: 0x06001202 RID: 4610 RVA: 0x0001C846 File Offset: 0x0001AA46
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

		// Token: 0x06001203 RID: 4611 RVA: 0x0001C857 File Offset: 0x0001AA57
		public FInterpCurveVector()
		{
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0001C85F File Offset: 0x0001AA5F
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveVector.StaticStruct();
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0001C86B File Offset: 0x0001AA6B
		[NullableContext(2)]
		public FInterpCurveVector(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0001C875 File Offset: 0x0001AA75
		public FInterpCurveVector(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0001C880 File Offset: 0x0001AA80
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveVector(Pointer, false, true);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0001C88A File Offset: 0x0001AA8A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveVector(Pointer, MemoryOwner);
		}

		// Token: 0x0400055E RID: 1374
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveVector";

		// Token: 0x0400055F RID: 1375
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000560 RID: 1376
		internal static int __PropertyOffset_Points;

		// Token: 0x04000561 RID: 1377
		[Nullable(2)]
		private TArray<FInterpCurvePointVector> _Points;

		// Token: 0x04000562 RID: 1378
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04000563 RID: 1379
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
