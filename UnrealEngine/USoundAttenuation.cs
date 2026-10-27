using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001122 RID: 4386
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundAttenuation")]
	[UnrealStructLayout(1016, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1016)]
	public class USoundAttenuation : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601003C RID: 65596 RVA: 0x00179410 File Offset: 0x00177610
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundAttenuation._ClassPtr;
		}

		// Token: 0x0601003D RID: 65597 RVA: 0x0017941C File Offset: 0x0017761C
		public USoundAttenuation() : this(BuiltinUtils.AllocNativeUObject(USoundAttenuation.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601003E RID: 65598 RVA: 0x00179444 File Offset: 0x00177644
		public USoundAttenuation(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundAttenuation.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E81 RID: 16001
		// (get) Token: 0x0601003F RID: 65599 RVA: 0x00179478 File Offset: 0x00177678
		// (set) Token: 0x06010040 RID: 65600 RVA: 0x001794B1 File Offset: 0x001776B1
		public FSoundAttenuationSettings Attenuation
		{
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationSettings result;
				if ((result = this._Attenuation) == null)
				{
					result = (this._Attenuation = new FSoundAttenuationSettings(base.NativePtr + (IntPtr)USoundAttenuation.__PropertyOffset_Attenuation, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationSettings.StaticStruct(), base.NativePtr + (IntPtr)USoundAttenuation.__PropertyOffset_Attenuation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06010041 RID: 65601 RVA: 0x001794D2 File Offset: 0x001776D2
		static USoundAttenuation()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundAttenuation");
		}

		// Token: 0x06010042 RID: 65602 RVA: 0x001794E0 File Offset: 0x001776E0
		protected USoundAttenuation(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040089A4 RID: 35236
		public new const string __ObjectPath = "/Script/Engine.SoundAttenuation";

		// Token: 0x040089A5 RID: 35237
		private static IntPtr _ClassPtr;

		// Token: 0x040089A6 RID: 35238
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040089A7 RID: 35239
		internal static int __PropertyOffset_Attenuation;

		// Token: 0x040089A8 RID: 35240
		[Nullable(2)]
		private FSoundAttenuationSettings _Attenuation;
	}
}
