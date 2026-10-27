using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200259C RID: 9628
	[UnrealObjectPath("/Script/Niagara.NiagaraEmitterHandle")]
	[UnrealStructLayout(88, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 88)]
	public class FNiagaraEmitterHandle : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06023C35 RID: 146485 RVA: 0x0034E44C File Offset: 0x0034C64C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNiagaraEmitterHandle._ScriptStructPtr != 0) ? FNiagaraEmitterHandle._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NiagaraEmitterHandle", ref FNiagaraEmitterHandle._ScriptStructPtr);
		}

		// Token: 0x17008977 RID: 35191
		// (get) Token: 0x06023C36 RID: 146486 RVA: 0x0034E470 File Offset: 0x0034C670
		// (set) Token: 0x06023C37 RID: 146487 RVA: 0x0034E484 File Offset: 0x0034C684
		public unsafe FGuid Id
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_Id);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_Id) = value;
			}
		}

		// Token: 0x17008978 RID: 35192
		// (get) Token: 0x06023C38 RID: 146488 RVA: 0x0034E499 File Offset: 0x0034C699
		// (set) Token: 0x06023C39 RID: 146489 RVA: 0x0034E4AD File Offset: 0x0034C6AD
		public unsafe FName IdName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_IdName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_IdName) = value;
			}
		}

		// Token: 0x17008979 RID: 35193
		// (get) Token: 0x06023C3A RID: 146490 RVA: 0x0034E4C2 File Offset: 0x0034C6C2
		// (set) Token: 0x06023C3B RID: 146491 RVA: 0x0034E4D2 File Offset: 0x0034C6D2
		public unsafe bool bIsEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_bIsEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_bIsEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700897A RID: 35194
		// (get) Token: 0x06023C3C RID: 146492 RVA: 0x0034E4E3 File Offset: 0x0034C6E3
		// (set) Token: 0x06023C3D RID: 146493 RVA: 0x0034E4F7 File Offset: 0x0034C6F7
		public unsafe FName Name
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_Name);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_Name) = value;
			}
		}

		// Token: 0x1700897B RID: 35195
		// (get) Token: 0x06023C3E RID: 146494 RVA: 0x0034E50C File Offset: 0x0034C70C
		// (set) Token: 0x06023C3F RID: 146495 RVA: 0x0034E520 File Offset: 0x0034C720
		[Nullable(2)]
		public unsafe UNiagaraEmitter Instance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEmitter>(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraEmitterHandle.__PropertyOffset_Instance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FNiagaraEmitterHandle.__PropertyOffset_Instance, value);
			}
		}

		// Token: 0x1700897C RID: 35196
		// (get) Token: 0x06023C40 RID: 146496 RVA: 0x0034E535 File Offset: 0x0034C735
		// (set) Token: 0x06023C41 RID: 146497 RVA: 0x0034E545 File Offset: 0x0034C745
		public unsafe int EmitterPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_EmitterPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FNiagaraEmitterHandle.__PropertyOffset_EmitterPriority) = value;
			}
		}

		// Token: 0x06023C42 RID: 146498 RVA: 0x0034E556 File Offset: 0x0034C756
		public FNiagaraEmitterHandle()
		{
		}

		// Token: 0x06023C43 RID: 146499 RVA: 0x0034E55E File Offset: 0x0034C75E
		[NullableContext(1)]
		public FNiagaraEmitterHandle(FGuid Id, FName IdName, bool bIsEnabled, FName Name, UNiagaraEmitter Source_DEPRECATED, UNiagaraEmitter LastMergedSource_DEPRECATED, UNiagaraEmitter Instance, int EmitterPriority)
		{
			this.Id = Id;
			this.IdName = IdName;
			this.bIsEnabled = bIsEnabled;
			this.Name = Name;
			this.Instance = Instance;
			this.EmitterPriority = EmitterPriority;
		}

		// Token: 0x06023C44 RID: 146500 RVA: 0x0034E593 File Offset: 0x0034C793
		protected override IntPtr GetUStructPtr()
		{
			return FNiagaraEmitterHandle.StaticStruct();
		}

		// Token: 0x06023C45 RID: 146501 RVA: 0x0034E59F File Offset: 0x0034C79F
		[NullableContext(2)]
		public FNiagaraEmitterHandle(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023C46 RID: 146502 RVA: 0x0034E5A9 File Offset: 0x0034C7A9
		public FNiagaraEmitterHandle(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023C47 RID: 146503 RVA: 0x0034E5B4 File Offset: 0x0034C7B4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNiagaraEmitterHandle(Pointer, false, true);
		}

		// Token: 0x06023C48 RID: 146504 RVA: 0x0034E5BE File Offset: 0x0034C7BE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNiagaraEmitterHandle(Pointer, MemoryOwner);
		}

		// Token: 0x040132EF RID: 78575
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Niagara.NiagaraEmitterHandle";

		// Token: 0x040132F0 RID: 78576
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040132F1 RID: 78577
		internal static int __PropertyOffset_Id;

		// Token: 0x040132F2 RID: 78578
		internal static int __PropertyOffset_IdName;

		// Token: 0x040132F3 RID: 78579
		internal static int __PropertyOffset_bIsEnabled;

		// Token: 0x040132F4 RID: 78580
		internal static int __PropertyOffset_Name;

		// Token: 0x040132F5 RID: 78581
		internal static int __PropertyOffset_Instance;

		// Token: 0x040132F6 RID: 78582
		internal static int __PropertyOffset_EmitterPriority;
	}
}
