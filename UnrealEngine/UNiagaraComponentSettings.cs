using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002547 RID: 9543
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraComponentSettings")]
	[UnrealStructLayout(288, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 288)]
	public class UNiagaraComponentSettings : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023775 RID: 145269 RVA: 0x00346D2A File Offset: 0x00344F2A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraComponentSettings._ClassPtr;
		}

		// Token: 0x06023776 RID: 145270 RVA: 0x00346D38 File Offset: 0x00344F38
		public UNiagaraComponentSettings() : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023777 RID: 145271 RVA: 0x00346D60 File Offset: 0x00344F60
		public UNiagaraComponentSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraComponentSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008836 RID: 34870
		// (get) Token: 0x06023778 RID: 145272 RVA: 0x00346D94 File Offset: 0x00344F94
		// (set) Token: 0x06023779 RID: 145273 RVA: 0x00346DCD File Offset: 0x00344FCD
		public TSet<FName> SuppressActivationList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._SuppressActivationList) == null)
				{
					result = (this._SuppressActivationList = new TSet<FName>(base.NativePtr + (IntPtr)UNiagaraComponentSettings.__PropertyOffset_SuppressActivationList, this));
				}
				return result;
			}
			set
			{
				this.SuppressActivationList.CopyAssign(value);
			}
		}

		// Token: 0x17008837 RID: 34871
		// (get) Token: 0x0602377A RID: 145274 RVA: 0x00346DDC File Offset: 0x00344FDC
		// (set) Token: 0x0602377B RID: 145275 RVA: 0x00346E15 File Offset: 0x00345015
		public TSet<FName> ForceAutoPooolingList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FName> result;
				if ((result = this._ForceAutoPooolingList) == null)
				{
					result = (this._ForceAutoPooolingList = new TSet<FName>(base.NativePtr + (IntPtr)UNiagaraComponentSettings.__PropertyOffset_ForceAutoPooolingList, this));
				}
				return result;
			}
			set
			{
				this.ForceAutoPooolingList.CopyAssign(value);
			}
		}

		// Token: 0x17008838 RID: 34872
		// (get) Token: 0x0602377C RID: 145276 RVA: 0x00346E24 File Offset: 0x00345024
		// (set) Token: 0x0602377D RID: 145277 RVA: 0x00346E5D File Offset: 0x0034505D
		public TSet<FNiagaraEmitterNameSettingsRef> SuppressEmitterList
		{
			get
			{
				base.FastCheckIsValid();
				TSet<FNiagaraEmitterNameSettingsRef> result;
				if ((result = this._SuppressEmitterList) == null)
				{
					result = (this._SuppressEmitterList = new TSet<FNiagaraEmitterNameSettingsRef>(base.NativePtr + (IntPtr)UNiagaraComponentSettings.__PropertyOffset_SuppressEmitterList, this));
				}
				return result;
			}
			set
			{
				this.SuppressEmitterList.CopyAssign(value);
			}
		}

		// Token: 0x0602377E RID: 145278 RVA: 0x00346E6B File Offset: 0x0034506B
		static UNiagaraComponentSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraComponentSettings");
		}

		// Token: 0x0602377F RID: 145279 RVA: 0x00346E79 File Offset: 0x00345079
		protected UNiagaraComponentSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013040 RID: 77888
		public new const string __ObjectPath = "/Script/Niagara.NiagaraComponentSettings";

		// Token: 0x04013041 RID: 77889
		private static IntPtr _ClassPtr;

		// Token: 0x04013042 RID: 77890
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013043 RID: 77891
		internal static int __PropertyOffset_SuppressActivationList;

		// Token: 0x04013044 RID: 77892
		[Nullable(2)]
		private TSet<FName> _SuppressActivationList;

		// Token: 0x04013045 RID: 77893
		internal static int __PropertyOffset_ForceAutoPooolingList;

		// Token: 0x04013046 RID: 77894
		[Nullable(2)]
		private TSet<FName> _ForceAutoPooolingList;

		// Token: 0x04013047 RID: 77895
		internal static int __PropertyOffset_SuppressEmitterList;

		// Token: 0x04013048 RID: 77896
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<FNiagaraEmitterNameSettingsRef> _SuppressEmitterList;
	}
}
