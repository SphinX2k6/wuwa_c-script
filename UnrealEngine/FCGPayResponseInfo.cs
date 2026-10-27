using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020012E0 RID: 4832
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GameMatrix.CGPayResponseInfo")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 120)]
	public class FCGPayResponseInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06011B34 RID: 72500 RVA: 0x0019FCFA File Offset: 0x0019DEFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FCGPayResponseInfo._ScriptStructPtr != 0) ? FCGPayResponseInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GameMatrix.CGPayResponseInfo", ref FCGPayResponseInfo._ScriptStructPtr);
		}

		// Token: 0x17004545 RID: 17733
		// (get) Token: 0x06011B35 RID: 72501 RVA: 0x0019FD1E File Offset: 0x0019DF1E
		// (set) Token: 0x06011B36 RID: 72502 RVA: 0x0019FD2E File Offset: 0x0019DF2E
		public unsafe int resultCode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FCGPayResponseInfo.__PropertyOffset_resultCode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FCGPayResponseInfo.__PropertyOffset_resultCode) = value;
			}
		}

		// Token: 0x17004546 RID: 17734
		// (get) Token: 0x06011B37 RID: 72503 RVA: 0x0019FD3F File Offset: 0x0019DF3F
		// (set) Token: 0x06011B38 RID: 72504 RVA: 0x0019FD53 File Offset: 0x0019DF53
		public unsafe string resultInnerCode
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_resultInnerCode)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_resultInnerCode)), value);
			}
		}

		// Token: 0x17004547 RID: 17735
		// (get) Token: 0x06011B39 RID: 72505 RVA: 0x0019FD68 File Offset: 0x0019DF68
		// (set) Token: 0x06011B3A RID: 72506 RVA: 0x0019FD7C File Offset: 0x0019DF7C
		public unsafe string payChannel
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_payChannel)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_payChannel)), value);
			}
		}

		// Token: 0x17004548 RID: 17736
		// (get) Token: 0x06011B3B RID: 72507 RVA: 0x0019FD91 File Offset: 0x0019DF91
		// (set) Token: 0x06011B3C RID: 72508 RVA: 0x0019FDA5 File Offset: 0x0019DFA5
		public unsafe string resultMsg
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_resultMsg)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_resultMsg)), value);
			}
		}

		// Token: 0x17004549 RID: 17737
		// (get) Token: 0x06011B3D RID: 72509 RVA: 0x0019FDBA File Offset: 0x0019DFBA
		// (set) Token: 0x06011B3E RID: 72510 RVA: 0x0019FDCE File Offset: 0x0019DFCE
		public unsafe string respString
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_respString)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_respString)), value);
			}
		}

		// Token: 0x1700454A RID: 17738
		// (get) Token: 0x06011B3F RID: 72511 RVA: 0x0019FDE3 File Offset: 0x0019DFE3
		// (set) Token: 0x06011B40 RID: 72512 RVA: 0x0019FDF7 File Offset: 0x0019DFF7
		public unsafe string successProductIds
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_successProductIds)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_successProductIds)), value);
			}
		}

		// Token: 0x1700454B RID: 17739
		// (get) Token: 0x06011B41 RID: 72513 RVA: 0x0019FE0C File Offset: 0x0019E00C
		// (set) Token: 0x06011B42 RID: 72514 RVA: 0x0019FE20 File Offset: 0x0019E020
		public unsafe string failedProductIds
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_failedProductIds)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_failedProductIds)), value);
			}
		}

		// Token: 0x1700454C RID: 17740
		// (get) Token: 0x06011B43 RID: 72515 RVA: 0x0019FE35 File Offset: 0x0019E035
		// (set) Token: 0x06011B44 RID: 72516 RVA: 0x0019FE49 File Offset: 0x0019E049
		public unsafe string appExtends
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_appExtends)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FCGPayResponseInfo.__PropertyOffset_appExtends)), value);
			}
		}

		// Token: 0x06011B45 RID: 72517 RVA: 0x0019FE5E File Offset: 0x0019E05E
		public FCGPayResponseInfo()
		{
		}

		// Token: 0x06011B46 RID: 72518 RVA: 0x0019FE68 File Offset: 0x0019E068
		public FCGPayResponseInfo(int resultCode, string resultInnerCode, string payChannel, string resultMsg, string respString, string successProductIds, string failedProductIds, string appExtends)
		{
			this.resultCode = resultCode;
			this.resultInnerCode = resultInnerCode;
			this.payChannel = payChannel;
			this.resultMsg = resultMsg;
			this.respString = respString;
			this.successProductIds = successProductIds;
			this.failedProductIds = failedProductIds;
			this.appExtends = appExtends;
		}

		// Token: 0x06011B47 RID: 72519 RVA: 0x0019FEB8 File Offset: 0x0019E0B8
		protected override IntPtr GetUStructPtr()
		{
			return FCGPayResponseInfo.StaticStruct();
		}

		// Token: 0x06011B48 RID: 72520 RVA: 0x0019FEC4 File Offset: 0x0019E0C4
		[NullableContext(2)]
		public FCGPayResponseInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06011B49 RID: 72521 RVA: 0x0019FECE File Offset: 0x0019E0CE
		public FCGPayResponseInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06011B4A RID: 72522 RVA: 0x0019FED9 File Offset: 0x0019E0D9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FCGPayResponseInfo(Pointer, false, true);
		}

		// Token: 0x06011B4B RID: 72523 RVA: 0x0019FEE3 File Offset: 0x0019E0E3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FCGPayResponseInfo(Pointer, MemoryOwner);
		}

		// Token: 0x04009809 RID: 38921
		public const string __ObjectPath = "/Script/GameMatrix.CGPayResponseInfo";

		// Token: 0x0400980A RID: 38922
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400980B RID: 38923
		internal static int __PropertyOffset_resultCode;

		// Token: 0x0400980C RID: 38924
		internal static int __PropertyOffset_resultInnerCode;

		// Token: 0x0400980D RID: 38925
		internal static int __PropertyOffset_payChannel;

		// Token: 0x0400980E RID: 38926
		internal static int __PropertyOffset_resultMsg;

		// Token: 0x0400980F RID: 38927
		internal static int __PropertyOffset_respString;

		// Token: 0x04009810 RID: 38928
		internal static int __PropertyOffset_successProductIds;

		// Token: 0x04009811 RID: 38929
		internal static int __PropertyOffset_failedProductIds;

		// Token: 0x04009812 RID: 38930
		internal static int __PropertyOffset_appExtends;
	}
}
