using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000AEB RID: 2795
	[UnrealObjectPath("/Script/Engine.EndpointSubmix")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UEndpointSubmix : USoundSubmixBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06009052 RID: 36946 RVA: 0x000CE8D9 File Offset: 0x000CCAD9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEndpointSubmix._ClassPtr;
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x000CE8E8 File Offset: 0x000CCAE8
		public UEndpointSubmix() : this(BuiltinUtils.AllocNativeUObject(UEndpointSubmix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x000CE910 File Offset: 0x000CCB10
		[NullableContext(1)]
		public UEndpointSubmix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UEndpointSubmix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002210 RID: 8720
		// (get) Token: 0x06009055 RID: 36949 RVA: 0x000CE943 File Offset: 0x000CCB43
		// (set) Token: 0x06009056 RID: 36950 RVA: 0x000CE957 File Offset: 0x000CCB57
		public unsafe FName EndpointType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEndpointSubmix.__PropertyOffset_EndpointType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEndpointSubmix.__PropertyOffset_EndpointType) = value;
			}
		}

		// Token: 0x17002211 RID: 8721
		// (get) Token: 0x06009057 RID: 36951 RVA: 0x000CE96C File Offset: 0x000CCB6C
		// (set) Token: 0x06009058 RID: 36952 RVA: 0x000CE980 File Offset: 0x000CCB80
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UAudioEndpointSettingsBase> EndpointSettingsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UEndpointSubmix.__PropertyOffset_EndpointSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UEndpointSubmix.__PropertyOffset_EndpointSettingsClass) = value;
			}
		}

		// Token: 0x17002212 RID: 8722
		// (get) Token: 0x06009059 RID: 36953 RVA: 0x000CE995 File Offset: 0x000CCB95
		// (set) Token: 0x0600905A RID: 36954 RVA: 0x000CE9A9 File Offset: 0x000CCBA9
		[Nullable(2)]
		public unsafe UAudioEndpointSettingsBase EndpointSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAudioEndpointSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + UEndpointSubmix.__PropertyOffset_EndpointSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UEndpointSubmix.__PropertyOffset_EndpointSettings, value);
			}
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x000CE9BE File Offset: 0x000CCBBE
		static UEndpointSubmix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.EndpointSubmix");
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x000CE9CC File Offset: 0x000CCBCC
		protected UEndpointSubmix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004B54 RID: 19284
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.EndpointSubmix";

		// Token: 0x04004B55 RID: 19285
		private static IntPtr _ClassPtr;

		// Token: 0x04004B56 RID: 19286
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004B57 RID: 19287
		internal static int __PropertyOffset_EndpointType;

		// Token: 0x04004B58 RID: 19288
		internal static int __PropertyOffset_EndpointSettingsClass;

		// Token: 0x04004B59 RID: 19289
		internal static int __PropertyOffset_EndpointSettings;
	}
}
