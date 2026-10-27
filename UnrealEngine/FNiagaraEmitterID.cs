using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200259D RID: 9629
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterID")]
	[UnrealStructLayout(4, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 4)]
	public class FNiagaraEmitterID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C49 RID: 146505 RVA: 0x0034E5C7 File Offset: 0x0034C7C7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterID._ScriptStructPtr != 0) ? FNiagaraEmitterID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterID", ref FNiagaraEmitterID._ScriptStructPtr);
		}

		// Token: 0x1700897D RID: 35197
		// (get) Token: 0x06023C4A RID: 146506 RVA: 0x0034E5EB File Offset: 0x0034C7EB
		// (set) Token: 0x06023C4B RID: 146507 RVA: 0x0034E5FB File Offset: 0x0034C7FB
		public unsafe int ID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterID.__PropertyOffset_ID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterID.__PropertyOffset_ID) = value;
			}
		}

		// Token: 0x06023C4C RID: 146508 RVA: 0x0034E60C File Offset: 0x0034C80C
		public FNiagaraEmitterID()
		{
		}

		// Token: 0x06023C4D RID: 146509 RVA: 0x0034E614 File Offset: 0x0034C814
		public FNiagaraEmitterID(int ID)
		{
			this.ID = ID;
		}

		// Token: 0x06023C4E RID: 146510 RVA: 0x0034E623 File Offset: 0x0034C823
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterID.StaticStruct();
		}

		// Token: 0x06023C4F RID: 146511 RVA: 0x0034E62F File Offset: 0x0034C82F
		[NullableContext(2)]
		public FNiagaraEmitterID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C50 RID: 146512 RVA: 0x0034E639 File Offset: 0x0034C839
		public FNiagaraEmitterID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C51 RID: 146513 RVA: 0x0034E644 File Offset: 0x0034C844
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterID(Pointer, false, true);
		}

		// Token: 0x06023C52 RID: 146514 RVA: 0x0034E64E File Offset: 0x0034C84E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterID(Pointer, MemoryOwner);
		}

		// Token: 0x040132F7 RID: 78583
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterID";

		// Token: 0x040132F8 RID: 78584
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040132F9 RID: 78585
		internal static int __PropertyOffset_ID;
	}
}
