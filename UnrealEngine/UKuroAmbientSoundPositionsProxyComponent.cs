using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001695 RID: 5781
	[UnrealObjectPath("/Script/KuroAudio.KuroAmbientSoundPositionsProxyComponent")]
	[UnrealStructLayout(2288, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2288)]
	public class UKuroAmbientSoundPositionsProxyComponent : UInstancedStaticMeshComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014F71 RID: 85873 RVA: 0x001ED171 File Offset: 0x001EB371
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroAmbientSoundPositionsProxyComponent._ClassPtr;
		}

		// Token: 0x06014F72 RID: 85874 RVA: 0x001ED180 File Offset: 0x001EB380
		public UKuroAmbientSoundPositionsProxyComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundPositionsProxyComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014F73 RID: 85875 RVA: 0x001ED1A8 File Offset: 0x001EB3A8
		[NullableContext(1)]
		public UKuroAmbientSoundPositionsProxyComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroAmbientSoundPositionsProxyComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700530C RID: 21260
		// (get) Token: 0x06014F74 RID: 85876 RVA: 0x001ED1DB File Offset: 0x001EB3DB
		// (set) Token: 0x06014F75 RID: 85877 RVA: 0x001ED1EF File Offset: 0x001EB3EF
		[Nullable(2)]
		public unsafe UKuroAmbientSoundComponent TargetComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroAmbientSoundComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAmbientSoundPositionsProxyComponent.__PropertyOffset_TargetComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroAmbientSoundPositionsProxyComponent.__PropertyOffset_TargetComponent, value);
			}
		}

		// Token: 0x06014F76 RID: 85878 RVA: 0x001ED204 File Offset: 0x001EB404
		static UKuroAmbientSoundPositionsProxyComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.KuroAmbientSoundPositionsProxyComponent");
		}

		// Token: 0x06014F77 RID: 85879 RVA: 0x001ED212 File Offset: 0x001EB412
		protected UKuroAmbientSoundPositionsProxyComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6C6 RID: 46790
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAudio.KuroAmbientSoundPositionsProxyComponent";

		// Token: 0x0400B6C7 RID: 46791
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6C8 RID: 46792
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6C9 RID: 46793
		internal static int __PropertyOffset_TargetComponent;
	}
}
