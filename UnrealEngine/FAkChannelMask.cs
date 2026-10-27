using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020001F7 RID: 503
	[UnrealObjectPath("/Script/AkAudio.AkChannelMask")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAkChannelMask : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001D87 RID: 7559 RVA: 0x0002BEAF File Offset: 0x0002A0AF
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAkChannelMask._ScriptStructPtr != 0) ? FAkChannelMask._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AkAudio.AkChannelMask", ref FAkChannelMask._ScriptStructPtr);
		}

		// Token: 0x1700076D RID: 1901
		// (get) Token: 0x06001D88 RID: 7560 RVA: 0x0002BED3 File Offset: 0x0002A0D3
		// (set) Token: 0x06001D89 RID: 7561 RVA: 0x0002BEE3 File Offset: 0x0002A0E3
		public unsafe int ChannelMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAkChannelMask.__PropertyOffset_ChannelMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAkChannelMask.__PropertyOffset_ChannelMask) = value;
			}
		}

		// Token: 0x06001D8A RID: 7562 RVA: 0x0002BEF4 File Offset: 0x0002A0F4
		public FAkChannelMask()
		{
		}

		// Token: 0x06001D8B RID: 7563 RVA: 0x0002BEFC File Offset: 0x0002A0FC
		public FAkChannelMask(int ChannelMask)
		{
			this.ChannelMask = ChannelMask;
		}

		// Token: 0x06001D8C RID: 7564 RVA: 0x0002BF0B File Offset: 0x0002A10B
		protected override IntPtr GetUStructPtr()
		{
			return FAkChannelMask.StaticStruct();
		}

		// Token: 0x06001D8D RID: 7565 RVA: 0x0002BF17 File Offset: 0x0002A117
		[NullableContext(2)]
		public FAkChannelMask(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06001D8E RID: 7566 RVA: 0x0002BF21 File Offset: 0x0002A121
		public FAkChannelMask(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06001D8F RID: 7567 RVA: 0x0002BF2C File Offset: 0x0002A12C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAkChannelMask(Pointer, false, true);
		}

		// Token: 0x06001D90 RID: 7568 RVA: 0x0002BF36 File Offset: 0x0002A136
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAkChannelMask(Pointer, MemoryOwner);
		}

		// Token: 0x040009BF RID: 2495
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AkAudio.AkChannelMask";

		// Token: 0x040009C0 RID: 2496
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040009C1 RID: 2497
		internal static int __PropertyOffset_ChannelMask;
	}
}
