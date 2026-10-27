using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200107E RID: 4222
	[UnrealObjectPath("/Script/Engine.RendererOverrideSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class URendererOverrideSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F031 RID: 61489 RVA: 0x0016408E File Offset: 0x0016228E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URendererOverrideSettings._ClassPtr;
		}

		// Token: 0x0600F032 RID: 61490 RVA: 0x0016409C File Offset: 0x0016229C
		public URendererOverrideSettings() : this(BuiltinUtils.AllocNativeUObject(URendererOverrideSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F033 RID: 61491 RVA: 0x001640C4 File Offset: 0x001622C4
		[NullableContext(1)]
		public URendererOverrideSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URendererOverrideSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x0600F034 RID: 61492 RVA: 0x001640F7 File Offset: 0x001622F7
		// (set) Token: 0x0600F035 RID: 61493 RVA: 0x00164110 File Offset: 0x00162310
		public unsafe bool bSupportAllShaderPermutations
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bSupportAllShaderPermutations) & URendererOverrideSettings.__PropertyMask_bSupportAllShaderPermutations) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bSupportAllShaderPermutations) = ((*(base.NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bSupportAllShaderPermutations) & ~URendererOverrideSettings.__PropertyMask_bSupportAllShaderPermutations) | (value ? URendererOverrideSettings.__PropertyMask_bSupportAllShaderPermutations : 0));
			}
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x0600F036 RID: 61494 RVA: 0x00164140 File Offset: 0x00162340
		// (set) Token: 0x0600F037 RID: 61495 RVA: 0x00164159 File Offset: 0x00162359
		public unsafe bool bForceRecomputeTangents
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bForceRecomputeTangents) & URendererOverrideSettings.__PropertyMask_bForceRecomputeTangents) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bForceRecomputeTangents) = ((*(base.NativePtr + (IntPtr)URendererOverrideSettings.__PropertyOffset_bForceRecomputeTangents) & ~URendererOverrideSettings.__PropertyMask_bForceRecomputeTangents) | (value ? URendererOverrideSettings.__PropertyMask_bForceRecomputeTangents : 0));
			}
		}

		// Token: 0x0600F038 RID: 61496 RVA: 0x00164189 File Offset: 0x00162389
		static URendererOverrideSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RendererOverrideSettings");
		}

		// Token: 0x0600F039 RID: 61497 RVA: 0x00164197 File Offset: 0x00162397
		protected URendererOverrideSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081EC RID: 33260
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RendererOverrideSettings";

		// Token: 0x040081ED RID: 33261
		private static IntPtr _ClassPtr;

		// Token: 0x040081EE RID: 33262
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081EF RID: 33263
		internal static int __PropertyOffset_bSupportAllShaderPermutations;

		// Token: 0x040081F0 RID: 33264
		internal static byte __PropertyMask_bSupportAllShaderPermutations;

		// Token: 0x040081F1 RID: 33265
		internal static int __PropertyOffset_bForceRecomputeTangents;

		// Token: 0x040081F2 RID: 33266
		internal static byte __PropertyMask_bForceRecomputeTangents;
	}
}
