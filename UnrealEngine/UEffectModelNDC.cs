using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018A6 RID: 6310
	[UnrealObjectPath("/Script/KuroGameplay.EffectModelNDC")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UEffectModelNDC : UEffectModelBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017402 RID: 95234 RVA: 0x0021EB4F File Offset: 0x0021CD4F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEffectModelNDC._ClassPtr;
		}

		// Token: 0x06017403 RID: 95235 RVA: 0x0021EB5C File Offset: 0x0021CD5C
		public UEffectModelNDC() : this(BuiltinUtils.AllocNativeUObject(UEffectModelNDC.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017404 RID: 95236 RVA: 0x0021EB84 File Offset: 0x0021CD84
		[NullableContext(1)]
		public UEffectModelNDC(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEffectModelNDC.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x06017405 RID: 95237 RVA: 0x0021EBB7 File Offset: 0x0021CDB7
		// (set) Token: 0x06017406 RID: 95238 RVA: 0x0021EBCB File Offset: 0x0021CDCB
		[Nullable(2)]
		public unsafe UNiagaraDataChannelAsset NiagaraDataChannel
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNDC.__PropertyOffset_NiagaraDataChannel);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEffectModelNDC.__PropertyOffset_NiagaraDataChannel, value);
			}
		}

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x06017407 RID: 95239 RVA: 0x0021EBE0 File Offset: 0x0021CDE0
		// (set) Token: 0x06017408 RID: 95240 RVA: 0x0021EBF4 File Offset: 0x0021CDF4
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17005D94 RID: 23956
		// (get) Token: 0x06017409 RID: 95241 RVA: 0x0021EC09 File Offset: 0x0021CE09
		// (set) Token: 0x0601740A RID: 95242 RVA: 0x0021EC19 File Offset: 0x0021CE19
		public unsafe bool IgnoreActorScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_IgnoreActorScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEffectModelNDC.__PropertyOffset_IgnoreActorScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x0601740B RID: 95243 RVA: 0x0021EC2A File Offset: 0x0021CE2A
		static UEffectModelNDC()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.EffectModelNDC");
		}

		// Token: 0x0601740C RID: 95244 RVA: 0x0021EC38 File Offset: 0x0021CE38
		protected UEffectModelNDC(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C9DA RID: 51674
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.EffectModelNDC";

		// Token: 0x0400C9DB RID: 51675
		private static IntPtr _ClassPtr;

		// Token: 0x0400C9DC RID: 51676
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400C9DD RID: 51677
		internal static int __PropertyOffset_NiagaraDataChannel;

		// Token: 0x0400C9DE RID: 51678
		internal static int __PropertyOffset_Scale;

		// Token: 0x0400C9DF RID: 51679
		internal static int __PropertyOffset_IgnoreActorScale;
	}
}
