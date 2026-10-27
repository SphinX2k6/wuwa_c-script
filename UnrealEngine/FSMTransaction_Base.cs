using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200289C RID: 10396
	[UnrealObjectPath("/Script/SMSystem.SMTransaction_Base")]
	[UnrealStructLayout(3, 1, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 3)]
	public class FSMTransaction_Base : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060268CE RID: 157902 RVA: 0x003ACC30 File Offset: 0x003AAE30
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSMTransaction_Base._ScriptStructPtr != 0) ? FSMTransaction_Base._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/SMSystem.SMTransaction_Base", ref FSMTransaction_Base._ScriptStructPtr);
		}

		// Token: 0x170094A7 RID: 38055
		// (get) Token: 0x060268CF RID: 157903 RVA: 0x003ACC54 File Offset: 0x003AAE54
		// (set) Token: 0x060268D0 RID: 157904 RVA: 0x003ACC64 File Offset: 0x003AAE64
		public unsafe ESMTransactionType TransactionType
		{
			get
			{
				return (ESMTransactionType)(*(base.NativePtr + (IntPtr)FSMTransaction_Base.__PropertyOffset_TransactionType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSMTransaction_Base.__PropertyOffset_TransactionType) = (byte)value;
			}
		}

		// Token: 0x170094A8 RID: 38056
		// (get) Token: 0x060268D1 RID: 157905 RVA: 0x003ACC75 File Offset: 0x003AAE75
		// (set) Token: 0x060268D2 RID: 157906 RVA: 0x003ACC8E File Offset: 0x003AAE8E
		public unsafe bool bOriginatedFromServer
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSMTransaction_Base.__PropertyOffset_bOriginatedFromServer) & FSMTransaction_Base.__PropertyMask_bOriginatedFromServer) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSMTransaction_Base.__PropertyOffset_bOriginatedFromServer) = ((*(base.NativePtr + (IntPtr)FSMTransaction_Base.__PropertyOffset_bOriginatedFromServer) & ~FSMTransaction_Base.__PropertyMask_bOriginatedFromServer) | (value ? FSMTransaction_Base.__PropertyMask_bOriginatedFromServer : 0));
			}
		}

		// Token: 0x060268D3 RID: 157907 RVA: 0x003ACCBE File Offset: 0x003AAEBE
		public FSMTransaction_Base()
		{
		}

		// Token: 0x060268D4 RID: 157908 RVA: 0x003ACCC6 File Offset: 0x003AAEC6
		public FSMTransaction_Base(ESMTransactionType TransactionType, bool bOriginatedFromServer)
		{
			this.TransactionType = TransactionType;
			this.bOriginatedFromServer = bOriginatedFromServer;
		}

		// Token: 0x060268D5 RID: 157909 RVA: 0x003ACCDC File Offset: 0x003AAEDC
		protected override IntPtr GetUStructPtr()
		{
			return FSMTransaction_Base.StaticStruct();
		}

		// Token: 0x060268D6 RID: 157910 RVA: 0x003ACCE8 File Offset: 0x003AAEE8
		[NullableContext(2)]
		public FSMTransaction_Base(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060268D7 RID: 157911 RVA: 0x003ACCF2 File Offset: 0x003AAEF2
		public FSMTransaction_Base(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060268D8 RID: 157912 RVA: 0x003ACCFD File Offset: 0x003AAEFD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSMTransaction_Base(Pointer, false, true);
		}

		// Token: 0x060268D9 RID: 157913 RVA: 0x003ACD07 File Offset: 0x003AAF07
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSMTransaction_Base(Pointer, MemoryOwner);
		}

		// Token: 0x040152C4 RID: 86724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/SMSystem.SMTransaction_Base";

		// Token: 0x040152C5 RID: 86725
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040152C6 RID: 86726
		internal static int __PropertyOffset_TransactionType;

		// Token: 0x040152C7 RID: 86727
		internal static int __PropertyOffset_bOriginatedFromServer;

		// Token: 0x040152C8 RID: 86728
		internal static byte __PropertyMask_bOriginatedFromServer;
	}
}
