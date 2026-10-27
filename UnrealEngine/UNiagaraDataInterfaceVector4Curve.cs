using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258C RID: 9612
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceVector4Curve")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UNiagaraDataInterfaceVector4Curve : UNiagaraDataInterfaceCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023ABE RID: 146110 RVA: 0x0034BDA5 File Offset: 0x00349FA5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceVector4Curve._ClassPtr;
		}

		// Token: 0x06023ABF RID: 146111 RVA: 0x0034BDB4 File Offset: 0x00349FB4
		public UNiagaraDataInterfaceVector4Curve() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVector4Curve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023AC0 RID: 146112 RVA: 0x0034BDDC File Offset: 0x00349FDC
		public UNiagaraDataInterfaceVector4Curve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVector4Curve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088F1 RID: 35057
		// (get) Token: 0x06023AC1 RID: 146113 RVA: 0x0034BE10 File Offset: 0x0034A010
		// (set) Token: 0x06023AC2 RID: 146114 RVA: 0x0034BE49 File Offset: 0x0034A049
		public FRichCurve XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_XCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F2 RID: 35058
		// (get) Token: 0x06023AC3 RID: 146115 RVA: 0x0034BE6C File Offset: 0x0034A06C
		// (set) Token: 0x06023AC4 RID: 146116 RVA: 0x0034BEA5 File Offset: 0x0034A0A5
		public FRichCurve YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_YCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F3 RID: 35059
		// (get) Token: 0x06023AC5 RID: 146117 RVA: 0x0034BEC8 File Offset: 0x0034A0C8
		// (set) Token: 0x06023AC6 RID: 146118 RVA: 0x0034BF01 File Offset: 0x0034A101
		public FRichCurve ZCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._ZCurve) == null)
				{
					result = (this._ZCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_ZCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_ZCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F4 RID: 35060
		// (get) Token: 0x06023AC7 RID: 146119 RVA: 0x0034BF24 File Offset: 0x0034A124
		// (set) Token: 0x06023AC8 RID: 146120 RVA: 0x0034BF5D File Offset: 0x0034A15D
		public FRichCurve WCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._WCurve) == null)
				{
					result = (this._WCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_WCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVector4Curve.__PropertyOffset_WCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023AC9 RID: 146121 RVA: 0x0034BF7E File Offset: 0x0034A17E
		static UNiagaraDataInterfaceVector4Curve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceVector4Curve");
		}

		// Token: 0x06023ACA RID: 146122 RVA: 0x0034BF8C File Offset: 0x0034A18C
		protected UNiagaraDataInterfaceVector4Curve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401320C RID: 78348
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceVector4Curve";

		// Token: 0x0401320D RID: 78349
		private static IntPtr _ClassPtr;

		// Token: 0x0401320E RID: 78350
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401320F RID: 78351
		internal static int __PropertyOffset_XCurve;

		// Token: 0x04013210 RID: 78352
		[Nullable(2)]
		private FRichCurve _XCurve;

		// Token: 0x04013211 RID: 78353
		internal static int __PropertyOffset_YCurve;

		// Token: 0x04013212 RID: 78354
		[Nullable(2)]
		private FRichCurve _YCurve;

		// Token: 0x04013213 RID: 78355
		internal static int __PropertyOffset_ZCurve;

		// Token: 0x04013214 RID: 78356
		[Nullable(2)]
		private FRichCurve _ZCurve;

		// Token: 0x04013215 RID: 78357
		internal static int __PropertyOffset_WCurve;

		// Token: 0x04013216 RID: 78358
		[Nullable(2)]
		private FRichCurve _WCurve;
	}
}
