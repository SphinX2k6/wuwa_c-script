using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020000F7 RID: 247
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/AIModule.AIRequestID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FAIRequestID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001346 RID: 4934 RVA: 0x0001C7B3 File Offset: 0x0001A9B3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAIRequestID._ScriptStructPtr != 0) ? FAIRequestID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AIModule.AIRequestID", ref FAIRequestID._ScriptStructPtr);
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001347 RID: 4935 RVA: 0x0001C7D7 File Offset: 0x0001A9D7
		// (set) Token: 0x06001348 RID: 4936 RVA: 0x0001C7E7 File Offset: 0x0001A9E7
		public unsafe uint RequestID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAIRequestID.__PropertyOffset_RequestID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAIRequestID.__PropertyOffset_RequestID) = (int)value;
			}
		}

		// Token: 0x06001349 RID: 4937 RVA: 0x0001C7F8 File Offset: 0x0001A9F8
		public FAIRequestID()
		{
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x0001C800 File Offset: 0x0001AA00
		public FAIRequestID(uint RequestID)
		{
			this.RequestID = RequestID;
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0001C80F File Offset: 0x0001AA0F
		protected override IntPtr GetUStructPtr()
		{
			return FAIRequestID.StaticStruct();
		}

		// Token: 0x0600134C RID: 4940 RVA: 0x0001C81B File Offset: 0x0001AA1B
		[NullableContext(2)]
		public FAIRequestID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x0001C825 File Offset: 0x0001AA25
		public FAIRequestID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x0001C830 File Offset: 0x0001AA30
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAIRequestID(Pointer, false, true);
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x0001C83A File Offset: 0x0001AA3A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAIRequestID(Pointer, MemoryOwner);
		}

		// Token: 0x04000379 RID: 889
		[Nullable(1)]
		public const string __ObjectPath = "/Script/AIModule.AIRequestID";

		// Token: 0x0400037A RID: 890
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400037B RID: 891
		internal static int __PropertyOffset_RequestID;
	}
}
