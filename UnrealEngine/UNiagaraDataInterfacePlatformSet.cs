using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200257F RID: 9599
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataInterfacePlatformSet")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UNiagaraDataInterfacePlatformSet : UNiagaraDataInterface, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023A0B RID: 145931 RVA: 0x0034AB1B File Offset: 0x00348D1B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataInterfacePlatformSet._ClassPtr;
		}

		// Token: 0x06023A0C RID: 145932 RVA: 0x0034AB28 File Offset: 0x00348D28
		public UNiagaraDataInterfacePlatformSet() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfacePlatformSet.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023A0D RID: 145933 RVA: 0x0034AB50 File Offset: 0x00348D50
		public UNiagaraDataInterfacePlatformSet(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataInterfacePlatformSet.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170088B9 RID: 35001
		// (get) Token: 0x06023A0E RID: 145934 RVA: 0x0034AB84 File Offset: 0x00348D84
		// (set) Token: 0x06023A0F RID: 145935 RVA: 0x0034ABBD File Offset: 0x00348DBD
		public FNiagaraPlatformSet Platforms
		{
			get
			{
				base.FastCheckIsValid();
				FNiagaraPlatformSet result;
				if ((result = this._Platforms) == null)
				{
					result = (this._Platforms = new FNiagaraPlatformSet(base.NativePtr + (IntPtr)UNiagaraDataInterfacePlatformSet.__PropertyOffset_Platforms, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNiagaraPlatformSet.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataInterfacePlatformSet.__PropertyOffset_Platforms, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06023A10 RID: 145936 RVA: 0x0034ABDE File Offset: 0x00348DDE
		static UNiagaraDataInterfacePlatformSet()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataInterfacePlatformSet");
		}

		// Token: 0x06023A11 RID: 145937 RVA: 0x0034ABEC File Offset: 0x00348DEC
		protected UNiagaraDataInterfacePlatformSet(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013196 RID: 78230
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataInterfacePlatformSet";

		// Token: 0x04013197 RID: 78231
		private static IntPtr _ClassPtr;

		// Token: 0x04013198 RID: 78232
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013199 RID: 78233
		internal static int __PropertyOffset_Platforms;

		// Token: 0x0401319A RID: 78234
		[Nullable(2)]
		private FNiagaraPlatformSet _Platforms;
	}
}
