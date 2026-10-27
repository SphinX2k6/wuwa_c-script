using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025AF RID: 9647
	[UnrealObjectPath("/Script/Niagara.NiagaraHalfVector2")]
	[UnrealStructLayout(4, 2, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraHalfVector2 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D69 RID: 146793 RVA: 0x0034FFDC File Offset: 0x0034E1DC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraHalfVector2._ScriptStructPtr != 0) ? FNiagaraHalfVector2._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraHalfVector2", ref FNiagaraHalfVector2._ScriptStructPtr);
		}

		// Token: 0x170089BC RID: 35260
		// (get) Token: 0x06023D6A RID: 146794 RVA: 0x00350000 File Offset: 0x0034E200
		// (set) Token: 0x06023D6B RID: 146795 RVA: 0x00350010 File Offset: 0x0034E210
		public unsafe ushort x
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector2.__PropertyOffset_x);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector2.__PropertyOffset_x) = (short)value;
			}
		}

		// Token: 0x170089BD RID: 35261
		// (get) Token: 0x06023D6C RID: 146796 RVA: 0x00350021 File Offset: 0x0034E221
		// (set) Token: 0x06023D6D RID: 146797 RVA: 0x00350031 File Offset: 0x0034E231
		public unsafe ushort y
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraHalfVector2.__PropertyOffset_y);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraHalfVector2.__PropertyOffset_y) = (short)value;
			}
		}

		// Token: 0x06023D6E RID: 146798 RVA: 0x00350042 File Offset: 0x0034E242
		public FNiagaraHalfVector2()
		{
		}

		// Token: 0x06023D6F RID: 146799 RVA: 0x0035004A File Offset: 0x0034E24A
		public FNiagaraHalfVector2(ushort x, ushort y)
		{
			this.x = x;
			this.y = y;
		}

		// Token: 0x06023D70 RID: 146800 RVA: 0x00350060 File Offset: 0x0034E260
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraHalfVector2.StaticStruct();
		}

		// Token: 0x06023D71 RID: 146801 RVA: 0x0035006C File Offset: 0x0034E26C
		[NullableContext(2)]
		public FNiagaraHalfVector2(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D72 RID: 146802 RVA: 0x00350076 File Offset: 0x0034E276
		public FNiagaraHalfVector2(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D73 RID: 146803 RVA: 0x00350081 File Offset: 0x0034E281
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraHalfVector2(Pointer, false, true);
		}

		// Token: 0x06023D74 RID: 146804 RVA: 0x0035008B File Offset: 0x0034E28B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraHalfVector2(Pointer, MemoryOwner);
		}

		// Token: 0x04013375 RID: 78709
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraHalfVector2";

		// Token: 0x04013376 RID: 78710
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013377 RID: 78711
		internal static int __PropertyOffset_x;

		// Token: 0x04013378 RID: 78712
		internal static int __PropertyOffset_y;
	}
}
