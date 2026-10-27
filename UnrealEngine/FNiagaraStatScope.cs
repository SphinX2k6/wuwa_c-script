using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025EE RID: 9710
	[UnrealObjectPath("/Script/Niagara.NiagaraStatScope")]
	[UnrealStructLayout(24, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FNiagaraStatScope : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060241A8 RID: 147880 RVA: 0x00356E62 File Offset: 0x00355062
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraStatScope._ScriptStructPtr != 0) ? FNiagaraStatScope._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraStatScope", ref FNiagaraStatScope._ScriptStructPtr);
		}

		// Token: 0x17008AFD RID: 35581
		// (get) Token: 0x060241A9 RID: 147881 RVA: 0x00356E86 File Offset: 0x00355086
		// (set) Token: 0x060241AA RID: 147882 RVA: 0x00356E9A File Offset: 0x0035509A
		public unsafe FName FullName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraStatScope.__PropertyOffset_FullName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraStatScope.__PropertyOffset_FullName) = value;
			}
		}

		// Token: 0x17008AFE RID: 35582
		// (get) Token: 0x060241AB RID: 147883 RVA: 0x00356EAF File Offset: 0x003550AF
		// (set) Token: 0x060241AC RID: 147884 RVA: 0x00356EC3 File Offset: 0x003550C3
		public unsafe FName FriendlyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraStatScope.__PropertyOffset_FriendlyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraStatScope.__PropertyOffset_FriendlyName) = value;
			}
		}

		// Token: 0x060241AD RID: 147885 RVA: 0x00356ED8 File Offset: 0x003550D8
		public FNiagaraStatScope()
		{
		}

		// Token: 0x060241AE RID: 147886 RVA: 0x00356EE0 File Offset: 0x003550E0
		public FNiagaraStatScope(FName FullName, FName FriendlyName)
		{
			this.FullName = FullName;
			this.FriendlyName = FriendlyName;
		}

		// Token: 0x060241AF RID: 147887 RVA: 0x00356EF6 File Offset: 0x003550F6
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraStatScope.StaticStruct();
		}

		// Token: 0x060241B0 RID: 147888 RVA: 0x00356F02 File Offset: 0x00355102
		[NullableContext(2)]
		public FNiagaraStatScope(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060241B1 RID: 147889 RVA: 0x00356F0C File Offset: 0x0035510C
		public FNiagaraStatScope(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060241B2 RID: 147890 RVA: 0x00356F17 File Offset: 0x00355117
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraStatScope(Pointer, false, true);
		}

		// Token: 0x060241B3 RID: 147891 RVA: 0x00356F21 File Offset: 0x00355121
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraStatScope(Pointer, MemoryOwner);
		}

		// Token: 0x040135E9 RID: 79337
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraStatScope";

		// Token: 0x040135EA RID: 79338
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040135EB RID: 79339
		internal static int __PropertyOffset_FullName;

		// Token: 0x040135EC RID: 79340
		internal static int __PropertyOffset_FriendlyName;
	}
}
