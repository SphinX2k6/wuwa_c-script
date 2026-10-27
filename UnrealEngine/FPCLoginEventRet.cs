using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E8 RID: 4840
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.PCLoginEventRet")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FPCLoginEventRet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011BCF RID: 72655 RVA: 0x001A094D File Offset: 0x0019EB4D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPCLoginEventRet._ScriptStructPtr != 0) ? FPCLoginEventRet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.PCLoginEventRet", ref FPCLoginEventRet._ScriptStructPtr);
		}

		// Token: 0x17004578 RID: 17784
		// (get) Token: 0x06011BD0 RID: 72656 RVA: 0x001A0971 File Offset: 0x0019EB71
		// (set) Token: 0x06011BD1 RID: 72657 RVA: 0x001A0985 File Offset: 0x0019EB85
		public unsafe string Channel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_Channel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_Channel)), value);
			}
		}

		// Token: 0x17004579 RID: 17785
		// (get) Token: 0x06011BD2 RID: 72658 RVA: 0x001A099A File Offset: 0x0019EB9A
		// (set) Token: 0x06011BD3 RID: 72659 RVA: 0x001A09AA File Offset: 0x0019EBAA
		public unsafe int ChannelID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPCLoginEventRet.__PropertyOffset_ChannelID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPCLoginEventRet.__PropertyOffset_ChannelID) = value;
			}
		}

		// Token: 0x1700457A RID: 17786
		// (get) Token: 0x06011BD4 RID: 72660 RVA: 0x001A09BB File Offset: 0x0019EBBB
		// (set) Token: 0x06011BD5 RID: 72661 RVA: 0x001A09CF File Offset: 0x0019EBCF
		public unsafe string ChannelOpenID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_ChannelOpenID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_ChannelOpenID)), value);
			}
		}

		// Token: 0x1700457B RID: 17787
		// (get) Token: 0x06011BD6 RID: 72662 RVA: 0x001A09E4 File Offset: 0x0019EBE4
		// (set) Token: 0x06011BD7 RID: 72663 RVA: 0x001A09F8 File Offset: 0x0019EBF8
		public unsafe string Code
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_Code)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPCLoginEventRet.__PropertyOffset_Code)), value);
			}
		}

		// Token: 0x06011BD8 RID: 72664 RVA: 0x001A0A0D File Offset: 0x0019EC0D
		public FPCLoginEventRet()
		{
		}

		// Token: 0x06011BD9 RID: 72665 RVA: 0x001A0A15 File Offset: 0x0019EC15
		public FPCLoginEventRet(string Channel, int ChannelID, string ChannelOpenID, string Code)
		{
			this.Channel = Channel;
			this.ChannelID = ChannelID;
			this.ChannelOpenID = ChannelOpenID;
			this.Code = Code;
		}

		// Token: 0x06011BDA RID: 72666 RVA: 0x001A0A3A File Offset: 0x0019EC3A
		protected override IntPtr GetUStructPtr()
		{
			return FPCLoginEventRet.StaticStruct();
		}

		// Token: 0x06011BDB RID: 72667 RVA: 0x001A0A46 File Offset: 0x0019EC46
		[NullableContext(2)]
		public FPCLoginEventRet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011BDC RID: 72668 RVA: 0x001A0A50 File Offset: 0x0019EC50
		public FPCLoginEventRet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011BDD RID: 72669 RVA: 0x001A0A5B File Offset: 0x0019EC5B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPCLoginEventRet(Pointer, false, true);
		}

		// Token: 0x06011BDE RID: 72670 RVA: 0x001A0A65 File Offset: 0x0019EC65
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPCLoginEventRet(Pointer, MemoryOwner);
		}

		// Token: 0x04009854 RID: 38996
		public const string __ObjectPath = "/Script/GameMatrix.PCLoginEventRet";

		// Token: 0x04009855 RID: 38997
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009856 RID: 38998
		internal static int __PropertyOffset_Channel;

		// Token: 0x04009857 RID: 38999
		internal static int __PropertyOffset_ChannelID;

		// Token: 0x04009858 RID: 39000
		internal static int __PropertyOffset_ChannelOpenID;

		// Token: 0x04009859 RID: 39001
		internal static int __PropertyOffset_Code;
	}
}
