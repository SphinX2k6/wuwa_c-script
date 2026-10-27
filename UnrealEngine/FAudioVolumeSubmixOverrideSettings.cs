using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000871 RID: 2161
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioVolumeSubmixOverrideSettings")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAudioVolumeSubmixOverrideSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007576 RID: 30070 RVA: 0x000A86F3 File Offset: 0x000A68F3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioVolumeSubmixOverrideSettings._ScriptStructPtr != 0) ? FAudioVolumeSubmixOverrideSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioVolumeSubmixOverrideSettings", ref FAudioVolumeSubmixOverrideSettings._ScriptStructPtr);
		}

		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06007577 RID: 30071 RVA: 0x000A8717 File Offset: 0x000A6917
		// (set) Token: 0x06007578 RID: 30072 RVA: 0x000A872B File Offset: 0x000A692B
		[Nullable(2)]
		public unsafe USoundSubmix Submix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + FAudioVolumeSubmixOverrideSettings.__PropertyOffset_Submix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAudioVolumeSubmixOverrideSettings.__PropertyOffset_Submix, value);
			}
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06007579 RID: 30073 RVA: 0x000A8740 File Offset: 0x000A6940
		// (set) Token: 0x0600757A RID: 30074 RVA: 0x000A8783 File Offset: 0x000A6983
		public TArray<USoundEffectSubmixPreset> SubmixEffectChain
		{
			get
			{
				base.FastCheckIsValid();
				TArray<USoundEffectSubmixPreset> result;
				if ((result = this._SubmixEffectChain) == null)
				{
					result = (this._SubmixEffectChain = new TArray<USoundEffectSubmixPreset>(base.NativePtr + (IntPtr)FAudioVolumeSubmixOverrideSettings.__PropertyOffset_SubmixEffectChain, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubmixEffectChain.CopyAssign(value);
			}
		}

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x0600757B RID: 30075 RVA: 0x000A8791 File Offset: 0x000A6991
		// (set) Token: 0x0600757C RID: 30076 RVA: 0x000A87A1 File Offset: 0x000A69A1
		public unsafe float CrossfadeTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAudioVolumeSubmixOverrideSettings.__PropertyOffset_CrossfadeTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioVolumeSubmixOverrideSettings.__PropertyOffset_CrossfadeTime) = value;
			}
		}

		// Token: 0x0600757D RID: 30077 RVA: 0x000A87B2 File Offset: 0x000A69B2
		public FAudioVolumeSubmixOverrideSettings()
		{
		}

		// Token: 0x0600757E RID: 30078 RVA: 0x000A87BA File Offset: 0x000A69BA
		public FAudioVolumeSubmixOverrideSettings(USoundSubmix Submix, TArray<USoundEffectSubmixPreset> SubmixEffectChain, float CrossfadeTime)
		{
			this.Submix = Submix;
			this.SubmixEffectChain = SubmixEffectChain;
			this.CrossfadeTime = CrossfadeTime;
		}

		// Token: 0x0600757F RID: 30079 RVA: 0x000A87D7 File Offset: 0x000A69D7
		protected override IntPtr GetUStructPtr()
		{
			return FAudioVolumeSubmixOverrideSettings.StaticStruct();
		}

		// Token: 0x06007580 RID: 30080 RVA: 0x000A87E3 File Offset: 0x000A69E3
		[NullableContext(2)]
		public FAudioVolumeSubmixOverrideSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007581 RID: 30081 RVA: 0x000A87ED File Offset: 0x000A69ED
		public FAudioVolumeSubmixOverrideSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007582 RID: 30082 RVA: 0x000A87F8 File Offset: 0x000A69F8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioVolumeSubmixOverrideSettings(Pointer, false, true);
		}

		// Token: 0x06007583 RID: 30083 RVA: 0x000A8802 File Offset: 0x000A6A02
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioVolumeSubmixOverrideSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003881 RID: 14465
		public const string __ObjectPath = "/Script/Engine.AudioVolumeSubmixOverrideSettings";

		// Token: 0x04003882 RID: 14466
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003883 RID: 14467
		internal static int __PropertyOffset_Submix;

		// Token: 0x04003884 RID: 14468
		internal static int __PropertyOffset_SubmixEffectChain;

		// Token: 0x04003885 RID: 14469
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<USoundEffectSubmixPreset> _SubmixEffectChain;

		// Token: 0x04003886 RID: 14470
		internal static int __PropertyOffset_CrossfadeTime;
	}
}
