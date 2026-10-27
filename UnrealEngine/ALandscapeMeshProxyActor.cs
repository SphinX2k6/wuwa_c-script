using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001F83 RID: 8067
	[UnrealObjectPath("/Script/Landscape.LandscapeMeshProxyActor")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ALandscapeMeshProxyActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601E995 RID: 125333 RVA: 0x002D7963 File Offset: 0x002D5B63
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ALandscapeMeshProxyActor._ClassPtr;
		}

		// Token: 0x0601E996 RID: 125334 RVA: 0x002D7970 File Offset: 0x002D5B70
		public ALandscapeMeshProxyActor() : this(BuiltinUtils.AllocNativeUObject(ALandscapeMeshProxyActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601E997 RID: 125335 RVA: 0x002D7998 File Offset: 0x002D5B98
		[NullableContext(1)]
		public ALandscapeMeshProxyActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ALandscapeMeshProxyActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170079BD RID: 31165
		// (get) Token: 0x0601E998 RID: 125336 RVA: 0x002D79CB File Offset: 0x002D5BCB
		// (set) Token: 0x0601E999 RID: 125337 RVA: 0x002D79DF File Offset: 0x002D5BDF
		[Nullable(2)]
		public unsafe ULandscapeMeshProxyComponent LandscapeMeshProxyComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULandscapeMeshProxyComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeMeshProxyActor.__PropertyOffset_LandscapeMeshProxyComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ALandscapeMeshProxyActor.__PropertyOffset_LandscapeMeshProxyComponent, value);
			}
		}

		// Token: 0x0601E99A RID: 125338 RVA: 0x002D79F4 File Offset: 0x002D5BF4
		static ALandscapeMeshProxyActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Landscape.LandscapeMeshProxyActor");
		}

		// Token: 0x0601E99B RID: 125339 RVA: 0x002D7A02 File Offset: 0x002D5C02
		protected ALandscapeMeshProxyActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010891 RID: 67729
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Landscape.LandscapeMeshProxyActor";

		// Token: 0x04010892 RID: 67730
		private static IntPtr _ClassPtr;

		// Token: 0x04010893 RID: 67731
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010894 RID: 67732
		internal static int __PropertyOffset_LandscapeMeshProxyComponent;
	}
}
