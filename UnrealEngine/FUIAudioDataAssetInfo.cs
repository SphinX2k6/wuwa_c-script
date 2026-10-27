using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002126 RID: 8486
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LGUI.UIAudioDataAssetInfo")]
	[UnrealStructLayout(408, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 408)]
	public class FUIAudioDataAssetInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FEB4 RID: 130740 RVA: 0x002F798E File Offset: 0x002F5B8E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FUIAudioDataAssetInfo._ScriptStructPtr != 0) ? FUIAudioDataAssetInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.UIAudioDataAssetInfo", ref FUIAudioDataAssetInfo._ScriptStructPtr);
		}

		// Token: 0x17007D7B RID: 32123
		// (get) Token: 0x0601FEB5 RID: 130741 RVA: 0x002F79B2 File Offset: 0x002F5BB2
		// (set) Token: 0x0601FEB6 RID: 130742 RVA: 0x002F79C2 File Offset: 0x002F5BC2
		public unsafe EUIAudioDataType AudioType
		{
			get
			{
				return (EUIAudioDataType)(*(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioType) = (byte)value;
			}
		}

		// Token: 0x17007D7C RID: 32124
		// (get) Token: 0x0601FEB7 RID: 130743 RVA: 0x002F79D4 File Offset: 0x002F5BD4
		// (set) Token: 0x0601FEB8 RID: 130744 RVA: 0x002F7A17 File Offset: 0x002F5C17
		public TMap<string, FAudioControl> AudioEntries
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FAudioControl> result;
				if ((result = this._AudioEntries) == null)
				{
					result = (this._AudioEntries = new TMap<string, FAudioControl>(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioEntries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AudioEntries.CopyAssign(value);
			}
		}

		// Token: 0x17007D7D RID: 32125
		// (get) Token: 0x0601FEB9 RID: 130745 RVA: 0x002F7A28 File Offset: 0x002F5C28
		// (set) Token: 0x0601FEBA RID: 130746 RVA: 0x002F7A6B File Offset: 0x002F5C6B
		public TMap<string, FSpineAudioControl> AudioSpineEntries
		{
			get
			{
				base.FastCheckIsValid();
				TMap<string, FSpineAudioControl> result;
				if ((result = this._AudioSpineEntries) == null)
				{
					result = (this._AudioSpineEntries = new TMap<string, FSpineAudioControl>(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioSpineEntries, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AudioSpineEntries.CopyAssign(value);
			}
		}

		// Token: 0x17007D7E RID: 32126
		// (get) Token: 0x0601FEBB RID: 130747 RVA: 0x002F7A7C File Offset: 0x002F5C7C
		// (set) Token: 0x0601FEBC RID: 130748 RVA: 0x002F7ABF File Offset: 0x002F5CBF
		public TMap<EButtonAudioStateTransferType, FSoftObjectPath> AudioButtonConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EButtonAudioStateTransferType, FSoftObjectPath> result;
				if ((result = this._AudioButtonConfig) == null)
				{
					result = (this._AudioButtonConfig = new TMap<EButtonAudioStateTransferType, FSoftObjectPath>(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioButtonConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AudioButtonConfig.CopyAssign(value);
			}
		}

		// Token: 0x17007D7F RID: 32127
		// (get) Token: 0x0601FEBD RID: 130749 RVA: 0x002F7AD0 File Offset: 0x002F5CD0
		// (set) Token: 0x0601FEBE RID: 130750 RVA: 0x002F7B13 File Offset: 0x002F5D13
		public TMap<EToggleAudioTransitionState, FSoftObjectPath> AudioToggleConfig
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EToggleAudioTransitionState, FSoftObjectPath> result;
				if ((result = this._AudioToggleConfig) == null)
				{
					result = (this._AudioToggleConfig = new TMap<EToggleAudioTransitionState, FSoftObjectPath>(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_AudioToggleConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.AudioToggleConfig.CopyAssign(value);
			}
		}

		// Token: 0x17007D80 RID: 32128
		// (get) Token: 0x0601FEBF RID: 130751 RVA: 0x002F7B24 File Offset: 0x002F5D24
		// (set) Token: 0x0601FEC0 RID: 130752 RVA: 0x002F7B67 File Offset: 0x002F5D67
		public FSoftObjectPath LongPressAudioEvent
		{
			get
			{
				base.FastCheckIsValid();
				FSoftObjectPath result;
				if ((result = this._LongPressAudioEvent) == null)
				{
					result = (this._LongPressAudioEvent = new FSoftObjectPath(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_LongPressAudioEvent, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoftObjectPath.StaticStruct(), base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_LongPressAudioEvent, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D81 RID: 32129
		// (get) Token: 0x0601FEC1 RID: 130753 RVA: 0x002F7B88 File Offset: 0x002F5D88
		// (set) Token: 0x0601FEC2 RID: 130754 RVA: 0x002F7BCB File Offset: 0x002F5DCB
		public FAudioControl NiagaraAudio
		{
			get
			{
				base.FastCheckIsValid();
				FAudioControl result;
				if ((result = this._NiagaraAudio) == null)
				{
					result = (this._NiagaraAudio = new FAudioControl(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_NiagaraAudio, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAudioControl.StaticStruct(), base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_NiagaraAudio, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007D82 RID: 32130
		// (get) Token: 0x0601FEC3 RID: 130755 RVA: 0x002F7BEC File Offset: 0x002F5DEC
		// (set) Token: 0x0601FEC4 RID: 130756 RVA: 0x002F7C00 File Offset: 0x002F5E00
		[Nullable(2)]
		public unsafe UAkAudioEvent DragBeginAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DragBeginAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DragBeginAudioEvent, value);
			}
		}

		// Token: 0x17007D83 RID: 32131
		// (get) Token: 0x0601FEC5 RID: 130757 RVA: 0x002F7C15 File Offset: 0x002F5E15
		// (set) Token: 0x0601FEC6 RID: 130758 RVA: 0x002F7C29 File Offset: 0x002F5E29
		[Nullable(2)]
		public unsafe UAkAudioEvent DragEndAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DragEndAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DragEndAudioEvent, value);
			}
		}

		// Token: 0x17007D84 RID: 32132
		// (get) Token: 0x0601FEC7 RID: 130759 RVA: 0x002F7C3E File Offset: 0x002F5E3E
		// (set) Token: 0x0601FEC8 RID: 130760 RVA: 0x002F7C52 File Offset: 0x002F5E52
		[Nullable(2)]
		public unsafe UAkAudioEvent DraggingAudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DraggingAudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FUIAudioDataAssetInfo.__PropertyOffset_DraggingAudioEvent, value);
			}
		}

		// Token: 0x17007D85 RID: 32133
		// (get) Token: 0x0601FEC9 RID: 130761 RVA: 0x002F7C67 File Offset: 0x002F5E67
		// (set) Token: 0x0601FECA RID: 130762 RVA: 0x002F7C77 File Offset: 0x002F5E77
		public unsafe float DraggingAudioEventInterval
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_DraggingAudioEventInterval);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FUIAudioDataAssetInfo.__PropertyOffset_DraggingAudioEventInterval) = value;
			}
		}

		// Token: 0x0601FECB RID: 130763 RVA: 0x002F7C88 File Offset: 0x002F5E88
		public FUIAudioDataAssetInfo()
		{
		}

		// Token: 0x0601FECC RID: 130764 RVA: 0x002F7C90 File Offset: 0x002F5E90
		public FUIAudioDataAssetInfo(EUIAudioDataType AudioType, TMap<string, FAudioControl> AudioEntries, TMap<string, FSpineAudioControl> AudioSpineEntries, TMap<EButtonAudioStateTransferType, FSoftObjectPath> AudioButtonConfig, TMap<EToggleAudioTransitionState, FSoftObjectPath> AudioToggleConfig, FSoftObjectPath LongPressAudioEvent, FAudioControl NiagaraAudio, UAkAudioEvent DragBeginAudioEvent, UAkAudioEvent DragEndAudioEvent, UAkAudioEvent DraggingAudioEvent, float DraggingAudioEventInterval)
		{
			this.AudioType = AudioType;
			this.AudioEntries = AudioEntries;
			this.AudioSpineEntries = AudioSpineEntries;
			this.AudioButtonConfig = AudioButtonConfig;
			this.AudioToggleConfig = AudioToggleConfig;
			this.LongPressAudioEvent = LongPressAudioEvent;
			this.NiagaraAudio = NiagaraAudio;
			this.DragBeginAudioEvent = DragBeginAudioEvent;
			this.DragEndAudioEvent = DragEndAudioEvent;
			this.DraggingAudioEvent = DraggingAudioEvent;
			this.DraggingAudioEventInterval = DraggingAudioEventInterval;
		}

		// Token: 0x0601FECD RID: 130765 RVA: 0x002F7CF8 File Offset: 0x002F5EF8
		protected override IntPtr GetUStructPtr()
		{
			return FUIAudioDataAssetInfo.StaticStruct();
		}

		// Token: 0x0601FECE RID: 130766 RVA: 0x002F7D04 File Offset: 0x002F5F04
		[NullableContext(2)]
		public FUIAudioDataAssetInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FECF RID: 130767 RVA: 0x002F7D0E File Offset: 0x002F5F0E
		public FUIAudioDataAssetInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FED0 RID: 130768 RVA: 0x002F7D19 File Offset: 0x002F5F19
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FUIAudioDataAssetInfo(Pointer, false, true);
		}

		// Token: 0x0601FED1 RID: 130769 RVA: 0x002F7D23 File Offset: 0x002F5F23
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FUIAudioDataAssetInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04011325 RID: 70437
		public const string __ObjectPath = "/Script/LGUI.UIAudioDataAssetInfo";

		// Token: 0x04011326 RID: 70438
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011327 RID: 70439
		internal static int __PropertyOffset_AudioType;

		// Token: 0x04011328 RID: 70440
		internal static int __PropertyOffset_AudioEntries;

		// Token: 0x04011329 RID: 70441
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FAudioControl> _AudioEntries;

		// Token: 0x0401132A RID: 70442
		internal static int __PropertyOffset_AudioSpineEntries;

		// Token: 0x0401132B RID: 70443
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private TMap<string, FSpineAudioControl> _AudioSpineEntries;

		// Token: 0x0401132C RID: 70444
		internal static int __PropertyOffset_AudioButtonConfig;

		// Token: 0x0401132D RID: 70445
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EButtonAudioStateTransferType, FSoftObjectPath> _AudioButtonConfig;

		// Token: 0x0401132E RID: 70446
		internal static int __PropertyOffset_AudioToggleConfig;

		// Token: 0x0401132F RID: 70447
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EToggleAudioTransitionState, FSoftObjectPath> _AudioToggleConfig;

		// Token: 0x04011330 RID: 70448
		internal static int __PropertyOffset_LongPressAudioEvent;

		// Token: 0x04011331 RID: 70449
		[Nullable(2)]
		private FSoftObjectPath _LongPressAudioEvent;

		// Token: 0x04011332 RID: 70450
		internal static int __PropertyOffset_NiagaraAudio;

		// Token: 0x04011333 RID: 70451
		[Nullable(2)]
		private FAudioControl _NiagaraAudio;

		// Token: 0x04011334 RID: 70452
		internal static int __PropertyOffset_DragBeginAudioEvent;

		// Token: 0x04011335 RID: 70453
		internal static int __PropertyOffset_DragEndAudioEvent;

		// Token: 0x04011336 RID: 70454
		internal static int __PropertyOffset_DraggingAudioEvent;

		// Token: 0x04011337 RID: 70455
		internal static int __PropertyOffset_DraggingAudioEventInterval;
	}
}
