using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200256D RID: 9581
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfaceColorCurve")]
	[UnrealStructLayout(704, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 704)]
	public class UNiagaraDataInterfaceColorCurve : UNiagaraDataInterfaceCurveBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602392B RID: 145707 RVA: 0x0034952A File Offset: 0x0034772A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfaceColorCurve._ClassPtr;
		}

		// Token: 0x0602392C RID: 145708 RVA: 0x00349538 File Offset: 0x00347738
		public UNiagaraDataInterfaceColorCurve() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceColorCurve.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602392D RID: 145709 RVA: 0x00349560 File Offset: 0x00347760
		public UNiagaraDataInterfaceColorCurve(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfaceColorCurve.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700887D RID: 34941
		// (get) Token: 0x0602392E RID: 145710 RVA: 0x00349594 File Offset: 0x00347794
		// (set) Token: 0x0602392F RID: 145711 RVA: 0x003495CD File Offset: 0x003477CD
		public FRichCurve RedCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._RedCurve) == null)
				{
					result = (this._RedCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_RedCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_RedCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700887E RID: 34942
		// (get) Token: 0x06023930 RID: 145712 RVA: 0x003495F0 File Offset: 0x003477F0
		// (set) Token: 0x06023931 RID: 145713 RVA: 0x00349629 File Offset: 0x00347829
		public FRichCurve GreenCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._GreenCurve) == null)
				{
					result = (this._GreenCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_GreenCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_GreenCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700887F RID: 34943
		// (get) Token: 0x06023932 RID: 145714 RVA: 0x0034964C File Offset: 0x0034784C
		// (set) Token: 0x06023933 RID: 145715 RVA: 0x00349685 File Offset: 0x00347885
		public FRichCurve BlueCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._BlueCurve) == null)
				{
					result = (this._BlueCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_BlueCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_BlueCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008880 RID: 34944
		// (get) Token: 0x06023934 RID: 145716 RVA: 0x003496A8 File Offset: 0x003478A8
		// (set) Token: 0x06023935 RID: 145717 RVA: 0x003496E1 File Offset: 0x003478E1
		public FRichCurve AlphaCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRichCurve result;
				if ((result = this._AlphaCurve) == null)
				{
					result = (this._AlphaCurve = new FRichCurve(base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_AlphaCurve, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRichCurve.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfaceColorCurve.__PropertyOffset_AlphaCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023936 RID: 145718 RVA: 0x00349702 File Offset: 0x00347902
		static UNiagaraDataInterfaceColorCurve()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfaceColorCurve");
		}

		// Token: 0x06023937 RID: 145719 RVA: 0x00349710 File Offset: 0x00347910
		protected UNiagaraDataInterfaceColorCurve(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013114 RID: 78100
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfaceColorCurve";

		// Token: 0x04013115 RID: 78101
		private static IntPtr _ClassPtr;

		// Token: 0x04013116 RID: 78102
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013117 RID: 78103
		internal static int __PropertyOffset_RedCurve;

		// Token: 0x04013118 RID: 78104
		[Nullable(2)]
		private FRichCurve _RedCurve;

		// Token: 0x04013119 RID: 78105
		internal static int __PropertyOffset_GreenCurve;

		// Token: 0x0401311A RID: 78106
		[Nullable(2)]
		private FRichCurve _GreenCurve;

		// Token: 0x0401311B RID: 78107
		internal static int __PropertyOffset_BlueCurve;

		// Token: 0x0401311C RID: 78108
		[Nullable(2)]
		private FRichCurve _BlueCurve;

		// Token: 0x0401311D RID: 78109
		internal static int __PropertyOffset_AlphaCurve;

		// Token: 0x0401311E RID: 78110
		[Nullable(2)]
		private FRichCurve _AlphaCurve;
	}
}
