using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020028FA RID: 10490
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/TASdkPlugin.SingleEvent")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSingleEvent : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026E7D RID: 159357 RVA: 0x003B5A0A File Offset: 0x003B3C0A
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSingleEvent._ScriptStructPtr != 0) ? FSingleEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/TASdkPlugin.SingleEvent", ref FSingleEvent._ScriptStructPtr);
		}

		// Token: 0x170095E4 RID: 38372
		// (get) Token: 0x06026E7E RID: 159358 RVA: 0x003B5A30 File Offset: 0x003B3C30
		// (set) Token: 0x06026E7F RID: 159359 RVA: 0x003B5A73 File Offset: 0x003B3C73
		public TArray<byte> Utf8StringCode
		{
			get
			{
				base.FastCheckIsValid();
				TArray<byte> result;
				if ((result = this._Utf8StringCode) == null)
				{
					result = (this._Utf8StringCode = new TArray<byte>(base.NativePtr + (IntPtr)FSingleEvent.__PropertyOffset_Utf8StringCode, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Utf8StringCode.CopyAssign(value);
			}
		}

		// Token: 0x06026E80 RID: 159360 RVA: 0x003B5A81 File Offset: 0x003B3C81
		public FSingleEvent()
		{
		}

		// Token: 0x06026E81 RID: 159361 RVA: 0x003B5A89 File Offset: 0x003B3C89
		public FSingleEvent(TArray<byte> Utf8StringCode)
		{
			this.Utf8StringCode = Utf8StringCode;
		}

		// Token: 0x06026E82 RID: 159362 RVA: 0x003B5A98 File Offset: 0x003B3C98
		protected override IntPtr GetUStructPtr()
		{
			return FSingleEvent.StaticStruct();
		}

		// Token: 0x06026E83 RID: 159363 RVA: 0x003B5AA4 File Offset: 0x003B3CA4
		[NullableContext(2)]
		public FSingleEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06026E84 RID: 159364 RVA: 0x003B5AAE File Offset: 0x003B3CAE
		public FSingleEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06026E85 RID: 159365 RVA: 0x003B5AB9 File Offset: 0x003B3CB9
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSingleEvent(Pointer, false, true);
		}

		// Token: 0x06026E86 RID: 159366 RVA: 0x003B5AC3 File Offset: 0x003B3CC3
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSingleEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040155C6 RID: 87494
		public const string __ObjectPath = "/Script/TASdkPlugin.SingleEvent";

		// Token: 0x040155C7 RID: 87495
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040155C8 RID: 87496
		internal static int __PropertyOffset_Utf8StringCode;

		// Token: 0x040155C9 RID: 87497
		[Nullable(2)]
		private TArray<byte> _Utf8StringCode;
	}
}
