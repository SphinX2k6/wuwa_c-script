using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001059 RID: 4185
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PurchaseInfo")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 64)]
	public class FPurchaseInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EE12 RID: 60946 RVA: 0x001614B0 File Offset: 0x0015F6B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPurchaseInfo._ScriptStructPtr != 0) ? FPurchaseInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PurchaseInfo", ref FPurchaseInfo._ScriptStructPtr);
		}

		// Token: 0x1700399F RID: 14751
		// (get) Token: 0x0600EE13 RID: 60947 RVA: 0x001614D4 File Offset: 0x0015F6D4
		// (set) Token: 0x0600EE14 RID: 60948 RVA: 0x001614E8 File Offset: 0x0015F6E8
		public unsafe string Identifier
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_Identifier)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_Identifier)), value);
			}
		}

		// Token: 0x170039A0 RID: 14752
		// (get) Token: 0x0600EE15 RID: 60949 RVA: 0x001614FD File Offset: 0x0015F6FD
		// (set) Token: 0x0600EE16 RID: 60950 RVA: 0x00161511 File Offset: 0x0015F711
		public unsafe string DisplayName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayName)), value);
			}
		}

		// Token: 0x170039A1 RID: 14753
		// (get) Token: 0x0600EE17 RID: 60951 RVA: 0x00161526 File Offset: 0x0015F726
		// (set) Token: 0x0600EE18 RID: 60952 RVA: 0x0016153A File Offset: 0x0015F73A
		public unsafe string DisplayDescription
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayDescription)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayDescription)), value);
			}
		}

		// Token: 0x170039A2 RID: 14754
		// (get) Token: 0x0600EE19 RID: 60953 RVA: 0x0016154F File Offset: 0x0015F74F
		// (set) Token: 0x0600EE1A RID: 60954 RVA: 0x00161563 File Offset: 0x0015F763
		public unsafe string DisplayPrice
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayPrice)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FPurchaseInfo.__PropertyOffset_DisplayPrice)), value);
			}
		}

		// Token: 0x0600EE1B RID: 60955 RVA: 0x00161578 File Offset: 0x0015F778
		public FPurchaseInfo()
		{
		}

		// Token: 0x0600EE1C RID: 60956 RVA: 0x00161580 File Offset: 0x0015F780
		public FPurchaseInfo(string Identifier, string DisplayName, string DisplayDescription, string DisplayPrice)
		{
			this.Identifier = Identifier;
			this.DisplayName = DisplayName;
			this.DisplayDescription = DisplayDescription;
			this.DisplayPrice = DisplayPrice;
		}

		// Token: 0x0600EE1D RID: 60957 RVA: 0x001615A5 File Offset: 0x0015F7A5
		protected override IntPtr GetUStructPtr()
		{
			return FPurchaseInfo.StaticStruct();
		}

		// Token: 0x0600EE1E RID: 60958 RVA: 0x001615B1 File Offset: 0x0015F7B1
		[NullableContext(2)]
		public FPurchaseInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EE1F RID: 60959 RVA: 0x001615BB File Offset: 0x0015F7BB
		public FPurchaseInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EE20 RID: 60960 RVA: 0x001615C6 File Offset: 0x0015F7C6
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPurchaseInfo(Pointer, false, true);
		}

		// Token: 0x0600EE21 RID: 60961 RVA: 0x001615D0 File Offset: 0x0015F7D0
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPurchaseInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040080EA RID: 33002
		public const string __ObjectPath = "/Script/Engine.PurchaseInfo";

		// Token: 0x040080EB RID: 33003
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040080EC RID: 33004
		internal static int __PropertyOffset_Identifier;

		// Token: 0x040080ED RID: 33005
		internal static int __PropertyOffset_DisplayName;

		// Token: 0x040080EE RID: 33006
		internal static int __PropertyOffset_DisplayDescription;

		// Token: 0x040080EF RID: 33007
		internal static int __PropertyOffset_DisplayPrice;
	}
}
