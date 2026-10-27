using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001217 RID: 4631
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.URL")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 104)]
	public class FURL : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060110BC RID: 69820 RVA: 0x00190356 File Offset: 0x0018E556
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FURL._ScriptStructPtr != 0) ? FURL._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.URL", ref FURL._ScriptStructPtr);
		}

		// Token: 0x17004289 RID: 17033
		// (get) Token: 0x060110BD RID: 69821 RVA: 0x0019037A File Offset: 0x0018E57A
		// (set) Token: 0x060110BE RID: 69822 RVA: 0x0019038E File Offset: 0x0018E58E
		public unsafe string Protocol
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Protocol)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Protocol)), value);
			}
		}

		// Token: 0x1700428A RID: 17034
		// (get) Token: 0x060110BF RID: 69823 RVA: 0x001903A3 File Offset: 0x0018E5A3
		// (set) Token: 0x060110C0 RID: 69824 RVA: 0x001903B7 File Offset: 0x0018E5B7
		public unsafe string Host
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Host)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Host)), value);
			}
		}

		// Token: 0x1700428B RID: 17035
		// (get) Token: 0x060110C1 RID: 69825 RVA: 0x001903CC File Offset: 0x0018E5CC
		// (set) Token: 0x060110C2 RID: 69826 RVA: 0x001903DC File Offset: 0x0018E5DC
		public unsafe int Port
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FURL.__PropertyOffset_Port);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FURL.__PropertyOffset_Port) = value;
			}
		}

		// Token: 0x1700428C RID: 17036
		// (get) Token: 0x060110C3 RID: 69827 RVA: 0x001903ED File Offset: 0x0018E5ED
		// (set) Token: 0x060110C4 RID: 69828 RVA: 0x001903FD File Offset: 0x0018E5FD
		public unsafe int Valid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FURL.__PropertyOffset_Valid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FURL.__PropertyOffset_Valid) = value;
			}
		}

		// Token: 0x1700428D RID: 17037
		// (get) Token: 0x060110C5 RID: 69829 RVA: 0x0019040E File Offset: 0x0018E60E
		// (set) Token: 0x060110C6 RID: 69830 RVA: 0x00190422 File Offset: 0x0018E622
		public unsafe string Map
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Map)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Map)), value);
			}
		}

		// Token: 0x1700428E RID: 17038
		// (get) Token: 0x060110C7 RID: 69831 RVA: 0x00190437 File Offset: 0x0018E637
		// (set) Token: 0x060110C8 RID: 69832 RVA: 0x0019044B File Offset: 0x0018E64B
		public unsafe string RedirectURL
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_RedirectURL)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_RedirectURL)), value);
			}
		}

		// Token: 0x1700428F RID: 17039
		// (get) Token: 0x060110C9 RID: 69833 RVA: 0x00190460 File Offset: 0x0018E660
		// (set) Token: 0x060110CA RID: 69834 RVA: 0x001904A3 File Offset: 0x0018E6A3
		public TArray<string> Op
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._Op) == null)
				{
					result = (this._Op = new TArray<string>(base.NativePtr + (IntPtr)FURL.__PropertyOffset_Op, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Op.CopyAssign(value);
			}
		}

		// Token: 0x17004290 RID: 17040
		// (get) Token: 0x060110CB RID: 69835 RVA: 0x001904B1 File Offset: 0x0018E6B1
		// (set) Token: 0x060110CC RID: 69836 RVA: 0x001904C5 File Offset: 0x0018E6C5
		public unsafe string Portal
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Portal)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FURL.__PropertyOffset_Portal)), value);
			}
		}

		// Token: 0x060110CD RID: 69837 RVA: 0x001904DA File Offset: 0x0018E6DA
		public FURL()
		{
		}

		// Token: 0x060110CE RID: 69838 RVA: 0x001904E4 File Offset: 0x0018E6E4
		public FURL(string Protocol, string Host, int Port, int Valid, string Map, string RedirectURL, TArray<string> Op, string Portal)
		{
			this.Protocol = Protocol;
			this.Host = Host;
			this.Port = Port;
			this.Valid = Valid;
			this.Map = Map;
			this.RedirectURL = RedirectURL;
			this.Op = Op;
			this.Portal = Portal;
		}

		// Token: 0x060110CF RID: 69839 RVA: 0x00190534 File Offset: 0x0018E734
		protected override IntPtr GetUStructPtr()
		{
			return FURL.StaticStruct();
		}

		// Token: 0x060110D0 RID: 69840 RVA: 0x00190540 File Offset: 0x0018E740
		[NullableContext(2)]
		public FURL(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060110D1 RID: 69841 RVA: 0x0019054A File Offset: 0x0018E74A
		public FURL(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060110D2 RID: 69842 RVA: 0x00190555 File Offset: 0x0018E755
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FURL(Pointer, false, true);
		}

		// Token: 0x060110D3 RID: 69843 RVA: 0x0019055F File Offset: 0x0018E75F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FURL(Pointer, MemoryOwner);
		}

		// Token: 0x04009200 RID: 37376
		public const string __ObjectPath = "/Script/Engine.URL";

		// Token: 0x04009201 RID: 37377
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009202 RID: 37378
		internal static int __PropertyOffset_Protocol;

		// Token: 0x04009203 RID: 37379
		internal static int __PropertyOffset_Host;

		// Token: 0x04009204 RID: 37380
		internal static int __PropertyOffset_Port;

		// Token: 0x04009205 RID: 37381
		internal static int __PropertyOffset_Valid;

		// Token: 0x04009206 RID: 37382
		internal static int __PropertyOffset_Map;

		// Token: 0x04009207 RID: 37383
		internal static int __PropertyOffset_RedirectURL;

		// Token: 0x04009208 RID: 37384
		internal static int __PropertyOffset_Op;

		// Token: 0x04009209 RID: 37385
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _Op;

		// Token: 0x0400920A RID: 37386
		internal static int __PropertyOffset_Portal;
	}
}
