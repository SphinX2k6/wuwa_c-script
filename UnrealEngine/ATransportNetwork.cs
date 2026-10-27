using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001943 RID: 6467
	[UnrealObjectPath("/Script/KuroGameplay.TransportNetwork")]
	[UnrealStructLayout(1048, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1048)]
	public class ATransportNetwork : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017F79 RID: 98169 RVA: 0x002323A8 File Offset: 0x002305A8
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ATransportNetwork._ClassPtr;
		}

		// Token: 0x06017F7A RID: 98170 RVA: 0x002323B4 File Offset: 0x002305B4
		public ATransportNetwork() : this(BuiltinUtils.AllocNativeUObject(ATransportNetwork.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017F7B RID: 98171 RVA: 0x002323DC File Offset: 0x002305DC
		[NullableContext(1)]
		public ATransportNetwork(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(ATransportNetwork.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700600B RID: 24587
		// (get) Token: 0x06017F7C RID: 98172 RVA: 0x0023240F File Offset: 0x0023060F
		// (set) Token: 0x06017F7D RID: 98173 RVA: 0x00232423 File Offset: 0x00230623
		[Nullable(2)]
		public unsafe UKuroTransportNetworkComponent TransportNetworkComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroTransportNetworkComponent>(base.NativePtr / (IntPtr)sizeof(void*) + ATransportNetwork.__PropertyOffset_TransportNetworkComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ATransportNetwork.__PropertyOffset_TransportNetworkComponent, value);
			}
		}

		// Token: 0x06017F7E RID: 98174 RVA: 0x00232438 File Offset: 0x00230638
		static ATransportNetwork()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.TransportNetwork");
		}

		// Token: 0x06017F7F RID: 98175 RVA: 0x00232446 File Offset: 0x00230646
		protected ATransportNetwork(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CF72 RID: 53106
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.TransportNetwork";

		// Token: 0x0400CF73 RID: 53107
		private static IntPtr _ClassPtr;

		// Token: 0x0400CF74 RID: 53108
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400CF75 RID: 53109
		internal static int __PropertyOffset_TransportNetworkComponent;
	}
}
