using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020025B2 RID: 9650
	[HasGetTypeHash]
	[UnrealObjectPath("/Script/Niagara.NiagaraID")]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 8)]
	public class FNiagaraID : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023D93 RID: 146835 RVA: 0x0035027D File Offset: 0x0034E47D
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraID._ScriptStructPtr != 0) ? FNiagaraID._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraID", ref FNiagaraID._ScriptStructPtr);
		}

		// Token: 0x170089C5 RID: 35269
		// (get) Token: 0x06023D94 RID: 146836 RVA: 0x003502A1 File Offset: 0x0034E4A1
		// (set) Token: 0x06023D95 RID: 146837 RVA: 0x003502B1 File Offset: 0x0034E4B1
		public unsafe int Index
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraID.__PropertyOffset_Index);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraID.__PropertyOffset_Index) = value;
			}
		}

		// Token: 0x170089C6 RID: 35270
		// (get) Token: 0x06023D96 RID: 146838 RVA: 0x003502C2 File Offset: 0x0034E4C2
		// (set) Token: 0x06023D97 RID: 146839 RVA: 0x003502D2 File Offset: 0x0034E4D2
		public unsafe int AcquireTag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraID.__PropertyOffset_AcquireTag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraID.__PropertyOffset_AcquireTag) = value;
			}
		}

		// Token: 0x06023D98 RID: 146840 RVA: 0x003502E3 File Offset: 0x0034E4E3
		public FNiagaraID()
		{
		}

		// Token: 0x06023D99 RID: 146841 RVA: 0x003502EB File Offset: 0x0034E4EB
		public FNiagaraID(int Index, int AcquireTag)
		{
			this.Index = Index;
			this.AcquireTag = AcquireTag;
		}

		// Token: 0x06023D9A RID: 146842 RVA: 0x00350301 File Offset: 0x0034E501
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraID.StaticStruct();
		}

		// Token: 0x06023D9B RID: 146843 RVA: 0x0035030D File Offset: 0x0034E50D
		[NullableContext(2)]
		public FNiagaraID(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023D9C RID: 146844 RVA: 0x00350317 File Offset: 0x0034E517
		public FNiagaraID(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023D9D RID: 146845 RVA: 0x00350322 File Offset: 0x0034E522
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraID(Pointer, false, true);
		}

		// Token: 0x06023D9E RID: 146846 RVA: 0x0035032C File Offset: 0x0034E52C
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraID(Pointer, MemoryOwner);
		}

		// Token: 0x04013384 RID: 78724
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraID";

		// Token: 0x04013385 RID: 78725
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04013386 RID: 78726
		internal static int __PropertyOffset_Index;

		// Token: 0x04013387 RID: 78727
		internal static int __PropertyOffset_AcquireTag;
	}
}
