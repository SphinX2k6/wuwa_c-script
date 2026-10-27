using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200254F RID: 9551
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelHandler_Islands")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class UNiagaraDataChannelHandler_Islands : UNiagaraDataChannelHandler, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060237C3 RID: 145347 RVA: 0x003474DE File Offset: 0x003456DE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelHandler_Islands._ClassPtr;
		}

		// Token: 0x060237C4 RID: 145348 RVA: 0x003474EC File Offset: 0x003456EC
		public UNiagaraDataChannelHandler_Islands() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Islands.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060237C5 RID: 145349 RVA: 0x00347514 File Offset: 0x00345714
		public UNiagaraDataChannelHandler_Islands(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelHandler_Islands.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008848 RID: 34888
		// (get) Token: 0x060237C6 RID: 145350 RVA: 0x00347548 File Offset: 0x00345748
		// (set) Token: 0x060237C7 RID: 145351 RVA: 0x00347581 File Offset: 0x00345781
		public TArray<int> ActiveIslandsArray
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._ActiveIslandsArray) == null)
				{
					result = (this._ActiveIslandsArray = new TArray<int>(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler_Islands.__PropertyOffset_ActiveIslandsArray, this));
				}
				return result;
			}
			set
			{
				this.ActiveIslandsArray.CopyAssign(value);
			}
		}

		// Token: 0x17008849 RID: 34889
		// (get) Token: 0x060237C8 RID: 145352 RVA: 0x00347590 File Offset: 0x00345790
		// (set) Token: 0x060237C9 RID: 145353 RVA: 0x003475C9 File Offset: 0x003457C9
		public TArray<int> FreeIslands
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._FreeIslands) == null)
				{
					result = (this._FreeIslands = new TArray<int>(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler_Islands.__PropertyOffset_FreeIslands, this));
				}
				return result;
			}
			set
			{
				this.FreeIslands.CopyAssign(value);
			}
		}

		// Token: 0x1700884A RID: 34890
		// (get) Token: 0x060237CA RID: 145354 RVA: 0x003475D8 File Offset: 0x003457D8
		// (set) Token: 0x060237CB RID: 145355 RVA: 0x00347611 File Offset: 0x00345811
		public TArray<FNDCIsland> IslandPool
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNDCIsland> result;
				if ((result = this._IslandPool) == null)
				{
					result = (this._IslandPool = new TArray<FNDCIsland>(base.NativePtr + (IntPtr)UNiagaraDataChannelHandler_Islands.__PropertyOffset_IslandPool, this));
				}
				return result;
			}
			set
			{
				this.IslandPool.CopyAssign(value);
			}
		}

		// Token: 0x060237CC RID: 145356 RVA: 0x0034761F File Offset: 0x0034581F
		static UNiagaraDataChannelHandler_Islands()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelHandler_Islands");
		}

		// Token: 0x060237CD RID: 145357 RVA: 0x0034762D File Offset: 0x0034582D
		protected UNiagaraDataChannelHandler_Islands(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013072 RID: 77938
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelHandler_Islands";

		// Token: 0x04013073 RID: 77939
		private static IntPtr _ClassPtr;

		// Token: 0x04013074 RID: 77940
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013075 RID: 77941
		internal static int __PropertyOffset_ActiveIslandsArray;

		// Token: 0x04013076 RID: 77942
		[Nullable(2)]
		private TArray<int> _ActiveIslandsArray;

		// Token: 0x04013077 RID: 77943
		internal static int __PropertyOffset_FreeIslands;

		// Token: 0x04013078 RID: 77944
		[Nullable(2)]
		private TArray<int> _FreeIslands;

		// Token: 0x04013079 RID: 77945
		internal static int __PropertyOffset_IslandPool;

		// Token: 0x0401307A RID: 77946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNDCIsland> _IslandPool;
	}
}
