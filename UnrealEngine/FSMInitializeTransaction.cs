using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002887 RID: 10375
	[UnrealObjectPath("/Script/SMSystem.SMInitializeTransaction")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FSMInitializeTransaction : FSMTransaction_Base, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06026663 RID: 157283 RVA: 0x003A5C0B File Offset: 0x003A3E0B
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMInitializeTransaction._ScriptStructPtr != 0) ? FSMInitializeTransaction._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMInitializeTransaction", ref FSMInitializeTransaction._ScriptStructPtr);
		}

		// Token: 0x17009415 RID: 37909
		// (get) Token: 0x06026664 RID: 157284 RVA: 0x003A5C2F File Offset: 0x003A3E2F
		// (set) Token: 0x06026665 RID: 157285 RVA: 0x003A5C43 File Offset: 0x003A3E43
		[Nullable(2)]
		public unsafe UObject Context
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + FSMInitializeTransaction.__PropertyOffset_Context);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSMInitializeTransaction.__PropertyOffset_Context, value);
			}
		}

		// Token: 0x06026666 RID: 157286 RVA: 0x003A5C58 File Offset: 0x003A3E58
		public FSMInitializeTransaction()
		{
		}

		// Token: 0x06026667 RID: 157287 RVA: 0x003A5C60 File Offset: 0x003A3E60
		[NullableContext(1)]
		public FSMInitializeTransaction(UObject Context, ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.Context = Context;
			base.TransactionType = TransactionType;
			base.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x06026668 RID: 157288 RVA: 0x003A5C7D File Offset: 0x003A3E7D
		protected override IntPtr GetUStructPtr()
		{
			return FSMInitializeTransaction.StaticStruct();
		}

		// Token: 0x06026669 RID: 157289 RVA: 0x003A5C89 File Offset: 0x003A3E89
		[NullableContext(2)]
		public FSMInitializeTransaction(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0602666A RID: 157290 RVA: 0x003A5C93 File Offset: 0x003A3E93
		public FSMInitializeTransaction(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0602666B RID: 157291 RVA: 0x003A5C9E File Offset: 0x003A3E9E
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMInitializeTransaction(Pointer, false, true);
		}

		// Token: 0x0602666C RID: 157292 RVA: 0x003A5CA8 File Offset: 0x003A3EA8
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMInitializeTransaction(Pointer, MemoryOwner);
		}

		// Token: 0x040150EF RID: 86255
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/SMSystem.SMInitializeTransaction";

		// Token: 0x040150F0 RID: 86256
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040150F1 RID: 86257
		internal static int __PropertyOffset_Context;
	}
}
