using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200044E RID: 1102
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ChaosSolverEngine.ChaosHandlerSet")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FChaosHandlerSet : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003B6F RID: 15215 RVA: 0x000599CE File Offset: 0x00057BCE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FChaosHandlerSet._ScriptStructPtr != 0) ? FChaosHandlerSet._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ChaosSolverEngine.ChaosHandlerSet", ref FChaosHandlerSet._ScriptStructPtr);
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003B70 RID: 15216 RVA: 0x000599F4 File Offset: 0x00057BF4
		// (set) Token: 0x06003B71 RID: 15217 RVA: 0x00059A37 File Offset: 0x00057C37
		public TSet<UObject> ChaosHandlers
		{
			get
			{
				base.FastCheckIsValid();
				TSet<UObject> result;
				if ((result = this._ChaosHandlers) == null)
				{
					result = (this._ChaosHandlers = new TSet<UObject>(base.NativePtr + (IntPtr)FChaosHandlerSet.__PropertyOffset_ChaosHandlers, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ChaosHandlers.CopyAssign(value);
			}
		}

		// Token: 0x06003B72 RID: 15218 RVA: 0x00059A45 File Offset: 0x00057C45
		public FChaosHandlerSet()
		{
		}

		// Token: 0x06003B73 RID: 15219 RVA: 0x00059A4D File Offset: 0x00057C4D
		public FChaosHandlerSet(TSet<UObject> ChaosHandlers)
		{
			this.ChaosHandlers = ChaosHandlers;
		}

		// Token: 0x06003B74 RID: 15220 RVA: 0x00059A5C File Offset: 0x00057C5C
		protected override IntPtr GetUStructPtr()
		{
			return FChaosHandlerSet.StaticStruct();
		}

		// Token: 0x06003B75 RID: 15221 RVA: 0x00059A68 File Offset: 0x00057C68
		[NullableContext(2)]
		public FChaosHandlerSet(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003B76 RID: 15222 RVA: 0x00059A72 File Offset: 0x00057C72
		public FChaosHandlerSet(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003B77 RID: 15223 RVA: 0x00059A7D File Offset: 0x00057C7D
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FChaosHandlerSet(Pointer, false, true);
		}

		// Token: 0x06003B78 RID: 15224 RVA: 0x00059A87 File Offset: 0x00057C87
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FChaosHandlerSet(Pointer, MemoryOwner);
		}

		// Token: 0x04001B5C RID: 7004
		public const string __ObjectPath = "/Script/ChaosSolverEngine.ChaosHandlerSet";

		// Token: 0x04001B5D RID: 7005
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B5E RID: 7006
		internal static int __PropertyOffset_ChaosHandlers;

		// Token: 0x04001B5F RID: 7007
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TSet<UObject> _ChaosHandlers;
	}
}
