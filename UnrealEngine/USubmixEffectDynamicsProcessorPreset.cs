using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037E RID: 894
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset")]
	[UnrealStructLayout(312, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 312)]
	public class USubmixEffectDynamicsProcessorPreset : USoundEffectSubmixPreset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06003112 RID: 12562 RVA: 0x0004BE5C File Offset: 0x0004A05C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USubmixEffectDynamicsProcessorPreset._ClassPtr;
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0004BE68 File Offset: 0x0004A068
		public USubmixEffectDynamicsProcessorPreset() : this(BuiltinUtils.AllocNativeUObject(USubmixEffectDynamicsProcessorPreset.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0004BE90 File Offset: 0x0004A090
		public USubmixEffectDynamicsProcessorPreset(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USubmixEffectDynamicsProcessorPreset.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06003115 RID: 12565 RVA: 0x0004BEC4 File Offset: 0x0004A0C4
		// (set) Token: 0x06003116 RID: 12566 RVA: 0x0004BEFD File Offset: 0x0004A0FD
		public FSubmixEffectDynamicsProcessorSettings Settings
		{
			get
			{
				base.FastCheckIsValid();
				FSubmixEffectDynamicsProcessorSettings result;
				if ((result = this._Settings) == null)
				{
					result = (this._Settings = new FSubmixEffectDynamicsProcessorSettings(base.NativePtr + (IntPtr)USubmixEffectDynamicsProcessorPreset.__PropertyOffset_Settings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubmixEffectDynamicsProcessorSettings.StaticStruct(), base.NativePtr + (IntPtr)USubmixEffectDynamicsProcessorPreset.__PropertyOffset_Settings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x0004BF1E File Offset: 0x0004A11E
		[NullableContext(2)]
		public void SetSettings(in FSubmixEffectDynamicsProcessorSettings Settings)
		{
			USubmixEffectDynamicsProcessorPreset.__SetSettings_Internal(base.NativePtr, (Settings ?? new FSubmixEffectDynamicsProcessorSettings()).NativePtr);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x0004BF3B File Offset: 0x0004A13B
		[NullableContext(2)]
		public void SetExternalSubmix(USoundSubmix Submix)
		{
			USubmixEffectDynamicsProcessorPreset.__SetExternalSubmix_Internal(base.NativePtr, (Submix != null) ? Submix.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06003119 RID: 12569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSettings_Internal(IntPtr @this, IntPtr Settings);

		// Token: 0x0600311A RID: 12570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetExternalSubmix_Internal(IntPtr @this, IntPtr Submix);

		// Token: 0x0600311B RID: 12571 RVA: 0x0004BF58 File Offset: 0x0004A158
		static USubmixEffectDynamicsProcessorPreset()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset");
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x0004BF66 File Offset: 0x0004A166
		protected USubmixEffectDynamicsProcessorPreset(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001554 RID: 5460
		public new const string __ObjectPath = "/Script/AudioMixer.SubmixEffectDynamicsProcessorPreset";

		// Token: 0x04001555 RID: 5461
		private static IntPtr _ClassPtr;

		// Token: 0x04001556 RID: 5462
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001557 RID: 5463
		internal static int __PropertyOffset_Settings;

		// Token: 0x04001558 RID: 5464
		[Nullable(2)]
		private FSubmixEffectDynamicsProcessorSettings _Settings;
	}
}
