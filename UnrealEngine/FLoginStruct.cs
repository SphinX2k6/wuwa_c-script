using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C92 RID: 7314
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.LoginStruct")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FLoginStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601C689 RID: 116361 RVA: 0x0029F495 File Offset: 0x0029D695
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoginStruct._ScriptStructPtr != 0) ? FLoginStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.LoginStruct", ref FLoginStruct._ScriptStructPtr);
		}

		// Token: 0x170072BF RID: 29375
		// (get) Token: 0x0601C68A RID: 116362 RVA: 0x0029F4B9 File Offset: 0x0029D6B9
		// (set) Token: 0x0601C68B RID: 116363 RVA: 0x0029F4C9 File Offset: 0x0029D6C9
		public unsafe byte LoginCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLoginStruct.__PropertyOffset_LoginCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLoginStruct.__PropertyOffset_LoginCode) = value;
			}
		}

		// Token: 0x170072C0 RID: 29376
		// (get) Token: 0x0601C68C RID: 116364 RVA: 0x0029F4DA File Offset: 0x0029D6DA
		// (set) Token: 0x0601C68D RID: 116365 RVA: 0x0029F4EE File Offset: 0x0029D6EE
		public unsafe string Uid
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_Uid)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_Uid)), value);
			}
		}

		// Token: 0x170072C1 RID: 29377
		// (get) Token: 0x0601C68E RID: 116366 RVA: 0x0029F503 File Offset: 0x0029D703
		// (set) Token: 0x0601C68F RID: 116367 RVA: 0x0029F517 File Offset: 0x0029D717
		public unsafe string UserName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_UserName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_UserName)), value);
			}
		}

		// Token: 0x170072C2 RID: 29378
		// (get) Token: 0x0601C690 RID: 116368 RVA: 0x0029F52C File Offset: 0x0029D72C
		// (set) Token: 0x0601C691 RID: 116369 RVA: 0x0029F540 File Offset: 0x0029D740
		public unsafe string Token
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_Token)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_Token)), value);
			}
		}

		// Token: 0x170072C3 RID: 29379
		// (get) Token: 0x0601C692 RID: 116370 RVA: 0x0029F555 File Offset: 0x0029D755
		// (set) Token: 0x0601C693 RID: 116371 RVA: 0x0029F569 File Offset: 0x0029D769
		public unsafe string ChannelId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_ChannelId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_ChannelId)), value);
			}
		}

		// Token: 0x170072C4 RID: 29380
		// (get) Token: 0x0601C694 RID: 116372 RVA: 0x0029F57E File Offset: 0x0029D77E
		// (set) Token: 0x0601C695 RID: 116373 RVA: 0x0029F592 File Offset: 0x0029D792
		public unsafe string ExParams
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_ExParams)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FLoginStruct.__PropertyOffset_ExParams)), value);
			}
		}

		// Token: 0x0601C696 RID: 116374 RVA: 0x0029F5A7 File Offset: 0x0029D7A7
		public FLoginStruct()
		{
		}

		// Token: 0x0601C697 RID: 116375 RVA: 0x0029F5AF File Offset: 0x0029D7AF
		public FLoginStruct(byte LoginCode, string Uid, string UserName, string Token, string ChannelId, string ExParams)
		{
			this.LoginCode = LoginCode;
			this.Uid = Uid;
			this.UserName = UserName;
			this.Token = Token;
			this.ChannelId = ChannelId;
			this.ExParams = ExParams;
		}

		// Token: 0x0601C698 RID: 116376 RVA: 0x0029F5E4 File Offset: 0x0029D7E4
		protected override IntPtr GetUStructPtr()
		{
			return FLoginStruct.StaticStruct();
		}

		// Token: 0x0601C699 RID: 116377 RVA: 0x0029F5F0 File Offset: 0x0029D7F0
		[NullableContext(2)]
		public FLoginStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C69A RID: 116378 RVA: 0x0029F5FA File Offset: 0x0029D7FA
		public FLoginStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C69B RID: 116379 RVA: 0x0029F605 File Offset: 0x0029D805
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoginStruct(Pointer, false, true);
		}

		// Token: 0x0601C69C RID: 116380 RVA: 0x0029F60F File Offset: 0x0029D80F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoginStruct(Pointer, MemoryOwner);
		}

		// Token: 0x0400F48F RID: 62607
		public const string __ObjectPath = "/Script/KuroSDK.LoginStruct";

		// Token: 0x0400F490 RID: 62608
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F491 RID: 62609
		internal static int __PropertyOffset_LoginCode;

		// Token: 0x0400F492 RID: 62610
		internal static int __PropertyOffset_Uid;

		// Token: 0x0400F493 RID: 62611
		internal static int __PropertyOffset_UserName;

		// Token: 0x0400F494 RID: 62612
		internal static int __PropertyOffset_Token;

		// Token: 0x0400F495 RID: 62613
		internal static int __PropertyOffset_ChannelId;

		// Token: 0x0400F496 RID: 62614
		internal static int __PropertyOffset_ExParams;
	}
}
