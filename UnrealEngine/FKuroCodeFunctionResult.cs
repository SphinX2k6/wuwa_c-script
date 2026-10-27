using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018C3 RID: 6339
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroCodeFunctionResult")]
	[UnrealStructLayout(904, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 904)]
	public class FKuroCodeFunctionResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060176CF RID: 95951 RVA: 0x00224218 File Offset: 0x00222418
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCodeFunctionResult._ScriptStructPtr != 0) ? FKuroCodeFunctionResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroCodeFunctionResult", ref FKuroCodeFunctionResult._ScriptStructPtr);
		}

		// Token: 0x17005E99 RID: 24217
		// (get) Token: 0x060176D0 RID: 95952 RVA: 0x0022423C File Offset: 0x0022243C
		// (set) Token: 0x060176D1 RID: 95953 RVA: 0x0022424C File Offset: 0x0022244C
		public unsafe bool Success
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCodeFunctionResult.__PropertyOffset_Success) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCodeFunctionResult.__PropertyOffset_Success) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005E9A RID: 24218
		// (get) Token: 0x060176D2 RID: 95954 RVA: 0x0022425D File Offset: 0x0022245D
		// (set) Token: 0x060176D3 RID: 95955 RVA: 0x00224271 File Offset: 0x00222471
		public unsafe string ErrorMessage
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCodeFunctionResult.__PropertyOffset_ErrorMessage)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroCodeFunctionResult.__PropertyOffset_ErrorMessage)), value);
			}
		}

		// Token: 0x17005E9B RID: 24219
		// (get) Token: 0x060176D4 RID: 95956 RVA: 0x00224288 File Offset: 0x00222488
		// (set) Token: 0x060176D5 RID: 95957 RVA: 0x002242CB File Offset: 0x002224CB
		public FKuroCodeFunctionPayload Values
		{
			get
			{
				base.FastCheckIsValid();
				FKuroCodeFunctionPayload result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new FKuroCodeFunctionPayload(base.NativePtr + (IntPtr)FKuroCodeFunctionResult.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroCodeFunctionPayload.StaticStruct(), base.NativePtr + (IntPtr)FKuroCodeFunctionResult.__PropertyOffset_Values, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060176D6 RID: 95958 RVA: 0x002242EC File Offset: 0x002224EC
		public FKuroCodeFunctionResult()
		{
		}

		// Token: 0x060176D7 RID: 95959 RVA: 0x002242F4 File Offset: 0x002224F4
		public FKuroCodeFunctionResult(bool Success, string ErrorMessage, FKuroCodeFunctionPayload Values)
		{
			this.Success = Success;
			this.ErrorMessage = ErrorMessage;
			this.Values = Values;
		}

		// Token: 0x060176D8 RID: 95960 RVA: 0x00224311 File Offset: 0x00222511
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCodeFunctionResult.StaticStruct();
		}

		// Token: 0x060176D9 RID: 95961 RVA: 0x0022431D File Offset: 0x0022251D
		[NullableContext(2)]
		public FKuroCodeFunctionResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060176DA RID: 95962 RVA: 0x00224327 File Offset: 0x00222527
		public FKuroCodeFunctionResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060176DB RID: 95963 RVA: 0x00224332 File Offset: 0x00222532
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCodeFunctionResult(Pointer, false, true);
		}

		// Token: 0x060176DC RID: 95964 RVA: 0x0022433C File Offset: 0x0022253C
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCodeFunctionResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400CBDD RID: 52189
		public const string __ObjectPath = "/Script/KuroGameplay.KuroCodeFunctionResult";

		// Token: 0x0400CBDE RID: 52190
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400CBDF RID: 52191
		internal static int __PropertyOffset_Success;

		// Token: 0x0400CBE0 RID: 52192
		internal static int __PropertyOffset_ErrorMessage;

		// Token: 0x0400CBE1 RID: 52193
		internal static int __PropertyOffset_Values;

		// Token: 0x0400CBE2 RID: 52194
		[Nullable(2)]
		private FKuroCodeFunctionPayload _Values;
	}
}
