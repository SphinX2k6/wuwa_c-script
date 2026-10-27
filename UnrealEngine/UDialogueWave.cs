using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BF RID: 2495
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DialogueWave")]
	[UnrealStructLayout(136, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 136)]
	public class UDialogueWave : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008CDA RID: 36058 RVA: 0x000C9939 File Offset: 0x000C7B39
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDialogueWave._ClassPtr;
		}

		// Token: 0x06008CDB RID: 36059 RVA: 0x000C9948 File Offset: 0x000C7B48
		public UDialogueWave() : this(BuiltinUtils.AllocNativeUObject(UDialogueWave.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008CDC RID: 36060 RVA: 0x000C9970 File Offset: 0x000C7B70
		public UDialogueWave(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDialogueWave.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700211F RID: 8479
		// (get) Token: 0x06008CDD RID: 36061 RVA: 0x000C99A3 File Offset: 0x000C7BA3
		// (set) Token: 0x06008CDE RID: 36062 RVA: 0x000C99BC File Offset: 0x000C7BBC
		public unsafe bool bMature
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bMature) & UDialogueWave.__PropertyMask_bMature) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bMature) = ((*(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bMature) & ~UDialogueWave.__PropertyMask_bMature) | (value ? UDialogueWave.__PropertyMask_bMature : 0));
			}
		}

		// Token: 0x17002120 RID: 8480
		// (get) Token: 0x06008CDF RID: 36063 RVA: 0x000C99EC File Offset: 0x000C7BEC
		// (set) Token: 0x06008CE0 RID: 36064 RVA: 0x000C9A05 File Offset: 0x000C7C05
		public unsafe bool bOverride_SubtitleOverride
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bOverride_SubtitleOverride) & UDialogueWave.__PropertyMask_bOverride_SubtitleOverride) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bOverride_SubtitleOverride) = ((*(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_bOverride_SubtitleOverride) & ~UDialogueWave.__PropertyMask_bOverride_SubtitleOverride) | (value ? UDialogueWave.__PropertyMask_bOverride_SubtitleOverride : 0));
			}
		}

		// Token: 0x17002121 RID: 8481
		// (get) Token: 0x06008CE1 RID: 36065 RVA: 0x000C9A35 File Offset: 0x000C7C35
		// (set) Token: 0x06008CE2 RID: 36066 RVA: 0x000C9A49 File Offset: 0x000C7C49
		public unsafe string SpokenText
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDialogueWave.__PropertyOffset_SpokenText)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDialogueWave.__PropertyOffset_SpokenText)), value);
			}
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x06008CE3 RID: 36067 RVA: 0x000C9A5E File Offset: 0x000C7C5E
		// (set) Token: 0x06008CE4 RID: 36068 RVA: 0x000C9A72 File Offset: 0x000C7C72
		public unsafe string SubtitleOverride
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UDialogueWave.__PropertyOffset_SubtitleOverride)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UDialogueWave.__PropertyOffset_SubtitleOverride)), value);
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x06008CE5 RID: 36069 RVA: 0x000C9A88 File Offset: 0x000C7C88
		// (set) Token: 0x06008CE6 RID: 36070 RVA: 0x000C9AC1 File Offset: 0x000C7CC1
		public TArray<FDialogueContextMapping> ContextMappings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FDialogueContextMapping> result;
				if ((result = this._ContextMappings) == null)
				{
					result = (this._ContextMappings = new TArray<FDialogueContextMapping>(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_ContextMappings, this));
				}
				return result;
			}
			set
			{
				this.ContextMappings.CopyAssign(value);
			}
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x06008CE7 RID: 36071 RVA: 0x000C9ACF File Offset: 0x000C7CCF
		// (set) Token: 0x06008CE8 RID: 36072 RVA: 0x000C9AE3 File Offset: 0x000C7CE3
		public unsafe FGuid LocalizationGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_LocalizationGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDialogueWave.__PropertyOffset_LocalizationGUID) = value;
			}
		}

		// Token: 0x06008CE9 RID: 36073 RVA: 0x000C9AF8 File Offset: 0x000C7CF8
		static UDialogueWave()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DialogueWave");
		}

		// Token: 0x06008CEA RID: 36074 RVA: 0x000C9B06 File Offset: 0x000C7D06
		protected UDialogueWave(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040042E2 RID: 17122
		public new const string __ObjectPath = "/Script/Engine.DialogueWave";

		// Token: 0x040042E3 RID: 17123
		private static IntPtr _ClassPtr;

		// Token: 0x040042E4 RID: 17124
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040042E5 RID: 17125
		internal static int __PropertyOffset_bMature;

		// Token: 0x040042E6 RID: 17126
		internal static byte __PropertyMask_bMature;

		// Token: 0x040042E7 RID: 17127
		internal static int __PropertyOffset_bOverride_SubtitleOverride;

		// Token: 0x040042E8 RID: 17128
		internal static byte __PropertyMask_bOverride_SubtitleOverride;

		// Token: 0x040042E9 RID: 17129
		internal static int __PropertyOffset_SpokenText;

		// Token: 0x040042EA RID: 17130
		internal static int __PropertyOffset_SubtitleOverride;

		// Token: 0x040042EB RID: 17131
		internal static int __PropertyOffset_ContextMappings;

		// Token: 0x040042EC RID: 17132
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FDialogueContextMapping> _ContextMappings;

		// Token: 0x040042ED RID: 17133
		internal static int __PropertyOffset_LocalizationGUID;
	}
}
