using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200182A RID: 6186
	[UnrealObjectPath("/Script/KuroEffectMakerRuntime.KuroEffectProxyActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class AKuroEffectProxyActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06016D36 RID: 93494 RVA: 0x0021538E File Offset: 0x0021358E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroEffectProxyActor._ClassPtr;
		}

		// Token: 0x06016D37 RID: 93495 RVA: 0x0021539C File Offset: 0x0021359C
		public AKuroEffectProxyActor() : this(BuiltinUtils.AllocNativeUObject(AKuroEffectProxyActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06016D38 RID: 93496 RVA: 0x002153C4 File Offset: 0x002135C4
		[NullableContext(1)]
		public AKuroEffectProxyActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroEffectProxyActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06016D39 RID: 93497 RVA: 0x002153F7 File Offset: 0x002135F7
		static AKuroEffectProxyActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroEffectMakerRuntime.KuroEffectProxyActor");
		}

		// Token: 0x06016D3A RID: 93498 RVA: 0x00215405 File Offset: 0x00213605
		protected AKuroEffectProxyActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400C682 RID: 50818
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroEffectMakerRuntime.KuroEffectProxyActor";

		// Token: 0x0400C683 RID: 50819
		private static IntPtr _ClassPtr;

		// Token: 0x0400C684 RID: 50820
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
