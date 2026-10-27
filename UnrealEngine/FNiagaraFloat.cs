using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025A9 RID: 9641
	[UnrealObjectPath("/Script/Niagara.NiagaraFloat")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023CE6 RID: 146662 RVA: 0x0034F340 File Offset: 0x0034D540
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraFloat._ScriptStructPtr != 0) ? FNiagaraFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraFloat", ref FNiagaraFloat._ScriptStructPtr);
		}

		// Token: 0x1700899F RID: 35231
		// (get) Token: 0x06023CE7 RID: 146663 RVA: 0x0034F364 File Offset: 0x0034D564
		// (set) Token: 0x06023CE8 RID: 146664 RVA: 0x0034F374 File Offset: 0x0034D574
		public unsafe float Value
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraFloat.__PropertyOffset_Value);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraFloat.__PropertyOffset_Value) = value;
			}
		}

		// Token: 0x06023CE9 RID: 146665 RVA: 0x0034F385 File Offset: 0x0034D585
		public FNiagaraFloat()
		{
		}

		// Token: 0x06023CEA RID: 146666 RVA: 0x0034F38D File Offset: 0x0034D58D
		public FNiagaraFloat(float Value)
		{
			this.Value = Value;
		}

		// Token: 0x06023CEB RID: 146667 RVA: 0x0034F39C File Offset: 0x0034D59C
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraFloat.StaticStruct();
		}

		// Token: 0x06023CEC RID: 146668 RVA: 0x0034F3A8 File Offset: 0x0034D5A8
		[NullableContext(2)]
		public FNiagaraFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023CED RID: 146669 RVA: 0x0034F3B2 File Offset: 0x0034D5B2
		public FNiagaraFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023CEE RID: 146670 RVA: 0x0034F3BD File Offset: 0x0034D5BD
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraFloat(Pointer, false, true);
		}

		// Token: 0x06023CEF RID: 146671 RVA: 0x0034F3C7 File Offset: 0x0034D5C7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraFloat(Pointer, MemoryOwner);
		}

		// Token: 0x04013340 RID: 78656
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraFloat";

		// Token: 0x04013341 RID: 78657
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013342 RID: 78658
		internal static int __PropertyOffset_Value;
	}
}
