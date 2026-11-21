using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000516 RID: 1302
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRopeEffect.ArcRopeDataAsset")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UArcRopeDataAsset : UPrimaryDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060079CF RID: 31183 RVA: 0x000B2AE9 File Offset: 0x000B0CE9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UArcRopeDataAsset._ClassPtr;
		}

		// Token: 0x060079D0 RID: 31184 RVA: 0x000B2AF8 File Offset: 0x000B0CF8
		public UArcRopeDataAsset() : this(BuiltinUtils.AllocNativeUObject(UArcRopeDataAsset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060079D1 RID: 31185 RVA: 0x000B2B20 File Offset: 0x000B0D20
		public UArcRopeDataAsset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UArcRopeDataAsset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700179F RID: 6047
		// (get) Token: 0x060079D2 RID: 31186 RVA: 0x000B2B53 File Offset: 0x000B0D53
		// (set) Token: 0x060079D3 RID: 31187 RVA: 0x000B2B68 File Offset: 0x000B0D68
		public TSoftObjectPtr<UNiagaraSystem> NiagaraEffect
		{
			get
			{
				return new TSoftObjectPtr<UNiagaraSystem>(base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_NiagaraEffect, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UArcRopeDataAsset.__PropertyOffset_NiagaraEffect, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x060079D4 RID: 31188 RVA: 0x000B2B8D File Offset: 0x000B0D8D
		static UArcRopeDataAsset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRopeEffect.ArcRopeDataAsset");
		}

		// Token: 0x060079D5 RID: 31189 RVA: 0x000B2B9B File Offset: 0x000B0D9B
		protected UArcRopeDataAsset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040033BF RID: 13247
		public new const string __ObjectPath = "/Script/KuroRopeEffect.ArcRopeDataAsset";

		// Token: 0x040033C0 RID: 13248
		private static IntPtr _ClassPtr;

		// Token: 0x040033C1 RID: 13249
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040033C2 RID: 13250
		internal static int __PropertyOffset_NiagaraEffect;
	}
}
