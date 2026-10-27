using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256F RID: 9583
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceCurve")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UNiagaraDataInterfaceCurve : UNiagaraDataInterfaceCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602393F RID: 145727 RVA: 0x003497BB File Offset: 0x003479BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceCurve._ClassPtr;
		}

		// Token: 0x06023940 RID: 145728 RVA: 0x003497C8 File Offset: 0x003479C8
		public UNiagaraDataInterfaceCurve() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023941 RID: 145729 RVA: 0x003497F0 File Offset: 0x003479F0
		public UNiagaraDataInterfaceCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008882 RID: 34946
		// (get) Token: 0x06023942 RID: 145730 RVA: 0x00349824 File Offset: 0x00347A24
		// (set) Token: 0x06023943 RID: 145731 RVA: 0x0034985D File Offset: 0x00347A5D
		public FRichCurve Curve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._Curve) == null)
				{
					result = (this._Curve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurve.__PropertyOffset_Curve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceCurve.__PropertyOffset_Curve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023944 RID: 145732 RVA: 0x0034987E File Offset: 0x00347A7E
		static UNiagaraDataInterfaceCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceCurve");
		}

		// Token: 0x06023945 RID: 145733 RVA: 0x0034988C File Offset: 0x00347A8C
		protected UNiagaraDataInterfaceCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013123 RID: 78115
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceCurve";

		// Token: 0x04013124 RID: 78116
		private static IntPtr _ClassPtr;

		// Token: 0x04013125 RID: 78117
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013126 RID: 78118
		internal static int __PropertyOffset_Curve;

		// Token: 0x04013127 RID: 78119
		[Nullable(2)]
		private FRichCurve _Curve;
	}
}
