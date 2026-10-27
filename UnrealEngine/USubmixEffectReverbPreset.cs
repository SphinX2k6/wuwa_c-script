using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000381 RID: 897
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectReverbPreset")]
	[UnrealStructLayout(280, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 280)]
	public class USubmixEffectReverbPreset : USoundEffectSubmixPreset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003159 RID: 12633 RVA: 0x0004C4F9 File Offset: 0x0004A6F9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubmixEffectReverbPreset._ClassPtr;
		}

		// Token: 0x0600315A RID: 12634 RVA: 0x0004C508 File Offset: 0x0004A708
		public USubmixEffectReverbPreset() : this(BuiltinUtils.AllocNativeUObject(USubmixEffectReverbPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600315B RID: 12635 RVA: 0x0004C530 File Offset: 0x0004A730
		public USubmixEffectReverbPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubmixEffectReverbPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x0004C564 File Offset: 0x0004A764
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x0004C59D File Offset: 0x0004A79D
		public FSubmixEffectReverbSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSubmixEffectReverbSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSubmixEffectReverbSettings(base.NativePtr + (IntPtr)USubmixEffectReverbPreset.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubmixEffectReverbSettings.StaticStruct(), base.NativePtr + (IntPtr)USubmixEffectReverbPreset.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600315E RID: 12638 RVA: 0x0004C5BE File Offset: 0x0004A7BE
		[NullableContext(2)]
		public void SetSettingsWithReverbEffect(UReverbEffect InReverbEffect, float WetLevel, float DryLevel = 0f)
		{
			USubmixEffectReverbPreset.__SetSettingsWithReverbEffect_Internal(base.NativePtr, (InReverbEffect != null) ? InReverbEffect.NativePtr : IntPtr.Zero, WetLevel, DryLevel);
		}

		// Token: 0x0600315F RID: 12639 RVA: 0x0004C5DD File Offset: 0x0004A7DD
		[NullableContext(2)]
		public void SetSettings(in FSubmixEffectReverbSettings InSettings)
		{
			USubmixEffectReverbPreset.__SetSettings_Internal(base.NativePtr, (InSettings ?? new FSubmixEffectReverbSettings()).NativePtr);
		}

		// Token: 0x06003160 RID: 12640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSettingsWithReverbEffect_Internal(IntPtr @this, IntPtr InReverbEffect, float WetLevel, float DryLevel);

		// Token: 0x06003161 RID: 12641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSettings_Internal(IntPtr @this, IntPtr InSettings);

		// Token: 0x06003162 RID: 12642 RVA: 0x0004C5FA File Offset: 0x0004A7FA
		static USubmixEffectReverbPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.SubmixEffectReverbPreset");
		}

		// Token: 0x06003163 RID: 12643 RVA: 0x0004C608 File Offset: 0x0004A808
		protected USubmixEffectReverbPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001579 RID: 5497
		public new const string __ObjectPath = "/Script/AudioMixer.SubmixEffectReverbPreset";

		// Token: 0x0400157A RID: 5498
		private static IntPtr _ClassPtr;

		// Token: 0x0400157B RID: 5499
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400157C RID: 5500
		internal static int __PropertyOffset_Settings;

		// Token: 0x0400157D RID: 5501
		[Nullable(2)]
		private FSubmixEffectReverbSettings _Settings;
	}
}
