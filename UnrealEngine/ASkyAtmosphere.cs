using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001113 RID: 4371
	[UnrealObjectPath("/Script/Engine.SkyAtmosphere")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public class ASkyAtmosphere : AInfo, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FE5A RID: 65114 RVA: 0x00177672 File Offset: 0x00175872
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ASkyAtmosphere._ClassPtr;
		}

		// Token: 0x0600FE5B RID: 65115 RVA: 0x00177680 File Offset: 0x00175880
		public ASkyAtmosphere() : this(BuiltinUtils.AllocNativeUObject(ASkyAtmosphere.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FE5C RID: 65116 RVA: 0x001776A8 File Offset: 0x001758A8
		[NullableContext(1)]
		public ASkyAtmosphere(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ASkyAtmosphere.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E07 RID: 15879
		// (get) Token: 0x0600FE5D RID: 65117 RVA: 0x001776DB File Offset: 0x001758DB
		// (set) Token: 0x0600FE5E RID: 65118 RVA: 0x001776EF File Offset: 0x001758EF
		[Nullable(2)]
		public unsafe USkyAtmosphereComponent SkyAtmosphereComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USkyAtmosphereComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ASkyAtmosphere.__PropertyOffset_SkyAtmosphereComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ASkyAtmosphere.__PropertyOffset_SkyAtmosphereComponent, value);
			}
		}

		// Token: 0x0600FE5F RID: 65119 RVA: 0x00177704 File Offset: 0x00175904
		static ASkyAtmosphere()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkyAtmosphere");
		}

		// Token: 0x0600FE60 RID: 65120 RVA: 0x00177712 File Offset: 0x00175912
		protected ASkyAtmosphere(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008902 RID: 35074
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkyAtmosphere";

		// Token: 0x04008903 RID: 35075
		private static IntPtr _ClassPtr;

		// Token: 0x04008904 RID: 35076
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008905 RID: 35077
		internal static int __PropertyOffset_SkyAtmosphereComponent;
	}
}
