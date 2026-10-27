using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000383 RID: 899
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectSubmixEQPreset")]
	[UnrealStructLayout(184, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 184)]
	public class USubmixEffectSubmixEQPreset : USoundEffectSubmixPreset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600318C RID: 12684 RVA: 0x0004C914 File Offset: 0x0004AB14
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubmixEffectSubmixEQPreset._ClassPtr;
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x0004C920 File Offset: 0x0004AB20
		public USubmixEffectSubmixEQPreset() : this(BuiltinUtils.AllocNativeUObject(USubmixEffectSubmixEQPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x0004C948 File Offset: 0x0004AB48
		public USubmixEffectSubmixEQPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubmixEffectSubmixEQPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x0004C97C File Offset: 0x0004AB7C
		// (set) Token: 0x06003190 RID: 12688 RVA: 0x0004C9B5 File Offset: 0x0004ABB5
		public FSubmixEffectSubmixEQSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSubmixEffectSubmixEQSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSubmixEffectSubmixEQSettings(base.NativePtr + (IntPtr)USubmixEffectSubmixEQPreset.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubmixEffectSubmixEQSettings.StaticStruct(), base.NativePtr + (IntPtr)USubmixEffectSubmixEQPreset.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003191 RID: 12689 RVA: 0x0004C9D6 File Offset: 0x0004ABD6
		[NullableContext(2)]
		public void SetSettings(in FSubmixEffectSubmixEQSettings InSettings)
		{
			USubmixEffectSubmixEQPreset.__SetSettings_Internal(base.NativePtr, (InSettings ?? new FSubmixEffectSubmixEQSettings()).NativePtr);
		}

		// Token: 0x06003192 RID: 12690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x06003193 RID: 12691 RVA: 0x0004C9F3 File Offset: 0x0004ABF3
		static USubmixEffectSubmixEQPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.SubmixEffectSubmixEQPreset");
		}

		// Token: 0x06003194 RID: 12692 RVA: 0x0004CA01 File Offset: 0x0004AC01
		protected USubmixEffectSubmixEQPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001590 RID: 5520
		public new const string __ObjectPath = "/Script/AudioMixer.SubmixEffectSubmixEQPreset";

		// Token: 0x04001591 RID: 5521
		private static IntPtr _ClassPtr;

		// Token: 0x04001592 RID: 5522
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001593 RID: 5523
		internal static int __PropertyOffset_Settings;

		// Token: 0x04001594 RID: 5524
		[Nullable(2)]
		private FSubmixEffectSubmixEQSettings _Settings;
	}
}
