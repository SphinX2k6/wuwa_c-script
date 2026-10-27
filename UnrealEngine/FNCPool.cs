using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002531 RID: 9521
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NCPool")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 56)]
	public class FNCPool : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0602358A RID: 144778 RVA: 0x003446D7 File Offset: 0x003428D7
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FNCPool._ScriptStructPtr != 0) ? FNCPool._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Niagara.NCPool", ref FNCPool._ScriptStructPtr);
		}

		// Token: 0x170087E3 RID: 34787
		// (get) Token: 0x0602358B RID: 144779 RVA: 0x003446FC File Offset: 0x003428FC
		// (set) Token: 0x0602358C RID: 144780 RVA: 0x0034473F File Offset: 0x0034293F
		public TArray<FNCPoolElement> FreeElements
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FNCPoolElement> result;
				if ((result = this._FreeElements) == null)
				{
					result = (this._FreeElements = new TArray<FNCPoolElement>(base.NativePtr + (IntPtr)FNCPool.__PropertyOffset_FreeElements, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FreeElements.CopyAssign(value);
			}
		}

		// Token: 0x170087E4 RID: 34788
		// (get) Token: 0x0602358D RID: 144781 RVA: 0x00344750 File Offset: 0x00342950
		// (set) Token: 0x0602358E RID: 144782 RVA: 0x00344793 File Offset: 0x00342993
		public TArray<UNiagaraComponent> InUseComponents_Auto
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._InUseComponents_Auto) == null)
				{
					result = (this._InUseComponents_Auto = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNCPool.__PropertyOffset_InUseComponents_Auto, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InUseComponents_Auto.CopyAssign(value);
			}
		}

		// Token: 0x170087E5 RID: 34789
		// (get) Token: 0x0602358F RID: 144783 RVA: 0x003447A4 File Offset: 0x003429A4
		// (set) Token: 0x06023590 RID: 144784 RVA: 0x003447E7 File Offset: 0x003429E7
		public TArray<UNiagaraComponent> InUseComponents_Manual
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UNiagaraComponent> result;
				if ((result = this._InUseComponents_Manual) == null)
				{
					result = (this._InUseComponents_Manual = new TArray<UNiagaraComponent>(base.NativePtr + (IntPtr)FNCPool.__PropertyOffset_InUseComponents_Manual, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.InUseComponents_Manual.CopyAssign(value);
			}
		}

		// Token: 0x06023591 RID: 144785 RVA: 0x003447F5 File Offset: 0x003429F5
		public FNCPool()
		{
		}

		// Token: 0x06023592 RID: 144786 RVA: 0x003447FD File Offset: 0x003429FD
		public FNCPool(TArray<FNCPoolElement> FreeElements, TArray<UNiagaraComponent> InUseComponents_Auto, TArray<UNiagaraComponent> InUseComponents_Manual)
		{
			this.FreeElements = FreeElements;
			this.InUseComponents_Auto = InUseComponents_Auto;
			this.InUseComponents_Manual = InUseComponents_Manual;
		}

		// Token: 0x06023593 RID: 144787 RVA: 0x0034481A File Offset: 0x00342A1A
		protected override IntPtr GetUStructPtr()
		{
			return FNCPool.StaticStruct();
		}

		// Token: 0x06023594 RID: 144788 RVA: 0x00344826 File Offset: 0x00342A26
		[NullableContext(2)]
		public FNCPool(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06023595 RID: 144789 RVA: 0x00344830 File Offset: 0x00342A30
		public FNCPool(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06023596 RID: 144790 RVA: 0x0034483B File Offset: 0x00342A3B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FNCPool(Pointer, false, true);
		}

		// Token: 0x06023597 RID: 144791 RVA: 0x00344845 File Offset: 0x00342A45
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FNCPool(Pointer, MemoryOwner);
		}

		// Token: 0x04012F96 RID: 77718
		public const string __ObjectPath = "/Script/Niagara.NCPool";

		// Token: 0x04012F97 RID: 77719
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04012F98 RID: 77720
		internal static int __PropertyOffset_FreeElements;

		// Token: 0x04012F99 RID: 77721
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FNCPoolElement> _FreeElements;

		// Token: 0x04012F9A RID: 77722
		internal static int __PropertyOffset_InUseComponents_Auto;

		// Token: 0x04012F9B RID: 77723
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _InUseComponents_Auto;

		// Token: 0x04012F9C RID: 77724
		internal static int __PropertyOffset_InUseComponents_Manual;

		// Token: 0x04012F9D RID: 77725
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UNiagaraComponent> _InUseComponents_Manual;
	}
}
