using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000864 RID: 2148
	[UnrealObjectPath("/Script/Engine.AtmosphericFog")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class AAtmosphericFog : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060073CB RID: 29643 RVA: 0x000A6354 File Offset: 0x000A4554
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AAtmosphericFog._ClassPtr;
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x000A6360 File Offset: 0x000A4560
		public AAtmosphericFog() : this(BuiltinUtils.AllocNativeUObject(AAtmosphericFog.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x000A6388 File Offset: 0x000A4588
		[NullableContext(1)]
		public AAtmosphericFog(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AAtmosphericFog.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x060073CE RID: 29646 RVA: 0x000A63BB File Offset: 0x000A45BB
		// (set) Token: 0x060073CF RID: 29647 RVA: 0x000A63CF File Offset: 0x000A45CF
		[Nullable(2)]
		public unsafe UAtmosphericFogComponent AtmosphericFogComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAtmosphericFogComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AAtmosphericFog.__PropertyOffset_AtmosphericFogComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AAtmosphericFog.__PropertyOffset_AtmosphericFogComponent, value);
			}
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x000A63E4 File Offset: 0x000A45E4
		static AAtmosphericFog()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.AtmosphericFog");
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x000A63F2 File Offset: 0x000A45F2
		protected AAtmosphericFog(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040037BB RID: 14267
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AtmosphericFog";

		// Token: 0x040037BC RID: 14268
		private static IntPtr _ClassPtr;

		// Token: 0x040037BD RID: 14269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040037BE RID: 14270
		internal static int __PropertyOffset_AtmosphericFogComponent;
	}
}
