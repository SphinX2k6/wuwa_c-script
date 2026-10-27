using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000872 RID: 2162
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.AudioVolumeSubmixSendSettings")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FAudioVolumeSubmixSendSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007584 RID: 30084 RVA: 0x000A880B File Offset: 0x000A6A0B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAudioVolumeSubmixSendSettings._ScriptStructPtr != 0) ? FAudioVolumeSubmixSendSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AudioVolumeSubmixSendSettings", ref FAudioVolumeSubmixSendSettings._ScriptStructPtr);
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06007585 RID: 30085 RVA: 0x000A882F File Offset: 0x000A6A2F
		// (set) Token: 0x06007586 RID: 30086 RVA: 0x000A883F File Offset: 0x000A6A3F
		public unsafe EAudioVolumeLocationState ListenerLocationState
		{
			get
			{
				return (EAudioVolumeLocationState)(*(base.NativePtr + (IntPtr)FAudioVolumeSubmixSendSettings.__PropertyOffset_ListenerLocationState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioVolumeSubmixSendSettings.__PropertyOffset_ListenerLocationState) = (byte)value;
			}
		}

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06007587 RID: 30087 RVA: 0x000A8850 File Offset: 0x000A6A50
		// (set) Token: 0x06007588 RID: 30088 RVA: 0x000A8860 File Offset: 0x000A6A60
		public unsafe EAudioVolumeLocationState SourceLocationState_DEPRECATED
		{
			get
			{
				return (EAudioVolumeLocationState)(*(base.NativePtr + (IntPtr)FAudioVolumeSubmixSendSettings.__PropertyOffset_SourceLocationState_DEPRECATED));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAudioVolumeSubmixSendSettings.__PropertyOffset_SourceLocationState_DEPRECATED) = (byte)value;
			}
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06007589 RID: 30089 RVA: 0x000A8874 File Offset: 0x000A6A74
		// (set) Token: 0x0600758A RID: 30090 RVA: 0x000A88B7 File Offset: 0x000A6AB7
		public TArray<FSoundSubmixSendInfo> SubmixSends
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FSoundSubmixSendInfo> result;
				if ((result = this._SubmixSends) == null)
				{
					result = (this._SubmixSends = new TArray<FSoundSubmixSendInfo>(base.NativePtr + (IntPtr)FAudioVolumeSubmixSendSettings.__PropertyOffset_SubmixSends, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubmixSends.CopyAssign(value);
			}
		}

		// Token: 0x0600758B RID: 30091 RVA: 0x000A88C5 File Offset: 0x000A6AC5
		public FAudioVolumeSubmixSendSettings()
		{
		}

		// Token: 0x0600758C RID: 30092 RVA: 0x000A88CD File Offset: 0x000A6ACD
		public FAudioVolumeSubmixSendSettings(EAudioVolumeLocationState ListenerLocationState, EAudioVolumeLocationState SourceLocationState_DEPRECATED, TArray<FSoundSubmixSendInfo> SubmixSends)
		{
			this.ListenerLocationState = ListenerLocationState;
			this.SourceLocationState_DEPRECATED = SourceLocationState_DEPRECATED;
			this.SubmixSends = SubmixSends;
		}

		// Token: 0x0600758D RID: 30093 RVA: 0x000A88EA File Offset: 0x000A6AEA
		protected override IntPtr GetUStructPtr()
		{
			return FAudioVolumeSubmixSendSettings.StaticStruct();
		}

		// Token: 0x0600758E RID: 30094 RVA: 0x000A88F6 File Offset: 0x000A6AF6
		[NullableContext(2)]
		public FAudioVolumeSubmixSendSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600758F RID: 30095 RVA: 0x000A8900 File Offset: 0x000A6B00
		public FAudioVolumeSubmixSendSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007590 RID: 30096 RVA: 0x000A890B File Offset: 0x000A6B0B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAudioVolumeSubmixSendSettings(Pointer, false, true);
		}

		// Token: 0x06007591 RID: 30097 RVA: 0x000A8915 File Offset: 0x000A6B15
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAudioVolumeSubmixSendSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04003887 RID: 14471
		public const string __ObjectPath = "/Script/Engine.AudioVolumeSubmixSendSettings";

		// Token: 0x04003888 RID: 14472
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003889 RID: 14473
		internal static int __PropertyOffset_ListenerLocationState;

		// Token: 0x0400388A RID: 14474
		internal static int __PropertyOffset_SourceLocationState_DEPRECATED;

		// Token: 0x0400388B RID: 14475
		internal static int __PropertyOffset_SubmixSends;

		// Token: 0x0400388C RID: 14476
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FSoundSubmixSendInfo> _SubmixSends;
	}
}
