using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001774 RID: 6004
	[UnrealObjectPath("/Script/KuroComputeShader.CSBatchedChainEditableComponent")]
	[UnrealStructLayout(2032, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2032)]
	public class UCSBatchedChainEditableComponent : UStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060159F7 RID: 88567 RVA: 0x001FCBE8 File Offset: 0x001FADE8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UCSBatchedChainEditableComponent._ClassPtr;
		}

		// Token: 0x060159F8 RID: 88568 RVA: 0x001FCBF4 File Offset: 0x001FADF4
		public UCSBatchedChainEditableComponent() : this(BuiltinUtils.AllocNativeUObject(UCSBatchedChainEditableComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060159F9 RID: 88569 RVA: 0x001FCC1C File Offset: 0x001FAE1C
		[NullableContext(1)]
		public UCSBatchedChainEditableComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UCSBatchedChainEditableComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005568 RID: 21864
		// (get) Token: 0x060159FA RID: 88570 RVA: 0x001FCC4F File Offset: 0x001FAE4F
		// (set) Token: 0x060159FB RID: 88571 RVA: 0x001FCC63 File Offset: 0x001FAE63
		[Nullable(2)]
		public unsafe UJacobiChainAsset SimulationProfile
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UCSBatchedChainEditableComponent.__PropertyOffset_SimulationProfile);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UCSBatchedChainEditableComponent.__PropertyOffset_SimulationProfile, value);
			}
		}

		// Token: 0x060159FC RID: 88572 RVA: 0x001FCC78 File Offset: 0x001FAE78
		static UCSBatchedChainEditableComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.CSBatchedChainEditableComponent");
		}

		// Token: 0x060159FD RID: 88573 RVA: 0x001FCC86 File Offset: 0x001FAE86
		protected UCSBatchedChainEditableComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BCB3 RID: 48307
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.CSBatchedChainEditableComponent";

		// Token: 0x0400BCB4 RID: 48308
		private static IntPtr _ClassPtr;

		// Token: 0x0400BCB5 RID: 48309
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BCB6 RID: 48310
		internal static int __PropertyOffset_SimulationProfile;
	}
}
