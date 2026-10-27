using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002570 RID: 9584
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceCurveBase")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UNiagaraDataInterfaceCurveBase : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023946 RID: 145734 RVA: 0x00349895 File Offset: 0x00347A95
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceCurveBase._ClassPtr;
		}

		// Token: 0x06023947 RID: 145735 RVA: 0x003498A4 File Offset: 0x00347AA4
		public UNiagaraDataInterfaceCurveBase() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurveBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023948 RID: 145736 RVA: 0x003498CC File Offset: 0x00347ACC
		public UNiagaraDataInterfaceCurveBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurveBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008883 RID: 34947
		// (get) Token: 0x06023949 RID: 145737 RVA: 0x00349900 File Offset: 0x00347B00
		// (set) Token: 0x0602394A RID: 145738 RVA: 0x00349939 File Offset: 0x00347B39
		public TArray<float> ShaderLUT
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._ShaderLUT) == null)
				{
					result = (this._ShaderLUT = new TArray<float>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_ShaderLUT, this));
				}
				return result;
			}
			set
			{
				this.ShaderLUT.CopyAssign(value);
			}
		}

		// Token: 0x17008884 RID: 34948
		// (get) Token: 0x0602394B RID: 145739 RVA: 0x00349947 File Offset: 0x00347B47
		// (set) Token: 0x0602394C RID: 145740 RVA: 0x00349957 File Offset: 0x00347B57
		public unsafe float LUTMinTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTMinTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTMinTime) = value;
			}
		}

		// Token: 0x17008885 RID: 34949
		// (get) Token: 0x0602394D RID: 145741 RVA: 0x00349968 File Offset: 0x00347B68
		// (set) Token: 0x0602394E RID: 145742 RVA: 0x00349978 File Offset: 0x00347B78
		public unsafe float LUTMaxTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTMaxTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTMaxTime) = value;
			}
		}

		// Token: 0x17008886 RID: 34950
		// (get) Token: 0x0602394F RID: 145743 RVA: 0x00349989 File Offset: 0x00347B89
		// (set) Token: 0x06023950 RID: 145744 RVA: 0x00349999 File Offset: 0x00347B99
		public unsafe float LUTInvTimeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTInvTimeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTInvTimeRange) = value;
			}
		}

		// Token: 0x17008887 RID: 34951
		// (get) Token: 0x06023951 RID: 145745 RVA: 0x003499AA File Offset: 0x00347BAA
		// (set) Token: 0x06023952 RID: 145746 RVA: 0x003499BA File Offset: 0x00347BBA
		public unsafe float LUTNumSamplesMinusOne
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTNumSamplesMinusOne);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_LUTNumSamplesMinusOne) = value;
			}
		}

		// Token: 0x17008888 RID: 34952
		// (get) Token: 0x06023953 RID: 145747 RVA: 0x003499CB File Offset: 0x00347BCB
		// (set) Token: 0x06023954 RID: 145748 RVA: 0x003499E4 File Offset: 0x00347BE4
		public unsafe bool bUseLUT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bUseLUT) & UNiagaraDataInterfaceCurveBase.__PropertyMask_bUseLUT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bUseLUT) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bUseLUT) & ~UNiagaraDataInterfaceCurveBase.__PropertyMask_bUseLUT) | (value ? UNiagaraDataInterfaceCurveBase.__PropertyMask_bUseLUT : 0));
			}
		}

		// Token: 0x17008889 RID: 34953
		// (get) Token: 0x06023955 RID: 145749 RVA: 0x00349A14 File Offset: 0x00347C14
		// (set) Token: 0x06023956 RID: 145750 RVA: 0x00349A2D File Offset: 0x00347C2D
		public unsafe bool bExposeCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bExposeCurve) & UNiagaraDataInterfaceCurveBase.__PropertyMask_bExposeCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bExposeCurve) = ((*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_bExposeCurve) & ~UNiagaraDataInterfaceCurveBase.__PropertyMask_bExposeCurve) | (value ? UNiagaraDataInterfaceCurveBase.__PropertyMask_bExposeCurve : 0));
			}
		}

		// Token: 0x1700888A RID: 34954
		// (get) Token: 0x06023957 RID: 145751 RVA: 0x00349A5D File Offset: 0x00347C5D
		// (set) Token: 0x06023958 RID: 145752 RVA: 0x00349A71 File Offset: 0x00347C71
		public unsafe FName ExposedName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_ExposedName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurveBase.__PropertyOffset_ExposedName) = value;
			}
		}

		// Token: 0x1700888B RID: 34955
		// (get) Token: 0x06023959 RID: 145753 RVA: 0x00349A86 File Offset: 0x00347C86
		// (set) Token: 0x0602395A RID: 145754 RVA: 0x00349A9A File Offset: 0x00347C9A
		[Nullable(2)]
		public unsafe UTexture2D ExposedTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceCurveBase.__PropertyOffset_ExposedTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceCurveBase.__PropertyOffset_ExposedTexture, value);
			}
		}

		// Token: 0x0602395B RID: 145755 RVA: 0x00349AAF File Offset: 0x00347CAF
		static UNiagaraDataInterfaceCurveBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceCurveBase");
		}

		// Token: 0x0602395C RID: 145756 RVA: 0x00349ABD File Offset: 0x00347CBD
		protected UNiagaraDataInterfaceCurveBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013128 RID: 78120
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceCurveBase";

		// Token: 0x04013129 RID: 78121
		private static IntPtr _ClassPtr;

		// Token: 0x0401312A RID: 78122
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401312B RID: 78123
		internal static int __PropertyOffset_ShaderLUT;

		// Token: 0x0401312C RID: 78124
		[Nullable(2)]
		private TArray<float> _ShaderLUT;

		// Token: 0x0401312D RID: 78125
		internal static int __PropertyOffset_LUTMinTime;

		// Token: 0x0401312E RID: 78126
		internal static int __PropertyOffset_LUTMaxTime;

		// Token: 0x0401312F RID: 78127
		internal static int __PropertyOffset_LUTInvTimeRange;

		// Token: 0x04013130 RID: 78128
		internal static int __PropertyOffset_LUTNumSamplesMinusOne;

		// Token: 0x04013131 RID: 78129
		internal static int __PropertyOffset_bUseLUT;

		// Token: 0x04013132 RID: 78130
		internal static byte __PropertyMask_bUseLUT;

		// Token: 0x04013133 RID: 78131
		internal static int __PropertyOffset_bExposeCurve;

		// Token: 0x04013134 RID: 78132
		internal static byte __PropertyMask_bExposeCurve;

		// Token: 0x04013135 RID: 78133
		internal static int __PropertyOffset_ExposedName;

		// Token: 0x04013136 RID: 78134
		internal static int __PropertyOffset_ExposedTexture;
	}
}
