using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001D96 RID: 7574
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_DA_FX")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UKSC_DA_FX : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601CFB2 RID: 118706 RVA: 0x002AD653 File Offset: 0x002AB853
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_DA_FX._ClassPtr;
		}

		// Token: 0x0601CFB3 RID: 118707 RVA: 0x002AD660 File Offset: 0x002AB860
		public UKSC_DA_FX() : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_FX.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601CFB4 RID: 118708 RVA: 0x002AD688 File Offset: 0x002AB888
		public UKSC_DA_FX(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKSC_DA_FX.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170074E7 RID: 29927
		// (get) Token: 0x0601CFB5 RID: 118709 RVA: 0x002AD6BB File Offset: 0x002AB8BB
		// (set) Token: 0x0601CFB6 RID: 118710 RVA: 0x002AD6CB File Offset: 0x002AB8CB
		public unsafe EKSC_FXBindingType FXBindingType
		{
			get
			{
				return (EKSC_FXBindingType)(*(base.NativePtr + (IntPtr)UKSC_DA_FX.__PropertyOffset_FXBindingType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_FX.__PropertyOffset_FXBindingType) = (byte)value;
			}
		}

		// Token: 0x170074E8 RID: 29928
		// (get) Token: 0x0601CFB7 RID: 118711 RVA: 0x002AD6DC File Offset: 0x002AB8DC
		// (set) Token: 0x0601CFB8 RID: 118712 RVA: 0x002AD6F0 File Offset: 0x002AB8F0
		public unsafe FTransform OffsetTrans
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_DA_FX.__PropertyOffset_OffsetTrans);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_DA_FX.__PropertyOffset_OffsetTrans) = value;
			}
		}

		// Token: 0x170074E9 RID: 29929
		// (get) Token: 0x0601CFB9 RID: 118713 RVA: 0x002AD705 File Offset: 0x002AB905
		// (set) Token: 0x0601CFBA RID: 118714 RVA: 0x002AD719 File Offset: 0x002AB919
		[Nullable(2)]
		public unsafe UNiagaraSystem FX
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_FX.__PropertyOffset_FX);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_DA_FX.__PropertyOffset_FX, value);
			}
		}

		// Token: 0x170074EA RID: 29930
		// (get) Token: 0x0601CFBB RID: 118715 RVA: 0x002AD730 File Offset: 0x002AB930
		// (set) Token: 0x0601CFBC RID: 118716 RVA: 0x002AD769 File Offset: 0x002AB969
		public TArray<FKSC_FXParam> Params
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKSC_FXParam> result;
				if ((result = this._Params) == null)
				{
					result = (this._Params = new TArray<FKSC_FXParam>(base.NativePtr + (IntPtr)UKSC_DA_FX.__PropertyOffset_Params, this));
				}
				return result;
			}
			set
			{
				this.Params.CopyAssign(value);
			}
		}

		// Token: 0x0601CFBD RID: 118717 RVA: 0x002AD777 File Offset: 0x002AB977
		static UKSC_DA_FX()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_DA_FX");
		}

		// Token: 0x0601CFBE RID: 118718 RVA: 0x002AD785 File Offset: 0x002AB985
		protected UKSC_DA_FX(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FBAE RID: 64430
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_DA_FX";

		// Token: 0x0400FBAF RID: 64431
		private static IntPtr _ClassPtr;

		// Token: 0x0400FBB0 RID: 64432
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FBB1 RID: 64433
		internal static int __PropertyOffset_FXBindingType;

		// Token: 0x0400FBB2 RID: 64434
		internal static int __PropertyOffset_OffsetTrans;

		// Token: 0x0400FBB3 RID: 64435
		internal static int __PropertyOffset_FX;

		// Token: 0x0400FBB4 RID: 64436
		internal static int __PropertyOffset_Params;

		// Token: 0x0400FBB5 RID: 64437
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKSC_FXParam> _Params;
	}
}
