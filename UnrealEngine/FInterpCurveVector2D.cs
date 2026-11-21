using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000126 RID: 294
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveVector2D")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveVector2D : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001209 RID: 4617 RVA: 0x0001C893 File Offset: 0x0001AA93
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveVector2D._ScriptStructPtr != 0) ? FInterpCurveVector2D._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveVector2D", ref FInterpCurveVector2D._ScriptStructPtr);
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x0001C8B8 File Offset: 0x0001AAB8
		// (set) Token: 0x0600120B RID: 4619 RVA: 0x0001C8FB File Offset: 0x0001AAFB
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

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600120C RID: 4620 RVA: 0x0001C909 File Offset: 0x0001AB09
		// (set) Token: 0x0600120D RID: 4621 RVA: 0x0001C919 File Offset: 0x0001AB19
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

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x0001C92A File Offset: 0x0001AB2A
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x0001C93A File Offset: 0x0001AB3A
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

		// Token: 0x06001210 RID: 4624 RVA: 0x0001C94B File Offset: 0x0001AB4B
		public FInterpCurveVector2D()
		{
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0001C953 File Offset: 0x0001AB53
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveVector2D.StaticStruct();
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0001C95F File Offset: 0x0001AB5F
		[NullableContext(2)]
		public FInterpCurveVector2D(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0001C969 File Offset: 0x0001AB69
		public FInterpCurveVector2D(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0001C974 File Offset: 0x0001AB74
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveVector2D(Pointer, false, true);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0001C97E File Offset: 0x0001AB7E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveVector2D(Pointer, MemoryOwner);
		}

		// Token: 0x04000564 RID: 1380
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveVector2D";

		// Token: 0x04000565 RID: 1381
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000566 RID: 1382
		internal static int __PropertyOffset_Points;

		// Token: 0x04000567 RID: 1383
		[Nullable(2)]
		private TArray<FInterpCurvePointVector2D> _Points;

		// Token: 0x04000568 RID: 1384
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04000569 RID: 1385
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
