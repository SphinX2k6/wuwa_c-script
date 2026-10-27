using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F7 RID: 5367
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterRampFloat")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UHoudiniParameterRampFloat : UHoudiniParameterMultiParm, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601373E RID: 79678 RVA: 0x001C9955 File Offset: 0x001C7B55
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterRampFloat._ClassPtr;
		}

		// Token: 0x0601373F RID: 79679 RVA: 0x001C9964 File Offset: 0x001C7B64
		public UHoudiniParameterRampFloat() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampFloat.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013740 RID: 79680 RVA: 0x001C998C File Offset: 0x001C7B8C
		public UHoudiniParameterRampFloat(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampFloat.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004C01 RID: 19457
		// (get) Token: 0x06013741 RID: 79681 RVA: 0x001C99C0 File Offset: 0x001C7BC0
		// (set) Token: 0x06013742 RID: 79682 RVA: 0x001C99F9 File Offset: 0x001C7BF9
		public TArray<UHoudiniParameterRampFloatPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampFloatPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<UHoudiniParameterRampFloatPoint>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17004C02 RID: 19458
		// (get) Token: 0x06013743 RID: 79683 RVA: 0x001C9A08 File Offset: 0x001C7C08
		// (set) Token: 0x06013744 RID: 79684 RVA: 0x001C9A41 File Offset: 0x001C7C41
		public TArray<UHoudiniParameterRampFloatPoint> CachedPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampFloatPoint> result;
				if ((result = this._CachedPoints) == null)
				{
					result = (this._CachedPoints = new TArray<UHoudiniParameterRampFloatPoint>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_CachedPoints, this));
				}
				return result;
			}
			set
			{
				this.CachedPoints.CopyAssign(value);
			}
		}

		// Token: 0x17004C03 RID: 19459
		// (get) Token: 0x06013745 RID: 79685 RVA: 0x001C9A50 File Offset: 0x001C7C50
		// (set) Token: 0x06013746 RID: 79686 RVA: 0x001C9A89 File Offset: 0x001C7C89
		public TArray<float> DefaultPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DefaultPositions) == null)
				{
					result = (this._DefaultPositions = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_DefaultPositions, this));
				}
				return result;
			}
			set
			{
				this.DefaultPositions.CopyAssign(value);
			}
		}

		// Token: 0x17004C04 RID: 19460
		// (get) Token: 0x06013747 RID: 79687 RVA: 0x001C9A98 File Offset: 0x001C7C98
		// (set) Token: 0x06013748 RID: 79688 RVA: 0x001C9AD1 File Offset: 0x001C7CD1
		public TArray<float> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004C05 RID: 19461
		// (get) Token: 0x06013749 RID: 79689 RVA: 0x001C9AE0 File Offset: 0x001C7CE0
		// (set) Token: 0x0601374A RID: 79690 RVA: 0x001C9B19 File Offset: 0x001C7D19
		public TArray<int> DefaultChoices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DefaultChoices) == null)
				{
					result = (this._DefaultChoices = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_DefaultChoices, this));
				}
				return result;
			}
			set
			{
				this.DefaultChoices.CopyAssign(value);
			}
		}

		// Token: 0x17004C06 RID: 19462
		// (get) Token: 0x0601374B RID: 79691 RVA: 0x001C9B27 File Offset: 0x001C7D27
		// (set) Token: 0x0601374C RID: 79692 RVA: 0x001C9B37 File Offset: 0x001C7D37
		public unsafe int NumDefaultPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_NumDefaultPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_NumDefaultPoints) = value;
			}
		}

		// Token: 0x17004C07 RID: 19463
		// (get) Token: 0x0601374D RID: 79693 RVA: 0x001C9B48 File Offset: 0x001C7D48
		// (set) Token: 0x0601374E RID: 79694 RVA: 0x001C9B58 File Offset: 0x001C7D58
		public unsafe bool bCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_bCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_bCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004C08 RID: 19464
		// (get) Token: 0x0601374F RID: 79695 RVA: 0x001C9B6C File Offset: 0x001C7D6C
		// (set) Token: 0x06013750 RID: 79696 RVA: 0x001C9BA5 File Offset: 0x001C7DA5
		public TArray<UHoudiniParameterRampModificationEvent> ModificationEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampModificationEvent> result;
				if ((result = this._ModificationEvents) == null)
				{
					result = (this._ModificationEvents = new TArray<UHoudiniParameterRampModificationEvent>(base.NativePtr + (IntPtr)UHoudiniParameterRampFloat.__PropertyOffset_ModificationEvents, this));
				}
				return result;
			}
			set
			{
				this.ModificationEvents.CopyAssign(value);
			}
		}

		// Token: 0x06013751 RID: 79697 RVA: 0x001C9BB3 File Offset: 0x001C7DB3
		static UHoudiniParameterRampFloat()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterRampFloat");
		}

		// Token: 0x06013752 RID: 79698 RVA: 0x001C9BC1 File Offset: 0x001C7DC1
		protected UHoudiniParameterRampFloat(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A839 RID: 43065
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterRampFloat";

		// Token: 0x0400A83A RID: 43066
		private static IntPtr _ClassPtr;

		// Token: 0x0400A83B RID: 43067
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A83C RID: 43068
		internal static int __PropertyOffset_Points;

		// Token: 0x0400A83D RID: 43069
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampFloatPoint> _Points;

		// Token: 0x0400A83E RID: 43070
		internal static int __PropertyOffset_CachedPoints;

		// Token: 0x0400A83F RID: 43071
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampFloatPoint> _CachedPoints;

		// Token: 0x0400A840 RID: 43072
		internal static int __PropertyOffset_DefaultPositions;

		// Token: 0x0400A841 RID: 43073
		[Nullable(2)]
		private TArray<float> _DefaultPositions;

		// Token: 0x0400A842 RID: 43074
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A843 RID: 43075
		[Nullable(2)]
		private TArray<float> _DefaultValues;

		// Token: 0x0400A844 RID: 43076
		internal static int __PropertyOffset_DefaultChoices;

		// Token: 0x0400A845 RID: 43077
		[Nullable(2)]
		private TArray<int> _DefaultChoices;

		// Token: 0x0400A846 RID: 43078
		internal static int __PropertyOffset_NumDefaultPoints;

		// Token: 0x0400A847 RID: 43079
		internal static int __PropertyOffset_bCaching;

		// Token: 0x0400A848 RID: 43080
		internal static int __PropertyOffset_ModificationEvents;

		// Token: 0x0400A849 RID: 43081
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampModificationEvent> _ModificationEvents;
	}
}
