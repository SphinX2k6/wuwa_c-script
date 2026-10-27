using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028DF RID: 10463
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapCommand")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FTapCommand : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D05 RID: 158981 RVA: 0x003B31D7 File Offset: 0x003B13D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapCommand._ScriptStructPtr != 0) ? FTapCommand._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapCommand", ref FTapCommand._ScriptStructPtr);
		}

		// Token: 0x17009587 RID: 38279
		// (get) Token: 0x06026D06 RID: 158982 RVA: 0x003B31FB File Offset: 0x003B13FB
		// (set) Token: 0x06026D07 RID: 158983 RVA: 0x003B320F File Offset: 0x003B140F
		public unsafe string service
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_service)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_service)), value);
			}
		}

		// Token: 0x17009588 RID: 38280
		// (get) Token: 0x06026D08 RID: 158984 RVA: 0x003B3224 File Offset: 0x003B1424
		// (set) Token: 0x06026D09 RID: 158985 RVA: 0x003B3238 File Offset: 0x003B1438
		public unsafe string method
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_method)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_method)), value);
			}
		}

		// Token: 0x17009589 RID: 38281
		// (get) Token: 0x06026D0A RID: 158986 RVA: 0x003B324D File Offset: 0x003B144D
		// (set) Token: 0x06026D0B RID: 158987 RVA: 0x003B3261 File Offset: 0x003B1461
		public unsafe string args
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_args)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_args)), value);
			}
		}

		// Token: 0x1700958A RID: 38282
		// (get) Token: 0x06026D0C RID: 158988 RVA: 0x003B3276 File Offset: 0x003B1476
		// (set) Token: 0x06026D0D RID: 158989 RVA: 0x003B3286 File Offset: 0x003B1486
		public unsafe bool callback
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapCommand.__PropertyOffset_callback) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapCommand.__PropertyOffset_callback) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700958B RID: 38283
		// (get) Token: 0x06026D0E RID: 158990 RVA: 0x003B3297 File Offset: 0x003B1497
		// (set) Token: 0x06026D0F RID: 158991 RVA: 0x003B32A7 File Offset: 0x003B14A7
		public unsafe bool onceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapCommand.__PropertyOffset_onceTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapCommand.__PropertyOffset_onceTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700958C RID: 38284
		// (get) Token: 0x06026D10 RID: 158992 RVA: 0x003B32B8 File Offset: 0x003B14B8
		// (set) Token: 0x06026D11 RID: 158993 RVA: 0x003B32CC File Offset: 0x003B14CC
		public unsafe string callbackId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_callbackId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapCommand.__PropertyOffset_callbackId)), value);
			}
		}

		// Token: 0x06026D12 RID: 158994 RVA: 0x003B32E1 File Offset: 0x003B14E1
		public FTapCommand()
		{
		}

		// Token: 0x06026D13 RID: 158995 RVA: 0x003B32E9 File Offset: 0x003B14E9
		public FTapCommand(string service, string method, string args, bool callback, bool onceTime, string callbackId)
		{
			this.service = service;
			this.method = method;
			this.args = args;
			this.callback = callback;
			this.onceTime = onceTime;
			this.callbackId = callbackId;
		}

		// Token: 0x06026D14 RID: 158996 RVA: 0x003B331E File Offset: 0x003B151E
		protected override IntPtr GetUStructPtr()
		{
			return FTapCommand.StaticStruct();
		}

		// Token: 0x06026D15 RID: 158997 RVA: 0x003B332A File Offset: 0x003B152A
		[NullableContext(2)]
		public FTapCommand(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D16 RID: 158998 RVA: 0x003B3334 File Offset: 0x003B1534
		public FTapCommand(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D17 RID: 158999 RVA: 0x003B333F File Offset: 0x003B153F
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapCommand(Pointer, false, true);
		}

		// Token: 0x06026D18 RID: 159000 RVA: 0x003B3349 File Offset: 0x003B1549
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapCommand(Pointer, MemoryOwner);
		}

		// Token: 0x040154F6 RID: 87286
		public const string __ObjectPath = "/Script/TapCommon.TapCommand";

		// Token: 0x040154F7 RID: 87287
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040154F8 RID: 87288
		internal static int __PropertyOffset_service;

		// Token: 0x040154F9 RID: 87289
		internal static int __PropertyOffset_method;

		// Token: 0x040154FA RID: 87290
		internal static int __PropertyOffset_args;

		// Token: 0x040154FB RID: 87291
		internal static int __PropertyOffset_callback;

		// Token: 0x040154FC RID: 87292
		internal static int __PropertyOffset_onceTime;

		// Token: 0x040154FD RID: 87293
		internal static int __PropertyOffset_callbackId;
	}
}
