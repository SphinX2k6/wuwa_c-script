using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258B RID: 9611
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceVector2DCurve")]
	[UnrealStructLayout(448, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 448)]
	public class UNiagaraDataInterfaceVector2DCurve : UNiagaraDataInterfaceCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023AB5 RID: 146101 RVA: 0x0034BC6F File Offset: 0x00349E6F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceVector2DCurve._ClassPtr;
		}

		// Token: 0x06023AB6 RID: 146102 RVA: 0x0034BC7C File Offset: 0x00349E7C
		public UNiagaraDataInterfaceVector2DCurve() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVector2DCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AB7 RID: 146103 RVA: 0x0034BCA4 File Offset: 0x00349EA4
		public UNiagaraDataInterfaceVector2DCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVector2DCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088EF RID: 35055
		// (get) Token: 0x06023AB8 RID: 146104 RVA: 0x0034BCD8 File Offset: 0x00349ED8
		// (set) Token: 0x06023AB9 RID: 146105 RVA: 0x0034BD11 File Offset: 0x00349F11
		public FRichCurve XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector2DCurve.__PropertyOffset_XCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector2DCurve.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F0 RID: 35056
		// (get) Token: 0x06023ABA RID: 146106 RVA: 0x0034BD34 File Offset: 0x00349F34
		// (set) Token: 0x06023ABB RID: 146107 RVA: 0x0034BD6D File Offset: 0x00349F6D
		public FRichCurve YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector2DCurve.__PropertyOffset_YCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector2DCurve.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023ABC RID: 146108 RVA: 0x0034BD8E File Offset: 0x00349F8E
		static UNiagaraDataInterfaceVector2DCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceVector2DCurve");
		}

		// Token: 0x06023ABD RID: 146109 RVA: 0x0034BD9C File Offset: 0x00349F9C
		protected UNiagaraDataInterfaceVector2DCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013205 RID: 78341
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceVector2DCurve";

		// Token: 0x04013206 RID: 78342
		private static IntPtr _ClassPtr;

		// Token: 0x04013207 RID: 78343
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013208 RID: 78344
		internal static int __PropertyOffset_XCurve;

		// Token: 0x04013209 RID: 78345
		[Nullable(2)]
		private FRichCurve _XCurve;

		// Token: 0x0401320A RID: 78346
		internal static int __PropertyOffset_YCurve;

		// Token: 0x0401320B RID: 78347
		[Nullable(2)]
		private FRichCurve _YCurve;
	}
}
