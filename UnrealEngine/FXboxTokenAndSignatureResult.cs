using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001F1B RID: 7963
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroUtility.XboxTokenAndSignatureResult")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FXboxTokenAndSignatureResult : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601E374 RID: 123764 RVA: 0x002CEA68 File Offset: 0x002CCC68
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FXboxTokenAndSignatureResult._ScriptStructPtr != 0) ? FXboxTokenAndSignatureResult._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroUtility.XboxTokenAndSignatureResult", ref FXboxTokenAndSignatureResult._ScriptStructPtr);
		}

		// Token: 0x17007801 RID: 30721
		// (get) Token: 0x0601E375 RID: 123765 RVA: 0x002CEA8C File Offset: 0x002CCC8C
		// (set) Token: 0x0601E376 RID: 123766 RVA: 0x002CEA9C File Offset: 0x002CCC9C
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

		// Token: 0x17007802 RID: 30722
		// (get) Token: 0x0601E377 RID: 123767 RVA: 0x002CEAAD File Offset: 0x002CCCAD
		// (set) Token: 0x0601E378 RID: 123768 RVA: 0x002CEAC1 File Offset: 0x002CCCC1
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

		// Token: 0x17007803 RID: 30723
		// (get) Token: 0x0601E379 RID: 123769 RVA: 0x002CEAD6 File Offset: 0x002CCCD6
		// (set) Token: 0x0601E37A RID: 123770 RVA: 0x002CEAEA File Offset: 0x002CCCEA
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

		// Token: 0x0601E37B RID: 123771 RVA: 0x002CEAFF File Offset: 0x002CCCFF
		public FXboxTokenAndSignatureResult()
		{
		}

		// Token: 0x0601E37C RID: 123772 RVA: 0x002CEB07 File Offset: 0x002CCD07
		public FXboxTokenAndSignatureResult(bool bSuccess, string Token, string Signature)
		{
			this.bSuccess = bSuccess;
			this.Token = Token;
			this.Signature = Signature;
		}

		// Token: 0x0601E37D RID: 123773 RVA: 0x002CEB24 File Offset: 0x002CCD24
		protected override IntPtr GetUStructPtr()
		{
			return FXboxTokenAndSignatureResult.StaticStruct();
		}

		// Token: 0x0601E37E RID: 123774 RVA: 0x002CEB30 File Offset: 0x002CCD30
		[NullableContext(2)]
		public FXboxTokenAndSignatureResult(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601E37F RID: 123775 RVA: 0x002CEB3A File Offset: 0x002CCD3A
		public FXboxTokenAndSignatureResult(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601E380 RID: 123776 RVA: 0x002CEB45 File Offset: 0x002CCD45
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FXboxTokenAndSignatureResult(Pointer, false, true);
		}

		// Token: 0x0601E381 RID: 123777 RVA: 0x002CEB4F File Offset: 0x002CCD4F
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FXboxTokenAndSignatureResult(Pointer, MemoryOwner);
		}

		// Token: 0x040104E8 RID: 66792
		public const string __ObjectPath = "/Script/KuroUtility.XboxTokenAndSignatureResult";

		// Token: 0x040104E9 RID: 66793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040104EA RID: 66794
		internal static int __PropertyOffset_bSuccess;

		// Token: 0x040104EB RID: 66795
		internal static int __PropertyOffset_Token;

		// Token: 0x040104EC RID: 66796
		internal static int __PropertyOffset_Signature;
	}
}
