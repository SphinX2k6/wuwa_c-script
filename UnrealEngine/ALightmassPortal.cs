using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D56 RID: 3414
	[UnrealObjectPath("/Script/Engine.LightmassPortal")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class ALightmassPortal : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B83F RID: 47167 RVA: 0x00106339 File Offset: 0x00104539
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALightmassPortal._ClassPtr;
		}

		// Token: 0x0600B840 RID: 47168 RVA: 0x00106348 File Offset: 0x00104548
		public ALightmassPortal() : this(BuiltinUtils.AllocNativeUObject(ALightmassPortal.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B841 RID: 47169 RVA: 0x00106370 File Offset: 0x00104570
		[NullableContext(1)]
		public ALightmassPortal(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALightmassPortal.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x0600B842 RID: 47170 RVA: 0x001063A3 File Offset: 0x001045A3
		// (set) Token: 0x0600B843 RID: 47171 RVA: 0x001063B7 File Offset: 0x001045B7
		[Nullable(2)]
		public unsafe ULightmassPortalComponent PortalComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULightmassPortalComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALightmassPortal.__PropertyOffset_PortalComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALightmassPortal.__PropertyOffset_PortalComponent, value);
			}
		}

		// Token: 0x0600B844 RID: 47172 RVA: 0x001063CC File Offset: 0x001045CC
		static ALightmassPortal()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightmassPortal");
		}

		// Token: 0x0600B845 RID: 47173 RVA: 0x001063DA File Offset: 0x001045DA
		protected ALightmassPortal(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400608B RID: 24715
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightmassPortal";

		// Token: 0x0400608C RID: 24716
		private static IntPtr _ClassPtr;

		// Token: 0x0400608D RID: 24717
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400608E RID: 24718
		internal static int __PropertyOffset_PortalComponent;
	}
}
