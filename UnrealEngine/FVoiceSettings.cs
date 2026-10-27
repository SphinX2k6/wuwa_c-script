using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200123B RID: 4667
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.VoiceSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FVoiceSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011261 RID: 70241 RVA: 0x00192D12 File Offset: 0x00190F12
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVoiceSettings._ScriptStructPtr != 0) ? FVoiceSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.VoiceSettings", ref FVoiceSettings._ScriptStructPtr);
		}

		// Token: 0x170042E3 RID: 17123
		// (get) Token: 0x06011262 RID: 70242 RVA: 0x00192D36 File Offset: 0x00190F36
		// (set) Token: 0x06011263 RID: 70243 RVA: 0x00192D4A File Offset: 0x00190F4A
		public unsafe USceneComponent ComponentToAttachTo
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USceneComponent>(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_ComponentToAttachTo);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_ComponentToAttachTo, value);
			}
		}

		// Token: 0x170042E4 RID: 17124
		// (get) Token: 0x06011264 RID: 70244 RVA: 0x00192D5F File Offset: 0x00190F5F
		// (set) Token: 0x06011265 RID: 70245 RVA: 0x00192D73 File Offset: 0x00190F73
		public unsafe USoundAttenuation AttenuationSettings
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_AttenuationSettings);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x170042E5 RID: 17125
		// (get) Token: 0x06011266 RID: 70246 RVA: 0x00192D88 File Offset: 0x00190F88
		// (set) Token: 0x06011267 RID: 70247 RVA: 0x00192D9C File Offset: 0x00190F9C
		public unsafe USoundEffectSourcePresetChain SourceEffectChain
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundEffectSourcePresetChain>(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_SourceEffectChain);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVoiceSettings.__PropertyOffset_SourceEffectChain, value);
			}
		}

		// Token: 0x06011268 RID: 70248 RVA: 0x00192DB1 File Offset: 0x00190FB1
		public FVoiceSettings()
		{
		}

		// Token: 0x06011269 RID: 70249 RVA: 0x00192DB9 File Offset: 0x00190FB9
		[NullableContext(1)]
		public FVoiceSettings(USceneComponent ComponentToAttachTo, USoundAttenuation AttenuationSettings, USoundEffectSourcePresetChain SourceEffectChain)
		{
			this.ComponentToAttachTo = ComponentToAttachTo;
			this.AttenuationSettings = AttenuationSettings;
			this.SourceEffectChain = SourceEffectChain;
		}

		// Token: 0x0601126A RID: 70250 RVA: 0x00192DD6 File Offset: 0x00190FD6
		protected override IntPtr GetUStructPtr()
		{
			return FVoiceSettings.StaticStruct();
		}

		// Token: 0x0601126B RID: 70251 RVA: 0x00192DE2 File Offset: 0x00190FE2
		public FVoiceSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601126C RID: 70252 RVA: 0x00192DEC File Offset: 0x00190FEC
		public FVoiceSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601126D RID: 70253 RVA: 0x00192DF7 File Offset: 0x00190FF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVoiceSettings(Pointer, false, true);
		}

		// Token: 0x0601126E RID: 70254 RVA: 0x00192E01 File Offset: 0x00191001
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVoiceSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040092D8 RID: 37592
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.VoiceSettings";

		// Token: 0x040092D9 RID: 37593
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040092DA RID: 37594
		internal static int __PropertyOffset_ComponentToAttachTo;

		// Token: 0x040092DB RID: 37595
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x040092DC RID: 37596
		internal static int __PropertyOffset_SourceEffectChain;
	}
}
