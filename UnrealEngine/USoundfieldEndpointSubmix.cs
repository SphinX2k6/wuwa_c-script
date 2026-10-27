using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001131 RID: 4401
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundfieldEndpointSubmix")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class USoundfieldEndpointSubmix : USoundSubmixBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060101A3 RID: 65955 RVA: 0x0017B95D File Offset: 0x00179B5D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundfieldEndpointSubmix._ClassPtr;
		}

		// Token: 0x060101A4 RID: 65956 RVA: 0x0017B96C File Offset: 0x00179B6C
		public USoundfieldEndpointSubmix() : this(BuiltinUtils.AllocNativeUObject(USoundfieldEndpointSubmix.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060101A5 RID: 65957 RVA: 0x0017B994 File Offset: 0x00179B94
		[NullableContext(1)]
		public USoundfieldEndpointSubmix(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundfieldEndpointSubmix.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F08 RID: 16136
		// (get) Token: 0x060101A6 RID: 65958 RVA: 0x0017B9C7 File Offset: 0x00179BC7
		// (set) Token: 0x060101A7 RID: 65959 RVA: 0x0017B9DB File Offset: 0x00179BDB
		public unsafe FName SoundfieldEndpointType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_SoundfieldEndpointType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_SoundfieldEndpointType) = value;
			}
		}

		// Token: 0x17003F09 RID: 16137
		// (get) Token: 0x060101A8 RID: 65960 RVA: 0x0017B9F0 File Offset: 0x00179BF0
		// (set) Token: 0x060101A9 RID: 65961 RVA: 0x0017BA04 File Offset: 0x00179C04
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
				return *(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_EndpointSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_EndpointSettingsClass) = value;
			}
		}

		// Token: 0x17003F0A RID: 16138
		// (get) Token: 0x060101AA RID: 65962 RVA: 0x0017BA19 File Offset: 0x00179C19
		// (set) Token: 0x060101AB RID: 65963 RVA: 0x0017BA2D File Offset: 0x00179C2D
		public unsafe USoundfieldEndpointSettingsBase EndpointSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundfieldEndpointSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEndpointSubmix.__PropertyOffset_EndpointSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEndpointSubmix.__PropertyOffset_EndpointSettings, value);
			}
		}

		// Token: 0x17003F0B RID: 16139
		// (get) Token: 0x060101AC RID: 65964 RVA: 0x0017BA42 File Offset: 0x00179C42
		// (set) Token: 0x060101AD RID: 65965 RVA: 0x0017BA56 File Offset: 0x00179C56
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<USoundfieldEncodingSettingsBase> EncodingSettingsClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_EncodingSettingsClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_EncodingSettingsClass) = value;
			}
		}

		// Token: 0x17003F0C RID: 16140
		// (get) Token: 0x060101AE RID: 65966 RVA: 0x0017BA6B File Offset: 0x00179C6B
		// (set) Token: 0x060101AF RID: 65967 RVA: 0x0017BA7F File Offset: 0x00179C7F
		public unsafe USoundfieldEncodingSettingsBase EncodingSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundfieldEncodingSettingsBase>(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEndpointSubmix.__PropertyOffset_EncodingSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundfieldEndpointSubmix.__PropertyOffset_EncodingSettings, value);
			}
		}

		// Token: 0x17003F0D RID: 16141
		// (get) Token: 0x060101B0 RID: 65968 RVA: 0x0017BA94 File Offset: 0x00179C94
		// (set) Token: 0x060101B1 RID: 65969 RVA: 0x0017BACD File Offset: 0x00179CCD
		[Nullable(1)]
		public TArray<USoundfieldEffectBase> SoundfieldEffectChain
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<USoundfieldEffectBase> result;
				if ((result = this._SoundfieldEffectChain) == null)
				{
					result = (this._SoundfieldEffectChain = new TArray<USoundfieldEffectBase>(base.NativePtr + (IntPtr)USoundfieldEndpointSubmix.__PropertyOffset_SoundfieldEffectChain, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.SoundfieldEffectChain.CopyAssign(value);
			}
		}

		// Token: 0x060101B2 RID: 65970 RVA: 0x0017BADB File Offset: 0x00179CDB
		static USoundfieldEndpointSubmix()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundfieldEndpointSubmix");
		}

		// Token: 0x060101B3 RID: 65971 RVA: 0x0017BAE9 File Offset: 0x00179CE9
		protected USoundfieldEndpointSubmix(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008A8C RID: 35468
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundfieldEndpointSubmix";

		// Token: 0x04008A8D RID: 35469
		private static IntPtr _ClassPtr;

		// Token: 0x04008A8E RID: 35470
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008A8F RID: 35471
		internal static int __PropertyOffset_SoundfieldEndpointType;

		// Token: 0x04008A90 RID: 35472
		internal static int __PropertyOffset_EndpointSettingsClass;

		// Token: 0x04008A91 RID: 35473
		internal static int __PropertyOffset_EndpointSettings;

		// Token: 0x04008A92 RID: 35474
		internal static int __PropertyOffset_EncodingSettingsClass;

		// Token: 0x04008A93 RID: 35475
		internal static int __PropertyOffset_EncodingSettings;

		// Token: 0x04008A94 RID: 35476
		internal static int __PropertyOffset_SoundfieldEffectChain;

		// Token: 0x04008A95 RID: 35477
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundfieldEffectBase> _SoundfieldEffectChain;
	}
}
