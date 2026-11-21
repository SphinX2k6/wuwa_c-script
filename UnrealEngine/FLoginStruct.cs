using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200052B RID: 1323
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSDK.LoginStruct")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FLoginStruct : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007BC8 RID: 31688 RVA: 0x000B6EA3 File Offset: 0x000B50A3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLoginStruct._ScriptStructPtr != 0) ? FLoginStruct._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroSDK.LoginStruct", ref FLoginStruct._ScriptStructPtr);
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06007BC9 RID: 31689 RVA: 0x000B6EC7 File Offset: 0x000B50C7
		// (set) Token: 0x06007BCA RID: 31690 RVA: 0x000B6ED7 File Offset: 0x000B50D7
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

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06007BCB RID: 31691 RVA: 0x000B6EE8 File Offset: 0x000B50E8
		// (set) Token: 0x06007BCC RID: 31692 RVA: 0x000B6EFC File Offset: 0x000B50FC
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

		// Token: 0x17001811 RID: 6161
		// (get) Token: 0x06007BCD RID: 31693 RVA: 0x000B6F11 File Offset: 0x000B5111
		// (set) Token: 0x06007BCE RID: 31694 RVA: 0x000B6F25 File Offset: 0x000B5125
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

		// Token: 0x17001812 RID: 6162
		// (get) Token: 0x06007BCF RID: 31695 RVA: 0x000B6F3A File Offset: 0x000B513A
		// (set) Token: 0x06007BD0 RID: 31696 RVA: 0x000B6F4E File Offset: 0x000B514E
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

		// Token: 0x17001813 RID: 6163
		// (get) Token: 0x06007BD1 RID: 31697 RVA: 0x000B6F63 File Offset: 0x000B5163
		// (set) Token: 0x06007BD2 RID: 31698 RVA: 0x000B6F77 File Offset: 0x000B5177
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

		// Token: 0x17001814 RID: 6164
		// (get) Token: 0x06007BD3 RID: 31699 RVA: 0x000B6F8C File Offset: 0x000B518C
		// (set) Token: 0x06007BD4 RID: 31700 RVA: 0x000B6FA0 File Offset: 0x000B51A0
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

		// Token: 0x06007BD5 RID: 31701 RVA: 0x000B6FB5 File Offset: 0x000B51B5
		public FLoginStruct()
		{
		}

		// Token: 0x06007BD6 RID: 31702 RVA: 0x000B6FBD File Offset: 0x000B51BD
		protected override IntPtr GetUStructPtr()
		{
			return FLoginStruct.StaticStruct();
		}

		// Token: 0x06007BD7 RID: 31703 RVA: 0x000B6FC9 File Offset: 0x000B51C9
		[NullableContext(2)]
		public FLoginStruct(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007BD8 RID: 31704 RVA: 0x000B6FD3 File Offset: 0x000B51D3
		public FLoginStruct(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007BD9 RID: 31705 RVA: 0x000B6FDE File Offset: 0x000B51DE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLoginStruct(Pointer, false, true);
		}

		// Token: 0x06007BDA RID: 31706 RVA: 0x000B6FE8 File Offset: 0x000B51E8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLoginStruct(Pointer, MemoryOwner);
		}

		// Token: 0x040034F9 RID: 13561
		public const string __ObjectPath = "/Script/KuroSDK.LoginStruct";

		// Token: 0x040034FA RID: 13562
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040034FB RID: 13563
		internal static int __PropertyOffset_LoginCode;

		// Token: 0x040034FC RID: 13564
		internal static int __PropertyOffset_Uid;

		// Token: 0x040034FD RID: 13565
		internal static int __PropertyOffset_UserName;

		// Token: 0x040034FE RID: 13566
		internal static int __PropertyOffset_Token;

		// Token: 0x040034FF RID: 13567
		internal static int __PropertyOffset_ChannelId;

		// Token: 0x04003500 RID: 13568
		internal static int __PropertyOffset_ExParams;
	}
}
