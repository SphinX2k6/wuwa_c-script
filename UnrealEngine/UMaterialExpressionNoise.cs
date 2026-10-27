using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000DFF RID: 3583
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionNoise")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 344)]
	public class UMaterialExpressionNoise : UMaterialExpression, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C1B6 RID: 49590 RVA: 0x001171A9 File Offset: 0x001153A9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionNoise._ClassPtr;
		}

		// Token: 0x0600C1B7 RID: 49591 RVA: 0x001171B8 File Offset: 0x001153B8
		public UMaterialExpressionNoise() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNoise.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C1B8 RID: 49592 RVA: 0x001171E0 File Offset: 0x001153E0
		public UMaterialExpressionNoise(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionNoise.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D00 RID: 11520
		// (get) Token: 0x0600C1B9 RID: 49593 RVA: 0x00117214 File Offset: 0x00115414
		// (set) Token: 0x0600C1BA RID: 49594 RVA: 0x0011724D File Offset: 0x0011544D
		public FExpressionInput Position
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Position, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D01 RID: 11521
		// (get) Token: 0x0600C1BB RID: 49595 RVA: 0x00117270 File Offset: 0x00115470
		// (set) Token: 0x0600C1BC RID: 49596 RVA: 0x001172A9 File Offset: 0x001154A9
		public FExpressionInput FilterWidth
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._FilterWidth) == null)
				{
					result = (this._FilterWidth = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_FilterWidth, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_FilterWidth, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002D02 RID: 11522
		// (get) Token: 0x0600C1BD RID: 49597 RVA: 0x001172CA File Offset: 0x001154CA
		// (set) Token: 0x0600C1BE RID: 49598 RVA: 0x001172DA File Offset: 0x001154DA
		public unsafe float Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17002D03 RID: 11523
		// (get) Token: 0x0600C1BF RID: 49599 RVA: 0x001172EB File Offset: 0x001154EB
		// (set) Token: 0x0600C1C0 RID: 49600 RVA: 0x001172FB File Offset: 0x001154FB
		public unsafe int Quality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Quality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Quality) = value;
			}
		}

		// Token: 0x17002D04 RID: 11524
		// (get) Token: 0x0600C1C1 RID: 49601 RVA: 0x0011730C File Offset: 0x0011550C
		// (set) Token: 0x0600C1C2 RID: 49602 RVA: 0x00117320 File Offset: 0x00115520
		[Nullable(0)]
		public unsafe TEnumAsByte<ENoiseFunction> NoiseFunction
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_NoiseFunction);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_NoiseFunction) = value;
			}
		}

		// Token: 0x17002D05 RID: 11525
		// (get) Token: 0x0600C1C3 RID: 49603 RVA: 0x00117335 File Offset: 0x00115535
		// (set) Token: 0x0600C1C4 RID: 49604 RVA: 0x0011734E File Offset: 0x0011554E
		public unsafe bool bTurbulence
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTurbulence) & UMaterialExpressionNoise.__PropertyMask_bTurbulence) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTurbulence) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTurbulence) & ~UMaterialExpressionNoise.__PropertyMask_bTurbulence) | (value ? UMaterialExpressionNoise.__PropertyMask_bTurbulence : 0));
			}
		}

		// Token: 0x17002D06 RID: 11526
		// (get) Token: 0x0600C1C5 RID: 49605 RVA: 0x0011737E File Offset: 0x0011557E
		// (set) Token: 0x0600C1C6 RID: 49606 RVA: 0x0011738E File Offset: 0x0011558E
		public unsafe int Levels
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Levels);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_Levels) = value;
			}
		}

		// Token: 0x17002D07 RID: 11527
		// (get) Token: 0x0600C1C7 RID: 49607 RVA: 0x0011739F File Offset: 0x0011559F
		// (set) Token: 0x0600C1C8 RID: 49608 RVA: 0x001173AF File Offset: 0x001155AF
		public unsafe float OutputMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_OutputMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_OutputMin) = value;
			}
		}

		// Token: 0x17002D08 RID: 11528
		// (get) Token: 0x0600C1C9 RID: 49609 RVA: 0x001173C0 File Offset: 0x001155C0
		// (set) Token: 0x0600C1CA RID: 49610 RVA: 0x001173D0 File Offset: 0x001155D0
		public unsafe float OutputMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_OutputMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_OutputMax) = value;
			}
		}

		// Token: 0x17002D09 RID: 11529
		// (get) Token: 0x0600C1CB RID: 49611 RVA: 0x001173E1 File Offset: 0x001155E1
		// (set) Token: 0x0600C1CC RID: 49612 RVA: 0x001173F1 File Offset: 0x001155F1
		public unsafe float LevelScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_LevelScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_LevelScale) = value;
			}
		}

		// Token: 0x17002D0A RID: 11530
		// (get) Token: 0x0600C1CD RID: 49613 RVA: 0x00117402 File Offset: 0x00115602
		// (set) Token: 0x0600C1CE RID: 49614 RVA: 0x0011741B File Offset: 0x0011561B
		public unsafe bool bTiling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTiling) & UMaterialExpressionNoise.__PropertyMask_bTiling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTiling) = ((*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_bTiling) & ~UMaterialExpressionNoise.__PropertyMask_bTiling) | (value ? UMaterialExpressionNoise.__PropertyMask_bTiling : 0));
			}
		}

		// Token: 0x17002D0B RID: 11531
		// (get) Token: 0x0600C1CF RID: 49615 RVA: 0x0011744B File Offset: 0x0011564B
		// (set) Token: 0x0600C1D0 RID: 49616 RVA: 0x0011745B File Offset: 0x0011565B
		public unsafe uint RepeatSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_RepeatSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMaterialExpressionNoise.__PropertyOffset_RepeatSize) = (int)value;
			}
		}

		// Token: 0x0600C1D1 RID: 49617 RVA: 0x0011746C File Offset: 0x0011566C
		static UMaterialExpressionNoise()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionNoise");
		}

		// Token: 0x0600C1D2 RID: 49618 RVA: 0x0011747A File Offset: 0x0011567A
		protected UMaterialExpressionNoise(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04006708 RID: 26376
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionNoise";

		// Token: 0x04006709 RID: 26377
		private static IntPtr _ClassPtr;

		// Token: 0x0400670A RID: 26378
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400670B RID: 26379
		internal static int __PropertyOffset_Position;

		// Token: 0x0400670C RID: 26380
		[Nullable(2)]
		private FExpressionInput _Position;

		// Token: 0x0400670D RID: 26381
		internal static int __PropertyOffset_FilterWidth;

		// Token: 0x0400670E RID: 26382
		[Nullable(2)]
		private FExpressionInput _FilterWidth;

		// Token: 0x0400670F RID: 26383
		internal static int __PropertyOffset_Scale;

		// Token: 0x04006710 RID: 26384
		internal static int __PropertyOffset_Quality;

		// Token: 0x04006711 RID: 26385
		internal static int __PropertyOffset_NoiseFunction;

		// Token: 0x04006712 RID: 26386
		internal static int __PropertyOffset_bTurbulence;

		// Token: 0x04006713 RID: 26387
		internal static byte __PropertyMask_bTurbulence;

		// Token: 0x04006714 RID: 26388
		internal static int __PropertyOffset_Levels;

		// Token: 0x04006715 RID: 26389
		internal static int __PropertyOffset_OutputMin;

		// Token: 0x04006716 RID: 26390
		internal static int __PropertyOffset_OutputMax;

		// Token: 0x04006717 RID: 26391
		internal static int __PropertyOffset_LevelScale;

		// Token: 0x04006718 RID: 26392
		internal static int __PropertyOffset_bTiling;

		// Token: 0x04006719 RID: 26393
		internal static byte __PropertyMask_bTiling;

		// Token: 0x0400671A RID: 26394
		internal static int __PropertyOffset_RepeatSize;
	}
}
