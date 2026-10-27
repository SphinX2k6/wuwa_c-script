using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001783 RID: 6019
	[UnrealObjectPath("/Script/KuroComputeShader.JacobiChainActor")]
	[UnrealStructLayout(1440, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1440)]
	public class AJacobiChainActor : AKuroBPActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06015A0C RID: 88588 RVA: 0x001FCD7F File Offset: 0x001FAF7F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AJacobiChainActor._ClassPtr;
		}

		// Token: 0x06015A0D RID: 88589 RVA: 0x001FCD8C File Offset: 0x001FAF8C
		public AJacobiChainActor() : this(BuiltinUtils.AllocNativeUObject(AJacobiChainActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06015A0E RID: 88590 RVA: 0x001FCDB4 File Offset: 0x001FAFB4
		[NullableContext(1)]
		public AJacobiChainActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AJacobiChainActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700556C RID: 21868
		// (get) Token: 0x06015A0F RID: 88591 RVA: 0x001FCDE7 File Offset: 0x001FAFE7
		// (set) Token: 0x06015A10 RID: 88592 RVA: 0x001FCDFB File Offset: 0x001FAFFB
		[Nullable(2)]
		public unsafe UJacobiChainComponent JacobiChain
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UJacobiChainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AJacobiChainActor.__PropertyOffset_JacobiChain);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AJacobiChainActor.__PropertyOffset_JacobiChain, value);
			}
		}

		// Token: 0x06015A11 RID: 88593 RVA: 0x001FCE10 File Offset: 0x001FB010
		static AJacobiChainActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroComputeShader.JacobiChainActor");
		}

		// Token: 0x06015A12 RID: 88594 RVA: 0x001FCE1E File Offset: 0x001FB01E
		protected AJacobiChainActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400BCFB RID: 48379
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroComputeShader.JacobiChainActor";

		// Token: 0x0400BCFC RID: 48380
		private static IntPtr _ClassPtr;

		// Token: 0x0400BCFD RID: 48381
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400BCFE RID: 48382
		internal static int __PropertyOffset_JacobiChain;
	}
}
