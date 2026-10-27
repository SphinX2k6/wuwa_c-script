using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CB5 RID: 3253
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackToggle")]
	[UnrealStructLayout(192, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 192)]
	public class UInterpTrackToggle : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A47E RID: 42110 RVA: 0x000EA01F File Offset: 0x000E821F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackToggle._ClassPtr;
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x000EA02C File Offset: 0x000E822C
		public UInterpTrackToggle() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackToggle.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x000EA054 File Offset: 0x000E8254
		public UInterpTrackToggle(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackToggle.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002723 RID: 10019
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x000EA088 File Offset: 0x000E8288
		// (set) Token: 0x0600A482 RID: 42114 RVA: 0x000EA0C1 File Offset: 0x000E82C1
		public TArray<FToggleTrackKey> ToggleTrack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FToggleTrackKey> result;
				if ((result = this._ToggleTrack) == null)
				{
					result = (this._ToggleTrack = new TArray<FToggleTrackKey>(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_ToggleTrack, this));
				}
				return result;
			}
			set
			{
				this.ToggleTrack.CopyAssign(value);
			}
		}

		// Token: 0x17002724 RID: 10020
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x000EA0CF File Offset: 0x000E82CF
		// (set) Token: 0x0600A484 RID: 42116 RVA: 0x000EA0E8 File Offset: 0x000E82E8
		public unsafe bool bActivateSystemEachUpdate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateSystemEachUpdate) & UInterpTrackToggle.__PropertyMask_bActivateSystemEachUpdate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateSystemEachUpdate) = ((*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateSystemEachUpdate) & ~UInterpTrackToggle.__PropertyMask_bActivateSystemEachUpdate) | (value ? UInterpTrackToggle.__PropertyMask_bActivateSystemEachUpdate : 0));
			}
		}

		// Token: 0x17002725 RID: 10021
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x000EA118 File Offset: 0x000E8318
		// (set) Token: 0x0600A486 RID: 42118 RVA: 0x000EA131 File Offset: 0x000E8331
		public unsafe bool bActivateWithJustAttachedFlag
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateWithJustAttachedFlag) & UInterpTrackToggle.__PropertyMask_bActivateWithJustAttachedFlag) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateWithJustAttachedFlag) = ((*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bActivateWithJustAttachedFlag) & ~UInterpTrackToggle.__PropertyMask_bActivateWithJustAttachedFlag) | (value ? UInterpTrackToggle.__PropertyMask_bActivateWithJustAttachedFlag : 0));
			}
		}

		// Token: 0x17002726 RID: 10022
		// (get) Token: 0x0600A487 RID: 42119 RVA: 0x000EA161 File Offset: 0x000E8361
		// (set) Token: 0x0600A488 RID: 42120 RVA: 0x000EA17A File Offset: 0x000E837A
		public unsafe bool bFireEventsWhenForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenForwards) & UInterpTrackToggle.__PropertyMask_bFireEventsWhenForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenForwards) & ~UInterpTrackToggle.__PropertyMask_bFireEventsWhenForwards) | (value ? UInterpTrackToggle.__PropertyMask_bFireEventsWhenForwards : 0));
			}
		}

		// Token: 0x17002727 RID: 10023
		// (get) Token: 0x0600A489 RID: 42121 RVA: 0x000EA1AA File Offset: 0x000E83AA
		// (set) Token: 0x0600A48A RID: 42122 RVA: 0x000EA1C3 File Offset: 0x000E83C3
		public unsafe bool bFireEventsWhenBackwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenBackwards) & UInterpTrackToggle.__PropertyMask_bFireEventsWhenBackwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenBackwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenBackwards) & ~UInterpTrackToggle.__PropertyMask_bFireEventsWhenBackwards) | (value ? UInterpTrackToggle.__PropertyMask_bFireEventsWhenBackwards : 0));
			}
		}

		// Token: 0x17002728 RID: 10024
		// (get) Token: 0x0600A48B RID: 42123 RVA: 0x000EA1F3 File Offset: 0x000E83F3
		// (set) Token: 0x0600A48C RID: 42124 RVA: 0x000EA20C File Offset: 0x000E840C
		public unsafe bool bFireEventsWhenJumpingForwards
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenJumpingForwards) & UInterpTrackToggle.__PropertyMask_bFireEventsWhenJumpingForwards) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenJumpingForwards) = ((*(base.NativePtr + (IntPtr)UInterpTrackToggle.__PropertyOffset_bFireEventsWhenJumpingForwards) & ~UInterpTrackToggle.__PropertyMask_bFireEventsWhenJumpingForwards) | (value ? UInterpTrackToggle.__PropertyMask_bFireEventsWhenJumpingForwards : 0));
			}
		}

		// Token: 0x0600A48D RID: 42125 RVA: 0x000EA23C File Offset: 0x000E843C
		static UInterpTrackToggle()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackToggle");
		}

		// Token: 0x0600A48E RID: 42126 RVA: 0x000EA24A File Offset: 0x000E844A
		protected UInterpTrackToggle(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A80 RID: 23168
		public new const string __ObjectPath = "/Script/Engine.InterpTrackToggle";

		// Token: 0x04005A81 RID: 23169
		private static IntPtr _ClassPtr;

		// Token: 0x04005A82 RID: 23170
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A83 RID: 23171
		internal static int __PropertyOffset_ToggleTrack;

		// Token: 0x04005A84 RID: 23172
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FToggleTrackKey> _ToggleTrack;

		// Token: 0x04005A85 RID: 23173
		internal static int __PropertyOffset_bActivateSystemEachUpdate;

		// Token: 0x04005A86 RID: 23174
		internal static byte __PropertyMask_bActivateSystemEachUpdate;

		// Token: 0x04005A87 RID: 23175
		internal static int __PropertyOffset_bActivateWithJustAttachedFlag;

		// Token: 0x04005A88 RID: 23176
		internal static byte __PropertyMask_bActivateWithJustAttachedFlag;

		// Token: 0x04005A89 RID: 23177
		internal static int __PropertyOffset_bFireEventsWhenForwards;

		// Token: 0x04005A8A RID: 23178
		internal static byte __PropertyMask_bFireEventsWhenForwards;

		// Token: 0x04005A8B RID: 23179
		internal static int __PropertyOffset_bFireEventsWhenBackwards;

		// Token: 0x04005A8C RID: 23180
		internal static byte __PropertyMask_bFireEventsWhenBackwards;

		// Token: 0x04005A8D RID: 23181
		internal static int __PropertyOffset_bFireEventsWhenJumpingForwards;

		// Token: 0x04005A8E RID: 23182
		internal static byte __PropertyMask_bFireEventsWhenJumpingForwards;
	}
}
