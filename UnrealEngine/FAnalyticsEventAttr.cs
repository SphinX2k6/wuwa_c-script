using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020002A6 RID: 678
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AnalyticsBlueprintLibrary.AnalyticsEventAttr")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FAnalyticsEventAttr : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06002575 RID: 9589 RVA: 0x00038933 File Offset: 0x00036B33
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnalyticsEventAttr._ScriptStructPtr != 0) ? FAnalyticsEventAttr._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AnalyticsBlueprintLibrary.AnalyticsEventAttr", ref FAnalyticsEventAttr._ScriptStructPtr);
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x06002576 RID: 9590 RVA: 0x00038957 File Offset: 0x00036B57
		// (set) Token: 0x06002577 RID: 9591 RVA: 0x0003896B File Offset: 0x00036B6B
		public unsafe string Name
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAnalyticsEventAttr.__PropertyOffset_Name)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAnalyticsEventAttr.__PropertyOffset_Name)), value);
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x06002578 RID: 9592 RVA: 0x00038980 File Offset: 0x00036B80
		// (set) Token: 0x06002579 RID: 9593 RVA: 0x00038994 File Offset: 0x00036B94
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FAnalyticsEventAttr.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FAnalyticsEventAttr.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000389A9 File Offset: 0x00036BA9
		public FAnalyticsEventAttr()
		{
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000389B1 File Offset: 0x00036BB1
		public FAnalyticsEventAttr(string Name, string Value)
		{
			this.Name = Name;
			this.Value = Value;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000389C7 File Offset: 0x00036BC7
		protected override IntPtr GetUStructPtr()
		{
			return FAnalyticsEventAttr.StaticStruct();
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000389D3 File Offset: 0x00036BD3
		[NullableContext(2)]
		public FAnalyticsEventAttr(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000389DD File Offset: 0x00036BDD
		public FAnalyticsEventAttr(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000389E8 File Offset: 0x00036BE8
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnalyticsEventAttr(Pointer, false, true);
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000389F2 File Offset: 0x00036BF2
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnalyticsEventAttr(Pointer, MemoryOwner);
		}

		// Token: 0x04000E69 RID: 3689
		public const string __ObjectPath = "/Script/AnalyticsBlueprintLibrary.AnalyticsEventAttr";

		// Token: 0x04000E6A RID: 3690
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04000E6B RID: 3691
		internal static int __PropertyOffset_Name;

		// Token: 0x04000E6C RID: 3692
		internal static int __PropertyOffset_Value;
	}
}
