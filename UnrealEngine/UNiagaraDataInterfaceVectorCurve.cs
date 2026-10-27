using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200258D RID: 9613
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceVectorCurve")]
	[UnrealStructLayout(576, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 576)]
	public class UNiagaraDataInterfaceVectorCurve : UNiagaraDataInterfaceCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023ACB RID: 146123 RVA: 0x0034BF95 File Offset: 0x0034A195
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceVectorCurve._ClassPtr;
		}

		// Token: 0x06023ACC RID: 146124 RVA: 0x0034BFA4 File Offset: 0x0034A1A4
		public UNiagaraDataInterfaceVectorCurve() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVectorCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023ACD RID: 146125 RVA: 0x0034BFCC File Offset: 0x0034A1CC
		public UNiagaraDataInterfaceVectorCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceVectorCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088F5 RID: 35061
		// (get) Token: 0x06023ACE RID: 146126 RVA: 0x0034C000 File Offset: 0x0034A200
		// (set) Token: 0x06023ACF RID: 146127 RVA: 0x0034C039 File Offset: 0x0034A239
		public FRichCurve XCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._XCurve) == null)
				{
					result = (this._XCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_XCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_XCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F6 RID: 35062
		// (get) Token: 0x06023AD0 RID: 146128 RVA: 0x0034C05C File Offset: 0x0034A25C
		// (set) Token: 0x06023AD1 RID: 146129 RVA: 0x0034C095 File Offset: 0x0034A295
		public FRichCurve YCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._YCurve) == null)
				{
					result = (this._YCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_YCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_YCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170088F7 RID: 35063
		// (get) Token: 0x06023AD2 RID: 146130 RVA: 0x0034C0B8 File Offset: 0x0034A2B8
		// (set) Token: 0x06023AD3 RID: 146131 RVA: 0x0034C0F1 File Offset: 0x0034A2F1
		public FRichCurve ZCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._ZCurve) == null)
				{
					result = (this._ZCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_ZCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceVectorCurve.__PropertyOffset_ZCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023AD4 RID: 146132 RVA: 0x0034C112 File Offset: 0x0034A312
		static UNiagaraDataInterfaceVectorCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceVectorCurve");
		}

		// Token: 0x06023AD5 RID: 146133 RVA: 0x0034C120 File Offset: 0x0034A320
		protected UNiagaraDataInterfaceVectorCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013217 RID: 78359
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceVectorCurve";

		// Token: 0x04013218 RID: 78360
		private static IntPtr _ClassPtr;

		// Token: 0x04013219 RID: 78361
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401321A RID: 78362
		internal static int __PropertyOffset_XCurve;

		// Token: 0x0401321B RID: 78363
		[Nullable(2)]
		private FRichCurve _XCurve;

		// Token: 0x0401321C RID: 78364
		internal static int __PropertyOffset_YCurve;

		// Token: 0x0401321D RID: 78365
		[Nullable(2)]
		private FRichCurve _YCurve;

		// Token: 0x0401321E RID: 78366
		internal static int __PropertyOffset_ZCurve;

		// Token: 0x0401321F RID: 78367
		[Nullable(2)]
		private FRichCurve _ZCurve;
	}
}
