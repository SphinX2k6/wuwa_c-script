using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002518 RID: 9496
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.KuroNDCEffectInstance")]
	[UnrealStructLayout(1088, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public class AKuroNDCEffectInstance : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06023496 RID: 144534 RVA: 0x003430A1 File Offset: 0x003412A1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroNDCEffectInstance._ClassPtr;
		}

		// Token: 0x06023497 RID: 144535 RVA: 0x003430B0 File Offset: 0x003412B0
		public AKuroNDCEffectInstance() : this(BuiltinUtils.AllocNativeUObject(AKuroNDCEffectInstance.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023498 RID: 144536 RVA: 0x003430D8 File Offset: 0x003412D8
		[NullableContext(1)]
		public AKuroNDCEffectInstance(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroNDCEffectInstance.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170087BE RID: 34750
		// (get) Token: 0x06023499 RID: 144537 RVA: 0x0034310B File Offset: 0x0034130B
		// (set) Token: 0x0602349A RID: 144538 RVA: 0x0034311F File Offset: 0x0034131F
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<USceneComponent> GroupRootCmp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_GroupRootCmp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_GroupRootCmp) = value;
			}
		}

		// Token: 0x170087BF RID: 34751
		// (get) Token: 0x0602349B RID: 144539 RVA: 0x00343134 File Offset: 0x00341334
		// (set) Token: 0x0602349C RID: 144540 RVA: 0x00343148 File Offset: 0x00341348
		public unsafe UNiagaraDataChannelAsset DataChannelAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectInstance.__PropertyOffset_DataChannelAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectInstance.__PropertyOffset_DataChannelAsset, value);
			}
		}

		// Token: 0x170087C0 RID: 34752
		// (get) Token: 0x0602349D RID: 144541 RVA: 0x0034315D File Offset: 0x0034135D
		// (set) Token: 0x0602349E RID: 144542 RVA: 0x0034316D File Offset: 0x0034136D
		public unsafe float SpawnRate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_SpawnRate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_SpawnRate) = value;
			}
		}

		// Token: 0x170087C1 RID: 34753
		// (get) Token: 0x0602349F RID: 144543 RVA: 0x0034317E File Offset: 0x0034137E
		// (set) Token: 0x060234A0 RID: 144544 RVA: 0x0034318E File Offset: 0x0034138E
		public unsafe float RandomDelayTimeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_RandomDelayTimeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroNDCEffectInstance.__PropertyOffset_RandomDelayTimeScale) = value;
			}
		}

		// Token: 0x170087C2 RID: 34754
		// (get) Token: 0x060234A1 RID: 144545 RVA: 0x0034319F File Offset: 0x0034139F
		// (set) Token: 0x060234A2 RID: 144546 RVA: 0x003431B3 File Offset: 0x003413B3
		public unsafe USceneComponent SceneComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectInstance.__PropertyOffset_SceneComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AKuroNDCEffectInstance.__PropertyOffset_SceneComponent, value);
			}
		}

		// Token: 0x060234A3 RID: 144547 RVA: 0x003431C8 File Offset: 0x003413C8
		static AKuroNDCEffectInstance()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.KuroNDCEffectInstance");
		}

		// Token: 0x060234A4 RID: 144548 RVA: 0x003431D6 File Offset: 0x003413D6
		protected AKuroNDCEffectInstance(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012F18 RID: 77592
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.KuroNDCEffectInstance";

		// Token: 0x04012F19 RID: 77593
		private static IntPtr _ClassPtr;

		// Token: 0x04012F1A RID: 77594
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012F1B RID: 77595
		internal static int __PropertyOffset_GroupRootCmp;

		// Token: 0x04012F1C RID: 77596
		internal static int __PropertyOffset_DataChannelAsset;

		// Token: 0x04012F1D RID: 77597
		internal static int __PropertyOffset_SpawnRate;

		// Token: 0x04012F1E RID: 77598
		internal static int __PropertyOffset_RandomDelayTimeScale;

		// Token: 0x04012F1F RID: 77599
		internal static int __PropertyOffset_SceneComponent;
	}
}
