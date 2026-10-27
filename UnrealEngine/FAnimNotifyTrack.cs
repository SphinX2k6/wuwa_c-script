using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200082E RID: 2094
	[UnrealObjectPath("/Script/Engine.AnimNotifyTrack")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FAnimNotifyTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060070C5 RID: 28869 RVA: 0x000A1AF6 File Offset: 0x0009FCF6
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyTrack._ScriptStructPtr != 0) ? FAnimNotifyTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyTrack", ref FAnimNotifyTrack._ScriptStructPtr);
		}

		// Token: 0x17001A8A RID: 6794
		// (get) Token: 0x060070C6 RID: 28870 RVA: 0x000A1B1A File Offset: 0x0009FD1A
		// (set) Token: 0x060070C7 RID: 28871 RVA: 0x000A1B2E File Offset: 0x0009FD2E
		public unsafe FName TrackName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyTrack.__PropertyOffset_TrackName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyTrack.__PropertyOffset_TrackName) = value;
			}
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x060070C8 RID: 28872 RVA: 0x000A1B43 File Offset: 0x0009FD43
		// (set) Token: 0x060070C9 RID: 28873 RVA: 0x000A1B57 File Offset: 0x0009FD57
		public unsafe FLinearColor TrackColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyTrack.__PropertyOffset_TrackColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyTrack.__PropertyOffset_TrackColor) = value;
			}
		}

		// Token: 0x060070CA RID: 28874 RVA: 0x000A1B6C File Offset: 0x0009FD6C
		public FAnimNotifyTrack()
		{
		}

		// Token: 0x060070CB RID: 28875 RVA: 0x000A1B74 File Offset: 0x0009FD74
		public FAnimNotifyTrack(FName TrackName, FLinearColor TrackColor)
		{
			this.TrackName = TrackName;
			this.TrackColor = TrackColor;
		}

		// Token: 0x060070CC RID: 28876 RVA: 0x000A1B8A File Offset: 0x0009FD8A
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyTrack.StaticStruct();
		}

		// Token: 0x060070CD RID: 28877 RVA: 0x000A1B96 File Offset: 0x0009FD96
		[NullableContext(2)]
		public FAnimNotifyTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060070CE RID: 28878 RVA: 0x000A1BA0 File Offset: 0x0009FDA0
		public FAnimNotifyTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060070CF RID: 28879 RVA: 0x000A1BAB File Offset: 0x0009FDAB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyTrack(Pointer, false, true);
		}

		// Token: 0x060070D0 RID: 28880 RVA: 0x000A1BB5 File Offset: 0x0009FDB5
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04003621 RID: 13857
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.AnimNotifyTrack";

		// Token: 0x04003622 RID: 13858
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003623 RID: 13859
		internal static int __PropertyOffset_TrackName;

		// Token: 0x04003624 RID: 13860
		internal static int __PropertyOffset_TrackColor;
	}
}
