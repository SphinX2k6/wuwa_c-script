using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200255A RID: 9562
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannel_Single")]
	[UnrealStructLayout(392, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 392)]
	public class UNiagaraDataChannel_Single : UNiagaraDataChannel, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023872 RID: 145522 RVA: 0x003483EA File Offset: 0x003465EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannel_Single._ClassPtr;
		}

		// Token: 0x06023873 RID: 145523 RVA: 0x003483F8 File Offset: 0x003465F8
		public UNiagaraDataChannel_Single() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Single.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023874 RID: 145524 RVA: 0x00348420 File Offset: 0x00346620
		public UNiagaraDataChannel_Single(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannel_Single.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700885F RID: 34911
		// (get) Token: 0x06023875 RID: 145525 RVA: 0x00348454 File Offset: 0x00346654
		// (set) Token: 0x06023876 RID: 145526 RVA: 0x0034848D File Offset: 0x0034668D
		public TArray<TSoftObjectPtr<UNiagaraSystem>> Systems
		{
			get
			{
				base.FastCheckIsValid();
				TArray<TSoftObjectPtr<UNiagaraSystem>> result;
				if ((result = this._Systems) == null)
				{
					result = (this._Systems = new TArray<TSoftObjectPtr<UNiagaraSystem>>(base.NativePtr + (IntPtr)UNiagaraDataChannel_Single.__PropertyOffset_Systems, this));
				}
				return result;
			}
			set
			{
				this.Systems.CopyAssign(value);
			}
		}

		// Token: 0x17008860 RID: 34912
		// (get) Token: 0x06023877 RID: 145527 RVA: 0x0034849C File Offset: 0x0034669C
		// (set) Token: 0x06023878 RID: 145528 RVA: 0x003484D5 File Offset: 0x003466D5
		public FNDCSingleDebugDrawSettings DebugDrawSettings
		{
			get
			{
				base.FastCheckIsValid();
				FNDCSingleDebugDrawSettings result;
				if ((result = this._DebugDrawSettings) == null)
				{
					result = (this._DebugDrawSettings = new FNDCSingleDebugDrawSettings(base.NativePtr + (IntPtr)UNiagaraDataChannel_Single.__PropertyOffset_DebugDrawSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FNDCSingleDebugDrawSettings.StaticStruct(), base.NativePtr + (IntPtr)UNiagaraDataChannel_Single.__PropertyOffset_DebugDrawSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17008861 RID: 34913
		// (get) Token: 0x06023879 RID: 145529 RVA: 0x003484F8 File Offset: 0x003466F8
		// (set) Token: 0x0602387A RID: 145530 RVA: 0x00348531 File Offset: 0x00346731
		public TArray<UNiagaraSystem> SystemsInternal
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraSystem> result;
				if ((result = this._SystemsInternal) == null)
				{
					result = (this._SystemsInternal = new TArray<UNiagaraSystem>(base.NativePtr + (IntPtr)UNiagaraDataChannel_Single.__PropertyOffset_SystemsInternal, this));
				}
				return result;
			}
			set
			{
				this.SystemsInternal.CopyAssign(value);
			}
		}

		// Token: 0x0602387B RID: 145531 RVA: 0x0034853F File Offset: 0x0034673F
		static UNiagaraDataChannel_Single()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannel_Single");
		}

		// Token: 0x0602387C RID: 145532 RVA: 0x0034854D File Offset: 0x0034674D
		protected UNiagaraDataChannel_Single(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040130B1 RID: 78001
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannel_Single";

		// Token: 0x040130B2 RID: 78002
		private static IntPtr _ClassPtr;

		// Token: 0x040130B3 RID: 78003
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040130B4 RID: 78004
		internal static int __PropertyOffset_Systems;

		// Token: 0x040130B5 RID: 78005
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TArray<TSoftObjectPtr<UNiagaraSystem>> _Systems;

		// Token: 0x040130B6 RID: 78006
		internal static int __PropertyOffset_DebugDrawSettings;

		// Token: 0x040130B7 RID: 78007
		[Nullable(2)]
		private FNDCSingleDebugDrawSettings _DebugDrawSettings;

		// Token: 0x040130B8 RID: 78008
		internal static int __PropertyOffset_SystemsInternal;

		// Token: 0x040130B9 RID: 78009
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraSystem> _SystemsInternal;
	}
}
