using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000625 RID: 1573
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxTokenAndSignatureResult")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FXboxTokenAndSignatureResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600897F RID: 35199 RVA: 0x000CF49C File Offset: 0x000CD69C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxTokenAndSignatureResult._ScriptStructPtr != 0) ? FXboxTokenAndSignatureResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxTokenAndSignatureResult", ref FXboxTokenAndSignatureResult._ScriptStructPtr);
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x06008980 RID: 35200 RVA: 0x000CF4C0 File Offset: 0x000CD6C0
		// (set) Token: 0x06008981 RID: 35201 RVA: 0x000CF4D0 File Offset: 0x000CD6D0
		public unsafe bool bSuccess
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_bSuccess) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_bSuccess) = (value ? 1 : 0);
			}
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x06008982 RID: 35202 RVA: 0x000CF4E1 File Offset: 0x000CD6E1
		// (set) Token: 0x06008983 RID: 35203 RVA: 0x000CF4F5 File Offset: 0x000CD6F5
		public unsafe string Token
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_Token)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_Token)), value);
			}
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x06008984 RID: 35204 RVA: 0x000CF50A File Offset: 0x000CD70A
		// (set) Token: 0x06008985 RID: 35205 RVA: 0x000CF51E File Offset: 0x000CD71E
		public unsafe string Signature
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_Signature)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FXboxTokenAndSignatureResult.__PropertyOffset_Signature)), value);
			}
		}

		// Token: 0x06008986 RID: 35206 RVA: 0x000CF533 File Offset: 0x000CD733
		public FXboxTokenAndSignatureResult()
		{
		}

		// Token: 0x06008987 RID: 35207 RVA: 0x000CF53B File Offset: 0x000CD73B
		protected override IntPtr GetUStructPtr()
		{
			return FXboxTokenAndSignatureResult.StaticStruct();
		}

		// Token: 0x06008988 RID: 35208 RVA: 0x000CF547 File Offset: 0x000CD747
		[NullableContext(2)]
		public FXboxTokenAndSignatureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06008989 RID: 35209 RVA: 0x000CF551 File Offset: 0x000CD751
		public FXboxTokenAndSignatureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600898A RID: 35210 RVA: 0x000CF55C File Offset: 0x000CD75C
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxTokenAndSignatureResult(Pointer, false, true);
		}

		// Token: 0x0600898B RID: 35211 RVA: 0x000CF566 File Offset: 0x000CD766
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxTokenAndSignatureResult(Pointer, MemoryOwner);
		}

		// Token: 0x04003BAB RID: 15275
		public const string __ObjectPath = "/Script/KuroUtility.XboxTokenAndSignatureResult";

		// Token: 0x04003BAC RID: 15276
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003BAD RID: 15277
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x04003BAE RID: 15278
		internal static int __PropertyOffset_Token;

		// Token: 0x04003BAF RID: 15279
		internal static int __PropertyOffset_Signature;
	}
}
