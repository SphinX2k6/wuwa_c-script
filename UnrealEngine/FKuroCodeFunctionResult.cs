using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003DE RID: 990
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroCodeFunctionResult")]
	[UnrealStructLayout(904, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 904)]
	public class FKuroCodeFunctionResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06006149 RID: 24905 RVA: 0x0008B1AD File Offset: 0x000893AD
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCodeFunctionResult._ScriptStructPtr != 0) ? FKuroCodeFunctionResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroGameplay.KuroCodeFunctionResult", ref FKuroCodeFunctionResult._ScriptStructPtr);
		}

		// Token: 0x170013D1 RID: 5073
		// (get) Token: 0x0600614A RID: 24906 RVA: 0x0008B1D1 File Offset: 0x000893D1
		// (set) Token: 0x0600614B RID: 24907 RVA: 0x0008B1E1 File Offset: 0x000893E1
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

		// Token: 0x170013D2 RID: 5074
		// (get) Token: 0x0600614C RID: 24908 RVA: 0x0008B1F2 File Offset: 0x000893F2
		// (set) Token: 0x0600614D RID: 24909 RVA: 0x0008B206 File Offset: 0x00089406
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

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x0600614E RID: 24910 RVA: 0x0008B21C File Offset: 0x0008941C
		// (set) Token: 0x0600614F RID: 24911 RVA: 0x0008B25F File Offset: 0x0008945F
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

		// Token: 0x06006150 RID: 24912 RVA: 0x0008B280 File Offset: 0x00089480
		public FKuroCodeFunctionResult()
		{
		}

		// Token: 0x06006151 RID: 24913 RVA: 0x0008B288 File Offset: 0x00089488
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCodeFunctionResult.StaticStruct();
		}

		// Token: 0x06006152 RID: 24914 RVA: 0x0008B294 File Offset: 0x00089494
		[NullableContext(2)]
		public FKuroCodeFunctionResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06006153 RID: 24915 RVA: 0x0008B29E File Offset: 0x0008949E
		public FKuroCodeFunctionResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06006154 RID: 24916 RVA: 0x0008B2A9 File Offset: 0x000894A9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCodeFunctionResult(Pointer, false, true);
		}

		// Token: 0x06006155 RID: 24917 RVA: 0x0008B2B3 File Offset: 0x000894B3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCodeFunctionResult(Pointer, MemoryOwner);
		}

		// Token: 0x0400297E RID: 10622
		public const string __ObjectPath = "/Script/KuroGameplay.KuroCodeFunctionResult";

		// Token: 0x0400297F RID: 10623
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04002980 RID: 10624
		internal static int __PropertyOffset_Success;

		// Token: 0x04002981 RID: 10625
		internal static int __PropertyOffset_ErrorMessage;

		// Token: 0x04002982 RID: 10626
		internal static int __PropertyOffset_Values;

		// Token: 0x04002983 RID: 10627
		[Nullable(2)]
		private FKuroCodeFunctionPayload _Values;
	}
}
