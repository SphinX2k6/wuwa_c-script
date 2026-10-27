using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257B RID: 9595
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceMultiSpline")]
	[UnrealStructLayout(168, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 168)]
	public class UNiagaraDataInterfaceMultiSpline : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060239E9 RID: 145897 RVA: 0x0034A7FF File Offset: 0x003489FF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceMultiSpline._ClassPtr;
		}

		// Token: 0x060239EA RID: 145898 RVA: 0x0034A80C File Offset: 0x00348A0C
		public UNiagaraDataInterfaceMultiSpline() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceMultiSpline.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060239EB RID: 145899 RVA: 0x0034A834 File Offset: 0x00348A34
		public UNiagaraDataInterfaceMultiSpline(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceMultiSpline.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088B2 RID: 34994
		// (get) Token: 0x060239EC RID: 145900 RVA: 0x0034A867 File Offset: 0x00348A67
		// (set) Token: 0x060239ED RID: 145901 RVA: 0x0034A87B File Offset: 0x00348A7B
		[Nullable(2)]
		public unsafe AActor Source
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceMultiSpline.__PropertyOffset_Source);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataInterfaceMultiSpline.__PropertyOffset_Source, value);
			}
		}

		// Token: 0x170088B3 RID: 34995
		// (get) Token: 0x060239EE RID: 145902 RVA: 0x0034A890 File Offset: 0x00348A90
		// (set) Token: 0x060239EF RID: 145903 RVA: 0x0034A8C9 File Offset: 0x00348AC9
		public TArray<USplineComponent> SplineComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USplineComponent> result;
				if ((result = this._SplineComponents) == null)
				{
					result = (this._SplineComponents = new TArray<USplineComponent>(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_SplineComponents, this));
				}
				return result;
			}
			set
			{
				this.SplineComponents.CopyAssign(value);
			}
		}

		// Token: 0x170088B4 RID: 34996
		// (get) Token: 0x060239F0 RID: 145904 RVA: 0x0034A8D7 File Offset: 0x00348AD7
		// (set) Token: 0x060239F1 RID: 145905 RVA: 0x0034A8E7 File Offset: 0x00348AE7
		public unsafe bool bUseLUT
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_bUseLUT) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_bUseLUT) = (value ? 1 : 0);
			}
		}

		// Token: 0x170088B5 RID: 34997
		// (get) Token: 0x060239F2 RID: 145906 RVA: 0x0034A8F8 File Offset: 0x00348AF8
		// (set) Token: 0x060239F3 RID: 145907 RVA: 0x0034A908 File Offset: 0x00348B08
		public unsafe int NumLUTSteps
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_NumLUTSteps);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_NumLUTSteps) = value;
			}
		}

		// Token: 0x170088B6 RID: 34998
		// (get) Token: 0x060239F4 RID: 145908 RVA: 0x0034A919 File Offset: 0x00348B19
		// (set) Token: 0x060239F5 RID: 145909 RVA: 0x0034A929 File Offset: 0x00348B29
		public unsafe int MaxSplineCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_MaxSplineCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataInterfaceMultiSpline.__PropertyOffset_MaxSplineCount) = value;
			}
		}

		// Token: 0x060239F6 RID: 145910 RVA: 0x0034A93A File Offset: 0x00348B3A
		static UNiagaraDataInterfaceMultiSpline()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceMultiSpline");
		}

		// Token: 0x060239F7 RID: 145911 RVA: 0x0034A948 File Offset: 0x00348B48
		protected UNiagaraDataInterfaceMultiSpline(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013182 RID: 78210
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceMultiSpline";

		// Token: 0x04013183 RID: 78211
		private static IntPtr _ClassPtr;

		// Token: 0x04013184 RID: 78212
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013185 RID: 78213
		internal static int __PropertyOffset_Source;

		// Token: 0x04013186 RID: 78214
		internal static int __PropertyOffset_SplineComponents;

		// Token: 0x04013187 RID: 78215
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USplineComponent> _SplineComponents;

		// Token: 0x04013188 RID: 78216
		internal static int __PropertyOffset_bUseLUT;

		// Token: 0x04013189 RID: 78217
		internal static int __PropertyOffset_NumLUTSteps;

		// Token: 0x0401318A RID: 78218
		internal static int __PropertyOffset_MaxSplineCount;
	}
}
