using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009BC RID: 2492
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.DialogueContextMapping")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FDialogueContextMapping : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06008CBA RID: 36026 RVA: 0x000C965B File Offset: 0x000C785B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FDialogueContextMapping._ScriptStructPtr != 0) ? FDialogueContextMapping._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.DialogueContextMapping", ref FDialogueContextMapping._ScriptStructPtr);
		}

		// Token: 0x17002118 RID: 8472
		// (get) Token: 0x06008CBB RID: 36027 RVA: 0x000C9680 File Offset: 0x000C7880
		// (set) Token: 0x06008CBC RID: 36028 RVA: 0x000C96C3 File Offset: 0x000C78C3
		public FDialogueContext Context
		{
			get
			{
				base.FastCheckIsValid();
				FDialogueContext result;
				if ((result = this._Context) == null)
				{
					result = (this._Context = new FDialogueContext(base.NativePtr + (IntPtr)FDialogueContextMapping.__PropertyOffset_Context, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDialogueContext.StaticStruct(), base.NativePtr + (IntPtr)FDialogueContextMapping.__PropertyOffset_Context, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17002119 RID: 8473
		// (get) Token: 0x06008CBD RID: 36029 RVA: 0x000C96E4 File Offset: 0x000C78E4
		// (set) Token: 0x06008CBE RID: 36030 RVA: 0x000C96F8 File Offset: 0x000C78F8
		[Nullable(2)]
		public unsafe USoundWave SoundWave
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundWave>(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContextMapping.__PropertyOffset_SoundWave);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContextMapping.__PropertyOffset_SoundWave, value);
			}
		}

		// Token: 0x1700211A RID: 8474
		// (get) Token: 0x06008CBF RID: 36031 RVA: 0x000C970D File Offset: 0x000C790D
		// (set) Token: 0x06008CC0 RID: 36032 RVA: 0x000C9721 File Offset: 0x000C7921
		public unsafe string LocalizationKeyFormat
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FDialogueContextMapping.__PropertyOffset_LocalizationKeyFormat)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FDialogueContextMapping.__PropertyOffset_LocalizationKeyFormat)), value);
			}
		}

		// Token: 0x1700211B RID: 8475
		// (get) Token: 0x06008CC1 RID: 36033 RVA: 0x000C9736 File Offset: 0x000C7936
		// (set) Token: 0x06008CC2 RID: 36034 RVA: 0x000C974A File Offset: 0x000C794A
		[Nullable(2)]
		public unsafe UDialogueSoundWaveProxy Proxy
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UDialogueSoundWaveProxy>(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContextMapping.__PropertyOffset_Proxy);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FDialogueContextMapping.__PropertyOffset_Proxy, value);
			}
		}

		// Token: 0x06008CC3 RID: 36035 RVA: 0x000C975F File Offset: 0x000C795F
		public FDialogueContextMapping()
		{
		}

		// Token: 0x06008CC4 RID: 36036 RVA: 0x000C9767 File Offset: 0x000C7967
		public FDialogueContextMapping(FDialogueContext Context, USoundWave SoundWave, string LocalizationKeyFormat, UDialogueSoundWaveProxy Proxy)
		{
			this.Context = Context;
			this.SoundWave = SoundWave;
			this.LocalizationKeyFormat = LocalizationKeyFormat;
			this.Proxy = Proxy;
		}

		// Token: 0x06008CC5 RID: 36037 RVA: 0x000C978C File Offset: 0x000C798C
		protected override IntPtr GetUStructPtr()
		{
			return FDialogueContextMapping.StaticStruct();
		}

		// Token: 0x06008CC6 RID: 36038 RVA: 0x000C9798 File Offset: 0x000C7998
		[NullableContext(2)]
		public FDialogueContextMapping(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008CC7 RID: 36039 RVA: 0x000C97A2 File Offset: 0x000C79A2
		public FDialogueContextMapping(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x000C97AD File Offset: 0x000C79AD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FDialogueContextMapping(Pointer, false, true);
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x000C97B7 File Offset: 0x000C79B7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FDialogueContextMapping(Pointer, MemoryOwner);
		}

		// Token: 0x040042D2 RID: 17106
		public const string __ObjectPath = "/Script/Engine.DialogueContextMapping";

		// Token: 0x040042D3 RID: 17107
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040042D4 RID: 17108
		internal static int __PropertyOffset_Context;

		// Token: 0x040042D5 RID: 17109
		[Nullable(2)]
		private FDialogueContext _Context;

		// Token: 0x040042D6 RID: 17110
		internal static int __PropertyOffset_SoundWave;

		// Token: 0x040042D7 RID: 17111
		internal static int __PropertyOffset_LocalizationKeyFormat;

		// Token: 0x040042D8 RID: 17112
		internal static int __PropertyOffset_Proxy;
	}
}
