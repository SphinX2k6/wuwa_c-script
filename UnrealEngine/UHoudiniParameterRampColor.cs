using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020014F5 RID: 5365
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.HoudiniParameterRampColor")]
	[UnrealStructLayout(456, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 456)]
	public class UHoudiniParameterRampColor : UHoudiniParameterMultiParm, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06013716 RID: 79638 RVA: 0x001C955F File Offset: 0x001C775F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UHoudiniParameterRampColor._ClassPtr;
		}

		// Token: 0x06013717 RID: 79639 RVA: 0x001C956C File Offset: 0x001C776C
		public UHoudiniParameterRampColor() : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampColor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06013718 RID: 79640 RVA: 0x001C9594 File Offset: 0x001C7794
		public UHoudiniParameterRampColor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UHoudiniParameterRampColor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004BF2 RID: 19442
		// (get) Token: 0x06013719 RID: 79641 RVA: 0x001C95C8 File Offset: 0x001C77C8
		// (set) Token: 0x0601371A RID: 79642 RVA: 0x001C9601 File Offset: 0x001C7801
		public TArray<UHoudiniParameterRampColorPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampColorPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<UHoudiniParameterRampColorPoint>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_Points, this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x17004BF3 RID: 19443
		// (get) Token: 0x0601371B RID: 79643 RVA: 0x001C960F File Offset: 0x001C780F
		// (set) Token: 0x0601371C RID: 79644 RVA: 0x001C961F File Offset: 0x001C781F
		public unsafe bool bCaching
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_bCaching) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_bCaching) = (value ? 1 : 0);
			}
		}

		// Token: 0x17004BF4 RID: 19444
		// (get) Token: 0x0601371D RID: 79645 RVA: 0x001C9630 File Offset: 0x001C7830
		// (set) Token: 0x0601371E RID: 79646 RVA: 0x001C9669 File Offset: 0x001C7869
		public TArray<UHoudiniParameterRampColorPoint> CachedPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampColorPoint> result;
				if ((result = this._CachedPoints) == null)
				{
					result = (this._CachedPoints = new TArray<UHoudiniParameterRampColorPoint>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_CachedPoints, this));
				}
				return result;
			}
			set
			{
				this.CachedPoints.CopyAssign(value);
			}
		}

		// Token: 0x17004BF5 RID: 19445
		// (get) Token: 0x0601371F RID: 79647 RVA: 0x001C9678 File Offset: 0x001C7878
		// (set) Token: 0x06013720 RID: 79648 RVA: 0x001C96B1 File Offset: 0x001C78B1
		public TArray<float> DefaultPositions
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._DefaultPositions) == null)
				{
					result = (this._DefaultPositions = new TArray<float>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_DefaultPositions, this));
				}
				return result;
			}
			set
			{
				this.DefaultPositions.CopyAssign(value);
			}
		}

		// Token: 0x17004BF6 RID: 19446
		// (get) Token: 0x06013721 RID: 79649 RVA: 0x001C96C0 File Offset: 0x001C78C0
		// (set) Token: 0x06013722 RID: 79650 RVA: 0x001C96F9 File Offset: 0x001C78F9
		public TArray<FLinearColor> DefaultValues
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._DefaultValues) == null)
				{
					result = (this._DefaultValues = new TArray<FLinearColor>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_DefaultValues, this));
				}
				return result;
			}
			set
			{
				this.DefaultValues.CopyAssign(value);
			}
		}

		// Token: 0x17004BF7 RID: 19447
		// (get) Token: 0x06013723 RID: 79651 RVA: 0x001C9708 File Offset: 0x001C7908
		// (set) Token: 0x06013724 RID: 79652 RVA: 0x001C9741 File Offset: 0x001C7941
		public TArray<int> DefaultChoices
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._DefaultChoices) == null)
				{
					result = (this._DefaultChoices = new TArray<int>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_DefaultChoices, this));
				}
				return result;
			}
			set
			{
				this.DefaultChoices.CopyAssign(value);
			}
		}

		// Token: 0x17004BF8 RID: 19448
		// (get) Token: 0x06013725 RID: 79653 RVA: 0x001C974F File Offset: 0x001C794F
		// (set) Token: 0x06013726 RID: 79654 RVA: 0x001C975F File Offset: 0x001C795F
		public unsafe int NumDefaultPoints
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_NumDefaultPoints);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_NumDefaultPoints) = value;
			}
		}

		// Token: 0x17004BF9 RID: 19449
		// (get) Token: 0x06013727 RID: 79655 RVA: 0x001C9770 File Offset: 0x001C7970
		// (set) Token: 0x06013728 RID: 79656 RVA: 0x001C97A9 File Offset: 0x001C79A9
		public TArray<UHoudiniParameterRampModificationEvent> ModificationEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UHoudiniParameterRampModificationEvent> result;
				if ((result = this._ModificationEvents) == null)
				{
					result = (this._ModificationEvents = new TArray<UHoudiniParameterRampModificationEvent>(base.NativePtr + (IntPtr)UHoudiniParameterRampColor.__PropertyOffset_ModificationEvents, this));
				}
				return result;
			}
			set
			{
				this.ModificationEvents.CopyAssign(value);
			}
		}

		// Token: 0x06013729 RID: 79657 RVA: 0x001C97B7 File Offset: 0x001C79B7
		static UHoudiniParameterRampColor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/HoudiniEngineRuntime.HoudiniParameterRampColor");
		}

		// Token: 0x0601372A RID: 79658 RVA: 0x001C97C5 File Offset: 0x001C79C5
		protected UHoudiniParameterRampColor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400A81E RID: 43038
		public new const string __ObjectPath = "/Script/HoudiniEngineRuntime.HoudiniParameterRampColor";

		// Token: 0x0400A81F RID: 43039
		private static IntPtr _ClassPtr;

		// Token: 0x0400A820 RID: 43040
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400A821 RID: 43041
		internal static int __PropertyOffset_Points;

		// Token: 0x0400A822 RID: 43042
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampColorPoint> _Points;

		// Token: 0x0400A823 RID: 43043
		internal static int __PropertyOffset_bCaching;

		// Token: 0x0400A824 RID: 43044
		internal static int __PropertyOffset_CachedPoints;

		// Token: 0x0400A825 RID: 43045
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampColorPoint> _CachedPoints;

		// Token: 0x0400A826 RID: 43046
		internal static int __PropertyOffset_DefaultPositions;

		// Token: 0x0400A827 RID: 43047
		[Nullable(2)]
		private TArray<float> _DefaultPositions;

		// Token: 0x0400A828 RID: 43048
		internal static int __PropertyOffset_DefaultValues;

		// Token: 0x0400A829 RID: 43049
		[Nullable(2)]
		private TArray<FLinearColor> _DefaultValues;

		// Token: 0x0400A82A RID: 43050
		internal static int __PropertyOffset_DefaultChoices;

		// Token: 0x0400A82B RID: 43051
		[Nullable(2)]
		private TArray<int> _DefaultChoices;

		// Token: 0x0400A82C RID: 43052
		internal static int __PropertyOffset_NumDefaultPoints;

		// Token: 0x0400A82D RID: 43053
		internal static int __PropertyOffset_ModificationEvents;

		// Token: 0x0400A82E RID: 43054
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UHoudiniParameterRampModificationEvent> _ModificationEvents;
	}
}
