using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020016ED RID: 5869
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroBulletCore.EmitterStackSettings")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FEmitterStackSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06015315 RID: 86805 RVA: 0x001F25F2 File Offset: 0x001F07F2
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FEmitterStackSettings._ScriptStructPtr != 0) ? FEmitterStackSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroBulletCore.EmitterStackSettings", ref FEmitterStackSettings._ScriptStructPtr);
		}

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x06015316 RID: 86806 RVA: 0x001F2616 File Offset: 0x001F0816
		// (set) Token: 0x06015317 RID: 86807 RVA: 0x001F2626 File Offset: 0x001F0826
		public unsafe int Layers
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_Layers);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_Layers) = value;
			}
		}

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x06015318 RID: 86808 RVA: 0x001F2638 File Offset: 0x001F0838
		// (set) Token: 0x06015319 RID: 86809 RVA: 0x001F267B File Offset: 0x001F087B
		public TArray<float> LayerBulletWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LayerBulletWeights) == null)
				{
					result = (this._LayerBulletWeights = new TArray<float>(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_LayerBulletWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerBulletWeights.CopyAssign(value);
			}
		}

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x0601531A RID: 86810 RVA: 0x001F268C File Offset: 0x001F088C
		// (set) Token: 0x0601531B RID: 86811 RVA: 0x001F26CF File Offset: 0x001F08CF
		public TArray<float> LayerRadiusScales
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LayerRadiusScales) == null)
				{
					result = (this._LayerRadiusScales = new TArray<float>(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_LayerRadiusScales, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerRadiusScales.CopyAssign(value);
			}
		}

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x0601531C RID: 86812 RVA: 0x001F26E0 File Offset: 0x001F08E0
		// (set) Token: 0x0601531D RID: 86813 RVA: 0x001F2723 File Offset: 0x001F0923
		public TArray<FVector> LayerPositionOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._LayerPositionOffsets) == null)
				{
					result = (this._LayerPositionOffsets = new TArray<FVector>(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_LayerPositionOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerPositionOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x0601531E RID: 86814 RVA: 0x001F2734 File Offset: 0x001F0934
		// (set) Token: 0x0601531F RID: 86815 RVA: 0x001F2777 File Offset: 0x001F0977
		public TArray<FRotator> LayerRotationOffsets
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRotator> result;
				if ((result = this._LayerRotationOffsets) == null)
				{
					result = (this._LayerRotationOffsets = new TArray<FRotator>(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_LayerRotationOffsets, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerRotationOffsets.CopyAssign(value);
			}
		}

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x06015320 RID: 86816 RVA: 0x001F2788 File Offset: 0x001F0988
		// (set) Token: 0x06015321 RID: 86817 RVA: 0x001F27CB File Offset: 0x001F09CB
		public TArray<float> LayerSpawnIntervals
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._LayerSpawnIntervals) == null)
				{
					result = (this._LayerSpawnIntervals = new TArray<float>(base.NativePtr + (IntPtr)FEmitterStackSettings.__PropertyOffset_LayerSpawnIntervals, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LayerSpawnIntervals.CopyAssign(value);
			}
		}

		// Token: 0x06015322 RID: 86818 RVA: 0x001F27D9 File Offset: 0x001F09D9
		public FEmitterStackSettings()
		{
		}

		// Token: 0x06015323 RID: 86819 RVA: 0x001F27E1 File Offset: 0x001F09E1
		public FEmitterStackSettings(int Layers, TArray<float> LayerBulletWeights, TArray<float> LayerRadiusScales, TArray<FVector> LayerPositionOffsets, TArray<FRotator> LayerRotationOffsets, TArray<float> LayerSpawnIntervals)
		{
			this.Layers = Layers;
			this.LayerBulletWeights = LayerBulletWeights;
			this.LayerRadiusScales = LayerRadiusScales;
			this.LayerPositionOffsets = LayerPositionOffsets;
			this.LayerRotationOffsets = LayerRotationOffsets;
			this.LayerSpawnIntervals = LayerSpawnIntervals;
		}

		// Token: 0x06015324 RID: 86820 RVA: 0x001F2816 File Offset: 0x001F0A16
		protected override IntPtr GetUStructPtr()
		{
			return FEmitterStackSettings.StaticStruct();
		}

		// Token: 0x06015325 RID: 86821 RVA: 0x001F2822 File Offset: 0x001F0A22
		[NullableContext(2)]
		public FEmitterStackSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06015326 RID: 86822 RVA: 0x001F282C File Offset: 0x001F0A2C
		public FEmitterStackSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06015327 RID: 86823 RVA: 0x001F2837 File Offset: 0x001F0A37
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FEmitterStackSettings(Pointer, false, true);
		}

		// Token: 0x06015328 RID: 86824 RVA: 0x001F2841 File Offset: 0x001F0A41
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FEmitterStackSettings(Pointer, MemoryOwner);
		}

		// Token: 0x0400B8E2 RID: 47330
		public const string __ObjectPath = "/Script/KuroBulletCore.EmitterStackSettings";

		// Token: 0x0400B8E3 RID: 47331
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400B8E4 RID: 47332
		internal static int __PropertyOffset_Layers;

		// Token: 0x0400B8E5 RID: 47333
		internal static int __PropertyOffset_LayerBulletWeights;

		// Token: 0x0400B8E6 RID: 47334
		[Nullable(2)]
		private TArray<float> _LayerBulletWeights;

		// Token: 0x0400B8E7 RID: 47335
		internal static int __PropertyOffset_LayerRadiusScales;

		// Token: 0x0400B8E8 RID: 47336
		[Nullable(2)]
		private TArray<float> _LayerRadiusScales;

		// Token: 0x0400B8E9 RID: 47337
		internal static int __PropertyOffset_LayerPositionOffsets;

		// Token: 0x0400B8EA RID: 47338
		[Nullable(2)]
		private TArray<FVector> _LayerPositionOffsets;

		// Token: 0x0400B8EB RID: 47339
		internal static int __PropertyOffset_LayerRotationOffsets;

		// Token: 0x0400B8EC RID: 47340
		[Nullable(2)]
		private TArray<FRotator> _LayerRotationOffsets;

		// Token: 0x0400B8ED RID: 47341
		internal static int __PropertyOffset_LayerSpawnIntervals;

		// Token: 0x0400B8EE RID: 47342
		[Nullable(2)]
		private TArray<float> _LayerSpawnIntervals;
	}
}
