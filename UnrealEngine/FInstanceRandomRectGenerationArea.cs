using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C68 RID: 3176
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InstanceRandomRectGenerationArea")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FInstanceRandomRectGenerationArea : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A18B RID: 41355 RVA: 0x000E57A3 File Offset: 0x000E39A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInstanceRandomRectGenerationArea._ScriptStructPtr != 0) ? FInstanceRandomRectGenerationArea._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InstanceRandomRectGenerationArea", ref FInstanceRandomRectGenerationArea._ScriptStructPtr);
		}

		// Token: 0x17002674 RID: 9844
		// (get) Token: 0x0600A18C RID: 41356 RVA: 0x000E57C7 File Offset: 0x000E39C7
		// (set) Token: 0x0600A18D RID: 41357 RVA: 0x000E57D7 File Offset: 0x000E39D7
		public unsafe int NumInstances
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_NumInstances);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_NumInstances) = value;
			}
		}

		// Token: 0x17002675 RID: 9845
		// (get) Token: 0x0600A18E RID: 41358 RVA: 0x000E57E8 File Offset: 0x000E39E8
		// (set) Token: 0x0600A18F RID: 41359 RVA: 0x000E57FC File Offset: 0x000E39FC
		public unsafe FVector RandomIntervalRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_RandomIntervalRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_RandomIntervalRange) = value;
			}
		}

		// Token: 0x17002676 RID: 9846
		// (get) Token: 0x0600A190 RID: 41360 RVA: 0x000E5811 File Offset: 0x000E3A11
		// (set) Token: 0x0600A191 RID: 41361 RVA: 0x000E5825 File Offset: 0x000E3A25
		public unsafe FVector2D RandomIntervalFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_RandomIntervalFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_RandomIntervalFactor) = value;
			}
		}

		// Token: 0x17002677 RID: 9847
		// (get) Token: 0x0600A192 RID: 41362 RVA: 0x000E583A File Offset: 0x000E3A3A
		// (set) Token: 0x0600A193 RID: 41363 RVA: 0x000E584A File Offset: 0x000E3A4A
		public unsafe bool bRandomRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_bRandomRotation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_bRandomRotation) = (value ? 1 : 0);
			}
		}

		// Token: 0x17002678 RID: 9848
		// (get) Token: 0x0600A194 RID: 41364 RVA: 0x000E585C File Offset: 0x000E3A5C
		// (set) Token: 0x0600A195 RID: 41365 RVA: 0x000E589F File Offset: 0x000E3A9F
		public TArray<FVector> RandomIntervals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._RandomIntervals) == null)
				{
					result = (this._RandomIntervals = new TArray<FVector>(base.NativePtr + (IntPtr)FInstanceRandomRectGenerationArea.__PropertyOffset_RandomIntervals, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.RandomIntervals.CopyAssign(value);
			}
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x000E58AD File Offset: 0x000E3AAD
		public FInstanceRandomRectGenerationArea()
		{
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x000E58B5 File Offset: 0x000E3AB5
		public FInstanceRandomRectGenerationArea(int NumInstances, FVector RandomIntervalRange, FVector2D RandomIntervalFactor, bool bRandomRotation, TArray<FVector> RandomIntervals)
		{
			this.NumInstances = NumInstances;
			this.RandomIntervalRange = RandomIntervalRange;
			this.RandomIntervalFactor = RandomIntervalFactor;
			this.bRandomRotation = bRandomRotation;
			this.RandomIntervals = RandomIntervals;
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x000E58E2 File Offset: 0x000E3AE2
		protected override IntPtr GetUStructPtr()
		{
			return FInstanceRandomRectGenerationArea.StaticStruct();
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x000E58EE File Offset: 0x000E3AEE
		[NullableContext(2)]
		public FInstanceRandomRectGenerationArea(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x000E58F8 File Offset: 0x000E3AF8
		public FInstanceRandomRectGenerationArea(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x000E5903 File Offset: 0x000E3B03
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInstanceRandomRectGenerationArea(Pointer, false, true);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x000E590D File Offset: 0x000E3B0D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInstanceRandomRectGenerationArea(Pointer, MemoryOwner);
		}

		// Token: 0x040058B7 RID: 22711
		public const string __ObjectPath = "/Script/Engine.InstanceRandomRectGenerationArea";

		// Token: 0x040058B8 RID: 22712
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040058B9 RID: 22713
		internal static int __PropertyOffset_NumInstances;

		// Token: 0x040058BA RID: 22714
		internal static int __PropertyOffset_RandomIntervalRange;

		// Token: 0x040058BB RID: 22715
		internal static int __PropertyOffset_RandomIntervalFactor;

		// Token: 0x040058BC RID: 22716
		internal static int __PropertyOffset_bRandomRotation;

		// Token: 0x040058BD RID: 22717
		internal static int __PropertyOffset_RandomIntervals;

		// Token: 0x040058BE RID: 22718
		[Nullable(2)]
		private TArray<FVector> _RandomIntervals;
	}
}
