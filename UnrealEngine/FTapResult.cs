using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028E7 RID: 10471
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TapCommon.TapResult")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FTapResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026D67 RID: 159079 RVA: 0x003B3ACA File Offset: 0x003B1CCA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTapResult._ScriptStructPtr != 0) ? FTapResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TapCommon.TapResult", ref FTapResult._ScriptStructPtr);
		}

		// Token: 0x17009599 RID: 38297
		// (get) Token: 0x06026D68 RID: 159080 RVA: 0x003B3AEE File Offset: 0x003B1CEE
		// (set) Token: 0x06026D69 RID: 159081 RVA: 0x003B3B02 File Offset: 0x003B1D02
		public unsafe string callbackId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_callbackId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_callbackId)), value);
			}
		}

		// Token: 0x1700959A RID: 38298
		// (get) Token: 0x06026D6A RID: 159082 RVA: 0x003B3B17 File Offset: 0x003B1D17
		// (set) Token: 0x06026D6B RID: 159083 RVA: 0x003B3B2B File Offset: 0x003B1D2B
		public unsafe string content
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_content)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_content)), value);
			}
		}

		// Token: 0x1700959B RID: 38299
		// (get) Token: 0x06026D6C RID: 159084 RVA: 0x003B3B40 File Offset: 0x003B1D40
		// (set) Token: 0x06026D6D RID: 159085 RVA: 0x003B3B54 File Offset: 0x003B1D54
		public unsafe string message
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_message)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTapResult.__PropertyOffset_message)), value);
			}
		}

		// Token: 0x1700959C RID: 38300
		// (get) Token: 0x06026D6E RID: 159086 RVA: 0x003B3B69 File Offset: 0x003B1D69
		// (set) Token: 0x06026D6F RID: 159087 RVA: 0x003B3B79 File Offset: 0x003B1D79
		public unsafe int code
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapResult.__PropertyOffset_code);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapResult.__PropertyOffset_code) = value;
			}
		}

		// Token: 0x1700959D RID: 38301
		// (get) Token: 0x06026D70 RID: 159088 RVA: 0x003B3B8A File Offset: 0x003B1D8A
		// (set) Token: 0x06026D71 RID: 159089 RVA: 0x003B3B9A File Offset: 0x003B1D9A
		public unsafe bool onceTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTapResult.__PropertyOffset_onceTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTapResult.__PropertyOffset_onceTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x06026D72 RID: 159090 RVA: 0x003B3BAB File Offset: 0x003B1DAB
		public FTapResult()
		{
		}

		// Token: 0x06026D73 RID: 159091 RVA: 0x003B3BB3 File Offset: 0x003B1DB3
		public FTapResult(string callbackId, string content, string message, int code, bool onceTime)
		{
			this.callbackId = callbackId;
			this.content = content;
			this.message = message;
			this.code = code;
			this.onceTime = onceTime;
		}

		// Token: 0x06026D74 RID: 159092 RVA: 0x003B3BE0 File Offset: 0x003B1DE0
		protected override IntPtr GetUStructPtr()
		{
			return FTapResult.StaticStruct();
		}

		// Token: 0x06026D75 RID: 159093 RVA: 0x003B3BEC File Offset: 0x003B1DEC
		[NullableContext(2)]
		public FTapResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026D76 RID: 159094 RVA: 0x003B3BF6 File Offset: 0x003B1DF6
		public FTapResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026D77 RID: 159095 RVA: 0x003B3C01 File Offset: 0x003B1E01
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTapResult(Pointer, false, true);
		}

		// Token: 0x06026D78 RID: 159096 RVA: 0x003B3C0B File Offset: 0x003B1E0B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTapResult(Pointer, MemoryOwner);
		}

		// Token: 0x04015521 RID: 87329
		public const string __ObjectPath = "/Script/TapCommon.TapResult";

		// Token: 0x04015522 RID: 87330
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04015523 RID: 87331
		internal static int __PropertyOffset_callbackId;

		// Token: 0x04015524 RID: 87332
		internal static int __PropertyOffset_content;

		// Token: 0x04015525 RID: 87333
		internal static int __PropertyOffset_message;

		// Token: 0x04015526 RID: 87334
		internal static int __PropertyOffset_code;

		// Token: 0x04015527 RID: 87335
		internal static int __PropertyOffset_onceTime;
	}
}
