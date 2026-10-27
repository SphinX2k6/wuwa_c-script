using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B4 RID: 9652
	[UnrealObjectPath("/Script/Niagara.NiagaraInt32")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraInt32 : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023DAB RID: 146859 RVA: 0x00350427 File Offset: 0x0034E627
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraInt32._ScriptStructPtr != 0) ? FNiagaraInt32._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraInt32", ref FNiagaraInt32._ScriptStructPtr);
		}

		// Token: 0x170089C9 RID: 35273
		// (get) Token: 0x06023DAC RID: 146860 RVA: 0x0035044B File Offset: 0x0034E64B
		// (set) Token: 0x06023DAD RID: 146861 RVA: 0x0035045B File Offset: 0x0034E65B
		public unsafe int Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraInt32.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraInt32.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06023DAE RID: 146862 RVA: 0x0035046C File Offset: 0x0034E66C
		public FNiagaraInt32()
		{
		}

		// Token: 0x06023DAF RID: 146863 RVA: 0x00350474 File Offset: 0x0034E674
		public FNiagaraInt32(int Value)
		{
			this.Value = Value;
		}

		// Token: 0x06023DB0 RID: 146864 RVA: 0x00350483 File Offset: 0x0034E683
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraInt32.StaticStruct();
		}

		// Token: 0x06023DB1 RID: 146865 RVA: 0x0035048F File Offset: 0x0034E68F
		[NullableContext(2)]
		public FNiagaraInt32(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023DB2 RID: 146866 RVA: 0x00350499 File Offset: 0x0034E699
		public FNiagaraInt32(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023DB3 RID: 146867 RVA: 0x003504A4 File Offset: 0x0034E6A4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraInt32(Pointer, false, true);
		}

		// Token: 0x06023DB4 RID: 146868 RVA: 0x003504AE File Offset: 0x0034E6AE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraInt32(Pointer, MemoryOwner);
		}

		// Token: 0x0401338D RID: 78733
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraInt32";

		// Token: 0x0401338E RID: 78734
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0401338F RID: 78735
		internal static int __PropertyOffset_Value;
	}
}
