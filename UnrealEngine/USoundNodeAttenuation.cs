using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113B RID: 4411
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeAttenuation")]
	[UnrealStructLayout(1072, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1072)]
	public class USoundNodeAttenuation : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010222 RID: 66082 RVA: 0x0017C511 File Offset: 0x0017A711
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeAttenuation._ClassPtr;
		}

		// Token: 0x06010223 RID: 66083 RVA: 0x0017C520 File Offset: 0x0017A720
		public USoundNodeAttenuation() : this(BuiltinUtils.AllocNativeUObject(USoundNodeAttenuation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010224 RID: 66084 RVA: 0x0017C548 File Offset: 0x0017A748
		public USoundNodeAttenuation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeAttenuation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F2A RID: 16170
		// (get) Token: 0x06010225 RID: 66085 RVA: 0x0017C57B File Offset: 0x0017A77B
		// (set) Token: 0x06010226 RID: 66086 RVA: 0x0017C58F File Offset: 0x0017A78F
		[Nullable(2)]
		public unsafe USoundAttenuation AttenuationSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeAttenuation.__PropertyOffset_AttenuationSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + USoundNodeAttenuation.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x17003F2B RID: 16171
		// (get) Token: 0x06010227 RID: 66087 RVA: 0x0017C5A4 File Offset: 0x0017A7A4
		// (set) Token: 0x06010228 RID: 66088 RVA: 0x0017C5DD File Offset: 0x0017A7DD
		public FSoundAttenuationSettings AttenuationOverrides
		{
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationSettings result;
				if ((result = this._AttenuationOverrides) == null)
				{
					result = (this._AttenuationOverrides = new FSoundAttenuationSettings(base.NativePtr + (IntPtr)USoundNodeAttenuation.__PropertyOffset_AttenuationOverrides, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeAttenuation.__PropertyOffset_AttenuationOverrides, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F2C RID: 16172
		// (get) Token: 0x06010229 RID: 66089 RVA: 0x0017C5FE File Offset: 0x0017A7FE
		// (set) Token: 0x0601022A RID: 66090 RVA: 0x0017C617 File Offset: 0x0017A817
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeAttenuation.__PropertyOffset_bOverrideAttenuation) & USoundNodeAttenuation.__PropertyMask_bOverrideAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeAttenuation.__PropertyOffset_bOverrideAttenuation) = ((*(base.NativePtr + (IntPtr)USoundNodeAttenuation.__PropertyOffset_bOverrideAttenuation) & ~USoundNodeAttenuation.__PropertyMask_bOverrideAttenuation) | (value ? USoundNodeAttenuation.__PropertyMask_bOverrideAttenuation : 0));
			}
		}

		// Token: 0x0601022B RID: 66091 RVA: 0x0017C647 File Offset: 0x0017A847
		static USoundNodeAttenuation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeAttenuation");
		}

		// Token: 0x0601022C RID: 66092 RVA: 0x0017C655 File Offset: 0x0017A855
		protected USoundNodeAttenuation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AD4 RID: 35540
		public new const string __ObjectPath = "/Script/Engine.SoundNodeAttenuation";

		// Token: 0x04008AD5 RID: 35541
		private static IntPtr _ClassPtr;

		// Token: 0x04008AD6 RID: 35542
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AD7 RID: 35543
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04008AD8 RID: 35544
		internal static int __PropertyOffset_AttenuationOverrides;

		// Token: 0x04008AD9 RID: 35545
		[Nullable(2)]
		private FSoundAttenuationSettings _AttenuationOverrides;

		// Token: 0x04008ADA RID: 35546
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x04008ADB RID: 35547
		internal static byte __PropertyMask_bOverrideAttenuation;
	}
}
