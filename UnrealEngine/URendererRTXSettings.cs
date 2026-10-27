using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200107F RID: 4223
	[UnrealObjectPath("/Script/Engine.RendererRTXSettings")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class URendererRTXSettings : UDeveloperSettings, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600F03A RID: 61498 RVA: 0x001641A0 File Offset: 0x001623A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URendererRTXSettings._ClassPtr;
		}

		// Token: 0x0600F03B RID: 61499 RVA: 0x001641AC File Offset: 0x001623AC
		public URendererRTXSettings() : this(BuiltinUtils.AllocNativeUObject(URendererRTXSettings.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600F03C RID: 61500 RVA: 0x001641D4 File Offset: 0x001623D4
		[NullableContext(1)]
		public URendererRTXSettings(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URendererRTXSettings.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003A26 RID: 14886
		// (get) Token: 0x0600F03D RID: 61501 RVA: 0x00164207 File Offset: 0x00162407
		// (set) Token: 0x0600F03E RID: 61502 RVA: 0x00164217 File Offset: 0x00162417
		public unsafe bool bStreamSkeletalMeshLODs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URendererRTXSettings.__PropertyOffset_bStreamSkeletalMeshLODs) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)URendererRTXSettings.__PropertyOffset_bStreamSkeletalMeshLODs) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600F03F RID: 61503 RVA: 0x00164228 File Offset: 0x00162428
		static URendererRTXSettings()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.RendererRTXSettings");
		}

		// Token: 0x0600F040 RID: 61504 RVA: 0x00164236 File Offset: 0x00162436
		protected URendererRTXSettings(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081F3 RID: 33267
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.RendererRTXSettings";

		// Token: 0x040081F4 RID: 33268
		private static IntPtr _ClassPtr;

		// Token: 0x040081F5 RID: 33269
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081F6 RID: 33270
		internal static int __PropertyOffset_bStreamSkeletalMeshLODs;
	}
}
