using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004E2 RID: 1250
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSeqPostParameter")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 80)]
	public class UKuroSeqPostParameter : UDataAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060075FF RID: 30207 RVA: 0x000AC6FB File Offset: 0x000AA8FB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSeqPostParameter._ClassPtr;
		}

		// Token: 0x06007600 RID: 30208 RVA: 0x000AC708 File Offset: 0x000AA908
		public UKuroSeqPostParameter() : this(BuiltinUtils.AllocNativeUObject(UKuroSeqPostParameter.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007601 RID: 30209 RVA: 0x000AC730 File Offset: 0x000AA930
		[NullableContext(1)]
		public UKuroSeqPostParameter(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSeqPostParameter.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016BE RID: 5822
		// (get) Token: 0x06007602 RID: 30210 RVA: 0x000AC763 File Offset: 0x000AA963
		// (set) Token: 0x06007603 RID: 30211 RVA: 0x000AC773 File Offset: 0x000AA973
		public unsafe float CharacterBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_CharacterBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_CharacterBloomIntensity) = value;
			}
		}

		// Token: 0x170016BF RID: 5823
		// (get) Token: 0x06007604 RID: 30212 RVA: 0x000AC784 File Offset: 0x000AA984
		// (set) Token: 0x06007605 RID: 30213 RVA: 0x000AC794 File Offset: 0x000AA994
		public unsafe float CharacterBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_CharacterBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_CharacterBloomThreshold) = value;
			}
		}

		// Token: 0x170016C0 RID: 5824
		// (get) Token: 0x06007606 RID: 30214 RVA: 0x000AC7A5 File Offset: 0x000AA9A5
		// (set) Token: 0x06007607 RID: 30215 RVA: 0x000AC7B5 File Offset: 0x000AA9B5
		public unsafe bool EnableSeqBloom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_EnableSeqBloom) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSeqPostParameter.__PropertyOffset_EnableSeqBloom) = (value ? 1 : 0);
			}
		}

		// Token: 0x06007608 RID: 30216 RVA: 0x000AC7C6 File Offset: 0x000AA9C6
		static UKuroSeqPostParameter()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSeqPostParameter");
		}

		// Token: 0x06007609 RID: 30217 RVA: 0x000AC7D4 File Offset: 0x000AA9D4
		protected UKuroSeqPostParameter(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040031C4 RID: 12740
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSeqPostParameter";

		// Token: 0x040031C5 RID: 12741
		private static IntPtr _ClassPtr;

		// Token: 0x040031C6 RID: 12742
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040031C7 RID: 12743
		internal static int __PropertyOffset_CharacterBloomIntensity;

		// Token: 0x040031C8 RID: 12744
		internal static int __PropertyOffset_CharacterBloomThreshold;

		// Token: 0x040031C9 RID: 12745
		internal static int __PropertyOffset_EnableSeqBloom;
	}
}
