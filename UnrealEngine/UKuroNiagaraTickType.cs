using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200251A RID: 9498
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroNiagaraTickType")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class UKuroNiagaraTickType : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060234B1 RID: 144561 RVA: 0x003432CF File Offset: 0x003414CF
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroNiagaraTickType._ClassPtr;
		}

		// Token: 0x060234B2 RID: 144562 RVA: 0x003432DC File Offset: 0x003414DC
		public UKuroNiagaraTickType() : this(BuiltinUtils.AllocNativeUObject(UKuroNiagaraTickType.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060234B3 RID: 144563 RVA: 0x00343304 File Offset: 0x00341504
		public UKuroNiagaraTickType(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroNiagaraTickType.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087C5 RID: 34757
		// (get) Token: 0x060234B4 RID: 144564 RVA: 0x00343338 File Offset: 0x00341538
		// (set) Token: 0x060234B5 RID: 144565 RVA: 0x00343371 File Offset: 0x00341571
		public TArray<FKuroTickByDistanceSetting> Settings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroTickByDistanceSetting> result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new TArray<FKuroTickByDistanceSetting>(base.NativePtr + (IntPtr)UKuroNiagaraTickType.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				this.Settings.CopyAssign(value);
			}
		}

		// Token: 0x060234B6 RID: 144566 RVA: 0x0034337F File Offset: 0x0034157F
		static UKuroNiagaraTickType()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.KuroNiagaraTickType");
		}

		// Token: 0x060234B7 RID: 144567 RVA: 0x0034338D File Offset: 0x0034158D
		protected UKuroNiagaraTickType(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F25 RID: 77605
		public new const string __ObjectPath = "/Script/Niagara.KuroNiagaraTickType";

		// Token: 0x04012F26 RID: 77606
		private static IntPtr _ClassPtr;

		// Token: 0x04012F27 RID: 77607
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F28 RID: 77608
		internal static int __PropertyOffset_Settings;

		// Token: 0x04012F29 RID: 77609
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroTickByDistanceSetting> _Settings;
	}
}
