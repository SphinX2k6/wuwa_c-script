using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001DE5 RID: 7653
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.KSC_EventResponder")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public abstract class UKSC_EventResponder : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601D3DE RID: 119774 RVA: 0x002B2EE5 File Offset: 0x002B10E5
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKSC_EventResponder._ClassPtr;
		}

		// Token: 0x17007610 RID: 30224
		// (get) Token: 0x0601D3DF RID: 119775 RVA: 0x002B2EF1 File Offset: 0x002B10F1
		// (set) Token: 0x0601D3E0 RID: 119776 RVA: 0x002B2F01 File Offset: 0x002B1101
		public unsafe int Priority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKSC_EventResponder.__PropertyOffset_Priority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKSC_EventResponder.__PropertyOffset_Priority) = value;
			}
		}

		// Token: 0x17007611 RID: 30225
		// (get) Token: 0x0601D3E1 RID: 119777 RVA: 0x002B2F14 File Offset: 0x002B1114
		// (set) Token: 0x0601D3E2 RID: 119778 RVA: 0x002B2F4D File Offset: 0x002B114D
		[Nullable(1)]
		public FKSC_TagFilter TargetTagFilter
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKSC_TagFilter result;
				if ((result = this._TargetTagFilter) == null)
				{
					result = (this._TargetTagFilter = new FKSC_TagFilter(base.NativePtr + (IntPtr)UKSC_EventResponder.__PropertyOffset_TargetTagFilter, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKSC_TagFilter.StaticStruct(), base.NativePtr + (IntPtr)UKSC_EventResponder.__PropertyOffset_TargetTagFilter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17007612 RID: 30226
		// (get) Token: 0x0601D3E3 RID: 119779 RVA: 0x002B2F6E File Offset: 0x002B116E
		// (set) Token: 0x0601D3E4 RID: 119780 RVA: 0x002B2F82 File Offset: 0x002B1182
		public unsafe UKSC_Buff_EventHandler Handler
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKSC_Buff_EventHandler>(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_EventResponder.__PropertyOffset_Handler);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKSC_EventResponder.__PropertyOffset_Handler, value);
			}
		}

		// Token: 0x0601D3E5 RID: 119781 RVA: 0x002B2F97 File Offset: 0x002B1197
		public virtual void Execute(in FKSC_EventContext Context)
		{
			UKSC_EventResponder.__Execute_Internal(base.NativePtr, (Context ?? new FKSC_EventContext()).NativePtr);
		}

		// Token: 0x0601D3E6 RID: 119782 RVA: 0x002B2FB4 File Offset: 0x002B11B4
		protected virtual void Execute_Implementation(in FKSC_EventContext Context)
		{
			UKSC_EventResponder.__Execute_Implementation_Internal(base.NativePtr, (Context ?? new FKSC_EventContext()).NativePtr);
		}

		// Token: 0x0601D3E7 RID: 119783 RVA: 0x002B2FD1 File Offset: 0x002B11D1
		public virtual bool CanExecute(in FKSC_EventContext Context)
		{
			return UKSC_EventResponder.__CanExecute_Internal(base.NativePtr, (Context ?? new FKSC_EventContext()).NativePtr);
		}

		// Token: 0x0601D3E8 RID: 119784 RVA: 0x002B2FEE File Offset: 0x002B11EE
		protected virtual bool CanExecute_Implementation(in FKSC_EventContext Context)
		{
			return UKSC_EventResponder.__CanExecute_Implementation_Internal(base.NativePtr, (Context ?? new FKSC_EventContext()).NativePtr);
		}

		// Token: 0x0601D3E9 RID: 119785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_Internal(IntPtr @this, IntPtr Context);

		// Token: 0x0601D3EA RID: 119786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Execute_Implementation_Internal(IntPtr @this, IntPtr Context);

		// Token: 0x0601D3EB RID: 119787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanExecute_Internal(IntPtr @this, IntPtr Context);

		// Token: 0x0601D3EC RID: 119788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanExecute_Implementation_Internal(IntPtr @this, IntPtr Context);

		// Token: 0x0601D3ED RID: 119789 RVA: 0x002B300B File Offset: 0x002B120B
		static UKSC_EventResponder()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroSimpleCombat.KSC_EventResponder");
		}

		// Token: 0x0601D3EE RID: 119790 RVA: 0x002B301C File Offset: 0x002B121C
		protected UKSC_EventResponder() : this(BuiltinUtils.AllocNativeUObject(UKSC_EventResponder.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601D3EF RID: 119791 RVA: 0x002B3044 File Offset: 0x002B1244
		protected UKSC_EventResponder(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400FDE2 RID: 64994
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroSimpleCombat.KSC_EventResponder";

		// Token: 0x0400FDE3 RID: 64995
		private static IntPtr _ClassPtr;

		// Token: 0x0400FDE4 RID: 64996
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400FDE5 RID: 64997
		internal static int __PropertyOffset_Priority;

		// Token: 0x0400FDE6 RID: 64998
		internal static int __PropertyOffset_TargetTagFilter;

		// Token: 0x0400FDE7 RID: 64999
		private FKSC_TagFilter _TargetTagFilter;

		// Token: 0x0400FDE8 RID: 65000
		internal static int __PropertyOffset_Handler;

		// Token: 0x02003299 RID: 12953
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 80)]
		protected ref struct __Execute_FunctionParams
		{
			// Token: 0x0401712B RID: 94507
			[FieldOffset(0)]
			public byte Context;
		}

		// Token: 0x0200329A RID: 12954
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 88)]
		protected ref struct __CanExecute_FunctionParams
		{
			// Token: 0x0401712C RID: 94508
			[FieldOffset(0)]
			public byte Context;

			// Token: 0x0401712D RID: 94509
			[FieldOffset(80)]
			public bool __Result;
		}
	}
}
