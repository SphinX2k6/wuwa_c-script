using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200120E RID: 4622
	[UnrealObjectPath("/Script/Engine.TTTrackId")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FTTTrackId : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011056 RID: 69718 RVA: 0x0018F957 File Offset: 0x0018DB57
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTTTrackId._ScriptStructPtr != 0) ? FTTTrackId._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.TTTrackId", ref FTTTrackId._ScriptStructPtr);
		}

		// Token: 0x17004278 RID: 17016
		// (get) Token: 0x06011057 RID: 69719 RVA: 0x0018F97B File Offset: 0x0018DB7B
		// (set) Token: 0x06011058 RID: 69720 RVA: 0x0018F98B File Offset: 0x0018DB8B
		public unsafe int TrackType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTTrackId.__PropertyOffset_TrackType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTTrackId.__PropertyOffset_TrackType) = value;
			}
		}

		// Token: 0x17004279 RID: 17017
		// (get) Token: 0x06011059 RID: 69721 RVA: 0x0018F99C File Offset: 0x0018DB9C
		// (set) Token: 0x0601105A RID: 69722 RVA: 0x0018F9AC File Offset: 0x0018DBAC
		public unsafe int TrackIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTTTrackId.__PropertyOffset_TrackIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTTTrackId.__PropertyOffset_TrackIndex) = value;
			}
		}

		// Token: 0x0601105B RID: 69723 RVA: 0x0018F9BD File Offset: 0x0018DBBD
		public FTTTrackId()
		{
		}

		// Token: 0x0601105C RID: 69724 RVA: 0x0018F9C5 File Offset: 0x0018DBC5
		public FTTTrackId(int TrackType, int TrackIndex)
		{
			this.TrackType = TrackType;
			this.TrackIndex = TrackIndex;
		}

		// Token: 0x0601105D RID: 69725 RVA: 0x0018F9DB File Offset: 0x0018DBDB
		protected override IntPtr GetUStructPtr()
		{
			return FTTTrackId.StaticStruct();
		}

		// Token: 0x0601105E RID: 69726 RVA: 0x0018F9E7 File Offset: 0x0018DBE7
		[NullableContext(2)]
		public FTTTrackId(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601105F RID: 69727 RVA: 0x0018F9F1 File Offset: 0x0018DBF1
		public FTTTrackId(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011060 RID: 69728 RVA: 0x0018F9FC File Offset: 0x0018DBFC
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTTTrackId(Pointer, false, true);
		}

		// Token: 0x06011061 RID: 69729 RVA: 0x0018FA06 File Offset: 0x0018DC06
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTTTrackId(Pointer, MemoryOwner);
		}

		// Token: 0x040091CB RID: 37323
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.TTTrackId";

		// Token: 0x040091CC RID: 37324
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040091CD RID: 37325
		internal static int __PropertyOffset_TrackType;

		// Token: 0x040091CE RID: 37326
		internal static int __PropertyOffset_TrackIndex;
	}
}
