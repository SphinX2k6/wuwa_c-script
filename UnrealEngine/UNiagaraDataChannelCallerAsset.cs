using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200254B RID: 9547
	[UnrealObjectPath("/Script/Niagara.NiagaraDataChannelCallerAsset")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UNiagaraDataChannelCallerAsset : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602379B RID: 145307 RVA: 0x0034712F File Offset: 0x0034532F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraDataChannelCallerAsset._ClassPtr;
		}

		// Token: 0x0602379C RID: 145308 RVA: 0x0034713C File Offset: 0x0034533C
		public UNiagaraDataChannelCallerAsset() : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelCallerAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602379D RID: 145309 RVA: 0x00347164 File Offset: 0x00345364
		[NullableContext(1)]
		public UNiagaraDataChannelCallerAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraDataChannelCallerAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008840 RID: 34880
		// (get) Token: 0x0602379E RID: 145310 RVA: 0x00347197 File Offset: 0x00345397
		// (set) Token: 0x0602379F RID: 145311 RVA: 0x003471AB File Offset: 0x003453AB
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset DataChannelAsset
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelCallerAsset.__PropertyOffset_DataChannelAsset);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraDataChannelCallerAsset.__PropertyOffset_DataChannelAsset, value);
			}
		}

		// Token: 0x17008841 RID: 34881
		// (get) Token: 0x060237A0 RID: 145312 RVA: 0x003471C0 File Offset: 0x003453C0
		// (set) Token: 0x060237A1 RID: 145313 RVA: 0x003471D0 File Offset: 0x003453D0
		public unsafe bool bRandomSpawn
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_bRandomSpawn) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_bRandomSpawn) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008842 RID: 34882
		// (get) Token: 0x060237A2 RID: 145314 RVA: 0x003471E1 File Offset: 0x003453E1
		// (set) Token: 0x060237A3 RID: 145315 RVA: 0x003471F1 File Offset: 0x003453F1
		public unsafe float RandomSpawnTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_RandomSpawnTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_RandomSpawnTimeScale) = value;
			}
		}

		// Token: 0x17008843 RID: 34883
		// (get) Token: 0x060237A4 RID: 145316 RVA: 0x00347202 File Offset: 0x00345402
		// (set) Token: 0x060237A5 RID: 145317 RVA: 0x00347212 File Offset: 0x00345412
		public unsafe float SpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_SpawnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraDataChannelCallerAsset.__PropertyOffset_SpawnRate) = value;
			}
		}

		// Token: 0x060237A6 RID: 145318 RVA: 0x00347223 File Offset: 0x00345423
		static UNiagaraDataChannelCallerAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraDataChannelCallerAsset");
		}

		// Token: 0x060237A7 RID: 145319 RVA: 0x00347231 File Offset: 0x00345431
		protected UNiagaraDataChannelCallerAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401305C RID: 77916
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraDataChannelCallerAsset";

		// Token: 0x0401305D RID: 77917
		private static IntPtr _ClassPtr;

		// Token: 0x0401305E RID: 77918
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0401305F RID: 77919
		internal static int __PropertyOffset_DataChannelAsset;

		// Token: 0x04013060 RID: 77920
		internal static int __PropertyOffset_bRandomSpawn;

		// Token: 0x04013061 RID: 77921
		internal static int __PropertyOffset_RandomSpawnTimeScale;

		// Token: 0x04013062 RID: 77922
		internal static int __PropertyOffset_SpawnRate;
	}
}
