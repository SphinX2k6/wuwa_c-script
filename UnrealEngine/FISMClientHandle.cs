using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CBE RID: 3262
	[UnrealObjectPath("/Script/Engine.ISMClientHandle")]
	[UnrealStructLayout(20, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 20)]
	public class FISMClientHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A4E9 RID: 42217 RVA: 0x000EAA24 File Offset: 0x000E8C24
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FISMClientHandle._ScriptStructPtr != 0) ? FISMClientHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ISMClientHandle", ref FISMClientHandle._ScriptStructPtr);
		}

		// Token: 0x1700273E RID: 10046
		// (get) Token: 0x0600A4EA RID: 42218 RVA: 0x000EAA48 File Offset: 0x000E8C48
		// (set) Token: 0x0600A4EB RID: 42219 RVA: 0x000EAA58 File Offset: 0x000E8C58
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMClientHandle.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMClientHandle.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x1700273F RID: 10047
		// (get) Token: 0x0600A4EC RID: 42220 RVA: 0x000EAA69 File Offset: 0x000E8C69
		// (set) Token: 0x0600A4ED RID: 42221 RVA: 0x000EAA7D File Offset: 0x000E8C7D
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FISMClientHandle.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FISMClientHandle.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x0600A4EE RID: 42222 RVA: 0x000EAA92 File Offset: 0x000E8C92
		public FISMClientHandle()
		{
		}

		// Token: 0x0600A4EF RID: 42223 RVA: 0x000EAA9A File Offset: 0x000E8C9A
		public FISMClientHandle(int Index, FGuid Guid)
		{
			this.Index = Index;
			this.Guid = Guid;
		}

		// Token: 0x0600A4F0 RID: 42224 RVA: 0x000EAAB0 File Offset: 0x000E8CB0
		protected override IntPtr GetUStructPtr()
		{
			return FISMClientHandle.StaticStruct();
		}

		// Token: 0x0600A4F1 RID: 42225 RVA: 0x000EAABC File Offset: 0x000E8CBC
		[NullableContext(2)]
		public FISMClientHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A4F2 RID: 42226 RVA: 0x000EAAC6 File Offset: 0x000E8CC6
		public FISMClientHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A4F3 RID: 42227 RVA: 0x000EAAD1 File Offset: 0x000E8CD1
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FISMClientHandle(Pointer, false, true);
		}

		// Token: 0x0600A4F4 RID: 42228 RVA: 0x000EAADB File Offset: 0x000E8CDB
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FISMClientHandle(Pointer, MemoryOwner);
		}

		// Token: 0x04005AC1 RID: 23233
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.ISMClientHandle";

		// Token: 0x04005AC2 RID: 23234
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005AC3 RID: 23235
		internal static int __PropertyOffset_Index;

		// Token: 0x04005AC4 RID: 23236
		internal static int __PropertyOffset_Guid;
	}
}
